
namespace PELOSCALVO
{
    partial class FormAlmacenes
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
            System.Windows.Forms.Label id_almacenesLabel;
            System.Windows.Forms.Label almacenesLabel;
            System.Windows.Forms.Label enlace_AlmacenesLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlmacenes));
            this.dtConfiguracionPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCONFIGURACCION = new PELOSCALVO.DsCONFIGURACCION();
            this.dsMultidatos = new PELOSCALVO.DsMultidatos();
            this.errorProvider1Confi = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtInicioMultiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtAlmacenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelAlmacenes = new System.Windows.Forms.Panel();
            this.id_almacenes = new System.Windows.Forms.Label();
            this.BotonesAlmacenes = new System.Windows.Forms.Panel();
            this.BtnEliminarAlmacen = new System.Windows.Forms.Button();
            this.BtnBuscarAlmacen = new System.Windows.Forms.Button();
            this.BtnNuevoAlmacen = new System.Windows.Forms.Button();
            this.BtnModificarAlmacen = new System.Windows.Forms.Button();
            this.almacenesTextBox = new System.Windows.Forms.TextBox();
            this.IdEmpresaAlm = new System.Windows.Forms.Label();
            this.SelecionarEmpresa2 = new System.Windows.Forms.ComboBox();
            this.dataGridAlmacenes = new System.Windows.Forms.DataGridView();
            this.idalmacenesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.almacenesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enlace_Almacenes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCancelarAlmacen = new System.Windows.Forms.Button();
            this.BtnGuardarAlmacen = new System.Windows.Forms.Button();
            this.BtnSalirAlmacen = new System.Windows.Forms.Button();
            id_almacenesLabel = new System.Windows.Forms.Label();
            almacenesLabel = new System.Windows.Forms.Label();
            enlace_AlmacenesLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1Confi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlmacenesBindingSource)).BeginInit();
            this.panelAlmacenes.SuspendLayout();
            this.BotonesAlmacenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlmacenes)).BeginInit();
            this.SuspendLayout();
            // 
            // id_almacenesLabel
            // 
            id_almacenesLabel.AutoSize = true;
            id_almacenesLabel.Location = new System.Drawing.Point(31, 14);
            id_almacenesLabel.Name = "id_almacenesLabel";
            id_almacenesLabel.Size = new System.Drawing.Size(19, 13);
            id_almacenesLabel.TabIndex = 54;
            id_almacenesLabel.Text = "Id:";
            // 
            // almacenesLabel
            // 
            almacenesLabel.AutoSize = true;
            almacenesLabel.Location = new System.Drawing.Point(6, 46);
            almacenesLabel.Name = "almacenesLabel";
            almacenesLabel.Size = new System.Drawing.Size(51, 13);
            almacenesLabel.TabIndex = 55;
            almacenesLabel.Text = "Almacen:";
            // 
            // enlace_AlmacenesLabel
            // 
            enlace_AlmacenesLabel.AutoSize = true;
            enlace_AlmacenesLabel.Location = new System.Drawing.Point(513, 321);
            enlace_AlmacenesLabel.Name = "enlace_AlmacenesLabel";
            enlace_AlmacenesLabel.Size = new System.Drawing.Size(51, 13);
            enlace_AlmacenesLabel.TabIndex = 60;
            enlace_AlmacenesLabel.Text = "Empresa:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(545, 351);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(19, 13);
            label1.TabIndex = 122;
            label1.Text = "Id:";
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
            // dsMultidatos
            // 
            this.dsMultidatos.DataSetName = "DsMultidatos";
            this.dsMultidatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProvider1Confi
            // 
            this.errorProvider1Confi.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1Confi.ContainerControl = this;
            // 
            // dtInicioMultiBindingSource
            // 
            this.dtInicioMultiBindingSource.DataMember = "DtInicioMulti";
            this.dtInicioMultiBindingSource.DataSource = this.dsMultidatos;
            // 
            // dtAlmacenesBindingSource
            // 
            this.dtAlmacenesBindingSource.DataMember = "FK_DtConfiguracionPrincipal_DtAlmacenes";
            this.dtAlmacenesBindingSource.DataSource = this.dtConfiguracionPrincipalBindingSource;
            // 
            // panelAlmacenes
            // 
            this.panelAlmacenes.Controls.Add(this.id_almacenes);
            this.panelAlmacenes.Controls.Add(this.BotonesAlmacenes);
            this.panelAlmacenes.Controls.Add(id_almacenesLabel);
            this.panelAlmacenes.Controls.Add(almacenesLabel);
            this.panelAlmacenes.Controls.Add(this.almacenesTextBox);
            this.panelAlmacenes.Location = new System.Drawing.Point(12, 308);
            this.panelAlmacenes.Name = "panelAlmacenes";
            this.panelAlmacenes.Size = new System.Drawing.Size(478, 178);
            this.panelAlmacenes.TabIndex = 62;
            this.panelAlmacenes.Tag = "NO";
            // 
            // id_almacenes
            // 
            this.id_almacenes.AutoSize = true;
            this.id_almacenes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtAlmacenesBindingSource, "Id", true));
            this.id_almacenes.Location = new System.Drawing.Point(74, 14);
            this.id_almacenes.Name = "id_almacenes";
            this.id_almacenes.Size = new System.Drawing.Size(13, 13);
            this.id_almacenes.TabIndex = 58;
            this.id_almacenes.Text = "1";
            this.id_almacenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BotonesAlmacenes
            // 
            this.BotonesAlmacenes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BotonesAlmacenes.BackColor = System.Drawing.Color.Transparent;
            this.BotonesAlmacenes.Controls.Add(this.BtnEliminarAlmacen);
            this.BotonesAlmacenes.Controls.Add(this.BtnBuscarAlmacen);
            this.BotonesAlmacenes.Controls.Add(this.BtnNuevoAlmacen);
            this.BotonesAlmacenes.Controls.Add(this.BtnModificarAlmacen);
            this.BotonesAlmacenes.Location = new System.Drawing.Point(9, 105);
            this.BotonesAlmacenes.Name = "BotonesAlmacenes";
            this.BotonesAlmacenes.Size = new System.Drawing.Size(396, 63);
            this.BotonesAlmacenes.TabIndex = 54;
            // 
            // BtnEliminarAlmacen
            // 
            this.BtnEliminarAlmacen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminarAlmacen.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarAlmacen.FlatAppearance.BorderSize = 0;
            this.BtnEliminarAlmacen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnEliminarAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnEliminarAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarAlmacen.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarAlmacen.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_trash_can_17_32;
            this.BtnEliminarAlmacen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminarAlmacen.Location = new System.Drawing.Point(238, 3);
            this.BtnEliminarAlmacen.Name = "BtnEliminarAlmacen";
            this.BtnEliminarAlmacen.Size = new System.Drawing.Size(77, 63);
            this.BtnEliminarAlmacen.TabIndex = 9;
            this.BtnEliminarAlmacen.Text = "Eliminar";
            this.BtnEliminarAlmacen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminarAlmacen.UseVisualStyleBackColor = false;
            this.BtnEliminarAlmacen.Click += new System.EventHandler(this.BtnEliminarAlmacen_Click);
            // 
            // BtnBuscarAlmacen
            // 
            this.BtnBuscarAlmacen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarAlmacen.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscarAlmacen.FlatAppearance.BorderSize = 0;
            this.BtnBuscarAlmacen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnBuscarAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnBuscarAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarAlmacen.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarAlmacen.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_magnifier_4_32;
            this.BtnBuscarAlmacen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscarAlmacen.Location = new System.Drawing.Point(161, 3);
            this.BtnBuscarAlmacen.Name = "BtnBuscarAlmacen";
            this.BtnBuscarAlmacen.Size = new System.Drawing.Size(77, 63);
            this.BtnBuscarAlmacen.TabIndex = 8;
            this.BtnBuscarAlmacen.Text = "Buscar";
            this.BtnBuscarAlmacen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscarAlmacen.UseVisualStyleBackColor = false;
            this.BtnBuscarAlmacen.Click += new System.EventHandler(this.BtnBuscarAlmacen_Click);
            // 
            // BtnNuevoAlmacen
            // 
            this.BtnNuevoAlmacen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNuevoAlmacen.BackColor = System.Drawing.Color.Transparent;
            this.BtnNuevoAlmacen.FlatAppearance.BorderSize = 0;
            this.BtnNuevoAlmacen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnNuevoAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnNuevoAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoAlmacen.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoAlmacen.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_file_14_32;
            this.BtnNuevoAlmacen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevoAlmacen.Location = new System.Drawing.Point(7, 3);
            this.BtnNuevoAlmacen.Name = "BtnNuevoAlmacen";
            this.BtnNuevoAlmacen.Size = new System.Drawing.Size(77, 63);
            this.BtnNuevoAlmacen.TabIndex = 6;
            this.BtnNuevoAlmacen.Tag = "stop";
            this.BtnNuevoAlmacen.Text = "Nuevo";
            this.BtnNuevoAlmacen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNuevoAlmacen.UseVisualStyleBackColor = false;
            this.BtnNuevoAlmacen.Click += new System.EventHandler(this.BtnNuevoAlmacen_Click);
            // 
            // BtnModificarAlmacen
            // 
            this.BtnModificarAlmacen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModificarAlmacen.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificarAlmacen.FlatAppearance.BorderSize = 0;
            this.BtnModificarAlmacen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnModificarAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnModificarAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarAlmacen.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarAlmacen.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_pen_8_32;
            this.BtnModificarAlmacen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnModificarAlmacen.Location = new System.Drawing.Point(84, 3);
            this.BtnModificarAlmacen.Name = "BtnModificarAlmacen";
            this.BtnModificarAlmacen.Size = new System.Drawing.Size(77, 63);
            this.BtnModificarAlmacen.TabIndex = 7;
            this.BtnModificarAlmacen.Text = "Modificar";
            this.BtnModificarAlmacen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificarAlmacen.UseVisualStyleBackColor = false;
            this.BtnModificarAlmacen.Click += new System.EventHandler(this.BtnModificarAlmacen_Click);
            // 
            // almacenesTextBox
            // 
            this.almacenesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtAlmacenesBindingSource, "Almacenes", true));
            this.almacenesTextBox.Location = new System.Drawing.Point(74, 43);
            this.almacenesTextBox.Name = "almacenesTextBox";
            this.almacenesTextBox.ReadOnly = true;
            this.almacenesTextBox.Size = new System.Drawing.Size(374, 20);
            this.almacenesTextBox.TabIndex = 56;
            // 
            // IdEmpresaAlm
            // 
            this.IdEmpresaAlm.AutoSize = true;
            this.IdEmpresaAlm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtConfiguracionPrincipalBindingSource, "IdEmpresa", true));
            this.IdEmpresaAlm.Location = new System.Drawing.Point(586, 351);
            this.IdEmpresaAlm.Name = "IdEmpresaAlm";
            this.IdEmpresaAlm.Size = new System.Drawing.Size(0, 13);
            this.IdEmpresaAlm.TabIndex = 59;
            // 
            // SelecionarEmpresa2
            // 
            this.SelecionarEmpresa2.DataSource = this.dtConfiguracionPrincipalBindingSource;
            this.SelecionarEmpresa2.DisplayMember = "EmpresaConfi";
            this.SelecionarEmpresa2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelecionarEmpresa2.FormattingEnabled = true;
            this.SelecionarEmpresa2.Location = new System.Drawing.Point(580, 318);
            this.SelecionarEmpresa2.Name = "SelecionarEmpresa2";
            this.SelecionarEmpresa2.Size = new System.Drawing.Size(294, 21);
            this.SelecionarEmpresa2.TabIndex = 61;
            // 
            // dataGridAlmacenes
            // 
            this.dataGridAlmacenes.AllowDrop = true;
            this.dataGridAlmacenes.AllowUserToAddRows = false;
            this.dataGridAlmacenes.AllowUserToDeleteRows = false;
            this.dataGridAlmacenes.AllowUserToResizeRows = false;
            this.dataGridAlmacenes.AutoGenerateColumns = false;
            this.dataGridAlmacenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAlmacenes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(102)))));
            this.dataGridAlmacenes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridAlmacenes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAlmacenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAlmacenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlmacenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idalmacenesDataGridViewTextBoxColumn,
            this.almacenesDataGridViewTextBoxColumn,
            this.Enlace_Almacenes});
            this.dataGridAlmacenes.DataSource = this.dtAlmacenesBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAlmacenes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridAlmacenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridAlmacenes.Enabled = false;
            this.dataGridAlmacenes.Location = new System.Drawing.Point(0, 0);
            this.dataGridAlmacenes.MultiSelect = false;
            this.dataGridAlmacenes.Name = "dataGridAlmacenes";
            this.dataGridAlmacenes.ReadOnly = true;
            this.dataGridAlmacenes.RowHeadersVisible = false;
            this.dataGridAlmacenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAlmacenes.Size = new System.Drawing.Size(967, 261);
            this.dataGridAlmacenes.TabIndex = 59;
            // 
            // idalmacenesDataGridViewTextBoxColumn
            // 
            this.idalmacenesDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.idalmacenesDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idalmacenesDataGridViewTextBoxColumn.FillWeight = 90.06917F;
            this.idalmacenesDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idalmacenesDataGridViewTextBoxColumn.MaxInputLength = 0;
            this.idalmacenesDataGridViewTextBoxColumn.Name = "idalmacenesDataGridViewTextBoxColumn";
            this.idalmacenesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // almacenesDataGridViewTextBoxColumn
            // 
            this.almacenesDataGridViewTextBoxColumn.DataPropertyName = "Almacenes";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.almacenesDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.almacenesDataGridViewTextBoxColumn.FillWeight = 306.934F;
            this.almacenesDataGridViewTextBoxColumn.HeaderText = "Almacenes";
            this.almacenesDataGridViewTextBoxColumn.MaxInputLength = 80;
            this.almacenesDataGridViewTextBoxColumn.Name = "almacenesDataGridViewTextBoxColumn";
            this.almacenesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Enlace_Almacenes
            // 
            this.Enlace_Almacenes.DataPropertyName = "Enlace_Almacenes";
            this.Enlace_Almacenes.FillWeight = 40.23725F;
            this.Enlace_Almacenes.HeaderText = "Enlace";
            this.Enlace_Almacenes.Name = "Enlace_Almacenes";
            this.Enlace_Almacenes.ReadOnly = true;
            this.Enlace_Almacenes.Visible = false;
            // 
            // BtnCancelarAlmacen
            // 
            this.BtnCancelarAlmacen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelarAlmacen.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelarAlmacen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelarAlmacen.Enabled = false;
            this.BtnCancelarAlmacen.FlatAppearance.BorderSize = 0;
            this.BtnCancelarAlmacen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancelarAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnCancelarAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarAlmacen.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarAlmacen.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_x_mark_8_24;
            this.BtnCancelarAlmacen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarAlmacen.Location = new System.Drawing.Point(714, 447);
            this.BtnCancelarAlmacen.Name = "BtnCancelarAlmacen";
            this.BtnCancelarAlmacen.Size = new System.Drawing.Size(89, 42);
            this.BtnCancelarAlmacen.TabIndex = 84;
            this.BtnCancelarAlmacen.Text = "Cancelar";
            this.BtnCancelarAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelarAlmacen.UseVisualStyleBackColor = false;
            this.BtnCancelarAlmacen.Click += new System.EventHandler(this.BtnCancelarAlmacen_Click);
            // 
            // BtnGuardarAlmacen
            // 
            this.BtnGuardarAlmacen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarAlmacen.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarAlmacen.Enabled = false;
            this.BtnGuardarAlmacen.FlatAppearance.BorderSize = 0;
            this.BtnGuardarAlmacen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnGuardarAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnGuardarAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarAlmacen.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarAlmacen.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_check_mark_9_24;
            this.BtnGuardarAlmacen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarAlmacen.Location = new System.Drawing.Point(580, 447);
            this.BtnGuardarAlmacen.Name = "BtnGuardarAlmacen";
            this.BtnGuardarAlmacen.Size = new System.Drawing.Size(89, 42);
            this.BtnGuardarAlmacen.TabIndex = 83;
            this.BtnGuardarAlmacen.Text = "Aceptar";
            this.BtnGuardarAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarAlmacen.UseVisualStyleBackColor = false;
            this.BtnGuardarAlmacen.Click += new System.EventHandler(this.BtnGuardarAlmacen_Click);
            // 
            // BtnSalirAlmacen
            // 
            this.BtnSalirAlmacen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalirAlmacen.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalirAlmacen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalirAlmacen.FlatAppearance.BorderSize = 0;
            this.BtnSalirAlmacen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnSalirAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnSalirAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalirAlmacen.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirAlmacen.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_door_5_32;
            this.BtnSalirAlmacen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalirAlmacen.Location = new System.Drawing.Point(858, 423);
            this.BtnSalirAlmacen.Name = "BtnSalirAlmacen";
            this.BtnSalirAlmacen.Size = new System.Drawing.Size(77, 63);
            this.BtnSalirAlmacen.TabIndex = 121;
            this.BtnSalirAlmacen.Text = "Salir";
            this.BtnSalirAlmacen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalirAlmacen.UseVisualStyleBackColor = false;
            this.BtnSalirAlmacen.Click += new System.EventHandler(this.BtnSalirAlmacen_Click);
            // 
            // FormAlmacenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 508);
            this.Controls.Add(label1);
            this.Controls.Add(this.IdEmpresaAlm);
            this.Controls.Add(this.BtnSalirAlmacen);
            this.Controls.Add(this.BtnCancelarAlmacen);
            this.Controls.Add(this.BtnGuardarAlmacen);
            this.Controls.Add(this.panelAlmacenes);
            this.Controls.Add(enlace_AlmacenesLabel);
            this.Controls.Add(this.SelecionarEmpresa2);
            this.Controls.Add(this.dataGridAlmacenes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlmacenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Almacenes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAlmacenes_FormClosing);
            this.Load += new System.EventHandler(this.FormAlmacenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1Confi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlmacenesBindingSource)).EndInit();
            this.panelAlmacenes.ResumeLayout(false);
            this.panelAlmacenes.PerformLayout();
            this.BotonesAlmacenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlmacenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource dtConfiguracionPrincipalBindingSource;
        private DsCONFIGURACCION dsCONFIGURACCION;
        private DsMultidatos dsMultidatos;
        private System.Windows.Forms.ErrorProvider errorProvider1Confi;
        private System.Windows.Forms.BindingSource dtInicioMultiBindingSource;
        private System.Windows.Forms.BindingSource dtAlmacenesBindingSource;
        private System.Windows.Forms.Panel panelAlmacenes;
        private System.Windows.Forms.Label IdEmpresaAlm;
        private System.Windows.Forms.Label id_almacenes;
        private System.Windows.Forms.Panel BotonesAlmacenes;
        private System.Windows.Forms.Button BtnEliminarAlmacen;
        private System.Windows.Forms.Button BtnBuscarAlmacen;
        private System.Windows.Forms.Button BtnNuevoAlmacen;
        private System.Windows.Forms.Button BtnModificarAlmacen;
        private System.Windows.Forms.TextBox almacenesTextBox;
        private System.Windows.Forms.ComboBox SelecionarEmpresa2;
        private System.Windows.Forms.Button BtnCancelarAlmacen;
        public System.Windows.Forms.Button BtnGuardarAlmacen;
        private System.Windows.Forms.Button BtnSalirAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalmacenesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn almacenesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enlace_Almacenes;
        public System.Windows.Forms.DataGridView dataGridAlmacenes;
    }
}