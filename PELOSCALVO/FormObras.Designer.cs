
namespace PELOSCALVO
{
    partial class FormObras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormObras));
            this.BtnGuardarObra = new System.Windows.Forms.Button();
            this.ObraTxt = new System.Windows.Forms.TextBox();
            this.dtObrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMulti2 = new PELOSCALVO.DsMulti2();
            this.PanelPais = new System.Windows.Forms.Panel();
            this.Id_obra = new System.Windows.Forms.Label();
            this.PanelBotones_Obra = new System.Windows.Forms.Panel();
            this.BtnEliminarObra = new System.Windows.Forms.Button();
            this.BtnBuscarObra = new System.Windows.Forms.Button();
            this.BtnNuevoObra = new System.Windows.Forms.Button();
            this.BtnModificarObra = new System.Windows.Forms.Button();
            this.BtnCancelarObra = new System.Windows.Forms.Button();
            this.BtnSalir_Obra = new System.Windows.Forms.Button();
            this.ErrorProve = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridObras = new System.Windows.Forms.DataGridView();
            this.idObrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtObrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMulti2)).BeginInit();
            this.PanelPais.SuspendLayout();
            this.PanelBotones_Obra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridObras)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(20, 11);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(19, 13);
            label10.TabIndex = 54;
            label10.Text = "Id:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(9, 43);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(33, 13);
            label11.TabIndex = 55;
            label11.Text = "Obra:";
            // 
            // BtnGuardarObra
            // 
            this.BtnGuardarObra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarObra.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarObra.Enabled = false;
            this.BtnGuardarObra.FlatAppearance.BorderSize = 0;
            this.BtnGuardarObra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnGuardarObra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnGuardarObra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarObra.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarObra.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_check_mark_9_24;
            this.BtnGuardarObra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarObra.Location = new System.Drawing.Point(528, 383);
            this.BtnGuardarObra.Name = "BtnGuardarObra";
            this.BtnGuardarObra.Size = new System.Drawing.Size(89, 42);
            this.BtnGuardarObra.TabIndex = 77;
            this.BtnGuardarObra.Text = "Aceptar";
            this.BtnGuardarObra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarObra.UseVisualStyleBackColor = false;
            this.BtnGuardarObra.Click += new System.EventHandler(this.BtnGuardarObra_Click);
            // 
            // ObraTxt
            // 
            this.ObraTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtObrasBindingSource, "Obras", true));
            this.ObraTxt.Location = new System.Drawing.Point(52, 40);
            this.ObraTxt.MaxLength = 40;
            this.ObraTxt.Name = "ObraTxt";
            this.ObraTxt.ReadOnly = true;
            this.ObraTxt.Size = new System.Drawing.Size(385, 20);
            this.ObraTxt.TabIndex = 56;
            // 
            // dtObrasBindingSource
            // 
            this.dtObrasBindingSource.DataMember = "DtObras";
            this.dtObrasBindingSource.DataSource = this.dsMulti2;
            // 
            // dsMulti2
            // 
            this.dsMulti2.DataSetName = "DsMulti2";
            this.dsMulti2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PanelPais
            // 
            this.PanelPais.Controls.Add(this.Id_obra);
            this.PanelPais.Controls.Add(this.PanelBotones_Obra);
            this.PanelPais.Controls.Add(label10);
            this.PanelPais.Controls.Add(label11);
            this.PanelPais.Controls.Add(this.ObraTxt);
            this.PanelPais.Location = new System.Drawing.Point(12, 275);
            this.PanelPais.Name = "PanelPais";
            this.PanelPais.Size = new System.Drawing.Size(478, 151);
            this.PanelPais.TabIndex = 75;
            // 
            // Id_obra
            // 
            this.Id_obra.AutoSize = true;
            this.Id_obra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtObrasBindingSource, "Id", true));
            this.Id_obra.Location = new System.Drawing.Point(52, 11);
            this.Id_obra.Name = "Id_obra";
            this.Id_obra.Size = new System.Drawing.Size(13, 13);
            this.Id_obra.TabIndex = 58;
            this.Id_obra.Text = "0";
            this.Id_obra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PanelBotones_Obra
            // 
            this.PanelBotones_Obra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelBotones_Obra.BackColor = System.Drawing.Color.Transparent;
            this.PanelBotones_Obra.Controls.Add(this.BtnEliminarObra);
            this.PanelBotones_Obra.Controls.Add(this.BtnBuscarObra);
            this.PanelBotones_Obra.Controls.Add(this.BtnNuevoObra);
            this.PanelBotones_Obra.Controls.Add(this.BtnModificarObra);
            this.PanelBotones_Obra.Location = new System.Drawing.Point(9, 78);
            this.PanelBotones_Obra.Name = "PanelBotones_Obra";
            this.PanelBotones_Obra.Size = new System.Drawing.Size(396, 63);
            this.PanelBotones_Obra.TabIndex = 54;
            this.PanelBotones_Obra.Tag = "NO";
            // 
            // BtnEliminarObra
            // 
            this.BtnEliminarObra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminarObra.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarObra.FlatAppearance.BorderSize = 0;
            this.BtnEliminarObra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnEliminarObra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnEliminarObra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarObra.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarObra.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_trash_can_17_32;
            this.BtnEliminarObra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminarObra.Location = new System.Drawing.Point(238, 3);
            this.BtnEliminarObra.Name = "BtnEliminarObra";
            this.BtnEliminarObra.Size = new System.Drawing.Size(77, 63);
            this.BtnEliminarObra.TabIndex = 9;
            this.BtnEliminarObra.Text = "Eliminar";
            this.BtnEliminarObra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminarObra.UseVisualStyleBackColor = false;
            this.BtnEliminarObra.Click += new System.EventHandler(this.BtnEliminarObra_Click);
            // 
            // BtnBuscarObra
            // 
            this.BtnBuscarObra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarObra.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscarObra.FlatAppearance.BorderSize = 0;
            this.BtnBuscarObra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnBuscarObra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnBuscarObra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarObra.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarObra.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_magnifier_4_32;
            this.BtnBuscarObra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscarObra.Location = new System.Drawing.Point(161, 3);
            this.BtnBuscarObra.Name = "BtnBuscarObra";
            this.BtnBuscarObra.Size = new System.Drawing.Size(77, 63);
            this.BtnBuscarObra.TabIndex = 8;
            this.BtnBuscarObra.Text = "Buscar";
            this.BtnBuscarObra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscarObra.UseVisualStyleBackColor = false;
            this.BtnBuscarObra.Click += new System.EventHandler(this.BtnBuscarObra_Click);
            // 
            // BtnNuevoObra
            // 
            this.BtnNuevoObra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNuevoObra.BackColor = System.Drawing.Color.Transparent;
            this.BtnNuevoObra.FlatAppearance.BorderSize = 0;
            this.BtnNuevoObra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnNuevoObra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnNuevoObra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoObra.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoObra.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_file_14_32;
            this.BtnNuevoObra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevoObra.Location = new System.Drawing.Point(7, 3);
            this.BtnNuevoObra.Name = "BtnNuevoObra";
            this.BtnNuevoObra.Size = new System.Drawing.Size(77, 63);
            this.BtnNuevoObra.TabIndex = 6;
            this.BtnNuevoObra.Tag = "stop";
            this.BtnNuevoObra.Text = "Nuevo";
            this.BtnNuevoObra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNuevoObra.UseVisualStyleBackColor = false;
            this.BtnNuevoObra.Click += new System.EventHandler(this.BtnNuevoObra_Click);
            // 
            // BtnModificarObra
            // 
            this.BtnModificarObra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModificarObra.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificarObra.FlatAppearance.BorderSize = 0;
            this.BtnModificarObra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnModificarObra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnModificarObra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarObra.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarObra.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_pen_8_32;
            this.BtnModificarObra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnModificarObra.Location = new System.Drawing.Point(84, 3);
            this.BtnModificarObra.Name = "BtnModificarObra";
            this.BtnModificarObra.Size = new System.Drawing.Size(77, 63);
            this.BtnModificarObra.TabIndex = 7;
            this.BtnModificarObra.Text = "Modificar";
            this.BtnModificarObra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificarObra.UseVisualStyleBackColor = false;
            this.BtnModificarObra.Click += new System.EventHandler(this.BtnModificarObra_Click);
            // 
            // BtnCancelarObra
            // 
            this.BtnCancelarObra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelarObra.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelarObra.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelarObra.Enabled = false;
            this.BtnCancelarObra.FlatAppearance.BorderSize = 0;
            this.BtnCancelarObra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancelarObra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnCancelarObra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarObra.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarObra.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_x_mark_8_24;
            this.BtnCancelarObra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarObra.Location = new System.Drawing.Point(674, 383);
            this.BtnCancelarObra.Name = "BtnCancelarObra";
            this.BtnCancelarObra.Size = new System.Drawing.Size(89, 42);
            this.BtnCancelarObra.TabIndex = 78;
            this.BtnCancelarObra.Text = "Cancelar";
            this.BtnCancelarObra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelarObra.UseVisualStyleBackColor = false;
            this.BtnCancelarObra.Click += new System.EventHandler(this.BtnCancelarObra_Click);
            // 
            // BtnSalir_Obra
            // 
            this.BtnSalir_Obra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir_Obra.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalir_Obra.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalir_Obra.FlatAppearance.BorderSize = 0;
            this.BtnSalir_Obra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnSalir_Obra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnSalir_Obra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir_Obra.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir_Obra.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_door_5_32;
            this.BtnSalir_Obra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalir_Obra.Location = new System.Drawing.Point(838, 362);
            this.BtnSalir_Obra.Name = "BtnSalir_Obra";
            this.BtnSalir_Obra.Size = new System.Drawing.Size(77, 63);
            this.BtnSalir_Obra.TabIndex = 76;
            this.BtnSalir_Obra.Text = "Salir";
            this.BtnSalir_Obra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalir_Obra.UseVisualStyleBackColor = false;
            this.BtnSalir_Obra.Click += new System.EventHandler(this.BtnSalir_Obra_Click);
            // 
            // ErrorProve
            // 
            this.ErrorProve.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.ErrorProve.ContainerControl = this;
            // 
            // dataGridObras
            // 
            this.dataGridObras.AllowDrop = true;
            this.dataGridObras.AllowUserToAddRows = false;
            this.dataGridObras.AutoGenerateColumns = false;
            this.dataGridObras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridObras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridObras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridObras.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridObras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridObras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridObras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idObrasDataGridViewTextBoxColumn,
            this.obrasDataGridViewTextBoxColumn});
            this.dataGridObras.DataSource = this.dtObrasBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridObras.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridObras.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridObras.Location = new System.Drawing.Point(0, 0);
            this.dataGridObras.MultiSelect = false;
            this.dataGridObras.Name = "dataGridObras";
            this.dataGridObras.ReadOnly = true;
            this.dataGridObras.RowHeadersVisible = false;
            this.dataGridObras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridObras.Size = new System.Drawing.Size(927, 257);
            this.dataGridObras.TabIndex = 74;
            // 
            // idObrasDataGridViewTextBoxColumn
            // 
            this.idObrasDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.idObrasDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idObrasDataGridViewTextBoxColumn.FillWeight = 160F;
            this.idObrasDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idObrasDataGridViewTextBoxColumn.Name = "idObrasDataGridViewTextBoxColumn";
            this.idObrasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // obrasDataGridViewTextBoxColumn
            // 
            this.obrasDataGridViewTextBoxColumn.DataPropertyName = "Obras";
            this.obrasDataGridViewTextBoxColumn.FillWeight = 700F;
            this.obrasDataGridViewTextBoxColumn.HeaderText = "Obras";
            this.obrasDataGridViewTextBoxColumn.Name = "obrasDataGridViewTextBoxColumn";
            this.obrasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormObras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 447);
            this.Controls.Add(this.BtnGuardarObra);
            this.Controls.Add(this.PanelPais);
            this.Controls.Add(this.BtnCancelarObra);
            this.Controls.Add(this.BtnSalir_Obra);
            this.Controls.Add(this.dataGridObras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(943, 486);
            this.Name = "FormObras";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Obras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormObras_FormClosing);
            this.Load += new System.EventHandler(this.FormObras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtObrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMulti2)).EndInit();
            this.PanelPais.ResumeLayout(false);
            this.PanelPais.PerformLayout();
            this.PanelBotones_Obra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridObras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button BtnGuardarObra;
        private System.Windows.Forms.TextBox ObraTxt;
        private System.Windows.Forms.Panel PanelPais;
        private System.Windows.Forms.Label Id_obra;
        private System.Windows.Forms.Panel PanelBotones_Obra;
        private System.Windows.Forms.Button BtnEliminarObra;
        private System.Windows.Forms.Button BtnBuscarObra;
        private System.Windows.Forms.Button BtnNuevoObra;
        private System.Windows.Forms.Button BtnModificarObra;
        private DsMulti2 dsMulti2;
        private System.Windows.Forms.Button BtnCancelarObra;
        private System.Windows.Forms.Button BtnSalir_Obra;
        private System.Windows.Forms.ErrorProvider ErrorProve;
        private System.Windows.Forms.BindingSource dtObrasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obrasDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridObras;
    }
}