using Conexiones;
using System;
using System.IO;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormDescuentos : Form
    {
        public FormDescuentos()
        {
            InitializeComponent();
        }
        private void FormDescuentos_Load(object sender, EventArgs e)
        {
            try
            {
                if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION != null)
                {
                    this.dtConfiguracionPrincipalBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION;


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void BtnSalirTipoTarifa_Click(object sender, EventArgs e)
        {
            if (this.BtnGuardarDescuentos.Enabled == false)
            {
                if (MessageBox.Show(" Salir Descuentos  ", " SALIR ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Close();
                }
            }
        }
        private void ModificarOjetosTari()
        {
            this.NombreTarifaTxt.ReadOnly = false;
            this.panelBotonesTipoTarifa.Enabled = false;
            this.BtnCancelarTipoTarifa.Enabled = true;
            this.BtnGuardarDescuentos.Enabled = true;
            this.dtTarifaTipoDataGridView.Enabled = false;
        }
        private void RestaurarOjetosTari()
        {
            this.NombreTarifaTxt.ReadOnly = true;
            this.panelBotonesTipoTarifa.Enabled = true;
            this.BtnCancelarTipoTarifa.Enabled = false;
            this.BtnGuardarDescuentos.Enabled = false;
            this.dtTarifaTipoDataGridView.Enabled = true;
        }
        private bool EspacioDiscosObra(string nombreDisco, int Espacio)
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
        private bool ValidarTarifa()
        {
            bool ok = true;

            if (this.NombreTarifaTxt.Text.Length < 3)
            {
                ok = false;
                this.ErrorDescuentos.SetError(this.NombreTarifaTxt, "_ingresar Nonbre Tarifa valido (( minimo 4 Caracteres))");
            }


            return ok;
        }
        private void BorrarErrorTari()
        {
            this.ErrorDescuentos.SetError(this.NombreTarifaTxt, "");

        }
        private void GuardarTarifaDb()
        {
            string consulta = "";
            if (this.panelBotonesTipoTarifa.Tag.ToString() == "Nuevo")
            {
                consulta = "  INSERT INTO [DtTarifa] VALUES([@Id],[@TarifaTipo],@TarifaReal,[@EnlaceTarifa])";

            }
            else
            {
                consulta = "UPDATE [DtTarifa] SET [Id] = @Id,[Tarifa] = @TarifaTipo ,[EnlaceTarifa] = @EnlaceTarifa " +
                " WHERE Id = @Id";
            }
            ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
            try
            {
                if (NuevaConexion.SiConexionDb)
                {

                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", string.IsNullOrEmpty(this.IdTarifa.Text) ? (object)DBNull.Value : Convert.ToInt32(this.IdTarifa.Text));
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@TarifaTipo", string.IsNullOrEmpty(this.NombreTarifaTxt.Text) ? (object)DBNull.Value : this.NombreTarifaTxt.Text);
                    if (this.panelBotonesTipoTarifa.Tag.ToString() == "Nuevo")
                    {
                        int FilaDesc = this.dtTarifaTipoDataGridView.CurrentCell.RowIndex;
                        string NombreTarifa = "PVP1";
                        if (FilaDesc > 6)
                        {
                            NombreTarifa = "PVP" + FilaDesc + 1;
                        }
                        if (FilaDesc == 6)
                        {
                            NombreTarifa = "PLUS";
                        }
                        if (FilaDesc == 7)
                        {
                            NombreTarifa = "IVA";
                        }

                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@TarifaReal", string.IsNullOrEmpty(NombreTarifa) ? (object)DBNull.Value : NombreTarifa);

                    }

                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@EnlaceTarifa", string.IsNullOrEmpty(this.IdEmpresa.Text) ? (object)DBNull.Value : Convert.ToInt32(this.IdEmpresa.Text));
                    NuevaConexion.ComandoDb.ExecuteNonQuery();
                    NuevaConexion.ComandoDb.Parameters.Clear();
                    Validate();
                    this.dtConfiDtTarifaTipoBindingSource.EndEdit();
                    this.dtTarifaTipoDataGridView.EndEdit();
                    MessageBox.Show("Se Guardo Correctamente", "GUARDAR TARIFA ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetosTari();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "TARIFAS");
            }
            finally
            {
                if (NuevaConexion.CerrarConexionDB)
                {

                }
            }
        }
        private void GuardarTarifaSql()
        {
            string consulta = "";
            if (this.panelBotonesTipoTarifa.Tag.ToString() == "Nuevo")
            {
                consulta = "  INSERT INTO [DtTarifa] VALUES([@Id],[@TarifaTipo],@TarifaReal,[@EnlaceTarifa])";

            }
            else
            {
                consulta = "UPDATE [DtTarifa] SET [Id] = @Id,[TarifaTipo] = @TarifaTipo ,[EnlaceTarifa] = @EnlaceTarifa " +
                " WHERE Id = @Id";
            }
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                if (NuevaConexion.SiConexionSql)
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", string.IsNullOrEmpty(this.IdTarifa.Text) ? (object)DBNull.Value : Convert.ToInt32(this.IdTarifa.Text));
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@TarifaTipo", string.IsNullOrEmpty(this.NombreTarifaTxt.Text) ? (object)DBNull.Value : this.NombreTarifaTxt.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@EnlaceTarifa", string.IsNullOrEmpty(this.IdEmpresa.Text) ? (object)DBNull.Value : Convert.ToInt32(this.IdEmpresa.Text));
                    if (this.panelBotonesTipoTarifa.Tag.ToString() == "Nuevo")
                    {
                        int FilaDesc = this.dtTarifaTipoDataGridView.CurrentCell.RowIndex;
                        string NombreTarifa = "PVP1";
                        if (FilaDesc > 6)
                        {
                            NombreTarifa = "PVP" + FilaDesc + 1;
                        }
                        if (FilaDesc == 6)
                        {
                            NombreTarifa = "PLUS";
                        }
                        if (FilaDesc == 7)
                        {
                            NombreTarifa = "IVA";
                        }

                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@TarifaReal", string.IsNullOrEmpty(NombreTarifa) ? (object)DBNull.Value : NombreTarifa);

                    }

                    NuevaConexion.ComandoSql.ExecuteNonQuery();
                    NuevaConexion.ComandoSql.Parameters.Clear();
                    Validate();
                    this.dtConfiDtTarifaTipoBindingSource.EndEdit();
                    this.dtTarifaTipoDataGridView.EndEdit();
                    MessageBox.Show("Se Guardo Correctamente", "GUARDAR TARIFA ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetosTari();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "TARIFA");
            }
            finally
            {
                if (NuevaConexion.CerrarConexionSql)
                {

                }
            }
        }
        private void EliminarTarifaBb()
        {
            if (File.Exists(ClasDatos.RutaBaseDatosDb))
            {
                string consulta = "Delete from  [DtTarifaTipo]   WHERE Id= '@Id'";
                ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
                try
                {
                    {
                        if (NuevaConexion.SiConexionDb)
                        {
                            NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", this.IdTarifa.Text);
                            NuevaConexion.ComandoDb.ExecuteNonQuery();
                            this.dtTarifaTipoDataGridView.Rows.RemoveAt(this.dtTarifaTipoDataGridView.CurrentCell.RowIndex);
                            this.dtConfiDtTarifaTipoBindingSource.EndEdit();
                            Validate();
                            MessageBox.Show("Se Elimino Correctamente", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    if (NuevaConexion.CerrarConexionDB)
                    {

                    }
                }

            }
            else
            {
                MessageBox.Show("El Archivo No Se Encuentra", "ARCHIVO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
        }
        private void EliminarTarifaSql()
        {

            string consulta = "Delete from  [DtTarifaTipo]   WHERE Id= '@Id'";
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                {
                    if (NuevaConexion.SiConexionSql)
                    {
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", this.IdTarifa.Text);
                        NuevaConexion.ComandoSql.ExecuteNonQuery();
                        this.dtTarifaTipoDataGridView.Rows.RemoveAt(this.dtTarifaTipoDataGridView.CurrentCell.RowIndex);
                        this.dtConfiDtTarifaTipoBindingSource.EndEdit();
                        Validate();
                        MessageBox.Show("Se Elimino Correctamente", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                if (NuevaConexion.CerrarConexionSql)
                {

                }
            }

        }

        private void BtnNuevoTipoTarifa_Click(object sender, EventArgs e)
        {
            if (this.dtConfiguracionPrincipalBindingSource.Count <= 0)
            {
                MessageBox.Show("Debe Crear Ejercicio De esta Empresa", "FALTA EMPRESA");
                return;
            }

            if (this.dtTarifaTipoDataGridView.RowCount > 6)
            {
                MessageBox.Show("Maximo Permitido", "LIMITE");
                return;
            }
            this.panelBotonesTipoTarifa.Tag = "Nuevo";
            try
            {
                int VALORid = 0;
                // this.dtTarifaTipoDataGridView.Sort(this.dtTarifaTipoDataGridView.Columns[0], ListSortDirection.Ascending);
                int numeroFILA = this.dtTarifaTipoDataGridView.Rows.Count;
                this.dtConfiDtTarifaTipoBindingSource.AddNew();
                if (this.dtTarifaTipoDataGridView.CurrentCell.RowIndex == 0)
                {
                    this.IdTarifa.Text = "1";
                    this.dtTarifaTipoDataGridView.Rows[0].Cells[0].Value = "1";
                }
                if (numeroFILA > 0)
                {
                    if (this.dtTarifaTipoDataGridView.Rows[numeroFILA - 1].Cells[0].Value.ToString() == string.Empty)
                    {
                        VALORid = 1;
                        this.dtTarifaTipoDataGridView.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.IdTarifa.Text = VALORid.ToString();
                    }
                    else
                    {
                        VALORid = Convert.ToInt32(this.dtTarifaTipoDataGridView.Rows[numeroFILA - 1].Cells[0].Value) + 1;
                        this.dtTarifaTipoDataGridView.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.IdTarifa.Text = VALORid.ToString();
                    }

                }
                if (this.dtTarifaTipoDataGridView.RowCount < 7)
                {
                    this.NombreTarifaTxt.Text = "Pvp" + this.IdTarifa.Text.ToString();
                }
                if (this.dtTarifaTipoDataGridView.RowCount == 7)
                {
                    this.NombreTarifaTxt.Text = "IVA";
                }
                this.NombreTarifaTxt.Focus();
                this.NombreTarifaTxt.SelectAll();
                ModificarOjetosTari();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnModificarTipoTarifa_Click(object sender, EventArgs e)
        {
            if (this.dtConfiDtTarifaTipoBindingSource.Count > 0)
            {
                this.panelBotonesTipoTarifa.Tag = "Actualizar";
                if (this.dtTarifaTipoDataGridView.CurrentCell.RowIndex <= 1)
                {
                    MessageBox.Show("Este Descuento No Se Puede Modificar", "Descuento");
                    return;
                }

                if (this.dtTarifaTipoDataGridView.CurrentCell.RowIndex >= 6)
                {
                    MessageBox.Show("Este Descuento No Se Puede Modificar", "Descuento");
                    return;
                }
                ModificarOjetosTari();
            }
        }

        private void BtnCancelarTipoTarifa_Click(object sender, EventArgs e)
        {
            BorrarErrorTari();
            if (this.dtConfiDtTarifaTipoBindingSource.Count > 0)
            {
                try
                {
                    if (this.panelBotonesTipoTarifa.Tag.ToString() == "Nuevo")
                    {
                        if (this.dtTarifaTipoDataGridView.RowCount > 0)
                        {
                            this.dtTarifaTipoDataGridView.Rows.RemoveAt(this.dtTarifaTipoDataGridView.CurrentCell.RowIndex);
                        }
                    }
                    else
                    {
                        // ObraTxt.Text = string.Empty;
                    }
                }
                catch (Exception)
                {

                    //  throw;
                }

            }
            RestaurarOjetosTari();
        }

        private void BtnGuardarDescuentos_Click(object sender, EventArgs e)
        {
            if (this.IdTarifa.Text == string.Empty)
            {
                MessageBox.Show("Falta (( id ))) o  ((Datos))", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (EspacioDiscosObra(Directory.GetCurrentDirectory(), 25))
            {
                BorrarErrorTari();
                if (ValidarTarifa())
                {
                    try
                    {
                        foreach (DataGridViewRow fila in this.dtTarifaTipoDataGridView.Rows)
                        {
                            if (fila.Cells[1].ToString() == this.NombreTarifaTxt.Text)
                            {
                                if (this.dtTarifaTipoDataGridView.CurrentCell.RowIndex == fila.Index)
                                {
                                    break;
                                }
                                MessageBox.Show(this.NombreTarifaTxt.Text.ToString(), "YA EXISTE ESTE TARIFA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.NombreTarifaTxt.Focus();
                                this.NombreTarifaTxt.SelectAll();
                                return;
                            }

                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    if (MessageBox.Show(" ¿Aceptar Guardar Tarifa ? ", " GUARDAR TARIFA ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (ClsConexionSql.SibaseDatosSql)
                        {
                            GuardarTarifaSql();
                        }
                        else
                        {

                            if (File.Exists(ClasDatos.RutaBaseDatosDb))
                            {
                                GuardarTarifaDb();
                            }
                            else
                            {
                                MessageBox.Show("Archivo No Se Encuentra", " FALLO AL GUARDAR ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                this.panelBotonesTipoTarifa.Enabled = false;
                            }
                        }
                    }

                }
            }
        }

        private void FormDescuentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.BtnGuardarDescuentos.Enabled == true)
            {
                e.Cancel = true;
            }
        }

        private void EnlaceTarifa_Click(object sender, EventArgs e)
        {

        }
    }
}
