using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
        }
        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
              string CadenaConexion = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            Properties.Settings leer = new Properties.Settings() ;
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
            }
            catch (Exception)
            {

               // throw;
            }
        }
    }
}
