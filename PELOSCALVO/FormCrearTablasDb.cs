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
    public partial class FormCrearTablasDb : Form
    {
        public FormCrearTablasDb()
        {
            InitializeComponent();
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

        private void FormCrearTablasDb_Load(object sender, EventArgs e)
        {

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
                    string ConsultaEmpresas = " CREATE TABLE [DtConfiguracionPrincipal] ([IdEmpresa] INTEGER , [EmpresaConfi] varchar , [NombreEmpresa] varchar  ," +
                    "[DireccionEmpresa] varchar  ,[LocalidadEmpresa] varchar  ,[CodigoPostalEmpresa] varchar  ,[ProvinciaEmpresa] varchar ," +
                  "[TelefonoEmpresa] varchar  ,[CorreoEmpresa] varchar  ,[WepEmpresa] varchar  ,[RegimenIvaEmpresa] varchar  ," +
                " [PaisEmpresa] varchar  ,[SerieDeFacturacionEmpresa] varchar  ,[Telefono2Empresa] varchar  ,[MovilEmpresa] varchar  ," +
                " [CifEmpresa] varchar  ,[NombreEmpresaReguistro] varchar primary key ,[ImagenEmpresa] IMAGE ) ";

                    string TablaDtconfi = "CREATE TABLE[DtConfi] ([ConfiguraccionBasica] varchar , [TipoInpuestoIVA] INTEGER, [EjerciciosDeAño] varchar  ," +
                        "[EmpresaENLACE] varchar ,[IdConexionConfi] INTEGER , [AñoDeEjercicio] varchar  ," +
                           " CONSTRAINT FK_DTCONFI" + valor + " FOREIGN KEY(EmpresaENLACE)REFERENCES DtConfiguracionPrincipal(NombreEmpresaReguistro) ON UPDATE CASCADE ON DELETE CASCADE )";
                    string TablaTarifa = "CREATE TABLE[DtTarifaTipo] ([IdTarifa] INTEGER , [TarifaTipo] varchar, [EnlaceTarifa] varchar ," +
                        "CONSTRAINT F_DtTipoTarifa" + valor.ToString() + " FOREIGN KEY(EnlaceTarifa)REFERENCES DtConfiguracionPrincipal(NombreEmpresaReguistro) ON UPDATE CASCADE ON DELETE CASCADE )";


                    string ConsultaAlmacen = "CREATE TABLE [DtAlmacenes]( [Id_almacenes] INTEGER ,[Almacenes] varchar,[Enlace_Almacenes] varchar , " +
                       " CONSTRAINT F_DtAlmacenes" + valor.ToString() + " FOREIGN KEY(Enlace_Almacenes)REFERENCES DtConfiguracionPrincipal(NombreEmpresaReguistro) ON UPDATE CASCADE ON DELETE CASCADE )";

                    string ConsultaProvedores = "   CREATE TABLE [DtProveedores]( [Id_Proveedores] INTEGER,[Proveedores] varchar ,[Enlace_Proveedores] varchar, " +
                      " CONSTRAINT F_DtProveedores" + valor.ToString() + " FOREIGN KEY(Enlace_Proveedores)REFERENCES DtConfiguracionPrincipal(NombreEmpresaReguistro) ON UPDATE CASCADE ON DELETE CASCADE )";

                    string ConsultaFamilia = "   CREATE TABLE [DtFamiliaProductos]([Id] INTEGER, [FamiliaProductos] varchar)";
                    string TablaPais = "CREATE TABLE[DtPaises] ([Id] INTEGER,[PaisesPaises] varchar)";
                    string TablaProvincia = "CREATE TABLE[DtProvincias] ([Id] INTEGER, [ProvinciasProvincias] varchar)";
                    string TablaObra = "CREATE TABLE[DtObras] ([Id_Obras] INTEGER ,[Obras] varchar)";
                    string TablaInicio = "CREATE TABLE[DtInicioMulti] ([Id] INTEGER ,[ArchivoInicioFacturas] varchar," +
                        "[EmpresaInicio] varchar,[EjercicioInicio] varchar,[SerieInicio] varchar,[NombreArchivoDatos] varchar," +
                       "[RutaArchivoDatos] varchar,[SerieProvinciaInicio] varchar, [SeriePaisInicio] varchar,[ArchivoArticulos] varchar," +
                       "[TipoExtensionArticulos] varchar,[ArchivoClientes] varchar)";

                    string TablaCorreo_E = "   CREATE TABLE [DtCorreos]([Id] INTEGER, [NombreEmpresa] varchar, [CorreoEletronico] varchar" +
                        ", [Usuario] varchar, [Contraseña] varchar, [smtp] varchar, [Puerto] INTEGER, [Timeof] INTEGER)";
                    string TablaCorreo_Cli = "   CREATE TABLE [DtCorreosCliente]([Id] INTEGER, [RazonSocial] varchar, [EmpresaNombre] varchar" +
                       ", [Direcion] varchar, [CorreoEletronico_cli] varchar)";
                    string TablaUser = "   CREATE TABLE [DtUsuario]([Id] INTEGER, [Usuario] varchar, [Nombre] varchar," +
                          "[Direcion] varchar, [Cargo] varchar, [Varios] varchar ,[CorreoEletronico] varchar)";

                    ClsConexionDb.CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ClasDatos.RutaBaseDatosDb;
                    ClsConexionDb NuevaConexion2 = new ClsConexionDb(ConsultaArticulos);
                    try
                    {
                        if (NuevaConexion2.SiConexionDb)
                        {

                            NuevaConexion2.ComandoDb.ExecuteNonQuery();

                        }
                    }
                    catch (Exception ex)
                    {


                        MessageBox.Show(ex.Message, "ERROR TABLA ARTICULOS");
                    }
                    NuevaConexion2.ComandoDb.Parameters.Clear();
                    NuevaConexion2 = new ClsConexionDb(ConsultaCliente);

                    try
                    {
                        if (NuevaConexion2.SiConexionDb)
                        {

                            NuevaConexion2.ComandoDb.ExecuteNonQuery();

                        }
                    }
                    catch (Exception ex)
                    {


                        MessageBox.Show(ex.Message, "ERROR TABLA CLIENTES");
                    }
                    NuevaConexion2.ComandoDb.Parameters.Clear();
                    string TipoNota = "DtNota";
                    string Tabladetalle = "DtDetalles_Nota";
                    string ConsultaFacturacion = "";
                    String ConsultaDetalles = "";
                    for (int i = 1; i < 7; i++)
                    {

                        if (i == 2)
                        {
                            TipoNota = "DtNota2";
                            Tabladetalle = "DtDetalles_Nota2";
                        }
                        if (i == 3)
                        {
                            TipoNota = "DtNota2";
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
                        valor = r.Next(10, 900000);
                        ConsultaFacturacion = "CREATE TABLE [" + TipoNota + "] ([EnlaceFactura] varchar primary key , [NumeroFactura] INTEGER ,[Apodo] varchar ,[Nombre] varchar," +
                       "[Direccion] varchar,[Calle] varchar,[NumeroCalle] varchar,[Dni] varchar,[Localidad] varchar," +
                          "[Provincia] varchar,[CodigoPostal] varchar,[NonbreAlmacen] varchar,[FechaFactura] varchar," +
                        "[IvaImpuesto] INTEGER,[SubTotal] DECIMAL,[BaseIva] DECIMAL,[TotalFactura] DECIMAL,[CobradaFactura] varchar," +
                      "[FechaCobro] varchar,[Pais_Fact] varchar,[TotalFactura2] DECIMAL,[TipoNOTA] varchar,[Obra_factu] varchar," +
                        "[EjercicioTipo] varchar,[SerieTipo] varchar, [EmpresaEnlace] varchar)";

                        ConsultaDetalles = "CREATE TABLE [" + Tabladetalle + "]( [ReferenciaDetalle] varchar" +
                               ",[CantidadDetalle] DECIMAL,[DescripccionDetalle] varchar, [DescuentoDetalle] DECIMAL" +
                               ",[PrecioDetalle] DECIMAL,[IvaDetalle] DECIMAL,[ImporteDetalle] DECIMAL,[EnlaceDetalle] varchar" +
                               ", CONSTRAINT FK_" + Tabladetalle + valor.ToString() + " FOREIGN KEY (EnlaceDetalle)REFERENCES " + TipoNota + "(EnlaceFactura) ON UPDATE CASCADE ON DELETE CASCADE )";

                        try
                        {
                            NuevaConexion2 = new ClsConexionDb(ConsultaFacturacion);
                            if (NuevaConexion2.SiConexionDb)
                            {
                                if (i != 3)
                                {
                                    NuevaConexion2.ComandoDb.ExecuteNonQuery();
                                    NuevaConexion2.ComandoDb.Parameters.Clear();
                                }

                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message, "ERROR" + "facturacion");
                        }
                        NuevaConexion2.ComandoDb.Parameters.Clear();
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

                            MessageBox.Show(ex.Message, "ERROR" + Tabladetalle);
                        }
                        NuevaConexion2.ComandoDb.Parameters.Clear();
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


                        MessageBox.Show(ex.Message, "ERROR" + "TABLAS EMPRESAS");
                    }
                    NuevaConexion2.ComandoDb.Parameters.Clear();
                    try
                    {
                        NuevaConexion2 = new ClsConexionDb(ConsultaAlmacen);
                        if (NuevaConexion2.SiConexionDb)
                        {

                            NuevaConexion2.ComandoDb.ExecuteNonQuery();

                        }
                    }
                    catch (Exception ex)
                    {


                        MessageBox.Show(ex.Message, "ERROR" + "ALMACENES");
                    }
                    NuevaConexion2.ComandoDb.Parameters.Clear();
                    try
                    {
                        NuevaConexion2 = new ClsConexionDb(ConsultaProvedores);
                        if (NuevaConexion2.SiConexionDb)
                        {

                            NuevaConexion2.ComandoDb.ExecuteNonQuery();

                        }
                    }
                    catch (Exception ex)
                    {


                        MessageBox.Show(ex.Message, "ERROR" + "PROVEEDORES");
                    }
                    NuevaConexion2.ComandoDb.Parameters.Clear();
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
                    NuevaConexion2.ComandoDb.Parameters.Clear();
                    try
                    {
                        NuevaConexion2 = new ClsConexionDb(TablaTarifa);
                        if (NuevaConexion2.SiConexionDb)
                        {

                            NuevaConexion2.ComandoDb.ExecuteNonQuery();

                        }
                    }
                    catch (Exception ex)
                    {


                        MessageBox.Show(ex.Message, "ERROR TABLA TIPO TARIFA");
                    }
                    NuevaConexion2.ComandoDb.Parameters.Clear();
                    try
                    {
                        NuevaConexion2 = new ClsConexionDb(ConsultaFamilia);
                        if (NuevaConexion2.SiConexionDb)
                        {

                            NuevaConexion2.ComandoDb.ExecuteNonQuery();

                        }
                    }
                    catch (Exception ex)
                    {


                        MessageBox.Show(ex.Message, "ERROR TABLA FAMILIAS");
                    }
                    NuevaConexion2.ComandoDb.Parameters.Clear();
                    try
                    {
                        NuevaConexion2 = new ClsConexionDb(TablaPais);
                        if (NuevaConexion2.SiConexionDb)
                        {

                            NuevaConexion2.ComandoDb.ExecuteNonQuery();

                        }
                    }
                    catch (Exception ex)
                    {


                        MessageBox.Show(ex.Message, "ERROR TABLA PAISES");
                    }
                    NuevaConexion2.ComandoDb.Parameters.Clear();
                    try
                    {
                        NuevaConexion2 = new ClsConexionDb(TablaObra);
                        if (NuevaConexion2.SiConexionDb)
                        {

                            NuevaConexion2.ComandoDb.ExecuteNonQuery();

                        }
                    }
                    catch (Exception ex)
                    {


                        MessageBox.Show(ex.Message, "ERROR TABLA OBRAS");
                    }
                    NuevaConexion2.ComandoDb.Parameters.Clear();
                    try
                    {
                        NuevaConexion2 = new ClsConexionDb(TablaProvincia);
                        if (NuevaConexion2.SiConexionDb)
                        {

                            NuevaConexion2.ComandoDb.ExecuteNonQuery();

                        }
                    }
                    catch (Exception ex)
                    {


                        MessageBox.Show(ex.Message, "ERROR TABLA PROVINCIAS");
                    }
                    NuevaConexion2.ComandoDb.Parameters.Clear();
                    try
                    {
                        NuevaConexion2 = new ClsConexionDb(TablaInicio);
                        if (NuevaConexion2.SiConexionDb)
                        {

                            NuevaConexion2.ComandoDb.ExecuteNonQuery();

                        }
                    }
                    catch (Exception ex)
                    {


                        MessageBox.Show(ex.Message, "ERROR TABLA INICIO");
                    }
                    NuevaConexion2.ComandoDb.Parameters.Clear();
                    try
                    {
                        NuevaConexion2 = new ClsConexionDb(TablaCorreo_E);
                        if (NuevaConexion2.SiConexionDb)
                        {

                            NuevaConexion2.ComandoDb.ExecuteNonQuery();

                        }
                    }
                    catch (Exception ex)
                    {


                        MessageBox.Show(ex.Message, "ERROR TABLA CORREO EMPRESA");
                    }
                    NuevaConexion2.ComandoDb.Parameters.Clear();
                    try
                    {
                        NuevaConexion2 = new ClsConexionDb(TablaCorreo_Cli);
                        if (NuevaConexion2.SiConexionDb)
                        {

                            NuevaConexion2.ComandoDb.ExecuteNonQuery();

                        }
                    }
                    catch (Exception ex)
                    {


                        MessageBox.Show(ex.Message, "ERROR TABLA CORREO CLIENTES");
                    }
                    NuevaConexion2.ComandoDb.Parameters.Clear();
                    try
                    {
                        NuevaConexion2 = new ClsConexionDb(TablaUser);
                        if (NuevaConexion2.SiConexionDb)
                        {

                            NuevaConexion2.ComandoDb.ExecuteNonQuery();

                        }
                    }
                    catch (Exception ex)
                    {


                        MessageBox.Show(ex.Message, "ERROR TABLA USUARIOS");
                    }

                    if (NuevaConexion2.CerrarConexionDB)
                    {

                        NuevaConexion2.ComandoDb.Parameters.Clear();

                    }
                    NuevaConexion2.ComandoDb.Parameters.Clear();
                    MessageBox.Show("Se Termino De crar Tablas");
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
                        this.NombreArchivo_T.Text = fi.Name;
                        this.NombreArchivo_T.Tag = "SI";
                        this.NombreArchivo_T.BackColor = Color.Bisque;
                    }
                    else
                    {
                        MessageBox.Show("Solo Archivos Con Extension (((accdb))) o (((mdb)))", "ARCHIVO NO VALIDO");
                    }
                }
            }
            catch (Exception ex)
            {
                if (this.NombreArchivo_T.Text == "Datos App Peloscalvo")
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
            string RutaBase = "";
            if (this.NombreArchivo_T.Tag.ToString() == "SI")
            {
                RutaBase = this.NombreArchivo_T.Text;
            }
            else
            {
                RutaBase = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + this.NombreArchivo_T.Text + "." + this.ExtensionTxt.Text;
            }

            ClsConexionDb.CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + RutaBase;
        }

        private void BtnRestablecer_t_Click(object sender, EventArgs e)
        {
            this.NombreArchivo_T.Text = "Datos App Peloscalvo";
            this.NombreArchivo_T.Tag = "NO";
            this.NombreArchivo_T.BackColor = SystemColors.Control;
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
            if (this.NombreArchivo_T.Text != "Datos App Peloscalvo")
            {
                MessageBox.Show("Este Tipo DE Archivo No Se Puede Crear", "CREAR", MessageBoxButtons.OK);
                return;
            }

            BORRARerror_ArchivosT();
            if (VALIDARcampos_ArchivosTablas())
            {
                string Ruta2 = "";
                if (this.NombreArchivo_T.Tag.ToString() == "SI")
                {
                    Ruta2 = this.NombreArchivo_T.Text;
                }
                else
                {
                    Ruta2 = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + this.NombreArchivo_T.Text + "." + this.ExtensionTxt.Text;
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
                    ClsConexionDb.CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Ruta2;
                    ClsConexionDb NuevaConexion2 = new ClsConexionDb(ConsultaArticulos);
                    try
                    {
                        if (NuevaConexion2.SiConexionDb)
                        {
                            NuevaConexion2.ComandoDb.ExecuteNonQuery();
                            MessageBox.Show("Creada Con exito" + "\n" + this.ArticulosTxt.Text, "CREAR TABLA", MessageBoxButtons.OK);
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
                    if (this.NombreArchivo_T.Tag.ToString() == "SI")
                    {
                        Ruta2 = this.ClientesTxt.Text;
                    }
                    else
                    {
                        Ruta2 = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + this.NombreArchivo_T.Text + "." + this.ExtensionTxt.Text;
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
                    ClsConexionDb.CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Ruta2;
                    ClsConexionDb NuevaConexion2 = new ClsConexionDb(ConsultaCliente);
                    try
                    {


                        if (NuevaConexion2.SiConexionDb)
                        {

                            NuevaConexion2.ComandoDb.ExecuteNonQuery();
                            MessageBox.Show("Creada Con exito" + "\n" + this.ClientesTxt.Text, "CREAR TABLA", MessageBoxButtons.OK);
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
}
