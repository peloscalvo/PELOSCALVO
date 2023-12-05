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
    public partial class FormAlmacenes : Form
    {
        public FormAlmacenes()
        {
            InitializeComponent();
        }
        private void FormAlmacenes_Load(object sender, EventArgs e)
        {
            try
            {
                if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION != null)
                {
                    this.dtConfiguracionPrincipalBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION;
                }

                if (FormMenuPrincipal.menu2principal.dsMultidatos != null)
                {
                    this.dtInicioMultiBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMultidatos;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void ModificarOjetos_Alm()
        {
            this.almacenesTextBox.ReadOnly = false;
            this.BtnGuardarAlmacen.Enabled = true;
            this.BtnCancelarAlmacen.Enabled = true;
            this.dataGridAlmacenes.Enabled = false;
        }
        private void RestaurarOjetos_Alm()
        {
            this.almacenesTextBox.ReadOnly = true;
            this.BtnGuardarAlmacen.Enabled = false;
            this.BtnCancelarAlmacen.Enabled = false;
            this.dataGridAlmacenes.Enabled = true;
        }
        private bool EspacioDiscosAlmacen(string nombreDisco, int Espacio)
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
        private bool ValidarAlmacen()
        {
            bool ok = true;

            if (this.almacenesTextBox.Text.Length < 4)
            {
                ok = false;
                this.errorProvider1Confi.SetError(this.almacenesTextBox, "_ingresar Nonbre Proveedor valido (( minimo 4 Caracteres))");
            }


            return ok;
        }
        private void BorrarErrorAlmacen()
        {
            this.errorProvider1Confi.SetError(this.almacenesTextBox, "");

        }
        private void EliminarAlmacenBb()
        {
            if (File.Exists(ClasDatos.RutaBaseDatosDb))
            {
                try
                {

                    string consulta = "Delete from  [DtAlmacenes]   WHERE Id_almacenes= @Id_almacenes";
                    //  ClsConexionDb.CadenaConexion = cadena;
                    ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
                    {
                        if (NuevaConexion.SiConexionDb)
                        {
                            NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id_almacenes", this.id_almacenes.Text);
                            NuevaConexion.ComandoDb.ExecuteNonQuery();
                            this.dataGridAlmacenes.Rows.RemoveAt(this.dataGridAlmacenes.CurrentCell.RowIndex);
                            this.dtAlmacenesBindingSource.EndEdit();
                            Validate();
                            MessageBox.Show("Se Elimino Correctamente", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
            else
            {
                MessageBox.Show("El Archivo No Se Encuentra", "ARCHIVO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
        }
        private void GuardarAlmacenesDb()
        {
            string consulta = "";
            if (this.panelAlmacenes.Tag.ToString() == "Nuevo")
            {
                consulta = "  INSERT INTO [DtAlmacenes]([Id_almacenes],[Almacenes],[Enlace_Almacenes]) VALUES( @Id_almacenes,@Almacenes,@Enlace_Almacenes)";

            }
            else
            {
                consulta = "UPDATE [DtAlmacenes] SET [Id_almacenes] = @Id_almacenes,[Almacenes] = @Almacenes, [Enlace_Almacenes] = @Enlace_Almacenes, " +
                " WHERE Id_almacenes = @Id_almacenes";
            }
            ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
            try
            {
                if (NuevaConexion.SiConexionDb)
                {
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id_almacenes", string.IsNullOrEmpty(this.id_almacenes.Text) ? (object)DBNull.Value : Convert.ToInt32(this.id_almacenes.Text));
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Almacenes", string.IsNullOrEmpty(this.almacenesTextBox.Text) ? (object)DBNull.Value : this.almacenesTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Enlace_Almacenes", string.IsNullOrEmpty(this.Enlace_almacen.Text) ? (object)DBNull.Value : this.Enlace_almacen.Text);
                    NuevaConexion.ComandoDb.ExecuteNonQuery();
                    NuevaConexion.ComandoDb.Parameters.Clear();
                    Validate();
                    this.dtAlmacenesBindingSource.EndEdit();
                    this.dataGridAlmacenes.EndEdit();
                    MessageBox.Show("Se Guardo Correctamente", "GUARDAR ALMACEN ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetos_Alm();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ALMACNEN");
            }
            finally
            {
                if (NuevaConexion.CerrarConexionDB)
                {

                }
            }
        }
        private void GuardarAlmacenesSql()
        {
            string consulta = "";
            if (this.panelAlmacenes.Tag.ToString() == "Nuevo")
            {
                consulta = "  INSERT INTO [DtAlmacenes]([@Id_almacenes],[@Almacenes],[@Enlace_Almacenes])";

            }
            else
            {
                consulta = "UPDATE [DtAlmacenes] SET [Id_almacenes] = @Id_almacenes,[Almacenes] = @Almacenes, [Enlace_Almacenes] = @Enlace_Almacenes, " +
                " WHERE Id_almacenes = @Id_almacenes";
            }
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                if (NuevaConexion.SiConexionSql)
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id_almacenes", string.IsNullOrEmpty(this.id_almacenes.Text) ? (object)DBNull.Value : Convert.ToInt32(this.id_almacenes.Text));
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Almacenes", string.IsNullOrEmpty(this.almacenesTextBox.Text) ? (object)DBNull.Value : this.almacenesTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Enlace_Almacenes", string.IsNullOrEmpty(this.Enlace_almacen.Text) ? (object)DBNull.Value : this.Enlace_almacen.Text);
                    NuevaConexion.ComandoSql.ExecuteNonQuery();
                    NuevaConexion.ComandoSql.Parameters.Clear();
                    Validate();
                    this.dtAlmacenesBindingSource.EndEdit();
                    this.dataGridAlmacenes.EndEdit();
                    MessageBox.Show("Se Guardo Correctamente", "GUARDAR ALMACEN ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetos_Alm();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ALMACNEN");
            }
            finally
            {
                if (NuevaConexion.CerrarConexionSql)
                {

                }
            }
        }
        private void EliminarAlmacenSQL()
        {
            string consulta = "Delete from  [DtAlmacenes]   WHERE Id_almacenes= @Id_almacenes";
            //  ClsConexionDb.CadenaConexion = cadena;
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                {
                    if (NuevaConexion.SiConexionSql)
                    {
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id_almacenes", this.id_almacenes.Text);
                        NuevaConexion.ComandoSql.ExecuteNonQuery();
                        this.dataGridAlmacenes.Rows.RemoveAt(this.dataGridAlmacenes.CurrentCell.RowIndex);
                        this.dtAlmacenesBindingSource.EndEdit();
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
        private void BtnNuevoAlmacen_Click(object sender, EventArgs e)
        {
            this.panelAlmacenes.Tag = "Nuevo";
            try
            {
                int numeroFILA = this.dataGridAlmacenes.Rows.Count;
                this.dtAlmacenesBindingSource.AddNew();
                if (this.dataGridAlmacenes.CurrentCell.RowIndex == 0)
                {
                    this.id_almacenes.Text = "1";
                    this.dataGridAlmacenes.Rows[0].Cells[0].Value = "1";
                }
                if (numeroFILA > 0)
                {
                    if (this.dataGridAlmacenes.Rows[numeroFILA - 1].Cells[0].Value.ToString() == string.Empty)
                    {
                        Random r = new Random();
                        int VALORid = r.Next(5000, 100000000);
                        this.dataGridAlmacenes.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.id_almacenes.Text = VALORid.ToString();
                    }
                    else
                    {
                        int VALORid = Convert.ToInt32(this.dataGridAlmacenes.Rows[numeroFILA - 1].Cells[0].Value) + 1;
                        this.dataGridAlmacenes.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.id_almacenes.Text = VALORid.ToString();
                    }
                  
                }
                almacenesTextBox.Text = "Almacen Central";
                almacenesTextBox.Focus();
                almacenesTextBox.SelectAll();
                ModificarOjetos_Alm();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEliminarAlmacen_Click(object sender, EventArgs e)
        {
            if (this.dataGridAlmacenes.RowCount >= 0)
            {
                if (MessageBox.Show("Desea Eliminar Permanentemente ", "ELIMINAR ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (ClsConexionSql.SibaseDatosSql)
                    {
                        EliminarAlmacenSQL();
                    }
                    else
                    {
                        if (File.Exists(ClasDatos.RutaBaseDatosDb))
                        {
                            EliminarAlmacenBb();

                        }
                        else
                        {
                            MessageBox.Show(" No Se Pudo Eliminar", "FALTA ARCHIVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void BtnGuardarAlmacen_Click(object sender, EventArgs e)
        {
            if (this.dtConfiguracionPrincipalBindingSource.Count <= 0)
            {
                MessageBox.Show("Debe al Menos Crear Una Empresa", "EMPRESA");
                return;
            }
            if (id_almacenes.Text == string.Empty & Enlace_almacen.Text == string.Empty)
            {
                MessageBox.Show("Falta (( id ))) o  ((Datos))", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (EspacioDiscosAlmacen(ClasDatos.RutaMultidatos, 25))

                BorrarErrorAlmacen();
            if (ValidarAlmacen())
            {
                {
                    try
                    {
                        foreach (DataGridViewRow fila in this.dataGridAlmacenes.Rows)
                        {
                            if (fila.Cells[1].ToString() == this.almacenesTextBox.Text)
                            {
                                if (this.dataGridAlmacenes.CurrentCell.RowIndex == fila.Index)
                                {
                                    break;
                                }
                                MessageBox.Show(this.almacenesTextBox.Text.ToString(), "YA EXISTE ESTA ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.almacenesTextBox.Focus();
                                this.almacenesTextBox.SelectAll();
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
                            GuardarAlmacenesDb();
                        }
                        else
                        {

                            if (File.Exists(ClasDatos.RutaBaseDatosDb))
                            {
                                GuardarAlmacenesSql();
                            }
                            else
                            {
                                MessageBox.Show("Archivo No Se Encuentra", " FALLO AL GUARDAR ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                this.panelAlmacenes.Enabled = false;
                            }
                        }
                    }
                }
            }
        }

        private void BtnCancelarAlmacen_Click(object sender, EventArgs e)
        {
            BorrarErrorAlmacen();
            if (this.dataGridAlmacenes.RowCount >= 0)
            {
                try
                {
                    if (this.panelAlmacenes.Tag.ToString() == "Nuevo")
                    {
                        if (this.dataGridAlmacenes.RowCount > 0)
                        {
                            this.dataGridAlmacenes.Rows.RemoveAt(this.dataGridAlmacenes.CurrentCell.RowIndex);
                        }
                    }
                }
                catch (Exception)
                {

                    //  throw;
                }
             
            }
            RestaurarOjetos_Alm();
        }

        private void BtnModificarAlmacen_Click(object sender, EventArgs e)
        {
            this.panelAlmacenes.Tag = "Nuevo";
            ModificarOjetos_Alm();
        }

        private void BtnSalirAlmacen_Click(object sender, EventArgs e)
        {
            if (BtnGuardarAlmacen.Enabled == false)
            {
                if (MessageBox.Show(" ¿Salir Almacenes ? ", " SALIR ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

        private void FormAlmacenes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.BtnGuardarAlmacen.Enabled == true)
            {
                e.Cancel = true;
            }
        }

        private void BtnBuscarAlmacen_Click(object sender, EventArgs e)
        {

        }
    }
}
