
namespace TechSupport.UserControls
{
    partial class OpenIncidentsReportUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.OpenIncidentsReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.techSupportDataSet = new TechSupport.DataSets.TechSupportDataSet();
            this.incidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidentsTableAdapter = new TechSupport.DataSets.TechSupportDataSetTableAdapters.IncidentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenIncidentsReportViewer
            // 
            this.OpenIncidentsReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "OpenIncidentsReportDataSet";
            reportDataSource2.Value = this.incidentsBindingSource;
            this.OpenIncidentsReportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.OpenIncidentsReportViewer.LocalReport.ReportEmbeddedResource = "TechSupport.Reports.OpenIncidentsReport.rdlc";
            this.OpenIncidentsReportViewer.Location = new System.Drawing.Point(0, 0);
            this.OpenIncidentsReportViewer.Name = "OpenIncidentsReportViewer";
            this.OpenIncidentsReportViewer.ServerReport.BearerToken = null;
            this.OpenIncidentsReportViewer.Size = new System.Drawing.Size(402, 253);
            this.OpenIncidentsReportViewer.TabIndex = 0;
            // 
            // techSupportDataSet
            // 
            this.techSupportDataSet.DataSetName = "TechSupportDataSet";
            this.techSupportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incidentsBindingSource
            // 
            this.incidentsBindingSource.DataMember = "Incidents";
            this.incidentsBindingSource.DataSource = this.techSupportDataSet;
            // 
            // incidentsTableAdapter
            // 
            this.incidentsTableAdapter.ClearBeforeFill = true;
            // 
            // OpenIncidentsReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OpenIncidentsReportViewer);
            this.Name = "OpenIncidentsReportUserControl";
            this.Size = new System.Drawing.Size(402, 253);
            this.Load += new System.EventHandler(this.OpenIncidentsReportUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer OpenIncidentsReportViewer;
        private System.Windows.Forms.BindingSource incidentsBindingSource;
        private DataSets.TechSupportDataSet techSupportDataSet;
        private DataSets.TechSupportDataSetTableAdapters.IncidentsTableAdapter incidentsTableAdapter;
    }
}
