namespace PointsUI
{
    partial class FrmContractorPending
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
            this.ColApprove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColReject = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColContractorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIdtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSupervisorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ColApprove,
            this.ColReject,
            this.ColContractorName,
            this.ColMobileNumber,
            this.ColAddress,
            this.ColIdtype,
            this.ColSupervisorName,
            this.ColStatus});
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
            this.GV.Size = new System.Drawing.Size(860, 406);
            this.GV.TabIndex = 2;
            this.GV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_CellContentClick);
            // 
            // ColContractorId
            // 
            this.ColContractorId.HeaderText = "Contractor Id";
            this.ColContractorId.Name = "ColContractorId";
            this.ColContractorId.Visible = false;
            // 
            // ColApprove
            // 
            this.ColApprove.HeaderText = "Approve";
            this.ColApprove.Name = "ColApprove";
            this.ColApprove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColApprove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColReject
            // 
            this.ColReject.HeaderText = "Reject";
            this.ColReject.Name = "ColReject";
            this.ColReject.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColReject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // ColAddress
            // 
            this.ColAddress.HeaderText = "Address";
            this.ColAddress.Name = "ColAddress";
            // 
            // ColIdtype
            // 
            this.ColIdtype.HeaderText = "Id Type";
            this.ColIdtype.Name = "ColIdtype";
            // 
            // ColSupervisorName
            // 
            this.ColSupervisorName.HeaderText = "Supervisor Name";
            this.ColSupervisorName.Name = "ColSupervisorName";
            // 
            // ColStatus
            // 
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.Name = "ColStatus";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(14, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
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
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GV);
            this.splitContainer1.Size = new System.Drawing.Size(860, 457);
            this.splitContainer1.SplitterDistance = 47;
            this.splitContainer1.TabIndex = 2;
            // 
            // FrmContractorPending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(900, 537);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmContractorPending";
            this.Text = "Pending approval for Contractors addition";
            this.Load += new System.EventHandler(this.FrmContractorPending_Load);
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
        private System.Windows.Forms.DataGridViewButtonColumn ColApprove;
        private System.Windows.Forms.DataGridViewButtonColumn ColReject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColContractorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMobileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSupervisorName;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}