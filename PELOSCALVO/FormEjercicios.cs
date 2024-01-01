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
            if (this.IdConfi.Text.Length < 1)
            {
                ok = false;
                this.ErrorEjercicios.SetError(this.IdConfi, "_ingresar Id valido (( minimo 4 Caracteres))");
            }
            if (this.configuraccionBasicaTextBox.Text.Length < 4)
            {
                ok = false;
                this.ErrorEjercicios.SetError(this.configuraccionBasicaTextBox, "_ingresar Descripccion valido (( minimo 4 Caracteres))");
            }
            if (this.ejerciciosDeAñoTextBox.Text.Length < 4)
            {
                ok = false;
                this.ErrorEjercicios.SetError(this.ejerciciosDeAñoTextBox, "_ingresar Ejercicio valido (( minimo 4 Caracteres))");
            }
            if (this.EmpresaEnlace.Text.Length < 4)
            {
                ok = false;
                this.ErrorEjercicios.SetError(this.EmpresaEnlace, "_ingresar Enlace Empresa valido (( minimo 4 Caracteres))");
                if (this.añoDeEjercicioTextBox.Text.Length < 4)
                {
                    ok = false;
                    this.ErrorEjercicios.SetError(this.añoDeEjercicioTextBox, "_ingresar Año valido (( minimo 4 Caracteres))");
                }
            }
            return ok;
        }
        private void BorrarErroresBasica()
        {
            this.ErrorEjercicios.SetError(this.IdConfi, "");
            this.ErrorEjercicios.SetError(this.configuraccionBasicaTextBox, "");
            this.ErrorEjercicios.SetError(this.ejerciciosDeAñoTextBox, "");
            this.ErrorEjercicios.SetError(this.EmpresaEnlace, "");
            this.ErrorEjercicios.SetError(this.añoDeEjercicioTextBox, "");
        }
        private void RestaurarOjetos_Ej()
        {
            this.dtConfiDataGridView.Enabled = true;
            this.BtnGuardarEjercicio.Enabled = false;
            this.BtnCancelarEjercicio.Enabled = false;
            this.CambiarDeEmpresa1.Enabled = true;
            this.panel1Ejercicio.Enabled = true;
            this.configuraccionBasicaTextBox.ReadOnly = true;
            this.tipoInpuestoIVANumericUpDown.Enabled = false;
            this.ejerciciosDeAñoTextBox.ReadOnly = false;
            this.dtConfiDataGridView.Refresh();
        }
        private void ModificarOjetos_Ej()
        {
            this.ejerciciosDeAñoTextBox.ReadOnly = false;
            this.configuraccionBasicaTextBox.ReadOnly = false;
            this.tipoInpuestoIVANumericUpDown.Enabled = true;
            this.tipoInpuestoIVANumericUpDown.Value = 21;
            this.dtConfiDataGridView.Enabled = false;
            this.BtnGuardarEjercicio.Enabled = true;
            this.BtnCancelarEjercicio.Enabled = true;
            this.CambiarDeEmpresa1.Enabled = false;
            this.panel1Ejercicio.Enabled = false;
        }
        private void GuardarEjercicioBb()
        {
            string consulta = "";
            if (this.BtnNuevoEjercicio.Tag.ToString() == "Nuevo")
            {
                consulta = "INSERT INTO [DtConfi] ([EmpresaENLACE],[ConfiguraccionBasica] ,[TipoInpuestoIVA],[EjerciciosDeAño],[IdConexionConfi]," +
                   "[AñoDeEjercicio]) VALUES(@EmpresaENLACE, @ConfiguraccionBasica, @TipoInpuestoIVA, @EjerciciosDeAño, @IdConexionConfi," +
                   "  @AñoDeEjercicio)";
            }
            else
            {
                consulta = "UPDATE [DtConfi] SET [EmpresaENLACE] = @EmpresaENLACE, [ConfiguraccionBasica] = @ConfiguraccionBasica, [TipoInpuestoIVA] = @TipoInpuestoIVA, " +
                   " [EjerciciosDeAño] = @EjerciciosDeAño,  [IdConexionConfi] = @IdConexionConfi, " +
                   " [AñoDeEjercicio] = @AñoDeEjercicio  WHERE IdEnlace = @IdEnlace";
            }

            ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
            try
            {
                if (NuevaConexion.SiConexionDb)
                {
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@EmpresaENLACE", string.IsNullOrEmpty(this.EmpresaEnlace.Text) ? (object)DBNull.Value : this.EmpresaEnlace.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@ConfiguraccionBasica", string.IsNullOrEmpty(this.configuraccionBasicaTextBox.Text) ? (object)DBNull.Value : this.configuraccionBasicaTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@TipoInpuestoIVA", string.IsNullOrEmpty(this.tipoInpuestoIVANumericUpDown.Text) ? (object)DBNull.Value : Convert.ToInt32(this.tipoInpuestoIVANumericUpDown.Text));
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@EjerciciosDeAño", string.IsNullOrEmpty(this.ejerciciosDeAñoTextBox.Text) ? (object)DBNull.Value : this.ejerciciosDeAñoTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@IdConexionConfi", string.IsNullOrEmpty(this.IdConfi.Text) ? (object)DBNull.Value : Convert.ToInt32(this.IdConfi.Text));
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@AñoDeEjercicio", string.IsNullOrEmpty(this.añoDeEjercicioTextBox.Text) ? (object)DBNull.Value : this.añoDeEjercicioTextBox.Text);
                    NuevaConexion.ComandoDb.ExecuteNonQuery();
                    NuevaConexion.ComandoDb.Parameters.Clear();
                    this.dtConfiguracionPrincipalBindingSource.EndEdit();
                    this.dtConfiguracionPrincipalDtConfiBindingSource.EndEdit();
                    this.dtConfiDataGridView.EndEdit();
                    Validate();
                    MessageBox.Show("Se Guardaron Datos con exito", "GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetos_Ej();
                    if (this.BtnNuevoEjercicio.Tag.ToString() == "Nuevo")
                    {
                        consulta = "Select max(IdEnlace) from [DtConfi]";
                        NuevaConexion = new ClsConexionDb(consulta);
                        if (NuevaConexion.SiConexionDb)
                        {
                            OleDbDataReader reader = NuevaConexion.ComandoDb.ExecuteReader();
                            if (reader.HasRows)
                            {
                                if (reader.Read())
                                {
                                    if (!string.IsNullOrEmpty((reader["IdEnlace"]).ToString()))
                                    {
                                        this.IdEnlace.Text = reader["IdEnlace"].ToString();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
                consulta = "INSERT INTO [DtConfi] ([EmpresaENLACE],[ConfiguraccionBasica] ,[TipoInpuestoIVA],[EjerciciosDeAño],[IdConexionConfi]," +
                   "[AñoDeEjercicio]) VALUES(@EmpresaENLACE, @ConfiguraccionBasica, @TipoInpuestoIVA, @EjerciciosDeAño, @IdConexionConfi," +
                   "  @AñoDeEjercicio)";
            }
            else
            {
                consulta = "UPDATE [DtConfi] SET [EmpresaENLACE] = @EmpresaENLACE, [ConfiguraccionBasica] = @ConfiguraccionBasica, [TipoInpuestoIVA] = @TipoInpuestoIVA, " +
                   " [EjerciciosDeAño] = @EjerciciosDeAño,  [IdConexionConfi] = @IdConexionConfi, " +
                   " [AñoDeEjercicio] = @AñoDeEjercicio  WHERE IdEnlace = @IdEnlace";
            }

            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                if (NuevaConexion.SiConexionSql)
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@EmpresaENLACE", string.IsNullOrEmpty(this.EmpresaEnlace.Text) ? (object)DBNull.Value : this.EmpresaEnlace.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@ConfiguraccionBasica", string.IsNullOrEmpty(this.configuraccionBasicaTextBox.Text) ? (object)DBNull.Value : this.configuraccionBasicaTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@TipoInpuestoIVA", string.IsNullOrEmpty(this.tipoInpuestoIVANumericUpDown.Text) ? (object)DBNull.Value : Convert.ToInt32(this.tipoInpuestoIVANumericUpDown.Text));
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@EjerciciosDeAño", string.IsNullOrEmpty(this.ejerciciosDeAñoTextBox.Text) ? (object)DBNull.Value : this.ejerciciosDeAñoTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@IdConexionConfi", string.IsNullOrEmpty(this.IdConfi.Text) ? (object)DBNull.Value : Convert.ToInt32(this.IdConfi.Text));
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@AñoDeEjercicio", string.IsNullOrEmpty(this.añoDeEjercicioTextBox.Text) ? (object)DBNull.Value : this.añoDeEjercicioTextBox.Text);
                    NuevaConexion.ComandoSql.ExecuteNonQuery();
                    NuevaConexion.ComandoSql.Parameters.Clear();
                    this.dtConfiguracionPrincipalBindingSource.EndEdit();
                    this.dtConfiguracionPrincipalDtConfiBindingSource.EndEdit();
                    this.dtConfiDataGridView.EndEdit();
                    Validate();
                    MessageBox.Show("Se Guardaron Datos con exito", "GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetos_Ej();

                    if (this.BtnNuevoEjercicio.Tag.ToString() == "Nuevo")
                    {
                        consulta = "Select max(IdEnlace) from [DtConfi]";
                        NuevaConexion = new ClsConexionSql(consulta);
                        if (NuevaConexion.SiConexionSql)
                        {
                            SqlDataReader reader = NuevaConexion.ComandoSql.ExecuteReader();
                            if (reader.HasRows)
                            {
                                if (reader.Read())
                                {
                                    if (!string.IsNullOrEmpty((reader["IdEnlace"]).ToString()))
                                    {
                                        this.IdEnlace.Text = reader["IdEnlace"].ToString();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
                MessageBox.Show(ex.Message.ToString());
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
                MessageBox.Show(ex.Message.ToString());
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
                    if (fila.Cells[2].Value.ToString() == this.ejerciciosDeAñoTextBox.Text)
                    {
                        if (i == this.dtConfiDataGridView.CurrentCell.RowIndex)
                        {
                            goto seguir2;
                        }
                        Random r = new Random();
                        int VALORid = r.Next(5, 100);
                        this.ejerciciosDeAñoTextBox.Text = this.ejerciciosDeAñoTextBox.Text + "_" + VALORid.ToString();
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
                this.BtnNuevoEjercicio.Tag = "Nuevo";
                if (this.dtConfiguracionPrincipalBindingSource.Count <= 0)
                {
                    MessageBox.Show("Debe al Menos Crear Una Empresa", "EMPRESA");
                    return;
                }
                SqlDataReader reader;
                Random r = new Random();
                int VALORid = r.Next(500, 1000000);
                int numeroFILA = this.dtConfiDataGridView.Rows.Count;
                string DtConfi = "";
                int I = 0;
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
                    this.añoDeEjercicioTextBox.Text = Convert.ToString(fecha);
                    this.ejerciciosDeAñoTextBox.Text = " EJERCICIO " + fecha;
                }
                else
                {
                    this.ejerciciosDeAñoTextBox.Text = " EJERCICIO " + String.Format("{0:yyyy}", DateTime.Now);
                    this.añoDeEjercicioTextBox.Text = String.Format("{0:yyyy}", DateTime.Now);
                }
                this.configuraccionBasicaTextBox.Text = "Mi Configurarcion Nueva " + this.añoDeEjercicioTextBox.Text;
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
            if (string.IsNullOrEmpty(this.EmpresaEnlace.Text))
            {
                MessageBox.Show("Eliga Empresa Valida", "EMPRESA");
            }

            if (EspacioDiscosConfi(ClasDatos.RutaBaseDatosDb, 30))
            {
                int i = 0;
                string Ejercicio = this.ejerciciosDeAñoTextBox.Text;
                foreach (DataGridViewRow fila in this.dtConfiDataGridView.Rows)
                {
                    if (fila.Cells[2].Value != null)
                    {
                        if (fila.Cells[2].Value.ToString() == this.ejerciciosDeAñoTextBox.Text)
                        {
                            if (fila.Index == this.dtConfiDataGridView.CurrentCell.RowIndex)
                            {
                                goto seguir2;
                            }
                            Random r = new Random();
                            int VALORid = r.Next(5, 100);
                            this.ejerciciosDeAñoTextBox.Text = this.ejerciciosDeAñoTextBox.Text + "_" + VALORid.ToString();
                            this.ejerciciosDeAñoTextBox.ReadOnly = false;
                            this.ejerciciosDeAñoTextBox.SelectAll();
                            this.ejerciciosDeAñoTextBox.Select(4, 4);
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
