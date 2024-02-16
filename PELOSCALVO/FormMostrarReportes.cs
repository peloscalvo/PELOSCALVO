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

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            if (ClasDatos.OkFacturar)
            {
                if (FormFacturar.menu2FACTURAR.dsFacturas != null)
                {
                    DtNuevaFacturaBindingSource.DataSource = FormFacturar.menu2FACTURAR.dsFacturas;
                }
            }
        }
    }
}
