
namespace PELOSCALVO
{
    partial class FormEnviarCorreos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnviarCorreos));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Mensage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSuject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCC = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TiempoEspera = new System.Windows.Forms.TextBox();
            this.CorreoEmpresa = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnVerPass = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SmtpCorreo = new System.Windows.Forms.TextBox();
            this.ChekSSL = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ContraseñaCorreo = new System.Windows.Forms.TextBox();
            this.PuertoCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UsuarioCorreo = new System.Windows.Forms.TextBox();
            this.ErrorCorreo = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtCorreoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.TxtNombreCliente = new System.Windows.Forms.ComboBox();
            this.ControlCorreo = new System.Windows.Forms.TabControl();
            this.TabCorreoE = new System.Windows.Forms.TabPage();
            this.InfoProcesoText = new System.Windows.Forms.Label();
            this.ListaDeAdjuntos = new System.Windows.Forms.ListBox();
            this.BtnLimpiarAdjuntos = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnExaminarCorreo = new System.Windows.Forms.Button();
            this.TabConfiCorreo = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.EmpresaTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCorreoBindingSource)).BeginInit();
            this.ControlCorreo.SuspendLayout();
            this.TabCorreoE.SuspendLayout();
            this.TabConfiCorreo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Para:";
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Location = new System.Drawing.Point(697, 425);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(64, 23);
            this.BtnEnviar.TabIndex = 2;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mensaje:";
            // 
            // Mensage
            // 
            this.Mensage.Location = new System.Drawing.Point(54, 85);
            this.Mensage.Multiline = true;
            this.Mensage.Name = "Mensage";
            this.Mensage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Mensage.Size = new System.Drawing.Size(608, 189);
            this.Mensage.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Suject:";
            // 
            // TxtSuject
            // 
            this.TxtSuject.Location = new System.Drawing.Point(54, 59);
            this.TxtSuject.Name = "TxtSuject";
            this.TxtSuject.Size = new System.Drawing.Size(608, 20);
            this.TxtSuject.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CC:";
            // 
            // TxtCC
            // 
            this.TxtCC.Location = new System.Drawing.Point(54, 33);
            this.TxtCC.Name = "TxtCC";
            this.TxtCC.Size = new System.Drawing.Size(608, 20);
            this.TxtCC.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.EmpresaTxt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TiempoEspera);
            this.groupBox1.Controls.Add(this.CorreoEmpresa);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.BtnVerPass);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.SmtpCorreo);
            this.groupBox1.Controls.Add(this.ChekSSL);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ContraseñaCorreo);
            this.groupBox1.Controls.Add(this.PuertoCorreo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.UsuarioCorreo);
            this.groupBox1.Location = new System.Drawing.Point(46, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 212);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(623, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Espera:";
            // 
            // TiempoEspera
            // 
            this.TiempoEspera.Location = new System.Drawing.Point(591, 158);
            this.TiempoEspera.Name = "TiempoEspera";
            this.TiempoEspera.Size = new System.Drawing.Size(77, 20);
            this.TiempoEspera.TabIndex = 23;
            this.TiempoEspera.Text = "45";
            this.TiempoEspera.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TiempoEspera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TiempoEspera_KeyPress);
            // 
            // CorreoEmpresa
            // 
            this.CorreoEmpresa.FormattingEnabled = true;
            this.CorreoEmpresa.Location = new System.Drawing.Point(74, 19);
            this.CorreoEmpresa.Name = "CorreoEmpresa";
            this.CorreoEmpresa.Size = new System.Drawing.Size(511, 21);
            this.CorreoEmpresa.TabIndex = 22;
            this.CorreoEmpresa.SelectedIndexChanged += new System.EventHandler(this.CorreoEmpresa_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "De:";
            // 
            // BtnVerPass
            // 
            this.BtnVerPass.Location = new System.Drawing.Point(510, 120);
            this.BtnVerPass.Name = "BtnVerPass";
            this.BtnVerPass.Size = new System.Drawing.Size(75, 23);
            this.BtnVerPass.TabIndex = 18;
            this.BtnVerPass.Tag = "SI";
            this.BtnVerPass.Text = "Ver";
            this.BtnVerPass.UseVisualStyleBackColor = true;
            this.BtnVerPass.Click += new System.EventHandler(this.BtnVerPass_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(249, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Smtp:";
            // 
            // SmtpCorreo
            // 
            this.SmtpCorreo.Location = new System.Drawing.Point(286, 158);
            this.SmtpCorreo.Name = "SmtpCorreo";
            this.SmtpCorreo.Size = new System.Drawing.Size(299, 20);
            this.SmtpCorreo.TabIndex = 16;
            this.SmtpCorreo.Text = "smtp.gmail.com";
            // 
            // ChekSSL
            // 
            this.ChekSSL.AutoSize = true;
            this.ChekSSL.Checked = true;
            this.ChekSSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChekSSL.Location = new System.Drawing.Point(510, 92);
            this.ChekSSL.Name = "ChekSSL";
            this.ChekSSL.Size = new System.Drawing.Size(46, 17);
            this.ChekSSL.TabIndex = 15;
            this.ChekSSL.Text = "SSL";
            this.ChekSSL.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Puerto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Contraseña:";
            // 
            // ContraseñaCorreo
            // 
            this.ContraseñaCorreo.Location = new System.Drawing.Point(74, 122);
            this.ContraseñaCorreo.Name = "ContraseñaCorreo";
            this.ContraseñaCorreo.PasswordChar = '*';
            this.ContraseñaCorreo.Size = new System.Drawing.Size(420, 20);
            this.ContraseñaCorreo.TabIndex = 11;
            // 
            // PuertoCorreo
            // 
            this.PuertoCorreo.Location = new System.Drawing.Point(74, 158);
            this.PuertoCorreo.Name = "PuertoCorreo";
            this.PuertoCorreo.Size = new System.Drawing.Size(121, 20);
            this.PuertoCorreo.TabIndex = 13;
            this.PuertoCorreo.Text = "587";
            this.PuertoCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PuertoCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PuertoCorreo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Usuario:";
            // 
            // UsuarioCorreo
            // 
            this.UsuarioCorreo.Location = new System.Drawing.Point(74, 93);
            this.UsuarioCorreo.Name = "UsuarioCorreo";
            this.UsuarioCorreo.Size = new System.Drawing.Size(420, 20);
            this.UsuarioCorreo.TabIndex = 9;
            // 
            // ErrorCorreo
            // 
            this.ErrorCorreo.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Tag = "SI";
            this.button1.Text = "prueba";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.FormattingEnabled = true;
            this.TxtNombreCliente.Location = new System.Drawing.Point(54, 6);
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.Size = new System.Drawing.Size(608, 21);
            this.TxtNombreCliente.TabIndex = 20;
            // 
            // ControlCorreo
            // 
            this.ControlCorreo.Controls.Add(this.TabCorreoE);
            this.ControlCorreo.Controls.Add(this.TabConfiCorreo);
            this.ControlCorreo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlCorreo.Location = new System.Drawing.Point(0, 0);
            this.ControlCorreo.Name = "ControlCorreo";
            this.ControlCorreo.SelectedIndex = 0;
            this.ControlCorreo.Size = new System.Drawing.Size(801, 490);
            this.ControlCorreo.TabIndex = 21;
            // 
            // TabCorreoE
            // 
            this.TabCorreoE.Controls.Add(this.InfoProcesoText);
            this.TabCorreoE.Controls.Add(this.ListaDeAdjuntos);
            this.TabCorreoE.Controls.Add(this.BtnLimpiarAdjuntos);
            this.TabCorreoE.Controls.Add(this.label11);
            this.TabCorreoE.Controls.Add(this.BtnExaminarCorreo);
            this.TabCorreoE.Controls.Add(this.TxtNombreCliente);
            this.TabCorreoE.Controls.Add(this.button1);
            this.TabCorreoE.Controls.Add(this.label1);
            this.TabCorreoE.Controls.Add(this.BtnEnviar);
            this.TabCorreoE.Controls.Add(this.Mensage);
            this.TabCorreoE.Controls.Add(this.label4);
            this.TabCorreoE.Controls.Add(this.label2);
            this.TabCorreoE.Controls.Add(this.TxtCC);
            this.TabCorreoE.Controls.Add(this.TxtSuject);
            this.TabCorreoE.Controls.Add(this.label3);
            this.TabCorreoE.Location = new System.Drawing.Point(4, 22);
            this.TabCorreoE.Name = "TabCorreoE";
            this.TabCorreoE.Padding = new System.Windows.Forms.Padding(3);
            this.TabCorreoE.Size = new System.Drawing.Size(793, 464);
            this.TabCorreoE.TabIndex = 0;
            this.TabCorreoE.Text = "Enviar";
            this.TabCorreoE.UseVisualStyleBackColor = true;
            // 
            // InfoProcesoText
            // 
            this.InfoProcesoText.AutoSize = true;
            this.InfoProcesoText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InfoProcesoText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoProcesoText.Location = new System.Drawing.Point(3, 436);
            this.InfoProcesoText.Margin = new System.Windows.Forms.Padding(3);
            this.InfoProcesoText.Name = "InfoProcesoText";
            this.InfoProcesoText.Padding = new System.Windows.Forms.Padding(2, 4, 2, 5);
            this.InfoProcesoText.Size = new System.Drawing.Size(40, 25);
            this.InfoProcesoText.TabIndex = 99;
            this.InfoProcesoText.Text = "Listo";
            // 
            // ListaDeAdjuntos
            // 
            this.ListaDeAdjuntos.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaDeAdjuntos.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ListaDeAdjuntos.FormattingEnabled = true;
            this.ListaDeAdjuntos.HorizontalScrollbar = true;
            this.ListaDeAdjuntos.ItemHeight = 20;
            this.ListaDeAdjuntos.Location = new System.Drawing.Point(54, 306);
            this.ListaDeAdjuntos.MultiColumn = true;
            this.ListaDeAdjuntos.Name = "ListaDeAdjuntos";
            this.ListaDeAdjuntos.Size = new System.Drawing.Size(527, 124);
            this.ListaDeAdjuntos.TabIndex = 98;
            // 
            // BtnLimpiarAdjuntos
            // 
            this.BtnLimpiarAdjuntos.Location = new System.Drawing.Point(598, 310);
            this.BtnLimpiarAdjuntos.Name = "BtnLimpiarAdjuntos";
            this.BtnLimpiarAdjuntos.Size = new System.Drawing.Size(64, 23);
            this.BtnLimpiarAdjuntos.TabIndex = 97;
            this.BtnLimpiarAdjuntos.Text = "&Limpiar";
            this.BtnLimpiarAdjuntos.UseVisualStyleBackColor = true;
            this.BtnLimpiarAdjuntos.Click += new System.EventHandler(this.BtnLimpiarAdjuntos_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(300, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 16);
            this.label11.TabIndex = 96;
            this.label11.Text = "Archivos Adjuntos";
            // 
            // BtnExaminarCorreo
            // 
            this.BtnExaminarCorreo.Location = new System.Drawing.Point(668, 310);
            this.BtnExaminarCorreo.Name = "BtnExaminarCorreo";
            this.BtnExaminarCorreo.Size = new System.Drawing.Size(75, 23);
            this.BtnExaminarCorreo.TabIndex = 95;
            this.BtnExaminarCorreo.Text = "&Examinar";
            this.BtnExaminarCorreo.UseVisualStyleBackColor = true;
            this.BtnExaminarCorreo.Click += new System.EventHandler(this.BtnExaminarCorreo_Click);
            // 
            // TabConfiCorreo
            // 
            this.TabConfiCorreo.Controls.Add(this.groupBox1);
            this.TabConfiCorreo.Location = new System.Drawing.Point(4, 22);
            this.TabConfiCorreo.Name = "TabConfiCorreo";
            this.TabConfiCorreo.Padding = new System.Windows.Forms.Padding(3);
            this.TabConfiCorreo.Size = new System.Drawing.Size(793, 464);
            this.TabConfiCorreo.TabIndex = 1;
            this.TabConfiCorreo.Text = "Configuracion";
            this.TabConfiCorreo.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Empresa:";
            // 
            // EmpresaTxt
            // 
            this.EmpresaTxt.Location = new System.Drawing.Point(74, 57);
            this.EmpresaTxt.Name = "EmpresaTxt";
            this.EmpresaTxt.Size = new System.Drawing.Size(420, 20);
            this.EmpresaTxt.TabIndex = 25;
            // 
            // FormEnviarCorreos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 502);
            this.Controls.Add(this.ControlCorreo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEnviarCorreos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Correo Eletronico";
            this.Load += new System.EventHandler(this.FormCorreo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCorreoBindingSource)).EndInit();
            this.ControlCorreo.ResumeLayout(false);
            this.TabCorreoE.ResumeLayout(false);
            this.TabCorreoE.PerformLayout();
            this.TabConfiCorreo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Mensage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSuject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SmtpCorreo;
        private System.Windows.Forms.CheckBox ChekSSL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ContraseñaCorreo;
        private System.Windows.Forms.TextBox PuertoCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UsuarioCorreo;
        private System.Windows.Forms.Button BtnVerPass;
        private System.Windows.Forms.ErrorProvider ErrorCorreo;
        public System.Windows.Forms.BindingSource dtCorreoBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox TxtNombreCliente;
        private System.Windows.Forms.ComboBox CorreoEmpresa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TiempoEspera;
        private System.Windows.Forms.TabControl ControlCorreo;
        private System.Windows.Forms.TabPage TabCorreoE;
        private System.Windows.Forms.TabPage TabConfiCorreo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnExaminarCorreo;
        private System.Windows.Forms.Button BtnLimpiarAdjuntos;
        private System.Windows.Forms.ListBox ListaDeAdjuntos;
        private System.Windows.Forms.Label InfoProcesoText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox EmpresaTxt;
    }
}

