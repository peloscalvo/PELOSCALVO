using System;
using System.IO;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormCrearCorreos : Form
    {
        string Rutacorreos = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + "correos.Xml";
        public FormCrearCorreos()
        {

            InitializeComponent();
        }

        private void FormCorreos_Load(object sender, EventArgs e)
        {
            try
            {
                if (FormMenuPrincipal.menu2principal.dsCorreos != null)
                {
                   // BindingSource CorreosbindingSource = new BindingSource();
                   // CorreosbindingSource.DataSource= FormMenuPrincipal.menu2principal.DtCorreos;
                    this.DatagridCorreosEmpresa.DataSource = FormMenuPrincipal.menu2principal.DtCorreos;
                    this.DataGridCorreoCliente.DataSource = FormMenuPrincipal.menu2principal.DtCorreosCliente;
                    //  if(DatagriCorreosEmpresa.RowCount<= 0)
                    //{
                    //    DataGridCorreoCliente.Rows[0].Cells[0].Value=""
                    // }
                }
            }
            catch (Exception)
            {

                // throw;
            }
            try
            {
                DatagridCorreosEmpresa.Columns[0].DisplayIndex = 7;
                DatagridCorreosEmpresa.Columns[0].Width = 190;//NombreEmpresa
                DatagridCorreosEmpresa.Columns[1].Width = 140;//CorreoEletronico
                DatagridCorreosEmpresa.Columns[2].Width = 120;//Usuario
                DatagridCorreosEmpresa.Columns[3].Width = 120;//Contraseña
                DatagridCorreosEmpresa.Columns[4].Width = 60;//smtp
                DatagridCorreosEmpresa.Columns[5].Width = 60;//tiempoespera
                //DatagridCorreosEmpresa.Columns[6].Width = 60;//eliminar

                DataGridCorreoCliente.Columns[0].DisplayIndex = 4;
                DataGridCorreoCliente.Columns[0].Width = 190;//RazonSocial
                DataGridCorreoCliente.Columns[1].Width = 140;//EmpresaNombre
                DataGridCorreoCliente.Columns[2].Width = 140;//Direcion
                DataGridCorreoCliente.Columns[3].Width = 120;//CorreoEletronico_cli
               // DataGridCorreoCliente.Columns[4].Width = 140;//eliminar
                //DatagridCorreosEmpresa.Columns[0].Width = 60;//Puerto
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

        }
        private bool EspacioDiscosCorreo_EMP(string nombreDisco, int Espacio)
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
        private void BtnGuardarCorreo_EMP_Click(object sender, EventArgs e)
        {
            if (EspacioDiscosCorreo_EMP(ClasDatos.RutaMulti2, 30))
            {
                try
                {

                    if (File.Exists(this.Rutacorreos))
                    {
                        this.DatagridCorreosEmpresa.EndEdit();
                        Validate();
                        //var dataSet = Comun.DataGrid_2.GetDataSet(this.DatagridCorreosEmpresa);
                       // ME.WriteXml(File.OpenWrite(this.Rutacorreos));
                        FormMenuPrincipal.menu2principal.DtCorreos.WriteXml(this.Rutacorreos);
                        MessageBox.Show("Se Actualizo Con Exito", "correos", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void DatagriCorreosEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string Correo = "";
                try
                {
                    if (e.ColumnIndex == 8)
                    {
                        if (e.RowIndex < this.DatagridCorreosEmpresa.RowCount - 1)
                        {
                            if (this.DatagridCorreosEmpresa.Rows[e.RowIndex].Cells[0].Value.ToString() != string.Empty)
                            {
                                Correo = this.DatagridCorreosEmpresa.Rows[e.RowIndex].Cells[0].Value.ToString();
                            }
                        }
                        if (MessageBox.Show("Desea Eliminar Este Correo ?? " + "\n" + "\n" + Correo, "ELIMINAR ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {

                            if (File.Exists(this.Rutacorreos))
                            {

                                // FormMenuPrincipal.menu2principal.CorreosBindisource.DataSource = FormMenuPrincipal.menu2principal.dsCorreos;
                                this.DatagridCorreosEmpresa.Rows.Remove(this.DatagridCorreosEmpresa.CurrentRow);
                                FormMenuPrincipal.menu2principal.dsCorreos.WriteXml(this.Rutacorreos);                  
                                this.DatagridCorreosEmpresa.Refresh();
                            }
                            MessageBox.Show(Correo + "\n" + "\n" + "Eliminado Con Exito ", "ELIMINAR ", MessageBoxButtons.OK);
                        }

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void DataGridCorreoCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    string Correo = "";
                        if (e.ColumnIndex == 4)
                        {
                        if (e.RowIndex < this.DatagridCorreosEmpresa.RowCount - 1)
                        {
                            if (this.DatagridCorreosEmpresa.Rows[e.RowIndex].Cells[1].Value.ToString() != string.Empty)
                            {
                                Correo = this.DatagridCorreosEmpresa.Rows[e.RowIndex].Cells[1].Value.ToString();
                            }
                        }
                            if (MessageBox.Show("Desea Eliminar Este Correo ?? " + "\n" + "\n" + Correo, "ELIMINAR ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                if (File.Exists(this.Rutacorreos))
                                {
                                this.DatagridCorreosEmpresa.Rows.Remove(this.DatagridCorreosEmpresa.CurrentRow);
                                FormMenuPrincipal.menu2principal.dsCorreos.WriteXml(this.Rutacorreos);                    
                                    this.DatagridCorreosEmpresa.Refresh();
                                }
                                MessageBox.Show(Correo + "\n" + "\n" + "Eliminado Con Exito ", "ELIMINAR ", MessageBoxButtons.OK);
                            }
                        }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnGuardarCorreoCli_Click(object sender, EventArgs e)
        {
            if (EspacioDiscosCorreo_EMP(ClasDatos.RutaMultidatos, 30))
            {
                if (File.Exists(ClasDatos.RutaMulti2))
                {
                    this.DataGridCorreoCliente.EndEdit();
                    Validate();
                    FormMenuPrincipal.menu2principal.dsCorreos.WriteXml(this.Rutacorreos);
                    MessageBox.Show("Se Actualizo Con Exito", "CORREO EMPRESA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No Se Guardo", "FALTAN ARCHIVOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}



