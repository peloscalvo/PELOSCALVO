using Comun;
using Conexiones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormBaseDatos : Form
    {
        public FormBaseDatos()
        {
            InitializeComponent();
            ToolTip InfoRestablecer = new ToolTip();
            InfoRestablecer.SetToolTip(this.BtnRestablecer, "Cierra toda Conexion y Restablece datos");
            InfoRestablecer.SetToolTip(this.BtnGuardarDatosArchivos, "Guarda Configuracion Local");
            InfoRestablecer.SetToolTip(this.BtnGuardarArchivo_Sql, "Guarda Configuracion Servidor");
            InfoRestablecer.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            InfoRestablecer.IsBalloon = true;

        }
        private void FormBaseDatos_Load(object sender, EventArgs e)
        {
            if (FormMenuPrincipal.menu2principal.dsMultidatos.DtInicioMulti != null)
            {

                this.dtInicioMultiBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMultidatos.DtInicioMulti;
            }

            if (FormMenuPrincipal.menu2principal.dsServidor != null)
            {
                this.dtServidorBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsServidor;
            }
            if (ClsConexionSql.SibaseDatosSql == false)
            {
                if (!File.Exists(ClasDatos.RutaBaseDatosDb))
                {
                    MessageBox.Show("Falta Archivo " + "\n" + ClasDatos.RutaBaseDatosDb, "ARCHIVO NO EXISTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            if (ClsConexionSql.SibaseDatosSql == false && ClsConexionDb.CadenaConexion != string.Empty)
            {
                if (!String.IsNullOrEmpty(FormMenuPrincipal.menu2principal.InfoBaseDatos.Text))
                {
                    if (FormMenuPrincipal.menu2principal.dsMultidatos.DtInicioMulti.Count > 0)
                    {
                        if (FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["NombreArchivoDatos"].ToString() != string.Empty)
                        {
                            this.NombreArchivoDatos.Text = FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["NombreArchivoDatos"].ToString();
                        }
                    }
                }
            }
            try
            {
                if (FormMenuPrincipal.menu2principal.dsServidor.DtServidor.Count < 4)
                {
                    FormMenuPrincipal.menu2principal.dsServidor.DtServidor.Rows.Add("(Local)");
                    FormMenuPrincipal.menu2principal.dsServidor.DtServidor.Rows.Add(".");
                    FormMenuPrincipal.menu2principal.dsServidor.DtServidor.Rows.Add("(localdb)\\MSSQLLocalDB");
                    FormMenuPrincipal.menu2principal.dsServidor.DtServidor.Rows.Add("(localdb)\\SQLVICTOR");
                    FormMenuPrincipal.menu2principal.dsServidor.DtServidor.Rows.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + "Servidores.Xml"))
                    {
                        FormMenuPrincipal.menu2principal.dsServidor.WriteXml(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + "Servidores.Xml");

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR");
            }
            //this.Servidor.Items.Add(string.Format(@"{0}\SQLEXPRESS", SL);

            Validate();
            this.Autenticacion.Text = "Autenticacion De Windows";

            CanbiarOjetos();
            this.Servidor.Tag = "SEGUIR";
            this.ContadorFactu.Text = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfiguracionPrincipal.Count.ToString();
            this.ContadorArticulos.Text = FormMenuPrincipal.menu2principal.articulos.DtArticulos.Count.ToString();
            this.ContadorClientes.Text = FormMenuPrincipal.menu2principal.dsClientes.DtClientes.Count.ToString();
        }
        private bool EspacioDiscosBase(string nombreDisco, int Espacio)
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
        public void Listar_InstantciasSql()
        {

            string connectionString = ClsConexionSql.CadenaConexion;
            SqlClientFactory Fatory = SqlClientFactory.Instance;
            Fatory.CreateConnection();
            using (DbConnection connection = Fatory.CreateConnection())
            {
                // System.Data.Common.DbProviderFactories
                connection.ConnectionString = connectionString;
                connection.Open();
                // Perform database operations here
            }

            DbCommand dbCommand = Fatory.CreateCommand();
            //SqlDataReader rd = dbCommand.ExecuteReader();
            dbCommand.ExecuteReader();
            System.Data.Sql.SqlDataSourceEnumerator GG = System.Data.Sql.SqlDataSourceEnumerator.Instance;
            GG.GetDataSources();
            // SqlDataReader RD =  FGHFG.CreateCommand ;

        }
        public List<string> ObtenerTablasBb()
        {

            // Microsoft Access provider factory
            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");

            DataTable userTables = null;
            string Ruta;
            if (this.NombreArchivoDatos.Text.ToString() == "Datos App Peloscalvo")
            {
                Ruta = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + this.NombreArchivoDatos.Text + "." + this.TipoExtension_b.Text;

            }
            else
            {
                Ruta = this.NombreArchivoDatos.Text;
            }

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
            this.SerieArticulosText.Items.Clear();
            this.SerieClientesText2.Items.Clear();
            List<string> tableNames = new List<string>();
            if (userTables != null)
            {
                try
                {
                    for (int i = 0; i < userTables.Rows.Count; i++)
                    {
                        this.ListaTablas.Items.Add(userTables.Rows[i][2].ToString());
                        if (!userTables.Rows[i][2].ToString().Contains("Dt"))
                        {
                            this.SerieArticulosText.Items.Add(userTables.Rows[i][2].ToString());
                            this.SerieClientesText2.Items.Add(userTables.Rows[i][2].ToString());
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
        public List<string> ObtenerTablasSql()
        {
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
                    userTables = connection.GetSchema("Tables");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            }
            this.SerieArticulosText.Items.Clear();
            this.SerieClientesText2.Items.Clear();
            this.ListaTablas.Items.Clear();
            List<string> tableNames = new List<string>();
            try
            {
                if (userTables != null)
                {
                    for (int i = 0; i < userTables.Rows.Count; i++)
                    {
                        this.ListaTablas.Items.Add(userTables.Rows[i][2].ToString());
                        if (!userTables.Rows[i][2].ToString().Contains("Dt"))
                        {
                            this.SerieArticulosText.Items.Add(userTables.Rows[i][2].ToString());
                            this.SerieClientesText2.Items.Add(userTables.Rows[i][2].ToString());
                            tableNames.Add(userTables.Rows[i][2].ToString());
                        }

                    }

                }
                // return tableNames;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            return tableNames;
        }
        private bool VALIDARcampos_Archivos()
        {
            bool ok = true;
            if (this.SerieArticulosText.Text == string.Empty)
            {
                ok = false;
                this.ErrorVer.SetError(this.SerieArticulosText, " (( Elija Una Opcion ..))");
            }
            if (this.SerieClientesText2.Text == string.Empty)
            {
                ok = false;
                this.ErrorVer.SetError(this.SerieClientesText2, " (( Elija Una Opcion ..))");
            }
            if (this.NombreArchivoDatos.ToString() == "Datos App Peloscalvo")
            {
                if (this.TipoExtension_b.Text == string.Empty)
                {
                    ok = false;
                    this.ErrorVer.SetError(this.TipoExtension_b, " (( Elija Una Opcion ..))");
                }
            }

            return ok;

        }
        private bool VALIDARcampos_SQL()
        {
            bool ok = true;
            if (this.SerieArticulosText.Text == string.Empty)
            {
                ok = false;
                this.ErrorVer.SetError(this.SerieArticulosText, " (( Elija Una Opcion ..))");
            }
            if (this.SerieClientesText2.Text == string.Empty)
            {
                ok = false;
                this.ErrorVer.SetError(this.SerieClientesText2, " (( Elija Una Opcion ..))");
            }
            return ok;

        }
        private void BORRARerror_Archivos()
        {
            this.ErrorVer.SetError(this.SerieClientesText2, "");
            this.ErrorVer.SetError(this.SerieArticulosText, "");
            this.ErrorVer.SetError(this.TipoExtension_b, "");
        }
        private void BORRARerror_Archivos_Sql()
        {
            this.ErrorVer.SetError(this.SerieClientesText2, "");
            this.ErrorVer.SetError(this.SerieArticulosText, "");
        }
        private void CanbiarOjetos()
        {
            if (ClsConexionSql.SibaseDatosSql)
            {
                if (ClsConexionSql.CadenaConexion != string.Empty)
                {

                    this.CheckAtivarServidor.Checked = true;
                    this.CheckActivarDb.Checked = false;
                    this.PictureArchivo.Image = Properties.Resources.CIRCULO_ROJO1;
                    this.PictureServidor.Image = Properties.Resources.CIRCULO_VERDE1_;
                    FormMenuPrincipal.menu2principal.Conectado.Image = Properties.Resources.CIRCULO_VERDE1_;
                    FormMenuPrincipal.menu2principal.InfoConectado.Text = "Conectado a Servidor";
                    FormMenuPrincipal.menu2principal.InfoConectado.BackColor = Color.LawnGreen;
                }
            }
            else
            {
                if (ClsConexionDb.CadenaConexion != string.Empty)
                {

                    this.CheckAtivarServidor.Checked = false;
                    this.CheckActivarDb.Checked = true;
                    this.PictureArchivo.Image = Properties.Resources.CIRCULO_VERDE1_;
                    this.PictureServidor.Image = Properties.Resources.CIRCULO_ROJO1;
                    FormMenuPrincipal.menu2principal.Conectado.Image = Properties.Resources.CIRCULO_VERDE1_;
                    FormMenuPrincipal.menu2principal.InfoConectado.Text = "Conectado a Db Local";
                    FormMenuPrincipal.menu2principal.InfoConectado.BackColor = Color.LawnGreen;
                }
            }
        }
        private void Contador()
        {
            this.ContadorFactu.Text = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfiguracionPrincipal.Count.ToString();
            this.ContadorArticulos.Text = FormMenuPrincipal.menu2principal.articulos.DtArticulos.Count.ToString();
            this.ContadorClientes.Text = FormMenuPrincipal.menu2principal.dsClientes.DtClientes.Count.ToString();
        }
        private void GuardarMultidatos()
        {
            if (EspacioDiscosBase(ClasDatos.RutaMultidatos, 5))
            {
                try
                {
                    if (File.Exists(ClasDatos.RutaMultidatos))
                    {
                        if (FormMenuPrincipal.menu2principal.dsMultidatos.DtInicioMulti.Count > 0)
                        {
                            FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["NombreArchivoDatos"] = this.NombreArchivoDatos.Text;
                            FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["ArchivoArticulos"] = this.SerieArticulosText.Text;
                            FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["ArchivoClientes"] = this.SerieClientesText2.Text;
                        }
                        else
                        {
                            string Ejercicio = " EJERCICIO " + String.Format("{0:yyyy}", DateTime.Now);
                            FormMenuPrincipal.menu2principal.dsMultidatos.DtInicioMulti.Rows.Add("Empresa", Ejercicio, "A", ClasDatos.RutaBaseDatosDb, Directory.GetCurrentDirectory(), "La Coruña", "España", this.SerieArticulosText.Text,
                               this.TipoExtension_b.Text, this.SerieClientesText2.Text, 1);
                        }
                        FormMenuPrincipal.menu2principal.dsMultidatos.WriteXml(ClasDatos.RutaMultidatos);
                    }
                    else
                    {
                        MessageBox.Show("Archivo No Se Encuentra", " FALLO AL GUARDAR ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        private void BuscarEmpresas()
        {
            int TTempresas = FormMenuPrincipal.menu2principal.dtConfiguracionPrincipalBindingSource.Count - 1;
            if (TTempresas >= 0)

                for (int bn = 0; bn <= TTempresas; bn++)
                {
                    if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtConfiguracionPrincipal"].Rows[bn]["EmpresaConfi"].ToString() != null)
                    {
                        string Archivo = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtConfiguracionPrincipal"].Rows[bn]["EmpresaConfi"].ToString();
                        string Ruta = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + Archivo + "." + this.TipoExtension_b.Text;
                        if (File.Exists(Ruta))
                        {
                            this.SerieClientesText2.Items.Add(Archivo);
                            this.SerieArticulosText.Items.Add(Archivo);
                        }

                    }
                }
        }
        private void ActualizarPrincipal_Db()
        {

            string consulta = "SELECT * from [DtConfiguracionPrincipal]  ";
            string consultaConfi = "SELECT * from [DtConfi]";
            string consultaTarifa = "SELECT * from[DtTarifaTipo]";
            string ConsultaAlmacenes = "SELECT * from [DtAlmacenes]";
            string ConsultaProveedores = "SELECT * from [DtProveedores]";
            string ConsultaOBRA = "SELECT * from [DtObras]";
            string ConsultaProvincia = "SELECT * from [DtProvincias]";
            string ConsultaPais = "SELECT * from [DtPaises]";
            string ConsultaFamilia = "SELECT * from [DtFamiliaProductos]";
            string ConsultaCorreoCli = "SELECT * from [DtCorreosCliente]";
            string ConsultaCorreoEmpresa = "SELECT * from [DtCorreos]";
            // string ConsutaInicio = "SELECT * from [DtInicioMulti]";

            ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
            OleDbDataAdapter AdactaPelos = new OleDbDataAdapter(consulta, ClsConexionDb.CadenaConexion);
            try
            {
                if (NuevaConexion.SiConexionDb)
                {
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfiguracionPrincipal);
                    AdactaPelos = new OleDbDataAdapter(consultaConfi, ClsConexionDb.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfi);
                    AdactaPelos = new OleDbDataAdapter(consultaTarifa, ClsConexionDb.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtTarifaTipo);
                    AdactaPelos = new OleDbDataAdapter(ConsultaAlmacenes, ClsConexionDb.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtAlmacenes);
                    AdactaPelos = new OleDbDataAdapter(ConsultaProveedores, ClsConexionDb.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtProveedores);
                    AdactaPelos = new OleDbDataAdapter(ConsultaOBRA, ClsConexionDb.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsMulti2.DtObras);
                    AdactaPelos = new OleDbDataAdapter(ConsultaPais, ClsConexionDb.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsMulti2.DtPaises);
                    AdactaPelos = new OleDbDataAdapter(ConsultaProvincia, ClsConexionDb.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsMulti2.DtProvincias);
                    AdactaPelos = new OleDbDataAdapter(ConsultaFamilia, ClsConexionDb.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsMulti2.DtFamiliaProductos);
                    AdactaPelos = new OleDbDataAdapter(ConsultaCorreoCli, ClsConexionDb.CadenaConexion);
                    AdactaPelos.Fill(ClassCorreosDB.DtCorreosCliente);
                    AdactaPelos = new OleDbDataAdapter(ConsultaCorreoEmpresa, ClsConexionDb.CadenaConexion);
                    AdactaPelos.Fill(ClassCorreosDB.DtCorreos);
                    AdactaPelos.Dispose();

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
                    AdactaPelos.Dispose();
                }
            }
        }
        private void ActualizarPrincipal_Sql()
        {

            string consulta = "SELECT * from [DtConfiguracionPrincipal]  ";
            string ConsultaAlmacenes = "SELECT * from [DtAlmacenes]";
            string ConsultaProveedores = "SELECT * from [DtProveedores]";
            string consultaConfi = "SELECT * from [DtConfi]";
            string consultaTarifa = "SELECT * from[DtTarifaTipo]";
            string ConsultaOBRA = "SELECT * from [DtObras]";
            string ConsultaProvincia = "SELECT * from [DtProvincias]";
            string ConsultaPais = "SELECT * from [DtPaises]";
            string ConsultaFamilia = "SELECT * from [DtFamiliaProductos]";
            string ConsultaCorreoCli = "SELECT * from [DtCorreosCliente]";
            string ConsultaCorreoEmpresa = "SELECT * from [DtCorreos]";
            // string ConsutaInicio = "SELECT * from [DtInicioMulti]";

            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            SqlDataAdapter AdactaPelos = new SqlDataAdapter(consulta, ClsConexionSql.CadenaConexion);
            try
            {
                if (NuevaConexion.SiConexionSql)
                {
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfiguracionPrincipal);
                    AdactaPelos = new SqlDataAdapter(consultaConfi, ClsConexionSql.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfi);
                    AdactaPelos = new SqlDataAdapter(consultaTarifa, ClsConexionSql.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtTarifaTipo);
                    AdactaPelos = new SqlDataAdapter(ConsultaAlmacenes, ClsConexionSql.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtAlmacenes);
                    AdactaPelos = new SqlDataAdapter(ConsultaProveedores, ClsConexionSql.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtProveedores);
                    AdactaPelos = new SqlDataAdapter(ConsultaPais, ClsConexionSql.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsMulti2.DtPaises);
                    AdactaPelos = new SqlDataAdapter(ConsultaProvincia, ClsConexionSql.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsMulti2.DtProvincias);
                    AdactaPelos = new SqlDataAdapter(ConsultaFamilia, ClsConexionSql.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsMulti2.DtFamiliaProductos);
                    AdactaPelos = new SqlDataAdapter(ConsultaOBRA, ClsConexionSql.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsMulti2.DtObras);
                    AdactaPelos = new SqlDataAdapter(ConsultaCorreoCli, ClsConexionDb.CadenaConexion);
                    AdactaPelos.Fill(ClassCorreosDB.DtCorreosCliente);
                    AdactaPelos = new SqlDataAdapter(ConsultaCorreoEmpresa, ClsConexionDb.CadenaConexion);
                    AdactaPelos.Fill(ClassCorreosDB.DtCorreos);
                    AdactaPelos.Dispose();

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
                    AdactaPelos.Dispose();
                }
            }
        }
        private void ActualizarArticulosSql()
        {
            if (FormMenuPrincipal.menu2principal.articulos.DtArticulos.Rows.Count <= 0)
            {

                string consulta = "SELECT * from [" + this.SerieArticulosText.Text + "]";
                ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
                FormMenuPrincipal.menu2principal.articulos.DtArticulos.Clear();
                try
                {
                    if (NuevaConexion.SiConexionSql)
                    {
                        SqlDataAdapter AdactaPelos = new SqlDataAdapter(consulta, ClsConexionSql.CadenaConexion);
                        AdactaPelos.Fill(FormMenuPrincipal.menu2principal.articulos.DtArticulos);

                        if (NuevaConexion.CerrarConexionSql)
                        {

                        }
                        // AñadirId();
                        // ValidarCalculosPrecios();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "ERROR");
                }
                finally

                {
                    if (NuevaConexion.CerrarConexionSql)
                    {

                    }
                }
            }
        }
        public void ActualizarArticulosDB()
        {
            String TipoTabla = "[" + this.SerieArticulosText.Text + "]";
            string consulta = "Select * from " + TipoTabla;
            ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
            try
            {
                if (NuevaConexion.SiConexionDb)
                {
                    OleDbDataAdapter AdactaPelos = new OleDbDataAdapter(consulta, ClsConexionDb.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.articulos.DtArticulos);
                    // SqlCommand cmd = new SqlCommand(ClsConexionDb.CadenaConexion);
                    OleDbDataReader reader = NuevaConexion.ComandoDb.ExecuteReader();
                    // DataTable TablaArticulos = new DataTable();
                    //  BindingSource bsArticulos = new BindingSource();
                    ClasArticulos.ListaArticulos.lista.Clear();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ClasArticulos.ArticulosDb item = new ClasArticulos.ArticulosDb();

                            if (!string.IsNullOrEmpty((reader["Id"]).ToString()))
                            {
                                item.Id = Convert.ToInt32(reader["Id"]);
                            }
                            if (!string.IsNullOrEmpty((reader["Referencia"]).ToString()))
                            {
                                item.Referencia = Convert.ToString(reader["Referencia"]);
                            }
                            if (!string.IsNullOrEmpty((reader["Descripcci"]).ToString()))
                            {
                                item.Descripcci = Convert.ToString(reader["Descripcci"]);
                            }
                            if (!string.IsNullOrEmpty((reader["Coste"]).ToString()))
                            {
                                item.Coste = Convert.ToDouble(reader["Coste"]);
                            }
                            if (!string.IsNullOrEmpty((reader["Ganancia"]).ToString()))
                            {
                                item.Ganancia = Convert.ToDouble(reader["Ganancia"]);
                            }
                            if (!string.IsNullOrEmpty((reader["Pvp1"]).ToString()))
                            {
                                item.Pvp1 = Convert.ToDouble(reader["Pvp1"]);
                            }
                            if (!string.IsNullOrEmpty((reader["PvpIva"]).ToString()))
                            {
                                item.PvpIva = Convert.ToDouble(reader["PvpIva"]);
                            }
                            if (!string.IsNullOrEmpty((reader["Pvp2Desc"]).ToString()))
                            {
                                item.Pvp2Desc = Convert.ToDouble(reader["Pvp2Desc"]);
                            }
                            if (!string.IsNullOrEmpty((reader["Pvp2"]).ToString()))
                            {
                                item.Pvp2 = Convert.ToDouble(reader["Pvp2"]);
                            }

                            if (!string.IsNullOrEmpty((reader["CastyDesc"]).ToString()))
                            {
                                item.CastyDesc = Convert.ToDouble(reader["CastyDesc"]);
                            }

                            if (!string.IsNullOrEmpty((reader["Casty"]).ToString()))
                            {
                                item.Casty = Convert.ToDouble(reader["Casty"]);
                            }
                            if (!string.IsNullOrEmpty((reader["SuarezDesc"]).ToString()))
                            {
                                item.SuarezDesc = Convert.ToDouble(reader["SuarezDesc"]);
                            }
                            if (!string.IsNullOrEmpty((reader["Suarez"]).ToString()))
                            {
                                item.Suarez = Convert.ToDouble(reader["Suarez"]);
                            }

                            if (!string.IsNullOrEmpty((reader["BenitoDesc"]).ToString()))
                            {
                                item.BenitoDesc = Convert.ToDouble(reader["BenitoDesc"]);
                            }
                            if (!string.IsNullOrEmpty((reader["Benito"]).ToString()))
                            {

                                item.Benito = Convert.ToDouble(reader["Benito"]);
                            }
                            if (!string.IsNullOrEmpty((reader["ValenteDes"]).ToString()))
                            {
                                item.ValenteDes = Convert.ToDouble(reader["ValenteDes"]);
                            }
                            if (!string.IsNullOrEmpty((reader["Valente"]).ToString()))
                            {
                                item.Valente = Convert.ToDouble(reader["Valente"]);
                            }
                            if (!string.IsNullOrEmpty((reader["PlusDesc"]).ToString()))
                            {
                                item.PlusDesc = Convert.ToDouble(reader["PlusDesc"]);
                            }
                            if (!string.IsNullOrEmpty((reader["Plus"]).ToString()))
                            {
                                item.Plus = Convert.ToDouble(reader["Plus"]);
                            }
                            if (!string.IsNullOrEmpty((reader["Stock"]).ToString()))
                            {
                                item.Stock = Convert.ToDouble(reader["Stock"]);
                            }
                            if (!string.IsNullOrEmpty((reader["Familia"]).ToString()))
                            {
                                item.Familia = Convert.ToString(reader["Familia"]);
                            }
                            if (!string.IsNullOrEmpty((reader["Fecha"]).ToString()))
                            {
                                item.Fecha = Convert.ToString(reader["Fecha"]);
                            }
                            if (!string.IsNullOrEmpty((reader["UnidadPale"]).ToString()))
                            {
                                item.UnidadPale = Convert.ToString(reader["UnidadPale"]);
                            }

                            if (!string.IsNullOrEmpty((reader["MinimosSto"]).ToString()))
                            {
                                item.MinimosSto = Convert.ToString(reader["MinimosSto"]);
                            }

                            if (string.IsNullOrEmpty((reader["Baja"]).ToString()))
                            {
                                item.Baja = Convert.ToBoolean(reader["Baja"]);
                            }
                            else
                            {
                                item.Baja = Convert.ToBoolean(false);
                            }
                            if (string.IsNullOrEmpty((reader["Fatu"]).ToString()))
                            {
                                item.Fatu = Convert.ToBoolean(reader["Fatu"]);
                            }
                            ClasArticulos.ListaArticulos.lista.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR");
            }
            finally
            {
                if (NuevaConexion.CerrarConexionDB)
                {

                }
            }





        }
        private void LeerArticulos_list()
        {
            // ClsConexionDb NuevaConexion = new ClsConexionDb("");

        }


        private void ActualizarClientes_DB()
        {
            if (File.Exists(ClasDatos.RutaBaseDatosDb))

            {
                String TipoTabla = "[" + this.SerieClientesText2.Text + "]";
                String consulta = "Select * from " + TipoTabla;
                String cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ClasDatos.RutaBaseDatosDb;
                ClsConexionDb.CadenaConexion = cadena;
                ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
                try
                {

                    if (NuevaConexion.SiConexionDb)
                    {
                        OleDbDataAdapter AdactaPelos = new OleDbDataAdapter(consulta, ClsConexionDb.CadenaConexion);
                        AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsClientes.DtClientes);

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "ERROR");
                }
                finally
                {
                    if (NuevaConexion.CerrarConexionDB)
                    {

                    }
                }
                //  this.ContadorDatosClientes.Text = this.dtArticulosBindingSource.Count.ToString();
            }
        }
        private void ActualizarClientes_Sql_B()
        {
            FormMenuPrincipal.menu2principal.dsClientes.DtClientes.Clear();
            string consulta = "SELECT* from [" + this.SerieClientesText2.Text + "]";
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);

            try
            {
                if (NuevaConexion.SiConexionSql)
                {

                    SqlDataAdapter AdactaPelos = new SqlDataAdapter(consulta, ClsConexionSql.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsClientes.DtClientes);
                    if (NuevaConexion.CerrarConexionSql)
                    {

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR");
            }
            finally

            {
                if (NuevaConexion.CerrarConexionSql)
                {

                }

            }
        }




        private void CheckAtivarServidor_Click(object sender, EventArgs e)
        {
            BORRARerror_Archivos();
            if (VALIDARcampos_SQL())
            {
                if (ClsConexionSql.CadenaConexion == string.Empty)
                {
                    MessageBox.Show("Debe De Guardar Configuracion Primero", "Sql Server", MessageBoxButtons.OK);
                    return;
                }
                this.CheckActivarDb.Checked = false;
                if (this.CheckAtivarServidor.Checked == false)
                {

                    this.CheckAtivarServidor.Checked = true;
                    ClsConexionSql.SibaseDatosSql = true;
                    MessageBox.Show("Activo Conexion Base Datos ((servidor ))", "Sql Server", MessageBoxButtons.OK);
                    this.PictureArchivo.Image = Properties.Resources.CIRCULO_ROJO1;
                    this.PictureServidor.Image = Properties.Resources.CIRCULO_VERDE1_;
                }
            }
        }


        private void BtnPobarSql_Click(object sender, EventArgs e)
        {
            ////Data Source=(LOCALDB)\VICTOR;Initial Catalog=PRUEBA;User ID=SA;Password=ASDF


            string CadenaConexion = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password{3}; ", this.Servidor.Text, this.BaseDatos.Text, this.UsuarioSql.Text, this.ContraseñaSql.Text);
            if (this.Autenticacion.SelectedIndex == 0)
            {
                CadenaConexion = string.Format("Data Source={0};Initial Catalog={1}; ", this.Servidor.Text, this.BaseDatos.Text) + ";Integrated Security = True";
            }
            else
            {
                if (this.ContraseñaSql.Text == string.Empty & this.UsuarioSql.Text == string.Empty)
                {
                    MessageBox.Show("Falta Usuario O Contraseña", "FALTAN DATOS");
                    return;
                }
            }
            using (SqlConnection ConectarPrueba = new SqlConnection(CadenaConexion))
            {
                try
                {
                    if (ConectarPrueba.State == ConnectionState.Closed)
                    {
                        ConectarPrueba.Open();
                        MessageBox.Show("Se conecto Con Exito", this.BaseDatos.Text);

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "ERROR");
                }
            }



        }

        private void Servidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Servidor.Refresh();
            if (this.Servidor.Tag.ToString() == "PARAR")
            {
                return;
            }

            string Cadena2 = "master";

            if (this.Servidor.Text != string.Empty)
            {
                this.InfoProcesoText2.BackColor = Color.FromArgb(234, 210, 8);
                this.InfoProcesoText2.Text = " Buscando Servidor: " + this.Servidor.Text + " .............. .......Espere Un Momento !!!!!!!";
                this.InfoProcesoText2.Refresh();
                string cadenaConexion = "Data Source=" + this.Servidor.Text + ";Initial Catalog=" + Cadena2 + ";Integrated Security=True";
                try
                {
                    using (SqlConnection NuevaConexion = new SqlConnection(cadenaConexion))
                    {
                        using (SqlCommand comando = new SqlCommand("Select Name From sysdatabases;", NuevaConexion))
                        {
                            NuevaConexion.Open();
                            using (SqlDataReader rd = comando.ExecuteReader())
                            {
                                this.BaseDatos.Items.Clear();
                                this.ListaBaseDatos2.Items.Clear();
                                while (rd.Read() == true)
                                {
                                    // Servidor.Items.Add(rd[1]);
                                    this.ListaBaseDatos2.Items.Add(rd[0]);
                                    this.BaseDatos.Items.Add(rd[0]);
                                }
                                BuscarServidor();
                            }

                        }

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    this.InfoProcesoText2.BackColor = this.BackColor;
                    this.InfoProcesoText2.Text = "Selecione Servidor a Buscar";
                    this.InfoProcesoText2.Refresh();
                }
            }
        }
        private void BuscarServidor()
        {
            try
            {
                int TotalServidores = this.Servidor.Items.Count;
                this.Servidor.Tag = "PARAR";
                bool SiExisteServidor = true;

                for (int i = 0; i < TotalServidores; i++)
                {

                    if (FormMenuPrincipal.menu2principal.dsServidor.Tables["DtServidor"].Rows[i]["Servidores"].ToString().Equals(this.Servidor.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        SiExisteServidor = false;
                    }

                }
                if (SiExisteServidor)
                {

                    if (!string.IsNullOrEmpty(this.Servidor.Text))
                    {
                        FormMenuPrincipal.menu2principal.dsServidor.DtServidor.Rows.Add(this.Servidor.Text);
                        Validate();
                        if (File.Exists(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + "Servidores.Xml"))
                        {
                            FormMenuPrincipal.menu2principal.dsServidor.WriteXml(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + "Servidores.Xml");

                        }
                        else
                        {
                            MessageBox.Show("Archivo No Existe" + "\n" + Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + "Servidores.Xml", "ARCHIVO NO EXISTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                this.Servidor.Tag = "SEGUIR";
            }
        }
        private void Autenticacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Autenticacion.SelectedIndex == 0)
            {
                this.UsuarioSql.Text = string.Format(@"{0}\" + Environment.UserName, Environment.MachineName);
                this.panelSql1.Enabled = false;
            }
            else
            {
                this.UsuarioSql.Text = string.Empty;
                this.panelSql1.Enabled = true;
            }
        }

        private void checkPass_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkPass.Checked == true)
            {
                this.checkPass.Text = "Ocultar";
                this.ContraseñaSql.PasswordChar = '\0';
            }
            else
            {
                this.checkPass.Text = "Mostrar";
                this.ContraseñaSql.PasswordChar = '*';

            }
        }

        private void ActualizarServidores_Click(object sender, EventArgs e)
        {
            string Cadena2 = "master";

            string cadenaConexion = "Data Source=" + this.Servidor.Text + ";Initial Catalog=" + Cadena2 + ";Integrated Security=True";
            // SqlClientFactory Fatory = SqlClientFactory.Instance;

            try
            {
                using (SqlConnection NuevaConexion = new SqlConnection(cadenaConexion))
                {
                    using (SqlCommand comando = new SqlCommand("Select srvname From sysservers;", NuevaConexion))
                    {
                        NuevaConexion.Open();
                        using (SqlDataReader rd = comando.ExecuteReader())
                        {
                            // this.Servidor.Items.Clear();
                            while (rd.Read() == true)
                            {
                                this.ListaBaseDatos2.Items.Add(rd[0]);
                                this.Servidor.Items.Add(rd[0]);
                            }
                        }

                    }

                    string instanceName = "";
                    string serverName = "";
                    SqlDataSourceEnumerator servidores = SqlDataSourceEnumerator.Instance;
                    SqlClientFactory Servidores2 = SqlClientFactory.Instance;
                    DataTable tablaServidores = servidores.GetDataSources();
                    foreach (DataRow row in tablaServidores.Rows)
                    {
                        instanceName = Convert.ToString(row[0]);
                        serverName = Convert.ToString(row[1]);

                        if (instanceName.ToString() == string.Empty && instanceName.ToString() == null)
                        {
                            this.Servidor.Items.Add(serverName);
                        }
                        else
                        {
                            this.Servidor.Items.Add(string.Format("{0}--{1}", serverName, instanceName));
                        }
                    }
                    // this.panelSql1.Tag = "NO";

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void CheckActivarDb_Click(object sender, EventArgs e)
        {
            BORRARerror_Archivos();
            if (ClsConexionDb.CadenaConexion != string.Empty)
            {
                if (VALIDARcampos_Archivos())
                {
                    this.PictureArchivo.Image = Properties.Resources.CIRCULO_VERDE1_;
                    this.PictureServidor.Image = Properties.Resources.CIRCULO_ROJO1;
                    this.CheckAtivarServidor.Checked = false;
                    if (this.CheckActivarDb.Checked == false)
                    {

                        this.CheckActivarDb.Checked = true;
                        ClsConexionSql.SibaseDatosSql = false;

                    }
                }
            }

        }

        private void Servidor_Validated(object sender, EventArgs e)
        {

        }

        private void BtnBuscarServidor_Click(object sender, EventArgs e)
        {
            string Cadena2 = "master";
            if (this.Servidor.Text != string.Empty)
            {
                this.InfoProcesoText2.BackColor = Color.FromArgb(234, 210, 8);
                this.InfoProcesoText2.Text = " Buscando Servidor: " + this.Servidor.Text + " .............. .......Espere Un Momento !!!!!!!";
                this.InfoProcesoText2.Refresh();
                string cadenaConexion = "Data Source=" + this.Servidor.Text + ";Initial Catalog=" + Cadena2 + ";Integrated Security=True";
                try
                {
                    using (SqlConnection NuevaConexion = new SqlConnection(cadenaConexion))
                    {
                        using (SqlCommand comando = new SqlCommand("Select Name From sysdatabases;", NuevaConexion))
                        {
                            NuevaConexion.Open();
                            using (SqlDataReader rd = comando.ExecuteReader())
                            {
                                this.BaseDatos.Items.Clear();
                                this.ListaBaseDatos2.Items.Clear();
                                while (rd.Read() == true)
                                {
                                    // Servidor.Items.Add(rd[1]);
                                    this.ListaBaseDatos2.Items.Add(rd[0]);
                                    this.BaseDatos.Items.Add(rd[0]);
                                }
                                BuscarServidor();
                            }

                        }

                    }
                }
                catch (Exception ex)
                {

                    ex.Message.ToString();
                }
                finally
                {
                    this.InfoProcesoText2.BackColor = this.BackColor;
                    this.InfoProcesoText2.Text = "Selecione Servidor a Buscar";
                    this.InfoProcesoText2.Refresh();
                }
            }


        }

        private void idConexionConfiLabel_Click(object sender, EventArgs e)
        {

        }

        private void Servidor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                e.Handled = false;
            }
        }

        private void BaseDatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                e.Handled = false;
            }
        }

        private void ListaBaseDatos2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ListaBaseDatos2.SelectedIndex >= 0)
            {
                this.BaseDatos.Text = this.ListaBaseDatos2.SelectedItem.ToString();
            }
        }

        private void ListaBaseDatos2_Click(object sender, EventArgs e)
        {
            if (this.ListaBaseDatos2.SelectedIndex >= 0)
            {
                this.BaseDatos.Text = this.ListaBaseDatos2.SelectedItem.ToString();
            }
        }

        private void Servidor_Enter(object sender, EventArgs e)
        {
            this.Servidor.Tag = "SEGUIR";
        }

        private void CheckActivarDb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckAtivarServidor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SerieArticulosText_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardarDatosArchivos_Click(object sender, EventArgs e)
        {
            BORRARerror_Archivos();
            if (VALIDARcampos_Archivos())
            {
                if (MessageBox.Show("Desea Conectar Archivo Local" + "\n" + "Dbf - Mdb - Accdb  ", "GUARDAR", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    if (this.NombreArchivoDatos.Text.ToString() == "Datos App Peloscalvo")
                    {
                        ClasDatos.RutaBaseDatosDb = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + this.NombreArchivoDatos.Text + "." + this.TipoExtension_b.Text;

                    }
                    else
                    {
                        ClasDatos.RutaBaseDatosDb = this.NombreArchivoDatos.Text;
                    }

                    ClsConexionDb.CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ClasDatos.RutaBaseDatosDb;
                    // FormMenuPrincipal.menu2principal.dsCorreos.Clear();
                    FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Clear();
                    FormMenuPrincipal.menu2principal.dsMulti2.Clear();
                    // FormMenuPrincipal.menu2principal.dsMultidatos.Clear();
                    FormMenuPrincipal.menu2principal.dsClientes.DtClientes.Clear();
                    FormMenuPrincipal.menu2principal.articulos.DtArticulos.Clear();
                    ClassCorreosDB.dsCorreos.Clear();
                    FormMenuPrincipal.menu2principal.dsClientes.Clear();
                    if (File.Exists(ClasDatos.RutaBaseDatosDb))
                    {
                        ActualizarPrincipal_Db();
                        ActualizarArticulosDB();
                        ActualizarClientes_DB();
                    }
                    else
                    {
                        MessageBox.Show(ClasDatos.RutaBaseDatosDb, "ARCHIVO NO EXISTE", MessageBoxButtons.OK);
                    }
                    GuardarMultidatos();
                    // ClasCorreos.ListaCorreosCliente.lista.Add();               
                    FormMenuPrincipal.menu2principal.InfoArticulo.Text = this.SerieArticulosText.Text;
                    FormMenuPrincipal.menu2principal.InfoClientes.Text = this.SerieClientesText2.Text;
                    FormMenuPrincipal.menu2principal.InfoExtension.Text = this.TipoExtension_b.Text;
                    ClsConexionSql.SibaseDatosSql = false;
                    MessageBox.Show("Configuracion Guardarda Y Lista Para Usar", "GUARDAR CONFIGURACION", MessageBoxButtons.OK);
                    Contador();
                    CanbiarOjetos();

                }
            }

        }

        private void TipoExtension_b_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.NombreArchivoDatos.Text != string.Empty)
            {
                ObtenerTablasBb();
            }
        }

        private void SerieClientesText2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void BtnGuardarServidores_Click(object sender, EventArgs e)
        {
            if (this.BaseDatos.Text == "master" || this.BaseDatos.Text == "msdb" || this.BaseDatos.Text == "model" || this.BaseDatos.Text == "tempdb")
            {
                MessageBox.Show("Bases De Datos No Validas" + "\n" + "[master]" + "\n" + "[model]" + "\n" + "[msdb]" + "\n" + "[tempdb]", "SELECION NO VALIDA");
                return;

            }
            if (this.Servidor.Text != string.Empty && this.BaseDatos.Text != string.Empty)
            {
                // string cadenaConexion = "Data Source=.;Initial Catalog=" + "PaisDB" + ";Integrated Security=True";
                try
                {
                    string CadenaConexion = string.Format("Data Source={0};Initial Catalog ={1};User ID ={2}; Password{3}; ", this.Servidor.Text, this.BaseDatos.Text, this.UsuarioSql.Text, this.ContraseñaSql.Text);
                    if (this.Autenticacion.SelectedIndex == 0)
                    {
                        CadenaConexion = string.Format("Data Source={0};Initial Catalog ={1}; ", this.Servidor.Text, this.BaseDatos.Text) + ";Integrated Security = True";
                    }
                    this.Servidor.Tag = "PARAR";
                    String ServidorCrearNuevo2 = this.Servidor.Text;
                    ClsConexionSql.CadenaConexion = CadenaConexion;
                    int TotalServidores = this.Servidor.Items.Count;
                    for (int i = 0; i < TotalServidores; i++)
                    {
                        if (FormMenuPrincipal.menu2principal.dsServidor.Tables["DtServidor"].Rows[i]["Servidores"].ToString() != ServidorCrearNuevo2)
                        {

                            // dtServidorBindingSource.AddNew();
                            //Validate();
                            // this.dsServidor.Tables["DtServidor"].Rows[TotalServidores-1]["Servidores"] = ServidorCrearNuevo2;

                        }
                    }
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + "Servidores.Xml"))
                    {
                        if (FormMenuPrincipal.menu2principal.EspacioDiscosPrincipal(Directory.GetCurrentDirectory(), 20))
                        {
                            FormMenuPrincipal.menu2principal.dsServidor.WriteXml(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + "Servidores.Xml");


                        }

                    }
                    else
                    {
                        MessageBox.Show("Archivo No Existe" + "\n" + Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + "Servidores.Xml", "ARCHIVO NO EXISTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    ObtenerTablasSql();
                    MessageBox.Show("Configuracion Guardarda  ((( Debe Activar)))", "GUARDAR CONFIGURACION", MessageBoxButtons.OK);
                    this.TabArchivoSql.SelectedIndex = 1;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "ERROR CONFIGURACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            else
            {
                MessageBox.Show("Faltan Datos", "CAMPOS VACIOS", MessageBoxButtons.OK);
            }
            this.Servidor.Tag = "SEGUIR";
        }

        private void BtnGuardarArchivo_Sql_Click(object sender, EventArgs e)
        {
            if (ClsConexionSql.CadenaConexion == string.Empty)
            {
                MessageBox.Show("Debe De Guardar Configuracion Primero", "Sql Server", MessageBoxButtons.OK);
                return;
            }
            BORRARerror_Archivos();
            if (VALIDARcampos_SQL())
            {
                if (MessageBox.Show("Desea Conectar Archivo En Red" + "\n" + " ((( SERVIDOR ))) ", "GUARDAR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // AñadirDatos();
                    try
                    {
                        FormMenuPrincipal.menu2principal.dsClientes.DtClientes.Clear();
                        FormMenuPrincipal.menu2principal.articulos.DtArticulos.Clear();
                        FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Clear();
                        FormMenuPrincipal.menu2principal.dsMulti2.Clear();
                        ClassCorreosDB.dsCorreos.Clear();
                        FormMenuPrincipal.menu2principal.dsClientes.Clear();
                        ActualizarPrincipal_Sql();//EMPRESAS Y EJERCICIOS
                        ActualizarArticulosSql();
                        ActualizarClientes_Sql_B();
                        FormMenuPrincipal.menu2principal.InfoArticulo.Text = this.SerieArticulosText.Text;
                        FormMenuPrincipal.menu2principal.InfoClientes.Text = this.SerieClientesText2.Text;
                        FormMenuPrincipal.menu2principal.InfoExtension.Text = "SERVIDOR EN RED";
                        ClsConexionSql.SibaseDatosSql = true;
                        MessageBox.Show("Configuracion Guardarda Y Lista Para Usar", "GUARDAR CONFIGURACION", MessageBoxButtons.OK);
                        CanbiarOjetos();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message.ToString(), "ERROR CONFIGURACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    GuardarMultidatos();
                    Contador();
                    this.Servidor.Tag = "SEGUIR";
                }
            }
        }


        private void BtnExaminarB_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog BuscarArchivo = new OpenFileDialog();//Datos App Peloscalvo - copia.accdb
                BuscarArchivo.Title = "Buscar Archivo Datos App";
                BuscarArchivo.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                BuscarArchivo.Filter = BuscarArchivo.Filter = @"All Files|*.*|Text File (.txt)|*.txt|access File (.accdb ,.mdb)|*.accdb;*.mdb|PDF (.pdf)|*.pdf|Office Files|*.doc;*.xls;*.ppt|Spreadsheet (.xls ,.xlsx)|  *.xls ;*.xlsx|Presentation (.pptx ,.ppt)|*.pptx;*.ppt";
                string Extension = "";
                if (BuscarArchivo.ShowDialog() == DialogResult.OK)
                {
                    if (!String.IsNullOrEmpty(Path.GetExtension(BuscarArchivo.FileName.ToString())))
                    {
                        Extension = Path.GetExtension(BuscarArchivo.FileName.ToString());
                    }

                    if (Extension.ToLower().ToString().Equals(".accdb".ToString(), StringComparison.OrdinalIgnoreCase) & Extension.ToLower().ToString().Equals(".mdb".ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        FileInfo fi = new FileInfo(BuscarArchivo.FileName.ToString());
                        this.NombreArchivoDatos.Text = BuscarArchivo.FileName.ToString();
                        ClasDatos.RutaBaseDatosDb = Path.GetFullPath(BuscarArchivo.FileName.ToString());
                        FormMenuPrincipal.menu2principal.InfoCarpeta.Text = Path.GetDirectoryName(BuscarArchivo.FileName.ToString());
                        FormMenuPrincipal.menu2principal.InfoBaseDatos.Text = Path.GetFileName(BuscarArchivo.FileName.ToString());
                        FormMenuPrincipal.menu2principal.InfoCarpeta.Text = Path.GetDirectoryName(BuscarArchivo.FileName.ToString());
                        //this.TabArchivos.Tag = "SI";
                        this.NombreArchivoDatos.BackColor = Color.Bisque;
                    }
                    else
                    {
                        MessageBox.Show("Solo Archivos Con Extension (((accdb))) o (((mdb)))", "ARCHIVO NO VALIDO");
                    }
                }
            }
            catch (Exception ex)
            {
                if (this.NombreArchivoDatos.Text == "Datos App Peloscalvo")
                {
                    MessageBox.Show(ex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Puede Que este Artivo Sea el Correcto" + "\n" + ex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void BtnCrearTbArticulos_Click(object sender, EventArgs e)
        {
            if (this.NombreArchivoDatos.Text != "Datos App Peloscalvo")
            {
                MessageBox.Show("Este Tipo DE Archivo No Se Puede Crear", "CREAR", MessageBoxButtons.OK);
                return;
            }

            BORRARerror_Archivos();
            if (VALIDARcampos_Archivos())
            {
                if (this.TabArchivos.Tag.ToString() == "SI")
                {
                    ClasDatos.RutaBaseDatosDb = this.NombreArchivoDatos.Text;
                }
                else
                {
                    ClasDatos.RutaBaseDatosDb = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + this.NombreArchivoDatos.Text + "." + this.TipoExtension_b.Text;
                }
                if (MessageBox.Show("\n" + " Crear Tabla  " + this.SerieArticulosText.Text, " CREAR? ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    string TablaArticulos = this.SerieArticulosText.Text;
                    string ConsultaArticulos = "CREATE TABLE [" + TablaArticulos + "] ( [Id] INTEGER  primary key , [Referencia] varchar," +
                        "[Descripcci] varchar,[Coste] MONEY , [Ganancia] DECIMAL ,[Pvp1] MONEY ,[PvpIva] MONEY ," +
                        "[Pvp2Desc] DECIMAL ,[Pvp2] MONEY ,[CastyDesc] DECIMAL ,[Casty] MONEY ,[SuarezDesc] DECIMAL " +
                        ",[Suarez] MONEY ,[BenitoDesc] DECIMAL ,[Benito] MONEY ,[ValenteDesc] DECIMAL ,[Valente] MONEY" +
                        " ,[PlusDesc] DECIMAL ,[Plus] MONEY ,[UnidadPale] DECIMAL,[MinimosSto] DECIMAL ,[Stock] DECIMAL " +
                        ",[Familia] varchar ,[Fecha] DATETIME ,[BAJA] bit default 0  , [Fatu] bit  default 0 )";
                    ClsConexionDb.CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ClasDatos.RutaBaseDatosDb;
                    ClsConexionDb NuevaConexion2 = new ClsConexionDb(ConsultaArticulos);
                    try
                    {
                        if (NuevaConexion2.SiConexionDb)
                        {
                            NuevaConexion2.ComandoDb.ExecuteNonQuery();
                            MessageBox.Show("Creada Con exito" + "\n" + this.SerieArticulosText.Text, "CREAR TABLA", MessageBoxButtons.OK);
                        }

                    }
                    catch (Exception ex)
                    {


                        MessageBox.Show(ex.Message, "ERROR");
                    }
                    finally
                    {
                        if (NuevaConexion2.CerrarConexionDB)
                        {
                            NuevaConexion2.ComandoDb.Parameters.Clear();
                        }
                    }
                }
            }
        }

        private void BtnCrearTbCliente_Click(object sender, EventArgs e)
        {
            if (this.TipoExtension_b.Text == "DBF" & this.NombreArchivoDatos.Text != "Datos App Peloscalvo")
            {
                MessageBox.Show("Este Tipo DE Archivo No Se Puede Crear", "CREAR", MessageBoxButtons.OK);
                return;
            }
            BORRARerror_Archivos();
            if (VALIDARcampos_Archivos())
            {
                if (MessageBox.Show("\n" + " Crear Tabla  " + this.SerieClientesText2.Text, " CREAR? ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (this.TabArchivos.Tag.ToString() == "SI")
                    {
                        ClasDatos.RutaBaseDatosDb = this.NombreArchivoDatos.Text;
                    }
                    else
                    {
                        ClasDatos.RutaBaseDatosDb = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + this.NombreArchivoDatos.Text + "." + this.TipoExtension_b.Text;
                    }

                    // Random r = new Random();
                    //  int valor = r.Next(10, 90000000);
                    //  string TablaCliente = "Cliente+" + valor.ToString();

                    string ConsultaCliente = " CREATE TABLE [" + this.SerieClientesText2.Text + "]( [Id] INTEGER primary key ,[APODOCLIEN] varchar(255) ,[NOMBRECLIE] varchar(255) ,DIRECCIONC varchar(255)," +
               "[TELEFONOCL] varchar(30) ,[MOVILCLIEN] varchar(50) ,[CORREOCLIE] varchar(255) ,[DNICLIENTE] varchar(30) ,[LOCALIDADC] varchar(255) ," +
               "[CODIGOPOST] varchar(50) ,[PAISCLIENT] varchar(255) ,[FECHAALTAC] DATETIME ,[CALLECLIEN] varchar(255) ,[NUMEROCALL] varchar(40) ," +
               "[PROVINCIAC] varchar(100) ,[TARIFATIPO] varchar(50) ,[TIPODNI] varchar(50) ,[TIPOCLIENT] varchar(50) ,[DESCUENTOC] DECIMAL ," +
               "[NUMEROCUEN] varchar(100) ,[PORTES] varchar(100) ,[BANCOOFICI] varchar(100) ,[BANCOPROVI] varchar(100) ,[BANCODIREC] varchar(150) ," +
               "[BANCOLOCAL] varchar(100) ,[BANCOIBAN] varchar(100) ,[BANCOCODIG] varchar(100) ,[BANCOENTID] varchar(100) ,[BANCOOFIC2] varchar(100) ," +
               "[BANCODC] varchar(100) NULL,[BANCON_CUE] varchar(100) ,[BAJA] bit default 0 )";

                    ClsConexionDb.CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ClasDatos.RutaBaseDatosDb;
                    ClsConexionDb NuevaConexion2 = new ClsConexionDb(ConsultaCliente);
                    try
                    {


                        if (NuevaConexion2.SiConexionDb)
                        {

                            NuevaConexion2.ComandoDb.ExecuteNonQuery();
                            MessageBox.Show("Creada Con exito" + "\n" + this.SerieClientesText2.Text, "CREAR TABLA", MessageBoxButtons.OK);
                        }

                    }
                    catch (Exception ex)
                    {


                        MessageBox.Show(ex.Message, "ERROR");
                    }
                    finally
                    {
                        if (NuevaConexion2.CerrarConexionDB)
                        {
                            NuevaConexion2.ComandoDb.Parameters.Clear();
                        }
                    }


                }
            }
        }

        private void BtnRestablecer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Restaurar Conexiones y Activar Archivos locales", "CERRAR CONEXIONES Y RESTAURAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.NombreArchivoDatos.Text = "Datos App Peloscalvo";
                //  this.TabArchivos.Tag = "NO";
                this.NombreArchivoDatos.BackColor = SystemColors.Control;
                Conexiones.ClsConexionSql.SibaseDatosSql = false;
                this.PictureArchivo.Image = Properties.Resources.CIRCULO_ROJO1;
                this.PictureServidor.Image = Properties.Resources.CIRCULO_ROJO1;
                FormMenuPrincipal.menu2principal.Conectado.Image = Properties.Resources.CIRCULO_ROJO1;
                FormMenuPrincipal.menu2principal.InfoConectado.Text = "Desconectado";
                FormMenuPrincipal.menu2principal.InfoConectado.BackColor = Color.Goldenrod;
                this.CheckAtivarServidor.Checked = false;
                this.CheckActivarDb.Checked = false;
                ClassCorreosDB.dsCorreos.Clear();
                FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Clear();
                FormMenuPrincipal.menu2principal.dsClientes.DtClientes.Clear();
                FormMenuPrincipal.menu2principal.articulos.DtArticulos.Clear();
                this.ContadorFactu.Text = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfiguracionPrincipal.Count.ToString();
                this.ContadorArticulos.Text = FormMenuPrincipal.menu2principal.articulos.DtArticulos.Count.ToString();
                this.ContadorClientes.Text = FormMenuPrincipal.menu2principal.dsClientes.DtClientes.Count.ToString();
                ClasDatos.RutaBaseDatosDb = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + "Datos App Peloscalvo.accdb";
                MessageBox.Show("Se Restauro Con Exito " + "n/" + "Carge Otra vez los Datos", "RESTAURAR");
            }
        }

        private void BtnRestablecer_MouseEnter(object sender, EventArgs e)
        {
            this.Info_Res.Visible = true;
        }



        private void TabArchivos_MouseEnter(object sender, EventArgs e)
        {
            this.Info_Res.Visible = false;
        }

        private void TabArchivos_Click(object sender, EventArgs e)
        {

        }
        public List<string> ObtenerInstanciasSql()
        {
            string Cadena2 = "master";

            string cadenaConexion = "Data Source=" + this.Servidor.Text + ";Initial Catalog=" + Cadena2 + ";Integrated Security=True";
            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
            DataTable userTables = null;
            using (DbConnection connection = factory.CreateConnection())
            {
                try
                {
                    connection.ConnectionString = cadenaConexion;
                    string[] restrictions = new string[4];
                    restrictions[3] = "Instance";
                    connection.Open();
                    userTables = connection.GetSchema("Instance", restrictions);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            }
            //this.Servidor.Items.Clear();
            List<string> tableNames = new List<string>();
            try
            {
                for (int i = 0; i < userTables.Rows.Count; i++)
                {
                    this.Servidor.Items.Add(userTables.Rows[i][2].ToString());

                    tableNames.Add(userTables.Rows[i][2].ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            return tableNames;
        }
        private void BtnActualizar_Servidor_Click(object sender, EventArgs e)
        {
            ObtenerInstanciasSql();


        }

        private void Servidor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ////BuscarServidor();
        }
    }

}





