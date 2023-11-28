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
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            this.tabFAMILIAproductos.Parent = null;
            this.tabPageTarifa.Parent = null;
            this.tabPageInicio.Parent = null;
            this.tabPagePaises.Parent = null;
            this.TabPageProvincias.Parent = null;
            this.tabObras.Parent = null;

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

        private void btnGuardarFAMILIA_Click(object sender, EventArgs e)
        {
            if (EspacioDiscosConfi(ClasDatos.RutaMultidatos, 20))
            {

                if (File.Exists(ClasDatos.RutaMultidatos))
                {
                    this.dtFamiliaProductosBindingSource.EndEdit();
                    Validate();
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

                        if (EspacioDiscosConfi(ClasDatos.RutaBaseDatosDb, 20))
                        {
                            if (File.Exists(ClasDatos.RutaBaseDatosDb))
                            {
                                Validate();
                                this.dtConfiDtTarifaTipoBindingSource.EndEdit();
                                this.dtTarifaTipoDataGridView.EndEdit();
                                // FormMenuPrincipal.menu2principal.dsCONFIGURACCION.WriteXml(ClasDatos.RutaBaseDatosDb);
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

        private byte[] ConvertirImagen(PictureBox pitureImagen)
        {
            MemoryStream memo2 = new MemoryStream();
            if (pitureImagen.Image != null)
            {
                pitureImagen.Image.Save(memo2, System.Drawing.Imaging.ImageFormat.Jpeg);
            }

            return memo2.GetBuffer();
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

        private void BtnVolverFamilia_Click(object sender, EventArgs e)
        {
            this.tabControlTodo.TabPages.Insert(0, this.tabMENU);
            this.tabFAMILIAproductos.Parent = null;
        }

        private void BtnVolverEmpresas_Click(object sender, EventArgs e)
        {
            this.tabControlTodo.TabPages.Insert(0, this.tabMENU);
        }

        private void BtnVolverBasica_Click(object sender, EventArgs e)
        {
            this.tabControlTodo.TabPages.Insert(0, this.tabMENU);
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
  


        private void tabMENU_Click(object sender, EventArgs e)
        {

        }

        private void tabMENU_Enter(object sender, EventArgs e)
        {


            this.label5.Text = Cursor.Position.Y.ToString();
            FormMenuPrincipal.menu2principal.panelventas.Visible = false;
            FormMenuPrincipal.menu2principal.panelSUBventas.Visible = false;
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
            if (EspacioDiscosConfi(ClasDatos.RutaMultidatos, 10))
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
                    string paisPais = "Pais";
                    if (this.dataGridPaises.Rows[e.RowIndex].Cells[0].Value.ToString() != string.Empty)
                    {
                        paisPais = this.dataGridPaises.Rows[e.RowIndex].Cells[0].Value.ToString();
                    }

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

                                if (File.Exists(ClasDatos.RutaMulti2))
                                {
                                    this.dtPaisesBindingSource.EndEdit();
                                    this.dataGridPaises.Rows.Remove(this.dataGridPaises.CurrentRow);
                                    FormMenuPrincipal.menu2principal.dsMulti2.WriteXml(ClasDatos.RutaMulti2);
                                }
                                MessageBox.Show(paisPais + "\n" + "\n" + "Eliminado Con Exito ", "ELIMINAR ", MessageBoxButtons.OK);
                                this.dataGridPaises.Refresh();
                            }

                        }
                    }
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void crearEjercioNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
 
        private void BtnVolverAlmacenes_Click(object sender, EventArgs e)
        {
            this.tabControlTodo.TabPages.Insert(0, this.tabMENU);
        }

        private void BtnGuardarObras_Click(object sender, EventArgs e)
        {
            if (EspacioDiscosConfi(ClasDatos.RutaMultidatos, 30))
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
                                if (File.Exists(ClasDatos.RutaMulti2))
                                {
                                    this.dtProvinciasBindingSource.EndEdit();
                                    this.dataGridProvincias.Rows.Remove(this.dataGridProvincias.CurrentRow);
                                    FormMenuPrincipal.menu2principal.dsMulti2.WriteXml(ClasDatos.RutaMulti2);
                                }
                                MessageBox.Show(provi + "\n" + "\n" + "Eliminado Con Exito ", "ELIMINAR ", MessageBoxButtons.OK);
                                this.dataGridProvincias.Refresh();
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

            }
        }

        private void dataGridObras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                string provi = " Obra";
                if (this.dataGridObras.Rows[e.RowIndex].Cells[1].Value.ToString() != string.Empty)
                {
                    provi = this.dataGridObras.Rows[e.RowIndex].Cells[1].Value.ToString();
                }

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
                            if (EspacioDiscosConfi(ClasDatos.RutaMultidatos, 20))
                            {
                                if (File.Exists(ClasDatos.RutaMulti2))
                                {
                                    this.dtObrasBindingSource.EndEdit();
                                    this.dataGridObras.Rows.Remove(this.dataGridObras.CurrentRow);
                                    FormMenuPrincipal.menu2principal.dsMulti2.WriteXml(ClasDatos.RutaMulti2);
                                }
                                MessageBox.Show(provi + "\n" + "\n" + "Eliminado Con Exito ", "ELIMINAR ", MessageBoxButtons.OK);
                                this.dataGridObras.Refresh();
                            }
                        }
                    }
                }
            }
        }

        private void BtnVolverProveedores_Click(object sender, EventArgs e)
        {
            this.tabControlTodo.TabPages.Insert(0, this.tabMENU);
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

            }
        }

        private void DataGridFamilias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                string provi = "Familia";
                if (this.DataGridFamilias.Rows[e.RowIndex].Cells[0].Value.ToString() != string.Empty)
                {
                    provi = this.DataGridFamilias.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
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

                            if (File.Exists(ClasDatos.RutaMultidatos))
                            {
                                this.dtFamiliaProductosBindingSource.EndEdit();
                                this.DataGridFamilias.Rows.Remove(this.DataGridFamilias.CurrentRow);
                                FormMenuPrincipal.menu2principal.dsMultidatos.WriteXml(ClasDatos.RutaMultidatos);
                            }
                            MessageBox.Show(provi + "\n" + "\n" + "Eliminado Con Exito ", "ELIMINAR ", MessageBoxButtons.OK);
                            this.DataGridFamilias.Refresh();
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

