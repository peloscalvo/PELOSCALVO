using System;
using System.Threading;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormBienvenida : Form
    {
        double I = 0.1;
        public static FormBienvenida menu2;
        public FormBienvenida()
        {
            InitializeComponent();
            FormBienvenida.menu2 = this;
            this.TransparencyKey = this.BackColor;
        }
        private void login(object sender, FormClosedEventArgs e)
        {
            Show();
        }
        private void FormBienvenida_Load(object sender, EventArgs e)
        {
           // this.TransparencyKey = this.BackColor;
            TimerStop.Start();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hide();

            //FormMenuPrincipal.menu2principal.Show();

        }

        private void FormBienvenida_FormClosed(object sender, FormClosedEventArgs e)
        {

 
 
        }

        private void FormBienvenida_Activated(object sender, EventArgs e)
        {

        }

        private void FormBienvenida_FormClosing(object sender, FormClosingEventArgs e)
        {
  
           
        }

        private void TimerStop_Tick(object sender, EventArgs e)
        {
            try
            {

                if (I >= 50)
                {
                    this.TimerStop.Stop();
                    //Hide();
                    FormMenuPrincipal frm = new FormMenuPrincipal();
                    frm.Show();
                    frm.BringToFront();
                    frm.Show();
                    Hide();
                }
                else
                {
                    I = I + 0.5;
                }



            }
            catch (Exception)
            {

                // throw;
            }
        }
    }
}
