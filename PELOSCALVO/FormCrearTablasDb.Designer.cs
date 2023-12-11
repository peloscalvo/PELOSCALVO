
namespace PELOSCALVO
{
    partial class FormCrearTablasDb
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearTablasDb));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnTablasCrear = new System.Windows.Forms.Button();
            this.Info_Res = new System.Windows.Forms.Label();
            this.BtnCrearTablaCli = new System.Windows.Forms.Button();
            this.BtnCrearTablaArti = new System.Windows.Forms.Button();
            this.BtnExaminarT = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BaseDatosTxt1 = new System.Windows.Forms.TextBox();
            this.ArticulosTxt = new System.Windows.Forms.ComboBox();
            this.dtInicioMultiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMultidatos = new PELOSCALVO.DsMultidatos();
            this.ClientesTxt = new System.Windows.Forms.ComboBox();
            this.ExtensionTxt = new System.Windows.Forms.ComboBox();
            this.BtnRestablecer_t = new System.Windows.Forms.Button();
            this.BtnSalirT = new System.Windows.Forms.Button();
            this.ErrorVer = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnConectar = new System.Windows.Forms.Button();
            this.TabControlPrincipal = new System.Windows.Forms.TabControl();
            this.TabInicio = new System.Windows.Forms.TabPage();
            this.ChckListar = new System.Windows.Forms.CheckBox();
            this.TabCopia = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.BaseDatos2 = new System.Windows.Forms.TextBox();
            this.BtnCrearBackupDb = new System.Windows.Forms.Button();
            this.TabCopiarTabla = new System.Windows.Forms.TabPage();
            this.TablaCopiarTxt = new System.Windows.Forms.TextBox();
            this.ListaTablasPrincipal = new System.Windows.Forms.ListBox();
            this.TablanuevaTxt = new System.Windows.Forms.ComboBox();
            this.BtnCopiarTabla = new System.Windows.Forms.Button();
            this.InfoProcesoText = new System.Windows.Forms.Label();
            this.dsCONFIGURACCION = new PELOSCALVO.DsCONFIGURACCION();
            this.dtConfiguracionPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            labelARTICULOS = new System.Windows.Forms.Label();
            labelCLIENTES = new System.Windows.Forms.Label();
            tipoExtensionArticulosLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorVer)).BeginInit();
            this.TabControlPrincipal.SuspendLayout();
            this.TabInicio.SuspendLayout();
            this.TabCopia.SuspendLayout();
            this.TabCopiarTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelARTICULOS
            // 
            labelARTICULOS.AutoSize = true;
            labelARTICULOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelARTICULOS.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelARTICULOS.Location = new System.Drawing.Point(16, 76);
            labelARTICULOS.Name = "labelARTICULOS";
            labelARTICULOS.Size = new System.Drawing.Size(133, 26);
            labelARTICULOS.TabIndex = 102;
            labelARTICULOS.Tag = "";
            labelARTICULOS.Text = "ARTICULOS";
            labelARTICULOS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCLIENTES
            // 
            labelCLIENTES.AutoSize = true;
            labelCLIENTES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelCLIENTES.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCLIENTES.Location = new System.Drawing.Point(34, 116);
            labelCLIENTES.Name = "labelCLIENTES";
            labelCLIENTES.Size = new System.Drawing.Size(115, 26);
            labelCLIENTES.TabIndex = 103;
            labelCLIENTES.Text = "CLIENTES";
            labelCLIENTES.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipoExtensionArticulosLabel
            // 
            tipoExtensionArticulosLabel.AutoSize = true;
            tipoExtensionArticulosLabel.Location = new System.Drawing.Point(298, 146);
            tipoExtensionArticulosLabel.Name = "tipoExtensionArticulosLabel";
            tipoExtensionArticulosLabel.Size = new System.Drawing.Size(56, 13);
            tipoExtensionArticulosLabel.TabIndex = 105;
            tipoExtensionArticulosLabel.Text = "Extension:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(89, 17);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(198, 26);
            label2.TabIndex = 123;
            label2.Tag = "";
            label2.Text = "TABLA PRINCIPAL";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(404, 307);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(99, 16);
            label3.TabIndex = 125;
            label3.Text = "Copiar a   .....";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(29, 310);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(40, 16);
            label4.TabIndex = 126;
            label4.Text = "De ..";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.BtnTablasCrear);
            this.panel3.Location = new System.Drawing.Point(79, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 110);
            this.panel3.TabIndex = 115;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 94;
            this.label9.Text = "Crear Todas Las Tablas";
            // 
            // BtnTablasCrear
            // 
            this.BtnTablasCrear.Location = new System.Drawing.Point(41, 49);
            this.BtnTablasCrear.Name = "BtnTablasCrear";
            this.BtnTablasCrear.Size = new System.Drawing.Size(75, 23);
            this.BtnTablasCrear.TabIndex = 87;
            this.BtnTablasCrear.Text = "Tablas";
            this.BtnTablasCrear.UseVisualStyleBackColor = true;
            this.BtnTablasCrear.Click += new System.EventHandler(this.BtnTablasCrear_Click);
            // 
            // Info_Res
            // 
            this.Info_Res.AutoSize = true;
            this.Info_Res.BackColor = System.Drawing.Color.Gold;
            this.Info_Res.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Info_Res.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Info_Res.Location = new System.Drawing.Point(554, 151);
            this.Info_Res.Name = "Info_Res";
            this.Info_Res.Size = new System.Drawing.Size(201, 15);
            this.Info_Res.TabIndex = 114;
            this.Info_Res.Text = "Cierra toda Conexion y Restablece datos";
            this.Info_Res.Visible = false;
            // 
            // BtnCrearTablaCli
            // 
            this.BtnCrearTablaCli.Location = new System.Drawing.Point(519, 120);
            this.BtnCrearTablaCli.Name = "BtnCrearTablaCli";
            this.BtnCrearTablaCli.Size = new System.Drawing.Size(75, 23);
            this.BtnCrearTablaCli.TabIndex = 113;
            this.BtnCrearTablaCli.Text = "&Crear";
            this.BtnCrearTablaCli.UseVisualStyleBackColor = true;
            this.BtnCrearTablaCli.Click += new System.EventHandler(this.BtnCrearTablaCli_Click);
            // 
            // BtnCrearTablaArti
            // 
            this.BtnCrearTablaArti.Location = new System.Drawing.Point(519, 80);
            this.BtnCrearTablaArti.Name = "BtnCrearTablaArti";
            this.BtnCrearTablaArti.Size = new System.Drawing.Size(75, 23);
            this.BtnCrearTablaArti.TabIndex = 112;
            this.BtnCrearTablaArti.Text = "&Crear";
            this.BtnCrearTablaArti.UseVisualStyleBackColor = true;
            this.BtnCrearTablaArti.Click += new System.EventHandler(this.BtnCrearTablaArti_Click);
            // 
            // BtnExaminarT
            // 
            this.BtnExaminarT.Location = new System.Drawing.Point(638, 37);
            this.BtnExaminarT.Name = "BtnExaminarT";
            this.BtnExaminarT.Size = new System.Drawing.Size(75, 23);
            this.BtnExaminarT.TabIndex = 111;
            this.BtnExaminarT.Text = "&Examinar";
            this.BtnExaminarT.UseVisualStyleBackColor = true;
            this.BtnExaminarT.Click += new System.EventHandler(this.BtnExaminarT_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 110;
            this.label6.Text = "Base De Datos:";
            // 
            // BaseDatosTxt1
            // 
            this.BaseDatosTxt1.Location = new System.Drawing.Point(155, 39);
            this.BaseDatosTxt1.Name = "BaseDatosTxt1";
            this.BaseDatosTxt1.ReadOnly = true;
            this.BaseDatosTxt1.Size = new System.Drawing.Size(477, 20);
            this.BaseDatosTxt1.TabIndex = 109;
            this.BaseDatosTxt1.Tag = "NO";
            this.BaseDatosTxt1.Text = "Datos App Peloscalvo";
            this.BaseDatosTxt1.TextChanged += new System.EventHandler(this.BaseDatosTxt1_TextChanged);
            // 
            // ArticulosTxt
            // 
            this.ArticulosTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "ArchivoArticulos", true));
            this.ArticulosTxt.DisplayMember = "A";
            this.ArticulosTxt.FormattingEnabled = true;
            this.ArticulosTxt.Items.AddRange(new object[] {
            "Tarifa De Articulos 1",
            "Tarifa De Articulos 2",
            "Tarifa De Articulos 3",
            "Tarifa De Articulos 4",
            "Tarifa De Articulos 5"});
            this.ArticulosTxt.Location = new System.Drawing.Point(155, 76);
            this.ArticulosTxt.MaxLength = 50;
            this.ArticulosTxt.Name = "ArticulosTxt";
            this.ArticulosTxt.Size = new System.Drawing.Size(348, 21);
            this.ArticulosTxt.TabIndex = 100;
            this.ArticulosTxt.SelectedIndexChanged += new System.EventHandler(this.ArticulosTxt_SelectedIndexChanged);
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
            // ClientesTxt
            // 
            this.ClientesTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "ArchivoClientes", true));
            this.ClientesTxt.DisplayMember = "A";
            this.ClientesTxt.FormattingEnabled = true;
            this.ClientesTxt.Items.AddRange(new object[] {
            "Listado De Clientes 1",
            "Listado De Clientes 2",
            "Listado De Clientes 3",
            "Listado De Clientes 4",
            "Listado De Clientes 5"});
            this.ClientesTxt.Location = new System.Drawing.Point(155, 116);
            this.ClientesTxt.MaxLength = 50;
            this.ClientesTxt.Name = "ClientesTxt";
            this.ClientesTxt.Size = new System.Drawing.Size(348, 21);
            this.ClientesTxt.TabIndex = 101;
            this.ClientesTxt.SelectedIndexChanged += new System.EventHandler(this.ClientesTxt_SelectedIndexChanged);
            // 
            // ExtensionTxt
            // 
            this.ExtensionTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "TipoExtensionArticulos", true));
            this.ExtensionTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExtensionTxt.FormattingEnabled = true;
            this.ExtensionTxt.Items.AddRange(new object[] {
            "accdb",
            "mdb"});
            this.ExtensionTxt.Location = new System.Drawing.Point(360, 143);
            this.ExtensionTxt.Name = "ExtensionTxt";
            this.ExtensionTxt.Size = new System.Drawing.Size(139, 21);
            this.ExtensionTxt.TabIndex = 106;
            this.ExtensionTxt.SelectedIndexChanged += new System.EventHandler(this.ExtensionTxt_SelectedIndexChanged);
            // 
            // BtnRestablecer_t
            // 
            this.BtnRestablecer_t.BackColor = System.Drawing.Color.DarkKhaki;
            this.BtnRestablecer_t.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnRestablecer_t.Location = new System.Drawing.Point(761, 146);
            this.BtnRestablecer_t.Name = "BtnRestablecer_t";
            this.BtnRestablecer_t.Size = new System.Drawing.Size(75, 23);
            this.BtnRestablecer_t.TabIndex = 116;
            this.BtnRestablecer_t.Text = "&Restablecer";
            this.BtnRestablecer_t.UseVisualStyleBackColor = false;
            this.BtnRestablecer_t.Click += new System.EventHandler(this.BtnRestablecer_t_Click);
            this.BtnRestablecer_t.MouseEnter += new System.EventHandler(this.BtnRestablecer_t_MouseEnter);
            // 
            // BtnSalirT
            // 
            this.BtnSalirT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalirT.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalirT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalirT.FlatAppearance.BorderSize = 0;
            this.BtnSalirT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnSalirT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnSalirT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalirT.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirT.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_door_5_32;
            this.BtnSalirT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalirT.Location = new System.Drawing.Point(786, 336);
            this.BtnSalirT.Name = "BtnSalirT";
            this.BtnSalirT.Size = new System.Drawing.Size(77, 63);
            this.BtnSalirT.TabIndex = 117;
            this.BtnSalirT.Text = "Salir";
            this.BtnSalirT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalirT.UseVisualStyleBackColor = false;
            this.BtnSalirT.Click += new System.EventHandler(this.BtnSalirT_Click);
            // 
            // ErrorVer
            // 
            this.ErrorVer.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.ErrorVer.ContainerControl = this;
            // 
            // BtnConectar
            // 
            this.BtnConectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConectar.BackColor = System.Drawing.Color.Transparent;
            this.BtnConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConectar.FlatAppearance.BorderSize = 0;
            this.BtnConectar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnConectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConectar.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConectar.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_check_mark_9_24;
            this.BtnConectar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConectar.Location = new System.Drawing.Point(728, 215);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(108, 42);
            this.BtnConectar.TabIndex = 118;
            this.BtnConectar.Text = "&Conectar";
            this.BtnConectar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConectar.UseVisualStyleBackColor = false;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // TabControlPrincipal
            // 
            this.TabControlPrincipal.Controls.Add(this.TabInicio);
            this.TabControlPrincipal.Controls.Add(this.TabCopia);
            this.TabControlPrincipal.Controls.Add(this.TabCopiarTabla);
            this.TabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabControlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TabControlPrincipal.Name = "TabControlPrincipal";
            this.TabControlPrincipal.SelectedIndex = 0;
            this.TabControlPrincipal.Size = new System.Drawing.Size(902, 442);
            this.TabControlPrincipal.TabIndex = 119;
            // 
            // TabInicio
            // 
            this.TabInicio.BackColor = System.Drawing.SystemColors.Control;
            this.TabInicio.Controls.Add(this.ChckListar);
            this.TabInicio.Controls.Add(this.BaseDatosTxt1);
            this.TabInicio.Controls.Add(this.BtnSalirT);
            this.TabInicio.Controls.Add(this.BtnConectar);
            this.TabInicio.Controls.Add(this.ExtensionTxt);
            this.TabInicio.Controls.Add(tipoExtensionArticulosLabel);
            this.TabInicio.Controls.Add(this.BtnRestablecer_t);
            this.TabInicio.Controls.Add(this.ClientesTxt);
            this.TabInicio.Controls.Add(this.panel3);
            this.TabInicio.Controls.Add(this.ArticulosTxt);
            this.TabInicio.Controls.Add(this.Info_Res);
            this.TabInicio.Controls.Add(labelCLIENTES);
            this.TabInicio.Controls.Add(this.BtnCrearTablaCli);
            this.TabInicio.Controls.Add(labelARTICULOS);
            this.TabInicio.Controls.Add(this.BtnCrearTablaArti);
            this.TabInicio.Controls.Add(this.label6);
            this.TabInicio.Controls.Add(this.BtnExaminarT);
            this.TabInicio.Location = new System.Drawing.Point(4, 22);
            this.TabInicio.Name = "TabInicio";
            this.TabInicio.Padding = new System.Windows.Forms.Padding(3);
            this.TabInicio.Size = new System.Drawing.Size(894, 416);
            this.TabInicio.TabIndex = 0;
            this.TabInicio.Tag = "NO";
            this.TabInicio.Text = "Principal";
            // 
            // ChckListar
            // 
            this.ChckListar.AutoSize = true;
            this.ChckListar.Location = new System.Drawing.Point(360, 170);
            this.ChckListar.Name = "ChckListar";
            this.ChckListar.Size = new System.Drawing.Size(139, 17);
            this.ChckListar.TabIndex = 119;
            this.ChckListar.Text = "Listar Todas Las Tablas";
            this.ChckListar.UseVisualStyleBackColor = true;
            // 
            // TabCopia
            // 
            this.TabCopia.BackColor = System.Drawing.SystemColors.Control;
            this.TabCopia.Controls.Add(this.label1);
            this.TabCopia.Controls.Add(this.BaseDatos2);
            this.TabCopia.Controls.Add(this.BtnCrearBackupDb);
            this.TabCopia.Location = new System.Drawing.Point(4, 22);
            this.TabCopia.Name = "TabCopia";
            this.TabCopia.Padding = new System.Windows.Forms.Padding(3);
            this.TabCopia.Size = new System.Drawing.Size(894, 416);
            this.TabCopia.TabIndex = 1;
            this.TabCopia.Text = "Copia Seguridad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 111;
            this.label1.Text = "Base Datos:";
            // 
            // BaseDatos2
            // 
            this.BaseDatos2.Location = new System.Drawing.Point(145, 288);
            this.BaseDatos2.Name = "BaseDatos2";
            this.BaseDatos2.ReadOnly = true;
            this.BaseDatos2.Size = new System.Drawing.Size(490, 20);
            this.BaseDatos2.TabIndex = 110;
            this.BaseDatos2.Tag = "NO";
            this.BaseDatos2.Text = "Datos App Peloscalvo";
            // 
            // BtnCrearBackupDb
            // 
            this.BtnCrearBackupDb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCrearBackupDb.BackColor = System.Drawing.Color.Transparent;
            this.BtnCrearBackupDb.FlatAppearance.BorderSize = 0;
            this.BtnCrearBackupDb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnCrearBackupDb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnCrearBackupDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearBackupDb.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearBackupDb.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_check_mark_9_24;
            this.BtnCrearBackupDb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCrearBackupDb.Location = new System.Drawing.Point(667, 249);
            this.BtnCrearBackupDb.Name = "BtnCrearBackupDb";
            this.BtnCrearBackupDb.Size = new System.Drawing.Size(187, 42);
            this.BtnCrearBackupDb.TabIndex = 77;
            this.BtnCrearBackupDb.Text = "&Crear Copia seguridad";
            this.BtnCrearBackupDb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCrearBackupDb.UseVisualStyleBackColor = false;
            this.BtnCrearBackupDb.Click += new System.EventHandler(this.BtnCrearBackupDb_Click);
            // 
            // TabCopiarTabla
            // 
            this.TabCopiarTabla.BackColor = System.Drawing.SystemColors.Control;
            this.TabCopiarTabla.Controls.Add(label4);
            this.TabCopiarTabla.Controls.Add(label3);
            this.TabCopiarTabla.Controls.Add(this.TablaCopiarTxt);
            this.TabCopiarTabla.Controls.Add(label2);
            this.TabCopiarTabla.Controls.Add(this.ListaTablasPrincipal);
            this.TabCopiarTabla.Controls.Add(this.TablanuevaTxt);
            this.TabCopiarTabla.Controls.Add(this.BtnCopiarTabla);
            this.TabCopiarTabla.Location = new System.Drawing.Point(4, 22);
            this.TabCopiarTabla.Name = "TabCopiarTabla";
            this.TabCopiarTabla.Padding = new System.Windows.Forms.Padding(3);
            this.TabCopiarTabla.Size = new System.Drawing.Size(894, 416);
            this.TabCopiarTabla.TabIndex = 2;
            this.TabCopiarTabla.Text = "Trasnsferir Datos";
            // 
            // TablaCopiarTxt
            // 
            this.TablaCopiarTxt.Location = new System.Drawing.Point(89, 308);
            this.TablaCopiarTxt.Name = "TablaCopiarTxt";
            this.TablaCopiarTxt.ReadOnly = true;
            this.TablaCopiarTxt.Size = new System.Drawing.Size(293, 20);
            this.TablaCopiarTxt.TabIndex = 124;
            this.TablaCopiarTxt.Tag = "NO";
            // 
            // ListaTablasPrincipal
            // 
            this.ListaTablasPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaTablasPrincipal.FormattingEnabled = true;
            this.ListaTablasPrincipal.HorizontalScrollbar = true;
            this.ListaTablasPrincipal.Location = new System.Drawing.Point(19, 49);
            this.ListaTablasPrincipal.Name = "ListaTablasPrincipal";
            this.ListaTablasPrincipal.Size = new System.Drawing.Size(363, 238);
            this.ListaTablasPrincipal.TabIndex = 122;
            this.ListaTablasPrincipal.Click += new System.EventHandler(this.ListaTablasPrincipal_Click);
            // 
            // TablanuevaTxt
            // 
            this.TablanuevaTxt.DisplayMember = "A";
            this.TablanuevaTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TablanuevaTxt.FormattingEnabled = true;
            this.TablanuevaTxt.Location = new System.Drawing.Point(520, 305);
            this.TablanuevaTxt.MaxLength = 50;
            this.TablanuevaTxt.Name = "TablanuevaTxt";
            this.TablanuevaTxt.Size = new System.Drawing.Size(348, 21);
            this.TablanuevaTxt.TabIndex = 114;
            // 
            // BtnCopiarTabla
            // 
            this.BtnCopiarTabla.Location = new System.Drawing.Point(793, 366);
            this.BtnCopiarTabla.Name = "BtnCopiarTabla";
            this.BtnCopiarTabla.Size = new System.Drawing.Size(75, 23);
            this.BtnCopiarTabla.TabIndex = 118;
            this.BtnCopiarTabla.Text = "&Copiar";
            this.BtnCopiarTabla.UseVisualStyleBackColor = true;
            this.BtnCopiarTabla.Click += new System.EventHandler(this.BtnCopiarTabla_Click);
            // 
            // InfoProcesoText
            // 
            this.InfoProcesoText.AutoSize = true;
            this.InfoProcesoText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InfoProcesoText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoProcesoText.Location = new System.Drawing.Point(0, 444);
            this.InfoProcesoText.Margin = new System.Windows.Forms.Padding(3);
            this.InfoProcesoText.Name = "InfoProcesoText";
            this.InfoProcesoText.Padding = new System.Windows.Forms.Padding(2, 4, 2, 5);
            this.InfoProcesoText.Size = new System.Drawing.Size(202, 25);
            this.InfoProcesoText.TabIndex = 112;
            this.InfoProcesoText.Text = "Indica La Base De Datos a Crear";
            // 
            // dsCONFIGURACCION
            // 
            this.dsCONFIGURACCION.DataSetName = "DsCONFIGURACCION";
            this.dsCONFIGURACCION.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtConfiguracionPrincipalBindingSource
            // 
            this.dtConfiguracionPrincipalBindingSource.DataMember = "DtConfiguracionPrincipal";
            this.dtConfiguracionPrincipalBindingSource.DataSource = this.dsCONFIGURACCION;
            // 
            // FormCrearTablasDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 469);
            this.Controls.Add(this.InfoProcesoText);
            this.Controls.Add(this.TabControlPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCrearTablasDb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Tablas Db";
            this.Load += new System.EventHandler(this.FormCrearTablasDb_Load);
            this.MouseEnter += new System.EventHandler(this.FormCrearTablasDb_MouseEnter);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorVer)).EndInit();
            this.TabControlPrincipal.ResumeLayout(false);
            this.TabInicio.ResumeLayout(false);
            this.TabInicio.PerformLayout();
            this.TabCopia.ResumeLayout(false);
            this.TabCopia.PerformLayout();
            this.TabCopiarTabla.ResumeLayout(false);
            this.TabCopiarTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnTablasCrear;
        private System.Windows.Forms.Label Info_Res;
        private System.Windows.Forms.Button BtnCrearTablaCli;
        private System.Windows.Forms.Button BtnCrearTablaArti;
        private System.Windows.Forms.Button BtnExaminarT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BaseDatosTxt1;
        public System.Windows.Forms.ComboBox ArticulosTxt;
        public System.Windows.Forms.ComboBox ClientesTxt;
        public System.Windows.Forms.ComboBox ExtensionTxt;
        private System.Windows.Forms.Button BtnRestablecer_t;
        private System.Windows.Forms.Button BtnSalirT;
        private System.Windows.Forms.ErrorProvider ErrorVer;
        public System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.TabControl TabControlPrincipal;
        private System.Windows.Forms.TabPage TabInicio;
        private System.Windows.Forms.TabPage TabCopia;
        public System.Windows.Forms.Button BtnCrearBackupDb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BaseDatos2;
        private System.Windows.Forms.Label InfoProcesoText;
        private System.Windows.Forms.TabPage TabCopiarTabla;
        public System.Windows.Forms.ComboBox TablanuevaTxt;
        private System.Windows.Forms.Button BtnCopiarTabla;
        private System.Windows.Forms.ListBox ListaTablasPrincipal;
        private System.Windows.Forms.TextBox TablaCopiarTxt;
        private System.Windows.Forms.CheckBox ChckListar;
        private DsCONFIGURACCION dsCONFIGURACCION;
        private System.Windows.Forms.BindingSource dtConfiguracionPrincipalBindingSource;
        private System.Windows.Forms.BindingSource dtInicioMultiBindingSource;
        private DsMultidatos dsMultidatos;
    }
}