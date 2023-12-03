using Conexiones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormObras : Form
    {
        public FormObras()
        {
            InitializeComponent();
        }

        private void FormObras_Load(object sender, EventArgs e)
        {

        }
        private void ModificarOjetosPais()
        {
            this.PaisTxt.ReadOnly = false;
            this.PanelBotones_Obra.Enabled = false;
            this.BtnCancelarObra.Enabled = true;
            this.BtnGuardarObra.Enabled = true;
            this.dataGridObras.Enabled = false;
        }
        private void RestaurarOjetosPais()
        {
            this.PaisTxt.ReadOnly = true;
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

            if (this.PaisTxt.Text.Length < 4)
            {
                ok = false;
                this.ErrorProve.SetError(this.PaisTxt, "_ingresar Nonbre Proveedor valido (( minimo 4 Caracteres))");
            }


            return ok;
        }
        private void BorrarErrorObra()
        {
            this.ErrorProve.SetError(this.PaisTxt, "");

        }
        private void GuardarObrasDb()
        {
            string consulta = "";
            if (this.PanelBotones_Obra.Tag.ToString() == "Nuevo")
            {
                consulta = "  INSERT INTO [DtObras]([@Id_Obras],[@Obras])";

            }
            else
            {
                consulta = "UPDATE [DtObras] SET [Id_Obras] = @Id_Obras,[Obras] = @Obras, " +
                " WHERE Id = @Id";
            }
            ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
            try
            {
                if (NuevaConexion.SiConexionDb)
                {
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id_Obras", string.IsNullOrEmpty(this.Id_obra.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Id_obra.Text));
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Obras", string.IsNullOrEmpty(this.PaisTxt.Text) ? (object)DBNull.Value : this.PaisTxt.Text);
                    NuevaConexion.ComandoDb.ExecuteNonQuery();
                    NuevaConexion.ComandoDb.Parameters.Clear();
                    Validate();
                    this.dataGridObras.EndEdit();
                    this.DtPaisBindinsource.EndEdit();
                    MessageBox.Show("Se Guardo Correctamente", "GUARDAR OBRAS ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetosPais();
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
                consulta = "  INSERT INTO [DtObras]([@Id_Obras],[@Obras])";

            }
            else
            {
                consulta = "UPDATE [DtObras] SET [Id_Obras] = @Id_Obras,[Obras] = @Obras, " +
                " WHERE Id = @Id";
            }
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                if (NuevaConexion.SiConexionSql)
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id_Obras", string.IsNullOrEmpty(this.Id_obra.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Id_obra.Text));
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Obras", string.IsNullOrEmpty(this.PaisTxt.Text) ? (object)DBNull.Value : this.PaisTxt.Text);
                    NuevaConexion.ComandoSql.ExecuteNonQuery();
                    NuevaConexion.ComandoSql.Parameters.Clear();
                    Validate();
                    this.DtPaisBindinsource.EndEdit();
                    this.dataGridObras.EndEdit();
                    MessageBox.Show("Se Guardo Correctamente", "GUARDAR OBRA ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetosPais();
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
                string consulta = "Delete from  [DtObras]   WHERE Id_Obras= '@Id_Obras'";
                ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
                try
                {
                    {
                        if (NuevaConexion.SiConexionDb)
                        {
                            NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id_Obras", this.Id_obra.Text);
                            NuevaConexion.ComandoDb.ExecuteNonQuery();
                            this.dataGridObras.Rows.RemoveAt(this.dataGridObras.CurrentCell.RowIndex);
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

            string consulta = "Delete from  [DtObras]   WHERE Id_Obras= '@Id_Obras'";
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                {
                    if (NuevaConexion.SiConexionSql)
                    {
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id_Obras", this.Id_obra.Text);
                        NuevaConexion.ComandoSql.ExecuteNonQuery();
                        this.dataGridObras.Rows.RemoveAt(this.dataGridObras.CurrentCell.RowIndex);
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
        private void BtnNuevoObra_Click(object sender, EventArgs e)
        {

        }

        private void BtnModificarObra_Click(object sender, EventArgs e)
        {
            if (dtObrasBindingSource.Count > 0)
            {
                this.PanelBotones_Obra.Tag = "Modificar";
                ModificarOjetosPais();
            }
        }

        private void BtnEliminarObra_Click(object sender, EventArgs e)
        {
            if (this.dataGridObras.RowCount >= 0)
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
            if (Id_obra.Text == string.Empty)
            {
                MessageBox.Show("Falta (( id ))) o  ((Datos))", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (EspacioDiscosObra(ClasDatos.RutaMultidatos, 25))

                BorrarErrorObra();
            if (ValidarPais())
            {
                {
                    try
                    {
                        foreach (DataGridViewRow fila in this.dataGridObras.Rows)
                        {
                            if (fila.Cells[1].ToString() == this.PaisTxt.Text)
                            {
                                if (this.dataGridObras.CurrentCell.RowIndex == fila.Index)
                                {
                                    break;
                                }
                                MessageBox.Show(this.PaisTxt.Text.ToString(), "YA EXISTE ESTA PAIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.PaisTxt.Focus();
                                this.PaisTxt.SelectAll();
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
            if (this.dataGridObras.RowCount >= 0)
            {
                try
                {
                    if (this.PanelBotones_Obra.Tag.ToString() == "Nuevo")
                    {
                        if (this.dataGridObras.RowCount > 0)
                        {
                            this.dataGridObras.Rows.RemoveAt(this.dataGridObras.CurrentCell.RowIndex);
                        }
                    }
                }
                catch (Exception)
                {

                    //  throw;
                }

            }
            RestaurarOjetosPais();
        }

        private void BtnSalir_Obra_Click(object sender, EventArgs e)
        {
            if (this.BtnGuardarObra.Enabled == true)
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
    }
}
