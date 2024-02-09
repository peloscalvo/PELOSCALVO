using Comun;
using Conexiones;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        private void cargarArticulo()
        {
            string ConsultaArticulo = "SELECT [Id],[Referencia],[Oem],[Descripcci],[Coste],[Ganancia],[Pvp1]" +
                ",[Desc2],[Pvp2],[Desc3],[Pvp3],[Desc4],[Pvp4],[Desc5],[Pvp5],[Desc6],[Pvp6],[DescPlus]" +
                ",[Plus],[UnidadPale],[MinimosSto],[Stock],[Familia],[Fecha],[BAJA],[Fatu]" +
                "FROM[" + FormMenuPrincipal.menu2principal.InfoArticulo.Text + "] WHERE Id = " + Convert.ToInt32(this.Id_Articulo.Text);

            foreach (Control Ctr in this.TabPageArti1.Controls)
            {
                if (Ctr is ComboBox | Ctr is TextBox)
                {
                    Ctr.Text = string.Empty;
                }
            }
            foreach (Control Ctr in this.TabPageArti2.Controls)
            {
                if (Ctr is ComboBox | Ctr is TextBox)
                {
                    Ctr.Text = string.Empty;
                }
            }
            if (ClsConexionSql.SibaseDatosSql)
            {

            }
            else
            {
                ClsConexionDb NuevaConexion = new ClsConexionDb(ConsultaArticulo);
                if (NuevaConexion.SiConexionDb)
                {
                    OleDbDataReader Leer = NuevaConexion.ComandoDb.ExecuteReader();
                    if (Leer.HasRows)
                    {
                        if (Leer.Read())
                        {
                            if (!string.IsNullOrEmpty(Leer["Referencia"].ToString()))
                            {
                                this.ReferenciaTextBox.Text = Leer["Referencia"].ToString();
                            }
                            if (!string.IsNullOrEmpty(Leer["Oem"].ToString()))
                            {
                                this.OemText.Text = Leer["Oem"].ToString();
                            }
                            if (!string.IsNullOrEmpty(Leer["Descripcci"].ToString()))
                            {
                                this.DescripccionTextBox.Text = Leer["Descripcci"].ToString();
                            }
                            if (!string.IsNullOrEmpty(Leer["Coste"].ToString()))
                            {
                                this.CosteTextBox.Text = Leer["Coste"].ToString();
                            }
                            if (!string.IsNullOrEmpty(Leer["Ganancia"].ToString()))
                            {
                                this.GananciaTextBox.Text = Leer["Ganancia"].ToString();
                            }
                            if (!string.IsNullOrEmpty(Leer["Pvp1"].ToString()))
                            {
                                this.Pvp1Text.Text = Leer["Pvp1"].ToString();
                            }
                            if (!string.IsNullOrEmpty(Leer["Pvp2"].ToString()))
                            {
                                this.Pvp2Text.Text = Leer["Pvp2"].ToString();
                            }
                            if (!string.IsNullOrEmpty(Leer["Pvp3"].ToString()))
                            {
                                this.Pvp3Txt.Text = Leer["Pvp3"].ToString();
                            }
                            if (!string.IsNullOrEmpty(Leer["Pvp4"].ToString()))
                            {
                                this.Pvp4Txt.Text = Leer["Pvp4"].ToString();
                            }

                            if (!string.IsNullOrEmpty(Leer["Pvp5"].ToString()))
                            {
                                this.Pvp5Txt.Text = Leer["Pvp5"].ToString();
                            }
                            if (!string.IsNullOrEmpty(Leer["Pvp6"].ToString()))
                            {
                                this.Pvp6Txt.Text = Leer["Pvp6"].ToString();
                            }

                            if (!string.IsNullOrEmpty(Leer["Desc2"].ToString()))
                            {
                                this.Desc2Text.Text = Leer["Desc2"].ToString();
                            }
                            if (!string.IsNullOrEmpty(Leer["Desc3"].ToString()))
                            {
                                this.Desc3Txt.Text = Leer["Desc3"].ToString();
                            }
                            if (!string.IsNullOrEmpty(Leer["Desc4"].ToString()))
                            {
                                this.Desc4Txt.Text = Leer["Desc4"].ToString();
                            }
                            if (!string.IsNullOrEmpty(Leer["Desc4"].ToString()))
                            {
                                this.Desc5Text.Text = Leer["Desc5"].ToString();
                            }
                            if (!string.IsNullOrEmpty(Leer["Desc6"].ToString()))
                            {
                                this.Desc6Txt.Text = Leer["Desc6"].ToString();
                            }
                            if (!string.IsNullOrEmpty(Leer["DescPlus"].ToString()))
                            {
                                this.PlusDescTxt.Text = Leer["DescPlus"].ToString();
                            }
                            if (!string.IsNullOrEmpty(Leer["Plus"].ToString()))
                            {
                                this.PlusLabel2.Text = Leer["Plus"].ToString();
                            }
                            if (!string.IsNullOrEmpty(Leer["UnidadPale"].ToString()))
                            {
                                this.UnidadPaletTextBox.Text = Leer["UnidadPale"].ToString();
                            }
                            if (!string.IsNullOrEmpty(Leer["MinimosSto"].ToString()))
                            {
                                this.MinimosStockTextBox.Text = Leer["MinimosSto"].ToString();
                            }
                            if (!string.IsNullOrEmpty(Leer["Stock"].ToString()))
                            {
                                this.StockTextBox.Text = Leer["Stock"].ToString();
                            }
                            if (!string.IsNullOrEmpty(Leer["Familia"].ToString()))
                            {
                                this.familiaComboBox.Text = Leer["Familia"].ToString();
                            }
                            if (!string.IsNullOrEmpty(Leer["Fecha"].ToString()))
                            {
                                this.FechaAlta.Text = Leer["Fecha"].ToString();
                            }
                            if (!string.IsNullOrEmpty(Leer["BAJA"].ToString()))
                            {
                                this.BajaCheckBox.Checked = Convert.ToBoolean(Leer["BAJA"]);
                            }
                        }
                    }
                }

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
                                NuevaConexion.ComandoDb.Parameters.AddWithValue("@ID", this.Id_Articulo.Text);
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
                    MessageBox.Show(ex.Message.ToString(), "ERROR AL GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                int Fila2 = 0;
                if (this.dtConfiDtTarifaTipoBindingSource.Count > 0)
                {
                    string item2 = this.TipoTarifa.Items.ToString();
                    string aaaa = item2[1].ToString();
                    foreach (ComboBox item in this.TipoTarifa.Items)
                    {
                        if (!string.IsNullOrEmpty(item.ToString()))
                        {
                            if (Fila2 == 0)
                            {
                                this.LabDes3.Text = item.ToString();
                            }
                            if (Fila2 == 3)
                            {
                                //   this.LabDesc4.Text = item[3].ToString();
                            }
                            if (Fila2 == 4)
                            {
                                // this.LabDes5.Text = item[4].ToString();
                            }
                            if (Fila2 == 5)
                            {
                                //   this.LabDes6.Text = item[5].ToString();
                            }

                        }
                        Fila2++;
                    }
                    return;
                    if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtTarifaTipo"].Rows[1 + Fila]["TarifaTipo"].ToString() != string.Empty)
                    {
                        this.LabDes3.Text = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtTarifaTipo"].Rows[1 + Fila]["TarifaTipo"].ToString();
                        // this.dtPreciosDataGridView.Columns[6].HeaderText = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtTarifaTipo"].Rows[1 + Fila]["TarifaTipo"].ToString();
                    }
                    if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtTarifaTipo"].Rows[2 + Fila]["TarifaTipo"].ToString() != string.Empty)
                    {
                        this.LabDesc4.Text = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtTarifaTipo"].Rows[2 + Fila]["TarifaTipo"].ToString();
                        //  this.dtPreciosDataGridView.Columns[7].HeaderText = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtTarifaTipo"].Rows[2 + Fila]["TarifaTipo"].ToString();
                    }
                    if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtTarifaTipo"].Rows[3 + Fila]["TarifaTipo"].ToString() != string.Empty)
                    {
                        this.LabDes5.Text = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtTarifaTipo"].Rows[3 + Fila]["TarifaTipo"].ToString();
                        // this.dtPreciosDataGridView.Columns[8].HeaderText = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtTarifaTipo"].Rows[3 + Fila]["TarifaTipo"].ToString();
                    }
                    if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtTarifaTipo"].Rows[4]["TarifaTipo"].ToString() != string.Empty)
                    {
                        this.LabDes6.Text = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtTarifaTipo"].Rows[4 + Fila]["TarifaTipo"].ToString();
                        // this.dtPreciosDataGridView.Columns[9].HeaderText = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtTarifaTipo"].Rows[4 + Fila]["TarifaTipo"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
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

                if (FormMenuPrincipal.menu2principal.dsMultidatos != null)
                {
                    this.dtInicioMultiBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMultidatos.DtInicioMulti;
                    this.dtFamiliaProductosBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2.DtFamiliaProductos;
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
            CalculosPrecios();
            this.dtArticulosBindingSource.EndEdit();
            //  Validate();
            RetocarArticulos();
        }
        public void AñadirIdArticulos()
        {
            int ii = 0;
            foreach (var fila in FormMenuPrincipal.menu2principal.articulos.DtArticulos)
            {
                fila["IdFila"] = ii.ToString();
                ii++;
            }

        }
        private void CalculosIva()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.TipoIVA_Up_Articulos.Text))
                {
                    this.iva = Convert.ToDouble(this.TipoIVA_Up_Articulos.Text);
                }
                {
                    this.pvp1 = Convert.ToDouble(this.Pvp1Text.Text.Replace("€", ""));
                }
                // this.pvp1 = (this.Coste + (this.Coste * this.Ganancia / 100));
                this.PvpIva2.Text = string.Format("{0:C3" + "}", this.pvp1 + (this.pvp1 * this.iva / 100));
            }
            catch (Exception)
            {

                // throw;
            }
        }
        private void CalculosPrecios()
        {
            if (!string.IsNullOrEmpty(this.CosteTextBox.Text))
                try
                {
                    {
                        this.Coste = Convert.ToDouble(this.CosteTextBox.Text.Replace("€", ""));
                    }
                    if (!string.IsNullOrEmpty(this.TipoIVA_Up_Articulos.Text))
                    {
                        this.iva = Convert.ToDouble(this.TipoIVA_Up_Articulos.Text);
                    }

                    this.pvp1 = (this.Coste + (this.Coste * this.Ganancia / 100));
                    this.Pvp1Text.Text = string.Format("{0:C3" + "}", this.pvp1);
                    this.PvpIva2.Text = string.Format("{0:C3" + "}", this.pvp1 + (this.pvp1 * this.iva / 100));
                    this.Pvp2Text.Text = string.Format("{0:C3" + "}", this.pvp1 - (this.pvp1 * (this.Pvp2Desc / 100)));
                    this.Pvp3Txt.Text = string.Format("{0:C3" + "}", this.pvp1 - (this.pvp1 * (this.CastiDesc / 100)));
                    this.Pvp4Txt.Text = string.Format("{0:C3" + "}", this.pvp1 - (this.pvp1 * (this.SuarezDesc / 100)));
                    this.Pvp5Txt.Text = string.Format("{0:C3" + "}", this.pvp1 - (this.pvp1 * (this.BenitoDesc / 100)));
                    this.Pvp6Txt.Text = string.Format("{0:C3" + "}", this.pvp1 - (this.pvp1 * (this.ValenteDesc / 100)));
                    this.PlusLabel2.Text = string.Format("{0:C3" + "}", this.pvp1 - (this.pvp1 * (this.PlusDesc / 100)));
                }
                catch (Exception)
                {

                    // throw;
                }
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
                    this.Id_Articulo.Text = "1";
                }
                if (numeroFILA > 0)
                {
                    if (this.dtPreciosDataGridView.Rows[numeroFILA - 1].Cells[0].Value.ToString() == string.Empty)
                    {
                        Random r = new Random();
                        int VALORid = r.Next(50000, 100000000);
                        this.dtPreciosDataGridView.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.Id_Articulo.Text = VALORid.ToString();
                    }
                    else
                    {
                        int VALORid = Convert.ToInt32(this.dtPreciosDataGridView.Rows[numeroFILA - 1].Cells[0].Value) + 1;
                        this.dtPreciosDataGridView.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.Id_Articulo.Text = VALORid.ToString();
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
                    if (this.Id_Articulo.Text == string.Empty)
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
                    if (this.dtArticulosBindingSource.Count > 0)
                    {
                        this.dtPreciosDataGridView.Rows.RemoveAt(this.dtPreciosDataGridView.CurrentCell.RowIndex);
                    }
                }
                else
                {
                    cargarArticulo();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "ERROR  ARTICULOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.dtPreciosDataGridView.Focus();
        }

        private void BtnBuscarArticulo_Click(object sender, EventArgs e)
        {
            if (this.dtArticulosBindingSource.Count > 0)
            {
                if (this.BtnGuardarArticulo.Enabled == false)
                {
                    try
                    {
                        if (FormMenuPrincipal.menu2principal.SiOpenBuscArti == 1)
                        {
                            MessageBox.Show("Debe Cerrar Formulario (( CODIGO BARRAS )))", "CERRAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        ClasDatos.OkFacturar = false;
                        ClasDatos.QUEform = "Articulos";
                        AñadirIdArticulos();
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
            CalculosPrecios();
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
                            NuevaConexion.ComandoSql.Parameters.AddWithValue("@ID", this.Id_Articulo.Text);
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

            if (this.TipoTarifa.Items.Count >= 6)
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
            CalculosPrecios();
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
            if (e.KeyChar == 46)
            {
                e.KeyChar = ',';
            }
            if (Convert.ToDouble(this.GananciaTextBox.Text) <= 0 & Convert.ToDouble(this.GananciaTextBox.Text) >= 100)
            {
                e.Handled = true;
            }
            else if (char.IsDigit(e.KeyChar))
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

        private void CastyDescTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46)
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
            else
            {
                e.Handled = true;
            }
        }

        private void SuarezDescTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46)
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
            else
            {
                e.Handled = true;
            }
        }

        private void BenitoDescTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46)
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
            else
            {
                e.Handled = true;
            }
        }

        private void ValenteDescTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46)
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
            else
            {
                e.Handled = true;
            }
        }

        private void Pvp2DescTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46)
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
            else
            {
                e.Handled = true;
            }
        }

        private void PlusDescTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46)
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
            else if ((e.KeyChar == ',') && (!this.PlusDescTxt.Text.Contains(",")))
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
            CalculosPrecios();
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
            CalculosPrecios();
        }

        private void BenitoDescTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculosPrecios();
        }

        private void ValenteDescTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculosPrecios();
        }

        private void Pvp2DescTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculosPrecios();
        }

        private void PlusDescTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculosPrecios();
        }

        private void GananciaTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculosPrecios();
        }
        private void CastyDescTextBox_Enter(object sender, EventArgs e)
        {
            this.Desc3Txt.Text = this.Desc3Txt.Text.Replace("%", "");

        }
        private void SuarezDescTextBox_Validated(object sender, EventArgs e)
        {
            CalculosPrecios();
        }

        private void BenitoDescTextBox_Validated(object sender, EventArgs e)
        {
            CalculosPrecios();
        }

        private void ValenteDescTextBox_Validated(object sender, EventArgs e)
        {
            CalculosPrecios();
        }

        private void Pvp2DescTextBox_Validated(object sender, EventArgs e)
        {
            CalculosPrecios();
        }

        private void PlusDescTextBox_Validated(object sender, EventArgs e)
        {
            CalculosPrecios();
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
            this.Desc4Txt.Text = this.Desc4Txt.Text.Replace("%", "");
        }

        private void BenitoDescTextBox_Enter(object sender, EventArgs e)
        {
            this.Desc5Text.Text = this.Desc5Text.Text.Replace("%", "");
        }

        private void ValenteDescTextBox_Enter(object sender, EventArgs e)
        {
            this.Desc6Txt.Text = this.Desc6Txt.Text.Replace("%", "");
        }

        private void Pvp2DescTextBox_Enter(object sender, EventArgs e)
        {
            this.Desc2Text.Text = this.Desc2Text.Text.Replace("%", "");
        }

        private void PlusDescTextBox_Enter(object sender, EventArgs e)
        {
            this.PlusDescTxt.Text = this.PlusDescTxt.Text.Replace("%", "");
        }

        private void CastyDescTextBox_Validated(object sender, EventArgs e)
        {
            CalculosPrecios();
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
                CalculosPrecios();
                Validate();
                // AñadirId();
            }

        }
        private void DtPreciosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CalculosIva();
        }
        private void CargarTexbox()
        {
            try
            {

                if (this.dtPreciosDataGridView.RowCount >= 0)
                {

                    int fila = this.dtPreciosDataGridView.CurrentCell.RowIndex;
                    LimpiarTextox();
                    this.Id_Articulo.Text = this.dtPreciosDataGridView.Rows[fila].Cells[0].FormattedValue.ToString();
                    this.ReferenciaTextBox.Text = this.dtPreciosDataGridView.Rows[fila].Cells[1].FormattedValue.ToString();
                    this.DescripccionTextBox.Text = this.dtPreciosDataGridView.Rows[fila].Cells[2].FormattedValue.ToString();
                    this.CosteTextBox.Text = this.dtPreciosDataGridView.Rows[fila].Cells[3].FormattedValue.ToString();
                    this.Pvp1Text.Text = this.dtPreciosDataGridView.Rows[fila].Cells[4].FormattedValue.ToString();
                    this.Pvp2Text.Text = this.dtPreciosDataGridView.Rows[fila].Cells[5].FormattedValue.ToString();
                    this.Pvp3Txt.Text = this.dtPreciosDataGridView.Rows[fila].Cells[6].FormattedValue.ToString();
                    this.Pvp4Txt.Text = this.dtPreciosDataGridView.Rows[fila].Cells[7].FormattedValue.ToString();
                    this.Pvp5Txt.Text = this.dtPreciosDataGridView.Rows[fila].Cells[8].FormattedValue.ToString();
                    this.Pvp6Txt.Text = this.dtPreciosDataGridView.Rows[fila].Cells[9].FormattedValue.ToString();
                    this.PlusLabel2.Text = this.dtPreciosDataGridView.Rows[fila].Cells[10].FormattedValue.ToString();
                    this.familiaComboBox.Text = ClasArticulos.ListaArticulos.lista[fila].Familia.ToString();
                    this.Desc3Txt.Text = ClasArticulos.ListaArticulos.lista[fila].CastyDesc.ToString();
                }
            }
            catch (Exception)
            {

                // throw;
            }
        }
        private void LimpiarTextox()
        {

            foreach (Control ctrl in this.TabPageArti1.Controls)
            {
                if (ctrl is TextBox)
                {
                    this.ReferenciaTextBox.ReadOnly = true;
                    ctrl.Text = string.Empty;

                }
            }
            foreach (Control ctrl in this.TabPageArti2.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = string.Empty;
                }
            }
            foreach (Control ctrl in this.TabPageArti1.Controls)
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

            foreach (Control ctrl in this.TabPageArti1.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = true;
                    ctrl.ForeColor = Color.FromArgb(153, 40, 7);
                }
            }
            foreach (Control ctrl in this.TabPageArti2.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = true;
                    ctrl.ForeColor = Color.FromArgb(153, 40, 7);
                }
            }
            foreach (Control ctrl in this.TabPageArti2.Controls)
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
            foreach (Control ctrl in this.TabPageArti1.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = false;
                    ctrl.ForeColor = Color.Black;
                }
            }
            foreach (Control ctrl in this.TabPageArti2.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = false;
                    ctrl.ForeColor = Color.Black;
                }
            }
            foreach (Control ctrl in this.TabPageArti2.Controls)
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
                // AñadirId();
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
               " @PVP1, @DESC2, @PVP2, @DESC3, @PVP3, @DESC4, @PVP4, @DESC5, @PVP5, @DESC6," +
               " @PVP6,@DESCPLUS, @PLUS, @UNIDADPALE, @MINIMOSSTO, @STOCK , @FAMILIA, @FECHA, @Baja)";

            }
            else
            {
                consulta = "UPDATE " + "[" + TipoTabla + "]" + " SET Id = @Id,REFERENCIA = @REFERENCIA,Oem=@Oem, DESCRIPCCI = @DESCRIPCCI,COSTE = @COSTE" +
              ",GANANCIA = @GANANCIA,PVP1 = @PVP1,DESC2 = @DESC2,PVP2 = @PVP2,DESC3 = @DESC3,PVP3 = @PVP3" +
              ",DESC4 = @DESC4, PVP4 = @PVP4,DESC5 = @DESC5,PVP5 = @PVP5,DESC6 = @DESC6," +
              "PVP6= @PVP6,DESCPLUS = @DESPLUS,PLUS = @PLUS,UNIDADPALE= @UNIDADPALE,MINIMOSSTO = @MINIMOSSTO," +
              "STOCK= @STOCK,FAMILIA= @FAMILIA,FECHA = @FECHA,Baja = @Baja WHERE Id = @Id";

            }

            // ClsConexionDb.CadenaConexion = cadena;
            ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
            {
                if (NuevaConexion.SiConexionDb)
                {
                    try
                    {
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", this.Id_Articulo.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@REFERENCIA", this.ReferenciaTextBox.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@Oem", string.IsNullOrEmpty(this.OemText.Text) ? (object)DBNull.Value : this.OemText.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@DESCRIPCCI", this.DescripccionTextBox.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@COSTE", this.CosteTextBox.Text.Replace("€", ""));
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@GANANCIA", string.IsNullOrEmpty(this.GananciaTextBox.Text) ? (object)DBNull.Value : this.Ganancia / 100);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@PVP1", string.IsNullOrEmpty(this.Pvp1Text.Text) ? (object)DBNull.Value : this.Pvp1Text.Text.Replace("€", ""));
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@DESC2", string.IsNullOrEmpty(this.Desc2Text.Text) ? (object)DBNull.Value : this.Pvp2Desc / 100);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@PVP2", string.IsNullOrEmpty(this.Pvp2Text.Text) ? (object)DBNull.Value : this.Pvp2Text.Text.Replace("€", ""));
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@DESC3", string.IsNullOrEmpty(this.Desc3Txt.Text) ? (object)DBNull.Value : this.CastiDesc / 100);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@PVP3", string.IsNullOrEmpty(this.Pvp3Txt.Text) ? (object)DBNull.Value : this.Pvp3Txt.Text.Replace("€", ""));
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@DESC4", string.IsNullOrEmpty(this.Desc4Txt.Text) ? (object)DBNull.Value : this.SuarezDesc / 100);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@PVP4", string.IsNullOrEmpty(this.Pvp4Txt.Text) ? (object)DBNull.Value : this.Pvp4Txt.Text.Replace("€", ""));
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@DESC5", string.IsNullOrEmpty(this.Desc5Text.Text) ? (object)DBNull.Value : this.BenitoDesc / 100);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@PVP5", string.IsNullOrEmpty(this.Pvp5Txt.Text) ? (object)DBNull.Value : this.Pvp5Txt.Text.Replace("€", ""));
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@DESC6", string.IsNullOrEmpty(this.Desc6Txt.Text) ? (object)DBNull.Value : this.ValenteDesc / 100);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@PVP6", string.IsNullOrEmpty(this.Pvp6Txt.Text) ? (object)DBNull.Value : this.Pvp6Txt.Text.Replace("€", ""));
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@DESCPLUS", string.IsNullOrEmpty(this.PlusDescTxt.Text) ? (object)DBNull.Value : this.PlusDesc / 100);
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
                        if (this.Id_Articulo.Tag.ToString() == "NUEVO")
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
            string consulta = "";
            if (this.panelBotonesArticulo.Tag.ToString() == "NUEVO")
            {
                consulta = "INSERT INTO " + "[" + TipoTabla + "]" + " VALUES (@Id, @REFERENCIA,@Oem, @DESCRIPCCI, @COSTE, @GANANCIA," +
               " @PVP1, @DESC2, @PVP2, @DESC3, @PVP3, @DESC4, @PVP4, @DESC5, @PVP5, @DESC6," +
               " @PVP6,@DESCPLUS, @PLUS, @UNIDADPALE, @MINIMOSSTO, @STOCK , @FAMILIA, @FECHA, @Baja)";

            }
            else
            {
                consulta = "UPDATE " + "[" + TipoTabla + "]" + " SET Id = @Id,REFERENCIA = @REFERENCIA,Oem=@Oem, DESCRIPCCI = @DESCRIPCCI,COSTE = @COSTE" +
              ",GANANCIA = @GANANCIA,PVP1 = @PVP1,DESC2 = @DESC2,PVP2 = @PVP2,DESC3 = @DESC3,PVP3 = @PVP3" +
              ",DESC4 = @DESC4, PVP4 = @PVP4,DESC5 = @DESC5,PVP5 = @PVP5,DESC6 = @DESC6," +
              "PVP6= @PVP6,DESCPLUS = @DESPLUS,PLUS = @PLUS,UNIDADPALE= @UNIDADPALE,MINIMOSSTO = @MINIMOSSTO," +
              "STOCK= @STOCK,FAMILIA= @FAMILIA,FECHA = @FECHA,Baja = @Baja WHERE Id = @Id";

            }
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            {
                NuevaConexion.ComandoSql.CommandType = CommandType.Text;
                if (NuevaConexion.SiConexionSql)
                {
                    try
                    {
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", Convert.ToInt32(this.Id_Articulo.Text));
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@REFERENCIA", this.ReferenciaTextBox.Text.ToString());
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@Oem", string.IsNullOrEmpty(this.OemText.Text) ? (object)DBNull.Value : this.OemText.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@DESCRIPCCI", this.DescripccionTextBox.Text.ToString());
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@COSTE", Convert.ToDouble(this.CosteTextBox.Text.Replace("€", "")));
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@GANANCIA", string.IsNullOrEmpty(this.GananciaTextBox.Text) ? (object)DBNull.Value : this.Ganancia / 100);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@PVP1", string.IsNullOrEmpty(this.Pvp1Text.Text) ? (object)DBNull.Value : this.Pvp1Text.Text.Replace("€", ""));
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@DESC2", string.IsNullOrEmpty(this.Desc2Text.Text) ? (object)DBNull.Value : this.Pvp2Desc / 100);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@PVP2", string.IsNullOrEmpty(this.Pvp2Text.Text) ? (object)DBNull.Value : this.Pvp2Text.Text.Replace("€", ""));
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@DESC3", string.IsNullOrEmpty(this.Desc3Txt.Text) ? (object)DBNull.Value : this.CastiDesc / 100);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@PVP3", string.IsNullOrEmpty(this.Pvp3Txt.Text) ? (object)DBNull.Value : this.Pvp3Txt.Text.Replace("€", ""));
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@DESC4", string.IsNullOrEmpty(this.Desc4Txt.Text) ? (object)DBNull.Value : this.SuarezDesc / 100);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@PVP4", string.IsNullOrEmpty(this.Pvp4Txt.Text) ? (object)DBNull.Value : this.Pvp4Txt.Text.Replace("€", ""));
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@DESC5", string.IsNullOrEmpty(this.Desc5Text.Text) ? (object)DBNull.Value : this.BenitoDesc / 100);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@PVP5", string.IsNullOrEmpty(this.Pvp5Txt.Text) ? (object)DBNull.Value : this.Pvp5Txt.Text.Replace("€", ""));
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@DESC6", string.IsNullOrEmpty(this.Desc6Txt.Text) ? (object)DBNull.Value : this.ValenteDesc / 100);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@PVP6", string.IsNullOrEmpty(this.Pvp6Txt.Text) ? (object)DBNull.Value : this.Pvp6Txt.Text.Replace("€", ""));
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@DESCPLUS", string.IsNullOrEmpty(this.PlusDescTxt.Text) ? (object)DBNull.Value : this.PlusDesc / 100);
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
                        if (this.Id_Articulo.Tag.ToString() == "NUEVO")
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
            if (this.Desc3Txt.Text != string.Empty)
            {
                this.CastiDesc = Convert.ToDouble(this.Desc3Txt.Text);
                this.Desc3Txt.Text = Convert.ToString(this.CastiDesc / 100);
            }

        }

        private void SuarezDescTextBox_Leave(object sender, EventArgs e)
        {
            if (this.GananciaTextBox.Text != string.Empty)
            {
                this.SuarezDesc = Convert.ToDouble(this.Desc4Txt.Text);
                this.Desc4Txt.Text = Convert.ToString(this.SuarezDesc / 100);
            }

        }

        private void BenitoDescTextBox_Leave(object sender, EventArgs e)
        {
            if (this.Desc5Text.Text != string.Empty)
            {
                this.BenitoDesc = Convert.ToDouble(this.Desc5Text.Text);
                this.Desc5Text.Text = Convert.ToString(this.BenitoDesc / 100);
            }

        }

        private void ValenteDescTextBox_Leave(object sender, EventArgs e)
        {
            if (this.Desc6Txt.Text != string.Empty)
            {
                this.ValenteDesc = Convert.ToDouble(this.Desc6Txt.Text);
                this.Desc6Txt.Text = Convert.ToString(this.ValenteDesc / 100);
            }

        }

        private void Pvp2DescTextBox_Leave(object sender, EventArgs e)
        {
            if (this.Desc2Text.Text != string.Empty)
            {
                this.Pvp2Desc = Convert.ToDouble(this.Desc2Text.Text);
                this.Desc2Text.Text = Convert.ToString(this.Pvp2Desc / 100);
            }


        }

        private void PlusDescTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (this.PlusDescTxt.Text != string.Empty)
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
            if (this.PlusDescTxt.Text != string.Empty)
            {
                this.PlusDesc = Convert.ToDouble(this.PlusDescTxt.Text);
                this.PlusDescTxt.Text = Convert.ToString(this.PlusDesc / 100);
            }
        }

        private void dtPreciosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //CalculosIva();
        }

        private void dtPreciosDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //CalculosIva();
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


