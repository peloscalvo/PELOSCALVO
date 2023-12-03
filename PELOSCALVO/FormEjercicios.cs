using Conexiones;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormEjercicios : Form
    {
        public FormEjercicios()
        {
            InitializeComponent();
        }
        private void FormEjercicios_Load(object sender, EventArgs e)
        {
            try
            {
                if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION != null)
                {
                    this.dtConfiguracionPrincipalBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION;
                    this.dtConfiBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION;
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
                consulta = "INSERT INTO [DtConfi] ([EnlaceDtconfi],[EmpresaENLACE],[ConfiguraccionBasica] ,[TipoInpuestoIVA],[EjerciciosDeAño],[IdConexionConfi]," +
                   "[AñoDeEjercicio]) VALUES(@EnlaceDtconfi, @EmpresaENLACE, @ConfiguraccionBasica, @TipoInpuestoIVA, @EjerciciosDeAño, @IdConexionConfi," +
                   "  @AñoDeEjercicio)";
            }
            else
            {
                consulta = "UPDATE [DtConfi] SET [EnlaceDtconfi] = @EnlaceDtconfi,[EmpresaENLACE] = @EmpresaENLACE, [ConfiguraccionBasica] = @ConfiguraccionBasica, [TipoInpuestoIVA] = @TipoInpuestoIVA, " +
                   " [EjerciciosDeAño] = @EjerciciosDeAño,  [IdConexionConfi] = @IdConexionConfi, " +
                   " [AñoDeEjercicio] = @AñoDeEjercicio  WHERE EnlaceDtconfi = @EnlaceDtconfi";
            }

            ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
            try
            {
                if (NuevaConexion.SiConexionDb)
                {
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@EnlaceDtconfi", string.IsNullOrEmpty(this.EnlaceDtconfi.Text) ? (object)DBNull.Value : this.EnlaceDtconfi.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@EmpresaENLACE", string.IsNullOrEmpty(this.EmpresaEnlace.Text) ? (object)DBNull.Value : this.EmpresaEnlace.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@ConfiguraccionBasica", string.IsNullOrEmpty(this.configuraccionBasicaTextBox.Text) ? (object)DBNull.Value : this.configuraccionBasicaTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@TipoInpuestoIVA", string.IsNullOrEmpty(this.tipoInpuestoIVANumericUpDown.Text) ? (object)DBNull.Value : Convert.ToInt32(this.tipoInpuestoIVANumericUpDown.Text));
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@EjerciciosDeAño", string.IsNullOrEmpty(this.ejerciciosDeAñoTextBox.Text) ? (object)DBNull.Value : this.ejerciciosDeAñoTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@IdConexionConfi", string.IsNullOrEmpty(this.IdConfi.Text) ? (object)DBNull.Value : Convert.ToInt32(this.IdConfi.Text));
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@AñoDeEjercicio", string.IsNullOrEmpty(this.añoDeEjercicioTextBox.Text) ? (object)DBNull.Value : this.añoDeEjercicioTextBox.Text);
                    NuevaConexion.ComandoDb.ExecuteNonQuery();
                    NuevaConexion.ComandoDb.Parameters.Clear();
                    this.dtConfiBindingSource.EndEdit();
                    this.dtConfiguracionPrincipalDtConfiBindingSource.EndEdit();
                    this.dtConfiDataGridView.EndEdit();
                    Validate();
                    MessageBox.Show("Se Guardaron Datos con exito", "GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetos_Ej();
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
                consulta = "INSERT INTO [DtConfi] ([EnlaceDtconfi],[EmpresaENLACE],[ConfiguraccionBasica] ,[TipoInpuestoIVA],[EjerciciosDeAño],[IdConexionConfi]," +
                   "[AñoDeEjercicio]) VALUES(@EnlaceDtconfi, @EmpresaENLACE, @ConfiguraccionBasica, @TipoInpuestoIVA, @EjerciciosDeAño, @IdConexionConfi," +
                   "  @AñoDeEjercicio)";
            }
            else
            {
                consulta = "UPDATE [DtConfi] SET [EnlaceDtconfi] = @EnlaceDtconfi,[EmpresaENLACE] = @EmpresaENLACE, [ConfiguraccionBasica] = @ConfiguraccionBasica, [TipoInpuestoIVA] = @TipoInpuestoIVA, " +
                   " [EjerciciosDeAño] = @EjerciciosDeAño,  [IdConexionConfi] = @IdConexionConfi, " +
                   " [AñoDeEjercicio] = @AñoDeEjercicio  WHERE EnlaceDtconfi = @EnlaceDtconfi";
            }

            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                if (NuevaConexion.SiConexionSql)
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@EnlaceDtconfi", string.IsNullOrEmpty(this.EnlaceDtconfi.Text) ? (object)DBNull.Value : this.EnlaceDtconfi.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@EmpresaENLACE", string.IsNullOrEmpty(this.EmpresaEnlace.Text) ? (object)DBNull.Value : this.EmpresaEnlace.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@ConfiguraccionBasica", string.IsNullOrEmpty(this.configuraccionBasicaTextBox.Text) ? (object)DBNull.Value : this.configuraccionBasicaTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@TipoInpuestoIVA", string.IsNullOrEmpty(this.tipoInpuestoIVANumericUpDown.Text) ? (object)DBNull.Value : Convert.ToInt32(this.tipoInpuestoIVANumericUpDown.Text));
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@EjerciciosDeAño", string.IsNullOrEmpty(this.ejerciciosDeAñoTextBox.Text) ? (object)DBNull.Value : this.ejerciciosDeAñoTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@IdConexionConfi", string.IsNullOrEmpty(this.IdConfi.Text) ? (object)DBNull.Value : Convert.ToInt32(this.IdConfi.Text));
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@AñoDeEjercicio", string.IsNullOrEmpty(this.añoDeEjercicioTextBox.Text) ? (object)DBNull.Value : this.añoDeEjercicioTextBox.Text);
                    NuevaConexion.ComandoSql.ExecuteNonQuery();
                    NuevaConexion.ComandoSql.Parameters.Clear();
                    this.dtConfiBindingSource.EndEdit();
                    this.dtConfiguracionPrincipalDtConfiBindingSource.EndEdit();
                    this.dtConfiDataGridView.EndEdit();
                    Validate();
                    MessageBox.Show("Se Guardaron Datos con exito", "GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetos_Ej();
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
            string consulta = "Delete from  [DtConfi]   WHERE Id= '@Id'";
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                {
                    if (NuevaConexion.SiConexionSql)
                    {
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", this.IdConfi.Text);
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
            string consulta = "Delete from  [DtConfi]   WHERE Id= '@Id'";
            ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
            try
            {
                {
                    if (NuevaConexion.SiConexionDb)
                    {
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", this.IdConfi.Text);
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
                Random r = new Random();
                int VALORid = r.Next(500, 1000000);
                int numeroFILA = this.dtConfiDataGridView.Rows.Count;
                this.dtConfiDataGridView.Sort(this.dtConfiDataGridView.Columns[0], ListSortDirection.Ascending);
                this.dtConfiguracionPrincipalDtConfiBindingSource.AddNew();
                this.EmpresaEnlace.Text = this.CambiarDeEmpresa1.Text;
                this.configuraccionBasicaTextBox.Text = "Mi Configurarcion Nueva " + this.añoDeEjercicioTextBox.Text;
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
            if (this.dtConfiDataGridView.RowCount >= 0)
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
                            this.ejerciciosDeAñoTextBox.ReadOnly = false;
                            this.ejerciciosDeAñoTextBox.SelectAll();
                            this.ejerciciosDeAñoTextBox.Select(4, 4);
                            MessageBox.Show(this.ejerciciosDeAñoTextBox.Text, "Este Ejercicio Ya Existe", MessageBoxButtons.OK);
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
                    if (MessageBox.Show(" ¿Aceptar Guardar Configuracion ? ", " GUARDAR DATOS ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Random r = new Random();
                        int VALORid = r.Next(500, 1000000);
                        EnlaceDtconfi.Text = ejerciciosDeAñoTextBox.Text + "/" + EmpresaEnlace.Text + "/" + IdConfi.Text + "/" + VALORid;

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
            {
                if (this.dtConfiBindingSource.Count > 0)
                {
                    if (MessageBox.Show("Desea Eliminar La Configuracion", "ELIMINAR ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
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
            if (MessageBox.Show(" ¿Salir Configuracion ? ", " SALIR ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
