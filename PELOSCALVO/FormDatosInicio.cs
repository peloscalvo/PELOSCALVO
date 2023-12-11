using Conexiones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormDatosInicio : Form
    {
        public FormDatosInicio()
        {
            InitializeComponent();
        }
        private void FormDatoInicio_Load(object sender, EventArgs e)
        {
            try
            {
                if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION != null)
                {
                    this.dtConfiguracionPrincipalBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfiguracionPrincipal;

                }
                if (FormMenuPrincipal.menu2principal.dsMulti2 != null)
                {
                    this.dtProvinciasBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2.DtProvincias;
                    this.dtPaisesBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2.DtPaises;
                }
                if (FormMenuPrincipal.menu2principal.dsMultidatos != null)
                {
                    this.dtInicioMultiBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMultidatos.DtInicioMulti;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            if (dtInicioMultiBindingSource.Count > 0)
            {
                BtnGuardarInico.Enabled = false;
            }
            ArchivoArticuloTxt.DataSource = ObtenerTablasDb();
            ArchivoClienteTxt.DataSource = ObtenerTablasDb();
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

        private bool ValidarInicio()
        {
            bool ok = true;
            if (this.EmpresaInicio.Text.Length < 3)
            {
                ok = false;
                this.ErrorInico.SetError(this.EmpresaInicio, "_ingresar Empresa valido (( minimo 3 Caracteres))");
            }
            if (this.EjercicioInicio.Text.Length < 3)
            {
                ok = false;
                this.ErrorInico.SetError(this.EjercicioInicio, "_ingresar Ejercicio valido (( minimo 3 Caracteres))");
            }
            if (this.SerieInicio.Text.Length < 1)
            {
                ok = false;
                this.ErrorInico.SetError(this.SerieInicio, "_ingresar Serie valido (( minimo 1 Caracteres))");
            }
            if (this.PaisInicio.Text.Length < 3)
            {
                ok = false;
                this.ErrorInico.SetError(this.PaisInicio, "_ingresar Pais valido (( minimo 3 Caracteres))");
            }
            if (this.ProvinciaInicio.Text.Length < 3)
            {
                ok = false;
                this.ErrorInico.SetError(this.ProvinciaInicio, "_ingresar Provincia valido (( minimo 3 Caracteres))");
            }
            if (this.ArchivoArticuloTxt.Text.Length < 3)
            {
                ok = false;
                this.ErrorInico.SetError(this.ArchivoArticuloTxt, "_ingresar Articulo valido (( minimo 3 Caracteres))");
            }
            if (this.ArchivoClienteTxt.Text.Length < 3)
            {
                ok = false;
                this.ErrorInico.SetError(this.ArchivoClienteTxt, "_ingresar Cliente valido (( minimo 3 Caracteres))");
            }
            if (this.ExtensionTipoInicio.Text.Length < 1)
            {
                ok = false;
                this.ErrorInico.SetError(this.ExtensionTipoInicio, "_ingresar Extension valido (( minimo 3 Caracteres))");
            }
            return ok;
        }
        private void BorrarErroresInicio()
        {
            this.ErrorInico.SetError(this.EmpresaInicio, "");
            this.ErrorInico.SetError(this.PaisInicio, "");
            this.ErrorInico.SetError(this.ProvinciaInicio, "");
            this.ErrorInico.SetError(this.PaisInicio, "");
            this.ErrorInico.SetError(this.SerieInicio, "");
            this.ErrorInico.SetError(this.ArchivoArticuloTxt, "");
            this.ErrorInico.SetError(this.ArchivoClienteTxt, "");
            this.ErrorInico.SetError(this.ExtensionTipoInicio, "");
            this.ErrorInico.SetError(this.EjercicioInicio, "");
        }
        private List<string> ObtenerTablasDb()
        {

            // Microsoft Access provider factory
            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");

            DataTable userTables = null;
            string Ruta = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + ClasDatos.RutaBaseDatosDb;
            using (DbConnection connection = factory.CreateConnection())
            {

                try
                {
                    connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Ruta;
                    string[] restrictions = new string[4];
                    restrictions[3] = "Table";
                    connection.Open();

                    userTables = connection.GetSchema("Tables", restrictions);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            }
            List<string> tableNames = new List<string>();
            if (userTables != null)
            {
                try
                {
                    for (int i = 0; i < userTables.Rows.Count; i++)
                    {
                        // ListaTablasPrincipal.Items.Add(userTables.Rows[i][2].ToString());

                        if (!userTables.Rows[i][2].ToString().Contains("Dt"))
                        {
                            tableNames.Add(userTables.Rows[i][2].ToString());
                        }


                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
              
            }

            return tableNames;
        }

        private void GuardarInicioDb()
        {
            string consulta = "";
            string Ruta = "";
            if (FormMenuPrincipal.menu2principal.InfoCarpeta.Text != string.Empty)
            {
                Ruta = FormMenuPrincipal.menu2principal.InfoCarpeta.Text;
            }
            else
            {
                Ruta = Directory.GetCurrentDirectory();
            }
            if (this.PanelBotones_Inicio.Tag.ToString() == "Nuevo")
            {
                consulta = "  INSERT INTO [DtInicioMulti] VALUES([@Id],[@EmpresaInicio],[@EjercicioInicio],[@SerieInicio]," +
                    "[@NombreArchivoDatos],[@RutaArchivoDatos],[@SerieProvinciaInicio],[@SeriePaisInicio],[@ArchivoArticulos],[@TipoExtensionArticulos]," +
                    "[@ArchivoClientes])";

            }
            else
            {
                consulta = "UPDATE [DtInicioMulti] SET [Id] = @Id,[EmpresaInicio] = @EmpresaInicio,[EjercicioInicio] = @EjercicioInicio,[SerieInicio] = @SerieInicio," +
                    "[NombreArchivoDatos] = @NombreArchivoDatos,[RutaArchivoDatos] = @RutaArchivoDatos,[SerieProvinciaInicio] = @SerieProvinciaInicio," +
                    "[SeriePaisInicio] = @SeriePaisInicio, [ArchivoArticulos] = @ArchivoArticulos,[TipoExtensionArticulos] = @TipoExtensionArticulos," +
                    "[ArchivoClientes] = @ArchivoClientes  WHERE Id = @Id";
            }
            ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
            try
            {
                if (NuevaConexion.SiConexionDb)
                {
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", string.IsNullOrEmpty(this.Id_Inicio.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Id_Inicio.Text));
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@EmpresaInicio", string.IsNullOrEmpty(this.EmpresaInicio.Text) ? (object)DBNull.Value : this.EmpresaInicio.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@EjercicioInicio", string.IsNullOrEmpty(this.EmpresaInicio.Text) ? (object)DBNull.Value : this.EmpresaInicio.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@SerieInicio", string.IsNullOrEmpty(this.SerieInicio.Text) ? (object)DBNull.Value : this.SerieInicio.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@NombreArchivoDatos", string.IsNullOrEmpty(ClasDatos.RutaBaseDatosDb) ? (object)DBNull.Value : ClasDatos.RutaBaseDatosDb);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@RutaArchivoDatos", string.IsNullOrEmpty(Ruta) ? (object)DBNull.Value : Ruta);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@SerieProvinciaInicio", string.IsNullOrEmpty(this.ProvinciaInicio.Text) ? (object)DBNull.Value : this.ProvinciaInicio.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@SeriePaisInicio", string.IsNullOrEmpty(this.PaisInicio.Text) ? (object)DBNull.Value : this.PaisInicio.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@ArchivoArticulos", string.IsNullOrEmpty(this.ArchivoArticuloTxt.Text) ? (object)DBNull.Value : this.ArchivoArticuloTxt.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@TipoExtensionArticulos", string.IsNullOrEmpty(this.ExtensionTipoInicio.Text) ? (object)DBNull.Value : this.ExtensionTipoInicio.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@ArchivoClientes", string.IsNullOrEmpty(this.ArchivoClienteTxt.Text) ? (object)DBNull.Value : this.ArchivoClienteTxt.Text);
                    NuevaConexion.ComandoDb.ExecuteNonQuery();
                    NuevaConexion.ComandoDb.Parameters.Clear();
                    Validate();
                    this.dtInicioDataGridView.EndEdit();
                    this.dtInicioMultiBindingSource.EndEdit();
                    MessageBox.Show("Se Guardo Correctamente", "GUARDAR DATOS INICIO ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetosInico();
                    BtnNuevoInicio.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "INICIO");
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
            string Ruta = "";
            if (this.PanelBotones_Inicio.Tag.ToString() == "Nuevo")
            {
                consulta = "  INSERT INTO [DtInicioMulti] VALUES([@Id],[@EmpresaInicio],[@EjercicioInicio],[@SerieInicio]," +
                    "[@NombreArchivoDatos],[@RutaArchivoDatos],[@SerieProvinciaInicio],[@SeriePaisInicio],[@ArchivoArticulos],[@TipoExtensionArticulos]," +
                    "[@ArchivoClientes])";

            }
            else
            {
                consulta = "UPDATE [DtInicioMulti] SET [Id] = @Id,[EmpresaInicio] = @EmpresaInicio,[EjercicioInicio] = @EjercicioInicio,[SerieInicio] = @SerieInicio," +
                    "[NombreArchivoDatos] = @NombreArchivoDatos,[RutaArchivoDatos] = @RutaArchivoDatos,[SerieProvinciaInicio] = @SerieProvinciaInicio," +
                    "[SeriePaisInicio] = @SeriePaisInicio, [ArchivoArticulos] = @ArchivoArticulos,[TipoExtensionArticulos] = @TipoExtensionArticulos," +
                    "[ArchivoClientes] = @ArchivoClientes  WHERE Id = @Id";
            }
            if(FormMenuPrincipal.menu2principal.InfoCarpeta.Text != string.Empty)
            {
                 Ruta = FormMenuPrincipal.menu2principal.InfoCarpeta.Text;
            }
            else
            {
                Ruta = Directory.GetCurrentDirectory();
            }
  
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                if (NuevaConexion.SiConexionSql)
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", string.IsNullOrEmpty(this.Id_Inicio.Text) ? (object)DBNull.Value :Convert.ToInt32( this.Id_Inicio.Text));
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@EmpresaInicio", string.IsNullOrEmpty(this.EmpresaInicio.Text) ? (object)DBNull.Value : this.EmpresaInicio.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@EjercicioInicio", string.IsNullOrEmpty(this.EmpresaInicio.Text) ? (object)DBNull.Value : this.EmpresaInicio.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@SerieInicio", string.IsNullOrEmpty(this.SerieInicio.Text) ? (object)DBNull.Value : this.SerieInicio.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@NombreArchivoDatos", string.IsNullOrEmpty(ClasDatos.RutaBaseDatosDb) ? (object)DBNull.Value : ClasDatos.RutaBaseDatosDb);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@RutaArchivoDatos", string.IsNullOrEmpty( Ruta  ) ? (object)DBNull.Value : Ruta);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@SerieProvinciaInicio", string.IsNullOrEmpty(this.ProvinciaInicio.Text) ? (object)DBNull.Value : this.ProvinciaInicio.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@SeriePaisInicio", string.IsNullOrEmpty(this.PaisInicio.Text) ? (object)DBNull.Value : this.PaisInicio.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@ArchivoArticulos", string.IsNullOrEmpty(this.ArchivoArticuloTxt.Text) ? (object)DBNull.Value : this.ArchivoArticuloTxt.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@TipoExtensionArticulos", string.IsNullOrEmpty(this.ExtensionTipoInicio.Text) ? (object)DBNull.Value : this.ExtensionTipoInicio.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@ArchivoClientes", string.IsNullOrEmpty(this.ArchivoClienteTxt.Text) ? (object)DBNull.Value : this.ArchivoClienteTxt.Text);
                    NuevaConexion.ComandoSql.ExecuteNonQuery();
                    NuevaConexion.ComandoSql.Parameters.Clear();
                    Validate();
                    this.dtInicioMultiBindingSource.EndEdit();
                    this.dtInicioDataGridView.EndEdit();
                    MessageBox.Show("Se Guardo Correctamente", "GUARDAR DATOS INICIO ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetosInico();
                    BtnNuevoInicio.Enabled = false;
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


        private void BtnModificarInicio_Click(object sender, EventArgs e)
        {
            this.PanelBotones_Inicio.Tag = "Modificar";
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
            if (EspacioDiscosInicio(Directory.GetCurrentDirectory(), 25))
            {
                BorrarErroresInicio();
                if (ValidarInicio())
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
                                GuardarInicioDb();
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

        private void BtnNuevoInicio_Click(object sender, EventArgs e)
        {
            this.PanelBotones_Inicio.Tag = "Nuevo";
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
    }
}
