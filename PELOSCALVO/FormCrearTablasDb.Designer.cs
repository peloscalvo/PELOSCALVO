
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
            System.Windows.Forms.Label labelARTICULOS;
            System.Windows.Forms.Label labelCLIENTES;
            System.Windows.Forms.Label tipoExtensionArticulosLabel;
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnTablas = new System.Windows.Forms.Button();
            this.Info_Res = new System.Windows.Forms.Label();
            this.BtnCrearTbCliente = new System.Windows.Forms.Button();
            this.BtnCrearTbArticulos = new System.Windows.Forms.Button();
            this.BtnExaminarB = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.NombreArchivoDatos = new System.Windows.Forms.TextBox();
            this.SerieArticulosText = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.ContadorFactu = new System.Windows.Forms.Label();
            this.ContadorArticulos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RegistLbel = new System.Windows.Forms.Label();
            this.ContadorClientes = new System.Windows.Forms.Label();
            this.SerieClientesText2 = new System.Windows.Forms.ComboBox();
            this.TipoExtension_b = new System.Windows.Forms.ComboBox();
            this.BtnRestablecer = new System.Windows.Forms.Button();
            this.BtnSalirT = new System.Windows.Forms.Button();
            labelARTICULOS = new System.Windows.Forms.Label();
            labelCLIENTES = new System.Windows.Forms.Label();
            tipoExtensionArticulosLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.BtnTablas);
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
            // BtnTablas
            // 
            this.BtnTablas.Location = new System.Drawing.Point(41, 49);
            this.BtnTablas.Name = "BtnTablas";
            this.BtnTablas.Size = new System.Drawing.Size(75, 23);
            this.BtnTablas.TabIndex = 87;
            this.BtnTablas.Text = "Tablas";
            this.BtnTablas.UseVisualStyleBackColor = true;
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
            // BtnCrearTbCliente
            // 
            this.BtnCrearTbCliente.Location = new System.Drawing.Point(458, 112);
            this.BtnCrearTbCliente.Name = "BtnCrearTbCliente";
            this.BtnCrearTbCliente.Size = new System.Drawing.Size(75, 23);
            this.BtnCrearTbCliente.TabIndex = 113;
            this.BtnCrearTbCliente.Text = "&Crear";
            this.BtnCrearTbCliente.UseVisualStyleBackColor = true;
            // 
            // BtnCrearTbArticulos
            // 
            this.BtnCrearTbArticulos.Location = new System.Drawing.Point(458, 72);
            this.BtnCrearTbArticulos.Name = "BtnCrearTbArticulos";
            this.BtnCrearTbArticulos.Size = new System.Drawing.Size(75, 23);
            this.BtnCrearTbArticulos.TabIndex = 112;
            this.BtnCrearTbArticulos.Text = "&Crear";
            this.BtnCrearTbArticulos.UseVisualStyleBackColor = true;
            // 
            // BtnExaminarB
            // 
            this.BtnExaminarB.Location = new System.Drawing.Point(440, 33);
            this.BtnExaminarB.Name = "BtnExaminarB";
            this.BtnExaminarB.Size = new System.Drawing.Size(75, 23);
            this.BtnExaminarB.TabIndex = 111;
            this.BtnExaminarB.Text = "&Examinar";
            this.BtnExaminarB.UseVisualStyleBackColor = true;
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
            // NombreArchivoDatos
            // 
            this.NombreArchivoDatos.Location = new System.Drawing.Point(152, 35);
            this.NombreArchivoDatos.Name = "NombreArchivoDatos";
            this.NombreArchivoDatos.ReadOnly = true;
            this.NombreArchivoDatos.Size = new System.Drawing.Size(271, 20);
            this.NombreArchivoDatos.TabIndex = 109;
            this.NombreArchivoDatos.Tag = "";
            this.NombreArchivoDatos.Text = "Datos App Peloscalvo";
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
            // SerieArticulosText
            // 
            this.SerieArticulosText.DisplayMember = "A";
            this.SerieArticulosText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SerieArticulosText.FormattingEnabled = true;
            this.SerieArticulosText.Items.AddRange(new object[] {
            "Tarifa De Articulos 1",
            "Tarifa De Articulos 2",
            "Tarifa De Articulos 3",
            "Tarifa De Articulos 4",
            "Tarifa De Articulos 5"});
            this.SerieArticulosText.Location = new System.Drawing.Point(152, 72);
            this.SerieArticulosText.Name = "SerieArticulosText";
            this.SerieArticulosText.Size = new System.Drawing.Size(300, 21);
            this.SerieArticulosText.TabIndex = 100;
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
            // SerieClientesText2
            // 
            this.SerieClientesText2.DisplayMember = "A";
            this.SerieClientesText2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SerieClientesText2.FormattingEnabled = true;
            this.SerieClientesText2.Items.AddRange(new object[] {
            "Listado De Clientes 1",
            "Listado De Clientes 1",
            "Listado De Clientes 1",
            "Listado De Clientes 1",
            "Listado De Clientes 1"});
            this.SerieClientesText2.Location = new System.Drawing.Point(152, 112);
            this.SerieClientesText2.Name = "SerieClientesText2";
            this.SerieClientesText2.Size = new System.Drawing.Size(300, 21);
            this.SerieClientesText2.TabIndex = 101;
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
            // TipoExtension_b
            // 
            this.TipoExtension_b.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoExtension_b.FormattingEnabled = true;
            this.TipoExtension_b.Items.AddRange(new object[] {
            "accdb",
            "mdb"});
            this.TipoExtension_b.Location = new System.Drawing.Point(357, 139);
            this.TipoExtension_b.Name = "TipoExtension_b";
            this.TipoExtension_b.Size = new System.Drawing.Size(95, 21);
            this.TipoExtension_b.TabIndex = 106;
            // 
            // BtnRestablecer
            // 
            this.BtnRestablecer.BackColor = System.Drawing.Color.DarkKhaki;
            this.BtnRestablecer.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnRestablecer.Location = new System.Drawing.Point(732, 228);
            this.BtnRestablecer.Name = "BtnRestablecer";
            this.BtnRestablecer.Size = new System.Drawing.Size(75, 23);
            this.BtnRestablecer.TabIndex = 116;
            this.BtnRestablecer.Text = "&Restablecer";
            this.BtnRestablecer.UseVisualStyleBackColor = false;
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
            // FormCrearTablasDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 469);
            this.Controls.Add(this.BtnSalirT);
            this.Controls.Add(this.BtnRestablecer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Info_Res);
            this.Controls.Add(this.BtnCrearTbCliente);
            this.Controls.Add(this.BtnCrearTbArticulos);
            this.Controls.Add(this.BtnExaminarB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NombreArchivoDatos);
            this.Controls.Add(labelARTICULOS);
            this.Controls.Add(labelCLIENTES);
            this.Controls.Add(this.SerieArticulosText);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SerieClientesText2);
            this.Controls.Add(tipoExtensionArticulosLabel);
            this.Controls.Add(this.TipoExtension_b);
            this.Name = "FormCrearTablasDb";
            this.Text = "FormCrearTablasDb";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnTablas;
        private System.Windows.Forms.Label Info_Res;
        private System.Windows.Forms.Button BtnCrearTbCliente;
        private System.Windows.Forms.Button BtnCrearTbArticulos;
        private System.Windows.Forms.Button BtnExaminarB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NombreArchivoDatos;
        public System.Windows.Forms.ComboBox SerieArticulosText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ContadorFactu;
        private System.Windows.Forms.Label ContadorArticulos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label RegistLbel;
        private System.Windows.Forms.Label ContadorClientes;
        public System.Windows.Forms.ComboBox SerieClientesText2;
        public System.Windows.Forms.ComboBox TipoExtension_b;
        private System.Windows.Forms.Button BtnRestablecer;
        private System.Windows.Forms.Button BtnSalirT;
    }
}