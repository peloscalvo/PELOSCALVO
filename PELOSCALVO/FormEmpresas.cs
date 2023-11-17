using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormEmpresas : Form
    {
        public FormEmpresas()
        {
            InitializeComponent();
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
                    this.dtProvinciasBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2;
                    this.dtPaisesBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2;
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
    }
}
