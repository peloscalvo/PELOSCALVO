using Comun;
using Conexiones;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
//using Aspose.Pdf;
//using System.Reflection.Emit;

namespace PELOSCALVO
{
    public partial class FormArticulos : Form
    {
        double Coste = 0;
        double Ganancia = 0;
        double CastiDesc = 0;
        double BenitoDesc = 0;
        double SuarezDesc = 0;
        double ValenteDesc = 0;
        double PlusDesc = 0;
        double pvp1 = 0;
        double iva = 0;
        double Pvp2Desc = 0;
        string articulos2 = "1";
        public static FormArticulos menu2Articulos;
        Boolean SiBajaarti = false;
        public FormArticulos()
        {
            InitializeComponent();
            FormArticulos.menu2Articulos = this;
        }
        private bool EspacioDiscos(string nombreDisco, int Espacio)
        {

            bool ok = true;
            DriveInfo discoBuscar = new DriveInfo(nombreDisco);
            if (discoBuscar.AvailableFreeSpace / 1024 / 1024 < Espacio)
            {
                MessageBox.Show("Libere Espacio en disco", "Espacio Insuficiente en :" + discoBuscar.Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ok = false;
            }
            return ok;
        }
        private void ColorearBajas()
        {
            try
            {
                if (this.dtPreciosDataGridView.Rows.Count > 0)
                {
                    int IB = 0;
                    this.dtPreciosDataGridView.DefaultCellStyle.ForeColor = Color.Black;
                    foreach (DataRow fila in FormMenuPrincipal.menu2principal.articulos.DtArticulos.Rows)
                    {
                        if (IB >= this.dtPreciosDataGridView.RowCount)
                        {
                            return;
                        }
                        if (fila[24].ToString() == Convert.ToBoolean("true").ToString())
                        {

                            this.dtPreciosDataGridView.Rows[IB].DefaultCellStyle.ForeColor = Color.LightGray;
                        }

                        IB++;

                    }
                }
            }
            catch (Exception)
            {

                // throw;
            }
        }
        private void EliminarArticuloBb()
        {
            if (File.Exists(ClasDatos.RutaBaseDatosDb))
            {
                try
                {
                    if (FormMenuPrincipal.menu2principal.InfoArticulo.Text != string.Empty)
                    {
                        String TipoTabla = "[" + FormMenuPrincipal.menu2principal.InfoArticulo.Text + "]";
                        string consulta = "Delete from " + TipoTabla + "  WHERE ID= @ID";
                        //  ClsConexionDb.CadenaConexion = cadena;
                        ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
                        {
                            if (NuevaConexion.SiConexionDb)
                            {
                                NuevaConexion.ComandoDb.Parameters.AddWithValue("@ID", this.idArticulo.Text);
                                NuevaConexion.ComandoDb.ExecuteNonQuery();
                                this.dtPreciosDataGridView.Rows.RemoveAt(this.dtPreciosDataGridView.CurrentCell.RowIndex);
                                this.dtArticulosBindingSource.EndEdit();
                                Validate();
                                MessageBox.Show("Se Elimino Correctamente", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(),"ERROR AL GUARDAR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("El Archivo No Se Encuentra", "ARCHIVO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
        }
        private void LlenarDescuentos()
        {

            try
            {
                int Fila = this.EmpresaArticulos.SelectedIndex;
                if (this.dtConfiguracionPrincipalBindingSource.Count > 0)
                {
                    if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtTarifaTipo"].Rows[1 + Fila]["TarifaTipo"].ToString() != string.Empty)
                    {
                        this.CastyLab.Text = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtTarifaTipo"].Rows[1 + Fila]["TarifaTipo"].ToString();
                        this.dtPreciosDataGridView.Columns[6].HeaderText = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtTarifaTipo"].Rows[1 + Fila]["TarifaTipo"].ToString();
                    }
                    if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtTarifaTipo"].Rows[2 + Fila]["TarifaTipo"].ToString() != string.Empty)
                    {
                        this.SuarezLab.Text = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtTarifaTipo"].Rows[2 + Fila]["TarifaTipo"].ToString();
                        this.dtPreciosDataGridView.Columns[7].HeaderText = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtTarifaTipo"].Rows[2 + Fila]["TarifaTipo"].ToString();
                    }
                    if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtTarifaTipo"].Rows[3 + Fila]["TarifaTipo"].ToString() != string.Empty)
                    {
                        this.BenitoLab.Text = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtTarifaTipo"].Rows[3 + Fila]["TarifaTipo"].ToString();
                        this.dtPreciosDataGridView.Columns[8].HeaderText = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtTarifaTipo"].Rows[3 + Fila]["TarifaTipo"].ToString();
                    }
                    if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtTarifaTipo"].Rows[4]["TarifaTipo"].ToString() != string.Empty)
                    {
                        this.ValenteLab.Text = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtTarifaTipo"].Rows[4 + Fila]["TarifaTipo"].ToString();
                        this.dtPreciosDataGridView.Columns[9].HeaderText = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtTarifaTipo"].Rows[4 + Fila]["TarifaTipo"].ToString();
                    }
                }
            }
            catch (Exception)
            {

                ////  throw; se deve editar aqui

            }
        }



        private void FormARTICULOS_Load(object sender, EventArgs e)
        {

            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal))
            {
                MessageBox.Show("Debe Restructurar Sistema", "DIRECTORIO " + ClasDatos.RutaDatosPrincipal + " NO EXISTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            try
            {
                if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION != null)
                {
                    this.dtConfiguracionPrincipalBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION;
                }
                if (FormMenuPrincipal.menu2principal.articulos != null)
                {
                    this.dtArticulosBindingSource.DataSource = FormMenuPrincipal.menu2principal.articulos;
                }
                if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION != null)
                {
                    this.dtConfiguracionPrincipalBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION;
                    this.dtConfiguracionPrincipalBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION;

                }

                if (FormMenuPrincipal.menu2principal.dsMultidatos != null)
                {
                    this.dtInicioMultiBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMultidatos;
                    this.dtFamiliaProductosBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMultidatos;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            this.dtArticulosBindingSource.Filter = "[BAJA]" + "=" + Convert.ToBoolean("false");
            this.dtArticulosBindingSource.Sort = "[Descripcci]";
            //  FormMenuPrincipal.menu2principal.articulos.DtArticulos.DefaultView.Sort = "[Descripcci]";
            if (ClsConexionSql.SibaseDatosSql == false)
            {
                if (!File.Exists(ClasDatos.RutaBaseDatosDb))
                {
                    MessageBox.Show("Falta Archivo De Datos", "ARCHIVO NO EXISTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            this.FiltrarBajas.Text = "Articulos De Alta";
            this.ContadorDatos3.Text = this.dtPreciosDataGridView.RowCount.ToString();
            ValidarCalculosPrecios();
            this.dtArticulosBindingSource.EndEdit();
            Validate();
            RetocarArticulos();
        }
        public void AñadirId()
        {
            int ii = 0;
            foreach (DataGridViewRow fila in this.dtPreciosDataGridView.Rows)
            {
                fila.Cells["IdFila"].Value = ii.ToString();
                ii++;
            }

        }
        private void ValidarCalculosPrecios()
        {
            //SacarPorcentaje();
            // this.Pvp1Text.Text = this.Pvp1Text.Text.Replace("€", "");
            //this.CosteTextBox.Text = this.CosteTextBox.Text.Replace("€", "");
            // this.PvpIvaLabel2.Text = this.PvpIvaLabel2.Text.Replace("€", "");
            if (this.CosteTextBox.Text != "")
            {
                this.Coste = Convert.ToDouble(this.CosteTextBox.Text.Replace("€", ""));
            }

            if (this.TipoIVA_Up_Articulos.Text != "")
            {
                this.iva = Convert.ToDouble(this.TipoIVA_Up_Articulos.Text);
            }

            this.pvp1 = (this.Coste + (this.Coste * this.Ganancia / 100));
            this.Pvp1Text.Text = string.Format("{0:C3" + "}", this.pvp1);
            this.PvpIvaLabel2.Text = string.Format("{0:C3" + "}", this.pvp1 + (this.pvp1 * this.iva / 100));
            this.Pvp2Label2.Text = string.Format("{0:C3" + "}", this.pvp1 - (this.pvp1 * (this.Pvp2Desc / 100)));
            this.CastyLabel2.Text = string.Format("{0:C3" + "}", this.pvp1 - (this.pvp1 * (this.CastiDesc / 100)));
            this.SuarezLabel2.Text = string.Format("{0:C3" + "}", this.pvp1 - (this.pvp1 * (this.SuarezDesc / 100)));
            this.BenitoLabel2.Text = string.Format("{0:C3" + "}", this.pvp1 - (this.pvp1 * (this.BenitoDesc / 100)));
            this.ValenteLabel2.Text = string.Format("{0:C3" + "}", this.pvp1 - (this.pvp1 * (this.ValenteDesc / 100)));
            this.PlusLabel2.Text = string.Format("{0:C3" + "}", this.pvp1 - (this.pvp1 * (this.PlusDesc / 100)));
            Validate();
        }


        private bool VALIDARcamposArticulos()
        {
            bool ok = true;
            if (this.ReferenciaTextBox.Text.Length < 1)
            {
                ok = false;
                this.errorProvider1.SetError(this.ReferenciaTextBox, "_ingresar Referencia (( minimo 1 Caracteres))");
            }
            if (this.DescripccionTextBox.Text.Length < 1)
            {
                ok = false;
                this.errorProvider1.SetError(this.DescripccionTextBox, "_ingresar Descripccion (( minimo 1 Caracteres))");
            }
            if (this.GananciaTextBox.Text.Length < 1)
            {
                ok = false;
                this.errorProvider1.SetError(this.GananciaTextBox, "_ingresar Margen Comercial (( minimo 1 Caracteres))");
            }

            if (this.CosteTextBox.Text.Length < 1)
            {
                ok = false;
                this.errorProvider1.SetError(this.CosteTextBox, "_ingresar Coste (( minimo 1 Caracteres))");
            }
            return ok;
        }
        private void BORRARerrores()
        {
            this.errorProvider1.SetError(this.ReferenciaTextBox, "");
            this.errorProvider1.SetError(this.DescripccionTextBox, "");
            this.errorProvider1.SetError(this.GananciaTextBox, "");
            this.errorProvider1.SetError(this.CosteTextBox, "");
        }
        private void PVPTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45) && (e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo numeros", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                //e.KeyChar = (char)08;
                return;
            }

        }

        private void FormARTICULOS_MouseEnter(object sender, EventArgs e)
        {
            FormMenuPrincipal.menu2principal.panelventas.Visible = false;
            FormMenuPrincipal.menu2principal.panelSUBventas.Visible = false;
        }
        private void BtnNuevoArticulo_Click(object sender, EventArgs e)
        {
            BORRARerrores();
            try
            {
                //  LimpiarTextox();
                this.panelBotonesArticulo.Tag = "NUEVO";
                this.FiltrarBajas.Text = "Todos";
                this.dtPreciosDataGridView.Refresh();
                this.dtPreciosDataGridView.Sort(this.dtPreciosDataGridView.Columns[0], ListSortDirection.Ascending);
                int numeroFILA = this.dtPreciosDataGridView.Rows.Count;
                this.dtArticulosBindingSource.AddNew();
                if (this.dtPreciosDataGridView.RowCount <= 0)
                {
                    this.dtPreciosDataGridView.Rows[0].Cells[0].Value = "1";
                    this.idArticulo.Text = "1";
                }
                if (numeroFILA > 0)
                {
                    if (this.dtPreciosDataGridView.Rows[numeroFILA - 1].Cells[0].Value.ToString() == string.Empty)
                    {
                        Random r = new Random();
                        int VALORid = r.Next(50000, 100000000);
                        this.dtPreciosDataGridView.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.idArticulo.Text = VALORid.ToString();
                    }
                    else
                    {
                        int VALORid = Convert.ToInt32(this.dtPreciosDataGridView.Rows[numeroFILA - 1].Cells[0].Value) + 1;
                        this.dtPreciosDataGridView.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.idArticulo.Text = VALORid.ToString();
                    }
                }
                this.FechaAlta.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now);
                if (this.dtPreciosDataGridView.RowCount >= 0)
                {
                    this.dtPreciosDataGridView.Rows[numeroFILA].Selected = true;
                }

                this.panelDesc1.Enabled = true;
                this.ReferenciaTextBox.Focus();
                this.tabControl1Articulo.SelectedIndex = 0;
                ModificarOjetosArticulos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void BtnGuardarArticulo_Click(object sender, EventArgs e)
        {
            if (FormMenuPrincipal.menu2principal.InfoArticulo.Text != string.Empty)
            {
                this.dtPreciosDataGridView.Focus();
                if (EspacioDiscos(Directory.GetCurrentDirectory(), 30))
                {
                    BORRARerrores();
                    if (this.idArticulo.Text == string.Empty)
                    {
                        MessageBox.Show("Falta ID De Registro", "ID !!!!! ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (VALIDARcamposArticulos())
                    {
                        if (MessageBox.Show(" ¿Aceptar Guardar ? ", " GUARDAR ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int i = 0;
                            foreach (DataGridViewRow fila in this.dtPreciosDataGridView.Rows)
                            {
                                if (i == this.dtPreciosDataGridView.CurrentCell.RowIndex)
                                {
                                    goto seguir2;
                                }
                                if (fila.Cells[1].Value != null)
                                {
                                    if (fila.Cells[1].Value.ToString() == this.ReferenciaTextBox.Text)
                                    {
                                        // this.ReferenciaTextBox.ReadOnly = false;
                                        this.ReferenciaTextBox.SelectAll();
                                        MessageBox.Show(this.ReferenciaTextBox.Text, "Este Articulo Ya Existe", MessageBoxButtons.OK);
                                        return;
                                    }
                                }
                                seguir2:
                                if (i == this.dtPreciosDataGridView.Rows.Count)
                                {
                                    break;
                                }
                                i++;
                            }

                            if (ClsConexionSql.SibaseDatosSql)
                            {
                                GuardarArticulosSQL();
                            }
                            else
                            {
                                if (File.Exists(ClasDatos.RutaBaseDatosDb))
                                {
                                    GuardarArticulosDB();
                                }
                                else
                                {
                                    MessageBox.Show("El Archivo No Se Encuentra" + "\n" + ClasDatos.RutaBaseDatosDb, "ARCHIVO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            this.ContadorDatos3.Text = this.dtPreciosDataGridView.Rows.Count.ToString();
                            RestaurarOjetosArticulos();
                            this.dtPreciosDataGridView.Focus();

                        }

                    }
                }

            }

        }

        private void BtnCancelarArticulo_Click(object sender, EventArgs e)
        {
            RestaurarOjetosArticulos();
            BORRARerrores();
            try
            {
                if (this.panelBotonesArticulo.Tag.ToString() == "NUEVO")
                {
                    if (this.dtPreciosDataGridView.RowCount >= 0)
                    {
                        this.dtPreciosDataGridView.Rows.RemoveAt(this.dtPreciosDataGridView.CurrentCell.RowIndex);
                    }
                }
            }
            catch (Exception)
            {

                // throw;
            }
            this.dtPreciosDataGridView.Focus();
        }

        private void BtnBuscarArticulo_Click(object sender, EventArgs e)
        {
            if (dtArticulosBindingSource.Count > 0)
            {
                if (this.BtnGuardarArticulo.Enabled == false)
                {
                    try
                    {
                        if (FormMenuPrincipal.menu2principal.SiOpenBuscArti == 1)
                        {
                            FormBuscarArticulos.MenuB.Close();
                            FormBuscarArticulos.MenuB.Dispose();
                        }
                        ClasDatos.OkFacturar = false;
                        ClasDatos.QUEform = "Articulos";
                        // dtPreciosDataGridView.CurrentCell.Selected = false;
                        FormBuscarArticulos frm = new FormBuscarArticulos();
                        //m.FormClosed += (o, args) => numeroFILA = 1;
                        frm.ShowDialog();
                        frm.BringToFront();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
        private void BtnSalirArticulo_Click(object sender, EventArgs e)
        {
            if (this.BtnGuardarArticulo.Enabled == false)
            {
                if (MessageBox.Show("Salir Articulos  ", " ARTICULOS ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Close();
                }
            }


        }

        private void FormARTICULOS_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.BtnGuardarArticulo.Enabled == true)
            {
                e.Cancel = true;
            }

        }

        private void BtnImprimirArticulo_Click(object sender, EventArgs e)
        {
            if (this.dtArticulosBindingSource.Count <= 0)
            {
                MessageBox.Show("Nada Que Imprimir ", " IMPRIMIR ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (this.articulos2 == "1")
            {
                this.articulos2 = "2";
                ClasDatos.OkFacturar = false;
                ClasDatos.QUEform = "Articulos";
                FormImprimirTodo frm = new FormImprimirTodo();
                frm.FormClosed += (o, args) => this.articulos2 = "1";
                frm.ShowDialog();
                frm.BringToFront();

            }
        }

        private void BtnModificarArticulo_Click(object sender, EventArgs e)
        {
            if (this.dtPreciosDataGridView.RowCount >= 0)
            {
                ModificarOjetosArticulos();
                this.panelBotonesArticulo.Tag = "MODIFICAR";
                this.panelDesc1.Enabled = true;
                this.ReferenciaTextBox.Focus();
                this.tabControl1Articulo.SelectedIndex = 0;
            }

        }

        private void CosteTextBox_Validated(object sender, EventArgs e)
        {
            ValidarCalculosPrecios();
        }
        private void CosteTextBox_Enter(object sender, EventArgs e)
        {
            this.CosteTextBox.Text = this.CosteTextBox.Text.Replace("€", "");
        }
        private void BtnEliminarArticulo_Click(object sender, EventArgs e)
        {
            if (this.dtArticulosBindingSource.Count > 0)
            {
                if (MessageBox.Show(" Desea Eliminar Este Articulo ", "ELIMINAR ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (ClsConexionSql.SibaseDatosSql == false)
                        {
                            EliminarArticuloBb();
                        }
                        else

                        {
                            EliminarArticuloSql();
                        }

                    }
                    catch (Exception)
                    {

                        //  throw;
                    }
                    this.dtPreciosDataGridView.Refresh();
                }
            }
        }

        private void EliminarArticuloSql()
        {
            try
            {
                if (FormMenuPrincipal.menu2principal.InfoArticulo.Text != string.Empty)
                {
                    String TipoTabla = "[" + FormMenuPrincipal.menu2principal.InfoArticulo.Text + "]";
                    string consulta = "Delete * from " + TipoTabla + "  WHERE ID= @ID";
                    ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
                    {
                        if (NuevaConexion.SiConexionSql)
                        {
                            NuevaConexion.ComandoSql.Parameters.AddWithValue("@ID", this.idArticulo.Text);
                            NuevaConexion.ComandoSql.ExecuteNonQuery();
                            this.dtPreciosDataGridView.Rows.RemoveAt(this.dtPreciosDataGridView.CurrentCell.RowIndex);
                            this.dtArticulosBindingSource.EndEdit();
                            Validate();
                            MessageBox.Show("Se Elimino Correctamente", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void EmpresaArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.tarifaTipoArticulos.Items.Count >= 6)
            {

                //LlenarDescuentos();
            }


        }

        private void GananciaTextBox_Enter(object sender, EventArgs e)
        {
            this.GananciaTextBox.Text = this.GananciaTextBox.Text.Replace("%", "");
        }



        private void GananciaTextBox_Validated(object sender, EventArgs e)
        {
            ValidarCalculosPrecios();
        }

        private void CosteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46)
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == (char)46)
            {
                e.KeyChar = ',';
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == ',') && (!this.CosteTextBox.Text.Contains(",")))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '-') && (!this.CosteTextBox.Text.Contains("-")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void GananciaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Convert.ToInt32(this.GananciaTextBox.Text) < 0 & Convert.ToInt32(this.GananciaTextBox.Text) > 100)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void CastyDescTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }

        private void SuarezDescTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BenitoDescTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ValenteDescTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Pvp2DescTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void PlusDescTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == ',') && (!this.PlusDescTextBox.Text.Contains(",")))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }


        private void CosteTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidarCalculosPrecios();
        }

        private void DescripccionTextBox_Leave(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow fila in this.dtPreciosDataGridView.Rows)
            {
                if (i == this.dtPreciosDataGridView.CurrentCell.RowIndex)
                {
                    goto seguir2;
                }
                if (fila.Cells[2].Value != null)
                {
                    if (fila.Cells[2].Value.ToString() == this.DescripccionTextBox.Text)
                    {
                        this.DescripccionTextBox.ReadOnly = false;
                        this.DescripccionTextBox.SelectAll();
                        this.DescripccionTextBox.Select(4, 4);
                        MessageBox.Show(this.DescripccionTextBox.Text, "Este Articulo Ya Existe", MessageBoxButtons.OK);
                        return;
                    }
                }
                seguir2:
                if (i == this.dtPreciosDataGridView.Rows.Count)
                {
                    break;
                }
                i++;
            }
        }

        private void SuarezDescTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidarCalculosPrecios();
        }

        private void BenitoDescTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidarCalculosPrecios();
        }

        private void ValenteDescTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidarCalculosPrecios();
        }

        private void Pvp2DescTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidarCalculosPrecios();
        }

        private void PlusDescTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidarCalculosPrecios();
        }

        private void GananciaTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidarCalculosPrecios();
        }
        private void CastyDescTextBox_Enter(object sender, EventArgs e)
        {
            this.CastyDescTextBox.Text = this.CastyDescTextBox.Text.Replace("%", "");

        }
        private void SuarezDescTextBox_Validated(object sender, EventArgs e)
        {
            ValidarCalculosPrecios();
        }

        private void BenitoDescTextBox_Validated(object sender, EventArgs e)
        {
            ValidarCalculosPrecios();
        }

        private void ValenteDescTextBox_Validated(object sender, EventArgs e)
        {
            ValidarCalculosPrecios();
        }

        private void Pvp2DescTextBox_Validated(object sender, EventArgs e)
        {
            ValidarCalculosPrecios();
        }

        private void PlusDescTextBox_Validated(object sender, EventArgs e)
        {
            ValidarCalculosPrecios();
        }

        private void DescripcionBuscarArt_Click(object sender, EventArgs e)
        {
            if (this.DescripcionBuscarArt.DataSource == null)
            {
                this.DescripcionBuscarArt.DataSource = this.dtArticulosBindingSource;
                this.DescripcionBuscarArt.DisplayMember = "Referencia";
            }
        }

        private void SuarezDescTextBox_Enter(object sender, EventArgs e)
        {
            this.SuarezDescTextBox.Text = this.SuarezDescTextBox.Text.Replace("%", "");
        }

        private void BenitoDescTextBox_Enter(object sender, EventArgs e)
        {
            this.BenitoDescTextBox.Text = this.BenitoDescTextBox.Text.Replace("%", "");
        }

        private void ValenteDescTextBox_Enter(object sender, EventArgs e)
        {
            this.ValenteDescTextBox.Text = this.ValenteDescTextBox.Text.Replace("%", "");
        }

        private void Pvp2DescTextBox_Enter(object sender, EventArgs e)
        {
            this.Pvp2DescTextBox.Text = this.Pvp2DescTextBox.Text.Replace("%", "");
        }

        private void PlusDescTextBox_Enter(object sender, EventArgs e)
        {
            this.PlusDescTextBox.Text = this.PlusDescTextBox.Text.Replace("%", "");
        }

        private void CastyDescTextBox_Validated(object sender, EventArgs e)
        {
            ValidarCalculosPrecios();
        }

        private void FiltrarBajas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.RegistLbel.Tag.ToString() != "stop" && this.FiltrarBajas.SelectedIndex >= 0)
            {
                string concepto = @"[Descripcci]";
                string fieldName = string.Concat("[", this.articulos.DtArticulos.Columns["Baja"].ColumnName, "]");
                if (this.FiltrarBajas.SelectedIndex == 0)
                {
                    this.dtPreciosDataGridView.DefaultCellStyle.ForeColor = Color.Black;
                    this.SiBajaarti = false;
                    this.dtArticulosBindingSource.Filter = fieldName + "=" + this.SiBajaarti;
                    FormMenuPrincipal.menu2principal.articulos.DtArticulos.DefaultView.Sort = concepto;
                }
                if (this.FiltrarBajas.SelectedIndex == 1)
                {
                    this.SiBajaarti = true;
                    this.dtArticulosBindingSource.Filter = fieldName + "=" + this.SiBajaarti;
                    FormMenuPrincipal.menu2principal.articulos.DtArticulos.DefaultView.Sort = concepto;
                }
                if (this.FiltrarBajas.SelectedIndex == 2)
                {
                    this.dtPreciosDataGridView.DefaultCellStyle.ForeColor = Color.Black;
                    this.dtArticulosBindingSource.Filter = "";
                    FormMenuPrincipal.menu2principal.articulos.DtArticulos.DefaultView.Sort = concepto;
                    this.dtPreciosDataGridView.EndEdit();
                    ColorearBajas();
                }
                this.ContadorDatos3.Text = this.dtPreciosDataGridView.Rows.Count.ToString();
                ValidarCalculosPrecios();
                Validate();
                AñadirId();
            }

        }
        private void DtPreciosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // CargarTexbox();
        }
        private void CargarTexbox()
        {
            try
            {

                if (this.dtPreciosDataGridView.RowCount >= 0)
                {

                    int fila = this.dtPreciosDataGridView.CurrentCell.RowIndex;
                    LimpiarTextox();
                    this.idArticulo.Text = this.dtPreciosDataGridView.Rows[fila].Cells[0].FormattedValue.ToString();
                    this.ReferenciaTextBox.Text = this.dtPreciosDataGridView.Rows[fila].Cells[1].FormattedValue.ToString();
                    this.DescripccionTextBox.Text = this.dtPreciosDataGridView.Rows[fila].Cells[2].FormattedValue.ToString();
                    this.CosteTextBox.Text = this.dtPreciosDataGridView.Rows[fila].Cells[3].FormattedValue.ToString();
                    this.Pvp1Text.Text = this.dtPreciosDataGridView.Rows[fila].Cells[4].FormattedValue.ToString();
                    this.Pvp2Label2.Text = this.dtPreciosDataGridView.Rows[fila].Cells[5].FormattedValue.ToString();
                    this.CastyLabel2.Text = this.dtPreciosDataGridView.Rows[fila].Cells[6].FormattedValue.ToString();
                    this.SuarezLabel2.Text = this.dtPreciosDataGridView.Rows[fila].Cells[7].FormattedValue.ToString();
                    this.BenitoLabel2.Text = this.dtPreciosDataGridView.Rows[fila].Cells[8].FormattedValue.ToString();
                    this.ValenteLabel2.Text = this.dtPreciosDataGridView.Rows[fila].Cells[9].FormattedValue.ToString();
                    this.PlusLabel2.Text = this.dtPreciosDataGridView.Rows[fila].Cells[10].FormattedValue.ToString();
                    this.familiaComboBox.Text = ClasArticulos.ListaArticulos.lista[fila].Familia.ToString();
                    this.CastyDescTextBox.Text = ClasArticulos.ListaArticulos.lista[fila].CastyDesc.ToString();
                }
            }
            catch (Exception)
            {

                // throw;
            }
        }
        private void LimpiarTextox()
        {

            foreach (Control ctrl in this.tabPage1Articulo.Controls)
            {
                if (ctrl is TextBox)
                {
                    this.ReferenciaTextBox.ReadOnly = true;
                    ctrl.Text = string.Empty;

                }
            }
            foreach (Control ctrl in this.tabPage2Articulo.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = string.Empty;
                }
            }
            foreach (Control ctrl in this.tabPage1Articulo.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ctrl.Text = string.Empty;
                }
            }
        }
        private void ModificarOjetosArticulos()
        {
            this.panelDesc1.Enabled = true;
            this.panelBotonesArticulo.Enabled = false;
            this.BtnGuardarArticulo.Enabled = true;
            this.BtnCancelarArticulo.Enabled = true;
            this.dtPreciosDataGridView.Enabled = false;
            this.ReferenciaBuscarArt.Enabled = false;
            this.DescripcionBuscarArt.Enabled = false;
            this.FiltrarBajas.Enabled = false;
            this.BajaCheckBox.Enabled = true;
            this.TipoIVA_Up_Articulos.Enabled = true;

            foreach (Control ctrl in this.tabPage1Articulo.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = true;
                    ctrl.ForeColor = Color.FromArgb(153, 40, 7);
                }
            }
            foreach (Control ctrl in this.tabPage2Articulo.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = true;
                    ctrl.ForeColor = Color.FromArgb(153, 40, 7);
                }
            }
            foreach (Control ctrl in this.tabPage2Articulo.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ctrl.Enabled = true;
                    ctrl.ForeColor = Color.FromArgb(153, 40, 7);

                }
            }
        }
        private void RestaurarOjetosArticulos()
        {
            foreach (Control ctrl in this.tabPage1Articulo.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = false;
                    ctrl.ForeColor = Color.Black;
                }
            }
            foreach (Control ctrl in this.tabPage2Articulo.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = false;
                    ctrl.ForeColor = Color.Black;
                }
            }
            foreach (Control ctrl in this.tabPage2Articulo.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ctrl.Enabled = false;
                    ctrl.ForeColor = Color.Black;
                }
            }
            this.panelDesc1.Enabled = false;
            this.BtnGuardarArticulo.Enabled = false;
            this.BtnCancelarArticulo.Enabled = false;
            this.panelBotonesArticulo.Enabled = true;
            this.dtPreciosDataGridView.Enabled = true;
            this.ReferenciaBuscarArt.Enabled = true;
            this.DescripcionBuscarArt.Enabled = true;
            this.BajaCheckBox.Enabled = false;
            this.FiltrarBajas.Enabled = true;
            this.TipoIVA_Up_Articulos.Enabled = false;

        }
        private void RetocarArticulos()
        {
            try
            {
                //this.dtPreciosDataGridView.Sort(this.dtPreciosDataGridView.Columns[2], ListSortDirection.Ascending);//da error
                if (this.FiltrarBajas.Text == "Todos")
                {
                    ColorearBajas();
                }
                this.dtArticulosBindingSource.EndEdit();
                if (this.dtPreciosDataGridView.RowCount >= 0)
                {
                    this.dtPreciosDataGridView.CurrentCell = this.dtPreciosDataGridView.Rows[0].Cells[0];
                }
                AñadirId();
            }
            catch (Exception)
            {

                // throw;
            }
            //ValidarCalculosPrecios();
            this.ContadorDatos3.Text = this.dtArticulosBindingSource.Count.ToString();
        }

        private void GuardarArticulosDB()
        {
            String TipoTabla = FormMenuPrincipal.menu2principal.InfoArticulo.Text;
            string consulta = "";
            if (this.panelBotonesArticulo.Tag.ToString() == "NUEVO")
            {
                consulta = "INSERT INTO " + "[" + TipoTabla + "]" + " VALUES (@Id, @REFERENCIA,@Oem, @DESCRIPCCI, @COSTE, @GANANCIA," +
               " @PVP1, @PVPIVA, @PVP2DESC, @PVP2, @CASTYDESC, @CASTY, @SUAREZDESC, @SUAREZ, @BENITODESC, @BENITO, @VALENTEDES," +
               " @VALENTE,@PLUSDESC, @PLUS, @UNIDADPALE, @MINIMOSSTO, @STOCK , @FAMILIA, @FECHA, @Baja)";

            }
            else
            {
                consulta = "UPDATE " + "[" + TipoTabla + "]" + " SET Id = @Id,REFERENCIA = @REFERENCIA,Oem=@Oem, DESCRIPCCI = @DESCRIPCCI,COSTE = @COSTE" +
              ",GANANCIA = @GANANCIA,PVP1 = @PVP1,PVPIVA = @PVPIVA,PVP2DESC = @PVP2DESC,PVP2 = @PVP2,CASTYDESC = @CASTYDESC,CASTY = @CASTY" +
              ",SUAREZDESC = @SUAREZDESC, SUAREZ = @SUAREZ,BENITODESC = @BENITODESC,BENITO = @BENITO,VALENTEDES = @VALENTEDES," +
              "VALENTE= @VALENTE,PLUSDESC = @PLUSDESC,PLUS = @PLUS,UNIDADPALE= @UNIDADPALE,MINIMOSSTO = @MINIMOSSTO," +
              "STOCK= @STOCK,FAMILIA= @FAMILIA,FECHA = @FECHA,Baja = @Baja WHERE Id = @Id";

            }

            // ClsConexionDb.CadenaConexion = cadena;
            ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
            {
                if (NuevaConexion.SiConexionDb)
                {
                    try
                    {
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", this.idArticulo.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@REFERENCIA", this.ReferenciaTextBox.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@Oem", string.IsNullOrEmpty(this.OemText.Text) ? (object)DBNull.Value : this.OemText.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@DESCRIPCCI", this.DescripccionTextBox.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@COSTE", this.CosteTextBox.Text.Replace("€", ""));
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@GANANCIA", string.IsNullOrEmpty(this.GananciaTextBox.Text) ? (object)DBNull.Value : this.Ganancia / 100);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@PVP1", string.IsNullOrEmpty(this.Pvp1Text.Text) ? (object)DBNull.Value : this.Pvp1Text.Text.Replace("€", ""));
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@PVPIVA", string.IsNullOrEmpty(this.PvpIvaLabel2.Text) ? (object)DBNull.Value : this.PvpIvaLabel2.Text.Replace("€", ""));
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@PVP2DESC", string.IsNullOrEmpty(this.Pvp2DescTextBox.Text) ? (object)DBNull.Value : this.Pvp2Desc / 100);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@PVP2", string.IsNullOrEmpty(this.Pvp2Label2.Text) ? (object)DBNull.Value : this.Pvp2Label2.Text.Replace("€", ""));
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@CASTYDESC", string.IsNullOrEmpty(this.CastyDescTextBox.Text) ? (object)DBNull.Value : this.CastiDesc / 100);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@CASTY", string.IsNullOrEmpty(this.CastyLabel2.Text) ? (object)DBNull.Value : this.CastyLabel2.Text.Replace("€", ""));
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@SUAREZDESC", string.IsNullOrEmpty(this.SuarezDescTextBox.Text) ? (object)DBNull.Value : this.SuarezDesc / 100);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@SUAREZ", string.IsNullOrEmpty(this.SuarezLabel2.Text) ? (object)DBNull.Value : this.SuarezLabel2.Text.Replace("€", ""));
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@BENITODESC", string.IsNullOrEmpty(this.BenitoDescTextBox.Text) ? (object)DBNull.Value : this.BenitoDesc / 100);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@BENITO", string.IsNullOrEmpty(this.BenitoLabel2.Text) ? (object)DBNull.Value : this.BenitoLabel2.Text.Replace("€", ""));
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@VALENTEDES", string.IsNullOrEmpty(this.ValenteDescTextBox.Text) ? (object)DBNull.Value : this.ValenteDesc / 100);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@VALENTE", string.IsNullOrEmpty(this.ValenteLabel2.Text) ? (object)DBNull.Value : this.ValenteLabel2.Text.Replace("€", ""));
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@PLUSDESC", string.IsNullOrEmpty(this.PlusDescTextBox.Text) ? (object)DBNull.Value : this.PlusDesc / 100);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@PLUS", string.IsNullOrEmpty(this.PlusLabel2.Text) ? (object)DBNull.Value : this.PlusLabel2.Text.Replace("€", ""));
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@UNIDADPALE", string.IsNullOrEmpty(this.UnidadPaletTextBox.Text) ? (object)DBNull.Value : this.UnidadPaletTextBox.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@MINIMOSSTO", string.IsNullOrEmpty(this.MinimosStockTextBox.Text) ? (object)DBNull.Value : this.MinimosStockTextBox.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@STOCK", string.IsNullOrEmpty(this.StockTextBox.Text) ? (object)DBNull.Value : this.StockTextBox.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@FAMILIA", string.IsNullOrEmpty(this.familiaComboBox.Text) ? "GENERAL" : this.familiaComboBox.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@FECHA", String.Format("{0:dd/MM/yyyy}", DateTime.Now));
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@Baja", this.BajaCheckBox.Checked);
                        NuevaConexion.ComandoDb.ExecuteNonQuery();
                        NuevaConexion.ComandoDb.Parameters.Clear();
                        Validate();
                        if (NuevaConexion.CerrarConexionDB)
                        {

                        }
                        this.dtPreciosDataGridView.Refresh();
                        MessageBox.Show("Guardado Correctamente", "GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        if (this.idArticulo.Tag.ToString() == "NUEVO")
                        {
                            // this.dtPreciosDataGridView.Rows.RemoveAt(this.dtPreciosDataGridView.RowCount);
                        }
                        MessageBox.Show(ex.Message, "ERROR AL GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (NuevaConexion.CerrarConexionDB)
                        {

                        }
                    }

                }
            }
        }
        private void GuardarArticulosSQL()
        {
            String TipoTabla = "[" + FormMenuPrincipal.menu2principal.InfoArticulo.Text + "]";
            string Consulta = "";
            if (this.panelBotonesArticulo.Tag.ToString() == "NUEVO")
            {
                Consulta = "INSERT INTO " + "[" + TipoTabla + "]" + " VALUES (@Id, @REFERENCIA,@Oem, @DESCRIPCCI, @COSTE, @GANANCIA," +
               " @PVP1, @PVPIVA, @PVP2DESC, @PVP2, @CASTYDESC, @CASTY, @SUAREZDESC, @SUAREZ, @BENITODESC, @BENITO, @VALENTEDES," +
               " @VALENTE,@PLUSDESC, @PLUS, @UNIDADPALE, @MINIMOSSTO, @STOCK , @FAMILIA, @FECHA, @Baja)";

            }
            else
            {
                Consulta = "UPDATE " + "[" + TipoTabla + "]" + " SET Id = @Id,REFERENCIA = @REFERENCIA,Oem=@Oem, DESCRIPCCI = @DESCRIPCCI,COSTE = @COSTE" +
              ",GANANCIA = @GANANCIA,PVP1 = @PVP1,PVPIVA = @PVPIVA,PVP2DESC = @PVP2DESC,PVP2 = @PVP2,CASTYDESC = @CASTYDESC,CASTY = @CASTY" +
              ",SUAREZDESC = @SUAREZDESC, SUAREZ = @SUAREZ,BENITODESC = @BENITODESC,BENITO = @BENITO,VALENTEDES = @VALENTEDES," +
              "VALENTE= @VALENTE,PLUSDESC = @PLUSDESC,PLUS = @PLUS,UNIDADPALE= @UNIDADPALE,MINIMOSSTO = @MINIMOSSTO," +
              "STOCK= @STOCK,FAMILIA= @FAMILIA,FECHA = @FECHA,Baja = @Baja WHERE Id = @Id";

            }
            ClsConexionSql NuevaConexion = new ClsConexionSql(Consulta);
            {
                NuevaConexion.ComandoSql.CommandType = CommandType.Text;
                if (NuevaConexion.SiConexionSql)
                {
                    try
                    {
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", Convert.ToInt32(this.idArticulo.Text));
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@REFERENCIA", this.ReferenciaTextBox.Text.ToString());
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@Oem", string.IsNullOrEmpty(this.OemText.Text) ? (object)DBNull.Value : this.OemText.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@DESCRIPCCI", this.DescripccionTextBox.Text.ToString());
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@COSTE", Convert.ToDouble(this.CosteTextBox.Text.Replace("€", "")));
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@GANANCIA", string.IsNullOrEmpty(this.GananciaTextBox.Text) ? (object)DBNull.Value : this.Ganancia / 100);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@PVP1", string.IsNullOrEmpty(this.Pvp1Text.Text) ? (object)DBNull.Value : this.Pvp1Text.Text.Replace("€", ""));
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@PVPIVA", string.IsNullOrEmpty(this.PvpIvaLabel2.Text) ? (object)DBNull.Value : this.PvpIvaLabel2.Text.Replace("€", ""));
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@PVP2DESC", string.IsNullOrEmpty(this.Pvp2DescTextBox.Text) ? (object)DBNull.Value : this.Pvp2Desc / 100);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@PVP2", string.IsNullOrEmpty(this.Pvp2Label2.Text) ? (object)DBNull.Value : this.Pvp2Label2.Text.Replace("€", ""));
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@CASTYDESC", string.IsNullOrEmpty(this.CastyDescTextBox.Text) ? (object)DBNull.Value : this.CastiDesc / 100);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@CASTY", string.IsNullOrEmpty(this.CastyLabel2.Text) ? (object)DBNull.Value : this.CastyLabel2.Text.Replace("€", ""));
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@SUAREZDESC", string.IsNullOrEmpty(this.SuarezDescTextBox.Text) ? (object)DBNull.Value : this.SuarezDesc / 100);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@SUAREZ", string.IsNullOrEmpty(this.SuarezLabel2.Text) ? (object)DBNull.Value : this.SuarezLabel2.Text.Replace("€", ""));
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@BENITODESC", string.IsNullOrEmpty(this.BenitoDescTextBox.Text) ? (object)DBNull.Value : this.BenitoDesc / 100);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@BENITO", string.IsNullOrEmpty(this.BenitoLabel2.Text) ? (object)DBNull.Value : this.BenitoLabel2.Text.Replace("€", ""));
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@VALENTEDES", string.IsNullOrEmpty(this.ValenteDescTextBox.Text) ? (object)DBNull.Value : this.ValenteDesc / 100);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@VALENTE", string.IsNullOrEmpty(this.ValenteLabel2.Text) ? (object)DBNull.Value : this.ValenteLabel2.Text.Replace("€", ""));
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@PLUSDESC", string.IsNullOrEmpty(this.PlusDescTextBox.Text) ? (object)DBNull.Value : this.PlusDesc / 100);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@PLUS", string.IsNullOrEmpty(this.PlusLabel2.Text) ? (object)DBNull.Value : this.PlusLabel2.Text.Replace("€", ""));
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@UNIDADPALE", string.IsNullOrEmpty(this.UnidadPaletTextBox.Text) ? (object)DBNull.Value : this.UnidadPaletTextBox.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@MINIMOSSTO", string.IsNullOrEmpty(this.MinimosStockTextBox.Text) ? (object)DBNull.Value : this.MinimosStockTextBox.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@STOCK", string.IsNullOrEmpty(this.StockTextBox.Text) ? (object)DBNull.Value : this.StockTextBox.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@FAMILIA", string.IsNullOrEmpty(this.familiaComboBox.Text) ? "GENERAL" : this.familiaComboBox.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@FECHA", String.Format("{0:dd/MM/yyyy}", DateTime.Now));
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@Baja", this.BajaCheckBox.Checked);
                        NuevaConexion.ComandoSql.ExecuteNonQuery();
                        NuevaConexion.ComandoSql.Parameters.Clear();
                        Validate();
                        if (NuevaConexion.CerrarConexionSql)
                        {

                        }
                        this.dtPreciosDataGridView.Refresh();
                        MessageBox.Show("Guardado Correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        if (this.idArticulo.Tag.ToString() == "NUEVO")
                        {
                            //this.dtPreciosDataGridView.Rows.RemoveAt(this.dtPreciosDataGridView.RowCount);
                        }
                        MessageBox.Show(ex.Message, "ERROR AL GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (NuevaConexion.CerrarConexionSql)
                        {

                        }
                    }


                }

            }
        }
        private void FiltrarFamiliaArt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.RegistLbel.Tag.ToString() != "stop" && this.BtnGuardarArticulo.Enabled == false)
            {
                try
                {
                    if (this.FiltrarFamiliaArt.SelectedIndex >= 0)
                    {
                        this.dtPreciosDataGridView.DefaultCellStyle.ForeColor = Color.Black;
                        string FilaFamilia = string.Concat("[", FormMenuPrincipal.menu2principal.articulos.DtArticulos.Columns["Familia"].ColumnName, "]");
                        string baja = string.Concat("[", FormMenuPrincipal.menu2principal.articulos.DtArticulos.Columns["Baja"].ColumnName, "]");
                        FormMenuPrincipal.menu2principal.articulos.DtArticulos.DefaultView.Sort = FilaFamilia;

                        this.dtArticulosBindingSource.Filter = FilaFamilia + " LIKE '%" + this.FiltrarFamiliaArt.Text + "%'" + "and " + baja + "=" + this.SiBajaarti;

                        if (this.FiltrarBajas.SelectedIndex == 2)
                        {
                            ColorearBajas();
                        }
                    }
                }
                catch (Exception)
                {

                    //  throw;
                }

            }
        }

        private void CheckFamiliaArt_Click(object sender, EventArgs e)
        {
            //CheckFamiliaArt.AutoCheck = false;
            if (this.CheckFamiliaArt.Checked == true)
            {
                this.FiltrarFamiliaArt.Visible = false;
                this.FiltrarFamiliaArt.Text = string.Empty;
                this.CheckFamiliaArt.Checked = false;

            }
            else
            {
                this.FiltrarFamiliaArt.Visible = true;
                this.FiltrarFamiliaArt.Text = "GENERAL";
                this.CheckFamiliaArt.Checked = true;
            }
        }

        private void CastyDescTextBox_Leave(object sender, EventArgs e)
        {
            if (this.CastyDescTextBox.Text != string.Empty)
            {
                this.CastiDesc = Convert.ToDouble(this.CastyDescTextBox.Text);
                this.CastyDescTextBox.Text = Convert.ToString(this.CastiDesc / 100);
            }

        }

        private void SuarezDescTextBox_Leave(object sender, EventArgs e)
        {
            if (this.GananciaTextBox.Text != string.Empty)
            {
                this.SuarezDesc = Convert.ToDouble(this.SuarezDescTextBox.Text);
                this.SuarezDescTextBox.Text = Convert.ToString(this.SuarezDesc / 100);
            }

        }

        private void BenitoDescTextBox_Leave(object sender, EventArgs e)
        {
            if (this.BenitoDescTextBox.Text != string.Empty)
            {
                this.BenitoDesc = Convert.ToDouble(this.BenitoDescTextBox.Text);
                this.BenitoDescTextBox.Text = Convert.ToString(this.BenitoDesc / 100);
            }

        }

        private void ValenteDescTextBox_Leave(object sender, EventArgs e)
        {
            if (this.ValenteDescTextBox.Text != string.Empty)
            {
                this.ValenteDesc = Convert.ToDouble(this.ValenteDescTextBox.Text);
                this.ValenteDescTextBox.Text = Convert.ToString(this.ValenteDesc / 100);
            }

        }

        private void Pvp2DescTextBox_Leave(object sender, EventArgs e)
        {
            if (this.Pvp2DescTextBox.Text != string.Empty)
            {
                this.Pvp2Desc = Convert.ToDouble(this.Pvp2DescTextBox.Text);
                this.Pvp2DescTextBox.Text = Convert.ToString(this.Pvp2Desc / 100);
            }


        }

        private void PlusDescTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (this.PlusDescTextBox.Text != string.Empty)
            {
                //PlusDesc = Convert.ToDouble(PlusDescTextBox.Text);
                //PlusDescTextBox.Text = Convert.ToString(PlusDesc / 100);
            }

        }

        private void GananciaTextBox_Leave(object sender, EventArgs e)
        {

            if (this.GananciaTextBox.Text != string.Empty)
            {
                this.Ganancia = Convert.ToDouble(this.GananciaTextBox.Text);
                this.GananciaTextBox.Text = Convert.ToString(this.Ganancia / 100);
            }
        }


        private void familiaComboBox_Click(object sender, EventArgs e)
        {
            this.familiaComboBox.DroppedDown = true;
        }

        private void EmpresaArticulos_Validated(object sender, EventArgs e)
        {
            //LlenarDescuentos();
        }

        private void tarifaTipoArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {


            LlenarDescuentos();

        }

        private void PlusDescTextBox_Leave(object sender, EventArgs e)
        {
            if (this.PlusDescTextBox.Text != string.Empty)
            {
                this.PlusDesc = Convert.ToDouble(this.PlusDescTextBox.Text);
                this.PlusDescTextBox.Text = Convert.ToString(this.PlusDesc / 100);
            }
        }

        private void dtPreciosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtPreciosDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            /// LimpiarTextox();
            //CargarTexbox();
        }

        private void FiltrarBajas_Enter(object sender, EventArgs e)
        {
            this.RegistLbel.Tag = "SI";
        }

        private void FiltrarFamiliaArt_Enter(object sender, EventArgs e)
        {
            this.RegistLbel.Tag = "stop";
        }

        private void EmpresaArticulos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LlenarDescuentos();
        }
    }
}


