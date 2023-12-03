
namespace PELOSCALVO
{
    partial class FormProvincias
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
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label Label4;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProvincias));
            this.BtnGuardarProvincia = new System.Windows.Forms.Button();
            this.ProvinciaText = new System.Windows.Forms.TextBox();
            this.DtProvinciasBindinsource = new System.Windows.Forms.BindingSource(this.components);
            this.dtPaisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMulti2 = new PELOSCALVO.DsMulti2();
            this.PanelProvincias = new System.Windows.Forms.Panel();
            this.Id_Provincias = new System.Windows.Forms.Label();
            this.PanelBotones_Provincia = new System.Windows.Forms.Panel();
            this.BtnEliminarProvincia = new System.Windows.Forms.Button();
            this.BtnBuscarProvincia = new System.Windows.Forms.Button();
            this.BtnNuevoProvincia = new System.Windows.Forms.Button();
            this.BtnModificarProvincia = new System.Windows.Forms.Button();
            this.BtnCancelarProvincia = new System.Windows.Forms.Button();
            this.BtnSalir_Provincias = new System.Windows.Forms.Button();
            this.ErrorProve = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridProvincias = new System.Windows.Forms.DataGridView();
            this.PaisTxt = new System.Windows.Forms.ComboBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            Label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtProvinciasBindinsource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMulti2)).BeginInit();
            this.PanelProvincias.SuspendLayout();
            this.PanelBotones_Provincia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProvincias)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(31, 14);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(19, 13);
            label10.TabIndex = 54;
            label10.Text = "Id:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(6, 46);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(54, 13);
            label11.TabIndex = 55;
            label11.Text = "Provincia:";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new System.Drawing.Point(534, 292);
            Label4.Name = "Label4";
            Label4.Size = new System.Drawing.Size(30, 13);
            Label4.TabIndex = 80;
            Label4.Text = "Pais:";
            // 
            // BtnGuardarProvincia
            // 
            this.BtnGuardarProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarProvincia.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarProvincia.Enabled = false;
            this.BtnGuardarProvincia.FlatAppearance.BorderSize = 0;
            this.BtnGuardarProvincia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnGuardarProvincia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnGuardarProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarProvincia.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarProvincia.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_check_mark_9_24;
            this.BtnGuardarProvincia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarProvincia.Location = new System.Drawing.Point(570, 415);
            this.BtnGuardarProvincia.Name = "BtnGuardarProvincia";
            this.BtnGuardarProvincia.Size = new System.Drawing.Size(89, 42);
            this.BtnGuardarProvincia.TabIndex = 79;
            this.BtnGuardarProvincia.Text = "Aceptar";
            this.BtnGuardarProvincia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarProvincia.UseVisualStyleBackColor = false;
            this.BtnGuardarProvincia.Click += new System.EventHandler(this.BtnGuardarProvincia_Click);
            // 
            // ProvinciaText
            // 
            this.ProvinciaText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DtProvinciasBindinsource, "ProvinciasProvincias", true));
            this.ProvinciaText.Location = new System.Drawing.Point(74, 43);
            this.ProvinciaText.MaxLength = 40;
            this.ProvinciaText.Name = "ProvinciaText";
            this.ProvinciaText.ReadOnly = true;
            this.ProvinciaText.Size = new System.Drawing.Size(385, 20);
            this.ProvinciaText.TabIndex = 56;
            // 
            // DtProvinciasBindinsource
            // 
            this.DtProvinciasBindinsource.DataMember = "FK_DtPaises_DtProvincias";
            this.DtProvinciasBindinsource.DataSource = this.dtPaisesBindingSource;
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
            // PanelProvincias
            // 
            this.PanelProvincias.Controls.Add(this.Id_Provincias);
            this.PanelProvincias.Controls.Add(this.PanelBotones_Provincia);
            this.PanelProvincias.Controls.Add(label10);
            this.PanelProvincias.Controls.Add(label11);
            this.PanelProvincias.Controls.Add(this.ProvinciaText);
            this.PanelProvincias.Location = new System.Drawing.Point(12, 284);
            this.PanelProvincias.Name = "PanelProvincias";
            this.PanelProvincias.Size = new System.Drawing.Size(478, 172);
            this.PanelProvincias.TabIndex = 77;
            // 
            // Id_Provincias
            // 
            this.Id_Provincias.AutoSize = true;
            this.Id_Provincias.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DtProvinciasBindinsource, "Id", true));
            this.Id_Provincias.Location = new System.Drawing.Point(74, 14);
            this.Id_Provincias.Name = "Id_Provincias";
            this.Id_Provincias.Size = new System.Drawing.Size(13, 13);
            this.Id_Provincias.TabIndex = 58;
            this.Id_Provincias.Text = "0";
            this.Id_Provincias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PanelBotones_Provincia
            // 
            this.PanelBotones_Provincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelBotones_Provincia.BackColor = System.Drawing.Color.Transparent;
            this.PanelBotones_Provincia.Controls.Add(this.BtnEliminarProvincia);
            this.PanelBotones_Provincia.Controls.Add(this.BtnBuscarProvincia);
            this.PanelBotones_Provincia.Controls.Add(this.BtnNuevoProvincia);
            this.PanelBotones_Provincia.Controls.Add(this.BtnModificarProvincia);
            this.PanelBotones_Provincia.Location = new System.Drawing.Point(9, 99);
            this.PanelBotones_Provincia.Name = "PanelBotones_Provincia";
            this.PanelBotones_Provincia.Size = new System.Drawing.Size(396, 63);
            this.PanelBotones_Provincia.TabIndex = 54;
            this.PanelBotones_Provincia.Tag = "NO";
            // 
            // BtnEliminarProvincia
            // 
            this.BtnEliminarProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminarProvincia.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarProvincia.FlatAppearance.BorderSize = 0;
            this.BtnEliminarProvincia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnEliminarProvincia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnEliminarProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarProvincia.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarProvincia.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_trash_can_17_32;
            this.BtnEliminarProvincia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminarProvincia.Location = new System.Drawing.Point(238, 3);
            this.BtnEliminarProvincia.Name = "BtnEliminarProvincia";
            this.BtnEliminarProvincia.Size = new System.Drawing.Size(77, 63);
            this.BtnEliminarProvincia.TabIndex = 9;
            this.BtnEliminarProvincia.Text = "Eliminar";
            this.BtnEliminarProvincia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminarProvincia.UseVisualStyleBackColor = false;
            this.BtnEliminarProvincia.Click += new System.EventHandler(this.BtnEliminarProvincia_Click);
            // 
            // BtnBuscarProvincia
            // 
            this.BtnBuscarProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarProvincia.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscarProvincia.FlatAppearance.BorderSize = 0;
            this.BtnBuscarProvincia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnBuscarProvincia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnBuscarProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarProvincia.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarProvincia.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_magnifier_4_32;
            this.BtnBuscarProvincia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscarProvincia.Location = new System.Drawing.Point(161, 3);
            this.BtnBuscarProvincia.Name = "BtnBuscarProvincia";
            this.BtnBuscarProvincia.Size = new System.Drawing.Size(77, 63);
            this.BtnBuscarProvincia.TabIndex = 8;
            this.BtnBuscarProvincia.Text = "Buscar";
            this.BtnBuscarProvincia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscarProvincia.UseVisualStyleBackColor = false;
            // 
            // BtnNuevoProvincia
            // 
            this.BtnNuevoProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNuevoProvincia.BackColor = System.Drawing.Color.Transparent;
            this.BtnNuevoProvincia.FlatAppearance.BorderSize = 0;
            this.BtnNuevoProvincia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnNuevoProvincia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnNuevoProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoProvincia.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoProvincia.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_file_14_32;
            this.BtnNuevoProvincia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevoProvincia.Location = new System.Drawing.Point(7, 3);
            this.BtnNuevoProvincia.Name = "BtnNuevoProvincia";
            this.BtnNuevoProvincia.Size = new System.Drawing.Size(77, 63);
            this.BtnNuevoProvincia.TabIndex = 6;
            this.BtnNuevoProvincia.Tag = "stop";
            this.BtnNuevoProvincia.Text = "Nuevo";
            this.BtnNuevoProvincia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNuevoProvincia.UseVisualStyleBackColor = false;
            this.BtnNuevoProvincia.Click += new System.EventHandler(this.BtnNuevoProvincia_Click);
            // 
            // BtnModificarProvincia
            // 
            this.BtnModificarProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModificarProvincia.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificarProvincia.FlatAppearance.BorderSize = 0;
            this.BtnModificarProvincia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnModificarProvincia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnModificarProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarProvincia.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarProvincia.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_pen_8_32;
            this.BtnModificarProvincia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnModificarProvincia.Location = new System.Drawing.Point(84, 3);
            this.BtnModificarProvincia.Name = "BtnModificarProvincia";
            this.BtnModificarProvincia.Size = new System.Drawing.Size(77, 63);
            this.BtnModificarProvincia.TabIndex = 7;
            this.BtnModificarProvincia.Text = "Modificar";
            this.BtnModificarProvincia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificarProvincia.UseVisualStyleBackColor = false;
            this.BtnModificarProvincia.Click += new System.EventHandler(this.BtnModificarProvincia_Click);
            // 
            // BtnCancelarProvincia
            // 
            this.BtnCancelarProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelarProvincia.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelarProvincia.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelarProvincia.Enabled = false;
            this.BtnCancelarProvincia.FlatAppearance.BorderSize = 0;
            this.BtnCancelarProvincia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancelarProvincia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnCancelarProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarProvincia.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarProvincia.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_x_mark_8_24;
            this.BtnCancelarProvincia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarProvincia.Location = new System.Drawing.Point(725, 415);
            this.BtnCancelarProvincia.Name = "BtnCancelarProvincia";
            this.BtnCancelarProvincia.Size = new System.Drawing.Size(89, 42);
            this.BtnCancelarProvincia.TabIndex = 80;
            this.BtnCancelarProvincia.Text = "Cancelar";
            this.BtnCancelarProvincia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelarProvincia.UseVisualStyleBackColor = false;
            this.BtnCancelarProvincia.Click += new System.EventHandler(this.BtnCancelarProvincia_Click);
            // 
            // BtnSalir_Provincias
            // 
            this.BtnSalir_Provincias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir_Provincias.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalir_Provincias.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalir_Provincias.FlatAppearance.BorderSize = 0;
            this.BtnSalir_Provincias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnSalir_Provincias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnSalir_Provincias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir_Provincias.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir_Provincias.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_door_5_32;
            this.BtnSalir_Provincias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalir_Provincias.Location = new System.Drawing.Point(891, 397);
            this.BtnSalir_Provincias.Name = "BtnSalir_Provincias";
            this.BtnSalir_Provincias.Size = new System.Drawing.Size(77, 63);
            this.BtnSalir_Provincias.TabIndex = 78;
            this.BtnSalir_Provincias.Text = "Salir";
            this.BtnSalir_Provincias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalir_Provincias.UseVisualStyleBackColor = false;
            this.BtnSalir_Provincias.Click += new System.EventHandler(this.BtnSalir_Provincias_Click);
            // 
            // ErrorProve
            // 
            this.ErrorProve.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.ErrorProve.ContainerControl = this;
            // 
            // dataGridProvincias
            // 
            this.dataGridProvincias.AllowDrop = true;
            this.dataGridProvincias.AllowUserToAddRows = false;
            this.dataGridProvincias.AutoGenerateColumns = false;
            this.dataGridProvincias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProvincias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridProvincias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridProvincias.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProvincias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProvincias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProvincias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridProvincias.DataSource = this.DtProvinciasBindinsource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridProvincias.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridProvincias.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridProvincias.Enabled = false;
            this.dataGridProvincias.Location = new System.Drawing.Point(0, 0);
            this.dataGridProvincias.MultiSelect = false;
            this.dataGridProvincias.Name = "dataGridProvincias";
            this.dataGridProvincias.ReadOnly = true;
            this.dataGridProvincias.RowHeadersVisible = false;
            this.dataGridProvincias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProvincias.Size = new System.Drawing.Size(1014, 257);
            this.dataGridProvincias.TabIndex = 74;
            // 
            // PaisTxt
            // 
            this.PaisTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtPaisesBindingSource, "PaisesPaises", true));
            this.PaisTxt.DataSource = this.dtPaisesBindingSource;
            this.PaisTxt.DisplayMember = "PaisesPaises";
            this.PaisTxt.FormattingEnabled = true;
            this.PaisTxt.Location = new System.Drawing.Point(570, 290);
            this.PaisTxt.Name = "PaisTxt";
            this.PaisTxt.Size = new System.Drawing.Size(330, 21);
            this.PaisTxt.TabIndex = 81;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 80F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ProvinciasProvincias";
            this.Column1.FillWeight = 300F;
            this.Column1.HeaderText = "Provincias";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // FormProvincias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 479);
            this.Controls.Add(this.PaisTxt);
            this.Controls.Add(Label4);
            this.Controls.Add(this.BtnGuardarProvincia);
            this.Controls.Add(this.PanelProvincias);
            this.Controls.Add(this.BtnCancelarProvincia);
            this.Controls.Add(this.BtnSalir_Provincias);
            this.Controls.Add(this.dataGridProvincias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProvincias";
            this.Text = "Provincias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormProvincias_FormClosing);
            this.Load += new System.EventHandler(this.FormProvincias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtProvinciasBindinsource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMulti2)).EndInit();
            this.PanelProvincias.ResumeLayout(false);
            this.PanelProvincias.PerformLayout();
            this.PanelBotones_Provincia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProvincias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button BtnGuardarProvincia;
        private System.Windows.Forms.TextBox ProvinciaText;
        private System.Windows.Forms.Panel PanelProvincias;
        private System.Windows.Forms.Label Id_Provincias;
        private System.Windows.Forms.Panel PanelBotones_Provincia;
        private System.Windows.Forms.Button BtnEliminarProvincia;
        private System.Windows.Forms.Button BtnBuscarProvincia;
        private System.Windows.Forms.Button BtnNuevoProvincia;
        private System.Windows.Forms.Button BtnModificarProvincia;
        private System.Windows.Forms.Button BtnCancelarProvincia;
        private System.Windows.Forms.Button BtnSalir_Provincias;
        private System.Windows.Forms.ErrorProvider ErrorProve;
        private System.Windows.Forms.DataGridView dataGridProvincias;
        private System.Windows.Forms.BindingSource DtProvinciasBindinsource;
        private DsMulti2 dsMulti2;
        private System.Windows.Forms.ComboBox PaisTxt;
        private System.Windows.Forms.BindingSource dtPaisesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}