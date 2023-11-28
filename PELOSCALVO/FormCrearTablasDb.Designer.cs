
namespace PELOSCALVO
{
    partial class FormCrearTablasDb
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
            System.Windows.Forms.Label labelARTICULOS;
            System.Windows.Forms.Label labelCLIENTES;
            System.Windows.Forms.Label tipoExtensionArticulosLabel;
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnTablasCrear = new System.Windows.Forms.Button();
            this.Info_Res = new System.Windows.Forms.Label();
            this.BtnCrearTablaCli = new System.Windows.Forms.Button();
            this.BtnCrearTablaArti = new System.Windows.Forms.Button();
            this.BtnExaminarT = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.NombreArchivo_T = new System.Windows.Forms.TextBox();
            this.ArticulosTxt = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.ContadorFactu = new System.Windows.Forms.Label();
            this.ContadorArticulos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RegistLbel = new System.Windows.Forms.Label();
            this.ContadorClientes = new System.Windows.Forms.Label();
            this.ClientesTxt = new System.Windows.Forms.ComboBox();
            this.ExtensionTxt = new System.Windows.Forms.ComboBox();
            this.BtnRestablecer_t = new System.Windows.Forms.Button();
            this.BtnSalirT = new System.Windows.Forms.Button();
            this.ErrorVer = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnConectar = new System.Windows.Forms.Button();
            labelARTICULOS = new System.Windows.Forms.Label();
            labelCLIENTES = new System.Windows.Forms.Label();
            tipoExtensionArticulosLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorVer)).BeginInit();
            this.SuspendLayout();
            // 
            // labelARTICULOS
            // 
            labelARTICULOS.AutoSize = true;
            labelARTICULOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelARTICULOS.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelARTICULOS.Location = new System.Drawing.Point(13, 72);
            labelARTICULOS.Name = "labelARTICULOS";
            labelARTICULOS.Size = new System.Drawing.Size(133, 26);
            labelARTICULOS.TabIndex = 102;
            labelARTICULOS.Tag = "";
            labelARTICULOS.Text = "ARTICULOS";
            labelARTICULOS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCLIENTES
            // 
            labelCLIENTES.AutoSize = true;
            labelCLIENTES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelCLIENTES.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCLIENTES.Location = new System.Drawing.Point(31, 112);
            labelCLIENTES.Name = "labelCLIENTES";
            labelCLIENTES.Size = new System.Drawing.Size(115, 26);
            labelCLIENTES.TabIndex = 103;
            labelCLIENTES.Text = "CLIENTES";
            labelCLIENTES.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipoExtensionArticulosLabel
            // 
            tipoExtensionArticulosLabel.AutoSize = true;
            tipoExtensionArticulosLabel.Location = new System.Drawing.Point(295, 142);
            tipoExtensionArticulosLabel.Name = "tipoExtensionArticulosLabel";
            tipoExtensionArticulosLabel.Size = new System.Drawing.Size(56, 13);
            tipoExtensionArticulosLabel.TabIndex = 105;
            tipoExtensionArticulosLabel.Text = "Extension:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.BtnTablasCrear);
            this.panel3.Location = new System.Drawing.Point(661, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 90);
            this.panel3.TabIndex = 115;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 94;
            this.label9.Text = "Crear Todas Las Tablas";
            // 
            // BtnTablasCrear
            // 
            this.BtnTablasCrear.Location = new System.Drawing.Point(41, 49);
            this.BtnTablasCrear.Name = "BtnTablasCrear";
            this.BtnTablasCrear.Size = new System.Drawing.Size(75, 23);
            this.BtnTablasCrear.TabIndex = 87;
            this.BtnTablasCrear.Text = "Tablas";
            this.BtnTablasCrear.UseVisualStyleBackColor = true;
            this.BtnTablasCrear.Click += new System.EventHandler(this.BtnTablasCrear_Click);
            // 
            // Info_Res
            // 
            this.Info_Res.AutoSize = true;
            this.Info_Res.BackColor = System.Drawing.Color.Gold;
            this.Info_Res.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Info_Res.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Info_Res.Location = new System.Drawing.Point(525, 233);
            this.Info_Res.Name = "Info_Res";
            this.Info_Res.Size = new System.Drawing.Size(201, 15);
            this.Info_Res.TabIndex = 114;
            this.Info_Res.Text = "Cierra toda Conexion y Restablece datos";
            this.Info_Res.Visible = false;
            // 
            // BtnCrearTablaCli
            // 
            this.BtnCrearTablaCli.Location = new System.Drawing.Point(458, 112);
            this.BtnCrearTablaCli.Name = "BtnCrearTablaCli";
            this.BtnCrearTablaCli.Size = new System.Drawing.Size(75, 23);
            this.BtnCrearTablaCli.TabIndex = 113;
            this.BtnCrearTablaCli.Text = "&Crear";
            this.BtnCrearTablaCli.UseVisualStyleBackColor = true;
            this.BtnCrearTablaCli.Click += new System.EventHandler(this.BtnCrearTablaCli_Click);
            // 
            // BtnCrearTablaArti
            // 
            this.BtnCrearTablaArti.Location = new System.Drawing.Point(458, 72);
            this.BtnCrearTablaArti.Name = "BtnCrearTablaArti";
            this.BtnCrearTablaArti.Size = new System.Drawing.Size(75, 23);
            this.BtnCrearTablaArti.TabIndex = 112;
            this.BtnCrearTablaArti.Text = "&Crear";
            this.BtnCrearTablaArti.UseVisualStyleBackColor = true;
            this.BtnCrearTablaArti.Click += new System.EventHandler(this.BtnCrearTablaArti_Click);
            // 
            // BtnExaminarT
            // 
            this.BtnExaminarT.Location = new System.Drawing.Point(440, 33);
            this.BtnExaminarT.Name = "BtnExaminarT";
            this.BtnExaminarT.Size = new System.Drawing.Size(75, 23);
            this.BtnExaminarT.TabIndex = 111;
            this.BtnExaminarT.Text = "&Examinar";
            this.BtnExaminarT.UseVisualStyleBackColor = true;
            this.BtnExaminarT.Click += new System.EventHandler(this.BtnExaminarT_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 110;
            this.label6.Text = "Nombre Archivo principal:";
            // 
            // NombreArchivo_T
            // 
            this.NombreArchivo_T.Location = new System.Drawing.Point(152, 35);
            this.NombreArchivo_T.Name = "NombreArchivo_T";
            this.NombreArchivo_T.ReadOnly = true;
            this.NombreArchivo_T.Size = new System.Drawing.Size(271, 20);
            this.NombreArchivo_T.TabIndex = 109;
            this.NombreArchivo_T.Tag = "NO";
            this.NombreArchivo_T.Text = "Datos App Peloscalvo";
            // 
            // ArticulosTxt
            // 
            this.ArticulosTxt.DisplayMember = "A";
            this.ArticulosTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArticulosTxt.FormattingEnabled = true;
            this.ArticulosTxt.Items.AddRange(new object[] {
            "Tarifa De Articulos 1",
            "Tarifa De Articulos 2",
            "Tarifa De Articulos 3",
            "Tarifa De Articulos 4",
            "Tarifa De Articulos 5"});
            this.ArticulosTxt.Location = new System.Drawing.Point(152, 72);
            this.ArticulosTxt.Name = "ArticulosTxt";
            this.ArticulosTxt.Size = new System.Drawing.Size(300, 21);
            this.ArticulosTxt.TabIndex = 100;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.ContadorFactu);
            this.panel2.Controls.Add(this.ContadorArticulos);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.RegistLbel);
            this.panel2.Controls.Add(this.ContadorClientes);
            this.panel2.Location = new System.Drawing.Point(7, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 129);
            this.panel2.TabIndex = 108;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 20);
            this.label8.TabIndex = 87;
            this.label8.Tag = "";
            this.label8.Text = "Total reguistros Articulos:";
            // 
            // ContadorFactu
            // 
            this.ContadorFactu.AutoSize = true;
            this.ContadorFactu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContadorFactu.Location = new System.Drawing.Point(206, 86);
            this.ContadorFactu.Name = "ContadorFactu";
            this.ContadorFactu.Size = new System.Drawing.Size(19, 20);
            this.ContadorFactu.TabIndex = 90;
            this.ContadorFactu.Text = "0";
            this.ContadorFactu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ContadorArticulos
            // 
            this.ContadorArticulos.AutoSize = true;
            this.ContadorArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContadorArticulos.Location = new System.Drawing.Point(206, 20);
            this.ContadorArticulos.Name = "ContadorArticulos";
            this.ContadorArticulos.Size = new System.Drawing.Size(19, 20);
            this.ContadorArticulos.TabIndex = 84;
            this.ContadorArticulos.Text = "0";
            this.ContadorArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 20);
            this.label7.TabIndex = 89;
            this.label7.Tag = "";
            this.label7.Text = "Total reguistros Empresas:";
            // 
            // RegistLbel
            // 
            this.RegistLbel.AutoSize = true;
            this.RegistLbel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistLbel.Location = new System.Drawing.Point(4, 55);
            this.RegistLbel.Name = "RegistLbel";
            this.RegistLbel.Size = new System.Drawing.Size(180, 20);
            this.RegistLbel.TabIndex = 85;
            this.RegistLbel.Tag = "";
            this.RegistLbel.Text = "Total reguistros clientes:";
            // 
            // ContadorClientes
            // 
            this.ContadorClientes.AutoSize = true;
            this.ContadorClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContadorClientes.Location = new System.Drawing.Point(206, 55);
            this.ContadorClientes.Name = "ContadorClientes";
            this.ContadorClientes.Size = new System.Drawing.Size(19, 20);
            this.ContadorClientes.TabIndex = 86;
            this.ContadorClientes.Text = "0";
            this.ContadorClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ClientesTxt
            // 
            this.ClientesTxt.DisplayMember = "A";
            this.ClientesTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientesTxt.FormattingEnabled = true;
            this.ClientesTxt.Items.AddRange(new object[] {
            "Listado De Clientes 1",
            "Listado De Clientes 1",
            "Listado De Clientes 1",
            "Listado De Clientes 1",
            "Listado De Clientes 1"});
            this.ClientesTxt.Location = new System.Drawing.Point(152, 112);
            this.ClientesTxt.Name = "ClientesTxt";
            this.ClientesTxt.Size = new System.Drawing.Size(300, 21);
            this.ClientesTxt.TabIndex = 101;
            // 
            // ExtensionTxt
            // 
            this.ExtensionTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExtensionTxt.FormattingEnabled = true;
            this.ExtensionTxt.Items.AddRange(new object[] {
            "accdb",
            "mdb"});
            this.ExtensionTxt.Location = new System.Drawing.Point(357, 139);
            this.ExtensionTxt.Name = "ExtensionTxt";
            this.ExtensionTxt.Size = new System.Drawing.Size(95, 21);
            this.ExtensionTxt.TabIndex = 106;
            // 
            // BtnRestablecer_t
            // 
            this.BtnRestablecer_t.BackColor = System.Drawing.Color.DarkKhaki;
            this.BtnRestablecer_t.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnRestablecer_t.Location = new System.Drawing.Point(732, 228);
            this.BtnRestablecer_t.Name = "BtnRestablecer_t";
            this.BtnRestablecer_t.Size = new System.Drawing.Size(75, 23);
            this.BtnRestablecer_t.TabIndex = 116;
            this.BtnRestablecer_t.Text = "&Restablecer";
            this.BtnRestablecer_t.UseVisualStyleBackColor = false;
            this.BtnRestablecer_t.Click += new System.EventHandler(this.BtnRestablecer_t_Click);
            this.BtnRestablecer_t.MouseEnter += new System.EventHandler(this.BtnRestablecer_t_MouseEnter);
            // 
            // BtnSalirT
            // 
            this.BtnSalirT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalirT.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalirT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalirT.FlatAppearance.BorderSize = 0;
            this.BtnSalirT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnSalirT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnSalirT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalirT.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirT.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_door_5_32;
            this.BtnSalirT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalirT.Location = new System.Drawing.Point(786, 377);
            this.BtnSalirT.Name = "BtnSalirT";
            this.BtnSalirT.Size = new System.Drawing.Size(77, 63);
            this.BtnSalirT.TabIndex = 117;
            this.BtnSalirT.Text = "Salir";
            this.BtnSalirT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalirT.UseVisualStyleBackColor = false;
            this.BtnSalirT.Click += new System.EventHandler(this.BtnSalirT_Click);
            // 
            // ErrorVer
            // 
            this.ErrorVer.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.ErrorVer.ContainerControl = this;
            // 
            // BtnConectar
            // 
            this.BtnConectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConectar.BackColor = System.Drawing.Color.Transparent;
            this.BtnConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConectar.FlatAppearance.BorderSize = 0;
            this.BtnConectar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnConectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConectar.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConectar.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_check_mark_9_24;
            this.BtnConectar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConectar.Location = new System.Drawing.Point(644, 315);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(108, 42);
            this.BtnConectar.TabIndex = 118;
            this.BtnConectar.Text = "&Conectar";
            this.BtnConectar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConectar.UseVisualStyleBackColor = false;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // FormCrearTablasDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 469);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.BtnSalirT);
            this.Controls.Add(this.BtnRestablecer_t);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Info_Res);
            this.Controls.Add(this.BtnCrearTablaCli);
            this.Controls.Add(this.BtnCrearTablaArti);
            this.Controls.Add(this.BtnExaminarT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NombreArchivo_T);
            this.Controls.Add(labelARTICULOS);
            this.Controls.Add(labelCLIENTES);
            this.Controls.Add(this.ArticulosTxt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ClientesTxt);
            this.Controls.Add(tipoExtensionArticulosLabel);
            this.Controls.Add(this.ExtensionTxt);
            this.Name = "FormCrearTablasDb";
            this.Text = "Crear Tablas Db";
            this.Load += new System.EventHandler(this.FormCrearTablasDb_Load);
            this.MouseEnter += new System.EventHandler(this.FormCrearTablasDb_MouseEnter);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorVer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnTablasCrear;
        private System.Windows.Forms.Label Info_Res;
        private System.Windows.Forms.Button BtnCrearTablaCli;
        private System.Windows.Forms.Button BtnCrearTablaArti;
        private System.Windows.Forms.Button BtnExaminarT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NombreArchivo_T;
        public System.Windows.Forms.ComboBox ArticulosTxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ContadorFactu;
        private System.Windows.Forms.Label ContadorArticulos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label RegistLbel;
        private System.Windows.Forms.Label ContadorClientes;
        public System.Windows.Forms.ComboBox ClientesTxt;
        public System.Windows.Forms.ComboBox ExtensionTxt;
        private System.Windows.Forms.Button BtnRestablecer_t;
        private System.Windows.Forms.Button BtnSalirT;
        private System.Windows.Forms.ErrorProvider ErrorVer;
        public System.Windows.Forms.Button BtnConectar;
    }
}