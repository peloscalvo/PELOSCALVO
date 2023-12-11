using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormCrearTablasDb : Form
    {
        public FormCrearTablasDb()
        {
            InitializeComponent();
        }
        private void FormCrearTablasDb_Load(object sender, EventArgs e)
        {
            try
            {
                if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION != null)
                {
                    this.dtConfiguracionPrincipalBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfiguracionPrincipal;

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
        }
        private bool VALIDARcampos_ArchivosTablas()
        {
            bool ok = true;
            if (this.ArticulosTxt.Text == string.Empty)
            {
                ok = false;
                this.ErrorVer.SetError(this.ArticulosTxt, " (( Elija Una Opcion ..))");
            }
            if (this.ClientesTxt.Text == string.Empty)
            {
                ok = false;
                this.ErrorVer.SetError(this.ClientesTxt, " (( Elija Una Opcion ..))");
            }
            if (this.ExtensionTxt.Text == string.Empty)
            {
                ok = false;
                this.ErrorVer.SetError(this.ExtensionTxt, " (( Elija Una Opcion ..))");
            }
            return ok;

        }
        private void BORRARerror_ArchivosT()
        {
            this.ErrorVer.SetError(this.ArticulosTxt, "");
            this.ErrorVer.SetError(this.ClientesTxt, "");
            this.ErrorVer.SetError(this.ExtensionTxt, "");
        }
        private void BtnSalirT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" ¿Salir Crear TAblas ? ", " Tablas ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
        private List<string> ObtenerTablasDb()
        {

            // Microsoft Access provider factory
            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");

            DataTable userTables = null;
            string Ruta = "";
            if (this.TabInicio.Tag.ToString() == "SI")
            {
                Ruta = this.BaseDatosTxt1.Text;
            }
            else
            {
                Ruta = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + this.BaseDatosTxt1.Text + "." + this.ExtensionTxt.Text;
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

            List<string> tableNames = new List<string>();
            for (int i = 0; i < userTables.Rows.Count; i++)
            {
                // ListaTablasPrincipal.Items.Add(userTables.Rows[i][2].ToString());
                if (ChckListar.Checked)
                {
                    if (!userTables.Rows[i][2].ToString().Contains("Dt"))
                    {
                        tableNames.Add(userTables.Rows[i][2].ToString());
                    }
                    
                }
                else
                {
                    tableNames.Add(userTables.Rows[i][2].ToString());
                }
            
            }
            return tableNames;
        }
    

        private void BtnTablasCrear_Click(object sender, EventArgs e)
        {
            BORRARerror_ArchivosT();

            if (VALIDARcampos_ArchivosTablas())
            {
                if (MessageBox.Show("Desea Crear Las Tablas Para Nueva Base Datos ", "CREAR TABLAS NUEVAS", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {


                    Random r = new Random();
                    int valor = r.Next(10, 900000);

                    string ConsultaArticulos = "CREATE TABLE [" + this.ArticulosTxt.Text + "] ([Id] INTEGER  primary key , [Referencia] varchar," +
                        "[Descripcci] varchar,[Coste] MONEY , [Ganancia] DECIMAL ,[Pvp1] MONEY ,[PvpIva] MONEY ," +
                        "[Pvp2Desc] DECIMAL ,[Pvp2] MONEY ,[CastyDesc] DECIMAL ,[Casty] MONEY ,[SuarezDesc] DECIMAL " +
                        ",[Suarez] MONEY ,[BenitoDesc] DECIMAL ,[Benito] MONEY ,[ValenteDesc] DECIMAL ,[Valente] MONEY" +
                        " ,[PlusDesc] DECIMAL ,[Plus] MONEY ,[UnidadPale] DECIMAL,[MinimosSto] DECIMAL ,[Stock] DECIMAL " +
                        ",[Familia] varchar ,[Fecha] DATETIME ,[BAJA] bit default 0  , [Fatu] bit  default 0 )";
                    string TablaCliente = this.ClientesTxt.Text;
                    string ConsultaCliente = "CREATE TABLE [" + TablaCliente + "] ( [Id] INTEGER  primary key , [Referencia] varchar," +
                        "[Descripcci] varchar,[Coste] MONEY , [Ganancia] DECIMAL ,[Pvp1] MONEY ,[PvpIva] MONEY ," +
                        "[Pvp2Desc] DECIMAL ,[Pvp2] MONEY ,[CastyDesc] DECIMAL ,[Casty] MONEY ,[SuarezDesc] DECIMAL " +
                        ",[Suarez] MONEY ,[BenitoDesc] DECIMAL ,[Benito] MONEY ,[ValenteDesc] DECIMAL ,[Valente] MONEY" +
                        " ,[PlusDesc] DECIMAL ,[Plus] MONEY ,[UnidadPale] DECIMAL,[MinimosSto] DECIMAL ,[Stock] DECIMAL " +
                        ",[Familia] varchar ,[Fecha] DATETIME ,[BAJA] bit default 0  , [Fatu] bit  default 0 )";
                    string ConsultaEmpresas = " CREATE TABLE [DtConfiguracionPrincipal] ([NombreEmpresaReguistro] varchar primary key ,[IdEmpresa] INTEGER , [EmpresaConfi] varchar , [NombreEmpresa] varchar  ," +
                    "[DireccionEmpresa] varchar  ,[LocalidadEmpresa] varchar  ,[CodigoPostalEmpresa] varchar  ,[ProvinciaEmpresa] varchar ," +
                  "[TelefonoEmpresa] varchar  ,[CorreoEmpresa] varchar  ,[WepEmpresa] varchar  ,[RegimenIvaEmpresa] varchar  ," +
                " [PaisEmpresa] varchar  ,[SerieDeFacturacionEmpresa] varchar  ,[Telefono2Empresa] varchar  ,[MovilEmpresa] varchar  ," +
                " [CifEmpresa] varchar   ,[ImagenEmpresa] IMAGE ) ";

                    string TablaDtconfi = "CREATE TABLE[DtConfi] ([EnlaceDtconfi] varchar primary key ,[ConfiguraccionBasica] varchar , [TipoInpuestoIVA] INTEGER, [EjerciciosDeAño] varchar  ," +
                        "[EmpresaENLACE] varchar not null ,[IdConexionConfi] INTEGER not null, [AñoDeEjercicio] varchar  ," +
                           " CONSTRAINT FK_DTCONFI" + valor + " FOREIGN KEY(EmpresaENLACE)REFERENCES DtConfiguracionPrincipal(NombreEmpresaReguistro) ON UPDATE CASCADE ON DELETE CASCADE )";
                    string TablaTarifa = "CREATE TABLE[DtTarifaTipo] ([Id] INTEGER , [TarifaTipo] varchar, [EnlaceTarifa] varchar not null," +
                        "CONSTRAINT F_DtTipoTarifa" + valor.ToString() + " FOREIGN KEY (EnlaceTarifa)REFERENCES DtConfiguracionPrincipal(NombreEmpresaReguistro) ON UPDATE CASCADE ON DELETE CASCADE )";


                    string ConsultaAlmacen = "CREATE TABLE [DtAlmacenes]( [Id] INTEGER primary key,[Almacenes] varchar,[Enlace_Almacenes] varchar not null, " +
                       " CONSTRAINT F_DtAlmacenes" + valor.ToString() + " FOREIGN KEY (Enlace_Almacenes)REFERENCES DtConfiguracionPrincipal(NombreEmpresaReguistro) ON UPDATE CASCADE ON DELETE CASCADE )";

                    string ConsultaProvedores = "   CREATE TABLE [DtProveedores]( [Id_Proveedores] INTEGER primary key,[Proveedores] varchar ,[Enlace_Proveedores] varchar not null, " +
                      " CONSTRAINT F_DtProveedores" + valor.ToString() + " FOREIGN KEY (Enlace_Proveedores)REFERENCES DtConfiguracionPrincipal(NombreEmpresaReguistro) ON UPDATE CASCADE ON DELETE CASCADE )";

                    string ConsultaFamilia = "   CREATE TABLE [DtFamiliaProductos]([Id] INTEGER primary key, [FamiliaProductos] varchar)";
                    string TablaPais = "CREATE TABLE[DtPaises] ([Id] INTEGER not null,[PaisesPaises] varchar primary key)";
                    string TablaProvincia = "CREATE TABLE[DtProvincias] ([Id] INTEGER primary key, [ProvinciasProvincias] varchar,[Enlace] varchar NOT NULL," +
                   " CONSTRAINT F_DtProvincias" + valor.ToString() + " FOREIGN KEY (Enlace)REFERENCES DtPaises(PaisesPaises) ON UPDATE CASCADE ON DELETE CASCADE )";
                    string TablaObra = "CREATE TABLE[DtObras] ([Id] INTEGER primary key,[Obras] varchar)";
                    string TablaInicio = "CREATE TABLE[DtInicioMulti] ([Id] INTEGER primary key," +
                        "[EmpresaInicio] varchar,[EjercicioInicio] varchar,[SerieInicio] varchar,[NombreArchivoDatos] varchar," +
                       "[RutaArchivoDatos] varchar,[SerieProvinciaInicio] varchar, [SeriePaisInicio] varchar,[ArchivoArticulos] varchar," +
                       "[TipoExtensionArticulos] varchar,[ArchivoClientes] varchar)";

                    string TablaCorreo_E = "   CREATE TABLE [DtCorreos]([Id] INTEGER primary key, [NombreEmpresa] varchar, [CorreoEletronico] varchar" +
                        ", [Usuario] varchar, [Contraseña] varchar, [smtp] varchar, [Puerto] INTEGER, [Timeof] INTEGER)";
                    string TablaCorreo_Cli = "   CREATE TABLE [DtCorreosCliente]([Id] INTEGER primary key, [RazonSocial] varchar, [EmpresaNombre] varchar" +
                       ", [Direcion] varchar, [CorreoEletronico_cli] varchar)";
                    string TablaUser = "   CREATE TABLE [DtUsuario]([Id] INTEGER primary key, [Usuario] varchar, [Nombre] varchar," +
                          "[Direcion] varchar, [Cargo] varchar, [Varios] varchar ,[CorreoEletronico] varchar)";

                    string Ruta2 = "";
                    if (this.TabInicio.Tag.ToString() == "SI")
                    {
                        Ruta2 = this.BaseDatosTxt1.Text;
                    }
                    else
                    {
                        Ruta2 = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + this.BaseDatosTxt1.Text + "." + this.ExtensionTxt.Text;
                    }
                    string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Ruta2;
                    string TipoNota = "DtNota";
                    string Tabladetalle = "DtDetalles_Nota";
                    string ConsultaFacturacion = "";
                    String ConsultaDetalles = "";


                    using (OleDbConnection NuevaConexion = new OleDbConnection(CadenaConexion))
                    {

                        NuevaConexion.Open();
                        using (OleDbCommand ComandoDb = new OleDbCommand(ConsultaArticulos, NuevaConexion))
                        {
                            try
                            {
                                ComandoDb.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {


                                MessageBox.Show(ex.Message, "ERROR " + "ConsultaArticulos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        using (OleDbCommand ComandoDb = new OleDbCommand(ConsultaCliente, NuevaConexion))
                        {
                            try
                            {
                                ComandoDb.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {


                                MessageBox.Show(ex.Message, "ERROR  CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }



                        using (OleDbCommand ComandoDb = new OleDbCommand(ConsultaEmpresas, NuevaConexion))
                        {
                            try
                            {
                                ComandoDb.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {


                                MessageBox.Show(ex.Message, "ERROR  EMPRESAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        using (OleDbCommand ComandoDb = new OleDbCommand(TablaInicio, NuevaConexion))
                        {
                            try
                            {
                                ComandoDb.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {


                                MessageBox.Show(ex.Message, "ERROR  INICIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        using (OleDbCommand ComandoDb = new OleDbCommand(ConsultaAlmacen, NuevaConexion))
                        {
                            try
                            {
                                ComandoDb.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {


                                MessageBox.Show(ex.Message, "ERROR  ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        using (OleDbCommand ComandoDb = new OleDbCommand(ConsultaProvedores, NuevaConexion))
                        {
                            try
                            {
                                ComandoDb.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {


                                MessageBox.Show(ex.Message, "ERROR  PROVEEDORES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        using (OleDbCommand ComandoDb = new OleDbCommand(TablaDtconfi, NuevaConexion))
                        {
                            try
                            {
                                ComandoDb.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {


                                MessageBox.Show(ex.Message, "ERROR  DTCONFI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        using (OleDbCommand ComandoDb = new OleDbCommand(TablaTarifa, NuevaConexion))
                        {
                            try
                            {
                                ComandoDb.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {


                                MessageBox.Show(ex.Message, "ERROR  TARIFA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        using (OleDbCommand ComandoDb = new OleDbCommand(ConsultaFamilia, NuevaConexion))
                        {
                            try
                            {
                                ComandoDb.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {


                                MessageBox.Show(ex.Message, "ERROR  FAMILIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        using (OleDbCommand ComandoDb = new OleDbCommand(TablaPais, NuevaConexion))
                        {
                            try
                            {
                                ComandoDb.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {


                                MessageBox.Show(ex.Message, "ERROR  PAISES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        using (OleDbCommand ComandoDb = new OleDbCommand(TablaObra, NuevaConexion))
                        {
                            try
                            {
                                ComandoDb.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message, "ERROR  OBRAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        using (OleDbCommand ComandoDb = new OleDbCommand(TablaProvincia, NuevaConexion))
                        {
                            try
                            {
                                ComandoDb.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {


                                MessageBox.Show(ex.Message, "ERROR  PROVINCIAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        using (OleDbCommand ComandoDb = new OleDbCommand(TablaCorreo_E, NuevaConexion))
                        {
                            try
                            {
                                ComandoDb.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message, "ERROR  CORREO DE EMPRESA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        using (OleDbCommand ComandoDb = new OleDbCommand(TablaCorreo_Cli, NuevaConexion))
                        {
                            try
                            {
                                ComandoDb.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message, "ERROR  CORREO CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        using (OleDbCommand ComandoDb = new OleDbCommand(TablaUser, NuevaConexion))
                        {
                            try
                            {
                                ComandoDb.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message, "ERROR  USUARIOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        for (int i = 1; i < 7; i++)
                        {
                            if (i == 2)
                            {
                                TipoNota = "DtNota2";
                                Tabladetalle = "DtDetalles_Nota2";
                            }
                            if (i == 3)
                            {
                                //TipoNota = "DtNota2";
                                Tabladetalle = "DtDetalles2_Nota2";
                            }
                            if (i == 4)
                            {
                                TipoNota = "DtAlbaran";
                                Tabladetalle = "DtDetalles_Albaran";
                            }
                            if (i == 5)
                            {
                                TipoNota = "DtPresupuesto";
                                Tabladetalle = "DtDetalles_Presupuesto";
                            }
                            if (i == 6)
                            {
                                TipoNota = "DtFactura";
                                Tabladetalle = "DtDetalles_Fatura";
                            }
                            valor = r.Next(10, 10000);
                            if (i != 3)
                            {
                                ConsultaFacturacion = "CREATE TABLE [" + TipoNota + "] ([EnlaceFactura] varchar primary key , [NumeroFactura] INTEGER not null,[Apodo] varchar ,[Nombre] varchar," +
                             "[Direccion] varchar,[Calle] varchar,[NumeroCalle] varchar,[Dni] varchar,[Localidad] varchar," +
                              "[Provincia] varchar,[CodigoPostal] varchar,[NonbreAlmacen] varchar,[FechaFactura] varchar," +
                             "[IvaImpuesto] INTEGER,[SubTotal] DECIMAL,[BaseIva] DECIMAL,[TotalFactura] DECIMAL,[CobradaFactura] varchar," +
                             "[FechaCobro] varchar,[Pais_Fact] varchar,[TotalFactura2] DECIMAL,[TipoNOTA] varchar,[Obra_factu] varchar," +
                            "[EjercicioTipo] varchar,[SerieTipo] varchar, [EmpresaEnlace] varchar not null,[EnlaceDtconfi] varchar not null," +
                            "CONSTRAINT F_DtConfi" + TipoNota + valor.ToString() + " FOREIGN KEY (EnlaceDtconfi)REFERENCES DtConfi(EnlaceDtconfi) ON UPDATE CASCADE ON DELETE CASCADE )";
                            }


                            ConsultaDetalles = "CREATE TABLE [" + Tabladetalle + "]( [ReferenciaDetalle] varchar" +
                                   ",[CantidadDetalle] DECIMAL,[DescripccionDetalle] varchar, [DescuentoDetalle] DECIMAL" +
                                   ",[PrecioDetalle]   MONEY,[IvaDetalle] DECIMAL,[ImporteDetalle]   MONEY,[EnlaceDetalle] varchar not null" +
                                   ", CONSTRAINT FK_" + Tabladetalle + valor.ToString() + " FOREIGN KEY (EnlaceDetalle)REFERENCES " + TipoNota + "(EnlaceFactura) ON UPDATE CASCADE ON DELETE CASCADE )";
                            using (OleDbCommand ComandoDb = new OleDbCommand(ConsultaFacturacion, NuevaConexion))
                            {

         
                                if (i != 3)
                                {
                                    try
                                    {
                                        ComandoDb.ExecuteNonQuery();
                                        ComandoDb.Parameters.Clear();
                                    }
                                    catch (Exception ex)
                                    {

                                        MessageBox.Show(ex.Message, "ERROR " + ConsultaFacturacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                }
                                using (OleDbCommand ComandoDbDetalle = new OleDbCommand(ConsultaDetalles, NuevaConexion))
                                {

                                    try
                                    {
                                        ComandoDbDetalle.ExecuteNonQuery();
                                        ComandoDbDetalle.Parameters.Clear();
                                    }
                                    catch (Exception ex)
                                    {

                                        MessageBox.Show(ex.Message, "ERROR " + ConsultaDetalles, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }


                            }

                        }
                        MessageBox.Show("Se Termino De crar Tablas");
                    }

                }
            }
        }

        private void BtnExaminarT_Click(object sender, EventArgs e)
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
                        this.BaseDatosTxt1.Text = BuscarArchivo.FileName.ToString();
                        this.TabInicio.Tag = "SI";
                        this.BaseDatosTxt1.BackColor = Color.Bisque;
                    }
                    else
                    {
                        MessageBox.Show("Solo Archivos Con Extension (((accdb))) o (((mdb)))", "ARCHIVO NO VALIDO");
                    }
                }
            }
            catch (Exception ex)
            {
                if (this.BaseDatosTxt1.Text == "Datos App Peloscalvo")
                {
                    MessageBox.Show(ex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Puede Que este Artivo Sea el Correcto" + "\n" + ex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {

        }

        private void BtnRestablecer_t_Click(object sender, EventArgs e)
        {
            this.BaseDatosTxt1.Text = "Datos App Peloscalvo";
            this.BaseDatosTxt1.Tag = "NO";
            this.BaseDatosTxt1.BackColor = SystemColors.Control;
        }

        private void BtnRestablecer_t_MouseEnter(object sender, EventArgs e)
        {
            this.Info_Res.Visible = true;
        }

        private void FormCrearTablasDb_MouseEnter(object sender, EventArgs e)
        {
            this.Info_Res.Visible = false;
        }

        private void BtnCrearTablaArti_Click(object sender, EventArgs e)
        {
            if (this.BaseDatosTxt1.Text != "Datos App Peloscalvo")
            {
                MessageBox.Show("Este Tipo DE Archivo No Se Puede Crear", "CREAR", MessageBoxButtons.OK);
                return;
            }

            BORRARerror_ArchivosT();
            if (VALIDARcampos_ArchivosTablas())
            {
                string Ruta2 = "";
                if (this.BaseDatosTxt1.Tag.ToString() == "SI")
                {
                    Ruta2 = this.BaseDatosTxt1.Text;
                }
                else
                {
                    Ruta2 = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + this.BaseDatosTxt1.Text + "." + this.ExtensionTxt.Text;
                }
                if (MessageBox.Show("\n" + " Crear Tabla  " + this.ArticulosTxt.Text, " CREAR? ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    Random r = new Random();
                    int valor = r.Next(10, 90000000);
                    string TablaArticulos = this.ArticulosTxt.Text;
                    string ConsultaArticulos = "CREATE TABLE [" + TablaArticulos + "] ( [Id] INTEGER  primary key , [Referencia] varchar," +
                        "[Descripcci] varchar,[Coste] MONEY , [Ganancia] DECIMAL ,[Pvp1] MONEY ,[PvpIva] MONEY ," +
                        "[Pvp2Desc] DECIMAL ,[Pvp2] MONEY ,[CastyDesc] DECIMAL ,[Casty] MONEY ,[SuarezDesc] DECIMAL " +
                        ",[Suarez] MONEY ,[BenitoDesc] DECIMAL ,[Benito] MONEY ,[ValenteDesc] DECIMAL ,[Valente] MONEY" +
                        " ,[PlusDesc] DECIMAL ,[Plus] MONEY ,[UnidadPale] DECIMAL,[MinimosSto] DECIMAL ,[Stock] DECIMAL " +
                        ",[Familia] varchar ,[Fecha] DATETIME ,[BAJA] bit default 0  , [Fatu] bit  default 0 )";


                    string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Ruta2;

                    using (OleDbConnection NuevaConexion = new OleDbConnection(CadenaConexion))
                    {
                        using (OleDbCommand ComandoDb = new OleDbCommand(ConsultaArticulos, NuevaConexion))
                        {
                            try
                            {
                                ComandoDb.ExecuteNonQuery();
                                MessageBox.Show("Creada Con exito" + "\n" + this.ArticulosTxt.Text, "CREAR TABLA", MessageBoxButtons.OK);
                            }
                            catch (Exception ex)
                            {


                                MessageBox.Show(ex.Message, "ERROR " + ConsultaArticulos, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }

                }
            }
        }

        private void BtnCrearTablaCli_Click(object sender, EventArgs e)
        {
            if (this.ExtensionTxt.Text == "DBF")
            {
                MessageBox.Show("Este Tipo DE Archivo No Se Puede Crear", "CREAR", MessageBoxButtons.OK);
                return;
            }
            BORRARerror_ArchivosT();
            if (VALIDARcampos_ArchivosTablas())
            {
                if (MessageBox.Show("\n" + " Crear Tabla  " + this.ClientesTxt.Text, " CREAR? ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string Ruta2 = "";
                    if (this.BaseDatosTxt1.Tag.ToString() == "SI")
                    {
                        Ruta2 = this.ClientesTxt.Text;
                    }
                    else
                    {
                        Ruta2 = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + this.BaseDatosTxt1.Text + "." + this.ExtensionTxt.Text;
                    }

                    Random r = new Random();
                    int valor = r.Next(10, 90000000);
                    string TablaCliente = this.ClientesTxt.Text;
                    string ConsultaCliente = "CREATE TABLE [" + TablaCliente + "] ( [Id] INTEGER  primary key , [Referencia] varchar," +
                        "[Descripcci] varchar,[Coste] MONEY , [Ganancia] DECIMAL ,[Pvp1] MONEY ,[PvpIva] MONEY ," +
                        "[Pvp2Desc] DECIMAL ,[Pvp2] MONEY ,[CastyDesc] DECIMAL ,[Casty] MONEY ,[SuarezDesc] DECIMAL " +
                        ",[Suarez] MONEY ,[BenitoDesc] DECIMAL ,[Benito] MONEY ,[ValenteDesc] DECIMAL ,[Valente] MONEY" +
                        " ,[PlusDesc] DECIMAL ,[Plus] MONEY ,[UnidadPale] DECIMAL,[MinimosSto] DECIMAL ,[Stock] DECIMAL " +
                        ",[Familia] varchar ,[Fecha] DATETIME ,[BAJA] bit default 0  , [Fatu] bit  default 0 )";

                    string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Ruta2;
                    using (OleDbConnection NuevaConexion = new OleDbConnection(CadenaConexion))
                    {
                        using (OleDbCommand ComandoDb = new OleDbCommand(ConsultaCliente, NuevaConexion))
                        {
                            try
                            {
                                ComandoDb.ExecuteNonQuery();
                                MessageBox.Show("Creada Con exito" + "\n" + this.ClientesTxt.Text, "CREAR TABLA", MessageBoxButtons.OK);
                            }
                            catch (Exception ex)
                            {


                                MessageBox.Show(ex.Message, "ERROR " + ConsultaCliente, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }

                }
            }
        }

        private void BaseDatosTxt1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.BaseDatosTxt1.Text))
            {
                this.BaseDatos2.Text = string.Empty;
            }
            else
            {
                this.BaseDatos2.Text = this.BaseDatosTxt1.Text;
            }

        }

        private void BtnCrearBackupDb_Click(object sender, EventArgs e)
        {
            if (this.BaseDatos2.Text != string.Empty || this.BaseDatos2.Text != string.Empty)
            {

                FolderBrowserDialog CarpetaElegir = new FolderBrowserDialog();
                if (CarpetaElegir.ShowDialog() == DialogResult.OK)
                {
                    this.InfoProcesoText.BackColor = Color.FromArgb(234, 210, 8);
                    this.InfoProcesoText.Text = " Creando Copia De Seguridad de Base Datos: " + this.BaseDatos2.Text + " .............. .......Espere Un Momento !!!!!!!";
                    this.InfoProcesoText.Refresh();
                    Application.DoEvents();
                    // string RutaOrigen = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal;
                    string RutaDestino = CarpetaElegir.SelectedPath;
                    string CarpetaCopia = "Copia Seguridad De PeloscalvoApp";
                    string NonbreBackup = "Backup De" + this.BaseDatos2.Text + String.Format("{0:dd-MM-yyyy hh:mm:ss}", DateTime.Now);
                    //string BACKUP = RutaDestino + "\\" + CarpetaCopia;


                    if (!Directory.Exists(RutaDestino + "\\" + CarpetaCopia))
                    {
                        DirectoryInfo DirectiorioCopia = new DirectoryInfo(RutaDestino);
                        DirectiorioCopia.CreateSubdirectory(CarpetaCopia);

                    }
                    string Ruta = "";
                    if (this.BaseDatosTxt1.Tag.ToString() == "SI")
                    {
                        Ruta = this.BaseDatosTxt1.Text;
                    }
                    else
                    {
                       Ruta = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + this.BaseDatos2.Text + "." + this.ExtensionTxt.Text;
                    }
                 
                    string consulta = "BACKUP DATABASE [" + this.BaseDatos2.Text + "." + this.ExtensionTxt.Text + "] TO  DISK = N'" + RutaDestino + "\\" + CarpetaCopia + "\\" + "\\" + NonbreBackup + ".bak' WITH NOFORMAT, NOINIT,  NAME = N'" + this.BaseDatos2.Text + " Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                    // string cadenaConexion = "Data Source=" + Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + this.BaseDatos2.Text + "." + this.ExtensionTxt.Text + ";Initial Catalog=" + Cadena2 + ";Integrated Security=True";
                    try
                    {
                        File.Copy(Ruta, RutaDestino);
                        MessageBox.Show("Se Creo Base Datos Correctamente" + "\n" + Ruta, "COPIA SEGURIDAD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message.ToString());
                    }
                    string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Ruta;
                    try
                    {
                        using (OleDbConnection NuevaConexion = new OleDbConnection(cadenaConexion))
                        {
                            using (OleDbCommand comando = new OleDbCommand(consulta, NuevaConexion))
                            {
                                // NuevaConexion.Open();
                                // comando.ExecuteNonQuery();


                            }
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message.ToString());
                    }
                }

                this.InfoProcesoText.Text = "Indica La Base Datos a Crear Copia De Seguridad";
                this.InfoProcesoText.BackColor = this.BackColor;
                this.InfoProcesoText.Refresh();
            }
        }

        private void BtnCopiarTabla_Click(object sender, EventArgs e)
        {
            if (this.TablaCopiarTxt.Text ==string.Empty)
            {
                MessageBox.Show("Debe Escojer Tabla A Copiar", "COPIAR", MessageBoxButtons.OK);
               // TablanuevaTxt.Focus();
                return;
            }
            if (this.TablanuevaTxt.Text == string.Empty)
            {
                MessageBox.Show("Debe Nueva Donde Copiar", "COPIAR", MessageBoxButtons.OK);
                // TablanuevaTxt.Focus();
                return;
            }
            if (this.TablanuevaTxt.Text == this.TablaCopiarTxt.Text)
            {
                MessageBox.Show("La Tabla No Puede Copiarse a Si Misma", "COPIAR", MessageBoxButtons.OK);
                // TablanuevaTxt.Focus();
                return;
            }
            FolderBrowserDialog CarpetaElegir = new FolderBrowserDialog();
            if (CarpetaElegir.ShowDialog() == DialogResult.OK)
            {
                this.InfoProcesoText.BackColor = Color.FromArgb(234, 210, 8);
                this.InfoProcesoText.Text = " Copiando Tabla de Base Datos: " + this.BaseDatos2.Text + " .............. .......Espere Un Momento !!!!!!!";
                this.InfoProcesoText.Refresh();
                Application.DoEvents();
                string Ruta = "";
                if (this.BaseDatosTxt1.Tag.ToString() == "SI")
                {
                    Ruta = this.BaseDatosTxt1.Text;
                }
                else
                {
                    Ruta = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + this.BaseDatos2.Text + "." + this.ExtensionTxt.Text;
                }

                string consulta = "INSERT INTO ["+TablanuevaTxt.Text+"] SELECT* FROM " + TablaCopiarTxt.Text + "order by Descripcci asc";
                string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Ruta;
                try
                {
                    using (OleDbConnection NuevaConexion = new OleDbConnection(cadenaConexion))
                    {
                        using (OleDbCommand comando = new OleDbCommand(consulta, NuevaConexion))
                        {
                             NuevaConexion.Open();
                             comando.ExecuteNonQuery();

                            MessageBox.Show("Copiaron Los Datos A Tabla Correctamente" + "\n" + Ruta, "COPIA TABLA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            }

            this.InfoProcesoText.Text = "Indica La Base Datos a Crear Copia De Seguridad";
            this.InfoProcesoText.BackColor = this.BackColor;
            this.InfoProcesoText.Refresh();
        }

        private void ExtensionTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( ExtensionTxt.Text != string.Empty & BaseDatosTxt1.Text != string.Empty)
            {           
                    ListaTablasPrincipal.DataSource = ObtenerTablasDb();
                    TablanuevaTxt.DataSource = ObtenerTablasDb();              
               
            }
          
        }

        private void ListaTablasPrincipal_Click(object sender, EventArgs e)
        {
            if (this.ExtensionTxt.Text == string.Empty)
            {
                MessageBox.Show("Falta Tipo Extenxision", "EXTENSION NO VALIDA", MessageBoxButtons.OK);
                TabControlPrincipal.SelectedIndex = 0;
                 ExtensionTxt.Focus();
                return;
            }
            if (this.ListaTablasPrincipal.SelectedIndex >= 0)
            {
                this.TablaCopiarTxt.Text = this.ListaTablasPrincipal.SelectedItem.ToString();
            }
        }

        private void ArticulosTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ExtensionTxt.Text != string.Empty & BaseDatosTxt1.Text != string.Empty)
            {

                ExtensionTxt.Enabled = true;
            }
        }

        private void ClientesTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ExtensionTxt.Text != string.Empty & BaseDatosTxt1.Text != string.Empty)
            {

                ExtensionTxt.Enabled = true;
            }
        }
    }
}
