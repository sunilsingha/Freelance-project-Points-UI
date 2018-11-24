namespace PointsUI
{
    partial class FrmSupervisor
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.BtnSubmit = new MetroFramework.Controls.MetroButton();
            this.TxtBxSupervisorName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.GV = new MetroFramework.Controls.MetroGrid();
            this.ColDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColSupervisorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.metroButton2);
            this.splitContainer1.Panel1.Controls.Add(this.BtnSubmit);
            this.splitContainer1.Panel1.Controls.Add(this.TxtBxSupervisorName);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GV);
            this.splitContainer1.Size = new System.Drawing.Size(686, 358);
            this.splitContainer1.SplitterDistance = 86;
            this.splitContainer1.TabIndex = 2;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(519, 47);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Cancel";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(438, 47);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmit.TabIndex = 4;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseSelectable = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // TxtBxSupervisorName
            // 
            // 
            // 
            // 
            this.TxtBxSupervisorName.CustomButton.Image = null;
            this.TxtBxSupervisorName.CustomButton.Location = new System.Drawing.Point(418, 1);
            this.TxtBxSupervisorName.CustomButton.Name = "";
            this.TxtBxSupervisorName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBxSupervisorName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBxSupervisorName.CustomButton.TabIndex = 1;
            this.TxtBxSupervisorName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBxSupervisorName.CustomButton.UseSelectable = true;
            this.TxtBxSupervisorName.CustomButton.Visible = false;
            this.TxtBxSupervisorName.Lines = new string[0];
            this.TxtBxSupervisorName.Location = new System.Drawing.Point(153, 18);
            this.TxtBxSupervisorName.MaxLength = 32767;
            this.TxtBxSupervisorName.Name = "TxtBxSupervisorName";
            this.TxtBxSupervisorName.PasswordChar = '\0';
            this.TxtBxSupervisorName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBxSupervisorName.SelectedText = "";
            this.TxtBxSupervisorName.SelectionLength = 0;
            this.TxtBxSupervisorName.SelectionStart = 0;
            this.TxtBxSupervisorName.ShortcutsEnabled = true;
            this.TxtBxSupervisorName.Size = new System.Drawing.Size(440, 23);
            this.TxtBxSupervisorName.TabIndex = 3;
            this.TxtBxSupervisorName.UseSelectable = true;
            this.TxtBxSupervisorName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBxSupervisorName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(111, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Supervisor Name";
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
            this.ColSupervisorName,
            this.ColCreatedBy,
            this.ColCreatedOn,
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
            this.GV.Size = new System.Drawing.Size(686, 268);
            this.GV.TabIndex = 0;
            this.GV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_CellContentClick);
            // 
            // ColDelete
            // 
            this.ColDelete.HeaderText = "Delete";
            this.ColDelete.Name = "ColDelete";
            // 
            // ColSupervisorName
            // 
            this.ColSupervisorName.HeaderText = "Supervisor Name";
            this.ColSupervisorName.Name = "ColSupervisorName";
            // 
            // ColCreatedBy
            // 
            this.ColCreatedBy.HeaderText = "Created By";
            this.ColCreatedBy.Name = "ColCreatedBy";
            // 
            // ColCreatedOn
            // 
            this.ColCreatedOn.HeaderText = "Created Date";
            this.ColCreatedOn.Name = "ColCreatedOn";
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.Visible = false;
            // 
            // FrmSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(726, 438);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmSupervisor";
            this.Text = "Manage Supervisors";
            this.Load += new System.EventHandler(this.FrmSupervisor_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton BtnSubmit;
        private MetroFramework.Controls.MetroTextBox TxtBxSupervisorName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid GV;
        private System.Windows.Forms.DataGridViewButtonColumn ColDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSupervisorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCreatedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
    }
}