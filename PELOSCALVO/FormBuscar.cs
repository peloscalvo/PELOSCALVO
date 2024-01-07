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
            try
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
                        //this.DataGridBuscar.Columns[3].Visible = false;
                    }

                    if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION != null)
                    {
                        if (ClasDatos.QUEform == "Almacen")
                        {

                            this.verViev = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtAlmacenes.DefaultView;
                            // BindingBuscarSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2.DtPaises;
                            this.DataGridBuscar.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtAlmacenes;
                        }
                    }
                }
               // AñadirIdBuscar();
                Buscador2.Focus();
                // this.BindingBuscarSource.DataSource = DataSourceDatos;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        public void AñadirIdBuscar()
        {
            int ii = 0;
            foreach (DataGridViewRow fila in this.DataGridBuscar.Rows)
            {
                fila.Cells["IdFila"].Value = ii.ToString();
                ii++;
            }

        }

        public void CargarDatos(int IdFila, string Nombrefila, string colunma)
        {
            try
            {
                DataGridBuscar.AutoGenerateColumns = false;
                this.Text = Nombrefila;
                Fila = IdFila;
                ColumnaB = colunma;
                this.DataGridBuscar.Columns[0].DataPropertyName = "Id";
                this.DataGridBuscar.Columns[1].HeaderText = Nombrefila;
                this.DataGridBuscar.Columns[1].DataPropertyName = colunma;
                this.DataGridBuscar.Columns[2].DataPropertyName = "IdFila";
                //this.DataGridBuscar.Columns.Add("IdFila", "Id_F");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR AL CARGAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Buscador2_TextChanged(object sender, EventArgs e)
        {
            BuscarDatos();
        }
    }
}
