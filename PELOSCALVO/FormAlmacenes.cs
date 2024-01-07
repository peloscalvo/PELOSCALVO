using Conexiones;
using System;
using System.IO;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormAlmacenes : Form
    {
        public static FormAlmacenes MenuB;
        public FormAlmacenes()
        {
            InitializeComponent();
            FormAlmacenes.MenuB = this;
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
            this.SelecionarEmpresa2.Enabled = false;
        }
        private void RestaurarOjetos_Alm()
        {
            this.almacenesTextBox.ReadOnly = true;
            this.BtnGuardarAlmacen.Enabled = false;
            this.BtnCancelarAlmacen.Enabled = false;
            this.dataGridAlmacenes.Enabled = true;
            this.SelecionarEmpresa2.Enabled = true;
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

                    string consulta = "Delete from  [DtAlmacenes]   WHERE Id= @Id";
                    //  ClsConexionDb.CadenaConexion = cadena;
                    ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
                    {
                        if (NuevaConexion.SiConexionDb)
                        {
                            NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", Convert.ToInt32(this.id_almacenes.Text));
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
                consulta = "  INSERT INTO [DtAlmacenes]([Id],[Almacenes],[Enlace_Almacenes]) VALUES(@Id,@Almacenes,@Enlace_Almacenes)";

            }
            else
            {
                consulta = "UPDATE [DtAlmacenes] SET [Id] = @Id,[Almacenes] = @Almacenes, [Enlace_Almacenes] = @Enlace_Almacenes, " +
                " WHERE Id = @Id";
            }
            ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
            try
            {
                if (NuevaConexion.SiConexionDb)
                {
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", string.IsNullOrEmpty(this.id_almacenes.Text) ? (object)DBNull.Value : Convert.ToInt32(this.id_almacenes.Text));
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Almacenes", string.IsNullOrEmpty(this.almacenesTextBox.Text) ? (object)DBNull.Value : this.almacenesTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Enlace_Almacenes", string.IsNullOrEmpty(this.IdEmpresaAlm.Text) ? (object)DBNull.Value : this.IdEmpresaAlm.Text);
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
                consulta = "  INSERT INTO [DtAlmacenes] VALUES ([@Id],[@Almacenes],[@Enlace_Almacenes])";

            }
            else
            {
                consulta = "UPDATE [DtAlmacenes] SET [Id] = @Id,[Almacenes] = @Almacenes, [Enlace_Almacenes] = @Enlace_Almacenes, " +
                " WHERE Id = @Id";
            }
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                if (NuevaConexion.SiConexionSql)
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", string.IsNullOrEmpty(this.id_almacenes.Text) ? (object)DBNull.Value : Convert.ToInt32(this.id_almacenes.Text));
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Almacenes", string.IsNullOrEmpty(this.almacenesTextBox.Text) ? (object)DBNull.Value : this.almacenesTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Enlace_Almacenes", string.IsNullOrEmpty(this.IdEmpresaAlm.Text) ? (object)DBNull.Value : this.IdEmpresaAlm.Text);
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
            string consulta = "Delete from  [DtAlmacenes]   WHERE Id= @Id";
            //  ClsConexionDb.CadenaConexion = cadena;
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                {
                    if (NuevaConexion.SiConexionSql)
                    {
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", Convert.ToInt32(this.id_almacenes.Text));
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
                this.almacenesTextBox.Text = "Almacen Central";
                this.almacenesTextBox.Focus();
                this.almacenesTextBox.SelectAll();
                ModificarOjetos_Alm();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEliminarAlmacen_Click(object sender, EventArgs e)
        {
            if (this.dtAlmacenesBindingSource.Count > 0)
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
            if (this.id_almacenes.Text == string.Empty & this.IdEmpresaAlm.Text == string.Empty)
            {
                MessageBox.Show("Falta (( id ))) o  ((Datos))", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (EspacioDiscosAlmacen(Directory.GetCurrentDirectory(), 25))

                BorrarErrorAlmacen();
            if (ValidarAlmacen())
            {
                {
                    try
                    {
                        foreach (DataGridViewRow fila in this.dataGridAlmacenes.Rows)
                        {
                            if (fila.Cells[1].Value.ToString() == this.almacenesTextBox.Text)
                            {
                                if (this.dataGridAlmacenes.CurrentCell.RowIndex == fila.Index)
                                {
                                    break;
                                }
                                MessageBox.Show(this.almacenesTextBox.Text.ToString(), "YA EXISTE ESTE ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (MessageBox.Show(" ¿Aceptar Guardar Almacen ? ", " GUARDAR ALMACENES ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (ClsConexionSql.SibaseDatosSql)
                        {
                            GuardarAlmacenesSql();
                        }
                        else
                        {

                            if (File.Exists(ClasDatos.RutaBaseDatosDb))
                            {
                                GuardarAlmacenesDb();
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
            if (this.BtnGuardarAlmacen.Enabled == false)
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
            if (this.dtAlmacenesBindingSource.Count > 0)
            {
                ClasDatos.QUEform = "Almacen";
                FormBuscar frm = new FormBuscar();
                frm.CargarDatos(1, " Almacenes", "Almacenes");
                frm.BringToFront();
                frm.ShowDialog();
            }
        }
    }
}
