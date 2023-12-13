using Comun;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormEnviarCorreos : Form
    {
        NetworkCredential login;
        SmtpClient ClienteCorreo;
        MailMessage MensageCorreo;
        string Rutacorreos = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + "correos.Xml";
        public static FormEnviarCorreos menu;
        public FormEnviarCorreos()
        {
            InitializeComponent();
            FormEnviarCorreos.menu = this;
        }

        private void FormCorreo_Load(object sender, EventArgs e)
        {
            try
            {
                if (FormMenuPrincipal.menu2principal.DtCorreos != null)
                {
                    this.CorreoEmpresa.DisplayMember = "CorreoEletronico";
                    this.CorreoEmpresa.DataSource = FormMenuPrincipal.menu2principal.DtCorreos;
                }
                if (FormMenuPrincipal.menu2principal.DtCorreosCliente != null)
                {
                    this.TxtNombreCliente.DisplayMember = "CorreoEletronico_cli";
                    this.TxtNombreCliente.DataSource = FormMenuPrincipal.menu2principal.DtCorreosCliente;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            borrarCorreoEnv();
            if (ValidarCorreoEnv())
            {
                try
                {
                    this.InfoProcesoText.BackColor = Color.FromArgb(234, 210, 8);
                    this.InfoProcesoText.Text = " Enviando Datos.............. .......Espere Un Momento !!!!!!!";
                    this.login = new NetworkCredential(this.UsuarioCorreo.Text, this.ContraseñaCorreo.Text);
                    this.ClienteCorreo = new SmtpClient(this.SmtpCorreo.Text);
                    this.ClienteCorreo.Port = Convert.ToInt32(this.PuertoCorreo.Text);
                    this.ClienteCorreo.EnableSsl = this.ChekSSL.Checked;
                    this.ClienteCorreo.Credentials = this.login;
                    this.ClienteCorreo.Timeout = Convert.ToInt32(this.TiempoEspera.Text);
                    this.MensageCorreo = new MailMessage { From = new MailAddress(this.CorreoEmpresa.Text + this.SmtpCorreo.Text.Replace("smptp.", "@"), this.CorreoEmpresa.Text, Encoding.UTF8) };

                    this.MensageCorreo.To.Add(new MailAddress(this.TxtNombreCliente.Text));
                    if (!string.IsNullOrEmpty(this.TxtCC.Text))
                    {
                        this.MensageCorreo.To.Add(this.TxtCC.Text);

                    }
                    // MensageCorreo.Attachments.Add("faf")
                    foreach (var item in this.ListaDeAdjuntos.Items)
                    {
                        if (item.ToString() != string.Empty)
                        {
                            Attachment Archivo_adju = new Attachment(item.ToString());
                            this.MensageCorreo.Attachments.Add(Archivo_adju);
                        }
                    }
                    this.MensageCorreo.Subject = this.TxtSuject.Text;
                    this.MensageCorreo.Body = this.Mensage.Text;
                    this.MensageCorreo.BodyEncoding = Encoding.UTF8;
                    this.MensageCorreo.IsBodyHtml = true;
                    this.MensageCorreo.Priority = MailPriority.Normal;
                    this.MensageCorreo.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                    this.ClienteCorreo.SendCompleted += new SendCompletedEventHandler(EnviarCorreo);
                    string Stado = " Enviando....";
                    this.ClienteCorreo.SendAsync(this.MensageCorreo, Stado);
                   // MessageBox.Show("Mensaje Enviado", "CORREO ELETRONICO");
                    this.InfoProcesoText.Text = "Listo";
                    this.InfoProcesoText.Refresh();
                    this.InfoProcesoText.BackColor = this.BackColor;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private static void EnviarCorreo(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show(e.UserState + " Cancelado", "CANCELADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.Error != null)
            {
                MessageBox.Show(String.Format(" {0}{1} ", e.UserState, e.Error), "CANCELADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(e.UserState + " Enviado Con Exito", "Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool ValidarCorreoEnv()
        {
            bool ok = true;
            if (this.TxtNombreCliente.Text == string.Empty)
            {
                ok = false;
                this.ErrorCorreo.SetError(this.TxtNombreCliente, "Campo Vacio Rellene");
            }
            if (this.UsuarioCorreo.Text == string.Empty)
            {
                ok = false;
                this.ErrorCorreo.SetError(this.UsuarioCorreo, "Campo Vacio Rellene");
            }
            if (this.ContraseñaCorreo.Text == string.Empty)
            {
                ok = false;
                this.ErrorCorreo.SetError(this.ContraseñaCorreo, "Campo Vacio Rellene");
            }
            if (this.PuertoCorreo.Text == string.Empty)
            {
                ok = false;
                this.ErrorCorreo.SetError(this.PuertoCorreo, "Campo Vacio Rellene");
            }
            if (this.SmtpCorreo.Text == string.Empty)
            {
                ok = false;
                this.ErrorCorreo.SetError(this.SmtpCorreo, "Campo Vacio Rellene");
            }
            if (ok == false)
            {
                this.ControlCorreo.SelectedIndex = 1;
            }
            return ok;
        }
        private void borrarCorreoEnv()
        {
            this.ErrorCorreo.SetError(this.TxtNombreCliente, "");
            this.ErrorCorreo.SetError(this.UsuarioCorreo, "");
            this.ErrorCorreo.SetError(this.ContraseñaCorreo, "");
            this.ErrorCorreo.SetError(this.PuertoCorreo, "");
        }
        private void BtnVerPass_Click(object sender, EventArgs e)
        {
            if (this.BtnVerPass.Tag.ToString() == "SI")
            {
                this.BtnVerPass.Tag = "NO";
                this.ContraseñaCorreo.PasswordChar = '\0';
                this.BtnVerPass.Text = "Ocultar";
            }
            else
            {
                this.ContraseñaCorreo.PasswordChar = '*';
                this.BtnVerPass.Tag = "SI";
                this.BtnVerPass.Text = "Ver";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(Directory.GetCurrentDirectory());
        }
        private void LimpiarCamposEmpresa()
        {
            EmpresaTxt.Text = string.Empty;
            this.UsuarioCorreo.Text = string.Empty;
            this.ContraseñaCorreo.Text = string.Empty;
            this.PuertoCorreo.Text = string.Empty;
            this.SmtpCorreo.Text = string.Empty;
            TiempoEspera.Text = string.Empty;
        }
        private void CorreoEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CorreoEmpresa.SelectedIndex >= 0)
            {
                LimpiarCamposEmpresa();
                int II = this.CorreoEmpresa.SelectedIndex;
                var fila = FormMenuPrincipal.menu2principal.dsCorreos;
       
                if (!string.IsNullOrEmpty(fila.Tables["DtCorreos"].Rows[II]["NombreEmpresa"].ToString()))
                {
                    this.EmpresaTxt.Text = fila.Tables["DtCorreos"].Rows[II]["NombreEmpresa"].ToString();
                }

                if (!string.IsNullOrEmpty(fila.Tables["DtCorreos"].Rows[II]["Usuario"].ToString()))
                {
                    this.UsuarioCorreo.Text = fila.Tables["DtCorreos"].Rows[II]["Usuario"].ToString();
                }
          
                if (!string.IsNullOrEmpty(fila.Tables["DtCorreos"].Rows[II]["Contraseña"].ToString()))
                {
                    ClasCodificarPass Decodificar = new ClasCodificarPass();
                    string Pass = Decodificar.Dedificar(fila.Tables["DtCorreos"].Rows[II]["Contraseña"].ToString());
                    this.ContraseñaCorreo.Text = Pass;
                }
                if (!string.IsNullOrEmpty(fila.Tables["DtCorreos"].Rows[II]["smtp"].ToString()))
                {
                    this.SmtpCorreo.Text = fila.Tables["DtCorreos"].Rows[II]["smtp"].ToString();
                }
                if (!string.IsNullOrEmpty(fila.Tables["DtCorreos"].Rows[II]["Puerto"].ToString()))
                {
                    this.PuertoCorreo.Text = fila.Tables["DtCorreos"].Rows[II]["Puerto"].ToString();
                }
                if (!string.IsNullOrEmpty(fila.Tables["DtCorreos"].Rows[II]["Timeof"].ToString()))
                {
                    this.TiempoEspera.Text = fila.Tables["DtCorreos"].Rows[II]["Timeof"].ToString();
                }
  
            }
        }

        private void PuertoCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TiempoEspera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BtnExaminarCorreo_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog BuscarArchivo = new OpenFileDialog();//Datos App Peloscalvo - copia.accdb
                BuscarArchivo.Title = "Buscar Archivo Datos App";
                BuscarArchivo.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                BuscarArchivo.Filter = BuscarArchivo.Filter = @"All Files|*.*|Text File (.txt)|*.txt|access File (.accdb ,.mdb)|*.accdb;*.mdb|PDF (.pdf)|*.pdf|Office Files|*.doc;*.xls;*.ppt|Spreadsheet (.xls ,.xlsx)|  *.xls ;*.xlsx|Presentation (.pptx ,.ppt)|*.pptx;*.ppt";
                if (BuscarArchivo.ShowDialog() == DialogResult.OK)
                {
                    this.ListaDeAdjuntos.Items.Add(Path.GetFullPath(BuscarArchivo.FileName.ToString()));


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Puede Que este Artivo Sea el Correcto" + "\n" + ex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void BtnLimpiarAdjuntos_Click(object sender, EventArgs e)
        {
            this.ListaDeAdjuntos.Items.Clear();
        }
    }
}
