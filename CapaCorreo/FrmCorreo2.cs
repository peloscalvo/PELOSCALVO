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

namespace CapaCorreo
{
    public partial class FormCorreo : Form
    {
        NetworkCredential login;
        SmtpClient ClienteCorreo;
        MailMessage MensageCorreo;
        public static FormCorreo menu;
        public FormCorreo()
        {
            InitializeComponent();
            FormCorreo.menu = this;
        }

        private void FormCorreo_Load(object sender, EventArgs e)
        {

        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            borrarCorreoEnv();
            if (ValidarCorreoEnv())
            {
                try
                {
                    login = new NetworkCredential(UsuarioCorreo.Text, ContraseñaCorreo.Text);
                    ClienteCorreo = new SmtpClient(StmpCorreo.Text);
                    ClienteCorreo.Port = Convert.ToInt32(PuertoCorreo.Text);
                    ClienteCorreo.EnableSsl = ChekSSL.Checked;
                    ClienteCorreo.Credentials = login;
                    MensageCorreo = new MailMessage { From = new MailAddress(UsuarioCorreo.Text + StmpCorreo.Text.Replace("smptp.", "@"), UsuarioCorreo.Text, Encoding.UTF8) };
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
            if (StmpCorreo.Text == string.Empty)
            {
                ok = false;
                ErrorCorreo.SetError(StmpCorreo, "Campo Vacio Rellene");
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
    }
}
