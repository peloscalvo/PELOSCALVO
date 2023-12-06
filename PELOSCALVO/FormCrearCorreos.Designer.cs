
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearCorreos));
            this.DatagridCorreosEmpresa = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.TabCorreos = new System.Windows.Forms.TabControl();
            this.PageInicio = new System.Windows.Forms.TabPage();
            this.BtnSalirCorreoEmpresa = new System.Windows.Forms.Button();
            this.PageEmpresa = new System.Windows.Forms.TabPage();
            this.Timeof = new System.Windows.Forms.TextBox();
            this.smtp = new System.Windows.Forms.TextBox();
            this.Puerto = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.CorreoEletronico = new System.Windows.Forms.TextBox();
            this.Id_Correo_E = new System.Windows.Forms.Label();
            this.BtnCancelarCorreo_E = new System.Windows.Forms.Button();
            this.PanelBotones_CorreoEmp = new System.Windows.Forms.Panel();
            this.BtnEliminarCorreoEmpresa = new System.Windows.Forms.Button();
            this.BtnBuscarCorreo_empr = new System.Windows.Forms.Button();
            this.BtnNuevoCorreoEmpr = new System.Windows.Forms.Button();
            this.BtnModificarCorreoEmpr = new System.Windows.Forms.Button();
            this.BtnGuardarCorreo_E = new System.Windows.Forms.Button();
            this.NombreEmpresa = new System.Windows.Forms.TextBox();
            this.PageClientes = new System.Windows.Forms.TabPage();
            this.BtnGuardarCorreoCli = new System.Windows.Forms.Button();
            this.DataGridCorreoCliente = new System.Windows.Forms.DataGridView();
            this.ErrorCorreosCrear = new System.Windows.Forms.ErrorProvider(this.components);
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridCorreosEmpresa)).BeginInit();
            this.TabCorreos.SuspendLayout();
            this.PageInicio.SuspendLayout();
            this.PageEmpresa.SuspendLayout();
            this.PanelBotones_CorreoEmp.SuspendLayout();
            this.PageClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCorreoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCorreosCrear)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(78, 265);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(19, 13);
            label10.TabIndex = 54;
            label10.Text = "Id:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(7, 295);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(91, 13);
            label11.TabIndex = 55;
            label11.Text = "Nombre Empresa:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 334);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(91, 13);
            label1.TabIndex = 78;
            label1.Text = "Correo Eletronico:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(533, 295);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 13);
            label2.TabIndex = 80;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(515, 334);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(64, 13);
            label3.TabIndex = 82;
            label3.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(533, 365);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 13);
            label4.TabIndex = 84;
            label4.Text = "Puerto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(61, 365);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(32, 13);
            label5.TabIndex = 86;
            label5.Text = "smtp:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(721, 365);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(42, 13);
            label6.TabIndex = 88;
            label6.Text = "Timeof:";
            // 
            // DatagridCorreosEmpresa
            // 
            this.DatagridCorreosEmpresa.AllowDrop = true;
            this.DatagridCorreosEmpresa.AllowUserToOrderColumns = true;
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
            this.DatagridCorreosEmpresa.Size = new System.Drawing.Size(958, 243);
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
            // TabCorreos
            // 
            this.TabCorreos.Controls.Add(this.PageInicio);
            this.TabCorreos.Controls.Add(this.PageEmpresa);
            this.TabCorreos.Controls.Add(this.PageClientes);
            this.TabCorreos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabCorreos.Location = new System.Drawing.Point(0, 0);
            this.TabCorreos.Name = "TabCorreos";
            this.TabCorreos.SelectedIndex = 0;
            this.TabCorreos.Size = new System.Drawing.Size(972, 501);
            this.TabCorreos.TabIndex = 55;
            // 
            // PageInicio
            // 
            this.PageInicio.Controls.Add(this.BtnSalirCorreoEmpresa);
            this.PageInicio.Location = new System.Drawing.Point(4, 22);
            this.PageInicio.Name = "PageInicio";
            this.PageInicio.Padding = new System.Windows.Forms.Padding(3);
            this.PageInicio.Size = new System.Drawing.Size(964, 475);
            this.PageInicio.TabIndex = 0;
            this.PageInicio.Text = "INICIO";
            this.PageInicio.UseVisualStyleBackColor = true;
            // 
            // BtnSalirCorreoEmpresa
            // 
            this.BtnSalirCorreoEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalirCorreoEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalirCorreoEmpresa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalirCorreoEmpresa.FlatAppearance.BorderSize = 0;
            this.BtnSalirCorreoEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnSalirCorreoEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnSalirCorreoEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalirCorreoEmpresa.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirCorreoEmpresa.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_door_5_32;
            this.BtnSalirCorreoEmpresa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalirCorreoEmpresa.Location = new System.Drawing.Point(778, 361);
            this.BtnSalirCorreoEmpresa.Name = "BtnSalirCorreoEmpresa";
            this.BtnSalirCorreoEmpresa.Size = new System.Drawing.Size(77, 63);
            this.BtnSalirCorreoEmpresa.TabIndex = 76;
            this.BtnSalirCorreoEmpresa.Text = "Salir";
            this.BtnSalirCorreoEmpresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalirCorreoEmpresa.UseVisualStyleBackColor = false;
            this.BtnSalirCorreoEmpresa.Click += new System.EventHandler(this.BtnSalirCorreoEmpresa_Click);
            // 
            // PageEmpresa
            // 
            this.PageEmpresa.Controls.Add(label6);
            this.PageEmpresa.Controls.Add(this.Timeof);
            this.PageEmpresa.Controls.Add(label5);
            this.PageEmpresa.Controls.Add(this.smtp);
            this.PageEmpresa.Controls.Add(label4);
            this.PageEmpresa.Controls.Add(this.Puerto);
            this.PageEmpresa.Controls.Add(label3);
            this.PageEmpresa.Controls.Add(this.Contraseña);
            this.PageEmpresa.Controls.Add(label2);
            this.PageEmpresa.Controls.Add(this.Usuario);
            this.PageEmpresa.Controls.Add(label1);
            this.PageEmpresa.Controls.Add(this.CorreoEletronico);
            this.PageEmpresa.Controls.Add(this.Id_Correo_E);
            this.PageEmpresa.Controls.Add(this.BtnCancelarCorreo_E);
            this.PageEmpresa.Controls.Add(this.PanelBotones_CorreoEmp);
            this.PageEmpresa.Controls.Add(label10);
            this.PageEmpresa.Controls.Add(this.BtnGuardarCorreo_E);
            this.PageEmpresa.Controls.Add(label11);
            this.PageEmpresa.Controls.Add(this.DatagridCorreosEmpresa);
            this.PageEmpresa.Controls.Add(this.NombreEmpresa);
            this.PageEmpresa.Location = new System.Drawing.Point(4, 22);
            this.PageEmpresa.Name = "PageEmpresa";
            this.PageEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.PageEmpresa.Size = new System.Drawing.Size(964, 475);
            this.PageEmpresa.TabIndex = 1;
            this.PageEmpresa.Text = "Correos Empresa";
            this.PageEmpresa.UseVisualStyleBackColor = true;
            // 
            // Timeof
            // 
            this.Timeof.Location = new System.Drawing.Point(773, 362);
            this.Timeof.MaxLength = 40;
            this.Timeof.Name = "Timeof";
            this.Timeof.ReadOnly = true;
            this.Timeof.Size = new System.Drawing.Size(102, 20);
            this.Timeof.TabIndex = 89;
            // 
            // smtp
            // 
            this.smtp.Location = new System.Drawing.Point(104, 362);
            this.smtp.MaxLength = 40;
            this.smtp.Name = "smtp";
            this.smtp.ReadOnly = true;
            this.smtp.Size = new System.Drawing.Size(314, 20);
            this.smtp.TabIndex = 87;
            // 
            // Puerto
            // 
            this.Puerto.Location = new System.Drawing.Point(585, 362);
            this.Puerto.MaxLength = 40;
            this.Puerto.Name = "Puerto";
            this.Puerto.ReadOnly = true;
            this.Puerto.Size = new System.Drawing.Size(102, 20);
            this.Puerto.TabIndex = 85;
            // 
            // Contraseña
            // 
            this.Contraseña.Location = new System.Drawing.Point(585, 331);
            this.Contraseña.MaxLength = 40;
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.PasswordChar = '*';
            this.Contraseña.ReadOnly = true;
            this.Contraseña.Size = new System.Drawing.Size(249, 20);
            this.Contraseña.TabIndex = 83;
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(585, 292);
            this.Usuario.MaxLength = 40;
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Size = new System.Drawing.Size(249, 20);
            this.Usuario.TabIndex = 81;
            // 
            // CorreoEletronico
            // 
            this.CorreoEletronico.Location = new System.Drawing.Point(104, 331);
            this.CorreoEletronico.MaxLength = 40;
            this.CorreoEletronico.Name = "CorreoEletronico";
            this.CorreoEletronico.ReadOnly = true;
            this.CorreoEletronico.Size = new System.Drawing.Size(314, 20);
            this.CorreoEletronico.TabIndex = 79;
            // 
            // Id_Correo_E
            // 
            this.Id_Correo_E.AutoSize = true;
            this.Id_Correo_E.Location = new System.Drawing.Point(110, 265);
            this.Id_Correo_E.Name = "Id_Correo_E";
            this.Id_Correo_E.Size = new System.Drawing.Size(13, 13);
            this.Id_Correo_E.TabIndex = 58;
            this.Id_Correo_E.Text = "0";
            this.Id_Correo_E.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnCancelarCorreo_E
            // 
            this.BtnCancelarCorreo_E.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelarCorreo_E.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelarCorreo_E.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelarCorreo_E.Enabled = false;
            this.BtnCancelarCorreo_E.FlatAppearance.BorderSize = 0;
            this.BtnCancelarCorreo_E.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancelarCorreo_E.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnCancelarCorreo_E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarCorreo_E.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarCorreo_E.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_x_mark_8_24;
            this.BtnCancelarCorreo_E.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarCorreo_E.Location = new System.Drawing.Point(724, 425);
            this.BtnCancelarCorreo_E.Name = "BtnCancelarCorreo_E";
            this.BtnCancelarCorreo_E.Size = new System.Drawing.Size(89, 42);
            this.BtnCancelarCorreo_E.TabIndex = 77;
            this.BtnCancelarCorreo_E.Text = "Cancelar";
            this.BtnCancelarCorreo_E.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelarCorreo_E.UseVisualStyleBackColor = false;
            this.BtnCancelarCorreo_E.Click += new System.EventHandler(this.BtnCancelarCorreo_E_Click);
            // 
            // PanelBotones_CorreoEmp
            // 
            this.PanelBotones_CorreoEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelBotones_CorreoEmp.BackColor = System.Drawing.Color.Transparent;
            this.PanelBotones_CorreoEmp.Controls.Add(this.BtnEliminarCorreoEmpresa);
            this.PanelBotones_CorreoEmp.Controls.Add(this.BtnBuscarCorreo_empr);
            this.PanelBotones_CorreoEmp.Controls.Add(this.BtnNuevoCorreoEmpr);
            this.PanelBotones_CorreoEmp.Controls.Add(this.BtnModificarCorreoEmpr);
            this.PanelBotones_CorreoEmp.Location = new System.Drawing.Point(20, 400);
            this.PanelBotones_CorreoEmp.Name = "PanelBotones_CorreoEmp";
            this.PanelBotones_CorreoEmp.Size = new System.Drawing.Size(396, 63);
            this.PanelBotones_CorreoEmp.TabIndex = 54;
            this.PanelBotones_CorreoEmp.Tag = "NO";
            // 
            // BtnEliminarCorreoEmpresa
            // 
            this.BtnEliminarCorreoEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminarCorreoEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarCorreoEmpresa.FlatAppearance.BorderSize = 0;
            this.BtnEliminarCorreoEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnEliminarCorreoEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnEliminarCorreoEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarCorreoEmpresa.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarCorreoEmpresa.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_trash_can_17_32;
            this.BtnEliminarCorreoEmpresa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminarCorreoEmpresa.Location = new System.Drawing.Point(238, 3);
            this.BtnEliminarCorreoEmpresa.Name = "BtnEliminarCorreoEmpresa";
            this.BtnEliminarCorreoEmpresa.Size = new System.Drawing.Size(77, 63);
            this.BtnEliminarCorreoEmpresa.TabIndex = 9;
            this.BtnEliminarCorreoEmpresa.Text = "Eliminar";
            this.BtnEliminarCorreoEmpresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminarCorreoEmpresa.UseVisualStyleBackColor = false;
            this.BtnEliminarCorreoEmpresa.Click += new System.EventHandler(this.BtnEliminarCorreoEmpresa_Click);
            // 
            // BtnBuscarCorreo_empr
            // 
            this.BtnBuscarCorreo_empr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarCorreo_empr.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscarCorreo_empr.FlatAppearance.BorderSize = 0;
            this.BtnBuscarCorreo_empr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnBuscarCorreo_empr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnBuscarCorreo_empr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarCorreo_empr.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarCorreo_empr.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_magnifier_4_32;
            this.BtnBuscarCorreo_empr.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscarCorreo_empr.Location = new System.Drawing.Point(161, 3);
            this.BtnBuscarCorreo_empr.Name = "BtnBuscarCorreo_empr";
            this.BtnBuscarCorreo_empr.Size = new System.Drawing.Size(77, 63);
            this.BtnBuscarCorreo_empr.TabIndex = 8;
            this.BtnBuscarCorreo_empr.Text = "Buscar";
            this.BtnBuscarCorreo_empr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscarCorreo_empr.UseVisualStyleBackColor = false;
            // 
            // BtnNuevoCorreoEmpr
            // 
            this.BtnNuevoCorreoEmpr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNuevoCorreoEmpr.BackColor = System.Drawing.Color.Transparent;
            this.BtnNuevoCorreoEmpr.FlatAppearance.BorderSize = 0;
            this.BtnNuevoCorreoEmpr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnNuevoCorreoEmpr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnNuevoCorreoEmpr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoCorreoEmpr.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoCorreoEmpr.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_file_14_32;
            this.BtnNuevoCorreoEmpr.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevoCorreoEmpr.Location = new System.Drawing.Point(7, 3);
            this.BtnNuevoCorreoEmpr.Name = "BtnNuevoCorreoEmpr";
            this.BtnNuevoCorreoEmpr.Size = new System.Drawing.Size(77, 63);
            this.BtnNuevoCorreoEmpr.TabIndex = 6;
            this.BtnNuevoCorreoEmpr.Tag = "stop";
            this.BtnNuevoCorreoEmpr.Text = "Nuevo";
            this.BtnNuevoCorreoEmpr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNuevoCorreoEmpr.UseVisualStyleBackColor = false;
            this.BtnNuevoCorreoEmpr.Click += new System.EventHandler(this.BtnNuevoCorreoEmpr_Click);
            // 
            // BtnModificarCorreoEmpr
            // 
            this.BtnModificarCorreoEmpr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModificarCorreoEmpr.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificarCorreoEmpr.FlatAppearance.BorderSize = 0;
            this.BtnModificarCorreoEmpr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnModificarCorreoEmpr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnModificarCorreoEmpr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarCorreoEmpr.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarCorreoEmpr.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_pen_8_32;
            this.BtnModificarCorreoEmpr.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnModificarCorreoEmpr.Location = new System.Drawing.Point(84, 3);
            this.BtnModificarCorreoEmpr.Name = "BtnModificarCorreoEmpr";
            this.BtnModificarCorreoEmpr.Size = new System.Drawing.Size(77, 63);
            this.BtnModificarCorreoEmpr.TabIndex = 7;
            this.BtnModificarCorreoEmpr.Text = "Modificar";
            this.BtnModificarCorreoEmpr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificarCorreoEmpr.UseVisualStyleBackColor = false;
            this.BtnModificarCorreoEmpr.Click += new System.EventHandler(this.BtnModificarCorreoEmpr_Click);
            // 
            // BtnGuardarCorreo_E
            // 
            this.BtnGuardarCorreo_E.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarCorreo_E.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarCorreo_E.Enabled = false;
            this.BtnGuardarCorreo_E.FlatAppearance.BorderSize = 0;
            this.BtnGuardarCorreo_E.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnGuardarCorreo_E.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnGuardarCorreo_E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarCorreo_E.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarCorreo_E.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_check_mark_9_24;
            this.BtnGuardarCorreo_E.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarCorreo_E.Location = new System.Drawing.Point(474, 425);
            this.BtnGuardarCorreo_E.Name = "BtnGuardarCorreo_E";
            this.BtnGuardarCorreo_E.Size = new System.Drawing.Size(89, 42);
            this.BtnGuardarCorreo_E.TabIndex = 76;
            this.BtnGuardarCorreo_E.Text = "Aceptar";
            this.BtnGuardarCorreo_E.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarCorreo_E.UseVisualStyleBackColor = false;
            this.BtnGuardarCorreo_E.Click += new System.EventHandler(this.BtnGuardarCorreo_E_Click);
            // 
            // NombreEmpresa
            // 
            this.NombreEmpresa.Location = new System.Drawing.Point(104, 292);
            this.NombreEmpresa.MaxLength = 40;
            this.NombreEmpresa.Name = "NombreEmpresa";
            this.NombreEmpresa.ReadOnly = true;
            this.NombreEmpresa.Size = new System.Drawing.Size(385, 20);
            this.NombreEmpresa.TabIndex = 56;
            // 
            // PageClientes
            // 
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
            this.DataGridCorreoCliente.Size = new System.Drawing.Size(958, 266);
            this.DataGridCorreoCliente.TabIndex = 53;
            this.DataGridCorreoCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCorreoCliente_CellClick);
            // 
            // ErrorCorreosCrear
            // 
            this.ErrorCorreosCrear.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.ErrorCorreosCrear.ContainerControl = this;
            // 
            // FormCrearCorreos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 501);
            this.Controls.Add(this.TabCorreos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCrearCorreos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Correos Eletronicos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCrearCorreos_FormClosing);
            this.Load += new System.EventHandler(this.FormCorreos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridCorreosEmpresa)).EndInit();
            this.TabCorreos.ResumeLayout(false);
            this.PageInicio.ResumeLayout(false);
            this.PageEmpresa.ResumeLayout(false);
            this.PageEmpresa.PerformLayout();
            this.PanelBotones_CorreoEmp.ResumeLayout(false);
            this.PageClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCorreoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCorreosCrear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DatagridCorreosEmpresa;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TabControl TabCorreos;
        private System.Windows.Forms.TabPage PageInicio;
        private System.Windows.Forms.TabPage PageEmpresa;
        private System.Windows.Forms.TabPage PageClientes;
        private System.Windows.Forms.DataGridView DataGridCorreoCliente;
        public System.Windows.Forms.Button BtnGuardarCorreoCli;
        private System.Windows.Forms.Button BtnSalirCorreoEmpresa;
        private System.Windows.Forms.Label Id_Correo_E;
        private System.Windows.Forms.Button BtnCancelarCorreo_E;
        private System.Windows.Forms.Panel PanelBotones_CorreoEmp;
        private System.Windows.Forms.Button BtnEliminarCorreoEmpresa;
        private System.Windows.Forms.Button BtnBuscarCorreo_empr;
        private System.Windows.Forms.Button BtnNuevoCorreoEmpr;
        private System.Windows.Forms.Button BtnModificarCorreoEmpr;
        public System.Windows.Forms.Button BtnGuardarCorreo_E;
        private System.Windows.Forms.TextBox NombreEmpresa;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.TextBox CorreoEletronico;
        private System.Windows.Forms.TextBox smtp;
        private System.Windows.Forms.TextBox Puerto;
        private System.Windows.Forms.TextBox Timeof;
        private System.Windows.Forms.ErrorProvider ErrorCorreosCrear;
    }
}