using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;

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
                if (FormMenuPrincipal.menu2principal.dsCorreos != null)
                {
                    CorreoEmpresa.DisplayMember = "CorreoEletronico";
                    CorreoEmpresa.DataSource = FormMenuPrincipal.menu2principal.DtCorreos;           
                }
                if (File.Exists(Rutacorreos))
                {
                    FormMenuPrincipal.menu2principal.dsCorreos.ReadXml(Rutacorreos);

                }
                else
                {
                    MessageBox.Show("Falta Archivo " + "\n" + ClasDatos.RutaMultidatos, "ARCHIVO NO EXISTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    // this.BtnBuscarServidor.Enabled = false;
                    // this.BtnGuardarDatosArchivos.Enabled = false;
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
                    login = new NetworkCredential(UsuarioCorreo.Text, ContraseñaCorreo.Text);
                    ClienteCorreo = new SmtpClient(SmtpCorreo.Text);
                    ClienteCorreo.Port = Convert.ToInt32(PuertoCorreo.Text);
                    ClienteCorreo.EnableSsl = ChekSSL.Checked;
                    ClienteCorreo.Credentials = login;
                    ClienteCorreo.Timeout =Convert.ToInt32( TiempoEspera.Text);
                    MensageCorreo = new MailMessage { From = new MailAddress(CorreoEmpresa.Text + SmtpCorreo.Text.Replace("smptp.", "@"), CorreoEmpresa.Text, Encoding.UTF8) };
                  
                    MensageCorreo.To.Add(new MailAddress(TxtNombreCliente.Text));
                    if (!string.IsNullOrEmpty(TxtCC.Text))
                    {
                        MensageCorreo.To.Add(TxtCC.Text);

                    }
                    // MensageCorreo.Attachments.Add("faf")
                
                    MensageCorreo.Subject = TxtSuject.Text;
                    MensageCorreo.Body = Mensage.Text;
                    MensageCorreo.BodyEncoding = Encoding.UTF8;
                    MensageCorreo.IsBodyHtml = true;
                    MensageCorreo.Priority = MailPriority.Normal;
                    MensageCorreo.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                    ClienteCorreo.SendCompleted += new SendCompletedEventHandler(EnviarCorreo);
                    string Stado = " Enviando....";
                    ClienteCorreo.SendAsync(MensageCorreo, Stado);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private static void EnviarCorreo(object sender,AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show(e.UserState+" Cancelado","CANCELADO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if(e.Error != null)
            {
                MessageBox.Show(String.Format(" {0}{1} " ,e.UserState , e.Error), "CANCELADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(e.UserState + " Enviado Con Exito", "Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private  bool ValidarCorreoEnv()
        {
            bool ok = true;
            if (TxtNombreCliente.Text == string.Empty)
            {
                ok = false;
                ErrorCorreo.SetError ( TxtNombreCliente, "Campo Vacio Rellene");
            }
            if (UsuarioCorreo.Text == string.Empty)
            {
                ok = false;
                ErrorCorreo.SetError(UsuarioCorreo, "Campo Vacio Rellene");
            }
            if (ContraseñaCorreo.Text == string.Empty)
            {
                ok = false;
                ErrorCorreo.SetError(ContraseñaCorreo, "Campo Vacio Rellene");
            }
            if (PuertoCorreo.Text == string.Empty)
            {
                ok = false;
                ErrorCorreo.SetError(PuertoCorreo, "Campo Vacio Rellene");
            }
            if (SmtpCorreo.Text == string.Empty)
            {
                ok = false;
                ErrorCorreo.SetError(SmtpCorreo, "Campo Vacio Rellene");
            }
            return ok;
        }
        private void borrarCorreoEnv()
        {
                ErrorCorreo.SetError(TxtNombreCliente, "");
                ErrorCorreo.SetError(UsuarioCorreo, "");
            ErrorCorreo.SetError(ContraseñaCorreo, "");
                ErrorCorreo.SetError(PuertoCorreo, "");
        }
        private void BtnVerPass_Click(object sender, EventArgs e)
        {
            if (BtnVerPass.Tag.ToString() == "SI")
            {
                ContraseñaCorreo.Tag= "NO";
                ContraseñaCorreo.PasswordChar = '\0';
                BtnEnviar.Text = "Ocultar";
            }
            else
            {
                ContraseñaCorreo.PasswordChar = '*';
                ContraseñaCorreo.Tag = "SI";
                BtnEnviar.Text = "Ver";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(Directory.GetCurrentDirectory());
        }
        private void LimpiarCamposEmpresa()
        {
            UsuarioCorreo.Text = string.Empty;
            ContraseñaCorreo.Text = string.Empty;
            PuertoCorreo.Text = string.Empty;
            SmtpCorreo.Text = string.Empty;
        }
        private void CorreoEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CorreoEmpresa.SelectedIndex >= 0)
            {
                LimpiarCamposEmpresa();
                int II = CorreoEmpresa.SelectedIndex;
                var fila = FormMenuPrincipal.menu2principal.dsCorreos;
                if (fila.Tables["Dtcorreos"].Rows[II]["smtp"].ToString() != string.Empty)
                {
                    SmtpCorreo.Text = fila.Tables["DtCorreos"].Rows[II]["smtp"].ToString();
                }
                if (fila.Tables["Dtcorreos"].Rows[II]["Usuario"].ToString() != string.Empty)
                {
                    UsuarioCorreo.Text = fila.Tables["DtCorreos"].Rows[II]["Usuario"].ToString();
                }
                if (fila.Tables["Dtcorreos"].Rows[II]["Contraseña"].ToString() != string.Empty)
                {
                    ContraseñaCorreo.Text = fila.Tables["DtCorreos"].Rows[II]["Contraseña"].ToString();
                }
                if (fila.Tables["Dtcorreos"].Rows[II]["Puerto"].ToString() != string.Empty)
                {
                    PuertoCorreo.Text = fila.Tables["DtCorreos"].Rows[II]["Puerto"].ToString();
                }
                if (fila.Tables["Dtcorreos"].Rows[II]["Timeof"].ToString() != string.Empty)
                {
                    PuertoCorreo.Text = fila.Tables["DtCorreos"].Rows[II]["Timeof"].ToString();
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
    }
}
