using Conexiones;
using System;
using System.IO;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormProveedores : Form
    {
        public static FormProveedores MenuB;
        public FormProveedores()
        {
            InitializeComponent();
            FormProveedores.MenuB = this;
        }
        private void FormProveedores_Load(object sender, EventArgs e)
        {
            try
            {
                if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION != null)
                {
                    this.dtConfiguracionPrincipalBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION;

                   // this.DtProveedoresBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtProveedores;
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
        private bool EspacioDiscosConfi(string nombreDisco, int Espacio)
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
        public void AñadirIdProveedor()
        {
            int ii = 0;
            foreach (var fila in FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtProveedores)
            {
                fila["IdFila"] = ii.ToString();
                ii++;
            }

        }
        private bool ValidarProveedor()
        {
            bool ok = true;

            if (this.NombreProveedor.Text.Length < 2)
            {
                ok = false;
                this.ErrorProve.SetError(this.NombreProveedor, "_ingresar Nonbre Proveedor valido (( minimo 2 Caracteres))");
            }


            return ok;
        }
        private void BorrarErrorProveedor()
        {
            this.ErrorProve.SetError(this.NombreProveedor, "");

        }
        private void ModificarOjetosProv()
        {
            this.NombreProveedor.ReadOnly = false;
            this.PanelBotones_pro.Enabled = false;
            this.BtnCancelarProve.Enabled = true;
            this.BtnGuardarProve.Enabled = true;
            this.dataGridProveedores.Enabled = false;
            EmpresaSelect.Enabled = false;
        }
        private void RestaurarOjetosProv()
        {
            this.dataGridProveedores.Enabled = true;
            this.NombreProveedor.ReadOnly = true;
            this.PanelBotones_pro.Enabled = true;
            this.BtnCancelarProve.Enabled = false;
            this.BtnGuardarProve.Enabled = false;
            EmpresaSelect.Enabled = true;
        }
        private void GuardarProveedoresDb()
        {
            string consulta = "";
            if (this.PanelBotones_pro.Tag.ToString() == "Nuevo")
            {
                consulta = "  INSERT INTO [DtProveedores] ([Id],[Proveedores],[Enlace_Proveedores]) VALUES( @Id,@Proveedores,@Enlace_Proveedores)";

            }
            else
            {
                consulta = "UPDATE [DtProveedores] SET [Id] = @Id,[Proveedores] = @Proveedores, [Enlace_Proveedores] = @Enlace_Proveedores, " +
                " WHERE Id = @Id";
            }
            ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
            try
            {
                if (NuevaConexion.SiConexionDb)
                {
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", string.IsNullOrEmpty(this.Id_proveedor.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Id_proveedor.Text));
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Proveedores", string.IsNullOrEmpty(this.EmpresaSelect.Text) ? (object)DBNull.Value : this.NombreProveedor.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Enlace_Proveedores", string.IsNullOrEmpty(this.Enlace_Proveedor.Text) ? (object)DBNull.Value : this.Enlace_Proveedor.Text);
                    NuevaConexion.ComandoDb.ExecuteNonQuery();
                    NuevaConexion.ComandoDb.Parameters.Clear();
                   // this.dataGridProveedores.EndEdit();
                    this.DtProveedoresBindingSource.EndEdit();
                    Validate();
                    MessageBox.Show("Se Guardo Correctamente", "GUARDAR PROVEEDOR ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetosProv();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "PROVEEDORES");
            }
            finally
            {
                if (NuevaConexion.CerrarConexionDB)
                {

                }
            }
        }
        private void GuardarProveedoresSql()
        {
            string consulta = "";
            if (this.PanelBotones_pro.Tag.ToString() == "Nuevo")
            {
                consulta = "  INSERT INTO [DtProveedores] VALUES([@Id],[@Proveedores],[@Enlace_Proveedores])";

            }
            else
            {
                consulta = "UPDATE [DtProveedores] SET [Id] = @Id,[Proveedores] = @Proveedores, [Enlace_Proveedores] = @Enlace_Proveedores, " +
                " WHERE Id = @Id";
            }
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                if (NuevaConexion.SiConexionSql)
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", string.IsNullOrEmpty(this.Id_proveedor.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Id_proveedor.Text));
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Proveedores", string.IsNullOrEmpty(this.NombreProveedor.Text) ? (object)DBNull.Value : this.NombreProveedor.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Enlace_Proveedores", string.IsNullOrEmpty(this.Enlace_Proveedor.Text) ? (object)DBNull.Value : this.Enlace_Proveedor.Text);
                    NuevaConexion.ComandoSql.ExecuteNonQuery();
                    NuevaConexion.ComandoSql.Parameters.Clear();
                    this.DtProveedoresBindingSource.EndEdit();
                   // this.dataGridProveedores.EndEdit();
                    Validate();
                    MessageBox.Show("Se Guardo Correctamente", "GUARDAR PROVEEDOR ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetosProv();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "PROVEEDORES");
            }
            finally
            {
                if (NuevaConexion.CerrarConexionSql)
                {

                }
            }
        }
        private void EliminarProveedorBb()
        {
            if (File.Exists(ClasDatos.RutaBaseDatosDb))
            {
                string consulta = "Delete from  [DtProveedores]   WHERE Id= @Id and Enlace_Proveedores= @Enlace_Proveedores";
                ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
                try
                {
                    {
                        if (NuevaConexion.SiConexionDb)
                        {
                            NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", Convert.ToInt32(this.Id_proveedor.Text));
                            NuevaConexion.ComandoDb.Parameters.AddWithValue("@Enlace_Proveedores", Convert.ToInt32(this.Enlace_Proveedor.Text));
                            NuevaConexion.ComandoDb.ExecuteNonQuery();
                            this.dataGridProveedores.Rows.RemoveAt(this.dataGridProveedores.CurrentCell.RowIndex);
                            this.DtProveedoresBindingSource.EndEdit();
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
        private void EliminarProveedorSql()
        {

            string consulta = "Delete from  [DtProveedores]   WHERE Id= @Id and Enlace_Proveedores= @Enlace_Proveedores";
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                {
                    if (NuevaConexion.SiConexionSql)
                    {
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", Convert.ToInt32(this.Id_proveedor.Text));
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@Enlace_Proveedores", Convert.ToInt32(this.Enlace_Proveedor.Text));
                        NuevaConexion.ComandoSql.ExecuteNonQuery();
                        this.dataGridProveedores.Rows.RemoveAt(this.dataGridProveedores.CurrentCell.RowIndex);
                        this.DtProveedoresBindingSource.EndEdit();
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

        private void BtnNuevoProveedor_Click(object sender, EventArgs e)
        {
            if (this.dtConfiguracionPrincipalBindingSource.Count <= 0)
            {
                MessageBox.Show("Debe al Menos Crear Una Empresa", "EMPRESA");
                return;
            }

            this.PanelBotones_pro.Tag = "Nuevo";
            try
            {
                int numeroFILA = this.dataGridProveedores.Rows.Count;
                this.DtProveedoresBindingSource.AddNew();
                if (DtProveedoresBindingSource.Count <= 1)
                {
                    this.Id_proveedor.Text = "1";
                    this.dataGridProveedores.Rows[0].Cells[0].Value = "1";
                }
                if (numeroFILA > 0)
                {
                    if (this.dataGridProveedores.Rows[numeroFILA - 1].Cells[0].Value.ToString() == string.Empty)
                    {
                        Random r = new Random();
                        int VALORid = r.Next(5000, 100000000);
                        this.dataGridProveedores.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.Id_proveedor.Text = VALORid.ToString();
                    }
                    else
                    {
                        int VALORid = Convert.ToInt32(this.dataGridProveedores.Rows[numeroFILA - 1].Cells[0].Value) + 1;
                        this.dataGridProveedores.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.Id_proveedor.Text = VALORid.ToString();
                    }

                }

                ModificarOjetosProv();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnGuardarProve_Click(object sender, EventArgs e)
        {
            if (this.dtConfiguracionPrincipalBindingSource.Count <= 0)
            {
                MessageBox.Show("Debe al Menos Crear Una Empresa", "EMPRESA");
                return;
            }
            if (this.Id_proveedor.Text == string.Empty & this.Enlace_Proveedor.Text == string.Empty)
            {
                MessageBox.Show("Falta (( id ))) o  ((Datos))", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (EspacioDiscosConfi(Directory.GetCurrentDirectory(), 25))
            {
                BorrarErrorProveedor();
                if (ValidarProveedor())
                {
                    try
                    {
                        foreach (DataGridViewRow fila in this.dataGridProveedores.Rows)
                        {
                            if (fila.Cells[1].Value.ToString() == this.NombreProveedor.Text)
                            {
                                if (this.dataGridProveedores.CurrentCell.RowIndex == fila.Index)
                                {
                                    break;
                                }
                                MessageBox.Show(this.NombreProveedor.Text.ToString(), "YA EXISTE ESTA PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.NombreProveedor.Focus();
                                this.NombreProveedor.SelectAll();
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
                            GuardarProveedoresSql();
                        }
                        else
                        {

                            if (File.Exists(ClasDatos.RutaBaseDatosDb))
                            {
                                GuardarProveedoresDb();
                            }
                            else
                            {
                                MessageBox.Show("Archivo No Se Encuentra", " FALLO AL GUARDAR ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                this.PanelBotones_pro.Enabled = false;
                            }
                        }
                    }

                }
            }
        }

        private void BtnModificarProveedor_Click(object sender, EventArgs e)
        {
            if (this.DtProveedoresBindingSource.Count > 0)
            {
                this.PanelBotones_pro.Tag = "Modificar";
                ModificarOjetosProv();
            }

        }

        private void BtnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (this.DtProveedoresBindingSource.Count > 0)
            {
                if(string.IsNullOrEmpty(Id_proveedor.Text))
                {
                    MessageBox.Show(" Falta Id", "ERROR DATOS",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(Enlace_Proveedor.Text))
                {
                    MessageBox.Show(" Falta Datos", "ERROR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Desea Eliminar Permanentemente ", "ELIMINAR ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    if (ClsConexionSql.SibaseDatosSql)
                    {
                        EliminarProveedorSql();
                    }
                    else
                    {
                        if (File.Exists(ClasDatos.RutaBaseDatosDb))
                        {
                            EliminarProveedorBb();

                        }
                        else
                        {
                            MessageBox.Show(" No Se Pudo Eliminar", "FALTA ARCHIVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void FormProveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.BtnGuardarProve.Enabled == true)
            {
                e.Cancel = true;
            }
        }

        private void BtnCancelarProve_Click(object sender, EventArgs e)
        {
            BorrarErrorProveedor();
            if (this.DtProveedoresBindingSource.Count > 0)
            {
                try
                {
                    if (this.PanelBotones_pro.Tag.ToString() == "Nuevo")
                    {
                        if (this.dataGridProveedores.RowCount >= 0)
                        {
                            this.dataGridProveedores.Rows.RemoveAt(this.dataGridProveedores.CurrentCell.RowIndex);
                        }
                    }
                }
                catch (Exception)
                {

                    //  throw;
                }

            }
            RestaurarOjetosProv();
        }

        private void BtnSalir_pro_Click(object sender, EventArgs e)
        {
            if (this.BtnGuardarProve.Enabled == false)
            {


                if (MessageBox.Show(" ¿Salir Proveedores ? ", " SALIR ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

        private void BtnBuscarProveedor_Click(object sender, EventArgs e)
        {
            if (DtProveedoresBindingSource.Count > 0)
            {
                int Id2 = EmpresaSelect.SelectedIndex;
                int IdEmpresa3 = 1;
                if (!String.IsNullOrEmpty(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtPaises"].Rows[Id2]["Id"].ToString()))
                {
                    IdEmpresa3 = Convert.ToInt32(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtPaises"].Rows[Id2]["Id"].ToString());
                }
                ClasDatos.OkFacturar = false;
                ClasDatos.QUEform = "Proveedores";
                AñadirIdProveedor();
                FormBuscar frm = new FormBuscar();
                frm.CargarDatos(1, " Proveedores", "Proveedores", "Enlace_Proveedores",IdEmpresa3);
                frm.BringToFront();
                frm.ShowDialog();
            }
        }
    }

}
