
namespace PELOSCALVO
{
    partial class FormVistaPreliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVistaPreliminar));
            this.DtDetallesFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Dtfacturas = new PELOSCALVO.Dtfacturas();
            this.DtNuevaFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsCONFIGURACCION = new PELOSCALVO.DsCONFIGURACCION();
            this.DtConfiguracionPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtfacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.printNota = new System.Drawing.Printing.PrintDocument();
            this.BtnImprimirVistaPre = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printArticulos = new System.Drawing.Printing.PrintDocument();
            this.printClientes = new System.Drawing.Printing.PrintDocument();
            this.printNota2 = new System.Drawing.Printing.PrintDocument();
            this.printAlbaran = new System.Drawing.Printing.PrintDocument();
            this.printPresupuesto = new System.Drawing.Printing.PrintDocument();
            this.printNotaSimple = new System.Drawing.Printing.PrintDocument();
            this.printNotaDiseño = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.DtDetallesFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtfacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtNuevaFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsCONFIGURACCION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtConfiguracionPrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfacturasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DtDetallesFacturaBindingSource
            // 
            this.DtDetallesFacturaBindingSource.DataMember = "DtDetallesFactura";
            // 
            // Dtfacturas
            // 
            this.Dtfacturas.DataSetName = "Dtfacturas";
            this.Dtfacturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DtNuevaFacturaBindingSource
            // 
            this.DtNuevaFacturaBindingSource.DataMember = "DtNuevaFactura";
            this.DtNuevaFacturaBindingSource.DataSource = this.Dtfacturas;
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
            // dtfacturasBindingSource
            // 
            this.dtfacturasBindingSource.DataSource = this.Dtfacturas;
            this.dtfacturasBindingSource.Position = 0;
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printPreviewControl1.AutoZoom = false;
            this.printPreviewControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.printPreviewControl1.Document = this.printNota;
            this.printPreviewControl1.Location = new System.Drawing.Point(0, 53);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(884, 696);
            this.printPreviewControl1.TabIndex = 0;
            this.printPreviewControl1.Zoom = 1D;
            // 
            // printNota
            // 
            this.printNota.DocumentName = "docum";
            this.printNota.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printNota_PrintPage);
            // 
            // BtnImprimirVistaPre
            // 
            this.BtnImprimirVistaPre.Location = new System.Drawing.Point(27, 12);
            this.BtnImprimirVistaPre.Name = "BtnImprimirVistaPre";
            this.BtnImprimirVistaPre.Size = new System.Drawing.Size(109, 34);
            this.BtnImprimirVistaPre.TabIndex = 1;
            this.BtnImprimirVistaPre.Text = "Imprimir";
            this.BtnImprimirVistaPre.UseVisualStyleBackColor = true;
            this.BtnImprimirVistaPre.Click += new System.EventHandler(this.BtnImprimirVistaPre_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.AllowSelection = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.PrintToFile = true;
            this.printDialog1.ShowHelp = true;
            this.printDialog1.UseEXDialog = true;
            // 
            // printArticulos
            // 
            this.printArticulos.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printArticulos_PrintPage);
            // 
            // printClientes
            // 
            this.printClientes.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printClientes_PrintPage);
            // 
            // printNota2
            // 
            this.printNota2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printAlbaran
            // 
            this.printAlbaran.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printAlbaran_PrintPage);
            // 
            // printPresupuesto
            // 
            this.printPresupuesto.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printPresupuesto_PrintPage);
            // 
            // printNotaSimple
            // 
            this.printNotaSimple.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printNotaSimple_PrintPage);
            // 
            // FormVistaPreliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 749);
            this.Controls.Add(this.BtnImprimirVistaPre);
            this.Controls.Add(this.printPreviewControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVistaPreliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista Preliminar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormVistaPreliminar_FormClosed);
            this.Load += new System.EventHandler(this.FormVistaPreliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtDetallesFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtfacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtNuevaFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsCONFIGURACCION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtConfiguracionPrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfacturasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource DtDetallesFacturaBindingSource;
        private Dtfacturas Dtfacturas;
        private System.Windows.Forms.BindingSource DtConfiguracionPrincipalBindingSource;
        private DsCONFIGURACCION DsCONFIGURACCION;
        public Microsoft.Reporting.WinForms.ReportViewer ReportesVer;
        public System.Windows.Forms.BindingSource DtNuevaFacturaBindingSource;
        private System.Windows.Forms.BindingSource dtfacturasBindingSource;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Drawing.Printing.PrintDocument printNota;
        private System.Windows.Forms.Button BtnImprimirVistaPre;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printArticulos;
        private System.Drawing.Printing.PrintDocument printClientes;
        private System.Drawing.Printing.PrintDocument printNota2;
        private System.Drawing.Printing.PrintDocument printAlbaran;
        private System.Drawing.Printing.PrintDocument printPresupuesto;
        private System.Drawing.Printing.PrintDocument printNotaSimple;
        private System.Drawing.Printing.PrintDocument printNotaDiseño;
    }
}