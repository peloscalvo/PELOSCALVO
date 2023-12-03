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
    public partial class FormProvincias : Form
    {
        public FormProvincias()
        {
            InitializeComponent();
        }
        private void FormProvincias_Load(object sender, EventArgs e)
        {
            try
            {
    
                if (FormMenuPrincipal.menu2principal.dsMulti2 != null)
                {
                    this.dtPaisesBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2;

                }
            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void ModificarOjetosProvi()
        {
            this.ProvinciaText.ReadOnly = false;
            this.PanelBotones_Provincia.Enabled = false;
            this.BtnCancelarProvincia.Enabled = true;
            this.BtnGuardarProvincia.Enabled = true;
            this.dataGridProvincias.Enabled = false;
        }
        private void RestaurarOjetosProvi()
        {
            this.ProvinciaText.ReadOnly = true;
            this.PanelBotones_Provincia.Enabled = true;
            this.BtnCancelarProvincia.Enabled = false;
            this.BtnGuardarProvincia.Enabled = false;
            this.dataGridProvincias.Enabled = true;
        }
        private bool EspacioDiscosProvincia(string nombreDisco, int Espacio)
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
        private bool ValidarProvi()
        {
            bool ok = true;

            if (this.ProvinciaText.Text.Length < 4)
            {
                ok = false;
                this.ErrorProve.SetError(this.ProvinciaText, "_ingresar Nonbre Proveedor valido (( minimo 4 Caracteres))");
            }


            return ok;
        }
        private void BorrarErrorProvi()
        {
            this.ErrorProve.SetError(this.ProvinciaText, "");

        }
        private void GuardarProvinciaDb()
        {
            string consulta = "";
            if (this.PanelBotones_Provincia.Tag.ToString() == "Nuevo")
            {
                consulta = "  INSERT INTO [DtProvincias]([@Id],[@ProvinciasProvincias])";

            }
            else
            {
                consulta = "UPDATE [DtProvincias] SET [Id] = @Id,[ProvinciasProvincias] = @ProvinciasProvincias, " +
                " WHERE Id = @Id";
            }
            ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
            try
            {
                if (NuevaConexion.SiConexionDb)
                {
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", string.IsNullOrEmpty(this.Id_Provincias.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Id_Provincias.Text));
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@ProvinciasProvincias", string.IsNullOrEmpty(this.ProvinciaText.Text) ? (object)DBNull.Value : this.ProvinciaText.Text);
                    NuevaConexion.ComandoDb.ExecuteNonQuery();
                    NuevaConexion.ComandoDb.Parameters.Clear();
                    Validate();
                    this.dataGridProvincias.EndEdit();
                    this.DtProvinciasBindinsource.EndEdit();
                    MessageBox.Show("Se Guardo Correctamente", "GUARDAR PROVINCIA ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetosProvi();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "PROVINCIAS");
            }
            finally
            {
                if (NuevaConexion.CerrarConexionDB)
                {

                }
            }
        }
        private void GuardarProvinciaSql()
        {
            string consulta = "";
            if (this.PanelBotones_Provincia.Tag.ToString() == "Nuevo")
            {
                consulta = "  INSERT INTO [DtProvincias]([@Id],[@ProvinciasProvincias])";

            }
            else
            {
                consulta = "UPDATE [DtProvincias] SET [Id] = @Id,[ProvinciasProvincias] = @ProvinciasProvincias, " +
                " WHERE Id = @Id";
            }
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                if (NuevaConexion.SiConexionSql)
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", string.IsNullOrEmpty(this.Id_Provincias.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Id_Provincias.Text));
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@ProvinciasProvincias", string.IsNullOrEmpty(this.ProvinciaText.Text) ? (object)DBNull.Value : this.ProvinciaText.Text);
                    NuevaConexion.ComandoSql.ExecuteNonQuery();
                    NuevaConexion.ComandoSql.Parameters.Clear();
                    Validate();
                    this.DtProvinciasBindinsource.EndEdit();
                    this.dataGridProvincias.EndEdit();
                    MessageBox.Show("Se Guardo Correctamente", "GUARDAR PROVINCIA ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetosProvi();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "PROVINCIAS");
            }
            finally
            {
                if (NuevaConexion.CerrarConexionSql)
                {

                }
            }
        }
        private void EliminarProvinciaBb()
        {
            if (File.Exists(ClasDatos.RutaBaseDatosDb))
            {
                string consulta = "Delete from  [DtProvincias]   WHERE Id= '@Id'";
                ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
                try
                {
                    {
                        if (NuevaConexion.SiConexionDb)
                        {
                            NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", this.Id_Provincias.Text);
                            NuevaConexion.ComandoDb.ExecuteNonQuery();
                            this.dataGridProvincias.Rows.RemoveAt(this.dataGridProvincias.CurrentCell.RowIndex);
                            this.DtProvinciasBindinsource.EndEdit();
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
        private void EliminarProvinciaSql()
        {

            string consulta = "Delete from  [DtProvincias]   WHERE Id= '@Id'";
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                {
                    if (NuevaConexion.SiConexionSql)
                    {
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", this.Id_Provincias.Text);
                        NuevaConexion.ComandoSql.ExecuteNonQuery();
                        this.dataGridProvincias.Rows.RemoveAt(this.dataGridProvincias.CurrentCell.RowIndex);
                        this.dtPaisesBindingSource.EndEdit();
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
        private void BtnNuevoProvincia_Click(object sender, EventArgs e)
        {
            this.PanelBotones_Provincia.Tag = "Nuevo";
            try
            {
                int numeroFILA = this.dataGridProvincias.Rows.Count;
                this.DtProvinciasBindinsource.AddNew();
                if (this.dataGridProvincias.CurrentCell.RowIndex == 0)
                {
                    this.Id_Provincias.Text = "1";
                    this.dataGridProvincias.Rows[0].Cells[0].Value = "1";
                }
                if (numeroFILA > 0)
                {
                    if (this.dataGridProvincias.Rows[numeroFILA - 1].Cells[0].Value.ToString() == string.Empty)
                    {
                        Random r = new Random();
                        int VALORid = r.Next(5000, 100000000);
                        this.dataGridProvincias.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.Id_Provincias.Text = VALORid.ToString();
                    }
                    else
                    {
                        int VALORid = Convert.ToInt32(this.dataGridProvincias.Rows[numeroFILA - 1].Cells[0].Value) + 1;
                        this.dataGridProvincias.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.Id_Provincias.Text = VALORid.ToString();
                    }

                }

                ModificarOjetosProvi();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnModificarProvincia_Click(object sender, EventArgs e)
        {
            if (dtPaisesBindingSource.Count > 0)
            {
                this.PanelBotones_Provincia.Tag = "Modificar";
                ModificarOjetosProvi();
            }
        }

        private void BtnGuardarProvincia_Click(object sender, EventArgs e)
        {
            if (this.dtPaisesBindingSource.Count <= 0)
            {
                MessageBox.Show("Debe al Menos Crear Un Pais", "PAIS");
                return;
            }
            if (Id_Provincias.Text == string.Empty)
            {
                MessageBox.Show("Falta (( id ))) o  ((Datos))", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (EspacioDiscosProvincia(ClasDatos.RutaMultidatos, 25))

                BorrarErrorProvi();
            if (ValidarProvi())
            {
                {
                    try
                    {
                        foreach (DataGridViewRow fila in this.dataGridProvincias.Rows)
                        {
                            if (fila.Cells[1].ToString() == this.ProvinciaText.Text)
                            {
                                if (this.dataGridProvincias.CurrentCell.RowIndex == fila.Index)
                                {
                                    break;
                                }
                                MessageBox.Show(this.ProvinciaText.Text.ToString(), "YA EXISTE ESTA PROVINCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.ProvinciaText.Focus();
                                this.ProvinciaText.SelectAll();
                                return;
                            }

                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    if (MessageBox.Show(" ¿Aceptar Guardar Proveedor ? ", " GUARDAR PROVEEDOR ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (ClsConexionSql.SibaseDatosSql)
                        {
                            GuardarProvinciaSql();
                        }
                        else
                        {

                            if (File.Exists(ClasDatos.RutaBaseDatosDb))
                            {
                                GuardarProvinciaDb();
                            }
                            else
                            {
                                MessageBox.Show("Archivo No Se Encuentra", " FALLO AL GUARDAR ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                this.PanelBotones_Provincia.Enabled = false;
                            }
                        }
                    }
                }
            }
        }

        private void BtnSalir_Provincias_Click(object sender, EventArgs e)
        {
            if (this.BtnGuardarProvincia.Enabled == true)
            {
                if (MessageBox.Show(" Salir Provincias  ", " SALIR ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

        private void FormProvincias_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.BtnGuardarProvincia.Enabled == true)
            {
                e.Cancel = true;
            }
        }

        private void BtnCancelarProvincia_Click(object sender, EventArgs e)
        {
            BorrarErrorProvi();
            if (this.dataGridProvincias.RowCount >= 0)
            {
                try
                {
                    if (this.PanelBotones_Provincia.Tag.ToString() == "Nuevo")
                    {
                        if (this.dataGridProvincias.RowCount > 0)
                        {
                            this.dataGridProvincias.Rows.RemoveAt(this.dataGridProvincias.CurrentCell.RowIndex);
                        }
                    }
                }
                catch (Exception)
                {

                    //  throw;
                }

            }
            RestaurarOjetosProvi();
        }

        private void BtnEliminarProvincia_Click(object sender, EventArgs e)
        {
            if (this.dataGridProvincias.RowCount >= 0)
            {
                if (MessageBox.Show("Desea Eliminar Permanentemente ", "ELIMINAR ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    if (ClsConexionSql.SibaseDatosSql)
                    {
                        EliminarProvinciaSql();
                    }
                    else
                    {
                        if (File.Exists(ClasDatos.RutaBaseDatosDb))
                        {
                            EliminarProvinciaBb();

                        }
                        else
                        {
                            MessageBox.Show(" No Se Pudo Eliminar", "FALTA ARCHIVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
    }
}
