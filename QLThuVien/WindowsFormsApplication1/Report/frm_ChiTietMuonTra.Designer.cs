namespace WindowsFormsApplication1.Report
{
    partial class frm_ChiTietMuonTra
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
            this.ChiTietMuonTraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new WindowsFormsApplication1.Report.DataSet1();
            this.QuaThoiHanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ChiTietMuonTraTableAdapter = new WindowsFormsApplication1.Report.DataSet1TableAdapters.ChiTietMuonTraTableAdapter();
            this.QuaThoiHanTableAdapter = new WindowsFormsApplication1.Report.DataSet1TableAdapters.QuaThoiHanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietMuonTraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuaThoiHanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ChiTietMuonTraBindingSource
            // 
            this.ChiTietMuonTraBindingSource.DataMember = "ChiTietMuonTra";
            this.ChiTietMuonTraBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // QuaThoiHanBindingSource
            // 
            this.QuaThoiHanBindingSource.DataMember = "QuaThoiHan";
            this.QuaThoiHanBindingSource.DataSource = this.DataSet1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ChiTietMuonTraBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(979, 559);
            this.reportViewer1.TabIndex = 0;
            // 
            // ChiTietMuonTraTableAdapter
            // 
            this.ChiTietMuonTraTableAdapter.ClearBeforeFill = true;
            // 
            // QuaThoiHanTableAdapter
            // 
            this.QuaThoiHanTableAdapter.ClearBeforeFill = true;
            // 
            // frm_ChiTietMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 559);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_ChiTietMuonTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Chi Tiết Mượn Trả";
            this.Load += new System.EventHandler(this.frm_ChiTietMuonTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietMuonTraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuaThoiHanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ChiTietMuonTraBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.ChiTietMuonTraTableAdapter ChiTietMuonTraTableAdapter;
        private System.Windows.Forms.BindingSource QuaThoiHanBindingSource;
        private DataSet1TableAdapters.QuaThoiHanTableAdapter QuaThoiHanTableAdapter;
    }
}