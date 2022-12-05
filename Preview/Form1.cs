using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teigha.DatabaseServices;

namespace Preview
{
    public partial class Form1 : Form
    {
        int WidthOrg;
        int HeightOrg;
        double RatioPanelWAndH;
        double Zoom = 1;
        string PathDwg;

        private DwgPreview DwgPreview = new DwgPreview();
        public Form1()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            WidthOrg = pictureBox_preview.Width;
            HeightOrg = pictureBox_preview.Height;
            RatioPanelWAndH = (double)WidthOrg / (double)HeightOrg;
            selectPath();
            base.OnLoad(e);
        }

        protected override void OnFormClosing(FormClosingEventArgs args)
        {
            DwgPreview.CleanUp();
            base.OnFormClosing(args);
        }

        void MakeDwgPreview()
        {
            pictureBox_preview.Image = DwgPreview.MakeImage(PathDwg,
                pictureBox_preview.Width, pictureBox_preview.Height);
        }

        private void button_path_Click(object sender, EventArgs e)
        {
            selectPath();
        }

        void selectPath()
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "dwg files (*.dwg)|*.dwg|All files (*.*)|*.*";
                dlg.RestoreDirectory = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    PathDwg = dlg.FileName;
                    MakeDwgPreview();
                }
            }
        }

        private void button_zoomIn_Click(object sender, EventArgs e)
        {
            Zoom += 0.1;
            panel1.AutoScroll = Zoom > 1;
            UpdatePreview();
        }


        private void button_zoomOut_Click(object sender, EventArgs e)
        {
            Zoom -= 0.1;
            panel1.AutoScroll = Zoom > 1;
            UpdatePreview();
        }

        private void button_zoonOld_Click(object sender, EventArgs e)
        {
            Zoom = 1;
            panel1.AutoScroll = false;
            UpdatePreview();
        }

        Size GetSizeAdjsted()
        {
            var w = WidthOrg * Zoom;
            var h = HeightOrg * Zoom;
            //画面サイズを変更したときは、縦横比は変わらない目的
            if (RatioPanelWAndH > (w / h)) {
                h = w / RatioPanelWAndH;
            }
            else {
                w = h * RatioPanelWAndH;
            }
            return new Size((int)w, (int)h);
        }

        void UpdatePreview()
        {
            pictureBox_preview.Size = GetSizeAdjsted();
            MakeDwgPreview();
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            WidthOrg = panel1.Width;
            HeightOrg = panel1.Height;
            UpdatePreview();
        }

        bool StartMovePic = false;
        int PosOrgX,PosOrgY;

        private void picktureBox_preview_MouseDown(object sender, MouseEventArgs e)
        {
            if (Zoom <= 1) {
                return;
            }
            StartMovePic = true;
            PosOrgX = e.X;
            PosOrgY = e.Y;
        }

        private void pickturBox_preview_MouseMove(object sender, MouseEventArgs e)
        {
            if (StartMovePic)
            {
                var hor = panel1.HorizontalScroll;
                var ver = panel1.VerticalScroll;
                var desX = hor.Value - (e.X - PosOrgX);
                if (e.X - PosOrgX != 0)
                {
                    desX = Math.Min(desX, hor.Maximum);
                    desX = Math.Max(desX, hor.Minimum);
                    panel1.HorizontalScroll.Value = desX;
                    panel1.ScrollControlIntoView(panel1);
                    PosOrgX = e.X;
                }
                if (e.Y - PosOrgY != 0)
                {
                    var desY = ver.Value - (e.Y - PosOrgY);
                    desY = Math.Min(desY, ver.Maximum);
                    desY = Math.Max(desY, ver.Minimum);
                    panel1.VerticalScroll.Value = desY;
                    panel1.ScrollControlIntoView(panel1);
                    PosOrgY = e.Y;
                }
                pictureBox_preview.Refresh();
            }
        }

        private void picktureBox_preview_MouseUp(object sender, MouseEventArgs e)
        {
            StartMovePic = false;
        }
    }
}
