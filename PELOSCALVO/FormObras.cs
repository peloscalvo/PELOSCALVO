using Conexiones;
using System;
using System.IO;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormObras : Form
    {
        public static FormObras MenuB;
        public FormObras()
        {
            InitializeComponent();
            FormObras.MenuB = this;
        }

        private void FormObras_Load(object sender, EventArgs e)
        {
            try
            {

                if (FormMenuPrincipal.menu2principal.dsMulti2 != null)
                {
                    this.dtObrasBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2.DtObras;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

        }
        public void AñadirIdObras()
        {
            int ii = 0;
            foreach (var fila in FormMenuPrincipal.menu2principal.dsMulti2.DtObras)
            {
                fila["IdFila"] = ii.ToString();
                ii++;
            }

        }
        private void ModificarOjetosObra()
        {
            this.ObraTxt.ReadOnly = false;
            this.PanelBotones_Obra.Enabled = false;
            this.BtnCancelarObra.Enabled = true;
            this.BtnGuardarObra.Enabled = true;
            this.dataGridObras.Enabled = false;
        }
        private void RestaurarOjetosObra()
        {
            this.ObraTxt.ReadOnly = true;
            this.PanelBotones_Obra.Enabled = true;
            this.BtnCancelarObra.Enabled = false;
            this.BtnGuardarObra.Enabled = false;
            this.dataGridObras.Enabled = true;
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
        private bool ValidarPais()
        {
            bool ok = true;

            if (this.ObraTxt.Text.Length < 4)
            {
                ok = false;
                this.ErrorProve.SetError(this.ObraTxt, "_ingresar Nonbre Obra valido (( minimo 4 Caracteres))");
            }


            return ok;
        }
        private void BorrarErrorObra()
        {
            this.ErrorProve.SetError(this.ObraTxt, "");

        }
        private void GuardarObrasDb()
        {
            string consulta = "";
            if (this.PanelBotones_Obra.Tag.ToString() == "Nuevo")
            {
                consulta = "  INSERT INTO [DtObras] VALUES([@Id],[@Obras])";

            }
            else
            {
                consulta = "UPDATE [DtObras] SET [Id] = @Id,[Obras] = @Obras " +
                " WHERE Id = @Id";
            }
            ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
            try
            {
                if (NuevaConexion.SiConexionDb)
                {
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", string.IsNullOrEmpty(this.Id_obra.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Id_obra.Text));
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Obras", string.IsNullOrEmpty(this.ObraTxt.Text) ? (object)DBNull.Value : this.ObraTxt.Text);
                    NuevaConexion.ComandoDb.ExecuteNonQuery();
                    NuevaConexion.ComandoDb.Parameters.Clear();
                    Validate();
                    this.dataGridObras.EndEdit();
                    this.dtObrasBindingSource.EndEdit();
                    MessageBox.Show("Se Guardo Correctamente", "GUARDAR OBRAS ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetosObra();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "OBRAS");
            }
            finally
            {
                if (NuevaConexion.CerrarConexionDB)
                {

                }
            }
        }
        private void GuardarObrasSql()
        {
            string consulta = "";
            if (this.PanelBotones_Obra.Tag.ToString() == "Nuevo")
            {
                consulta = "  INSERT INTO [DtObras] VALUES([@Id],[@Obras])";

            }
            else
            {
                consulta = "UPDATE [DtObras] SET [Id] = @Id,[Obras] = @Obras  " +
                " WHERE Id = @Id";
            }
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                if (NuevaConexion.SiConexionSql)
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", string.IsNullOrEmpty(this.Id_obra.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Id_obra.Text));
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Obras", string.IsNullOrEmpty(this.ObraTxt.Text) ? (object)DBNull.Value : this.ObraTxt.Text);
                    NuevaConexion.ComandoSql.ExecuteNonQuery();
                    NuevaConexion.ComandoSql.Parameters.Clear();
                    Validate();
                    this.dtObrasBindingSource.EndEdit();
                    this.dataGridObras.EndEdit();
                    MessageBox.Show("Se Guardo Correctamente", "GUARDAR OBRA ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetosObra();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "OBRAS");
            }
            finally
            {
                if (NuevaConexion.CerrarConexionSql)
                {

                }
            }
        }
        private void EliminarObraBb()
        {
            if (File.Exists(ClasDatos.RutaBaseDatosDb))
            {
                string consulta = "Delete from  [DtObras]   WHERE Id= @Id";
                ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
                try
                {
                    {
                        if (NuevaConexion.SiConexionDb)
                        {
                            NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", Convert.ToInt32(this.Id_obra.Text));
                            NuevaConexion.ComandoDb.ExecuteNonQuery();
                            this.dataGridObras.Rows.RemoveAt(this.dataGridObras.CurrentCell.RowIndex);
                            this.dtObrasBindingSource.EndEdit();
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
        private void EliminarObraSql()
        {

            string consulta = "Delete from  [DtObras]   WHERE Id= @Id";
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                {
                    if (NuevaConexion.SiConexionSql)
                    {
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", Convert.ToInt32(this.Id_obra.Text));
                        NuevaConexion.ComandoSql.ExecuteNonQuery();
                        this.dataGridObras.Rows.RemoveAt(this.dataGridObras.CurrentCell.RowIndex);
                        this.dtObrasBindingSource.EndEdit();
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
        private void BtnNuevoObra_Click(object sender, EventArgs e)
        {
            this.PanelBotones_Obra.Tag = "Nuevo";
            try
            {
                int numeroFILA = this.dataGridObras.Rows.Count;
                this.dtObrasBindingSource.AddNew();
                if (this.dataGridObras.CurrentCell.RowIndex == 0)
                {
                    this.Id_obra.Text = "1";
                    this.dataGridObras.Rows[0].Cells[0].Value = "1";
                }
                if (numeroFILA > 0)
                {
                    if (this.dataGridObras.Rows[numeroFILA - 1].Cells[0].Value.ToString() == string.Empty)
                    {
                        Random r = new Random();
                        int VALORid = r.Next(5000, 100000000);
                        this.dataGridObras.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.Id_obra.Text = VALORid.ToString();
                    }
                    else
                    {
                        int VALORid = Convert.ToInt32(this.dataGridObras.Rows[numeroFILA - 1].Cells[0].Value) + 1;
                        this.dataGridObras.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.Id_obra.Text = VALORid.ToString();
                    }

                }
                this.ObraTxt.Text = "Casa";
                this.ObraTxt.Focus();
                this.ObraTxt.SelectAll();
                ModificarOjetosObra();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnModificarObra_Click(object sender, EventArgs e)
        {
            if (this.dtObrasBindingSource.Count > 0)
            {
                this.PanelBotones_Obra.Tag = "Modificar";
                ModificarOjetosObra();
            }
        }

        private void BtnEliminarObra_Click(object sender, EventArgs e)
        {
            if (this.dtObrasBindingSource.Count > 0)
            {
                if (MessageBox.Show("Desea Eliminar Permanentemente ", "ELIMINAR ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    if (ClsConexionSql.SibaseDatosSql)
                    {
                        EliminarObraSql();
                    }
                    else
                    {
                        if (File.Exists(ClasDatos.RutaBaseDatosDb))
                        {
                            EliminarObraBb();

                        }
                        else
                        {
                            MessageBox.Show(" No Se Pudo Eliminar", "FALTA ARCHIVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void BtnGuardarObra_Click(object sender, EventArgs e)
        {
            if (this.Id_obra.Text == string.Empty)
            {
                MessageBox.Show("Falta (( id ))) o  ((Datos))", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (EspacioDiscosObra(Directory.GetCurrentDirectory(), 25))
            {
                BorrarErrorObra();
                if (ValidarPais())
                {

                    try
                    {
                        foreach (DataGridViewRow fila in this.dataGridObras.Rows)
                        {
                            if (fila.Cells[1].Value.ToString() == this.ObraTxt.Text)
                            {
                                if (this.dataGridObras.CurrentCell.RowIndex == fila.Index)
                                {
                                    break;
                                }
                                MessageBox.Show(this.ObraTxt.Text.ToString(), "YA EXISTE ESTE OBRA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.ObraTxt.Focus();
                                this.ObraTxt.SelectAll();
                                return;
                            }

                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    if (MessageBox.Show(" ¿Aceptar Guardar Obra ? ", " GUARDAR OBRA ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (ClsConexionSql.SibaseDatosSql)
                        {
                            GuardarObrasSql();
                        }
                        else
                        {

                            if (File.Exists(ClasDatos.RutaBaseDatosDb))
                            {
                                GuardarObrasDb();
                            }
                            else
                            {
                                MessageBox.Show("Archivo No Se Encuentra", " FALLO AL GUARDAR ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                this.PanelBotones_Obra.Enabled = false;
                            }
                        }
                    }
                }

            }
        }

        private void BtnCancelarObra_Click(object sender, EventArgs e)
        {
            BorrarErrorObra();
            if (this.dtObrasBindingSource.Count > 0)
            {
                try
                {
                    if (this.PanelBotones_Obra.Tag.ToString() == "Nuevo")
                    {

                        this.dataGridObras.Rows.RemoveAt(this.dataGridObras.CurrentCell.RowIndex);
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
            RestaurarOjetosObra();
        }

        private void BtnSalir_Obra_Click(object sender, EventArgs e)
        {
            if (this.BtnGuardarObra.Enabled == false)
            {
                if (MessageBox.Show(" Salir Obras  ", " SALIR ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

        private void FormObras_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.BtnGuardarObra.Enabled == true)
            {
                e.Cancel = true;
            }
        }

        private void BtnBuscarObra_Click(object sender, EventArgs e)
        {
            if (dtObrasBindingSource.Count > 0)
            {
                ClasDatos.QUEform = "Obras";
                AñadirIdObras();
                FormBuscar frm = new FormBuscar();
                frm.CargarDatos(1, " Obras", "Obras");
                frm.BringToFront();
                frm.ShowDialog();
            }
        }
    }
}
