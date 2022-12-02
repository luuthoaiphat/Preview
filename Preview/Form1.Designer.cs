
namespace Preview
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_preview = new System.Windows.Forms.PictureBox();
            this.button_zoonOld = new System.Windows.Forms.Button();
            this.button_zoomOut = new System.Windows.Forms.Button();
            this.button_zoomIn = new System.Windows.Forms.Button();
            this.button_path = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox_preview);
            this.panel1.Location = new System.Drawing.Point(22, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 367);
            this.panel1.TabIndex = 4;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            // 
            // pictureBox_preview
            // 
            this.pictureBox_preview.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_preview.Name = "pictureBox_preview";
            this.pictureBox_preview.Size = new System.Drawing.Size(585, 367);
            this.pictureBox_preview.TabIndex = 0;
            this.pictureBox_preview.TabStop = false;
            this.pictureBox_preview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picktureBox_preview_MouseDown);
            this.pictureBox_preview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pickturBox_preview_MouseMove);
            this.pictureBox_preview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picktureBox_preview_MouseUp);
            // 
            // button_zoonOld
            // 
            this.button_zoonOld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_zoonOld.Location = new System.Drawing.Point(568, 3);
            this.button_zoonOld.Name = "button_zoonOld";
            this.button_zoonOld.Size = new System.Drawing.Size(39, 32);
            this.button_zoonOld.TabIndex = 3;
            this.button_zoonOld.Text = "=";
            this.button_zoonOld.UseVisualStyleBackColor = true;
            this.button_zoonOld.Click += new System.EventHandler(this.button_zoonOld_Click);
            // 
            // button_zoomOut
            // 
            this.button_zoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_zoomOut.Location = new System.Drawing.Point(523, 3);
            this.button_zoomOut.Name = "button_zoomOut";
            this.button_zoomOut.Size = new System.Drawing.Size(39, 32);
            this.button_zoomOut.TabIndex = 2;
            this.button_zoomOut.Text = "-";
            this.button_zoomOut.UseVisualStyleBackColor = true;
            this.button_zoomOut.Click += new System.EventHandler(this.button_zoomOut_Click);
            // 
            // button_zoomIn
            // 
            this.button_zoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_zoomIn.Location = new System.Drawing.Point(478, 3);
            this.button_zoomIn.Name = "button_zoomIn";
            this.button_zoomIn.Size = new System.Drawing.Size(39, 32);
            this.button_zoomIn.TabIndex = 1;
            this.button_zoomIn.Text = "+";
            this.button_zoomIn.UseVisualStyleBackColor = true;
            this.button_zoomIn.Click += new System.EventHandler(this.button_zoomIn_Click);
            // 
            // button_path
            // 
            this.button_path.Location = new System.Drawing.Point(22, 8);
            this.button_path.Name = "button_path";
            this.button_path.Size = new System.Drawing.Size(145, 23);
            this.button_path.TabIndex = 0;
            this.button_path.Text = "DWGパス選択";
            this.button_path.UseVisualStyleBackColor = true;
            this.button_path.Click += new System.EventHandler(this.button_path_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 429);
            this.Controls.Add(this.button_zoonOld);
            this.Controls.Add(this.button_path);
            this.Controls.Add(this.button_zoomOut);
            this.Controls.Add(this.button_zoomIn);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(652, 468);
            this.Name = "Form1";
            this.Text = "Form_Preview";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_zoomOut;
        private System.Windows.Forms.Button button_zoomIn;
        private System.Windows.Forms.PictureBox pictureBox_preview;
        private System.Windows.Forms.Button button_path;
        private System.Windows.Forms.Button button_zoonOld;
    }
}