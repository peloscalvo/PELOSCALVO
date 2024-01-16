using Conexiones;
using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormEjercicios : Form
    {
        public FormEjercicios()
        {
            InitializeComponent();
            ToolTip InfoEliminar = new ToolTip();
            InfoEliminar.SetToolTip(this.BtnEliminarEjercicio, "Se Borrara Permanentemente " + "\n" + "(EJERCICIOS DE EMPRESA)" + "\n" + "(FACTURACION)");
            InfoEliminar.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            InfoEliminar.IsBalloon = true;
            ToolTip InfoSalir = new ToolTip();
            InfoSalir.SetToolTip(this.BtnSalirEjerc, "Salir De Ejercicio");
            InfoSalir.IsBalloon = true;
            InfoSalir.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
        }
        private void FormEjercicios_Load(object sender, EventArgs e)
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
        private void BtnVolverBasica_Click(object sender, EventArgs e)
        {

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
        private bool ValidarBasica()
        {
            bool ok = true;
            if (string.IsNullOrEmpty(this.IdConfi.Text))
            {
                ok = false;
                this.ErrorEjercicios.SetError(this.IdConfi, "_ingresar Id valido (( Vacio no Valido))");
            }
            if (this.DescripicionEjer.Text.Length < 4)
            {
                ok = false;
                this.ErrorEjercicios.SetError(this.DescripicionEjer, "_ingresar Descripccion valido (( minimo 4 Caracteres))");
            }
            if (this.EjercicioTxt.Text.Length < 4)
            {
                ok = false;
                this.ErrorEjercicios.SetError(this.EjercicioTxt, "_ingresar Ejercicio valido (( minimo 4 Caracteres))");
            }
            if (string.IsNullOrEmpty(this.IdEmpresa.Text))
            {
                ok = false;
                this.ErrorEjercicios.SetError(this.IdEmpresa, "_ingresar Id Empresa valido (( Vacio no Valido))");
                if (this.AñoTxt.Text.Length < 4)
                {
                    ok = false;
                    this.ErrorEjercicios.SetError(this.AñoTxt, "_ingresar Año valido (( minimo 4 Caracteres))");
                }
            }
            return ok;
        }
        private void BorrarErroresBasica()
        {
            this.ErrorEjercicios.SetError(this.IdConfi, "");
            this.ErrorEjercicios.SetError(this.DescripicionEjer, "");
            this.ErrorEjercicios.SetError(this.EjercicioTxt, "");
            this.ErrorEjercicios.SetError(this.IdEmpresa, "");
            this.ErrorEjercicios.SetError(this.AñoTxt, "");
        }
        private void RestaurarOjetos_Ej()
        {
            this.dtConfiDataGridView.Enabled = true;
            this.BtnGuardarEjercicio.Enabled = false;
            this.BtnCancelarEjercicio.Enabled = false;
            this.EmpresaEjercicioTxt.Enabled = true;
            this.panel1Ejercicio.Enabled = true;
            this.DescripicionEjer.ReadOnly = true;
            this.IvaEjercicioTxt.Enabled = false;
            this.EjercicioTxt.ReadOnly = true;
            this.dtConfiDataGridView.Refresh();
        }
        private void ModificarOjetos_Ej()
        {
            this.EjercicioTxt.ReadOnly = false;
            this.DescripicionEjer.ReadOnly = false;
            this.IvaEjercicioTxt.Enabled = true;
            this.IvaEjercicioTxt.Value = 21;
            this.dtConfiDataGridView.Enabled = false;
            this.BtnGuardarEjercicio.Enabled = true;
            this.BtnCancelarEjercicio.Enabled = true;
            this.EmpresaEjercicioTxt.Enabled = false;
            this.panel1Ejercicio.Enabled = false;
        }
        private void GuardarEjercicioBb()
        {
            string consulta = "";
            if (this.BtnNuevoEjercicio.Tag.ToString() == "Nuevo")
            {
                consulta = "INSERT INTO [DtConfi] ([IdEnlace], [EmpresaENLACE],[ConfiguraccionBasica] ,[TipoInpuestoIVA],[EjerciciosDeAño],[IdConexionConfi]," +
                   "[AñoDeEjercicio]) VALUES(@IdEnlace,@EmpresaENLACE, @ConfiguraccionBasica, @TipoInpuestoIVA, @EjerciciosDeAño, @IdConexionConfi," +
                   "  @AñoDeEjercicio)";
            }
            else
            {
                consulta = "UPDATE [DtConfi] SET [IdEnlace]=[@IdEnlace] ,[EmpresaENLACE] = @EmpresaENLACE, [ConfiguraccionBasica] = @ConfiguraccionBasica, [TipoInpuestoIVA] = @TipoInpuestoIVA, " +
                   " [EjerciciosDeAño] = @EjerciciosDeAño,  [IdConexionConfi] = @IdConexionConfi, " +
                   " [AñoDeEjercicio] = @AñoDeEjercicio  WHERE IdEnlace = @IdEnlace";
            }

            ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
            try
            {
                if (NuevaConexion.SiConexionDb)
                {
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@IdEnlace", string.IsNullOrEmpty(this.IdEnlace.Text) ? (object)DBNull.Value : this.IdEnlace.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@EmpresaENLACE", string.IsNullOrEmpty(this.IdEmpresa.Text) ? (object)DBNull.Value : this.IdEmpresa.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@ConfiguraccionBasica", string.IsNullOrEmpty(this.DescripicionEjer.Text) ? (object)DBNull.Value : this.DescripicionEjer.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@TipoInpuestoIVA", string.IsNullOrEmpty(this.IvaEjercicioTxt.Text) ? (object)DBNull.Value : Convert.ToInt32(this.IvaEjercicioTxt.Text));
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@EjerciciosDeAño", string.IsNullOrEmpty(this.EjercicioTxt.Text) ? (object)DBNull.Value : this.EjercicioTxt.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@IdConexionConfi", string.IsNullOrEmpty(this.IdConfi.Text) ? (object)DBNull.Value : Convert.ToInt32(this.IdConfi.Text));
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@AñoDeEjercicio", string.IsNullOrEmpty(this.AñoTxt.Text) ? (object)DBNull.Value : this.AñoTxt.Text);
                    NuevaConexion.ComandoDb.ExecuteNonQuery();
                    NuevaConexion.ComandoDb.Parameters.Clear();
                    this.dtConfiguracionPrincipalBindingSource.EndEdit();
                    this.dtConfiguracionPrincipalDtConfiBindingSource.EndEdit();
                    this.dtConfiDataGridView.EndEdit();
                    Validate();
                    MessageBox.Show("Se Guardaron Datos con exito", "GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetos_Ej();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (NuevaConexion.CerrarConexionDB)
                {

                }
            }
        }
        private void GuardarEjercicioSql()
        {
            string consulta = "";
            if (this.BtnNuevoEjercicio.Tag.ToString() == "Nuevo")
            {
                consulta = "INSERT INTO [DtConfi] ([IdEnlace], [EmpresaENLACE],[ConfiguraccionBasica] ,[TipoInpuestoIVA],[EjerciciosDeAño],[IdConexionConfi]," +
                   "[AñoDeEjercicio]) VALUES(@IdEnlace ,@EmpresaENLACE, @ConfiguraccionBasica, @TipoInpuestoIVA, @EjerciciosDeAño, @IdConexionConfi," +
                   "  @AñoDeEjercicio)";
            }
            else
            {
                consulta = "UPDATE [DtConfi] SET [IdEnlace]=[@IdEnlace] ,[EmpresaENLACE] = @EmpresaENLACE, [ConfiguraccionBasica] = @ConfiguraccionBasica, [TipoInpuestoIVA] = @TipoInpuestoIVA, " +
                   " [EjerciciosDeAño] = @EjerciciosDeAño,  [IdConexionConfi] = @IdConexionConfi, " +
                   " [AñoDeEjercicio] = @AñoDeEjercicio  WHERE IdEnlace = @IdEnlace";
            }

            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                if (NuevaConexion.SiConexionSql)
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@IdEnlace", string.IsNullOrEmpty(this.IdEnlace.Text) ? (object)DBNull.Value : this.IdEnlace.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@EmpresaENLACE", string.IsNullOrEmpty(this.IdEmpresa.Text) ? (object)DBNull.Value : this.IdEmpresa.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@ConfiguraccionBasica", string.IsNullOrEmpty(this.DescripicionEjer.Text) ? (object)DBNull.Value : this.DescripicionEjer.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@TipoInpuestoIVA", string.IsNullOrEmpty(this.IvaEjercicioTxt.Text) ? (object)DBNull.Value : Convert.ToInt32(this.IvaEjercicioTxt.Text));
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@EjerciciosDeAño", string.IsNullOrEmpty(this.EjercicioTxt.Text) ? (object)DBNull.Value : this.EjercicioTxt.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@IdConexionConfi", string.IsNullOrEmpty(this.IdConfi.Text) ? (object)DBNull.Value : Convert.ToInt32(this.IdConfi.Text));
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@AñoDeEjercicio", string.IsNullOrEmpty(this.AñoTxt.Text) ? (object)DBNull.Value : this.AñoTxt.Text);
                    NuevaConexion.ComandoSql.ExecuteNonQuery();
                    NuevaConexion.ComandoSql.Parameters.Clear();
                    this.dtConfiguracionPrincipalBindingSource.EndEdit();
                    this.dtConfiguracionPrincipalDtConfiBindingSource.EndEdit();
                    this.dtConfiDataGridView.EndEdit();
                    Validate();
                    MessageBox.Show("Se Guardaron Datos con exito", "GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetos_Ej();
                }
     
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (NuevaConexion.CerrarConexionSql)
                {

                }
            }
        }
        private void EliminarEjercicioSql()
        {
            string consulta = "Delete from  [DtConfi]   WHERE IdEnlace= @IdEnlace";
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                {
                    if (NuevaConexion.SiConexionSql)
                    {
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@IdEnlace", Convert.ToInt32(this.IdEnlace.Text));
                        NuevaConexion.ComandoSql.ExecuteNonQuery();
                        this.dtConfiDataGridView.Rows.RemoveAt(this.dtConfiDataGridView.CurrentCell.RowIndex);
                        this.dtConfiguracionPrincipalDtConfiBindingSource.EndEdit();
                        Validate();
                        MessageBox.Show("Se Elimino Correctamente", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (NuevaConexion.CerrarConexionSql)
                {

                }
            }

        }
        private void EliminarEjercicioBb()
        {
            string consulta = "Delete from  [DtConfi]   WHERE IdEnlace= @IdEnlace";
            ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
            try
            {
                {
                    if (NuevaConexion.SiConexionDb)
                    {
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@IdEnlace", Convert.ToInt32(this.IdEnlace.Text));
                        NuevaConexion.ComandoDb.ExecuteNonQuery();
                        this.dtConfiDataGridView.Rows.RemoveAt(this.dtConfiDataGridView.CurrentCell.RowIndex);
                        this.dtConfiguracionPrincipalDtConfiBindingSource.EndEdit();
                        Validate();
                        MessageBox.Show("Se Elimino Correctamente", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (NuevaConexion.CerrarConexionDB)
                {

                }
            }

        }
        private void SiEjercicio()
        {
            int i = 0;
            foreach (DataGridViewRow fila in this.dtConfiDataGridView.Rows)
            {
                if (fila.Cells[2].Value != null)
                {
                    if (fila.Cells[2].Value.ToString() == this.EjercicioTxt.Text)
                    {
                        if (i == this.dtConfiDataGridView.CurrentCell.RowIndex)
                        {
                            goto seguir2;
                        }
                        Random r = new Random();
                        int VALORid = r.Next(5, 100);
                        this.EjercicioTxt.Text = this.EjercicioTxt.Text + "_" + VALORid.ToString();
                    }
                }
                seguir2:
                if (i == this.dtConfiDataGridView.Rows.Count)
                {
                    break;
                }
                i++;
            }
        }
        private void BtnNuevoEjercicio_Click(object sender, EventArgs e)
        {
            try
            {
                int Id_Enlace;
                this.BtnNuevoEjercicio.Tag = "Nuevo";
                if (this.dtConfiguracionPrincipalBindingSource.Count <= 0)
                {
                    MessageBox.Show("Debe al Menos Crear Una Empresa", "EMPRESA");
                    return;
                }
                // SqlDataReader reader;


   
                Random r = new Random();
                int VALORid = r.Next(500, 1000000);
                int numeroFILA = this.dtConfiDataGridView.Rows.Count;
                this.dtConfiDataGridView.Sort(this.dtConfiDataGridView.Columns[0], ListSortDirection.Ascending);
                this.dtConfiguracionPrincipalDtConfiBindingSource.AddNew();
                if (this.dtConfiDataGridView.CurrentCell.RowIndex == 0)
                {
                    this.IdConfi.Text = "1";
                    this.dtConfiDataGridView.Rows[0].Cells[0].Value = "1";
                }
                if (numeroFILA > 0)
                {
                    if (this.dtConfiDataGridView.Rows[numeroFILA - 1].Cells[0].Value.ToString() == string.Empty)
                    {

                        this.dtConfiDataGridView.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.IdConfi.Text = VALORid.ToString();
                    }
                    else
                    {
                        VALORid = Convert.ToInt32(this.dtConfiDataGridView.Rows[numeroFILA - 1].Cells[0].Value) + 1;
                        this.dtConfiDataGridView.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.IdConfi.Text = VALORid.ToString();
                    }

                }

                string fecha = String.Format("{0:yyyy}", DateTime.Now);
                if (fecha == this.dtConfiDataGridView.Rows[numeroFILA].Cells[3].Value.ToString())

                {
                    int sumarFecha1 = Convert.ToInt32(DateTime.Now.Year.ToString());
                    fecha = Convert.ToString(sumarFecha1 + 1);
                    this.AñoTxt.Text = Convert.ToString(fecha);
                    this.EjercicioTxt.Text = " EJERCICIO " + fecha;
                }
                else
                {
                    this.EjercicioTxt.Text = " EJERCICIO " + String.Format("{0:yyyy}", DateTime.Now);
                    this.AñoTxt.Text = String.Format("{0:yyyy}", DateTime.Now);
                }
                this.DescripicionEjer.Text = "Mi Configurarcion Nueva " + this.AñoTxt.Text;
                if (dtConfiguracionPrincipalDtConfiBindingSource.Count > 1)
                {
                    string consulta = "Select max(IdEnlace) from [DtConfi]";
                    if (ClsConexionSql.SibaseDatosSql)
                    {
                        ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
                        if (NuevaConexion.SiConexionSql)
                        {
                            SqlDataReader reader = NuevaConexion.ComandoSql.ExecuteReader();

                            if (reader.Read())
                            {
                                if (!string.IsNullOrEmpty((reader[0]).ToString()))
                                {

                                    Id_Enlace = Convert.ToInt32(reader[0].ToString());
                                    IdEnlace.Text = Convert.ToString(Id_Enlace + 1);
                                }
                                else
                                {

                                    MessageBox.Show("Falta Id Conexion", "ERROR CONFI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                    }
                    else
                    {
                        ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
                        if (NuevaConexion.SiConexionDb)
                        {
                            OleDbDataReader reader = NuevaConexion.ComandoDb.ExecuteReader();

                            if (reader.Read())
                            {
                                if (!string.IsNullOrEmpty((reader[0]).ToString()))
                                {
                                    Id_Enlace = Convert.ToInt32(reader[0].ToString());
                                    IdEnlace.Text = Convert.ToString(Id_Enlace + 1);
                                }
                                else
                                {
                                    MessageBox.Show("Falta Id Conexion", "ERROR CONFI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                    }
                }
                else
                {
                    IdEnlace.Text = "1";
                }
                SiEjercicio();
                ModificarOjetos_Ej();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnModificarEjercicio_Click(object sender, EventArgs e)
        {
            this.BtnNuevoEjercicio.Tag = "Actualizar";
            if (this.dtConfiguracionPrincipalDtConfiBindingSource.Count >= 1)
            {
                ModificarOjetos_Ej();
            }
            else
            {
                MessageBox.Show("No Hay Nada Que Mofificar", "MODIFICAR", MessageBoxButtons.OK);
            }
        }

        private void BtnCancelarEjercicio_Click(object sender, EventArgs e)
        {
            BorrarErroresBasica();
            if (this.dtConfiguracionPrincipalDtConfiBindingSource.Count > 0)
            {
                if (this.BtnNuevoEjercicio.Tag.ToString() == "Nuevo")
                {
                    if (this.dtConfiDataGridView.RowCount > 0)
                    {
                        this.dtConfiDataGridView.Rows.RemoveAt(this.dtConfiDataGridView.CurrentCell.RowIndex);
                    }
                }

            }
            RestaurarOjetos_Ej();

        }

        private void BtnGuardarEjercicio_Click(object sender, EventArgs e)
        {

            if (this.dtConfiguracionPrincipalBindingSource.Count <= 0)
            {
                MessageBox.Show("Debe al Menos Crear Una Empresa", "EMPRESA");
                return;
            }
            if (string.IsNullOrEmpty(this.IdEmpresa.Text))
            {
                MessageBox.Show("Eliga Empresa Valida", "EMPRESA");
                return;
            }

            if (string.IsNullOrEmpty(this.IdConfi.Text))
            {
                MessageBox.Show("Falta Id Empresa", "ERROR APP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(this.IdEnlace.Text))
            {
                MessageBox.Show("Falta Id Reguistro", "ERROR APP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (EspacioDiscosConfi(ClasDatos.RutaBaseDatosDb, 30))
            {
                int i = 0;
                string Ejercicio = this.EjercicioTxt.Text;
                foreach (DataGridViewRow fila in this.dtConfiDataGridView.Rows)
                {
                    if (fila.Cells[2].Value != null)
                    {
                        if (fila.Cells[2].Value.ToString() == this.EjercicioTxt.Text)
                        {
                            if (fila.Index == this.dtConfiDataGridView.CurrentCell.RowIndex)
                            {
                                goto seguir2;
                            }
                            Random r = new Random();
                            int VALORid = r.Next(5, 100);
                            this.EjercicioTxt.Text = this.EjercicioTxt.Text + "_" + VALORid.ToString();
                            this.EjercicioTxt.ReadOnly = false;
                            this.EjercicioTxt.SelectAll();
                            this.EjercicioTxt.Select(4, 4);
                            MessageBox.Show(Ejercicio, "Este Ejercicio Ya Existe", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    seguir2:
                    if (i == this.dtConfiDataGridView.Rows.Count)
                    {
                        break;
                    }
                    i++;
                }
                BorrarErroresBasica();
                if (ValidarBasica())
                {
                    if (MessageBox.Show(" ¿Aceptar Guardar Ejercicio ? ", " GUARDAR DATOS ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        if (ClsConexionSql.SibaseDatosSql)
                        {


                            GuardarEjercicioSql();

                        }
                        else
                        {

                            if (File.Exists(ClasDatos.RutaBaseDatosDb))
                            {
                                GuardarEjercicioBb();
                            }
                            else
                            {
                                this.panel1Ejercicio.Enabled = false;
                                MessageBox.Show("No Se Guardo Correctamente", "FALLO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }


                    }
                }
            }
        }

        private void BtnEliminarEjercicio_Click(object sender, EventArgs e)
        {
            if (FormMenuPrincipal.menu2principal.SiOpenFatu == 0)
            {
                if (this.dtConfiguracionPrincipalDtConfiBindingSource.Count > 0)
                {
                    if (String.IsNullOrEmpty(this.IdEnlace.Text))
                    {
                        MessageBox.Show("Falta Id ", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (MessageBox.Show("Desea Eliminar La Ejercicio Y Todo Su Contenido", "ELIMINAR ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {

                        if (ClsConexionSql.SibaseDatosSql)
                        {
                            EliminarEjercicioSql();
                        }
                        else
                        {
                            EliminarEjercicioBb();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe Cerrar Formulario De  ((( FACTURACION )))", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormEjercicios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.BtnGuardarEjercicio.Enabled == true)
            {
                e.Cancel = true;
            }
        }

        private void BtnSalirEjerc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" ¿Salir Ejercicios ? ", " SALIR ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
