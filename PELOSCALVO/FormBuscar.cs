using System;
using System.Data;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormBuscar : Form
    {
        public static FormBuscar MenuB;
        public static string ColumnaB = "";
        public static int Fila = 0;
        DataView verViev = default;
        public FormBuscar()
        {
            InitializeComponent();
            FormBuscar.MenuB = this;
        }

        private void FormBuscar_Load(object sender, EventArgs e)
        {
            if (FormMenuPrincipal.menu2principal.dsMulti2 != null)
            {
                if (ClasDatos.QUEform == "Paises")
                {
                    this.verViev = FormMenuPrincipal.menu2principal.dsMulti2.DtPaises.DefaultView;
                    // BindingBuscarSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2.DtPaises;
                    this.DataGridBuscar.DataSource = FormMenuPrincipal.menu2principal.dsMulti2.DtPaises;
                }
                if (ClasDatos.QUEform == "Provincias")
                {
                    this.verViev = FormMenuPrincipal.menu2principal.dsMulti2.DtProvincias.DefaultView;
                    // BindingBuscarSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2.DtPaises;
                    this.DataGridBuscar.DataSource = FormMenuPrincipal.menu2principal.dsMulti2.DtProvincias;
                }
            }

            // this.BindingBuscarSource.DataSource = DataSourceDatos;
            // this.DataGridBuscar.Columns[1].HeaderText = Columna;


        }
        public void CargarDatos(int IdFila, string Nombrefila, string colunma)
        {
            this.Text = Nombrefila;
            Fila = IdFila;
            ColumnaB = colunma;
            this.DataGridBuscar.Columns[1].HeaderText = Nombrefila;
            this.DataGridBuscar.Columns[0].DataPropertyName = "Id";
            this.DataGridBuscar.Columns[1].DataPropertyName = colunma;
            this.DataGridBuscar.Columns[2].DataPropertyName = "IdFila";
        }
        public void BuscarDatos()
        {
            // this.BindingBuscarSource.DataSource = Formulirio;
            try
            {
                //this.DataGridBuscar.Columns[Fila].HeaderText = Columna;
                if (this.TipoBuscar2.SelectedIndex == 0)
                {
                    this.verViev.RowFilter = ColumnaB + " LIKE '%" + this.Buscador2.Text + "%'";

                }

                if (this.TipoBuscar2.SelectedIndex == 1)//referencia
                {




                }
                this.DataGridBuscar.DataSource = this.verViev;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

            //this.DataGridBuscar.DataSource = this.BindingBuscarSource;
            this.Contador3.Text = string.Format("{0:N0" + "}", ((this.DataGridBuscar.Rows.Count).ToString()));
        }

        private void DataGridBuscar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                try
                {
                    ClasDatos.ValorBuscado = Convert.ToInt32(this.DataGridBuscar.Rows[e.RowIndex].Cells["IdFila"].Value);
                    if (ClasDatos.ValorBuscado >= 0)
                    {
                        if (ClasDatos.QUEform == "Paises")
                        {
                            FormPaises.MenuB.dataGridPais.CurrentCell = this.DataGridBuscar.Rows[ClasDatos.ValorBuscado].Cells[0];
                            FormPaises.MenuB.dataGridPais.CurrentCell.Selected = true;
                        }

                    }
                    if (ClasDatos.QUEform == "Provincias")
                    {
                        FormProvincias.MenuB.dataGridProvincias.CurrentCell = this.DataGridBuscar.Rows[ClasDatos.ValorBuscado].Cells[0];
                        FormProvincias.MenuB.dataGridProvincias.CurrentCell.Selected = true;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            }

        }

        private void Buscador2_TextChanged(object sender, EventArgs e)
        {
            BuscarDatos();
        }
    }
}
