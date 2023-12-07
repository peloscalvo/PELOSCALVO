
namespace PELOSCALVO
{
    partial class FormClientes
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
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label apodoClienteLabel;
            System.Windows.Forms.Label nombreClienteLabel;
            System.Windows.Forms.Label direccionClienteLabel;
            System.Windows.Forms.Label telefonoClienteLabel;
            System.Windows.Forms.Label movilClienteLabel;
            System.Windows.Forms.Label correoClienteLabel;
            System.Windows.Forms.Label dniClienteLabel;
            System.Windows.Forms.Label localidadClienteLabel;
            System.Windows.Forms.Label codigoPostalClienteLabel;
            System.Windows.Forms.Label fechaAltaClienteLabel;
            System.Windows.Forms.Label numeroCalleClienteLabel;
            System.Windows.Forms.Label tarifaTipoClienteLabel;
            System.Windows.Forms.Label dniClienteTipoLabel;
            System.Windows.Forms.Label calleClienteLabel;
            System.Windows.Forms.Label apodoClienteLabel1;
            System.Windows.Forms.Label nombreClienteLabel1;
            System.Windows.Forms.Label direccionClienteLabel1;
            System.Windows.Forms.Label paisClienteLabel1;
            System.Windows.Forms.Label provinciaClienteLabel1;
            System.Windows.Forms.Label bANCOOFICILabel;
            System.Windows.Forms.Label bANCOPROVILabel;
            System.Windows.Forms.Label bANCODIRECLabel;
            System.Windows.Forms.Label bANCOLOCALLabel;
            System.Windows.Forms.Label bANCOIBANLabel;
            System.Windows.Forms.Label bANCOCODIGLabel;
            System.Windows.Forms.Label bANCOENTIDLabel;
            System.Windows.Forms.Label bANCOOFIC2Label;
            System.Windows.Forms.Label bANCODCLabel;
            System.Windows.Forms.Label bANCON_CUELabel;
            System.Windows.Forms.Label tIPOCLIENTLabel;
            System.Windows.Forms.Label pORTESLabel;
            System.Windows.Forms.Label nUMEROCUENLabel;
            System.Windows.Forms.Label Label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.dtClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsClientes = new PELOSCALVO.DsClientes();
            this.dtClientesDataGridView = new System.Windows.Forms.DataGridView();
            this.iDCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPODOCLIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRECLIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRECCIONCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAALTACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnAceptarFINALBuscar = new System.Windows.Forms.Button();
            this.apodoClienteComboBox = new System.Windows.Forms.ComboBox();
            this.nombreClienteComboBox = new System.Windows.Forms.ComboBox();
            this.direccionClienteComboBox = new System.Windows.Forms.ComboBox();
            this.BtnBuscarClientes2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1Clientes = new System.Windows.Forms.TabPage();
            this.apodoClienteTextBox = new System.Windows.Forms.TextBox();
            this.nombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.direccionClienteTextBox = new System.Windows.Forms.TextBox();
            this.calleClienteTextBox = new System.Windows.Forms.TextBox();
            this.telefonoClienteTextBox = new System.Windows.Forms.TextBox();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            this.movilClienteTextBox = new System.Windows.Forms.TextBox();
            this.correoClienteTextBox = new System.Windows.Forms.TextBox();
            this.dniClienteTextBox = new System.Windows.Forms.TextBox();
            this.localidadClienteTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2Clientes = new System.Windows.Forms.TabPage();
            this.dESCUENTOCTextBox = new System.Windows.Forms.TextBox();
            this.FechaAltaCliente = new System.Windows.Forms.DateTimePicker();
            this.pORTESComboBox = new System.Windows.Forms.ComboBox();
            this.tIPOCLIENTComboBox = new System.Windows.Forms.ComboBox();
            this.paisClienteComboBox1 = new System.Windows.Forms.ComboBox();
            this.dtPaisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMulti2 = new PELOSCALVO.DsMulti2();
            this.provinciaClienteComboBox1 = new System.Windows.Forms.ComboBox();
            this.dtProvinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dniClienteTipoComboBox = new System.Windows.Forms.ComboBox();
            this.numeroCalleClienteTextBox = new System.Windows.Forms.TextBox();
            this.tarifaTipoClienteComboBox = new System.Windows.Forms.ComboBox();
            this.codigoPostalClienteTextBox = new System.Windows.Forms.TextBox();
            this.tabDatos2 = new System.Windows.Forms.TabPage();
            this.BancoProvincia = new System.Windows.Forms.ComboBox();
            this.panelCuenta = new System.Windows.Forms.Panel();
            this.bANCOIBANTextBox = new System.Windows.Forms.TextBox();
            this.NUMEROCUENTextBox = new System.Windows.Forms.TextBox();
            this.bANCOENTIDTextBox = new System.Windows.Forms.TextBox();
            this.BANCOOFIC2TextBox = new System.Windows.Forms.TextBox();
            this.bANCODCTextBox = new System.Windows.Forms.TextBox();
            this.bANCON_CUETextBox = new System.Windows.Forms.TextBox();
            this.bANCOCODIGTextBox = new System.Windows.Forms.TextBox();
            this.bANCOLOCALTextBox = new System.Windows.Forms.TextBox();
            this.bANCODIRECTextBox = new System.Windows.Forms.TextBox();
            this.bANCOOFICITextBox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtInicioMultiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMultidatos = new PELOSCALVO.DsMultidatos();
            this.BtnGuardarCliente = new System.Windows.Forms.Button();
            this.BtnCancelarCliente = new System.Windows.Forms.Button();
            this.BtnNuevoCliente = new System.Windows.Forms.Button();
            this.BtnModificarCliente = new System.Windows.Forms.Button();
            this.panelBotonesClientes = new System.Windows.Forms.Panel();
            this.BtnImprimirCliente = new System.Windows.Forms.Button();
            this.BtnEnviarMailCliente = new System.Windows.Forms.Button();
            this.BtnEliminarCliente = new System.Windows.Forms.Button();
            this.BtnBuscarCliente = new System.Windows.Forms.Button();
            this.BtnSalirCliente = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dsCONFIGURACCION = new PELOSCALVO.DsCONFIGURACCION();
            this.label4 = new System.Windows.Forms.Label();
            this.ContadorDatosClientes = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            apodoClienteLabel = new System.Windows.Forms.Label();
            nombreClienteLabel = new System.Windows.Forms.Label();
            direccionClienteLabel = new System.Windows.Forms.Label();
            telefonoClienteLabel = new System.Windows.Forms.Label();
            movilClienteLabel = new System.Windows.Forms.Label();
            correoClienteLabel = new System.Windows.Forms.Label();
            dniClienteLabel = new System.Windows.Forms.Label();
            localidadClienteLabel = new System.Windows.Forms.Label();
            codigoPostalClienteLabel = new System.Windows.Forms.Label();
            fechaAltaClienteLabel = new System.Windows.Forms.Label();
            numeroCalleClienteLabel = new System.Windows.Forms.Label();
            tarifaTipoClienteLabel = new System.Windows.Forms.Label();
            dniClienteTipoLabel = new System.Windows.Forms.Label();
            calleClienteLabel = new System.Windows.Forms.Label();
            apodoClienteLabel1 = new System.Windows.Forms.Label();
            nombreClienteLabel1 = new System.Windows.Forms.Label();
            direccionClienteLabel1 = new System.Windows.Forms.Label();
            paisClienteLabel1 = new System.Windows.Forms.Label();
            provinciaClienteLabel1 = new System.Windows.Forms.Label();
            bANCOOFICILabel = new System.Windows.Forms.Label();
            bANCOPROVILabel = new System.Windows.Forms.Label();
            bANCODIRECLabel = new System.Windows.Forms.Label();
            bANCOLOCALLabel = new System.Windows.Forms.Label();
            bANCOIBANLabel = new System.Windows.Forms.Label();
            bANCOCODIGLabel = new System.Windows.Forms.Label();
            bANCOENTIDLabel = new System.Windows.Forms.Label();
            bANCOOFIC2Label = new System.Windows.Forms.Label();
            bANCODCLabel = new System.Windows.Forms.Label();
            bANCON_CUELabel = new System.Windows.Forms.Label();
            tIPOCLIENTLabel = new System.Windows.Forms.Label();
            pORTESLabel = new System.Windows.Forms.Label();
            nUMEROCUENLabel = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1Clientes.SuspendLayout();
            this.tabPage2Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMulti2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProvinciasBindingSource)).BeginInit();
            this.tabDatos2.SuspendLayout();
            this.panelCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).BeginInit();
            this.panelBotonesClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).BeginInit();
            this.SuspendLayout();
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(63, 127);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(19, 13);
            idClienteLabel.TabIndex = 0;
            idClienteLabel.Text = "Id:";
            // 
            // apodoClienteLabel
            // 
            apodoClienteLabel.AutoSize = true;
            apodoClienteLabel.Location = new System.Drawing.Point(20, 26);
            apodoClienteLabel.Name = "apodoClienteLabel";
            apodoClienteLabel.Size = new System.Drawing.Size(76, 13);
            apodoClienteLabel.TabIndex = 2;
            apodoClienteLabel.Text = "Apodo Cliente:";
            // 
            // nombreClienteLabel
            // 
            nombreClienteLabel.AutoSize = true;
            nombreClienteLabel.Location = new System.Drawing.Point(14, 53);
            nombreClienteLabel.Name = "nombreClienteLabel";
            nombreClienteLabel.Size = new System.Drawing.Size(82, 13);
            nombreClienteLabel.TabIndex = 4;
            nombreClienteLabel.Text = "Nombre Cliente:";
            // 
            // direccionClienteLabel
            // 
            direccionClienteLabel.AutoSize = true;
            direccionClienteLabel.Location = new System.Drawing.Point(41, 77);
            direccionClienteLabel.Name = "direccionClienteLabel";
            direccionClienteLabel.Size = new System.Drawing.Size(55, 13);
            direccionClienteLabel.TabIndex = 6;
            direccionClienteLabel.Text = "Direccion:";
            // 
            // telefonoClienteLabel
            // 
            telefonoClienteLabel.AutoSize = true;
            telefonoClienteLabel.Location = new System.Drawing.Point(554, 127);
            telefonoClienteLabel.Name = "telefonoClienteLabel";
            telefonoClienteLabel.Size = new System.Drawing.Size(87, 13);
            telefonoClienteLabel.TabIndex = 8;
            telefonoClienteLabel.Text = "Telefono Cliente:";
            // 
            // movilClienteLabel
            // 
            movilClienteLabel.AutoSize = true;
            movilClienteLabel.Location = new System.Drawing.Point(571, 101);
            movilClienteLabel.Name = "movilClienteLabel";
            movilClienteLabel.Size = new System.Drawing.Size(70, 13);
            movilClienteLabel.TabIndex = 10;
            movilClienteLabel.Text = "Movil Cliente:";
            // 
            // correoClienteLabel
            // 
            correoClienteLabel.AutoSize = true;
            correoClienteLabel.Location = new System.Drawing.Point(280, 98);
            correoClienteLabel.Name = "correoClienteLabel";
            correoClienteLabel.Size = new System.Drawing.Size(76, 13);
            correoClienteLabel.TabIndex = 12;
            correoClienteLabel.Text = "Correo Cliente:";
            // 
            // dniClienteLabel
            // 
            dniClienteLabel.AutoSize = true;
            dniClienteLabel.Location = new System.Drawing.Point(24, 98);
            dniClienteLabel.Name = "dniClienteLabel";
            dniClienteLabel.Size = new System.Drawing.Size(61, 13);
            dniClienteLabel.TabIndex = 14;
            dniClienteLabel.Text = "Dni Cliente:";
            // 
            // localidadClienteLabel
            // 
            localidadClienteLabel.AutoSize = true;
            localidadClienteLabel.Location = new System.Drawing.Point(384, 13);
            localidadClienteLabel.Name = "localidadClienteLabel";
            localidadClienteLabel.Size = new System.Drawing.Size(91, 13);
            localidadClienteLabel.TabIndex = 16;
            localidadClienteLabel.Text = "Localidad Cliente:";
            // 
            // codigoPostalClienteLabel
            // 
            codigoPostalClienteLabel.AutoSize = true;
            codigoPostalClienteLabel.Location = new System.Drawing.Point(8, 74);
            codigoPostalClienteLabel.Name = "codigoPostalClienteLabel";
            codigoPostalClienteLabel.Size = new System.Drawing.Size(75, 13);
            codigoPostalClienteLabel.TabIndex = 28;
            codigoPostalClienteLabel.Text = "Codigo Postal:";
            // 
            // fechaAltaClienteLabel
            // 
            fechaAltaClienteLabel.AutoSize = true;
            fechaAltaClienteLabel.Location = new System.Drawing.Point(331, 71);
            fechaAltaClienteLabel.Name = "fechaAltaClienteLabel";
            fechaAltaClienteLabel.Size = new System.Drawing.Size(96, 13);
            fechaAltaClienteLabel.TabIndex = 32;
            fechaAltaClienteLabel.Text = "Fecha Alta Cliente:";
            // 
            // numeroCalleClienteLabel
            // 
            numeroCalleClienteLabel.AutoSize = true;
            numeroCalleClienteLabel.Location = new System.Drawing.Point(10, 97);
            numeroCalleClienteLabel.Name = "numeroCalleClienteLabel";
            numeroCalleClienteLabel.Size = new System.Drawing.Size(73, 13);
            numeroCalleClienteLabel.TabIndex = 36;
            numeroCalleClienteLabel.Text = "Numero Calle:";
            // 
            // tarifaTipoClienteLabel
            // 
            tarifaTipoClienteLabel.AutoSize = true;
            tarifaTipoClienteLabel.Location = new System.Drawing.Point(409, 44);
            tarifaTipoClienteLabel.Name = "tarifaTipoClienteLabel";
            tarifaTipoClienteLabel.Size = new System.Drawing.Size(61, 13);
            tarifaTipoClienteLabel.TabIndex = 40;
            tarifaTipoClienteLabel.Text = "Tarifa Tipo:";
            // 
            // dniClienteTipoLabel
            // 
            dniClienteTipoLabel.AutoSize = true;
            dniClienteTipoLabel.Location = new System.Drawing.Point(364, 19);
            dniClienteTipoLabel.Name = "dniClienteTipoLabel";
            dniClienteTipoLabel.Size = new System.Drawing.Size(106, 13);
            dniClienteTipoLabel.TabIndex = 42;
            dniClienteTipoLabel.Text = "Tipo De Documento:";
            // 
            // calleClienteLabel
            // 
            calleClienteLabel.AutoSize = true;
            calleClienteLabel.Location = new System.Drawing.Point(442, 40);
            calleClienteLabel.Name = "calleClienteLabel";
            calleClienteLabel.Size = new System.Drawing.Size(33, 13);
            calleClienteLabel.TabIndex = 36;
            calleClienteLabel.Text = "Calle:";
            // 
            // apodoClienteLabel1
            // 
            apodoClienteLabel1.AutoSize = true;
            apodoClienteLabel1.Location = new System.Drawing.Point(16, 16);
            apodoClienteLabel1.Name = "apodoClienteLabel1";
            apodoClienteLabel1.Size = new System.Drawing.Size(73, 13);
            apodoClienteLabel1.TabIndex = 37;
            apodoClienteLabel1.Text = "Razon Social:";
            // 
            // nombreClienteLabel1
            // 
            nombreClienteLabel1.AutoSize = true;
            nombreClienteLabel1.Location = new System.Drawing.Point(35, 39);
            nombreClienteLabel1.Name = "nombreClienteLabel1";
            nombreClienteLabel1.Size = new System.Drawing.Size(47, 13);
            nombreClienteLabel1.TabIndex = 39;
            nombreClienteLabel1.Text = "Nombre:";
            // 
            // direccionClienteLabel1
            // 
            direccionClienteLabel1.AutoSize = true;
            direccionClienteLabel1.Location = new System.Drawing.Point(34, 65);
            direccionClienteLabel1.Name = "direccionClienteLabel1";
            direccionClienteLabel1.Size = new System.Drawing.Size(55, 13);
            direccionClienteLabel1.TabIndex = 41;
            direccionClienteLabel1.Text = "Direccion:";
            // 
            // paisClienteLabel1
            // 
            paisClienteLabel1.AutoSize = true;
            paisClienteLabel1.Location = new System.Drawing.Point(53, 46);
            paisClienteLabel1.Name = "paisClienteLabel1";
            paisClienteLabel1.Size = new System.Drawing.Size(30, 13);
            paisClienteLabel1.TabIndex = 46;
            paisClienteLabel1.Text = "Pais:";
            // 
            // provinciaClienteLabel1
            // 
            provinciaClienteLabel1.AutoSize = true;
            provinciaClienteLabel1.Location = new System.Drawing.Point(29, 19);
            provinciaClienteLabel1.Name = "provinciaClienteLabel1";
            provinciaClienteLabel1.Size = new System.Drawing.Size(54, 13);
            provinciaClienteLabel1.TabIndex = 45;
            provinciaClienteLabel1.Text = "Provincia:";
            // 
            // bANCOOFICILabel
            // 
            bANCOOFICILabel.AutoSize = true;
            bANCOOFICILabel.Location = new System.Drawing.Point(725, 6);
            bANCOOFICILabel.Name = "bANCOOFICILabel";
            bANCOOFICILabel.Size = new System.Drawing.Size(49, 13);
            bANCOOFICILabel.TabIndex = 0;
            bANCOOFICILabel.Text = "OFICINA";
            // 
            // bANCOPROVILabel
            // 
            bANCOPROVILabel.AutoSize = true;
            bANCOPROVILabel.Location = new System.Drawing.Point(517, 48);
            bANCOPROVILabel.Name = "bANCOPROVILabel";
            bANCOPROVILabel.Size = new System.Drawing.Size(65, 13);
            bANCOPROVILabel.TabIndex = 2;
            bANCOPROVILabel.Text = "PROVINCIA";
            // 
            // bANCODIRECLabel
            // 
            bANCODIRECLabel.AutoSize = true;
            bANCODIRECLabel.Location = new System.Drawing.Point(133, 48);
            bANCODIRECLabel.Name = "bANCODIRECLabel";
            bANCODIRECLabel.Size = new System.Drawing.Size(66, 13);
            bANCODIRECLabel.TabIndex = 4;
            bANCODIRECLabel.Text = "DIRECCION";
            // 
            // bANCOLOCALLabel
            // 
            bANCOLOCALLabel.AutoSize = true;
            bANCOLOCALLabel.Location = new System.Drawing.Point(886, 48);
            bANCOLOCALLabel.Name = "bANCOLOCALLabel";
            bANCOLOCALLabel.Size = new System.Drawing.Size(41, 13);
            bANCOLOCALLabel.TabIndex = 6;
            bANCOLOCALLabel.Text = "LOCAL";
            // 
            // bANCOIBANLabel
            // 
            bANCOIBANLabel.AutoSize = true;
            bANCOIBANLabel.Location = new System.Drawing.Point(129, 57);
            bANCOIBANLabel.Name = "bANCOIBANLabel";
            bANCOIBANLabel.Size = new System.Drawing.Size(32, 13);
            bANCOIBANLabel.TabIndex = 8;
            bANCOIBANLabel.Text = "IBAN";
            // 
            // bANCOCODIGLabel
            // 
            bANCOCODIGLabel.AutoSize = true;
            bANCOCODIGLabel.Location = new System.Drawing.Point(30, 6);
            bANCOCODIGLabel.Name = "bANCOCODIGLabel";
            bANCOCODIGLabel.Size = new System.Drawing.Size(52, 13);
            bANCOCODIGLabel.TabIndex = 10;
            bANCOCODIGLabel.Text = "CODIGO:";
            // 
            // bANCOENTIDLabel
            // 
            bANCOENTIDLabel.AutoSize = true;
            bANCOENTIDLabel.Location = new System.Drawing.Point(26, 12);
            bANCOENTIDLabel.Name = "bANCOENTIDLabel";
            bANCOENTIDLabel.Size = new System.Drawing.Size(40, 13);
            bANCOENTIDLabel.TabIndex = 12;
            bANCOENTIDLabel.Text = "ENTID";
            // 
            // bANCOOFIC2Label
            // 
            bANCOOFIC2Label.AutoSize = true;
            bANCOOFIC2Label.Location = new System.Drawing.Point(194, 12);
            bANCOOFIC2Label.Name = "bANCOOFIC2Label";
            bANCOOFIC2Label.Size = new System.Drawing.Size(49, 13);
            bANCOOFIC2Label.TabIndex = 14;
            bANCOOFIC2Label.Text = "OFICINA";
            // 
            // bANCODCLabel
            // 
            bANCODCLabel.AutoSize = true;
            bANCODCLabel.Location = new System.Drawing.Point(480, 12);
            bANCODCLabel.Name = "bANCODCLabel";
            bANCODCLabel.Size = new System.Drawing.Size(22, 13);
            bANCODCLabel.TabIndex = 16;
            bANCODCLabel.Text = "DC";
            // 
            // bANCON_CUELabel
            // 
            bANCON_CUELabel.AutoSize = true;
            bANCON_CUELabel.Location = new System.Drawing.Point(199, 6);
            bANCON_CUELabel.Name = "bANCON_CUELabel";
            bANCON_CUELabel.Size = new System.Drawing.Size(44, 13);
            bANCON_CUELabel.TabIndex = 18;
            bANCON_CUELabel.Text = "BANCO";
            // 
            // tIPOCLIENTLabel
            // 
            tIPOCLIENTLabel.AutoSize = true;
            tIPOCLIENTLabel.Location = new System.Drawing.Point(701, 88);
            tIPOCLIENTLabel.Name = "tIPOCLIENTLabel";
            tIPOCLIENTLabel.Size = new System.Drawing.Size(66, 13);
            tIPOCLIENTLabel.TabIndex = 48;
            tIPOCLIENTLabel.Text = "Tipo Cliente:";
            // 
            // pORTESLabel
            // 
            pORTESLabel.AutoSize = true;
            pORTESLabel.Location = new System.Drawing.Point(727, 40);
            pORTESLabel.Name = "pORTESLabel";
            pORTESLabel.Size = new System.Drawing.Size(40, 13);
            pORTESLabel.TabIndex = 49;
            pORTESLabel.Text = "Portes:";
            // 
            // nUMEROCUENLabel
            // 
            nUMEROCUENLabel.AutoSize = true;
            nUMEROCUENLabel.Location = new System.Drawing.Point(602, 12);
            nUMEROCUENLabel.Name = "nUMEROCUENLabel";
            nUMEROCUENLabel.Size = new System.Drawing.Size(102, 13);
            nUMEROCUENLabel.TabIndex = 49;
            nUMEROCUENLabel.Text = "NUMERO CUENTA";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new System.Drawing.Point(302, 119);
            Label2.Name = "Label2";
            Label2.Size = new System.Drawing.Size(62, 13);
            Label2.TabIndex = 66;
            Label2.Text = "Descuento:";
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
            // dtClientesDataGridView
            // 
            this.dtClientesDataGridView.AllowUserToAddRows = false;
            this.dtClientesDataGridView.AllowUserToOrderColumns = true;
            this.dtClientesDataGridView.AllowUserToResizeRows = false;
            this.dtClientesDataGridView.AutoGenerateColumns = false;
            this.dtClientesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtClientesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkKhaki;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(60)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtClientesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtClientesDataGridView.ColumnHeadersHeight = 30;
            this.dtClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtClientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCLIENTEDataGridViewTextBoxColumn,
            this.aPODOCLIENDataGridViewTextBoxColumn,
            this.nOMBRECLIEDataGridViewTextBoxColumn,
            this.dIRECCIONCDataGridViewTextBoxColumn,
            this.fECHAALTACDataGridViewTextBoxColumn});
            this.dtClientesDataGridView.DataSource = this.dtClientesBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtClientesDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtClientesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtClientesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.dtClientesDataGridView.MultiSelect = false;
            this.dtClientesDataGridView.Name = "dtClientesDataGridView";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(44)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtClientesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtClientesDataGridView.RowHeadersVisible = false;
            this.dtClientesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtClientesDataGridView.Size = new System.Drawing.Size(1118, 245);
            this.dtClientesDataGridView.TabIndex = 1;
            this.dtClientesDataGridView.Click += new System.EventHandler(this.dtClientesDataGridView_Click);
            // 
            // iDCLIENTEDataGridViewTextBoxColumn
            // 
            this.iDCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "IDCLIENTE";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.iDCLIENTEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.iDCLIENTEDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDCLIENTEDataGridViewTextBoxColumn.Name = "iDCLIENTEDataGridViewTextBoxColumn";
            // 
            // aPODOCLIENDataGridViewTextBoxColumn
            // 
            this.aPODOCLIENDataGridViewTextBoxColumn.DataPropertyName = "APODOCLIEN";
            this.aPODOCLIENDataGridViewTextBoxColumn.FillWeight = 260F;
            this.aPODOCLIENDataGridViewTextBoxColumn.HeaderText = "Razon Social";
            this.aPODOCLIENDataGridViewTextBoxColumn.Name = "aPODOCLIENDataGridViewTextBoxColumn";
            // 
            // nOMBRECLIEDataGridViewTextBoxColumn
            // 
            this.nOMBRECLIEDataGridViewTextBoxColumn.DataPropertyName = "NOMBRECLIE";
            this.nOMBRECLIEDataGridViewTextBoxColumn.FillWeight = 300F;
            this.nOMBRECLIEDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nOMBRECLIEDataGridViewTextBoxColumn.Name = "nOMBRECLIEDataGridViewTextBoxColumn";
            // 
            // dIRECCIONCDataGridViewTextBoxColumn
            // 
            this.dIRECCIONCDataGridViewTextBoxColumn.DataPropertyName = "DIRECCIONC";
            this.dIRECCIONCDataGridViewTextBoxColumn.FillWeight = 250F;
            this.dIRECCIONCDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.dIRECCIONCDataGridViewTextBoxColumn.Name = "dIRECCIONCDataGridViewTextBoxColumn";
            // 
            // fECHAALTACDataGridViewTextBoxColumn
            // 
            this.fECHAALTACDataGridViewTextBoxColumn.DataPropertyName = "FECHAALTAC";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.fECHAALTACDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.fECHAALTACDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fECHAALTACDataGridViewTextBoxColumn.Name = "fECHAALTACDataGridViewTextBoxColumn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtClientesDataGridView);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 245);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(610, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 176);
            this.panel2.TabIndex = 38;
            this.panel2.Visible = false;
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.BtnAceptarFINALBuscar);
            this.panel3.Controls.Add(this.apodoClienteComboBox);
            this.panel3.Controls.Add(direccionClienteLabel);
            this.panel3.Controls.Add(this.nombreClienteComboBox);
            this.panel3.Controls.Add(nombreClienteLabel);
            this.panel3.Controls.Add(this.direccionClienteComboBox);
            this.panel3.Controls.Add(apodoClienteLabel);
            this.panel3.Location = new System.Drawing.Point(16, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(447, 148);
            this.panel3.TabIndex = 39;
            // 
            // BtnAceptarFINALBuscar
            // 
            this.BtnAceptarFINALBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnAceptarFINALBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptarFINALBuscar.Location = new System.Drawing.Point(335, 104);
            this.BtnAceptarFINALBuscar.Name = "BtnAceptarFINALBuscar";
            this.BtnAceptarFINALBuscar.Size = new System.Drawing.Size(84, 28);
            this.BtnAceptarFINALBuscar.TabIndex = 14;
            this.BtnAceptarFINALBuscar.Text = "Aceptar";
            this.BtnAceptarFINALBuscar.UseVisualStyleBackColor = false;
            this.BtnAceptarFINALBuscar.Click += new System.EventHandler(this.BtnAceptarFINALBuscar_Click);
            // 
            // apodoClienteComboBox
            // 
            this.apodoClienteComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.apodoClienteComboBox.AllowDrop = true;
            this.apodoClienteComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.apodoClienteComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.apodoClienteComboBox.DataSource = this.dtClientesBindingSource;
            this.apodoClienteComboBox.DisplayMember = "ApodoCliente";
            this.apodoClienteComboBox.FormattingEnabled = true;
            this.apodoClienteComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.apodoClienteComboBox.Location = new System.Drawing.Point(102, 23);
            this.apodoClienteComboBox.MaxLength = 200;
            this.apodoClienteComboBox.Name = "apodoClienteComboBox";
            this.apodoClienteComboBox.Size = new System.Drawing.Size(219, 21);
            this.apodoClienteComboBox.TabIndex = 3;
            // 
            // nombreClienteComboBox
            // 
            this.nombreClienteComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.nombreClienteComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.nombreClienteComboBox.DataSource = this.dtClientesBindingSource;
            this.nombreClienteComboBox.DisplayMember = "NombreCliente";
            this.nombreClienteComboBox.FormattingEnabled = true;
            this.nombreClienteComboBox.Location = new System.Drawing.Point(102, 50);
            this.nombreClienteComboBox.Name = "nombreClienteComboBox";
            this.nombreClienteComboBox.Size = new System.Drawing.Size(335, 21);
            this.nombreClienteComboBox.TabIndex = 5;
            // 
            // direccionClienteComboBox
            // 
            this.direccionClienteComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.direccionClienteComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.direccionClienteComboBox.DataSource = this.dtClientesBindingSource;
            this.direccionClienteComboBox.DisplayMember = "DireccionCliente";
            this.direccionClienteComboBox.FormattingEnabled = true;
            this.direccionClienteComboBox.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.direccionClienteComboBox.Location = new System.Drawing.Point(102, 77);
            this.direccionClienteComboBox.Name = "direccionClienteComboBox";
            this.direccionClienteComboBox.Size = new System.Drawing.Size(335, 21);
            this.direccionClienteComboBox.TabIndex = 7;
            // 
            // BtnBuscarClientes2
            // 
            this.BtnBuscarClientes2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarClientes2.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscarClientes2.FlatAppearance.BorderSize = 0;
            this.BtnBuscarClientes2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnBuscarClientes2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnBuscarClientes2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarClientes2.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarClientes2.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_magnifier_4_24;
            this.BtnBuscarClientes2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscarClientes2.Location = new System.Drawing.Point(460, 21);
            this.BtnBuscarClientes2.Name = "BtnBuscarClientes2";
            this.BtnBuscarClientes2.Size = new System.Drawing.Size(41, 28);
            this.BtnBuscarClientes2.TabIndex = 13;
            this.BtnBuscarClientes2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscarClientes2.UseVisualStyleBackColor = false;
            this.BtnBuscarClientes2.Click += new System.EventHandler(this.BtnBuscarClientes2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1Clientes);
            this.tabControl1.Controls.Add(this.tabPage2Clientes);
            this.tabControl1.Controls.Add(this.tabDatos2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 275);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1094, 251);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1Clientes
            // 
            this.tabPage1Clientes.AutoScroll = true;
            this.tabPage1Clientes.Controls.Add(apodoClienteLabel1);
            this.tabPage1Clientes.Controls.Add(this.apodoClienteTextBox);
            this.tabPage1Clientes.Controls.Add(nombreClienteLabel1);
            this.tabPage1Clientes.Controls.Add(this.nombreClienteTextBox);
            this.tabPage1Clientes.Controls.Add(direccionClienteLabel1);
            this.tabPage1Clientes.Controls.Add(this.direccionClienteTextBox);
            this.tabPage1Clientes.Controls.Add(calleClienteLabel);
            this.tabPage1Clientes.Controls.Add(this.calleClienteTextBox);
            this.tabPage1Clientes.Controls.Add(idClienteLabel);
            this.tabPage1Clientes.Controls.Add(this.telefonoClienteTextBox);
            this.tabPage1Clientes.Controls.Add(telefonoClienteLabel);
            this.tabPage1Clientes.Controls.Add(this.idClienteTextBox);
            this.tabPage1Clientes.Controls.Add(movilClienteLabel);
            this.tabPage1Clientes.Controls.Add(this.movilClienteTextBox);
            this.tabPage1Clientes.Controls.Add(correoClienteLabel);
            this.tabPage1Clientes.Controls.Add(this.correoClienteTextBox);
            this.tabPage1Clientes.Controls.Add(dniClienteLabel);
            this.tabPage1Clientes.Controls.Add(this.dniClienteTextBox);
            this.tabPage1Clientes.Controls.Add(localidadClienteLabel);
            this.tabPage1Clientes.Controls.Add(this.localidadClienteTextBox);
            this.tabPage1Clientes.Location = new System.Drawing.Point(4, 22);
            this.tabPage1Clientes.Name = "tabPage1Clientes";
            this.tabPage1Clientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1Clientes.Size = new System.Drawing.Size(1086, 225);
            this.tabPage1Clientes.TabIndex = 0;
            this.tabPage1Clientes.Text = "General";
            this.tabPage1Clientes.UseVisualStyleBackColor = true;
            // 
            // apodoClienteTextBox
            // 
            this.apodoClienteTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.apodoClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "APODOCLIEN", true));
            this.apodoClienteTextBox.Enabled = false;
            this.apodoClienteTextBox.Location = new System.Drawing.Point(98, 13);
            this.apodoClienteTextBox.MaxLength = 70;
            this.apodoClienteTextBox.Name = "apodoClienteTextBox";
            this.apodoClienteTextBox.Size = new System.Drawing.Size(250, 20);
            this.apodoClienteTextBox.TabIndex = 1;
            this.apodoClienteTextBox.Click += new System.EventHandler(this.apodoClienteTextBox_Click);
            this.apodoClienteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apodoClienteTextBox_KeyPress);
            // 
            // nombreClienteTextBox
            // 
            this.nombreClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "NOMBRECLIE", true));
            this.nombreClienteTextBox.Enabled = false;
            this.nombreClienteTextBox.Location = new System.Drawing.Point(98, 39);
            this.nombreClienteTextBox.MaxLength = 120;
            this.nombreClienteTextBox.Name = "nombreClienteTextBox";
            this.nombreClienteTextBox.Size = new System.Drawing.Size(338, 20);
            this.nombreClienteTextBox.TabIndex = 2;
            this.nombreClienteTextBox.Click += new System.EventHandler(this.nombreClienteTextBox_Click);
            // 
            // direccionClienteTextBox
            // 
            this.direccionClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "DIRECCIONC", true));
            this.direccionClienteTextBox.Enabled = false;
            this.direccionClienteTextBox.Location = new System.Drawing.Point(98, 65);
            this.direccionClienteTextBox.MaxLength = 100;
            this.direccionClienteTextBox.Name = "direccionClienteTextBox";
            this.direccionClienteTextBox.Size = new System.Drawing.Size(292, 20);
            this.direccionClienteTextBox.TabIndex = 3;
            this.direccionClienteTextBox.Click += new System.EventHandler(this.direccionClienteTextBox_Click);
            this.direccionClienteTextBox.Leave += new System.EventHandler(this.direccionClienteTextBox_Leave);
            // 
            // calleClienteTextBox
            // 
            this.calleClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "CALLECLIEN", true));
            this.calleClienteTextBox.Enabled = false;
            this.calleClienteTextBox.Location = new System.Drawing.Point(481, 36);
            this.calleClienteTextBox.MaxLength = 30;
            this.calleClienteTextBox.Name = "calleClienteTextBox";
            this.calleClienteTextBox.Size = new System.Drawing.Size(121, 20);
            this.calleClienteTextBox.TabIndex = 5;
            // 
            // telefonoClienteTextBox
            // 
            this.telefonoClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "TELEFONOCL", true));
            this.telefonoClienteTextBox.Enabled = false;
            this.telefonoClienteTextBox.Location = new System.Drawing.Point(647, 124);
            this.telefonoClienteTextBox.MaxLength = 14;
            this.telefonoClienteTextBox.Name = "telefonoClienteTextBox";
            this.telefonoClienteTextBox.Size = new System.Drawing.Size(137, 20);
            this.telefonoClienteTextBox.TabIndex = 8;
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.idClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "IDCLIENTE", true));
            this.idClienteTextBox.Enabled = false;
            this.idClienteTextBox.Location = new System.Drawing.Point(88, 124);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(121, 20);
            this.idClienteTextBox.TabIndex = 1;
            this.idClienteTextBox.TabStop = false;
            this.idClienteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.idClienteTextBox.TextChanged += new System.EventHandler(this.idClienteTextBox_TextChanged);
            this.idClienteTextBox.DoubleClick += new System.EventHandler(this.idClienteTextBox_DoubleClick);
            this.idClienteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idClienteTextBox_KeyPress);
            // 
            // movilClienteTextBox
            // 
            this.movilClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "MOVILCLIEN", true));
            this.movilClienteTextBox.Enabled = false;
            this.movilClienteTextBox.Location = new System.Drawing.Point(647, 98);
            this.movilClienteTextBox.MaxLength = 14;
            this.movilClienteTextBox.Name = "movilClienteTextBox";
            this.movilClienteTextBox.Size = new System.Drawing.Size(137, 20);
            this.movilClienteTextBox.TabIndex = 7;
            // 
            // correoClienteTextBox
            // 
            this.correoClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "CORREOCLIE", true));
            this.correoClienteTextBox.Enabled = false;
            this.correoClienteTextBox.Location = new System.Drawing.Point(361, 95);
            this.correoClienteTextBox.MaxLength = 25;
            this.correoClienteTextBox.Name = "correoClienteTextBox";
            this.correoClienteTextBox.Size = new System.Drawing.Size(190, 20);
            this.correoClienteTextBox.TabIndex = 6;
            this.correoClienteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.correoClienteTextBox_Validating);
            // 
            // dniClienteTextBox
            // 
            this.dniClienteTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dniClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "DNICLIENTE", true));
            this.dniClienteTextBox.Enabled = false;
            this.dniClienteTextBox.Location = new System.Drawing.Point(91, 98);
            this.dniClienteTextBox.MaxLength = 12;
            this.dniClienteTextBox.Name = "dniClienteTextBox";
            this.dniClienteTextBox.Size = new System.Drawing.Size(163, 20);
            this.dniClienteTextBox.TabIndex = 6;
            this.dniClienteTextBox.Click += new System.EventHandler(this.dniClienteTextBox_Click);
            this.dniClienteTextBox.TextChanged += new System.EventHandler(this.dniClienteTextBox_TextChanged);
            this.dniClienteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dniClienteTextBox_KeyPress);
            this.dniClienteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.dniClienteTextBox_Validating);
            // 
            // localidadClienteTextBox
            // 
            this.localidadClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "LOCALIDADC", true));
            this.localidadClienteTextBox.Enabled = false;
            this.localidadClienteTextBox.Location = new System.Drawing.Point(481, 10);
            this.localidadClienteTextBox.MaxLength = 35;
            this.localidadClienteTextBox.Name = "localidadClienteTextBox";
            this.localidadClienteTextBox.Size = new System.Drawing.Size(174, 20);
            this.localidadClienteTextBox.TabIndex = 4;
            // 
            // tabPage2Clientes
            // 
            this.tabPage2Clientes.AutoScroll = true;
            this.tabPage2Clientes.Controls.Add(Label2);
            this.tabPage2Clientes.Controls.Add(this.dESCUENTOCTextBox);
            this.tabPage2Clientes.Controls.Add(this.FechaAltaCliente);
            this.tabPage2Clientes.Controls.Add(pORTESLabel);
            this.tabPage2Clientes.Controls.Add(this.pORTESComboBox);
            this.tabPage2Clientes.Controls.Add(tIPOCLIENTLabel);
            this.tabPage2Clientes.Controls.Add(this.tIPOCLIENTComboBox);
            this.tabPage2Clientes.Controls.Add(paisClienteLabel1);
            this.tabPage2Clientes.Controls.Add(this.paisClienteComboBox1);
            this.tabPage2Clientes.Controls.Add(provinciaClienteLabel1);
            this.tabPage2Clientes.Controls.Add(this.provinciaClienteComboBox1);
            this.tabPage2Clientes.Controls.Add(dniClienteTipoLabel);
            this.tabPage2Clientes.Controls.Add(this.dniClienteTipoComboBox);
            this.tabPage2Clientes.Controls.Add(numeroCalleClienteLabel);
            this.tabPage2Clientes.Controls.Add(this.numeroCalleClienteTextBox);
            this.tabPage2Clientes.Controls.Add(tarifaTipoClienteLabel);
            this.tabPage2Clientes.Controls.Add(this.tarifaTipoClienteComboBox);
            this.tabPage2Clientes.Controls.Add(codigoPostalClienteLabel);
            this.tabPage2Clientes.Controls.Add(this.codigoPostalClienteTextBox);
            this.tabPage2Clientes.Controls.Add(fechaAltaClienteLabel);
            this.tabPage2Clientes.Location = new System.Drawing.Point(4, 22);
            this.tabPage2Clientes.Name = "tabPage2Clientes";
            this.tabPage2Clientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2Clientes.Size = new System.Drawing.Size(1086, 225);
            this.tabPage2Clientes.TabIndex = 1;
            this.tabPage2Clientes.Text = "Otros Datos";
            this.tabPage2Clientes.UseVisualStyleBackColor = true;
            this.tabPage2Clientes.Click += new System.EventHandler(this.tabPage2Clientes_Click);
            // 
            // dESCUENTOCTextBox
            // 
            this.dESCUENTOCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "DESCUENTOC", true));
            this.dESCUENTOCTextBox.Location = new System.Drawing.Point(370, 116);
            this.dESCUENTOCTextBox.Name = "dESCUENTOCTextBox";
            this.dESCUENTOCTextBox.ReadOnly = true;
            this.dESCUENTOCTextBox.Size = new System.Drawing.Size(95, 20);
            this.dESCUENTOCTextBox.TabIndex = 67;
            this.dESCUENTOCTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dESCUENTOCTextBox_KeyPress);
            this.dESCUENTOCTextBox.Leave += new System.EventHandler(this.dESCUENTOCTextBox_Leave);
            // 
            // FechaAltaCliente
            // 
            this.FechaAltaCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "FECHAALTAC", true));
            this.FechaAltaCliente.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dtClientesBindingSource, "FECHAALTAC", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.FechaAltaCliente.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaAltaCliente.Location = new System.Drawing.Point(433, 67);
            this.FechaAltaCliente.Name = "FechaAltaCliente";
            this.FechaAltaCliente.Size = new System.Drawing.Size(200, 20);
            this.FechaAltaCliente.TabIndex = 66;
            this.FechaAltaCliente.Value = new System.DateTime(2022, 8, 4, 16, 12, 35, 0);
            // 
            // pORTESComboBox
            // 
            this.pORTESComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "PORTES", true));
            this.pORTESComboBox.FormattingEnabled = true;
            this.pORTESComboBox.Items.AddRange(new object[] {
            "Portes Sus Medios",
            "Portes Pagados",
            "Portes Devidos",
            "Otros Portes"});
            this.pORTESComboBox.Location = new System.Drawing.Point(773, 37);
            this.pORTESComboBox.Name = "pORTESComboBox";
            this.pORTESComboBox.Size = new System.Drawing.Size(165, 21);
            this.pORTESComboBox.TabIndex = 50;
            this.pORTESComboBox.Tag = "Portes Pagados";
            this.pORTESComboBox.Text = "Portes Sus Medios";
            // 
            // tIPOCLIENTComboBox
            // 
            this.tIPOCLIENTComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "TIPOCLIENT", true));
            this.tIPOCLIENTComboBox.FormattingEnabled = true;
            this.tIPOCLIENTComboBox.Items.AddRange(new object[] {
            "Particular",
            "Empresa Autonomo",
            "Empresa Sociedad",
            "Albañil Contratista",
            "Otros"});
            this.tIPOCLIENTComboBox.Location = new System.Drawing.Point(773, 85);
            this.tIPOCLIENTComboBox.Name = "tIPOCLIENTComboBox";
            this.tIPOCLIENTComboBox.Size = new System.Drawing.Size(165, 21);
            this.tIPOCLIENTComboBox.TabIndex = 49;
            this.tIPOCLIENTComboBox.Text = "Particular";
            // 
            // paisClienteComboBox1
            // 
            this.paisClienteComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "PAISCLIENT", true));
            this.paisClienteComboBox1.DataSource = this.dtPaisesBindingSource;
            this.paisClienteComboBox1.DisplayMember = "PaisesPaises";
            this.paisClienteComboBox1.FormattingEnabled = true;
            this.paisClienteComboBox1.Location = new System.Drawing.Point(89, 43);
            this.paisClienteComboBox1.Name = "paisClienteComboBox1";
            this.paisClienteComboBox1.Size = new System.Drawing.Size(275, 21);
            this.paisClienteComboBox1.TabIndex = 12;
            // 
            // dtPaisesBindingSource
            // 
            this.dtPaisesBindingSource.DataMember = "DtPaises";
            this.dtPaisesBindingSource.DataSource = this.dsMulti2;
            // 
            // dsMulti2
            // 
            this.dsMulti2.DataSetName = "DsMulti2";
            this.dsMulti2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provinciaClienteComboBox1
            // 
            this.provinciaClienteComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "PROVINCIAC", true));
            this.provinciaClienteComboBox1.DataSource = this.dtProvinciasBindingSource;
            this.provinciaClienteComboBox1.DisplayMember = "ProvinciasProvincias";
            this.provinciaClienteComboBox1.FormattingEnabled = true;
            this.provinciaClienteComboBox1.Location = new System.Drawing.Point(89, 14);
            this.provinciaClienteComboBox1.Name = "provinciaClienteComboBox1";
            this.provinciaClienteComboBox1.Size = new System.Drawing.Size(275, 21);
            this.provinciaClienteComboBox1.TabIndex = 10;
            // 
            // dtProvinciasBindingSource
            // 
            this.dtProvinciasBindingSource.DataMember = "DtProvincias";
            this.dtProvinciasBindingSource.DataSource = this.dsMulti2;
            // 
            // dniClienteTipoComboBox
            // 
            this.dniClienteTipoComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "1.  D.N.I",
            "2. C.I.F",
            "3. PAPEL"});
            this.dniClienteTipoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "TIPODNI", true));
            this.dniClienteTipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dniClienteTipoComboBox.FormattingEnabled = true;
            this.dniClienteTipoComboBox.Items.AddRange(new object[] {
            "DNI",
            "CIF",
            "PAPEL2"});
            this.dniClienteTipoComboBox.Location = new System.Drawing.Point(476, 16);
            this.dniClienteTipoComboBox.Name = "dniClienteTipoComboBox";
            this.dniClienteTipoComboBox.Size = new System.Drawing.Size(179, 21);
            this.dniClienteTipoComboBox.TabIndex = 13;
            this.dniClienteTipoComboBox.Tag = "";
            // 
            // numeroCalleClienteTextBox
            // 
            this.numeroCalleClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "NUMEROCALL", true));
            this.numeroCalleClienteTextBox.Location = new System.Drawing.Point(89, 97);
            this.numeroCalleClienteTextBox.MaxLength = 4;
            this.numeroCalleClienteTextBox.Name = "numeroCalleClienteTextBox";
            this.numeroCalleClienteTextBox.Size = new System.Drawing.Size(73, 20);
            this.numeroCalleClienteTextBox.TabIndex = 9;
            this.numeroCalleClienteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tarifaTipoClienteComboBox
            // 
            this.tarifaTipoClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "TARIFATIPO", true));
            this.tarifaTipoClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tarifaTipoClienteComboBox.FormattingEnabled = true;
            this.tarifaTipoClienteComboBox.Items.AddRange(new object[] {
            "Pvp1",
            "Pvp2",
            "Casty",
            "Suarez",
            "Benito",
            "Valente",
            "Casty%",
            "Suarez%",
            "Valente%",
            "Plus",
            "Pvp Iva"});
            this.tarifaTipoClienteComboBox.Location = new System.Drawing.Point(476, 40);
            this.tarifaTipoClienteComboBox.Name = "tarifaTipoClienteComboBox";
            this.tarifaTipoClienteComboBox.Size = new System.Drawing.Size(179, 21);
            this.tarifaTipoClienteComboBox.TabIndex = 14;
            // 
            // codigoPostalClienteTextBox
            // 
            this.codigoPostalClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "CODIGOPOST", true));
            this.codigoPostalClienteTextBox.Location = new System.Drawing.Point(89, 71);
            this.codigoPostalClienteTextBox.MaxLength = 10;
            this.codigoPostalClienteTextBox.Name = "codigoPostalClienteTextBox";
            this.codigoPostalClienteTextBox.Size = new System.Drawing.Size(121, 20);
            this.codigoPostalClienteTextBox.TabIndex = 11;
            this.codigoPostalClienteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabDatos2
            // 
            this.tabDatos2.AutoScroll = true;
            this.tabDatos2.Controls.Add(this.BancoProvincia);
            this.tabDatos2.Controls.Add(this.panelCuenta);
            this.tabDatos2.Controls.Add(bANCON_CUELabel);
            this.tabDatos2.Controls.Add(this.bANCON_CUETextBox);
            this.tabDatos2.Controls.Add(bANCOCODIGLabel);
            this.tabDatos2.Controls.Add(this.bANCOCODIGTextBox);
            this.tabDatos2.Controls.Add(bANCOLOCALLabel);
            this.tabDatos2.Controls.Add(this.bANCOLOCALTextBox);
            this.tabDatos2.Controls.Add(bANCODIRECLabel);
            this.tabDatos2.Controls.Add(this.bANCODIRECTextBox);
            this.tabDatos2.Controls.Add(bANCOPROVILabel);
            this.tabDatos2.Controls.Add(bANCOOFICILabel);
            this.tabDatos2.Controls.Add(this.bANCOOFICITextBox);
            this.tabDatos2.Location = new System.Drawing.Point(4, 22);
            this.tabDatos2.Name = "tabDatos2";
            this.tabDatos2.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatos2.Size = new System.Drawing.Size(1086, 225);
            this.tabDatos2.TabIndex = 3;
            this.tabDatos2.Text = "Datos Bancarios";
            this.tabDatos2.UseVisualStyleBackColor = true;
            // 
            // BancoProvincia
            // 
            this.BancoProvincia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "BANCOPROVI", true));
            this.BancoProvincia.DataSource = this.dtProvinciasBindingSource;
            this.BancoProvincia.DisplayMember = "ProvinciasProvincias";
            this.BancoProvincia.FormattingEnabled = true;
            this.BancoProvincia.Location = new System.Drawing.Point(406, 64);
            this.BancoProvincia.Name = "BancoProvincia";
            this.BancoProvincia.Size = new System.Drawing.Size(368, 21);
            this.BancoProvincia.TabIndex = 51;
            // 
            // panelCuenta
            // 
            this.panelCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelCuenta.Controls.Add(bANCOIBANLabel);
            this.panelCuenta.Controls.Add(nUMEROCUENLabel);
            this.panelCuenta.Controls.Add(this.bANCOIBANTextBox);
            this.panelCuenta.Controls.Add(this.NUMEROCUENTextBox);
            this.panelCuenta.Controls.Add(this.bANCOENTIDTextBox);
            this.panelCuenta.Controls.Add(bANCOENTIDLabel);
            this.panelCuenta.Controls.Add(this.BANCOOFIC2TextBox);
            this.panelCuenta.Controls.Add(bANCODCLabel);
            this.panelCuenta.Controls.Add(bANCOOFIC2Label);
            this.panelCuenta.Controls.Add(this.bANCODCTextBox);
            this.panelCuenta.Enabled = false;
            this.panelCuenta.Location = new System.Drawing.Point(6, 103);
            this.panelCuenta.Name = "panelCuenta";
            this.panelCuenta.Size = new System.Drawing.Size(1057, 116);
            this.panelCuenta.TabIndex = 51;
            // 
            // bANCOIBANTextBox
            // 
            this.bANCOIBANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "BANCOIBAN", true));
            this.bANCOIBANTextBox.Location = new System.Drawing.Point(6, 76);
            this.bANCOIBANTextBox.Name = "bANCOIBANTextBox";
            this.bANCOIBANTextBox.Size = new System.Drawing.Size(437, 20);
            this.bANCOIBANTextBox.TabIndex = 9;
            // 
            // NUMEROCUENTextBox
            // 
            this.NUMEROCUENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "NUMEROCUEN", true));
            this.NUMEROCUENTextBox.Location = new System.Drawing.Point(546, 28);
            this.NUMEROCUENTextBox.Name = "NUMEROCUENTextBox";
            this.NUMEROCUENTextBox.Size = new System.Drawing.Size(222, 20);
            this.NUMEROCUENTextBox.TabIndex = 50;
            this.NUMEROCUENTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NUMEROCUENTextBox_KeyPress);
            // 
            // bANCOENTIDTextBox
            // 
            this.bANCOENTIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "BANCOENTID", true));
            this.bANCOENTIDTextBox.Location = new System.Drawing.Point(6, 28);
            this.bANCOENTIDTextBox.Name = "bANCOENTIDTextBox";
            this.bANCOENTIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.bANCOENTIDTextBox.TabIndex = 13;
            this.bANCOENTIDTextBox.Enter += new System.EventHandler(this.bANCOENTIDTextBox_Enter);
            this.bANCOENTIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bANCOENTIDTextBox_KeyPress);
            // 
            // BANCOOFIC2TextBox
            // 
            this.BANCOOFIC2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "BANCOOFIC2", true));
            this.BANCOOFIC2TextBox.Location = new System.Drawing.Point(112, 28);
            this.BANCOOFIC2TextBox.Name = "BANCOOFIC2TextBox";
            this.BANCOOFIC2TextBox.Size = new System.Drawing.Size(316, 20);
            this.BANCOOFIC2TextBox.TabIndex = 15;
            this.BANCOOFIC2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BANCOOFIC2TextBox_KeyPress);
            // 
            // bANCODCTextBox
            // 
            this.bANCODCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "BANCODC", true));
            this.bANCODCTextBox.Location = new System.Drawing.Point(458, 28);
            this.bANCODCTextBox.Name = "bANCODCTextBox";
            this.bANCODCTextBox.Size = new System.Drawing.Size(74, 20);
            this.bANCODCTextBox.TabIndex = 17;
            this.bANCODCTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bANCODCTextBox_KeyPress);
            // 
            // bANCON_CUETextBox
            // 
            this.bANCON_CUETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "BANCON_CUE", true));
            this.bANCON_CUETextBox.Enabled = false;
            this.bANCON_CUETextBox.Location = new System.Drawing.Point(118, 22);
            this.bANCON_CUETextBox.Name = "bANCON_CUETextBox";
            this.bANCON_CUETextBox.Size = new System.Drawing.Size(464, 20);
            this.bANCON_CUETextBox.TabIndex = 19;
            // 
            // bANCOCODIGTextBox
            // 
            this.bANCOCODIGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "BANCOCODIG", true));
            this.bANCOCODIGTextBox.Enabled = false;
            this.bANCOCODIGTextBox.Location = new System.Drawing.Point(12, 22);
            this.bANCOCODIGTextBox.Name = "bANCOCODIGTextBox";
            this.bANCOCODIGTextBox.Size = new System.Drawing.Size(100, 20);
            this.bANCOCODIGTextBox.TabIndex = 11;
            // 
            // bANCOLOCALTextBox
            // 
            this.bANCOLOCALTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "BANCOLOCAL", true));
            this.bANCOLOCALTextBox.Enabled = false;
            this.bANCOLOCALTextBox.Location = new System.Drawing.Point(798, 64);
            this.bANCOLOCALTextBox.Name = "bANCOLOCALTextBox";
            this.bANCOLOCALTextBox.Size = new System.Drawing.Size(184, 20);
            this.bANCOLOCALTextBox.TabIndex = 7;
            // 
            // bANCODIRECTextBox
            // 
            this.bANCODIRECTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "BANCODIREC", true));
            this.bANCODIRECTextBox.Enabled = false;
            this.bANCODIRECTextBox.Location = new System.Drawing.Point(12, 64);
            this.bANCODIRECTextBox.Name = "bANCODIRECTextBox";
            this.bANCODIRECTextBox.Size = new System.Drawing.Size(388, 20);
            this.bANCODIRECTextBox.TabIndex = 5;
            // 
            // bANCOOFICITextBox
            // 
            this.bANCOOFICITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "BANCOOFICI", true));
            this.bANCOOFICITextBox.Enabled = false;
            this.bANCOOFICITextBox.Location = new System.Drawing.Point(588, 22);
            this.bANCOOFICITextBox.Name = "bANCOOFICITextBox";
            this.bANCOOFICITextBox.Size = new System.Drawing.Size(394, 20);
            this.bANCOOFICITextBox.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1086, 225);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Control";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // BtnGuardarCliente
            // 
            this.BtnGuardarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarCliente.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarCliente.Enabled = false;
            this.BtnGuardarCliente.FlatAppearance.BorderSize = 0;
            this.BtnGuardarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnGuardarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnGuardarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarCliente.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarCliente.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_check_mark_9_24;
            this.BtnGuardarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarCliente.Location = new System.Drawing.Point(570, 599);
            this.BtnGuardarCliente.Name = "BtnGuardarCliente";
            this.BtnGuardarCliente.Size = new System.Drawing.Size(89, 42);
            this.BtnGuardarCliente.TabIndex = 4;
            this.BtnGuardarCliente.Text = "Aceptar";
            this.BtnGuardarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarCliente.UseVisualStyleBackColor = false;
            this.BtnGuardarCliente.Click += new System.EventHandler(this.BtnGuardarCliente_Click);
            // 
            // BtnCancelarCliente
            // 
            this.BtnCancelarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelarCliente.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelarCliente.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelarCliente.Enabled = false;
            this.BtnCancelarCliente.FlatAppearance.BorderSize = 0;
            this.BtnCancelarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancelarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnCancelarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarCliente.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarCliente.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_x_mark_8_24;
            this.BtnCancelarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarCliente.Location = new System.Drawing.Point(730, 599);
            this.BtnCancelarCliente.Name = "BtnCancelarCliente";
            this.BtnCancelarCliente.Size = new System.Drawing.Size(89, 42);
            this.BtnCancelarCliente.TabIndex = 5;
            this.BtnCancelarCliente.Text = "Cancelar";
            this.BtnCancelarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelarCliente.UseVisualStyleBackColor = false;
            this.BtnCancelarCliente.Click += new System.EventHandler(this.BtnCancelarCliente_Click);
            // 
            // BtnNuevoCliente
            // 
            this.BtnNuevoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNuevoCliente.BackColor = System.Drawing.Color.Transparent;
            this.BtnNuevoCliente.FlatAppearance.BorderSize = 0;
            this.BtnNuevoCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnNuevoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoCliente.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoCliente.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_file_14_32;
            this.BtnNuevoCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevoCliente.Location = new System.Drawing.Point(-8, 0);
            this.BtnNuevoCliente.Name = "BtnNuevoCliente";
            this.BtnNuevoCliente.Size = new System.Drawing.Size(77, 63);
            this.BtnNuevoCliente.TabIndex = 6;
            this.BtnNuevoCliente.Text = "Nuevo";
            this.BtnNuevoCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNuevoCliente.UseVisualStyleBackColor = false;
            this.BtnNuevoCliente.Click += new System.EventHandler(this.BtnNuevoCliente_Click);
            // 
            // BtnModificarCliente
            // 
            this.BtnModificarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModificarCliente.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificarCliente.FlatAppearance.BorderSize = 0;
            this.BtnModificarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnModificarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarCliente.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarCliente.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_pen_8_32;
            this.BtnModificarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnModificarCliente.Location = new System.Drawing.Point(69, 0);
            this.BtnModificarCliente.Name = "BtnModificarCliente";
            this.BtnModificarCliente.Size = new System.Drawing.Size(77, 63);
            this.BtnModificarCliente.TabIndex = 7;
            this.BtnModificarCliente.Text = "Modificar";
            this.BtnModificarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificarCliente.UseVisualStyleBackColor = false;
            this.BtnModificarCliente.Click += new System.EventHandler(this.BtnModificarCliente_Click);
            // 
            // panelBotonesClientes
            // 
            this.panelBotonesClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelBotonesClientes.BackColor = System.Drawing.Color.Transparent;
            this.panelBotonesClientes.Controls.Add(this.BtnImprimirCliente);
            this.panelBotonesClientes.Controls.Add(this.BtnBuscarClientes2);
            this.panelBotonesClientes.Controls.Add(this.BtnEnviarMailCliente);
            this.panelBotonesClientes.Controls.Add(this.BtnEliminarCliente);
            this.panelBotonesClientes.Controls.Add(this.BtnBuscarCliente);
            this.panelBotonesClientes.Controls.Add(this.BtnNuevoCliente);
            this.panelBotonesClientes.Controls.Add(this.BtnModificarCliente);
            this.panelBotonesClientes.Location = new System.Drawing.Point(16, 578);
            this.panelBotonesClientes.Name = "panelBotonesClientes";
            this.panelBotonesClientes.Size = new System.Drawing.Size(515, 63);
            this.panelBotonesClientes.TabIndex = 8;
            this.panelBotonesClientes.Tag = "STOP";
            // 
            // BtnImprimirCliente
            // 
            this.BtnImprimirCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnImprimirCliente.BackColor = System.Drawing.Color.Transparent;
            this.BtnImprimirCliente.FlatAppearance.BorderSize = 0;
            this.BtnImprimirCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnImprimirCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnImprimirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimirCliente.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimirCliente.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_printer_5_32;
            this.BtnImprimirCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnImprimirCliente.Location = new System.Drawing.Point(300, 0);
            this.BtnImprimirCliente.Name = "BtnImprimirCliente";
            this.BtnImprimirCliente.Size = new System.Drawing.Size(77, 63);
            this.BtnImprimirCliente.TabIndex = 11;
            this.BtnImprimirCliente.Text = "Imprimir";
            this.BtnImprimirCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnImprimirCliente.UseVisualStyleBackColor = false;
            this.BtnImprimirCliente.Click += new System.EventHandler(this.BtnImprimirCliente_Click);
            // 
            // BtnEnviarMailCliente
            // 
            this.BtnEnviarMailCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEnviarMailCliente.BackColor = System.Drawing.Color.Transparent;
            this.BtnEnviarMailCliente.FlatAppearance.BorderSize = 0;
            this.BtnEnviarMailCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnEnviarMailCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnEnviarMailCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnviarMailCliente.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviarMailCliente.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_email_9_32;
            this.BtnEnviarMailCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEnviarMailCliente.Location = new System.Drawing.Point(377, 0);
            this.BtnEnviarMailCliente.Name = "BtnEnviarMailCliente";
            this.BtnEnviarMailCliente.Size = new System.Drawing.Size(77, 63);
            this.BtnEnviarMailCliente.TabIndex = 10;
            this.BtnEnviarMailCliente.Text = "Email";
            this.BtnEnviarMailCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEnviarMailCliente.UseVisualStyleBackColor = false;
            // 
            // BtnEliminarCliente
            // 
            this.BtnEliminarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminarCliente.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarCliente.FlatAppearance.BorderSize = 0;
            this.BtnEliminarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnEliminarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarCliente.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarCliente.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_trash_can_17_32;
            this.BtnEliminarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminarCliente.Location = new System.Drawing.Point(223, 0);
            this.BtnEliminarCliente.Name = "BtnEliminarCliente";
            this.BtnEliminarCliente.Size = new System.Drawing.Size(77, 63);
            this.BtnEliminarCliente.TabIndex = 9;
            this.BtnEliminarCliente.Text = "Eliminar";
            this.BtnEliminarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminarCliente.UseVisualStyleBackColor = false;
            this.BtnEliminarCliente.Click += new System.EventHandler(this.BtnEliminarCliente_Click);
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.BtnBuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarCliente.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarCliente.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_magnifier_4_32;
            this.BtnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscarCliente.Location = new System.Drawing.Point(146, 0);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(77, 63);
            this.BtnBuscarCliente.TabIndex = 8;
            this.BtnBuscarCliente.Text = "Buscar";
            this.BtnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscarCliente.UseVisualStyleBackColor = false;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // BtnSalirCliente
            // 
            this.BtnSalirCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalirCliente.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalirCliente.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalirCliente.FlatAppearance.BorderSize = 0;
            this.BtnSalirCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnSalirCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnSalirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalirCliente.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirCliente.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_door_5_32;
            this.BtnSalirCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalirCliente.Location = new System.Drawing.Point(1025, 578);
            this.BtnSalirCliente.Name = "BtnSalirCliente";
            this.BtnSalirCliente.Size = new System.Drawing.Size(77, 63);
            this.BtnSalirCliente.TabIndex = 12;
            this.BtnSalirCliente.Text = "Salir";
            this.BtnSalirCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalirCliente.UseVisualStyleBackColor = false;
            this.BtnSalirCliente.Click += new System.EventHandler(this.BtnSalirCliente_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // dsCONFIGURACCION
            // 
            this.dsCONFIGURACCION.DataSetName = "DsCONFIGURACCION";
            this.dsCONFIGURACCION.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(820, 543);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Reguistros #";
            // 
            // ContadorDatosClientes
            // 
            this.ContadorDatosClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ContadorDatosClientes.AutoSize = true;
            this.ContadorDatosClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContadorDatosClientes.Location = new System.Drawing.Point(930, 543);
            this.ContadorDatosClientes.Name = "ContadorDatosClientes";
            this.ContadorDatosClientes.Size = new System.Drawing.Size(19, 20);
            this.ContadorDatosClientes.TabIndex = 39;
            this.ContadorDatosClientes.Text = "0";
            this.ContadorDatosClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnSalirCliente;
            this.ClientSize = new System.Drawing.Size(1118, 653);
            this.Controls.Add(this.BtnSalirCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ContadorDatosClientes);
            this.Controls.Add(this.panelBotonesClientes);
            this.Controls.Add(this.BtnCancelarCliente);
            this.Controls.Add(this.BtnGuardarCliente);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClientes_FormClosing);
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.MouseEnter += new System.EventHandler(this.FormClientes_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1Clientes.ResumeLayout(false);
            this.tabPage1Clientes.PerformLayout();
            this.tabPage2Clientes.ResumeLayout(false);
            this.tabPage2Clientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMulti2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProvinciasBindingSource)).EndInit();
            this.tabDatos2.ResumeLayout(false);
            this.tabDatos2.PerformLayout();
            this.panelCuenta.ResumeLayout(false);
            this.panelCuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).EndInit();
            this.panelBotonesClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DsClientes dsClientes;
        private System.Windows.Forms.BindingSource dtClientesBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1Clientes;
        private System.Windows.Forms.TabPage tabPage2Clientes;
        private System.Windows.Forms.TextBox calleClienteTextBox;
        private System.Windows.Forms.TextBox telefonoClienteTextBox;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.ComboBox apodoClienteComboBox;
        private System.Windows.Forms.ComboBox direccionClienteComboBox;
        private System.Windows.Forms.TextBox movilClienteTextBox;
        private System.Windows.Forms.TextBox correoClienteTextBox;
        private System.Windows.Forms.TextBox dniClienteTextBox;
        private System.Windows.Forms.TextBox localidadClienteTextBox;
        private System.Windows.Forms.ComboBox dniClienteTipoComboBox;
        private System.Windows.Forms.TextBox numeroCalleClienteTextBox;
        private System.Windows.Forms.ComboBox tarifaTipoClienteComboBox;
        private System.Windows.Forms.TextBox codigoPostalClienteTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox apodoClienteTextBox;
        private System.Windows.Forms.TextBox nombreClienteTextBox;
        private System.Windows.Forms.TextBox direccionClienteTextBox;
        private System.Windows.Forms.Button BtnCancelarCliente;
        private System.Windows.Forms.Button BtnNuevoCliente;
        private System.Windows.Forms.Button BtnModificarCliente;
        private System.Windows.Forms.Panel panelBotonesClientes;
        private System.Windows.Forms.Button BtnBuscarCliente;
        private System.Windows.Forms.Button BtnEliminarCliente;
        private System.Windows.Forms.Button BtnImprimirCliente;
        private System.Windows.Forms.Button BtnEnviarMailCliente;
        private System.Windows.Forms.Button BtnSalirCliente;
        private System.Windows.Forms.Button BtnBuscarClientes2;
        public System.Windows.Forms.Button BtnGuardarCliente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.DataGridView dtClientesDataGridView;
        private System.Windows.Forms.ComboBox nombreClienteComboBox;
        public System.Windows.Forms.Button BtnAceptarFINALBuscar;
        private System.Windows.Forms.TabPage tabPage1;
        private DsCONFIGURACCION dsCONFIGURACCION;
        private System.Windows.Forms.ComboBox paisClienteComboBox1;
        private System.Windows.Forms.ComboBox provinciaClienteComboBox1;
        private DsMultidatos dsMultidatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ContadorDatosClientes;
        private System.Windows.Forms.BindingSource dtInicioMultiBindingSource;
        private System.Windows.Forms.ComboBox pORTESComboBox;
        private System.Windows.Forms.ComboBox tIPOCLIENTComboBox;
        private System.Windows.Forms.TabPage tabDatos2;
        private System.Windows.Forms.TextBox NUMEROCUENTextBox;
        private System.Windows.Forms.TextBox bANCON_CUETextBox;
        private System.Windows.Forms.TextBox bANCODCTextBox;
        private System.Windows.Forms.TextBox BANCOOFIC2TextBox;
        private System.Windows.Forms.TextBox bANCOENTIDTextBox;
        private System.Windows.Forms.TextBox bANCOCODIGTextBox;
        private System.Windows.Forms.TextBox bANCOIBANTextBox;
        private System.Windows.Forms.TextBox bANCOLOCALTextBox;
        private System.Windows.Forms.TextBox bANCODIRECTextBox;
        private System.Windows.Forms.TextBox bANCOOFICITextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPODOCLIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRECLIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAALTACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker FechaAltaCliente;
        private System.Windows.Forms.TextBox dESCUENTOCTextBox;
        private System.Windows.Forms.ComboBox BancoProvincia;
        private System.Windows.Forms.BindingSource dtProvinciasBindingSource;
        private DsMulti2 dsMulti2;
        private System.Windows.Forms.Panel panelCuenta;
        private System.Windows.Forms.BindingSource dtPaisesBindingSource;
    }
}