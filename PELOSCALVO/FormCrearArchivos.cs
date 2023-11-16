using System;
using System.IO;
using System.Windows.Forms;
using Conexiones;

namespace PELOSCALVO
{
    public partial class FormCrearArchivos : Form
    {
        public FormCrearArchivos()
        {
            InitializeComponent();
        }
        private void BuscarTarifas_Clientes()
        {
            int i;
            String variable2 = " De Clientes";
            if (this.tipoExtension.Text == "DBF")
            {
                variable2 = "";
            }
            for (i = 1; i <= 6; i++)
            {

                string Archivo2 = "Listado" + i;
                string Ruta = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + Archivo2 + variable2 + "." + this.tipoExtension.Text;
                if (File.Exists(Ruta))
                {

                    this.SerieCrear.Items.Add(Archivo2.ToString());
                }

            }
        }
        private void BuscarTarifas_Articulos()
        {
            String variable1 = " De Articulos";
            if (this.tipoExtension.Text == "DBF")
            {
                variable1 = "";
            }
            int i;
            for (i = 1; i <= 6; i++)
            {

                string Archivo = "Tarifa" + i;
                string Ruta = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + Archivo + variable1 + "." + this.tipoExtension.Text;
                if (File.Exists(Ruta))
                {
                    this.SerieCrear.Items.Add(Archivo.ToString());
                }

            }

        }
        private void FormCrearArchivos_Load(object sender, EventArgs e)
        {
            this.tipoExtension.Text = FormMenuPrincipal.menu2principal.InfoExtension.Text;
            this.SerieCrear.Text = "Nuevo o Vacio";
            if (ClasDatos.QUEform == "BASE_DATOS_ARTICULOS")
            {
                this.NombreArchivoClonar.Text = FormMenuPrincipal.menu2principal.InfoArticulo.Text;
                this.labelInfo.Text = "ARTICULOS";
                BuscarTarifas_Articulos();
            }
            if (ClasDatos.QUEform == "BASE_DATOS_CLIENTES")
            {
                this.NombreArchivoClonar.Text = FormMenuPrincipal.menu2principal.InfoClientes.Text;
                this.labelInfo.Text = "CLIENTES";
                BuscarTarifas_Clientes();
            }


        }
        private void CrearArchivoVacio()
        {
            try
            {
                if (File.Exists(ClasDatos.RutaBaseDatosDb))
                {
                    if (NombreArchivoClonar.Text != string.Empty)
                    {
                        String TipoTabla = "[DtArticulos]";
                        string consulta = "";

                        string cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\" + "[" + NombreArchivoClonar.Text + " De Articulos" + "]" + tipoExtension.Text;
                        // string sql = "DELETE FROM " + Archivo + "  WHERE ID= @ID";
                        if (FormMenuPrincipal.menu2principal.InfoExtension.Text == "accdb")
                        {
                            consulta = "Delete * from " +"["+ TipoTabla+"]";// + "  WHERE ID= @ID";
                            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ClasDatos.RutaBaseDatosDb;
                        }
                        if (FormMenuPrincipal.menu2principal.InfoExtension.Text == "mdb")
                        {
                            consulta = "Delete * from " + "["+ TipoTabla+"]";
                            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ClasDatos.RutaBaseDatosDb;
                        }
                        if (FormMenuPrincipal.menu2principal.InfoExtension.Text == "DBF")
                        {
                            consulta = "Delete * from " +"[" +FormMenuPrincipal.menu2principal.InfoArticulo.Text+"]";
                            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + ";Extended Properties=dBASE IV;";
                        }

                        ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
                        {
                            if (NuevaConexion.SiConexionDb)
                            {
                                ClsConexionDb.CadenaConexion = cadena;
                                //guarda Aqui

                            }
                        }

                        MessageBox.Show("Creado Correctamente", "CREAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormMenuPrincipal.menu2principal.InfoArticulo.Tag = "no";
                    }




                }
                else
                {
                    MessageBox.Show("El Archivo No Se Encuentra", "ARCHIVO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void BtnCrearArchivoDatos_Click(object sender, EventArgs e)
        {
            string variable1 = " De articulos";
            if (ClasDatos.QUEform == "BASE_DATOS_ARTICULOS")
            {
                variable1 = "Tarifa1";
            }
            if (ClasDatos.QUEform == "BASE_DATOS_CLIENTES")
            {
                variable1 = "Listado1";
            }
            if (FormMenuPrincipal.menu2principal.InfoExtension.Text == "DBF")
            {
                if (this.SerieCrear.SelectedIndex > 5)
                {
                    MessageBox.Show("Este Tipo De Archivo No Se Puede Crear", "CREAR", MessageBoxButtons.OK);
                    return;
                }

            }
            if (MessageBox.Show(" Desea Crear  ", " NUEVO ? ", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                string ruta = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + this.SerieCrear.Text + "." + FormMenuPrincipal.menu2principal.InfoExtension.Text;
                string destino = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + this.NombreArchivoClonar.Text + variable1 + "." + FormMenuPrincipal.menu2principal.InfoExtension.Text;
                if (this.SerieCrear.SelectedIndex == 0)
                {
                    ruta = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + variable1 + "." + FormMenuPrincipal.menu2principal.InfoExtension.Text;

                }

                try
                {
                    if (File.Exists(ruta))
                    {
                        File.Copy(ruta, destino, true);
                        MessageBox.Show("Se Creo Con EXito", "CREAR", MessageBoxButtons.OK);
                        if (this.SerieCrear.Text == "Nuevo o Vacio")
                        {
                            CrearArchivoVacio();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Falta Archivo Base", "ERROR AL CREAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }



            }
        }
    }
}



