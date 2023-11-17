using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormCrearTablasDb : Form
    {
        public FormCrearTablasDb()
        {
            InitializeComponent();
        }

        private void BtnSalirT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" ¿Salir Crear TAblas ? ", " Tablas ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
