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
        double Zoom = 1;
        string PathDwg;

        private DwgPreview DwgPreview = new DwgPreview();
        public Form1()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            WidthOrg = panel1.Width;
            HeightOrg = panel1.Height;
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
            UpdatePreview();
        }


        private void button_zoomOut_Click(object sender, EventArgs e)
        {
            Zoom -= 0.1;
            UpdatePreview();
        }

        private void button_zoonOld_Click(object sender, EventArgs e)
        {
            Zoom = 1;
            UpdatePreview();
        }

        void UpdatePreview()
        {
            pictureBox_preview.Width = (int)(WidthOrg * Zoom);
            pictureBox_preview.Height = (int)(HeightOrg * Zoom);
            MakeDwgPreview();
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            WidthOrg = panel1.Width;
            HeightOrg = panel1.Height;
            UpdatePreview();
        }
    }
}
