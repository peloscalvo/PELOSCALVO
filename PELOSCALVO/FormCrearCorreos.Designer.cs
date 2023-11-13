
namespace PELOSCALVO
{
    partial class FormCrearCorreos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearCorreos));
            this.DatagridCorreosEmpresa = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.BtnGuardarCorreo_EMP = new System.Windows.Forms.Button();
            this.BtnVolverCorreo_E = new System.Windows.Forms.Button();
            this.TabCorreos = new System.Windows.Forms.TabControl();
            this.PageInicio = new System.Windows.Forms.TabPage();
            this.PageEmpresa = new System.Windows.Forms.TabPage();
            this.PageClientes = new System.Windows.Forms.TabPage();
            this.BtnVolver_cli = new System.Windows.Forms.Button();
            this.BtnGuardarCorreoCli = new System.Windows.Forms.Button();
            this.DataGridCorreoCliente = new System.Windows.Forms.DataGridView();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpresaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoEletronico_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.NombreEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoEletronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smtp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timeof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EliminarCorreoE = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridCorreosEmpresa)).BeginInit();
            this.TabCorreos.SuspendLayout();
            this.PageEmpresa.SuspendLayout();
            this.PageClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCorreoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // DatagridCorreosEmpresa
            // 
            this.DatagridCorreosEmpresa.AllowDrop = true;
            this.DatagridCorreosEmpresa.AllowUserToResizeRows = false;
            this.DatagridCorreosEmpresa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(70)))));
            this.DatagridCorreosEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridCorreosEmpresa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DatagridCorreosEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridCorreosEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreEmpresa,
            this.CorreoEletronico,
            this.Usuario,
            this.Contraseña,
            this.smtp,
            this.Puerto,
            this.Timeof,
            this.EliminarCorreoE});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatagridCorreosEmpresa.DefaultCellStyle = dataGridViewCellStyle2;
            this.DatagridCorreosEmpresa.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatagridCorreosEmpresa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DatagridCorreosEmpresa.Location = new System.Drawing.Point(3, 3);
            this.DatagridCorreosEmpresa.MultiSelect = false;
            this.DatagridCorreosEmpresa.Name = "DatagridCorreosEmpresa";
            this.DatagridCorreosEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DatagridCorreosEmpresa.Size = new System.Drawing.Size(958, 350);
            this.DatagridCorreosEmpresa.TabIndex = 52;
            this.DatagridCorreosEmpresa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagriCorreosEmpresa_CellClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 90F;
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_pen_8_32;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 405;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 98F;
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_trash_can_17_32;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 440;
            // 
            // BtnGuardarCorreo_EMP
            // 
            this.BtnGuardarCorreo_EMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarCorreo_EMP.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarCorreo_EMP.FlatAppearance.BorderSize = 0;
            this.BtnGuardarCorreo_EMP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnGuardarCorreo_EMP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnGuardarCorreo_EMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarCorreo_EMP.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarCorreo_EMP.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_check_mark_9_24;
            this.BtnGuardarCorreo_EMP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarCorreo_EMP.Location = new System.Drawing.Point(682, 405);
            this.BtnGuardarCorreo_EMP.Name = "BtnGuardarCorreo_EMP";
            this.BtnGuardarCorreo_EMP.Size = new System.Drawing.Size(107, 42);
            this.BtnGuardarCorreo_EMP.TabIndex = 54;
            this.BtnGuardarCorreo_EMP.Text = "Actualizar";
            this.BtnGuardarCorreo_EMP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarCorreo_EMP.UseVisualStyleBackColor = false;
            this.BtnGuardarCorreo_EMP.Click += new System.EventHandler(this.BtnGuardarCorreo_EMP_Click);
            // 
            // BtnVolverCorreo_E
            // 
            this.BtnVolverCorreo_E.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVolverCorreo_E.BackColor = System.Drawing.Color.Transparent;
            this.BtnVolverCorreo_E.FlatAppearance.BorderSize = 0;
            this.BtnVolverCorreo_E.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnVolverCorreo_E.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnVolverCorreo_E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolverCorreo_E.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolverCorreo_E.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_undo_4_24;
            this.BtnVolverCorreo_E.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVolverCorreo_E.Location = new System.Drawing.Point(824, 405);
            this.BtnVolverCorreo_E.Name = "BtnVolverCorreo_E";
            this.BtnVolverCorreo_E.Size = new System.Drawing.Size(107, 42);
            this.BtnVolverCorreo_E.TabIndex = 53;
            this.BtnVolverCorreo_E.Text = "Volver";
            this.BtnVolverCorreo_E.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVolverCorreo_E.UseVisualStyleBackColor = false;
            // 
            // TabCorreos
            // 
            this.TabCorreos.Controls.Add(this.PageInicio);
            this.TabCorreos.Controls.Add(this.PageEmpresa);
            this.TabCorreos.Controls.Add(this.PageClientes);
            this.TabCorreos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabCorreos.Location = new System.Drawing.Point(0, 0);
            this.TabCorreos.Name = "TabCorreos";
            this.TabCorreos.SelectedIndex = 0;
            this.TabCorreos.Size = new System.Drawing.Size(972, 489);
            this.TabCorreos.TabIndex = 55;
            // 
            // PageInicio
            // 
            this.PageInicio.Location = new System.Drawing.Point(4, 22);
            this.PageInicio.Name = "PageInicio";
            this.PageInicio.Padding = new System.Windows.Forms.Padding(3);
            this.PageInicio.Size = new System.Drawing.Size(964, 463);
            this.PageInicio.TabIndex = 0;
            this.PageInicio.Text = "INICIO";
            this.PageInicio.UseVisualStyleBackColor = true;
            // 
            // PageEmpresa
            // 
            this.PageEmpresa.Controls.Add(this.DatagridCorreosEmpresa);
            this.PageEmpresa.Controls.Add(this.BtnVolverCorreo_E);
            this.PageEmpresa.Controls.Add(this.BtnGuardarCorreo_EMP);
            this.PageEmpresa.Location = new System.Drawing.Point(4, 22);
            this.PageEmpresa.Name = "PageEmpresa";
            this.PageEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.PageEmpresa.Size = new System.Drawing.Size(964, 463);
            this.PageEmpresa.TabIndex = 1;
            this.PageEmpresa.Text = "Correos Empresa";
            this.PageEmpresa.UseVisualStyleBackColor = true;
            // 
            // PageClientes
            // 
            this.PageClientes.Controls.Add(this.BtnVolver_cli);
            this.PageClientes.Controls.Add(this.BtnGuardarCorreoCli);
            this.PageClientes.Controls.Add(this.DataGridCorreoCliente);
            this.PageClientes.Location = new System.Drawing.Point(4, 22);
            this.PageClientes.Name = "PageClientes";
            this.PageClientes.Padding = new System.Windows.Forms.Padding(3);
            this.PageClientes.Size = new System.Drawing.Size(964, 463);
            this.PageClientes.TabIndex = 2;
            this.PageClientes.Text = "Correos Clientes";
            this.PageClientes.UseVisualStyleBackColor = true;
            // 
            // BtnVolver_cli
            // 
            this.BtnVolver_cli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVolver_cli.BackColor = System.Drawing.Color.Transparent;
            this.BtnVolver_cli.FlatAppearance.BorderSize = 0;
            this.BtnVolver_cli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnVolver_cli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnVolver_cli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver_cli.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver_cli.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_undo_4_24;
            this.BtnVolver_cli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVolver_cli.Location = new System.Drawing.Point(811, 402);
            this.BtnVolver_cli.Name = "BtnVolver_cli";
            this.BtnVolver_cli.Size = new System.Drawing.Size(107, 42);
            this.BtnVolver_cli.TabIndex = 55;
            this.BtnVolver_cli.Text = "Volver";
            this.BtnVolver_cli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVolver_cli.UseVisualStyleBackColor = false;
            // 
            // BtnGuardarCorreoCli
            // 
            this.BtnGuardarCorreoCli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarCorreoCli.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarCorreoCli.FlatAppearance.BorderSize = 0;
            this.BtnGuardarCorreoCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnGuardarCorreoCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnGuardarCorreoCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarCorreoCli.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarCorreoCli.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_check_mark_9_24;
            this.BtnGuardarCorreoCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarCorreoCli.Location = new System.Drawing.Point(669, 402);
            this.BtnGuardarCorreoCli.Name = "BtnGuardarCorreoCli";
            this.BtnGuardarCorreoCli.Size = new System.Drawing.Size(107, 42);
            this.BtnGuardarCorreoCli.TabIndex = 56;
            this.BtnGuardarCorreoCli.Text = "Actualizar";
            this.BtnGuardarCorreoCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarCorreoCli.UseVisualStyleBackColor = false;
            this.BtnGuardarCorreoCli.Click += new System.EventHandler(this.BtnGuardarCorreoCli_Click);
            // 
            // DataGridCorreoCliente
            // 
            this.DataGridCorreoCliente.AllowDrop = true;
            this.DataGridCorreoCliente.AllowUserToResizeRows = false;
            this.DataGridCorreoCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridCorreoCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DataGridCorreoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridCorreoCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridCorreoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCorreoCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RazonSocial,
            this.EmpresaNombre,
            this.Direcion,
            this.CorreoEletronico_cli,
            this.dataGridViewImageColumn3});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridCorreoCliente.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridCorreoCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataGridCorreoCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DataGridCorreoCliente.Location = new System.Drawing.Point(3, 3);
            this.DataGridCorreoCliente.MultiSelect = false;
            this.DataGridCorreoCliente.Name = "DataGridCorreoCliente";
            this.DataGridCorreoCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridCorreoCliente.Size = new System.Drawing.Size(958, 350);
            this.DataGridCorreoCliente.TabIndex = 53;
            this.DataGridCorreoCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCorreoCliente_CellClick);
            // 
            // RazonSocial
            // 
            this.RazonSocial.FillWeight = 260F;
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.Name = "RazonSocial";
            // 
            // EmpresaNombre
            // 
            this.EmpresaNombre.FillWeight = 260F;
            this.EmpresaNombre.HeaderText = "Empresa";
            this.EmpresaNombre.Name = "EmpresaNombre";
            // 
            // Direcion
            // 
            this.Direcion.FillWeight = 160F;
            this.Direcion.HeaderText = "Direccion";
            this.Direcion.Name = "Direcion";
            // 
            // CorreoEletronico_cli
            // 
            this.CorreoEletronico_cli.FillWeight = 150F;
            this.CorreoEletronico_cli.HeaderText = "Correo eletronico";
            this.CorreoEletronico_cli.Name = "CorreoEletronico_cli";
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.FillWeight = 98F;
            this.dataGridViewImageColumn3.HeaderText = "Eliminar";
            this.dataGridViewImageColumn3.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_trash_can_17_32;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NombreEmpresa
            // 
            this.NombreEmpresa.FillWeight = 200F;
            this.NombreEmpresa.HeaderText = "Nombre Empresa";
            this.NombreEmpresa.Name = "NombreEmpresa";
            this.NombreEmpresa.Width = 200;
            // 
            // CorreoEletronico
            // 
            this.CorreoEletronico.FillWeight = 170F;
            this.CorreoEletronico.HeaderText = "Correo Eletronico";
            this.CorreoEletronico.Name = "CorreoEletronico";
            this.CorreoEletronico.Width = 170;
            // 
            // Usuario
            // 
            this.Usuario.FillWeight = 140F;
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.Width = 140;
            // 
            // Contraseña
            // 
            this.Contraseña.FillWeight = 90F;
            this.Contraseña.HeaderText = "contraseña";
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Width = 90;
            // 
            // smtp
            // 
            this.smtp.FillWeight = 130F;
            this.smtp.HeaderText = "Datos Del Servidor";
            this.smtp.Name = "smtp";
            this.smtp.Width = 130;
            // 
            // Puerto
            // 
            this.Puerto.HeaderText = "Puerto";
            this.Puerto.Name = "Puerto";
            // 
            // Timeof
            // 
            this.Timeof.FillWeight = 80F;
            this.Timeof.HeaderText = "Timeof";
            this.Timeof.Name = "Timeof";
            this.Timeof.Width = 80;
            // 
            // EliminarCorreoE
            // 
            this.EliminarCorreoE.FillWeight = 98F;
            this.EliminarCorreoE.HeaderText = "Eliminar";
            this.EliminarCorreoE.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_trash_can_17_32;
            this.EliminarCorreoE.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EliminarCorreoE.Name = "EliminarCorreoE";
            this.EliminarCorreoE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EliminarCorreoE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EliminarCorreoE.Width = 129;
            // 
            // FormCorreos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 489);
            this.Controls.Add(this.TabCorreos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCorreos";
            this.Text = "Correos Eletronicos";
            this.Load += new System.EventHandler(this.FormCorreos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridCorreosEmpresa)).EndInit();
            this.TabCorreos.ResumeLayout(false);
            this.PageEmpresa.ResumeLayout(false);
            this.PageClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCorreoCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button BtnGuardarCorreo_EMP;
        public System.Windows.Forms.Button BtnVolverCorreo_E;
        private System.Windows.Forms.DataGridView DatagridCorreosEmpresa;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TabControl TabCorreos;
        private System.Windows.Forms.TabPage PageInicio;
        private System.Windows.Forms.TabPage PageEmpresa;
        private System.Windows.Forms.TabPage PageClientes;
        private System.Windows.Forms.DataGridView DataGridCorreoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpresaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoEletronico_cli;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        public System.Windows.Forms.Button BtnVolver_cli;
        public System.Windows.Forms.Button BtnGuardarCorreoCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoEletronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn smtp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puerto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timeof;
        private System.Windows.Forms.DataGridViewImageColumn EliminarCorreoE;
    }
}