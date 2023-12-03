
namespace PELOSCALVO
{
    partial class FormFamiliaProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFamiliaProductos));
            this.errorProvider1Confi = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtFamiliaProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnSalirFamilia = new System.Windows.Forms.Button();
            this.BtnCancelarFamilia = new System.Windows.Forms.Button();
            this.BtnEliminarFamilia = new System.Windows.Forms.Button();
            this.BtnBuscarFamilia = new System.Windows.Forms.Button();
            this.BtnNuevoFamilia = new System.Windows.Forms.Button();
            this.BtnModificarFAmilia = new System.Windows.Forms.Button();
            this.BtnGuardarFamillia = new System.Windows.Forms.Button();
            this.Id_Familia = new System.Windows.Forms.Label();
            this.BotonesFamilia = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.FamiliaTex = new System.Windows.Forms.TextBox();
            this.panelFamilia = new System.Windows.Forms.Panel();
            this.DtGridFamilia = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsMulti2 = new PELOSCALVO.DsMulti2();
            id_almacenesLabel = new System.Windows.Forms.Label();
            almacenesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1Confi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFamiliaProductosBindingSource)).BeginInit();
            this.BotonesFamilia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelFamilia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridFamilia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMulti2)).BeginInit();
            this.SuspendLayout();
            // 
            // id_almacenesLabel
            // 
            id_almacenesLabel.AutoSize = true;
            id_almacenesLabel.Location = new System.Drawing.Point(31, 20);
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
            // errorProvider1Confi
            // 
            this.errorProvider1Confi.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1Confi.ContainerControl = this;
            // 
            // dtFamiliaProductosBindingSource
            // 
            this.dtFamiliaProductosBindingSource.DataMember = "DtFamiliaProductos";
            this.dtFamiliaProductosBindingSource.DataSource = this.dsMulti2;
            // 
            // BtnSalirFamilia
            // 
            this.BtnSalirFamilia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalirFamilia.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalirFamilia.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalirFamilia.FlatAppearance.BorderSize = 0;
            this.BtnSalirFamilia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnSalirFamilia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnSalirFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalirFamilia.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirFamilia.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_door_5_32;
            this.BtnSalirFamilia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalirFamilia.Location = new System.Drawing.Point(849, 391);
            this.BtnSalirFamilia.Name = "BtnSalirFamilia";
            this.BtnSalirFamilia.Size = new System.Drawing.Size(77, 63);
            this.BtnSalirFamilia.TabIndex = 128;
            this.BtnSalirFamilia.Text = "Salir";
            this.BtnSalirFamilia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalirFamilia.UseVisualStyleBackColor = false;
            this.BtnSalirFamilia.Click += new System.EventHandler(this.BtnSalirFamilia_Click);
            // 
            // BtnCancelarFamilia
            // 
            this.BtnCancelarFamilia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelarFamilia.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelarFamilia.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelarFamilia.Enabled = false;
            this.BtnCancelarFamilia.FlatAppearance.BorderSize = 0;
            this.BtnCancelarFamilia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancelarFamilia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnCancelarFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarFamilia.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarFamilia.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_x_mark_8_24;
            this.BtnCancelarFamilia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarFamilia.Location = new System.Drawing.Point(693, 416);
            this.BtnCancelarFamilia.Name = "BtnCancelarFamilia";
            this.BtnCancelarFamilia.Size = new System.Drawing.Size(89, 42);
            this.BtnCancelarFamilia.TabIndex = 127;
            this.BtnCancelarFamilia.Text = "Cancelar";
            this.BtnCancelarFamilia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelarFamilia.UseVisualStyleBackColor = false;
            this.BtnCancelarFamilia.Click += new System.EventHandler(this.BtnCancelarFamilia_Click);
            // 
            // BtnEliminarFamilia
            // 
            this.BtnEliminarFamilia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminarFamilia.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarFamilia.FlatAppearance.BorderSize = 0;
            this.BtnEliminarFamilia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnEliminarFamilia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnEliminarFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarFamilia.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarFamilia.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_trash_can_17_32;
            this.BtnEliminarFamilia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminarFamilia.Location = new System.Drawing.Point(238, 3);
            this.BtnEliminarFamilia.Name = "BtnEliminarFamilia";
            this.BtnEliminarFamilia.Size = new System.Drawing.Size(77, 63);
            this.BtnEliminarFamilia.TabIndex = 9;
            this.BtnEliminarFamilia.Text = "Eliminar";
            this.BtnEliminarFamilia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminarFamilia.UseVisualStyleBackColor = false;
            this.BtnEliminarFamilia.Click += new System.EventHandler(this.BtnEliminarFamilia_Click);
            // 
            // BtnBuscarFamilia
            // 
            this.BtnBuscarFamilia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarFamilia.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscarFamilia.FlatAppearance.BorderSize = 0;
            this.BtnBuscarFamilia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnBuscarFamilia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnBuscarFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarFamilia.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarFamilia.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_magnifier_4_32;
            this.BtnBuscarFamilia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscarFamilia.Location = new System.Drawing.Point(161, 3);
            this.BtnBuscarFamilia.Name = "BtnBuscarFamilia";
            this.BtnBuscarFamilia.Size = new System.Drawing.Size(77, 63);
            this.BtnBuscarFamilia.TabIndex = 8;
            this.BtnBuscarFamilia.Text = "Buscar";
            this.BtnBuscarFamilia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscarFamilia.UseVisualStyleBackColor = false;
            // 
            // BtnNuevoFamilia
            // 
            this.BtnNuevoFamilia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNuevoFamilia.BackColor = System.Drawing.Color.Transparent;
            this.BtnNuevoFamilia.FlatAppearance.BorderSize = 0;
            this.BtnNuevoFamilia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnNuevoFamilia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnNuevoFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoFamilia.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoFamilia.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_file_14_32;
            this.BtnNuevoFamilia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevoFamilia.Location = new System.Drawing.Point(7, 3);
            this.BtnNuevoFamilia.Name = "BtnNuevoFamilia";
            this.BtnNuevoFamilia.Size = new System.Drawing.Size(77, 63);
            this.BtnNuevoFamilia.TabIndex = 6;
            this.BtnNuevoFamilia.Tag = "stop";
            this.BtnNuevoFamilia.Text = "Nuevo";
            this.BtnNuevoFamilia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNuevoFamilia.UseVisualStyleBackColor = false;
            this.BtnNuevoFamilia.Click += new System.EventHandler(this.BtnNuevoFamilia_Click);
            // 
            // BtnModificarFAmilia
            // 
            this.BtnModificarFAmilia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModificarFAmilia.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificarFAmilia.FlatAppearance.BorderSize = 0;
            this.BtnModificarFAmilia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnModificarFAmilia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnModificarFAmilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarFAmilia.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarFAmilia.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_pen_8_32;
            this.BtnModificarFAmilia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnModificarFAmilia.Location = new System.Drawing.Point(84, 3);
            this.BtnModificarFAmilia.Name = "BtnModificarFAmilia";
            this.BtnModificarFAmilia.Size = new System.Drawing.Size(77, 63);
            this.BtnModificarFAmilia.TabIndex = 7;
            this.BtnModificarFAmilia.Text = "Modificar";
            this.BtnModificarFAmilia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificarFAmilia.UseVisualStyleBackColor = false;
            this.BtnModificarFAmilia.Click += new System.EventHandler(this.BtnModificarFAmilia_Click);
            // 
            // BtnGuardarFamillia
            // 
            this.BtnGuardarFamillia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarFamillia.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarFamillia.Enabled = false;
            this.BtnGuardarFamillia.FlatAppearance.BorderSize = 0;
            this.BtnGuardarFamillia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnGuardarFamillia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnGuardarFamillia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarFamillia.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarFamillia.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_check_mark_9_24;
            this.BtnGuardarFamillia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarFamillia.Location = new System.Drawing.Point(559, 416);
            this.BtnGuardarFamillia.Name = "BtnGuardarFamillia";
            this.BtnGuardarFamillia.Size = new System.Drawing.Size(89, 42);
            this.BtnGuardarFamillia.TabIndex = 126;
            this.BtnGuardarFamillia.Text = "Aceptar";
            this.BtnGuardarFamillia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarFamillia.UseVisualStyleBackColor = false;
            this.BtnGuardarFamillia.Click += new System.EventHandler(this.BtnGuardarFamillia_Click);
            // 
            // Id_Familia
            // 
            this.Id_Familia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtFamiliaProductosBindingSource, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.Id_Familia.Location = new System.Drawing.Point(74, 14);
            this.Id_Familia.Name = "Id_Familia";
            this.Id_Familia.Size = new System.Drawing.Size(210, 23);
            this.Id_Familia.TabIndex = 58;
            this.Id_Familia.Text = "0";
            this.Id_Familia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BotonesFamilia
            // 
            this.BotonesFamilia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BotonesFamilia.BackColor = System.Drawing.Color.Transparent;
            this.BotonesFamilia.Controls.Add(this.BtnEliminarFamilia);
            this.BotonesFamilia.Controls.Add(this.BtnBuscarFamilia);
            this.BotonesFamilia.Controls.Add(this.BtnNuevoFamilia);
            this.BotonesFamilia.Controls.Add(this.BtnModificarFAmilia);
            this.BotonesFamilia.Location = new System.Drawing.Point(9, 105);
            this.BotonesFamilia.Name = "BotonesFamilia";
            this.BotonesFamilia.Size = new System.Drawing.Size(396, 63);
            this.BotonesFamilia.TabIndex = 54;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // FamiliaTex
            // 
            this.FamiliaTex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtFamiliaProductosBindingSource, "Familia", true));
            this.FamiliaTex.Location = new System.Drawing.Point(74, 43);
            this.FamiliaTex.Name = "FamiliaTex";
            this.FamiliaTex.ReadOnly = true;
            this.FamiliaTex.Size = new System.Drawing.Size(374, 20);
            this.FamiliaTex.TabIndex = 56;
            // 
            // panelFamilia
            // 
            this.panelFamilia.Controls.Add(this.Id_Familia);
            this.panelFamilia.Controls.Add(this.BotonesFamilia);
            this.panelFamilia.Controls.Add(id_almacenesLabel);
            this.panelFamilia.Controls.Add(almacenesLabel);
            this.panelFamilia.Controls.Add(this.FamiliaTex);
            this.panelFamilia.Location = new System.Drawing.Point(12, 280);
            this.panelFamilia.Name = "panelFamilia";
            this.panelFamilia.Size = new System.Drawing.Size(478, 178);
            this.panelFamilia.TabIndex = 125;
            this.panelFamilia.Tag = "NO";
            // 
            // DtGridFamilia
            // 
            this.DtGridFamilia.AllowDrop = true;
            this.DtGridFamilia.AllowUserToAddRows = false;
            this.DtGridFamilia.AllowUserToDeleteRows = false;
            this.DtGridFamilia.AllowUserToResizeRows = false;
            this.DtGridFamilia.AutoGenerateColumns = false;
            this.DtGridFamilia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtGridFamilia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(102)))));
            this.DtGridFamilia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DtGridFamilia.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtGridFamilia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtGridFamilia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGridFamilia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.familiaDataGridViewTextBoxColumn});
            this.DtGridFamilia.DataSource = this.dtFamiliaProductosBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtGridFamilia.DefaultCellStyle = dataGridViewCellStyle3;
            this.DtGridFamilia.Dock = System.Windows.Forms.DockStyle.Top;
            this.DtGridFamilia.Enabled = false;
            this.DtGridFamilia.Location = new System.Drawing.Point(0, 0);
            this.DtGridFamilia.MultiSelect = false;
            this.DtGridFamilia.Name = "DtGridFamilia";
            this.DtGridFamilia.ReadOnly = true;
            this.DtGridFamilia.RowHeadersVisible = false;
            this.DtGridFamilia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtGridFamilia.Size = new System.Drawing.Size(956, 261);
            this.DtGridFamilia.TabIndex = 122;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idDataGridViewTextBoxColumn.FillWeight = 60F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // familiaDataGridViewTextBoxColumn
            // 
            this.familiaDataGridViewTextBoxColumn.DataPropertyName = "Familia";
            this.familiaDataGridViewTextBoxColumn.FillWeight = 98.47716F;
            this.familiaDataGridViewTextBoxColumn.HeaderText = "Familia";
            this.familiaDataGridViewTextBoxColumn.Name = "familiaDataGridViewTextBoxColumn";
            this.familiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dsMulti2
            // 
            this.dsMulti2.DataSetName = "DsMulti2";
            this.dsMulti2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormFamiliaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 466);
            this.Controls.Add(this.BtnSalirFamilia);
            this.Controls.Add(this.BtnCancelarFamilia);
            this.Controls.Add(this.BtnGuardarFamillia);
            this.Controls.Add(this.panelFamilia);
            this.Controls.Add(this.DtGridFamilia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFamiliaProductos";
            this.Text = "Familia De Productos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFamiliaProductos_FormClosing);
            this.Load += new System.EventHandler(this.FormFamiliaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1Confi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFamiliaProductosBindingSource)).EndInit();
            this.BotonesFamilia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelFamilia.ResumeLayout(false);
            this.panelFamilia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridFamilia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMulti2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1Confi;
        private System.Windows.Forms.BindingSource dtFamiliaProductosBindingSource;
        private System.Windows.Forms.Button BtnSalirFamilia;
        private System.Windows.Forms.Button BtnCancelarFamilia;
        public System.Windows.Forms.Button BtnGuardarFamillia;
        private System.Windows.Forms.Panel panelFamilia;
        private System.Windows.Forms.Label Id_Familia;
        private System.Windows.Forms.Panel BotonesFamilia;
        private System.Windows.Forms.Button BtnEliminarFamilia;
        private System.Windows.Forms.Button BtnBuscarFamilia;
        private System.Windows.Forms.Button BtnNuevoFamilia;
        private System.Windows.Forms.Button BtnModificarFAmilia;
        private System.Windows.Forms.TextBox FamiliaTex;
        private System.Windows.Forms.DataGridView DtGridFamilia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DsMulti2 dsMulti2;
    }
}