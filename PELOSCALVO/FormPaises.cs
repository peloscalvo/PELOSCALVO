using Conexiones;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormPaises : Form
    {
         public static FormPaises MenuB;
        public FormPaises()
        {        
            InitializeComponent();
            FormPaises.MenuB = this;
        }
        private void FormPaises_Load(object sender, EventArgs e)
        {
            try
            {

                if (FormMenuPrincipal.menu2principal.dsMulti2 != null)
                {
                    this.DtPaisBindinsource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2.DtPaises;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
           // AñadirIdBuscar();
        }
        public void AñadirIdPais()
        {
            int ii = 0;
            foreach (var fila in FormMenuPrincipal.menu2principal.dsMulti2.DtPaises)
            {
                fila["IdFila"] = ii.ToString();
                ii++;
            }

        }
        private void ModificarOjetosPais()
        {
            this.NombrePais.ReadOnly = false;
            this.PanelBotones_Pais.Enabled = false;
            this.BtnCancelarPais.Enabled = true;
            this.BtnGuardarPais.Enabled = true;
            this.dataGridPais.Enabled = false;
        }
        private void RestaurarOjetosPais()
        {
            this.NombrePais.ReadOnly = true;
            this.PanelBotones_Pais.Enabled = true;
            this.BtnCancelarPais.Enabled = false;
            this.BtnGuardarPais.Enabled = false;
            this.dataGridPais.Enabled = true;
        }
        private bool EspacioDiscosPais(string nombreDisco, int Espacio)
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

            if (this.NombrePais.Text.Length < 3)
            {
                ok = false;
                this.ErrorProve.SetError(this.NombrePais, "_ingresar Nonbre Pais valido (( minimo 3 Caracteres))");
            }


            return ok;
        }
        private void BorrarErrorPais()
        {
            this.ErrorProve.SetError(this.NombrePais, "");

        }
        private void GuardarPaiesDb()
        {
            string consulta = "";
            if (this.PanelBotones_Pais.Tag.ToString() == "Nuevo")
            {
                consulta = "  INSERT INTO [DtPaises] VALUES([@Id],[@Paises])";

            }
            else
            {
                consulta = "UPDATE [DtPaises] SET [Id] = @Id,[Paises] = @Paises, " +
                " WHERE Id = @Id";
            }
            ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
            try
            {
                if (NuevaConexion.SiConexionDb)
                {
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", string.IsNullOrEmpty(this.Id_Pais.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Id_Pais.Text));
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Paises", string.IsNullOrEmpty(this.NombrePais.Text) ? (object)DBNull.Value : this.NombrePais.Text);
                    NuevaConexion.ComandoDb.ExecuteNonQuery();
                    NuevaConexion.ComandoDb.Parameters.Clear();
                    Validate();
                    this.dataGridPais.EndEdit();
                    this.DtPaisBindinsource.EndEdit();
                    MessageBox.Show("Se Guardo Correctamente", "GUARDAR PAIS ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetosPais();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "PAIS");
            }
            finally
            {
                if (NuevaConexion.CerrarConexionDB)
                {

                }
            }
        }
        private void GuardarPaisSql()
        {
            string consulta = "";
            if (this.PanelBotones_Pais.Tag.ToString() == "Nuevo")
            {
                consulta = "  INSERT INTO [DtPaises] VALUES([@Id],[@Paises])";

            }
            else
            {
                consulta = "UPDATE [DtPaises] SET [Id] = @Id,[Paises] = @Paises, " +
                " WHERE Id = @Id";
            }
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                if (NuevaConexion.SiConexionSql)
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", string.IsNullOrEmpty(this.Id_Pais.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Id_Pais.Text));
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Paises", string.IsNullOrEmpty(this.NombrePais.Text) ? (object)DBNull.Value : this.NombrePais.Text);
                    NuevaConexion.ComandoSql.ExecuteNonQuery();
                    NuevaConexion.ComandoSql.Parameters.Clear();
                    Validate();
                    this.DtPaisBindinsource.EndEdit();
                    this.dataGridPais.EndEdit();
                    MessageBox.Show("Se Guardo Correctamente", "GUARDAR PAIS ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetosPais();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "PAISES");
            }
            finally
            {
                if (NuevaConexion.CerrarConexionSql)
                {

                }
            }
        }
        private void EliminarPaisBb()
        {
            if (File.Exists(ClasDatos.RutaBaseDatosDb))
            {
                string consulta = "Delete from  [DtPaises]   WHERE Id= @Id";
                ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
                try
                {
                    {
                        if (NuevaConexion.SiConexionDb)
                        {
                            NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", Convert.ToInt32(this.Id_Pais.Text));
                            NuevaConexion.ComandoDb.ExecuteNonQuery();
                            this.dataGridPais.Rows.RemoveAt(this.dataGridPais.CurrentCell.RowIndex);
                            this.DtPaisBindinsource.EndEdit();
                            Validate();
                            this.dataGridPais.Refresh();
                            this.dataGridPais.Focus();
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
        private void EliminarPaisSql()
        {

            string consulta = "Delete from  [DtPaises]   WHERE Id= @Id";
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                {
                    if (NuevaConexion.SiConexionSql)
                    {
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", Convert.ToInt32(this.Id_Pais.Text));
                        NuevaConexion.ComandoSql.ExecuteNonQuery();
                        this.dataGridPais.Rows.RemoveAt(this.dataGridPais.CurrentCell.RowIndex);
                        this.DtPaisBindinsource.EndEdit();
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
        private void BtnNuevoPais_Click(object sender, EventArgs e)
        {
            this.PanelBotones_Pais.Tag = "Nuevo";
            try
            {
                this.dataGridPais.Sort(this.dataGridPais.Columns[0], ListSortDirection.Ascending);
                int numeroFILA = this.dataGridPais.Rows.Count;
                this.DtPaisBindinsource.AddNew();
                if (this.dataGridPais.CurrentCell.RowIndex == 0)
                {
                    this.Id_Pais.Text = "1";
                    this.dataGridPais.Rows[0].Cells[0].Value = "1";
                }
                if (numeroFILA > 0)
                {
                    if (this.dataGridPais.Rows[numeroFILA - 1].Cells[0].Value.ToString() == string.Empty)
                    {
                        Random r = new Random();
                        int VALORid = r.Next(5000, 100000000);
                        this.dataGridPais.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.Id_Pais.Text = VALORid.ToString();
                    }
                    else
                    {
                        int VALORid = Convert.ToInt32(this.dataGridPais.Rows[numeroFILA - 1].Cells[0].Value) + 1;
                        this.dataGridPais.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.Id_Pais.Text = VALORid.ToString();
                    }

                }
                if (DtPaisBindinsource.Count <= 2)
                {
                    this.NombrePais.Text = "España";
                }
                this.NombrePais.Focus();
                this.NombrePais.SelectAll();
                ModificarOjetosPais();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnModificarPais_Click(object sender, EventArgs e)
        {
            if (this.DtPaisBindinsource.Count > 0)
            {
                this.PanelBotones_Pais.Tag = "Modificar";
                ModificarOjetosPais();
            }
        }

        private void BtnEliminarPais_Click(object sender, EventArgs e)
        {
            if (this.DtPaisBindinsource.Count > 0)
            {
                if (MessageBox.Show("Desea Eliminar Permanentemente ", "ELIMINAR ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    if (ClsConexionSql.SibaseDatosSql)
                    {
                        EliminarPaisSql();
                    }
                    else
                    {
                        if (File.Exists(ClasDatos.RutaBaseDatosDb))
                        {
                            EliminarPaisBb();

                        }
                        else
                        {
                            MessageBox.Show(" No Se Pudo Eliminar", "FALTA ARCHIVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void BtnGuardarPais_Click(object sender, EventArgs e)
        {
            if (this.Id_Pais.Text == string.Empty)
            {
                MessageBox.Show("Falta (( id ))) o  ((Datos))", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (EspacioDiscosPais(Directory.GetCurrentDirectory(), 25))
            {

                BorrarErrorPais();
                if (ValidarPais())
                {
                    try
                    {
                        foreach (DataGridViewRow fila in this.dataGridPais.Rows)
                        {
                            if (fila.Cells[1].Value.ToString() == this.NombrePais.Text)
                            {
                                if (this.dataGridPais.CurrentCell.RowIndex == fila.Index)
                                {
                                    break;
                                }
                                MessageBox.Show(this.NombrePais.Text.ToString(), "YA EXISTE ESTE PAIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.NombrePais.Focus();
                                this.NombrePais.SelectAll();
                                return;
                            }

                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    if (MessageBox.Show(" ¿Aceptar Guardar Pais ? ", " GUARDAR PAIS ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (ClsConexionSql.SibaseDatosSql)
                        {
                            GuardarPaisSql();
                        }
                        else
                        {

                            if (File.Exists(ClasDatos.RutaBaseDatosDb))
                            {
                                GuardarPaiesDb();
                            }
                            else
                            {
                                MessageBox.Show("Archivo No Se Encuentra", " FALLO AL GUARDAR ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                this.PanelBotones_Pais.Enabled = false;
                            }
                        }
                    }

                }
            }
        }

        private void BtnCancelarPais_Click(object sender, EventArgs e)
        {
            BorrarErrorPais();
            if (this.DtPaisBindinsource.Count > 0)
            {
                try
                {
                    if (this.PanelBotones_Pais.Tag.ToString() == "Nuevo")
                    {
                  
                            this.dataGridPais.Rows.RemoveAt(this.dataGridPais.CurrentCell.RowIndex);
                    }
                }
                catch (Exception)
                {

                    //  throw;
                }

            }
            RestaurarOjetosPais();
        }

        private void BtnSalir_Pais_Click(object sender, EventArgs e)
        {
            if (this.BtnGuardarPais.Enabled == false)
            {
                if (MessageBox.Show(" Salir Paises  ", " SALIR ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

        private void FormPaises_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.BtnGuardarPais.Enabled == true)
            {
                e.Cancel = true;
            }
        }

        private void BtnBuscarPais_Click(object sender, EventArgs e)
        {
            if (DtPaisBindinsource.Count > 0)
            {
                ClasDatos.QUEform = "Paises";
                AñadirIdPais();
                FormBuscar frm = new FormBuscar();
                frm.CargarDatos(1, " Paises", "Paises");
                frm.BringToFront();
                frm.ShowDialog();

            }
        }
    }
}
