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
        DataView firstView = new DataView(FormMenuPrincipal.menu2principal.dsMulti2.DtProvincias);
        BindingSource Bd = new BindingSource();
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
                        this.DataGridBuscar.DataSource = FormMenuPrincipal.menu2principal.dsMulti2.DtPaises;
                        this.verViev = FormMenuPrincipal.menu2principal.dsMulti2.DtPaises.DefaultView;
                        // BindingBuscarSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2.DtPaises;
                    }
                    if (ClasDatos.QUEform == "Provincias")
                    {
                        this.Bd.DataSource = FormProvincias.MenuB.dataGridProvincias.DataSource;

                        // firstView.Table = new BindingSource(FormFacturar.menu2FACTURAR.dtArticulosBindingSource.DataSource);
                        this.verViev = FormMenuPrincipal.menu2principal.dsMulti2.DtProvincias.DefaultView;
                        // BindingBuscarSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2.DtPaises;
                       // this.DataGridBuscar.DataSource = FormMenuPrincipal.menu2principal.dsMulti2.DtProvincias;
                        // this.DataGridBuscar.DataSource =FormProvincias.MenuB.dataGridProvincias.DataSource;
                        // this.verViev.RowFilter = "[fff]" + " LIKE '%" + this.BuscarArticulosText.Text + "%'"; 
                        //this.DataGridBuscar.Columns[3].Visible = false;
                    }
                    if (ClasDatos.QUEform == "Obras")
                    {

                        this.verViev = FormMenuPrincipal.menu2principal.dsMulti2.DtObras.DefaultView;
                        // BindingBuscarSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2.DtPaises;Proveedores
                        this.DataGridBuscar.DataSource = FormMenuPrincipal.menu2principal.dsMulti2.DtObras;
                    }
                    if (ClasDatos.QUEform == "Familia")
                    {
                        this.verViev = FormMenuPrincipal.menu2principal.dsMulti2.DtFamiliaProductos.DefaultView;
                        this.DataGridBuscar.DataSource = FormMenuPrincipal.menu2principal.dsMulti2.DtFamiliaProductos;
                    }

                }
                if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION != null)
                {
                    if (ClasDatos.QUEform == "Almacen")
                    {
                        this.verViev = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtAlmacenes.DefaultView;
                        this.DataGridBuscar.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtAlmacenes;
                    }
                    if (ClasDatos.QUEform == "Proveedores")
                    {
                        this.verViev = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtProveedores.DefaultView;
                        this.DataGridBuscar.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtProveedores;
                    }

                }
                this.verViev.RowFilter = "";
                this.Buscador2.Focus();
                this.ContadorBus.Text = string.Format("{0:N0" + "}", (Convert.ToInt32(this.DataGridBuscar.Rows.Count).ToString()));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Buscador2.Focus();

        }
        public void AñadirIdBuscar()
        {
            int ii = 0;
            foreach (DataGridViewRow fila in this.DataGridBuscar.Rows)
            {
                // fila.Cells["IdFila"].Value = ii.ToString();
                ii++;
            }

        }

        public void CargarDatos(int IdFila, string Nombrefila, string colunma)
        {
            try
            {

                this.DataGridBuscar.AutoGenerateColumns = false;
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
                if (ClasDatos.QUEform == "Provincias")
                {
                    this.Bd.Filter = ColumnaB + " LIKE '%" + this.Buscador2.Text + "%'";
                }
                //this.DataGridBuscar.Columns[Fila].HeaderText = Columna;
                if (this.TipoBuscar2.SelectedIndex == 0)
                {
                  //  this.verViev.RowFilter = ColumnaB + " LIKE '%" + this.Buscador2.Text + "%'";
                }

                if (this.TipoBuscar2.SelectedIndex == 1)//referencia
                {


                   // this.verViev.RowFilter = ColumnaB + " LIKE '%" + this.Buscador2.Text + "%'";

                }
                this.DataGridBuscar.DataSource = Bd;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //this.DataGridBuscar.DataSource = this.BindingBuscarSource;
            this.ContadorBus.Text = string.Format("{0:N0" + "}", (this.DataGridBuscar.Rows.Count).ToString());
        }

        private void DataGridBuscar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                try
                {
                    ClasDatos.ValorBuscado = Convert.ToInt32(this.DataGridBuscar.Rows[e.RowIndex].Cells[2].Value);

                    if (ClasDatos.ValorBuscado >= 0)
                    {
                        if (ClasDatos.OkFacturar == true)
                        {
                            if (ClasDatos.QUEform == "Paises")
                            {
                                FormFacturar.menu2FACTURAR.PaisFatuTxt.Text = this.DataGridBuscar.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                            }
                            if (ClasDatos.QUEform == "Provincias")
                            {
                                FormFacturar.menu2FACTURAR.ProvinciaTxt.Text = this.DataGridBuscar.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                            }
                        }
                        else
                        {
                            if (ClasDatos.QUEform == "Paises")
                            {
                                FormPaises.MenuB.dataGridPais.CurrentCell.Selected = false;
                                FormPaises.MenuB.dataGridPais.CurrentCell = FormPaises.MenuB.dataGridPais.Rows[ClasDatos.ValorBuscado].Cells[0];
                                FormPaises.MenuB.dataGridPais.CurrentCell.Selected = true;
                            }
                            if (ClasDatos.QUEform == "Provincias")
                            {
                                FormProvincias.MenuB.dataGridProvincias.CurrentCell = FormProvincias.MenuB.dataGridProvincias.Rows[ClasDatos.ValorBuscado].Cells[0];
                                FormProvincias.MenuB.dataGridProvincias.CurrentCell.Selected = true;
                            }
                            if (ClasDatos.QUEform == "Obras")
                            {
                                FormObras.MenuB.dataGridObras.CurrentCell = FormObras.MenuB.dataGridObras.Rows[ClasDatos.ValorBuscado].Cells[0];
                                FormObras.MenuB.dataGridObras.CurrentCell.Selected = true;
                            }
                            if (ClasDatos.QUEform == "Familia")
                            {
                                FormFamiliaProductos.MenuB.DataGridFamilia.CurrentCell = FormFamiliaProductos.MenuB.DataGridFamilia.Rows[ClasDatos.ValorBuscado].Cells[0];
                                FormFamiliaProductos.MenuB.DataGridFamilia.CurrentCell.Selected = true;
                            }
                            if (ClasDatos.QUEform == "Proveedores")//Proveedores
                            {
                                FormProveedores.MenuB.dataGridProveedores.CurrentCell = FormProveedores.MenuB.dataGridProveedores.Rows[ClasDatos.ValorBuscado].Cells[0];
                                FormProveedores.MenuB.dataGridProveedores.CurrentCell.Selected = true;
                            }
                        }



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
