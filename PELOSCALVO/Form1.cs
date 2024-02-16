using System;
using System.Configuration;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Properties.Settings.Default.UserVictor))
                {

                   this.InfoTxt.Text=  Properties.Settings.Default.UserVictor;

                }
            }
            catch (Exception)
            {

               // throw;
            }
        }
        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string CadenaConexion = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            Properties.Settings leer = new Properties.Settings();
            // leer.UserVictor=""
            if (Properties.Settings.Default.UserVictor == "" || Properties.Settings.Default.UserVictor == "")
            {
                // loginForm.Show();
                //if (loginForm.IBContinue == true)
                //{
                //    //continue;
                //}
            }
            Properties.Settings.Default.UserVictor = "fsdfdsffdsffsd";
            Properties.Settings.Default.Save();
            // string aa=UserVictor
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string CadenaConexion = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                Properties.Settings leer = new Properties.Settings();
                // leer.UserVictor=""
                if (Properties.Settings.Default.UserVictor == "" || Properties.Settings.Default.UserVictor == "")
                {
                    // loginForm.Show();
                    //if (loginForm.IBContinue == true)
                    //{
                    //    //continue;
                    //}
                }
                if (!string.IsNullOrEmpty(this.textBox1.Text))
                {

                    Properties.Settings.Default.UserVictor = this.textBox1.Text;

                    Properties.Settings.Default.Save();
                    MessageBox.Show("guardado");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Properties.Settings.Default.UserVictor))
                {

                    this.InfoTxt.Text = Properties.Settings.Default.UserVictor;
                    MessageBox.Show("leido");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
