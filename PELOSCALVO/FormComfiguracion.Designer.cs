
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
            System.Windows.Forms.Label idEmpresaLabel1;
            System.Windows.Forms.Label empresaConfiLabel1;
            System.Windows.Forms.Label enlaceTarifaLabel;
            System.Windows.Forms.Label tarifaTipoLabel;
            System.Windows.Forms.Label idTarifaLabel;
            System.Windows.Forms.Label empresaConfiLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.TabTablas = new System.Windows.Forms.TabPage();
            this.DataGridTablas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTablaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabObras = new System.Windows.Forms.TabPage();
            this.BtnGuardarObras = new System.Windows.Forms.Button();
            this.BtnVolverObras = new System.Windows.Forms.Button();
            this.dataGridObras = new System.Windows.Forms.DataGridView();
            this.idObrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.tabPageTarifa = new System.Windows.Forms.TabPage();
            this.EnlaceTarifa = new System.Windows.Forms.Label();
            this.IdEmpresa = new System.Windows.Forms.Label();
            this.IdTarifa = new System.Windows.Forms.Label();
            this.BtnVolverDescuentos = new System.Windows.Forms.Button();
            this.dtTarifaTipoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifaTipoTextBox = new System.Windows.Forms.TextBox();
            this.empresaConfiComboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnCancelarTipoTarifa = new System.Windows.Forms.Button();
            this.BtnGuardarDescuentos = new System.Windows.Forms.Button();
            this.panelBotonesTipoTarifa = new System.Windows.Forms.Panel();
            this.BtnBuscarTipoTarifa = new System.Windows.Forms.Button();
            this.BtnNuevoTipoTarifa = new System.Windows.Forms.Button();
            this.BtnModificarTipoTarifa = new System.Windows.Forms.Button();
            this.empresaConfiComboBox = new System.Windows.Forms.ComboBox();
            this.tabMENU = new System.Windows.Forms.TabPage();
            this.BtnRestructurar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirBaseDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirPdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirBaseDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearBaseDatosSqlLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Abrir_Correos = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCopiaSeguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCopiaSeguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCopiaSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCopiaCompletaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarCopiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tooInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDeInicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDescuentos = new System.Windows.Forms.ToolStripMenuItem();
            this.editarDescuentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verDescuentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolFamilia = new System.Windows.Forms.ToolStripMenuItem();
            this.familiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.índiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSalirTipoTarifa = new System.Windows.Forms.Button();
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
            idEmpresaLabel1 = new System.Windows.Forms.Label();
            empresaConfiLabel1 = new System.Windows.Forms.Label();
            enlaceTarifaLabel = new System.Windows.Forms.Label();
            tarifaTipoLabel = new System.Windows.Forms.Label();
            idTarifaLabel = new System.Windows.Forms.Label();
            empresaConfiLabel = new System.Windows.Forms.Label();
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
            this.TabTablas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTablas)).BeginInit();
            this.tabObras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridObras)).BeginInit();
            this.tabPageInicio.SuspendLayout();
            this.panelDatosInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioDataGridView)).BeginInit();
            this.tabPageTarifa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarifaTipoDataGridView)).BeginInit();
            this.panelBotonesTipoTarifa.SuspendLayout();
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
            // idEmpresaLabel1
            // 
            idEmpresaLabel1.AutoSize = true;
            idEmpresaLabel1.Location = new System.Drawing.Point(414, 345);
            idEmpresaLabel1.Name = "idEmpresaLabel1";
            idEmpresaLabel1.Size = new System.Drawing.Size(63, 13);
            idEmpresaLabel1.TabIndex = 41;
            idEmpresaLabel1.Text = "Id Empresa:";
            // 
            // empresaConfiLabel1
            // 
            empresaConfiLabel1.AutoSize = true;
            empresaConfiLabel1.Location = new System.Drawing.Point(414, 318);
            empresaConfiLabel1.Name = "empresaConfiLabel1";
            empresaConfiLabel1.Size = new System.Drawing.Size(78, 13);
            empresaConfiLabel1.TabIndex = 39;
            empresaConfiLabel1.Text = "Empresa Confi:";
            // 
            // enlaceTarifaLabel
            // 
            enlaceTarifaLabel.AutoSize = true;
            enlaceTarifaLabel.Location = new System.Drawing.Point(31, 341);
            enlaceTarifaLabel.Name = "enlaceTarifaLabel";
            enlaceTarifaLabel.Size = new System.Drawing.Size(37, 13);
            enlaceTarifaLabel.TabIndex = 46;
            enlaceTarifaLabel.Text = "Tarifa:";
            // 
            // tarifaTipoLabel
            // 
            tarifaTipoLabel.AutoSize = true;
            tarifaTipoLabel.Location = new System.Drawing.Point(14, 366);
            tarifaTipoLabel.Name = "tarifaTipoLabel";
            tarifaTipoLabel.Size = new System.Drawing.Size(61, 13);
            tarifaTipoLabel.TabIndex = 44;
            tarifaTipoLabel.Text = "Tarifa Tipo:";
            // 
            // idTarifaLabel
            // 
            idTarifaLabel.AutoSize = true;
            idTarifaLabel.Location = new System.Drawing.Point(51, 315);
            idTarifaLabel.Name = "idTarifaLabel";
            idTarifaLabel.Size = new System.Drawing.Size(19, 13);
            idTarifaLabel.TabIndex = 42;
            idTarifaLabel.Text = "Id:";
            // 
            // empresaConfiLabel
            // 
            empresaConfiLabel.AutoSize = true;
            empresaConfiLabel.Location = new System.Drawing.Point(451, 354);
            empresaConfiLabel.Name = "empresaConfiLabel";
            empresaConfiLabel.Size = new System.Drawing.Size(43, 13);
            empresaConfiLabel.TabIndex = 9;
            empresaConfiLabel.Text = "Buscar:";
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
            // TabTablas
            // 
            this.TabTablas.Controls.Add(this.DataGridTablas);
            this.TabTablas.Location = new System.Drawing.Point(4, 25);
            this.TabTablas.Name = "TabTablas";
            this.TabTablas.Padding = new System.Windows.Forms.Padding(3);
            this.TabTablas.Size = new System.Drawing.Size(1012, 463);
            this.TabTablas.TabIndex = 12;
            this.TabTablas.Text = "Tipos de Tablas ";
            this.TabTablas.UseVisualStyleBackColor = true;
            // 
            // DataGridTablas
            // 
            this.DataGridTablas.AllowDrop = true;
            this.DataGridTablas.AllowUserToResizeRows = false;
            this.DataGridTablas.AutoGenerateColumns = false;
            this.DataGridTablas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridTablas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.DataGridTablas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridTablas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridTablas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridTablas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nombreTablaDataGridViewTextBoxColumn,
            this.dataGridViewImageColumn1,
            this.dataGridViewImageColumn2});
            this.DataGridTablas.DataSource = this.dtNombresTablasBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridTablas.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridTablas.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataGridTablas.EnableHeadersVisualStyles = false;
            this.DataGridTablas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DataGridTablas.Location = new System.Drawing.Point(3, 3);
            this.DataGridTablas.MultiSelect = false;
            this.DataGridTablas.Name = "DataGridTablas";
            this.DataGridTablas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridTablas.Size = new System.Drawing.Size(1006, 374);
            this.DataGridTablas.TabIndex = 50;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.FillWeight = 80F;
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nombreTablaDataGridViewTextBoxColumn
            // 
            this.nombreTablaDataGridViewTextBoxColumn.DataPropertyName = "NombreTabla";
            this.nombreTablaDataGridViewTextBoxColumn.FillWeight = 200F;
            this.nombreTablaDataGridViewTextBoxColumn.HeaderText = "NombreTabla";
            this.nombreTablaDataGridViewTextBoxColumn.Name = "nombreTablaDataGridViewTextBoxColumn";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 90F;
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_pen_8_32;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 90F;
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_trash_can_17_32;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabObras
            // 
            this.tabObras.Controls.Add(this.BtnGuardarObras);
            this.tabObras.Controls.Add(this.BtnVolverObras);
            this.tabObras.Controls.Add(this.dataGridObras);
            this.tabObras.Location = new System.Drawing.Point(4, 25);
            this.tabObras.Name = "tabObras";
            this.tabObras.Padding = new System.Windows.Forms.Padding(3);
            this.tabObras.Size = new System.Drawing.Size(1012, 531);
            this.tabObras.TabIndex = 11;
            this.tabObras.Text = "Obras";
            this.tabObras.UseVisualStyleBackColor = true;
            // 
            // BtnGuardarObras
            // 
            this.BtnGuardarObras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarObras.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarObras.FlatAppearance.BorderSize = 0;
            this.BtnGuardarObras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnGuardarObras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnGuardarObras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarObras.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarObras.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_check_mark_9_24;
            this.BtnGuardarObras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarObras.Location = new System.Drawing.Point(676, 497);
            this.BtnGuardarObras.Name = "BtnGuardarObras";
            this.BtnGuardarObras.Size = new System.Drawing.Size(107, 42);
            this.BtnGuardarObras.TabIndex = 51;
            this.BtnGuardarObras.Text = "Actualizar";
            this.BtnGuardarObras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarObras.UseVisualStyleBackColor = false;
            this.BtnGuardarObras.Click += new System.EventHandler(this.BtnGuardarObras_Click);
            // 
            // BtnVolverObras
            // 
            this.BtnVolverObras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVolverObras.BackColor = System.Drawing.Color.Transparent;
            this.BtnVolverObras.FlatAppearance.BorderSize = 0;
            this.BtnVolverObras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnVolverObras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnVolverObras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolverObras.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolverObras.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_undo_4_24;
            this.BtnVolverObras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVolverObras.Location = new System.Drawing.Point(828, 497);
            this.BtnVolverObras.Name = "BtnVolverObras";
            this.BtnVolverObras.Size = new System.Drawing.Size(107, 42);
            this.BtnVolverObras.TabIndex = 50;
            this.BtnVolverObras.Text = "Volver";
            this.BtnVolverObras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVolverObras.UseVisualStyleBackColor = false;
            this.BtnVolverObras.Click += new System.EventHandler(this.BtnVolverObras_Click);
            // 
            // dataGridObras
            // 
            this.dataGridObras.AllowDrop = true;
            this.dataGridObras.AllowUserToResizeRows = false;
            this.dataGridObras.AutoGenerateColumns = false;
            this.dataGridObras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridObras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(70)))));
            this.dataGridObras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridObras.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridObras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridObras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridObras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idObrasDataGridViewTextBoxColumn,
            this.obrasDataGridViewTextBoxColumn,
            this.dataGridViewImageColumn5,
            this.dataGridViewImageColumn6});
            this.dataGridObras.DataSource = this.dtObrasBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridObras.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridObras.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridObras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dataGridObras.Location = new System.Drawing.Point(3, 3);
            this.dataGridObras.MultiSelect = false;
            this.dataGridObras.Name = "dataGridObras";
            this.dataGridObras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridObras.Size = new System.Drawing.Size(1006, 374);
            this.dataGridObras.TabIndex = 49;
            this.dataGridObras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridObras_CellClick);
            this.dataGridObras.Validated += new System.EventHandler(this.dataGridObras_Validated);
            // 
            // idObrasDataGridViewTextBoxColumn
            // 
            this.idObrasDataGridViewTextBoxColumn.DataPropertyName = "Id_Obras";
            this.idObrasDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idObrasDataGridViewTextBoxColumn.Name = "idObrasDataGridViewTextBoxColumn";
            this.idObrasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // obrasDataGridViewTextBoxColumn
            // 
            this.obrasDataGridViewTextBoxColumn.DataPropertyName = "Obras";
            this.obrasDataGridViewTextBoxColumn.FillWeight = 300F;
            this.obrasDataGridViewTextBoxColumn.HeaderText = "Obras";
            this.obrasDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.obrasDataGridViewTextBoxColumn.Name = "obrasDataGridViewTextBoxColumn";
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.FillWeight = 90F;
            this.dataGridViewImageColumn5.HeaderText = "Editar";
            this.dataGridViewImageColumn5.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_pen_8_32;
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.ReadOnly = true;
            this.dataGridViewImageColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn6
            // 
            this.dataGridViewImageColumn6.FillWeight = 98F;
            this.dataGridViewImageColumn6.HeaderText = "Eliminar";
            this.dataGridViewImageColumn6.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_trash_can_17_32;
            this.dataGridViewImageColumn6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn6.Name = "dataGridViewImageColumn6";
            this.dataGridViewImageColumn6.ReadOnly = true;
            this.dataGridViewImageColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.tabPageInicio.Size = new System.Drawing.Size(1012, 463);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtInicioDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtInicioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtInicioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn12});
            this.dtInicioDataGridView.DataSource = this.dtInicioMultiBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtInicioDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
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
            // tabPageTarifa
            // 
            this.tabPageTarifa.AutoScroll = true;
            this.tabPageTarifa.Controls.Add(this.EnlaceTarifa);
            this.tabPageTarifa.Controls.Add(this.IdEmpresa);
            this.tabPageTarifa.Controls.Add(this.IdTarifa);
            this.tabPageTarifa.Controls.Add(this.BtnVolverDescuentos);
            this.tabPageTarifa.Controls.Add(this.dtTarifaTipoDataGridView);
            this.tabPageTarifa.Controls.Add(idTarifaLabel);
            this.tabPageTarifa.Controls.Add(tarifaTipoLabel);
            this.tabPageTarifa.Controls.Add(this.tarifaTipoTextBox);
            this.tabPageTarifa.Controls.Add(enlaceTarifaLabel);
            this.tabPageTarifa.Controls.Add(empresaConfiLabel1);
            this.tabPageTarifa.Controls.Add(this.empresaConfiComboBox1);
            this.tabPageTarifa.Controls.Add(idEmpresaLabel1);
            this.tabPageTarifa.Controls.Add(this.BtnCancelarTipoTarifa);
            this.tabPageTarifa.Controls.Add(this.BtnGuardarDescuentos);
            this.tabPageTarifa.Controls.Add(this.panelBotonesTipoTarifa);
            this.tabPageTarifa.Location = new System.Drawing.Point(4, 25);
            this.tabPageTarifa.Name = "tabPageTarifa";
            this.tabPageTarifa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTarifa.Size = new System.Drawing.Size(1012, 463);
            this.tabPageTarifa.TabIndex = 4;
            this.tabPageTarifa.Text = "Descuentos Clientes";
            this.tabPageTarifa.UseVisualStyleBackColor = true;
            // 
            // EnlaceTarifa
            // 
            this.EnlaceTarifa.AutoSize = true;
            this.EnlaceTarifa.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.dtConfiDtTarifaTipoBindingSource, "EnlaceTarifa", true));
            this.EnlaceTarifa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtConfiguracionPrincipalBindingSource, "IdEmpresa", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.EnlaceTarifa.Location = new System.Drawing.Point(76, 339);
            this.EnlaceTarifa.Name = "EnlaceTarifa";
            this.EnlaceTarifa.Size = new System.Drawing.Size(40, 13);
            this.EnlaceTarifa.TabIndex = 51;
            this.EnlaceTarifa.Text = "Enlace";
            this.EnlaceTarifa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IdEmpresa
            // 
            this.IdEmpresa.AutoSize = true;
            this.IdEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtConfiguracionPrincipalBindingSource, "IdEmpresa", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.IdEmpresa.Location = new System.Drawing.Point(508, 345);
            this.IdEmpresa.Name = "IdEmpresa";
            this.IdEmpresa.Size = new System.Drawing.Size(15, 15);
            this.IdEmpresa.TabIndex = 50;
            this.IdEmpresa.Text = "2";
            this.IdEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IdTarifa
            // 
            this.IdTarifa.AutoSize = true;
            this.IdTarifa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdTarifa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtConfiDtTarifaTipoBindingSource, "IdTarifa", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.IdTarifa.Location = new System.Drawing.Point(76, 315);
            this.IdTarifa.Name = "IdTarifa";
            this.IdTarifa.Size = new System.Drawing.Size(15, 15);
            this.IdTarifa.TabIndex = 49;
            this.IdTarifa.Text = "1";
            this.IdTarifa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnVolverDescuentos
            // 
            this.BtnVolverDescuentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVolverDescuentos.BackColor = System.Drawing.Color.Transparent;
            this.BtnVolverDescuentos.FlatAppearance.BorderSize = 0;
            this.BtnVolverDescuentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnVolverDescuentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnVolverDescuentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolverDescuentos.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolverDescuentos.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_undo_4_24;
            this.BtnVolverDescuentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVolverDescuentos.Location = new System.Drawing.Point(879, 435);
            this.BtnVolverDescuentos.Name = "BtnVolverDescuentos";
            this.BtnVolverDescuentos.Size = new System.Drawing.Size(107, 42);
            this.BtnVolverDescuentos.TabIndex = 48;
            this.BtnVolverDescuentos.Text = "Volver";
            this.BtnVolverDescuentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVolverDescuentos.UseVisualStyleBackColor = false;
            this.BtnVolverDescuentos.Click += new System.EventHandler(this.BtnVolverDescuentos_Click);
            // 
            // dtTarifaTipoDataGridView
            // 
            this.dtTarifaTipoDataGridView.AllowUserToAddRows = false;
            this.dtTarifaTipoDataGridView.AllowUserToDeleteRows = false;
            this.dtTarifaTipoDataGridView.AllowUserToResizeRows = false;
            this.dtTarifaTipoDataGridView.AutoGenerateColumns = false;
            this.dtTarifaTipoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtTarifaTipoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtTarifaTipoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTarifaTipoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.dtTarifaTipoDataGridView.DataSource = this.dtConfiDtTarifaTipoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtTarifaTipoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtTarifaTipoDataGridView.Location = new System.Drawing.Point(79, 20);
            this.dtTarifaTipoDataGridView.Name = "dtTarifaTipoDataGridView";
            this.dtTarifaTipoDataGridView.ReadOnly = true;
            this.dtTarifaTipoDataGridView.RowHeadersVisible = false;
            this.dtTarifaTipoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtTarifaTipoDataGridView.Size = new System.Drawing.Size(715, 275);
            this.dtTarifaTipoDataGridView.TabIndex = 47;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IdTarifa";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "TarifaTipo";
            this.dataGridViewTextBoxColumn13.FillWeight = 190F;
            this.dataGridViewTextBoxColumn13.HeaderText = "Tarifa";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "EnlaceTarifa";
            this.dataGridViewTextBoxColumn14.HeaderText = "Empresa";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // tarifaTipoTextBox
            // 
            this.tarifaTipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtConfiDtTarifaTipoBindingSource, "TarifaTipo", true));
            this.tarifaTipoTextBox.Location = new System.Drawing.Point(79, 363);
            this.tarifaTipoTextBox.Name = "tarifaTipoTextBox";
            this.tarifaTipoTextBox.ReadOnly = true;
            this.tarifaTipoTextBox.Size = new System.Drawing.Size(231, 20);
            this.tarifaTipoTextBox.TabIndex = 45;
            // 
            // empresaConfiComboBox1
            // 
            this.empresaConfiComboBox1.DataSource = this.dtConfiguracionPrincipalBindingSource;
            this.empresaConfiComboBox1.DisplayMember = "EmpresaConfi";
            this.empresaConfiComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empresaConfiComboBox1.FormattingEnabled = true;
            this.empresaConfiComboBox1.Location = new System.Drawing.Point(498, 315);
            this.empresaConfiComboBox1.Name = "empresaConfiComboBox1";
            this.empresaConfiComboBox1.Size = new System.Drawing.Size(334, 21);
            this.empresaConfiComboBox1.TabIndex = 40;
            // 
            // BtnCancelarTipoTarifa
            // 
            this.BtnCancelarTipoTarifa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelarTipoTarifa.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelarTipoTarifa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelarTipoTarifa.Enabled = false;
            this.BtnCancelarTipoTarifa.FlatAppearance.BorderSize = 0;
            this.BtnCancelarTipoTarifa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancelarTipoTarifa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnCancelarTipoTarifa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarTipoTarifa.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarTipoTarifa.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_x_mark_8_24;
            this.BtnCancelarTipoTarifa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarTipoTarifa.Location = new System.Drawing.Point(649, 435);
            this.BtnCancelarTipoTarifa.Name = "BtnCancelarTipoTarifa";
            this.BtnCancelarTipoTarifa.Size = new System.Drawing.Size(89, 42);
            this.BtnCancelarTipoTarifa.TabIndex = 34;
            this.BtnCancelarTipoTarifa.Text = "Cancelar";
            this.BtnCancelarTipoTarifa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelarTipoTarifa.UseVisualStyleBackColor = false;
            this.BtnCancelarTipoTarifa.Click += new System.EventHandler(this.BtnCancelarTipoTarifa_Click);
            // 
            // BtnGuardarDescuentos
            // 
            this.BtnGuardarDescuentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarDescuentos.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarDescuentos.Enabled = false;
            this.BtnGuardarDescuentos.FlatAppearance.BorderSize = 0;
            this.BtnGuardarDescuentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnGuardarDescuentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnGuardarDescuentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarDescuentos.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarDescuentos.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_check_mark_9_24;
            this.BtnGuardarDescuentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarDescuentos.Location = new System.Drawing.Point(498, 435);
            this.BtnGuardarDescuentos.Name = "BtnGuardarDescuentos";
            this.BtnGuardarDescuentos.Size = new System.Drawing.Size(89, 42);
            this.BtnGuardarDescuentos.TabIndex = 33;
            this.BtnGuardarDescuentos.Text = "Aceptar";
            this.BtnGuardarDescuentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarDescuentos.UseVisualStyleBackColor = false;
            this.BtnGuardarDescuentos.Click += new System.EventHandler(this.BtnGuardarDescuentos_Click);
            // 
            // panelBotonesTipoTarifa
            // 
            this.panelBotonesTipoTarifa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelBotonesTipoTarifa.BackColor = System.Drawing.Color.Transparent;
            this.panelBotonesTipoTarifa.Controls.Add(this.BtnBuscarTipoTarifa);
            this.panelBotonesTipoTarifa.Controls.Add(this.BtnNuevoTipoTarifa);
            this.panelBotonesTipoTarifa.Controls.Add(this.BtnModificarTipoTarifa);
            this.panelBotonesTipoTarifa.Location = new System.Drawing.Point(17, 414);
            this.panelBotonesTipoTarifa.Name = "panelBotonesTipoTarifa";
            this.panelBotonesTipoTarifa.Size = new System.Drawing.Size(401, 63);
            this.panelBotonesTipoTarifa.TabIndex = 31;
            // 
            // BtnBuscarTipoTarifa
            // 
            this.BtnBuscarTipoTarifa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarTipoTarifa.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscarTipoTarifa.FlatAppearance.BorderSize = 0;
            this.BtnBuscarTipoTarifa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnBuscarTipoTarifa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnBuscarTipoTarifa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarTipoTarifa.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarTipoTarifa.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_magnifier_4_32;
            this.BtnBuscarTipoTarifa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscarTipoTarifa.Location = new System.Drawing.Point(166, 3);
            this.BtnBuscarTipoTarifa.Name = "BtnBuscarTipoTarifa";
            this.BtnBuscarTipoTarifa.Size = new System.Drawing.Size(77, 63);
            this.BtnBuscarTipoTarifa.TabIndex = 8;
            this.BtnBuscarTipoTarifa.Text = "Buscar";
            this.BtnBuscarTipoTarifa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscarTipoTarifa.UseVisualStyleBackColor = false;
            // 
            // BtnNuevoTipoTarifa
            // 
            this.BtnNuevoTipoTarifa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNuevoTipoTarifa.BackColor = System.Drawing.Color.Transparent;
            this.BtnNuevoTipoTarifa.FlatAppearance.BorderSize = 0;
            this.BtnNuevoTipoTarifa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnNuevoTipoTarifa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnNuevoTipoTarifa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoTipoTarifa.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoTipoTarifa.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_file_14_32;
            this.BtnNuevoTipoTarifa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevoTipoTarifa.Location = new System.Drawing.Point(12, 3);
            this.BtnNuevoTipoTarifa.Name = "BtnNuevoTipoTarifa";
            this.BtnNuevoTipoTarifa.Size = new System.Drawing.Size(77, 63);
            this.BtnNuevoTipoTarifa.TabIndex = 6;
            this.BtnNuevoTipoTarifa.Tag = "STOP";
            this.BtnNuevoTipoTarifa.Text = "Nuevo";
            this.BtnNuevoTipoTarifa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNuevoTipoTarifa.UseVisualStyleBackColor = false;
            this.BtnNuevoTipoTarifa.Click += new System.EventHandler(this.BtnNuevoTipoTarifa_Click);
            // 
            // BtnModificarTipoTarifa
            // 
            this.BtnModificarTipoTarifa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModificarTipoTarifa.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificarTipoTarifa.FlatAppearance.BorderSize = 0;
            this.BtnModificarTipoTarifa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnModificarTipoTarifa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnModificarTipoTarifa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarTipoTarifa.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarTipoTarifa.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_pen_8_32;
            this.BtnModificarTipoTarifa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnModificarTipoTarifa.Location = new System.Drawing.Point(89, 3);
            this.BtnModificarTipoTarifa.Name = "BtnModificarTipoTarifa";
            this.BtnModificarTipoTarifa.Size = new System.Drawing.Size(77, 63);
            this.BtnModificarTipoTarifa.TabIndex = 7;
            this.BtnModificarTipoTarifa.Text = "Modificar";
            this.BtnModificarTipoTarifa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificarTipoTarifa.UseVisualStyleBackColor = false;
            this.BtnModificarTipoTarifa.Click += new System.EventHandler(this.BtnModificarTipoTarifa_Click);
            // 
            // empresaConfiComboBox
            // 
            this.empresaConfiComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.empresaConfiComboBox.DataSource = this.dtConfiguracionPrincipalBindingSource;
            this.empresaConfiComboBox.DisplayMember = "EmpresaConfi";
            this.empresaConfiComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empresaConfiComboBox.FormattingEnabled = true;
            this.empresaConfiComboBox.Location = new System.Drawing.Point(500, 346);
            this.empresaConfiComboBox.Name = "empresaConfiComboBox";
            this.empresaConfiComboBox.Size = new System.Drawing.Size(282, 21);
            this.empresaConfiComboBox.TabIndex = 10;
            // 
            // tabMENU
            // 
            this.tabMENU.Controls.Add(this.BtnRestructurar);
            this.tabMENU.Controls.Add(this.empresaConfiComboBox);
            this.tabMENU.Controls.Add(empresaConfiLabel);
            this.tabMENU.Controls.Add(this.label5);
            this.tabMENU.Controls.Add(this.menuStrip);
            this.tabMENU.Controls.Add(this.BtnSalirTipoTarifa);
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
            this.BtnRestructurar.Location = new System.Drawing.Point(680, 227);
            this.BtnRestructurar.Name = "BtnRestructurar";
            this.BtnRestructurar.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.BtnRestructurar.Size = new System.Drawing.Size(277, 42);
            this.BtnRestructurar.TabIndex = 47;
            this.BtnRestructurar.Text = "RESTRUCTURAR ARCHIVOS";
            this.BtnRestructurar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnRestructurar.UseVisualStyleBackColor = false;
            this.BtnRestructurar.Click += new System.EventHandler(this.BtnRestructurar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(881, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "label5";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolArchivo,
            this.toolCopiaSeguridad,
            this.tooInicio,
            this.toolDescuentos,
            this.toolFamilia,
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
            this.Abrir_Correos,
            this.imprimirReportesToolStripMenuItem});
            this.toolArchivo.Name = "toolArchivo";
            this.toolArchivo.Size = new System.Drawing.Size(60, 20);
            this.toolArchivo.Text = "Archivo";
            this.toolArchivo.MouseEnter += new System.EventHandler(this.toolArchivo_MouseEnter);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.verToolStripMenuItem.Text = "&Ver";
            // 
            // abrirBaseDatosToolStripMenuItem
            // 
            this.abrirBaseDatosToolStripMenuItem.Name = "abrirBaseDatosToolStripMenuItem";
            this.abrirBaseDatosToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.abrirBaseDatosToolStripMenuItem.Text = "&Abrir Base Datos";
            // 
            // abrirPdfToolStripMenuItem
            // 
            this.abrirPdfToolStripMenuItem.Name = "abrirPdfToolStripMenuItem";
            this.abrirPdfToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.abrirPdfToolStripMenuItem.Text = "&Abrir P.d.f";
            // 
            // añadirBaseDatosToolStripMenuItem
            // 
            this.añadirBaseDatosToolStripMenuItem.Name = "añadirBaseDatosToolStripMenuItem";
            this.añadirBaseDatosToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.añadirBaseDatosToolStripMenuItem.Text = "&Añadir Archivos Datos";
            this.añadirBaseDatosToolStripMenuItem.Click += new System.EventHandler(this.añadirBaseDatosToolStripMenuItem_Click);
            // 
            // crearBaseDatosSqlLocalToolStripMenuItem
            // 
            this.crearBaseDatosSqlLocalToolStripMenuItem.Name = "crearBaseDatosSqlLocalToolStripMenuItem";
            this.crearBaseDatosSqlLocalToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.crearBaseDatosSqlLocalToolStripMenuItem.Text = "&Base Datos Sql local";
            this.crearBaseDatosSqlLocalToolStripMenuItem.Click += new System.EventHandler(this.crearBaseDatosSqlLocalToolStripMenuItem_Click);
            // 
            // Abrir_Correos
            // 
            this.Abrir_Correos.Name = "Abrir_Correos";
            this.Abrir_Correos.Size = new System.Drawing.Size(205, 22);
            this.Abrir_Correos.Text = "&Abrir Correos Eletronicos";
            this.Abrir_Correos.Click += new System.EventHandler(this.baseDatosLocalToolStripMenuItem_Click);
            // 
            // imprimirReportesToolStripMenuItem
            // 
            this.imprimirReportesToolStripMenuItem.Name = "imprimirReportesToolStripMenuItem";
            this.imprimirReportesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
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
            // tooInicio
            // 
            this.tooInicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDeInicioToolStripMenuItem,
            this.configurarDatosToolStripMenuItem});
            this.tooInicio.Name = "tooInicio";
            this.tooInicio.Size = new System.Drawing.Size(127, 20);
            this.tooInicio.Text = "Configuracion Inicio";
            // 
            // datosDeInicioToolStripMenuItem
            // 
            this.datosDeInicioToolStripMenuItem.Name = "datosDeInicioToolStripMenuItem";
            this.datosDeInicioToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.datosDeInicioToolStripMenuItem.Text = "Consultar Datos";
            this.datosDeInicioToolStripMenuItem.Click += new System.EventHandler(this.datosDeInicioToolStripMenuItem_Click);
            // 
            // configurarDatosToolStripMenuItem
            // 
            this.configurarDatosToolStripMenuItem.Name = "configurarDatosToolStripMenuItem";
            this.configurarDatosToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.configurarDatosToolStripMenuItem.Text = "Configurar Datos";
            this.configurarDatosToolStripMenuItem.Click += new System.EventHandler(this.configurarDatosToolStripMenuItem_Click);
            // 
            // toolDescuentos
            // 
            this.toolDescuentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarDescuentosToolStripMenuItem,
            this.verDescuentosToolStripMenuItem});
            this.toolDescuentos.Name = "toolDescuentos";
            this.toolDescuentos.Size = new System.Drawing.Size(125, 20);
            this.toolDescuentos.Text = "Descuentos Clientes";
            // 
            // editarDescuentosToolStripMenuItem
            // 
            this.editarDescuentosToolStripMenuItem.Name = "editarDescuentosToolStripMenuItem";
            this.editarDescuentosToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.editarDescuentosToolStripMenuItem.Text = "Editar Descuentos";
            this.editarDescuentosToolStripMenuItem.Click += new System.EventHandler(this.editarDescuentosToolStripMenuItem_Click);
            // 
            // verDescuentosToolStripMenuItem
            // 
            this.verDescuentosToolStripMenuItem.Name = "verDescuentosToolStripMenuItem";
            this.verDescuentosToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.verDescuentosToolStripMenuItem.Text = "Ver Descuentos";
            this.verDescuentosToolStripMenuItem.Click += new System.EventHandler(this.verDescuentosToolStripMenuItem_Click);
            // 
            // toolFamilia
            // 
            this.toolFamilia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.familiasToolStripMenuItem});
            this.toolFamilia.Name = "toolFamilia";
            this.toolFamilia.Size = new System.Drawing.Size(114, 20);
            this.toolFamilia.Text = "Familia Productos";
            // 
            // familiasToolStripMenuItem
            // 
            this.familiasToolStripMenuItem.Name = "familiasToolStripMenuItem";
            this.familiasToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.familiasToolStripMenuItem.Text = "Familias";
            this.familiasToolStripMenuItem.Click += new System.EventHandler(this.familiasToolStripMenuItem_Click);
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
            // BtnSalirTipoTarifa
            // 
            this.BtnSalirTipoTarifa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalirTipoTarifa.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalirTipoTarifa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalirTipoTarifa.FlatAppearance.BorderSize = 0;
            this.BtnSalirTipoTarifa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnSalirTipoTarifa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnSalirTipoTarifa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalirTipoTarifa.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirTipoTarifa.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_door_5_32;
            this.BtnSalirTipoTarifa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalirTipoTarifa.Location = new System.Drawing.Point(902, 460);
            this.BtnSalirTipoTarifa.Name = "BtnSalirTipoTarifa";
            this.BtnSalirTipoTarifa.Size = new System.Drawing.Size(77, 63);
            this.BtnSalirTipoTarifa.TabIndex = 13;
            this.BtnSalirTipoTarifa.Text = "Salir";
            this.BtnSalirTipoTarifa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalirTipoTarifa.UseVisualStyleBackColor = false;
            this.BtnSalirTipoTarifa.Click += new System.EventHandler(this.BtnSalirTipoTarifa_Click);
            // 
            // tabControlTodo
            // 
            this.tabControlTodo.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlTodo.Controls.Add(this.tabMENU);
            this.tabControlTodo.Controls.Add(this.tabPageTarifa);
            this.tabControlTodo.Controls.Add(this.tabPageInicio);
            this.tabControlTodo.Controls.Add(this.tabObras);
            this.tabControlTodo.Controls.Add(this.TabTablas);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
            this.TabTablas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTablas)).EndInit();
            this.tabObras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridObras)).EndInit();
            this.tabPageInicio.ResumeLayout(false);
            this.panelDatosInicio.ResumeLayout(false);
            this.panelDatosInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioDataGridView)).EndInit();
            this.tabPageTarifa.ResumeLayout(false);
            this.tabPageTarifa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarifaTipoDataGridView)).EndInit();
            this.panelBotonesTipoTarifa.ResumeLayout(false);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolArchivo;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirBaseDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirPdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirBaseDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearBaseDatosSqlLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Abrir_Correos;
        private System.Windows.Forms.ToolStripMenuItem imprimirReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolCopiaSeguridad;
        private System.Windows.Forms.ToolStripMenuItem crearCopiaSeguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCopiaSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCopiaCompletaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restaurarCopiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tooInicio;
        private System.Windows.Forms.ToolStripMenuItem datosDeInicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolDescuentos;
        private System.Windows.Forms.ToolStripMenuItem editarDescuentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDescuentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolFamilia;
        private System.Windows.Forms.ToolStripMenuItem familiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem índiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.Button BtnSalirTipoTarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiaProductosDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox empresaConfiComboBox;
        private System.Windows.Forms.TabPage tabPageTarifa;
        private System.Windows.Forms.Label EnlaceTarifa;
        private System.Windows.Forms.Label IdEmpresa;
        private System.Windows.Forms.Label IdTarifa;
        public System.Windows.Forms.Button BtnVolverDescuentos;
        private System.Windows.Forms.DataGridView dtTarifaTipoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.TextBox tarifaTipoTextBox;
        private System.Windows.Forms.ComboBox empresaConfiComboBox1;
        private System.Windows.Forms.Button BtnCancelarTipoTarifa;
        public System.Windows.Forms.Button BtnGuardarDescuentos;
        private System.Windows.Forms.Panel panelBotonesTipoTarifa;
        private System.Windows.Forms.Button BtnBuscarTipoTarifa;
        private System.Windows.Forms.Button BtnNuevoTipoTarifa;
        private System.Windows.Forms.Button BtnModificarTipoTarifa;
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
        private System.Windows.Forms.TabPage tabObras;
        public System.Windows.Forms.Button BtnGuardarObras;
        public System.Windows.Forms.Button BtnVolverObras;
        private System.Windows.Forms.DataGridView dataGridObras;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn6;
        private System.Windows.Forms.TabPage TabTablas;
        private System.Windows.Forms.DataGridView DataGridTablas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTablaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.BindingSource dtTarifaTipoBindingSource;
    }
}