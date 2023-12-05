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
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

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
            if (!File.Exists(ClasDatos.RutaBaseDatosDb))
            {
                MessageBox.Show("Archivo : " + ClasDatos.RutaBaseDatosDb, "FALTA ARCHIVO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            if (ClsConexionSql.SibaseDatosSql)
            {
                // this.tooInicio.Visible = false;
                // this.archivoArticulosComboBox.Items.Clear();
                // this.archivoClientesComboBox.Items.Clear();
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

 


        private void FormComfiguracion_FormClosing(object sender, FormClosingEventArgs e)
        {
   
        }

        private void BtnSalirTipoTarifa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" ¿Salir Configuracion ? ", " SALIR ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
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
                        FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["ArchivoInicioFacturas"] = ClasDatos.RutaBaseDatosDb;
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





        private void BtnVolverConfi_Inicio_Click(object sender, EventArgs e)
        {
            BorrarErroresInicio();

        }

        private void BtnConfiReportes_Click(object sender, EventArgs e)
        {


        }


 

        private void tabMENU_Click(object sender, EventArgs e)
        {

        }

        private void tabMENU_Enter(object sender, EventArgs e)
        {
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
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnCopySecurite_Click(object sender, EventArgs e)
        {

        }
       private void crearCopiaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearEjercioNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabMENU.Parent = null;
        }

        private void familiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            FormCrearTablasDb frm = new FormCrearTablasDb();
            frm.BringToFront();
            frm.ShowDialog();
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
        private void crearBaseDatosSqlLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCrearBaseDatos frm = new FormCrearBaseDatos();
            frm.BringToFront();
            frm.ShowDialog();
        }





        private void BtnRestructurar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Restructurar Archivos y Carpetas Sistema", "RESTRUCTURAR ARCHIVOS", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                CrearArchivos_Xml_Confi();
            }

        }
        private void baseDatosLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCrearCorreos frm = new FormCrearCorreos();
            frm.BringToFront();
            frm.ShowDialog();
        }

    }
}

