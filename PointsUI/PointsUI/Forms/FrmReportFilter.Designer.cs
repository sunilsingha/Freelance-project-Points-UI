namespace PointsUI.Forms
{
    partial class FrmReportFilter
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.qryPointsTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetTransactions = new PointsUI.Forms.DataSetTransactions();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dtEnd = new MetroFramework.Controls.MetroDateTime();
            this.dtStart = new MetroFramework.Controls.MetroDateTime();
            this.CmbBxSupervisor = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.CmbBxContractor = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.qryPointsTransactionsTableAdapter = new PointsUI.Forms.DataSetTransactionsTableAdapters.qryPointsTransactionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qryPointsTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qryPointsTransactionsBindingSource
            // 
            this.qryPointsTransactionsBindingSource.DataMember = "qryPointsTransactions";
            this.qryPointsTransactionsBindingSource.DataSource = this.DataSetTransactions;
            // 
            // DataSetTransactions
            // 
            this.DataSetTransactions.DataSetName = "DataSetTransactions";
            this.DataSetTransactions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Transaction";
            reportDataSource1.Value = this.qryPointsTransactionsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PointsUI.Forms.ReportTransaction.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(674, 420);
            this.reportViewer1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel5);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel4);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel3);
            this.splitContainer1.Panel1.Controls.Add(this.dtEnd);
            this.splitContainer1.Panel1.Controls.Add(this.dtStart);
            this.splitContainer1.Panel1.Controls.Add(this.CmbBxSupervisor);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.CmbBxContractor);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(860, 420);
            this.splitContainer1.SplitterDistance = 182;
            this.splitContainer1.TabIndex = 1;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(20, 21);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(118, 25);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Apply Filters";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(9, 265);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(62, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "End Date";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(9, 199);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Start Date";
            
            // 
            // dtEnd
            // 
            this.dtEnd.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtEnd.Location = new System.Drawing.Point(10, 284);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(157, 25);
            this.dtEnd.TabIndex = 5;
            this.dtEnd.ValueChanged += new System.EventHandler(this.dtEnd_ValueChanged);
            // 
            // dtStart
            // 
            this.dtStart.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtStart.Location = new System.Drawing.Point(11, 219);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(157, 25);
            this.dtStart.TabIndex = 4;
            this.dtStart.ValueChanged += new System.EventHandler(this.dtStart_ValueChanged);
            // 
            // CmbBxSupervisor
            // 
            this.CmbBxSupervisor.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.CmbBxSupervisor.FormattingEnabled = true;
            this.CmbBxSupervisor.ItemHeight = 19;
            this.CmbBxSupervisor.Location = new System.Drawing.Point(9, 154);
            this.CmbBxSupervisor.Name = "CmbBxSupervisor";
            this.CmbBxSupervisor.Size = new System.Drawing.Size(157, 25);
            this.CmbBxSupervisor.TabIndex = 3;
            this.CmbBxSupervisor.UseSelectable = true;
            this.CmbBxSupervisor.SelectedIndexChanged += new System.EventHandler(this.CmbBxSupervisor_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 133);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Supervisor Name";
            // 
            // CmbBxContractor
            // 
            this.CmbBxContractor.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.CmbBxContractor.FormattingEnabled = true;
            this.CmbBxContractor.ItemHeight = 19;
            this.CmbBxContractor.Location = new System.Drawing.Point(9, 89);
            this.CmbBxContractor.Name = "CmbBxContractor";
            this.CmbBxContractor.Size = new System.Drawing.Size(157, 25);
            this.CmbBxContractor.TabIndex = 1;
            this.CmbBxContractor.UseSelectable = true;
            this.CmbBxContractor.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Contractor Name";
            // 
            // qryPointsTransactionsTableAdapter
            // 
            this.qryPointsTransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmReportFilter";
            this.Text = "Transation Report";
            this.Load += new System.EventHandler(this.FrmReportFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qryPointsTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetTransactions)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource qryPointsTransactionsBindingSource;
        private DataSetTransactions DataSetTransactions;
        private DataSetTransactionsTableAdapters.qryPointsTransactionsTableAdapter qryPointsTransactionsTableAdapter;
        private MetroFramework.Controls.MetroDateTime dtEnd;
        private MetroFramework.Controls.MetroDateTime dtStart;
        private MetroFramework.Controls.MetroComboBox CmbBxSupervisor;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox CmbBxContractor;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}