using Conexiones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
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
                    this.dtConfiBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfiguracionPrincipal;
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
            if (this.dtInicioMultiBindingSource.Count > 0)
            {
                this.BtnNuevoInicio.Enabled = false;
            }
            if (ClsConexionSql.SibaseDatosSql)
            {
                this.ArchivoArticuloTxt.DataSource = ObtenerTablasSql();
                this.ArchivoClienteTxt.DataSource = ObtenerTablasSql();
            }
            else
            {
                this.ArchivoArticuloTxt.DataSource = ObtenerTablasDb();
                this.ArchivoClienteTxt.DataSource = ObtenerTablasDb();
            }

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



        private List<string> ObtenerTablasSql()
        {

            // Microsoft Access provider factory
            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.SqlClient");

            DataTable userTables = null;
            using (DbConnection connection = factory.CreateConnection())
            {

                try
                {
                    connection.ConnectionString = ClsConexionSql.CadenaConexion;
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
        private List<string> ObtenerTablasDb()
        {

            // Microsoft Access provider factory
            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");

            DataTable userTables = null;
            using (DbConnection connection = factory.CreateConnection())
            {

                try
                {
                    connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ClasDatos.RutaBaseDatosDb;
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
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@EjercicioInicio", string.IsNullOrEmpty(this.EjercicioInicio.Text) ? (object)DBNull.Value : this.EjercicioInicio.Text);
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
                    this.BtnNuevoInicio.Enabled = false;
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
            if (FormMenuPrincipal.menu2principal.InfoCarpeta.Text != string.Empty)
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
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", string.IsNullOrEmpty(this.Id_Inicio.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Id_Inicio.Text));
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@EmpresaInicio", string.IsNullOrEmpty(this.EmpresaInicio.Text) ? (object)DBNull.Value : this.EmpresaInicio.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@EjercicioInicio", string.IsNullOrEmpty(this.EjercicioInicio.Text) ? (object)DBNull.Value : this.EjercicioInicio.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@SerieInicio", string.IsNullOrEmpty(this.SerieInicio.Text) ? (object)DBNull.Value : this.SerieInicio.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@NombreArchivoDatos", string.IsNullOrEmpty(ClasDatos.RutaBaseDatosDb) ? (object)DBNull.Value : ClasDatos.RutaBaseDatosDb);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@RutaArchivoDatos", string.IsNullOrEmpty(Ruta) ? (object)DBNull.Value : Ruta);
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
                    this.BtnNuevoInicio.Enabled = false;
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
            this.PanelDatosInicio.Enabled = true;
            this.PanelBotones_Inicio.Enabled = false;
            this.BtnGuardarInico.Enabled = true;
            this.BtnCancelarInicio.Enabled = true;
        }
        private void RestaurarOjetosInico()
        {
            this.PanelBotones_Inicio.Enabled = false;
            this.PanelDatosInicio.Enabled = true;
            this.BtnGuardarInico.Enabled = false;
            this.BtnCancelarInicio.Enabled = false;
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

                if (MessageBox.Show(" ¿Aceptar Guardar Datos De Inicio ? ", " GUARDAR DATOS INICIO ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (File.Exists(ClasDatos.RutaMultidatos))
                    {
                        try
                        {
                            FormMenuPrincipal.menu2principal.dsMultidatos.WriteXml(ClasDatos.RutaMultidatos);
                            MessageBox.Show("Se guardo Con Exito", "GUARDAR ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RestaurarOjetosInico();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message.ToString(), "ERROR AL GUARDAR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Archivo No Se Encuentra", " FALLO AL GUARDAR ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.PanelBotones_Inicio.Enabled = false;
                    }
                    if (this.dtInicioMultiBindingSource.Count > 0)
                    {
                        this.BtnNuevoInicio.Enabled = false;
                    }
                }

            }
        }

        private void BtnNuevoInicio_Click(object sender, EventArgs e)
        {
            this.PanelBotones_Inicio.Tag = "Nuevo";
            try
            {
                this.Id_Inicio.Text = "1";

                ModificarOjetosInicio();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancelarInicio_Click(object sender, EventArgs e)
        {
            RestaurarOjetosInico();
        }
    }
}
