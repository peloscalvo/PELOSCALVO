using System;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormBuscar : Form
    {
        public static FormBuscar MenuB;
        //public static string Columna = "";
        //public static string DataSourceDatos = "";
        public FormBuscar()
        {
            InitializeComponent();
            FormBuscar.MenuB = this;
        }

        private void FormBuscar_Load(object sender, EventArgs e)
        {
            try
            {
                int ii = 0;
                foreach (DataGridViewRow fila in this.DataGridBuscar.Rows)
                {
                    fila.Cells["IdFila"].Value = ii.ToString();
                    ii++;
                }
            }
            catch (Exception)
            {

               // throw;
            }
           // this.BindingBuscarSource.DataSource = DataSourceDatos;
           // this.DataGridBuscar.Columns[1].HeaderText = Columna;


        }
        public void CargarDatos( BindingSource DatasourceCarga, string fila)
        {
            BindingBuscarSource.DataSource = DatasourceCarga;
            this.DataGridBuscar.Columns[1].HeaderText = fila;
        }
        public void BuscarDatos(string Formulirio, string Colunna)
        {
            this.BindingBuscarSource.DataSource = Formulirio;
            this.DataGridBuscar.Columns[1].HeaderText = Colunna;
            if (this.TipoBuscar2.SelectedIndex == 0)
            {
                this.BindingBuscarSource.Filter = Colunna + " LIKE '%" + this.Buscador2.Text + "%'";

            }

            if (this.TipoBuscar2.SelectedIndex == 1)//referencia
            {




            }

            //this.DataGridBuscar.DataSource = this.BindingBuscarSource;
            this.Contador3.Text = string.Format("{0:N0" + "}", ((this.DataGridBuscar.Rows.Count).ToString()));
        }

        private void DataGridBuscar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ClasDatos.QUEform == "Paises")
            {
                if(e.RowIndex >= 0)
                {
                    ClasDatos.ValorBuscado = Convert.ToInt32(this.DataGridBuscar.Rows[e.RowIndex].Cells["IdFila"].Value);
                    if (ClasDatos.ValorBuscado >= 0)
                    {
                      FormPaises.MenuB.dataGridPais.CurrentCell = DataGridBuscar.Rows[ClasDatos.ValorBuscado].Cells[0];
                        FormPaises.MenuB.dataGridPais.CurrentCell.Selected = true;
                    }
                }
            }
        }
    }
}
