using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teigha.DatabaseServices;

namespace Preview
{
    public class DwgPreview
    {
        Dictionary<string, System.Drawing.Bitmap> path_cache = new Dictionary<string, System.Drawing.Bitmap>();
        internal bool ThumbnailCallback()
        {
            return false;
        }

        internal System.Drawing.Image MakeImage(string path, int width, int height)
        {
            System.Drawing.Bitmap bm;
            if (path_cache.ContainsKey(path))
            {
                bm = path_cache[path];
            }
            else
            {
                using (var db = new Database(false, true))
                {
                    try
                    {
                        db.ReadDwgFile(path, FileOpenMode.OpenForReadAndWriteNoShare, true, "", true);
                    }
                    catch (System.Exception)
                    {
                        return null;
                    }
                    bm = db.ThumbnailBitmap;
                    path_cache[path] = bm;
                }
            }
            return bm.GetThumbnailImage(width, height, new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero);
        }

        internal void CleanUp()
        {
            foreach(var pair in path_cache)
            {
                pair.Value.Dispose();
            }
            path_cache.Clear();
        }
    }
}
