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
    public partial class FormAlmacenes : Form
    {
        public FormAlmacenes()
        {
            InitializeComponent();
        }
        private void FormAlmacenes_Load(object sender, EventArgs e)
        {

        }
        private void ModificarOjetos_Alm()
        {
            this.almacenesTextBox.ReadOnly = false;
            this.BtnGuardarAlmacen.Enabled = true;
            this.BtnCancelarAlmacen.Enabled = true;
            this.dataGridAlmacenes.Enabled = false;
        }
        private void RestaurarOjetos_Alm()
        {
            this.almacenesTextBox.ReadOnly = true;
            this.BtnGuardarAlmacen.Enabled = false;
            this.BtnCancelarAlmacen.Enabled = false;
            this.dataGridAlmacenes.Enabled = true;
        }
        private void EliminarAlmacenBb()
        {
            if (File.Exists(ClasDatos.RutaBaseDatosDb))
            {
                try
                {

                    string consulta = "Delete from  [DtAlmacenes]   WHERE Id_almacenes= '@Id_almacenes'";
                    //  ClsConexionDb.CadenaConexion = cadena;
                    ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
                    {
                        if (NuevaConexion.SiConexionDb)
                        {
                            NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id_almacenes", this.id_almacenes.Text);
                            NuevaConexion.ComandoDb.ExecuteNonQuery();
                            this.dataGridAlmacenes.Rows.RemoveAt(this.dataGridAlmacenes.CurrentCell.RowIndex);
                            this.dtAlmacenesBindingSource.EndEdit();
                            Validate();
                            MessageBox.Show("Se Elimino Correctamente", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
            else
            {
                MessageBox.Show("El Archivo No Se Encuentra", "ARCHIVO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
        }
        private void EliminarAlmacenSQL()
        {
            string consulta = "Delete from  [DtAlmacenes]   WHERE Id_almacenes= '@Id_almacenes'";
            //  ClsConexionDb.CadenaConexion = cadena;
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                {
                    if (NuevaConexion.SiConexionSql)
                    {
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id_almacenes", this.id_almacenes.Text);
                        NuevaConexion.ComandoSql.ExecuteNonQuery();
                        this.dataGridAlmacenes.Rows.RemoveAt(this.dataGridAlmacenes.CurrentCell.RowIndex);
                        this.dtAlmacenesBindingSource.EndEdit();
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
        private void BtnNuevoAlmacen_Click(object sender, EventArgs e)
        {
            this.BtnNuevoAlmacen.Tag = "Nuevo";
            try
            {
                int numeroFILA = this.dataGridAlmacenes.Rows.Count;
                this.dtAlmacenesBindingSource.AddNew();
                if (this.dataGridAlmacenes.CurrentCell.RowIndex == 0)
                {
                    this.id_almacenes.Text = "1";
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
                  
                }

                ModificarOjetos_Alm();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEliminarAlmacen_Click(object sender, EventArgs e)
        {
            if (this.dataGridAlmacenes.RowCount >= 0)
            {
                if (MessageBox.Show("Desea Eliminar Permanentemente ", "ELIMINAR ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (ClsConexionSql.SibaseDatosSql)
                    {
                        EliminarAlmacenSQL();
                    }
                    else
                    {
                        if (File.Exists(ClasDatos.RutaBaseDatosDb))
                        {
                            EliminarAlmacenBb();

                        }
                        else
                        {
                            MessageBox.Show(" No Se Pudo Eliminar", "FALTA ARCHIVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void BtnGuardarAlmacen_Click(object sender, EventArgs e)
        {

        }
    }
}
