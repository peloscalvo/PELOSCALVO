
namespace PELOSCALVO
{
    partial class FormArticulos
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
            System.Windows.Forms.Label Pvp2Label;
            System.Windows.Forms.Label PlusLabel;
            System.Windows.Forms.Label familiaLabel;
            System.Windows.Forms.Label StockLabel;
            System.Windows.Forms.Label MinimosStockLabel;
            System.Windows.Forms.Label UnidadPaletLabel;
            System.Windows.Forms.Label IdLabel;
            System.Windows.Forms.Label ReferenciaLabel;
            System.Windows.Forms.Label DescripccionLabel;
            System.Windows.Forms.Label CosteLabel;
            System.Windows.Forms.Label GananciaLabel;
            System.Windows.Forms.Label Pvp1Label;
            System.Windows.Forms.Label FechaRgLabel;
            System.Windows.Forms.Label EmpresaENLACELabel;
            System.Windows.Forms.Label DescueLabel1;
            System.Windows.Forms.Label Buscarlabel;
            System.Windows.Forms.Label pvp1Label1;
            System.Windows.Forms.Label pvpIvaLabel1;
            System.Windows.Forms.Label TipoInpuestoIVALabel1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label oemLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArticulos));
            this.dtPreciosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Familia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFILA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtArticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articulos = new PELOSCALVO.DsArticulos();
            this.tabControl1Articulo = new System.Windows.Forms.TabControl();
            this.tabPage1Articulo = new System.Windows.Forms.TabPage();
            this.OemText = new System.Windows.Forms.TextBox();
            this.idArticulo = new System.Windows.Forms.Label();
            this.BajaCheckBox = new System.Windows.Forms.CheckBox();
            this.FechaAlta = new System.Windows.Forms.DateTimePicker();
            this.Pvp1Text = new System.Windows.Forms.Label();
            this.PvpIvaLabel2 = new System.Windows.Forms.Label();
            this.ReferenciaBuscarArt = new System.Windows.Forms.ComboBox();
            this.DescripcionBuscarArt = new System.Windows.Forms.ComboBox();
            this.ReferenciaTextBox = new System.Windows.Forms.TextBox();
            this.DescripccionTextBox = new System.Windows.Forms.TextBox();
            this.CosteTextBox = new System.Windows.Forms.TextBox();
            this.GananciaTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2Articulo = new System.Windows.Forms.TabPage();
            this.panelDesc1 = new System.Windows.Forms.Panel();
            this.PlusDescTxt = new System.Windows.Forms.TextBox();
            this.Desc2Text = new System.Windows.Forms.TextBox();
            this.PlusLabel2 = new System.Windows.Forms.Label();
            this.Desc3Txt = new System.Windows.Forms.TextBox();
            this.Desc6Txt = new System.Windows.Forms.TextBox();
            this.Pvp2Text = new System.Windows.Forms.Label();
            this.Desc5Text = new System.Windows.Forms.TextBox();
            this.Desc4Txt = new System.Windows.Forms.TextBox();
            this.Pvp3Txt = new System.Windows.Forms.Label();
            this.Pvp4Txt = new System.Windows.Forms.Label();
            this.Pvp6Txt = new System.Windows.Forms.Label();
            this.Pvp5Txt = new System.Windows.Forms.Label();
            this.LabDes6 = new System.Windows.Forms.Label();
            this.LabDes5 = new System.Windows.Forms.Label();
            this.LabDesc4 = new System.Windows.Forms.Label();
            this.LabDes3 = new System.Windows.Forms.Label();
            this.UnidadPaletTextBox = new System.Windows.Forms.TextBox();
            this.MinimosStockTextBox = new System.Windows.Forms.TextBox();
            this.StockTextBox = new System.Windows.Forms.TextBox();
            this.familiaComboBox = new System.Windows.Forms.ComboBox();
            this.dtFamiliaProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMulti2 = new PELOSCALVO.DsMulti2();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TipoIVA_Up_Articulos = new System.Windows.Forms.NumericUpDown();
            this.TipoTarifa = new System.Windows.Forms.ComboBox();
            this.dtConfiDtTarifaTipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtConfiguracionPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCONFIGURACCION = new PELOSCALVO.DsCONFIGURACCION();
            this.EmpresaArticulos = new System.Windows.Forms.ComboBox();
            this.dtInicioMultiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMultidatos = new PELOSCALVO.DsMultidatos();
            this.panelBotonesArticulo = new System.Windows.Forms.Panel();
            this.BtnImprimirArticulo = new System.Windows.Forms.Button();
            this.BtnEnviarMailArticulo = new System.Windows.Forms.Button();
            this.BtnEliminarArticulo = new System.Windows.Forms.Button();
            this.BtnBuscarArticulo = new System.Windows.Forms.Button();
            this.BtnNuevoArticulo = new System.Windows.Forms.Button();
            this.BtnModificarArticulo = new System.Windows.Forms.Button();
            this.BtnSalirArticulo = new System.Windows.Forms.Button();
            this.BtnCancelarArticulo = new System.Windows.Forms.Button();
            this.BtnGuardarArticulo = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.RegistLbel = new System.Windows.Forms.Label();
            this.ContadorDatos3 = new System.Windows.Forms.Label();
            this.FiltrarBajas = new System.Windows.Forms.ComboBox();
            this.FiltrarFamiliaArt = new System.Windows.Forms.ComboBox();
            this.CheckFamiliaArt = new System.Windows.Forms.RadioButton();
            Pvp2Label = new System.Windows.Forms.Label();
            PlusLabel = new System.Windows.Forms.Label();
            familiaLabel = new System.Windows.Forms.Label();
            StockLabel = new System.Windows.Forms.Label();
            MinimosStockLabel = new System.Windows.Forms.Label();
            UnidadPaletLabel = new System.Windows.Forms.Label();
            IdLabel = new System.Windows.Forms.Label();
            ReferenciaLabel = new System.Windows.Forms.Label();
            DescripccionLabel = new System.Windows.Forms.Label();
            CosteLabel = new System.Windows.Forms.Label();
            GananciaLabel = new System.Windows.Forms.Label();
            Pvp1Label = new System.Windows.Forms.Label();
            FechaRgLabel = new System.Windows.Forms.Label();
            EmpresaENLACELabel = new System.Windows.Forms.Label();
            DescueLabel1 = new System.Windows.Forms.Label();
            Buscarlabel = new System.Windows.Forms.Label();
            pvp1Label1 = new System.Windows.Forms.Label();
            pvpIvaLabel1 = new System.Windows.Forms.Label();
            TipoInpuestoIVALabel1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            oemLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtPreciosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtArticulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulos)).BeginInit();
            this.tabControl1Articulo.SuspendLayout();
            this.tabPage1Articulo.SuspendLayout();
            this.tabPage2Articulo.SuspendLayout();
            this.panelDesc1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFamiliaProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMulti2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TipoIVA_Up_Articulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiDtTarifaTipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).BeginInit();
            this.panelBotonesArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pvp2Label
            // 
            Pvp2Label.AutoSize = true;
            Pvp2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Pvp2Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            Pvp2Label.Location = new System.Drawing.Point(26, 160);
            Pvp2Label.Name = "Pvp2Label";
            Pvp2Label.Size = new System.Drawing.Size(42, 15);
            Pvp2Label.TabIndex = 16;
            Pvp2Label.Text = "Pvp2:";
            Pvp2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlusLabel
            // 
            PlusLabel.AutoSize = true;
            PlusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            PlusLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            PlusLabel.Location = new System.Drawing.Point(26, 186);
            PlusLabel.Name = "PlusLabel";
            PlusLabel.Size = new System.Drawing.Size(39, 15);
            PlusLabel.TabIndex = 36;
            PlusLabel.Text = "Plus:";
            PlusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // familiaLabel
            // 
            familiaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            familiaLabel.AutoSize = true;
            familiaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            familiaLabel.Location = new System.Drawing.Point(612, 117);
            familiaLabel.Name = "familiaLabel";
            familiaLabel.Size = new System.Drawing.Size(42, 13);
            familiaLabel.TabIndex = 44;
            familiaLabel.Text = "Familia:";
            // 
            // StockLabel
            // 
            StockLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            StockLabel.AutoSize = true;
            StockLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            StockLabel.Location = new System.Drawing.Point(831, 76);
            StockLabel.Name = "StockLabel";
            StockLabel.Size = new System.Drawing.Size(38, 13);
            StockLabel.TabIndex = 42;
            StockLabel.Text = "Stock:";
            // 
            // MinimosStockLabel
            // 
            MinimosStockLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            MinimosStockLabel.AutoSize = true;
            MinimosStockLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            MinimosStockLabel.Location = new System.Drawing.Point(790, 50);
            MinimosStockLabel.Name = "MinimosStockLabel";
            MinimosStockLabel.Size = new System.Drawing.Size(79, 13);
            MinimosStockLabel.TabIndex = 40;
            MinimosStockLabel.Text = "Minimos Stock:";
            // 
            // UnidadPaletLabel
            // 
            UnidadPaletLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            UnidadPaletLabel.AutoSize = true;
            UnidadPaletLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            UnidadPaletLabel.Location = new System.Drawing.Point(798, 24);
            UnidadPaletLabel.Name = "UnidadPaletLabel";
            UnidadPaletLabel.Size = new System.Drawing.Size(71, 13);
            UnidadPaletLabel.TabIndex = 38;
            UnidadPaletLabel.Text = "Unidad Palet:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            IdLabel.Location = new System.Drawing.Point(19, 17);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new System.Drawing.Size(19, 13);
            IdLabel.TabIndex = 16;
            IdLabel.Text = "Id:";
            // 
            // ReferenciaLabel
            // 
            ReferenciaLabel.AutoSize = true;
            ReferenciaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            ReferenciaLabel.Location = new System.Drawing.Point(19, 51);
            ReferenciaLabel.Name = "ReferenciaLabel";
            ReferenciaLabel.Size = new System.Drawing.Size(62, 13);
            ReferenciaLabel.TabIndex = 18;
            ReferenciaLabel.Text = "Referencia:";
            // 
            // DescripccionLabel
            // 
            DescripccionLabel.AutoSize = true;
            DescripccionLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            DescripccionLabel.Location = new System.Drawing.Point(19, 103);
            DescripccionLabel.Name = "DescripccionLabel";
            DescripccionLabel.Size = new System.Drawing.Size(72, 13);
            DescripccionLabel.TabIndex = 20;
            DescripccionLabel.Text = "Descripccion:";
            // 
            // CosteLabel
            // 
            CosteLabel.AutoSize = true;
            CosteLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            CosteLabel.Location = new System.Drawing.Point(19, 129);
            CosteLabel.Name = "CosteLabel";
            CosteLabel.Size = new System.Drawing.Size(37, 13);
            CosteLabel.TabIndex = 22;
            CosteLabel.Text = "Coste:";
            // 
            // GananciaLabel
            // 
            GananciaLabel.AutoSize = true;
            GananciaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            GananciaLabel.Location = new System.Drawing.Point(19, 155);
            GananciaLabel.Name = "GananciaLabel";
            GananciaLabel.Size = new System.Drawing.Size(56, 13);
            GananciaLabel.TabIndex = 24;
            GananciaLabel.Text = "Ganancia:";
            // 
            // Pvp1Label
            // 
            Pvp1Label.AutoSize = true;
            Pvp1Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            Pvp1Label.Location = new System.Drawing.Point(19, 181);
            Pvp1Label.Name = "Pvp1Label";
            Pvp1Label.Size = new System.Drawing.Size(35, 13);
            Pvp1Label.TabIndex = 26;
            Pvp1Label.Text = "Pvp1:";
            // 
            // FechaRgLabel
            // 
            FechaRgLabel.AutoSize = true;
            FechaRgLabel.Location = new System.Drawing.Point(749, 127);
            FechaRgLabel.Name = "FechaRgLabel";
            FechaRgLabel.Size = new System.Drawing.Size(40, 13);
            FechaRgLabel.TabIndex = 50;
            FechaRgLabel.Text = "Fecha:";
            // 
            // EmpresaENLACELabel
            // 
            EmpresaENLACELabel.AutoSize = true;
            EmpresaENLACELabel.Location = new System.Drawing.Point(55, 31);
            EmpresaENLACELabel.Name = "EmpresaENLACELabel";
            EmpresaENLACELabel.Size = new System.Drawing.Size(51, 13);
            EmpresaENLACELabel.TabIndex = 28;
            EmpresaENLACELabel.Text = "Empresa:";
            // 
            // DescueLabel1
            // 
            DescueLabel1.AutoSize = true;
            DescueLabel1.Location = new System.Drawing.Point(10, 71);
            DescueLabel1.Name = "DescueLabel1";
            DescueLabel1.Size = new System.Drawing.Size(96, 13);
            DescueLabel1.TabIndex = 31;
            DescueLabel1.Text = "Descuento cliente:";
            // 
            // Buscarlabel
            // 
            Buscarlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            Buscarlabel.AutoSize = true;
            Buscarlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Buscarlabel.Location = new System.Drawing.Point(481, 14);
            Buscarlabel.Name = "Buscarlabel";
            Buscarlabel.Size = new System.Drawing.Size(74, 16);
            Buscarlabel.TabIndex = 61;
            Buscarlabel.Text = "BUSCAR:";
            // 
            // pvp1Label1
            // 
            pvp1Label1.AutoSize = true;
            pvp1Label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pvp1Label1.Location = new System.Drawing.Point(335, 3);
            pvp1Label1.Name = "pvp1Label1";
            pvp1Label1.Size = new System.Drawing.Size(68, 19);
            pvp1Label1.TabIndex = 60;
            pvp1Label1.Text = "Precios";
            pvp1Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pvpIvaLabel1
            // 
            pvpIvaLabel1.AutoSize = true;
            pvpIvaLabel1.Location = new System.Drawing.Point(262, 186);
            pvpIvaLabel1.Name = "pvpIvaLabel1";
            pvpIvaLabel1.Size = new System.Drawing.Size(47, 13);
            pvpIvaLabel1.TabIndex = 62;
            pvpIvaLabel1.Text = "Pvp Iva:";
            // 
            // TipoInpuestoIVALabel1
            // 
            TipoInpuestoIVALabel1.AutoSize = true;
            TipoInpuestoIVALabel1.Location = new System.Drawing.Point(55, 112);
            TipoInpuestoIVALabel1.Name = "TipoInpuestoIVALabel1";
            TipoInpuestoIVALabel1.Size = new System.Drawing.Size(49, 13);
            TipoInpuestoIVALabel1.TabIndex = 46;
            TipoInpuestoIVALabel1.Text = "Tipo Iva:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label2.Location = new System.Drawing.Point(782, 8);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(35, 13);
            label2.TabIndex = 38;
            label2.Text = "Filtrar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(197, 1);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(100, 19);
            label1.TabIndex = 61;
            label1.Text = "Descuentos";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oemLabel
            // 
            oemLabel.AutoSize = true;
            oemLabel.Location = new System.Drawing.Point(19, 77);
            oemLabel.Name = "oemLabel";
            oemLabel.Size = new System.Drawing.Size(32, 13);
            oemLabel.TabIndex = 67;
            oemLabel.Text = "Oem:";
            // 
            // dtPreciosDataGridView
            // 
            this.dtPreciosDataGridView.AllowUserToAddRows = false;
            this.dtPreciosDataGridView.AllowUserToDeleteRows = false;
            this.dtPreciosDataGridView.AllowUserToOrderColumns = true;
            this.dtPreciosDataGridView.AllowUserToResizeColumns = false;
            this.dtPreciosDataGridView.AllowUserToResizeRows = false;
            this.dtPreciosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPreciosDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtPreciosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtPreciosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPreciosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Descripcci,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn19,
            this.Familia,
            this.IdFILA});
            this.dtPreciosDataGridView.DataSource = this.dtArticulosBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtPreciosDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtPreciosDataGridView.Location = new System.Drawing.Point(9, 32);
            this.dtPreciosDataGridView.MultiSelect = false;
            this.dtPreciosDataGridView.Name = "dtPreciosDataGridView";
            this.dtPreciosDataGridView.ReadOnly = true;
            this.dtPreciosDataGridView.RowHeadersVisible = false;
            this.dtPreciosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtPreciosDataGridView.Size = new System.Drawing.Size(1014, 220);
            this.dtPreciosDataGridView.TabIndex = 1;
            this.dtPreciosDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtPreciosDataGridView_CellClick);
            this.dtPreciosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPreciosDataGridView_CellContentClick);
            this.dtPreciosDataGridView.SelectionChanged += new System.EventHandler(this.dtPreciosDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.FillWeight = 174.3626F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Referencia";
            this.dataGridViewTextBoxColumn2.FillWeight = 379.3742F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Referencia";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 218;
            // 
            // Descripcci
            // 
            this.Descripcci.DataPropertyName = "Descripcci";
            this.Descripcci.FillWeight = 428.141F;
            this.Descripcci.HeaderText = "Descripccion";
            this.Descripcci.Name = "Descripcci";
            this.Descripcci.ReadOnly = true;
            this.Descripcci.Width = 245;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Coste";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.Format = "C3";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.FillWeight = 90F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Coste";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Pvp1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.Format = "C3";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn6.FillWeight = 90F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Pvp1";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 90;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Pvp2";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle5.Format = "C3";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn9.FillWeight = 90F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Pvp2";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 90;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Plus";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.Format = "C3";
            dataGridViewCellStyle6.NullValue = null;
            this.dataGridViewTextBoxColumn19.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn19.FillWeight = 90F;
            this.dataGridViewTextBoxColumn19.HeaderText = "Plus";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 90;
            // 
            // Familia
            // 
            this.Familia.DataPropertyName = "Familia";
            this.Familia.FillWeight = 140F;
            this.Familia.HeaderText = "Familia";
            this.Familia.Name = "Familia";
            this.Familia.ReadOnly = true;
            this.Familia.Width = 140;
            // 
            // IdFILA
            // 
            this.IdFILA.DataPropertyName = "IdFILA";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.IdFILA.DefaultCellStyle = dataGridViewCellStyle7;
            this.IdFILA.FillWeight = 52.97979F;
            this.IdFILA.HeaderText = "Id";
            this.IdFILA.Name = "IdFILA";
            this.IdFILA.ReadOnly = true;
            this.IdFILA.Visible = false;
            this.IdFILA.Width = 30;
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
            // tabControl1Articulo
            // 
            this.tabControl1Articulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1Articulo.Controls.Add(this.tabPage1Articulo);
            this.tabControl1Articulo.Controls.Add(this.tabPage2Articulo);
            this.tabControl1Articulo.Controls.Add(this.tabPage1);
            this.tabControl1Articulo.Location = new System.Drawing.Point(9, 258);
            this.tabControl1Articulo.Name = "tabControl1Articulo";
            this.tabControl1Articulo.SelectedIndex = 0;
            this.tabControl1Articulo.Size = new System.Drawing.Size(1023, 255);
            this.tabControl1Articulo.TabIndex = 2;
            // 
            // tabPage1Articulo
            // 
            this.tabPage1Articulo.AutoScroll = true;
            this.tabPage1Articulo.Controls.Add(oemLabel);
            this.tabPage1Articulo.Controls.Add(this.OemText);
            this.tabPage1Articulo.Controls.Add(this.idArticulo);
            this.tabPage1Articulo.Controls.Add(this.BajaCheckBox);
            this.tabPage1Articulo.Controls.Add(this.FechaAlta);
            this.tabPage1Articulo.Controls.Add(this.Pvp1Text);
            this.tabPage1Articulo.Controls.Add(pvpIvaLabel1);
            this.tabPage1Articulo.Controls.Add(this.PvpIvaLabel2);
            this.tabPage1Articulo.Controls.Add(Buscarlabel);
            this.tabPage1Articulo.Controls.Add(this.ReferenciaBuscarArt);
            this.tabPage1Articulo.Controls.Add(this.DescripcionBuscarArt);
            this.tabPage1Articulo.Controls.Add(FechaRgLabel);
            this.tabPage1Articulo.Controls.Add(IdLabel);
            this.tabPage1Articulo.Controls.Add(ReferenciaLabel);
            this.tabPage1Articulo.Controls.Add(this.ReferenciaTextBox);
            this.tabPage1Articulo.Controls.Add(DescripccionLabel);
            this.tabPage1Articulo.Controls.Add(this.DescripccionTextBox);
            this.tabPage1Articulo.Controls.Add(CosteLabel);
            this.tabPage1Articulo.Controls.Add(this.CosteTextBox);
            this.tabPage1Articulo.Controls.Add(GananciaLabel);
            this.tabPage1Articulo.Controls.Add(this.GananciaTextBox);
            this.tabPage1Articulo.Controls.Add(Pvp1Label);
            this.tabPage1Articulo.Location = new System.Drawing.Point(4, 22);
            this.tabPage1Articulo.Name = "tabPage1Articulo";
            this.tabPage1Articulo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1Articulo.Size = new System.Drawing.Size(1015, 229);
            this.tabPage1Articulo.TabIndex = 0;
            this.tabPage1Articulo.Text = "General";
            this.tabPage1Articulo.UseVisualStyleBackColor = true;
            // 
            // OemText
            // 
            this.OemText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtArticulosBindingSource, "Oem", true));
            this.OemText.Location = new System.Drawing.Point(101, 74);
            this.OemText.Name = "OemText";
            this.OemText.Size = new System.Drawing.Size(333, 20);
            this.OemText.TabIndex = 68;
            // 
            // idArticulo
            // 
            this.idArticulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.idArticulo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtArticulosBindingSource, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.idArticulo.Location = new System.Drawing.Point(101, 11);
            this.idArticulo.Name = "idArticulo";
            this.idArticulo.Size = new System.Drawing.Size(100, 23);
            this.idArticulo.TabIndex = 67;
            this.idArticulo.Tag = "";
            this.idArticulo.Text = "1";
            this.idArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BajaCheckBox
            // 
            this.BajaCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BajaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.dtArticulosBindingSource, "Baja", true));
            this.BajaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dtArticulosBindingSource, "Baja", true));
            this.BajaCheckBox.Enabled = false;
            this.BajaCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BajaCheckBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BajaCheckBox.Location = new System.Drawing.Point(784, 147);
            this.BajaCheckBox.Name = "BajaCheckBox";
            this.BajaCheckBox.Size = new System.Drawing.Size(211, 50);
            this.BajaCheckBox.TabIndex = 66;
            this.BajaCheckBox.Text = "Articulo De Baja";
            this.BajaCheckBox.UseVisualStyleBackColor = true;
            // 
            // FechaAlta
            // 
            this.FechaAlta.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dtArticulosBindingSource, "Fecha", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.FechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaAlta.Location = new System.Drawing.Point(795, 121);
            this.FechaAlta.Name = "FechaAlta";
            this.FechaAlta.Size = new System.Drawing.Size(200, 20);
            this.FechaAlta.TabIndex = 65;
            this.FechaAlta.Value = new System.DateTime(2022, 8, 4, 16, 12, 35, 0);
            // 
            // Pvp1Text
            // 
            this.Pvp1Text.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pvp1Text.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtArticulosBindingSource, "Pvp1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "00,0 €", "C3"));
            this.Pvp1Text.Location = new System.Drawing.Point(101, 180);
            this.Pvp1Text.Name = "Pvp1Text";
            this.Pvp1Text.Size = new System.Drawing.Size(152, 23);
            this.Pvp1Text.TabIndex = 64;
            this.Pvp1Text.Text = "00,0 €";
            this.Pvp1Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PvpIvaLabel2
            // 
            this.PvpIvaLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PvpIvaLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PvpIvaLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtArticulosBindingSource, "PvpIva", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0,00 €", "C3"));
            this.PvpIvaLabel2.Location = new System.Drawing.Point(327, 181);
            this.PvpIvaLabel2.Name = "PvpIvaLabel2";
            this.PvpIvaLabel2.Size = new System.Drawing.Size(135, 23);
            this.PvpIvaLabel2.TabIndex = 63;
            this.PvpIvaLabel2.Text = "00,0 €";
            this.PvpIvaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ReferenciaBuscarArt
            // 
            this.ReferenciaBuscarArt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReferenciaBuscarArt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ReferenciaBuscarArt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ReferenciaBuscarArt.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ReferenciaBuscarArt.DataSource = this.dtArticulosBindingSource;
            this.ReferenciaBuscarArt.DisplayMember = "Referencia";
            this.ReferenciaBuscarArt.FormattingEnabled = true;
            this.ReferenciaBuscarArt.Location = new System.Drawing.Point(569, 13);
            this.ReferenciaBuscarArt.Name = "ReferenciaBuscarArt";
            this.ReferenciaBuscarArt.Size = new System.Drawing.Size(332, 21);
            this.ReferenciaBuscarArt.TabIndex = 60;
            // 
            // DescripcionBuscarArt
            // 
            this.DescripcionBuscarArt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DescripcionBuscarArt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DescripcionBuscarArt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DescripcionBuscarArt.BackColor = System.Drawing.Color.AntiqueWhite;
            this.DescripcionBuscarArt.DataSource = this.dtArticulosBindingSource;
            this.DescripcionBuscarArt.DisplayMember = "Descripcci";
            this.DescripcionBuscarArt.FormattingEnabled = true;
            this.DescripcionBuscarArt.Location = new System.Drawing.Point(569, 38);
            this.DescripcionBuscarArt.Name = "DescripcionBuscarArt";
            this.DescripcionBuscarArt.Size = new System.Drawing.Size(427, 21);
            this.DescripcionBuscarArt.TabIndex = 58;
            this.DescripcionBuscarArt.Click += new System.EventHandler(this.DescripcionBuscarArt_Click);
            // 
            // ReferenciaTextBox
            // 
            this.ReferenciaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ReferenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtArticulosBindingSource, "Referencia", true));
            this.ReferenciaTextBox.Enabled = false;
            this.ReferenciaTextBox.Location = new System.Drawing.Point(101, 48);
            this.ReferenciaTextBox.MaxLength = 40;
            this.ReferenciaTextBox.Name = "ReferenciaTextBox";
            this.ReferenciaTextBox.Size = new System.Drawing.Size(333, 20);
            this.ReferenciaTextBox.TabIndex = 19;
            // 
            // DescripccionTextBox
            // 
            this.DescripccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtArticulosBindingSource, "Descripcci", true));
            this.DescripccionTextBox.Enabled = false;
            this.DescripccionTextBox.Location = new System.Drawing.Point(101, 100);
            this.DescripccionTextBox.Name = "DescripccionTextBox";
            this.DescripccionTextBox.Size = new System.Drawing.Size(411, 20);
            this.DescripccionTextBox.TabIndex = 21;
            this.DescripccionTextBox.Leave += new System.EventHandler(this.DescripccionTextBox_Leave);
            // 
            // CosteTextBox
            // 
            this.CosteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtArticulosBindingSource, "Coste", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C3"));
            this.CosteTextBox.Enabled = false;
            this.CosteTextBox.Location = new System.Drawing.Point(101, 126);
            this.CosteTextBox.Name = "CosteTextBox";
            this.CosteTextBox.Size = new System.Drawing.Size(121, 20);
            this.CosteTextBox.TabIndex = 23;
            this.CosteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CosteTextBox.Enter += new System.EventHandler(this.CosteTextBox_Enter);
            this.CosteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CosteTextBox_KeyPress);
            this.CosteTextBox.Validated += new System.EventHandler(this.CosteTextBox_Validated);
            // 
            // GananciaTextBox
            // 
            this.GananciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtArticulosBindingSource, "Ganancia", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0 %", "P0"));
            this.GananciaTextBox.Enabled = false;
            this.GananciaTextBox.Location = new System.Drawing.Point(101, 152);
            this.GananciaTextBox.MaxLength = 3;
            this.GananciaTextBox.Name = "GananciaTextBox";
            this.GananciaTextBox.Size = new System.Drawing.Size(121, 20);
            this.GananciaTextBox.TabIndex = 25;
            this.GananciaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.GananciaTextBox.Enter += new System.EventHandler(this.GananciaTextBox_Enter);
            this.GananciaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GananciaTextBox_KeyPress);
            this.GananciaTextBox.Leave += new System.EventHandler(this.GananciaTextBox_Leave);
            this.GananciaTextBox.Validated += new System.EventHandler(this.GananciaTextBox_Validated);
            // 
            // tabPage2Articulo
            // 
            this.tabPage2Articulo.AutoScroll = true;
            this.tabPage2Articulo.Controls.Add(this.panelDesc1);
            this.tabPage2Articulo.Controls.Add(label1);
            this.tabPage2Articulo.Controls.Add(pvp1Label1);
            this.tabPage2Articulo.Controls.Add(this.LabDes6);
            this.tabPage2Articulo.Controls.Add(this.LabDes5);
            this.tabPage2Articulo.Controls.Add(this.LabDesc4);
            this.tabPage2Articulo.Controls.Add(this.LabDes3);
            this.tabPage2Articulo.Controls.Add(Pvp2Label);
            this.tabPage2Articulo.Controls.Add(PlusLabel);
            this.tabPage2Articulo.Controls.Add(UnidadPaletLabel);
            this.tabPage2Articulo.Controls.Add(this.UnidadPaletTextBox);
            this.tabPage2Articulo.Controls.Add(MinimosStockLabel);
            this.tabPage2Articulo.Controls.Add(this.MinimosStockTextBox);
            this.tabPage2Articulo.Controls.Add(StockLabel);
            this.tabPage2Articulo.Controls.Add(this.StockTextBox);
            this.tabPage2Articulo.Controls.Add(familiaLabel);
            this.tabPage2Articulo.Controls.Add(this.familiaComboBox);
            this.tabPage2Articulo.Location = new System.Drawing.Point(4, 22);
            this.tabPage2Articulo.Name = "tabPage2Articulo";
            this.tabPage2Articulo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2Articulo.Size = new System.Drawing.Size(1015, 229);
            this.tabPage2Articulo.TabIndex = 1;
            this.tabPage2Articulo.Text = "Datos";
            this.tabPage2Articulo.UseVisualStyleBackColor = true;
            // 
            // panelDesc1
            // 
            this.panelDesc1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDesc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDesc1.Controls.Add(this.PlusDescTxt);
            this.panelDesc1.Controls.Add(this.Desc2Text);
            this.panelDesc1.Controls.Add(this.PlusLabel2);
            this.panelDesc1.Controls.Add(this.Desc3Txt);
            this.panelDesc1.Controls.Add(this.Desc6Txt);
            this.panelDesc1.Controls.Add(this.Pvp2Text);
            this.panelDesc1.Controls.Add(this.Desc5Text);
            this.panelDesc1.Controls.Add(this.Desc4Txt);
            this.panelDesc1.Controls.Add(this.Pvp3Txt);
            this.panelDesc1.Controls.Add(this.Pvp4Txt);
            this.panelDesc1.Controls.Add(this.Pvp6Txt);
            this.panelDesc1.Controls.Add(this.Pvp5Txt);
            this.panelDesc1.Enabled = false;
            this.panelDesc1.Location = new System.Drawing.Point(198, 27);
            this.panelDesc1.Name = "panelDesc1";
            this.panelDesc1.Size = new System.Drawing.Size(238, 194);
            this.panelDesc1.TabIndex = 62;
            // 
            // PlusDescTxt
            // 
            this.PlusDescTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtArticulosBindingSource, "DescPlus", true));
            this.PlusDescTxt.Location = new System.Drawing.Point(4, 157);
            this.PlusDescTxt.MaxLength = 3;
            this.PlusDescTxt.Name = "PlusDescTxt";
            this.PlusDescTxt.Size = new System.Drawing.Size(90, 20);
            this.PlusDescTxt.TabIndex = 35;
            this.PlusDescTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PlusDescTxt.Enter += new System.EventHandler(this.PlusDescTextBox_Enter);
            this.PlusDescTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlusDescTextBox_KeyPress);
            this.PlusDescTxt.Leave += new System.EventHandler(this.PlusDescTextBox_Leave);
            this.PlusDescTxt.MouseLeave += new System.EventHandler(this.PlusDescTextBox_MouseLeave);
            this.PlusDescTxt.Validated += new System.EventHandler(this.PlusDescTextBox_Validated);
            // 
            // Desc2Text
            // 
            this.Desc2Text.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtArticulosBindingSource, "Desc2", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "P0"));
            this.Desc2Text.Location = new System.Drawing.Point(4, 131);
            this.Desc2Text.MaxLength = 3;
            this.Desc2Text.Name = "Desc2Text";
            this.Desc2Text.Size = new System.Drawing.Size(90, 20);
            this.Desc2Text.TabIndex = 47;
            this.Desc2Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Desc2Text.Enter += new System.EventHandler(this.Pvp2DescTextBox_Enter);
            this.Desc2Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pvp2DescTextBox_KeyPress);
            this.Desc2Text.Leave += new System.EventHandler(this.Pvp2DescTextBox_Leave);
            this.Desc2Text.Validated += new System.EventHandler(this.Pvp2DescTextBox_Validated);
            // 
            // PlusLabel2
            // 
            this.PlusLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtArticulosBindingSource, "Plus", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "00,0 €", "C3"));
            this.PlusLabel2.Location = new System.Drawing.Point(106, 158);
            this.PlusLabel2.Name = "PlusLabel2";
            this.PlusLabel2.Size = new System.Drawing.Size(100, 23);
            this.PlusLabel2.TabIndex = 54;
            this.PlusLabel2.Text = "00,0 €";
            this.PlusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Desc3Txt
            // 
            this.Desc3Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtArticulosBindingSource, "Desc3", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "P0"));
            this.Desc3Txt.Location = new System.Drawing.Point(2, 8);
            this.Desc3Txt.MaxLength = 3;
            this.Desc3Txt.Name = "Desc3Txt";
            this.Desc3Txt.Size = new System.Drawing.Size(90, 20);
            this.Desc3Txt.TabIndex = 19;
            this.Desc3Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Desc3Txt.Enter += new System.EventHandler(this.CastyDescTextBox_Enter);
            this.Desc3Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CastyDescTextBox_KeyPress);
            this.Desc3Txt.Leave += new System.EventHandler(this.CastyDescTextBox_Leave);
            this.Desc3Txt.Validated += new System.EventHandler(this.CastyDescTextBox_Validated);
            // 
            // Desc6Txt
            // 
            this.Desc6Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtArticulosBindingSource, "Desc6", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "P0"));
            this.Desc6Txt.Location = new System.Drawing.Point(2, 89);
            this.Desc6Txt.MaxLength = 3;
            this.Desc6Txt.Name = "Desc6Txt";
            this.Desc6Txt.Size = new System.Drawing.Size(90, 20);
            this.Desc6Txt.TabIndex = 31;
            this.Desc6Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Desc6Txt.Enter += new System.EventHandler(this.ValenteDescTextBox_Enter);
            this.Desc6Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValenteDescTextBox_KeyPress);
            this.Desc6Txt.Leave += new System.EventHandler(this.ValenteDescTextBox_Leave);
            this.Desc6Txt.Validated += new System.EventHandler(this.ValenteDescTextBox_Validated);
            // 
            // Pvp2Text
            // 
            this.Pvp2Text.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtArticulosBindingSource, "Pvp2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "00,0 €", "C3"));
            this.Pvp2Text.Location = new System.Drawing.Point(106, 132);
            this.Pvp2Text.Name = "Pvp2Text";
            this.Pvp2Text.Size = new System.Drawing.Size(100, 23);
            this.Pvp2Text.TabIndex = 55;
            this.Pvp2Text.Text = "00,0 €";
            this.Pvp2Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Desc5Text
            // 
            this.Desc5Text.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtArticulosBindingSource, "Desc5", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "P0"));
            this.Desc5Text.Location = new System.Drawing.Point(2, 62);
            this.Desc5Text.MaxLength = 3;
            this.Desc5Text.Name = "Desc5Text";
            this.Desc5Text.Size = new System.Drawing.Size(90, 20);
            this.Desc5Text.TabIndex = 27;
            this.Desc5Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Desc5Text.Enter += new System.EventHandler(this.BenitoDescTextBox_Enter);
            this.Desc5Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BenitoDescTextBox_KeyPress);
            this.Desc5Text.Leave += new System.EventHandler(this.BenitoDescTextBox_Leave);
            this.Desc5Text.Validated += new System.EventHandler(this.BenitoDescTextBox_Validated);
            // 
            // Desc4Txt
            // 
            this.Desc4Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtArticulosBindingSource, "Desc4", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "P0"));
            this.Desc4Txt.Location = new System.Drawing.Point(2, 35);
            this.Desc4Txt.MaxLength = 3;
            this.Desc4Txt.Name = "Desc4Txt";
            this.Desc4Txt.Size = new System.Drawing.Size(90, 20);
            this.Desc4Txt.TabIndex = 23;
            this.Desc4Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Desc4Txt.Enter += new System.EventHandler(this.SuarezDescTextBox_Enter);
            this.Desc4Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SuarezDescTextBox_KeyPress);
            this.Desc4Txt.Leave += new System.EventHandler(this.SuarezDescTextBox_Leave);
            this.Desc4Txt.Validated += new System.EventHandler(this.SuarezDescTextBox_Validated);
            // 
            // Pvp3Txt
            // 
            this.Pvp3Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtArticulosBindingSource, "Pvp3", true));
            this.Pvp3Txt.Location = new System.Drawing.Point(104, 6);
            this.Pvp3Txt.Name = "Pvp3Txt";
            this.Pvp3Txt.Size = new System.Drawing.Size(100, 23);
            this.Pvp3Txt.TabIndex = 50;
            this.Pvp3Txt.Text = "00,0 €";
            this.Pvp3Txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Pvp4Txt
            // 
            this.Pvp4Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtArticulosBindingSource, "Pvp4", true));
            this.Pvp4Txt.Location = new System.Drawing.Point(104, 33);
            this.Pvp4Txt.Name = "Pvp4Txt";
            this.Pvp4Txt.Size = new System.Drawing.Size(100, 23);
            this.Pvp4Txt.TabIndex = 51;
            this.Pvp4Txt.Text = "00,0 €";
            this.Pvp4Txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Pvp6Txt
            // 
            this.Pvp6Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtArticulosBindingSource, "Pvp6", true));
            this.Pvp6Txt.Location = new System.Drawing.Point(104, 87);
            this.Pvp6Txt.Name = "Pvp6Txt";
            this.Pvp6Txt.Size = new System.Drawing.Size(100, 23);
            this.Pvp6Txt.TabIndex = 53;
            this.Pvp6Txt.Text = "00,0 €";
            this.Pvp6Txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Pvp5Txt
            // 
            this.Pvp5Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtArticulosBindingSource, "Pvp5", true));
            this.Pvp5Txt.Location = new System.Drawing.Point(104, 60);
            this.Pvp5Txt.Name = "Pvp5Txt";
            this.Pvp5Txt.Size = new System.Drawing.Size(100, 23);
            this.Pvp5Txt.TabIndex = 52;
            this.Pvp5Txt.Text = "00,0 €";
            this.Pvp5Txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabDes6
            // 
            this.LabDes6.AutoSize = true;
            this.LabDes6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDes6.Location = new System.Drawing.Point(26, 117);
            this.LabDes6.Name = "LabDes6";
            this.LabDes6.Size = new System.Drawing.Size(42, 15);
            this.LabDes6.TabIndex = 59;
            this.LabDes6.Text = "Pvp6:";
            this.LabDes6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabDes5
            // 
            this.LabDes5.AutoSize = true;
            this.LabDes5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDes5.Location = new System.Drawing.Point(26, 90);
            this.LabDes5.Name = "LabDes5";
            this.LabDes5.Size = new System.Drawing.Size(42, 15);
            this.LabDes5.TabIndex = 58;
            this.LabDes5.Text = "Pvp5:";
            this.LabDes5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabDesc4
            // 
            this.LabDesc4.AutoSize = true;
            this.LabDesc4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDesc4.Location = new System.Drawing.Point(26, 63);
            this.LabDesc4.Name = "LabDesc4";
            this.LabDesc4.Size = new System.Drawing.Size(42, 15);
            this.LabDesc4.TabIndex = 57;
            this.LabDesc4.Text = "Pvp4:";
            this.LabDesc4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabDes3
            // 
            this.LabDes3.AutoSize = true;
            this.LabDes3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDes3.Location = new System.Drawing.Point(26, 36);
            this.LabDes3.Name = "LabDes3";
            this.LabDes3.Size = new System.Drawing.Size(42, 15);
            this.LabDes3.TabIndex = 56;
            this.LabDes3.Text = "Pvp3:";
            this.LabDes3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UnidadPaletTextBox
            // 
            this.UnidadPaletTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UnidadPaletTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtArticulosBindingSource, "UnidadPale", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N1"));
            this.UnidadPaletTextBox.Enabled = false;
            this.UnidadPaletTextBox.Location = new System.Drawing.Point(875, 21);
            this.UnidadPaletTextBox.MaxLength = 24;
            this.UnidadPaletTextBox.Name = "UnidadPaletTextBox";
            this.UnidadPaletTextBox.Size = new System.Drawing.Size(121, 20);
            this.UnidadPaletTextBox.TabIndex = 39;
            this.UnidadPaletTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MinimosStockTextBox
            // 
            this.MinimosStockTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimosStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtArticulosBindingSource, "MinimosSto", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N1"));
            this.MinimosStockTextBox.Enabled = false;
            this.MinimosStockTextBox.Location = new System.Drawing.Point(875, 47);
            this.MinimosStockTextBox.MaxLength = 24;
            this.MinimosStockTextBox.Name = "MinimosStockTextBox";
            this.MinimosStockTextBox.Size = new System.Drawing.Size(121, 20);
            this.MinimosStockTextBox.TabIndex = 41;
            this.MinimosStockTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // StockTextBox
            // 
            this.StockTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtArticulosBindingSource, "Stock", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N1"));
            this.StockTextBox.Enabled = false;
            this.StockTextBox.Location = new System.Drawing.Point(875, 73);
            this.StockTextBox.MaxLength = 24;
            this.StockTextBox.Name = "StockTextBox";
            this.StockTextBox.Size = new System.Drawing.Size(121, 20);
            this.StockTextBox.TabIndex = 43;
            this.StockTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // familiaComboBox
            // 
            this.familiaComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.familiaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.familiaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.familiaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtArticulosBindingSource, "Familia", true));
            this.familiaComboBox.DataSource = this.dtFamiliaProductosBindingSource;
            this.familiaComboBox.DisplayMember = "Familia";
            this.familiaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.familiaComboBox.Enabled = false;
            this.familiaComboBox.FormattingEnabled = true;
            this.familiaComboBox.Location = new System.Drawing.Point(660, 114);
            this.familiaComboBox.MaxDropDownItems = 30;
            this.familiaComboBox.MaxLength = 50;
            this.familiaComboBox.Name = "familiaComboBox";
            this.familiaComboBox.Size = new System.Drawing.Size(334, 21);
            this.familiaComboBox.TabIndex = 45;
            this.familiaComboBox.Click += new System.EventHandler(this.familiaComboBox_Click);
            // 
            // dtFamiliaProductosBindingSource
            // 
            this.dtFamiliaProductosBindingSource.DataMember = "DtFamiliaProductos";
            this.dtFamiliaProductosBindingSource.DataSource = this.dsMulti2;
            // 
            // dsMulti2
            // 
            this.dsMulti2.DataSetName = "DsMulti2";
            this.dsMulti2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.TipoIVA_Up_Articulos);
            this.tabPage1.Controls.Add(TipoInpuestoIVALabel1);
            this.tabPage1.Controls.Add(DescueLabel1);
            this.tabPage1.Controls.Add(this.TipoTarifa);
            this.tabPage1.Controls.Add(EmpresaENLACELabel);
            this.tabPage1.Controls.Add(this.EmpresaArticulos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1015, 229);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Control";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TipoIVA_Up_Articulos
            // 
            this.TipoIVA_Up_Articulos.Enabled = false;
            this.TipoIVA_Up_Articulos.Location = new System.Drawing.Point(112, 110);
            this.TipoIVA_Up_Articulos.Name = "TipoIVA_Up_Articulos";
            this.TipoIVA_Up_Articulos.Size = new System.Drawing.Size(85, 20);
            this.TipoIVA_Up_Articulos.TabIndex = 53;
            this.TipoIVA_Up_Articulos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TipoIVA_Up_Articulos.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // TipoTarifa
            // 
            this.TipoTarifa.DataSource = this.dtConfiDtTarifaTipoBindingSource;
            this.TipoTarifa.DisplayMember = "TarifaTipo";
            this.TipoTarifa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoTarifa.FormattingEnabled = true;
            this.TipoTarifa.Location = new System.Drawing.Point(112, 68);
            this.TipoTarifa.Name = "TipoTarifa";
            this.TipoTarifa.Size = new System.Drawing.Size(202, 21);
            this.TipoTarifa.TabIndex = 30;
            this.TipoTarifa.SelectedIndexChanged += new System.EventHandler(this.tarifaTipoArticulos_SelectedIndexChanged);
            // 
            // dtConfiDtTarifaTipoBindingSource
            // 
            this.dtConfiDtTarifaTipoBindingSource.DataMember = "FK_DtConfiguracionPrincipal_DtTarifaTipo";
            this.dtConfiDtTarifaTipoBindingSource.DataSource = this.dtConfiguracionPrincipalBindingSource;
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
            // EmpresaArticulos
            // 
            this.EmpresaArticulos.DataSource = this.dtConfiguracionPrincipalBindingSource;
            this.EmpresaArticulos.DisplayMember = "EmpresaConfi";
            this.EmpresaArticulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpresaArticulos.FormattingEnabled = true;
            this.EmpresaArticulos.Location = new System.Drawing.Point(112, 26);
            this.EmpresaArticulos.Name = "EmpresaArticulos";
            this.EmpresaArticulos.Size = new System.Drawing.Size(294, 21);
            this.EmpresaArticulos.TabIndex = 29;
            this.EmpresaArticulos.SelectedIndexChanged += new System.EventHandler(this.EmpresaArticulos_SelectedIndexChanged);
            this.EmpresaArticulos.SelectionChangeCommitted += new System.EventHandler(this.EmpresaArticulos_SelectionChangeCommitted);
            this.EmpresaArticulos.Validated += new System.EventHandler(this.EmpresaArticulos_Validated);
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
            // panelBotonesArticulo
            // 
            this.panelBotonesArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelBotonesArticulo.BackColor = System.Drawing.Color.Transparent;
            this.panelBotonesArticulo.Controls.Add(this.BtnImprimirArticulo);
            this.panelBotonesArticulo.Controls.Add(this.BtnEnviarMailArticulo);
            this.panelBotonesArticulo.Controls.Add(this.BtnEliminarArticulo);
            this.panelBotonesArticulo.Controls.Add(this.BtnBuscarArticulo);
            this.panelBotonesArticulo.Controls.Add(this.BtnNuevoArticulo);
            this.panelBotonesArticulo.Controls.Add(this.BtnModificarArticulo);
            this.panelBotonesArticulo.Location = new System.Drawing.Point(17, 579);
            this.panelBotonesArticulo.Name = "panelBotonesArticulo";
            this.panelBotonesArticulo.Size = new System.Drawing.Size(459, 63);
            this.panelBotonesArticulo.TabIndex = 31;
            this.panelBotonesArticulo.Tag = "stop";
            // 
            // BtnImprimirArticulo
            // 
            this.BtnImprimirArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnImprimirArticulo.BackColor = System.Drawing.Color.Transparent;
            this.BtnImprimirArticulo.FlatAppearance.BorderSize = 0;
            this.BtnImprimirArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnImprimirArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnImprimirArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimirArticulo.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimirArticulo.ForeColor = System.Drawing.Color.Black;
            this.BtnImprimirArticulo.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_printer_5_32;
            this.BtnImprimirArticulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnImprimirArticulo.Location = new System.Drawing.Point(304, -3);
            this.BtnImprimirArticulo.Name = "BtnImprimirArticulo";
            this.BtnImprimirArticulo.Size = new System.Drawing.Size(77, 63);
            this.BtnImprimirArticulo.TabIndex = 11;
            this.BtnImprimirArticulo.Text = "Imprimir";
            this.BtnImprimirArticulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnImprimirArticulo.UseVisualStyleBackColor = false;
            this.BtnImprimirArticulo.Click += new System.EventHandler(this.BtnImprimirArticulo_Click);
            // 
            // BtnEnviarMailArticulo
            // 
            this.BtnEnviarMailArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEnviarMailArticulo.BackColor = System.Drawing.Color.Transparent;
            this.BtnEnviarMailArticulo.FlatAppearance.BorderSize = 0;
            this.BtnEnviarMailArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnEnviarMailArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnEnviarMailArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnviarMailArticulo.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviarMailArticulo.ForeColor = System.Drawing.Color.Black;
            this.BtnEnviarMailArticulo.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_email_9_32;
            this.BtnEnviarMailArticulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEnviarMailArticulo.Location = new System.Drawing.Point(381, -3);
            this.BtnEnviarMailArticulo.Name = "BtnEnviarMailArticulo";
            this.BtnEnviarMailArticulo.Size = new System.Drawing.Size(77, 63);
            this.BtnEnviarMailArticulo.TabIndex = 10;
            this.BtnEnviarMailArticulo.Text = "Email";
            this.BtnEnviarMailArticulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEnviarMailArticulo.UseVisualStyleBackColor = false;
            // 
            // BtnEliminarArticulo
            // 
            this.BtnEliminarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminarArticulo.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarArticulo.FlatAppearance.BorderSize = 0;
            this.BtnEliminarArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnEliminarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnEliminarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarArticulo.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarArticulo.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminarArticulo.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_trash_can_17_32;
            this.BtnEliminarArticulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminarArticulo.Location = new System.Drawing.Point(227, -3);
            this.BtnEliminarArticulo.Name = "BtnEliminarArticulo";
            this.BtnEliminarArticulo.Size = new System.Drawing.Size(77, 63);
            this.BtnEliminarArticulo.TabIndex = 9;
            this.BtnEliminarArticulo.Text = "Eliminar";
            this.BtnEliminarArticulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminarArticulo.UseVisualStyleBackColor = false;
            this.BtnEliminarArticulo.Click += new System.EventHandler(this.BtnEliminarArticulo_Click);
            // 
            // BtnBuscarArticulo
            // 
            this.BtnBuscarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarArticulo.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscarArticulo.FlatAppearance.BorderSize = 0;
            this.BtnBuscarArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnBuscarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnBuscarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarArticulo.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarArticulo.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscarArticulo.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_magnifier_4_32;
            this.BtnBuscarArticulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscarArticulo.Location = new System.Drawing.Point(150, -3);
            this.BtnBuscarArticulo.Name = "BtnBuscarArticulo";
            this.BtnBuscarArticulo.Size = new System.Drawing.Size(77, 63);
            this.BtnBuscarArticulo.TabIndex = 8;
            this.BtnBuscarArticulo.Text = "Buscar";
            this.BtnBuscarArticulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscarArticulo.UseVisualStyleBackColor = false;
            this.BtnBuscarArticulo.Click += new System.EventHandler(this.BtnBuscarArticulo_Click);
            // 
            // BtnNuevoArticulo
            // 
            this.BtnNuevoArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNuevoArticulo.BackColor = System.Drawing.Color.Transparent;
            this.BtnNuevoArticulo.FlatAppearance.BorderSize = 0;
            this.BtnNuevoArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnNuevoArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnNuevoArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoArticulo.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoArticulo.ForeColor = System.Drawing.Color.Black;
            this.BtnNuevoArticulo.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_file_14_32;
            this.BtnNuevoArticulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevoArticulo.Location = new System.Drawing.Point(-4, -3);
            this.BtnNuevoArticulo.Name = "BtnNuevoArticulo";
            this.BtnNuevoArticulo.Size = new System.Drawing.Size(77, 63);
            this.BtnNuevoArticulo.TabIndex = 6;
            this.BtnNuevoArticulo.Text = "Nuevo";
            this.BtnNuevoArticulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNuevoArticulo.UseVisualStyleBackColor = false;
            this.BtnNuevoArticulo.Click += new System.EventHandler(this.BtnNuevoArticulo_Click);
            // 
            // BtnModificarArticulo
            // 
            this.BtnModificarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModificarArticulo.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificarArticulo.FlatAppearance.BorderSize = 0;
            this.BtnModificarArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnModificarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnModificarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarArticulo.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarArticulo.ForeColor = System.Drawing.Color.Black;
            this.BtnModificarArticulo.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_pen_8_32;
            this.BtnModificarArticulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnModificarArticulo.Location = new System.Drawing.Point(73, -3);
            this.BtnModificarArticulo.Name = "BtnModificarArticulo";
            this.BtnModificarArticulo.Size = new System.Drawing.Size(77, 63);
            this.BtnModificarArticulo.TabIndex = 7;
            this.BtnModificarArticulo.Text = "Modificar";
            this.BtnModificarArticulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificarArticulo.UseVisualStyleBackColor = false;
            this.BtnModificarArticulo.Click += new System.EventHandler(this.BtnModificarArticulo_Click);
            // 
            // BtnSalirArticulo
            // 
            this.BtnSalirArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalirArticulo.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalirArticulo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalirArticulo.FlatAppearance.BorderSize = 0;
            this.BtnSalirArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnSalirArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnSalirArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalirArticulo.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirArticulo.ForeColor = System.Drawing.Color.Black;
            this.BtnSalirArticulo.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_door_5_32;
            this.BtnSalirArticulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalirArticulo.Location = new System.Drawing.Point(931, 579);
            this.BtnSalirArticulo.Name = "BtnSalirArticulo";
            this.BtnSalirArticulo.Size = new System.Drawing.Size(77, 63);
            this.BtnSalirArticulo.TabIndex = 12;
            this.BtnSalirArticulo.Text = "Salir";
            this.BtnSalirArticulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalirArticulo.UseVisualStyleBackColor = false;
            this.BtnSalirArticulo.Click += new System.EventHandler(this.BtnSalirArticulo_Click);
            // 
            // BtnCancelarArticulo
            // 
            this.BtnCancelarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelarArticulo.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelarArticulo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelarArticulo.Enabled = false;
            this.BtnCancelarArticulo.FlatAppearance.BorderSize = 0;
            this.BtnCancelarArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancelarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnCancelarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarArticulo.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarArticulo.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelarArticulo.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_x_mark_8_24;
            this.BtnCancelarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarArticulo.Location = new System.Drawing.Point(673, 597);
            this.BtnCancelarArticulo.Name = "BtnCancelarArticulo";
            this.BtnCancelarArticulo.Size = new System.Drawing.Size(89, 42);
            this.BtnCancelarArticulo.TabIndex = 34;
            this.BtnCancelarArticulo.Text = "Cancelar";
            this.BtnCancelarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelarArticulo.UseVisualStyleBackColor = false;
            this.BtnCancelarArticulo.Click += new System.EventHandler(this.BtnCancelarArticulo_Click);
            // 
            // BtnGuardarArticulo
            // 
            this.BtnGuardarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarArticulo.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarArticulo.Enabled = false;
            this.BtnGuardarArticulo.FlatAppearance.BorderSize = 0;
            this.BtnGuardarArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnGuardarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnGuardarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarArticulo.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarArticulo.ForeColor = System.Drawing.Color.Black;
            this.BtnGuardarArticulo.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_check_mark_9_24;
            this.BtnGuardarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarArticulo.Location = new System.Drawing.Point(503, 597);
            this.BtnGuardarArticulo.Name = "BtnGuardarArticulo";
            this.BtnGuardarArticulo.Size = new System.Drawing.Size(89, 42);
            this.BtnGuardarArticulo.TabIndex = 33;
            this.BtnGuardarArticulo.Tag = "";
            this.BtnGuardarArticulo.Text = "Aceptar";
            this.BtnGuardarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarArticulo.UseVisualStyleBackColor = false;
            this.BtnGuardarArticulo.Click += new System.EventHandler(this.BtnGuardarArticulo_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegistLbel
            // 
            this.RegistLbel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistLbel.AutoSize = true;
            this.RegistLbel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistLbel.Location = new System.Drawing.Point(781, 528);
            this.RegistLbel.Name = "RegistLbel";
            this.RegistLbel.Size = new System.Drawing.Size(99, 20);
            this.RegistLbel.TabIndex = 36;
            this.RegistLbel.Tag = "";
            this.RegistLbel.Text = "Reguistros #";
            // 
            // ContadorDatos3
            // 
            this.ContadorDatos3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ContadorDatos3.AutoSize = true;
            this.ContadorDatos3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContadorDatos3.Location = new System.Drawing.Point(891, 528);
            this.ContadorDatos3.Name = "ContadorDatos3";
            this.ContadorDatos3.Size = new System.Drawing.Size(19, 20);
            this.ContadorDatos3.TabIndex = 35;
            this.ContadorDatos3.Text = "0";
            this.ContadorDatos3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FiltrarBajas
            // 
            this.FiltrarBajas.DisplayMember = "Articulos De Alta";
            this.FiltrarBajas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrarBajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrarBajas.FormattingEnabled = true;
            this.FiltrarBajas.Items.AddRange(new object[] {
            "Articulos De Alta",
            "Articulos De Baja",
            "Todos"});
            this.FiltrarBajas.Location = new System.Drawing.Point(832, 2);
            this.FiltrarBajas.Name = "FiltrarBajas";
            this.FiltrarBajas.Size = new System.Drawing.Size(188, 24);
            this.FiltrarBajas.Sorted = true;
            this.FiltrarBajas.TabIndex = 37;
            this.FiltrarBajas.Tag = "";
            this.FiltrarBajas.ValueMember = "Articulos De Alta";
            this.FiltrarBajas.SelectedIndexChanged += new System.EventHandler(this.FiltrarBajas_SelectedIndexChanged);
            this.FiltrarBajas.Enter += new System.EventHandler(this.FiltrarBajas_Enter);
            // 
            // FiltrarFamiliaArt
            // 
            this.FiltrarFamiliaArt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FiltrarFamiliaArt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtArticulosBindingSource, "Familia", true));
            this.FiltrarFamiliaArt.DataSource = this.dtFamiliaProductosBindingSource;
            this.FiltrarFamiliaArt.DisplayMember = "Familia";
            this.FiltrarFamiliaArt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrarFamiliaArt.FormattingEnabled = true;
            this.FiltrarFamiliaArt.Location = new System.Drawing.Point(130, 4);
            this.FiltrarFamiliaArt.Name = "FiltrarFamiliaArt";
            this.FiltrarFamiliaArt.Size = new System.Drawing.Size(395, 21);
            this.FiltrarFamiliaArt.TabIndex = 47;
            this.FiltrarFamiliaArt.Visible = false;
            this.FiltrarFamiliaArt.SelectedIndexChanged += new System.EventHandler(this.FiltrarFamiliaArt_SelectedIndexChanged);
            this.FiltrarFamiliaArt.Enter += new System.EventHandler(this.FiltrarFamiliaArt_Enter);
            // 
            // CheckFamiliaArt
            // 
            this.CheckFamiliaArt.AutoCheck = false;
            this.CheckFamiliaArt.AutoSize = true;
            this.CheckFamiliaArt.Location = new System.Drawing.Point(17, 5);
            this.CheckFamiliaArt.Name = "CheckFamiliaArt";
            this.CheckFamiliaArt.Size = new System.Drawing.Size(107, 17);
            this.CheckFamiliaArt.TabIndex = 48;
            this.CheckFamiliaArt.Text = "Filtrar Por Familia:";
            this.CheckFamiliaArt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckFamiliaArt.UseVisualStyleBackColor = true;
            this.CheckFamiliaArt.Click += new System.EventHandler(this.CheckFamiliaArt_Click);
            // 
            // FormArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 654);
            this.Controls.Add(this.BtnSalirArticulo);
            this.Controls.Add(this.CheckFamiliaArt);
            this.Controls.Add(this.FiltrarFamiliaArt);
            this.Controls.Add(label2);
            this.Controls.Add(this.FiltrarBajas);
            this.Controls.Add(this.RegistLbel);
            this.Controls.Add(this.ContadorDatos3);
            this.Controls.Add(this.BtnCancelarArticulo);
            this.Controls.Add(this.BtnGuardarArticulo);
            this.Controls.Add(this.panelBotonesArticulo);
            this.Controls.Add(this.tabControl1Articulo);
            this.Controls.Add(this.dtPreciosDataGridView);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ARTICULOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormARTICULOS_FormClosing);
            this.Load += new System.EventHandler(this.FormARTICULOS_Load);
            this.MouseEnter += new System.EventHandler(this.FormARTICULOS_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.dtPreciosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtArticulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulos)).EndInit();
            this.tabControl1Articulo.ResumeLayout(false);
            this.tabPage1Articulo.ResumeLayout(false);
            this.tabPage1Articulo.PerformLayout();
            this.tabPage2Articulo.ResumeLayout(false);
            this.tabPage2Articulo.PerformLayout();
            this.panelDesc1.ResumeLayout(false);
            this.panelDesc1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFamiliaProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMulti2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TipoIVA_Up_Articulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiDtTarifaTipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).EndInit();
            this.panelBotonesArticulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1Articulo;
        private System.Windows.Forms.TabPage tabPage1Articulo;
        private System.Windows.Forms.TabPage tabPage2Articulo;
        private System.Windows.Forms.TextBox Desc3Txt;
        private System.Windows.Forms.TextBox Desc4Txt;
        private System.Windows.Forms.TextBox Desc5Text;
        private System.Windows.Forms.TextBox Desc6Txt;
        private System.Windows.Forms.TextBox PlusDescTxt;
        private System.Windows.Forms.TextBox UnidadPaletTextBox;
        private System.Windows.Forms.TextBox MinimosStockTextBox;
        private System.Windows.Forms.TextBox StockTextBox;
        private System.Windows.Forms.ComboBox familiaComboBox;
        private System.Windows.Forms.TextBox ReferenciaTextBox;
        private System.Windows.Forms.TextBox DescripccionTextBox;
        private System.Windows.Forms.TextBox CosteTextBox;
        private System.Windows.Forms.TextBox GananciaTextBox;
        private System.Windows.Forms.Panel panelBotonesArticulo;
        private System.Windows.Forms.Button BtnSalirArticulo;
        private System.Windows.Forms.Button BtnImprimirArticulo;
        private System.Windows.Forms.Button BtnEnviarMailArticulo;
        private System.Windows.Forms.Button BtnEliminarArticulo;
        private System.Windows.Forms.Button BtnBuscarArticulo;
        private System.Windows.Forms.Button BtnNuevoArticulo;
        private System.Windows.Forms.Button BtnModificarArticulo;
        private System.Windows.Forms.Button BtnCancelarArticulo;
        public System.Windows.Forms.Button BtnGuardarArticulo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.DataGridView dtPreciosDataGridView;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.BindingSource dtConfiguracionPrincipalBindingSource;
        private System.Windows.Forms.Label Pvp2Text;
        private System.Windows.Forms.Label PlusLabel2;
        private System.Windows.Forms.Label Pvp6Txt;
        private System.Windows.Forms.Label Pvp5Txt;
        private System.Windows.Forms.Label Pvp4Txt;
        private System.Windows.Forms.Label Pvp3Txt;
        private System.Windows.Forms.TextBox Desc2Text;
        public System.Windows.Forms.ComboBox EmpresaArticulos;
        private System.Windows.Forms.Label LabDes3;
        private System.Windows.Forms.Label LabDes6;
        private System.Windows.Forms.Label LabDes5;
        private System.Windows.Forms.Label LabDesc4;
        private System.Windows.Forms.BindingSource dtConfiDtTarifaTipoBindingSource;
        private System.Windows.Forms.ComboBox TipoTarifa;
        private DsMultidatos dsMultidatos;
        private System.Windows.Forms.ComboBox DescripcionBuscarArt;
        private System.Windows.Forms.BindingSource dtInicioMultiBindingSource;
        private System.Windows.Forms.Label RegistLbel;
        private System.Windows.Forms.Label ContadorDatos3;
        private System.Windows.Forms.ComboBox ReferenciaBuscarArt;
        private System.Windows.Forms.Label PvpIvaLabel2;
        private System.Windows.Forms.Label Pvp1Text;
        private System.Windows.Forms.DateTimePicker FechaAlta;
        public DsCONFIGURACCION dsCONFIGURACCION;
        private System.Windows.Forms.NumericUpDown TipoIVA_Up_Articulos;
        private System.Windows.Forms.BindingSource dtFamiliaProductosBindingSource;
        private System.Windows.Forms.CheckBox BajaCheckBox;
        public System.Windows.Forms.BindingSource dtArticulosBindingSource;
        public DsArticulos articulos;
        public System.Windows.Forms.ComboBox FiltrarBajas;
        private System.Windows.Forms.ComboBox FiltrarFamiliaArt;
        private System.Windows.Forms.RadioButton CheckFamiliaArt;
        private System.Windows.Forms.Label idArticulo;
        private System.Windows.Forms.Panel panelDesc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcci;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Familia;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFILA;
        private DsMulti2 dsMulti2;
        private System.Windows.Forms.TextBox OemText;
    }
}