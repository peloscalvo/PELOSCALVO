using System;
using System.Data;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormBuscar : Form
    {
        public static FormBuscar MenuB;
        public static string ColumnaPrincipal = "";
        public static string ColumnaSecundaria = "";
        public static int Fila = 0;
        public static int IdBuscar = 0;
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
                        this.DataGridBuscar.DataSource = this.verViev;
                    }
                    if (ClasDatos.QUEform == "Provincias")
                    {
                        this.verViev = FormMenuPrincipal.menu2principal.dsMulti2.DtProvincias.DefaultView;
                        this.DataGridBuscar.DataSource = this.verViev;
                    }
                    if (ClasDatos.QUEform == "Obras")
                    {

                        this.verViev = FormMenuPrincipal.menu2principal.dsMulti2.DtObras.DefaultView;
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
                    if (ClasDatos.QUEform == "Ejercicio")
                    {
                        this.verViev = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfi.DefaultView;
                        this.DataGridBuscar.DataSource = this.verViev;
                    }

                }
                if (ClasDatos.OkFacturar == true)
                {
                    if (FormFacturar.menu2FACTURAR.dsFacturas.DtNuevaFactura != null)
                    {
                        if (ClasDatos.QUEform == "FACTURA")
                        {
                            this.verViev = FormFacturar.menu2FACTURAR.dsFacturas.DtNuevaFactura.DefaultView;
                            this.DataGridBuscar.DataSource = this.verViev;
                        }
                    }
                }
                FiltrarDatos();
                //this.verViev.RowFilter = "";             
                this.ContadorBus.Text = string.Format("{0:N0" + "}", (Convert.ToInt32(this.DataGridBuscar.Rows.Count).ToString()));
                this.Buscador2.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Buscador2.Focus();

        }

        public void CargarDatos(int IdFila, string Nombrefila, string colunma, string colunma2, int IdB)
        {
            try
            {

                this.DataGridBuscar.AutoGenerateColumns = false;
                this.Text = Nombrefila;
                Fila = IdFila;
                ColumnaPrincipal = colunma;
                ColumnaSecundaria = colunma2;
                IdBuscar = IdB;
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
        public void FiltrarDatos()
        {
            // this.BindingBuscarSource.DataSource = Formulirio;
            try
            {
                if (ClasDatos.QUEform == "Provincias" | ClasDatos.QUEform == "Almacen" | ClasDatos.QUEform == "Proveedores" | ClasDatos.QUEform == "Ejercicio")
                {
                    this.verViev.RowFilter = "[" + ColumnaPrincipal + "]" + " LIKE '%" + this.Buscador2.Text + "%'" + "and " + "[" + ColumnaSecundaria + "] =" + IdBuscar;
                }
                else
                {
                    this.verViev.RowFilter = "[" + ColumnaPrincipal + "]" + " LIKE '%" + this.Buscador2.Text + "%'";
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
                this.DataGridBuscar.DataSource = this.verViev;
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
                            if (ClasDatos.QUEform == "FACTURA")
                            {
                                FormFacturar.menu2FACTURAR.dtNuevaFacturaDataGridView.CurrentCell = FormFacturar.menu2FACTURAR.dtNuevaFacturaDataGridView.Rows[ClasDatos.ValorBuscado].Cells[0];
                            }
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
                  // this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Buscador2_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }
    }
}
