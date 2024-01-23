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
    public partial class FormFamiliaProductos : Form
    {
        public static FormFamiliaProductos MenuB;
        public FormFamiliaProductos()
        {
            InitializeComponent();
            FormFamiliaProductos.MenuB = this;
        }

        private void FormFamiliaProductos_Load(object sender, EventArgs e)
        {
            try
            {
 
                if (FormMenuPrincipal.menu2principal.dsMultidatos != null)
                {
                   // this.dtInicioMultiBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMultidatos;
                    this.dtFamiliaProductosBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2.DtFamiliaProductos;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
        private bool EspacioDiscosFami(string nombreDisco, int Espacio)
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
        public void AñadirIdFamilias()
        {
            int ii = 0;
            foreach (var fila in FormMenuPrincipal.menu2principal.dsMulti2.DtFamiliaProductos)
            {
                fila["IdFila"] = ii.ToString();
                ii++;
            }

        }
        private bool ValidarFami()
        {
            bool ok = true;

            if (this.FamiliaTex.Text.Length < 4)
            {
                ok = false;
                this.errorProvider1Confi.SetError(this.FamiliaTex, "_ingresar Nonbre Proveedor valido (( minimo 4 Caracteres))");
            }


            return ok;
        }
        private void BorrarErrorFami()
        {
            this.errorProvider1Confi.SetError(this.FamiliaTex, "");

        }
        private void ModificarOjetos_Fami()
        {
            this.FamiliaTex.ReadOnly = false;
            this.BtnGuardarFamillia.Enabled = true;
            this.BtnCancelarFamilia.Enabled = true;
            this.DataGridFamilia.Enabled = false;
        }
        private void RestaurarOjetos_Fami()
        {
            this.FamiliaTex.ReadOnly = true;
            this.BtnGuardarFamillia.Enabled = false;
            this.BtnCancelarFamilia.Enabled = false;
            this.DataGridFamilia.Enabled = true;
        }
        private void GuardarFamiliaDb()
        {
            string consulta = "";
            if (this.panelFamilia.Tag.ToString() == "Nuevo")
            {
                consulta = "  INSERT INTO [DtFamiliaProductos]  VALUES( @Id,@Familia)";

            }
            else
            {
                consulta = "UPDATE [DtFamiliaProductos] SET [Id] = @Id_almacenes,[Familia] = @Familia, " +
                " WHERE Id = @Id";
            }
            ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
            try
            {
                if (NuevaConexion.SiConexionDb)
                {
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", string.IsNullOrEmpty(this.Id_Familia.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Id_Familia.Text));
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Familia", string.IsNullOrEmpty(this.FamiliaTex.Text) ? (object)DBNull.Value : this.FamiliaTex.Text);
                    NuevaConexion.ComandoDb.ExecuteNonQuery();
                    NuevaConexion.ComandoDb.Parameters.Clear();
                    Validate();
                    this.dtFamiliaProductosBindingSource.EndEdit();
                    this.DataGridFamilia.EndEdit();
                    MessageBox.Show("Se Guardo Correctamente", "GUARDAR FAMILIA ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetos_Fami();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "FAMILIA PRODUCTOS");
            }
            finally
            {
                if (NuevaConexion.CerrarConexionDB)
                {

                }
            }
        }
        private void GuardarFamiliaSql()
        {
            string consulta = "";
            if (this.panelFamilia.Tag.ToString() == "Nuevo")
            {
                consulta = "  INSERT INTO [DtFamiliaProductos] VALUES( @Id,@Familia)";

            }
            else
            {
                consulta = "UPDATE [DtFamiliaProductos] SET [Id] = @Id_almacenes,[Familia] = @Familia, " +
                " WHERE Id = @Id";
            }
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                if (NuevaConexion.SiConexionSql)
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", string.IsNullOrEmpty(this.Id_Familia.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Id_Familia.Text));
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Familia", string.IsNullOrEmpty(this.FamiliaTex.Text) ? (object)DBNull.Value : this.FamiliaTex.Text);
                    NuevaConexion.ComandoSql.ExecuteNonQuery();
                    NuevaConexion.ComandoSql.Parameters.Clear();
                    Validate();
                    this.dtFamiliaProductosBindingSource.EndEdit();
                    this.DataGridFamilia.EndEdit();
                    MessageBox.Show("Se Guardo Correctamente", "GUARDAR FAMILIA ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetos_Fami();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "FAMILIA PRODUCTOS");
            }
            finally
            {
                if (NuevaConexion.CerrarConexionSql)
                {

                }
            }
        }
        private void EliminarFamiliaBb()
        {
            if (File.Exists(ClasDatos.RutaBaseDatosDb))
            {
                try
                {

                    string consulta = "Delete from  [DtFamiliaProductos]   WHERE Id= '@Id'";
                    //  ClsConexionDb.CadenaConexion = cadena;
                    ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
                    {
                        if (NuevaConexion.SiConexionDb)
                        {
                            NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", this.Id_Familia.Text);
                            NuevaConexion.ComandoDb.ExecuteNonQuery();
                            this.DataGridFamilia.Rows.RemoveAt(this.DataGridFamilia.CurrentCell.RowIndex);
                            this.dtFamiliaProductosBindingSource.EndEdit();
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
        private void EliminarFAmiliaSQL()
        {
            string consulta = "Delete from  [DtFamiliaProductos]   WHERE Id= '@Id'";
            //  ClsConexionDb.CadenaConexion = cadena;
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                {
                    if (NuevaConexion.SiConexionSql)
                    {
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", this.Id_Familia.Text);
                        NuevaConexion.ComandoSql.ExecuteNonQuery();
                        this.DataGridFamilia.Rows.RemoveAt(this.DataGridFamilia.CurrentCell.RowIndex);
                        this.dtFamiliaProductosBindingSource.EndEdit();
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
        private void BtnNuevoFamilia_Click(object sender, EventArgs e)
        {
            this.panelFamilia.Tag = "Nuevo";
            try
            {
                int numeroFILA = this.DataGridFamilia.Rows.Count;
                this.dtFamiliaProductosBindingSource.AddNew();
                if (this.DataGridFamilia.CurrentCell.RowIndex == 0)
                {
                    this.Id_Familia.Text = "1";
                    this.DataGridFamilia.Rows[0].Cells[0].Value = "1";
                }
                if (numeroFILA > 0)
                {
                    if (this.DataGridFamilia.Rows[numeroFILA - 1].Cells[0].Value.ToString() == string.Empty)
                    {
                        Random r = new Random();
                        int VALORid = r.Next(5000, 100000000);
                        this.DataGridFamilia.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.Id_Familia.Text = VALORid.ToString();
                    }
                    else
                    {
                        int VALORid = Convert.ToInt32(this.DataGridFamilia.Rows[numeroFILA - 1].Cells[0].Value) + 1;
                        this.DataGridFamilia.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.Id_Familia.Text = VALORid.ToString();
                    }

                }
                FamiliaTex.Text = "GENERAL";
                ModificarOjetos_Fami();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancelarFamilia_Click(object sender, EventArgs e)
        {
            BorrarErrorFami();
            if (this.DataGridFamilia.RowCount >= 0)
            {
                try
                {
                    if (this.panelFamilia.Tag.ToString() == "Nuevo")
                    {
                        if (this.DataGridFamilia.RowCount > 0)
                        {
                            this.DataGridFamilia.Rows.RemoveAt(this.DataGridFamilia.CurrentCell.RowIndex);
                        }
                    }
                }
                catch (Exception)
                {

                    //  throw;
                }

            }
            RestaurarOjetos_Fami();
        }

        private void BtnSalirFamilia_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" ¿Salir Familia Productos ? ", " SALIR ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void FormFamiliaProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.BtnGuardarFamillia.Enabled == true)
            {
                e.Cancel = true;
            }
        }

        private void BtnModificarFAmilia_Click(object sender, EventArgs e)
        {
            if (dtFamiliaProductosBindingSource.Count > 0)
            {
                this.panelFamilia.Tag = "Nuevo";
                ModificarOjetos_Fami();
            }
        }

        private void BtnGuardarFamillia_Click(object sender, EventArgs e)
        {
            if (Id_Familia .Text == string.Empty)
            {
                MessageBox.Show("Falta (( id ))) o  ((Datos))", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Random r = new Random();
                int I = r.Next(20, 2000);
                Id_Familia.Text = I.ToString();
                return;
            }
            if (EspacioDiscosFami(Directory.GetCurrentDirectory(), 25))
            {
                BorrarErrorFami();
                if (ValidarFami())
                {
                    {
                        try
                        {
                            foreach (DataGridViewRow fila in this.DataGridFamilia.Rows)
                            {
                                if (fila.Cells[1].ToString() == this.FamiliaTex.Text)
                                {
                                    if (this.DataGridFamilia.CurrentCell.RowIndex == fila.Index)
                                    {
                                        break;
                                    }
                                    MessageBox.Show(this.FamiliaTex.Text.ToString(), "YA EXISTE ESTA ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.FamiliaTex.Focus();
                                    this.FamiliaTex.SelectAll();
                                    return;
                                }

                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                        if (MessageBox.Show(" ¿Aceptar Guardar Familia ? ", " GUARDAR FAMILIAS ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            if (ClsConexionSql.SibaseDatosSql)
                            {
                                GuardarFamiliaSql();
                            }
                            else
                            {

                                if (File.Exists(ClasDatos.RutaBaseDatosDb))
                                {
                                    GuardarFamiliaDb();
                                }
                                else
                                {
                                    MessageBox.Show("Archivo No Se Encuentra", " FALLO AL GUARDAR ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    this.panelFamilia.Enabled = false;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void BtnEliminarFamilia_Click(object sender, EventArgs e)
        {
            if (this.dtFamiliaProductosBindingSource.Count > 0)
            {
                if (MessageBox.Show("Desea Eliminar Permanentemente ", "ELIMINAR ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (ClsConexionSql.SibaseDatosSql)
                    {
                        EliminarFAmiliaSQL();
                    }
                    else
                    {
                        if (File.Exists(ClasDatos.RutaBaseDatosDb))
                        {
                            EliminarFamiliaBb();

                        }
                        else
                        {
                            MessageBox.Show(" No Se Pudo Eliminar", "FALTA ARCHIVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void dtFamiliaProductosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void BtnBuscarFamilia_Click(object sender, EventArgs e)
        {
            if (dtFamiliaProductosBindingSource.Count > 0)
            {
                ClasDatos.OkFacturar = true;
                ClasDatos.QUEform = "Familia";
                AñadirIdFamilias();
                FormBuscar frm = new FormBuscar();
                frm.CargarDatos(1, " Familia", "Familia","fami",0);
                frm.BringToFront();
                frm.ShowDialog();

            }
        }
    }
}
