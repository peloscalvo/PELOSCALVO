using Comun;
using Conexiones;
using System;
using System.Data;
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
            if (this.TipoExtension_b.Text == string.Empty)
            {
                ok = false;
                this.ErrorVer.SetError(this.TipoExtension_b, " (( Elija Una Opcion ..))");
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
            if (FormMenuPrincipal.menu2principal.InfoExtension.Text != string.Empty)
            {
                if (FormMenuPrincipal.menu2principal.InfoExtension.Text == "SERVIDOR EN RED")
                {
                    this.TipoExtension_b.Text = string.Empty;
                }
                else
                {
                    this.TipoExtension_b.Text = FormMenuPrincipal.menu2principal.InfoExtension.Text;

                }

            }

            if (ClsConexionSql.CadenaConexion != string.Empty & ClsConexionDb.CadenaConexion != string.Empty)
            {

                if (ClsConexionSql.SibaseDatosSql)
                {
                    this.CheckAtivarServidor.Checked = true;
                    this.CheckActivarDb.Checked = false;
                    this.PictureArchivo.Image = Properties.Resources.CIRCULO_ROJO1;
                    this.PictureServidor.Image = Properties.Resources.CIRCULO_VERDE1_;
                }
                else
                {
                    this.CheckAtivarServidor.Checked = false;
                    this.CheckActivarDb.Checked = true;
                    this.PictureArchivo.Image = Properties.Resources.CIRCULO_VERDE1_;
                    this.PictureServidor.Image = Properties.Resources.CIRCULO_ROJO1;

                }
            }
        }
        private void Contador()
        {
            this.ContadorFactu.Text = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfiguracionPrincipal.Count.ToString();
            this.ContadorArticulos.Text = FormMenuPrincipal.menu2principal.articulos.DtArticulos.Count.ToString();
            this.ContadorClientes.Text = FormMenuPrincipal.menu2principal.dsClientes.DtClientes.Count.ToString();
        }
        private void AñadirDatos()
        {
            string nombreBasedatos = this.NombreArchivoDatos.Text;
            if (this.TipoExtension_b.Text == "DBF")
            {
                nombreBasedatos = "";
            }
            if (this.TabArchivos.Tag.ToString() == "SI")
            {
                ClasDatos.Clientes = this.NombreArchivoDatos.Text;
                ClasDatos.Articulos = this.NombreArchivoDatos.Text;
                ClasDatos.ArchivoInicioFacturas = this.NombreArchivoDatos.Text;
                ClasDatos.RutaEmpresas = this.NombreArchivoDatos.Text;
            }
            else
            {
                ClasDatos.RutaEmpresas = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" +nombreBasedatos + "." + this.TipoExtension_b.Text;
                ClasDatos.ArchivoInicioFacturas = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + nombreBasedatos + "." + this.TipoExtension_b.Text;
                ClasDatos.Clientes = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + nombreBasedatos + "." + this.TipoExtension_b.Text;
                ClasDatos.Articulos = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + nombreBasedatos + "." + this.TipoExtension_b.Text;
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
            string consulta2 = "SELECT * from [DtConfi]";
            string consulta3 = "SELECT * from[DtTarifaTipo]";
            string ConsultaAlmacenes = "SELECT * from [DtAlmacenes]";
            string ConsultaProveedores = "SELECT * from [DtProveedores]";
            ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
            NuevaConexion = new ClsConexionDb(consulta);

            try
            {
                if (NuevaConexion.SiConexionDb)
                {

                    OleDbDataAdapter AdactaPelos = new OleDbDataAdapter(consulta, ClsConexionDb.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfiguracionPrincipal);
                    AdactaPelos = new OleDbDataAdapter(consulta2, ClsConexionDb.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfi);
                    AdactaPelos = new OleDbDataAdapter(consulta3, ClsConexionDb.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtTarifaTipo);
                    AdactaPelos = new OleDbDataAdapter(ConsultaAlmacenes, ClsConexionDb.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtAlmacenes);
                    AdactaPelos = new OleDbDataAdapter(ConsultaProveedores, ClsConexionDb.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtProveedores);
                    AdactaPelos.Dispose();

                    this.ContadorFactu.Text = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfiguracionPrincipal.Count.ToString();

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
        private void ActualizarPrincipal_Sql()
        {

            string consulta = "SELECT * from [DtConfiguracionPrincipal]  ";
            string consulta2 = "SELECT * from [DtConfi]";
            string consulta3 = "SELECT * from[DtTarifaTipo]";
            string ConsultaAlmacenes = "SELECT * from [DtAlmacenes]";
            string ConsultaProveedores = "SELECT * from [DtProveedores]";
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            NuevaConexion = new ClsConexionSql(consulta);

            try
            {
                if (NuevaConexion.SiConexionSql)
                {

                    SqlDataAdapter AdactaPelos = new SqlDataAdapter(consulta, ClsConexionSql.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfiguracionPrincipal);
                    AdactaPelos = new SqlDataAdapter(consulta2, ClsConexionSql.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfi);
                    AdactaPelos = new SqlDataAdapter(consulta3, ClsConexionSql.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtTarifaTipo);
                    AdactaPelos = new SqlDataAdapter(ConsultaAlmacenes, ClsConexionSql.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtAlmacenes);
                    AdactaPelos = new SqlDataAdapter(ConsultaProveedores, ClsConexionSql.CadenaConexion);
                    AdactaPelos.Fill(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtProveedores);
                    AdactaPelos.Dispose();

                    this.ContadorFactu.Text = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfiguracionPrincipal.Count.ToString();

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
        private void ActualizarArticulosSql()
        {
            if (FormMenuPrincipal.menu2principal.articulos.DtArticulos.Rows.Count <= 0)
            {

                string consulta = "SELECT * from [" + this.SerieArticulosText.Text + " De Articulos]";
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
            String TipoTabla = "[" + this.SerieArticulosText.Text + " De Articulos" + "]";
            string consulta = "";
            string cadena = "";
            if (this.TipoExtension_b.Text == "accdb")
            {

                consulta = "Select * from " + TipoTabla;
                cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ClasDatos.Articulos;
            }
            if (this.TipoExtension_b.Text == "mdb")
            {
                consulta = "Select * from " + TipoTabla;
                cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ClasDatos.Articulos;
            }
            if (this.TipoExtension_b.Text == "DBF")
            {
                consulta = "Select * from " + this.SerieArticulosText.Text;
                //consulta = "Select * from " + "Tarifa1dea";
                cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + ";Extended Properties=dBASE IV;";
            }
            ClsConexionDb.CadenaConexion = cadena;
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


                            // item.IdFILA = Convert.ToInt32(reader["IdFILA"]);
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
        private void FormBaseDatos_Load(object sender, EventArgs e)
        {
            if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION != null)
            {

                this.dtConfiguracionPrincipalBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION;
            }
            string Rutacorreos = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + "correos.Xml";
            if (File.Exists(Rutacorreos))
            {
                FormMenuPrincipal.menu2principal.dsCorreos.ReadXml(Rutacorreos);
            }
            if (!File.Exists(ClasDatos.RutaMultidatos))
            {
                MessageBox.Show("Falta Archivo " + "\n" + ClasDatos.RutaMultidatos, "ARCHIVO NO EXISTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.BtnBuscarServidor.Enabled = false;
                this.BtnGuardarDatosArchivos.Enabled = false;
                return;
            }
            if (FormMenuPrincipal.menu2principal.dsServidor != null)
            {
                this.dtServidorBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsServidor;
            }
            if (!ClsConexionSql.SibaseDatosSql == false)
            {
                if (!File.Exists(ClasDatos.RutaEmpresas))
                {
                    MessageBox.Show("Falta Archivo " + "\n" + ClasDatos.RutaEmpresas, "ARCHIVO NO EXISTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

            if (FormMenuPrincipal.menu2principal.dsMultidatos.DtInicioMulti.Count > 0)
            {

            }
            if (FormMenuPrincipal.menu2principal.InfoArticulo.Text != string.Empty)
            {
                this.SerieArticulosText.Text = FormMenuPrincipal.menu2principal.InfoArticulo.Text;
            }
            if (FormMenuPrincipal.menu2principal.InfoClientes.Text != string.Empty)
            {
                this.SerieClientesText2.Text = FormMenuPrincipal.menu2principal.InfoClientes.Text;
            }


            try
            {
                int TTempresas = FormMenuPrincipal.menu2principal.dtConfiguracionPrincipalBindingSource.Count - 1;
                if (TTempresas >= 0)
                {
                    String variable1 = " De Articulos";
                    string VariableCliente = " De Clientes";
                    if (FormMenuPrincipal.menu2principal.InfoExtension.Text == "DBF")
                    {
                        variable1 = "";
                    }
                    string Ruta;
                    string RutaCliente;
                    string Archivo;
                    for (int bn = 0; bn <= TTempresas; bn++)
                    {
                        if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtConfiguracionPrincipal"].Rows[bn]["EmpresaConfi"].ToString() != null)
                        {
                            Archivo = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtConfiguracionPrincipal"].Rows[bn]["EmpresaConfi"].ToString();
                            Ruta = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + Archivo + variable1 + "." + FormMenuPrincipal.menu2principal.InfoExtension.Text;
                            RutaCliente = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + Archivo + VariableCliente + "." + FormMenuPrincipal.menu2principal.InfoExtension.Text;
                            if (File.Exists(Ruta))
                            {
                                this.SerieArticulosText.Items.Add(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtConfiguracionPrincipal"].Rows[bn]["EmpresaConfi"].ToString());
                            }
                            if (File.Exists(RutaCliente))
                            {
                                this.SerieClientesText2.Items.Add(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtConfiguracionPrincipal"].Rows[bn]["EmpresaConfi"].ToString());
                            }

                        }
                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR CARGAR COMBOVOX");
            }
            try
            {
                if (this.Servidor.Items.Count < 4)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        this.dtServidorBindingSource.AddNew();

                        // this.dsServidor.Tables["DtServidor"].Rows[0]["Servidores"] = ".";
                    }
                    Validate();
                    FormMenuPrincipal.menu2principal.dsServidor.Tables["DtServidor"].Rows[0]["Servidores"] = ".";
                    FormMenuPrincipal.menu2principal.dsServidor.Tables["DtServidor"].Rows[1]["Servidores"] = "(Local)";
                    FormMenuPrincipal.menu2principal.dsServidor.Tables["DtServidor"].Rows[2]["Servidores"] = "(localdb)\\MSSQLLocalDB";
                    FormMenuPrincipal.menu2principal.dsServidor.Tables["DtServidor"].Rows[3]["Servidores"] = "(localdb)\\SQLVICTOR";
                    FormMenuPrincipal.menu2principal.dsServidor.Tables["DtServidor"].Rows[4]["Servidores"] = @".\SQLEXPRESS";
                    FormMenuPrincipal.menu2principal.dsServidor.Tables["DtServidor"].Rows[5]["Servidores"] = string.Format(@"{0}\SQLEXPRESS", Environment.MachineName);
                    FormMenuPrincipal.menu2principal.dsServidor.WriteXml(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + "Servidores.Xml");
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

        private void ActualizarClientes_DB()
        {
            String NombreBaseDatos = this.NombreArchivoDatos.Text;
            if (this.TipoExtension_b.Text == "DBF")
            {
                NombreBaseDatos = "";
            }

            if (File.Exists(ClasDatos.Clientes))

            {
                String TipoTabla = "[" + this.SerieClientesText2.Text + " De Clientes" + "]";
                string consulta = "";
                string cadena = "";
                String Archivo = this.SerieClientesText2.Text;
                if (this.TipoExtension_b.Text == "accdb")
                {
                    consulta = "Select * from " + TipoTabla;
                    cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ClasDatos.Clientes;
                }
                if (this.TipoExtension_b.Text == "mdb")
                {
                    consulta = "Select * from " + TipoTabla;
                    cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ClasDatos.Clientes;
                }
                if (this.TipoExtension_b.Text == "DBF")
                {
                    consulta = "Select * from " + this.SerieClientesText2.Text;
                    //consulta = "Select * from " + "Tarifa1dea";
                    cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + ";Extended Properties=dBASE IV;";
                }
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
            string consulta = "SELECT* from [" + this.SerieClientesText2.Text + " De Clientes]";
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
                String ServidorCrearNuevo = this.Servidor.Text;
                bool SiExisteServidor = true;
                for (int i = 0; i < TotalServidores; i++)
                {

                    if (FormMenuPrincipal.menu2principal.dsServidor.Tables["DtServidor"].Rows[i]["Servidores"].ToString().Equals(ServidorCrearNuevo, StringComparison.OrdinalIgnoreCase))
                    {
                        SiExisteServidor = false;
                    }

                }
                if (SiExisteServidor)
                {
                    string ServidorAnalizar = "";
                    if (this.Servidor.Text != string.Empty)
                    {
                        ServidorAnalizar = this.Servidor.Text;
                    }
                    this.dtServidorBindingSource.AddNew();
                    if (ServidorAnalizar != string.Empty)
                    {
                        this.Servidor.Text = ServidorAnalizar;
                        this.dtServidorBindingSource.EndEdit();
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
                        instanceName = Convert.ToString(row["InstanceName"]);
                        serverName = Convert.ToString(row["ServerName"]);

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
                    AñadirDatos(); 
                    if (this.TipoExtension_b.Text == "DBF")
                    {
                        if (!File.Exists(ClasDatos.Articulos))
                        {


                            if (MessageBox.Show(this.SerieArticulosText.Text + this.TipoExtension_b.Text + "\n" + " Archivo No Existe  ", " CREAR NUEVO ? ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                if (this.SerieArticulosText.SelectedIndex > 5)
                                {
                                    if (this.TipoExtension_b.Text == "DBF")
                                    {
                                        MessageBox.Show("Este Tipo DE Archivo No Se Puede Crear", "CREAR", MessageBoxButtons.OK);
                                        return;
                                    }
                                }
                                ClasDatos.QUEform = "BASE_DATOS_CLIENTES";
                                FormCrearArchivos frm = new FormCrearArchivos();
                                frm.ShowDialog();

                            }

                        }
                        if (!File.Exists(ClasDatos.Clientes))
                        {
                            if (MessageBox.Show(this.SerieClientesText2.Text + this.TipoExtension_b.Text + "\n" + " Archivo No Existe  ", " CREAR NUEVO ? ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                if (this.SerieArticulosText.SelectedIndex > 5)
                                {
                                    if (this.TipoExtension_b.Text == "DBF")
                                    {
                                        MessageBox.Show("Este Tipo DE Archivo No Se Puede Crear", "CREAR", MessageBoxButtons.OK);
                                        return;
                                    }
                                }
                                ClasDatos.QUEform = "BASE_DATOS_CLIENTES";
                                FormCrearArchivos frm = new FormCrearArchivos();
                                frm.ShowDialog();

                            }
                            return;
                        }
                    }
                    FormMenuPrincipal.menu2principal.dsCorreos.Clear();
                    FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Clear();
                    FormMenuPrincipal.menu2principal.dsClientes.DtClientes.Clear();
                    FormMenuPrincipal.menu2principal.articulos.DtArticulos.Clear();

                    if (File.Exists(ClasDatos.RutaEmpresas))
                    {
                        // FormMenuPrincipal.menu2principal.dsCONFIGURACCION.ReadXml(ClasDatos.RutaConfiguracionXml);
                    }
                    if (File.Exists(ClasDatos.ArchivoInicioFacturas))
                    {
                        ActualizarPrincipal_Db();

                    }
                    else
                    {
                        MessageBox.Show(ClasDatos.ArchivoInicioFacturas, "ARCHIVO NO EXISTE", MessageBoxButtons.OK);
                    }
                    if (File.Exists(ClasDatos.Articulos))
                    {
                        ActualizarArticulosDB();
                    }
                    else
                    {
                        MessageBox.Show(ClasDatos.Articulos, "ARCHIVO NO EXISTE", MessageBoxButtons.OK);
                    }
                    if (File.Exists(ClasDatos.Clientes))
                    {
                        ActualizarClientes_DB();
                    }
                    else
                    {
                        MessageBox.Show(ClasDatos.Clientes, "ARCHIVO NO EXISTE", MessageBoxButtons.OK);
                    }
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
            ClasDatos.Clientes = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + this.SerieClientesText2.Text + "." + this.TipoExtension_b.Text;

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
                        if (FormMenuPrincipal.menu2principal.EspacioDiscosPrincipal(ClasDatos.RutaMulti2, 20))
                        {
                            FormMenuPrincipal.menu2principal.dsServidor.WriteXml(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + "Servidores.Xml");


                        }

                    }
                    else
                    {
                        MessageBox.Show("Archivo No Existe" + "\n" + Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + "Servidores.Xml", "ARCHIVO NO EXISTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
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
                        FormMenuPrincipal.menu2principal.dsCorreos.Clear();
                        FormMenuPrincipal.menu2principal.dsClientes.DtClientes.Clear();
                        FormMenuPrincipal.menu2principal.articulos.DtArticulos.Clear();
                        FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Clear();
                        ActualizarPrincipal_Sql();//EMPRESAS Y EJERCICIOS
                        ActualizarArticulosSql();
                        ActualizarClientes_Sql_B();
                        string Rutacorreos = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + "correos.Xml";
                        if (File.Exists(Rutacorreos))
                        {
                            FormMenuPrincipal.menu2principal.dsCorreos.ReadXml(Rutacorreos);
                        }
                        FormMenuPrincipal.menu2principal.InfoArticulo.Text = this.SerieArticulosText.Text;
                        FormMenuPrincipal.menu2principal.InfoClientes.Text = this.SerieClientesText2.Text;
                        FormMenuPrincipal.menu2principal.InfoExtension.Text = "SERVIDOR EN RED";
                        String variableArticulo = " De Articulos";
                        String variableCliente = " De Clientes";
                        if (this.TipoExtension_b.Text == "DBF")
                        {
                            variableArticulo = "";
                            variableCliente = "";
                        }
                        if (this.SerieArticulosText.Text != string.Empty && this.SerieArticulosText.Text != string.Empty)
                        {
                            ClasDatos.Articulos = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + this.SerieArticulosText.Text + variableArticulo + "." + this.TipoExtension_b.Text;
                            ClasDatos.Clientes = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + this.SerieClientesText2.Text + variableCliente + "." + this.TipoExtension_b.Text;

                        }
                        ClsConexionSql.SibaseDatosSql = true;
                        MessageBox.Show("Configuracion Guardarda Y Lista Para Usar", "GUARDAR CONFIGURACION", MessageBoxButtons.OK);

                        CanbiarOjetos();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message.ToString(), "ERROR CONFIGURACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Contador();
                    this.Servidor.Tag = "SEGUIR";
                }
            }
        }

        private void BtnPrueba_Click(object sender, EventArgs e)
        {
            //////    prueba prueba
            if (VALIDARcampos_Archivos())
            {
                string cadena = "";
                if (this.TipoExtension_b.Text == "accdb")
                {
                    cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ClasDatos.Articulos;
                }
                if (this.TipoExtension_b.Text == "mdb")
                {

                    cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ClasDatos.Articulos;
                }
                if (this.TipoExtension_b.Text == "DBF")
                {
                    //consulta = "Select * from " + "Tarifa1dea";
                    cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + ";Extended Properties=dBASE IV;";
                }
                string TipoNota = "DtNuevaTotaldatos";
                if (ClasDatos.NombreFactura != string.Empty)
                {
                    TipoNota = "Dt" + ClasDatos.NombreFactura;
                }
                Random r = new Random();
                int valor = r.Next(10, 90000000);
                string TablaArticulos = "lISTAdeARTICULOS+" + valor.ToString();
                string ConsultaArticulos = "CREATE TABLE [" + TablaArticulos + valor + "] ([Id] INTEGER  primary key , [Referencia] varchar," +
                    "[Descripcci] varchar,[Coste] MONEY , [Ganancia] DECIMAL ,[Pvp1] MONEY ,[PvpIva] MONEY ," +
                    "[Pvp2Desc] DECIMAL ,[Pvp2] MONEY ,[CastyDesc] DECIMAL ,[Casty] MONEY ,[SuarezDesc] DECIMAL " +
                    ",[Suarez] MONEY ,[BenitoDesc] DECIMAL ,[Benito] MONEY ,[ValenteDesc] DECIMAL ,[Valente] MONEY" +
                    " ,[PlusDesc] DECIMAL ,[Plus] MONEY ,[UnidadPale] DECIMAL,[MinimosSto] DECIMAL ,[Stock] DECIMAL " +
                    ",[Familia] varchar ,[Fecha] DATETIME ,[BAJA] bit default 0  , [Fatu] bit  default 0 )";
                string ConsultaFacturacion = "CREATE TABLE [" + TipoNota + valor + "] ([EnlaceFactura] varchar primary key , [NumeroFactura] INTEGER ,[Apodo] varchar ,[Nombre] varchar," +
               "[Direccion] varchar,[Calle] varchar,[NumeroCalle] varchar,[Dni] varchar,[Localidad] varchar," +
                 "[Provincia] varchar,[CodigoPostal] varchar,[NonbreAlmacen] varchar,[FechaFactura] varchar," +
               "[IvaImpuesto] INTEGER,[SubTotal] DECIMAL,[BaseIva] DECIMAL,[TotalFactura] DECIMAL,[CobradaFactura] varchar," +
             "[FechaCobro] varchar,[Pais_Fact] varchar,[TotalFactura2] DECIMAL,[TipoNOTA] varchar,[Obra_factu] varchar," +
         "[EjercicioTipo] varchar,[SerieTipo] varchar, [EmpresaEnlace] varchar)";

                string ConsultaEmpresas = " CREATE TABLE [DtConfiguracionPrincipal" + valor + "] ([IdEmpresa] INTEGER , [EmpresaConfi] varchar , [NombreEmpresa] varchar  ," +
                "[DireccionEmpresa] varchar  ,[LocalidadEmpresa] varchar  ,[CodigoPostalEmpresa] varchar  ,[ProvinciaEmpresa] varchar ," +
              "[TelefonoEmpresa] varchar  ,[CorreoEmpresa] varchar  ,[WepEmpresa] varchar  ,[RegimenIvaEmpresa] varchar  ," +
            " [PaisEmpresa] varchar  ,[SerieDeFacturacionEmpresa] varchar  ,[Telefono2Empresa] varchar  ,[MovilEmpresa] varchar  ," +
            " [CifEmpresa] varchar  ,[NombreEmpresaReguistro] varchar primary key ,[ImagenEmpresa] IMAGE) ";

                string TablaDtconfi = "CREATE TABLE[DtConfi" + valor + "] ([ConfiguraccionBasica] varchar , [TipoInpuestoIVA] INTEGER, [EjerciciosDeAño] varchar  ," +
                    "[EmpresaENLACE] varchar ,[IdConexionConfi] INTEGER , [AñoDeEjercicio] varchar  ," +
                       " CONSTRAINT FK_DTCONFI" + valor + " FOREIGN KEY(EmpresaENLACE)REFERENCES DtConfiguracionPrincipal" + valor + "(NombreEmpresaReguistro) ON UPDATE CASCADE ON DELETE CASCADE )";

                string ConsultaTablas = "CREATE TABLE [DtAlmacenes" + valor + "]( [Id_almacenes] INTEGER ,[Almacenes] varchar,[Enlace_Almacenes] varchar , " +
            " CONSTRAINT F_DtAlmacenes" + valor + " FOREIGN KEY(Enlace_Almacenes)REFERENCES DtConfiguracionPrincipal" + valor + "(NombreEmpresaReguistro) ON UPDATE CASCADE ON DELETE CASCADE )";


                ClsConexionDb.CadenaConexion = cadena;
                ClsConexionDb NuevaConexion2 = new ClsConexionDb(ConsultaArticulos);
                ClsConexionDb.CadenaConexion = cadena;
                try
                {


                    if (NuevaConexion2.SiConexionDb)
                    {

                        NuevaConexion2.ComandoDb.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {


                    MessageBox.Show(ex.Message, "ERROR" + TablaArticulos);
                }
                try
                {
                    NuevaConexion2 = new ClsConexionDb(ConsultaFacturacion);
                    if (NuevaConexion2.SiConexionDb)
                    {

                        NuevaConexion2.ComandoDb.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {


                    MessageBox.Show(ex.Message, "ERROR" + TipoNota);
                }
                try
                {
                    NuevaConexion2 = new ClsConexionDb(ConsultaEmpresas);
                    if (NuevaConexion2.SiConexionDb)
                    {

                        NuevaConexion2.ComandoDb.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {


                    MessageBox.Show(ex.Message, "ERROR" + "EMPRESAS");
                }
                try
                {
                    NuevaConexion2 = new ClsConexionDb(TablaDtconfi);
                    if (NuevaConexion2.SiConexionDb)
                    {

                        NuevaConexion2.ComandoDb.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {


                    MessageBox.Show(ex.Message, "ERROR" + "DtConfi");
                }
                finally
                {
                    if (NuevaConexion2.CerrarConexionDB)
                    {

                        NuevaConexion2.ComandoDb.Parameters.Clear();

                    }
                }
                MessageBox.Show("Se Termino De crar Tablas");
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

                    if (Extension.ToString().Equals(".accdb".ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        FileInfo fi = new FileInfo(BuscarArchivo.FileName.ToString());
                        this.NombreArchivoDatos.Text = fi.Name;
                        ClasDatos.Clientes = Path.GetFullPath(BuscarArchivo.FileName.ToString());
                        ClasDatos.Articulos = Path.GetFullPath(BuscarArchivo.FileName.ToString());
                        this.TabArchivos.Tag = "SI";
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
                if (MessageBox.Show("\n" + " Crear Tabla  " + this.SerieArticulosText.Text, " CREAR? ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    if (this.TabArchivos.Tag.ToString() == "SI")
                    {
                        ClasDatos.Articulos = this.NombreArchivoDatos.Text;
                        ClasDatos.Clientes = this.NombreArchivoDatos.Text;
                    }
                    else
                    {
                        ClasDatos.Articulos = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + this.NombreArchivoDatos.Text + "." + this.TipoExtension_b.Text;
                        ClasDatos.Clientes = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + this.NombreArchivoDatos.Text + "." + this.TipoExtension_b.Text;
                    }
                    if (MessageBox.Show("\n" + " Crear Tabla  " + this.SerieArticulosText.Text, " CREAR? ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        string cadena = "";
                        if (this.TipoExtension_b.Text == "accdb")
                        {


                            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ClasDatos.Articulos;
                        }
                        if (this.TipoExtension_b.Text == "mdb")
                        {

                            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ClasDatos.Articulos;
                        }
                        if (this.TipoExtension_b.Text == "DBF")
                        {
                            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + ";Extended Properties=dBASE IV;";
                        }
                        Random r = new Random();
                        int valor = r.Next(10, 90000000);
                        string TablaArticulos = "Articulos+" + valor.ToString();
                        string ConsultaArticulos = "CREATE TABLE [" + TablaArticulos + "] ( [Id] INTEGER  primary key , [Referencia] varchar," +
                            "[Descripcci] varchar,[Coste] MONEY , [Ganancia] DECIMAL ,[Pvp1] MONEY ,[PvpIva] MONEY ," +
                            "[Pvp2Desc] DECIMAL ,[Pvp2] MONEY ,[CastyDesc] DECIMAL ,[Casty] MONEY ,[SuarezDesc] DECIMAL " +
                            ",[Suarez] MONEY ,[BenitoDesc] DECIMAL ,[Benito] MONEY ,[ValenteDesc] DECIMAL ,[Valente] MONEY" +
                            " ,[PlusDesc] DECIMAL ,[Plus] MONEY ,[UnidadPale] DECIMAL,[MinimosSto] DECIMAL ,[Stock] DECIMAL " +
                            ",[Familia] varchar ,[Fecha] DATETIME ,[BAJA] bit default 0  , [Fatu] bit  default 0 )";
                        ClsConexionDb.CadenaConexion = cadena;
                        ClsConexionDb NuevaConexion2 = new ClsConexionDb(ConsultaArticulos);
                        ClsConexionDb.CadenaConexion = cadena;
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
                if (MessageBox.Show("\n" + " Crear Tabla  " + this.SerieArticulosText.Text, " CREAR? ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (this.TabArchivos.Tag.ToString() == "SI")
                    {
                        ClasDatos.Articulos = this.NombreArchivoDatos.Text;
                        ClasDatos.Clientes = this.NombreArchivoDatos.Text;
                    }
                    else
                    {
                        ClasDatos.Articulos = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + this.NombreArchivoDatos.Text + "." + this.TipoExtension_b.Text;
                        ClasDatos.Clientes = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + this.NombreArchivoDatos.Text + "." + this.TipoExtension_b.Text;
                    }
                    string cadena = "";
                    if (this.TipoExtension_b.Text == "accdb")
                    {


                        cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ClasDatos.Clientes;
                    }
                    if (this.TipoExtension_b.Text == "mdb")
                    {

                        cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ClasDatos.Clientes;
                    }
                    if (this.TipoExtension_b.Text == "DBF")
                    {
                        cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + ";Extended Properties=dBASE IV;";
                    }
                    Random r = new Random();
                    int valor = r.Next(10, 90000000);
                    string TablaCliente = "Cliente+" + valor.ToString();
                    string ConsultaCliente = "CREATE TABLE [" + TablaCliente + "] ( [Id] INTEGER  primary key , [Referencia] varchar," +
                        "[Descripcci] varchar,[Coste] MONEY , [Ganancia] DECIMAL ,[Pvp1] MONEY ,[PvpIva] MONEY ," +
                        "[Pvp2Desc] DECIMAL ,[Pvp2] MONEY ,[CastyDesc] DECIMAL ,[Casty] MONEY ,[SuarezDesc] DECIMAL " +
                        ",[Suarez] MONEY ,[BenitoDesc] DECIMAL ,[Benito] MONEY ,[ValenteDesc] DECIMAL ,[Valente] MONEY" +
                        " ,[PlusDesc] DECIMAL ,[Plus] MONEY ,[UnidadPale] DECIMAL,[MinimosSto] DECIMAL ,[Stock] DECIMAL " +
                        ",[Familia] varchar ,[Fecha] DATETIME ,[BAJA] bit default 0  , [Fatu] bit  default 0 )";
                    ClsConexionDb.CadenaConexion = cadena;
                    ClsConexionDb NuevaConexion2 = new ClsConexionDb(ConsultaCliente);
                    ClsConexionDb.CadenaConexion = cadena;
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

        private void BtnRestablecer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Restaurar Conexiones y Activar Archivos locales", "CERRAR CONEXIONES Y RESTAURAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.NombreArchivoDatos.Text = "Datos App Peloscalvo";
                this.TabArchivos.Tag = "NO";
                this.NombreArchivoDatos.BackColor = SystemColors.Control;
                Conexiones.ClsConexionSql.SibaseDatosSql = false;
                this.PictureArchivo.Image = Properties.Resources.CIRCULO_ROJO1;
                this.PictureServidor.Image = Properties.Resources.CIRCULO_ROJO1;
                this.CheckAtivarServidor.Checked = false;
                this.CheckActivarDb.Checked = false;
                FormMenuPrincipal.menu2principal.dsCorreos.Clear();
                FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Clear();
                FormMenuPrincipal.menu2principal.dsClientes.DtClientes.Clear();
                FormMenuPrincipal.menu2principal.articulos.DtArticulos.Clear();
                this.ContadorFactu.Text = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfiguracionPrincipal.Count.ToString();
                this.ContadorArticulos.Text = FormMenuPrincipal.menu2principal.articulos.DtArticulos.Count.ToString();
                this.ContadorClientes.Text = FormMenuPrincipal.menu2principal.dsClientes.DtClientes.Count.ToString();
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

        private void BtnTablas_Click(object sender, EventArgs e)
        {
            //////    prueba prueba
            if (VALIDARcampos_Archivos())
            {
                string cadena = "";
                if (this.TipoExtension_b.Text == "accdb")
                {
                    cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ClasDatos.Articulos;
                }
                if (this.TipoExtension_b.Text == "mdb")
                {

                    cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ClasDatos.Articulos;
                }
                if (this.TipoExtension_b.Text == "DBF")
                {
                    //consulta = "Select * from " + "Tarifa1dea";
                    cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + ";Extended Properties=dBASE IV;";
                }
                string TipoNota = "DtNota";
                if (ClasDatos.NombreFactura != string.Empty)
                {
                    TipoNota = "Dt" + ClasDatos.NombreFactura;
                }
                Random r = new Random();
                int valor = r.Next(10, 90000000);
                string TablaArticulos = "Lista_de_articulos+" + valor.ToString();
                string ConsultaArticulos = "CREATE TABLE [" + TablaArticulos + "] ([Id] INTEGER  primary key , [Referencia] varchar," +
                    "[Descripcci] varchar,[Coste] MONEY , [Ganancia] DECIMAL ,[Pvp1] MONEY ,[PvpIva] MONEY ," +
                    "[Pvp2Desc] DECIMAL ,[Pvp2] MONEY ,[CastyDesc] DECIMAL ,[Casty] MONEY ,[SuarezDesc] DECIMAL " +
                    ",[Suarez] MONEY ,[BenitoDesc] DECIMAL ,[Benito] MONEY ,[ValenteDesc] DECIMAL ,[Valente] MONEY" +
                    " ,[PlusDesc] DECIMAL ,[Plus] MONEY ,[UnidadPale] DECIMAL,[MinimosSto] DECIMAL ,[Stock] DECIMAL " +
                    ",[Familia] varchar ,[Fecha] DATETIME ,[BAJA] bit default 0  , [Fatu] bit  default 0 )";
                string ConsultaFacturacion = "CREATE TABLE [" + TipoNota + "] ([EnlaceFactura] varchar primary key , [NumeroFactura] INTEGER ,[Apodo] varchar ,[Nombre] varchar," +
                  "[Direccion] varchar,[Calle] varchar,[NumeroCalle] varchar,[Dni] varchar,[Localidad] varchar," +
                 "[Provincia] varchar,[CodigoPostal] varchar,[NonbreAlmacen] varchar,[FechaFactura] varchar," +
                  "[IvaImpuesto] INTEGER,[SubTotal] DECIMAL,[BaseIva] DECIMAL,[TotalFactura] DECIMAL,[CobradaFactura] varchar," +
                  "[FechaCobro] varchar,[Pais_Fact] varchar,[TotalFactura2] DECIMAL,[TipoNOTA] varchar,[Obra_factu] varchar," +
                 "[EjercicioTipo] varchar,[SerieTipo] varchar, [EmpresaEnlace] varchar)";
                string Tabladetalle = "DtDetalles_Nota";
                string ConsultaDetalles = "CREATE TABLE [" + Tabladetalle + "]( [ReferenciaDetalle] varchar" +
                         ",[CantidadDetalle] DECIMAL,[DescripccionDetalle] varchar, [DescuentoDetalle] DECIMAL" +
                         ",[PrecioDetalle] DECIMAL,[IvaDetalle] DECIMAL,[ImporteDetalle] DECIMAL,[EnlaceDetalle] varchar" +
                         ", CONSTRAINT FK_" + Tabladetalle + " FOREIGN KEY (EnlaceDetalle)REFERENCES " + TipoNota + "(EnlaceFactura) ON UPDATE CASCADE ON DELETE CASCADE" + ")";

                string ConsultaEmpresas = " CREATE TABLE [DtConfiguracionPrincipal] ([IdEmpresa] INTEGER , [EmpresaConfi] varchar , [NombreEmpresa] varchar  ," +
                "[DireccionEmpresa] varchar  ,[LocalidadEmpresa] varchar  ,[CodigoPostalEmpresa] varchar  ,[ProvinciaEmpresa] varchar ," +
              "[TelefonoEmpresa] varchar  ,[CorreoEmpresa] varchar  ,[WepEmpresa] varchar  ,[RegimenIvaEmpresa] varchar  ," +
            " [PaisEmpresa] varchar  ,[SerieDeFacturacionEmpresa] varchar  ,[Telefono2Empresa] varchar  ,[MovilEmpresa] varchar  ," +
            " [CifEmpresa] varchar  ,[NombreEmpresaReguistro] varchar primary key ,[ImagenEmpresa] varchar ) ";

                string TablaDtconfi = "CREATE TABLE[DtConfi] ([ConfiguraccionBasica] varchar , [TipoInpuestoIVA] INTEGER, [EjerciciosDeAño] varchar  ," +
                    "[EmpresaENLACE] varchar ,[IdConexionConfi] INTEGER , [AñoDeEjercicio] varchar  ," +
                       " CONSTRAINT FK_DTCONFI" + valor + " FOREIGN KEY(EmpresaENLACE)REFERENCES DtConfiguracionPrincipal(NombreEmpresaReguistro) ON UPDATE CASCADE ON DELETE CASCADE )";

                string ConsultaTablas = "CREATE TABLE [DtAlmacenes]( [Id_almacenes] INTEGER ,[Almacenes] varchar,[Enlace_Almacenes] varchar , " +
                   " CONSTRAINT F_DtAlmacenes" + valor + " FOREIGN KEY(Enlace_Almacenes)REFERENCES DtConfiguracionPrincipal(NombreEmpresaReguistro) ON UPDATE CASCADE ON DELETE CASCADE )" +

                 "   CREATE TABLE [DtProveedores]( [Id_Proveedores] INTEGER,[Proveedores] varchar ,[Enlace_Proveedores] varchar, " +
                  " CONSTRAINT F_DtProveedores" + valor + " FOREIGN KEY(Enlace_Proveedores)REFERENCES DtConfiguracionPrincipal(NombreEmpresaReguistro) ON UPDATE CASCADE ON DELETE CASCADE )"; 


                ClsConexionDb.CadenaConexion = cadena;
                ClsConexionDb NuevaConexion2 = new ClsConexionDb(ConsultaArticulos);
                ClsConexionDb.CadenaConexion = cadena;
                try
                {


                    if (NuevaConexion2.SiConexionDb)
                    {

                        NuevaConexion2.ComandoDb.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {


                    MessageBox.Show(ex.Message, "ERROR" + TablaArticulos);
                }
                try
                {
                    NuevaConexion2 = new ClsConexionDb(ConsultaFacturacion);
                    if (NuevaConexion2.SiConexionDb)
                    {

                        NuevaConexion2.ComandoDb.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {


                    MessageBox.Show(ex.Message, "ERROR" + TipoNota);
                }
                try
                {
                    NuevaConexion2 = new ClsConexionDb(ConsultaEmpresas);
                    if (NuevaConexion2.SiConexionDb)
                    {

                        NuevaConexion2.ComandoDb.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {


                    MessageBox.Show(ex.Message, "ERROR" + "EMPRESAS");
                }
                try
                {
                    NuevaConexion2 = new ClsConexionDb(ConsultaDetalles);
                    if (NuevaConexion2.SiConexionDb)
                    {

                        NuevaConexion2.ComandoDb.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {


                    MessageBox.Show(ex.Message, "ERROR" + "Detalles");
                }
                try
                {
                    NuevaConexion2 = new ClsConexionDb(TablaDtconfi);
                    if (NuevaConexion2.SiConexionDb)
                    {

                        NuevaConexion2.ComandoDb.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {


                    MessageBox.Show(ex.Message, "ERROR" + "DtConfi");
                }
                finally
                {
                    if (NuevaConexion2.CerrarConexionDB)
                    {

                        NuevaConexion2.ComandoDb.Parameters.Clear();

                    }
                }
                MessageBox.Show("Se Termino De crar Tablas");
            }
        }
    }
}


