
namespace PELOSCALVO
{
    partial class FormDatoInicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label label10;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatoInicio));
            this.ErrorInico = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtPaisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMulti2 = new PELOSCALVO.DsMulti2();
            this.dsCONFIGURACCION = new PELOSCALVO.DsCONFIGURACCION();
            this.dsMultidatos = new PELOSCALVO.DsMultidatos();
            this.dtProvinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtInicioMultiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtNombresTablasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtConfiguracionPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PanelDatosInicio = new System.Windows.Forms.Panel();
            this.empresaInicio = new System.Windows.Forms.ComboBox();
            this.archivoClientesComboBox = new System.Windows.Forms.ComboBox();
            this.SerieInicio = new System.Windows.Forms.ComboBox();
            this.tipoExtensionArticulosComboBox = new System.Windows.Forms.ComboBox();
            this.EjercicioInicio = new System.Windows.Forms.ComboBox();
            this.archivoArticulosComboBox = new System.Windows.Forms.ComboBox();
            this.provinciaInicio = new System.Windows.Forms.ComboBox();
            this.PaisInicio = new System.Windows.Forms.ComboBox();
            this.dtInicioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCancelarInicio = new System.Windows.Forms.Button();
            this.BtnSalir_Inico = new System.Windows.Forms.Button();
            this.PanelBotones_Inicio = new System.Windows.Forms.Panel();
            this.BtnBuscarInicio = new System.Windows.Forms.Button();
            this.BtnNuevoPais = new System.Windows.Forms.Button();
            this.BtnModificarInicio = new System.Windows.Forms.Button();
            this.BtnGuardarInico = new System.Windows.Forms.Button();
            this.Id_Inicio = new System.Windows.Forms.Label();
            archivoClientesLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            tipoExtensionArticulosLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            archivoArticulosLabel = new System.Windows.Forms.Label();
            pais_FactLabel = new System.Windows.Forms.Label();
            provinciaLabel = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorInico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMulti2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProvinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNombresTablasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).BeginInit();
            this.PanelDatosInicio.SuspendLayout();
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
            tipoExtensionArticulosLabel.Location = new System.Drawing.Point(37, 237);
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
            provinciaLabel.Location = new System.Drawing.Point(39, 103);
            provinciaLabel.Name = "provinciaLabel";
            provinciaLabel.Size = new System.Drawing.Size(54, 13);
            provinciaLabel.TabIndex = 36;
            provinciaLabel.Text = "Provincia:";
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
            this.dtProvinciasBindingSource.DataMember = "DtProvincias";
            this.dtProvinciasBindingSource.DataSource = this.dsMulti2;
            // 
            // dtInicioMultiBindingSource
            // 
            this.dtInicioMultiBindingSource.DataMember = "DtInicioMulti";
            this.dtInicioMultiBindingSource.DataSource = this.dsMultidatos;
            // 
            // dtNombresTablasBindingSource
            // 
            this.dtNombresTablasBindingSource.DataMember = "DtNombresTablas";
            this.dtNombresTablasBindingSource.DataSource = this.dsMultidatos;
            // 
            // dtConfiguracionPrincipalBindingSource
            // 
            this.dtConfiguracionPrincipalBindingSource.DataMember = "DtConfiguracionPrincipal";
            this.dtConfiguracionPrincipalBindingSource.DataSource = this.dsCONFIGURACCION;
            // 
            // PanelDatosInicio
            // 
            this.PanelDatosInicio.Controls.Add(this.Id_Inicio);
            this.PanelDatosInicio.Controls.Add(this.empresaInicio);
            this.PanelDatosInicio.Controls.Add(label10);
            this.PanelDatosInicio.Controls.Add(archivoClientesLabel);
            this.PanelDatosInicio.Controls.Add(label2);
            this.PanelDatosInicio.Controls.Add(this.archivoClientesComboBox);
            this.PanelDatosInicio.Controls.Add(label4);
            this.PanelDatosInicio.Controls.Add(tipoExtensionArticulosLabel);
            this.PanelDatosInicio.Controls.Add(this.SerieInicio);
            this.PanelDatosInicio.Controls.Add(this.tipoExtensionArticulosComboBox);
            this.PanelDatosInicio.Controls.Add(label3);
            this.PanelDatosInicio.Controls.Add(archivoArticulosLabel);
            this.PanelDatosInicio.Controls.Add(this.EjercicioInicio);
            this.PanelDatosInicio.Controls.Add(this.archivoArticulosComboBox);
            this.PanelDatosInicio.Controls.Add(this.provinciaInicio);
            this.PanelDatosInicio.Controls.Add(pais_FactLabel);
            this.PanelDatosInicio.Controls.Add(provinciaLabel);
            this.PanelDatosInicio.Controls.Add(this.PaisInicio);
            this.PanelDatosInicio.Location = new System.Drawing.Point(23, 70);
            this.PanelDatosInicio.Name = "PanelDatosInicio";
            this.PanelDatosInicio.Size = new System.Drawing.Size(565, 273);
            this.PanelDatosInicio.TabIndex = 45;
            // 
            // empresaInicio
            // 
            this.empresaInicio.DataSource = this.dtConfiguracionPrincipalBindingSource;
            this.empresaInicio.DisplayMember = "EmpresaConfi";
            this.empresaInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empresaInicio.FormattingEnabled = true;
            this.empresaInicio.Location = new System.Drawing.Point(103, 13);
            this.empresaInicio.Name = "empresaInicio";
            this.empresaInicio.Size = new System.Drawing.Size(312, 21);
            this.empresaInicio.TabIndex = 7;
            // 
            // archivoClientesComboBox
            // 
            this.archivoClientesComboBox.DataSource = this.dtNombresTablasBindingSource;
            this.archivoClientesComboBox.DisplayMember = "NombreTabla";
            this.archivoClientesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.archivoClientesComboBox.FormattingEnabled = true;
            this.archivoClientesComboBox.Location = new System.Drawing.Point(103, 195);
            this.archivoClientesComboBox.Name = "archivoClientesComboBox";
            this.archivoClientesComboBox.Size = new System.Drawing.Size(299, 21);
            this.archivoClientesComboBox.TabIndex = 43;
            // 
            // SerieInicio
            // 
            this.SerieInicio.Cursor = System.Windows.Forms.Cursors.Default;
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
            this.SerieInicio.Size = new System.Drawing.Size(200, 21);
            this.SerieInicio.TabIndex = 26;
            // 
            // tipoExtensionArticulosComboBox
            // 
            this.tipoExtensionArticulosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoExtensionArticulosComboBox.FormattingEnabled = true;
            this.tipoExtensionArticulosComboBox.Items.AddRange(new object[] {
            "mdb",
            "accdb"});
            this.tipoExtensionArticulosComboBox.Location = new System.Drawing.Point(103, 234);
            this.tipoExtensionArticulosComboBox.Name = "tipoExtensionArticulosComboBox";
            this.tipoExtensionArticulosComboBox.Size = new System.Drawing.Size(121, 21);
            this.tipoExtensionArticulosComboBox.TabIndex = 42;
            // 
            // EjercicioInicio
            // 
            this.EjercicioInicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.EjercicioInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EjercicioInicio.FormattingEnabled = true;
            this.EjercicioInicio.Location = new System.Drawing.Point(103, 46);
            this.EjercicioInicio.Name = "EjercicioInicio";
            this.EjercicioInicio.Size = new System.Drawing.Size(268, 21);
            this.EjercicioInicio.TabIndex = 33;
            // 
            // archivoArticulosComboBox
            // 
            this.archivoArticulosComboBox.DataSource = this.dtNombresTablasBindingSource;
            this.archivoArticulosComboBox.DisplayMember = "NombreTabla";
            this.archivoArticulosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.archivoArticulosComboBox.FormattingEnabled = true;
            this.archivoArticulosComboBox.Location = new System.Drawing.Point(103, 164);
            this.archivoArticulosComboBox.Name = "archivoArticulosComboBox";
            this.archivoArticulosComboBox.Size = new System.Drawing.Size(299, 21);
            this.archivoArticulosComboBox.TabIndex = 40;
            // 
            // provinciaInicio
            // 
            this.provinciaInicio.DataSource = this.dtProvinciasBindingSource;
            this.provinciaInicio.DisplayMember = "ProvinciasProvincias";
            this.provinciaInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provinciaInicio.FormattingEnabled = true;
            this.provinciaInicio.Location = new System.Drawing.Point(103, 100);
            this.provinciaInicio.Name = "provinciaInicio";
            this.provinciaInicio.Size = new System.Drawing.Size(268, 21);
            this.provinciaInicio.TabIndex = 37;
            // 
            // PaisInicio
            // 
            this.PaisInicio.DataSource = this.dtPaisesBindingSource;
            this.PaisInicio.DisplayMember = "PaisesPaises";
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
            this.dtInicioDataGridView.Location = new System.Drawing.Point(0, 0);
            this.dtInicioDataGridView.Name = "dtInicioDataGridView";
            this.dtInicioDataGridView.ReadOnly = true;
            this.dtInicioDataGridView.RowHeadersVisible = false;
            this.dtInicioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtInicioDataGridView.Size = new System.Drawing.Size(914, 51);
            this.dtInicioDataGridView.TabIndex = 46;
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
            this.BtnCancelarInicio.Location = new System.Drawing.Point(685, 387);
            this.BtnCancelarInicio.Name = "BtnCancelarInicio";
            this.BtnCancelarInicio.Size = new System.Drawing.Size(89, 42);
            this.BtnCancelarInicio.TabIndex = 77;
            this.BtnCancelarInicio.Text = "Cancelar";
            this.BtnCancelarInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelarInicio.UseVisualStyleBackColor = false;
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
            this.BtnSalir_Inico.Location = new System.Drawing.Point(824, 366);
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
            this.PanelBotones_Inicio.Controls.Add(this.BtnBuscarInicio);
            this.PanelBotones_Inicio.Controls.Add(this.BtnNuevoPais);
            this.PanelBotones_Inicio.Controls.Add(this.BtnModificarInicio);
            this.PanelBotones_Inicio.Location = new System.Drawing.Point(23, 366);
            this.PanelBotones_Inicio.Name = "PanelBotones_Inicio";
            this.PanelBotones_Inicio.Size = new System.Drawing.Size(396, 63);
            this.PanelBotones_Inicio.TabIndex = 54;
            this.PanelBotones_Inicio.Tag = "NO";
            // 
            // BtnBuscarInicio
            // 
            this.BtnBuscarInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarInicio.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscarInicio.FlatAppearance.BorderSize = 0;
            this.BtnBuscarInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnBuscarInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnBuscarInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarInicio.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarInicio.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_magnifier_4_32;
            this.BtnBuscarInicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscarInicio.Location = new System.Drawing.Point(161, 3);
            this.BtnBuscarInicio.Name = "BtnBuscarInicio";
            this.BtnBuscarInicio.Size = new System.Drawing.Size(77, 63);
            this.BtnBuscarInicio.TabIndex = 8;
            this.BtnBuscarInicio.Text = "Buscar";
            this.BtnBuscarInicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscarInicio.UseVisualStyleBackColor = false;
            // 
            // BtnNuevoPais
            // 
            this.BtnNuevoPais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNuevoPais.BackColor = System.Drawing.Color.Transparent;
            this.BtnNuevoPais.FlatAppearance.BorderSize = 0;
            this.BtnNuevoPais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnNuevoPais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnNuevoPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoPais.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoPais.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_file_14_32;
            this.BtnNuevoPais.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevoPais.Location = new System.Drawing.Point(7, 3);
            this.BtnNuevoPais.Name = "BtnNuevoPais";
            this.BtnNuevoPais.Size = new System.Drawing.Size(77, 63);
            this.BtnNuevoPais.TabIndex = 6;
            this.BtnNuevoPais.Tag = "stop";
            this.BtnNuevoPais.Text = "Nuevo";
            this.BtnNuevoPais.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNuevoPais.UseVisualStyleBackColor = false;
            this.BtnNuevoPais.Click += new System.EventHandler(this.BtnNuevoPais_Click);
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
            this.BtnModificarInicio.Location = new System.Drawing.Point(78, 3);
            this.BtnModificarInicio.Name = "BtnModificarInicio";
            this.BtnModificarInicio.Size = new System.Drawing.Size(77, 63);
            this.BtnModificarInicio.TabIndex = 7;
            this.BtnModificarInicio.Text = "Modificar";
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
            this.BtnGuardarInico.Location = new System.Drawing.Point(530, 387);
            this.BtnGuardarInico.Name = "BtnGuardarInico";
            this.BtnGuardarInico.Size = new System.Drawing.Size(89, 42);
            this.BtnGuardarInico.TabIndex = 76;
            this.BtnGuardarInico.Text = "Aceptar";
            this.BtnGuardarInico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarInico.UseVisualStyleBackColor = false;
            this.BtnGuardarInico.Click += new System.EventHandler(this.BtnGuardarInico_Click);
            // 
            // Id_Inicio
            // 
            this.Id_Inicio.AutoSize = true;
            this.Id_Inicio.Location = new System.Drawing.Point(358, 242);
            this.Id_Inicio.Name = "Id_Inicio";
            this.Id_Inicio.Size = new System.Drawing.Size(13, 13);
            this.Id_Inicio.TabIndex = 79;
            this.Id_Inicio.Text = "1";
            this.Id_Inicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // FormDatoInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 441);
            this.Controls.Add(this.PanelBotones_Inicio);
            this.Controls.Add(this.BtnCancelarInicio);
            this.Controls.Add(this.BtnSalir_Inico);
            this.Controls.Add(this.BtnGuardarInico);
            this.Controls.Add(this.dtInicioDataGridView);
            this.Controls.Add(this.PanelDatosInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDatoInicio";
            this.Text = "Datos De inicio";
            this.Load += new System.EventHandler(this.FormDatoInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorInico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMulti2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProvinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNombresTablasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).EndInit();
            this.PanelDatosInicio.ResumeLayout(false);
            this.PanelDatosInicio.PerformLayout();
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
        private System.Windows.Forms.BindingSource dtNombresTablasBindingSource;
        private System.Windows.Forms.BindingSource dtConfiguracionPrincipalBindingSource;
        private System.Windows.Forms.Panel PanelDatosInicio;
        private System.Windows.Forms.ComboBox empresaInicio;
        private System.Windows.Forms.ComboBox archivoClientesComboBox;
        private System.Windows.Forms.ComboBox SerieInicio;
        private System.Windows.Forms.ComboBox tipoExtensionArticulosComboBox;
        private System.Windows.Forms.ComboBox EjercicioInicio;
        private System.Windows.Forms.ComboBox archivoArticulosComboBox;
        public System.Windows.Forms.ComboBox provinciaInicio;
        public System.Windows.Forms.ComboBox PaisInicio;
        private System.Windows.Forms.DataGridView dtInicioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Panel PanelBotones_Inicio;
        private System.Windows.Forms.Button BtnBuscarInicio;
        private System.Windows.Forms.Button BtnNuevoPais;
        private System.Windows.Forms.Button BtnModificarInicio;
        private System.Windows.Forms.Button BtnCancelarInicio;
        private System.Windows.Forms.Button BtnSalir_Inico;
        public System.Windows.Forms.Button BtnGuardarInico;
        private System.Windows.Forms.Label Id_Inicio;
    }
}