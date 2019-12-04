namespace DoAn_PhanMemQuanLy
{
    partial class Form1_BC_QuyenTruyCapcs
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DeAnDataSet = new DoAn_PhanMemQuanLy.DeAnDataSet();
            this.QUYENTRUYCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QUYENTRUYCAPTableAdapter = new DoAn_PhanMemQuanLy.DeAnDataSetTableAdapters.QUYENTRUYCAPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DeAnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUYENTRUYCAPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "QuyenTruyCap";
            reportDataSource1.Value = this.QUYENTRUYCAPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAn_PhanMemQuanLy.Report.Report_QuyenTruyCap.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(720, 432);
            this.reportViewer1.TabIndex = 0;
            // 
            // DeAnDataSet
            // 
            this.DeAnDataSet.DataSetName = "DeAnDataSet";
            this.DeAnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // QUYENTRUYCAPBindingSource
            // 
            this.QUYENTRUYCAPBindingSource.DataMember = "QUYENTRUYCAP";
            this.QUYENTRUYCAPBindingSource.DataSource = this.DeAnDataSet;
            // 
            // QUYENTRUYCAPTableAdapter
            // 
            this.QUYENTRUYCAPTableAdapter.ClearBeforeFill = true;
            // 
            // Form1_BC_QuyenTruyCapcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 432);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1_BC_QuyenTruyCapcs";
            this.Text = "Form1_BC_QuyenTruyCapcs";
            this.Load += new System.EventHandler(this.Form1_BC_QuyenTruyCapcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeAnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUYENTRUYCAPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource QUYENTRUYCAPBindingSource;
        private DeAnDataSet DeAnDataSet;
        private DeAnDataSetTableAdapters.QUYENTRUYCAPTableAdapter QUYENTRUYCAPTableAdapter;
    }
}