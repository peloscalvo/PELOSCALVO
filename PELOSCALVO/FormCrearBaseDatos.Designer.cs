
namespace PELOSCALVO
{
    partial class FormCrearBaseDatos
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label idConexionConfiLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label servidoresLabel1;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearBaseDatos));
            this.NombreBaseDatos = new System.Windows.Forms.TextBox();
            this.BtnCrearBaseDatos = new System.Windows.Forms.Button();
            this.TabCrear = new System.Windows.Forms.TabControl();
            this.TabBaseDatos = new System.Windows.Forms.TabPage();
            this.panelSql2 = new System.Windows.Forms.Panel();
            this.UsuarioSql2 = new System.Windows.Forms.ComboBox();
            this.dtServidorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsServidor = new PELOSCALVO.DsServidor();
            this.checkPass2 = new System.Windows.Forms.CheckBox();
            this.ContraseñaSql2 = new System.Windows.Forms.TextBox();
            this.AutenticacionCrear = new System.Windows.Forms.ComboBox();
            this.BtnBuscarServidorCrear = new System.Windows.Forms.Button();
            this.ServidorCrear = new System.Windows.Forms.ComboBox();
            this.TabCrearTablas = new System.Windows.Forms.TabPage();
            this.SerieClientesTabla = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SerieArticulosTabla = new System.Windows.Forms.ComboBox();
            this.checkTablas = new System.Windows.Forms.CheckBox();
            this.checkEmpresas = new System.Windows.Forms.CheckBox();
            this.ServidoresLabel3 = new System.Windows.Forms.Label();
            this.NombreBaseTablas = new System.Windows.Forms.Label();
            this.BtnCrearTablas = new System.Windows.Forms.Button();
            this.CheckFacturacion = new System.Windows.Forms.CheckBox();
            this.CheckClientes = new System.Windows.Forms.CheckBox();
            this.CheckTablaArticulos = new System.Windows.Forms.CheckBox();
            this.tabPageBackup = new System.Windows.Forms.TabPage();
            this.ServidoresLabel4 = new System.Windows.Forms.Label();
            this.Backuptext = new System.Windows.Forms.Label();
            this.BtnCrearBackup = new System.Windows.Forms.Button();
            this.TabInstacias = new System.Windows.Forms.TabPage();
            this.BtnLeerInstancias = new System.Windows.Forms.Button();
            this.ServidoresLabel2 = new System.Windows.Forms.Label();
            this.BtnDesactivarInstancia = new System.Windows.Forms.Button();
            this.BtnActivarInstancia = new System.Windows.Forms.Button();
            this.BtnEliminarInstancia = new System.Windows.Forms.Button();
            this.BtnCrearInstancia = new System.Windows.Forms.Button();
            this.InstanciaNueva = new System.Windows.Forms.TextBox();
            this.TabRestaurar = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRestaurar = new System.Windows.Forms.Label();
            this.BtnRestaurarBases = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ListaNueva = new System.Windows.Forms.ListBox();
            this.ListaBaseDatos = new System.Windows.Forms.ListBox();
            this.InfoProcesoText = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            idConexionConfiLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            servidoresLabel1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.TabCrear.SuspendLayout();
            this.TabBaseDatos.SuspendLayout();
            this.panelSql2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtServidorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsServidor)).BeginInit();
            this.TabCrearTablas.SuspendLayout();
            this.tabPageBackup.SuspendLayout();
            this.TabInstacias.SuspendLayout();
            this.TabRestaurar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 119);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 13);
            label1.TabIndex = 73;
            label1.Text = "Base Datos:";
            // 
            // idConexionConfiLabel
            // 
            idConexionConfiLabel.AutoSize = true;
            idConexionConfiLabel.Location = new System.Drawing.Point(24, 25);
            idConexionConfiLabel.Name = "idConexionConfiLabel";
            idConexionConfiLabel.Size = new System.Drawing.Size(49, 13);
            idConexionConfiLabel.TabIndex = 75;
            idConexionConfiLabel.Text = "Servidor:";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(712, 25);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 13);
            label2.TabIndex = 79;
            label2.Text = "Lista Bases Datos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(73, 108);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(168, 13);
            label3.TabIndex = 78;
            label3.Text = "Base Datos Crear Copia Seguriad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(29, 11);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(128, 13);
            label5.TabIndex = 80;
            label5.Text = "Base Datos Crear Tablas:";
            // 
            // servidoresLabel1
            // 
            servidoresLabel1.AutoSize = true;
            servidoresLabel1.Location = new System.Drawing.Point(20, 20);
            servidoresLabel1.Name = "servidoresLabel1";
            servidoresLabel1.Size = new System.Drawing.Size(88, 13);
            servidoresLabel1.TabIndex = 0;
            servidoresLabel1.Text = "Nueva Instancia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 73);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(36, 13);
            label4.TabIndex = 79;
            label4.Text = "encts:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(26, 63);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(64, 13);
            label6.TabIndex = 70;
            label6.Text = "Contraseña:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(44, 24);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(46, 13);
            label7.TabIndex = 69;
            label7.Text = "Usuario:";
            // 
            // NombreBaseDatos
            // 
            this.NombreBaseDatos.Location = new System.Drawing.Point(77, 116);
            this.NombreBaseDatos.MaxLength = 50;
            this.NombreBaseDatos.Name = "NombreBaseDatos";
            this.NombreBaseDatos.Size = new System.Drawing.Size(269, 20);
            this.NombreBaseDatos.TabIndex = 72;
            // 
            // BtnCrearBaseDatos
            // 
            this.BtnCrearBaseDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCrearBaseDatos.BackColor = System.Drawing.Color.Transparent;
            this.BtnCrearBaseDatos.FlatAppearance.BorderSize = 0;
            this.BtnCrearBaseDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnCrearBaseDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnCrearBaseDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearBaseDatos.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearBaseDatos.Image = global::PELOSCALVO.Properties.Resources.Aceptar;
            this.BtnCrearBaseDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCrearBaseDatos.Location = new System.Drawing.Point(488, 216);
            this.BtnCrearBaseDatos.Name = "BtnCrearBaseDatos";
            this.BtnCrearBaseDatos.Size = new System.Drawing.Size(159, 42);
            this.BtnCrearBaseDatos.TabIndex = 74;
            this.BtnCrearBaseDatos.Text = "&Crear Base Datos";
            this.BtnCrearBaseDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCrearBaseDatos.UseVisualStyleBackColor = false;
            this.BtnCrearBaseDatos.Click += new System.EventHandler(this.BtnCrearBaseDatos_Click);
            // 
            // TabCrear
            // 
            this.TabCrear.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.TabCrear.Controls.Add(this.TabBaseDatos);
            this.TabCrear.Controls.Add(this.TabCrearTablas);
            this.TabCrear.Controls.Add(this.tabPageBackup);
            this.TabCrear.Controls.Add(this.TabInstacias);
            this.TabCrear.Controls.Add(this.TabRestaurar);
            this.TabCrear.Controls.Add(this.tabPage1);
            this.TabCrear.Location = new System.Drawing.Point(3, 0);
            this.TabCrear.Name = "TabCrear";
            this.TabCrear.SelectedIndex = 0;
            this.TabCrear.Size = new System.Drawing.Size(681, 317);
            this.TabCrear.TabIndex = 75;
            this.TabCrear.SelectedIndexChanged += new System.EventHandler(this.TabCrear_SelectedIndexChanged);
            // 
            // TabBaseDatos
            // 
            this.TabBaseDatos.Controls.Add(this.panelSql2);
            this.TabBaseDatos.Controls.Add(this.AutenticacionCrear);
            this.TabBaseDatos.Controls.Add(label4);
            this.TabBaseDatos.Controls.Add(this.BtnBuscarServidorCrear);
            this.TabBaseDatos.Controls.Add(this.ServidorCrear);
            this.TabBaseDatos.Controls.Add(idConexionConfiLabel);
            this.TabBaseDatos.Controls.Add(this.NombreBaseDatos);
            this.TabBaseDatos.Controls.Add(this.BtnCrearBaseDatos);
            this.TabBaseDatos.Controls.Add(label1);
            this.TabBaseDatos.Location = new System.Drawing.Point(4, 25);
            this.TabBaseDatos.Name = "TabBaseDatos";
            this.TabBaseDatos.Padding = new System.Windows.Forms.Padding(3);
            this.TabBaseDatos.Size = new System.Drawing.Size(673, 288);
            this.TabBaseDatos.TabIndex = 0;
            this.TabBaseDatos.Text = "Crear Base Datos";
            this.TabBaseDatos.UseVisualStyleBackColor = true;
            // 
            // panelSql2
            // 
            this.panelSql2.Controls.Add(this.UsuarioSql2);
            this.panelSql2.Controls.Add(this.checkPass2);
            this.panelSql2.Controls.Add(this.ContraseñaSql2);
            this.panelSql2.Controls.Add(label6);
            this.panelSql2.Controls.Add(label7);
            this.panelSql2.Location = new System.Drawing.Point(11, 142);
            this.panelSql2.Name = "panelSql2";
            this.panelSql2.Size = new System.Drawing.Size(446, 120);
            this.panelSql2.TabIndex = 81;
            this.panelSql2.Tag = "SI";
            // 
            // UsuarioSql2
            // 
            this.UsuarioSql2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtServidorBindingSource, "UsusarioSql", true));
            this.UsuarioSql2.FormattingEnabled = true;
            this.UsuarioSql2.Location = new System.Drawing.Point(93, 16);
            this.UsuarioSql2.Name = "UsuarioSql2";
            this.UsuarioSql2.Size = new System.Drawing.Size(291, 21);
            this.UsuarioSql2.TabIndex = 73;
            // 
            // dtServidorBindingSource
            // 
            this.dtServidorBindingSource.DataMember = "DtServidor";
            this.dtServidorBindingSource.DataSource = this.dsServidor;
            // 
            // dsServidor
            // 
            this.dsServidor.DataSetName = "DsServidor";
            this.dsServidor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkPass2
            // 
            this.checkPass2.AutoSize = true;
            this.checkPass2.Location = new System.Drawing.Point(376, 62);
            this.checkPass2.Name = "checkPass2";
            this.checkPass2.Size = new System.Drawing.Size(61, 17);
            this.checkPass2.TabIndex = 72;
            this.checkPass2.Text = "Mostrar";
            this.checkPass2.UseVisualStyleBackColor = true;
            this.checkPass2.CheckedChanged += new System.EventHandler(this.checkPass2_CheckedChanged);
            // 
            // ContraseñaSql2
            // 
            this.ContraseñaSql2.Location = new System.Drawing.Point(93, 60);
            this.ContraseñaSql2.Name = "ContraseñaSql2";
            this.ContraseñaSql2.PasswordChar = '*';
            this.ContraseñaSql2.Size = new System.Drawing.Size(269, 20);
            this.ContraseñaSql2.TabIndex = 71;
            // 
            // AutenticacionCrear
            // 
            this.AutenticacionCrear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AutenticacionCrear.FormattingEnabled = true;
            this.AutenticacionCrear.Items.AddRange(new object[] {
            "Autenticacion De Windows",
            "Autenticacion De SQL Server"});
            this.AutenticacionCrear.Location = new System.Drawing.Point(77, 70);
            this.AutenticacionCrear.Name = "AutenticacionCrear";
            this.AutenticacionCrear.Size = new System.Drawing.Size(291, 21);
            this.AutenticacionCrear.TabIndex = 80;
            this.AutenticacionCrear.SelectedIndexChanged += new System.EventHandler(this.AutenticacionCrear_SelectedIndexChanged);
            // 
            // BtnBuscarServidorCrear
            // 
            this.BtnBuscarServidorCrear.Location = new System.Drawing.Point(380, 20);
            this.BtnBuscarServidorCrear.Name = "BtnBuscarServidorCrear";
            this.BtnBuscarServidorCrear.Size = new System.Drawing.Size(48, 23);
            this.BtnBuscarServidorCrear.TabIndex = 77;
            this.BtnBuscarServidorCrear.Text = "Buscar";
            this.BtnBuscarServidorCrear.UseVisualStyleBackColor = true;
            this.BtnBuscarServidorCrear.Click += new System.EventHandler(this.BtnBuscarServidorCrear_Click);
            // 
            // ServidorCrear
            // 
            this.ServidorCrear.DataSource = this.dtServidorBindingSource;
            this.ServidorCrear.DisplayMember = "Servidores";
            this.ServidorCrear.FormattingEnabled = true;
            this.ServidorCrear.Location = new System.Drawing.Point(77, 20);
            this.ServidorCrear.MaxLength = 60;
            this.ServidorCrear.Name = "ServidorCrear";
            this.ServidorCrear.Size = new System.Drawing.Size(291, 21);
            this.ServidorCrear.TabIndex = 76;
            this.ServidorCrear.Tag = "PARAR";
            this.ServidorCrear.SelectedIndexChanged += new System.EventHandler(this.ServidorCrear_SelectedIndexChanged);
            this.ServidorCrear.TextChanged += new System.EventHandler(this.ServidorCrear_TextChanged);
            this.ServidorCrear.Enter += new System.EventHandler(this.ServidorCrear_Enter);
            this.ServidorCrear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ServidorCrear_KeyPress);
            this.ServidorCrear.Validated += new System.EventHandler(this.ServidorCrear_Validated);
            // 
            // TabCrearTablas
            // 
            this.TabCrearTablas.Controls.Add(this.SerieClientesTabla);
            this.TabCrearTablas.Controls.Add(this.label10);
            this.TabCrearTablas.Controls.Add(this.label9);
            this.TabCrearTablas.Controls.Add(this.SerieArticulosTabla);
            this.TabCrearTablas.Controls.Add(this.checkTablas);
            this.TabCrearTablas.Controls.Add(this.checkEmpresas);
            this.TabCrearTablas.Controls.Add(this.ServidoresLabel3);
            this.TabCrearTablas.Controls.Add(this.NombreBaseTablas);
            this.TabCrearTablas.Controls.Add(label5);
            this.TabCrearTablas.Controls.Add(this.BtnCrearTablas);
            this.TabCrearTablas.Controls.Add(this.CheckFacturacion);
            this.TabCrearTablas.Controls.Add(this.CheckClientes);
            this.TabCrearTablas.Controls.Add(this.CheckTablaArticulos);
            this.TabCrearTablas.Location = new System.Drawing.Point(4, 25);
            this.TabCrearTablas.Name = "TabCrearTablas";
            this.TabCrearTablas.Padding = new System.Windows.Forms.Padding(3);
            this.TabCrearTablas.Size = new System.Drawing.Size(673, 288);
            this.TabCrearTablas.TabIndex = 1;
            this.TabCrearTablas.Text = "Crear Tablas";
            this.TabCrearTablas.UseVisualStyleBackColor = true;
            // 
            // SerieClientesTabla
            // 
            this.SerieClientesTabla.FormattingEnabled = true;
            this.SerieClientesTabla.Items.AddRange(new object[] {
            "Listado De Clientes 1",
            "Listado De Clientes 1",
            "Listado De Clientes 1",
            "Listado De Clientes 1",
            "Listado De Clientes 1"});
            this.SerieClientesTabla.Location = new System.Drawing.Point(308, 192);
            this.SerieClientesTabla.MaxLength = 50;
            this.SerieClientesTabla.Name = "SerieClientesTabla";
            this.SerieClientesTabla.Size = new System.Drawing.Size(344, 21);
            this.SerieClientesTabla.TabIndex = 88;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(205, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 87;
            this.label10.Text = "Tarifa De Clientes:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 86;
            this.label9.Text = "Tarifa De Articulos:";
            // 
            // SerieArticulosTabla
            // 
            this.SerieArticulosTabla.DisplayMember = "A";
            this.SerieArticulosTabla.FormattingEnabled = true;
            this.SerieArticulosTabla.Items.AddRange(new object[] {
            "Tarifa De Articulos 1",
            "Tarifa De Articulos 2",
            "Tarifa De Articulos 3",
            "Tarifa De Articulos 4",
            "Tarifa De Articulos 5"});
            this.SerieArticulosTabla.Location = new System.Drawing.Point(308, 160);
            this.SerieArticulosTabla.MaxLength = 50;
            this.SerieArticulosTabla.Name = "SerieArticulosTabla";
            this.SerieArticulosTabla.Size = new System.Drawing.Size(344, 21);
            this.SerieArticulosTabla.TabIndex = 85;
            this.SerieArticulosTabla.Tag = "stop";
            // 
            // checkTablas
            // 
            this.checkTablas.AutoSize = true;
            this.checkTablas.Checked = true;
            this.checkTablas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkTablas.Location = new System.Drawing.Point(53, 198);
            this.checkTablas.Name = "checkTablas";
            this.checkTablas.Size = new System.Drawing.Size(104, 17);
            this.checkTablas.TabIndex = 84;
            this.checkTablas.Text = "Resto de Tablas";
            this.checkTablas.UseVisualStyleBackColor = true;
            // 
            // checkEmpresas
            // 
            this.checkEmpresas.AutoSize = true;
            this.checkEmpresas.Checked = true;
            this.checkEmpresas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEmpresas.Location = new System.Drawing.Point(53, 164);
            this.checkEmpresas.Name = "checkEmpresas";
            this.checkEmpresas.Size = new System.Drawing.Size(72, 17);
            this.checkEmpresas.TabIndex = 83;
            this.checkEmpresas.Text = "Empresas";
            this.checkEmpresas.UseVisualStyleBackColor = true;
            // 
            // ServidoresLabel3
            // 
            this.ServidoresLabel3.Location = new System.Drawing.Point(183, 11);
            this.ServidoresLabel3.Name = "ServidoresLabel3";
            this.ServidoresLabel3.Size = new System.Drawing.Size(294, 23);
            this.ServidoresLabel3.TabIndex = 82;
            // 
            // NombreBaseTablas
            // 
            this.NombreBaseTablas.AutoSize = true;
            this.NombreBaseTablas.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.NombreBaseTablas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreBaseTablas.Location = new System.Drawing.Point(209, 16);
            this.NombreBaseTablas.Name = "NombreBaseTablas";
            this.NombreBaseTablas.Size = new System.Drawing.Size(0, 18);
            this.NombreBaseTablas.TabIndex = 81;
            // 
            // BtnCrearTablas
            // 
            this.BtnCrearTablas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCrearTablas.BackColor = System.Drawing.Color.Transparent;
            this.BtnCrearTablas.FlatAppearance.BorderSize = 0;
            this.BtnCrearTablas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnCrearTablas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnCrearTablas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearTablas.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearTablas.Image = global::PELOSCALVO.Properties.Resources.Aceptar;
            this.BtnCrearTablas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCrearTablas.Location = new System.Drawing.Point(474, 230);
            this.BtnCrearTablas.Name = "BtnCrearTablas";
            this.BtnCrearTablas.Size = new System.Drawing.Size(159, 42);
            this.BtnCrearTablas.TabIndex = 75;
            this.BtnCrearTablas.Text = "&Crear Tablas";
            this.BtnCrearTablas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCrearTablas.UseVisualStyleBackColor = false;
            this.BtnCrearTablas.Click += new System.EventHandler(this.BtnCrearTablas_Click);
            // 
            // CheckFacturacion
            // 
            this.CheckFacturacion.AutoSize = true;
            this.CheckFacturacion.Checked = true;
            this.CheckFacturacion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckFacturacion.Location = new System.Drawing.Point(53, 132);
            this.CheckFacturacion.Name = "CheckFacturacion";
            this.CheckFacturacion.Size = new System.Drawing.Size(82, 17);
            this.CheckFacturacion.TabIndex = 2;
            this.CheckFacturacion.Text = "Facturacion";
            this.CheckFacturacion.UseVisualStyleBackColor = true;
            // 
            // CheckClientes
            // 
            this.CheckClientes.AutoSize = true;
            this.CheckClientes.Checked = true;
            this.CheckClientes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckClientes.Location = new System.Drawing.Point(53, 98);
            this.CheckClientes.Name = "CheckClientes";
            this.CheckClientes.Size = new System.Drawing.Size(63, 17);
            this.CheckClientes.TabIndex = 1;
            this.CheckClientes.Text = "Clientes";
            this.CheckClientes.UseVisualStyleBackColor = true;
            // 
            // CheckTablaArticulos
            // 
            this.CheckTablaArticulos.AutoSize = true;
            this.CheckTablaArticulos.Checked = true;
            this.CheckTablaArticulos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckTablaArticulos.Location = new System.Drawing.Point(53, 65);
            this.CheckTablaArticulos.Name = "CheckTablaArticulos";
            this.CheckTablaArticulos.Size = new System.Drawing.Size(66, 17);
            this.CheckTablaArticulos.TabIndex = 0;
            this.CheckTablaArticulos.Text = "Articulos";
            this.CheckTablaArticulos.UseVisualStyleBackColor = true;
            // 
            // tabPageBackup
            // 
            this.tabPageBackup.Controls.Add(this.ServidoresLabel4);
            this.tabPageBackup.Controls.Add(this.Backuptext);
            this.tabPageBackup.Controls.Add(label3);
            this.tabPageBackup.Controls.Add(this.BtnCrearBackup);
            this.tabPageBackup.Location = new System.Drawing.Point(4, 25);
            this.tabPageBackup.Name = "tabPageBackup";
            this.tabPageBackup.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBackup.Size = new System.Drawing.Size(673, 288);
            this.tabPageBackup.TabIndex = 2;
            this.tabPageBackup.Text = "Crear Backup";
            this.tabPageBackup.UseVisualStyleBackColor = true;
            // 
            // ServidoresLabel4
            // 
            this.ServidoresLabel4.Location = new System.Drawing.Point(73, 62);
            this.ServidoresLabel4.Name = "ServidoresLabel4";
            this.ServidoresLabel4.Size = new System.Drawing.Size(294, 23);
            this.ServidoresLabel4.TabIndex = 80;
            this.ServidoresLabel4.Text = "Info";
            // 
            // Backuptext
            // 
            this.Backuptext.AutoSize = true;
            this.Backuptext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backuptext.Location = new System.Drawing.Point(247, 104);
            this.Backuptext.Name = "Backuptext";
            this.Backuptext.Size = new System.Drawing.Size(17, 18);
            this.Backuptext.TabIndex = 79;
            this.Backuptext.Text = "0";
            // 
            // BtnCrearBackup
            // 
            this.BtnCrearBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCrearBackup.BackColor = System.Drawing.Color.Transparent;
            this.BtnCrearBackup.FlatAppearance.BorderSize = 0;
            this.BtnCrearBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnCrearBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnCrearBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearBackup.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearBackup.Image = global::PELOSCALVO.Properties.Resources.Aceptar;
            this.BtnCrearBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCrearBackup.Location = new System.Drawing.Point(437, 217);
            this.BtnCrearBackup.Name = "BtnCrearBackup";
            this.BtnCrearBackup.Size = new System.Drawing.Size(187, 42);
            this.BtnCrearBackup.TabIndex = 76;
            this.BtnCrearBackup.Text = "&Crear Copia seguridad";
            this.BtnCrearBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCrearBackup.UseVisualStyleBackColor = false;
            this.BtnCrearBackup.Click += new System.EventHandler(this.BtnCrearBackup_Click);
            // 
            // TabInstacias
            // 
            this.TabInstacias.Controls.Add(this.BtnLeerInstancias);
            this.TabInstacias.Controls.Add(this.ServidoresLabel2);
            this.TabInstacias.Controls.Add(this.BtnDesactivarInstancia);
            this.TabInstacias.Controls.Add(this.BtnActivarInstancia);
            this.TabInstacias.Controls.Add(this.BtnEliminarInstancia);
            this.TabInstacias.Controls.Add(this.BtnCrearInstancia);
            this.TabInstacias.Controls.Add(servidoresLabel1);
            this.TabInstacias.Controls.Add(this.InstanciaNueva);
            this.TabInstacias.Location = new System.Drawing.Point(4, 25);
            this.TabInstacias.Name = "TabInstacias";
            this.TabInstacias.Padding = new System.Windows.Forms.Padding(3);
            this.TabInstacias.Size = new System.Drawing.Size(673, 288);
            this.TabInstacias.TabIndex = 3;
            this.TabInstacias.Text = "Crear Instancias";
            this.TabInstacias.UseVisualStyleBackColor = true;
            // 
            // BtnLeerInstancias
            // 
            this.BtnLeerInstancias.Location = new System.Drawing.Point(47, 117);
            this.BtnLeerInstancias.Name = "BtnLeerInstancias";
            this.BtnLeerInstancias.Size = new System.Drawing.Size(75, 23);
            this.BtnLeerInstancias.TabIndex = 82;
            this.BtnLeerInstancias.Text = "&Buscar";
            this.BtnLeerInstancias.UseVisualStyleBackColor = true;
            this.BtnLeerInstancias.Click += new System.EventHandler(this.BtnLeerInstancias_Click);
            // 
            // ServidoresLabel2
            // 
            this.ServidoresLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtServidorBindingSource, "Servidores", true));
            this.ServidoresLabel2.Location = new System.Drawing.Point(111, 40);
            this.ServidoresLabel2.Name = "ServidoresLabel2";
            this.ServidoresLabel2.Size = new System.Drawing.Size(294, 23);
            this.ServidoresLabel2.TabIndex = 81;
            this.ServidoresLabel2.Text = "Info";
            // 
            // BtnDesactivarInstancia
            // 
            this.BtnDesactivarInstancia.Location = new System.Drawing.Point(47, 182);
            this.BtnDesactivarInstancia.Name = "BtnDesactivarInstancia";
            this.BtnDesactivarInstancia.Size = new System.Drawing.Size(75, 23);
            this.BtnDesactivarInstancia.TabIndex = 80;
            this.BtnDesactivarInstancia.Text = "&Desactivar";
            this.BtnDesactivarInstancia.UseVisualStyleBackColor = true;
            this.BtnDesactivarInstancia.Click += new System.EventHandler(this.BtnDesactivarInstancia_Click);
            // 
            // BtnActivarInstancia
            // 
            this.BtnActivarInstancia.Location = new System.Drawing.Point(47, 146);
            this.BtnActivarInstancia.Name = "BtnActivarInstancia";
            this.BtnActivarInstancia.Size = new System.Drawing.Size(75, 23);
            this.BtnActivarInstancia.TabIndex = 79;
            this.BtnActivarInstancia.Text = "&Activar";
            this.BtnActivarInstancia.UseVisualStyleBackColor = true;
            this.BtnActivarInstancia.Click += new System.EventHandler(this.BtnActivarInstancia_Click);
            // 
            // BtnEliminarInstancia
            // 
            this.BtnEliminarInstancia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminarInstancia.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarInstancia.FlatAppearance.BorderSize = 0;
            this.BtnEliminarInstancia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnEliminarInstancia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnEliminarInstancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarInstancia.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarInstancia.Image = global::PELOSCALVO.Properties.Resources.Cancelar;
            this.BtnEliminarInstancia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminarInstancia.Location = new System.Drawing.Point(223, 163);
            this.BtnEliminarInstancia.Name = "BtnEliminarInstancia";
            this.BtnEliminarInstancia.Size = new System.Drawing.Size(104, 42);
            this.BtnEliminarInstancia.TabIndex = 78;
            this.BtnEliminarInstancia.Text = "&Eliminar";
            this.BtnEliminarInstancia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminarInstancia.UseVisualStyleBackColor = false;
            this.BtnEliminarInstancia.Click += new System.EventHandler(this.BtnEliminarInstancia_Click);
            // 
            // BtnCrearInstancia
            // 
            this.BtnCrearInstancia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCrearInstancia.BackColor = System.Drawing.Color.Transparent;
            this.BtnCrearInstancia.FlatAppearance.BorderSize = 0;
            this.BtnCrearInstancia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnCrearInstancia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnCrearInstancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearInstancia.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearInstancia.Image = global::PELOSCALVO.Properties.Resources.Aceptar;
            this.BtnCrearInstancia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCrearInstancia.Location = new System.Drawing.Point(373, 163);
            this.BtnCrearInstancia.Name = "BtnCrearInstancia";
            this.BtnCrearInstancia.Size = new System.Drawing.Size(87, 42);
            this.BtnCrearInstancia.TabIndex = 77;
            this.BtnCrearInstancia.Text = "&Crear";
            this.BtnCrearInstancia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCrearInstancia.UseVisualStyleBackColor = false;
            this.BtnCrearInstancia.Click += new System.EventHandler(this.BtnCrearInstancia_Click);
            // 
            // InstanciaNueva
            // 
            this.InstanciaNueva.Location = new System.Drawing.Point(114, 17);
            this.InstanciaNueva.MaxLength = 40;
            this.InstanciaNueva.Name = "InstanciaNueva";
            this.InstanciaNueva.Size = new System.Drawing.Size(346, 20);
            this.InstanciaNueva.TabIndex = 1;
            // 
            // TabRestaurar
            // 
            this.TabRestaurar.Controls.Add(this.label8);
            this.TabRestaurar.Controls.Add(this.panel1);
            this.TabRestaurar.Controls.Add(this.BtnRestaurarBases);
            this.TabRestaurar.Location = new System.Drawing.Point(4, 25);
            this.TabRestaurar.Name = "TabRestaurar";
            this.TabRestaurar.Padding = new System.Windows.Forms.Padding(3);
            this.TabRestaurar.Size = new System.Drawing.Size(673, 288);
            this.TabRestaurar.TabIndex = 4;
            this.TabRestaurar.Text = "Resturar Base Datos";
            this.TabRestaurar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(2, 4, 2, 5);
            this.label8.Size = new System.Drawing.Size(155, 25);
            this.label8.TabIndex = 84;
            this.label8.Text = "Base Datos A Restaurar:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.labelRestaurar);
            this.panel1.Location = new System.Drawing.Point(190, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 51);
            this.panel1.TabIndex = 83;
            // 
            // labelRestaurar
            // 
            this.labelRestaurar.Location = new System.Drawing.Point(22, 18);
            this.labelRestaurar.Name = "labelRestaurar";
            this.labelRestaurar.Size = new System.Drawing.Size(294, 23);
            this.labelRestaurar.TabIndex = 82;
            // 
            // BtnRestaurarBases
            // 
            this.BtnRestaurarBases.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestaurarBases.BackColor = System.Drawing.Color.Transparent;
            this.BtnRestaurarBases.FlatAppearance.BorderSize = 0;
            this.BtnRestaurarBases.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnRestaurarBases.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnRestaurarBases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRestaurarBases.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestaurarBases.Image = global::PELOSCALVO.Properties.Resources.Aceptar;
            this.BtnRestaurarBases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRestaurarBases.Location = new System.Drawing.Point(341, 160);
            this.BtnRestaurarBases.Name = "BtnRestaurarBases";
            this.BtnRestaurarBases.Size = new System.Drawing.Size(106, 42);
            this.BtnRestaurarBases.TabIndex = 78;
            this.BtnRestaurarBases.Text = "&Restaurar";
            this.BtnRestaurarBases.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRestaurarBases.UseVisualStyleBackColor = false;
            this.BtnRestaurarBases.Click += new System.EventHandler(this.BtnRestaurarBases_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ListaNueva);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(673, 288);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Lista De Instancias";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ListaNueva
            // 
            this.ListaNueva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaNueva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ListaNueva.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaNueva.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ListaNueva.FormattingEnabled = true;
            this.ListaNueva.ItemHeight = 15;
            this.ListaNueva.Location = new System.Drawing.Point(20, 42);
            this.ListaNueva.Name = "ListaNueva";
            this.ListaNueva.Size = new System.Drawing.Size(550, 214);
            this.ListaNueva.TabIndex = 79;
            this.ListaNueva.Click += new System.EventHandler(this.ListaNueva_Click);
            // 
            // ListaBaseDatos
            // 
            this.ListaBaseDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaBaseDatos.FormattingEnabled = true;
            this.ListaBaseDatos.Location = new System.Drawing.Point(699, 50);
            this.ListaBaseDatos.Name = "ListaBaseDatos";
            this.ListaBaseDatos.Size = new System.Drawing.Size(155, 225);
            this.ListaBaseDatos.TabIndex = 78;
            this.ListaBaseDatos.SelectedIndexChanged += new System.EventHandler(this.ListaBaseDatos_SelectedIndexChanged);
            this.ListaBaseDatos.DoubleClick += new System.EventHandler(this.ListaBaseDatos_DoubleClick);
            // 
            // InfoProcesoText
            // 
            this.InfoProcesoText.AutoSize = true;
            this.InfoProcesoText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InfoProcesoText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoProcesoText.Location = new System.Drawing.Point(0, 336);
            this.InfoProcesoText.Margin = new System.Windows.Forms.Padding(3);
            this.InfoProcesoText.Name = "InfoProcesoText";
            this.InfoProcesoText.Padding = new System.Windows.Forms.Padding(2, 4, 2, 5);
            this.InfoProcesoText.Size = new System.Drawing.Size(202, 25);
            this.InfoProcesoText.TabIndex = 80;
            this.InfoProcesoText.Text = "Indica La Base De Datos a Crear";
            // 
            // FormCrearBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 361);
            this.Controls.Add(this.InfoProcesoText);
            this.Controls.Add(label2);
            this.Controls.Add(this.ListaBaseDatos);
            this.Controls.Add(this.TabCrear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCrearBaseDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bases De Datos";
            this.Load += new System.EventHandler(this.FormCrearBaseDatos_Load);
            this.TabCrear.ResumeLayout(false);
            this.TabBaseDatos.ResumeLayout(false);
            this.TabBaseDatos.PerformLayout();
            this.panelSql2.ResumeLayout(false);
            this.panelSql2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtServidorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsServidor)).EndInit();
            this.TabCrearTablas.ResumeLayout(false);
            this.TabCrearTablas.PerformLayout();
            this.tabPageBackup.ResumeLayout(false);
            this.tabPageBackup.PerformLayout();
            this.TabInstacias.ResumeLayout(false);
            this.TabInstacias.PerformLayout();
            this.TabRestaurar.ResumeLayout(false);
            this.TabRestaurar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreBaseDatos;
        public System.Windows.Forms.Button BtnCrearBaseDatos;
        private System.Windows.Forms.TabControl TabCrear;
        private System.Windows.Forms.TabPage TabBaseDatos;
        private System.Windows.Forms.TabPage TabCrearTablas;
        public System.Windows.Forms.Button BtnCrearTablas;
        private System.Windows.Forms.CheckBox CheckFacturacion;
        private System.Windows.Forms.CheckBox CheckClientes;
        private System.Windows.Forms.CheckBox CheckTablaArticulos;
        private System.Windows.Forms.Button BtnBuscarServidorCrear;
        private System.Windows.Forms.ComboBox ServidorCrear;
        private System.Windows.Forms.ListBox ListaBaseDatos;
        private DsServidor dsServidor;
        private System.Windows.Forms.BindingSource dtServidorBindingSource;
        private System.Windows.Forms.TabPage tabPageBackup;
        public System.Windows.Forms.Button BtnCrearBackup;
        private System.Windows.Forms.Label Backuptext;
        private System.Windows.Forms.Label NombreBaseTablas;
        private System.Windows.Forms.Label InfoProcesoText;
        private System.Windows.Forms.TabPage TabInstacias;
        private System.Windows.Forms.Button BtnDesactivarInstancia;
        private System.Windows.Forms.Button BtnActivarInstancia;
        public System.Windows.Forms.Button BtnEliminarInstancia;
        public System.Windows.Forms.Button BtnCrearInstancia;
        private System.Windows.Forms.TextBox InstanciaNueva;
        private System.Windows.Forms.Label ServidoresLabel2;
        private System.Windows.Forms.Label ServidoresLabel3;
        private System.Windows.Forms.Label ServidoresLabel4;
        private System.Windows.Forms.TabPage TabRestaurar;
        private System.Windows.Forms.Label labelRestaurar;
        public System.Windows.Forms.Button BtnRestaurarBases;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox ListaNueva;
        private System.Windows.Forms.Button BtnLeerInstancias;
        private System.Windows.Forms.ComboBox AutenticacionCrear;
        private System.Windows.Forms.Panel panelSql2;
        private System.Windows.Forms.ComboBox UsuarioSql2;
        private System.Windows.Forms.CheckBox checkPass2;
        private System.Windows.Forms.TextBox ContraseñaSql2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkEmpresas;
        private System.Windows.Forms.CheckBox checkTablas;
        public System.Windows.Forms.ComboBox SerieArticulosTabla;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox SerieClientesTabla;
    }
}