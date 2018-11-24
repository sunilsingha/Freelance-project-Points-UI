namespace PointsUI.Forms
{
    partial class FrmWebCam
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
            this.webCameraControl1 = new WebEye.Controls.WinForms.WebCameraControl.WebCameraControl();
            this.CmbCameras = new MetroFramework.Controls.MetroComboBox();
            this.BtnCapture = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // webCameraControl1
            // 
            this.webCameraControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.webCameraControl1.BackColor = System.Drawing.Color.Black;
            this.webCameraControl1.Location = new System.Drawing.Point(23, 64);
            this.webCameraControl1.Margin = new System.Windows.Forms.Padding(2);
            this.webCameraControl1.Name = "webCameraControl1";
            this.webCameraControl1.Size = new System.Drawing.Size(372, 262);
            this.webCameraControl1.TabIndex = 5;
            // 
            // CmbCameras
            // 
            this.CmbCameras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmbCameras.FormattingEnabled = true;
            this.CmbCameras.ItemHeight = 23;
            this.CmbCameras.Location = new System.Drawing.Point(23, 331);
            this.CmbCameras.Name = "CmbCameras";
            this.CmbCameras.Size = new System.Drawing.Size(154, 29);
            this.CmbCameras.TabIndex = 6;
            this.CmbCameras.UseSelectable = true;
            this.CmbCameras.SelectedIndexChanged += new System.EventHandler(this.CmbCameras_SelectedIndexChanged);
            // 
            // BtnCapture
            // 
            this.BtnCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCapture.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnCapture.Location = new System.Drawing.Point(266, 332);
            this.BtnCapture.Name = "BtnCapture";
            this.BtnCapture.Size = new System.Drawing.Size(129, 28);
            this.BtnCapture.TabIndex = 7;
            this.BtnCapture.Text = "Capture";
            this.BtnCapture.UseSelectable = true;
            this.BtnCapture.Click += new System.EventHandler(this.BtnCapture_Click);
            // 
            // FrmWebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 365);
            this.Controls.Add(this.BtnCapture);
            this.Controls.Add(this.CmbCameras);
            this.Controls.Add(this.webCameraControl1);
            this.MaximizeBox = false;
            this.Name = "FrmWebCam";
            this.Text = "Capture Image";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmWebCam_FormClosed);
            this.Load += new System.EventHandler(this.FrmWebCam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private WebEye.Controls.WinForms.WebCameraControl.WebCameraControl webCameraControl1;
        private MetroFramework.Controls.MetroComboBox CmbCameras;
        private MetroFramework.Controls.MetroButton BtnCapture;
    }
}