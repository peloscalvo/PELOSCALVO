using Conexiones;
using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormEmpresas : Form
    {
        string Empresa;
        string RazonSocial;
        string Direcion;
        string Localidad;
        string Telefono;
        string Telefono2;
        string Correo;
        string Cif;
        string CodigoPostal;
        string Movil;
        string Web;
        string Iva;
        string Serie;
        public FormEmpresas()
        {
            InitializeComponent();
            ToolTip InfoEliminar = new ToolTip();
            InfoEliminar.SetToolTip(this.BtnEliminarEmpresa, "Se Borrara Permanentemente (EMPRESSA)" + "\n" + "(EJERCICIOS DE EMPRESA)" + "\n" + "(FACTURACION)");
            InfoEliminar.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            InfoEliminar.IsBalloon = true;
            ToolTip InfoSalir = new ToolTip();
            InfoSalir.SetToolTip(this.BtnSalirEmpresa, "Salir De Empresa");
            InfoSalir.IsBalloon = true;
            InfoSalir.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
        }

        private void FormEmpresas_Load(object sender, EventArgs e)
        {
            try
            {
                if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION != null)
                {
                    this.dtConfiguracionPrincipalBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION;

                }
                if (FormMenuPrincipal.menu2principal.dsMulti2 != null)
                {
                    this.dtPaisesBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2;
                    // this.dtProvinciasBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2;        
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


            //dtObrasBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2;
            //dtProvinciasBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2;

            if (!File.Exists(ClasDatos.RutaBaseDatosDb))
            {
                MessageBox.Show("Archivo : " + ClasDatos.RutaBaseDatosDb, "FALTA ARCHIVO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
        private bool ValidarEmpresa()
        {
            bool ok = true;
            if (string.IsNullOrEmpty(this.idEmpresa.Text))
            {
                ok = false;
                this.errorProvider1Confi.SetError(this.idEmpresa, "_ingresar Id valido (( FALTA  ID  ))");
            }
            if (this.EmpresaRazonTxt.Text.Length < 4)
            {
                ok = false;
                this.errorProvider1Confi.SetError(this.EmpresaRazonTxt, "_ingresar Nonbre empresa valido (( minimo 4 Caracteres))");
            }
            if (this.EmpresaTxt.Text.Length < 4)
            {
                ok = false;
                this.errorProvider1Confi.SetError(this.EmpresaTxt, "_ingresar Razon Social valido (( minimo 4 Caracteres))");
            }
            if (this.DirecionEmpresa.Text.Length < 4)
            {
                ok = false;
                this.errorProvider1Confi.SetError(this.DirecionEmpresa, "_ingresar Direccion valido (( minimo 4 Caracteres))");
            }

            return ok;
        }
        private void BorrarErroresEmpresa()
        {
            this.errorProvider1Confi.SetError(this.idEmpresa, "");
            this.errorProvider1Confi.SetError(this.EmpresaRazonTxt, "");
            this.errorProvider1Confi.SetError(this.EmpresaTxt, "");
            this.errorProvider1Confi.SetError(this.DirecionEmpresa, "");
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
        private void ModficarOjetos_E()
        {
            this.panelEmpresas.Enabled = false;
            this.BtnGuardarEmpresas.Enabled = true;
            this.BtnCancelarEmpresas.Enabled = true;
            this.dtConfiguracionPrincipalDataGridView.Enabled = false;
            this.empresaConfiComboBox.Enabled = false;
            this.Paistxt.Enabled = true;
            this.ProvinciaTxt.Enabled = true;
            this.RegimenIva.Enabled = true;
            this.SerieEmpresa.Enabled = true;
            this.EmpresaRazonTxt.ReadOnly = false;
            this.EmpresaTxt.ReadOnly = false;
            this.DirecionEmpresa.ReadOnly = false;
            this.LocalidadEmpresa.ReadOnly = false;
            this.codigoPostalEmpresaTextBox.ReadOnly = false;
            this.telefonoEmpresaTextBox.ReadOnly = false;
            this.correoEmpresaTextBox.ReadOnly = false;
            this.wepEmpresaTextBox.ReadOnly = false;
            this.EmpresaRazonTxt.ReadOnly = false;
            this.telefono2EmpresaTextBox.ReadOnly = false;
            this.movilEmpresaTextBox.ReadOnly = false;
            this.cifEmpresaTextBox.ReadOnly = false;
            this.BtnImagenEmpresa.Enabled = true;
            this.BtnEliminarImagenE.Enabled = true;
            this.BtnImprimirEmpresa.Enabled = true;//PARA SEGUIR PASOS VALIDACION EMPRESAS
        }
        private void BtnImagenEmpresa_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Title = "Nueva Imagen Empresa";
            openFileDialog1.FileName = "Logo Empresa";
            //openFileDialog1.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpg*.jpeg||All files (*.*)|*.*";
            openFileDialog1.Filter = "Archivo De Imagenes|*.jpg;*.jpeg;*.png;*.gif;*.tif;...|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.imagenEmpresaPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void BtnNuevaEmpresa_Click(object sender, EventArgs e)
        {
            this.BtnNuevaEmpresa.Tag = "Nuevo";
            if (ClsConexionSql.SibaseDatosSql)
            {
                if (this.dtConfiguracionPrincipalDataGridView.RowCount > 0)
                {
                    MessageBox.Show("En Esa Base Datos Solo Se Permite Una Empresa", "LIMITE DE EMPRESAS", MessageBoxButtons.OK);
                    return;
                }
            }
            try
            {

                int numeroFILA = this.dtConfiguracionPrincipalDataGridView.Rows.Count;
                if (numeroFILA > 5)
                {
                    MessageBox.Show("Maximo Permitido De Empresas", "LIMITE");
                    return;
                }
                this.dtConfiguracionPrincipalDataGridView.Sort(this.dtConfiguracionPrincipalDataGridView.Columns[0], ListSortDirection.Ascending);
                this.dtConfiguracionPrincipalBindingSource.AddNew();

                if (this.dtConfiguracionPrincipalDataGridView.CurrentCell.RowIndex == 0)
                {
                    this.idEmpresa.Text = "1";
                    this.dtConfiguracionPrincipalDataGridView.Rows[0].Cells[0].Value = "1";
                }
                if (numeroFILA > 0)
                {
                    if (this.dtConfiguracionPrincipalDataGridView.Rows[numeroFILA - 1].Cells[0].Value.ToString() == string.Empty)
                    {
                        Random r = new Random();
                        int VALORid = r.Next(50000, 100000000);
                        this.dtConfiguracionPrincipalDataGridView.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.idEmpresa.Text = VALORid.ToString();
                    }
                    else
                    {
                        int VALORid = Convert.ToInt32(this.dtConfiguracionPrincipalDataGridView.Rows[numeroFILA - 1].Cells[0].Value) + 1;
                        this.dtConfiguracionPrincipalDataGridView.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.idEmpresa.Text = VALORid.ToString();
                    }

                }
                this.EmpresaTxt.Text = "Nombre Tu Empresa";
                ModficarOjetos_E();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnModificarEmpresa_Click(object sender, EventArgs e)
        {
            if (this.dtConfiguracionPrincipalBindingSource.Count > 0)
            {
                this.BtnNuevaEmpresa.Tag = "Modificar";
                if (!string.IsNullOrEmpty(this.EmpresaRazonTxt.Text))
                {
                    this.RazonSocial = this.EmpresaRazonTxt.Text;
                }
                if (!string.IsNullOrEmpty(this.EmpresaTxt.Text))
                {
                    this.Empresa = this.EmpresaTxt.Text;
                }
                if (!string.IsNullOrEmpty(this.DirecionEmpresa.Text))
                {
                    this.Direcion = this.DirecionEmpresa.Text;
                }
                if (!string.IsNullOrEmpty(this.LocalidadEmpresa.Text))
                {
                    this.Localidad = this.LocalidadEmpresa.Text;
                }
                if (!string.IsNullOrEmpty(this.telefonoEmpresaTextBox.Text))
                {
                    this.Telefono = this.telefonoEmpresaTextBox.Text;
                }
                if (!string.IsNullOrEmpty(this.telefono2EmpresaTextBox.Text))
                {
                    this.Telefono2 = this.telefono2EmpresaTextBox.Text;
                }

                if (!string.IsNullOrEmpty(this.wepEmpresaTextBox.Text))
                {
                    this.Web = this.wepEmpresaTextBox.Text;
                }
                if (!string.IsNullOrEmpty(this.cifEmpresaTextBox.Text))
                {
                    this.Cif = this.cifEmpresaTextBox.Text;
                }
                if (!string.IsNullOrEmpty(this.codigoPostalEmpresaTextBox.Text))
                {
                    this.CodigoPostal = this.codigoPostalEmpresaTextBox.Text;
                }

                if (!string.IsNullOrEmpty(this.RegimenIva.Text))
                {
                    this.Iva = this.RegimenIva.Text;
                }
                if (!string.IsNullOrEmpty(this.SerieEmpresa.Text))
                {
                    this.Serie = this.SerieEmpresa.Text;
                }


                ModficarOjetos_E();
            }
        }
        private void GuardarEmpresasSql()
        {
            if (EspacioDiscosConfi(Directory.GetCurrentDirectory(), 25))
            {
                int Id_Confi = 1;
                String ConsultaDescuetos = "";
                string consulta = "";
                string Almacenes = "  INSERT INTO [DtAlmacenes]([Id],[Almacenes],[Enlace_Almacenes]) VALUES(@Id,@Almacenes,@Enlace_Almacenes)";
                if (this.BtnNuevaEmpresa.Tag.ToString() == "Nuevo")
                {
                    ConsultaDescuetos = " INSERT INTO [DtTarifaTipo]([Id],[TarifaTipo],[EnlaceTarifa]) VALUES( @Id, @TarifaTipo, @EnlaceTarifa)";
                    consulta = "  INSERT INTO [DtConfiguracionPrincipal]([EmpresaConfi],[IdEmpresa],[NombreEmpresa],[DireccionEmpresa],[LocalidadEmpresa]" +
                 " ,[CodigoPostalEmpresa],[ProvinciaEmpresa],[TelefonoEmpresa],[CorreoEmpresa],[WepEmpresa] ,[RegimenIvaEmpresa]" +
                     " ,[PaisEmpresa],[SerieDeFacturacionEmpresa],[Telefono2Empresa],[MovilEmpresa],[CifEmpresa],[NombreEmpresaReguistro]" +
                     "  ,[ImagenEmpresa])  VALUES( @EmpresaConfi, @IdEmpresa, @NombreEmpresa, @DireccionEmpresa, @LocalidadEmpresa," +
                       " @CodigoPostalEmpresa, @ProvinciaEmpresa, @TelefonoEmpresa, @CorreoEmpresa, @WepEmpresa, @RegimenIvaEmpresa," +
                       " @PaisEmpresa, @SerieDeFacturacionEmpresa, @Telefono2Empresa, @MovilEmpresa, @CifEmpresa, @ImagenEmpresa)";


                }
                else
                {
                    ConsultaDescuetos = " UPDATE [DtTarifaTipo] SET [Id] = @Id,[TarifaTipo] =@TarifaTipo,[EnlaceTarifa]= @EnlaceTarifa";
                    consulta = "UPDATE [DtConfiguracionPrincipal] SET [EmpresaConfi] = @EmpresaConfi,[IdEmpresa] = @IdEmpresa, [NombreEmpresa] = @NombreEmpresa, " +
                        "[DireccionEmpresa] = @DireccionEmpresa, [LocalidadEmpresa] = @LocalidadEmpresa,[CodigoPostalEmpresa] = @CodigoPostalEmpresa,  [ProvinciaEmpresa] = @ProvinciaEmpresa, " +
                        " [TelefonoEmpresa] = @TelefonoEmpresa, [CorreoEmpresa] = @CorreoEmpresa,  [WepEmpresa] = @WepEmpresa, [RegimenIvaEmpresa] = @RegimenIvaEmpresa, [PaisEmpresa] = @PaisEmpresa, " +
                        " [SerieDeFacturacionEmpresa] = @SerieDeFacturacionEmpresa, [Telefono2Empresa] = @Telefono2Empresa, [MovilEmpresa] = @MovilEmpresa, [CifEmpresa] = @CifEmpresa, " +
                        " [ImagenEmpresa] = @ImagenEmpresa  WHERE IdEmpresa = @IdEmpresa";
                }
                ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);


                try
                {
                    if (NuevaConexion.SiConexionSql)
                    {

                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@EmpresaConfi", string.IsNullOrEmpty(this.EmpresaRazonTxt.Text) ? (object)DBNull.Value : this.EmpresaRazonTxt.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@IdEmpresa", string.IsNullOrEmpty(this.idEmpresa.Text) ? (object)DBNull.Value : Convert.ToInt32(this.idEmpresa.Text));
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@NombreEmpresa", string.IsNullOrEmpty(this.EmpresaTxt.Text) ? (object)DBNull.Value : this.EmpresaTxt.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@DireccionEmpresa", string.IsNullOrEmpty(this.DirecionEmpresa.Text) ? (object)DBNull.Value : this.DirecionEmpresa.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@LocalidadEmpresa", string.IsNullOrEmpty(this.LocalidadEmpresa.Text) ? (object)DBNull.Value : this.LocalidadEmpresa.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@CodigoPostalEmpresa", string.IsNullOrEmpty(this.codigoPostalEmpresaTextBox.Text) ? (object)DBNull.Value : this.codigoPostalEmpresaTextBox.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@ProvinciaEmpresa", string.IsNullOrEmpty(this.ProvinciaTxt.Text) ? (object)DBNull.Value : this.ProvinciaTxt.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@TelefonoEmpresa", string.IsNullOrEmpty(this.telefonoEmpresaTextBox.Text) ? (object)DBNull.Value : this.telefonoEmpresaTextBox.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@CorreoEmpresa", string.IsNullOrEmpty(this.correoEmpresaTextBox.Text) ? (object)DBNull.Value : this.correoEmpresaTextBox.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@WepEmpresa", string.IsNullOrEmpty(this.wepEmpresaTextBox.Text) ? (object)DBNull.Value : this.wepEmpresaTextBox.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@RegimenIvaEmpresa", string.IsNullOrEmpty(this.RegimenIva.Text) ? (object)DBNull.Value : this.RegimenIva.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@PaisEmpresa", string.IsNullOrEmpty(this.Paistxt.Text) ? (object)DBNull.Value : this.Paistxt.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@SerieDeFacturacionEmpresa", string.IsNullOrEmpty(this.SerieEmpresa.Text) ? (object)DBNull.Value : this.SerieEmpresa.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@Telefono2Empresa", string.IsNullOrEmpty(this.telefono2EmpresaTextBox.Text) ? (object)DBNull.Value : this.telefono2EmpresaTextBox.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@MovilEmpresa", string.IsNullOrEmpty(this.movilEmpresaTextBox.Text) ? (object)DBNull.Value : this.movilEmpresaTextBox.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@CifEmpresa", string.IsNullOrEmpty(this.cifEmpresaTextBox.Text) ? (object)DBNull.Value : this.cifEmpresaTextBox.Text);
                        //  NuevaConexion.ComandoSql.Parameters.AddWithValue("@ImagenEmpresa", (imagenEmpresaPictureBox.Image) == null ? (object) DBNull.Value :Convert.ToByte( ConvertirImagen(imagenEmpresaPictureBox)));
                        byte[] IMAGENnUEVA = ConvertirImagen(this.imagenEmpresaPictureBox);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@ImagenEmpresa", IMAGENnUEVA);
                        NuevaConexion.ComandoSql.ExecuteNonQuery();
                        this.dtConfiguracionPrincipalBindingSource.EndEdit();
                        Validate();
                        if (this.BtnNuevaEmpresa.Tag.ToString() == "Nuevo")
                        {
                            NuevaConexion = new ClsConexionSql(ConsultaDescuetos);////Guarda Descuentos Clientes
                            string Tarifa = "Pvp";
                            if (NuevaConexion.SiConexionSql)
                            {
                                for (int Fila = 1; Fila < 8; Fila++)
                                {

                                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", Fila);
                                    if (Fila == 6)
                                    {

                                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@TarifaTipo", "IVA");
                                        FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtTarifaTipo.Rows.Add(Fila, "IVA" + Fila.ToString(), this.idEmpresa.Text);
                                    }
                                    else
                                    {
                                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@TarifaTipo", Tarifa + Fila.ToString());
                                        FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtTarifaTipo.Rows.Add(Fila, Tarifa + Fila.ToString(), this.idEmpresa.Text);
                                    }

                                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@EnlaceTarifa", string.IsNullOrEmpty(this.idEmpresa.Text) ? (object)DBNull.Value : Convert.ToInt32(this.idEmpresa.Text));
                                    NuevaConexion.ComandoSql.ExecuteNonQuery();
                                    NuevaConexion.ComandoSql.Parameters.Clear();

                                }
                                string Basica = "Mi Configurarcion Nueva  " + String.Format("{0:yyyy}", DateTime.Now);
                                string Ejercicio = "EJERCICIO   " + String.Format("{0:yyyy}", DateTime.Now);
                                String ConsultaEjercios = "INSERT INTO [DtConfi] ([IdEnlace],[EmpresaENLACE],[ConfiguraccionBasica] ,[TipoInpuestoIVA],[EjerciciosDeAño],[IdConexionConfi]," +
                                      "[AñoDeEjercicio]) VALUES(@IdEnlace,@EmpresaENLACE, @ConfiguraccionBasica, @TipoInpuestoIVA, @EjerciciosDeAño, @IdConexionConfi," +
                                         "  @AñoDeEjercicio)";

              
                                NuevaConexion = new ClsConexionSql(Almacenes);////Guarda almacen
                                if (NuevaConexion.SiConexionSql)
                                {
                                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", 1);
                                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Almacenes", "Almacen Central");
                                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Enlace_Almacenes", Convert.ToInt32(this.idEmpresa.Text));
                                    NuevaConexion.ComandoSql.ExecuteNonQuery();
                                    NuevaConexion.ComandoSql.Parameters.Clear();
                                    FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtAlmacenes.Rows.Add(1, "Almacen Central", Convert.ToInt32(this.idEmpresa.Text));
                                }
                                if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfi.Count > 0)
                                {
                                    consulta = "Select max(IdEnlace) from [DtConfi]";
                                    NuevaConexion = new ClsConexionSql(consulta);
                                    if (NuevaConexion.SiConexionSql)
                                    {
                                        SqlDataReader reader = NuevaConexion.ComandoSql.ExecuteReader();
                                        if (reader.Read())
                                        {
                                            if (!string.IsNullOrEmpty((reader[0]).ToString()))
                                            {
                                                Id_Confi = Convert.ToInt32(reader[0].ToString());
                                                Id_Confi++;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Falta Id Conexion", "ERROR CONFI 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                return;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Falta Id Conexion", "ERROR CONFI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                    }
                                    NuevaConexion = new ClsConexionSql(ConsultaEjercios);////Guarda Ejercicio a empresa
                                    if (NuevaConexion.SiConexionSql)
                                    {
                                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@IdEnlace", string.IsNullOrEmpty(Id_Confi.ToString()) ? (object)DBNull.Value : Id_Confi);
                                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@EmpresaENLACE", string.IsNullOrEmpty(this.idEmpresa.Text) ? (object)DBNull.Value : Convert.ToInt32(this.idEmpresa.Text));
                                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@ConfiguraccionBasica", Basica);
                                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@TipoInpuestoIVA", 21);
                                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@EjerciciosDeAño", Ejercicio);
                                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@IdConexionConfi", 1);
                                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@AñoDeEjercicio", String.Format("{0:yyyy}", DateTime.Now));
                                        NuevaConexion.ComandoSql.ExecuteNonQuery();
                                        NuevaConexion.ComandoSql.Parameters.Clear();
                                        FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfi.Rows.Add(Basica, 21, Ejercicio, this.idEmpresa.Text, 1,
                                          String.Format("{0:yyyy}", DateTime.Now));
                                    }
                                }
                            }
                            this.dtConfiguracionPrincipalBindingSource.EndEdit();
                            Validate();
                            MessageBox.Show("Se Guardo Correctamente", "GUARDAR EMPRESA ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RestaurarOjetosEmpresa();
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "EMPRESAS",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                finally
                {
                    NuevaConexion.ComandoSql.Parameters.Clear();

                    if (NuevaConexion.CerrarConexionSql)
                    {

                    }

                }

            }


        }

        private void RestaurarOjetosEmpresa()
        {
            this.panelEmpresas.Enabled = true;
            this.BtnGuardarEmpresas.Enabled = false;
            this.BtnCancelarEmpresas.Enabled = false;
            this.dtConfiguracionPrincipalDataGridView.Enabled = true;
            this.empresaConfiComboBox.Enabled = true;
            this.Paistxt.Enabled = false;
            this.ProvinciaTxt.Enabled = false;
            this.RegimenIva.Enabled = false;
            this.SerieEmpresa.Enabled = false;
            this.EmpresaRazonTxt.ReadOnly = true;
            this.EmpresaTxt.ReadOnly = true;
            this.DirecionEmpresa.ReadOnly = true;
            this.LocalidadEmpresa.ReadOnly = true;
            this.codigoPostalEmpresaTextBox.ReadOnly = true;
            this.telefonoEmpresaTextBox.ReadOnly = true;
            this.correoEmpresaTextBox.ReadOnly = true;
            this.wepEmpresaTextBox.ReadOnly = true;
            this.EmpresaRazonTxt.ReadOnly = true;
            this.telefono2EmpresaTextBox.ReadOnly = true;
            this.movilEmpresaTextBox.ReadOnly = true;
            this.cifEmpresaTextBox.ReadOnly = true;
            this.BtnImagenEmpresa.Enabled = false;
            this.BtnEliminarImagenE.Enabled = false;
            this.BtnImprimirEmpresa.Enabled = true;///VALIDACION EMPRESA
            this.dtConfiguracionPrincipalDataGridView.Refresh();
        }
        private byte[] ConvertirImagen(PictureBox pitureImagen)
        {
            MemoryStream memo2 = new MemoryStream();
            if (pitureImagen.Image != null)
            {
                pitureImagen.Image.Save(memo2, System.Drawing.Imaging.ImageFormat.Jpeg);
            }

            return memo2.GetBuffer();
        }
        private void listaTarifa()
        {

        }

        private void GuardarEmpresasDb()
        {
            if (EspacioDiscosConfi(Directory.GetCurrentDirectory(), 20))
            {
                int Id_Confi = 1;
                string Almacenes = "  INSERT INTO [DtAlmacenes]([Id],[Almacenes],[Enlace_Almacenes]) VALUES(@Id,@Almacenes,@Enlace_Almacenes)";
                string consulta = "";
                if (this.BtnNuevaEmpresa.Tag.ToString() == "Nuevo")
                {

                    consulta = "  INSERT INTO [DtConfiguracionPrincipal]([EmpresaConfi],[IdEmpresa],[NombreEmpresa],[DireccionEmpresa],[LocalidadEmpresa]" +
                 " ,[CodigoPostalEmpresa],[ProvinciaEmpresa],[TelefonoEmpresa],[CorreoEmpresa],[WepEmpresa] ,[RegimenIvaEmpresa]" +
                     " ,[PaisEmpresa],[SerieDeFacturacionEmpresa],[Telefono2Empresa],[MovilEmpresa],[CifEmpresa]" +
                     "  ,[ImagenEmpresa])  VALUES( @EmpresaConfi, @IdEmpresa, @NombreEmpresa, @DireccionEmpresa, @LocalidadEmpresa," +
                       " @CodigoPostalEmpresa, @ProvinciaEmpresa, @TelefonoEmpresa, @CorreoEmpresa, @WepEmpresa, @RegimenIvaEmpresa," +
                       " @PaisEmpresa, @SerieDeFacturacionEmpresa, @Telefono2Empresa, @MovilEmpresa, @CifEmpresa, @ImagenEmpresa)";


                }
                else
                {
                    consulta = "UPDATE [DtConfiguracionPrincipal] SET [EmpresaConfi] = @EmpresaConfi,[IdEmpresa] = @IdEmpresa, [NombreEmpresa] = @NombreEmpresa, " +
                        "[DireccionEmpresa] = @DireccionEmpresa, [LocalidadEmpresa] = @LocalidadEmpresa,[CodigoPostalEmpresa] = @CodigoPostalEmpresa,  [ProvinciaEmpresa] = @ProvinciaEmpresa, " +
                        " [TelefonoEmpresa] = @TelefonoEmpresa, [CorreoEmpresa] = @CorreoEmpresa,  [WepEmpresa] = @WepEmpresa, [RegimenIvaEmpresa] = @RegimenIvaEmpresa, [PaisEmpresa] = @PaisEmpresa, " +
                        " [SerieDeFacturacionEmpresa] = @SerieDeFacturacionEmpresa, [Telefono2Empresa] = @Telefono2Empresa, [MovilEmpresa] = @MovilEmpresa, [CifEmpresa] = @CifEmpresa, " +
                        "[ImagenEmpresa] = @ImagenEmpresa  WHERE IdEmpresa = @IdEmpresa";
                }
                ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);


                try
                {
                    if (NuevaConexion.SiConexionDb)
                    {

                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@EmpresaConfi", string.IsNullOrEmpty(this.EmpresaRazonTxt.Text) ? (object)DBNull.Value : this.EmpresaRazonTxt.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@IdEmpresa", string.IsNullOrEmpty(this.idEmpresa.Text) ? (object)DBNull.Value : Convert.ToInt32(this.idEmpresa.Text));
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@NombreEmpresa", string.IsNullOrEmpty(this.EmpresaTxt.Text) ? (object)DBNull.Value : this.EmpresaTxt.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@DireccionEmpresa", string.IsNullOrEmpty(this.DirecionEmpresa.Text) ? (object)DBNull.Value : this.DirecionEmpresa.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@LocalidadEmpresa", string.IsNullOrEmpty(this.LocalidadEmpresa.Text) ? (object)DBNull.Value : this.LocalidadEmpresa.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@CodigoPostalEmpresa", string.IsNullOrEmpty(this.codigoPostalEmpresaTextBox.Text) ? (object)DBNull.Value : this.codigoPostalEmpresaTextBox.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@ProvinciaEmpresa", string.IsNullOrEmpty(this.ProvinciaTxt.Text) ? (object)DBNull.Value : this.ProvinciaTxt.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@TelefonoEmpresa", string.IsNullOrEmpty(this.telefonoEmpresaTextBox.Text) ? (object)DBNull.Value : this.telefonoEmpresaTextBox.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@CorreoEmpresa", string.IsNullOrEmpty(this.correoEmpresaTextBox.Text) ? (object)DBNull.Value : this.correoEmpresaTextBox.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@WepEmpresa", string.IsNullOrEmpty(this.wepEmpresaTextBox.Text) ? (object)DBNull.Value : this.wepEmpresaTextBox.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@RegimenIvaEmpresa", string.IsNullOrEmpty(this.RegimenIva.Text) ? (object)DBNull.Value : this.RegimenIva.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@PaisEmpresa", string.IsNullOrEmpty(this.Paistxt.Text) ? (object)DBNull.Value : this.Paistxt.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@SerieDeFacturacionEmpresa", string.IsNullOrEmpty(this.SerieEmpresa.Text) ? (object)DBNull.Value : this.SerieEmpresa.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@Telefono2Empresa", string.IsNullOrEmpty(this.telefono2EmpresaTextBox.Text) ? (object)DBNull.Value : this.telefono2EmpresaTextBox.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@MovilEmpresa", string.IsNullOrEmpty(this.movilEmpresaTextBox.Text) ? (object)DBNull.Value : this.movilEmpresaTextBox.Text);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@CifEmpresa", string.IsNullOrEmpty(this.cifEmpresaTextBox.Text) ? (object)DBNull.Value : this.cifEmpresaTextBox.Text);
                        //  NuevaConexion.ComandoSql.Parameters.AddWithValue("@ImagenEmpresa", (imagenEmpresaPictureBox.Image) == null ? (object) DBNull.Value :Convert.ToByte( ConvertirImagen(imagenEmpresaPictureBox)));
                        byte[] IMAGENnUEVA = ConvertirImagen(this.imagenEmpresaPictureBox);
                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@ImagenEmpresa", IMAGENnUEVA);
                        NuevaConexion.ComandoDb.ExecuteNonQuery();
                        this.dtConfiguracionPrincipalBindingSource.EndEdit();
                        Validate();
                        if (this.BtnNuevaEmpresa.Tag.ToString() == "Nuevo")
                        {
                            string ConsultaDescuetos = " INSERT INTO [DtTarifaTipo]([Id],[TarifaTipo],[EnlaceTarifa]) VALUES( @Id, @TarifaTipo, @EnlaceTarifa)";
                            string Basica = "Mi Configurarcion Nueva  " + String.Format("{0:yyyy}", DateTime.Now);
                            string Ejercicio = "EJERCICIO " + String.Format("{0:yyyy}", DateTime.Now);
                            String ConsultaEjercios = "INSERT INTO [DtConfi] ([IdEnlace],[EmpresaENLACE],[ConfiguraccionBasica] ,[TipoInpuestoIVA],[EjerciciosDeAño],[IdConexionConfi]," +
                                  "[AñoDeEjercicio]) VALUES(@IdEnlace,@EmpresaENLACE, @ConfiguraccionBasica, @TipoInpuestoIVA, @EjerciciosDeAño, @IdConexionConfi," +
                                     "  @AñoDeEjercicio)";

                            NuevaConexion = new ClsConexionDb(ConsultaDescuetos);////Guarda Descuentos Clientes
                            if (NuevaConexion.SiConexionDb)
                            {

                                string Tarifa = "Pvp";

                                for (int Fila = 1; Fila < 8; Fila++)
                                {


                                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", Fila);
                                    if (Fila == 7)
                                    {

                                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@TarifaTipo", "IVA");
                                        FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtTarifaTipo.Rows.Add(Fila, "IVA", this.idEmpresa.Text);
                                    }
                                    else
                                    {
                                        FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtTarifaTipo.Rows.Add(Fila, Tarifa + Fila.ToString(), this.idEmpresa.Text);
                                        NuevaConexion.ComandoDb.Parameters.AddWithValue("@TarifaTipo", Tarifa + Fila.ToString());
                                    }

                                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@EnlaceTarifa", string.IsNullOrEmpty(this.idEmpresa.Text) ? (object)DBNull.Value : Convert.ToInt32(this.idEmpresa.Text));
                                    NuevaConexion.ComandoDb.ExecuteNonQuery();
                                    NuevaConexion.ComandoDb.Parameters.Clear();

                                }
                            }

                            NuevaConexion = new ClsConexionDb(Almacenes);////Guarda almacen
                            if (NuevaConexion.SiConexionDb)
                            {
                                NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", 1);
                                NuevaConexion.ComandoDb.Parameters.AddWithValue("@Almacenes", "Almacen Central");
                                NuevaConexion.ComandoDb.Parameters.AddWithValue("@Enlace_Almacenes", Convert.ToInt32(this.idEmpresa.Text));
                                NuevaConexion.ComandoDb.ExecuteNonQuery();
                                NuevaConexion.ComandoDb.Parameters.Clear();
                                FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtAlmacenes.Rows.Add(1, "Almacen Central", Convert.ToInt32(this.idEmpresa.Text));
                            }
                            if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfi.Count > 0)
                            {
                                consulta = "Select max(IdEnlace) from [DtConfi]";
                                NuevaConexion = new ClsConexionDb(consulta);
                                if (NuevaConexion.SiConexionDb)
                                {
                                    OleDbDataReader reader = NuevaConexion.ComandoDb.ExecuteReader();
                                    if (reader.Read())
                                    {
                                        if (!string.IsNullOrEmpty((reader[0]).ToString()))
                                        {

                                            Id_Confi = Convert.ToInt32(reader[0].ToString());
                                            Id_Confi++;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Falta Id Conexion", "ERROR CONFI 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                           // return;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Falta Id Conexion", "ERROR CONFI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                       // return;
                                    }

                                }
                            }
                            NuevaConexion = new ClsConexionDb(ConsultaEjercios);//
                            if (NuevaConexion.SiConexionDb)
                            {
                                NuevaConexion.ComandoDb.Parameters.AddWithValue("@IdEnlace", string.IsNullOrEmpty(Id_Confi.ToString()) ? (object)DBNull.Value : Id_Confi);
                                NuevaConexion.ComandoDb.Parameters.AddWithValue("@EmpresaENLACE", string.IsNullOrEmpty(this.idEmpresa.Text) ? (object)DBNull.Value : Convert.ToInt32(this.idEmpresa.Text));
                                NuevaConexion.ComandoDb.Parameters.AddWithValue("@ConfiguraccionBasica", Basica);
                                NuevaConexion.ComandoDb.Parameters.AddWithValue("@TipoInpuestoIVA", 21);
                                NuevaConexion.ComandoDb.Parameters.AddWithValue("@EjerciciosDeAño", Ejercicio);
                                NuevaConexion.ComandoDb.Parameters.AddWithValue("@IdConexionConfi", 1);
                                NuevaConexion.ComandoDb.Parameters.AddWithValue("@AñoDeEjercicio", String.Format("{0:yyyy}", DateTime.Now));
                                NuevaConexion.ComandoDb.ExecuteNonQuery();
                                NuevaConexion.ComandoDb.Parameters.Clear();

                                FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfi.Rows.Add(Basica, 21, Ejercicio, this.idEmpresa.Text, 1,
                                    String.Format("{0:yyyy}", DateTime.Now), Id_Confi);
                            }


                        }
                        this.dtConfiguracionPrincipalBindingSource.EndEdit();
                        Validate();
                        MessageBox.Show("Se Guardo Correctamente", "GUARDAR EMPRESA ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RestaurarOjetosEmpresa();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "EMPRESAS CREAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    NuevaConexion.ComandoDb.Parameters.Clear();

                    if (NuevaConexion.CerrarConexionDB)
                    {

                    }
                }

            }


        }
        private void BtnGuardarEmpresas_Click(object sender, EventArgs e)
        {

            if (this.dtConfiguracionPrincipalBindingSource.Count <= 0 && string.IsNullOrEmpty(this.empresaConfiComboBox.Text))
            {
                MessageBox.Show("Debe al Menos Crear Una Empresa", "EMPRESA");
                return;
            }

            if (EspacioDiscosConfi(Directory.GetCurrentDirectory(), 25))
            {
                try
                {
                    foreach (DataGridViewRow fila in this.dtConfiguracionPrincipalDataGridView.Rows)
                    {
                        if (fila.Cells[1].Value.ToString() == this.EmpresaRazonTxt.Text)
                        {
                            if (this.dtConfiguracionPrincipalDataGridView.CurrentCell.RowIndex == fila.Index)
                            {
                                break;
                            }
                            MessageBox.Show(this.EmpresaRazonTxt.Text.ToString(), "YA EXISTE ESTA EMPRESA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.EmpresaRazonTxt.Focus();
                            this.EmpresaRazonTxt.SelectAll();
                            return;
                        }

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                BorrarErroresEmpresa();


                if (ValidarEmpresa())
                {
                    if (MessageBox.Show(" ¿Aceptar Guardar Empresa ? ", " GUARDAR EMPRESA ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (ClsConexionSql.SibaseDatosSql)
                        {
                            GuardarEmpresasSql();
                        }
                        else
                        {

                            if (File.Exists(ClasDatos.RutaBaseDatosDb))
                            {
                                GuardarEmpresasDb();
                            }
                            else
                            {
                                MessageBox.Show("Archivo No Se Encuentra", " FALLO AL GUARDAR ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                this.panelEmpresas.Enabled = false;
                            }
                        }
                    }
                }
            }

        }

        private void BtnCancelarEmpresas_Click(object sender, EventArgs e)
        {
            BorrarErroresEmpresa();
            if (this.dtConfiguracionPrincipalBindingSource.Count > 0)
            {
                if (this.BtnNuevaEmpresa.Tag.ToString() == "Nuevo")
                {
                    if (this.dtConfiguracionPrincipalDataGridView.RowCount >= 0)
                    {
                        this.dtConfiguracionPrincipalDataGridView.Rows.RemoveAt(this.dtConfiguracionPrincipalDataGridView.CurrentCell.RowIndex);
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(this.RazonSocial))
                    {
                        this.EmpresaRazonTxt.Text = this.RazonSocial;
                    }
                    else
                    {
                        this.EmpresaRazonTxt.Text = "";
                    }
                    if (!string.IsNullOrEmpty(this.Empresa))
                    {
                        this.EmpresaTxt.Text = this.Empresa;
                    }
                    else
                    {
                        this.EmpresaTxt.Text = "";
                    }
                    if (!string.IsNullOrEmpty(this.Direcion))
                    {
                        this.DirecionEmpresa.Text = this.Direcion;
                    }
                    else
                    {
                        this.DirecionEmpresa.Text = "";
                    }
                    if (!string.IsNullOrEmpty(this.Localidad))
                    {
                        this.LocalidadEmpresa.Text = this.Localidad;
                    }
                    else
                    {
                        this.LocalidadEmpresa.Text = "";
                    }
                    if (!string.IsNullOrEmpty(this.Telefono))
                    {
                        this.telefonoEmpresaTextBox.Text = this.Telefono;
                    }
                    else
                    {
                        this.telefonoEmpresaTextBox.Text = "";
                    }
                    if (!string.IsNullOrEmpty(this.Telefono2))
                    {
                        this.telefono2EmpresaTextBox.Text = this.Telefono2;
                    }
                    else
                    {
                        this.telefono2EmpresaTextBox.Text = "";
                    }

                    if (!string.IsNullOrEmpty(this.Web))
                    {
                        this.wepEmpresaTextBox.Text = this.Web;
                    }
                    else
                    {
                        this.wepEmpresaTextBox.Text = "";
                    }
                    if (!string.IsNullOrEmpty(this.Cif))
                    {
                        this.cifEmpresaTextBox.Text = this.Cif;
                    }
                    else
                    {
                        this.cifEmpresaTextBox.Text = "";
                    }
                    if (!string.IsNullOrEmpty(this.CodigoPostal))
                    {
                        this.codigoPostalEmpresaTextBox.Text = this.CodigoPostal;
                    }
                    else
                    {
                        this.codigoPostalEmpresaTextBox.Text = "";
                    }

                    if (!string.IsNullOrEmpty(this.Iva))
                    {
                        this.RegimenIva.Text = this.Iva;
                    }
                    else
                    {
                        this.RegimenIva.Text = "";
                    }
                    if (!string.IsNullOrEmpty(this.Serie))
                    {
                        this.SerieEmpresa.Text = this.Serie;
                    }
                    else
                    {
                        this.SerieEmpresa.Text = "";
                    }

                }

            }
            RestaurarOjetosEmpresa();
        }

        private void BtnSalirEmpresa_Click(object sender, EventArgs e)
        {
            if (this.BtnGuardarEmpresas.Enabled == false)
            {

                if (MessageBox.Show(" ¿Salir Empresas ? ", " SALIR ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

        private void BtnEliminarImagenE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Elimar Imagen ", " IMAGEN ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.imagenEmpresaPictureBox.Image = (null);
            }

        }
        private void EliminarEmpresaBb()
        {

            if (File.Exists(ClasDatos.RutaBaseDatosDb))
            {
                string consulta = "Delete from  [DtConfiguracionPrincipal]   WHERE IdEmpresa= @IdEmpresa";
                ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
                try
                {
                    {
                        if (NuevaConexion.SiConexionDb)
                        {
                            NuevaConexion.ComandoDb.Parameters.AddWithValue("@IdEmpresa", Convert.ToInt32(this.idEmpresa.Text));
                            NuevaConexion.ComandoDb.ExecuteNonQuery();
                            this.dtConfiguracionPrincipalDataGridView.Rows.RemoveAt(this.dtConfiguracionPrincipalDataGridView.CurrentCell.RowIndex);
                            this.dtConfiguracionPrincipalBindingSource.EndEdit();
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
            else
            {
                MessageBox.Show("El Archivo No Se Encuentra", "ARCHIVO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
        }
        private void EliminarEmpresaSql()
        {
            string consulta = "Delete from  [DtConfiguracionPrincipal]   WHERE IdEmpresa= @IdEmpresa";
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                {
                    if (NuevaConexion.SiConexionSql)
                    {
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@IdEmpresa", Convert.ToInt32(this.idEmpresa.Text));
                        NuevaConexion.ComandoSql.ExecuteNonQuery();
                        this.dtConfiguracionPrincipalDataGridView.Rows.RemoveAt(this.dtConfiguracionPrincipalDataGridView.CurrentCell.RowIndex);
                        this.dtConfiguracionPrincipalBindingSource.EndEdit();
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
        private void BtnEliminarEmpresa_Click(object sender, EventArgs e)
        {
            if (FormMenuPrincipal.menu2principal.SiOpenFatu == 0)
            {
                if (this.dtConfiguracionPrincipalBindingSource.Count > 0)
                {
                    if (MessageBox.Show("Desea Eliminar Permanentemente y Todo su Contenido", "ELIMINAR ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {

                        if (ClsConexionSql.SibaseDatosSql)
                        {
                            EliminarEmpresaSql();
                        }
                        else
                        {
                            EliminarEmpresaBb();
                        }


                    }
                }
            }
            else
            {
                MessageBox.Show("Debe Cerrar Formulario De  ((( FACTURACION )))", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EmpresaRazonTxt_TextChanged(object sender, EventArgs e)
        {
            if (this.BtnNuevaEmpresa.Tag.ToString() == "Nuevo")
            {
                ///  this.EmpresaReguistro.Text = this.EmpresaRazonTxt.Text;///NO HACE FALTA
            }
        }

        private void FormEmpresas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.BtnGuardarEmpresas.Enabled == true)
            {
                e.Cancel = true;
            }
        }

        private void BtnImprimirEmpresa_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
            SystemSounds.Beep.Play();
        }

        private void BtnBuscarEmpresa_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }


    }
}
