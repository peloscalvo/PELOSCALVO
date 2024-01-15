
namespace PELOSCALVO
{
    partial class FormBuscarArticulos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarArticulos));
            this.TIPObuscarArticulos = new System.Windows.Forms.ComboBox();
            this.BuscarArticulosText = new System.Windows.Forms.TextBox();
            this.DataGridViewBuscarArticulos = new System.Windows.Forms.DataGridView();
            this.referenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pvp1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PvpIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFILA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtArticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articulos = new PELOSCALVO.Articulos();
            this.label1 = new System.Windows.Forms.Label();
            this.ContadorDatos2 = new System.Windows.Forms.Label();
            this.FiltrarBajasBuscar = new System.Windows.Forms.ComboBox();
            this.labelfiltrarBUSCAR = new System.Windows.Forms.Label();
            this.ListCodigos = new System.Windows.Forms.ListView();
            this.Id_Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Texto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListaQr = new System.Windows.Forms.ComboBox();
            this.dtInicioMultiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMultidatos = new PELOSCALVO.DsMultidatos();
            this.BtnCrearQr = new System.Windows.Forms.Button();
            this.TituloText = new System.Windows.Forms.TextBox();
            this.PitureQr = new System.Windows.Forms.PictureBox();
            this.BtnCodifiCar = new System.Windows.Forms.Button();
            this.BtnCancelarBArticulo = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.Anchotext = new System.Windows.Forms.TextBox();
            this.AltoText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBuscarArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtArticulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PitureQr)).BeginInit();
            this.SuspendLayout();
            // 
            // TIPObuscarArticulos
            // 
            this.TIPObuscarArticulos.FormattingEnabled = true;
            this.TIPObuscarArticulos.Items.AddRange(new object[] {
            "Todos",
            "Referencia",
            "Descripccion",
            "Familia"});
            this.TIPObuscarArticulos.Location = new System.Drawing.Point(12, 12);
            this.TIPObuscarArticulos.Name = "TIPObuscarArticulos";
            this.TIPObuscarArticulos.Size = new System.Drawing.Size(204, 21);
            this.TIPObuscarArticulos.TabIndex = 2;
            this.TIPObuscarArticulos.Text = "Todos";
            this.TIPObuscarArticulos.SelectedIndexChanged += new System.EventHandler(this.TIPObuscarArticulos_SelectedIndexChanged);
            // 
            // BuscarArticulosText
            // 
            this.BuscarArticulosText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.BuscarArticulosText.Location = new System.Drawing.Point(248, 12);
            this.BuscarArticulosText.Name = "BuscarArticulosText";
            this.BuscarArticulosText.Size = new System.Drawing.Size(324, 20);
            this.BuscarArticulosText.TabIndex = 1;
            this.BuscarArticulosText.Click += new System.EventHandler(this.BuscarArticulosText_Click);
            this.BuscarArticulosText.TextChanged += new System.EventHandler(this.BuscarArticulosText_TextChanged);
            // 
            // DataGridViewBuscarArticulos
            // 
            this.DataGridViewBuscarArticulos.AllowUserToAddRows = false;
            this.DataGridViewBuscarArticulos.AllowUserToDeleteRows = false;
            this.DataGridViewBuscarArticulos.AllowUserToResizeRows = false;
            this.DataGridViewBuscarArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataGridViewBuscarArticulos.AutoGenerateColumns = false;
            this.DataGridViewBuscarArticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridViewBuscarArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridViewBuscarArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DataGridViewBuscarArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewBuscarArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewBuscarArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewBuscarArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referenciaDataGridViewTextBoxColumn,
            this.descripcciDataGridViewTextBoxColumn,
            this.pvp1DataGridViewTextBoxColumn,
            this.PvpIva,
            this.familiaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.IdFILA});
            this.DataGridViewBuscarArticulos.DataSource = this.dtArticulosBindingSource;
            this.DataGridViewBuscarArticulos.Location = new System.Drawing.Point(12, 48);
            this.DataGridViewBuscarArticulos.Name = "DataGridViewBuscarArticulos";
            this.DataGridViewBuscarArticulos.ReadOnly = true;
            this.DataGridViewBuscarArticulos.RowHeadersVisible = false;
            this.DataGridViewBuscarArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewBuscarArticulos.Size = new System.Drawing.Size(766, 318);
            this.DataGridViewBuscarArticulos.TabIndex = 6;
            this.DataGridViewBuscarArticulos.TabStop = false;
            this.DataGridViewBuscarArticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewBuscarArticulos_CellClick);
            this.DataGridViewBuscarArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewBuscarArticulos_CellDoubleClick);
            // 
            // referenciaDataGridViewTextBoxColumn
            // 
            this.referenciaDataGridViewTextBoxColumn.DataPropertyName = "Referencia";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.referenciaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.referenciaDataGridViewTextBoxColumn.FillWeight = 150F;
            this.referenciaDataGridViewTextBoxColumn.HeaderText = "Referencia";
            this.referenciaDataGridViewTextBoxColumn.Name = "referenciaDataGridViewTextBoxColumn";
            this.referenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.referenciaDataGridViewTextBoxColumn.Width = 150;
            // 
            // descripcciDataGridViewTextBoxColumn
            // 
            this.descripcciDataGridViewTextBoxColumn.DataPropertyName = "Descripcci";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.descripcciDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.descripcciDataGridViewTextBoxColumn.FillWeight = 300F;
            this.descripcciDataGridViewTextBoxColumn.HeaderText = "Descripccion";
            this.descripcciDataGridViewTextBoxColumn.Name = "descripcciDataGridViewTextBoxColumn";
            this.descripcciDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcciDataGridViewTextBoxColumn.Width = 300;
            // 
            // pvp1DataGridViewTextBoxColumn
            // 
            this.pvp1DataGridViewTextBoxColumn.DataPropertyName = "Pvp1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.pvp1DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.pvp1DataGridViewTextBoxColumn.FillWeight = 80F;
            this.pvp1DataGridViewTextBoxColumn.HeaderText = "Pvp1";
            this.pvp1DataGridViewTextBoxColumn.Name = "pvp1DataGridViewTextBoxColumn";
            this.pvp1DataGridViewTextBoxColumn.ReadOnly = true;
            this.pvp1DataGridViewTextBoxColumn.Width = 80;
            // 
            // PvpIva
            // 
            this.PvpIva.DataPropertyName = "PvpIva";
            this.PvpIva.HeaderText = "C/iIva";
            this.PvpIva.Name = "PvpIva";
            this.PvpIva.ReadOnly = true;
            // 
            // familiaDataGridViewTextBoxColumn
            // 
            this.familiaDataGridViewTextBoxColumn.DataPropertyName = "Familia";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.familiaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.familiaDataGridViewTextBoxColumn.FillWeight = 140F;
            this.familiaDataGridViewTextBoxColumn.HeaderText = "Familia";
            this.familiaDataGridViewTextBoxColumn.Name = "familiaDataGridViewTextBoxColumn";
            this.familiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.familiaDataGridViewTextBoxColumn.Width = 140;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.fechaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.fechaDataGridViewTextBoxColumn.FillWeight = 85F;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 85;
            // 
            // IdFILA
            // 
            this.IdFILA.DataPropertyName = "IdFILA";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Maroon;
            this.IdFILA.DefaultCellStyle = dataGridViewCellStyle7;
            this.IdFILA.HeaderText = "I.D";
            this.IdFILA.Name = "IdFILA";
            this.IdFILA.ReadOnly = true;
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Reguistros #";
            // 
            // ContadorDatos2
            // 
            this.ContadorDatos2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ContadorDatos2.AutoSize = true;
            this.ContadorDatos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContadorDatos2.Location = new System.Drawing.Point(126, 378);
            this.ContadorDatos2.Name = "ContadorDatos2";
            this.ContadorDatos2.Size = new System.Drawing.Size(19, 20);
            this.ContadorDatos2.TabIndex = 9;
            this.ContadorDatos2.Text = "0";
            this.ContadorDatos2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FiltrarBajasBuscar
            // 
            this.FiltrarBajasBuscar.DisplayMember = "Articulos De Alta";
            this.FiltrarBajasBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrarBajasBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrarBajasBuscar.FormattingEnabled = true;
            this.FiltrarBajasBuscar.Items.AddRange(new object[] {
            "Articulos De Alta",
            "Articulos De Baja",
            "Todos"});
            this.FiltrarBajasBuscar.Location = new System.Drawing.Point(69, 422);
            this.FiltrarBajasBuscar.Name = "FiltrarBajasBuscar";
            this.FiltrarBajasBuscar.Size = new System.Drawing.Size(188, 24);
            this.FiltrarBajasBuscar.Sorted = true;
            this.FiltrarBajasBuscar.TabIndex = 39;
            this.FiltrarBajasBuscar.Tag = "";
            this.FiltrarBajasBuscar.ValueMember = "Articulos De Alta";
            this.FiltrarBajasBuscar.SelectedIndexChanged += new System.EventHandler(this.FiltrarBajasBuscar_SelectedIndexChanged);
            // 
            // labelfiltrarBUSCAR
            // 
            this.labelfiltrarBUSCAR.AutoSize = true;
            this.labelfiltrarBUSCAR.Location = new System.Drawing.Point(9, 427);
            this.labelfiltrarBUSCAR.Name = "labelfiltrarBUSCAR";
            this.labelfiltrarBUSCAR.Size = new System.Drawing.Size(35, 13);
            this.labelfiltrarBUSCAR.TabIndex = 40;
            this.labelfiltrarBUSCAR.Text = "Filtrar:";
            this.labelfiltrarBUSCAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelfiltrarBUSCAR.Visible = false;
            // 
            // ListCodigos
            // 
            this.ListCodigos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id_Codigo,
            this.Texto});
            this.ListCodigos.FullRowSelect = true;
            this.ListCodigos.GridLines = true;
            this.ListCodigos.HideSelection = false;
            this.ListCodigos.Location = new System.Drawing.Point(810, 101);
            this.ListCodigos.Name = "ListCodigos";
            this.ListCodigos.Size = new System.Drawing.Size(411, 176);
            this.ListCodigos.TabIndex = 41;
            this.ListCodigos.UseCompatibleStateImageBehavior = false;
            this.ListCodigos.View = System.Windows.Forms.View.Details;
            this.ListCodigos.Click += new System.EventHandler(this.ListCodigos_Click);
            // 
            // Id_Codigo
            // 
            this.Id_Codigo.Text = "Id";
            this.Id_Codigo.Width = 98;
            // 
            // Texto
            // 
            this.Texto.Text = "Texto";
            this.Texto.Width = 335;
            // 
            // ListaQr
            // 
            this.ListaQr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtInicioMultiBindingSource, "CodigoBarras", true));
            this.ListaQr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListaQr.FormattingEnabled = true;
            this.ListaQr.Location = new System.Drawing.Point(810, 48);
            this.ListaQr.Name = "ListaQr";
            this.ListaQr.Size = new System.Drawing.Size(361, 21);
            this.ListaQr.TabIndex = 74;
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
            // BtnCrearQr
            // 
            this.BtnCrearQr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCrearQr.BackColor = System.Drawing.Color.Transparent;
            this.BtnCrearQr.FlatAppearance.BorderSize = 0;
            this.BtnCrearQr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnCrearQr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnCrearQr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearQr.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearQr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCrearQr.Location = new System.Drawing.Point(1013, 419);
            this.BtnCrearQr.Name = "BtnCrearQr";
            this.BtnCrearQr.Size = new System.Drawing.Size(89, 42);
            this.BtnCrearQr.TabIndex = 75;
            this.BtnCrearQr.Text = "&Crear";
            this.BtnCrearQr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCrearQr.UseVisualStyleBackColor = false;
            this.BtnCrearQr.Click += new System.EventHandler(this.BtnCrearQr_Click);
            // 
            // TituloText
            // 
            this.TituloText.Location = new System.Drawing.Point(810, 75);
            this.TituloText.Name = "TituloText";
            this.TituloText.Size = new System.Drawing.Size(312, 20);
            this.TituloText.TabIndex = 76;
            // 
            // PitureQr
            // 
            this.PitureQr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PitureQr.Location = new System.Drawing.Point(810, 309);
            this.PitureQr.Name = "PitureQr";
            this.PitureQr.Size = new System.Drawing.Size(411, 104);
            this.PitureQr.TabIndex = 77;
            this.PitureQr.TabStop = false;
            // 
            // BtnCodifiCar
            // 
            this.BtnCodifiCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCodifiCar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCodifiCar.FlatAppearance.BorderSize = 0;
            this.BtnCodifiCar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnCodifiCar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnCodifiCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCodifiCar.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCodifiCar.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_check_mark_9_24;
            this.BtnCodifiCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCodifiCar.Location = new System.Drawing.Point(1154, 419);
            this.BtnCodifiCar.Name = "BtnCodifiCar";
            this.BtnCodifiCar.Size = new System.Drawing.Size(89, 42);
            this.BtnCodifiCar.TabIndex = 73;
            this.BtnCodifiCar.Text = "&Guardar";
            this.BtnCodifiCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCodifiCar.UseVisualStyleBackColor = false;
            this.BtnCodifiCar.Click += new System.EventHandler(this.BtnCodifiCar_Click);
            // 
            // BtnCancelarBArticulo
            // 
            this.BtnCancelarBArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancelarBArticulo.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelarBArticulo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelarBArticulo.FlatAppearance.BorderSize = 0;
            this.BtnCancelarBArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancelarBArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnCancelarBArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarBArticulo.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarBArticulo.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_x_mark_8_24;
            this.BtnCancelarBArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarBArticulo.Location = new System.Drawing.Point(668, 404);
            this.BtnCancelarBArticulo.Name = "BtnCancelarBArticulo";
            this.BtnCancelarBArticulo.Size = new System.Drawing.Size(89, 42);
            this.BtnCancelarBArticulo.TabIndex = 34;
            this.BtnCancelarBArticulo.Tag = "SI";
            this.BtnCancelarBArticulo.Text = "Cancelar";
            this.BtnCancelarBArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelarBArticulo.UseVisualStyleBackColor = false;
            this.BtnCancelarBArticulo.Click += new System.EventHandler(this.BtnCancelarBArticulo_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(1227, 101);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(52, 23);
            this.BtnLimpiar.TabIndex = 78;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // Anchotext
            // 
            this.Anchotext.Location = new System.Drawing.Point(903, 283);
            this.Anchotext.Name = "Anchotext";
            this.Anchotext.Size = new System.Drawing.Size(91, 20);
            this.Anchotext.TabIndex = 79;
            this.Anchotext.Text = "300";
            this.Anchotext.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Anchotext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Anchotext_KeyPress);
            // 
            // AltoText
            // 
            this.AltoText.Location = new System.Drawing.Point(1080, 283);
            this.AltoText.Name = "AltoText";
            this.AltoText.Size = new System.Drawing.Size(91, 20);
            this.AltoText.TabIndex = 80;
            this.AltoText.Text = "120";
            this.AltoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AltoText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AltoText_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(856, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "Ancho:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1024, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Ancho:";
            // 
            // FormBuscarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 467);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AltoText);
            this.Controls.Add(this.Anchotext);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.PitureQr);
            this.Controls.Add(this.TituloText);
            this.Controls.Add(this.BtnCrearQr);
            this.Controls.Add(this.ListaQr);
            this.Controls.Add(this.BtnCodifiCar);
            this.Controls.Add(this.ListCodigos);
            this.Controls.Add(this.labelfiltrarBUSCAR);
            this.Controls.Add(this.FiltrarBajasBuscar);
            this.Controls.Add(this.BtnCancelarBArticulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContadorDatos2);
            this.Controls.Add(this.TIPObuscarArticulos);
            this.Controls.Add(this.BuscarArticulosText);
            this.Controls.Add(this.DataGridViewBuscarArticulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuscarArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar Articulos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormBuscarArticulosEnFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBuscarArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtArticulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PitureQr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TIPObuscarArticulos;
        private System.Windows.Forms.TextBox BuscarArticulosText;
        private System.Windows.Forms.DataGridView DataGridViewBuscarArticulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ContadorDatos2;
        private System.Windows.Forms.Button BtnCancelarBArticulo;
        private Articulos articulos;
        public System.Windows.Forms.BindingSource dtArticulosBindingSource;
        private System.Windows.Forms.ComboBox FiltrarBajasBuscar;
        private System.Windows.Forms.Label labelfiltrarBUSCAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pvp1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PvpIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFILA;
        private System.Windows.Forms.ListView ListCodigos;
        public System.Windows.Forms.Button BtnCodifiCar;
        private System.Windows.Forms.ComboBox ListaQr;
        public System.Windows.Forms.Button BtnCrearQr;
        private System.Windows.Forms.TextBox TituloText;
        private System.Windows.Forms.PictureBox PitureQr;
        private System.Windows.Forms.ColumnHeader Id_Codigo;
        private System.Windows.Forms.ColumnHeader Texto;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.BindingSource dtInicioMultiBindingSource;
        private DsMultidatos dsMultidatos;
        private System.Windows.Forms.TextBox Anchotext;
        private System.Windows.Forms.TextBox AltoText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}