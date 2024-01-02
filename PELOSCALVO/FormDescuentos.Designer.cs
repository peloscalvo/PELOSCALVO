
namespace PELOSCALVO
{
    partial class FormDescuentos
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
            System.Windows.Forms.Label idTarifaLabel;
            System.Windows.Forms.Label tarifaTipoLabel;
            System.Windows.Forms.Label Label4;
            System.Windows.Forms.Label ConfiLabel1;
            System.Windows.Forms.Label idEmpresaLabel1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDescuentos));
            this.dsCONFIGURACCION = new PELOSCALVO.DsCONFIGURACCION();
            this.dtConfiguracionPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EnlaceTarifa = new System.Windows.Forms.Label();
            this.dtConfiDtTarifaTipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IdEmpresa = new System.Windows.Forms.Label();
            this.IdTarifa = new System.Windows.Forms.Label();
            this.dtTarifaTipoDataGridView = new System.Windows.Forms.DataGridView();
            this.idTarifaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifaTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enlaceTarifaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifaTipoTextBox = new System.Windows.Forms.TextBox();
            this.empresaConfiComboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnCancelarTipoTarifa = new System.Windows.Forms.Button();
            this.BtnGuardarDescuentos = new System.Windows.Forms.Button();
            this.panelBotonesTipoTarifa = new System.Windows.Forms.Panel();
            this.BtnNuevoTipoTarifa = new System.Windows.Forms.Button();
            this.BtnModificarTipoTarifa = new System.Windows.Forms.Button();
            this.BtnSalirTipoTarifa = new System.Windows.Forms.Button();
            this.ErrorDescuentos = new System.Windows.Forms.ErrorProvider(this.components);
            idTarifaLabel = new System.Windows.Forms.Label();
            tarifaTipoLabel = new System.Windows.Forms.Label();
            Label4 = new System.Windows.Forms.Label();
            ConfiLabel1 = new System.Windows.Forms.Label();
            idEmpresaLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiDtTarifaTipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarifaTipoDataGridView)).BeginInit();
            this.panelBotonesTipoTarifa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDescuentos)).BeginInit();
            this.SuspendLayout();
            // 
            // idTarifaLabel
            // 
            idTarifaLabel.AutoSize = true;
            idTarifaLabel.Location = new System.Drawing.Point(53, 292);
            idTarifaLabel.Name = "idTarifaLabel";
            idTarifaLabel.Size = new System.Drawing.Size(19, 13);
            idTarifaLabel.TabIndex = 58;
            idTarifaLabel.Text = "Id:";
            // 
            // tarifaTipoLabel
            // 
            tarifaTipoLabel.AutoSize = true;
            tarifaTipoLabel.Location = new System.Drawing.Point(11, 355);
            tarifaTipoLabel.Name = "tarifaTipoLabel";
            tarifaTipoLabel.Size = new System.Drawing.Size(61, 13);
            tarifaTipoLabel.TabIndex = 59;
            tarifaTipoLabel.Text = "Tarifa Tipo:";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new System.Drawing.Point(21, 319);
            Label4.Name = "Label4";
            Label4.Size = new System.Drawing.Size(43, 13);
            Label4.TabIndex = 61;
            Label4.Text = "Enlace:";
            // 
            // ConfiLabel1
            // 
            ConfiLabel1.AutoSize = true;
            ConfiLabel1.Location = new System.Drawing.Point(456, 304);
            ConfiLabel1.Name = "ConfiLabel1";
            ConfiLabel1.Size = new System.Drawing.Size(54, 13);
            ConfiLabel1.TabIndex = 55;
            ConfiLabel1.Text = "Empresa::";
            // 
            // idEmpresaLabel1
            // 
            idEmpresaLabel1.AutoSize = true;
            idEmpresaLabel1.Location = new System.Drawing.Point(491, 331);
            idEmpresaLabel1.Name = "idEmpresaLabel1";
            idEmpresaLabel1.Size = new System.Drawing.Size(19, 13);
            idEmpresaLabel1.TabIndex = 57;
            idEmpresaLabel1.Text = "Id:";
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
            // EnlaceTarifa
            // 
            this.EnlaceTarifa.AutoSize = true;
            this.EnlaceTarifa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtConfiguracionPrincipalBindingSource, "NombreEmpresaReguistro", true));
            this.EnlaceTarifa.Location = new System.Drawing.Point(78, 319);
            this.EnlaceTarifa.Name = "EnlaceTarifa";
            this.EnlaceTarifa.Size = new System.Drawing.Size(0, 13);
            this.EnlaceTarifa.TabIndex = 65;
            this.EnlaceTarifa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtConfiDtTarifaTipoBindingSource
            // 
            this.dtConfiDtTarifaTipoBindingSource.DataMember = "FK_DtConfiguracionPrincipal_DtTarifaTipo";
            this.dtConfiDtTarifaTipoBindingSource.DataSource = this.dtConfiguracionPrincipalBindingSource;
            // 
            // IdEmpresa
            // 
            this.IdEmpresa.AutoSize = true;
            this.IdEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtConfiguracionPrincipalBindingSource, "IdEmpresa", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.IdEmpresa.Location = new System.Drawing.Point(526, 331);
            this.IdEmpresa.Name = "IdEmpresa";
            this.IdEmpresa.Size = new System.Drawing.Size(15, 15);
            this.IdEmpresa.TabIndex = 64;
            this.IdEmpresa.Text = "1";
            this.IdEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IdTarifa
            // 
            this.IdTarifa.AutoSize = true;
            this.IdTarifa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdTarifa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtConfiDtTarifaTipoBindingSource, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.IdTarifa.Location = new System.Drawing.Point(78, 289);
            this.IdTarifa.Name = "IdTarifa";
            this.IdTarifa.Size = new System.Drawing.Size(15, 15);
            this.IdTarifa.TabIndex = 63;
            this.IdTarifa.Text = "1";
            this.IdTarifa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.idTarifaDataGridViewTextBoxColumn,
            this.tarifaTipoDataGridViewTextBoxColumn,
            this.enlaceTarifaDataGridViewTextBoxColumn});
            this.dtTarifaTipoDataGridView.DataSource = this.dtConfiDtTarifaTipoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtTarifaTipoDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtTarifaTipoDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtTarifaTipoDataGridView.EnableHeadersVisualStyles = false;
            this.dtTarifaTipoDataGridView.Location = new System.Drawing.Point(0, 0);
            this.dtTarifaTipoDataGridView.Name = "dtTarifaTipoDataGridView";
            this.dtTarifaTipoDataGridView.ReadOnly = true;
            this.dtTarifaTipoDataGridView.RowHeadersVisible = false;
            this.dtTarifaTipoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtTarifaTipoDataGridView.Size = new System.Drawing.Size(882, 275);
            this.dtTarifaTipoDataGridView.TabIndex = 62;
            // 
            // idTarifaDataGridViewTextBoxColumn
            // 
            this.idTarifaDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.idTarifaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idTarifaDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idTarifaDataGridViewTextBoxColumn.Name = "idTarifaDataGridViewTextBoxColumn";
            this.idTarifaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarifaTipoDataGridViewTextBoxColumn
            // 
            this.tarifaTipoDataGridViewTextBoxColumn.DataPropertyName = "TarifaTipo";
            this.tarifaTipoDataGridViewTextBoxColumn.FillWeight = 350F;
            this.tarifaTipoDataGridViewTextBoxColumn.HeaderText = "Tarifa";
            this.tarifaTipoDataGridViewTextBoxColumn.Name = "tarifaTipoDataGridViewTextBoxColumn";
            this.tarifaTipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enlaceTarifaDataGridViewTextBoxColumn
            // 
            this.enlaceTarifaDataGridViewTextBoxColumn.DataPropertyName = "EnlaceTarifa";
            this.enlaceTarifaDataGridViewTextBoxColumn.HeaderText = "EnlaceTarifa";
            this.enlaceTarifaDataGridViewTextBoxColumn.Name = "enlaceTarifaDataGridViewTextBoxColumn";
            this.enlaceTarifaDataGridViewTextBoxColumn.ReadOnly = true;
            this.enlaceTarifaDataGridViewTextBoxColumn.Visible = false;
            // 
            // tarifaTipoTextBox
            // 
            this.tarifaTipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtConfiDtTarifaTipoBindingSource, "TarifaTipo", true));
            this.tarifaTipoTextBox.Location = new System.Drawing.Point(78, 352);
            this.tarifaTipoTextBox.Name = "tarifaTipoTextBox";
            this.tarifaTipoTextBox.ReadOnly = true;
            this.tarifaTipoTextBox.Size = new System.Drawing.Size(283, 20);
            this.tarifaTipoTextBox.TabIndex = 60;
            // 
            // empresaConfiComboBox1
            // 
            this.empresaConfiComboBox1.DataSource = this.dtConfiguracionPrincipalBindingSource;
            this.empresaConfiComboBox1.DisplayMember = "EmpresaConfi";
            this.empresaConfiComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empresaConfiComboBox1.FormattingEnabled = true;
            this.empresaConfiComboBox1.Location = new System.Drawing.Point(516, 301);
            this.empresaConfiComboBox1.Name = "empresaConfiComboBox1";
            this.empresaConfiComboBox1.Size = new System.Drawing.Size(334, 21);
            this.empresaConfiComboBox1.TabIndex = 56;
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
            this.BtnCancelarTipoTarifa.Location = new System.Drawing.Point(629, 411);
            this.BtnCancelarTipoTarifa.Name = "BtnCancelarTipoTarifa";
            this.BtnCancelarTipoTarifa.Size = new System.Drawing.Size(89, 42);
            this.BtnCancelarTipoTarifa.TabIndex = 54;
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
            this.BtnGuardarDescuentos.Location = new System.Drawing.Point(452, 411);
            this.BtnGuardarDescuentos.Name = "BtnGuardarDescuentos";
            this.BtnGuardarDescuentos.Size = new System.Drawing.Size(89, 42);
            this.BtnGuardarDescuentos.TabIndex = 53;
            this.BtnGuardarDescuentos.Text = "Aceptar";
            this.BtnGuardarDescuentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarDescuentos.UseVisualStyleBackColor = false;
            this.BtnGuardarDescuentos.Click += new System.EventHandler(this.BtnGuardarDescuentos_Click);
            // 
            // panelBotonesTipoTarifa
            // 
            this.panelBotonesTipoTarifa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelBotonesTipoTarifa.BackColor = System.Drawing.Color.Transparent;
            this.panelBotonesTipoTarifa.Controls.Add(this.BtnNuevoTipoTarifa);
            this.panelBotonesTipoTarifa.Controls.Add(this.BtnModificarTipoTarifa);
            this.panelBotonesTipoTarifa.Location = new System.Drawing.Point(12, 390);
            this.panelBotonesTipoTarifa.Name = "panelBotonesTipoTarifa";
            this.panelBotonesTipoTarifa.Size = new System.Drawing.Size(401, 63);
            this.panelBotonesTipoTarifa.TabIndex = 52;
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
            this.BtnSalirTipoTarifa.Location = new System.Drawing.Point(773, 390);
            this.BtnSalirTipoTarifa.Name = "BtnSalirTipoTarifa";
            this.BtnSalirTipoTarifa.Size = new System.Drawing.Size(77, 63);
            this.BtnSalirTipoTarifa.TabIndex = 66;
            this.BtnSalirTipoTarifa.Text = "Salir";
            this.BtnSalirTipoTarifa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalirTipoTarifa.UseVisualStyleBackColor = false;
            this.BtnSalirTipoTarifa.Click += new System.EventHandler(this.BtnSalirTipoTarifa_Click);
            // 
            // ErrorDescuentos
            // 
            this.ErrorDescuentos.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.ErrorDescuentos.ContainerControl = this;
            // 
            // FormDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 465);
            this.Controls.Add(this.BtnSalirTipoTarifa);
            this.Controls.Add(this.EnlaceTarifa);
            this.Controls.Add(this.IdEmpresa);
            this.Controls.Add(this.IdTarifa);
            this.Controls.Add(this.dtTarifaTipoDataGridView);
            this.Controls.Add(idTarifaLabel);
            this.Controls.Add(tarifaTipoLabel);
            this.Controls.Add(this.tarifaTipoTextBox);
            this.Controls.Add(Label4);
            this.Controls.Add(ConfiLabel1);
            this.Controls.Add(this.empresaConfiComboBox1);
            this.Controls.Add(idEmpresaLabel1);
            this.Controls.Add(this.BtnCancelarTipoTarifa);
            this.Controls.Add(this.BtnGuardarDescuentos);
            this.Controls.Add(this.panelBotonesTipoTarifa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(898, 504);
            this.Name = "FormDescuentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descuentos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDescuentos_FormClosing);
            this.Load += new System.EventHandler(this.FormDescuentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiDtTarifaTipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarifaTipoDataGridView)).EndInit();
            this.panelBotonesTipoTarifa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDescuentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DsCONFIGURACCION dsCONFIGURACCION;
        private System.Windows.Forms.BindingSource dtConfiguracionPrincipalBindingSource;
        private System.Windows.Forms.Label EnlaceTarifa;
        private System.Windows.Forms.Label IdEmpresa;
        private System.Windows.Forms.Label IdTarifa;
        private System.Windows.Forms.DataGridView dtTarifaTipoDataGridView;
        private System.Windows.Forms.TextBox tarifaTipoTextBox;
        private System.Windows.Forms.ComboBox empresaConfiComboBox1;
        private System.Windows.Forms.Button BtnCancelarTipoTarifa;
        public System.Windows.Forms.Button BtnGuardarDescuentos;
        private System.Windows.Forms.Panel panelBotonesTipoTarifa;
        private System.Windows.Forms.Button BtnNuevoTipoTarifa;
        private System.Windows.Forms.Button BtnModificarTipoTarifa;
        private System.Windows.Forms.BindingSource dtConfiDtTarifaTipoBindingSource;
        private System.Windows.Forms.Button BtnSalirTipoTarifa;
        private System.Windows.Forms.ErrorProvider ErrorDescuentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTarifaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifaTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enlaceTarifaDataGridViewTextBoxColumn;
    }
}