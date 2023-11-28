using System;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormReporteFactura : Form
    {
        public static FormReporteFactura menu2Reporte;
        public FormReporteFactura()
        {
            InitializeComponent();
            //this.NumeroFACTURA = NumeroFACTURA;
            FormReporteFactura.menu2Reporte = this;
        }

        private void FormReporteFactura_Load(object sender, EventArgs e)
        {
              this.reportViewer1.RefreshReport();      
            DtDetallesFacturaBindingSource.DataSource = FormFacturar.menu2FACTURAR.dtDetallesFacturaBindingSource;
            DtNuevaFacturaBindingSource.DataSource = FormFacturar.menu2FACTURAR.dtNuevaFacturaBindingSource.Current;
            dtConfiguracionPrincipalBindingSource.DataSource = FormFacturar.menu2FACTURAR.dtConfiguracionPrincipalBindingSource.Current;
            //DtNuevaFacturaBindingSource.DataSource = (FormFACTURAR.menu2FACTURAR.dtNuevaFacturaDataGridView);
        
        }

        private void FormReporteFactura_FormClosed(object sender, FormClosedEventArgs e)
        {

            DtDetallesFacturaBindingSource.DataSource = null;
            DtNuevaFacturaBindingSource.DataSource = null;
            //DtDetallesFacturaBindingSource.ResetBindings(false);
           // dtfacturasBindingSource.ResetBindings(true);
            //DtDetallesFacturaBindingSource.Remove();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
