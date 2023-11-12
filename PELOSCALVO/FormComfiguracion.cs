using Conexiones;
using Microsoft.Reporting.WinForms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
//using Windows.Storage.Pickers;
//using PELOSCALVO.Datos;

namespace PELOSCALVO
{
    public partial class FormComfiguracion : Form
    {
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
            if (this.idConexionConfiTextBox.Text.Length < 1)
            {
                ok = false;
                this.errorProvider1Confi.SetError(this.idConexionConfiTextBox, "_ingresar Id valido (( minimo 4 Caracteres))");
            }
            if (this.configuraccionBasicaTextBox.Text.Length < 4)
            {
                ok = false;
                this.errorProvider1Confi.SetError(this.configuraccionBasicaTextBox, "_ingresar Descripccion valido (( minimo 4 Caracteres))");
            }
            if (this.ejerciciosDeAñoTextBox.Text.Length < 4)
            {
                ok = false;
                this.errorProvider1Confi.SetError(this.ejerciciosDeAñoTextBox, "_ingresar Ejercicio valido (( minimo 4 Caracteres))");
            }
            if (this.empresaENLACETextBox.Text.Length < 4)
            {
                ok = false;
                this.errorProvider1Confi.SetError(this.empresaENLACETextBox, "_ingresar Enlace Empresa valido (( minimo 4 Caracteres))");
                if (this.añoDeEjercicioTextBox.Text.Length < 4)
                {
                    ok = false;
                    this.errorProvider1Confi.SetError(this.añoDeEjercicioTextBox, "_ingresar Año valido (( minimo 4 Caracteres))");
                }
            }
            return ok;
        }
        private void BorrarErroresBasica()
        {
            this.errorProvider1Confi.SetError(this.idConexionConfiTextBox, "");
            this.errorProvider1Confi.SetError(this.configuraccionBasicaTextBox, "");
            this.errorProvider1Confi.SetError(this.ejerciciosDeAñoTextBox, "");
            this.errorProvider1Confi.SetError(this.empresaENLACETextBox, "");
            this.errorProvider1Confi.SetError(this.añoDeEjercicioTextBox, "");
        }
        private bool ValidarEmpresa()
        {
            bool ok = true;
            if (string.IsNullOrEmpty(this.idEmpresaTextBox.Text))
            {
                ok = false;
                this.errorProvider1Confi.SetError(this.idEmpresaTextBox, "_ingresar Id valido (( FALTA  ID  ))");
            }
            if (this.empresaConfiTextBox.Text.Length < 4)
            {
                ok = false;
                this.errorProvider1Confi.SetError(this.empresaConfiTextBox, "_ingresar Nonbre empresa valido (( minimo 4 Caracteres))");
            }
            if (this.nombreEmpresaTextBox.Text.Length < 4)
            {
                ok = false;
                this.errorProvider1Confi.SetError(this.nombreEmpresaTextBox, "_ingresar Razon Social valido (( minimo 4 Caracteres))");
            }
            if (this.direccionEmpresaTextBox.Text.Length < 4)
            {
                ok = false;
                this.errorProvider1Confi.SetError(this.direccionEmpresaTextBox, "_ingresar Direccion valido (( minimo 4 Caracteres))");
            }

            return ok;
        }
        private void BorrarErroresEmpresa()
        {
            this.errorProvider1Confi.SetError(this.idEmpresaTextBox, "");
            this.errorProvider1Confi.SetError(this.empresaConfiTextBox, "");
            this.errorProvider1Confi.SetError(this.nombreEmpresaTextBox, "");
            this.errorProvider1Confi.SetError(this.direccionEmpresaTextBox, "");
            this.errorProvider1Confi.SetError(this.EmpresaReguistro, "");
        }
        private bool ValidarTipoTarifa()
        {
            bool ok = true;
            if (this.tarifaTipoTextBox.Text.Length < 3)
            {
                ok = false;
                this.errorProvider1Confi.SetError(this.tarifaTipoTextBox, "_ingresar Descuento valido (( minimo 3 Caracteres))");
            }
            return ok;
        }
        private void BorrarErroresTipoTarifa()
        {
            this.errorProvider1Confi.SetError(this.tarifaTipoTextBox, "");
        }
        private bool ValidarArchivo()
        {
            bool ok = true;
            if (this.idTextBox.Text.Length < 1)
            {
                ok = false;
                this.errorProvider1Confi.SetError(this.idTextBox, "_ingresar Id valido (( minimo 4 Caracteres))");
            }
            if (this.nombreArchivoDatosTextBox.Text.Length < 4)
            {
                ok = false;
                this.errorProvider1Confi.SetError(this.nombreArchivoDatosTextBox, "_ingresar Nombre valido (( minimo 4 Caracteres))");
            }
            if (this.descripcionArchivoDatosTextBox.Text.Length < 4)
            {
                ok = false;

                this.errorProvider1Confi.SetError(this.descripcionArchivoDatosTextBox, "_ingresar Descripccion valido (( minimo 4 Caracteres))");
            }
            if (this.directorioArchivoDatosTextBox.Text.Length < 4)
            {
                ok = false;
                this.errorProvider1Confi.SetError(this.directorioArchivoDatosTextBox, "_ingresar Directorio Empresa valido (( minimo 4 Caracteres))");
            }
            return ok;
        }
        private void BorrarErroresArchivo()
        {
            this.errorProvider1Confi.SetError(this.idTextBox, "");
            this.errorProvider1Confi.SetError(this.nombreArchivoDatosTextBox, "");
            this.errorProvider1Confi.SetError(this.descripcionArchivoDatosTextBox, "");
            this.errorProvider1Confi.SetError(this.directorioArchivoDatosTextBox, "");
        }
        private bool ValidarInicio()
        {
            bool ok = true;
            if (this.empresaInicio.Text.Length < 3)
            {
                ok = false;
                this.errorProvider1Confi.SetError(this.empresaInicio, "_ingresar Empresa valido (( minimo 3 Caracteres))");
            }
            if (this.EjercicioInicio.Text.Length < 3)
            {
                ok = false;
                this.errorProvider1Confi.SetError(this.EjercicioInicio, "_ingresar Ejercicio valido (( minimo 3 Caracteres))");
            }
            if (this.SerieInicio.Text.Length < 1)
            {
                ok = false;
                this.errorProvider1Confi.SetError(this.SerieInicio, "_ingresar Serie valido (( minimo 1 Caracteres))");
            }
            if (this.PaisInicio.Text.Length < 3)
            {
                ok = false;
                this.errorProvider1Confi.SetError(this.PaisInicio, "_ingresar Pais valido (( minimo 3 Caracteres))");
            }
            if (this.provinciaInicio.Text.Length < 3)
            {
                ok = false;
                this.errorProvider1Confi.SetError(this.provinciaInicio, "_ingresar Provincia valido (( minimo 3 Caracteres))");
            }
            return ok;
        }
        private void BorrarErroresInicio()
        {
            this.errorProvider1Confi.SetError(this.empresaInicio, "");
            this.errorProvider1Confi.SetError(this.tarifaTipoTextBox, "");
            this.errorProvider1Confi.SetError(this.PaisInicio, "");
            this.errorProvider1Confi.SetError(this.provinciaInicio, "");
            this.errorProvider1Confi.SetError(this.SerieInicio, "");
        }

        public FormComfiguracion()
        {
            InitializeComponent();
        }
        private void CrearArchivos_Xml_Confi()
        {
            if (EspacioDiscosConfi(ClasDatos.RutaDatosPrincipal, 30))
            {
                try
                {
                    if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal))
                    {
                        DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());
                        dir.CreateSubdirectory(ClasDatos.RutaDatosPrincipal);
                    }

                    for (int i = 1; i <= 5; i++)
                    {
                        if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + ClasDatos.RutaDatosPrincipal + " FN" + i))
                        {
                            DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal);
                            dir.CreateSubdirectory(ClasDatos.RutaDatosPrincipal + " FN" + i);
                        }
                    }
                    if (!File.Exists(ClasDatos.RutaConfiguracionXml))
                    {
                        FormMenuPrincipal.menu2principal.CrearArchivosXml(ClasDatos.RutaConfiguracionXml);///solo crear no Abrir
                    }
                    if (!File.Exists(ClasDatos.RutaMultidatos))
                    {
                        FormMenuPrincipal.menu2principal.CrearArchivosXml(ClasDatos.RutaMultidatos);
                    }
                    if (!File.Exists(ClasDatos.RutaMulti2))
                    {
                        FormMenuPrincipal.menu2principal.CrearArchivosXml(ClasDatos.RutaMulti2);
                    }
                    if (!File.Exists(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + "Servidores.Xml"))
                    {
                        FormMenuPrincipal.menu2principal.CrearArchivosXml(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + "Servidores.Xml");
                    }

                    MessageBox.Show("Sistema Restructurado Con Exito", "SISTEMA", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "SISTEMA ERROR", MessageBoxButtons.OK);

                }
            }
        }
        private void FormComfiguracion_Load(object sender, EventArgs e)
        {
            // System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Articulos.accdb");
            try
            {
                if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION != null)
                {
                    this.dtConfiguracionPrincipalBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION;
                    this.dtConfiBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION;
                    this.dtConfiguracionPrincipalBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION;
                    this.dtTarifaTipoBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION;

                }
                if (FormMenuPrincipal.menu2principal.dsMulti2 != null)
                {
                    this.dtObrasBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2;
                    this.dtProvinciasBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2;
                    this.dtPaisesBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2;
                    this.dtObrasBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2;
                }
                if (FormMenuPrincipal.menu2principal.dsMultidatos != null)
                {
                    this.dtInicioMultiBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMultidatos;
                    this.dtFamiliaProductosBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMultidatos;
                    this.dtArchivoDatosMultiBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMultidatos;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            this.tabCONFIGURACION.Parent = null;
            this.tabFAMILIAproductos.Parent = null;
            this.tabPageEmpresas.Parent = null;
            this.tabPageTarifa.Parent = null;
            this.tabPageInicio.Parent = null;
            this.tabPageArchivo.Parent = null;
            this.tabPagePaises.Parent = null;
            this.TabPageProvincias.Parent = null;
            this.Almacenes.Parent = null;
            this.tabObras.Parent = null;
            this.tabProveedores.Parent = null;

            //dtObrasBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2;
            //dtProvinciasBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2;
            if (!File.Exists(ClasDatos.RutaMultidatos))
            {
                MessageBox.Show("Archivo : " + ClasDatos.RutaMultidatos, "DEBE RESTRUCTURAR ARCHIVOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            if (!File.Exists(ClasDatos.RutaMulti2))
            {
                MessageBox.Show("Archivo : " + ClasDatos.RutaMulti2, "DEBE RESTRUCTURAR ARCHIVOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            if (!File.Exists(ClasDatos.RutaConfiguracionXml))
            {
                MessageBox.Show("Archivo : " + ClasDatos.RutaConfiguracionXml, "DEBE RESTRUCTURAR ARCHIVOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            if (ClsConexionSql.SibaseDatosSql)
            {
                this.panelAlmacenes.Visible = true;
                this.PanelProveedores.Visible = true;
                this.tooInicio.Visible = false;
                this.dataGridAlmacenes.Columns[2].Visible = false;
                this.dataGridProveedores.Columns[2].Visible = false;
                this.dataGridObras.Columns[2].Visible = false;
                this.DataGridFamilias.Columns[1].Visible = false;
                this.archivoArticulosComboBox.Items.Clear();
                this.serieArticulosComboBox.Items.Clear();
                this.serieClientesComboBox.Items.Clear();
                this.archivoClientesComboBox.Items.Clear();
            }
            else
            {
                if (this.dtConfiguracionPrincipalDtConfiBindingSource.Count >= 0)
                {
                    String variable1 = " De Articulos";
                    String variable2 = " De Clientes";
                    if (this.tipoExtensionArticulosComboBox.Text == "DBF")
                    {
                        variable1 = "";
                    }

                    for (int i = 1; i <= 6; i++)
                    {

                        string Archivo = "Tarifa" + i;
                        string Ruta = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + Archivo + variable1 + "." + this.tipoExtensionArticulosComboBox.Text;
                        if (File.Exists(Ruta))
                        {
                            this.archivoArticulosComboBox.Items.Add(Archivo.ToString());
                            this.serieArticulosComboBox.Items.Add(Archivo.ToString());
                        }

                    }
                    if (this.tipoExtensionArticulosComboBox.Text == "DBF")
                    {
                        variable2 = "";
                    }
                    for (int i = 1; i <= 6; i++)
                    {

                        string Archivo2 = "Listado" + i;
                        string Ruta = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + Archivo2 + variable2 + "." + this.tipoExtensionArticulosComboBox.Text;
                        if (File.Exists(Ruta))
                        {
                            this.serieClientesComboBox.Items.Add(Archivo2.ToString());
                            this.archivoClientesComboBox.Items.Add(Archivo2.ToString());
                        }

                    }

                }

            }

            try
            {
                if (FormMenuPrincipal.menu2principal.dsMultidatos.DtArchivoDatosMulti.Count <= 0)
                {
                    this.dtArchivoDatosMultiBindingSource.AddNew();
                    this.dataGridViewDatos.Rows[0].Cells[0].Value = 1;
                    this.dataGridViewDatos.Rows[0].Cells[1].Value = "Archivo Inicial";
                    this.dataGridViewDatos.Rows[0].Cells[2].Value = Directory.GetCurrentDirectory();
                    this.dataGridViewDatos.Rows[0].Cells[3].Value = "Guarda Datos Aplicacion Principal";
                    this.dtInicioMultiBindingSource.AddNew();
                    this.dtInicioMultiBindingSource.EndEdit();
                    this.dataGridViewDatos.EndEdit();
                    this.dtInicioDataGridView.Rows[0].Cells[0].Value = Directory.GetCurrentDirectory();
                    this.rutaArchivoDatosTextBox.Text = Directory.GetCurrentDirectory();
                    ClasDatos.ArchivoInicioFacturas = Directory.GetCurrentDirectory();
                    this.dtArchivoDatosMultiBindingSource.EndEdit();
                    this.dataGridViewDatos.EndEdit();
                    if (EspacioDiscosConfi(ClasDatos.RutaConfiguracionXml, 20))
                    {
                        if (File.Exists(ClasDatos.RutaMultidatos))
                        {
                            FormMenuPrincipal.menu2principal.dsMultidatos.WriteXml(ClasDatos.RutaMultidatos);
                        }
                        else
                        {
                            MessageBox.Show("Falta Archivo", "FALTA ARCHIVO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                    }



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

            try
            {
                if (FormMenuPrincipal.menu2principal.dsMultidatos.DtArchivoDatosMulti.Count > 0)
                {
                    if (FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["RutaArchivoDatos"].ToString() != string.Empty)
                    {
                        this.idComboBox.Text = FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["RutaArchivoDatos"].ToString();
                    }
                }
            }
            catch (Exception)
            {

                //  throw;
            }

        }

        private void TabControl1_MouseEnter(object sender, EventArgs e)
        {
            FormMenuPrincipal.menu2principal.panelventas.Visible = false;
            FormMenuPrincipal.menu2principal.panelSUBventas.Visible = false;
        }

        private void TabMENU_MouseEnter(object sender, EventArgs e)
        {
            FormMenuPrincipal.menu2principal.panelventas.Visible = false;
            FormMenuPrincipal.menu2principal.panelSUBventas.Visible = false;
        }


        private void TabCONFIGURACION_MouseEnter(object sender, EventArgs e)
        {
            FormMenuPrincipal.menu2principal.panelventas.Visible = false;
            FormMenuPrincipal.menu2principal.panelSUBventas.Visible = false;
        }

        private void btnGuardarFAMILIA_Click(object sender, EventArgs e)
        {
            if (EspacioDiscosConfi(ClasDatos.RutaConfiguracionXml, 20))
            {

                if (File.Exists(ClasDatos.RutaMultidatos))
                {
                    Validate();
                    this.dtFamiliaProductosBindingSource.EndEdit();
                    FormMenuPrincipal.menu2principal.dsMultidatos.WriteXml(ClasDatos.RutaMultidatos);

                }
                this.DataGridFamilias.Refresh();
            }
        }

        private void BtnNuevoTipoTarifa_Click(object sender, EventArgs e)
        {
            this.BtnNuevoTipoTarifa.Tag = "Nuevo";
            if (this.dtConfiguracionPrincipalBindingSource.Count <= 0)
            {
                MessageBox.Show("Debe Crear Ejercicio De esta Empresa", "FALTA EMPRESA");
                return;
            }

            if (this.dtTarifaTipoDataGridView.RowCount > 7)
            {
                MessageBox.Show("Maximo Permitido", "LIMITE");
                return;
            }
            try
            {
                this.dtTarifaTipoDataGridView.Sort(this.dtTarifaTipoDataGridView.Columns[0], ListSortDirection.Ascending);
                int numeroFILA = this.dtTarifaTipoDataGridView.Rows.Count;
                this.dtConfiDtTarifaTipoBindingSource.AddNew();
                if (this.dtTarifaTipoDataGridView.CurrentCell.RowIndex == 0)
                {
                    this.IdTarifa.Text = "1";
                    this.dtTarifaTipoDataGridView.Rows[0].Cells[0].Value = "1";
                }
                if (numeroFILA > 0)
                {
                    if (this.dtTarifaTipoDataGridView.Rows[numeroFILA - 1].Cells[0].Value.ToString() == string.Empty)
                    {
                        Random r = new Random();
                        int VALORid = r.Next(50000, 100000000);
                        this.dtTarifaTipoDataGridView.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.IdTarifa.Text = VALORid.ToString();
                    }
                    else
                    {
                        int VALORid = Convert.ToInt32(this.dtTarifaTipoDataGridView.Rows[numeroFILA - 1].Cells[0].Value) + 1;
                        this.dtTarifaTipoDataGridView.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.IdTarifa.Text = VALORid.ToString();
                    }

                }

                this.dtTarifaTipoDataGridView.Refresh();
                this.BtnVolverDescuentos.Visible = false;
                this.panelBotonesTipoTarifa.Enabled = false;
                this.BtnGuardarDescuentos.Enabled = true;
                this.BtnCancelarTipoTarifa.Enabled = true;
                this.dtTarifaTipoDataGridView.Enabled = false;
                this.empresaConfiComboBox1.Enabled = false;
                this.tarifaTipoTextBox.ReadOnly = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnCancelarTipoTarifa_Click(object sender, EventArgs e)
        {
            BorrarErroresTipoTarifa();
            if (this.dtTarifaTipoDataGridView.RowCount >= 0)
            {
                if (this.BtnNuevoTipoTarifa.Tag.ToString() == "Nuevo")
                {
                    this.dtTarifaTipoDataGridView.Rows.RemoveAt(this.dtTarifaTipoDataGridView.CurrentCell.RowIndex);
                }

            }
            this.dtTarifaTipoDataGridView.Refresh();
            this.panelBotonesTipoTarifa.Enabled = true;
            this.BtnGuardarDescuentos.Enabled = false;
            this.BtnCancelarTipoTarifa.Enabled = false;
            this.dtTarifaTipoDataGridView.Enabled = true;
            this.empresaConfiComboBox1.Enabled = true;
            this.tarifaTipoTextBox.ReadOnly = true;
            this.BtnVolverDescuentos.Visible = true;
        }

        private void BtnGuardarDescuentos_Click(object sender, EventArgs e)
        {

            BorrarErroresTipoTarifa();
            //email_bien_escrito();
            if (ValidarTipoTarifa())
            {
                if (this.dtTarifaTipoBindingSource.Count < 0)
                {
                    //this.tabControl1Factura.SelectedIndex = 1;
                    return;
                }
                if (MessageBox.Show(" ¿Aceptar Guardar Descuentos ? ", " GUARDAR ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (ClsConexionSql.SibaseDatosSql)
                    {
                        //GuardarTarifas_Cli_Sql();
                    }
                    else
                    {

                        if (EspacioDiscosConfi(ClasDatos.RutaConfiguracionXml, 20))
                        {
                            if (File.Exists(ClasDatos.RutaConfiguracionXml))
                            {
                                Validate();
                                this.dtConfiDtTarifaTipoBindingSource.EndEdit();
                                this.dtTarifaTipoDataGridView.EndEdit();
                                FormMenuPrincipal.menu2principal.dsCONFIGURACCION.WriteXml(ClasDatos.RutaConfiguracionXml);
                                MessageBox.Show("Guardado Correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Falta Archivo ", "NO GUARDO DATOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    this.panelBotonesTipoTarifa.Enabled = true;
                    this.BtnGuardarDescuentos.Enabled = false;
                    this.BtnCancelarTipoTarifa.Enabled = false;
                    this.dtTarifaTipoDataGridView.Enabled = true;
                    this.empresaConfiComboBox1.Enabled = true;
                    this.tarifaTipoTextBox.ReadOnly = true;
                    this.BtnVolverDescuentos.Visible = true;
                    this.dtTarifaTipoDataGridView.Refresh();
                }
            }

        }

        private void FormComfiguracion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.BtnGuardarDescuentos.Enabled == true)
            {
                e.Cancel = true;
            }
            if (this.BtnGuardarEjercicio.Enabled == true)
            {
                e.Cancel = true;
            }
            if (this.BtnGuardarEmpresas.Enabled == true)
            {
                e.Cancel = true;
            }
        }

        private void BtnSalirTipoTarifa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" ¿Salir Configuracion ? ", " SALIR ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void BtnModificarTipoTarifa_Click(object sender, EventArgs e)
        {
            this.BtnNuevoTipoTarifa.Tag = "Actualizar";
            if (this.dtTarifaTipoDataGridView.CurrentCell.RowIndex == 0)
            {
                MessageBox.Show("Este Descuento No Se Puede Modificar", "Descuento");
                return;
            }
            if (this.dtTarifaTipoDataGridView.CurrentCell.RowIndex == 1)
            {
                MessageBox.Show("Este Descuento No Se Puede Modificar", "Descuento");
                return;
            }
            if (this.dtTarifaTipoDataGridView.CurrentCell.RowIndex == 8)
            {
                MessageBox.Show("Este Descuento No Se Puede Modificar", "Descuento");
                return;
            }
            this.panelBotonesTipoTarifa.Enabled = false;
            this.BtnGuardarDescuentos.Enabled = true;
            this.BtnCancelarTipoTarifa.Enabled = true;
            this.dtTarifaTipoDataGridView.Enabled = false;
            this.BtnGuardarDescuentos.Enabled = true;
            this.BtnCancelarTipoTarifa.Enabled = true;
            this.empresaConfiComboBox1.Enabled = false;
            this.tarifaTipoTextBox.ReadOnly = false;
            this.BtnVolverDescuentos.Visible = false;
        }

        private void BtnGuardarEjercicio_Click(object sender, EventArgs e)
        {

            if (this.dtConfiguracionPrincipalBindingSource.Count <= 0)
            {
                MessageBox.Show("Debe al Menos Crear Una Empresa", "EMPRESA");
                return;
            }
            if (!string.IsNullOrEmpty(this.empresaConfiComboBox.Text))
            {
                ClasDatos.ArchivoInicioFacturas = this.nombreEmpresaTextBox.Text + " EJERCICIO " + String.Format("{0:yyyy}", DateTime.Now);

            }
            else
            {
                MessageBox.Show("Eliga Empresa Valida", "EMPRESA");
                return;
            }

            if (EspacioDiscosConfi(ClasDatos.RutaConfiguracionXml, 10))
            {
                this.dtConfiDataGridView.EndEdit();
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

                        if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtInicio.Rows.Count <= 0)
                        {
                            FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtInicio.Rows.Add(ClasDatos.ArchivoInicioFacturas + ".Xml");
                        }
                        else
                        {
                            FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtInicio"].Rows[0]["ArchivoInicioFacturas"] = ClasDatos.ArchivoInicioFacturas + ".Xml";
                            // dsCONFIGURACCION.DtInicio.Rows[0]["ArchivoInicioFacturas"] = ClaseCompartida.ArchivoInicioFacturas + ".Xml";
                        }

                        if (ClsConexionSql.SibaseDatosSql)
                        {
                            string consulta = "";
                            if (this.BtnNuevoEjercicio.Tag.ToString() == "Nuevo")
                            {
                                consulta = "INSERT INTO [DtConfi] ([ConfiguraccionBasica] ,[TipoInpuestoIVA],[EjerciciosDeAño],[EmpresaENLACE],[IdConexionConfi]," +
                                   "[AñoDeEjercicio]) VALUES( @ConfiguraccionBasica, @TipoInpuestoIVA, @EjerciciosDeAño, @EmpresaENLACE, @IdConexionConfi," +
                                   "  @AñoDeEjercicio)";
                            }
                            else
                            {
                                consulta = "UPDATE [DtConfi] SET [ConfiguraccionBasica] = @ConfiguraccionBasica, [TipoInpuestoIVA] = @TipoInpuestoIVA, " +
                                   " [EjerciciosDeAño] = @EjerciciosDeAño,  [EmpresaENLACE] = @EmpresaENLACE, [IdConexionConfi] = @IdConexionConfi, " +
                                   " [AñoDeEjercicio] = @AñoDeEjercicio  WHERE EmpresaENLACE = @EmpresaENLACE";
                            }

                            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
                            try
                            {
                                if (NuevaConexion.SiConexionSql)
                                {
                                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@ConfiguraccionBasica", string.IsNullOrEmpty(this.configuraccionBasicaTextBox.Text) ? (object)DBNull.Value : this.configuraccionBasicaTextBox.Text);
                                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@TipoInpuestoIVA", string.IsNullOrEmpty(this.tipoInpuestoIVANumericUpDown.Text) ? (object)DBNull.Value : Convert.ToInt32(this.tipoInpuestoIVANumericUpDown.Text));
                                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@EjerciciosDeAño", string.IsNullOrEmpty(this.ejerciciosDeAñoTextBox.Text) ? (object)DBNull.Value : this.ejerciciosDeAñoTextBox.Text);
                                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@IdConexionConfi", string.IsNullOrEmpty(this.idConexionConfiTextBox.Text) ? (object)DBNull.Value : Convert.ToInt32(this.idConexionConfiTextBox.Text));
                                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@AñoDeEjercicio", string.IsNullOrEmpty(this.añoDeEjercicioTextBox.Text) ? (object)DBNull.Value : this.añoDeEjercicioTextBox.Text);
                                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@EmpresaENLACE", string.IsNullOrEmpty(this.EmpresaReguistro.Text) ? (object)DBNull.Value : this.EmpresaReguistro.Text);
                                    NuevaConexion.ComandoSql.ExecuteNonQuery();
                                    NuevaConexion.ComandoSql.Parameters.Clear();
                                    MessageBox.Show("Se Guardo Comfiguracion Correctamente", "GUARDAR CONFIGURACION", MessageBoxButtons.OK);
                                    this.dtConfiBindingSource.EndEdit();
                                    Validate();
                                    RestaurarOjetosDtconfi();
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
                        else
                        {

                            if (File.Exists(ClasDatos.RutaConfiguracionXml))
                            {
                                this.dtConfiguracionPrincipalDtConfiBindingSource.EndEdit();
                                this.dtConfiDataGridView.EndEdit();
                                Validate();
                                FormMenuPrincipal.menu2principal.dsCONFIGURACCION.WriteXml(ClasDatos.RutaConfiguracionXml);
                                MessageBox.Show("Se Guardaron Datos con exito", "GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                RestaurarOjetosDtconfi();
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
        private void RestaurarOjetosDtconfi()
        {

            this.dtConfiDataGridView.Refresh();
            this.dtConfiDataGridView.Enabled = true;
            this.configuraccionBasicaTextBox.ReadOnly = true;
            this.CambiarDeEmpresa1.Enabled = true;
            this.tipoInpuestoIVANumericUpDown.Enabled = false;
            this.BtnGuardarEjercicio.Enabled = false;
            this.BtnCancelarEjercicio.Enabled = false;
            this.panel1Ejercicio.Enabled = true;
            this.BtnVolverBasica.Visible = true;
            this.ejerciciosDeAñoTextBox.ReadOnly = true;
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
                int numeroFILA = this.dtConfiDataGridView.Rows.Count;
                this.dtConfiDataGridView.Sort(this.dtConfiDataGridView.Columns[0], ListSortDirection.Ascending);
                this.dtConfiguracionPrincipalDtConfiBindingSource.AddNew();
                this.empresaENLACETextBox.Text = this.CambiarDeEmpresa1.Text;
                this.configuraccionBasicaTextBox.Text = "Mi Configurarcion Nueva " + this.añoDeEjercicioTextBox.Text;
                if (this.dtConfiDataGridView.CurrentCell.RowIndex == 0)
                {
                    this.idConexionConfiTextBox.Text = "1";
                    this.dtConfiDataGridView.Rows[0].Cells[0].Value = "1";
                }
                if (numeroFILA > 0)
                {
                    if (this.dtConfiDataGridView.Rows[numeroFILA - 1].Cells[0].Value.ToString() == string.Empty)
                    {
                        Random r = new Random();
                        int VALORid = r.Next(50000, 100000000);
                        this.dtConfiDataGridView.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.idConexionConfiTextBox.Text = VALORid.ToString();
                    }
                    else
                    {
                        int VALORid = Convert.ToInt32(this.dtConfiDataGridView.Rows[numeroFILA - 1].Cells[0].Value) + 1;
                        this.dtConfiDataGridView.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.idConexionConfiTextBox.Text = VALORid.ToString();
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
                this.ejerciciosDeAñoTextBox.ReadOnly = false;
                this.configuraccionBasicaTextBox.ReadOnly = false;
                this.tipoInpuestoIVANumericUpDown.Enabled = true;
                this.tipoInpuestoIVANumericUpDown.Value = 21;
                this.dtConfiDataGridView.Enabled = false;
                this.BtnGuardarEjercicio.Enabled = true;
                this.BtnCancelarEjercicio.Enabled = true;
                this.CambiarDeEmpresa1.Enabled = false;
                this.panel1Ejercicio.Enabled = false;
                this.BtnVolverBasica.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
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
            this.dtConfiDataGridView.Refresh();
            this.dtConfiDataGridView.Enabled = true;
            this.BtnGuardarEjercicio.Enabled = false;
            this.BtnCancelarEjercicio.Enabled = false;
            this.CambiarDeEmpresa1.Enabled = true;
            this.panel1Ejercicio.Enabled = true;
            this.configuraccionBasicaTextBox.ReadOnly = true;
            this.tipoInpuestoIVANumericUpDown.Enabled = false;
            this.BtnVolverBasica.Visible = true;
            this.ejerciciosDeAñoTextBox.ReadOnly = false;
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
                this.dtConfiguracionPrincipalDataGridView.Sort(this.dtConfiguracionPrincipalDataGridView.Columns[0], ListSortDirection.Ascending);
                int numeroFILA = this.dtConfiguracionPrincipalDataGridView.Rows.Count;
                this.dtConfiguracionPrincipalBindingSource.AddNew();
                if (numeroFILA > 5)
                {
                    MessageBox.Show("Maximo Permitido De Empresas", "LIMITE");
                    return;
                }


                if (this.dtConfiguracionPrincipalDataGridView.CurrentCell.RowIndex == 0)
                {
                    this.idEmpresaTextBox.Text = "1";
                    this.dtConfiguracionPrincipalDataGridView.Rows[0].Cells[0].Value = "1";
                }
                if (numeroFILA > 0)
                {
                    if (this.dtConfiguracionPrincipalDataGridView.Rows[numeroFILA - 1].Cells[0].Value.ToString() == string.Empty)
                    {
                        Random r = new Random();
                        int VALORid = r.Next(50000, 100000000);
                        this.dtConfiguracionPrincipalDataGridView.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.idEmpresaTextBox.Text = VALORid.ToString();
                    }
                    else
                    {
                        int VALORid = Convert.ToInt32(this.dtConfiguracionPrincipalDataGridView.Rows[numeroFILA - 1].Cells[0].Value) + 1;
                        this.dtConfiguracionPrincipalDataGridView.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.idEmpresaTextBox.Text = VALORid.ToString();
                    }

                }

                this.serieArticulosComboBox.Text = "Tarifa1";
                this.serieClientesComboBox.Text = "Listado1";
                this.dtConfiguracionPrincipalDataGridView.Refresh();
                this.panelEmpresas.Enabled = false;
                this.BtnGuardarEmpresas.Enabled = true;
                this.BtnCancelarEmpresas.Enabled = true;
                this.dtConfiguracionPrincipalDataGridView.Enabled = false;
                this.empresaConfiComboBox.Enabled = false;
                this.paisEmpresaComboBox.Enabled = true;
                this.provinciaEmpresaComboBox.Enabled = true;
                this.regimenIvaEmpresaComboBox.Enabled = true;
                this.serieDeFacturacionEmpresaComboBox.Enabled = true;
                this.empresaConfiTextBox.ReadOnly = false;
                this.nombreEmpresaTextBox.ReadOnly = false;
                this.direccionEmpresaTextBox.ReadOnly = false;
                this.localidadEmpresaTextBox.ReadOnly = false;
                this.codigoPostalEmpresaTextBox.ReadOnly = false;
                this.telefonoEmpresaTextBox.ReadOnly = false;
                this.correoEmpresaTextBox.ReadOnly = false;
                this.wepEmpresaTextBox.ReadOnly = false;
                this.empresaConfiTextBox.ReadOnly = false;
                this.telefono2EmpresaTextBox.ReadOnly = false;
                this.movilEmpresaTextBox.ReadOnly = false;
                this.cifEmpresaTextBox.ReadOnly = false;
                this.BtnVolverEmpresas.Visible = false;
                this.BtnImagenEmpresa.Enabled = true;
                this.serieArticulosComboBox.Enabled = true;
                this.serieClientesComboBox.Enabled = true;
                this.BtnImprimirEmpresa.Enabled = false;
                this.panelBotonesArchivo.Tag = "SI";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
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
        private void GuardarEmpresasSql()
        {
            if (EspacioDiscosConfi(ClasDatos.Articulos, 20))
            {
                String ConsultaDescuetos = "";
                string consulta = "";
                if (this.BtnNuevaEmpresa.Tag.ToString() == "Nuevo")
                {
                    ConsultaDescuetos = " INSERT INTO [DtTarifaTipo]([IdTarifa],[TarifaTipo],[EnlaceTarifa]) VALUES( @IdTarifa, @TarifaTipo, @EnlaceTarifa)";
                    consulta = "  INSERT INTO [DtConfiguracionPrincipal]([EmpresaConfi],[IdEmpresa],[NombreEmpresa],[DireccionEmpresa],[LocalidadEmpresa]" +
                 " ,[CodigoPostalEmpresa],[ProvinciaEmpresa],[TelefonoEmpresa],[CorreoEmpresa],[WepEmpresa] ,[RegimenIvaEmpresa]" +
                     " ,[PaisEmpresa],[SerieDeFacturacionEmpresa],[Telefono2Empresa],[MovilEmpresa],[CifEmpresa],[NombreEmpresaReguistro]" +
                     "  ,[ImagenEmpresa])  VALUES( @EmpresaConfi, @IdEmpresa, @NombreEmpresa, @DireccionEmpresa, @LocalidadEmpresa," +
                       " @CodigoPostalEmpresa, @ProvinciaEmpresa, @TelefonoEmpresa, @CorreoEmpresa, @WepEmpresa, @RegimenIvaEmpresa," +
                       " @PaisEmpresa, @SerieDeFacturacionEmpresa, @Telefono2Empresa, @MovilEmpresa, @CifEmpresa," +
                        " @NombreEmpresaReguistro, @ImagenEmpresa)";


                }
                else
                {
                    ConsultaDescuetos = " UPDATE [DtTarifaTipo] SET [IdTarifa] = @IdTarifa,[TarifaTipo] =@TarifaTipo,[EnlaceTarifa]= @EnlaceTarifa";
                    consulta = "UPDATE [DtConfiguracionPrincipal] SET [EmpresaConfi] = @EmpresaConfi,[IdEmpresa] = @IdEmpresa, [NombreEmpresa] = @NombreEmpresa, " +
                        "[DireccionEmpresa] = @DireccionEmpresa, [LocalidadEmpresa] = @LocalidadEmpresa,[CodigoPostalEmpresa] = @CodigoPostalEmpresa,  [ProvinciaEmpresa] = @ProvinciaEmpresa, " +
                        " [TelefonoEmpresa] = @TelefonoEmpresa, [CorreoEmpresa] = @CorreoEmpresa,  [WepEmpresa] = @WepEmpresa, [RegimenIvaEmpresa] = @RegimenIvaEmpresa, [PaisEmpresa] = @PaisEmpresa, " +
                        " [SerieDeFacturacionEmpresa] = @SerieDeFacturacionEmpresa, [Telefono2Empresa] = @Telefono2Empresa, [MovilEmpresa] = @MovilEmpresa, [CifEmpresa] = @CifEmpresa, " +
                        " [NombreEmpresaReguistro] = @NombreEmpresaReguistro,[ImagenEmpresa] = @ImagenEmpresa  WHERE NombreEmpresaReguistro = @NombreEmpresaReguistro";
                }
                ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);


                try
                {
                    if (NuevaConexion.SiConexionSql)
                    {

                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@EmpresaConfi", string.IsNullOrEmpty(this.empresaConfiTextBox.Text) ? (object)DBNull.Value : this.empresaConfiTextBox.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@IdEmpresa", string.IsNullOrEmpty(this.idEmpresaTextBox.Text) ? (object)DBNull.Value : Convert.ToInt32(this.idEmpresaTextBox.Text));
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@NombreEmpresa", string.IsNullOrEmpty(this.nombreEmpresaTextBox.Text) ? (object)DBNull.Value : this.nombreEmpresaTextBox.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@DireccionEmpresa", string.IsNullOrEmpty(this.direccionEmpresaTextBox.Text) ? (object)DBNull.Value : this.direccionEmpresaTextBox.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@LocalidadEmpresa", string.IsNullOrEmpty(this.localidadEmpresaTextBox.Text) ? (object)DBNull.Value : this.localidadEmpresaTextBox.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@CodigoPostalEmpresa", string.IsNullOrEmpty(this.codigoPostalEmpresaTextBox.Text) ? (object)DBNull.Value : this.codigoPostalEmpresaTextBox.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@ProvinciaEmpresa", string.IsNullOrEmpty(this.provinciaEmpresaComboBox.Text) ? (object)DBNull.Value : this.provinciaEmpresaComboBox.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@TelefonoEmpresa", string.IsNullOrEmpty(this.telefonoEmpresaTextBox.Text) ? (object)DBNull.Value : this.telefonoEmpresaTextBox.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@CorreoEmpresa", string.IsNullOrEmpty(this.correoEmpresaTextBox.Text) ? (object)DBNull.Value : this.correoEmpresaTextBox.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@WepEmpresa", string.IsNullOrEmpty(this.wepEmpresaTextBox.Text) ? (object)DBNull.Value : this.wepEmpresaTextBox.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@RegimenIvaEmpresa", string.IsNullOrEmpty(this.regimenIvaEmpresaComboBox.Text) ? (object)DBNull.Value : this.regimenIvaEmpresaComboBox.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@PaisEmpresa", string.IsNullOrEmpty(this.paisEmpresaComboBox.Text) ? (object)DBNull.Value : this.paisEmpresaComboBox.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@SerieDeFacturacionEmpresa", string.IsNullOrEmpty(this.serieDeFacturacionEmpresaComboBox.Text) ? (object)DBNull.Value : this.serieDeFacturacionEmpresaComboBox.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@Telefono2Empresa", string.IsNullOrEmpty(this.telefono2EmpresaTextBox.Text) ? (object)DBNull.Value : this.telefono2EmpresaTextBox.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@MovilEmpresa", string.IsNullOrEmpty(this.movilEmpresaTextBox.Text) ? (object)DBNull.Value : this.movilEmpresaTextBox.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@CifEmpresa", string.IsNullOrEmpty(this.cifEmpresaTextBox.Text) ? (object)DBNull.Value : this.cifEmpresaTextBox.Text);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@NombreEmpresaReguistro", string.IsNullOrEmpty(this.EmpresaReguistro.Text) ? (object)DBNull.Value : this.EmpresaReguistro.Text);
                        //  NuevaConexion.ComandoSql.Parameters.AddWithValue("@ImagenEmpresa", (imagenEmpresaPictureBox.Image) == null ? (object) DBNull.Value :Convert.ToByte( ConvertirImagen(imagenEmpresaPictureBox)));
                        byte[] IMAGENnUEVA = ConvertirImagen(this.imagenEmpresaPictureBox);
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@ImagenEmpresa", IMAGENnUEVA);
                        NuevaConexion.ComandoSql.ExecuteNonQuery();
                        NuevaConexion.ComandoSql.Parameters.Clear();
                        RestaurarOjetosEmpresa();
                        MessageBox.Show("Se Guardo Correctamente", "GUARDAR EMPRESA ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "EMPRESAS");
                }
                finally
                {
                    if (NuevaConexion.CerrarConexionSql)
                    {

                    }
                }
                NuevaConexion = new ClsConexionSql(ConsultaDescuetos);////Guarda Descuentos Clientes
                try
                {
                    if (NuevaConexion.SiConexionSql)
                    {
                        foreach (DataGridViewRow row in this.dtTarifaTipoDataGridView.Rows)
                        {

                            NuevaConexion.ComandoSql.Parameters.AddWithValue("@IdTarifa", string.IsNullOrEmpty(row.Cells[0].Value.ToString()) ? (object)DBNull.Value : Convert.ToInt32(row.Cells[0].Value.ToString()));
                            NuevaConexion.ComandoSql.Parameters.AddWithValue("@TarifaTipo", string.IsNullOrEmpty(row.Cells[1].Value.ToString()) ? (object)DBNull.Value : row.Cells[1].Value.ToString());
                            NuevaConexion.ComandoSql.Parameters.AddWithValue("@EnlaceTarifa", string.IsNullOrEmpty(this.EmpresaReguistro.Text) ? (object)DBNull.Value : this.EmpresaReguistro.Text);
                            NuevaConexion.ComandoSql.ExecuteNonQuery();
                            NuevaConexion.ComandoSql.Parameters.Clear();
                        }


                    }
                    MessageBox.Show("Se Guardo Correctamente", "GUARDAR DESCUENTOS CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "DESCUENTOS");
                }
            }


        }
        private void BtnGuardarEmpresas_Click_1(object sender, EventArgs e)
        {
            if (this.dtConfiguracionPrincipalBindingSource.Count <= 0)
            {
                MessageBox.Show("Debe al Menos Crear Una Empresa", "EMPRESA");
                return;
            }
            if (this.BtnNuevaEmpresa.Tag.ToString() == "Actualizar")
            {
                if (string.IsNullOrEmpty(this.EmpresaReguistro.Text))
                {
                    MessageBox.Show("Datos erroneos fallo", "EMPRESA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!string.IsNullOrEmpty(this.empresaConfiComboBox.Text))
            {
                ClasDatos.ArchivoInicioFacturas = this.nombreEmpresaTextBox.Text + " EJERCICIO " + String.Format("{0:yyyy}", DateTime.Now);

            }
            else
            {
                MessageBox.Show("Eliga Empresa Valida", "EMPRESA");
                return;
            }
            if (EspacioDiscosConfi(ClasDatos.Clientes, 10))
            {
                try
                {
                    foreach (DataGridViewRow fila in this.dtConfiguracionPrincipalDataGridView.Rows)
                    {
                        if (fila.Cells[1].ToString() == this.empresaConfiComboBox.Text)
                        {
                            if (this.dtConfiguracionPrincipalDataGridView.CurrentCell.RowIndex == fila.Index)
                            {
                                break;
                            }
                            MessageBox.Show(this.empresaConfiTextBox.Text.ToString(), "YA EXISTE ESTA EMPRESA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.empresaConfiTextBox.Focus();
                            this.empresaConfiTextBox.SelectAll();
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
                        if (this.panelBotonesArchivo.Tag.ToString() == "SI")
                        {
                            if (this.empresaConfiTextBox.Text != string.Empty)
                            {

                                this.EmpresaReguistro.Text = this.empresaConfiTextBox.Text;
                                //FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtConfiguracionPrincipal"].Rows[0]["NombreEmpresaReguistro"] = this.empresaConfiTextBox.Text;
                            }
                        }


                        for (int i = 0; i <= 8; i++)
                        {
                            this.dtConfiDtTarifaTipoBindingSource.AddNew();
                            this.dtTarifaTipoDataGridView.Rows[i].Cells[1].Value = "PVP" + (i + 1);
                            this.dtTarifaTipoDataGridView.Rows[i].Cells[0].Value = i + 1;
                        }
                        this.dtTarifaTipoDataGridView.Rows[8].Cells[1].Value = "IVA";


                        //this.dtConfiguracionPrincipalBindingSource.EndEdit();
                        this.dtConfiDtTarifaTipoBindingSource.EndEdit();
                        try
                        {
                            if (this.dtTarifaTipoDataGridView.Rows.Count > 0)
                            {
                                this.dtTarifaTipoDataGridView.CurrentCell = this.dtTarifaTipoDataGridView.Rows[0].Cells[0];
                            }
                        }
                        catch (Exception)
                        {

                            // throw;
                        }
                        if (ClsConexionSql.SibaseDatosSql)
                        {
                            GuardarEmpresasSql();
                        }
                        else
                        {

                            if (File.Exists(ClasDatos.RutaConfiguracionXml))
                            {
                                Validate();
                                FormMenuPrincipal.menu2principal.dsCONFIGURACCION.WriteXml(ClasDatos.RutaConfiguracionXml);
                                MessageBox.Show("Se Guardo Correctamente", "GUARDAR ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                RestaurarOjetosEmpresa();
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
        private void RestaurarOjetosEmpresa()
        {
            this.panelEmpresas.Enabled = true;
            this.BtnGuardarEmpresas.Enabled = false;
            this.BtnCancelarEmpresas.Enabled = false;
            this.dtConfiguracionPrincipalDataGridView.Enabled = true;
            this.empresaConfiComboBox.Enabled = true;
            this.paisEmpresaComboBox.Enabled = false;
            this.provinciaEmpresaComboBox.Enabled = false;
            this.regimenIvaEmpresaComboBox.Enabled = false;
            this.serieDeFacturacionEmpresaComboBox.Enabled = false;
            this.empresaConfiTextBox.ReadOnly = true;
            this.nombreEmpresaTextBox.ReadOnly = true;
            this.direccionEmpresaTextBox.ReadOnly = true;
            this.localidadEmpresaTextBox.ReadOnly = true;
            this.codigoPostalEmpresaTextBox.ReadOnly = true;
            this.telefonoEmpresaTextBox.ReadOnly = true;
            this.correoEmpresaTextBox.ReadOnly = true;
            this.wepEmpresaTextBox.ReadOnly = true;
            this.empresaConfiTextBox.ReadOnly = true;
            this.telefono2EmpresaTextBox.ReadOnly = true;
            this.movilEmpresaTextBox.ReadOnly = true;
            this.cifEmpresaTextBox.ReadOnly = true;
            this.BtnVolverEmpresas.Visible = true;
            this.BtnImagenEmpresa.Enabled = false;
            this.serieArticulosComboBox.Enabled = false;
            this.serieClientesComboBox.Enabled = false;
            this.BtnEliminarImagenE.Enabled = false;
            this.BtnImprimirEmpresa.Enabled = true;///VALIDACION EMPRESA
            this.dtConfiguracionPrincipalDataGridView.Refresh();
        }
        private void BtnCancelarEmpresas_Click(object sender, EventArgs e)
        {
            BorrarErroresEmpresa();
            if (this.dtConfiguracionPrincipalDataGridView.RowCount >= 0)
            {
                if (this.BtnNuevaEmpresa.Tag.ToString() == "Nuevo")
                {
                    this.dtConfiguracionPrincipalDataGridView.Rows.RemoveAt(this.dtConfiguracionPrincipalDataGridView.CurrentCell.RowIndex);
                }

            }
            this.dtConfiguracionPrincipalDataGridView.Refresh();
            this.panelEmpresas.Enabled = true;
            this.BtnGuardarEmpresas.Enabled = false;
            this.BtnCancelarEmpresas.Enabled = false;
            this.dtConfiguracionPrincipalDataGridView.Enabled = true;
            this.empresaConfiComboBox.Enabled = true;
            this.paisEmpresaComboBox.Enabled = false;
            this.provinciaEmpresaComboBox.Enabled = false;
            this.regimenIvaEmpresaComboBox.Enabled = false;
            this.serieDeFacturacionEmpresaComboBox.Enabled = false;
            this.empresaConfiTextBox.ReadOnly = true;
            this.nombreEmpresaTextBox.ReadOnly = true;
            this.direccionEmpresaTextBox.ReadOnly = true;
            this.localidadEmpresaTextBox.ReadOnly = true;
            this.codigoPostalEmpresaTextBox.ReadOnly = true;
            this.telefonoEmpresaTextBox.ReadOnly = true;
            this.correoEmpresaTextBox.ReadOnly = true;
            this.wepEmpresaTextBox.ReadOnly = true;
            this.empresaConfiTextBox.ReadOnly = true;
            this.telefono2EmpresaTextBox.ReadOnly = true;
            this.movilEmpresaTextBox.ReadOnly = true;
            this.cifEmpresaTextBox.ReadOnly = true;
            this.BtnVolverEmpresas.Visible = true;
            this.BtnImagenEmpresa.Enabled = false;
            this.serieArticulosComboBox.Enabled = false;
            this.serieClientesComboBox.Enabled = false;
            this.BtnEliminarImagenE.Enabled = false;
            this.BtnImprimirEmpresa.Enabled = true;//VALIDACION SI EXISTE EMPRESA
        }

        private void BtnModificarEmpresa_Click(object sender, EventArgs e)
        {
            this.BtnNuevaEmpresa.Tag = "Actualizar";
            int numeroFILA = this.dtConfiguracionPrincipalDataGridView.Rows.Count;
            if (numeroFILA > 0)
            {
                this.panelEmpresas.Enabled = false;
                this.BtnGuardarEmpresas.Enabled = true;
                this.BtnCancelarEmpresas.Enabled = true;
                this.dtConfiguracionPrincipalDataGridView.Enabled = false;
                this.empresaConfiComboBox.Enabled = false;
                this.paisEmpresaComboBox.Enabled = true;
                this.provinciaEmpresaComboBox.Enabled = true;
                this.regimenIvaEmpresaComboBox.Enabled = true;
                this.serieDeFacturacionEmpresaComboBox.Enabled = true;
                this.empresaConfiTextBox.ReadOnly = false;
                this.nombreEmpresaTextBox.ReadOnly = false;
                this.direccionEmpresaTextBox.ReadOnly = false;
                this.localidadEmpresaTextBox.ReadOnly = false;
                this.codigoPostalEmpresaTextBox.ReadOnly = false;
                this.telefonoEmpresaTextBox.ReadOnly = false;
                this.correoEmpresaTextBox.ReadOnly = false;
                this.wepEmpresaTextBox.ReadOnly = false;
                this.empresaConfiTextBox.ReadOnly = false;
                this.telefono2EmpresaTextBox.ReadOnly = false;
                this.movilEmpresaTextBox.ReadOnly = false;
                this.cifEmpresaTextBox.ReadOnly = false;
                this.BtnVolverEmpresas.Visible = false;
                this.BtnImagenEmpresa.Enabled = true;
                this.serieArticulosComboBox.Enabled = true;
                this.serieClientesComboBox.Enabled = true;
                this.BtnEliminarImagenE.Enabled = true;
                this.BtnImprimirEmpresa.Enabled = true;//PARA SEGUIR PASOS VALIDACION EMPRESAS
            }

        }

        private void BtnGuardarInicio_Click(object sender, EventArgs e)
        {
            Validate();
            BorrarErroresInicio();
            if (ValidarInicio())
            {
                if (MessageBox.Show(" ¿Aceptar Actualicar ? ", " DATOS DE INICIO ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (this.empresaInicio.Text == String.Empty)
                    {
                        MessageBox.Show("Datos Empresa Vacios", "CAMPO VACIO");
                        return;
                    }
                    if (this.EjercicioInicio.Text == String.Empty)
                    {
                        MessageBox.Show("Datos ejercicio Vacios", "CAMPO VACIO");
                        return;
                    }
                    if (this.SerieInicio.Text == String.Empty)
                    {
                        MessageBox.Show("Datos Serie Vacia", "CAMPO VACIO");
                        return;
                    }
                    if (this.provinciaInicio.SelectedIndex < 0)
                    {
                        MessageBox.Show("Falta Provincia", "CAMPO VACIO");
                        return;
                    }
                    if (this.PaisInicio.SelectedIndex < 0)
                    {
                        MessageBox.Show("Falta Pais", "CAMPO VACIO");
                        return;
                    }
                    if (this.dtInicioMultiBindingSource.Count < 1)
                    {
                        this.dtInicioMultiBindingSource.AddNew();
                        //dtInicioMultiBindingSource.AddNew();
                        Validate();
                        this.dtInicioDataGridView.EndEdit();
                        this.dtInicioMultiBindingSource.EndEdit();
                    }
                    if (FormMenuPrincipal.menu2principal.dsMultidatos.DtInicioMulti.Count > 0)
                    {
                        // MessageBox.Show(dtInicioMultiBindingSource.Current.ToString());
                        // dsMultidatos.Tables["DtInicioMulti"].Rows[0]["EmpresaInicio"] = empresaInicio.Text;
                        // return;
                        FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["EjercicioInicio"] = this.EjercicioInicio.Text;
                        FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["SeriePaisInicio"] = this.PaisInicio.Text;
                        FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["SerieInicio"] = this.SerieInicio.Text;
                        FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["SerieProvinciaInicio"] = this.provinciaInicio.Text;
                        FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["SeriePaisInicio"] = this.PaisInicio.Text;
                        FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["ArchivoInicioFacturas"] = ClasDatos.RutaConfiguracionXml;
                    }
                    else
                    {
                        MessageBox.Show("No Se Guardaron Todos Los Datos", "FALLO AL GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    Validate();
                    this.dtInicioDataGridView.EndEdit();
                    this.dtInicioMultiBindingSource.EndEdit();
                    if (File.Exists(ClasDatos.RutaMultidatos))
                    {
                        FormMenuPrincipal.menu2principal.dsMultidatos.WriteXml(ClasDatos.RutaMultidatos);
                        this.dtInicioDataGridView.Refresh();
                        MessageBox.Show("Se Actualizo Correctamente", "ACTUALIZAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Falta Archivo", "FALLO AL GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

        }

        private void BtnModificarEjercicio_Click(object sender, EventArgs e)
        {
            this.BtnNuevoEjercicio.Tag = "Actualizar";
            if (this.dtConfiguracionPrincipalDtConfiBindingSource.Count >= 1)
            {
                this.configuraccionBasicaTextBox.ReadOnly = false;
                this.tipoInpuestoIVANumericUpDown.Enabled = true;
                this.dtConfiDataGridView.Enabled = false;
                this.BtnGuardarEjercicio.Enabled = true;
                this.BtnCancelarEjercicio.Enabled = true;
                this.CambiarDeEmpresa1.Enabled = false;
                this.panel1Ejercicio.Enabled = false;
                this.BtnVolverBasica.Visible = false;
            }
            else
            {
                MessageBox.Show("No Hay Nada Que Mofificar", "MODIFICAR", MessageBoxButtons.OK);
            }

        }



        private void BtnVolverFamilia_Click(object sender, EventArgs e)
        {
            this.tabControlTodo.TabPages.Insert(0, this.tabMENU);
            this.tabFAMILIAproductos.Parent = null;
        }

        private void BtnVolverEmpresas_Click(object sender, EventArgs e)
        {
            this.tabControlTodo.TabPages.Insert(0, this.tabMENU);
            this.tabPageEmpresas.Parent = null;
        }

        private void BtnVolverBasica_Click(object sender, EventArgs e)
        {
            this.tabControlTodo.TabPages.Insert(0, this.tabMENU);
            this.tabCONFIGURACION.Parent = null;
        }

        private void BtnVolverDescuentos_Click(object sender, EventArgs e)
        {
            this.tabControlTodo.TabPages.Insert(0, this.tabMENU);
            this.tabPageTarifa.Parent = null;
            this.panelBotonesTipoTarifa.Visible = true;
            this.BtnGuardarDescuentos.Visible = true;
        }

        private void BtnVolverConfi_Inicio_Click(object sender, EventArgs e)
        {
            BorrarErroresInicio();
            this.tabControlTodo.TabPages.Insert(0, this.tabMENU);
            this.tabPageInicio.Parent = null;
            this.BtnGuardarInicio.Visible = true;
            this.panelDatosInicio.Enabled = true;
        }


        private void BtnDescuentos_Click(object sender, EventArgs e)
        {
            this.tabControlTodo.TabPages.Insert(1, this.tabPageTarifa);
            this.tabMENU.Parent = null;
        }



        private void BtnConfiReportes_Click(object sender, EventArgs e)
        {


        }

        private void BtnVolver_Inicio_Archivo_Click(object sender, EventArgs e)
        {
            this.tabControlTodo.TabPages.Insert(0, this.tabMENU);
            this.tabPageArchivo.Parent = null;
        }

        private void BtnNuevoDatos_Click(object sender, EventArgs e)
        {
            this.BtnNuevoDatos.Tag = "Nuevo";
            int numeroFILA = this.dataGridViewDatos.Rows.Count;
            this.dtArchivoDatosMultiBindingSource.AddNew();
            this.descripcionArchivoDatosTextBox.Text = "Archivo de Datos Nuevo ";
            try
            {
                if (this.dataGridViewDatos.CurrentCell.RowIndex == 0)
                {
                    this.idTextBox.Text = "1";
                    this.dataGridViewDatos.Rows[0].Cells[0].Value = "1";
                }
                if (numeroFILA > 0)
                {
                    if (this.dataGridViewDatos.Rows[numeroFILA - 1].Cells[0].Value.ToString() == string.Empty)
                    {
                        Random r = new Random();
                        int VALORid = r.Next(5000, 100000000);
                        this.dataGridViewDatos.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.idTextBox.Text = VALORid.ToString();
                    }
                    else
                    {
                        int VALORid = Convert.ToInt32(this.dataGridViewDatos.Rows[numeroFILA - 1].Cells[0].Value) + 1;
                        this.dataGridViewDatos.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.idTextBox.Text = VALORid.ToString();
                    }
                }

                this.directorioArchivoDatosTextBox.Text = Directory.GetCurrentDirectory();
                this.BtnBuscarDirectorio.Enabled = true;
                this.dataGridViewDatos.Enabled = false;
                this.BtnGuardarDatos.Enabled = true;
                this.BtnCancelarDatos.Enabled = true;
                this.panelBotonesArchivo.Enabled = false;
                this.nombreArchivoDatosTextBox.ReadOnly = false;
                this.descripcionArchivoDatosTextBox.ReadOnly = false;
                this.directorioArchivoDatosTextBox.ReadOnly = false;
                this.BtnVolver_Inicio_Archivo.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnBuscarDirectorio_Click(object sender, EventArgs e)
        {
            //directorioArchivoDatosTextBox.Text = Directory.GetCurrentDirectory();
            this.folderBrowserDialog1.Description = "Logo Empresa";
            //folderBrowserDialog1.
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.directorioArchivoDatosTextBox.Text = this.folderBrowserDialog1.SelectedPath;
                this.rutaArchivoDatosTextBox.Text = this.folderBrowserDialog1.SelectedPath;
            }
            // Directory.GetFiles(@"c:\", "*.*");
            //directorioArchivoDatosTextBox.Text = Directory.GetCurrentDirectory();
        }

        private void BtnGuardarDatos_Click(object sender, EventArgs e)
        {
            Validate();
            BorrarErroresArchivo();
            if (ValidarArchivo())
            {

                this.dtArchivoDatosMultiBindingSource.EndEdit();
                this.dataGridViewDatos.EndEdit();
                if (MessageBox.Show(" ¿Guardar Nueva Ruta Acceso? ", " GUARDAR DATOS ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (!Directory.Exists(this.directorioArchivoDatosTextBox.Text + "\\" + ClasDatos.RutaDatosPrincipal))
                    {
                        DirectoryInfo dir = new DirectoryInfo(this.directorioArchivoDatosTextBox.Text);
                        dir.CreateSubdirectory(ClasDatos.RutaDatosPrincipal);
                    }
                    for (int i = 1; i <= 5; i++)
                    {
                        if (!Directory.Exists(this.directorioArchivoDatosTextBox.Text + "\\" + ClasDatos.RutaDatosPrincipal + " FN" + i))
                        {
                            DirectoryInfo dir = new DirectoryInfo(this.directorioArchivoDatosTextBox.Text + "\\" + ClasDatos.RutaDatosPrincipal);
                            dir.CreateSubdirectory(ClasDatos.RutaDatosPrincipal + " FN" + i);
                        }
                    }
                    if (this.dtInicioMultiBindingSource.Count < 1)
                    {
                        this.dtInicioMultiBindingSource.AddNew();

                    }
                    this.dtInicioMultiBindingSource.EndEdit();
                    this.dataGridViewDatos.EndEdit();
                    ClasDatos.RutaConfiguracionXml = this.directorioArchivoDatosTextBox.Text + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + "Configuracion.Xml";
                    ClasDatos.ArchivoInicioFacturas = ClasDatos.RutaConfiguracionXml;
                    if (this.dtInicioMultiBindingSource.Count > 0)
                    {
                        FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["NombreArchivoDatos"] = this.nombreArchivoDatosTextBox.Text;
                        FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["RutaArchivoDatos"] = this.directorioArchivoDatosTextBox.Text;
                        FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["ArchivoInicioFacturas"] = ClasDatos.RutaConfiguracionXml;
                    }


                }
                if (File.Exists(ClasDatos.RutaMultidatos))
                {
                    FormMenuPrincipal.menu2principal.dsMultidatos.WriteXml(ClasDatos.RutaMultidatos);
                    MessageBox.Show("Se Guardaron Datos con exito", "GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Archivo No Encontrado ", "FALLO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                this.BtnBuscarDirectorio.Enabled = false;
                this.dataGridViewDatos.Enabled = true;
                this.BtnGuardarDatos.Enabled = false;
                this.BtnCancelarDatos.Enabled = false;
                this.panelBotonesArchivo.Enabled = true;
                this.nombreArchivoDatosTextBox.ReadOnly = true;
                this.descripcionArchivoDatosTextBox.ReadOnly = true;
                this.directorioArchivoDatosTextBox.ReadOnly = true;
                this.BtnVolver_Inicio_Archivo.Visible = true;

            }
        }

        private void BtnCancelarDatos_Click(object sender, EventArgs e)
        {
            BorrarErroresArchivo();
            if (this.dataGridViewDatos.RowCount >= 0)
            {
                if (this.BtnNuevoDatos.Tag.ToString() == "Nuevo")
                {
                    this.dataGridViewDatos.Rows.RemoveAt(this.dataGridViewDatos.CurrentCell.RowIndex);
                }

            }
            this.BtnBuscarDirectorio.Enabled = false;
            this.dataGridViewDatos.Enabled = true;
            this.BtnGuardarDatos.Enabled = false;
            this.BtnCancelarDatos.Enabled = false;
            this.panelBotonesArchivo.Enabled = true;
            this.nombreArchivoDatosTextBox.ReadOnly = false;
            this.descripcionArchivoDatosTextBox.ReadOnly = false;
            this.directorioArchivoDatosTextBox.ReadOnly = false;
            this.BtnVolver_Inicio_Archivo.Visible = true;
        }

        private void BtnModificarDatos_Click(object sender, EventArgs e)
        {
            if (EspacioDiscosConfi(ClasDatos.RutaDatosPrincipal, 20))
            {
                this.BtnNuevoDatos.Tag = "Actualizar";
                if (this.dataGridViewDatos.Rows.Count >= 0)
                {

                    int fila = this.dataGridViewDatos.CurrentCell.RowIndex;
                    if (fila == 0)
                    {
                        MessageBox.Show("Este Archivo no Se Puede Modificar", "RESTRINGIDO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if (MessageBox.Show("Establecer Como Activo", "ACTIVAR", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            if (this.dtInicioMultiBindingSource.Count > 0)
                            {
                                FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["NombreArchivoDatos"] = this.nombreArchivoDatosTextBox.Text;
                                FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["RutaArchivoDatos"] = this.directorioArchivoDatosTextBox.Text;
                                FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["ArchivoInicioFacturas"] = ClasDatos.RutaConfiguracionXml;
                                ClasDatos.ArchivoInicioFacturas = this.directorioArchivoDatosTextBox.Text;
                                if (File.Exists(ClasDatos.RutaMultidatos))
                                {
                                    FormMenuPrincipal.menu2principal.dsMultidatos.WriteXml(ClasDatos.RutaMultidatos);
                                    MessageBox.Show("Se Actualizo Con Exito", "ACTIVAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                            }


                        }

                    }
                    else
                    {
                        this.BtnBuscarDirectorio.Enabled = true;
                        this.dataGridViewDatos.Enabled = false;
                        this.BtnGuardarDatos.Enabled = true;
                        this.BtnCancelarDatos.Enabled = true;
                        this.panelBotonesArchivo.Enabled = false;
                        this.nombreArchivoDatosTextBox.ReadOnly = false;
                        this.descripcionArchivoDatosTextBox.ReadOnly = false;
                        this.directorioArchivoDatosTextBox.ReadOnly = false;
                        this.BtnVolver_Inicio_Archivo.Visible = false;
                    }
                }
            }
        }
        private void BtnEliminarDatos_Click(object sender, EventArgs e)
        {
            if (this.dtArchivoDatosMultiBindingSource.Count > 0)
            {
                if (this.dataGridViewDatos.CurrentRow.Index == 0)
                {
                    MessageBox.Show("Esta Comfiguacion No Se Puede Eliminar", "ELIMINAR ", MessageBoxButtons.OK);
                    return;
                }
                if (MessageBox.Show("Desea Eliminar La Configuracion", "ELIMINAR ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    if (File.Exists(ClasDatos.RutaMultidatos))
                    {
                        FormMenuPrincipal.menu2principal.dsMultidatos.WriteXml(ClasDatos.RutaMultidatos);
                        this.dataGridViewDatos.Rows.Remove(this.dataGridViewDatos.CurrentRow);
                        this.dtArchivoDatosMultiBindingSource.EndEdit();
                        this.dataGridViewDatos.EndEdit();
                        MessageBox.Show("Se Elimino Correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }


        private void BtnImagenEmpresa_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            this.openFileDialog1.Title = "Nueva Imagen Empresa";
            this.openFileDialog1.FileName = "Logo Empresa";
            //openFileDialog1.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpg*.jpeg||All files (*.*)|*.*";
            this.openFileDialog1.Filter = "Archivo De Imagenes|*.jpg;*.jpeg;*.png;*.gif;*.tif;...|All files (*.*)|*.*";

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.imagenEmpresaPictureBox.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }


        private void BtnGuardarFamilias_Click(object sender, EventArgs e)
        {

            if (File.Exists(ClasDatos.RutaMultidatos))
            {
                Validate();
                this.dtFamiliaProductosBindingSource.EndEdit();
                this.DataGridFamilias.EndEdit();
                FormMenuPrincipal.menu2principal.dsMultidatos.WriteXml(ClasDatos.RutaMultidatos);
                MessageBox.Show("Se Actualizo Con Exito", "FAMILIAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Se Guardo", "FALTAN ARCHIVOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DataGridFamilias_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int II = 0;
            int FILAbusc = this.DataGridFamilias.CurrentCell.RowIndex;
            foreach (DataGridViewRow CeldaF in this.DataGridFamilias.Rows)
            {
                if (CeldaF.Cells[0].Value != null)
                {
                    if (FILAbusc != II)
                    {
                        if (CeldaF.Cells[0].Value.ToString() == this.DataGridFamilias.Rows[FILAbusc].Cells[0].Value.ToString())

                        {
                            // DataGridFamilias.CurrentCell.Selected = true;
                            this.DataGridFamilias.BeginEdit(true);
                            MessageBox.Show("Articulo Repetido", "EXISTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            break;
                        }
                        else
                        {

                            this.DataGridFamilias.Refresh();
                        }

                        II++;
                    }


                }

            }
            //DataGridFamilias.BeginEdit(false);
        }


        private void BtnEliminarImagenE_Click(object sender, EventArgs e)
        {
            //imagenEmpresaPictureBox.Image = Image.FromFile(null);
            this.imagenEmpresaPictureBox.Image = (null);
        }

        private void BtnEliminarEmpresa_Click(object sender, EventArgs e)
        {
            if (this.dtConfiguracionPrincipalBindingSource.Count > 0)
            {
                if (MessageBox.Show("Desea Eliminar Permanentemente y Todo su Contenido", "ELIMINAR ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    if (File.Exists(ClasDatos.RutaConfiguracionXml))
                    {
                        FormMenuPrincipal.menu2principal.dsCONFIGURACCION.WriteXml(ClasDatos.RutaConfiguracionXml);
                        this.dtConfiguracionPrincipalDataGridView.Rows.Remove(this.dtConfiguracionPrincipalDataGridView.CurrentRow);
                        MessageBox.Show("Se Elimino Correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(" No Se Pudo Eliminar", "FALTA ARCHIVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        private void tabMENU_Click(object sender, EventArgs e)
        {

        }

        private void tabMENU_Enter(object sender, EventArgs e)
        {


            this.label5.Text = Cursor.Position.Y.ToString();
            FormMenuPrincipal.menu2principal.panelventas.Visible = false;
            FormMenuPrincipal.menu2principal.panelSUBventas.Visible = false;
        }

        private void BtnEliminarEjercicio_Click(object sender, EventArgs e)
        {
            if (this.dtConfiBindingSource.Count > 0)
            {
                if (MessageBox.Show("Desea Eliminar La Configuracion", "ELIMINAR ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    if (File.Exists(ClasDatos.RutaConfiguracionXml))
                    {
                        FormMenuPrincipal.menu2principal.dsCONFIGURACCION.WriteXml(ClasDatos.RutaConfiguracionXml);
                        this.dtConfiDataGridView.Rows.Remove(this.dtConfiDataGridView.CurrentRow);
                        this.dtConfiBindingSource.EndEdit();
                        this.dtConfiDataGridView.EndEdit();
                        MessageBox.Show("Se Elimino Correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void empresaConfiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else if ((e.KeyChar == '-') && (e.KeyChar == '_'))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }

        }

        private void btnVolverPaises_Click(object sender, EventArgs e)
        {
            this.tabControlTodo.TabPages.Insert(0, this.tabMENU);
            this.tabPagePaises.Parent = null;
        }

        private void BtnActualizarPaises_Click(object sender, EventArgs e)
        {
            if (EspacioDiscosConfi(ClasDatos.Clientes, 10))
            {
                if (ClsConexionSql.SibaseDatosSql)
                {

                }
                else
                {
                    Validate();
                    this.dataGridPaises.EndEdit();
                    this.dtPaisesBindingSource.EndEdit();
                    if (File.Exists(ClasDatos.RutaMulti2))
                    {
                        FormMenuPrincipal.menu2principal.dsMulti2.WriteXml(ClasDatos.RutaMulti2);
                        MessageBox.Show("Se Actualizo Con Exito", "PAISES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No Se Guardo", "FALTAN ARCHIVOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
        }



        private void ejerciciosDeAñoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            if ((e.KeyChar == 95))
            {
                e.Handled = false;

            }
            else

            if ((e.KeyChar == 45))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }


        private void dataGridPaises_Validated(object sender, EventArgs e)
        {
            this.dataGridPaises.Sort(this.dataGridPaises.Columns[0], ListSortDirection.Ascending);
        }


        private void dataGridPaises_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (this.dataGridPaises.RowCount >= 0)
                {

                    string paisPais = this.dataGridPaises.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (e.ColumnIndex == 1)
                    {

                        this.dataGridPaises.CurrentCell = this.dataGridPaises.Rows[e.RowIndex].Cells[0];
                        this.dataGridPaises.BeginEdit(true);
                    }
                    if (e.ColumnIndex == 2)
                    {
                        if (e.RowIndex < this.dataGridPaises.RowCount - 1)
                        {
                            if (MessageBox.Show("Desea Eliminar Este Pais ?? " + "\n" + "\n" + paisPais, "ELIMINAR ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {


                                this.dataGridPaises.Rows.Remove(this.dataGridPaises.CurrentRow);
                                this.dtPaisesBindingSource.EndEdit();
                                this.dataGridPaises.Refresh();
                                if (File.Exists(ClasDatos.RutaMulti2))
                                {
                                    FormMenuPrincipal.menu2principal.dsMulti2.WriteXml(ClasDatos.RutaMulti2);
                                }
                                MessageBox.Show(paisPais + "\n" + "\n" + "Eliminado Con Exito ", "ELIMINAR ", MessageBoxButtons.OK);
                            }

                        }
                    }
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.dsMultidatos.DtArchivoDatosMulti.Count > 0)
            {
                if (this.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["RutaArchivoDatos"].ToString() != string.Empty)
                {
                    this.idComboBox.Text = this.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["RutaArchivoDatos"].ToString();
                }
            }
        }

        private void BtnCopySecurite_Click(object sender, EventArgs e)
        {

        }

        private void BtnVolverProvincias_Click(object sender, EventArgs e)
        {
            this.tabControlTodo.TabPages.Insert(0, this.tabMENU);
            this.TabPageProvincias.Parent = null;
        }

        private void BtnActualizarProvincias_Click(object sender, EventArgs e)
        {
            Validate();
            this.dtProvinciasBindingSource.EndEdit();
            this.dataGridProvincias.EndEdit();
            if (File.Exists(ClasDatos.RutaMulti2))
            {
                this.dsMulti2.WriteXml(ClasDatos.RutaMulti2);
                MessageBox.Show("Se Actualizo Con Exito", "PROVINCIAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Se Guardo", "FALTAN ARCHIVOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        private void crearCopiaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControlTodo.TabPages.Insert(1, this.tabPageEmpresas);
            this.tabMENU.Parent = null;
        }

        private void crearEjercioNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControlTodo.TabPages.Insert(1, this.tabCONFIGURACION);
            this.tabMENU.Parent = null;
        }

        private void familiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControlTodo.TabPages.Insert(1, this.tabFAMILIAproductos);
            this.tabMENU.Parent = null;
        }

        private void configurarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabControlTodo.TabPages.Insert(1, this.tabPageInicio);
                this.tabMENU.Parent = null;
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void añadirBaseDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControlTodo.TabPages.Insert(1, this.tabPageArchivo);
            this.tabMENU.Parent = null;
        }

        private void crearCopiaCompletaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.Description = "COPIA SEGURIDAD";
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string RutaOrigen = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal;
                string RutaDestino = this.folderBrowserDialog1.SelectedPath;
                string CarpetaBackup = "BACKUP " + String.Format("{0:dd-MM-yyyy hhmmss}", DateTime.Now);
                string BACKUP = RutaDestino + "\\" + "Copia Seguridad" + "\\" + CarpetaBackup;


                if (!Directory.Exists(RutaDestino + "\\" + "Copia Seguridad"))
                {
                    DirectoryInfo DirectiorioCopia = new DirectoryInfo(RutaDestino);
                    DirectiorioCopia.CreateSubdirectory("Copia Seguridad");
                    if (!Directory.Exists(BACKUP))
                    {
                        DirectoryInfo DirectioriobACKUP = new DirectoryInfo(RutaDestino + "\\" + "Copia Seguridad");
                        DirectioriobACKUP.CreateSubdirectory(CarpetaBackup);
                    }


                    if (!Directory.Exists(BACKUP + "\\" + ClasDatos.RutaDatosPrincipal))
                    {
                        DirectoryInfo dir = new DirectoryInfo(BACKUP);
                        dir.CreateSubdirectory(ClasDatos.RutaDatosPrincipal);
                    }
                    if (!Directory.Exists(BACKUP + "\\" + "Aplicacion"))
                    {
                        DirectoryInfo dir = new DirectoryInfo(BACKUP);
                        dir.CreateSubdirectory("Aplicacion");
                    }
                    for (int i = 1; i <= 5; i++)
                    {
                        if (!Directory.Exists(BACKUP + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + ClasDatos.RutaDatosPrincipal + " FN" + i))
                        {
                            DirectoryInfo dir = new DirectoryInfo(BACKUP + "\\" + ClasDatos.RutaDatosPrincipal);
                            dir.CreateSubdirectory(ClasDatos.RutaDatosPrincipal + " FN" + i);
                        }
                        foreach (string RutaOrigenArchivos in Directory.GetFiles(RutaOrigen + "\\" + ClasDatos.RutaDatosPrincipal + " FN" + i, "*.*", SearchOption.AllDirectories))
                        {
                            FileInfo Dir2 = new FileInfo(RutaOrigenArchivos);
                            var Archivos = Dir2.Name;
                            File.Copy(RutaOrigenArchivos, BACKUP + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + ClasDatos.RutaDatosPrincipal + " FN" + i + "\\" + Archivos, true);

                        }
                    }

                    ///          MODIFCANDO DESDE AQUI   //////////////

                    foreach (string RutaOrigenArchivos in Directory.GetFiles(BACKUP + "\\" + ClasDatos.RutaDatosPrincipal, "*.*", SearchOption.TopDirectoryOnly))
                    {
                        FileInfo Dir2 = new FileInfo(RutaOrigenArchivos);
                        var Archivos = Dir2.Name;
                        File.Copy(RutaOrigenArchivos, BACKUP + "\\" + Archivos, true);

                    }
                    foreach (string RutaOrigenArchivos in Directory.GetFiles(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal, "*.*", SearchOption.TopDirectoryOnly))
                    {
                        FileInfo Dir2 = new FileInfo(RutaOrigenArchivos);
                        var Archivos = Dir2.Name;
                        File.Copy(RutaOrigenArchivos, BACKUP + "\\" + "Aplicacion" + "\\" + Archivos, true);
                    }

                    MessageBox.Show("Copia Seguridad Guardada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show(" ¿Ya Existe Copia sobreescribirla ? ", " GUARDAR COPIA SEGURIDAD ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DirectoryInfo DirectiorioCopia = new DirectoryInfo(RutaDestino);
                        DirectiorioCopia.CreateSubdirectory("Copia Seguridad");
                        if (!Directory.Exists(BACKUP))
                        {
                            DirectoryInfo DirectioriobACKUP = new DirectoryInfo(RutaDestino + "\\" + "Copia Seguridad");
                            DirectioriobACKUP.CreateSubdirectory(CarpetaBackup);
                        }


                        if (!Directory.Exists(BACKUP + "\\" + ClasDatos.RutaDatosPrincipal))
                        {
                            DirectoryInfo dir = new DirectoryInfo(BACKUP);
                            dir.CreateSubdirectory(ClasDatos.RutaDatosPrincipal);
                        }
                        if (!Directory.Exists(BACKUP + "\\" + "Aplicacion"))
                        {
                            DirectoryInfo dir = new DirectoryInfo(BACKUP);
                            dir.CreateSubdirectory("Aplicacion");
                        }
                        for (int i = 1; i <= 5; i++)
                        {
                            if (!Directory.Exists(BACKUP + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + ClasDatos.RutaDatosPrincipal + " FN" + i))
                            {
                                DirectoryInfo dir = new DirectoryInfo(BACKUP + "\\" + ClasDatos.RutaDatosPrincipal);
                                dir.CreateSubdirectory(ClasDatos.RutaDatosPrincipal + " FN" + i);
                            }
                            foreach (string RutaOrigenArchivos in Directory.GetFiles(RutaOrigen + "\\" + ClasDatos.RutaDatosPrincipal + " FN" + i, "*.*", SearchOption.TopDirectoryOnly))
                            {
                                FileInfo Dir2 = new FileInfo(RutaOrigenArchivos);
                                var Archivos = Dir2.Name;
                                File.Copy(RutaOrigenArchivos, BACKUP + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + ClasDatos.RutaDatosPrincipal + " FN" + i + "\\" + Archivos, true);

                            }
                        }


                        foreach (string RutaOrigenArchivos in Directory.GetFiles(BACKUP + "\\" + ClasDatos.RutaDatosPrincipal, "*.*", SearchOption.TopDirectoryOnly))
                        {
                            FileInfo Dir2 = new FileInfo(RutaOrigenArchivos);
                            var Archivos = Dir2.Name;
                            File.Copy(RutaOrigenArchivos, BACKUP + "\\" + "Aplicacion " + "\\" + Archivos, true);

                        }


                        MessageBox.Show("Copia Seguridad Modificada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void imprimirReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormVistaPreliminar FmrMostrar = new FormVistaPreliminar();
                //string dt = dtConfiBindingSource;
                FormReporteFactura ffff = new FormReporteFactura();
                //FormReporteFactura.menu2Reporte.reportViewer1 ff = new FormReporteFactura.menu2Reporte.reportViewer1();
                // FormVistaPreliminar.menu2MostrarReportes.ReportesVer.LocalReport.DataSources.Clear();
                // FormMostrarReportes.menu2MostrarReportes.ReportesVer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("FormReporteFactura.menu2Reporte.DtDetallesFacturaBindingSource", FormFACTURAR.menu2FACTURAR.dtDetallesFacturaBindingSource));
                // FormMostrarReportes.menu2MostrarReportes.ReportesVer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("FormReporteFactura.menu2Reporte.DtNuevaFacturaBindingSource", FormFACTURAR.menu2FACTURAR.dtNuevaFacturaBindingSource));
                //FormMostrarReportes.menu2MostrarReportes.ReportesVer.LocalReport.ReportPath = ("ReporteFactura.rdlc");
                //FormMostrarReportes.menu2MostrarReportes.panel5.Controls.Add(ffff);
                // ffff.TopLevel = false;
                //ffff.FormBorderStyle = FormBorderStyle.None;
                //ffff.Dock = DockStyle.Fill;
                //FormMostrarReportes.menu2MostrarReportes.panel5.Controls.Add(ffff);
                //FormMenuPrincipal.menu2principal.panelContenedorForm.Controls.Add(ffff);
                //FmrMostrar.ShowDialog();
                ReportDataSource rs = new ReportDataSource
                {
                    Name = "DataSetFactura",
                    Value = FormReporteFactura.menu2Reporte.DtDetallesFacturaBindingSource
                };

                FmrMostrar.ReportesVer.LocalReport.DataSources.Clear();
                FmrMostrar.ReportesVer.LocalReport.DataSources.Add(rs);
                FmrMostrar.ReportesVer.LocalReport.ReportEmbeddedResource = "ReporteFactura.rdlc";
                FmrMostrar.ReportesVer.LocalReport.DisplayName = "Your File Name Goes Here" + "_" + DateTime.Now.ToString("yyyyMMdd HH:mm");
                FmrMostrar.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void menuStrip_MouseLeave(object sender, EventArgs e)
        {
            if (Cursor.Position.Y > 800)
            {
                //return;
                this.toolArchivo.DropDown.Visible = false;
                this.toolDescuentos.DropDown.Visible = false;
                this.toolEmpresas.DropDown.Visible = false;
                this.toolFamilia.DropDown.Visible = false;
                this.toolCopiaSeguridad.DropDown.Visible = false;
                this.tooInicio.DropDown.Visible = false;
                this.ayudaToolStripMenuItem.DropDown.Visible = false;
            }
        }

        private void toolArchivo_MouseEnter(object sender, EventArgs e)
        {
            this.toolArchivo.Visible = true;
        }

        private void verDescuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControlTodo.TabPages.Insert(1, this.tabPageTarifa);
            this.tabMENU.Parent = null;
        }
        private void GuardarAlmacenesSql()
        {
            string consulta = "";
            if (this.BtnNuevaEmpresa.Tag.ToString() == "Nuevo")
            {
                consulta = "  INSERT INTO [DtAlmacenes]([@Id_almacenes],[@Almacenes],[@Enlace_Almacenes])";
            }
            else
            {
                consulta = "UPDATE [DtAlmacenes] SET [Id_almacenes] = @Id_almacenes,[Almacenes] = @Almacenes, [Enlace_Almacenes] = @Enlace_Almacenes, " +
                " WHERE Enlace_Almacenes = @Enlace_Almacenes";
            }
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                if (NuevaConexion.SiConexionSql)
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Enlace_Almacenes", string.IsNullOrEmpty(this.enlace_AlmacenesTextBox.Text) ? (object)DBNull.Value : this.enlace_AlmacenesTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id_almacenes", string.IsNullOrEmpty(this.id_almacenes.Text) ? (object)DBNull.Value : Convert.ToInt32(this.id_almacenes.Text));
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Almacenes", string.IsNullOrEmpty(this.almacenesTextBox.Text) ? (object)DBNull.Value : this.almacenesTextBox.Text);
                    NuevaConexion.ComandoSql.ExecuteNonQuery();
                    NuevaConexion.ComandoSql.Parameters.Clear();
                    RestaurarOjetosEmpresa();
                    MessageBox.Show("Se Guardo Correctamente", "GUARDAR ALMACENEN ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Validate();
                    this.dtAlmacenesBindingSource.EndEdit();
                    this.dataGridAlmacenes.EndEdit();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ALMACNEN");
            }
            finally
            {
                if (NuevaConexion.CerrarConexionSql)
                {

                }
            }
        }
        private void GuardarProveedoresSql()
        {
            string consulta = "";
            if (this.BtnNuevaEmpresa.Tag.ToString() == "Nuevo")
            {
                consulta = "  INSERT INTO [DtProveedores]([@Id_Proveedores],[@Proveedores],[@Enlace_Proveedores])";

            }
            else
            {
                consulta = "UPDATE [DtProveedores] SET [Id_Proveedores] = @Id_Proveedores,[Proveedores] = @Proveedores, [Enlace_Proveedores] = @Enlace_Proveedores, " +
                " WHERE Enlace_Proveedores = @Enlace_Proveedores";
            }
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                if (NuevaConexion.SiConexionSql)
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Enlace_Proveedores", string.IsNullOrEmpty(this.enlace_AlmacenesTextBox.Text) ? (object)DBNull.Value : this.enlace_AlmacenesTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id_almacenes", string.IsNullOrEmpty(this.id_almacenes.Text) ? (object)DBNull.Value : Convert.ToInt32(this.id_almacenes.Text));
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Proveedores", string.IsNullOrEmpty(this.almacenesTextBox.Text) ? (object)DBNull.Value : this.almacenesTextBox.Text);
                    NuevaConexion.ComandoSql.ExecuteNonQuery();
                    NuevaConexion.ComandoSql.Parameters.Clear();
                    RestaurarOjetosEmpresa();
                    MessageBox.Show("Se Guardo Correctamente", "GUARDAR PROVEEDOR ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Validate();
                    this.dtAlmacenesBindingSource.EndEdit();
                    this.dataGridAlmacenes.EndEdit();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ALMACNEN");
            }
            finally
            {
                if (NuevaConexion.CerrarConexionSql)
                {

                }
            }
        }
        private void BtnActualizarAlmacenes_Click(object sender, EventArgs e)
        {
            if (this.dtConfiguracionPrincipalBindingSource.Count <= 0)
            {
                MessageBox.Show("Debe al Menos Crear Una Empresa", "EMPRESA");
                return;
            }
            if (string.IsNullOrEmpty(this.empresaConfiComboBox.Text) && string.IsNullOrEmpty(this.EmpresaReguistro.Text))
            {

                MessageBox.Show("Eliga Empresa Valida", "EMPRESA");
                return;
            }
            if (EspacioDiscosConfi(ClasDatos.RutaDatosPrincipal, 30))
            {
                if (string.IsNullOrEmpty(this.enlace_AlmacenesTextBox.Text) & string.IsNullOrEmpty(this.id_almacenes.Text))
                {
                    MessageBox.Show("Datos Erradicos ", "FALTA ENLACE FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(this.almacenesTextBox.Text))
                {
                    MessageBox.Show("Rellene Campo de Almacen ", "FALTA ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ClsConexionSql.SibaseDatosSql)
                {
                    GuardarAlmacenesSql();
                }
                else
                {
                    try
                    {

                        if (File.Exists(ClasDatos.RutaConfiguracionXml))
                        {
                            Validate();
                            this.dtAlmacenesBindingSource.EndEdit();
                            this.dataGridAlmacenes.EndEdit();

                            FormMenuPrincipal.menu2principal.dsCONFIGURACCION.WriteXml(ClasDatos.RutaConfiguracionXml);
                            MessageBox.Show("Se Actualizo Con Exito", "ALMACENES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No Se Guardo", "FALTAN ARCHIVOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                this.dataGridAlmacenes.Enabled = true;
                this.almacenesTextBox.ReadOnly = true;
                this.panelBotonesArchivo.Enabled = true;
            }
        }

        private void BtnVolverAlmacenes_Click(object sender, EventArgs e)
        {
            this.tabControlTodo.TabPages.Insert(0, this.tabMENU);
            this.Almacenes.Parent = null;
        }

        private void BtnGuardarObras_Click(object sender, EventArgs e)
        {
            if (EspacioDiscosConfi(ClasDatos.RutaConfiguracionXml, 30))
            {
                if (File.Exists(ClasDatos.RutaMulti2))
                {
                    this.dtObrasBindingSource.EndEdit();
                    this.dataGridObras.EndEdit();
                    Validate();
                    FormMenuPrincipal.menu2principal.dsMulti2.WriteXml(ClasDatos.RutaMulti2);
                    MessageBox.Show("Se Actualizo Con Exito", "OBRA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No Se Guardo", "FALTAN ARCHIVOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void BtnGuardarProveedores_Click(object sender, EventArgs e)
        {
            if (this.dtConfiguracionPrincipalBindingSource.Count <= 0)
            {
                MessageBox.Show("Debe al Menos Crear Una Empresa", "EMPRESA");
                return;
            }
            if (string.IsNullOrEmpty(this.empresaConfiComboBox.Text) && string.IsNullOrEmpty(this.EmpresaReguistro.Text))
            {

                MessageBox.Show("Eliga Empresa Valida", "EMPRESA");
                return;
            }
            if (EspacioDiscosConfi(ClasDatos.RutaConfiguracionXml, 30))
            {
                if (ClsConexionSql.SibaseDatosSql)
                {
                    GuardarProveedoresSql();
                }
                else
                {
                    if (File.Exists(ClasDatos.RutaConfiguracionXml))
                    {
                        this.dtProveedoresBindingSource.EndEdit();
                        this.dataGridProveedores.EndEdit();
                        Validate();
                        FormMenuPrincipal.menu2principal.dsCONFIGURACCION.WriteXml(ClasDatos.RutaConfiguracionXml);
                        MessageBox.Show("Se Actualizo Con Exito", "PROVEEDORES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No Se Guardo", "FALTAN ARCHIVOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                this.dataGridProveedores.Enabled = true;
            }
        }

        private void dataGridProvincias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (this.dataGridProvincias.RowCount >= 0)
                {

                    string provi = this.dataGridProvincias.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (e.ColumnIndex == 1)
                    {

                        this.dataGridProvincias.CurrentCell = this.dataGridProvincias.Rows[e.RowIndex].Cells[0];
                        this.dataGridProvincias.BeginEdit(true);
                    }
                    if (e.ColumnIndex == 2)
                    {
                        if (e.RowIndex < this.dataGridProvincias.RowCount - 1)
                        {
                            if (MessageBox.Show("Desea Eliminar Este Provincia ?? " + "\n" + "\n" + provi, "ELIMINAR ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                this.dataGridProvincias.Rows.Remove(this.dataGridProvincias.CurrentRow);
                                this.dtProvinciasBindingSource.EndEdit();
                                this.dataGridProvincias.Refresh();
                                if (File.Exists(ClasDatos.RutaMulti2))
                                {
                                    FormMenuPrincipal.menu2principal.dsMulti2.WriteXml(ClasDatos.RutaMulti2);
                                }
                                MessageBox.Show(provi + "\n" + "\n" + "Eliminado Con Exito ", "ELIMINAR ", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
            }
        }

        private void dataGridProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (this.dataGridProveedores.RowCount >= 0)
                {

                    string provi = this.dataGridProveedores.Rows[e.RowIndex].Cells[1].Value.ToString();
                    if (e.ColumnIndex == 2)
                    {

                        this.dataGridProveedores.CurrentCell = this.dataGridProveedores.Rows[e.RowIndex].Cells[1];
                        this.dataGridProveedores.BeginEdit(true);
                    }
                    if (e.ColumnIndex == 3)
                    {
                        if (e.RowIndex < this.dataGridProveedores.RowCount - 1)
                        {


                            if (MessageBox.Show("Desea Eliminar Este Provedor ?? " + "\n" + "\n" + provi, "ELIMINAR ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                this.dataGridProveedores.Rows.Remove(this.dataGridProveedores.CurrentRow);
                                this.dtProveedoresBindingSource.EndEdit();
                                this.dataGridProveedores.Refresh();
                                if (File.Exists(ClasDatos.RutaConfiguracionXml))
                                {
                                    FormMenuPrincipal.menu2principal.dsCONFIGURACCION.WriteXml(ClasDatos.RutaConfiguracionXml);
                                }
                                MessageBox.Show(provi + "\n" + "\n" + "Eliminado Con Exito ", "ELIMINAR ", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
            }
        }

        private void dataGridObras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                string provi = this.dataGridObras.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (e.ColumnIndex == 2)
                {

                    this.dataGridObras.CurrentCell = this.dataGridObras.Rows[e.RowIndex].Cells[1];
                    this.dataGridObras.BeginEdit(true);
                }
                if (e.ColumnIndex == 3)
                {
                    if (e.RowIndex < this.dataGridObras.RowCount - 1)
                    {
                        if (MessageBox.Show("Desea Eliminar Este Obra ?? " + "\n" + "\n" + provi, "ELIMINAR ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            this.dataGridObras.Rows.Remove(this.dataGridObras.CurrentRow);
                            this.dtObrasBindingSource.EndEdit();
                            this.dataGridObras.Refresh();
                            if (File.Exists(ClasDatos.RutaMulti2))
                            {
                                FormMenuPrincipal.menu2principal.dsMulti2.WriteXml(ClasDatos.RutaMulti2);
                            }
                            MessageBox.Show(provi + "\n" + "\n" + "Eliminado Con Exito ", "ELIMINAR ", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void BtnVolverProveedores_Click(object sender, EventArgs e)
        {
            this.tabControlTodo.TabPages.Insert(0, this.tabMENU);
            this.tabProveedores.Parent = null;
        }

        private void BtnVolverObras_Click(object sender, EventArgs e)
        {
            this.tabControlTodo.TabPages.Insert(0, this.tabMENU);
            this.tabObras.Parent = null;
        }

        private void provinciasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabControlTodo.TabPages.Insert(1, this.TabPageProvincias);
                this.tabMENU.Parent = null;
            }
            catch (Exception)
            {

                // throw;
            }
        }

        private void paisesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabControlTodo.TabPages.Insert(1, this.tabPagePaises);
                this.tabMENU.Parent = null;
            }
            catch (Exception)
            {

                // throw;
            }
        }

        private void almacenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabControlTodo.TabPages.Insert(1, this.Almacenes);
                this.tabMENU.Parent = null;
            }
            catch (Exception)
            {

                // throw;
            }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabControlTodo.TabPages.Insert(1, this.tabProveedores);
                this.tabMENU.Parent = null;
            }
            catch (Exception)
            {

                // throw;
            }
        }

        private void obrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabControlTodo.TabPages.Insert(1, this.tabObras);
                this.tabMENU.Parent = null;
            }
            catch (Exception)
            {

                // throw;
            }
        }

        private void dataGridAlmacenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                string provi = this.dataGridAlmacenes.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (e.ColumnIndex == 2)
                {

                    this.dataGridAlmacenes.CurrentCell = this.dataGridAlmacenes.Rows[e.RowIndex].Cells[0];
                    this.dataGridAlmacenes.BeginEdit(true);
                }
                if (e.ColumnIndex == 3)
                {
                    if (e.RowIndex < this.dataGridAlmacenes.RowCount - 1)
                    {


                        if (MessageBox.Show("Desea Eliminar Este Almacen ?? " + "\n" + "\n" + provi, "ELIMINAR ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            this.dataGridAlmacenes.Rows.Remove(this.dataGridAlmacenes.CurrentRow);
                            this.dtAlmacenesBindingSource.EndEdit();
                            this.dataGridAlmacenes.Refresh();
                            if (File.Exists(ClasDatos.RutaConfiguracionXml))
                            {
                                FormMenuPrincipal.menu2principal.dsCONFIGURACCION.WriteXml(ClasDatos.RutaConfiguracionXml);
                            }
                            MessageBox.Show(provi + "\n" + "\n" + "Eliminado Con Exito ", "ELIMINAR ", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void DataGridFamilias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                string provi = this.DataGridFamilias.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (e.ColumnIndex == 1)
                {

                    this.DataGridFamilias.CurrentCell = this.DataGridFamilias.Rows[e.RowIndex].Cells[0];
                    this.DataGridFamilias.BeginEdit(true);
                }
                if (e.ColumnIndex == 2)
                {
                    if (e.RowIndex < this.DataGridFamilias.RowCount - 1)
                    {


                        if (MessageBox.Show("Desea Eliminar Familia Producto ?? " + "\n" + "\n" + provi, "ELIMINAR ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            this.DataGridFamilias.Rows.Remove(this.DataGridFamilias.CurrentRow);
                            this.dtFamiliaProductosBindingSource.EndEdit();
                            this.DataGridFamilias.Refresh();
                            if (File.Exists(ClasDatos.RutaMultidatos))
                            {
                                FormMenuPrincipal.menu2principal.dsMultidatos.WriteXml(ClasDatos.RutaMultidatos);
                            }
                            MessageBox.Show(provi + "\n" + "\n" + "Eliminado Con Exito ", "ELIMINAR ", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void datosDeInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabControlTodo.TabPages.Insert(1, this.tabPageInicio);
                this.tabMENU.Parent = null;
                this.BtnGuardarInicio.Visible = false;
                this.panelDatosInicio.Enabled = false;
            }
            catch (Exception)
            {

                // throw;
            }
        }

        private void editarDescuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelBotonesTipoTarifa.Visible = false;
            this.BtnGuardarDescuentos.Visible = false;
            this.tabControlTodo.TabPages.Insert(1, this.tabPageTarifa);
            this.tabMENU.Parent = null;

        }

        private void DataGridFamilias_Validated(object sender, EventArgs e)
        {
            this.DataGridFamilias.Sort(this.DataGridFamilias.Columns[0], ListSortDirection.Ascending);
        }

        private void dataGridProvincias_Validated(object sender, EventArgs e)
        {
            this.dataGridProvincias.Sort(this.dataGridProvincias.Columns[0], ListSortDirection.Ascending);
        }

        private void dataGridAlmacenes_Validated(object sender, EventArgs e)
        {
            //this.dataGridAlmacenes.Sort(this.dataGridAlmacenes.Columns[1], ListSortDirection.Ascending);
        }

        private void dataGridProveedores_Validated(object sender, EventArgs e)
        {
            this.dataGridProveedores.Sort(this.dataGridProveedores.Columns[1], ListSortDirection.Ascending);
        }

        private void dataGridObras_Validated(object sender, EventArgs e)
        {
            {
                this.dataGridObras.Sort(this.dataGridObras.Columns[1], ListSortDirection.Ascending);
            }
        }

        private void crearBaseDatosSqlLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCrearBaseDatos frm = new FormCrearBaseDatos();
            frm.BringToFront();
            frm.ShowDialog();
        }

        private void BtnNuevoAlmacen_Click(object sender, EventArgs e)
        {
            this.BtnNuevoAlmacen.Tag = "Nuevo";
            try
            {
                int numeroFILA = this.dataGridAlmacenes.Rows.Count;
                this.dtAlmacenesBindingSource.AddNew();
                if (this.dataGridAlmacenes.CurrentCell.RowIndex == 0)
                {
                    this.idEmpresaTextBox.Text = "1";
                    this.dataGridAlmacenes.Rows[0].Cells[0].Value = "1";
                }
                if (numeroFILA > 0)
                {
                    if (this.dataGridAlmacenes.Rows[numeroFILA - 1].Cells[0].Value.ToString() == string.Empty)
                    {
                        Random r = new Random();
                        int VALORid = r.Next(5000, 100000000);
                        this.dataGridAlmacenes.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.id_almacenes.Text = VALORid.ToString();
                    }
                    else
                    {
                        int VALORid = Convert.ToInt32(this.dataGridAlmacenes.Rows[numeroFILA - 1].Cells[0].Value) + 1;
                        this.dataGridAlmacenes.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.id_almacenes.Text = VALORid.ToString();
                    }
                    this.almacenesTextBox.ReadOnly = false;
                    this.panelBotonesArchivo.Enabled = false;
                    this.BtnActualizarAlmacenes.Enabled = true;
                    this.BtnCancelarAlmacen.Enabled = true;
                }

                this.dataGridAlmacenes.Enabled = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnModificarAlmacen_Click(object sender, EventArgs e)
        {
            this.BtnNuevoAlmacen.Tag = "stop";
            this.almacenesTextBox.ReadOnly = false;
            this.panelBotonesArchivo.Enabled = false;
            this.BtnActualizarAlmacenes.Enabled = true;
            this.BtnCancelarAlmacen.Enabled = true;
            this.dataGridProveedores.Enabled = false;
        }

        private void BtnCancelarAlmacen_Click(object sender, EventArgs e)
        {
            this.almacenesTextBox.ReadOnly = true;
            this.panelBotonesArchivo.Enabled = true;
            this.BtnActualizarAlmacenes.Enabled = false;
            this.BtnCancelarAlmacen.Enabled = false;
            this.panelBotonesArchivo.Enabled = true;
            this.dataGridAlmacenes.Enabled = true;
            if (this.BtnNuevoAlmacen.Tag.ToString() == "Nuevo")
            {
                if (this.dataGridAlmacenes.RowCount >= 0)
                {
                    this.dataGridAlmacenes.Rows.RemoveAt(this.dataGridAlmacenes.CurrentCell.RowIndex);
                }

            }

        }

        private void BtnRestructurar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Restructurar Archivos y Carpetas Sistema", "RESTRUCTURAR ARCHIVOS", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                CrearArchivos_Xml_Confi();
            }
        }

        private void BtnNuevoProveedor_Click(object sender, EventArgs e)
        {
            this.BtnNuevoAlmacen.Tag = "Nuevo";
            try
            {
                int numeroFILA = this.dataGridProveedores.Rows.Count;
                this.dtProveedoresBindingSource.AddNew();
                if (this.dataGridProveedores.CurrentCell.RowIndex == 0)
                {
                    this.Id_proveedor.Text = "1";
                    this.dataGridProveedores.Rows[0].Cells[0].Value = "1";
                }
                if (numeroFILA > 0)
                {
                    if (this.dataGridProveedores.Rows[numeroFILA - 1].Cells[0].Value.ToString() == string.Empty)
                    {
                        Random r = new Random();
                        int VALORid = r.Next(5000, 100000000);
                        this.dataGridProveedores.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.Id_proveedor.Text = VALORid.ToString();
                    }
                    else
                    {
                        int VALORid = Convert.ToInt32(this.dataGridProveedores.Rows[numeroFILA - 1].Cells[0].Value) + 1;
                        this.dataGridProveedores.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.Id_proveedor.Text = VALORid.ToString();
                    }
                    this.NombreProveedor.ReadOnly = false;
                    this.PanelElementosProveedor.Enabled = false;
                    this.BtnCancelarProveedores.Enabled = true;
                    this.BtnGuardarProveedores.Enabled = true;
                }

                this.dataGridProveedores.Enabled = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnModificarProveedor_Click(object sender, EventArgs e)
        {
            this.BtnNuevoAlmacen.Tag = "Modificar";
            this.dataGridProveedores.Enabled = false;
        }

        private void BtnCancelarProveedores_Click(object sender, EventArgs e)
        {
            this.dataGridProveedores.Enabled = true;
        }

        private void baseDatosLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCorreos frm = new FormCorreos();
            frm.BringToFront();
            frm.ShowDialog();
        }
    }
}

