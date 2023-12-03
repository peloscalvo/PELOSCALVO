
namespace PELOSCALVO
{
    partial class FormPaises
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPaises));
            this.ErrorProve = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnCancelarPais = new System.Windows.Forms.Button();
            this.BtnSalir_Pais = new System.Windows.Forms.Button();
            this.DtPaisBindinsource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMulti2 = new PELOSCALVO.DsMulti2();
            this.BtnEliminarPais = new System.Windows.Forms.Button();
            this.BtnBuscarPais = new System.Windows.Forms.Button();
            this.BtnNuevoPais = new System.Windows.Forms.Button();
            this.BtnModificarPais = new System.Windows.Forms.Button();
            this.Id_Pais = new System.Windows.Forms.Label();
            this.PanelBotones_Pais = new System.Windows.Forms.Panel();
            this.PanelPais = new System.Windows.Forms.Panel();
            this.NombrePais = new System.Windows.Forms.TextBox();
            this.BtnGuardarPais = new System.Windows.Forms.Button();
            this.dataGridPais = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisesPaisesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtPaisBindinsource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMulti2)).BeginInit();
            this.PanelBotones_Pais.SuspendLayout();
            this.PanelPais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPais)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(20, 14);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(19, 13);
            label10.TabIndex = 54;
            label10.Text = "Id:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(9, 46);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(30, 13);
            label11.TabIndex = 55;
            label11.Text = "Pais:";
            // 
            // ErrorProve
            // 
            this.ErrorProve.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.ErrorProve.ContainerControl = this;
            // 
            // BtnCancelarPais
            // 
            this.BtnCancelarPais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelarPais.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelarPais.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelarPais.Enabled = false;
            this.BtnCancelarPais.FlatAppearance.BorderSize = 0;
            this.BtnCancelarPais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancelarPais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnCancelarPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarPais.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarPais.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_x_mark_8_24;
            this.BtnCancelarPais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarPais.Location = new System.Drawing.Point(736, 448);
            this.BtnCancelarPais.Name = "BtnCancelarPais";
            this.BtnCancelarPais.Size = new System.Drawing.Size(89, 42);
            this.BtnCancelarPais.TabIndex = 73;
            this.BtnCancelarPais.Text = "Cancelar";
            this.BtnCancelarPais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelarPais.UseVisualStyleBackColor = false;
            this.BtnCancelarPais.Click += new System.EventHandler(this.BtnCancelarPais_Click);
            // 
            // BtnSalir_Pais
            // 
            this.BtnSalir_Pais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir_Pais.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalir_Pais.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalir_Pais.FlatAppearance.BorderSize = 0;
            this.BtnSalir_Pais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnSalir_Pais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnSalir_Pais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir_Pais.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir_Pais.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_door_5_32;
            this.BtnSalir_Pais.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalir_Pais.Location = new System.Drawing.Point(847, 432);
            this.BtnSalir_Pais.Name = "BtnSalir_Pais";
            this.BtnSalir_Pais.Size = new System.Drawing.Size(77, 63);
            this.BtnSalir_Pais.TabIndex = 71;
            this.BtnSalir_Pais.Text = "Salir";
            this.BtnSalir_Pais.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalir_Pais.UseVisualStyleBackColor = false;
            this.BtnSalir_Pais.Click += new System.EventHandler(this.BtnSalir_Pais_Click);
            // 
            // DtPaisBindinsource
            // 
            this.DtPaisBindinsource.DataMember = "DtPaises";
            this.DtPaisBindinsource.DataSource = this.dsMulti2;
            // 
            // dsMulti2
            // 
            this.dsMulti2.DataSetName = "DsMulti2";
            this.dsMulti2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnEliminarPais
            // 
            this.BtnEliminarPais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminarPais.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarPais.FlatAppearance.BorderSize = 0;
            this.BtnEliminarPais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnEliminarPais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnEliminarPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarPais.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarPais.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_trash_can_17_32;
            this.BtnEliminarPais.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminarPais.Location = new System.Drawing.Point(238, 3);
            this.BtnEliminarPais.Name = "BtnEliminarPais";
            this.BtnEliminarPais.Size = new System.Drawing.Size(77, 63);
            this.BtnEliminarPais.TabIndex = 9;
            this.BtnEliminarPais.Text = "Eliminar";
            this.BtnEliminarPais.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminarPais.UseVisualStyleBackColor = false;
            this.BtnEliminarPais.Click += new System.EventHandler(this.BtnEliminarPais_Click);
            // 
            // BtnBuscarPais
            // 
            this.BtnBuscarPais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarPais.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscarPais.FlatAppearance.BorderSize = 0;
            this.BtnBuscarPais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnBuscarPais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnBuscarPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarPais.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarPais.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_magnifier_4_32;
            this.BtnBuscarPais.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscarPais.Location = new System.Drawing.Point(161, 3);
            this.BtnBuscarPais.Name = "BtnBuscarPais";
            this.BtnBuscarPais.Size = new System.Drawing.Size(77, 63);
            this.BtnBuscarPais.TabIndex = 8;
            this.BtnBuscarPais.Text = "Buscar";
            this.BtnBuscarPais.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscarPais.UseVisualStyleBackColor = false;
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
            // BtnModificarPais
            // 
            this.BtnModificarPais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModificarPais.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificarPais.FlatAppearance.BorderSize = 0;
            this.BtnModificarPais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnModificarPais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnModificarPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarPais.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarPais.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_pen_8_32;
            this.BtnModificarPais.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnModificarPais.Location = new System.Drawing.Point(84, 3);
            this.BtnModificarPais.Name = "BtnModificarPais";
            this.BtnModificarPais.Size = new System.Drawing.Size(77, 63);
            this.BtnModificarPais.TabIndex = 7;
            this.BtnModificarPais.Text = "Modificar";
            this.BtnModificarPais.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificarPais.UseVisualStyleBackColor = false;
            this.BtnModificarPais.Click += new System.EventHandler(this.BtnModificarPais_Click);
            // 
            // Id_Pais
            // 
            this.Id_Pais.AutoSize = true;
            this.Id_Pais.Location = new System.Drawing.Point(52, 14);
            this.Id_Pais.Name = "Id_Pais";
            this.Id_Pais.Size = new System.Drawing.Size(13, 13);
            this.Id_Pais.TabIndex = 58;
            this.Id_Pais.Text = "0";
            this.Id_Pais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PanelBotones_Pais
            // 
            this.PanelBotones_Pais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelBotones_Pais.BackColor = System.Drawing.Color.Transparent;
            this.PanelBotones_Pais.Controls.Add(this.BtnEliminarPais);
            this.PanelBotones_Pais.Controls.Add(this.BtnBuscarPais);
            this.PanelBotones_Pais.Controls.Add(this.BtnNuevoPais);
            this.PanelBotones_Pais.Controls.Add(this.BtnModificarPais);
            this.PanelBotones_Pais.Location = new System.Drawing.Point(9, 99);
            this.PanelBotones_Pais.Name = "PanelBotones_Pais";
            this.PanelBotones_Pais.Size = new System.Drawing.Size(396, 63);
            this.PanelBotones_Pais.TabIndex = 54;
            this.PanelBotones_Pais.Tag = "NO";
            // 
            // PanelPais
            // 
            this.PanelPais.Controls.Add(this.Id_Pais);
            this.PanelPais.Controls.Add(this.PanelBotones_Pais);
            this.PanelPais.Controls.Add(label10);
            this.PanelPais.Controls.Add(label11);
            this.PanelPais.Controls.Add(this.NombrePais);
            this.PanelPais.Location = new System.Drawing.Point(12, 318);
            this.PanelPais.Name = "PanelPais";
            this.PanelPais.Size = new System.Drawing.Size(478, 172);
            this.PanelPais.TabIndex = 70;
            // 
            // NombrePais
            // 
            this.NombrePais.Location = new System.Drawing.Point(52, 43);
            this.NombrePais.MaxLength = 40;
            this.NombrePais.Name = "NombrePais";
            this.NombrePais.ReadOnly = true;
            this.NombrePais.Size = new System.Drawing.Size(385, 20);
            this.NombrePais.TabIndex = 56;
            // 
            // BtnGuardarPais
            // 
            this.BtnGuardarPais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarPais.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarPais.Enabled = false;
            this.BtnGuardarPais.FlatAppearance.BorderSize = 0;
            this.BtnGuardarPais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnGuardarPais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnGuardarPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarPais.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarPais.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_check_mark_9_24;
            this.BtnGuardarPais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarPais.Location = new System.Drawing.Point(581, 448);
            this.BtnGuardarPais.Name = "BtnGuardarPais";
            this.BtnGuardarPais.Size = new System.Drawing.Size(89, 42);
            this.BtnGuardarPais.TabIndex = 72;
            this.BtnGuardarPais.Text = "Aceptar";
            this.BtnGuardarPais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarPais.UseVisualStyleBackColor = false;
            this.BtnGuardarPais.Click += new System.EventHandler(this.BtnGuardarPais_Click);
            // 
            // dataGridPais
            // 
            this.dataGridPais.AllowDrop = true;
            this.dataGridPais.AllowUserToAddRows = false;
            this.dataGridPais.AutoGenerateColumns = false;
            this.dataGridPais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPais.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(140)))));
            this.dataGridPais.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridPais.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.paisesPaisesDataGridViewTextBoxColumn});
            this.dataGridPais.DataSource = this.DtPaisBindinsource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPais.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridPais.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridPais.Enabled = false;
            this.dataGridPais.Location = new System.Drawing.Point(0, 0);
            this.dataGridPais.MultiSelect = false;
            this.dataGridPais.Name = "dataGridPais";
            this.dataGridPais.ReadOnly = true;
            this.dataGridPais.RowHeadersVisible = false;
            this.dataGridPais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPais.Size = new System.Drawing.Size(936, 257);
            this.dataGridPais.TabIndex = 67;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idDataGridViewTextBoxColumn.FillWeight = 220F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paisesPaisesDataGridViewTextBoxColumn
            // 
            this.paisesPaisesDataGridViewTextBoxColumn.DataPropertyName = "PaisesPaises";
            this.paisesPaisesDataGridViewTextBoxColumn.FillWeight = 600F;
            this.paisesPaisesDataGridViewTextBoxColumn.HeaderText = "Paises";
            this.paisesPaisesDataGridViewTextBoxColumn.Name = "paisesPaisesDataGridViewTextBoxColumn";
            this.paisesPaisesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 519);
            this.Controls.Add(this.BtnCancelarPais);
            this.Controls.Add(this.BtnSalir_Pais);
            this.Controls.Add(this.PanelPais);
            this.Controls.Add(this.BtnGuardarPais);
            this.Controls.Add(this.dataGridPais);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPaises";
            this.Text = "Paises";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPaises_FormClosing);
            this.Load += new System.EventHandler(this.FormPaises_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtPaisBindinsource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMulti2)).EndInit();
            this.PanelBotones_Pais.ResumeLayout(false);
            this.PanelPais.ResumeLayout(false);
            this.PanelPais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ErrorProve;
        private System.Windows.Forms.Button BtnCancelarPais;
        private System.Windows.Forms.Button BtnSalir_Pais;
        private System.Windows.Forms.BindingSource DtPaisBindinsource;
        private System.Windows.Forms.Panel PanelPais;
        private System.Windows.Forms.Label Id_Pais;
        private System.Windows.Forms.Panel PanelBotones_Pais;
        private System.Windows.Forms.Button BtnEliminarPais;
        private System.Windows.Forms.Button BtnBuscarPais;
        private System.Windows.Forms.Button BtnNuevoPais;
        private System.Windows.Forms.Button BtnModificarPais;
        private System.Windows.Forms.TextBox NombrePais;
        public System.Windows.Forms.Button BtnGuardarPais;
        private System.Windows.Forms.DataGridView dataGridPais;
        private DsMulti2 dsMulti2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisesPaisesDataGridViewTextBoxColumn;
    }
}