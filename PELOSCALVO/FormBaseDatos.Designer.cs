
namespace PELOSCALVO
{
    partial class FormBaseDatos
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
            System.Windows.Forms.Label labelARTICULOS;
            System.Windows.Forms.Label labelCLIENTES;
            System.Windows.Forms.Label tipoExtensionArticulosLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label idConexionConfiLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaseDatos));
            this.dtServidorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsServidor = new PELOSCALVO.DsServidor();
            this.CheckAtivarServidor = new System.Windows.Forms.RadioButton();
            this.CheckActivarDb = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureServidor = new System.Windows.Forms.PictureBox();
            this.PictureArchivo = new System.Windows.Forms.PictureBox();
            this.articulos = new PELOSCALVO.Articulos();
            this.dtInicioMultiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMultidatos = new PELOSCALVO.DsMultidatos();
            this.ErrorVer = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtConfiguracionPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TabArchivos = new System.Windows.Forms.TabPage();
            this.BtnCrearTbCliente = new System.Windows.Forms.Button();
            this.BtnCrearTbArticulos = new System.Windows.Forms.Button();
            this.BtnExaminarB = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.NombreArchivoDatos = new System.Windows.Forms.TextBox();
            this.SerieArticulosText = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.ContadorFactu = new System.Windows.Forms.Label();
            this.ContadorArticulos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RegistLbel = new System.Windows.Forms.Label();
            this.ContadorClientes = new System.Windows.Forms.Label();
            this.SerieClientesText2 = new System.Windows.Forms.ComboBox();
            this.BtnGuardarArchivo_Sql = new System.Windows.Forms.Button();
            this.BtnGuardarDatosArchivos = new System.Windows.Forms.Button();
            this.TipoExtension_b = new System.Windows.Forms.ComboBox();
            this.TabServidor = new System.Windows.Forms.TabPage();
            this.BtnGuardarServidores = new System.Windows.Forms.Button();
            this.Servidor = new System.Windows.Forms.ComboBox();
            this.InfoProcesoText2 = new System.Windows.Forms.Label();
            this.BtnPobarSql = new System.Windows.Forms.Button();
            this.ListaBaseDatos2 = new System.Windows.Forms.ListBox();
            this.BaseDatos = new System.Windows.Forms.ComboBox();
            this.BtnBuscarServidor = new System.Windows.Forms.Button();
            this.panelSql1 = new System.Windows.Forms.Panel();
            this.UsuarioSql = new System.Windows.Forms.ComboBox();
            this.checkPass = new System.Windows.Forms.CheckBox();
            this.ContraseñaSql = new System.Windows.Forms.TextBox();
            this.ActualizarServidores = new System.Windows.Forms.Button();
            this.Autenticacion = new System.Windows.Forms.ComboBox();
            this.TabArchivoSql = new System.Windows.Forms.TabControl();
            this.BtnPrueba = new System.Windows.Forms.Button();
            this.BtnRestablecer = new System.Windows.Forms.Button();
            this.Info_Res = new System.Windows.Forms.Label();
            labelARTICULOS = new System.Windows.Forms.Label();
            labelCLIENTES = new System.Windows.Forms.Label();
            tipoExtensionArticulosLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            idConexionConfiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtServidorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsServidor)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureServidor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureArchivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TabArchivos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TabServidor.SuspendLayout();
            this.panelSql1.SuspendLayout();
            this.TabArchivoSql.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelARTICULOS
            // 
            labelARTICULOS.AutoSize = true;
            labelARTICULOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelARTICULOS.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelARTICULOS.Location = new System.Drawing.Point(11, 56);
            labelARTICULOS.Name = "labelARTICULOS";
            labelARTICULOS.Size = new System.Drawing.Size(133, 26);
            labelARTICULOS.TabIndex = 27;
            labelARTICULOS.Tag = "";
            labelARTICULOS.Text = "ARTICULOS";
            labelARTICULOS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCLIENTES
            // 
            labelCLIENTES.AutoSize = true;
            labelCLIENTES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelCLIENTES.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCLIENTES.Location = new System.Drawing.Point(29, 96);
            labelCLIENTES.Name = "labelCLIENTES";
            labelCLIENTES.Size = new System.Drawing.Size(115, 26);
            labelCLIENTES.TabIndex = 27;
            labelCLIENTES.Text = "CLIENTES";
            labelCLIENTES.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipoExtensionArticulosLabel
            // 
            tipoExtensionArticulosLabel.AutoSize = true;
            tipoExtensionArticulosLabel.Location = new System.Drawing.Point(293, 126);
            tipoExtensionArticulosLabel.Name = "tipoExtensionArticulosLabel";
            tipoExtensionArticulosLabel.Size = new System.Drawing.Size(56, 13);
            tipoExtensionArticulosLabel.TabIndex = 69;
            tipoExtensionArticulosLabel.Text = "Extension:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(61, 109);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(36, 13);
            label4.TabIndex = 69;
            label4.Text = "encts:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(44, 24);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 13);
            label2.TabIndex = 69;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(26, 63);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(64, 13);
            label3.TabIndex = 70;
            label3.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(35, 73);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 13);
            label1.TabIndex = 55;
            label1.Text = "Base Datos:";
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(569, 12);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(92, 13);
            label5.TabIndex = 81;
            label5.Text = "Lista Bases Datos";
            // 
            // idConexionConfiLabel
            // 
            idConexionConfiLabel.AutoSize = true;
            idConexionConfiLabel.Location = new System.Drawing.Point(48, 41);
            idConexionConfiLabel.Name = "idConexionConfiLabel";
            idConexionConfiLabel.Size = new System.Drawing.Size(49, 13);
            idConexionConfiLabel.TabIndex = 54;
            idConexionConfiLabel.Text = "Servidor:";
            idConexionConfiLabel.Click += new System.EventHandler(this.idConexionConfiLabel_Click);
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
            // CheckAtivarServidor
            // 
            this.CheckAtivarServidor.AutoCheck = false;
            this.CheckAtivarServidor.AutoSize = true;
            this.CheckAtivarServidor.Location = new System.Drawing.Point(37, 51);
            this.CheckAtivarServidor.Name = "CheckAtivarServidor";
            this.CheckAtivarServidor.Size = new System.Drawing.Size(64, 17);
            this.CheckAtivarServidor.TabIndex = 64;
            this.CheckAtivarServidor.Text = "Servidor";
            this.CheckAtivarServidor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckAtivarServidor.UseVisualStyleBackColor = true;
            this.CheckAtivarServidor.CheckedChanged += new System.EventHandler(this.CheckAtivarServidor_CheckedChanged);
            this.CheckAtivarServidor.Click += new System.EventHandler(this.CheckAtivarServidor_Click);
            // 
            // CheckActivarDb
            // 
            this.CheckActivarDb.AutoCheck = false;
            this.CheckActivarDb.AutoSize = true;
            this.CheckActivarDb.Location = new System.Drawing.Point(37, 13);
            this.CheckActivarDb.Name = "CheckActivarDb";
            this.CheckActivarDb.Size = new System.Drawing.Size(61, 17);
            this.CheckActivarDb.TabIndex = 65;
            this.CheckActivarDb.Text = "Archivo";
            this.CheckActivarDb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckActivarDb.UseVisualStyleBackColor = true;
            this.CheckActivarDb.CheckedChanged += new System.EventHandler(this.CheckActivarDb_CheckedChanged);
            this.CheckActivarDb.Click += new System.EventHandler(this.CheckActivarDb_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PictureServidor);
            this.panel1.Controls.Add(this.CheckActivarDb);
            this.panel1.Controls.Add(this.PictureArchivo);
            this.panel1.Controls.Add(this.CheckAtivarServidor);
            this.panel1.Location = new System.Drawing.Point(139, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 85);
            this.panel1.TabIndex = 66;
            this.panel1.Tag = "";
            // 
            // PictureServidor
            // 
            this.PictureServidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureServidor.Image = global::PELOSCALVO.Properties.Resources.CIRCULO_ROJO1;
            this.PictureServidor.Location = new System.Drawing.Point(10, 51);
            this.PictureServidor.Name = "PictureServidor";
            this.PictureServidor.Size = new System.Drawing.Size(22, 22);
            this.PictureServidor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureServidor.TabIndex = 85;
            this.PictureServidor.TabStop = false;
            // 
            // PictureArchivo
            // 
            this.PictureArchivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureArchivo.Image = global::PELOSCALVO.Properties.Resources.CIRCULO_ROJO1;
            this.PictureArchivo.Location = new System.Drawing.Point(10, 13);
            this.PictureArchivo.Name = "PictureArchivo";
            this.PictureArchivo.Size = new System.Drawing.Size(22, 22);
            this.PictureArchivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureArchivo.TabIndex = 84;
            this.PictureArchivo.TabStop = false;
            // 
            // articulos
            // 
            this.articulos.DataSetName = "Articulos";
            this.articulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // ErrorVer
            // 
            this.ErrorVer.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.ErrorVer.ContainerControl = this;
            // 
            // dtConfiguracionPrincipalBindingSource
            // 
            this.dtConfiguracionPrincipalBindingSource.DataMember = "DtConfiguracionPrincipal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(357, 367);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // TabArchivos
            // 
            this.TabArchivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TabArchivos.Controls.Add(this.Info_Res);
            this.TabArchivos.Controls.Add(this.BtnRestablecer);
            this.TabArchivos.Controls.Add(this.BtnCrearTbCliente);
            this.TabArchivos.Controls.Add(this.BtnCrearTbArticulos);
            this.TabArchivos.Controls.Add(this.BtnExaminarB);
            this.TabArchivos.Controls.Add(this.label6);
            this.TabArchivos.Controls.Add(this.NombreArchivoDatos);
            this.TabArchivos.Controls.Add(labelARTICULOS);
            this.TabArchivos.Controls.Add(labelCLIENTES);
            this.TabArchivos.Controls.Add(this.SerieArticulosText);
            this.TabArchivos.Controls.Add(this.panel2);
            this.TabArchivos.Controls.Add(this.SerieClientesText2);
            this.TabArchivos.Controls.Add(this.BtnGuardarArchivo_Sql);
            this.TabArchivos.Controls.Add(tipoExtensionArticulosLabel);
            this.TabArchivos.Controls.Add(this.BtnGuardarDatosArchivos);
            this.TabArchivos.Controls.Add(this.TipoExtension_b);
            this.TabArchivos.Location = new System.Drawing.Point(4, 22);
            this.TabArchivos.Name = "TabArchivos";
            this.TabArchivos.Padding = new System.Windows.Forms.Padding(3);
            this.TabArchivos.Size = new System.Drawing.Size(733, 315);
            this.TabArchivos.TabIndex = 2;
            this.TabArchivos.Tag = "NO";
            this.TabArchivos.Text = "CONFIGURAR ARCHIVOS";
            // 
            // BtnCrearTbCliente
            // 
            this.BtnCrearTbCliente.Location = new System.Drawing.Point(456, 96);
            this.BtnCrearTbCliente.Name = "BtnCrearTbCliente";
            this.BtnCrearTbCliente.Size = new System.Drawing.Size(75, 23);
            this.BtnCrearTbCliente.TabIndex = 96;
            this.BtnCrearTbCliente.Text = "&Crear";
            this.BtnCrearTbCliente.UseVisualStyleBackColor = true;
            this.BtnCrearTbCliente.Click += new System.EventHandler(this.BtnCrearTbCliente_Click);
            // 
            // BtnCrearTbArticulos
            // 
            this.BtnCrearTbArticulos.Location = new System.Drawing.Point(456, 56);
            this.BtnCrearTbArticulos.Name = "BtnCrearTbArticulos";
            this.BtnCrearTbArticulos.Size = new System.Drawing.Size(75, 23);
            this.BtnCrearTbArticulos.TabIndex = 95;
            this.BtnCrearTbArticulos.Text = "&Crear";
            this.BtnCrearTbArticulos.UseVisualStyleBackColor = true;
            this.BtnCrearTbArticulos.Click += new System.EventHandler(this.BtnCrearTbArticulos_Click);
            // 
            // BtnExaminarB
            // 
            this.BtnExaminarB.Location = new System.Drawing.Point(438, 17);
            this.BtnExaminarB.Name = "BtnExaminarB";
            this.BtnExaminarB.Size = new System.Drawing.Size(75, 23);
            this.BtnExaminarB.TabIndex = 94;
            this.BtnExaminarB.Text = "&Examinar";
            this.BtnExaminarB.UseVisualStyleBackColor = true;
            this.BtnExaminarB.Click += new System.EventHandler(this.BtnExaminarB_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 93;
            this.label6.Text = "Nombre Archivo principal:";
            // 
            // NombreArchivoDatos
            // 
            this.NombreArchivoDatos.Location = new System.Drawing.Point(150, 19);
            this.NombreArchivoDatos.Name = "NombreArchivoDatos";
            this.NombreArchivoDatos.ReadOnly = true;
            this.NombreArchivoDatos.Size = new System.Drawing.Size(271, 20);
            this.NombreArchivoDatos.TabIndex = 92;
            this.NombreArchivoDatos.Tag = "";
            this.NombreArchivoDatos.Text = "Datos App Peloscalvo";
            // 
            // SerieArticulosText
            // 
            this.SerieArticulosText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "ArchivoArticulos", true));
            this.SerieArticulosText.DisplayMember = "A";
            this.SerieArticulosText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SerieArticulosText.FormattingEnabled = true;
            this.SerieArticulosText.Items.AddRange(new object[] {
            "Tarifa1",
            "Tarifa2",
            "Tarifa3",
            "Tarifa4",
            "Tarifa5",
            "Tarifa6"});
            this.SerieArticulosText.Location = new System.Drawing.Point(150, 56);
            this.SerieArticulosText.Name = "SerieArticulosText";
            this.SerieArticulosText.Size = new System.Drawing.Size(300, 21);
            this.SerieArticulosText.TabIndex = 24;
            this.SerieArticulosText.SelectedIndexChanged += new System.EventHandler(this.SerieArticulosText_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.ContadorFactu);
            this.panel2.Controls.Add(this.ContadorArticulos);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.RegistLbel);
            this.panel2.Controls.Add(this.ContadorClientes);
            this.panel2.Location = new System.Drawing.Point(25, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 129);
            this.panel2.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 20);
            this.label8.TabIndex = 87;
            this.label8.Tag = "";
            this.label8.Text = "Total reguistros Articulos:";
            // 
            // ContadorFactu
            // 
            this.ContadorFactu.AutoSize = true;
            this.ContadorFactu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContadorFactu.Location = new System.Drawing.Point(206, 86);
            this.ContadorFactu.Name = "ContadorFactu";
            this.ContadorFactu.Size = new System.Drawing.Size(19, 20);
            this.ContadorFactu.TabIndex = 90;
            this.ContadorFactu.Text = "0";
            this.ContadorFactu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ContadorArticulos
            // 
            this.ContadorArticulos.AutoSize = true;
            this.ContadorArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContadorArticulos.Location = new System.Drawing.Point(206, 20);
            this.ContadorArticulos.Name = "ContadorArticulos";
            this.ContadorArticulos.Size = new System.Drawing.Size(19, 20);
            this.ContadorArticulos.TabIndex = 84;
            this.ContadorArticulos.Text = "0";
            this.ContadorArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 20);
            this.label7.TabIndex = 89;
            this.label7.Tag = "";
            this.label7.Text = "Total reguistros Empresas:";
            // 
            // RegistLbel
            // 
            this.RegistLbel.AutoSize = true;
            this.RegistLbel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistLbel.Location = new System.Drawing.Point(4, 55);
            this.RegistLbel.Name = "RegistLbel";
            this.RegistLbel.Size = new System.Drawing.Size(180, 20);
            this.RegistLbel.TabIndex = 85;
            this.RegistLbel.Tag = "";
            this.RegistLbel.Text = "Total reguistros clientes:";
            // 
            // ContadorClientes
            // 
            this.ContadorClientes.AutoSize = true;
            this.ContadorClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContadorClientes.Location = new System.Drawing.Point(206, 55);
            this.ContadorClientes.Name = "ContadorClientes";
            this.ContadorClientes.Size = new System.Drawing.Size(19, 20);
            this.ContadorClientes.TabIndex = 86;
            this.ContadorClientes.Text = "0";
            this.ContadorClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SerieClientesText2
            // 
            this.SerieClientesText2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "ArchivoClientes", true));
            this.SerieClientesText2.DisplayMember = "A";
            this.SerieClientesText2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SerieClientesText2.FormattingEnabled = true;
            this.SerieClientesText2.Items.AddRange(new object[] {
            "Listado1",
            "Listado2",
            "Listado3",
            "Listado4",
            "Listado5",
            "Listado6"});
            this.SerieClientesText2.Location = new System.Drawing.Point(150, 96);
            this.SerieClientesText2.Name = "SerieClientesText2";
            this.SerieClientesText2.Size = new System.Drawing.Size(300, 21);
            this.SerieClientesText2.TabIndex = 24;
            this.SerieClientesText2.SelectedIndexChanged += new System.EventHandler(this.SerieClientesText2_SelectedIndexChanged);
            // 
            // BtnGuardarArchivo_Sql
            // 
            this.BtnGuardarArchivo_Sql.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarArchivo_Sql.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarArchivo_Sql.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardarArchivo_Sql.FlatAppearance.BorderSize = 0;
            this.BtnGuardarArchivo_Sql.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnGuardarArchivo_Sql.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnGuardarArchivo_Sql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarArchivo_Sql.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarArchivo_Sql.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_check_mark_9_24;
            this.BtnGuardarArchivo_Sql.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarArchivo_Sql.Location = new System.Drawing.Point(529, 265);
            this.BtnGuardarArchivo_Sql.Name = "BtnGuardarArchivo_Sql";
            this.BtnGuardarArchivo_Sql.Size = new System.Drawing.Size(189, 42);
            this.BtnGuardarArchivo_Sql.TabIndex = 88;
            this.BtnGuardarArchivo_Sql.Text = "Activar ServidorRed";
            this.BtnGuardarArchivo_Sql.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarArchivo_Sql.UseVisualStyleBackColor = false;
            this.BtnGuardarArchivo_Sql.Click += new System.EventHandler(this.BtnGuardarArchivo_Sql_Click);
            // 
            // BtnGuardarDatosArchivos
            // 
            this.BtnGuardarDatosArchivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarDatosArchivos.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarDatosArchivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardarDatosArchivos.FlatAppearance.BorderSize = 0;
            this.BtnGuardarDatosArchivos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnGuardarDatosArchivos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnGuardarDatosArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarDatosArchivos.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarDatosArchivos.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_check_mark_9_24;
            this.BtnGuardarDatosArchivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarDatosArchivos.Location = new System.Drawing.Point(529, 217);
            this.BtnGuardarDatosArchivos.Name = "BtnGuardarDatosArchivos";
            this.BtnGuardarDatosArchivos.Size = new System.Drawing.Size(189, 42);
            this.BtnGuardarDatosArchivos.TabIndex = 53;
            this.BtnGuardarDatosArchivos.Text = "Activar Archivo Local";
            this.BtnGuardarDatosArchivos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarDatosArchivos.UseVisualStyleBackColor = false;
            this.BtnGuardarDatosArchivos.Click += new System.EventHandler(this.BtnGuardarDatosArchivos_Click);
            // 
            // TipoExtension_b
            // 
            this.TipoExtension_b.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "TipoExtensionArticulos", true));
            this.TipoExtension_b.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoExtension_b.FormattingEnabled = true;
            this.TipoExtension_b.Items.AddRange(new object[] {
            "DBF",
            "mdb",
            "accdb"});
            this.TipoExtension_b.Location = new System.Drawing.Point(355, 123);
            this.TipoExtension_b.Name = "TipoExtension_b";
            this.TipoExtension_b.Size = new System.Drawing.Size(95, 21);
            this.TipoExtension_b.TabIndex = 70;
            this.TipoExtension_b.SelectedIndexChanged += new System.EventHandler(this.TipoExtension_b_SelectedIndexChanged);
            // 
            // TabServidor
            // 
            this.TabServidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TabServidor.Controls.Add(this.BtnGuardarServidores);
            this.TabServidor.Controls.Add(this.Servidor);
            this.TabServidor.Controls.Add(this.InfoProcesoText2);
            this.TabServidor.Controls.Add(idConexionConfiLabel);
            this.TabServidor.Controls.Add(this.BtnPobarSql);
            this.TabServidor.Controls.Add(label5);
            this.TabServidor.Controls.Add(label1);
            this.TabServidor.Controls.Add(this.ListaBaseDatos2);
            this.TabServidor.Controls.Add(this.BaseDatos);
            this.TabServidor.Controls.Add(this.BtnBuscarServidor);
            this.TabServidor.Controls.Add(this.panelSql1);
            this.TabServidor.Controls.Add(this.ActualizarServidores);
            this.TabServidor.Controls.Add(label4);
            this.TabServidor.Controls.Add(this.Autenticacion);
            this.TabServidor.Location = new System.Drawing.Point(4, 22);
            this.TabServidor.Name = "TabServidor";
            this.TabServidor.Padding = new System.Windows.Forms.Padding(3);
            this.TabServidor.Size = new System.Drawing.Size(733, 315);
            this.TabServidor.TabIndex = 1;
            this.TabServidor.Text = "SERVIDOR";
            // 
            // BtnGuardarServidores
            // 
            this.BtnGuardarServidores.AllowDrop = true;
            this.BtnGuardarServidores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarServidores.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarServidores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardarServidores.FlatAppearance.BorderSize = 0;
            this.BtnGuardarServidores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnGuardarServidores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnGuardarServidores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarServidores.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarServidores.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_check_mark_9_24;
            this.BtnGuardarServidores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarServidores.Location = new System.Drawing.Point(613, 259);
            this.BtnGuardarServidores.Name = "BtnGuardarServidores";
            this.BtnGuardarServidores.Size = new System.Drawing.Size(112, 42);
            this.BtnGuardarServidores.TabIndex = 84;
            this.BtnGuardarServidores.Text = "&Guardar";
            this.BtnGuardarServidores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarServidores.UseVisualStyleBackColor = false;
            this.BtnGuardarServidores.Click += new System.EventHandler(this.BtnGuardarServidores_Click);
            // 
            // Servidor
            // 
            this.Servidor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtServidorBindingSource, "Servidores", true));
            this.Servidor.DataSource = this.dtServidorBindingSource;
            this.Servidor.DisplayMember = "Servidores";
            this.Servidor.FormattingEnabled = true;
            this.Servidor.Location = new System.Drawing.Point(100, 38);
            this.Servidor.Name = "Servidor";
            this.Servidor.Size = new System.Drawing.Size(291, 21);
            this.Servidor.TabIndex = 57;
            this.Servidor.Tag = "PARAR";
            this.Servidor.SelectedIndexChanged += new System.EventHandler(this.Servidor_SelectedIndexChanged);
            this.Servidor.Enter += new System.EventHandler(this.Servidor_Enter);
            this.Servidor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Servidor_KeyPress);
            this.Servidor.Validated += new System.EventHandler(this.Servidor_Validated);
            // 
            // InfoProcesoText2
            // 
            this.InfoProcesoText2.AutoSize = true;
            this.InfoProcesoText2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InfoProcesoText2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoProcesoText2.Location = new System.Drawing.Point(3, 287);
            this.InfoProcesoText2.Margin = new System.Windows.Forms.Padding(3);
            this.InfoProcesoText2.Name = "InfoProcesoText2";
            this.InfoProcesoText2.Padding = new System.Windows.Forms.Padding(2, 4, 2, 5);
            this.InfoProcesoText2.Size = new System.Drawing.Size(175, 25);
            this.InfoProcesoText2.TabIndex = 82;
            this.InfoProcesoText2.Text = "Selecione Servidor a Buscar";
            // 
            // BtnPobarSql
            // 
            this.BtnPobarSql.Location = new System.Drawing.Point(473, 217);
            this.BtnPobarSql.Name = "BtnPobarSql";
            this.BtnPobarSql.Size = new System.Drawing.Size(57, 30);
            this.BtnPobarSql.TabIndex = 67;
            this.BtnPobarSql.Text = "Probar conexion";
            this.BtnPobarSql.UseVisualStyleBackColor = true;
            this.BtnPobarSql.Click += new System.EventHandler(this.BtnPobarSql_Click);
            // 
            // ListaBaseDatos2
            // 
            this.ListaBaseDatos2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaBaseDatos2.FormattingEnabled = true;
            this.ListaBaseDatos2.Location = new System.Drawing.Point(570, 28);
            this.ListaBaseDatos2.Name = "ListaBaseDatos2";
            this.ListaBaseDatos2.Size = new System.Drawing.Size(155, 225);
            this.ListaBaseDatos2.TabIndex = 80;
            this.ListaBaseDatos2.Click += new System.EventHandler(this.ListaBaseDatos2_Click);
            this.ListaBaseDatos2.SelectedIndexChanged += new System.EventHandler(this.ListaBaseDatos2_SelectedIndexChanged);
            // 
            // BaseDatos
            // 
            this.BaseDatos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtServidorBindingSource, "BaseDatos", true));
            this.BaseDatos.FormattingEnabled = true;
            this.BaseDatos.Location = new System.Drawing.Point(100, 70);
            this.BaseDatos.Name = "BaseDatos";
            this.BaseDatos.Size = new System.Drawing.Size(291, 21);
            this.BaseDatos.TabIndex = 58;
            this.BaseDatos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BaseDatos_KeyPress);
            // 
            // BtnBuscarServidor
            // 
            this.BtnBuscarServidor.Location = new System.Drawing.Point(403, 38);
            this.BtnBuscarServidor.Name = "BtnBuscarServidor";
            this.BtnBuscarServidor.Size = new System.Drawing.Size(48, 23);
            this.BtnBuscarServidor.TabIndex = 72;
            this.BtnBuscarServidor.Text = "Buscar";
            this.BtnBuscarServidor.UseVisualStyleBackColor = true;
            this.BtnBuscarServidor.Click += new System.EventHandler(this.BtnBuscarServidor_Click);
            // 
            // panelSql1
            // 
            this.panelSql1.Controls.Add(this.UsuarioSql);
            this.panelSql1.Controls.Add(this.checkPass);
            this.panelSql1.Controls.Add(this.ContraseñaSql);
            this.panelSql1.Controls.Add(label3);
            this.panelSql1.Controls.Add(label2);
            this.panelSql1.Location = new System.Drawing.Point(14, 133);
            this.panelSql1.Name = "panelSql1";
            this.panelSql1.Size = new System.Drawing.Size(446, 120);
            this.panelSql1.TabIndex = 68;
            this.panelSql1.Tag = "SI";
            // 
            // UsuarioSql
            // 
            this.UsuarioSql.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtServidorBindingSource, "UsusarioSql", true));
            this.UsuarioSql.FormattingEnabled = true;
            this.UsuarioSql.Location = new System.Drawing.Point(93, 16);
            this.UsuarioSql.Name = "UsuarioSql";
            this.UsuarioSql.Size = new System.Drawing.Size(291, 21);
            this.UsuarioSql.TabIndex = 73;
            // 
            // checkPass
            // 
            this.checkPass.AutoSize = true;
            this.checkPass.Location = new System.Drawing.Point(376, 62);
            this.checkPass.Name = "checkPass";
            this.checkPass.Size = new System.Drawing.Size(61, 17);
            this.checkPass.TabIndex = 72;
            this.checkPass.Text = "Mostrar";
            this.checkPass.UseVisualStyleBackColor = true;
            this.checkPass.CheckedChanged += new System.EventHandler(this.checkPass_CheckedChanged);
            // 
            // ContraseñaSql
            // 
            this.ContraseñaSql.Location = new System.Drawing.Point(93, 60);
            this.ContraseñaSql.Name = "ContraseñaSql";
            this.ContraseñaSql.PasswordChar = '*';
            this.ContraseñaSql.Size = new System.Drawing.Size(269, 20);
            this.ContraseñaSql.TabIndex = 71;
            // 
            // ActualizarServidores
            // 
            this.ActualizarServidores.Location = new System.Drawing.Point(457, 38);
            this.ActualizarServidores.Name = "ActualizarServidores";
            this.ActualizarServidores.Size = new System.Drawing.Size(75, 23);
            this.ActualizarServidores.TabIndex = 71;
            this.ActualizarServidores.Text = "Actualizar";
            this.ActualizarServidores.UseVisualStyleBackColor = true;
            this.ActualizarServidores.Click += new System.EventHandler(this.ActualizarServidores_Click);
            // 
            // Autenticacion
            // 
            this.Autenticacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Autenticacion.FormattingEnabled = true;
            this.Autenticacion.Items.AddRange(new object[] {
            "Autenticacion De Windows",
            "Autenticacion De SQL Server"});
            this.Autenticacion.Location = new System.Drawing.Point(100, 106);
            this.Autenticacion.Name = "Autenticacion";
            this.Autenticacion.Size = new System.Drawing.Size(291, 21);
            this.Autenticacion.TabIndex = 70;
            this.Autenticacion.SelectedIndexChanged += new System.EventHandler(this.Autenticacion_SelectedIndexChanged);
            // 
            // TabArchivoSql
            // 
            this.TabArchivoSql.Controls.Add(this.TabServidor);
            this.TabArchivoSql.Controls.Add(this.TabArchivos);
            this.TabArchivoSql.Location = new System.Drawing.Point(0, 0);
            this.TabArchivoSql.Name = "TabArchivoSql";
            this.TabArchivoSql.SelectedIndex = 0;
            this.TabArchivoSql.Size = new System.Drawing.Size(741, 341);
            this.TabArchivoSql.TabIndex = 83;
            // 
            // BtnPrueba
            // 
            this.BtnPrueba.Location = new System.Drawing.Point(516, 370);
            this.BtnPrueba.Name = "BtnPrueba";
            this.BtnPrueba.Size = new System.Drawing.Size(75, 23);
            this.BtnPrueba.TabIndex = 86;
            this.BtnPrueba.Text = "prueba";
            this.BtnPrueba.UseVisualStyleBackColor = true;
            this.BtnPrueba.Click += new System.EventHandler(this.BtnPrueba_Click);
            // 
            // BtnRestablecer
            // 
            this.BtnRestablecer.BackColor = System.Drawing.Color.DarkKhaki;
            this.BtnRestablecer.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnRestablecer.Location = new System.Drawing.Point(643, 160);
            this.BtnRestablecer.Name = "BtnRestablecer";
            this.BtnRestablecer.Size = new System.Drawing.Size(75, 23);
            this.BtnRestablecer.TabIndex = 97;
            this.BtnRestablecer.Text = "&Restablecer";
            this.BtnRestablecer.UseVisualStyleBackColor = false;
            this.BtnRestablecer.Click += new System.EventHandler(this.BtnRestablecer_Click);
            this.BtnRestablecer.Enter += new System.EventHandler(this.BtnRestablecer_Enter);
            this.BtnRestablecer.Leave += new System.EventHandler(this.BtnRestablecer_Leave);
            // 
            // Info_Res
            // 
            this.Info_Res.AutoSize = true;
            this.Info_Res.BackColor = System.Drawing.Color.Gold;
            this.Info_Res.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Info_Res.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Info_Res.Location = new System.Drawing.Point(435, 165);
            this.Info_Res.Name = "Info_Res";
            this.Info_Res.Size = new System.Drawing.Size(201, 15);
            this.Info_Res.TabIndex = 98;
            this.Info_Res.Text = "Cierra toda Conexion y Restablece datos";
            this.Info_Res.Visible = false;
            // 
            // FormBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 453);
            this.Controls.Add(this.BtnPrueba);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TabArchivoSql);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBaseDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base Datos";
            this.Load += new System.EventHandler(this.FormBaseDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtServidorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsServidor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureServidor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureArchivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TabArchivos.ResumeLayout(false);
            this.TabArchivos.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TabServidor.ResumeLayout(false);
            this.TabServidor.PerformLayout();
            this.panelSql1.ResumeLayout(false);
            this.panelSql1.PerformLayout();
            this.TabArchivoSql.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton CheckAtivarServidor;
        private System.Windows.Forms.RadioButton CheckActivarDb;
        private System.Windows.Forms.Panel panel1;
        public Articulos articulos;
        private System.Windows.Forms.BindingSource dtServidorBindingSource;
        private DsServidor dsServidor;
        private System.Windows.Forms.BindingSource dtInicioMultiBindingSource;
        private DsMultidatos dsMultidatos;
        private System.Windows.Forms.ErrorProvider ErrorVer;
        public System.Windows.Forms.BindingSource dtConfiguracionPrincipalBindingSource;
        private System.Windows.Forms.PictureBox PictureServidor;
        private System.Windows.Forms.PictureBox PictureArchivo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl TabArchivoSql;
        private System.Windows.Forms.TabPage TabServidor;
        public System.Windows.Forms.Button BtnGuardarServidores;
        private System.Windows.Forms.ComboBox Servidor;
        private System.Windows.Forms.Label InfoProcesoText2;
        private System.Windows.Forms.Button BtnPobarSql;
        private System.Windows.Forms.ListBox ListaBaseDatos2;
        private System.Windows.Forms.ComboBox BaseDatos;
        private System.Windows.Forms.Button BtnBuscarServidor;
        private System.Windows.Forms.Panel panelSql1;
        private System.Windows.Forms.ComboBox UsuarioSql;
        private System.Windows.Forms.CheckBox checkPass;
        private System.Windows.Forms.TextBox ContraseñaSql;
        private System.Windows.Forms.Button ActualizarServidores;
        private System.Windows.Forms.ComboBox Autenticacion;
        private System.Windows.Forms.TabPage TabArchivos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ContadorClientes;
        private System.Windows.Forms.Label RegistLbel;
        private System.Windows.Forms.Label ContadorArticulos;
        public System.Windows.Forms.Button BtnGuardarDatosArchivos;
        public System.Windows.Forms.ComboBox SerieClientesText2;
        public System.Windows.Forms.ComboBox TipoExtension_b;
        public System.Windows.Forms.ComboBox SerieArticulosText;
        public System.Windows.Forms.Button BtnGuardarArchivo_Sql;
        private System.Windows.Forms.Label ContadorFactu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnPrueba;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnExaminarB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NombreArchivoDatos;
        private System.Windows.Forms.Button BtnCrearTbArticulos;
        private System.Windows.Forms.Button BtnCrearTbCliente;
        private System.Windows.Forms.Button BtnRestablecer;
        private System.Windows.Forms.Label Info_Res;
    }
}