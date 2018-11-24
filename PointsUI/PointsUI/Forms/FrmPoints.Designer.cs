namespace PointsUI
{
    partial class FrmPoints
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtBxUniqueId = new MetroFramework.Controls.MetroTextBox();
            this.LinkUniqueId = new MetroFramework.Controls.MetroLink();
            this.LinkPhone = new MetroFramework.Controls.MetroLink();
            this.LinkContractor = new MetroFramework.Controls.MetroLink();
            this.CmbBxSupervisor = new MetroFramework.Controls.MetroComboBox();
            this.TxtBxKgs = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TxtBxLiters = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TxtBxPhoneNo = new MetroFramework.Controls.MetroTextBox();
            this.TxtBxContracotrName = new MetroFramework.Controls.MetroTextBox();
            this.BtnUpdate = new MetroFramework.Controls.MetroButton();
            this.BtnCancel = new MetroFramework.Controls.MetroButton();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtBxUniqueId);
            this.groupBox2.Controls.Add(this.LinkUniqueId);
            this.groupBox2.Controls.Add(this.LinkPhone);
            this.groupBox2.Controls.Add(this.LinkContractor);
            this.groupBox2.Controls.Add(this.CmbBxSupervisor);
            this.groupBox2.Controls.Add(this.TxtBxKgs);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.TxtBxLiters);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.TxtBxPhoneNo);
            this.groupBox2.Controls.Add(this.TxtBxContracotrName);
            this.groupBox2.Location = new System.Drawing.Point(47, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(785, 303);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Points Detail";
            // 
            // TxtBxUniqueId
            // 
            // 
            // 
            // 
            this.TxtBxUniqueId.CustomButton.Image = null;
            this.TxtBxUniqueId.CustomButton.Location = new System.Drawing.Point(487, 1);
            this.TxtBxUniqueId.CustomButton.Name = "";
            this.TxtBxUniqueId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBxUniqueId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBxUniqueId.CustomButton.TabIndex = 1;
            this.TxtBxUniqueId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBxUniqueId.CustomButton.UseSelectable = true;
            this.TxtBxUniqueId.CustomButton.Visible = false;
            this.TxtBxUniqueId.Enabled = false;
            this.TxtBxUniqueId.Lines = new string[0];
            this.TxtBxUniqueId.Location = new System.Drawing.Point(215, 156);
            this.TxtBxUniqueId.MaxLength = 32767;
            this.TxtBxUniqueId.Name = "TxtBxUniqueId";
            this.TxtBxUniqueId.PasswordChar = '\0';
            this.TxtBxUniqueId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBxUniqueId.SelectedText = "";
            this.TxtBxUniqueId.SelectionLength = 0;
            this.TxtBxUniqueId.SelectionStart = 0;
            this.TxtBxUniqueId.ShortcutsEnabled = true;
            this.TxtBxUniqueId.Size = new System.Drawing.Size(509, 23);
            this.TxtBxUniqueId.TabIndex = 12;
            this.TxtBxUniqueId.UseSelectable = true;
            this.TxtBxUniqueId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBxUniqueId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LinkUniqueId
            // 
            this.LinkUniqueId.Location = new System.Drawing.Point(35, 156);
            this.LinkUniqueId.Name = "LinkUniqueId";
            this.LinkUniqueId.Size = new System.Drawing.Size(109, 23);
            this.LinkUniqueId.TabIndex = 11;
            this.LinkUniqueId.Text = "Unique Id";
            this.LinkUniqueId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LinkUniqueId.UseSelectable = true;
            this.LinkUniqueId.Click += new System.EventHandler(this.LinkUniqueId_Click);
            // 
            // LinkPhone
            // 
            this.LinkPhone.Location = new System.Drawing.Point(35, 104);
            this.LinkPhone.Name = "LinkPhone";
            this.LinkPhone.Size = new System.Drawing.Size(109, 23);
            this.LinkPhone.TabIndex = 10;
            this.LinkPhone.Text = "Phone Number";
            this.LinkPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LinkPhone.UseSelectable = true;
            this.LinkPhone.Click += new System.EventHandler(this.LinkPhone_Click);
            // 
            // LinkContractor
            // 
            this.LinkContractor.Location = new System.Drawing.Point(35, 52);
            this.LinkContractor.Name = "LinkContractor";
            this.LinkContractor.Size = new System.Drawing.Size(109, 23);
            this.LinkContractor.TabIndex = 9;
            this.LinkContractor.Text = "Contractor Name";
            this.LinkContractor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LinkContractor.UseSelectable = true;
            this.LinkContractor.Click += new System.EventHandler(this.LinkContractor_Click);
            // 
            // CmbBxSupervisor
            // 
            this.CmbBxSupervisor.Enabled = false;
            this.CmbBxSupervisor.FormattingEnabled = true;
            this.CmbBxSupervisor.ItemHeight = 23;
            this.CmbBxSupervisor.Location = new System.Drawing.Point(215, 203);
            this.CmbBxSupervisor.Name = "CmbBxSupervisor";
            this.CmbBxSupervisor.Size = new System.Drawing.Size(509, 29);
            this.CmbBxSupervisor.TabIndex = 8;
            this.CmbBxSupervisor.UseSelectable = true;
            // 
            // TxtBxKgs
            // 
            // 
            // 
            // 
            this.TxtBxKgs.CustomButton.Image = null;
            this.TxtBxKgs.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.TxtBxKgs.CustomButton.Name = "";
            this.TxtBxKgs.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBxKgs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBxKgs.CustomButton.TabIndex = 1;
            this.TxtBxKgs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBxKgs.CustomButton.UseSelectable = true;
            this.TxtBxKgs.CustomButton.Visible = false;
            this.TxtBxKgs.Lines = new string[] {
        "Kgs"};
            this.TxtBxKgs.Location = new System.Drawing.Point(482, 254);
            this.TxtBxKgs.MaxLength = 32767;
            this.TxtBxKgs.Name = "TxtBxKgs";
            this.TxtBxKgs.PasswordChar = '\0';
            this.TxtBxKgs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBxKgs.SelectedText = "";
            this.TxtBxKgs.SelectionLength = 0;
            this.TxtBxKgs.SelectionStart = 0;
            this.TxtBxKgs.ShortcutsEnabled = true;
            this.TxtBxKgs.Size = new System.Drawing.Size(242, 23);
            this.TxtBxKgs.TabIndex = 7;
            this.TxtBxKgs.Text = "Kgs";
            this.TxtBxKgs.UseSelectable = true;
            this.TxtBxKgs.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBxKgs.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(101, 256);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Points";
            // 
            // TxtBxLiters
            // 
            // 
            // 
            // 
            this.TxtBxLiters.CustomButton.Image = null;
            this.TxtBxLiters.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.TxtBxLiters.CustomButton.Name = "";
            this.TxtBxLiters.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBxLiters.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBxLiters.CustomButton.TabIndex = 1;
            this.TxtBxLiters.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBxLiters.CustomButton.UseSelectable = true;
            this.TxtBxLiters.CustomButton.Visible = false;
            this.TxtBxLiters.Lines = new string[] {
        "liters"};
            this.TxtBxLiters.Location = new System.Drawing.Point(215, 254);
            this.TxtBxLiters.MaxLength = 32767;
            this.TxtBxLiters.Name = "TxtBxLiters";
            this.TxtBxLiters.PasswordChar = '\0';
            this.TxtBxLiters.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBxLiters.SelectedText = "";
            this.TxtBxLiters.SelectionLength = 0;
            this.TxtBxLiters.SelectionStart = 0;
            this.TxtBxLiters.ShortcutsEnabled = true;
            this.TxtBxLiters.Size = new System.Drawing.Size(240, 23);
            this.TxtBxLiters.TabIndex = 5;
            this.TxtBxLiters.Text = "liters";
            this.TxtBxLiters.UseSelectable = true;
            this.TxtBxLiters.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBxLiters.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(73, 208);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Supervisor";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtBxPhoneNo
            // 
            // 
            // 
            // 
            this.TxtBxPhoneNo.CustomButton.Image = null;
            this.TxtBxPhoneNo.CustomButton.Location = new System.Drawing.Point(487, 1);
            this.TxtBxPhoneNo.CustomButton.Name = "";
            this.TxtBxPhoneNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBxPhoneNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBxPhoneNo.CustomButton.TabIndex = 1;
            this.TxtBxPhoneNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBxPhoneNo.CustomButton.UseSelectable = true;
            this.TxtBxPhoneNo.CustomButton.Visible = false;
            this.TxtBxPhoneNo.Enabled = false;
            this.TxtBxPhoneNo.Lines = new string[0];
            this.TxtBxPhoneNo.Location = new System.Drawing.Point(215, 104);
            this.TxtBxPhoneNo.MaxLength = 32767;
            this.TxtBxPhoneNo.Name = "TxtBxPhoneNo";
            this.TxtBxPhoneNo.PasswordChar = '\0';
            this.TxtBxPhoneNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBxPhoneNo.SelectedText = "";
            this.TxtBxPhoneNo.SelectionLength = 0;
            this.TxtBxPhoneNo.SelectionStart = 0;
            this.TxtBxPhoneNo.ShortcutsEnabled = true;
            this.TxtBxPhoneNo.Size = new System.Drawing.Size(509, 23);
            this.TxtBxPhoneNo.TabIndex = 3;
            this.TxtBxPhoneNo.UseSelectable = true;
            this.TxtBxPhoneNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBxPhoneNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtBxContracotrName
            // 
            // 
            // 
            // 
            this.TxtBxContracotrName.CustomButton.Image = null;
            this.TxtBxContracotrName.CustomButton.Location = new System.Drawing.Point(487, 1);
            this.TxtBxContracotrName.CustomButton.Name = "";
            this.TxtBxContracotrName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBxContracotrName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBxContracotrName.CustomButton.TabIndex = 1;
            this.TxtBxContracotrName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBxContracotrName.CustomButton.UseSelectable = true;
            this.TxtBxContracotrName.CustomButton.Visible = false;
            this.TxtBxContracotrName.Enabled = false;
            this.TxtBxContracotrName.Lines = new string[0];
            this.TxtBxContracotrName.Location = new System.Drawing.Point(215, 52);
            this.TxtBxContracotrName.MaxLength = 32767;
            this.TxtBxContracotrName.Name = "TxtBxContracotrName";
            this.TxtBxContracotrName.PasswordChar = '\0';
            this.TxtBxContracotrName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBxContracotrName.SelectedText = "";
            this.TxtBxContracotrName.SelectionLength = 0;
            this.TxtBxContracotrName.SelectionStart = 0;
            this.TxtBxContracotrName.ShortcutsEnabled = true;
            this.TxtBxContracotrName.Size = new System.Drawing.Size(509, 23);
            this.TxtBxContracotrName.TabIndex = 1;
            this.TxtBxContracotrName.UseSelectable = true;
            this.TxtBxContracotrName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBxContracotrName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(588, 407);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(116, 23);
            this.BtnUpdate.TabIndex = 7;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseSelectable = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(716, 407);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(116, 23);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseSelectable = true;
            // 
            // FrmPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 453);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "FrmPoints";
            this.Text = "Points Input Form";
            this.Load += new System.EventHandler(this.FrmPoints_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox TxtBxUniqueId;
        private MetroFramework.Controls.MetroLink LinkUniqueId;
        private MetroFramework.Controls.MetroLink LinkPhone;
        private MetroFramework.Controls.MetroLink LinkContractor;
        private MetroFramework.Controls.MetroComboBox CmbBxSupervisor;
        private MetroFramework.Controls.MetroTextBox TxtBxKgs;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox TxtBxLiters;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TxtBxPhoneNo;
        private MetroFramework.Controls.MetroTextBox TxtBxContracotrName;
        private MetroFramework.Controls.MetroButton BtnUpdate;
        private MetroFramework.Controls.MetroButton BtnCancel;
    }
}