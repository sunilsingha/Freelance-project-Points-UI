using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using WebEye.Controls.WinForms.WebCameraControl;

namespace PointsUI.Forms
{
    public partial class FrmWebCam : MetroFramework.Forms.MetroForm
    {
        public FrmWebCam()
        {
            InitializeComponent();
        }

        private void BtnCapture_Click(object sender, EventArgs e)
        {
            string contractorImage = System.IO.Path.Combine( Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "contractor.bmp");
           
            webCameraControl1.GetCurrentImage().Save(contractorImage);
            DialogResult = DialogResult.OK;
        }

        private void FrmWebCam_Load(object sender, EventArgs e)
        {
            foreach (WebCameraId camera in webCameraControl1.GetVideoCaptureDevices())
            {
                CmbCameras.Items.Add(new ComboBoxItem(camera));
            }

            if (CmbCameras.Items.Count > 0)
            {
                CmbCameras.SelectedItem = CmbCameras.Items[0];
            }
        }

        private class ComboBoxItem
        {
            public ComboBoxItem(WebCameraId id)
            {
                _id = id;
            }

            private readonly WebCameraId _id;

            public WebCameraId ID
            {
                get { return _id; }
            }

            public override string ToString()
            {
                return _id.Name;
            }
        }

        private void CmbCameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartCamera();
        }

        void StartCamera()
        {
            ComboBoxItem i = (ComboBoxItem)CmbCameras.SelectedItem;
            try
            {
                webCameraControl1.StartCapture(i.ID);
            }
            finally
            {
                UpdateButtons();
            }
        }

        private void UpdateButtons()
        {
            BtnCapture.Enabled = true;
        }

        private void FrmWebCam_FormClosed(object sender, FormClosedEventArgs e)
        {
            webCameraControl1.StopCapture();
        }
    }
}
