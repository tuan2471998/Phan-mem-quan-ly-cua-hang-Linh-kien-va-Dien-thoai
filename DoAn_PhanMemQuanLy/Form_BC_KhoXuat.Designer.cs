namespace DoAn_PhanMemQuanLy
{
    partial class Form_BC_KhoXuat
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
            this.KHO_XUATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KHO_XUATTableAdapter = new DoAn_PhanMemQuanLy.DeAnDataSetTableAdapters.KHO_XUATTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DeAnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KHO_XUATBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "KhoXuat";
            reportDataSource1.Value = this.KHO_XUATBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAn_PhanMemQuanLy.Report.Report_KhoXuat.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1102, 521);
            this.reportViewer1.TabIndex = 0;
            // 
            // DeAnDataSet
            // 
            this.DeAnDataSet.DataSetName = "DeAnDataSet";
            this.DeAnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KHO_XUATBindingSource
            // 
            this.KHO_XUATBindingSource.DataMember = "KHO_XUAT";
            this.KHO_XUATBindingSource.DataSource = this.DeAnDataSet;
            // 
            // KHO_XUATTableAdapter
            // 
            this.KHO_XUATTableAdapter.ClearBeforeFill = true;
            // 
            // Form_BC_KhoXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 521);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_BC_KhoXuat";
            this.Text = "Form_BC_KhoXuat";
            this.Load += new System.EventHandler(this.Form_BC_KhoXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeAnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KHO_XUATBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KHO_XUATBindingSource;
        private DeAnDataSet DeAnDataSet;
        private DeAnDataSetTableAdapters.KHO_XUATTableAdapter KHO_XUATTableAdapter;
    }
}