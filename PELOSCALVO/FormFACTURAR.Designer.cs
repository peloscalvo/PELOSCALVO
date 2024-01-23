
namespace PELOSCALVO
{
    partial class FormFacturar
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
            System.Windows.Forms.Label empresaENLACELabel;
            System.Windows.Forms.Label numeroFacturaLabel;
            System.Windows.Forms.Label apodoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label calleLabel;
            System.Windows.Forms.Label numeroCalleLabel;
            System.Windows.Forms.Label dniLabel;
            System.Windows.Forms.Label localidadLabel;
            System.Windows.Forms.Label provinciaLabel;
            System.Windows.Forms.Label codigoPostalLabel;
            System.Windows.Forms.Label nonbreAlmacenLabel;
            System.Windows.Forms.Label ejerciciosDeAñoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label sub;
            System.Windows.Forms.Label label55;
            System.Windows.Forms.Label ttlabel;
            System.Windows.Forms.Label fechaCobroLabel;
            System.Windows.Forms.Label Label77;
            System.Windows.Forms.Label pais_FactLabel;
            System.Windows.Forms.Label idTarifaLabel;
            System.Windows.Forms.Label tarifaTipoLabel1;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label fechaFacturaLabel;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label obrasLabel;
            System.Windows.Forms.Label proveedoresLabel;
            System.Windows.Forms.Label nombreEmpresaReguistroLabel;
            System.Windows.Forms.Label Label11;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacturar));
            this.dtNuevaFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsFacturas = new PELOSCALVO.DsFacturas();
            this.dtConfiguracionPrincipalDtConfiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtConfiguracionPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCONFIGURACCION = new PELOSCALVO.DsCONFIGURACCION();
            this.PanelArriba = new System.Windows.Forms.Panel();
            this.EmpresaPrincipal = new System.Windows.Forms.ComboBox();
            this.SerieText = new System.Windows.Forms.ComboBox();
            this.dtInicioMultiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMultidatos = new PELOSCALVO.DsMultidatos();
            this.ejerciciosDeAñoComboBox = new System.Windows.Forms.ComboBox();
            this.Id_Empresa = new System.Windows.Forms.Label();
            this.dtConfiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1Factura = new System.Windows.Forms.TabPage();
            this.BtnBuscarPais = new System.Windows.Forms.Button();
            this.BtnBuscarProvi = new System.Windows.Forms.Button();
            this.EnlaceFactu = new System.Windows.Forms.Label();
            this.ProveedorTxt = new System.Windows.Forms.ComboBox();
            this.dtProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtConfiguracionPrincipalDtProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obrasComboBox = new System.Windows.Forms.ComboBox();
            this.dtObrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMulti2 = new PELOSCALVO.DsMulti2();
            this.FechaFactura = new System.Windows.Forms.DateTimePicker();
            this.BtnBuscarClientesFact = new System.Windows.Forms.Button();
            this.PaisFatuTxt = new System.Windows.Forms.ComboBox();
            this.dtPaisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cobradaFacturaCheckBox = new System.Windows.Forms.CheckBox();
            this.fechaCobroText = new System.Windows.Forms.MaskedTextBox();
            this.NumeroFactura = new System.Windows.Forms.TextBox();
            this.RazonSocialFatu = new System.Windows.Forms.TextBox();
            this.NombreClienteFatu = new System.Windows.Forms.TextBox();
            this.DirecionClienteFatu = new System.Windows.Forms.TextBox();
            this.CalleTex = new System.Windows.Forms.TextBox();
            this.NumeroCalleTxt = new System.Windows.Forms.TextBox();
            this.DniTextBox = new System.Windows.Forms.TextBox();
            this.LocalidadTxt = new System.Windows.Forms.TextBox();
            this.ProvinciaTxt = new System.Windows.Forms.ComboBox();
            this.fKDtPaisesDtProvinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CodigoPostalTxt = new System.Windows.Forms.TextBox();
            this.AlmacenTxt = new System.Windows.Forms.ComboBox();
            this.dtAlmacenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtConfiguracionPrincipalDtAlmacenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1Factura = new System.Windows.Forms.TabControl();
            this.tabPage2Factura = new System.Windows.Forms.TabPage();
            this.dtDetallesFacturaDataGridView = new System.Windows.Forms.DataGridView();
            this.referenciaDetalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusquedaArticulo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cantidadDetalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripccionDetalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDetalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoDetalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivaDetalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDetallesFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4Factura = new System.Windows.Forms.TabPage();
            this.dtDetallesFacturaDataGridView2 = new System.Windows.Forms.DataGridView();
            this.referenciaDetalleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cantidadDetalleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripccionDetalleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDetalleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoDetalleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDetallesFactura2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3Factura = new System.Windows.Forms.TabPage();
            this.CheckDescuentos = new System.Windows.Forms.RadioButton();
            this.IdDescuento = new System.Windows.Forms.Label();
            this.dtTarifaTipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.NumTotales = new System.Windows.Forms.NumericUpDown();
            this.Numimporte = new System.Windows.Forms.NumericUpDown();
            this.NumDescuento = new System.Windows.Forms.NumericUpDown();
            this.NumPrecio = new System.Windows.Forms.NumericUpDown();
            this.imagenEmpresaPicture2 = new System.Windows.Forms.PictureBox();
            this.TipoTarifaFactu = new System.Windows.Forms.ComboBox();
            this.dtConfiDtTarifaTipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtArticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articulos = new PELOSCALVO.Articulos();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.BtnSalirFactura = new System.Windows.Forms.Button();
            this.BtnImprimirFactura = new System.Windows.Forms.Button();
            this.BtnEnviarMailFactura = new System.Windows.Forms.Button();
            this.BtnEliminarFactura = new System.Windows.Forms.Button();
            this.BtnBuscarFactura = new System.Windows.Forms.Button();
            this.BtnNuevoFactura = new System.Windows.Forms.Button();
            this.BtnModificarFactura = new System.Windows.Forms.Button();
            this.BtnCancelarfactura = new System.Windows.Forms.Button();
            this.BtnGuardarFactura = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtNuevaFacturaDataGridView = new System.Windows.Forms.DataGridView();
            this.numeroFacturaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apodoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CobradaFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFacturaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IvaFactuTxt = new System.Windows.Forms.NumericUpDown();
            this.subTotal = new System.Windows.Forms.Label();
            this.baseIva = new System.Windows.Forms.Label();
            this.TotalFactura1 = new System.Windows.Forms.Label();
            this.TipoNota = new System.Windows.Forms.Label();
            this.panelTotales = new System.Windows.Forms.Panel();
            this.TotalFactura2 = new System.Windows.Forms.Label();
            this.dtClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsClientes = new PELOSCALVO.DsClientes();
            empresaENLACELabel = new System.Windows.Forms.Label();
            numeroFacturaLabel = new System.Windows.Forms.Label();
            apodoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            calleLabel = new System.Windows.Forms.Label();
            numeroCalleLabel = new System.Windows.Forms.Label();
            dniLabel = new System.Windows.Forms.Label();
            localidadLabel = new System.Windows.Forms.Label();
            provinciaLabel = new System.Windows.Forms.Label();
            codigoPostalLabel = new System.Windows.Forms.Label();
            nonbreAlmacenLabel = new System.Windows.Forms.Label();
            ejerciciosDeAñoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            sub = new System.Windows.Forms.Label();
            label55 = new System.Windows.Forms.Label();
            ttlabel = new System.Windows.Forms.Label();
            fechaCobroLabel = new System.Windows.Forms.Label();
            Label77 = new System.Windows.Forms.Label();
            pais_FactLabel = new System.Windows.Forms.Label();
            idTarifaLabel = new System.Windows.Forms.Label();
            tarifaTipoLabel1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            fechaFacturaLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            obrasLabel = new System.Windows.Forms.Label();
            proveedoresLabel = new System.Windows.Forms.Label();
            nombreEmpresaReguistroLabel = new System.Windows.Forms.Label();
            Label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtNuevaFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalDtConfiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).BeginInit();
            this.PanelArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiBindingSource)).BeginInit();
            this.tabPage1Factura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalDtProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtObrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMulti2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDtPaisesDtProvinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlmacenesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalDtAlmacenesBindingSource)).BeginInit();
            this.tabControl1Factura.SuspendLayout();
            this.tabPage2Factura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetallesFacturaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetallesFacturaBindingSource)).BeginInit();
            this.tabPage4Factura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetallesFacturaDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetallesFactura2BindingSource)).BeginInit();
            this.tabPage3Factura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarifaTipoBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTotales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numimporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenEmpresaPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiDtTarifaTipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtArticulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulos)).BeginInit();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNuevaFacturaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IvaFactuTxt)).BeginInit();
            this.panelTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // empresaENLACELabel
            // 
            empresaENLACELabel.AutoSize = true;
            empresaENLACELabel.Location = new System.Drawing.Point(5, 10);
            empresaENLACELabel.Name = "empresaENLACELabel";
            empresaENLACELabel.Size = new System.Drawing.Size(51, 13);
            empresaENLACELabel.TabIndex = 4;
            empresaENLACELabel.Text = "Empresa:";
            // 
            // numeroFacturaLabel
            // 
            numeroFacturaLabel.AutoSize = true;
            numeroFacturaLabel.Location = new System.Drawing.Point(44, 40);
            numeroFacturaLabel.Name = "numeroFacturaLabel";
            numeroFacturaLabel.Size = new System.Drawing.Size(44, 13);
            numeroFacturaLabel.TabIndex = 0;
            numeroFacturaLabel.Text = "Numero";
            // 
            // apodoLabel
            // 
            apodoLabel.AutoSize = true;
            apodoLabel.Location = new System.Drawing.Point(15, 70);
            apodoLabel.Name = "apodoLabel";
            apodoLabel.Size = new System.Drawing.Size(73, 13);
            apodoLabel.TabIndex = 2;
            apodoLabel.Text = "Razon Social:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(41, 102);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(33, 128);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 6;
            direccionLabel.Text = "Direccion:";
            // 
            // calleLabel
            // 
            calleLabel.AutoSize = true;
            calleLabel.Location = new System.Drawing.Point(55, 154);
            calleLabel.Name = "calleLabel";
            calleLabel.Size = new System.Drawing.Size(33, 13);
            calleLabel.TabIndex = 8;
            calleLabel.Text = "Calle:";
            // 
            // numeroCalleLabel
            // 
            numeroCalleLabel.AutoSize = true;
            numeroCalleLabel.Location = new System.Drawing.Point(15, 183);
            numeroCalleLabel.Name = "numeroCalleLabel";
            numeroCalleLabel.Size = new System.Drawing.Size(73, 13);
            numeroCalleLabel.TabIndex = 10;
            numeroCalleLabel.Text = "Numero Calle:";
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Location = new System.Drawing.Point(391, 40);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new System.Drawing.Size(26, 13);
            dniLabel.TabIndex = 12;
            dniLabel.Text = "Dni:";
            // 
            // localidadLabel
            // 
            localidadLabel.AutoSize = true;
            localidadLabel.Location = new System.Drawing.Point(454, 99);
            localidadLabel.Name = "localidadLabel";
            localidadLabel.Size = new System.Drawing.Size(56, 13);
            localidadLabel.TabIndex = 14;
            localidadLabel.Text = "Localidad:";
            // 
            // provinciaLabel
            // 
            provinciaLabel.AutoSize = true;
            provinciaLabel.Location = new System.Drawing.Point(456, 125);
            provinciaLabel.Name = "provinciaLabel";
            provinciaLabel.Size = new System.Drawing.Size(54, 13);
            provinciaLabel.TabIndex = 16;
            provinciaLabel.Text = "Provincia:";
            // 
            // codigoPostalLabel
            // 
            codigoPostalLabel.AutoSize = true;
            codigoPostalLabel.Location = new System.Drawing.Point(683, 40);
            codigoPostalLabel.Name = "codigoPostalLabel";
            codigoPostalLabel.Size = new System.Drawing.Size(75, 13);
            codigoPostalLabel.TabIndex = 18;
            codigoPostalLabel.Text = "Codigo Postal:";
            // 
            // nonbreAlmacenLabel
            // 
            nonbreAlmacenLabel.AutoSize = true;
            nonbreAlmacenLabel.Location = new System.Drawing.Point(834, 85);
            nonbreAlmacenLabel.Name = "nonbreAlmacenLabel";
            nonbreAlmacenLabel.Size = new System.Drawing.Size(51, 13);
            nonbreAlmacenLabel.TabIndex = 20;
            nonbreAlmacenLabel.Text = "Almacen:";
            // 
            // ejerciciosDeAñoLabel
            // 
            ejerciciosDeAñoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            ejerciciosDeAñoLabel.AutoSize = true;
            ejerciciosDeAñoLabel.Location = new System.Drawing.Point(823, 10);
            ejerciciosDeAñoLabel.Name = "ejerciciosDeAñoLabel";
            ejerciciosDeAñoLabel.Size = new System.Drawing.Size(55, 13);
            ejerciciosDeAñoLabel.TabIndex = 7;
            ejerciciosDeAñoLabel.Text = "Ejercicios:";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(1118, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(34, 13);
            label1.TabIndex = 23;
            label1.Text = "Serie:";
            // 
            // sub
            // 
            sub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            sub.AutoSize = true;
            sub.Location = new System.Drawing.Point(9, 5);
            sub.Name = "sub";
            sub.Size = new System.Drawing.Size(56, 13);
            sub.TabIndex = 39;
            sub.Text = "Sub Total:";
            // 
            // label55
            // 
            label55.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label55.AutoSize = true;
            label55.Location = new System.Drawing.Point(9, 37);
            label55.Name = "label55";
            label55.Size = new System.Drawing.Size(52, 13);
            label55.TabIndex = 41;
            label55.Text = "Base Iva:";
            // 
            // ttlabel
            // 
            ttlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            ttlabel.AutoSize = true;
            ttlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ttlabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            ttlabel.Location = new System.Drawing.Point(1070, 609);
            ttlabel.Name = "ttlabel";
            ttlabel.Size = new System.Drawing.Size(43, 15);
            ttlabel.TabIndex = 43;
            ttlabel.Text = "Total:";
            ttlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fechaCobroLabel
            // 
            fechaCobroLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            fechaCobroLabel.AutoSize = true;
            fechaCobroLabel.Location = new System.Drawing.Point(900, 180);
            fechaCobroLabel.Name = "fechaCobroLabel";
            fechaCobroLabel.Size = new System.Drawing.Size(71, 13);
            fechaCobroLabel.TabIndex = 26;
            fechaCobroLabel.Text = "Fecha Cobro:";
            // 
            // Label77
            // 
            Label77.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            Label77.AutoSize = true;
            Label77.Location = new System.Drawing.Point(864, 548);
            Label77.Name = "Label77";
            Label77.Size = new System.Drawing.Size(49, 13);
            Label77.TabIndex = 44;
            Label77.Text = "Tipo Iva:";
            Label77.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            Label77.MouseEnter += new System.EventHandler(this.tipoInpuestoIVALabel1_MouseEnter);
            // 
            // pais_FactLabel
            // 
            pais_FactLabel.AutoSize = true;
            pais_FactLabel.Location = new System.Drawing.Point(480, 153);
            pais_FactLabel.Name = "pais_FactLabel";
            pais_FactLabel.Size = new System.Drawing.Size(30, 13);
            pais_FactLabel.TabIndex = 27;
            pais_FactLabel.Text = "Pais:";
            // 
            // idTarifaLabel
            // 
            idTarifaLabel.AutoSize = true;
            idTarifaLabel.Location = new System.Drawing.Point(42, 29);
            idTarifaLabel.Name = "idTarifaLabel";
            idTarifaLabel.Size = new System.Drawing.Size(22, 13);
            idTarifaLabel.TabIndex = 6;
            idTarifaLabel.Text = "Id :";
            // 
            // tarifaTipoLabel1
            // 
            tarifaTipoLabel1.AutoSize = true;
            tarifaTipoLabel1.Location = new System.Drawing.Point(3, 55);
            tarifaTipoLabel1.Name = "tarifaTipoLabel1";
            tarifaTipoLabel1.Size = new System.Drawing.Size(62, 13);
            tarifaTipoLabel1.TabIndex = 8;
            tarifaTipoLabel1.Text = "Descuento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(53, 24);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(40, 13);
            label5.TabIndex = 47;
            label5.Text = "Precio:";
            // 
            // fechaFacturaLabel
            // 
            fechaFacturaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            fechaFacturaLabel.AutoSize = true;
            fechaFacturaLabel.Location = new System.Drawing.Point(892, 150);
            fechaFacturaLabel.Name = "fechaFacturaLabel";
            fechaFacturaLabel.Size = new System.Drawing.Size(79, 13);
            fechaFacturaLabel.TabIndex = 69;
            fechaFacturaLabel.Text = "Fecha Factura:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(34, 45);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(59, 13);
            label6.TabIndex = 49;
            label6.Text = "Descuento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(43, 69);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(50, 13);
            label7.TabIndex = 51;
            label7.Text = "Importes:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(48, 95);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(45, 13);
            label8.TabIndex = 53;
            label8.Text = "Totales:";
            // 
            // obrasLabel
            // 
            obrasLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            obrasLabel.AutoSize = true;
            obrasLabel.Location = new System.Drawing.Point(986, 41);
            obrasLabel.Name = "obrasLabel";
            obrasLabel.Size = new System.Drawing.Size(33, 13);
            obrasLabel.TabIndex = 70;
            obrasLabel.Text = "Obra:";
            // 
            // proveedoresLabel
            // 
            proveedoresLabel.AutoSize = true;
            proveedoresLabel.Location = new System.Drawing.Point(409, 180);
            proveedoresLabel.Name = "proveedoresLabel";
            proveedoresLabel.Size = new System.Drawing.Size(101, 13);
            proveedoresLabel.TabIndex = 71;
            proveedoresLabel.Text = "Proveedor o Marca:";
            // 
            // nombreEmpresaReguistroLabel
            // 
            nombreEmpresaReguistroLabel.AutoSize = true;
            nombreEmpresaReguistroLabel.Location = new System.Drawing.Point(858, 195);
            nombreEmpresaReguistroLabel.Name = "nombreEmpresaReguistroLabel";
            nombreEmpresaReguistroLabel.Size = new System.Drawing.Size(91, 13);
            nombreEmpresaReguistroLabel.TabIndex = 71;
            nombreEmpresaReguistroLabel.Text = "Nombre Empresa:";
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Location = new System.Drawing.Point(33, 10);
            Label11.Name = "Label11";
            Label11.Size = new System.Drawing.Size(19, 13);
            Label11.TabIndex = 72;
            Label11.Text = "Id:";
            // 
            // dtNuevaFacturaBindingSource
            // 
            this.dtNuevaFacturaBindingSource.DataMember = "DtNuevaFactura";
            this.dtNuevaFacturaBindingSource.DataSource = this.dsFacturas;
            // 
            // dsFacturas
            // 
            this.dsFacturas.DataSetName = "DsFacturas";
            this.dsFacturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtConfiguracionPrincipalDtConfiBindingSource
            // 
            this.dtConfiguracionPrincipalDtConfiBindingSource.DataMember = "FK_DtConfiguracionPrincipal_DtConfi";
            this.dtConfiguracionPrincipalDtConfiBindingSource.DataSource = this.dtConfiguracionPrincipalBindingSource;
            // 
            // dtConfiguracionPrincipalBindingSource
            // 
            this.dtConfiguracionPrincipalBindingSource.DataMember = "DtConfiguracionPrincipal";
            this.dtConfiguracionPrincipalBindingSource.DataSource = this.dsCONFIGURACCION;
            // 
            // dsCONFIGURACCION
            // 
            this.dsCONFIGURACCION.DataSetName = "DsCONFIGURACCION";
            this.dsCONFIGURACCION.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PanelArriba
            // 
            this.PanelArriba.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelArriba.Controls.Add(this.EmpresaPrincipal);
            this.PanelArriba.Controls.Add(label1);
            this.PanelArriba.Controls.Add(this.SerieText);
            this.PanelArriba.Controls.Add(ejerciciosDeAñoLabel);
            this.PanelArriba.Controls.Add(this.ejerciciosDeAñoComboBox);
            this.PanelArriba.Controls.Add(empresaENLACELabel);
            this.PanelArriba.Controls.Add(this.Id_Empresa);
            this.PanelArriba.Location = new System.Drawing.Point(0, 0);
            this.PanelArriba.Name = "PanelArriba";
            this.PanelArriba.Size = new System.Drawing.Size(1287, 35);
            this.PanelArriba.TabIndex = 2;
            this.PanelArriba.Tag = "NO";
            this.PanelArriba.MouseEnter += new System.EventHandler(this.PanelArriba_MouseEnter);
            this.PanelArriba.MouseLeave += new System.EventHandler(this.PanelArriba_MouseLeave);
            // 
            // EmpresaPrincipal
            // 
            this.EmpresaPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.EmpresaPrincipal.DataSource = this.dtConfiguracionPrincipalBindingSource;
            this.EmpresaPrincipal.DisplayMember = "EmpresaConfi";
            this.EmpresaPrincipal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpresaPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpresaPrincipal.FormattingEnabled = true;
            this.EmpresaPrincipal.Location = new System.Drawing.Point(62, 7);
            this.EmpresaPrincipal.Name = "EmpresaPrincipal";
            this.EmpresaPrincipal.Size = new System.Drawing.Size(377, 24);
            this.EmpresaPrincipal.TabIndex = 73;
            this.EmpresaPrincipal.SelectedIndexChanged += new System.EventHandler(this.EmpresaPrincipal_SelectedIndexChanged);
            this.EmpresaPrincipal.SelectedValueChanged += new System.EventHandler(this.EmpresaPrincipal_SelectedValueChanged);
            this.EmpresaPrincipal.Click += new System.EventHandler(this.EmpresaPrincipal_Click);
            this.EmpresaPrincipal.Enter += new System.EventHandler(this.EmpresaPrincipal_Enter);
            this.EmpresaPrincipal.MouseEnter += new System.EventHandler(this.EmpresaPrincipal_MouseEnter);
            this.EmpresaPrincipal.MouseLeave += new System.EventHandler(this.EmpresaPrincipal_MouseLeave);
            // 
            // SerieText
            // 
            this.SerieText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SerieText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "SerieInicio", true));
            this.SerieText.DisplayMember = "A";
            this.SerieText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SerieText.FormattingEnabled = true;
            this.SerieText.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G"});
            this.SerieText.Location = new System.Drawing.Point(1163, 7);
            this.SerieText.Name = "SerieText";
            this.SerieText.Size = new System.Drawing.Size(121, 21);
            this.SerieText.TabIndex = 9;
            this.SerieText.SelectedIndexChanged += new System.EventHandler(this.SerieText_SelectedIndexChanged);
            this.SerieText.Click += new System.EventHandler(this.SerieText_Click);
            // 
            // dtInicioMultiBindingSource
            // 
            this.dtInicioMultiBindingSource.DataMember = "DtInicioMulti";
            this.dtInicioMultiBindingSource.DataSource = this.dsMultidatos;
            // 
            // dsMultidatos
            // 
            this.dsMultidatos.DataSetName = "DsMultidatos";
            this.dsMultidatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ejerciciosDeAñoComboBox
            // 
            this.ejerciciosDeAñoComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ejerciciosDeAñoComboBox.DataSource = this.dtConfiguracionPrincipalDtConfiBindingSource;
            this.ejerciciosDeAñoComboBox.DisplayMember = "EjerciciosDeAño";
            this.ejerciciosDeAñoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ejerciciosDeAñoComboBox.FormattingEnabled = true;
            this.ejerciciosDeAñoComboBox.Location = new System.Drawing.Point(884, 7);
            this.ejerciciosDeAñoComboBox.Name = "ejerciciosDeAñoComboBox";
            this.ejerciciosDeAñoComboBox.Size = new System.Drawing.Size(195, 21);
            this.ejerciciosDeAñoComboBox.TabIndex = 8;
            this.ejerciciosDeAñoComboBox.SelectedIndexChanged += new System.EventHandler(this.EjerciciosDeAñoComboBox_SelectedIndexChanged_1);
            this.ejerciciosDeAñoComboBox.Click += new System.EventHandler(this.ejerciciosDeAñoComboBox_Click_1);
            // 
            // Id_Empresa
            // 
            this.Id_Empresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtConfiguracionPrincipalBindingSource, "IdEmpresa", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.Id_Empresa.Location = new System.Drawing.Point(445, 9);
            this.Id_Empresa.Name = "Id_Empresa";
            this.Id_Empresa.Size = new System.Drawing.Size(0, 23);
            this.Id_Empresa.TabIndex = 72;
            this.Id_Empresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Id_Empresa.TextChanged += new System.EventHandler(this.NombreEmpresaReguistro_TextChanged);
            // 
            // dtConfiBindingSource
            // 
            this.dtConfiBindingSource.DataMember = "DtConfi";
            this.dtConfiBindingSource.DataSource = this.dsCONFIGURACCION;
            // 
            // tabPage1Factura
            // 
            this.tabPage1Factura.AutoScroll = true;
            this.tabPage1Factura.Controls.Add(this.BtnBuscarPais);
            this.tabPage1Factura.Controls.Add(this.BtnBuscarProvi);
            this.tabPage1Factura.Controls.Add(Label11);
            this.tabPage1Factura.Controls.Add(this.EnlaceFactu);
            this.tabPage1Factura.Controls.Add(proveedoresLabel);
            this.tabPage1Factura.Controls.Add(this.ProveedorTxt);
            this.tabPage1Factura.Controls.Add(obrasLabel);
            this.tabPage1Factura.Controls.Add(this.obrasComboBox);
            this.tabPage1Factura.Controls.Add(fechaFacturaLabel);
            this.tabPage1Factura.Controls.Add(this.FechaFactura);
            this.tabPage1Factura.Controls.Add(this.BtnBuscarClientesFact);
            this.tabPage1Factura.Controls.Add(pais_FactLabel);
            this.tabPage1Factura.Controls.Add(this.PaisFatuTxt);
            this.tabPage1Factura.Controls.Add(this.cobradaFacturaCheckBox);
            this.tabPage1Factura.Controls.Add(fechaCobroLabel);
            this.tabPage1Factura.Controls.Add(this.fechaCobroText);
            this.tabPage1Factura.Controls.Add(numeroFacturaLabel);
            this.tabPage1Factura.Controls.Add(this.NumeroFactura);
            this.tabPage1Factura.Controls.Add(apodoLabel);
            this.tabPage1Factura.Controls.Add(this.RazonSocialFatu);
            this.tabPage1Factura.Controls.Add(nombreLabel);
            this.tabPage1Factura.Controls.Add(this.NombreClienteFatu);
            this.tabPage1Factura.Controls.Add(direccionLabel);
            this.tabPage1Factura.Controls.Add(this.DirecionClienteFatu);
            this.tabPage1Factura.Controls.Add(calleLabel);
            this.tabPage1Factura.Controls.Add(this.CalleTex);
            this.tabPage1Factura.Controls.Add(numeroCalleLabel);
            this.tabPage1Factura.Controls.Add(this.NumeroCalleTxt);
            this.tabPage1Factura.Controls.Add(dniLabel);
            this.tabPage1Factura.Controls.Add(this.DniTextBox);
            this.tabPage1Factura.Controls.Add(localidadLabel);
            this.tabPage1Factura.Controls.Add(this.LocalidadTxt);
            this.tabPage1Factura.Controls.Add(provinciaLabel);
            this.tabPage1Factura.Controls.Add(this.ProvinciaTxt);
            this.tabPage1Factura.Controls.Add(codigoPostalLabel);
            this.tabPage1Factura.Controls.Add(this.CodigoPostalTxt);
            this.tabPage1Factura.Controls.Add(nonbreAlmacenLabel);
            this.tabPage1Factura.Controls.Add(this.AlmacenTxt);
            this.tabPage1Factura.Location = new System.Drawing.Point(4, 22);
            this.tabPage1Factura.Name = "tabPage1Factura";
            this.tabPage1Factura.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1Factura.Size = new System.Drawing.Size(1283, 219);
            this.tabPage1Factura.TabIndex = 0;
            this.tabPage1Factura.Text = "General";
            this.tabPage1Factura.UseVisualStyleBackColor = true;
            this.tabPage1Factura.MouseEnter += new System.EventHandler(this.TabPage1_MouseEnter);
            // 
            // BtnBuscarPais
            // 
            this.BtnBuscarPais.Enabled = false;
            this.BtnBuscarPais.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_magnifier_4_16;
            this.BtnBuscarPais.Location = new System.Drawing.Point(777, 154);
            this.BtnBuscarPais.Name = "BtnBuscarPais";
            this.BtnBuscarPais.Size = new System.Drawing.Size(39, 23);
            this.BtnBuscarPais.TabIndex = 75;
            this.BtnBuscarPais.UseVisualStyleBackColor = true;
            this.BtnBuscarPais.Click += new System.EventHandler(this.BtnBuscarPais_Click);
            // 
            // BtnBuscarProvi
            // 
            this.BtnBuscarProvi.Enabled = false;
            this.BtnBuscarProvi.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_magnifier_4_16;
            this.BtnBuscarProvi.Location = new System.Drawing.Point(777, 120);
            this.BtnBuscarProvi.Name = "BtnBuscarProvi";
            this.BtnBuscarProvi.Size = new System.Drawing.Size(39, 23);
            this.BtnBuscarProvi.TabIndex = 74;
            this.BtnBuscarProvi.UseVisualStyleBackColor = true;
            this.BtnBuscarProvi.Click += new System.EventHandler(this.BtnBuscarProvi_Click);
            // 
            // EnlaceFactu
            // 
            this.EnlaceFactu.AutoSize = true;
            this.EnlaceFactu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtNuevaFacturaBindingSource, "EnlaceFactura", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.EnlaceFactu.Location = new System.Drawing.Point(91, 10);
            this.EnlaceFactu.Name = "EnlaceFactu";
            this.EnlaceFactu.Size = new System.Drawing.Size(0, 13);
            this.EnlaceFactu.TabIndex = 73;
            // 
            // ProveedorTxt
            // 
            this.ProveedorTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtProveedoresBindingSource, "Proveedores", true));
            this.ProveedorTxt.DataSource = this.dtConfiguracionPrincipalDtProveedoresBindingSource;
            this.ProveedorTxt.DisplayMember = "Proveedores";
            this.ProveedorTxt.FormattingEnabled = true;
            this.ProveedorTxt.Location = new System.Drawing.Point(514, 177);
            this.ProveedorTxt.MaxLength = 60;
            this.ProveedorTxt.Name = "ProveedorTxt";
            this.ProveedorTxt.Size = new System.Drawing.Size(257, 21);
            this.ProveedorTxt.TabIndex = 72;
            // 
            // dtProveedoresBindingSource
            // 
            this.dtProveedoresBindingSource.DataMember = "FK_DtConfiguracionPrincipal_DtProveedores";
            this.dtProveedoresBindingSource.DataSource = this.dtConfiguracionPrincipalBindingSource;
            // 
            // dtConfiguracionPrincipalDtProveedoresBindingSource
            // 
            this.dtConfiguracionPrincipalDtProveedoresBindingSource.DataMember = "FK_DtConfiguracionPrincipal_DtProveedores";
            this.dtConfiguracionPrincipalDtProveedoresBindingSource.DataSource = this.dtConfiguracionPrincipalBindingSource;
            // 
            // obrasComboBox
            // 
            this.obrasComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.obrasComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.obrasComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtNuevaFacturaBindingSource, "Obra_factu", true));
            this.obrasComboBox.DataSource = this.dtObrasBindingSource;
            this.obrasComboBox.DisplayMember = "Obras";
            this.obrasComboBox.Enabled = false;
            this.obrasComboBox.FormattingEnabled = true;
            this.obrasComboBox.Location = new System.Drawing.Point(1025, 38);
            this.obrasComboBox.MaxLength = 60;
            this.obrasComboBox.Name = "obrasComboBox";
            this.obrasComboBox.Size = new System.Drawing.Size(236, 21);
            this.obrasComboBox.TabIndex = 71;
            this.obrasComboBox.Click += new System.EventHandler(this.obrasComboBox_Click);
            // 
            // dtObrasBindingSource
            // 
            this.dtObrasBindingSource.DataMember = "DtObras";
            this.dtObrasBindingSource.DataSource = this.dsMulti2;
            // 
            // dsMulti2
            // 
            this.dsMulti2.DataSetName = "DsMulti2";
            this.dsMulti2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FechaFactura
            // 
            this.FechaFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaFactura.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dtNuevaFacturaBindingSource, "FechaFactura", true));
            this.FechaFactura.Enabled = false;
            this.FechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.errorProvider1.SetIconAlignment(this.FechaFactura, System.Windows.Forms.ErrorIconAlignment.BottomRight);
            this.FechaFactura.Location = new System.Drawing.Point(977, 147);
            this.FechaFactura.Name = "FechaFactura";
            this.FechaFactura.Size = new System.Drawing.Size(144, 20);
            this.FechaFactura.TabIndex = 70;
            this.FechaFactura.Value = new System.DateTime(2023, 5, 1, 0, 5, 18, 0);
            // 
            // BtnBuscarClientesFact
            // 
            this.BtnBuscarClientesFact.Enabled = false;
            this.BtnBuscarClientesFact.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_magnifier_4_16;
            this.BtnBuscarClientesFact.Location = new System.Drawing.Point(368, 67);
            this.BtnBuscarClientesFact.Name = "BtnBuscarClientesFact";
            this.BtnBuscarClientesFact.Size = new System.Drawing.Size(39, 23);
            this.BtnBuscarClientesFact.TabIndex = 69;
            this.BtnBuscarClientesFact.UseVisualStyleBackColor = true;
            this.BtnBuscarClientesFact.Click += new System.EventHandler(this.BtnBuscarClientesFact_Click);
            // 
            // PaisFatuTxt
            // 
            this.PaisFatuTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtNuevaFacturaBindingSource, "Pais_Fact", true));
            this.PaisFatuTxt.DataSource = this.dtPaisesBindingSource;
            this.PaisFatuTxt.DisplayMember = "Paises";
            this.PaisFatuTxt.Enabled = false;
            this.PaisFatuTxt.FormattingEnabled = true;
            this.PaisFatuTxt.Location = new System.Drawing.Point(514, 150);
            this.PaisFatuTxt.MaxLength = 60;
            this.PaisFatuTxt.Name = "PaisFatuTxt";
            this.PaisFatuTxt.Size = new System.Drawing.Size(257, 21);
            this.PaisFatuTxt.TabIndex = 28;
            this.PaisFatuTxt.Click += new System.EventHandler(this.Pais_FactComboBox_Click);
            // 
            // dtPaisesBindingSource
            // 
            this.dtPaisesBindingSource.DataMember = "DtPaises";
            this.dtPaisesBindingSource.DataSource = this.dsMulti2;
            // 
            // cobradaFacturaCheckBox
            // 
            this.cobradaFacturaCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cobradaFacturaCheckBox.Enabled = false;
            this.cobradaFacturaCheckBox.Location = new System.Drawing.Point(1092, 175);
            this.cobradaFacturaCheckBox.Name = "cobradaFacturaCheckBox";
            this.cobradaFacturaCheckBox.Size = new System.Drawing.Size(104, 24);
            this.cobradaFacturaCheckBox.TabIndex = 25;
            this.cobradaFacturaCheckBox.Text = "Cobrado";
            this.cobradaFacturaCheckBox.UseVisualStyleBackColor = true;
            this.cobradaFacturaCheckBox.CheckedChanged += new System.EventHandler(this.CobradaFacturaCheckBox_CheckedChanged);
            this.cobradaFacturaCheckBox.CheckStateChanged += new System.EventHandler(this.CobradaFacturaCheckBox_CheckStateChanged);
            // 
            // fechaCobroText
            // 
            this.fechaCobroText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaCobroText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtNuevaFacturaBindingSource, "FechaCobro", true));
            this.fechaCobroText.Location = new System.Drawing.Point(977, 177);
            this.fechaCobroText.Mask = "00/00/0000";
            this.fechaCobroText.Name = "fechaCobroText";
            this.fechaCobroText.ReadOnly = true;
            this.fechaCobroText.Size = new System.Drawing.Size(109, 20);
            this.fechaCobroText.TabIndex = 27;
            this.fechaCobroText.TabStop = false;
            this.fechaCobroText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fechaCobroText.UseWaitCursor = true;
            this.fechaCobroText.ValidatingType = typeof(System.DateTime);
            // 
            // NumeroFactura
            // 
            this.NumeroFactura.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtNuevaFacturaBindingSource, "NumeroFactura", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.NumeroFactura.Enabled = false;
            this.NumeroFactura.Location = new System.Drawing.Point(94, 38);
            this.NumeroFactura.Name = "NumeroFactura";
            this.NumeroFactura.Size = new System.Drawing.Size(203, 20);
            this.NumeroFactura.TabIndex = 1;
            // 
            // RazonSocialFatu
            // 
            this.RazonSocialFatu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.RazonSocialFatu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtNuevaFacturaBindingSource, "Apodo", true));
            this.RazonSocialFatu.Enabled = false;
            this.RazonSocialFatu.Location = new System.Drawing.Point(94, 67);
            this.RazonSocialFatu.MaxLength = 34;
            this.RazonSocialFatu.Name = "RazonSocialFatu";
            this.RazonSocialFatu.Size = new System.Drawing.Size(253, 20);
            this.RazonSocialFatu.TabIndex = 3;
            // 
            // NombreClienteFatu
            // 
            this.NombreClienteFatu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtNuevaFacturaBindingSource, "Nombre", true));
            this.NombreClienteFatu.Enabled = false;
            this.NombreClienteFatu.Location = new System.Drawing.Point(94, 99);
            this.NombreClienteFatu.MaxLength = 50;
            this.NombreClienteFatu.Name = "NombreClienteFatu";
            this.NombreClienteFatu.Size = new System.Drawing.Size(333, 20);
            this.NombreClienteFatu.TabIndex = 5;
            // 
            // DirecionClienteFatu
            // 
            this.DirecionClienteFatu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtNuevaFacturaBindingSource, "Direccion", true));
            this.DirecionClienteFatu.Enabled = false;
            this.DirecionClienteFatu.Location = new System.Drawing.Point(94, 125);
            this.DirecionClienteFatu.MaxLength = 45;
            this.DirecionClienteFatu.Name = "DirecionClienteFatu";
            this.DirecionClienteFatu.Size = new System.Drawing.Size(313, 20);
            this.DirecionClienteFatu.TabIndex = 7;
            // 
            // CalleTex
            // 
            this.CalleTex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtNuevaFacturaBindingSource, "Calle", true));
            this.CalleTex.Enabled = false;
            this.CalleTex.Location = new System.Drawing.Point(94, 151);
            this.CalleTex.MaxLength = 24;
            this.CalleTex.Name = "CalleTex";
            this.CalleTex.Size = new System.Drawing.Size(121, 20);
            this.CalleTex.TabIndex = 9;
            // 
            // NumeroCalleTxt
            // 
            this.NumeroCalleTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtNuevaFacturaBindingSource, "NumeroCalle", true));
            this.NumeroCalleTxt.Enabled = false;
            this.NumeroCalleTxt.Location = new System.Drawing.Point(94, 180);
            this.NumeroCalleTxt.MaxLength = 5;
            this.NumeroCalleTxt.Name = "NumeroCalleTxt";
            this.NumeroCalleTxt.Size = new System.Drawing.Size(121, 20);
            this.NumeroCalleTxt.TabIndex = 11;
            // 
            // DniTextBox
            // 
            this.DniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtNuevaFacturaBindingSource, "Dni", true));
            this.DniTextBox.Enabled = false;
            this.DniTextBox.Location = new System.Drawing.Point(423, 37);
            this.DniTextBox.MaxLength = 14;
            this.DniTextBox.Name = "DniTextBox";
            this.DniTextBox.Size = new System.Drawing.Size(233, 20);
            this.DniTextBox.TabIndex = 13;
            this.DniTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.dniTextBox_Validating);
            // 
            // LocalidadTxt
            // 
            this.LocalidadTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtNuevaFacturaBindingSource, "Localidad", true));
            this.LocalidadTxt.Enabled = false;
            this.LocalidadTxt.Location = new System.Drawing.Point(514, 96);
            this.LocalidadTxt.MaxLength = 25;
            this.LocalidadTxt.Name = "LocalidadTxt";
            this.LocalidadTxt.Size = new System.Drawing.Size(257, 20);
            this.LocalidadTxt.TabIndex = 15;
            // 
            // ProvinciaTxt
            // 
            this.ProvinciaTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtNuevaFacturaBindingSource, "Provincia", true));
            this.ProvinciaTxt.DataSource = this.fKDtPaisesDtProvinciasBindingSource;
            this.ProvinciaTxt.DisplayMember = "Provincias";
            this.ProvinciaTxt.Enabled = false;
            this.ProvinciaTxt.FormattingEnabled = true;
            this.ProvinciaTxt.Location = new System.Drawing.Point(514, 122);
            this.ProvinciaTxt.MaxLength = 60;
            this.ProvinciaTxt.Name = "ProvinciaTxt";
            this.ProvinciaTxt.Size = new System.Drawing.Size(257, 21);
            this.ProvinciaTxt.TabIndex = 17;
            this.ProvinciaTxt.Click += new System.EventHandler(this.ProvinciaComboBox_Click);
            // 
            // fKDtPaisesDtProvinciasBindingSource
            // 
            this.fKDtPaisesDtProvinciasBindingSource.DataMember = "FK_DtPaises_DtProvincias";
            this.fKDtPaisesDtProvinciasBindingSource.DataSource = this.dtPaisesBindingSource;
            // 
            // CodigoPostalTxt
            // 
            this.CodigoPostalTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtNuevaFacturaBindingSource, "CodigoPostal", true));
            this.CodigoPostalTxt.Enabled = false;
            this.CodigoPostalTxt.Location = new System.Drawing.Point(764, 37);
            this.CodigoPostalTxt.MaxLength = 30;
            this.CodigoPostalTxt.Name = "CodigoPostalTxt";
            this.CodigoPostalTxt.Size = new System.Drawing.Size(121, 20);
            this.CodigoPostalTxt.TabIndex = 19;
            // 
            // AlmacenTxt
            // 
            this.AlmacenTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtNuevaFacturaBindingSource, "NonbreAlmacen", true));
            this.AlmacenTxt.DataSource = this.dtAlmacenesBindingSource;
            this.AlmacenTxt.DisplayMember = "Almacenes";
            this.AlmacenTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlmacenTxt.Enabled = false;
            this.AlmacenTxt.FormattingEnabled = true;
            this.AlmacenTxt.Location = new System.Drawing.Point(891, 82);
            this.AlmacenTxt.Name = "AlmacenTxt";
            this.AlmacenTxt.Size = new System.Drawing.Size(298, 21);
            this.AlmacenTxt.TabIndex = 21;
            this.AlmacenTxt.Click += new System.EventHandler(this.AlmacenTxt_Click);
            // 
            // dtAlmacenesBindingSource
            // 
            this.dtAlmacenesBindingSource.DataMember = "FK_DtConfiguracionPrincipal_DtAlmacenes";
            this.dtAlmacenesBindingSource.DataSource = this.dtConfiguracionPrincipalBindingSource;
            // 
            // dtConfiguracionPrincipalDtAlmacenesBindingSource
            // 
            this.dtConfiguracionPrincipalDtAlmacenesBindingSource.DataMember = "FK_DtConfiguracionPrincipal_DtAlmacenes";
            this.dtConfiguracionPrincipalDtAlmacenesBindingSource.DataSource = this.dtConfiguracionPrincipalBindingSource;
            // 
            // tabControl1Factura
            // 
            this.tabControl1Factura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1Factura.Controls.Add(this.tabPage1Factura);
            this.tabControl1Factura.Controls.Add(this.tabPage2Factura);
            this.tabControl1Factura.Controls.Add(this.tabPage4Factura);
            this.tabControl1Factura.Controls.Add(this.tabPage3Factura);
            this.tabControl1Factura.Location = new System.Drawing.Point(0, 278);
            this.tabControl1Factura.Name = "tabControl1Factura";
            this.tabControl1Factura.SelectedIndex = 0;
            this.tabControl1Factura.Size = new System.Drawing.Size(1291, 245);
            this.tabControl1Factura.TabIndex = 29;
            this.tabControl1Factura.SelectedIndexChanged += new System.EventHandler(this.TabControl1Factura_SelectedIndexChanged);
            // 
            // tabPage2Factura
            // 
            this.tabPage2Factura.AutoScroll = true;
            this.tabPage2Factura.Controls.Add(this.dtDetallesFacturaDataGridView);
            this.tabPage2Factura.Location = new System.Drawing.Point(4, 22);
            this.tabPage2Factura.Name = "tabPage2Factura";
            this.tabPage2Factura.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2Factura.Size = new System.Drawing.Size(1283, 219);
            this.tabPage2Factura.TabIndex = 1;
            this.tabPage2Factura.Text = "Lineas";
            this.tabPage2Factura.UseVisualStyleBackColor = true;
            // 
            // dtDetallesFacturaDataGridView
            // 
            this.dtDetallesFacturaDataGridView.AllowUserToResizeRows = false;
            this.dtDetallesFacturaDataGridView.AutoGenerateColumns = false;
            this.dtDetallesFacturaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtDetallesFacturaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtDetallesFacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDetallesFacturaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referenciaDetalleDataGridViewTextBoxColumn,
            this.BusquedaArticulo,
            this.cantidadDetalleDataGridViewTextBoxColumn,
            this.descripccionDetalleDataGridViewTextBoxColumn,
            this.precioDetalleDataGridViewTextBoxColumn,
            this.descuentoDetalleDataGridViewTextBoxColumn,
            this.ivaDetalleDataGridViewTextBoxColumn,
            this.ImporteDetalle});
            this.dtDetallesFacturaDataGridView.DataSource = this.dtDetallesFacturaBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.NullValue = null;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtDetallesFacturaDataGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.dtDetallesFacturaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtDetallesFacturaDataGridView.Location = new System.Drawing.Point(3, 3);
            this.dtDetallesFacturaDataGridView.Name = "dtDetallesFacturaDataGridView";
            this.dtDetallesFacturaDataGridView.ReadOnly = true;
            this.dtDetallesFacturaDataGridView.RowHeadersVisible = false;
            this.dtDetallesFacturaDataGridView.RowHeadersWidth = 30;
            this.dtDetallesFacturaDataGridView.Size = new System.Drawing.Size(1277, 213);
            this.dtDetallesFacturaDataGridView.TabIndex = 0;
            this.dtDetallesFacturaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtDetallesFacturaDataGridView_CellClick);
            this.dtDetallesFacturaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDetallesFacturaDataGridView_CellContentClick);
            this.dtDetallesFacturaDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtDetallesFacturaDataGridView_CellEndEdit);
            this.dtDetallesFacturaDataGridView.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtDetallesFacturaDataGridView_CellLeave);
            this.dtDetallesFacturaDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DtDetallesFacturaDataGridView_DataError);
            this.dtDetallesFacturaDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DtDetallesFacturaDataGridView_EditingControlShowing);
            this.dtDetallesFacturaDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DtDetallesFacturaDataGridView_KeyDown);
            this.dtDetallesFacturaDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DtDetallesFacturaDataGridView_KeyPress);
            this.dtDetallesFacturaDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtDetallesFacturaDataGridView_MouseClick);
            this.dtDetallesFacturaDataGridView.MouseEnter += new System.EventHandler(this.DtDetallesFacturaDataGridView_MouseEnter);
            this.dtDetallesFacturaDataGridView.Validating += new System.ComponentModel.CancelEventHandler(this.dtDetallesFacturaDataGridView_Validating);
            this.dtDetallesFacturaDataGridView.Validated += new System.EventHandler(this.dtDetallesFacturaDataGridView_Validated);
            // 
            // referenciaDetalleDataGridViewTextBoxColumn
            // 
            this.referenciaDetalleDataGridViewTextBoxColumn.DataPropertyName = "ReferenciaDetalle";
            this.referenciaDetalleDataGridViewTextBoxColumn.HeaderText = "Referencia";
            this.referenciaDetalleDataGridViewTextBoxColumn.Name = "referenciaDetalleDataGridViewTextBoxColumn";
            this.referenciaDetalleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BusquedaArticulo
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BusquedaArticulo.DefaultCellStyle = dataGridViewCellStyle6;
            this.BusquedaArticulo.FillWeight = 34.1035F;
            this.BusquedaArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BusquedaArticulo.HeaderText = "";
            this.BusquedaArticulo.Name = "BusquedaArticulo";
            this.BusquedaArticulo.ReadOnly = true;
            this.BusquedaArticulo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cantidadDetalleDataGridViewTextBoxColumn
            // 
            this.cantidadDetalleDataGridViewTextBoxColumn.DataPropertyName = "CantidadDetalle";
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.cantidadDetalleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.cantidadDetalleDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDetalleDataGridViewTextBoxColumn.Name = "cantidadDetalleDataGridViewTextBoxColumn";
            this.cantidadDetalleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripccionDetalleDataGridViewTextBoxColumn
            // 
            this.descripccionDetalleDataGridViewTextBoxColumn.DataPropertyName = "DescripccionDetalle";
            this.descripccionDetalleDataGridViewTextBoxColumn.HeaderText = "Descripccion";
            this.descripccionDetalleDataGridViewTextBoxColumn.Name = "descripccionDetalleDataGridViewTextBoxColumn";
            this.descripccionDetalleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDetalleDataGridViewTextBoxColumn
            // 
            this.precioDetalleDataGridViewTextBoxColumn.DataPropertyName = "PrecioDetalle";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.precioDetalleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.precioDetalleDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDetalleDataGridViewTextBoxColumn.Name = "precioDetalleDataGridViewTextBoxColumn";
            this.precioDetalleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descuentoDetalleDataGridViewTextBoxColumn
            // 
            this.descuentoDetalleDataGridViewTextBoxColumn.DataPropertyName = "DescuentoDetalle";
            dataGridViewCellStyle9.Format = "P0";
            this.descuentoDetalleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.descuentoDetalleDataGridViewTextBoxColumn.HeaderText = "Descuento";
            this.descuentoDetalleDataGridViewTextBoxColumn.Name = "descuentoDetalleDataGridViewTextBoxColumn";
            this.descuentoDetalleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ivaDetalleDataGridViewTextBoxColumn
            // 
            this.ivaDetalleDataGridViewTextBoxColumn.DataPropertyName = "IvaDetalle";
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = null;
            this.ivaDetalleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.ivaDetalleDataGridViewTextBoxColumn.HeaderText = "Iva";
            this.ivaDetalleDataGridViewTextBoxColumn.Name = "ivaDetalleDataGridViewTextBoxColumn";
            this.ivaDetalleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ImporteDetalle
            // 
            this.ImporteDetalle.DataPropertyName = "ImporteDetalle";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = null;
            this.ImporteDetalle.DefaultCellStyle = dataGridViewCellStyle11;
            this.ImporteDetalle.FillWeight = 102.3105F;
            this.ImporteDetalle.HeaderText = "Importe";
            this.ImporteDetalle.Name = "ImporteDetalle";
            this.ImporteDetalle.ReadOnly = true;
            this.ImporteDetalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dtDetallesFacturaBindingSource
            // 
            this.dtDetallesFacturaBindingSource.DataMember = "DtNuevaFactura_DtDetallesFactura";
            this.dtDetallesFacturaBindingSource.DataSource = this.dtNuevaFacturaBindingSource;
            // 
            // tabPage4Factura
            // 
            this.tabPage4Factura.Controls.Add(this.dtDetallesFacturaDataGridView2);
            this.tabPage4Factura.Location = new System.Drawing.Point(4, 22);
            this.tabPage4Factura.Name = "tabPage4Factura";
            this.tabPage4Factura.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4Factura.Size = new System.Drawing.Size(1283, 219);
            this.tabPage4Factura.TabIndex = 3;
            this.tabPage4Factura.Text = "Lineas ( 2 )";
            this.tabPage4Factura.UseVisualStyleBackColor = true;
            // 
            // dtDetallesFacturaDataGridView2
            // 
            this.dtDetallesFacturaDataGridView2.AllowUserToResizeRows = false;
            this.dtDetallesFacturaDataGridView2.AutoGenerateColumns = false;
            this.dtDetallesFacturaDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtDetallesFacturaDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dtDetallesFacturaDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDetallesFacturaDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referenciaDetalleDataGridViewTextBoxColumn1,
            this.dataGridViewButtonColumn1,
            this.cantidadDetalleDataGridViewTextBoxColumn1,
            this.descripccionDetalleDataGridViewTextBoxColumn1,
            this.precioDetalleDataGridViewTextBoxColumn1,
            this.descuentoDetalleDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn27});
            this.dtDetallesFacturaDataGridView2.DataSource = this.dtDetallesFactura2BindingSource;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtDetallesFacturaDataGridView2.DefaultCellStyle = dataGridViewCellStyle19;
            this.dtDetallesFacturaDataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtDetallesFacturaDataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dtDetallesFacturaDataGridView2.Name = "dtDetallesFacturaDataGridView2";
            this.dtDetallesFacturaDataGridView2.ReadOnly = true;
            this.dtDetallesFacturaDataGridView2.RowHeadersVisible = false;
            this.dtDetallesFacturaDataGridView2.RowHeadersWidth = 30;
            this.dtDetallesFacturaDataGridView2.Size = new System.Drawing.Size(1277, 213);
            this.dtDetallesFacturaDataGridView2.TabIndex = 1;
            this.dtDetallesFacturaDataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtDetallesFacturaDataGridView2_CellClick);
            this.dtDetallesFacturaDataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtDetallesFacturaDataGridView2_CellEndEdit);
            this.dtDetallesFacturaDataGridView2.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DtDetallesFacturaDataGridView2_DataError);
            this.dtDetallesFacturaDataGridView2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DtDetallesFacturaDataGridView2_EditingControlShowing);
            this.dtDetallesFacturaDataGridView2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DtDetallesFacturaDataGridView2_KeyPress);
            this.dtDetallesFacturaDataGridView2.Validated += new System.EventHandler(this.dtDetallesFacturaDataGridView2_Validated);
            // 
            // referenciaDetalleDataGridViewTextBoxColumn1
            // 
            this.referenciaDetalleDataGridViewTextBoxColumn1.DataPropertyName = "ReferenciaDetalle";
            this.referenciaDetalleDataGridViewTextBoxColumn1.FillWeight = 120F;
            this.referenciaDetalleDataGridViewTextBoxColumn1.HeaderText = "Referencia";
            this.referenciaDetalleDataGridViewTextBoxColumn1.Name = "referenciaDetalleDataGridViewTextBoxColumn1";
            this.referenciaDetalleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewButtonColumn1.FillWeight = 50F;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cantidadDetalleDataGridViewTextBoxColumn1
            // 
            this.cantidadDetalleDataGridViewTextBoxColumn1.DataPropertyName = "CantidadDetalle";
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = null;
            this.cantidadDetalleDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle15;
            this.cantidadDetalleDataGridViewTextBoxColumn1.HeaderText = "Cantidad";
            this.cantidadDetalleDataGridViewTextBoxColumn1.Name = "cantidadDetalleDataGridViewTextBoxColumn1";
            this.cantidadDetalleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descripccionDetalleDataGridViewTextBoxColumn1
            // 
            this.descripccionDetalleDataGridViewTextBoxColumn1.DataPropertyName = "DescripccionDetalle";
            this.descripccionDetalleDataGridViewTextBoxColumn1.FillWeight = 250F;
            this.descripccionDetalleDataGridViewTextBoxColumn1.HeaderText = "Descripccion";
            this.descripccionDetalleDataGridViewTextBoxColumn1.Name = "descripccionDetalleDataGridViewTextBoxColumn1";
            this.descripccionDetalleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // precioDetalleDataGridViewTextBoxColumn1
            // 
            this.precioDetalleDataGridViewTextBoxColumn1.DataPropertyName = "PrecioDetalle";
            dataGridViewCellStyle16.Format = "C2";
            dataGridViewCellStyle16.NullValue = null;
            this.precioDetalleDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle16;
            this.precioDetalleDataGridViewTextBoxColumn1.HeaderText = "Precio";
            this.precioDetalleDataGridViewTextBoxColumn1.Name = "precioDetalleDataGridViewTextBoxColumn1";
            this.precioDetalleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descuentoDetalleDataGridViewTextBoxColumn1
            // 
            this.descuentoDetalleDataGridViewTextBoxColumn1.DataPropertyName = "DescuentoDetalle";
            dataGridViewCellStyle17.Format = "PO";
            this.descuentoDetalleDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle17;
            this.descuentoDetalleDataGridViewTextBoxColumn1.HeaderText = "Descuento";
            this.descuentoDetalleDataGridViewTextBoxColumn1.Name = "descuentoDetalleDataGridViewTextBoxColumn1";
            this.descuentoDetalleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "ImporteDetalle";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "C2";
            dataGridViewCellStyle18.NullValue = null;
            this.dataGridViewTextBoxColumn27.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewTextBoxColumn27.FillWeight = 140F;
            this.dataGridViewTextBoxColumn27.HeaderText = "Importe";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dtDetallesFactura2BindingSource
            // 
            this.dtDetallesFactura2BindingSource.DataMember = "DtNuevaFactura_DtDetallesFactura2";
            this.dtDetallesFactura2BindingSource.DataSource = this.dtNuevaFacturaBindingSource;
            // 
            // tabPage3Factura
            // 
            this.tabPage3Factura.AutoScroll = true;
            this.tabPage3Factura.Controls.Add(nombreEmpresaReguistroLabel);
            this.tabPage3Factura.Controls.Add(this.CheckDescuentos);
            this.tabPage3Factura.Controls.Add(this.IdDescuento);
            this.tabPage3Factura.Controls.Add(this.panel2);
            this.tabPage3Factura.Controls.Add(this.imagenEmpresaPicture2);
            this.tabPage3Factura.Controls.Add(idTarifaLabel);
            this.tabPage3Factura.Controls.Add(tarifaTipoLabel1);
            this.tabPage3Factura.Controls.Add(this.TipoTarifaFactu);
            this.tabPage3Factura.Location = new System.Drawing.Point(4, 22);
            this.tabPage3Factura.Name = "tabPage3Factura";
            this.tabPage3Factura.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3Factura.Size = new System.Drawing.Size(1283, 219);
            this.tabPage3Factura.TabIndex = 2;
            this.tabPage3Factura.Text = "Configuracion";
            this.tabPage3Factura.UseVisualStyleBackColor = true;
            // 
            // CheckDescuentos
            // 
            this.CheckDescuentos.AutoCheck = false;
            this.CheckDescuentos.AutoSize = true;
            this.CheckDescuentos.Location = new System.Drawing.Point(71, 91);
            this.CheckDescuentos.Name = "CheckDescuentos";
            this.CheckDescuentos.Size = new System.Drawing.Size(109, 17);
            this.CheckDescuentos.TabIndex = 71;
            this.CheckDescuentos.Text = "Añadiendo Precio";
            this.CheckDescuentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckDescuentos.UseVisualStyleBackColor = true;
            this.CheckDescuentos.Click += new System.EventHandler(this.CheckDescuentos_Click);
            // 
            // IdDescuento
            // 
            this.IdDescuento.AutoSize = true;
            this.IdDescuento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtTarifaTipoBindingSource, "Id", true));
            this.IdDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IdDescuento.Location = new System.Drawing.Point(71, 28);
            this.IdDescuento.Name = "IdDescuento";
            this.IdDescuento.Size = new System.Drawing.Size(13, 13);
            this.IdDescuento.TabIndex = 70;
            this.IdDescuento.Text = "0";
            // 
            // dtTarifaTipoBindingSource
            // 
            this.dtTarifaTipoBindingSource.DataMember = "DtTarifaTipo";
            this.dtTarifaTipoBindingSource.DataSource = this.dsCONFIGURACCION;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.NumTotales);
            this.panel2.Controls.Add(label8);
            this.panel2.Controls.Add(this.Numimporte);
            this.panel2.Controls.Add(label7);
            this.panel2.Controls.Add(this.NumDescuento);
            this.panel2.Controls.Add(label6);
            this.panel2.Controls.Add(this.NumPrecio);
            this.panel2.Controls.Add(label5);
            this.panel2.Location = new System.Drawing.Point(350, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 118);
            this.panel2.TabIndex = 69;
            // 
            // NumTotales
            // 
            this.NumTotales.Location = new System.Drawing.Point(99, 93);
            this.NumTotales.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumTotales.Name = "NumTotales";
            this.NumTotales.Size = new System.Drawing.Size(54, 20);
            this.NumTotales.TabIndex = 52;
            this.NumTotales.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumTotales.ValueChanged += new System.EventHandler(this.NumTotales_ValueChanged);
            // 
            // Numimporte
            // 
            this.Numimporte.Location = new System.Drawing.Point(99, 67);
            this.Numimporte.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Numimporte.Name = "Numimporte";
            this.Numimporte.Size = new System.Drawing.Size(54, 20);
            this.Numimporte.TabIndex = 50;
            this.Numimporte.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Numimporte.ValueChanged += new System.EventHandler(this.Numimporte_ValueChanged);
            // 
            // NumDescuento
            // 
            this.NumDescuento.Location = new System.Drawing.Point(99, 43);
            this.NumDescuento.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumDescuento.Name = "NumDescuento";
            this.NumDescuento.Size = new System.Drawing.Size(54, 20);
            this.NumDescuento.TabIndex = 48;
            this.NumDescuento.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumDescuento.ValueChanged += new System.EventHandler(this.NumDescuento_ValueChanged);
            // 
            // NumPrecio
            // 
            this.NumPrecio.Location = new System.Drawing.Point(99, 17);
            this.NumPrecio.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumPrecio.Name = "NumPrecio";
            this.NumPrecio.Size = new System.Drawing.Size(54, 20);
            this.NumPrecio.TabIndex = 46;
            this.NumPrecio.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumPrecio.ValueChanged += new System.EventHandler(this.NumPrecio_ValueChanged);
            // 
            // imagenEmpresaPicture2
            // 
            this.imagenEmpresaPicture2.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.dtConfiguracionPrincipalBindingSource, "ImagenEmpresa", true));
            this.imagenEmpresaPicture2.Location = new System.Drawing.Point(935, 9);
            this.imagenEmpresaPicture2.Name = "imagenEmpresaPicture2";
            this.imagenEmpresaPicture2.Size = new System.Drawing.Size(325, 150);
            this.imagenEmpresaPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenEmpresaPicture2.TabIndex = 68;
            this.imagenEmpresaPicture2.TabStop = false;
            // 
            // TipoTarifaFactu
            // 
            this.TipoTarifaFactu.DataSource = this.dtConfiDtTarifaTipoBindingSource;
            this.TipoTarifaFactu.DisplayMember = "TarifaTipo";
            this.TipoTarifaFactu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoTarifaFactu.FormattingEnabled = true;
            this.TipoTarifaFactu.Location = new System.Drawing.Point(71, 52);
            this.TipoTarifaFactu.Name = "TipoTarifaFactu";
            this.TipoTarifaFactu.Size = new System.Drawing.Size(246, 21);
            this.TipoTarifaFactu.TabIndex = 9;
            this.TipoTarifaFactu.SelectedIndexChanged += new System.EventHandler(this.TarifaTipoComboBox_SelectedIndexChanged);
            // 
            // dtConfiDtTarifaTipoBindingSource
            // 
            this.dtConfiDtTarifaTipoBindingSource.DataMember = "FK_DtConfiguracionPrincipal_DtTarifaTipo";
            this.dtConfiDtTarifaTipoBindingSource.DataSource = this.dtConfiguracionPrincipalBindingSource;
            // 
            // dtArticulosBindingSource
            // 
            this.dtArticulosBindingSource.DataMember = "DtArticulos";
            this.dtArticulosBindingSource.DataSource = this.articulos;
            // 
            // articulos
            // 
            this.articulos.DataSetName = "Articulos";
            this.articulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelBotones
            // 
            this.panelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelBotones.BackColor = System.Drawing.Color.Transparent;
            this.panelBotones.Controls.Add(this.BtnSalirFactura);
            this.panelBotones.Controls.Add(this.BtnImprimirFactura);
            this.panelBotones.Controls.Add(this.BtnEnviarMailFactura);
            this.panelBotones.Controls.Add(this.BtnEliminarFactura);
            this.panelBotones.Controls.Add(this.BtnBuscarFactura);
            this.panelBotones.Controls.Add(this.BtnNuevoFactura);
            this.panelBotones.Controls.Add(this.BtnModificarFactura);
            this.panelBotones.Location = new System.Drawing.Point(12, 609);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(547, 63);
            this.panelBotones.TabIndex = 30;
            this.panelBotones.Tag = "Nuevo";
            // 
            // BtnSalirFactura
            // 
            this.BtnSalirFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSalirFactura.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalirFactura.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalirFactura.FlatAppearance.BorderSize = 0;
            this.BtnSalirFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnSalirFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnSalirFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalirFactura.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirFactura.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_door_5_32;
            this.BtnSalirFactura.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalirFactura.Location = new System.Drawing.Point(458, 0);
            this.BtnSalirFactura.Name = "BtnSalirFactura";
            this.BtnSalirFactura.Size = new System.Drawing.Size(77, 63);
            this.BtnSalirFactura.TabIndex = 12;
            this.BtnSalirFactura.Text = "Salir";
            this.BtnSalirFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalirFactura.UseVisualStyleBackColor = false;
            this.BtnSalirFactura.Click += new System.EventHandler(this.BtnSalirFactura_Click);
            // 
            // BtnImprimirFactura
            // 
            this.BtnImprimirFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnImprimirFactura.BackColor = System.Drawing.Color.Transparent;
            this.BtnImprimirFactura.FlatAppearance.BorderSize = 0;
            this.BtnImprimirFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnImprimirFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnImprimirFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimirFactura.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimirFactura.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_printer_5_32;
            this.BtnImprimirFactura.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnImprimirFactura.Location = new System.Drawing.Point(311, 0);
            this.BtnImprimirFactura.Name = "BtnImprimirFactura";
            this.BtnImprimirFactura.Size = new System.Drawing.Size(77, 63);
            this.BtnImprimirFactura.TabIndex = 11;
            this.BtnImprimirFactura.Text = "Imprimir";
            this.BtnImprimirFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnImprimirFactura.UseVisualStyleBackColor = false;
            this.BtnImprimirFactura.Click += new System.EventHandler(this.BtnImprimirFactura_Click);
            // 
            // BtnEnviarMailFactura
            // 
            this.BtnEnviarMailFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEnviarMailFactura.BackColor = System.Drawing.Color.Transparent;
            this.BtnEnviarMailFactura.FlatAppearance.BorderSize = 0;
            this.BtnEnviarMailFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnEnviarMailFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnEnviarMailFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnviarMailFactura.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviarMailFactura.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_email_9_32;
            this.BtnEnviarMailFactura.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEnviarMailFactura.Location = new System.Drawing.Point(388, 0);
            this.BtnEnviarMailFactura.Name = "BtnEnviarMailFactura";
            this.BtnEnviarMailFactura.Size = new System.Drawing.Size(77, 63);
            this.BtnEnviarMailFactura.TabIndex = 10;
            this.BtnEnviarMailFactura.Text = "Email";
            this.BtnEnviarMailFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEnviarMailFactura.UseVisualStyleBackColor = false;
            this.BtnEnviarMailFactura.Click += new System.EventHandler(this.BtnEnviarMailFactura_Click);
            // 
            // BtnEliminarFactura
            // 
            this.BtnEliminarFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEliminarFactura.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarFactura.FlatAppearance.BorderSize = 0;
            this.BtnEliminarFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnEliminarFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnEliminarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarFactura.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarFactura.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_trash_can_17_32;
            this.BtnEliminarFactura.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminarFactura.Location = new System.Drawing.Point(234, 0);
            this.BtnEliminarFactura.Name = "BtnEliminarFactura";
            this.BtnEliminarFactura.Size = new System.Drawing.Size(77, 63);
            this.BtnEliminarFactura.TabIndex = 9;
            this.BtnEliminarFactura.Text = "Eliminar";
            this.BtnEliminarFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminarFactura.UseVisualStyleBackColor = false;
            this.BtnEliminarFactura.Click += new System.EventHandler(this.BtnEliminarFactura_Click);
            // 
            // BtnBuscarFactura
            // 
            this.BtnBuscarFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnBuscarFactura.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscarFactura.FlatAppearance.BorderSize = 0;
            this.BtnBuscarFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnBuscarFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnBuscarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarFactura.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarFactura.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_magnifier_4_32;
            this.BtnBuscarFactura.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscarFactura.Location = new System.Drawing.Point(157, 0);
            this.BtnBuscarFactura.Name = "BtnBuscarFactura";
            this.BtnBuscarFactura.Size = new System.Drawing.Size(77, 63);
            this.BtnBuscarFactura.TabIndex = 8;
            this.BtnBuscarFactura.Text = "Buscar";
            this.BtnBuscarFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscarFactura.UseVisualStyleBackColor = false;
            this.BtnBuscarFactura.Click += new System.EventHandler(this.BtnBuscarFactura_Click);
            // 
            // BtnNuevoFactura
            // 
            this.BtnNuevoFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevoFactura.BackColor = System.Drawing.Color.Transparent;
            this.BtnNuevoFactura.FlatAppearance.BorderSize = 0;
            this.BtnNuevoFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnNuevoFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnNuevoFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoFactura.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoFactura.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_file_14_32;
            this.BtnNuevoFactura.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevoFactura.Location = new System.Drawing.Point(3, 0);
            this.BtnNuevoFactura.Name = "BtnNuevoFactura";
            this.BtnNuevoFactura.Size = new System.Drawing.Size(77, 63);
            this.BtnNuevoFactura.TabIndex = 6;
            this.BtnNuevoFactura.Text = "Nuevo";
            this.BtnNuevoFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNuevoFactura.UseVisualStyleBackColor = false;
            this.BtnNuevoFactura.Click += new System.EventHandler(this.BtnNuevoFactura_Click);
            // 
            // BtnModificarFactura
            // 
            this.BtnModificarFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnModificarFactura.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificarFactura.FlatAppearance.BorderSize = 0;
            this.BtnModificarFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnModificarFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnModificarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarFactura.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarFactura.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_pen_8_32;
            this.BtnModificarFactura.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnModificarFactura.Location = new System.Drawing.Point(80, 0);
            this.BtnModificarFactura.Name = "BtnModificarFactura";
            this.BtnModificarFactura.Size = new System.Drawing.Size(77, 63);
            this.BtnModificarFactura.TabIndex = 7;
            this.BtnModificarFactura.Text = "Modificar";
            this.BtnModificarFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificarFactura.UseVisualStyleBackColor = false;
            this.BtnModificarFactura.Click += new System.EventHandler(this.BtnModificarFactura_Click);
            // 
            // BtnCancelarfactura
            // 
            this.BtnCancelarfactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelarfactura.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelarfactura.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelarfactura.Enabled = false;
            this.BtnCancelarfactura.FlatAppearance.BorderSize = 0;
            this.BtnCancelarfactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancelarfactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnCancelarfactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarfactura.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarfactura.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_x_mark_8_24;
            this.BtnCancelarfactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarfactura.Location = new System.Drawing.Point(950, 647);
            this.BtnCancelarfactura.Name = "BtnCancelarfactura";
            this.BtnCancelarfactura.Size = new System.Drawing.Size(89, 42);
            this.BtnCancelarfactura.TabIndex = 32;
            this.BtnCancelarfactura.Text = "Cancelar";
            this.BtnCancelarfactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelarfactura.UseVisualStyleBackColor = false;
            this.BtnCancelarfactura.Click += new System.EventHandler(this.BtnCancelarfactura_Click);
            // 
            // BtnGuardarFactura
            // 
            this.BtnGuardarFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarFactura.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarFactura.Enabled = false;
            this.BtnGuardarFactura.FlatAppearance.BorderSize = 0;
            this.BtnGuardarFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnGuardarFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnGuardarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarFactura.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarFactura.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_check_mark_9_24;
            this.BtnGuardarFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarFactura.Location = new System.Drawing.Point(747, 647);
            this.BtnGuardarFactura.Name = "BtnGuardarFactura";
            this.BtnGuardarFactura.Size = new System.Drawing.Size(89, 42);
            this.BtnGuardarFactura.TabIndex = 31;
            this.BtnGuardarFactura.Text = "Aceptar";
            this.BtnGuardarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarFactura.UseVisualStyleBackColor = false;
            this.BtnGuardarFactura.Click += new System.EventHandler(this.BtnGuardarFactura_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.dtNuevaFacturaBindingSource;
            // 
            // dtNuevaFacturaDataGridView
            // 
            this.dtNuevaFacturaDataGridView.AllowUserToAddRows = false;
            this.dtNuevaFacturaDataGridView.AllowUserToDeleteRows = false;
            this.dtNuevaFacturaDataGridView.AllowUserToOrderColumns = true;
            this.dtNuevaFacturaDataGridView.AllowUserToResizeColumns = false;
            this.dtNuevaFacturaDataGridView.AllowUserToResizeRows = false;
            this.dtNuevaFacturaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtNuevaFacturaDataGridView.AutoGenerateColumns = false;
            this.dtNuevaFacturaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtNuevaFacturaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtNuevaFacturaDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtNuevaFacturaDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtNuevaFacturaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtNuevaFacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtNuevaFacturaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroFacturaDataGridViewTextBoxColumn2,
            this.apodoDataGridViewTextBoxColumn2,
            this.nombreDataGridViewTextBoxColumn2,
            this.direccionDataGridViewTextBoxColumn2,
            this.CobradaFactura,
            this.fechaFacturaDataGridViewTextBoxColumn2});
            this.dtNuevaFacturaDataGridView.DataSource = this.dtNuevaFacturaBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtNuevaFacturaDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtNuevaFacturaDataGridView.EnableHeadersVisualStyles = false;
            this.dtNuevaFacturaDataGridView.Location = new System.Drawing.Point(4, 37);
            this.dtNuevaFacturaDataGridView.Name = "dtNuevaFacturaDataGridView";
            this.dtNuevaFacturaDataGridView.ReadOnly = true;
            this.dtNuevaFacturaDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtNuevaFacturaDataGridView.RowHeadersVisible = false;
            this.dtNuevaFacturaDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dtNuevaFacturaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtNuevaFacturaDataGridView.Size = new System.Drawing.Size(1288, 238);
            this.dtNuevaFacturaDataGridView.TabIndex = 33;
            this.dtNuevaFacturaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtNuevaFacturaDataGridView_CellClick);
            this.dtNuevaFacturaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtNuevaFacturaDataGridView_CellContentClick);
            this.dtNuevaFacturaDataGridView.MouseEnter += new System.EventHandler(this.DtNuevaFacturaDataGridView_MouseEnter);
            // 
            // numeroFacturaDataGridViewTextBoxColumn2
            // 
            this.numeroFacturaDataGridViewTextBoxColumn2.DataPropertyName = "NumeroFactura";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.numeroFacturaDataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.numeroFacturaDataGridViewTextBoxColumn2.FillWeight = 120F;
            this.numeroFacturaDataGridViewTextBoxColumn2.HeaderText = "Numero";
            this.numeroFacturaDataGridViewTextBoxColumn2.Name = "numeroFacturaDataGridViewTextBoxColumn2";
            this.numeroFacturaDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // apodoDataGridViewTextBoxColumn2
            // 
            this.apodoDataGridViewTextBoxColumn2.DataPropertyName = "Apodo";
            this.apodoDataGridViewTextBoxColumn2.FillWeight = 220F;
            this.apodoDataGridViewTextBoxColumn2.HeaderText = "Razon Social";
            this.apodoDataGridViewTextBoxColumn2.Name = "apodoDataGridViewTextBoxColumn2";
            this.apodoDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn2
            // 
            this.nombreDataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn2.FillWeight = 220F;
            this.nombreDataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn2.Name = "nombreDataGridViewTextBoxColumn2";
            this.nombreDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn2
            // 
            this.direccionDataGridViewTextBoxColumn2.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn2.FillWeight = 200F;
            this.direccionDataGridViewTextBoxColumn2.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn2.Name = "direccionDataGridViewTextBoxColumn2";
            this.direccionDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // CobradaFactura
            // 
            this.CobradaFactura.DataPropertyName = "CobradaFactura";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CobradaFactura.DefaultCellStyle = dataGridViewCellStyle3;
            this.CobradaFactura.FillWeight = 80F;
            this.CobradaFactura.HeaderText = "Cobrado";
            this.CobradaFactura.Name = "CobradaFactura";
            this.CobradaFactura.ReadOnly = true;
            // 
            // fechaFacturaDataGridViewTextBoxColumn2
            // 
            this.fechaFacturaDataGridViewTextBoxColumn2.DataPropertyName = "FechaFactura";
            this.fechaFacturaDataGridViewTextBoxColumn2.FillWeight = 60F;
            this.fechaFacturaDataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.fechaFacturaDataGridViewTextBoxColumn2.Name = "fechaFacturaDataGridViewTextBoxColumn2";
            this.fechaFacturaDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // IvaFactuTxt
            // 
            this.IvaFactuTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IvaFactuTxt.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dtConfiguracionPrincipalDtConfiBindingSource, "TipoInpuestoIVA", true));
            this.IvaFactuTxt.Location = new System.Drawing.Point(919, 547);
            this.IvaFactuTxt.Name = "IvaFactuTxt";
            this.IvaFactuTxt.Size = new System.Drawing.Size(120, 20);
            this.IvaFactuTxt.TabIndex = 45;
            this.IvaFactuTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // subTotal
            // 
            this.subTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtNuevaFacturaBindingSource, "SubTotal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0 €", "C3"));
            this.subTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotal.Location = new System.Drawing.Point(67, 0);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(130, 23);
            this.subTotal.TabIndex = 46;
            this.subTotal.Text = "0 €";
            this.subTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // baseIva
            // 
            this.baseIva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baseIva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtNuevaFacturaBindingSource, "BaseIva", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0 €", "C3"));
            this.baseIva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.baseIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseIva.Location = new System.Drawing.Point(67, 32);
            this.baseIva.Name = "baseIva";
            this.baseIva.Size = new System.Drawing.Size(130, 23);
            this.baseIva.TabIndex = 48;
            this.baseIva.Text = "0 €";
            this.baseIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalFactura1
            // 
            this.TotalFactura1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalFactura1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalFactura1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtNuevaFacturaBindingSource, "TotalFactura", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0 €", "C3"));
            this.TotalFactura1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TotalFactura1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFactura1.Location = new System.Drawing.Point(1120, 605);
            this.TotalFactura1.Name = "TotalFactura1";
            this.TotalFactura1.Size = new System.Drawing.Size(167, 23);
            this.TotalFactura1.TabIndex = 50;
            this.TotalFactura1.Text = "0 €";
            this.TotalFactura1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TipoNota
            // 
            this.TipoNota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TipoNota.AutoSize = true;
            this.TipoNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoNota.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TipoNota.Location = new System.Drawing.Point(1201, 637);
            this.TipoNota.Name = "TipoNota";
            this.TipoNota.Size = new System.Drawing.Size(87, 15);
            this.TipoNota.TabIndex = 51;
            this.TipoNota.Text = "Presupuesto";
            this.TipoNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTotales
            // 
            this.panelTotales.Controls.Add(this.subTotal);
            this.panelTotales.Controls.Add(this.baseIva);
            this.panelTotales.Controls.Add(sub);
            this.panelTotales.Controls.Add(label55);
            this.panelTotales.Location = new System.Drawing.Point(1091, 529);
            this.panelTotales.Name = "panelTotales";
            this.panelTotales.Size = new System.Drawing.Size(200, 58);
            this.panelTotales.TabIndex = 54;
            // 
            // TotalFactura2
            // 
            this.TotalFactura2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalFactura2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalFactura2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtNuevaFacturaBindingSource, "TotalFactura2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0 €", "C3"));
            this.TotalFactura2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFactura2.Location = new System.Drawing.Point(1119, 605);
            this.TotalFactura2.Name = "TotalFactura2";
            this.TotalFactura2.Size = new System.Drawing.Size(170, 23);
            this.TotalFactura2.TabIndex = 55;
            this.TotalFactura2.Text = "0 €";
            this.TotalFactura2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TotalFactura2.Visible = false;
            // 
            // dtClientesBindingSource
            // 
            this.dtClientesBindingSource.DataMember = "DtClientes";
            this.dtClientesBindingSource.DataSource = this.dsClientes;
            // 
            // dsClientes
            // 
            this.dsClientes.DataSetName = "DsClientes";
            this.dsClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1319, 712);
            this.Controls.Add(this.TotalFactura2);
            this.Controls.Add(this.panelTotales);
            this.Controls.Add(this.TipoNota);
            this.Controls.Add(this.TotalFactura1);
            this.Controls.Add(Label77);
            this.Controls.Add(this.IvaFactuTxt);
            this.Controls.Add(ttlabel);
            this.Controls.Add(this.dtNuevaFacturaDataGridView);
            this.Controls.Add(this.BtnCancelarfactura);
            this.Controls.Add(this.BtnGuardarFactura);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.tabControl1Factura);
            this.Controls.Add(this.PanelArriba);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFacturar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFACTURAR_FormClosing);
            this.Load += new System.EventHandler(this.FormFACTURAR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtNuevaFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalDtConfiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).EndInit();
            this.PanelArriba.ResumeLayout(false);
            this.PanelArriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiBindingSource)).EndInit();
            this.tabPage1Factura.ResumeLayout(false);
            this.tabPage1Factura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalDtProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtObrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMulti2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDtPaisesDtProvinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlmacenesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalDtAlmacenesBindingSource)).EndInit();
            this.tabControl1Factura.ResumeLayout(false);
            this.tabPage2Factura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtDetallesFacturaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetallesFacturaBindingSource)).EndInit();
            this.tabPage4Factura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtDetallesFacturaDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetallesFactura2BindingSource)).EndInit();
            this.tabPage3Factura.ResumeLayout(false);
            this.tabPage3Factura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarifaTipoBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTotales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numimporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenEmpresaPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiDtTarifaTipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtArticulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulos)).EndInit();
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNuevaFacturaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IvaFactuTxt)).EndInit();
            this.panelTotales.ResumeLayout(false);
            this.panelTotales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelArriba;
        private System.Windows.Forms.TabPage tabPage2Factura;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button BtnSalirFactura;
        private System.Windows.Forms.Button BtnImprimirFactura;
        private System.Windows.Forms.Button BtnEnviarMailFactura;
        private System.Windows.Forms.Button BtnEliminarFactura;
        private System.Windows.Forms.Button BtnBuscarFactura;
        private System.Windows.Forms.Button BtnNuevoFactura;
        private System.Windows.Forms.Button BtnModificarFactura;
        private System.Windows.Forms.Button BtnCancelarfactura;
        public System.Windows.Forms.Button BtnGuardarFactura;
        private System.Windows.Forms.TabPage tabPage3Factura;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox AlmacenTxt;
        private System.Windows.Forms.ComboBox ejerciciosDeAñoComboBox;
        private System.Windows.Forms.BindingSource dtConfiBindingSource;
        private System.Windows.Forms.ComboBox SerieText;
        private System.Windows.Forms.CheckBox cobradaFacturaCheckBox;
        private System.Windows.Forms.MaskedTextBox fechaCobroText;
        private System.Windows.Forms.NumericUpDown IvaFactuTxt;
        public System.Windows.Forms.DataGridView dtDetallesFacturaDataGridView;
        private System.Windows.Forms.TabControl tabControl1Factura;
        private System.Windows.Forms.BindingSource dtTarifaTipoBindingSource;
        private System.Windows.Forms.BindingSource dtConfiDtTarifaTipoBindingSource;
        private System.Windows.Forms.BindingSource dtConfiguracionPrincipalDtConfiBindingSource;
        public System.Windows.Forms.BindingSource dtDetallesFacturaBindingSource;
        public System.Windows.Forms.BindingSource dtNuevaFacturaBindingSource;
        public System.Windows.Forms.DataGridView dtNuevaFacturaDataGridView;
        public System.Windows.Forms.BindingSource dtConfiguracionPrincipalBindingSource;
        private System.Windows.Forms.TabPage tabPage4Factura;
        public System.Windows.Forms.DataGridView dtDetallesFacturaDataGridView2;
        private System.Windows.Forms.Panel panelTotales;
        private System.Windows.Forms.Label TipoNota;
        private System.Windows.Forms.Button BtnBuscarClientesFact;
        public System.Windows.Forms.TabPage tabPage1Factura;
        public System.Windows.Forms.TextBox NombreClienteFatu;
        public System.Windows.Forms.TextBox DirecionClienteFatu;
        public System.Windows.Forms.TextBox CalleTex;
        public System.Windows.Forms.TextBox NumeroCalleTxt;
        public System.Windows.Forms.TextBox RazonSocialFatu;
        public System.Windows.Forms.TextBox LocalidadTxt;
        public System.Windows.Forms.ComboBox ProvinciaTxt;
        public System.Windows.Forms.BindingSource dtDetallesFactura2BindingSource;
        public System.Windows.Forms.TextBox NumeroFactura;
        public System.Windows.Forms.ComboBox PaisFatuTxt;
        public DsCONFIGURACCION dsCONFIGURACCION;
        public System.Windows.Forms.Label subTotal;
        public System.Windows.Forms.Label baseIva;
        public System.Windows.Forms.Label TotalFactura1;
        public System.Windows.Forms.Label TotalFactura2;
        public System.Windows.Forms.TextBox DniTextBox;
        public System.Windows.Forms.TextBox CodigoPostalTxt;
        private DsMultidatos dsMultidatos;
        public System.Windows.Forms.PictureBox imagenEmpresaPicture2;
        public System.Windows.Forms.BindingSource dtArticulosBindingSource;
        private System.Windows.Forms.BindingSource dtInicioMultiBindingSource;
        private System.Windows.Forms.BindingSource dtPaisesBindingSource;
        public Articulos articulos;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DateTimePicker FechaFactura;
        private System.Windows.Forms.Label IdDescuento;
        private System.Windows.Forms.NumericUpDown NumTotales;
        private System.Windows.Forms.NumericUpDown Numimporte;
        public System.Windows.Forms.RadioButton CheckDescuentos;
        public System.Windows.Forms.ComboBox TipoTarifaFactu;
        public System.Windows.Forms.NumericUpDown NumPrecio;
        public System.Windows.Forms.NumericUpDown NumDescuento;
        private System.Windows.Forms.BindingSource dtObrasBindingSource;
        private DsMulti2 dsMulti2;
        public System.Windows.Forms.ComboBox obrasComboBox;
        private System.Windows.Forms.ComboBox ProveedorTxt;
        private System.Windows.Forms.BindingSource dtProveedoresBindingSource;
        private System.Windows.Forms.BindingSource dtConfiguracionPrincipalDtProveedoresBindingSource;
        private System.Windows.Forms.BindingSource dtConfiguracionPrincipalDtAlmacenesBindingSource;
        private System.Windows.Forms.BindingSource dtClientesBindingSource;
        private System.Windows.Forms.Label EnlaceFactu;
        public System.Windows.Forms.ComboBox EmpresaPrincipal;
        private System.Windows.Forms.BindingSource dtAlmacenesBindingSource;
        private System.Windows.Forms.BindingSource fKDtPaisesDtProvinciasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroFacturaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn apodoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CobradaFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFacturaDataGridViewTextBoxColumn2;
        private DsFacturas dsFacturas;
        private DsClientes dsClientes;
        private System.Windows.Forms.Label Id_Empresa;
        private System.Windows.Forms.Button BtnBuscarProvi;
        private System.Windows.Forms.Button BtnBuscarPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaDetalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn BusquedaArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDetalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripccionDetalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDetalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoDetalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivaDetalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaDetalleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDetalleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripccionDetalleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDetalleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoDetalleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
    }
}