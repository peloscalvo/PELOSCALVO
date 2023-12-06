using Conexiones;
using System;
using System.IO;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormCrearCorreos : Form
    {
        //BindingSource CorreoBindinSource = new BindingSource();
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
                DatagridCorreosEmpresa.Columns[1].Width = 190;//NombreEmpresa
                DatagridCorreosEmpresa.Columns[2].Width = 140;//CorreoEletronico
                DatagridCorreosEmpresa.Columns[3].Width = 120;//Usuario
                DatagridCorreosEmpresa.Columns[4].Width = 120;//Contraseña
                DatagridCorreosEmpresa.Columns[5].Width = 60;//smtp
                DatagridCorreosEmpresa.Columns[6].Width = 60;//tiempoespera
                //DatagridCorreosEmpresa.Columns[6].Width = 60;//eliminar

                DataGridCorreoCliente.Columns[1].Width = 190;//RazonSocial
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
        private void ModificarOjetosCorreo_E()
        {
            this.NombreEmpresa.ReadOnly = false;
            this.PanelBotones_CorreoEmp.Enabled = false;
            this.BtnCancelarCorreo_E.Enabled = true;
            this.BtnGuardarCorreo_E.Enabled = true;
            this.DataGridCorreoCliente.Enabled = false;
        }
        private void RestaurarOjetosCorreo_E()
        {
            this.NombreEmpresa.ReadOnly = true;
            this.PanelBotones_CorreoEmp.Enabled = true;
            this.BtnCancelarCorreo_E.Enabled = false;
            this.BtnGuardarCorreo_E.Enabled = false;
            this.DataGridCorreoCliente.Enabled = true;
        }
 
        private bool ValidarCorreoEmpresa()
        {
            bool ok = true;

            if (this.NombreEmpresa.Text.Length < 4)
            {
                ok = false;
                this.ErrorCorreosCrear.SetError(this.NombreEmpresa, "_ingresar Nonbre Nombre Empreasa valido (( minimo 4 Caracteres))");
            }


            return ok;
        }
        private void BorrarErrorCorreoEmpresa()
        {
            this.ErrorCorreosCrear.SetError(this.NombreEmpresa, "");

        }
        private void LlenarDatagrid()
        {
            DatagridCorreosEmpresa.Rows.Add(Id_Correo_E.Text, NombreEmpresa.Text, CorreoEletronico.Text, Usuario.Text,
                Contraseña.Text,smtp.Text,Puerto.Text,Timeof.Text);
        }
        private void GuardarCorreo_EmpresaDb()
        {
            string consulta = "";
            if (this.PanelBotones_CorreoEmp.Tag.ToString() == "Nuevo")
            {
                consulta = "  INSERT INTO [DtCorreos] VALUES([@Id],[@NombreEmpresa],[@CorreoEletronico],[@Usuario],[@Contraseña],[@smtp],[@Puerto],[@Timeof])";

            }
            else
            {
                consulta = "UPDATE [DtCorreos] SET [Id] = @Id,[NombreEmpresa] = @NombreEmpresa,[CorreoEletronico] = @CorreoEletronico ," +
                    "[Usuario] = @Usuario,[Contraseña] = @Contraseña,[smtp] = @smtp,[Puerto] = @Puerto,[Timeof] = @Timeof  WHERE Id = @Id";
            }
            ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
            try
            {
                if (NuevaConexion.SiConexionDb)
                {
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", string.IsNullOrEmpty(this.Id_Correo_E.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Id_Correo_E.Text));
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@NombreEmpresa", string.IsNullOrEmpty(this.NombreEmpresa.Text) ? (object)DBNull.Value : this.NombreEmpresa.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@CorreoEletronico", string.IsNullOrEmpty(this.CorreoEletronico.Text) ? (object)DBNull.Value : this.CorreoEletronico.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Usuario", string.IsNullOrEmpty(this.Usuario.Text) ? (object)DBNull.Value : this.Usuario.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Contraseña", string.IsNullOrEmpty(this.Contraseña.Text) ? (object)DBNull.Value : this.Contraseña.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@smtp", string.IsNullOrEmpty(this.smtp.Text) ? (object)DBNull.Value : this.smtp.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Puerto", string.IsNullOrEmpty(this.Puerto.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Puerto.Text));
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Timeof", string.IsNullOrEmpty(this.Timeof.Text) ? (object)DBNull.Value : this.Timeof.Text);
                    NuevaConexion.ComandoDb.ExecuteNonQuery();
                    NuevaConexion.ComandoDb.Parameters.Clear();             
                    LlenarDatagrid();
                    this.DataGridCorreoCliente.EndEdit();
                    Validate();
                    MessageBox.Show("Se Guardo Correctamente", "GUARDAR CORREO ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetosCorreo_E();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "CORREOS");
            }
            finally
            {
                if (NuevaConexion.CerrarConexionDB)
                {

                }
            }
        }
        private void GuardarCorreo_EmpSql()
        {
            string consulta = "";
            if (this.PanelBotones_CorreoEmp.Tag.ToString() == "Nuevo")
            {
                consulta = "  INSERT INTO [DtCorreos] VALUES([@Id],[@NombreEmpresa],[@CorreoEletronico],[@Usuario],[@Contraseña],[@smtp],[@Puerto],[@Timeof])";

            }
            else
            {
                consulta = "UPDATE [DtCorreos] SET [Id] = @Id,[NombreEmpresa] = @NombreEmpresa,[CorreoEletronico] = @CorreoEletronico ," +
                    "[Usuario] = @Usuario,[Contraseña] = @Contraseña,[smtp] = @smtp,[Puerto] = @Puerto,[Timeof] = @Timeof  WHERE Id = @Id";
            }
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                if (NuevaConexion.SiConexionSql)
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", string.IsNullOrEmpty(this.Id_Correo_E.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Id_Correo_E.Text));
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@NombreEmpresa", string.IsNullOrEmpty(this.NombreEmpresa.Text) ? (object)DBNull.Value : this.NombreEmpresa.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@CorreoEletronico", string.IsNullOrEmpty(this.CorreoEletronico.Text) ? (object)DBNull.Value : this.CorreoEletronico.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Usuario", string.IsNullOrEmpty(this.Usuario.Text) ? (object)DBNull.Value : this.Usuario.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Contraseña", string.IsNullOrEmpty(this.Contraseña.Text) ? (object)DBNull.Value : this.Contraseña.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@smtp", string.IsNullOrEmpty(this.smtp.Text) ? (object)DBNull.Value : this.smtp.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Timeof", string.IsNullOrEmpty(this.Timeof.Text) ? (object)DBNull.Value : this.Timeof.Text);
                    NuevaConexion.ComandoSql.ExecuteNonQuery();
                    NuevaConexion.ComandoSql.Parameters.Clear();
                    LlenarDatagrid();
                    this.DataGridCorreoCliente.EndEdit();
                    Validate();
                    MessageBox.Show("Se Guardo Correctamente", "GUARDAR CORREO ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestaurarOjetosCorreo_E();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "CORREOS");
            }
            finally
            {
                if (NuevaConexion.CerrarConexionSql)
                {

                }
            }
        }
        private void EliminarCorreo_CliBb()
        {
            if (File.Exists(ClasDatos.RutaBaseDatosDb))
            {
                string consulta = "Delete from  [DtCorreos]   WHERE Id= '@Id'";
                ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
                try
                {
                    {
                        if (NuevaConexion.SiConexionDb)
                        {
                            NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", Convert.ToInt32(this.Id_Correo_E.Text));
                            NuevaConexion.ComandoDb.ExecuteNonQuery();
                            this.DataGridCorreoCliente.Rows.RemoveAt(this.DataGridCorreoCliente.CurrentCell.RowIndex);
                            this.DataGridCorreoCliente.EndEdit();
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
        private void EliminarCorreo_CliSql()
        {

            string consulta = "Delete from  [DtProvincias]   WHERE Id= @Id";
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                {
                    if (NuevaConexion.SiConexionSql)
                    {
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", Convert.ToInt32(this.Id_Correo_E.Text));
                        NuevaConexion.ComandoSql.ExecuteNonQuery();
                        this.DatagridCorreosEmpresa.Rows.RemoveAt(this.DatagridCorreosEmpresa.CurrentCell.RowIndex);
                        this.DatagridCorreosEmpresa.EndEdit();
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
          
        }

        private void DataGridCorreoCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    string Correo = "";
                        if (e.ColumnIndex == 0)
                        {
                        if (e.RowIndex < this.DataGridCorreoCliente.RowCount - 1)
                        {
                            if (this.DataGridCorreoCliente.Rows[e.RowIndex].Cells[1].Value.ToString() != string.Empty)
                            {
                                Correo = this.DataGridCorreoCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
                            }
                        }
                            if (MessageBox.Show("Desea Eliminar Este Correo ?? " + "\n" + "\n" + Correo, "ELIMINAR ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                if (File.Exists(this.Rutacorreos))
                                {
                                this.DataGridCorreoCliente.Rows.Remove(this.DataGridCorreoCliente.CurrentRow);
                                FormMenuPrincipal.menu2principal.dsCorreos.WriteXml(this.Rutacorreos);                    
                                    this.DataGridCorreoCliente.Refresh();
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

        private void BtnEliminarCorreoEmpresa_Click(object sender, EventArgs e)
        {
            if (this.DatagridCorreosEmpresa.RowCount >= 0)
            {
                if (MessageBox.Show("Desea Eliminar Permanentemente ", "ELIMINAR ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    if (ClsConexionSql.SibaseDatosSql)
                    {
                        EliminarCorreo_CliSql();
                    }
                    else
                    {
                        if (File.Exists(ClasDatos.RutaBaseDatosDb))
                        {
                            EliminarCorreo_CliBb();

                        }
                        else
                        {
                            MessageBox.Show(" No Se Pudo Eliminar", "FALTA ARCHIVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void BtnNuevoCorreoEmpr_Click(object sender, EventArgs e)
        {
            this.PanelBotones_CorreoEmp.Tag = "Nuevo";
            try
            {
                int numeroFILA = this.DatagridCorreosEmpresa.Rows.Count;
                // this.DtProvinciasBindinsource.AddNew();

               // CorreoBindinSource.DataSource = FormMenuPrincipal.menu2principal.DtCorreos;
               // CorreoBindinSource.AddNew();
                if (this.DatagridCorreosEmpresa.Rows.Count == 0)
                {
                    this.Id_Correo_E.Text = "1";
                  //  this.DataGridCorreoCliente.Rows[0].Cells[0].Value = "1";
                }
                if (numeroFILA > 0)
                {
                    if (this.DatagridCorreosEmpresa.Rows[numeroFILA].Cells[0].Value.ToString() == string.Empty)
                    {
                        Random r = new Random();
                        int VALORid = r.Next(5000, 100000000);
                       // this.DataGridCorreoCliente.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.Id_Correo_E.Text = VALORid.ToString();
                    }
                    else
                    {
                        int VALORid = Convert.ToInt32(this.DatagridCorreosEmpresa.Rows[numeroFILA].Cells[0].Value) + 1;
                       // this.DataGridCorreoCliente.Rows[numeroFILA].Cells[0].Value = (VALORid);
                        this.Id_Correo_E.Text = VALORid.ToString();
                    }

                }
                CorreoEletronico.Text = "Peloscalvo@Gmail.com";
                CorreoEletronico.Focus();
                CorreoEletronico.SelectAll();
                ModificarOjetosCorreo_E();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnModificarCorreoEmpr_Click(object sender, EventArgs e)
        {
            if (DatagridCorreosEmpresa.RowCount > 0)
            {
                this.PanelBotones_CorreoEmp.Tag = "Modificar";
                ModificarOjetosCorreo_E();
            }
        }

        private void BtnGuardarCorreo_E_Click(object sender, EventArgs e)
        {
            if (this.DataGridCorreoCliente.RowCount < 0)
            {
                MessageBox.Show("No Tiene Nada Que Guardar", "GUARDAR");
                return;
            }
            if (Id_Correo_E.Text == string.Empty)
            {
                MessageBox.Show("Falta (( id ))) o  ((Datos))", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (EspacioDiscosCorreo_EMP(ClasDatos.RutaMultidatos, 25))

                BorrarErrorCorreoEmpresa();
            if (ValidarCorreoEmpresa())
            {
                {
                    try
                    {
                        foreach (DataGridViewRow fila in this.DataGridCorreoCliente.Rows)
                        {
                            if (fila.Cells[1].ToString() == this.CorreoEletronico.Text)
                            {
                                if (this.DataGridCorreoCliente.CurrentCell.RowIndex == fila.Index)
                                {
                                    break;
                                }
                                MessageBox.Show(this.CorreoEletronico.Text.ToString(), "YA EXISTE ESTA CORREO ELETRONICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               // this.CorreoEletronico.Focus();
      
                            }

                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    if (MessageBox.Show(" ¿Aceptar Guardar Correo ? ", " GUARDAR CORREO ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (ClsConexionSql.SibaseDatosSql)
                        {
                            GuardarCorreo_EmpSql();
                        }
                        else
                        {

                            if (File.Exists(ClasDatos.RutaBaseDatosDb))
                            {
                                GuardarCorreo_EmpresaDb();
                            }
                            else
                            {
                                MessageBox.Show("Archivo No Se Encuentra", " FALLO AL GUARDAR ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                this.PanelBotones_CorreoEmp.Enabled = false;
                            }
                        }
                    }
                }
            }
        }

        private void BtnCancelarCorreo_E_Click(object sender, EventArgs e)
        {
            BorrarErrorCorreoEmpresa();
            if (this.DatagridCorreosEmpresa.RowCount > 0)
            {
                try
                {
                    if (this.PanelBotones_CorreoEmp.Tag.ToString() == "Nuevo")
                    {
                    
                            this.DatagridCorreosEmpresa.Rows.RemoveAt(this.DatagridCorreosEmpresa.CurrentCell.RowIndex);
             
                    }
                }
                catch (Exception)
                {

                    //  throw;
                }

            }
            RestaurarOjetosCorreo_E();
        }

        private void FormCrearCorreos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.BtnGuardarCorreo_E.Enabled == true)
            {
                e.Cancel = true;
            }
        }

        private void BtnSalirCorreoEmpresa_Click(object sender, EventArgs e)
        {
            if (this.BtnGuardarCorreo_E.Enabled == false)
            {
                if (MessageBox.Show(" Salir Correos  ", " SALIR ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Close();
                }
            }
        }
    }
}



