
namespace PELOSCALVO
{
    partial class FormReporteFactura
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
            this.DtDetallesFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCONFIGURACCION = new PELOSCALVO.DsCONFIGURACCION();
            this.DtNuevaFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtConfiguracionPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsFacturas = new PELOSCALVO.DsFacturas();
            this.DtDetallesFactura2BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DtDetallesFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtNuevaFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtDetallesFactura2BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // DtDetallesFacturaBindingSource
            // 
            this.DtDetallesFacturaBindingSource.DataMember = "DtNuevaFactura_DtDetallesFactura";
            this.DtDetallesFacturaBindingSource.DataSource = this.DtNuevaFacturaBindingSource;
            // 
            // dsCONFIGURACCION
            // 
            this.dsCONFIGURACCION.DataSetName = "DsCONFIGURACCION";
            this.dsCONFIGURACCION.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DtNuevaFacturaBindingSource
            // 
            this.DtNuevaFacturaBindingSource.DataMember = "DtNuevaFactura";
            this.DtNuevaFacturaBindingSource.DataSource = this.dsFacturas;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetFactura";
            reportDataSource1.Value = this.DtDetallesFacturaBindingSource;
            reportDataSource2.Name = "DataSetDatosFactura";
            reportDataSource2.Value = this.DtNuevaFacturaBindingSource;
            reportDataSource3.Name = "DataSetEmpresas";
            reportDataSource3.Value = this.dtConfiguracionPrincipalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PELOSCALVO.Reportes.ReporteFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(925, 687);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dsFacturas
            // 
            this.dsFacturas.DataSetName = "DsFacturas";
            this.dsFacturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DtDetallesFactura2BindingSource2
            // 
            this.DtDetallesFactura2BindingSource2.DataMember = "DtNuevaFactura_DtDetallesFactura2";
            this.DtDetallesFactura2BindingSource2.DataSource = this.DtNuevaFacturaBindingSource;
            // 
            // FormReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 687);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir Factura";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReporteFactura_FormClosed);
            this.Load += new System.EventHandler(this.FormReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtDetallesFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtNuevaFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtDetallesFactura2BindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource DtNuevaFacturaBindingSource;
        private System.Windows.Forms.BindingSource dtConfiguracionPrincipalBindingSource;
        private DsCONFIGURACCION dsCONFIGURACCION;
        public System.Windows.Forms.BindingSource DtDetallesFacturaBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DsFacturas dsFacturas;
        public System.Windows.Forms.BindingSource DtDetallesFactura2BindingSource2;
    }
}