using PointsUI.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PointsUI.DBOperations;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing;

namespace PointsUI
{
    public partial class FrmContractor : MetroFramework.Forms.MetroForm
    {      

        List<Supervisor> supervisors;

        /// <summary>
        /// if contractorId !=0 then Update else Add.
        /// </summary>

        private Contractor _contractor { get; set; }
        private int _contractorId { get; set; }

        public FrmContractor(int contractorId)
        {
            this._contractorId = contractorId;
            InitializeComponent();

            supervisors = DBSupervisor.getSupervisors();
            supervisors.Insert(0, new Supervisor()
            {
                Id = -1,
                Name = "-Select-"
            });

            CmbBxSupervisor.DataSource = supervisors;
            CmbBxSupervisor.DisplayMember = "Name";
            CmbBxSupervisor.ValueMember = "Id";
            CmbBxSupervisor.SelectedValue = -1;
        }

        private void LinkIdProof_Click(object sender, EventArgs e)
        {
            if (OpnPictureDialog.ShowDialog() == DialogResult.OK)
            {
                PictureID.ImageLocation = OpnPictureDialog.FileName;
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (TxtBxName.Text == string.Empty)
            {
                ShowWarningMessage("Contractor Name is empty!");
                TxtBxName.Focus();
                return;
            }

            if (!Helper.IsPhoneNumber(TxtBxPhoneNo.Text))
            {
                ShowWarningMessage("Please check phone number!");
                TxtBxPhoneNo.Focus();
                return;
            }

            if (CmbBxSupervisor.SelectedIndex == 0)
            {
                ShowWarningMessage("Please select Supervisor from the list!");
                CmbBxSupervisor.Focus();
                return;
            }

            if (CmbBxIDproof.Text == string.Empty)
            {
                ShowWarningMessage("Please select ID proof from the list!");
                CmbBxIDproof.Focus();
                return;
            }

            Contractor contractor = new Contractor();
            contractor.Name = TxtBxName.Text.Trim();
            contractor.MobileNumber = TxtBxPhoneNo.Text.Trim();
            contractor.Address = TxtBxAddress.Text.Trim();
            contractor.IdType = CmbBxIDproof.Text;
            contractor.IdProof = PictureID.Image;
            contractor.SupervisorId = int.Parse(CmbBxSupervisor.SelectedValue.ToString());

            MemoryStream ms;

            if (PictureID.Image != null)
            {
                //using MemoryStream:
                 ms = new MemoryStream();
                PictureID.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                //contractor.ImageFileDataInBytes = photo_aray;

                contractor.ImageBase64 = Convert.ToBase64String(photo_aray);               

            }


            try
            {
                //if contractorId !=0 then Update else Add.
                if (_contractorId == -1)
                {
                    DBContractor.AddContractor(contractor, UserLoggedIn.Instance().UserId);
                    MessageBox.Show("Contractor Added", "Contractor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtBxAddress.Clear();
                    TxtBxName.Clear();
                    TxtBxPhoneNo.Clear();
                    CmbBxSupervisor.SelectedValue = -1;
                    PictureID.Image = null;
                }
                else
                {
                    contractor.ID = _contractorId;
                    DBContractor.UpdateContractor(contractor, UserLoggedIn.Instance().UserId);
                    MessageBox.Show("Contractor Updated", "Contractor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "Error Validating Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void FrmContractor_Load(object sender, EventArgs e)
        {
            _contractor = DBContractor.getContractorbyId(_contractorId);
            this.Text = "Add New Contractor";

            if (_contractor != null)
                loadContractor();
        }

        private void loadContractor()
        {
            this.Text = "Contractor No - " + _contractor.ContractorNo;
            TxtBxName.Text = _contractor.Name;
            TxtBxAddress.Text = _contractor.Address;
            TxtBxPhoneNo.Text = _contractor.MobileNumber;
            CmbBxIDproof.Text = _contractor.IdType;
            CmbBxSupervisor.SelectedValue = _contractor.SupervisorId;
            if (_contractor.ImageBase64 != string.Empty)
            {
                byte[] bytes = Convert.FromBase64String(_contractor.ImageBase64);
                string contractorImage = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "contractor.bmp");
                
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    PictureID.Image = Image.FromStream(ms);
                    PictureID.Image.Save(contractorImage);
                    PictureID.Image = Image.FromFile(contractorImage);
                }
            }
                 
         
        }

 

        private void BtnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCamera_Click(object sender, EventArgs e)
        {
            PictureID.Image = null;
            string contractorImage = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "contractor.bmp");          
            PointsUI.Forms.FrmWebCam frmWebCam = new Forms.FrmWebCam();
            if (frmWebCam.ShowDialog() == DialogResult.OK)
            {

                Image img;
                using (var bmpTemp = new Bitmap(contractorImage))
                {

                    img = new Bitmap(bmpTemp);
                }
                PictureID.Image = img;
            }


        }
    }

}








