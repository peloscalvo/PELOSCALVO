using Comun;
using Conexiones;
using System;
using System.IO;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormCrearCorreos : Form
    {
        BindingSource CorreosbindingSource = new BindingSource();
        BindingSource CorreosClientebindingSource = new BindingSource();
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
                    this.CorreosbindingSource.DataSource = FormMenuPrincipal.menu2principal.DtCorreos;
                    this.DatagridCorreosEmpresa.DataSource = this.CorreosbindingSource.DataSource;
                    //this.DatagridCorreosEmpresa.DataSource = FormMenuPrincipal.menu2principal.DtCorreos;
                    this.CorreosClientebindingSource.DataSource = FormMenuPrincipal.menu2principal.DtCorreosCliente;
                    this.DataGridCorreoCliente.DataSource = this.CorreosClientebindingSource.DataSource;
                    //MessageBox.Show(FormMenuPrincipal.menu2principal.DtCorreos.Rows.Count.ToString());
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
                //this.DatagridCorreosEmpresa.Columns[1].Width = 190;//NombreEmpresa
                //  this.DatagridCorreosEmpresa.Columns[2].Width = 140;//CorreoEletronico
                // this.DatagridCorreosEmpresa.Columns[3].Width = 120;//Usuario
                // this.DatagridCorreosEmpresa.Columns[4].Width = 120;//Contraseña
                // this.DatagridCorreosEmpresa.Columns[5].Width = 60;//smtp
                // this.DatagridCorreosEmpresa.Columns[6].Width = 60;//tiempoespera
                //DatagridCorreosEmpresa.Columns[6].Width = 60;//eliminar

                // this.DataGridCorreoCliente.Columns[1].Width = 190;//RazonSocial
                //  this.DataGridCorreoCliente.Columns[1].Width = 140;//EmpresaNombre
                //  this.DataGridCorreoCliente.Columns[2].Width = 140;//Direcion
                // this.DataGridCorreoCliente.Columns[3].Width = 120;//CorreoEletronico_cli
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
        private void LimpiarCorreo_Empresa()
        {
            this.NombreEmpresa.Text = string.Empty;
            this.CorreoEletronico.Text = string.Empty;
            this.Usuario.Text = string.Empty;
            this.Contraseña.Text = string.Empty;
            this.smtp.Text = string.Empty;
            this.Puerto.Text = string.Empty;
            this.Timeof.Text = string.Empty;

        }
        private void limpiarCorreo_Cli()
        {
            Id_CorreoCli.Text =string.Empty;
            this.EmpresaCli.Text = string.Empty;   
            this.RazonSocial.Text = string.Empty;
            this.Direcion.Text = string.Empty;
            CorreoEletronicoCli.Text = string.Empty;

        }
        private void ModificarOjetosCorreo_Cli()
        {
            this.EmpresaCli.ReadOnly = false;
            this.CorreoEletronicoCli.ReadOnly = false;
            this.RazonSocial.ReadOnly = false;
            this.Direcion.ReadOnly = false;
            this.PanelBotonesCorreoCli.Enabled = false;
            this.DataGridCorreoCliente.Enabled = false;
            this.BtnCancelarCli.Enabled = true;
            this.BtnGuardarCorreoCli.Enabled = true;
            this.PanelBotones_CorreoEmp.Enabled = false;//Para no Editar Otro 
            this.DatagridCorreosEmpresa.Enabled = false;///tambien
        }
        private void RestaurarOjetosCorreo_Cli()
        {
            this.EmpresaCli.ReadOnly = true;
            this.CorreoEletronicoCli.ReadOnly = true;
            this.RazonSocial.ReadOnly = true;
            this.Direcion.ReadOnly = true;
            this.PanelBotonesCorreoCli.Enabled = true;
            this.DataGridCorreoCliente.Enabled = true;
            this.BtnCancelarCli.Enabled = false;
            this.BtnGuardarCorreoCli.Enabled = false;
            this.PanelBotones_CorreoEmp.Enabled = true;//Para no Editar Otro 
            this.DatagridCorreosEmpresa.Enabled = true;///tambien
        }
        private void ModificarOjetosCorreo_E()
        {
            this.NombreEmpresa.ReadOnly = false;
            this.CorreoEletronico.ReadOnly = false;
            this.Usuario.ReadOnly = false;
            this.Contraseña.ReadOnly = false;
            this.smtp.ReadOnly = false;
            this.Puerto.ReadOnly = false;
            this.Timeof.ReadOnly = false;
            this.PanelBotones_CorreoEmp.Enabled = false;
            this.BtnCancelarCorreo_E.Enabled = true;
            this.BtnGuardarCorreo_E.Enabled = true;
            this.DatagridCorreosEmpresa.Enabled = false;
            this.PanelBotonesCorreoCli.Enabled = false;//Para no Editar Otro 
            this.DataGridCorreoCliente.Enabled = false;///tambien
        }
        private void RestaurarOjetosCorreo_E()
        {
            this.NombreEmpresa.ReadOnly = true;
            this.CorreoEletronico.ReadOnly = true;
            this.Usuario.ReadOnly = true;
            this.Contraseña.ReadOnly = true;
            this.smtp.ReadOnly = true;
            this.Puerto.ReadOnly = true;
            this.Timeof.ReadOnly = true;
            this.PanelBotones_CorreoEmp.Enabled = true;
            this.BtnCancelarCorreo_E.Enabled = false;
            this.BtnGuardarCorreo_E.Enabled = false;
            this.DatagridCorreosEmpresa.Enabled = true;
            this.PanelBotonesCorreoCli.Enabled = true;//Para no Editar Otro 
            this.DataGridCorreoCliente.Enabled = true;///tambien
        }

        private bool ValidarCorreoCli()
        {
            bool ok = true;

            if (this.EmpresaCli.Text.Length < 4)
            {
                ok = false;
                this.ErrorCorreosCrear.SetError(this.EmpresaCli, "_ingresar Nonbre Nombre Empreasa valido (( minimo 4 Caracteres))");
            }
            if (this.CorreoEletronicoCli.Text.Length < 4)
            {
                ok = false;
                this.ErrorCorreosCrear.SetError(this.CorreoEletronicoCli, "_ingresar Nonbre Nombre Correeo Eletronico valido (( minimo 4 Caracteres))");
            }
            if (this.RazonSocial.Text.Length < 4)
            {
                ok = false;
                this.ErrorCorreosCrear.SetError(this.RazonSocial, "_ingresar Nonbre Nombre Razon Social valido (( minimo 4 Caracteres))");
            }
            if (this.Direcion.Text.Length < 4)
            {
                ok = false;
                this.ErrorCorreosCrear.SetError(this.Direcion, "_ingresar Nonbre Nombre Direccion valido (( minimo 4 Caracteres))");
            }
            return ok;
        }
        private void BorrarErrorCorreoCli()
        {
            this.ErrorCorreosCrear.SetError(this.EmpresaCli, "");
            this.ErrorCorreosCrear.SetError(this.CorreoEletronicoCli, "");
            this.ErrorCorreosCrear.SetError(this.RazonSocial, "");
            this.ErrorCorreosCrear.SetError(this.Contraseña, "");
            this.ErrorCorreosCrear.SetError(this.Direcion, "");
        }
        private bool ValidarCorreoEmpresa()
        {
            bool ok = true;

            if (this.NombreEmpresa.Text.Length < 4)
            {
                ok = false;
                this.ErrorCorreosCrear.SetError(this.NombreEmpresa, "_ingresar Nonbre Nombre Empreasa valido (( minimo 4 Caracteres))");
            }
            if (this.CorreoEletronico.Text.Length < 4)
            {
                ok = false;
                this.ErrorCorreosCrear.SetError(this.CorreoEletronico, "_ingresar Nonbre Nombre Correeo Eletronico valido (( minimo 4 Caracteres))");
            }
            if (this.Usuario.Text.Length < 4)
            {
                ok = false;
                this.ErrorCorreosCrear.SetError(this.Usuario, "_ingresar Nonbre Nombre USUARIO valido (( minimo 4 Caracteres))");
            }

            if (this.Contraseña.Text == string.Empty)
            {
                ok = false;
                this.ErrorCorreosCrear.SetError(this.Contraseña, "_ingresar Nonbre Nombre CONTRASEÑA valido (( minimo 1 Caracteres))");
            }
            if (this.smtp.Text == String.Empty)
            {
                ok = false;
                this.ErrorCorreosCrear.SetError(this.smtp, "_ingresar Nonbre Nombre SMTP valido (( minimo 1 Caracteres))");
            }
            if (this.Puerto.Text == String.Empty)
            {
                ok = false;
                this.ErrorCorreosCrear.SetError(this.Puerto, "_ingresar Puerto valido (( minimo 1 Caracteres))");
            }
            if (this.Timeof.Text == String.Empty)
            {
                ok = false;
                this.ErrorCorreosCrear.SetError(this.Timeof, "_ingresar TimeOf valido (( minimo 1 Caracteres))");
            }
            return ok;
        }
        private void BorrarErrorCorreoEmpresa()
        {
            this.ErrorCorreosCrear.SetError(this.NombreEmpresa, "");
            this.ErrorCorreosCrear.SetError(this.CorreoEletronico, "");
            this.ErrorCorreosCrear.SetError(this.Usuario, "");
            this.ErrorCorreosCrear.SetError(this.Contraseña, "");
            this.ErrorCorreosCrear.SetError(this.smtp, "");
            this.ErrorCorreosCrear.SetError(this.Puerto, "");
            this.ErrorCorreosCrear.SetError(this.Timeof, "");
        }
        private void ExtraerDatagrid()
        {
            int II = this.DatagridCorreosEmpresa.CurrentCell.RowIndex;
            this.Id_Correo_E.Text = this.DatagridCorreosEmpresa.Rows[II].Cells[0].FormattedValue.ToString();
            this.NombreEmpresa.Text = this.DatagridCorreosEmpresa.Rows[II].Cells[1].FormattedValue.ToString();
            this.CorreoEletronico.Text = this.DatagridCorreosEmpresa.Rows[II].Cells[2].FormattedValue.ToString();
            this.Usuario.Text = this.DatagridCorreosEmpresa.Rows[II].Cells[3].FormattedValue.ToString();
            if (!string.IsNullOrEmpty(this.DatagridCorreosEmpresa.Rows[II].Cells[4].FormattedValue.ToString()))
            {
                ClasCodificarPass Decodificar = new ClasCodificarPass();
                string Pass = Decodificar.Dedificar(this.DatagridCorreosEmpresa.Rows[II].Cells[4].FormattedValue.ToString());
                this.Contraseña.Text = Pass;
            }      
            this.smtp.Text = this.DatagridCorreosEmpresa.Rows[II].Cells[5].FormattedValue.ToString();
            this.Puerto.Text = this.DatagridCorreosEmpresa.Rows[II].Cells[6].FormattedValue.ToString();
            this.Timeof.Text = this.DatagridCorreosEmpresa.Rows[II].Cells[7].FormattedValue.ToString();
        }
        private void ExtraerDatagridCliente()
        {
            int II = this.DataGridCorreoCliente.CurrentCell.RowIndex;
            this.Id_CorreoCli.Text = this.DataGridCorreoCliente.Rows[II].Cells[0].FormattedValue.ToString();
            this.RazonSocial.Text = this.DataGridCorreoCliente.Rows[II].Cells[1].FormattedValue.ToString();
            this.EmpresaCli.Text = this.DataGridCorreoCliente.Rows[II].Cells[2].FormattedValue.ToString();
            this.Direcion.Text = this.DataGridCorreoCliente.Rows[II].Cells[3].FormattedValue.ToString();
            this.CorreoEletronicoCli.Text = this.DataGridCorreoCliente.Rows[II].Cells[4].FormattedValue.ToString();
        }
        private void LlenarDatagridCliente()
        {
            try
            {
                this.CorreosClientebindingSource.AddNew();
                FormMenuPrincipal.menu2principal.DtCorreosCliente.Rows.Add(this.Id_CorreoCli.Text, this.RazonSocial.Text, this.EmpresaCli.Text, this.Direcion.Text,
               this.CorreoEletronicoCli.Text);
 
                if (this.DataGridCorreoCliente.RowCount >= 0)
                {
                    int II = this.DataGridCorreoCliente.CurrentCell.RowIndex;
                    if (!string.IsNullOrEmpty(this.Id_CorreoCli.Text))
                    {
                        this.DataGridCorreoCliente.Rows[II].Cells[0].Value = this.Id_CorreoCli.Text;
                    }
                    if (!string.IsNullOrEmpty(this.RazonSocial.Text))
                    {
                        this.DataGridCorreoCliente.Rows[II].Cells[1].Value = this.RazonSocial.Text;
                    }
                    if (!string.IsNullOrEmpty(this.EmpresaCli.Text))
                    {
                        this.DataGridCorreoCliente.Rows[II].Cells[2].Value = this.EmpresaCli.Text;
                    }
                    if (!string.IsNullOrEmpty(this.Direcion.Text))
                    {
                        this.DataGridCorreoCliente.Rows[II].Cells[3].Value = this.Direcion.Text;
                    }
                    if (!string.IsNullOrEmpty(this.CorreoEletronicoCli.Text))
                    {
                        this.DataGridCorreoCliente.Rows[II].Cells[4].Value = this.CorreoEletronicoCli.Text.ToString();
                    }

                    // FormMenuPrincipal.menu2principal.DtCorreosCliente.Rows.Add(Id_CorreoCli.Text, RazonSocial.Text, EmpresaCli.Text, Direcion.Text,
                    // CorreoEletronicoCli.Text);
                }



                // DatagridCorreosEmpresa.Rows.Add(Id_Correo_E.Text, NombreEmpresa.Text, CorreoEletronico.Text, Usuario.Text,
                //  Contraseña.Text,smtp.Text,Puerto.Text,Timeof.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void LlenarDatagrid()
        {
            try
            {
                this.CorreosbindingSource.AddNew();
                int II = this.DatagridCorreosEmpresa.CurrentCell.RowIndex;
                if (!string.IsNullOrEmpty(this.Id_Correo_E.Text))
                {
                    this.DatagridCorreosEmpresa.Rows[II].Cells[0].Value = this.Id_Correo_E.Text;
                }
                if (!string.IsNullOrEmpty(this.NombreEmpresa.Text))
                {
                    this.DatagridCorreosEmpresa.Rows[II].Cells[1].Value = this.NombreEmpresa.Text;
                }
                if (!string.IsNullOrEmpty(this.CorreoEletronico.Text))
                {
                    this.DatagridCorreosEmpresa.Rows[II].Cells[2].Value = this.CorreoEletronico.Text;
                }
                if (!string.IsNullOrEmpty(this.Usuario.Text))
                {
                    this.DatagridCorreosEmpresa.Rows[II].Cells[3].Value = this.Usuario.Text;
                }
                if (!string.IsNullOrEmpty(this.Contraseña.Text))
                {
                    this.DatagridCorreosEmpresa.Rows[II].Cells[4].Value = this.Contraseña.Text.ToString();
                }
                if (!string.IsNullOrEmpty(this.smtp.Text))
                {
                    this.DatagridCorreosEmpresa.Rows[II].Cells[5].Value = this.smtp.Text;
                }
                if (!string.IsNullOrEmpty(this.Puerto.Text))
                {
                    this.DatagridCorreosEmpresa.Rows[II].Cells[6].Value = this.Puerto.Text;
                }
                if (!string.IsNullOrEmpty(this.Timeof.Text))
                {
                    this.DatagridCorreosEmpresa.Rows[II].Cells[7].Value = this.Timeof.Text;
                }

                FormMenuPrincipal.menu2principal.DtCorreos.Rows.Add(this.Id_Correo_E.Text, this.NombreEmpresa.Text, this.CorreoEletronico.Text, this.Usuario.Text,
                 this.Contraseña.Text, this.smtp.Text, this.Puerto.Text, this.Timeof.Text);
                // DatagridCorreosEmpresa.Rows.Add(Id_Correo_E.Text, NombreEmpresa.Text, CorreoEletronico.Text, Usuario.Text,
                //  Contraseña.Text,smtp.Text,Puerto.Text,Timeof.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
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
                ClasCodificarPass Codificar = new ClasCodificarPass();
                string Pass = Codificar.Codificar(this.Contraseña.Text);
                if (NuevaConexion.SiConexionDb)
                {
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", string.IsNullOrEmpty(this.Id_Correo_E.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Id_Correo_E.Text));
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@NombreEmpresa", string.IsNullOrEmpty(this.NombreEmpresa.Text) ? (object)DBNull.Value : this.NombreEmpresa.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@CorreoEletronico", string.IsNullOrEmpty(this.CorreoEletronico.Text) ? (object)DBNull.Value : this.CorreoEletronico.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Usuario", string.IsNullOrEmpty(this.Usuario.Text) ? (object)DBNull.Value : this.Usuario.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Contraseña", string.IsNullOrEmpty(Pass) ? (object)DBNull.Value : Pass);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@smtp", string.IsNullOrEmpty(this.smtp.Text) ? (object)DBNull.Value : this.smtp.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Puerto", string.IsNullOrEmpty(this.Puerto.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Puerto.Text));
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Timeof", string.IsNullOrEmpty(this.Timeof.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Timeof.Text));
                    NuevaConexion.ComandoDb.ExecuteNonQuery();
                    NuevaConexion.ComandoDb.Parameters.Clear();
                    FormMenuPrincipal.menu2principal.DtCorreos.Rows.Add(this.Id_Correo_E.Text, this.NombreEmpresa.Text, this.CorreoEletronico.Text, this.Usuario.Text,
                               this.Contraseña.Text, this.smtp.Text, this.Puerto.Text, this.Timeof.Text);
                   // LlenarDatagrid();
                    this.DataGridCorreoCliente.EndEdit();
                    this.CorreosClientebindingSource.EndEdit();
                    Validate();
                    LimpiarCorreo_Empresa();
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
        private void GuardarCorreo_ClienteSql()
        {
            string consulta = "";
            if (this.PanelBotonesCorreoCli.Tag.ToString() == "Nuevo")
            {
                consulta = "  INSERT INTO [DtCorreosCliente] VALUES([@Id],[@RazonSocial],[@EmpresaNombre],[@Direcion],[@CorreoEletronico_cli])";

            }
            else
            {
                consulta = "UPDATE [DtCorreosCliente] SET [Id] = @Id,[RazonSocial] = @RazonSocial,[EmpresaNombre] = @EmpresaNombre ," +
                    "[Direcion] = @Direcion,[CorreoEletronico_cli] = @CorreoEletronico_cli  WHERE Id = @Id";
            }
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                if (NuevaConexion.SiConexionSql)
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", string.IsNullOrEmpty(this.Id_CorreoCli.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Id_CorreoCli.Text));
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@RazonSocial", string.IsNullOrEmpty(this.RazonSocial.Text) ? (object)DBNull.Value : this.RazonSocial.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@EmpresaNombre", string.IsNullOrEmpty(this.EmpresaCli.Text) ? (object)DBNull.Value : this.EmpresaCli.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Direcion", string.IsNullOrEmpty(this.Direcion.Text) ? (object)DBNull.Value : this.Direcion.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@CorreoEletronico_cli", string.IsNullOrEmpty(this.CorreoEletronicoCli.Text) ? (object)DBNull.Value : this.CorreoEletronicoCli.Text);
                    NuevaConexion.ComandoSql.ExecuteNonQuery();
                    NuevaConexion.ComandoSql.Parameters.Clear();
                    FormMenuPrincipal.menu2principal.DtCorreosCliente.Rows.Add(this.Id_CorreoCli.Text, this.RazonSocial.Text, this.EmpresaCli.Text, this.Direcion.Text,
                        this.CorreoEletronicoCli.Text);
                    this.DataGridCorreoCliente.EndEdit();
                    this.CorreosClientebindingSource.EndEdit();
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
        private void GuardarCorreo_ClienteDb()
        {
            string consulta = "";
            if (this.PanelBotonesCorreoCli.Tag.ToString() == "Nuevo")
            {
                consulta = "  INSERT INTO [DtCorreosCliente] VALUES([@Id],[@RazonSocial],[@EmpresaNombre],[@Direcion],[@CorreoEletronico_cli])";

            }
            else
            {
                consulta = "UPDATE [DtCorreosCliente] SET [Id] = @Id,[RazonSocial] = @RazonSocial,[EmpresaNombre] = @EmpresaNombre ," +
                    "[Direcion] = @Direcion,[CorreoEletronico_cli] = @CorreoEletronico_cli  WHERE Id = @Id";
            }
            ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
            try
            {
                if (NuevaConexion.SiConexionDb)
                {
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", string.IsNullOrEmpty(this.Id_CorreoCli.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Id_CorreoCli.Text));
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@RazonSocial", string.IsNullOrEmpty(this.RazonSocial.Text) ? (object)DBNull.Value : this.RazonSocial.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@EmpresaNombre", string.IsNullOrEmpty(this.EmpresaCli.Text) ? (object)DBNull.Value : this.EmpresaCli.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Direcion", string.IsNullOrEmpty(this.Direcion.Text) ? (object)DBNull.Value : this.Direcion.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@CorreoEletronico_cli", string.IsNullOrEmpty(this.CorreoEletronicoCli.Text) ? (object)DBNull.Value : this.CorreoEletronicoCli.Text);
                    NuevaConexion.ComandoDb.ExecuteNonQuery();
                    NuevaConexion.ComandoDb.Parameters.Clear();
                    FormMenuPrincipal.menu2principal.DtCorreosCliente.Rows.Add(this.Id_CorreoCli.Text, this.RazonSocial.Text, this.EmpresaCli.Text, this.Direcion.Text,
                        this.CorreoEletronicoCli.Text);
                    // LlenarDatagridCliente();
                    this.DatagridCorreosEmpresa.EndEdit();
                    this.CorreosbindingSource.EndEdit();
                    Validate();
                    limpiarCorreo_Cli();
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
                ClasCodificarPass Codificar = new ClasCodificarPass();
                string Pass = Codificar.Codificar(this.Contraseña.Text);
                if (NuevaConexion.SiConexionSql)
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", string.IsNullOrEmpty(this.Id_Correo_E.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Id_Correo_E.Text));
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@NombreEmpresa", string.IsNullOrEmpty(this.NombreEmpresa.Text) ? (object)DBNull.Value : this.NombreEmpresa.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@CorreoEletronico", string.IsNullOrEmpty(this.CorreoEletronico.Text) ? (object)DBNull.Value : this.CorreoEletronico.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Usuario", string.IsNullOrEmpty(this.Usuario.Text) ? (object)DBNull.Value : this.Usuario.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Contraseña", string.IsNullOrEmpty(Pass) ? (object)DBNull.Value : Pass);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@smtp", string.IsNullOrEmpty(this.smtp.Text) ? (object)DBNull.Value : this.smtp.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Puerto", string.IsNullOrEmpty(this.Puerto.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Puerto.Text));
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Timeof", string.IsNullOrEmpty(this.Timeof.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Timeof.Text));
                    NuevaConexion.ComandoSql.ExecuteNonQuery();
                    NuevaConexion.ComandoSql.Parameters.Clear();
                    FormMenuPrincipal.menu2principal.DtCorreos.Rows.Add(this.Id_Correo_E.Text, this.NombreEmpresa.Text, this.CorreoEletronico.Text, this.Usuario.Text,
                        this.Contraseña.Text, this.smtp.Text, this.Puerto.Text, this.Timeof.Text);
                    this.DatagridCorreosEmpresa.EndEdit();
                    this.CorreosbindingSource.EndEdit();
                    Validate();
                    LimpiarCorreo_Empresa();
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
                string consulta = "Delete from  [DtCorreosCliente]   WHERE Id= @Id";
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

            string consulta = "Delete from  [DtCorreosCliente]   WHERE Id= @Id";
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
            try
            {
                {
                    if (NuevaConexion.SiConexionSql)
                    {
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", Convert.ToInt32(this.Id_Correo_E.Text));
                        NuevaConexion.ComandoSql.ExecuteNonQuery();
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
                if (NuevaConexion.CerrarConexionSql)
                {

                }
            }

        }
        private void EliminarCorreo_EmpresaBb()
        {
            if (File.Exists(ClasDatos.RutaBaseDatosDb))
            {
                string consulta = "Delete from  [DtCorreos]   WHERE Id= @Id";
                ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
                try
                {
                    {
                        if (NuevaConexion.SiConexionDb)
                        {
                            NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", Convert.ToInt32(this.Id_Correo_E.Text));
                            NuevaConexion.ComandoDb.ExecuteNonQuery();
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
        private void EliminarCorreo_EnpresaSql()
        {

            string consulta = "Delete from  [DtCorreos]   WHERE Id= @Id";
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
            if (EspacioDiscosCorreo_EMP(Directory.GetCurrentDirectory(), 30))
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
            if (e.RowIndex > -1)
            {
                try
                {
                    LimpiarCorreo_Empresa();
                    ExtraerDatagrid();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            }

        }

        private void DataGridCorreoCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    limpiarCorreo_Cli();
                    ExtraerDatagridCliente();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnEliminarCorreoEmpresa_Click(object sender, EventArgs e)
        {
            if (this.CorreosbindingSource.Count > 0)
            {
                if (MessageBox.Show("Desea Eliminar Permanentemente ", "ELIMINAR ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    if (ClsConexionSql.SibaseDatosSql)
                    {
                        EliminarCorreo_EnpresaSql();
                    }
                    else
                    {
                        if (File.Exists(ClasDatos.RutaBaseDatosDb))
                        {
                            EliminarCorreo_EmpresaBb();

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
                int numeroFILA = this.CorreosbindingSource.Count;

                if (this.CorreosbindingSource.Count >= 0)
                {
                    this.Id_Correo_E.Text = "1";
                }
                if (numeroFILA > 0)
                {
                    if (this.DatagridCorreosEmpresa.Rows[numeroFILA - 1].Cells[0].Value.ToString() == string.Empty)
                    {
                        Random r = new Random();
                        int VALORid = r.Next(5000, 100000000);
                        this.Id_Correo_E.Text = VALORid.ToString();
                    }
                    else
                    {
                        int VALORid = Convert.ToInt32(this.DatagridCorreosEmpresa.Rows[numeroFILA - 1].Cells[0].Value) + 1;
                        this.Id_Correo_E.Text = VALORid.ToString();
                    }

                }
                this.CorreoEletronico.Text = "Peloscalvo@Gmail.com";
                this.smtp.Text = "Gmail.com";
                this.Puerto.Text = "587";
                this.CorreoEletronico.Focus();
                this.CorreoEletronico.Select(1, 1);
                LimpiarCorreo_Empresa();
                ModificarOjetosCorreo_E();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnModificarCorreoEmpr_Click(object sender, EventArgs e)
        {
            if (this.CorreosbindingSource.Count > 0)
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
            if (this.Id_Correo_E.Text == string.Empty)
            {
                MessageBox.Show("Falta (( id ))) o  ((Datos))", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (EspacioDiscosCorreo_EMP(Directory.GetCurrentDirectory(), 25))
            {
                BorrarErrorCorreoEmpresa();
                if (ValidarCorreoEmpresa())
                {
                    {
                        try
                        {
                            foreach (DataGridViewRow fila in this.DatagridCorreosEmpresa.Rows)
                            {
                                if (fila.Cells[1].ToString() == this.CorreoEletronico.Text)
                                {
                                    if (this.DatagridCorreosEmpresa.CurrentCell.RowIndex == fila.Index)
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
        }

        private void BtnCancelarCorreo_E_Click(object sender, EventArgs e)
        {
            BorrarErrorCorreoEmpresa();
            if (this.CorreosbindingSource.Count > 0)
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
            if (this.BtnGuardarCorreo_E.Enabled == true & this.BtnGuardarCorreoCli.Enabled == true)
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

        private void checkPassCorreo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkPassCorreo.Checked == true)
            {
                this.checkPassCorreo.Text = "Ocultar";
                this.Contraseña.PasswordChar = '\0';
            }
            else
            {
                this.checkPassCorreo.Text = "Mostrar";
                this.Contraseña.PasswordChar = '*';

            }
        }

        private void Puerto_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            {
                e.Handled = true;
            }
        }

        private void Timeof_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            {
                e.Handled = true;
            }
        }

        private void DatagridCorreosEmpresa_SelectionChanged(object sender, EventArgs e)
        {
            if (this.CorreosbindingSource.Count > 0)
            {
                try
                {
                    LimpiarCorreo_Empresa();
                    ExtraerDatagrid();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnNuevoCorreoCli_Click(object sender, EventArgs e)
        {
            this.PanelBotonesCorreoCli.Tag = "Nuevo";
            try
            {
                int numeroFILA = this.CorreosClientebindingSource.Count;

                if (this.CorreosClientebindingSource.Count >= 0)
                {
                    this.Id_CorreoCli.Text = "1";
                }
                if (numeroFILA > 0)
                {
                    if (this.DataGridCorreoCliente.Rows[numeroFILA - 1].Cells[0].Value.ToString() == string.Empty)
                    {
                        Random r = new Random();
                        int VALORid = r.Next(5000, 100000000);
                        this.Id_CorreoCli.Text = VALORid.ToString();
                    }
                    else
                    {
                        int VALORid = Convert.ToInt32(this.DataGridCorreoCliente.Rows[numeroFILA - 1].Cells[0].Value) + 1;
                        this.Id_CorreoCli.Text = VALORid.ToString();
                    }

                }
                this.CorreoEletronicoCli.Text = "Ejemplo@Gmail.com";
                this.CorreoEletronicoCli.Focus();
                // this.CorreoEletronicoCli.Select(1, 1);
                limpiarCorreo_Cli();
                ModificarOjetosCorreo_Cli();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnModificarCorreoCli_Click(object sender, EventArgs e)
        {
            if (this.CorreosbindingSource.Count > 0)
            {
                this.PanelBotonesCorreoCli.Tag = "Modificar";
                ModificarOjetosCorreo_Cli();
            }
        }

        private void BtnCancelarCli_Click(object sender, EventArgs e)
        {
            BorrarErrorCorreoEmpresa();
            if (this.CorreosClientebindingSource.Count > 0)
            {
                try
                {
                    if (this.PanelBotonesCorreoCli.Tag.ToString() == "Nuevo")
                    {

                        this.DataGridCorreoCliente.Rows.RemoveAt(this.DataGridCorreoCliente.CurrentCell.RowIndex);

                    }
                }
                catch (Exception)
                {

                    //  throw;
                }

            }
            RestaurarOjetosCorreo_Cli();
        }

        private void BtnGuardarCorreoCli_Click_1(object sender, EventArgs e)
        {
            if (this.DataGridCorreoCliente.RowCount < 0)
            {
                MessageBox.Show("No Tiene Nada Que Guardar", "GUARDAR");
                return;
            }
            if (this.Id_CorreoCli.Text == string.Empty)
            {
                MessageBox.Show("Falta (( id ))) o  ((Datos))", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (EspacioDiscosCorreo_EMP(Directory.GetCurrentDirectory(), 25))

                BorrarErrorCorreoCli();
            if (ValidarCorreoCli())
            {
                {
                    try
                    {
                        foreach (DataGridViewRow fila in this.DataGridCorreoCliente.Rows)
                        {
                            if (fila.Cells[1].ToString() == this.CorreoEletronicoCli.Text)
                            {
                                if (this.DataGridCorreoCliente.CurrentCell.RowIndex == fila.Index)
                                {
                                    break;
                                }
                                MessageBox.Show(this.CorreoEletronicoCli.Text.ToString(), "YA EXISTE ESTA CORREO ELETRONICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            GuardarCorreo_ClienteSql();
                        }
                        else
                        {

                            if (File.Exists(ClasDatos.RutaBaseDatosDb))
                            {
                                GuardarCorreo_ClienteDb();
                            }
                            else
                            {
                                MessageBox.Show("Archivo No Se Encuentra", " FALLO AL GUARDAR ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                this.PanelBotonesCorreoCli.Enabled = false;
                            }
                        }
                    }
                }
            }
        }

        private void BtnEliminarCorreoCli_Click(object sender, EventArgs e)
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

        private void DataGridCorreoCliente_SelectionChanged(object sender, EventArgs e)
        {
            if (this.CorreosClientebindingSource.Count > 0)
            {
                try
                {
                    limpiarCorreo_Cli();
                    ExtraerDatagridCliente();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}



