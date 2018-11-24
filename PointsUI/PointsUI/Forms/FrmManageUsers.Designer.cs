namespace PointsUI.Forms
{
    partial class FrmManageUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtBxPass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TxtBxConfirmPass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TxtBxUserName = new MetroFramework.Controls.MetroTextBox();
            this.ChkAdmin = new System.Windows.Forms.CheckBox();
            this.BtnAdd = new MetroFramework.Controls.MetroButton();
            this.BtnClear = new MetroFramework.Controls.MetroButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GV = new MetroFramework.Controls.MetroGrid();
            this.ColDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColModify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColisAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuperUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColId = new System.Windows.Forms.DataGridViewButtonColumn();
            this.chkSuperUser = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBxPass
            // 
            // 
            // 
            // 
            this.TxtBxPass.CustomButton.Image = null;
            this.TxtBxPass.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.TxtBxPass.CustomButton.Name = "";
            this.TxtBxPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBxPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBxPass.CustomButton.TabIndex = 1;
            this.TxtBxPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBxPass.CustomButton.UseSelectable = true;
            this.TxtBxPass.CustomButton.Visible = false;
            this.TxtBxPass.Lines = new string[0];
            this.TxtBxPass.Location = new System.Drawing.Point(134, 79);
            this.TxtBxPass.MaxLength = 32767;
            this.TxtBxPass.Name = "TxtBxPass";
            this.TxtBxPass.PasswordChar = '*';
            this.TxtBxPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBxPass.SelectedText = "";
            this.TxtBxPass.SelectionLength = 0;
            this.TxtBxPass.SelectionStart = 0;
            this.TxtBxPass.ShortcutsEnabled = true;
            this.TxtBxPass.Size = new System.Drawing.Size(194, 23);
            this.TxtBxPass.TabIndex = 2;
            this.TxtBxPass.UseSelectable = true;
            this.TxtBxPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBxPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(53, 82);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Password";
            // 
            // TxtBxConfirmPass
            // 
            // 
            // 
            // 
            this.TxtBxConfirmPass.CustomButton.Image = null;
            this.TxtBxConfirmPass.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.TxtBxConfirmPass.CustomButton.Name = "";
            this.TxtBxConfirmPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBxConfirmPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBxConfirmPass.CustomButton.TabIndex = 1;
            this.TxtBxConfirmPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBxConfirmPass.CustomButton.UseSelectable = true;
            this.TxtBxConfirmPass.CustomButton.Visible = false;
            this.TxtBxConfirmPass.Lines = new string[0];
            this.TxtBxConfirmPass.Location = new System.Drawing.Point(134, 135);
            this.TxtBxConfirmPass.MaxLength = 32767;
            this.TxtBxConfirmPass.Name = "TxtBxConfirmPass";
            this.TxtBxConfirmPass.PasswordChar = '*';
            this.TxtBxConfirmPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBxConfirmPass.SelectedText = "";
            this.TxtBxConfirmPass.SelectionLength = 0;
            this.TxtBxConfirmPass.SelectionStart = 0;
            this.TxtBxConfirmPass.ShortcutsEnabled = true;
            this.TxtBxConfirmPass.Size = new System.Drawing.Size(194, 23);
            this.TxtBxConfirmPass.TabIndex = 3;
            this.TxtBxConfirmPass.UseSelectable = true;
            this.TxtBxConfirmPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBxConfirmPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(5, 139);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(111, 19);
            this.metroLabel1.TabIndex = 29;
            this.metroLabel1.Text = "ConfirmPassword";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(45, 25);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 19);
            this.metroLabel4.TabIndex = 31;
            this.metroLabel4.Text = "UserName";
            // 
            // TxtBxUserName
            // 
            // 
            // 
            // 
            this.TxtBxUserName.CustomButton.Image = null;
            this.TxtBxUserName.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.TxtBxUserName.CustomButton.Name = "";
            this.TxtBxUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBxUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBxUserName.CustomButton.TabIndex = 1;
            this.TxtBxUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBxUserName.CustomButton.UseSelectable = true;
            this.TxtBxUserName.CustomButton.Visible = false;
            this.TxtBxUserName.Lines = new string[0];
            this.TxtBxUserName.Location = new System.Drawing.Point(134, 23);
            this.TxtBxUserName.MaxLength = 32767;
            this.TxtBxUserName.Name = "TxtBxUserName";
            this.TxtBxUserName.PasswordChar = '\0';
            this.TxtBxUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBxUserName.SelectedText = "";
            this.TxtBxUserName.SelectionLength = 0;
            this.TxtBxUserName.SelectionStart = 0;
            this.TxtBxUserName.ShortcutsEnabled = true;
            this.TxtBxUserName.Size = new System.Drawing.Size(194, 23);
            this.TxtBxUserName.TabIndex = 1;
            this.TxtBxUserName.UseSelectable = true;
            this.TxtBxUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBxUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ChkAdmin
            // 
            this.ChkAdmin.AutoSize = true;
            this.ChkAdmin.Location = new System.Drawing.Point(94, 181);
            this.ChkAdmin.Name = "ChkAdmin";
            this.ChkAdmin.Size = new System.Drawing.Size(66, 17);
            this.ChkAdmin.TabIndex = 4;
            this.ChkAdmin.Text = "Is Admin";
            this.ChkAdmin.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(134, 204);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(94, 23);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseSelectable = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(234, 204);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(94, 23);
            this.BtnClear.TabIndex = 6;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseSelectable = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chkSuperUser);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel4);
            this.splitContainer1.Panel2.Controls.Add(this.BtnClear);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel3);
            this.splitContainer1.Panel2.Controls.Add(this.BtnAdd);
            this.splitContainer1.Panel2.Controls.Add(this.TxtBxPass);
            this.splitContainer1.Panel2.Controls.Add(this.ChkAdmin);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel1);
            this.splitContainer1.Panel2.Controls.Add(this.TxtBxUserName);
            this.splitContainer1.Panel2.Controls.Add(this.TxtBxConfirmPass);
            this.splitContainer1.Size = new System.Drawing.Size(783, 256);
            this.splitContainer1.SplitterDistance = 430;
            this.splitContainer1.TabIndex = 37;
            // 
            // GV
            // 
            this.GV.AllowUserToAddRows = false;
            this.GV.AllowUserToDeleteRows = false;
            this.GV.AllowUserToResizeRows = false;
            this.GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDelete,
            this.ColModify,
            this.ColUserName,
            this.ColisAdmin,
            this.colSuperUser,
            this.ColAddedBy,
            this.ColAddedOn,
            this.ColId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GV.DefaultCellStyle = dataGridViewCellStyle2;
            this.GV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GV.EnableHeadersVisualStyles = false;
            this.GV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GV.Location = new System.Drawing.Point(0, 0);
            this.GV.Name = "GV";
            this.GV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new System.Drawing.Size(428, 254);
            this.GV.TabIndex = 0;
            this.GV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_CellContentClick);
            // 
            // ColDelete
            // 
            this.ColDelete.HeaderText = "Delete";
            this.ColDelete.Name = "ColDelete";
            // 
            // ColModify
            // 
            this.ColModify.HeaderText = "Modify";
            this.ColModify.Name = "ColModify";
            // 
            // ColUserName
            // 
            this.ColUserName.HeaderText = "UserName";
            this.ColUserName.Name = "ColUserName";
            this.ColUserName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColUserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColisAdmin
            // 
            this.ColisAdmin.HeaderText = "IsAdmin";
            this.ColisAdmin.Name = "ColisAdmin";
            // 
            // colSuperUser
            // 
            this.colSuperUser.HeaderText = "Is Super User";
            this.colSuperUser.Name = "colSuperUser";
            // 
            // ColAddedBy
            // 
            this.ColAddedBy.HeaderText = "AddedBy";
            this.ColAddedBy.Name = "ColAddedBy";
            this.ColAddedBy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColAddedBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColAddedOn
            // 
            this.ColAddedOn.HeaderText = "AddedOn";
            this.ColAddedOn.Name = "ColAddedOn";
            this.ColAddedOn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColAddedOn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "ID";
            this.ColId.Name = "ColId";
            this.ColId.Visible = false;
            // 
            // chkSuperUser
            // 
            this.chkSuperUser.AutoSize = true;
            this.chkSuperUser.Location = new System.Drawing.Point(184, 181);
            this.chkSuperUser.Name = "chkSuperUser";
            this.chkSuperUser.Size = new System.Drawing.Size(90, 17);
            this.chkSuperUser.TabIndex = 32;
            this.chkSuperUser.Text = "Is Super User";
            this.chkSuperUser.UseVisualStyleBackColor = true;
            // 
            // FrmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(823, 336);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "FrmManageUsers";
            this.Text = "Manage Users";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox TxtBxPass;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TxtBxConfirmPass;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox TxtBxUserName;
        private System.Windows.Forms.CheckBox ChkAdmin;
        private MetroFramework.Controls.MetroButton BtnAdd;
        private MetroFramework.Controls.MetroButton BtnClear;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroGrid GV;
        private System.Windows.Forms.CheckBox chkSuperUser;
        private System.Windows.Forms.DataGridViewButtonColumn ColDelete;
        private System.Windows.Forms.DataGridViewButtonColumn ColModify;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColisAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSuperUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddedOn;
        private System.Windows.Forms.DataGridViewButtonColumn ColId;
    }
}