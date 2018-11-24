namespace PointsUI
{
    partial class FrmListContractors
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
            this.GV = new MetroFramework.Controls.MetroGrid();
            this.ColContractorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColModify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColContractorNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColContractorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSupervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSupervisorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
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
            this.ColContractorId,
            this.ColModify,
            this.ColDelete,
            this.ColContractorNo,
            this.ColContractorName,
            this.ColMobileNumber,
            this.ColSupervisor,
            this.ColAddedBy,
            this.ColAddedOn,
            this.ColImage,
            this.ColAddress,
            this.ColSupervisorId});
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
            this.GV.Size = new System.Drawing.Size(860, 410);
            this.GV.TabIndex = 2;
            this.GV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_CellContentClick);
            // 
            // ColContractorId
            // 
            this.ColContractorId.HeaderText = "Contractor Id";
            this.ColContractorId.Name = "ColContractorId";
            this.ColContractorId.Visible = false;
            // 
            // ColModify
            // 
            this.ColModify.HeaderText = "Modify";
            this.ColModify.Name = "ColModify";
            this.ColModify.Text = "Modify";
            // 
            // ColDelete
            // 
            this.ColDelete.HeaderText = "Delete";
            this.ColDelete.Name = "ColDelete";
            this.ColDelete.Text = "Delete";
            // 
            // ColContractorNo
            // 
            this.ColContractorNo.HeaderText = "Contractor No";
            this.ColContractorNo.Name = "ColContractorNo";
            // 
            // ColContractorName
            // 
            this.ColContractorName.HeaderText = "Contractor Name";
            this.ColContractorName.Name = "ColContractorName";
            // 
            // ColMobileNumber
            // 
            this.ColMobileNumber.HeaderText = "Mobile Number";
            this.ColMobileNumber.Name = "ColMobileNumber";
            // 
            // ColSupervisor
            // 
            this.ColSupervisor.HeaderText = "Supervisor Name";
            this.ColSupervisor.Name = "ColSupervisor";
            // 
            // ColAddedBy
            // 
            this.ColAddedBy.HeaderText = "Added By";
            this.ColAddedBy.Name = "ColAddedBy";
            // 
            // ColAddedOn
            // 
            this.ColAddedOn.HeaderText = "Added On";
            this.ColAddedOn.Name = "ColAddedOn";
            // 
            // ColImage
            // 
            this.ColImage.HeaderText = "Image";
            this.ColImage.Name = "ColImage";
            this.ColImage.Visible = false;
            // 
            // ColAddress
            // 
            this.ColAddress.HeaderText = "Address";
            this.ColAddress.Name = "ColAddress";
            this.ColAddress.Visible = false;
            // 
            // ColSupervisorId
            // 
            this.ColSupervisorId.HeaderText = "supervisorId";
            this.ColSupervisorId.Name = "ColSupervisorId";
            this.ColSupervisorId.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(130, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(29, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.btnRefresh);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GV);
            this.splitContainer1.Size = new System.Drawing.Size(860, 457);
            this.splitContainer1.SplitterDistance = 43;
            this.splitContainer1.TabIndex = 7;
            // 
            // FrmListContractors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(900, 537);
            this.Controls.Add(this.splitContainer1);
            this.MinimizeBox = false;
            this.Name = "FrmListContractors";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Contractor List";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColContractorId;
        private System.Windows.Forms.DataGridViewButtonColumn ColModify;
        private System.Windows.Forms.DataGridViewButtonColumn ColDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColContractorNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColContractorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMobileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSupervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSupervisorId;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}