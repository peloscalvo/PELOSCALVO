
namespace PELOSCALVO
{
    partial class FormDatosInicio
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
            System.Windows.Forms.Label archivoClientesLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label tipoExtensionArticulosLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label archivoArticulosLabel;
            System.Windows.Forms.Label pais_FactLabel;
            System.Windows.Forms.Label provinciaLabel;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatosInicio));
            this.ErrorInico = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtPaisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMulti2 = new PELOSCALVO.DsMulti2();
            this.dsCONFIGURACCION = new PELOSCALVO.DsCONFIGURACCION();
            this.dsMultidatos = new PELOSCALVO.DsMultidatos();
            this.dtProvinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtInicioMultiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtConfiguracionPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PanelDatosInicio = new System.Windows.Forms.Panel();
            this.CodigoBarras = new System.Windows.Forms.ComboBox();
            this.Id_Inicio = new System.Windows.Forms.Label();
            this.EmpresaInicio = new System.Windows.Forms.ComboBox();
            this.ArchivoClienteTxt = new System.Windows.Forms.ComboBox();
            this.SerieInicio = new System.Windows.Forms.ComboBox();
            this.ExtensionTipoInicio = new System.Windows.Forms.ComboBox();
            this.EjercicioInicio = new System.Windows.Forms.ComboBox();
            this.dtConfiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ArchivoArticuloTxt = new System.Windows.Forms.ComboBox();
            this.ProvinciaInicio = new System.Windows.Forms.ComboBox();
            this.PaisInicio = new System.Windows.Forms.ComboBox();
            this.dtInicioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCancelarInicio = new System.Windows.Forms.Button();
            this.BtnSalir_Inico = new System.Windows.Forms.Button();
            this.PanelBotones_Inicio = new System.Windows.Forms.Panel();
            this.BtnModificarInicio = new System.Windows.Forms.Button();
            this.BtnGuardarInico = new System.Windows.Forms.Button();
            archivoClientesLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            tipoExtensionArticulosLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            archivoArticulosLabel = new System.Windows.Forms.Label();
            pais_FactLabel = new System.Windows.Forms.Label();
            provinciaLabel = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorInico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMulti2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProvinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).BeginInit();
            this.PanelDatosInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioDataGridView)).BeginInit();
            this.PanelBotones_Inicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // archivoClientesLabel
            // 
            archivoClientesLabel.AutoSize = true;
            archivoClientesLabel.Location = new System.Drawing.Point(7, 198);
            archivoClientesLabel.Name = "archivoClientesLabel";
            archivoClientesLabel.Size = new System.Drawing.Size(86, 13);
            archivoClientesLabel.TabIndex = 42;
            archivoClientesLabel.Text = "Archivo Clientes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(42, 16);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 13);
            label2.TabIndex = 6;
            label2.Text = "Empresa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(39, 49);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 13);
            label4.TabIndex = 24;
            label4.Text = "Ejercicios:";
            // 
            // tipoExtensionArticulosLabel
            // 
            tipoExtensionArticulosLabel.AutoSize = true;
            tipoExtensionArticulosLabel.Location = new System.Drawing.Point(417, 170);
            tipoExtensionArticulosLabel.Name = "tipoExtensionArticulosLabel";
            tipoExtensionArticulosLabel.Size = new System.Drawing.Size(56, 13);
            tipoExtensionArticulosLabel.TabIndex = 41;
            tipoExtensionArticulosLabel.Text = "Extension:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(59, 76);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(34, 13);
            label3.TabIndex = 27;
            label3.Text = "Serie:";
            // 
            // archivoArticulosLabel
            // 
            archivoArticulosLabel.AutoSize = true;
            archivoArticulosLabel.Location = new System.Drawing.Point(8, 167);
            archivoArticulosLabel.Name = "archivoArticulosLabel";
            archivoArticulosLabel.Size = new System.Drawing.Size(89, 13);
            archivoArticulosLabel.TabIndex = 39;
            archivoArticulosLabel.Text = "Archivo Articulos:";
            // 
            // pais_FactLabel
            // 
            pais_FactLabel.AutoSize = true;
            pais_FactLabel.Location = new System.Drawing.Point(63, 131);
            pais_FactLabel.Name = "pais_FactLabel";
            pais_FactLabel.Size = new System.Drawing.Size(30, 13);
            pais_FactLabel.TabIndex = 38;
            pais_FactLabel.Text = "Pais:";
            // 
            // provinciaLabel
            // 
            provinciaLabel.AutoSize = true;
            provinciaLabel.Location = new System.Drawing.Point(399, 134);
            provinciaLabel.Name = "provinciaLabel";
            provinciaLabel.Size = new System.Drawing.Size(54, 13);
            provinciaLabel.TabIndex = 36;
            provinciaLabel.Text = "Provincia:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(326, 242);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(19, 13);
            label10.TabIndex = 78;
            label10.Text = "Id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(511, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 13);
            label1.TabIndex = 80;
            label1.Text = "Codigo Barras:";
            // 
            // ErrorInico
            // 
            this.ErrorInico.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.ErrorInico.ContainerControl = this;
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
            // dsCONFIGURACCION
            // 
            this.dsCONFIGURACCION.DataSetName = "DsCONFIGURACCION";
            this.dsCONFIGURACCION.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsMultidatos
            // 
            this.dsMultidatos.DataSetName = "DsMultidatos";
            this.dsMultidatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtProvinciasBindingSource
            // 
            this.dtProvinciasBindingSource.DataMember = "FK_DtPaises_DtProvincias";
            this.dtProvinciasBindingSource.DataSource = this.dtPaisesBindingSource;
            // 
            // dtInicioMultiBindingSource
            // 
            this.dtInicioMultiBindingSource.DataMember = "DtInicioMulti";
            this.dtInicioMultiBindingSource.DataSource = this.dsMultidatos;
            // 
            // dtConfiguracionPrincipalBindingSource
            // 
            this.dtConfiguracionPrincipalBindingSource.DataMember = "DtConfiguracionPrincipal";
            this.dtConfiguracionPrincipalBindingSource.DataSource = this.dsCONFIGURACCION;
            // 
            // PanelDatosInicio
            // 
            this.PanelDatosInicio.Controls.Add(label1);
            this.PanelDatosInicio.Controls.Add(this.CodigoBarras);
            this.PanelDatosInicio.Controls.Add(this.Id_Inicio);
            this.PanelDatosInicio.Controls.Add(this.EmpresaInicio);
            this.PanelDatosInicio.Controls.Add(label10);
            this.PanelDatosInicio.Controls.Add(archivoClientesLabel);
            this.PanelDatosInicio.Controls.Add(label2);
            this.PanelDatosInicio.Controls.Add(this.ArchivoClienteTxt);
            this.PanelDatosInicio.Controls.Add(label4);
            this.PanelDatosInicio.Controls.Add(tipoExtensionArticulosLabel);
            this.PanelDatosInicio.Controls.Add(this.SerieInicio);
            this.PanelDatosInicio.Controls.Add(this.ExtensionTipoInicio);
            this.PanelDatosInicio.Controls.Add(label3);
            this.PanelDatosInicio.Controls.Add(archivoArticulosLabel);
            this.PanelDatosInicio.Controls.Add(this.EjercicioInicio);
            this.PanelDatosInicio.Controls.Add(this.ArchivoArticuloTxt);
            this.PanelDatosInicio.Controls.Add(this.ProvinciaInicio);
            this.PanelDatosInicio.Controls.Add(pais_FactLabel);
            this.PanelDatosInicio.Controls.Add(provinciaLabel);
            this.PanelDatosInicio.Controls.Add(this.PaisInicio);
            this.PanelDatosInicio.Enabled = false;
            this.PanelDatosInicio.Location = new System.Drawing.Point(23, 70);
            this.PanelDatosInicio.Name = "PanelDatosInicio";
            this.PanelDatosInicio.Size = new System.Drawing.Size(879, 273);
            this.PanelDatosInicio.TabIndex = 45;
            // 
            // CodigoBarras
            // 
            this.CodigoBarras.Cursor = System.Windows.Forms.Cursors.Default;
            this.CodigoBarras.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "CodigoBarras", true));
            this.CodigoBarras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CodigoBarras.FormattingEnabled = true;
            this.CodigoBarras.Location = new System.Drawing.Point(593, 13);
            this.CodigoBarras.Name = "CodigoBarras";
            this.CodigoBarras.Size = new System.Drawing.Size(268, 21);
            this.CodigoBarras.TabIndex = 81;
            // 
            // Id_Inicio
            // 
            this.Id_Inicio.AutoSize = true;
            this.Id_Inicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "Id", true));
            this.Id_Inicio.Location = new System.Drawing.Point(358, 242);
            this.Id_Inicio.Name = "Id_Inicio";
            this.Id_Inicio.Size = new System.Drawing.Size(13, 13);
            this.Id_Inicio.TabIndex = 79;
            this.Id_Inicio.Text = "1";
            this.Id_Inicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EmpresaInicio
            // 
            this.EmpresaInicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "EmpresaInicio", true));
            this.EmpresaInicio.DataSource = this.dtConfiguracionPrincipalBindingSource;
            this.EmpresaInicio.DisplayMember = "EmpresaConfi";
            this.EmpresaInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpresaInicio.FormattingEnabled = true;
            this.EmpresaInicio.Location = new System.Drawing.Point(103, 13);
            this.EmpresaInicio.Name = "EmpresaInicio";
            this.EmpresaInicio.Size = new System.Drawing.Size(384, 21);
            this.EmpresaInicio.TabIndex = 7;
            // 
            // ArchivoClienteTxt
            // 
            this.ArchivoClienteTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "ArchivoClientes", true));
            this.ArchivoClienteTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArchivoClienteTxt.FormattingEnabled = true;
            this.ArchivoClienteTxt.Location = new System.Drawing.Point(103, 195);
            this.ArchivoClienteTxt.Name = "ArchivoClienteTxt";
            this.ArchivoClienteTxt.Size = new System.Drawing.Size(299, 21);
            this.ArchivoClienteTxt.TabIndex = 43;
            // 
            // SerieInicio
            // 
            this.SerieInicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.SerieInicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "SerieInicio", true));
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
            this.SerieInicio.Location = new System.Drawing.Point(103, 73);
            this.SerieInicio.Name = "SerieInicio";
            this.SerieInicio.Size = new System.Drawing.Size(121, 21);
            this.SerieInicio.TabIndex = 26;
            // 
            // ExtensionTipoInicio
            // 
            this.ExtensionTipoInicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "TipoExtensionArticulos", true));
            this.ExtensionTipoInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExtensionTipoInicio.FormattingEnabled = true;
            this.ExtensionTipoInicio.Items.AddRange(new object[] {
            "mdb",
            "accdb"});
            this.ExtensionTipoInicio.Location = new System.Drawing.Point(483, 167);
            this.ExtensionTipoInicio.Name = "ExtensionTipoInicio";
            this.ExtensionTipoInicio.Size = new System.Drawing.Size(121, 21);
            this.ExtensionTipoInicio.TabIndex = 42;
            // 
            // EjercicioInicio
            // 
            this.EjercicioInicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.EjercicioInicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "EjercicioInicio", true));
            this.EjercicioInicio.DataSource = this.dtConfiBindingSource;
            this.EjercicioInicio.DisplayMember = "EjerciciosDeAño";
            this.EjercicioInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EjercicioInicio.FormattingEnabled = true;
            this.EjercicioInicio.Location = new System.Drawing.Point(103, 46);
            this.EjercicioInicio.Name = "EjercicioInicio";
            this.EjercicioInicio.Size = new System.Drawing.Size(268, 21);
            this.EjercicioInicio.TabIndex = 33;
            // 
            // dtConfiBindingSource
            // 
            this.dtConfiBindingSource.DataMember = "FK_DtConfiguracionPrincipal_DtConfi";
            this.dtConfiBindingSource.DataSource = this.dtConfiguracionPrincipalBindingSource;
            // 
            // ArchivoArticuloTxt
            // 
            this.ArchivoArticuloTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "ArchivoArticulos", true));
            this.ArchivoArticuloTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArchivoArticuloTxt.FormattingEnabled = true;
            this.ArchivoArticuloTxt.Location = new System.Drawing.Point(103, 164);
            this.ArchivoArticuloTxt.Name = "ArchivoArticuloTxt";
            this.ArchivoArticuloTxt.Size = new System.Drawing.Size(299, 21);
            this.ArchivoArticuloTxt.TabIndex = 40;
            // 
            // ProvinciaInicio
            // 
            this.ProvinciaInicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "SerieProvinciaInicio", true));
            this.ProvinciaInicio.DataSource = this.dtProvinciasBindingSource;
            this.ProvinciaInicio.DisplayMember = "Provincias";
            this.ProvinciaInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProvinciaInicio.FormattingEnabled = true;
            this.ProvinciaInicio.Location = new System.Drawing.Point(463, 131);
            this.ProvinciaInicio.Name = "ProvinciaInicio";
            this.ProvinciaInicio.Size = new System.Drawing.Size(268, 21);
            this.ProvinciaInicio.TabIndex = 37;
            // 
            // PaisInicio
            // 
            this.PaisInicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "SeriePaisInicio", true));
            this.PaisInicio.DataSource = this.dtPaisesBindingSource;
            this.PaisInicio.DisplayMember = "Paises";
            this.PaisInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaisInicio.FormattingEnabled = true;
            this.PaisInicio.Location = new System.Drawing.Point(103, 128);
            this.PaisInicio.Name = "PaisInicio";
            this.PaisInicio.Size = new System.Drawing.Size(268, 21);
            this.PaisInicio.TabIndex = 39;
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
            this.dtInicioDataGridView.Location = new System.Drawing.Point(0, 0);
            this.dtInicioDataGridView.Name = "dtInicioDataGridView";
            this.dtInicioDataGridView.ReadOnly = true;
            this.dtInicioDataGridView.RowHeadersVisible = false;
            this.dtInicioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtInicioDataGridView.Size = new System.Drawing.Size(914, 51);
            this.dtInicioDataGridView.TabIndex = 46;
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
            // BtnCancelarInicio
            // 
            this.BtnCancelarInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelarInicio.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelarInicio.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelarInicio.Enabled = false;
            this.BtnCancelarInicio.FlatAppearance.BorderSize = 0;
            this.BtnCancelarInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancelarInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnCancelarInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarInicio.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarInicio.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_x_mark_8_24;
            this.BtnCancelarInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarInicio.Location = new System.Drawing.Point(685, 383);
            this.BtnCancelarInicio.Name = "BtnCancelarInicio";
            this.BtnCancelarInicio.Size = new System.Drawing.Size(89, 42);
            this.BtnCancelarInicio.TabIndex = 77;
            this.BtnCancelarInicio.Text = "Cancelar";
            this.BtnCancelarInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelarInicio.UseVisualStyleBackColor = false;
            this.BtnCancelarInicio.Click += new System.EventHandler(this.BtnCancelarInicio_Click);
            // 
            // BtnSalir_Inico
            // 
            this.BtnSalir_Inico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir_Inico.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalir_Inico.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalir_Inico.FlatAppearance.BorderSize = 0;
            this.BtnSalir_Inico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnSalir_Inico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnSalir_Inico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir_Inico.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir_Inico.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_door_5_32;
            this.BtnSalir_Inico.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalir_Inico.Location = new System.Drawing.Point(824, 362);
            this.BtnSalir_Inico.Name = "BtnSalir_Inico";
            this.BtnSalir_Inico.Size = new System.Drawing.Size(77, 63);
            this.BtnSalir_Inico.TabIndex = 75;
            this.BtnSalir_Inico.Text = "Salir";
            this.BtnSalir_Inico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalir_Inico.UseVisualStyleBackColor = false;
            this.BtnSalir_Inico.Click += new System.EventHandler(this.BtnSalir_Inico_Click);
            // 
            // PanelBotones_Inicio
            // 
            this.PanelBotones_Inicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelBotones_Inicio.BackColor = System.Drawing.Color.Transparent;
            this.PanelBotones_Inicio.Controls.Add(this.BtnModificarInicio);
            this.PanelBotones_Inicio.Location = new System.Drawing.Point(22, 362);
            this.PanelBotones_Inicio.Name = "PanelBotones_Inicio";
            this.PanelBotones_Inicio.Size = new System.Drawing.Size(94, 63);
            this.PanelBotones_Inicio.TabIndex = 54;
            this.PanelBotones_Inicio.Tag = "NO";
            // 
            // BtnModificarInicio
            // 
            this.BtnModificarInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModificarInicio.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificarInicio.FlatAppearance.BorderSize = 0;
            this.BtnModificarInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnModificarInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnModificarInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarInicio.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarInicio.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_pen_8_32;
            this.BtnModificarInicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnModificarInicio.Location = new System.Drawing.Point(14, 0);
            this.BtnModificarInicio.Name = "BtnModificarInicio";
            this.BtnModificarInicio.Size = new System.Drawing.Size(77, 63);
            this.BtnModificarInicio.TabIndex = 7;
            this.BtnModificarInicio.Text = "&Editar";
            this.BtnModificarInicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificarInicio.UseVisualStyleBackColor = false;
            this.BtnModificarInicio.Click += new System.EventHandler(this.BtnModificarInicio_Click);
            // 
            // BtnGuardarInico
            // 
            this.BtnGuardarInico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarInico.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarInico.Enabled = false;
            this.BtnGuardarInico.FlatAppearance.BorderSize = 0;
            this.BtnGuardarInico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnGuardarInico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnGuardarInico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarInico.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarInico.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_check_mark_9_24;
            this.BtnGuardarInico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarInico.Location = new System.Drawing.Point(530, 383);
            this.BtnGuardarInico.Name = "BtnGuardarInico";
            this.BtnGuardarInico.Size = new System.Drawing.Size(89, 42);
            this.BtnGuardarInico.TabIndex = 76;
            this.BtnGuardarInico.Text = "Aceptar";
            this.BtnGuardarInico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarInico.UseVisualStyleBackColor = false;
            this.BtnGuardarInico.Click += new System.EventHandler(this.BtnGuardarInico_Click);
            // 
            // FormDatosInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 437);
            this.Controls.Add(this.PanelBotones_Inicio);
            this.Controls.Add(this.BtnCancelarInicio);
            this.Controls.Add(this.BtnSalir_Inico);
            this.Controls.Add(this.BtnGuardarInico);
            this.Controls.Add(this.dtInicioDataGridView);
            this.Controls.Add(this.PanelDatosInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDatosInicio";
            this.Text = "Datos De inicio";
            this.Load += new System.EventHandler(this.FormDatoInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorInico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMulti2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProvinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).EndInit();
            this.PanelDatosInicio.ResumeLayout(false);
            this.PanelDatosInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioDataGridView)).EndInit();
            this.PanelBotones_Inicio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ErrorInico;
        private System.Windows.Forms.BindingSource dtPaisesBindingSource;
        private DsMulti2 dsMulti2;
        private DsCONFIGURACCION dsCONFIGURACCION;
        private DsMultidatos dsMultidatos;
        private System.Windows.Forms.BindingSource dtProvinciasBindingSource;
        private System.Windows.Forms.BindingSource dtInicioMultiBindingSource;
        private System.Windows.Forms.BindingSource dtConfiguracionPrincipalBindingSource;
        private System.Windows.Forms.Panel PanelDatosInicio;
        private System.Windows.Forms.ComboBox EmpresaInicio;
        private System.Windows.Forms.ComboBox ArchivoClienteTxt;
        private System.Windows.Forms.ComboBox SerieInicio;
        private System.Windows.Forms.ComboBox ExtensionTipoInicio;
        private System.Windows.Forms.ComboBox EjercicioInicio;
        private System.Windows.Forms.ComboBox ArchivoArticuloTxt;
        public System.Windows.Forms.ComboBox ProvinciaInicio;
        public System.Windows.Forms.ComboBox PaisInicio;
        private System.Windows.Forms.DataGridView dtInicioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Panel PanelBotones_Inicio;
        private System.Windows.Forms.Button BtnModificarInicio;
        private System.Windows.Forms.Button BtnCancelarInicio;
        private System.Windows.Forms.Button BtnSalir_Inico;
        public System.Windows.Forms.Button BtnGuardarInico;
        private System.Windows.Forms.Label Id_Inicio;
        private System.Windows.Forms.BindingSource dtConfiBindingSource;
        private System.Windows.Forms.ComboBox CodigoBarras;
    }
}