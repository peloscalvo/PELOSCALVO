using System;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormMostrarReportes : Form
    {
        public FormMostrarReportes()
        {
            InitializeComponent();
        }

        private void FormMostrarReportes_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
