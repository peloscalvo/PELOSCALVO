
namespace PELOSCALVO
{
    partial class FormComfiguracion
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
            System.Windows.Forms.Label provinciaLabel;
            System.Windows.Forms.Label pais_FactLabel;
            System.Windows.Forms.Label archivoArticulosLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label tipoExtensionArticulosLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label archivoClientesLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComfiguracion));
            this.dtConfiguracionPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCONFIGURACCION = new PELOSCALVO.DsCONFIGURACCION();
            this.dtConfiguracionPrincipalDtConfiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMultidatos = new PELOSCALVO.DsMultidatos();
            this.dtConfiDtTarifaTipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtInicioMultiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtPaisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMulti2 = new PELOSCALVO.DsMulti2();
            this.dtProvinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtConfiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1Confi = new System.Windows.Forms.ErrorProvider(this.components);
            this.idTarifaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifaTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enlaceTarifaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.dtObrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtNombresTablasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMultidatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idProveedoresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageInicio = new System.Windows.Forms.TabPage();
            this.panelDatosInicio = new System.Windows.Forms.Panel();
            this.empresaInicio = new System.Windows.Forms.ComboBox();
            this.archivoClientesComboBox = new System.Windows.Forms.ComboBox();
            this.SerieInicio = new System.Windows.Forms.ComboBox();
            this.tipoExtensionArticulosComboBox = new System.Windows.Forms.ComboBox();
            this.EjercicioInicio = new System.Windows.Forms.ComboBox();
            this.archivoArticulosComboBox = new System.Windows.Forms.ComboBox();
            this.provinciaInicio = new System.Windows.Forms.ComboBox();
            this.PaisInicio = new System.Windows.Forms.ComboBox();
            this.BtnVolverConfi_Inicio = new System.Windows.Forms.Button();
            this.dtInicioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnGuardarInicio = new System.Windows.Forms.Button();
            this.tabMENU = new System.Windows.Forms.TabPage();
            this.BtnRestructurar = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirBaseDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirPdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirBaseDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearBaseDatosSqlLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCopiaSeguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCopiaSeguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCopiaSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCopiaCompletaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarCopiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.índiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSalirConfi = new System.Windows.Forms.Button();
            this.tabControlTodo = new System.Windows.Forms.TabControl();
            this.dtTarifaTipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            provinciaLabel = new System.Windows.Forms.Label();
            pais_FactLabel = new System.Windows.Forms.Label();
            archivoArticulosLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            tipoExtensionArticulosLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            archivoClientesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalDtConfiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiDtTarifaTipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMulti2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProvinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1Confi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtObrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNombresTablasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatosBindingSource)).BeginInit();
            this.tabPageInicio.SuspendLayout();
            this.panelDatosInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioDataGridView)).BeginInit();
            this.tabMENU.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tabControlTodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarifaTipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // provinciaLabel
            // 
            provinciaLabel.AutoSize = true;
            provinciaLabel.Location = new System.Drawing.Point(40, 109);
            provinciaLabel.Name = "provinciaLabel";
            provinciaLabel.Size = new System.Drawing.Size(54, 13);
            provinciaLabel.TabIndex = 36;
            provinciaLabel.Text = "Provincia:";
            // 
            // pais_FactLabel
            // 
            pais_FactLabel.AutoSize = true;
            pais_FactLabel.Location = new System.Drawing.Point(64, 137);
            pais_FactLabel.Name = "pais_FactLabel";
            pais_FactLabel.Size = new System.Drawing.Size(30, 13);
            pais_FactLabel.TabIndex = 38;
            pais_FactLabel.Text = "Pais:";
            // 
            // archivoArticulosLabel
            // 
            archivoArticulosLabel.AutoSize = true;
            archivoArticulosLabel.Location = new System.Drawing.Point(9, 173);
            archivoArticulosLabel.Name = "archivoArticulosLabel";
            archivoArticulosLabel.Size = new System.Drawing.Size(89, 13);
            archivoArticulosLabel.TabIndex = 39;
            archivoArticulosLabel.Text = "Archivo Articulos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(60, 82);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(34, 13);
            label3.TabIndex = 27;
            label3.Text = "Serie:";
            // 
            // tipoExtensionArticulosLabel
            // 
            tipoExtensionArticulosLabel.AutoSize = true;
            tipoExtensionArticulosLabel.Location = new System.Drawing.Point(38, 243);
            tipoExtensionArticulosLabel.Name = "tipoExtensionArticulosLabel";
            tipoExtensionArticulosLabel.Size = new System.Drawing.Size(56, 13);
            tipoExtensionArticulosLabel.TabIndex = 41;
            tipoExtensionArticulosLabel.Text = "Extension:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(40, 55);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 13);
            label4.TabIndex = 24;
            label4.Text = "Ejercicios:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(43, 22);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 13);
            label2.TabIndex = 6;
            label2.Text = "Empresa:";
            // 
            // archivoClientesLabel
            // 
            archivoClientesLabel.AutoSize = true;
            archivoClientesLabel.Location = new System.Drawing.Point(8, 204);
            archivoClientesLabel.Name = "archivoClientesLabel";
            archivoClientesLabel.Size = new System.Drawing.Size(86, 13);
            archivoClientesLabel.TabIndex = 42;
            archivoClientesLabel.Text = "Archivo Clientes:";
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
            // dtConfiguracionPrincipalDtConfiBindingSource
            // 
            this.dtConfiguracionPrincipalDtConfiBindingSource.DataMember = "DtConfiguracionPrincipal_DtConfi";
            this.dtConfiguracionPrincipalDtConfiBindingSource.DataSource = this.dtConfiguracionPrincipalBindingSource;
            // 
            // dsMultidatos
            // 
            this.dsMultidatos.DataSetName = "DsMultidatos";
            this.dsMultidatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtConfiDtTarifaTipoBindingSource
            // 
            this.dtConfiDtTarifaTipoBindingSource.DataMember = "DtConfi_DtTarifaTipo";
            this.dtConfiDtTarifaTipoBindingSource.DataSource = this.dtConfiguracionPrincipalBindingSource;
            // 
            // dtInicioMultiBindingSource
            // 
            this.dtInicioMultiBindingSource.DataMember = "DtInicioMulti";
            this.dtInicioMultiBindingSource.DataSource = this.dsMultidatos;
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
            // dtProvinciasBindingSource
            // 
            this.dtProvinciasBindingSource.DataMember = "DtProvincias";
            this.dtProvinciasBindingSource.DataSource = this.dsMulti2;
            // 
            // dtConfiBindingSource
            // 
            this.dtConfiBindingSource.DataMember = "DtConfi";
            this.dtConfiBindingSource.DataSource = this.dsCONFIGURACCION;
            // 
            // errorProvider1Confi
            // 
            this.errorProvider1Confi.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1Confi.ContainerControl = this;
            // 
            // idTarifaDataGridViewTextBoxColumn
            // 
            this.idTarifaDataGridViewTextBoxColumn.DataPropertyName = "IdTarifa";
            this.idTarifaDataGridViewTextBoxColumn.HeaderText = "IdTarifa";
            this.idTarifaDataGridViewTextBoxColumn.Name = "idTarifaDataGridViewTextBoxColumn";
            // 
            // tarifaTipoDataGridViewTextBoxColumn
            // 
            this.tarifaTipoDataGridViewTextBoxColumn.DataPropertyName = "TarifaTipo";
            this.tarifaTipoDataGridViewTextBoxColumn.HeaderText = "TarifaTipo";
            this.tarifaTipoDataGridViewTextBoxColumn.Name = "tarifaTipoDataGridViewTextBoxColumn";
            // 
            // enlaceTarifaDataGridViewTextBoxColumn
            // 
            this.enlaceTarifaDataGridViewTextBoxColumn.DataPropertyName = "EnlaceTarifa";
            this.enlaceTarifaDataGridViewTextBoxColumn.HeaderText = "EnlaceTarifa";
            this.enlaceTarifaDataGridViewTextBoxColumn.Name = "enlaceTarifaDataGridViewTextBoxColumn";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "Selección de nuevo elemento";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Location = new System.Drawing.Point(781, 2);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.miniToolStrip.Size = new System.Drawing.Size(783, 24);
            this.miniToolStrip.TabIndex = 45;
            // 
            // dtObrasBindingSource
            // 
            this.dtObrasBindingSource.DataMember = "DtObras";
            this.dtObrasBindingSource.DataSource = this.dsMulti2;
            // 
            // dtNombresTablasBindingSource
            // 
            this.dtNombresTablasBindingSource.DataMember = "DtNombresTablas";
            this.dtNombresTablasBindingSource.DataSource = this.dsMultidatosBindingSource;
            // 
            // dsMultidatosBindingSource
            // 
            this.dsMultidatosBindingSource.DataSource = this.dsMultidatos;
            this.dsMultidatosBindingSource.Position = 0;
            // 
            // idProveedoresDataGridViewTextBoxColumn
            // 
            this.idProveedoresDataGridViewTextBoxColumn.DataPropertyName = "Id_Proveedores";
            this.idProveedoresDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idProveedoresDataGridViewTextBoxColumn.Name = "idProveedoresDataGridViewTextBoxColumn";
            this.idProveedoresDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProveedoresDataGridViewTextBoxColumn.Width = 153;
            // 
            // tabPageInicio
            // 
            this.tabPageInicio.AutoScroll = true;
            this.tabPageInicio.Controls.Add(this.panelDatosInicio);
            this.tabPageInicio.Controls.Add(this.BtnVolverConfi_Inicio);
            this.tabPageInicio.Controls.Add(this.dtInicioDataGridView);
            this.tabPageInicio.Controls.Add(this.BtnGuardarInicio);
            this.tabPageInicio.Location = new System.Drawing.Point(4, 25);
            this.tabPageInicio.Name = "tabPageInicio";
            this.tabPageInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInicio.Size = new System.Drawing.Size(1012, 531);
            this.tabPageInicio.TabIndex = 5;
            this.tabPageInicio.Text = "Configuracion Inicio";
            this.tabPageInicio.UseVisualStyleBackColor = true;
            // 
            // panelDatosInicio
            // 
            this.panelDatosInicio.Controls.Add(this.empresaInicio);
            this.panelDatosInicio.Controls.Add(archivoClientesLabel);
            this.panelDatosInicio.Controls.Add(label2);
            this.panelDatosInicio.Controls.Add(this.archivoClientesComboBox);
            this.panelDatosInicio.Controls.Add(label4);
            this.panelDatosInicio.Controls.Add(tipoExtensionArticulosLabel);
            this.panelDatosInicio.Controls.Add(this.SerieInicio);
            this.panelDatosInicio.Controls.Add(this.tipoExtensionArticulosComboBox);
            this.panelDatosInicio.Controls.Add(label3);
            this.panelDatosInicio.Controls.Add(archivoArticulosLabel);
            this.panelDatosInicio.Controls.Add(this.EjercicioInicio);
            this.panelDatosInicio.Controls.Add(this.archivoArticulosComboBox);
            this.panelDatosInicio.Controls.Add(this.provinciaInicio);
            this.panelDatosInicio.Controls.Add(pais_FactLabel);
            this.panelDatosInicio.Controls.Add(provinciaLabel);
            this.panelDatosInicio.Controls.Add(this.PaisInicio);
            this.panelDatosInicio.Location = new System.Drawing.Point(17, 75);
            this.panelDatosInicio.Name = "panelDatosInicio";
            this.panelDatosInicio.Size = new System.Drawing.Size(565, 316);
            this.panelDatosInicio.TabIndex = 44;
            // 
            // empresaInicio
            // 
            this.empresaInicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "EmpresaInicio", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.empresaInicio.DataSource = this.dtConfiguracionPrincipalBindingSource;
            this.empresaInicio.DisplayMember = "EmpresaConfi";
            this.empresaInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empresaInicio.FormattingEnabled = true;
            this.empresaInicio.Location = new System.Drawing.Point(104, 19);
            this.empresaInicio.Name = "empresaInicio";
            this.empresaInicio.Size = new System.Drawing.Size(312, 21);
            this.empresaInicio.TabIndex = 7;
            // 
            // archivoClientesComboBox
            // 
            this.archivoClientesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "ArchivoClientes", true));
            this.archivoClientesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.archivoClientesComboBox.FormattingEnabled = true;
            this.archivoClientesComboBox.Items.AddRange(new object[] {
            "Listado1",
            "Listado2",
            "Listado3",
            "Listado4",
            "Listado5",
            "Listado6"});
            this.archivoClientesComboBox.Location = new System.Drawing.Point(104, 201);
            this.archivoClientesComboBox.Name = "archivoClientesComboBox";
            this.archivoClientesComboBox.Size = new System.Drawing.Size(299, 21);
            this.archivoClientesComboBox.TabIndex = 43;
            // 
            // SerieInicio
            // 
            this.SerieInicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.SerieInicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "SerieInicio", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SerieInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SerieInicio.FormattingEnabled = true;
            this.SerieInicio.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G"});
            this.SerieInicio.Location = new System.Drawing.Point(104, 79);
            this.SerieInicio.Name = "SerieInicio";
            this.SerieInicio.Size = new System.Drawing.Size(200, 21);
            this.SerieInicio.TabIndex = 26;
            // 
            // tipoExtensionArticulosComboBox
            // 
            this.tipoExtensionArticulosComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "TipoExtensionArticulos", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tipoExtensionArticulosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoExtensionArticulosComboBox.FormattingEnabled = true;
            this.tipoExtensionArticulosComboBox.Items.AddRange(new object[] {
            "DBF",
            "mdb",
            "accdb"});
            this.tipoExtensionArticulosComboBox.Location = new System.Drawing.Point(104, 240);
            this.tipoExtensionArticulosComboBox.Name = "tipoExtensionArticulosComboBox";
            this.tipoExtensionArticulosComboBox.Size = new System.Drawing.Size(121, 21);
            this.tipoExtensionArticulosComboBox.TabIndex = 42;
            // 
            // EjercicioInicio
            // 
            this.EjercicioInicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.EjercicioInicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "EjercicioInicio", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.EjercicioInicio.DataSource = this.dtConfiBindingSource;
            this.EjercicioInicio.DisplayMember = "EjerciciosDeAño";
            this.EjercicioInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EjercicioInicio.FormattingEnabled = true;
            this.EjercicioInicio.Location = new System.Drawing.Point(104, 52);
            this.EjercicioInicio.Name = "EjercicioInicio";
            this.EjercicioInicio.Size = new System.Drawing.Size(268, 21);
            this.EjercicioInicio.TabIndex = 33;
            // 
            // archivoArticulosComboBox
            // 
            this.archivoArticulosComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "ArchivoArticulos", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.archivoArticulosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.archivoArticulosComboBox.FormattingEnabled = true;
            this.archivoArticulosComboBox.Items.AddRange(new object[] {
            "Tarifa1",
            "Tarifa2",
            "Tarifa3",
            "Tarifa4",
            "Tarifa5",
            "Tarifa6"});
            this.archivoArticulosComboBox.Location = new System.Drawing.Point(104, 170);
            this.archivoArticulosComboBox.Name = "archivoArticulosComboBox";
            this.archivoArticulosComboBox.Size = new System.Drawing.Size(299, 21);
            this.archivoArticulosComboBox.TabIndex = 40;
            // 
            // provinciaInicio
            // 
            this.provinciaInicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "SerieProvinciaInicio", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.provinciaInicio.DataSource = this.dtProvinciasBindingSource;
            this.provinciaInicio.DisplayMember = "ProvinciasProvincias";
            this.provinciaInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provinciaInicio.FormattingEnabled = true;
            this.provinciaInicio.Location = new System.Drawing.Point(104, 106);
            this.provinciaInicio.Name = "provinciaInicio";
            this.provinciaInicio.Size = new System.Drawing.Size(268, 21);
            this.provinciaInicio.TabIndex = 37;
            // 
            // PaisInicio
            // 
            this.PaisInicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "SeriePaisInicio", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PaisInicio.DataSource = this.dtPaisesBindingSource;
            this.PaisInicio.DisplayMember = "PaisesPaises";
            this.PaisInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaisInicio.FormattingEnabled = true;
            this.PaisInicio.Location = new System.Drawing.Point(104, 134);
            this.PaisInicio.Name = "PaisInicio";
            this.PaisInicio.Size = new System.Drawing.Size(268, 21);
            this.PaisInicio.TabIndex = 39;
            // 
            // BtnVolverConfi_Inicio
            // 
            this.BtnVolverConfi_Inicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVolverConfi_Inicio.BackColor = System.Drawing.Color.Transparent;
            this.BtnVolverConfi_Inicio.FlatAppearance.BorderSize = 0;
            this.BtnVolverConfi_Inicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnVolverConfi_Inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnVolverConfi_Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolverConfi_Inicio.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolverConfi_Inicio.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_undo_4_24;
            this.BtnVolverConfi_Inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVolverConfi_Inicio.Location = new System.Drawing.Point(869, 462);
            this.BtnVolverConfi_Inicio.Name = "BtnVolverConfi_Inicio";
            this.BtnVolverConfi_Inicio.Size = new System.Drawing.Size(107, 42);
            this.BtnVolverConfi_Inicio.TabIndex = 35;
            this.BtnVolverConfi_Inicio.Text = "Volver";
            this.BtnVolverConfi_Inicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVolverConfi_Inicio.UseVisualStyleBackColor = false;
            this.BtnVolverConfi_Inicio.Click += new System.EventHandler(this.BtnVolverConfi_Inicio_Click);
            // 
            // dtInicioDataGridView
            // 
            this.dtInicioDataGridView.AllowUserToAddRows = false;
            this.dtInicioDataGridView.AllowUserToDeleteRows = false;
            this.dtInicioDataGridView.AllowUserToResizeColumns = false;
            this.dtInicioDataGridView.AllowUserToResizeRows = false;
            this.dtInicioDataGridView.AutoGenerateColumns = false;
            this.dtInicioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtInicioDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtInicioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtInicioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn12});
            this.dtInicioDataGridView.DataSource = this.dtInicioMultiBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtInicioDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtInicioDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtInicioDataGridView.Location = new System.Drawing.Point(3, 3);
            this.dtInicioDataGridView.Name = "dtInicioDataGridView";
            this.dtInicioDataGridView.ReadOnly = true;
            this.dtInicioDataGridView.RowHeadersVisible = false;
            this.dtInicioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtInicioDataGridView.Size = new System.Drawing.Size(1006, 51);
            this.dtInicioDataGridView.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ArchivoInicioFacturas";
            this.dataGridViewTextBoxColumn1.FillWeight = 130F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Archivo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmpresaInicio";
            this.dataGridViewTextBoxColumn2.FillWeight = 150F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Empresa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EjercicioInicio";
            this.dataGridViewTextBoxColumn3.FillWeight = 120F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Ejercicio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "SerieInicio";
            this.dataGridViewTextBoxColumn12.FillWeight = 53F;
            this.dataGridViewTextBoxColumn12.HeaderText = "Serie";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // BtnGuardarInicio
            // 
            this.BtnGuardarInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarInicio.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarInicio.FlatAppearance.BorderSize = 0;
            this.BtnGuardarInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnGuardarInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnGuardarInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarInicio.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarInicio.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_check_mark_9_24;
            this.BtnGuardarInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarInicio.Location = new System.Drawing.Point(459, 462);
            this.BtnGuardarInicio.Name = "BtnGuardarInicio";
            this.BtnGuardarInicio.Size = new System.Drawing.Size(107, 42);
            this.BtnGuardarInicio.TabIndex = 32;
            this.BtnGuardarInicio.Text = "Actualizar";
            this.BtnGuardarInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarInicio.UseVisualStyleBackColor = false;
            this.BtnGuardarInicio.Click += new System.EventHandler(this.BtnGuardarInicio_Click);
            // 
            // tabMENU
            // 
            this.tabMENU.Controls.Add(this.BtnRestructurar);
            this.tabMENU.Controls.Add(this.menuStrip);
            this.tabMENU.Controls.Add(this.BtnSalirConfi);
            this.tabMENU.Location = new System.Drawing.Point(4, 25);
            this.tabMENU.Name = "tabMENU";
            this.tabMENU.Padding = new System.Windows.Forms.Padding(3);
            this.tabMENU.Size = new System.Drawing.Size(1012, 531);
            this.tabMENU.TabIndex = 0;
            this.tabMENU.Text = "Menu Principal";
            this.tabMENU.UseVisualStyleBackColor = true;
            this.tabMENU.Click += new System.EventHandler(this.tabMENU_Click);
            this.tabMENU.Enter += new System.EventHandler(this.tabMENU_Enter);
            this.tabMENU.MouseEnter += new System.EventHandler(this.TabMENU_MouseEnter);
            // 
            // BtnRestructurar
            // 
            this.BtnRestructurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(1)))));
            this.BtnRestructurar.FlatAppearance.BorderSize = 0;
            this.BtnRestructurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.BtnRestructurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.BtnRestructurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRestructurar.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestructurar.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_arrow_35_24;
            this.BtnRestructurar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRestructurar.Location = new System.Drawing.Point(665, 315);
            this.BtnRestructurar.Name = "BtnRestructurar";
            this.BtnRestructurar.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.BtnRestructurar.Size = new System.Drawing.Size(277, 42);
            this.BtnRestructurar.TabIndex = 47;
            this.BtnRestructurar.Text = "RESTRUCTURAR ARCHIVOS";
            this.BtnRestructurar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnRestructurar.UseVisualStyleBackColor = false;
            this.BtnRestructurar.Click += new System.EventHandler(this.BtnRestructurar_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolArchivo,
            this.toolCopiaSeguridad,
            this.ayudaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(3, 3);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(1006, 24);
            this.menuStrip.TabIndex = 45;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.MouseLeave += new System.EventHandler(this.menuStrip_MouseLeave);
            // 
            // toolArchivo
            // 
            this.toolArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem,
            this.abrirBaseDatosToolStripMenuItem,
            this.abrirPdfToolStripMenuItem,
            this.añadirBaseDatosToolStripMenuItem,
            this.crearBaseDatosSqlLocalToolStripMenuItem,
            this.imprimirReportesToolStripMenuItem});
            this.toolArchivo.Name = "toolArchivo";
            this.toolArchivo.Size = new System.Drawing.Size(60, 20);
            this.toolArchivo.Text = "Archivo";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verToolStripMenuItem.Text = "&Ver";
            // 
            // abrirBaseDatosToolStripMenuItem
            // 
            this.abrirBaseDatosToolStripMenuItem.Name = "abrirBaseDatosToolStripMenuItem";
            this.abrirBaseDatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirBaseDatosToolStripMenuItem.Text = "&Abrir Base Datos";
            // 
            // abrirPdfToolStripMenuItem
            // 
            this.abrirPdfToolStripMenuItem.Name = "abrirPdfToolStripMenuItem";
            this.abrirPdfToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirPdfToolStripMenuItem.Text = "&Abrir P.d.f";
            // 
            // añadirBaseDatosToolStripMenuItem
            // 
            this.añadirBaseDatosToolStripMenuItem.Name = "añadirBaseDatosToolStripMenuItem";
            this.añadirBaseDatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.añadirBaseDatosToolStripMenuItem.Text = "&Base Datos Db Local";
            this.añadirBaseDatosToolStripMenuItem.Click += new System.EventHandler(this.añadirBaseDatosToolStripMenuItem_Click);
            // 
            // crearBaseDatosSqlLocalToolStripMenuItem
            // 
            this.crearBaseDatosSqlLocalToolStripMenuItem.Name = "crearBaseDatosSqlLocalToolStripMenuItem";
            this.crearBaseDatosSqlLocalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearBaseDatosSqlLocalToolStripMenuItem.Text = "&Base Datos Sql ";
            this.crearBaseDatosSqlLocalToolStripMenuItem.Click += new System.EventHandler(this.crearBaseDatosSqlLocalToolStripMenuItem_Click);
            // 
            // imprimirReportesToolStripMenuItem
            // 
            this.imprimirReportesToolStripMenuItem.Name = "imprimirReportesToolStripMenuItem";
            this.imprimirReportesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimirReportesToolStripMenuItem.Text = "&Imprimir Reportes";
            this.imprimirReportesToolStripMenuItem.Click += new System.EventHandler(this.imprimirReportesToolStripMenuItem_Click);
            // 
            // toolCopiaSeguridad
            // 
            this.toolCopiaSeguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCopiaSeguridadToolStripMenuItem,
            this.restaurarCopiaToolStripMenuItem});
            this.toolCopiaSeguridad.Name = "toolCopiaSeguridad";
            this.toolCopiaSeguridad.Size = new System.Drawing.Size(106, 20);
            this.toolCopiaSeguridad.Text = "Copia Seguridad";
            // 
            // crearCopiaSeguridadToolStripMenuItem
            // 
            this.crearCopiaSeguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCopiaSimpleToolStripMenuItem,
            this.crearCopiaCompletaToolStripMenuItem1});
            this.crearCopiaSeguridadToolStripMenuItem.Name = "crearCopiaSeguridadToolStripMenuItem";
            this.crearCopiaSeguridadToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.crearCopiaSeguridadToolStripMenuItem.Text = "Crear copia";
            // 
            // crearCopiaSimpleToolStripMenuItem
            // 
            this.crearCopiaSimpleToolStripMenuItem.Name = "crearCopiaSimpleToolStripMenuItem";
            this.crearCopiaSimpleToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.crearCopiaSimpleToolStripMenuItem.Text = "Crear copia Simple";
            this.crearCopiaSimpleToolStripMenuItem.Click += new System.EventHandler(this.crearCopiaSimpleToolStripMenuItem_Click);
            // 
            // crearCopiaCompletaToolStripMenuItem1
            // 
            this.crearCopiaCompletaToolStripMenuItem1.Name = "crearCopiaCompletaToolStripMenuItem1";
            this.crearCopiaCompletaToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.crearCopiaCompletaToolStripMenuItem1.Text = "Crear Copia Completa";
            this.crearCopiaCompletaToolStripMenuItem1.Click += new System.EventHandler(this.crearCopiaCompletaToolStripMenuItem1_Click);
            // 
            // restaurarCopiaToolStripMenuItem
            // 
            this.restaurarCopiaToolStripMenuItem.Name = "restaurarCopiaToolStripMenuItem";
            this.restaurarCopiaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.restaurarCopiaToolStripMenuItem.Text = "Restaurar Copia";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.índiceToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ay&uda";
            // 
            // índiceToolStripMenuItem
            // 
            this.índiceToolStripMenuItem.Name = "índiceToolStripMenuItem";
            this.índiceToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.índiceToolStripMenuItem.Text = "Índic&e";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.buscarToolStripMenuItem.Text = "&Buscar";
            // 
            // BtnSalirConfi
            // 
            this.BtnSalirConfi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalirConfi.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalirConfi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalirConfi.FlatAppearance.BorderSize = 0;
            this.BtnSalirConfi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnSalirConfi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnSalirConfi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalirConfi.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirConfi.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_door_5_32;
            this.BtnSalirConfi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalirConfi.Location = new System.Drawing.Point(902, 460);
            this.BtnSalirConfi.Name = "BtnSalirConfi";
            this.BtnSalirConfi.Size = new System.Drawing.Size(77, 63);
            this.BtnSalirConfi.TabIndex = 13;
            this.BtnSalirConfi.Text = "Salir";
            this.BtnSalirConfi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalirConfi.UseVisualStyleBackColor = false;
            this.BtnSalirConfi.Click += new System.EventHandler(this.BtnSalirTipoTarifa_Click);
            // 
            // tabControlTodo
            // 
            this.tabControlTodo.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlTodo.Controls.Add(this.tabMENU);
            this.tabControlTodo.Controls.Add(this.tabPageInicio);
            this.tabControlTodo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlTodo.HotTrack = true;
            this.tabControlTodo.Location = new System.Drawing.Point(0, 0);
            this.tabControlTodo.MinimumSize = new System.Drawing.Size(32, 32);
            this.tabControlTodo.Name = "tabControlTodo";
            this.tabControlTodo.SelectedIndex = 0;
            this.tabControlTodo.Size = new System.Drawing.Size(1020, 560);
            this.tabControlTodo.TabIndex = 0;
            this.tabControlTodo.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControlTodo.MouseEnter += new System.EventHandler(this.TabControl1_MouseEnter);
            // 
            // dtTarifaTipoBindingSource
            // 
            this.dtTarifaTipoBindingSource.DataMember = "DtTarifaTipo";
            this.dtTarifaTipoBindingSource.DataSource = this.dsCONFIGURACCION;
            // 
            // FormComfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 556);
            this.Controls.Add(this.tabControlTodo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(32, 39);
            this.Name = "FormComfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Comfiguracion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormComfiguracion_FormClosing);
            this.Load += new System.EventHandler(this.FormComfiguracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalDtConfiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiDtTarifaTipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMulti2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProvinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1Confi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtObrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNombresTablasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatosBindingSource)).EndInit();
            this.tabPageInicio.ResumeLayout(false);
            this.panelDatosInicio.ResumeLayout(false);
            this.panelDatosInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioDataGridView)).EndInit();
            this.tabMENU.ResumeLayout(false);
            this.tabMENU.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControlTodo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtTarifaTipoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dtConfiBindingSource;
        private DsCONFIGURACCION dsCONFIGURACCION;
        private System.Windows.Forms.BindingSource dtConfiguracionPrincipalBindingSource;
        private System.Windows.Forms.BindingSource dtConfiDtTarifaTipoBindingSource;
        private System.Windows.Forms.BindingSource dtConfiguracionPrincipalDtConfiBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1Confi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTarifaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifaTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enlaceTarifaDataGridViewTextBoxColumn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DsMultidatos dsMultidatos;
        private System.Windows.Forms.BindingSource dtInicioMultiBindingSource;
        private System.Windows.Forms.BindingSource dtProvinciasBindingSource;
        private System.Windows.Forms.BindingSource dtPaisesBindingSource;
        private System.Windows.Forms.MenuStrip miniToolStrip;
        private System.Windows.Forms.BindingSource dtObrasBindingSource;
        private DsMulti2 dsMulti2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedoresDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dtNombresTablasBindingSource;
        private System.Windows.Forms.BindingSource dsMultidatosBindingSource;
        private System.Windows.Forms.TabControl tabControlTodo;
        private System.Windows.Forms.TabPage tabMENU;
        private System.Windows.Forms.Button BtnRestructurar;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolArchivo;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirBaseDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirPdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirBaseDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearBaseDatosSqlLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolCopiaSeguridad;
        private System.Windows.Forms.ToolStripMenuItem crearCopiaSeguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCopiaSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCopiaCompletaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restaurarCopiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem índiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.Button BtnSalirConfi;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiaProductosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TabPage tabPageInicio;
        private System.Windows.Forms.Panel panelDatosInicio;
        private System.Windows.Forms.ComboBox empresaInicio;
        private System.Windows.Forms.ComboBox archivoClientesComboBox;
        private System.Windows.Forms.ComboBox SerieInicio;
        private System.Windows.Forms.ComboBox tipoExtensionArticulosComboBox;
        private System.Windows.Forms.ComboBox EjercicioInicio;
        private System.Windows.Forms.ComboBox archivoArticulosComboBox;
        public System.Windows.Forms.ComboBox provinciaInicio;
        public System.Windows.Forms.ComboBox PaisInicio;
        public System.Windows.Forms.Button BtnVolverConfi_Inicio;
        private System.Windows.Forms.DataGridView dtInicioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        public System.Windows.Forms.Button BtnGuardarInicio;
        private System.Windows.Forms.BindingSource dtTarifaTipoBindingSource;
    }
}