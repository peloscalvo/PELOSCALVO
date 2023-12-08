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
    public partial class FormDatoInicio : Form
    {
        public FormDatoInicio()
        {
            InitializeComponent();
        }
        private void FormDatoInicio_Load(object sender, EventArgs e)
        {

        }
        private bool EspacioDiscosInicio(string nombreDisco, int Espacio)
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

            if (this.empresaInicio.Text.Length < 3)
            {
                ok = false;
                this.ErrorInico.SetError(this.empresaInicio, "_ingresar Nonbre Empresa valido (( minimo 3 Caracteres))");
            }


            return ok;
        }
        private void BorrarErrorPais()
        {
            this.ErrorInico.SetError(this.empresaInicio, "");

        }
        private void GuardarInicioDb()
        {
            string consulta = "";
            if (this.PanelBotones_Inicio.Tag.ToString() == "Nuevo")
            {
                consulta = "  INSERT INTO [DtInicioMulti] VALUES([@Id],[@EmpresaInicio],[@EjercicioInicio],[@SerieInicio]," +
                    "[@NombreArchivoDatos],[@RutaArchivoDatos],[@SerieProvinciaInicio],[@SeriePaisInicio],[@ArchivoArticulos],[@TipoExtensionArticulos]," +
                    "[@ArchivoClientes],[@ArchivoInicioFacturas])";

            }
            else
            {
                consulta = "UPDATE [DtInicioMulti] SET [Id] = @Id,[EmpresaInicio] = @EmpresaInicio,[EjercicioInicio] = @EjercicioInicio,[SerieInicio] = @SerieInicio," +
                    "[NombreArchivoDatos] = @NombreArchivoDatos,[RutaArchivoDatos] = @RutaArchivoDatos,[SerieProvinciaInicio] = @SerieProvinciaInicio," +
                    "[SeriePaisInicio] = @SeriePaisInicio, [ArchivoArticulos] = @ArchivoArticulos,[TipoExtensionArticulos] = @TipoExtensionArticulos," +
                    "[ArchivoClientes] = @ArchivoClientes,[ArchivoInicioFacturas] = @ArchivoInicioFacturas  WHERE Id = @Id";
            }
            ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
            try
            {
                if (NuevaConexion.SiConexionDb)
                {
                  //  NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", string.IsNullOrEmpty(this.Id_Pais.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Id_Pais.Text));
                   // NuevaConexion.ComandoDb.Parameters.AddWithValue("@PaisesPaises", string.IsNullOrEmpty(this.NombrePais.Text) ? (object)DBNull.Value : this.NombrePais.Text);
                    NuevaConexion.ComandoDb.ExecuteNonQuery();
                    NuevaConexion.ComandoDb.Parameters.Clear();
                    Validate();
                    this.dtInicioDataGridView.EndEdit();
                    this.dtInicioMultiBindingSource.EndEdit();
                    MessageBox.Show("Se Guardo Correctamente", "GUARDAR DATOS INICIO ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetosInico();
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
        private void GuardarInicioSql()
        {
            string consulta = "";
            if (this.PanelBotones_Inicio.Tag.ToString() == "Nuevo")
            {
                consulta = "  INSERT INTO [DtInicioMulti] VALUES([@Id],[@EmpresaInicio],[@EjercicioInicio],[@SerieInicio]," +
                    "[@NombreArchivoDatos],[@RutaArchivoDatos],[@SerieProvinciaInicio],[@SeriePaisInicio],[@ArchivoArticulos],[@TipoExtensionArticulos]," +
                    "[@ArchivoClientes],[@ArchivoInicioFacturas])";

            }
            else
            {
                consulta = "UPDATE [DtInicioMulti] SET [Id] = @Id,[EmpresaInicio] = @EmpresaInicio,[EjercicioInicio] = @EjercicioInicio,[SerieInicio] = @SerieInicio," +
                    "[NombreArchivoDatos] = @NombreArchivoDatos,[RutaArchivoDatos] = @RutaArchivoDatos,[SerieProvinciaInicio] = @SerieProvinciaInicio," +
                    "[SeriePaisInicio] = @SeriePaisInicio, [ArchivoArticulos] = @ArchivoArticulos,[TipoExtensionArticulos] = @TipoExtensionArticulos," +
                    "[ArchivoClientes] = @ArchivoClientes,[ArchivoInicioFacturas] = @ArchivoInicioFacturas  WHERE Id = @Id";
            }
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                if (NuevaConexion.SiConexionSql)
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", string.IsNullOrEmpty(this.Id_Inicio.Text) ? (object)DBNull.Value :Convert.ToInt32( this.Id_Inicio.Text));
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@EmpresaInicio", string.IsNullOrEmpty(this.empresaInicio.Text) ? (object)DBNull.Value : this.empresaInicio.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@EjercicioInicio", string.IsNullOrEmpty(this.empresaInicio.Text) ? (object)DBNull.Value : this.empresaInicio.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@SerieInicio", string.IsNullOrEmpty(this.SerieInicio.Text) ? (object)DBNull.Value : this.SerieInicio.Text);
                   // NuevaConexion.ComandoSql.Parameters.AddWithValue("@NombreArchivoDatos", string.IsNullOrEmpty(this.nombr.Text) ? (object)DBNull.Value : this.empresaInicio.Text);
                  //  NuevaConexion.ComandoSql.Parameters.AddWithValue("@RutaArchivoDatos", string.IsNullOrEmpty(this.empresaInicio.Text) ? (object)DBNull.Value : this.empresaInicio.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@SerieProvinciaInicio", string.IsNullOrEmpty(this.provinciaInicio.Text) ? (object)DBNull.Value : this.provinciaInicio.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@SeriePaisInicio", string.IsNullOrEmpty(this.PaisInicio.Text) ? (object)DBNull.Value : this.PaisInicio.Text);
                   // NuevaConexion.ComandoSql.Parameters.AddWithValue("@ArchivoArticulos", string.IsNullOrEmpty(this.EjercicioInicio.Text) ? (object)DBNull.Value : this.EjercicioInicio.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@TipoExtensionArticulos", string.IsNullOrEmpty(this.tipoExtensionArticulosComboBox.Text) ? (object)DBNull.Value : this.tipoExtensionArticulosComboBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@ArchivoClientes", string.IsNullOrEmpty(this.archivoClientesComboBox.Text) ? (object)DBNull.Value : this.archivoClientesComboBox.Text);
                   // NuevaConexion.ComandoSql.Parameters.AddWithValue("@ArchivoInicioFacturas", string.IsNullOrEmpty(this.EjercicioInicio.Text) ? (object)DBNull.Value : this.EjercicioInicio.Text);
                    NuevaConexion.ComandoSql.ExecuteNonQuery();
                    NuevaConexion.ComandoSql.Parameters.Clear();
                    Validate();
                    this.dtInicioMultiBindingSource.EndEdit();
                    this.dtInicioDataGridView.EndEdit();
                    MessageBox.Show("Se Guardo Correctamente", "GUARDAR DATOS INICIO ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetosInico();
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
        private void ModificarOjetosInicio()
        {
            this.PanelDatosInicio.Enabled = false;
            BtnGuardarInico.Enabled = true;
            BtnCancelarInicio.Enabled = true;
        }
        private void RestaurarOjetosInico()
        {
            this.PanelDatosInicio.Enabled = true;
            BtnGuardarInico.Enabled = false;
            BtnCancelarInicio.Enabled = false;
        }
        private void BtnSalir_Inico_Click(object sender, EventArgs e)
        {
            if (this.BtnGuardarInico.Enabled == false)
            {
                if (MessageBox.Show(" Salir Datos Inico  ", " SALIR ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

        private void BtnNuevoPais_Click(object sender, EventArgs e)
        {
            this.PanelDatosInicio.Tag = "Nuevo";
            try
            {
                Id_Inicio.Text = "1";
             
              ModificarOjetosInicio();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnModificarInicio_Click(object sender, EventArgs e)
        {
            this.PanelDatosInicio.Tag = "Modificar";
            try
            {


                ModificarOjetosInicio();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnGuardarInico_Click(object sender, EventArgs e)
        {
            if (EspacioDiscosInicio(ClasDatos.RutaMultidatos, 25))

                BorrarErrorPais();
            if (ValidarPais())
            {
                
                  
                    if (MessageBox.Show(" ¿Aceptar Guardar Datos De Inicio ? ", " GUARDAR DATOS INICIO ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (ClsConexionSql.SibaseDatosSql)
                        {
                            GuardarInicioSql();
                        }
                        else
                        {

                            if (File.Exists(ClasDatos.RutaBaseDatosDb))
                            {
                                GuardarInicioSql();
                            }
                            else
                            {
                                MessageBox.Show("Archivo No Se Encuentra", " FALLO AL GUARDAR ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                this.PanelBotones_Inicio.Enabled = false;
                            }
                        }
                    }
                
            }
        }
    }
}
