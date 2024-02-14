
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
            System.Windows.Forms.Label Label67;
            System.Windows.Forms.Label Label66;
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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.TabControlCli = new System.Windows.Forms.TabControl();
            this.PageCliente1 = new System.Windows.Forms.TabPage();
            this.Id_Clientes = new System.Windows.Forms.Label();
            this.ApodoClienteTex = new System.Windows.Forms.TextBox();
            this.NombreCliente = new System.Windows.Forms.TextBox();
            this.DirecionCliente = new System.Windows.Forms.TextBox();
            this.CalleClienteTextBox = new System.Windows.Forms.TextBox();
            this.numeroCalleClienteTextBox = new System.Windows.Forms.TextBox();
            this.TelefonoClienteTextBox = new System.Windows.Forms.TextBox();
            this.MovilClienteText = new System.Windows.Forms.TextBox();
            this.CorreoClienteText = new System.Windows.Forms.TextBox();
            this.dniClienteTextBox = new System.Windows.Forms.TextBox();
            this.LocalidadClienteTxt = new System.Windows.Forms.TextBox();
            this.PageCliente2 = new System.Windows.Forms.TabPage();
            this.DescuentoCliente = new System.Windows.Forms.TextBox();
            this.FechaAltaCliente = new System.Windows.Forms.DateTimePicker();
            this.PortesTxt = new System.Windows.Forms.ComboBox();
            this.TipoCliente = new System.Windows.Forms.ComboBox();
            this.paisClienteComboBox1 = new System.Windows.Forms.ComboBox();
            this.dtPaisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMulti2 = new PELOSCALVO.DsMulti2();
            this.provinciaClienteComboBox1 = new System.Windows.Forms.ComboBox();
            this.dtProvinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TipoDocumento = new System.Windows.Forms.ComboBox();
            this.TipoTarifa = new System.Windows.Forms.ComboBox();
            this.dtTarifaTipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtConfiguracionPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCONFIGURACCION = new PELOSCALVO.DsCONFIGURACCION();
            this.codigoPostalClienteTextBox = new System.Windows.Forms.TextBox();
            this.PageCliente3 = new System.Windows.Forms.TabPage();
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
            this.PageCliente4 = new System.Windows.Forms.TabPage();
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
            Label67 = new System.Windows.Forms.Label();
            Label66 = new System.Windows.Forms.Label();
            nUMEROCUENLabel = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.TabControlCli.SuspendLayout();
            this.PageCliente1.SuspendLayout();
            this.PageCliente2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMulti2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProvinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarifaTipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).BeginInit();
            this.PageCliente3.SuspendLayout();
            this.panelCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).BeginInit();
            this.panelBotonesClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(63, 30);
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
            telefonoClienteLabel.Location = new System.Drawing.Point(456, 111);
            telefonoClienteLabel.Name = "telefonoClienteLabel";
            telefonoClienteLabel.Size = new System.Drawing.Size(52, 13);
            telefonoClienteLabel.TabIndex = 8;
            telefonoClienteLabel.Text = "Telefono:";
            // 
            // movilClienteLabel
            // 
            movilClienteLabel.AutoSize = true;
            movilClienteLabel.Location = new System.Drawing.Point(473, 139);
            movilClienteLabel.Name = "movilClienteLabel";
            movilClienteLabel.Size = new System.Drawing.Size(35, 13);
            movilClienteLabel.TabIndex = 10;
            movilClienteLabel.Text = "Movil:";
            // 
            // correoClienteLabel
            // 
            correoClienteLabel.AutoSize = true;
            correoClienteLabel.Location = new System.Drawing.Point(417, 166);
            correoClienteLabel.Name = "correoClienteLabel";
            correoClienteLabel.Size = new System.Drawing.Size(91, 13);
            correoClienteLabel.TabIndex = 12;
            correoClienteLabel.Text = "Correo Eletronico:";
            // 
            // dniClienteLabel
            // 
            dniClienteLabel.AutoSize = true;
            dniClienteLabel.Location = new System.Drawing.Point(56, 141);
            dniClienteLabel.Name = "dniClienteLabel";
            dniClienteLabel.Size = new System.Drawing.Size(26, 13);
            dniClienteLabel.TabIndex = 14;
            dniClienteLabel.Text = "Dni:";
            // 
            // localidadClienteLabel
            // 
            localidadClienteLabel.AutoSize = true;
            localidadClienteLabel.Location = new System.Drawing.Point(452, 30);
            localidadClienteLabel.Name = "localidadClienteLabel";
            localidadClienteLabel.Size = new System.Drawing.Size(56, 13);
            localidadClienteLabel.TabIndex = 16;
            localidadClienteLabel.Text = "Localidad:";
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
            fechaAltaClienteLabel.Location = new System.Drawing.Point(427, 78);
            fechaAltaClienteLabel.Name = "fechaAltaClienteLabel";
            fechaAltaClienteLabel.Size = new System.Drawing.Size(96, 13);
            fechaAltaClienteLabel.TabIndex = 32;
            fechaAltaClienteLabel.Text = "Fecha Alta Cliente:";
            // 
            // numeroCalleClienteLabel
            // 
            numeroCalleClienteLabel.AutoSize = true;
            numeroCalleClienteLabel.Location = new System.Drawing.Point(434, 82);
            numeroCalleClienteLabel.Name = "numeroCalleClienteLabel";
            numeroCalleClienteLabel.Size = new System.Drawing.Size(73, 13);
            numeroCalleClienteLabel.TabIndex = 36;
            numeroCalleClienteLabel.Text = "Numero Calle:";
            // 
            // tarifaTipoClienteLabel
            // 
            tarifaTipoClienteLabel.AutoSize = true;
            tarifaTipoClienteLabel.Location = new System.Drawing.Point(486, 44);
            tarifaTipoClienteLabel.Name = "tarifaTipoClienteLabel";
            tarifaTipoClienteLabel.Size = new System.Drawing.Size(37, 13);
            tarifaTipoClienteLabel.TabIndex = 40;
            tarifaTipoClienteLabel.Text = "Tarifa:";
            // 
            // dniClienteTipoLabel
            // 
            dniClienteTipoLabel.AutoSize = true;
            dniClienteTipoLabel.Location = new System.Drawing.Point(417, 17);
            dniClienteTipoLabel.Name = "dniClienteTipoLabel";
            dniClienteTipoLabel.Size = new System.Drawing.Size(106, 13);
            dniClienteTipoLabel.TabIndex = 42;
            dniClienteTipoLabel.Text = "Tipo De Documento:";
            // 
            // calleClienteLabel
            // 
            calleClienteLabel.AutoSize = true;
            calleClienteLabel.Location = new System.Drawing.Point(475, 59);
            calleClienteLabel.Name = "calleClienteLabel";
            calleClienteLabel.Size = new System.Drawing.Size(33, 13);
            calleClienteLabel.TabIndex = 36;
            calleClienteLabel.Text = "Calle:";
            // 
            // apodoClienteLabel1
            // 
            apodoClienteLabel1.AutoSize = true;
            apodoClienteLabel1.Location = new System.Drawing.Point(9, 59);
            apodoClienteLabel1.Name = "apodoClienteLabel1";
            apodoClienteLabel1.Size = new System.Drawing.Size(73, 13);
            apodoClienteLabel1.TabIndex = 37;
            apodoClienteLabel1.Text = "Razon Social:";
            // 
            // nombreClienteLabel1
            // 
            nombreClienteLabel1.AutoSize = true;
            nombreClienteLabel1.Location = new System.Drawing.Point(35, 83);
            nombreClienteLabel1.Name = "nombreClienteLabel1";
            nombreClienteLabel1.Size = new System.Drawing.Size(47, 13);
            nombreClienteLabel1.TabIndex = 39;
            nombreClienteLabel1.Text = "Nombre:";
            // 
            // direccionClienteLabel1
            // 
            direccionClienteLabel1.AutoSize = true;
            direccionClienteLabel1.Location = new System.Drawing.Point(27, 111);
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
            // Label67
            // 
            Label67.AutoSize = true;
            Label67.Location = new System.Drawing.Point(773, 44);
            Label67.Name = "Label67";
            Label67.Size = new System.Drawing.Size(66, 13);
            Label67.TabIndex = 48;
            Label67.Text = "Tipo Cliente:";
            // 
            // Label66
            // 
            Label66.AutoSize = true;
            Label66.Location = new System.Drawing.Point(799, 17);
            Label66.Name = "Label66";
            Label66.Size = new System.Drawing.Size(40, 13);
            Label66.TabIndex = 49;
            Label66.Text = "Portes:";
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
            Label2.Location = new System.Drawing.Point(461, 114);
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
            this.Id,
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
            this.dtClientesDataGridView.ReadOnly = true;
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
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.Id.DefaultCellStyle = dataGridViewCellStyle2;
            this.Id.HeaderText = "Numero";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // aPODOCLIENDataGridViewTextBoxColumn
            // 
            this.aPODOCLIENDataGridViewTextBoxColumn.DataPropertyName = "APODOCLIEN";
            this.aPODOCLIENDataGridViewTextBoxColumn.FillWeight = 260F;
            this.aPODOCLIENDataGridViewTextBoxColumn.HeaderText = "Razon Social";
            this.aPODOCLIENDataGridViewTextBoxColumn.Name = "aPODOCLIENDataGridViewTextBoxColumn";
            this.aPODOCLIENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBRECLIEDataGridViewTextBoxColumn
            // 
            this.nOMBRECLIEDataGridViewTextBoxColumn.DataPropertyName = "NOMBRECLIE";
            this.nOMBRECLIEDataGridViewTextBoxColumn.FillWeight = 300F;
            this.nOMBRECLIEDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nOMBRECLIEDataGridViewTextBoxColumn.Name = "nOMBRECLIEDataGridViewTextBoxColumn";
            this.nOMBRECLIEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIRECCIONCDataGridViewTextBoxColumn
            // 
            this.dIRECCIONCDataGridViewTextBoxColumn.DataPropertyName = "DIRECCIONC";
            this.dIRECCIONCDataGridViewTextBoxColumn.FillWeight = 250F;
            this.dIRECCIONCDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.dIRECCIONCDataGridViewTextBoxColumn.Name = "dIRECCIONCDataGridViewTextBoxColumn";
            this.dIRECCIONCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHAALTACDataGridViewTextBoxColumn
            // 
            this.fECHAALTACDataGridViewTextBoxColumn.DataPropertyName = "FECHAALTAC";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.fECHAALTACDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.fECHAALTACDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fECHAALTACDataGridViewTextBoxColumn.Name = "fECHAALTACDataGridViewTextBoxColumn";
            this.fECHAALTACDataGridViewTextBoxColumn.ReadOnly = true;
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
            // TabControlCli
            // 
            this.TabControlCli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlCli.Controls.Add(this.PageCliente1);
            this.TabControlCli.Controls.Add(this.PageCliente2);
            this.TabControlCli.Controls.Add(this.PageCliente3);
            this.TabControlCli.Controls.Add(this.PageCliente4);
            this.TabControlCli.Location = new System.Drawing.Point(12, 275);
            this.TabControlCli.Name = "TabControlCli";
            this.TabControlCli.SelectedIndex = 0;
            this.TabControlCli.Size = new System.Drawing.Size(1094, 251);
            this.TabControlCli.TabIndex = 3;
            // 
            // PageCliente1
            // 
            this.PageCliente1.AutoScroll = true;
            this.PageCliente1.Controls.Add(this.Id_Clientes);
            this.PageCliente1.Controls.Add(apodoClienteLabel1);
            this.PageCliente1.Controls.Add(this.ApodoClienteTex);
            this.PageCliente1.Controls.Add(nombreClienteLabel1);
            this.PageCliente1.Controls.Add(this.NombreCliente);
            this.PageCliente1.Controls.Add(direccionClienteLabel1);
            this.PageCliente1.Controls.Add(this.DirecionCliente);
            this.PageCliente1.Controls.Add(calleClienteLabel);
            this.PageCliente1.Controls.Add(numeroCalleClienteLabel);
            this.PageCliente1.Controls.Add(this.CalleClienteTextBox);
            this.PageCliente1.Controls.Add(this.numeroCalleClienteTextBox);
            this.PageCliente1.Controls.Add(idClienteLabel);
            this.PageCliente1.Controls.Add(this.TelefonoClienteTextBox);
            this.PageCliente1.Controls.Add(telefonoClienteLabel);
            this.PageCliente1.Controls.Add(movilClienteLabel);
            this.PageCliente1.Controls.Add(this.MovilClienteText);
            this.PageCliente1.Controls.Add(correoClienteLabel);
            this.PageCliente1.Controls.Add(this.CorreoClienteText);
            this.PageCliente1.Controls.Add(dniClienteLabel);
            this.PageCliente1.Controls.Add(this.dniClienteTextBox);
            this.PageCliente1.Controls.Add(localidadClienteLabel);
            this.PageCliente1.Controls.Add(this.LocalidadClienteTxt);
            this.PageCliente1.Location = new System.Drawing.Point(4, 22);
            this.PageCliente1.Name = "PageCliente1";
            this.PageCliente1.Padding = new System.Windows.Forms.Padding(3);
            this.PageCliente1.Size = new System.Drawing.Size(1086, 225);
            this.PageCliente1.TabIndex = 0;
            this.PageCliente1.Text = "General";
            this.PageCliente1.UseVisualStyleBackColor = true;
            // 
            // Id_Clientes
            // 
            this.Id_Clientes.AutoSize = true;
            this.Id_Clientes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "Id", true));
            this.Id_Clientes.Location = new System.Drawing.Point(88, 30);
            this.Id_Clientes.Name = "Id_Clientes";
            this.Id_Clientes.Size = new System.Drawing.Size(13, 13);
            this.Id_Clientes.TabIndex = 42;
            this.Id_Clientes.Text = "0";
            // 
            // ApodoClienteTex
            // 
            this.ApodoClienteTex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ApodoClienteTex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "APODOCLIEN", true));
            this.ApodoClienteTex.Enabled = false;
            this.ApodoClienteTex.Location = new System.Drawing.Point(88, 56);
            this.ApodoClienteTex.MaxLength = 70;
            this.ApodoClienteTex.Name = "ApodoClienteTex";
            this.ApodoClienteTex.Size = new System.Drawing.Size(250, 20);
            this.ApodoClienteTex.TabIndex = 1;
            this.ApodoClienteTex.Click += new System.EventHandler(this.apodoClienteTextBox_Click);
            this.ApodoClienteTex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apodoClienteTextBox_KeyPress);
            // 
            // NombreCliente
            // 
            this.NombreCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.NombreCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "NOMBRECLIE", true));
            this.NombreCliente.Enabled = false;
            this.NombreCliente.Location = new System.Drawing.Point(88, 82);
            this.NombreCliente.MaxLength = 120;
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Size = new System.Drawing.Size(338, 20);
            this.NombreCliente.TabIndex = 2;
            this.NombreCliente.Click += new System.EventHandler(this.nombreClienteTextBox_Click);
            // 
            // DirecionCliente
            // 
            this.DirecionCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "DIRECCIONC", true));
            this.DirecionCliente.Enabled = false;
            this.DirecionCliente.Location = new System.Drawing.Point(88, 108);
            this.DirecionCliente.MaxLength = 100;
            this.DirecionCliente.Name = "DirecionCliente";
            this.DirecionCliente.Size = new System.Drawing.Size(292, 20);
            this.DirecionCliente.TabIndex = 3;
            this.DirecionCliente.Click += new System.EventHandler(this.direccionClienteTextBox_Click);
            this.DirecionCliente.Leave += new System.EventHandler(this.direccionClienteTextBox_Leave);
            // 
            // CalleClienteTextBox
            // 
            this.CalleClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "CALLECLIEN", true));
            this.CalleClienteTextBox.Enabled = false;
            this.CalleClienteTextBox.Location = new System.Drawing.Point(513, 56);
            this.CalleClienteTextBox.MaxLength = 30;
            this.CalleClienteTextBox.Name = "CalleClienteTextBox";
            this.CalleClienteTextBox.Size = new System.Drawing.Size(121, 20);
            this.CalleClienteTextBox.TabIndex = 5;
            // 
            // numeroCalleClienteTextBox
            // 
            this.numeroCalleClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "NUMEROCALL", true));
            this.numeroCalleClienteTextBox.Enabled = false;
            this.numeroCalleClienteTextBox.Location = new System.Drawing.Point(513, 82);
            this.numeroCalleClienteTextBox.MaxLength = 4;
            this.numeroCalleClienteTextBox.Name = "numeroCalleClienteTextBox";
            this.numeroCalleClienteTextBox.Size = new System.Drawing.Size(73, 20);
            this.numeroCalleClienteTextBox.TabIndex = 9;
            this.numeroCalleClienteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TelefonoClienteTextBox
            // 
            this.TelefonoClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "TELEFONOCL", true));
            this.TelefonoClienteTextBox.Enabled = false;
            this.TelefonoClienteTextBox.Location = new System.Drawing.Point(513, 108);
            this.TelefonoClienteTextBox.MaxLength = 14;
            this.TelefonoClienteTextBox.Name = "TelefonoClienteTextBox";
            this.TelefonoClienteTextBox.Size = new System.Drawing.Size(137, 20);
            this.TelefonoClienteTextBox.TabIndex = 8;
            // 
            // MovilClienteText
            // 
            this.MovilClienteText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "MOVILCLIEN", true));
            this.MovilClienteText.Enabled = false;
            this.MovilClienteText.Location = new System.Drawing.Point(513, 136);
            this.MovilClienteText.MaxLength = 14;
            this.MovilClienteText.Name = "MovilClienteText";
            this.MovilClienteText.Size = new System.Drawing.Size(137, 20);
            this.MovilClienteText.TabIndex = 7;
            // 
            // CorreoClienteText
            // 
            this.CorreoClienteText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "CORREOCLIE", true));
            this.CorreoClienteText.Enabled = false;
            this.CorreoClienteText.Location = new System.Drawing.Point(513, 163);
            this.CorreoClienteText.MaxLength = 25;
            this.CorreoClienteText.Name = "CorreoClienteText";
            this.CorreoClienteText.Size = new System.Drawing.Size(190, 20);
            this.CorreoClienteText.TabIndex = 6;
            this.CorreoClienteText.Validating += new System.ComponentModel.CancelEventHandler(this.correoClienteTextBox_Validating);
            // 
            // dniClienteTextBox
            // 
            this.dniClienteTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dniClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "DNICLIENTE", true));
            this.dniClienteTextBox.Enabled = false;
            this.dniClienteTextBox.Location = new System.Drawing.Point(88, 138);
            this.dniClienteTextBox.MaxLength = 12;
            this.dniClienteTextBox.Name = "dniClienteTextBox";
            this.dniClienteTextBox.Size = new System.Drawing.Size(163, 20);
            this.dniClienteTextBox.TabIndex = 6;
            this.dniClienteTextBox.Click += new System.EventHandler(this.dniClienteTextBox_Click);
            this.dniClienteTextBox.TextChanged += new System.EventHandler(this.dniClienteTextBox_TextChanged);
            this.dniClienteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dniClienteTextBox_KeyPress);
            this.dniClienteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.dniClienteTextBox_Validating);
            // 
            // LocalidadClienteTxt
            // 
            this.LocalidadClienteTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "LOCALIDADC", true));
            this.LocalidadClienteTxt.Enabled = false;
            this.LocalidadClienteTxt.Location = new System.Drawing.Point(513, 27);
            this.LocalidadClienteTxt.MaxLength = 35;
            this.LocalidadClienteTxt.Name = "LocalidadClienteTxt";
            this.LocalidadClienteTxt.Size = new System.Drawing.Size(214, 20);
            this.LocalidadClienteTxt.TabIndex = 4;
            // 
            // PageCliente2
            // 
            this.PageCliente2.AutoScroll = true;
            this.PageCliente2.Controls.Add(Label2);
            this.PageCliente2.Controls.Add(this.DescuentoCliente);
            this.PageCliente2.Controls.Add(this.FechaAltaCliente);
            this.PageCliente2.Controls.Add(Label66);
            this.PageCliente2.Controls.Add(this.PortesTxt);
            this.PageCliente2.Controls.Add(Label67);
            this.PageCliente2.Controls.Add(this.TipoCliente);
            this.PageCliente2.Controls.Add(paisClienteLabel1);
            this.PageCliente2.Controls.Add(this.paisClienteComboBox1);
            this.PageCliente2.Controls.Add(provinciaClienteLabel1);
            this.PageCliente2.Controls.Add(this.provinciaClienteComboBox1);
            this.PageCliente2.Controls.Add(dniClienteTipoLabel);
            this.PageCliente2.Controls.Add(this.TipoDocumento);
            this.PageCliente2.Controls.Add(tarifaTipoClienteLabel);
            this.PageCliente2.Controls.Add(this.TipoTarifa);
            this.PageCliente2.Controls.Add(codigoPostalClienteLabel);
            this.PageCliente2.Controls.Add(this.codigoPostalClienteTextBox);
            this.PageCliente2.Controls.Add(fechaAltaClienteLabel);
            this.PageCliente2.Location = new System.Drawing.Point(4, 22);
            this.PageCliente2.Name = "PageCliente2";
            this.PageCliente2.Padding = new System.Windows.Forms.Padding(3);
            this.PageCliente2.Size = new System.Drawing.Size(1086, 225);
            this.PageCliente2.TabIndex = 1;
            this.PageCliente2.Text = "Otros Datos";
            this.PageCliente2.UseVisualStyleBackColor = true;
            this.PageCliente2.Click += new System.EventHandler(this.tabPage2Clientes_Click);
            // 
            // DescuentoCliente
            // 
            this.DescuentoCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "DESCUENTOC", true));
            this.DescuentoCliente.Location = new System.Drawing.Point(529, 111);
            this.DescuentoCliente.Name = "DescuentoCliente";
            this.DescuentoCliente.Size = new System.Drawing.Size(95, 20);
            this.DescuentoCliente.TabIndex = 67;
            this.DescuentoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dESCUENTOCTextBox_KeyPress);
            this.DescuentoCliente.Leave += new System.EventHandler(this.dESCUENTOCTextBox_Leave);
            // 
            // FechaAltaCliente
            // 
            this.FechaAltaCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "FECHAALTAC", true));
            this.FechaAltaCliente.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dtClientesBindingSource, "FECHAALTAC", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.FechaAltaCliente.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaAltaCliente.Location = new System.Drawing.Point(529, 74);
            this.FechaAltaCliente.Name = "FechaAltaCliente";
            this.FechaAltaCliente.Size = new System.Drawing.Size(200, 20);
            this.FechaAltaCliente.TabIndex = 66;
            this.FechaAltaCliente.Value = new System.DateTime(2022, 8, 4, 16, 12, 35, 0);
            // 
            // PortesTxt
            // 
            this.PortesTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "PORTES", true));
            this.PortesTxt.FormattingEnabled = true;
            this.PortesTxt.Items.AddRange(new object[] {
            "Portes Sus Medios",
            "Portes Pagados",
            "Portes Devidos",
            "Otros Portes"});
            this.PortesTxt.Location = new System.Drawing.Point(845, 14);
            this.PortesTxt.Name = "PortesTxt";
            this.PortesTxt.Size = new System.Drawing.Size(165, 21);
            this.PortesTxt.TabIndex = 50;
            this.PortesTxt.Tag = "Portes Pagados";
            this.PortesTxt.Text = "Portes Sus Medios";
            // 
            // TipoCliente
            // 
            this.TipoCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "TIPOCLIENT", true));
            this.TipoCliente.FormattingEnabled = true;
            this.TipoCliente.Items.AddRange(new object[] {
            "Particular",
            "Empresa Autonomo",
            "Empresa Sociedad",
            "Albañil Contratista",
            "Otros"});
            this.TipoCliente.Location = new System.Drawing.Point(845, 41);
            this.TipoCliente.Name = "TipoCliente";
            this.TipoCliente.Size = new System.Drawing.Size(165, 21);
            this.TipoCliente.TabIndex = 49;
            this.TipoCliente.Text = "Particular";
            // 
            // paisClienteComboBox1
            // 
            this.paisClienteComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "PAISCLIENT", true));
            this.paisClienteComboBox1.DataSource = this.dtPaisesBindingSource;
            this.paisClienteComboBox1.DisplayMember = "Paises";
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
            this.provinciaClienteComboBox1.DisplayMember = "Provincias";
            this.provinciaClienteComboBox1.FormattingEnabled = true;
            this.provinciaClienteComboBox1.Location = new System.Drawing.Point(89, 14);
            this.provinciaClienteComboBox1.Name = "provinciaClienteComboBox1";
            this.provinciaClienteComboBox1.Size = new System.Drawing.Size(275, 21);
            this.provinciaClienteComboBox1.TabIndex = 10;
            // 
            // dtProvinciasBindingSource
            // 
            this.dtProvinciasBindingSource.DataMember = "FK_DtPaises_DtProvincias";
            this.dtProvinciasBindingSource.DataSource = this.dtPaisesBindingSource;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.AutoCompleteCustomSource.AddRange(new string[] {
            "1.  D.N.I",
            "2. C.I.F",
            "3. PAPEL"});
            this.TipoDocumento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "TIPODNI", true));
            this.TipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoDocumento.FormattingEnabled = true;
            this.TipoDocumento.Items.AddRange(new object[] {
            "DNI",
            "CIF",
            "PAPEL2"});
            this.TipoDocumento.Location = new System.Drawing.Point(529, 14);
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.Size = new System.Drawing.Size(179, 21);
            this.TipoDocumento.TabIndex = 13;
            this.TipoDocumento.Tag = "";
            // 
            // TipoTarifa
            // 
            this.TipoTarifa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "TARIFATIPO", true));
            this.TipoTarifa.DataSource = this.dtTarifaTipoBindingSource;
            this.TipoTarifa.DisplayMember = "TarifaTipo";
            this.TipoTarifa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoTarifa.FormattingEnabled = true;
            this.TipoTarifa.Location = new System.Drawing.Point(529, 38);
            this.TipoTarifa.Name = "TipoTarifa";
            this.TipoTarifa.Size = new System.Drawing.Size(201, 21);
            this.TipoTarifa.TabIndex = 14;
            // 
            // dtTarifaTipoBindingSource
            // 
            this.dtTarifaTipoBindingSource.DataMember = "FK_DtConfiguracionPrincipal_DtTarifaTipo";
            this.dtTarifaTipoBindingSource.DataSource = this.dtConfiguracionPrincipalBindingSource;
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
            // PageCliente3
            // 
            this.PageCliente3.AutoScroll = true;
            this.PageCliente3.Controls.Add(this.BancoProvincia);
            this.PageCliente3.Controls.Add(this.panelCuenta);
            this.PageCliente3.Controls.Add(bANCON_CUELabel);
            this.PageCliente3.Controls.Add(this.bANCON_CUETextBox);
            this.PageCliente3.Controls.Add(bANCOCODIGLabel);
            this.PageCliente3.Controls.Add(this.bANCOCODIGTextBox);
            this.PageCliente3.Controls.Add(bANCOLOCALLabel);
            this.PageCliente3.Controls.Add(this.bANCOLOCALTextBox);
            this.PageCliente3.Controls.Add(bANCODIRECLabel);
            this.PageCliente3.Controls.Add(this.bANCODIRECTextBox);
            this.PageCliente3.Controls.Add(bANCOPROVILabel);
            this.PageCliente3.Controls.Add(bANCOOFICILabel);
            this.PageCliente3.Controls.Add(this.bANCOOFICITextBox);
            this.PageCliente3.Location = new System.Drawing.Point(4, 22);
            this.PageCliente3.Name = "PageCliente3";
            this.PageCliente3.Padding = new System.Windows.Forms.Padding(3);
            this.PageCliente3.Size = new System.Drawing.Size(1086, 225);
            this.PageCliente3.TabIndex = 3;
            this.PageCliente3.Text = "Datos Bancarios";
            this.PageCliente3.UseVisualStyleBackColor = true;
            // 
            // BancoProvincia
            // 
            this.BancoProvincia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientesBindingSource, "BANCOPROVI", true));
            this.BancoProvincia.DataSource = this.dtProvinciasBindingSource;
            this.BancoProvincia.DisplayMember = "Provincias";
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
            // PageCliente4
            // 
            this.PageCliente4.Location = new System.Drawing.Point(4, 22);
            this.PageCliente4.Name = "PageCliente4";
            this.PageCliente4.Padding = new System.Windows.Forms.Padding(3);
            this.PageCliente4.Size = new System.Drawing.Size(1086, 225);
            this.PageCliente4.TabIndex = 2;
            this.PageCliente4.Text = "Control";
            this.PageCliente4.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.TabControlCli);
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
            this.TabControlCli.ResumeLayout(false);
            this.PageCliente1.ResumeLayout(false);
            this.PageCliente1.PerformLayout();
            this.PageCliente2.ResumeLayout(false);
            this.PageCliente2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMulti2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProvinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarifaTipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).EndInit();
            this.PageCliente3.ResumeLayout(false);
            this.PageCliente3.PerformLayout();
            this.panelCuenta.ResumeLayout(false);
            this.panelCuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).EndInit();
            this.panelBotonesClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DsClientes dsClientes;
        private System.Windows.Forms.BindingSource dtClientesBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl TabControlCli;
        private System.Windows.Forms.TabPage PageCliente1;
        private System.Windows.Forms.TabPage PageCliente2;
        private System.Windows.Forms.TextBox CalleClienteTextBox;
        private System.Windows.Forms.TextBox TelefonoClienteTextBox;
        private System.Windows.Forms.ComboBox apodoClienteComboBox;
        private System.Windows.Forms.ComboBox direccionClienteComboBox;
        private System.Windows.Forms.TextBox MovilClienteText;
        private System.Windows.Forms.TextBox CorreoClienteText;
        private System.Windows.Forms.TextBox dniClienteTextBox;
        private System.Windows.Forms.TextBox LocalidadClienteTxt;
        private System.Windows.Forms.ComboBox TipoDocumento;
        private System.Windows.Forms.TextBox numeroCalleClienteTextBox;
        private System.Windows.Forms.ComboBox TipoTarifa;
        private System.Windows.Forms.TextBox codigoPostalClienteTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ApodoClienteTex;
        private System.Windows.Forms.TextBox NombreCliente;
        private System.Windows.Forms.TextBox DirecionCliente;
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
        private System.Windows.Forms.TabPage PageCliente4;
        private DsCONFIGURACCION dsCONFIGURACCION;
        private System.Windows.Forms.ComboBox paisClienteComboBox1;
        private System.Windows.Forms.ComboBox provinciaClienteComboBox1;
        private DsMultidatos dsMultidatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ContadorDatosClientes;
        private System.Windows.Forms.BindingSource dtInicioMultiBindingSource;
        private System.Windows.Forms.ComboBox PortesTxt;
        private System.Windows.Forms.ComboBox TipoCliente;
        private System.Windows.Forms.TabPage PageCliente3;
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
        private System.Windows.Forms.DateTimePicker FechaAltaCliente;
        private System.Windows.Forms.TextBox DescuentoCliente;
        private System.Windows.Forms.ComboBox BancoProvincia;
        private System.Windows.Forms.BindingSource dtProvinciasBindingSource;
        private DsMulti2 dsMulti2;
        private System.Windows.Forms.Panel panelCuenta;
        private System.Windows.Forms.BindingSource dtPaisesBindingSource;
        private System.Windows.Forms.Label Id_Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPODOCLIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRECLIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAALTACDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dtTarifaTipoBindingSource;
        public System.Windows.Forms.BindingSource dtConfiguracionPrincipalBindingSource;
    }
}