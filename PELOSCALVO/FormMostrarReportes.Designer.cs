
namespace PELOSCALVO
{
    partial class FormMostrarReportes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DtDetallesFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DtNuevaFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsCONFIGURACCION = new PELOSCALVO.DsCONFIGURACCION();
            this.DtConfiguracionPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DtDetallesFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtNuevaFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsCONFIGURACCION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtConfiguracionPrincipalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetFactura";
            reportDataSource1.Value = this.DtDetallesFacturaBindingSource;
            reportDataSource2.Name = "DataSetDatosFactura";
            reportDataSource2.Value = this.DtNuevaFacturaBindingSource;
            reportDataSource3.Name = "DataSetEmpresas";
            reportDataSource3.Value = this.DtConfiguracionPrincipalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PELOSCALVO.Reportes.ReporteFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(978, 749);
            this.reportViewer1.TabIndex = 0;
            // 
            // Dtfacturas
            // 
            // DtDetallesFacturaBindingSource
            // 
            this.DtDetallesFacturaBindingSource.DataMember = "DtDetallesFactura";
  
            // 
            // DtNuevaFacturaBindingSource
            // 
            this.DtNuevaFacturaBindingSource.DataMember = "DtNuevaFactura";
            // 
            // DsCONFIGURACCION
            // 
            this.DsCONFIGURACCION.DataSetName = "DsCONFIGURACCION";
            this.DsCONFIGURACCION.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DtConfiguracionPrincipalBindingSource
            // 
            this.DtConfiguracionPrincipalBindingSource.DataMember = "DtConfiguracionPrincipal";
            this.DtConfiguracionPrincipalBindingSource.DataSource = this.DsCONFIGURACCION;
            // 
            // FormMostrarReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 749);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormMostrarReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impresiones";
            this.Load += new System.EventHandler(this.FormMostrarReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtDetallesFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtNuevaFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsCONFIGURACCION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtConfiguracionPrincipalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DtDetallesFacturaBindingSource;
        private System.Windows.Forms.BindingSource DtNuevaFacturaBindingSource;
        private System.Windows.Forms.BindingSource DtConfiguracionPrincipalBindingSource;
        private DsCONFIGURACCION DsCONFIGURACCION;
    }
}