using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teigha.Runtime;

namespace Preview
{
    public class Class1
    {
        [CommandMethod("Preview", "PreviewDwg", CommandFlags.Modal)]
        public void preview()
        {
            using(var dlg = new Form1())
            {
                dlg.ShowDialog();
            }
        }
    }
}
