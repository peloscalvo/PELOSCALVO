
namespace PELOSCALVO
{
    partial class FormProveedores
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
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProveedores));
            this.dtInicioMultiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMultidatos = new PELOSCALVO.DsMultidatos();
            this.dsCONFIGURACCION = new PELOSCALVO.DsCONFIGURACCION();
            this.dtConfiguracionPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DtProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PanelProveedores = new System.Windows.Forms.Panel();
            this.Id_proveedor = new System.Windows.Forms.Label();
            this.PanelBotones_pro = new System.Windows.Forms.Panel();
            this.BtnEliminarProveedor = new System.Windows.Forms.Button();
            this.BtnBuscarProveedor = new System.Windows.Forms.Button();
            this.BtnNuevoProveedor = new System.Windows.Forms.Button();
            this.BtnModificarProveedor = new System.Windows.Forms.Button();
            this.NombreProveedor = new System.Windows.Forms.TextBox();
            this.Enlace_Proveedor = new System.Windows.Forms.Label();
            this.EmpresaSelect = new System.Windows.Forms.ComboBox();
            this.dataGridProveedores = new System.Windows.Forms.DataGridView();
            this.BtnSalir_pro = new System.Windows.Forms.Button();
            this.BtnCancelarProve = new System.Windows.Forms.Button();
            this.BtnGuardarProve = new System.Windows.Forms.Button();
            this.ErrorProve = new System.Windows.Forms.ErrorProvider(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedoresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtProveedoresBindingSource)).BeginInit();
            this.PanelProveedores.SuspendLayout();
            this.PanelBotones_pro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProve)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(545, 324);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(19, 13);
            label9.TabIndex = 56;
            label9.Text = "Id:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(31, 20);
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
            label11.Size = new System.Drawing.Size(59, 13);
            label11.TabIndex = 55;
            label11.Text = "Proveedor:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(537, 347);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(51, 13);
            label6.TabIndex = 61;
            label6.Text = "Empresa:";
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
            // DtProveedoresBindingSource
            // 
            this.DtProveedoresBindingSource.AllowNew = false;
            this.DtProveedoresBindingSource.DataMember = "FK_DtConfiguracionPrincipal_DtProveedores";
            this.DtProveedoresBindingSource.DataSource = this.dtConfiguracionPrincipalBindingSource;
            // 
            // PanelProveedores
            // 
            this.PanelProveedores.Controls.Add(this.Id_proveedor);
            this.PanelProveedores.Controls.Add(this.PanelBotones_pro);
            this.PanelProveedores.Controls.Add(label10);
            this.PanelProveedores.Controls.Add(label11);
            this.PanelProveedores.Controls.Add(this.NombreProveedor);
            this.PanelProveedores.Location = new System.Drawing.Point(32, 304);
            this.PanelProveedores.Name = "PanelProveedores";
            this.PanelProveedores.Size = new System.Drawing.Size(478, 172);
            this.PanelProveedores.TabIndex = 63;
            // 
            // Id_proveedor
            // 
            this.Id_proveedor.AutoSize = true;
            this.Id_proveedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DtProveedoresBindingSource, "Id", true));
            this.Id_proveedor.Location = new System.Drawing.Point(74, 14);
            this.Id_proveedor.Name = "Id_proveedor";
            this.Id_proveedor.Size = new System.Drawing.Size(13, 13);
            this.Id_proveedor.TabIndex = 58;
            this.Id_proveedor.Text = "1";
            this.Id_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PanelBotones_pro
            // 
            this.PanelBotones_pro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelBotones_pro.BackColor = System.Drawing.Color.Transparent;
            this.PanelBotones_pro.Controls.Add(this.BtnEliminarProveedor);
            this.PanelBotones_pro.Controls.Add(this.BtnBuscarProveedor);
            this.PanelBotones_pro.Controls.Add(this.BtnNuevoProveedor);
            this.PanelBotones_pro.Controls.Add(this.BtnModificarProveedor);
            this.PanelBotones_pro.Location = new System.Drawing.Point(9, 99);
            this.PanelBotones_pro.Name = "PanelBotones_pro";
            this.PanelBotones_pro.Size = new System.Drawing.Size(396, 63);
            this.PanelBotones_pro.TabIndex = 54;
            this.PanelBotones_pro.Tag = "NO";
            // 
            // BtnEliminarProveedor
            // 
            this.BtnEliminarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarProveedor.FlatAppearance.BorderSize = 0;
            this.BtnEliminarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnEliminarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnEliminarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarProveedor.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarProveedor.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_trash_can_17_32;
            this.BtnEliminarProveedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminarProveedor.Location = new System.Drawing.Point(238, 3);
            this.BtnEliminarProveedor.Name = "BtnEliminarProveedor";
            this.BtnEliminarProveedor.Size = new System.Drawing.Size(77, 63);
            this.BtnEliminarProveedor.TabIndex = 9;
            this.BtnEliminarProveedor.Text = "Eliminar";
            this.BtnEliminarProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminarProveedor.UseVisualStyleBackColor = false;
            this.BtnEliminarProveedor.Click += new System.EventHandler(this.BtnEliminarProveedor_Click);
            // 
            // BtnBuscarProveedor
            // 
            this.BtnBuscarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscarProveedor.FlatAppearance.BorderSize = 0;
            this.BtnBuscarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnBuscarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarProveedor.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarProveedor.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_magnifier_4_32;
            this.BtnBuscarProveedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscarProveedor.Location = new System.Drawing.Point(161, 3);
            this.BtnBuscarProveedor.Name = "BtnBuscarProveedor";
            this.BtnBuscarProveedor.Size = new System.Drawing.Size(77, 63);
            this.BtnBuscarProveedor.TabIndex = 8;
            this.BtnBuscarProveedor.Text = "Buscar";
            this.BtnBuscarProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscarProveedor.UseVisualStyleBackColor = false;
            this.BtnBuscarProveedor.Click += new System.EventHandler(this.BtnBuscarProveedor_Click);
            // 
            // BtnNuevoProveedor
            // 
            this.BtnNuevoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNuevoProveedor.BackColor = System.Drawing.Color.Transparent;
            this.BtnNuevoProveedor.FlatAppearance.BorderSize = 0;
            this.BtnNuevoProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnNuevoProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnNuevoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoProveedor.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoProveedor.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_file_14_32;
            this.BtnNuevoProveedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevoProveedor.Location = new System.Drawing.Point(7, 3);
            this.BtnNuevoProveedor.Name = "BtnNuevoProveedor";
            this.BtnNuevoProveedor.Size = new System.Drawing.Size(77, 63);
            this.BtnNuevoProveedor.TabIndex = 6;
            this.BtnNuevoProveedor.Tag = "stop";
            this.BtnNuevoProveedor.Text = "Nuevo";
            this.BtnNuevoProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNuevoProveedor.UseVisualStyleBackColor = false;
            this.BtnNuevoProveedor.Click += new System.EventHandler(this.BtnNuevoProveedor_Click);
            // 
            // BtnModificarProveedor
            // 
            this.BtnModificarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModificarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificarProveedor.FlatAppearance.BorderSize = 0;
            this.BtnModificarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnModificarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnModificarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarProveedor.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarProveedor.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_pen_8_32;
            this.BtnModificarProveedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnModificarProveedor.Location = new System.Drawing.Point(84, 3);
            this.BtnModificarProveedor.Name = "BtnModificarProveedor";
            this.BtnModificarProveedor.Size = new System.Drawing.Size(77, 63);
            this.BtnModificarProveedor.TabIndex = 7;
            this.BtnModificarProveedor.Text = "Modificar";
            this.BtnModificarProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificarProveedor.UseVisualStyleBackColor = false;
            this.BtnModificarProveedor.Click += new System.EventHandler(this.BtnModificarProveedor_Click);
            // 
            // NombreProveedor
            // 
            this.NombreProveedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DtProveedoresBindingSource, "Proveedores", true));
            this.NombreProveedor.Location = new System.Drawing.Point(74, 43);
            this.NombreProveedor.MaxLength = 40;
            this.NombreProveedor.Name = "NombreProveedor";
            this.NombreProveedor.ReadOnly = true;
            this.NombreProveedor.Size = new System.Drawing.Size(385, 20);
            this.NombreProveedor.TabIndex = 56;
            // 
            // Enlace_Proveedor
            // 
            this.Enlace_Proveedor.AutoSize = true;
            this.Enlace_Proveedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtConfiguracionPrincipalBindingSource, "IdEmpresa", true));
            this.Enlace_Proveedor.Location = new System.Drawing.Point(597, 324);
            this.Enlace_Proveedor.Name = "Enlace_Proveedor";
            this.Enlace_Proveedor.Size = new System.Drawing.Size(0, 13);
            this.Enlace_Proveedor.TabIndex = 59;
            // 
            // EmpresaSelect
            // 
            this.EmpresaSelect.DataSource = this.dtConfiguracionPrincipalBindingSource;
            this.EmpresaSelect.DisplayMember = "EmpresaConfi";
            this.EmpresaSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpresaSelect.FormattingEnabled = true;
            this.EmpresaSelect.Location = new System.Drawing.Point(594, 344);
            this.EmpresaSelect.Name = "EmpresaSelect";
            this.EmpresaSelect.Size = new System.Drawing.Size(346, 21);
            this.EmpresaSelect.TabIndex = 62;
            // 
            // dataGridProveedores
            // 
            this.dataGridProveedores.AllowDrop = true;
            this.dataGridProveedores.AllowUserToAddRows = false;
            this.dataGridProveedores.AutoGenerateColumns = false;
            this.dataGridProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProveedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(140)))));
            this.dataGridProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridProveedores.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.proveedoresDataGridViewTextBoxColumn});
            this.dataGridProveedores.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.DtProveedoresBindingSource, "Id_Proveedores", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.dataGridProveedores.DataSource = this.DtProveedoresBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridProveedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridProveedores.Location = new System.Drawing.Point(0, 0);
            this.dataGridProveedores.MultiSelect = false;
            this.dataGridProveedores.Name = "dataGridProveedores";
            this.dataGridProveedores.ReadOnly = true;
            this.dataGridProveedores.RowHeadersVisible = false;
            this.dataGridProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProveedores.Size = new System.Drawing.Size(952, 282);
            this.dataGridProveedores.TabIndex = 60;
            // 
            // BtnSalir_pro
            // 
            this.BtnSalir_pro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir_pro.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalir_pro.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalir_pro.FlatAppearance.BorderSize = 0;
            this.BtnSalir_pro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnSalir_pro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnSalir_pro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir_pro.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir_pro.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_door_5_32;
            this.BtnSalir_pro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalir_pro.Location = new System.Drawing.Point(853, 413);
            this.BtnSalir_pro.Name = "BtnSalir_pro";
            this.BtnSalir_pro.Size = new System.Drawing.Size(77, 63);
            this.BtnSalir_pro.TabIndex = 64;
            this.BtnSalir_pro.Text = "Salir";
            this.BtnSalir_pro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalir_pro.UseVisualStyleBackColor = false;
            this.BtnSalir_pro.Click += new System.EventHandler(this.BtnSalir_pro_Click);
            // 
            // BtnCancelarProve
            // 
            this.BtnCancelarProve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelarProve.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelarProve.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelarProve.Enabled = false;
            this.BtnCancelarProve.FlatAppearance.BorderSize = 0;
            this.BtnCancelarProve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancelarProve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnCancelarProve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarProve.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarProve.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_x_mark_8_24;
            this.BtnCancelarProve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarProve.Location = new System.Drawing.Point(718, 424);
            this.BtnCancelarProve.Name = "BtnCancelarProve";
            this.BtnCancelarProve.Size = new System.Drawing.Size(89, 42);
            this.BtnCancelarProve.TabIndex = 66;
            this.BtnCancelarProve.Text = "Cancelar";
            this.BtnCancelarProve.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelarProve.UseVisualStyleBackColor = false;
            this.BtnCancelarProve.Click += new System.EventHandler(this.BtnCancelarProve_Click);
            // 
            // BtnGuardarProve
            // 
            this.BtnGuardarProve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarProve.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarProve.Enabled = false;
            this.BtnGuardarProve.FlatAppearance.BorderSize = 0;
            this.BtnGuardarProve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnGuardarProve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnGuardarProve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarProve.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarProve.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_check_mark_9_24;
            this.BtnGuardarProve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarProve.Location = new System.Drawing.Point(563, 424);
            this.BtnGuardarProve.Name = "BtnGuardarProve";
            this.BtnGuardarProve.Size = new System.Drawing.Size(89, 42);
            this.BtnGuardarProve.TabIndex = 65;
            this.BtnGuardarProve.Text = "Aceptar";
            this.BtnGuardarProve.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarProve.UseVisualStyleBackColor = false;
            this.BtnGuardarProve.Click += new System.EventHandler(this.BtnGuardarProve_Click);
            // 
            // ErrorProve
            // 
            this.ErrorProve.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.ErrorProve.ContainerControl = this;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 150F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proveedoresDataGridViewTextBoxColumn
            // 
            this.proveedoresDataGridViewTextBoxColumn.DataPropertyName = "Proveedores";
            this.proveedoresDataGridViewTextBoxColumn.FillWeight = 350F;
            this.proveedoresDataGridViewTextBoxColumn.HeaderText = "Proveedores";
            this.proveedoresDataGridViewTextBoxColumn.Name = "proveedoresDataGridViewTextBoxColumn";
            this.proveedoresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 497);
            this.Controls.Add(this.Enlace_Proveedor);
            this.Controls.Add(this.BtnCancelarProve);
            this.Controls.Add(this.BtnGuardarProve);
            this.Controls.Add(label9);
            this.Controls.Add(this.BtnSalir_pro);
            this.Controls.Add(this.PanelProveedores);
            this.Controls.Add(label6);
            this.Controls.Add(this.EmpresaSelect);
            this.Controls.Add(this.dataGridProveedores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(968, 536);
            this.Name = "FormProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Proveedores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormProveedores_FormClosing);
            this.Load += new System.EventHandler(this.FormProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtProveedoresBindingSource)).EndInit();
            this.PanelProveedores.ResumeLayout(false);
            this.PanelProveedores.PerformLayout();
            this.PanelBotones_pro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource dtInicioMultiBindingSource;
        private DsMultidatos dsMultidatos;
        private DsCONFIGURACCION dsCONFIGURACCION;
        private System.Windows.Forms.BindingSource dtConfiguracionPrincipalBindingSource;
        private System.Windows.Forms.BindingSource DtProveedoresBindingSource;
        private System.Windows.Forms.Panel PanelProveedores;
        private System.Windows.Forms.Label Enlace_Proveedor;
        private System.Windows.Forms.Label Id_proveedor;
        private System.Windows.Forms.Panel PanelBotones_pro;
        private System.Windows.Forms.Button BtnEliminarProveedor;
        private System.Windows.Forms.Button BtnBuscarProveedor;
        private System.Windows.Forms.Button BtnNuevoProveedor;
        private System.Windows.Forms.Button BtnModificarProveedor;
        private System.Windows.Forms.TextBox NombreProveedor;
        private System.Windows.Forms.ComboBox EmpresaSelect;
        private System.Windows.Forms.Button BtnSalir_pro;
        private System.Windows.Forms.Button BtnCancelarProve;
        public System.Windows.Forms.Button BtnGuardarProve;
        private System.Windows.Forms.ErrorProvider ErrorProve;
        public System.Windows.Forms.DataGridView dataGridProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedoresDataGridViewTextBoxColumn;
    }
}