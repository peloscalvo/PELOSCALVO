using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Conexiones;
namespace PELOSCALVO
{
    public partial class FormClientes : Form
    {
        string clientes2 = "1";
        public static FormClientes menu2CLIENTES2;
        private bool EspacioDiscosCli(string nombreDisco, int Espacio)
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
        private bool VALIDARcampos()
        {
            bool ok = true;
            if (this.apodoClienteTextBox.Text.Length < 4)
            {
                ok = false;
                this.errorProvider1.SetError(this.apodoClienteTextBox, "_ingresar Razon Social (( minimo 4 Caracteres))");
            }
            if (this.nombreClienteTextBox.Text.Length < 4)
            {
                ok = false;
                this.errorProvider1.SetError(this.nombreClienteTextBox, "_ingresar NOMBRE (( minimo 4 Caracteres))");
            }
            if (this.direccionClienteTextBox.Text.Length < 4)
            {
                ok = false;
                this.errorProvider1.SetError(this.direccionClienteTextBox, "_ingresar Direcion (( minimo 4 Caracteres))");
            }

            if (this.idClienteTextBox.Text.Length < 1)
            {
                ok = false;
                this.errorProvider1.SetError(this.idClienteTextBox, "_ingresar Direcion (( minimo 1 Caracteres))");
            }
            if (this.provinciaClienteComboBox1.Text.Length < 3)
            {
                ok = false;
                this.errorProvider1.SetError(this.provinciaClienteComboBox1, "Falta Provincia(( minimo 3 Caracteres)) ");
            }
            if (this.paisClienteComboBox1.Text.Length < 3)
            {
                ok = false;
                this.errorProvider1.SetError(this.paisClienteComboBox1, "Falta Provincia (( minimo 3 Caracteres))");
            }
            return ok;
        }
        private void BORRARerrores()
        {
            this.errorProvider1.SetError(this.apodoClienteTextBox, "");
            this.errorProvider1.SetError(this.nombreClienteTextBox, "");
            this.errorProvider1.SetError(this.direccionClienteTextBox, "");
            this.errorProvider1.SetError(this.dniClienteTextBox, "");
            this.errorProvider1.SetError(this.idClienteTextBox, "");
            this.errorProvider1.SetError(this.provinciaClienteComboBox1, "");
            this.errorProvider1.SetError(this.paisClienteComboBox1, "");
        }

        public Boolean email_bien_escrito()
        {
            String expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(this.correoClienteTextBox.Text, expresion))
            {
                if (Regex.Replace(this.correoClienteTextBox.Text, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void ValidarCuit()
        {
            email_bien_escrito();


            // a.ValidarCuit(this.correoClienteTextBox.Text);
        }
        private void ModificarControlesForm()
        {
            this.dtClientesDataGridView.Enabled = false;
            this.dtClientesBindingSource.EndEdit();
            this.idClienteTextBox.Enabled = true;
            this.panelBotonesClientes.Enabled = false;
            this.BtnGuardarCliente.Enabled = true;
            this.BtnCancelarCliente.Enabled = true;
            this.dtClientesDataGridView.Enabled = false;
            this.panelCuenta.Enabled = true;
            foreach (Control ctrl in this.tabPage1Clientes.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = true;

                }
            }
            foreach (Control ctrl in this.tabPage2Clientes.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = true;

                }
            }
            foreach (Control ctrl in this.tabPage2Clientes.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ctrl.Enabled = true;

                }
            }
            foreach (Control ctrl in this.tabDatos2.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = true;
                }
            }
            this.panelCuenta.Enabled = true;
            foreach (Control ctrl in this.tabDatos2.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ctrl.Enabled = true;
                }
            }
            this.idClienteTextBox.Enabled = false;

        }
        private void RestaurarControlesForm()
        {
            this.dtClientesDataGridView.Refresh();
            foreach (Control ctrl in this.tabPage1Clientes.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = false;

                }
            }
            foreach (Control ctrl in this.tabPage2Clientes.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = false;

                }
            }
            foreach (Control ctrl in this.tabPage2Clientes.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ctrl.Enabled = false;

                }
            }
            foreach (Control ctrl in this.tabDatos2.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = false;
                }
            }
            this.panelCuenta.Enabled = true;
            foreach (Control ctrl in this.tabDatos2.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ctrl.Enabled = false;
                }
            }
            this.panelCuenta.Enabled = true;
            this.idClienteTextBox.Enabled = false;
            this.BtnGuardarCliente.Enabled = false;
            this.BtnCancelarCliente.Enabled = false;
            this.panelBotonesClientes.Enabled = true;
            this.dtClientesDataGridView.Enabled = true;
            int numeroFILA = this.dtClientesDataGridView.Rows.Count;
            BORRARerrores();

            if (numeroFILA > 1)
            {
                this.dtClientesDataGridView.Rows[0].Selected = true;
            }
        }
        private void GuardarClientesDb()
        {
            string DatoCliente = FormMenuPrincipal.menu2principal.InfoClientes.Text + " De Clientes";
            if (FormMenuPrincipal.menu2principal.InfoExtension.Text == "DBF")
            {
                DatoCliente = FormMenuPrincipal.menu2principal.InfoClientes.Text;
            }
            string Consulta = "";
            if (this.panelBotonesClientes.Tag.ToString() == "Nuevo")
            {
                Consulta = "INSERT INTO [" + DatoCliente + "] VALUES(@IDCLIENTE, @APODOCLIEN, @NOMBRECLIE, @DIRECCIONC, @TELEFONOCL, @MOVILCLIEN," +
                 " @CORREOCLIE, @DNICLIENTE, @LOCALIDADC, @CODIGOPOST, @PAISCLIENT, @FECHAALTAC, @CALLECLIEN,@NUMEROCALL, @PROVINCIAC, @TARIFATIPO, @TIPODNI," +
                 " @TIPOCLIENT, @DESCUENTOC, @NUMEROCUEN, @PORTES,@BANCOOFICI, @BANCOPROVI, @BANCODIREC, @BANCOLOCAL, @BANCOIBAN, @BANCOCODIG, @BANCOENTID, @BANCOOFIC2, @BANCODC, @BANCON_CUE, @BAJA)";

            }
            else
            {
                Consulta = "UPDATE [DtClientes]SET[" + DatoCliente + "] = @IDCLIENTE, [APODOCLIEN] = @APODOCLIEN,[NOMBRECLIE] = @NOMBRECLIE," +
              " [DIRECCIONC] = @DIRECCIONC, [TELEFONOCL] = @TELEFONOCL, [MOVILCLIEN] = @MOVILCLIEN, [CORREOCLIE] = @CORREOCLIE, [DNICLIENTE] = @DNICLIENTE,[LOCALIDADC] = @LOCALIDADC," +
              "[CODIGOPOST] = @CODIGOPOST,[PAISCLIENT] = @PAISCLIENT, [FECHAALTAC] = @FECHAALTAC, [CALLECLIEN] = @CALLECLIEN,[NUMEROCALL]= @NUMEROCALL, [PROVINCIAC] = @PROVINCIAC," +
              " [TARIFATIPO] = @TARIFATIPO, [TIPODNI] = @TIPODNI,[TIPOCLIENT] = @TIPOCLIENT, [DESCUENTOC] = @DESCUENTOC, [NUMEROCUEN] = @NUMEROCUEN, [PORTES] = @PORTES," +
              "[BANCOOFICI] = @BANCOOFICI,[BANCOPROVI] = @BANCOPROVI,[BANCODIREC] = @BANCODIREC,[BANCOLOCAL] = @BANCOLOCAL, [BANCOIBAN] = @BANCOIBAN, [BANCOCODIG] = @BANCOCODIG," +
              " [BANCOENTID] = @BANCOENTID, [BANCOOFIC2] = @BANCOOFIC2, [BANCODC] = @BANCODC, [BANCON_CUE] = @BANCON_CUE,[BAJA] = @BAJA WHERE [IDCLIENTE] = @IDCLIENTE";
            }
            ClsConexionDb NuevaConexion = new ClsConexionDb(Consulta);

            try
            {
                if (NuevaConexion.SiConexionDb)
                {
                    //añadir guaradar a  qui
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@IDCLIENTE", this.idClienteTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@APODOCLIEN", this.apodoClienteTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@NOMBRECLIE", string.IsNullOrEmpty(this.nombreClienteTextBox.Text) ? (object)DBNull.Value : this.nombreClienteTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@DIRECCIONC", string.IsNullOrEmpty(this.direccionClienteTextBox.Text) ? (object)DBNull.Value : this.direccionClienteTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@DNICLIENTE", string.IsNullOrEmpty(this.dniClienteTextBox.Text) ? (object)DBNull.Value : this.dniClienteTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@LOCALIDADC", string.IsNullOrEmpty(this.localidadClienteTextBox.Text) ? (object)DBNull.Value : this.localidadClienteTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@TELEFONOCL", string.IsNullOrEmpty(this.telefonoClienteTextBox.Text) ? (object)DBNull.Value : this.telefonoClienteTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@NUMEROCUEN", string.IsNullOrEmpty(this.NUMEROCUENTextBox.Text) ? (object)DBNull.Value : this.NUMEROCUENTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@MOVILCLIEN", string.IsNullOrEmpty(this.movilClienteTextBox.Text) ? (object)DBNull.Value : this.movilClienteTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@CORREOCLIE", string.IsNullOrEmpty(this.correoClienteTextBox.Text) ? (object)DBNull.Value : this.correoClienteTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@CODIGOPOST", string.IsNullOrEmpty(this.codigoPostalClienteTextBox.Text) ? (object)DBNull.Value : this.codigoPostalClienteTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@PAISCLIENT", string.IsNullOrEmpty(this.paisClienteComboBox1.Text) ? (object)DBNull.Value : this.paisClienteComboBox1.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@CALLECLIEN", string.IsNullOrEmpty(this.calleClienteTextBox.Text) ? (object)DBNull.Value : this.calleClienteTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@NUMEROCALL", string.IsNullOrEmpty(this.numeroCalleClienteTextBox.Text) ? (object)DBNull.Value : this.numeroCalleClienteTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@PROVINCIAC", string.IsNullOrEmpty(this.provinciaClienteComboBox1.Text) ? (object)DBNull.Value : this.provinciaClienteComboBox1.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@TARIFATIPO", string.IsNullOrEmpty(this.tarifaTipoClienteComboBox.Text) ? (object)DBNull.Value : this.tarifaTipoClienteComboBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@TIPODNI", string.IsNullOrEmpty(this.dniClienteTipoComboBox.Text) ? (object)DBNull.Value : this.dniClienteTipoComboBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@TIPOCLIENT", string.IsNullOrEmpty(this.tIPOCLIENTComboBox.Text) ? (object)DBNull.Value : this.tIPOCLIENTComboBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@DESCUENTOC", string.IsNullOrEmpty(this.dESCUENTOCTextBox.Text) ? (object)DBNull.Value : this.dESCUENTOCTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@PORTES", string.IsNullOrEmpty(this.pORTESComboBox.Text) ? (object)DBNull.Value : this.pORTESComboBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@BANCOOFICI", string.IsNullOrEmpty(this.bANCOOFICITextBox.Text) ? (object)DBNull.Value : this.bANCOOFICITextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@BANCOPROVI", string.IsNullOrEmpty(this.BancoProvincia.Text) ? (object)DBNull.Value : this.BancoProvincia.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@BANCODIREC", string.IsNullOrEmpty(this.bANCODIRECTextBox.Text) ? (object)DBNull.Value : this.bANCODIRECTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@BANCOLOCAL", string.IsNullOrEmpty(this.bANCOLOCALTextBox.Text) ? (object)DBNull.Value : this.bANCOLOCALTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@BANCOCODIG", string.IsNullOrEmpty(this.bANCOCODIGTextBox.Text) ? (object)DBNull.Value : this.bANCOCODIGTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@BANCOENTID", string.IsNullOrEmpty(this.bANCOENTIDTextBox.Text) ? (object)DBNull.Value : this.bANCOENTIDTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@BANCOOFIC2", string.IsNullOrEmpty(this.BANCOOFIC2TextBox.Text) ? (object)DBNull.Value : this.BANCOOFIC2TextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@BANCODC", string.IsNullOrEmpty(this.bANCODCTextBox.Text) ? (object)DBNull.Value : this.bANCODCTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@BANCOIBAN", string.IsNullOrEmpty(this.bANCOIBANTextBox.Text) ? (object)DBNull.Value : this.bANCOIBANTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@BANCON_CUE", string.IsNullOrEmpty(this.bANCON_CUETextBox.Text) ? (object)DBNull.Value : this.bANCON_CUETextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@BAJA", 0);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@FECHAALTAC", this.FechaAltaCliente.Text);
                    NuevaConexion.ComandoDb.ExecuteNonQuery();
                    RestaurarControlesForm();
                    MessageBox.Show("Guardado Correctamente", "EXITO");
                    if (NuevaConexion.CerrarConexionDB)
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                if (NuevaConexion.CerrarConexionDB)
                {

                }
                MessageBox.Show(ex.Message, "ERROR");
            }
        }
        private void GuardarClientesSql()
        {
            string DatoCliente = FormMenuPrincipal.menu2principal.InfoClientes.Text + " De Clientes";
            string Consulta = "";
            if (this.panelBotonesClientes.Tag.ToString() == "Nuevo")
            {
                Consulta = "INSERT INTO ["+DatoCliente+"] VALUES(@IDCLIENTE, @APODOCLIEN, @NOMBRECLIE, @DIRECCIONC, @TELEFONOCL, @MOVILCLIEN," +
                 " @CORREOCLIE, @DNICLIENTE, @LOCALIDADC, @CODIGOPOST, @PAISCLIENT, @FECHAALTAC, @CALLECLIEN,@NUMEROCALL, @PROVINCIAC, @TARIFATIPO, @TIPODNI," +
                 " @TIPOCLIENT, @DESCUENTOC, @NUMEROCUEN, @PORTES,@BANCOOFICI, @BANCOPROVI, @BANCODIREC, @BANCOLOCAL, @BANCOIBAN, @BANCOCODIG, @BANCOENTID, @BANCOOFIC2, @BANCODC, @BANCON_CUE, @BAJA)";

            }
            else
            {
                Consulta = "UPDATE [DtClientes]SET[" + DatoCliente + "] = @IDCLIENTE, [APODOCLIEN] = @APODOCLIEN,[NOMBRECLIE] = @NOMBRECLIE," +
              " [DIRECCIONC] = @DIRECCIONC, [TELEFONOCL] = @TELEFONOCL, [MOVILCLIEN] = @MOVILCLIEN, [CORREOCLIE] = @CORREOCLIE, [DNICLIENTE] = @DNICLIENTE,[LOCALIDADC] = @LOCALIDADC," +
              "[CODIGOPOST] = @CODIGOPOST,[PAISCLIENT] = @PAISCLIENT, [FECHAALTAC] = @FECHAALTAC, [CALLECLIEN] = @CALLECLIEN,[NUMEROCALL]= @NUMEROCALL, [PROVINCIAC] = @PROVINCIAC," +
              " [TARIFATIPO] = @TARIFATIPO, [TIPODNI] = @TIPODNI,[TIPOCLIENT] = @TIPOCLIENT, [DESCUENTOC] = @DESCUENTOC, [NUMEROCUEN] = @NUMEROCUEN, [PORTES] = @PORTES," +
              "[BANCOOFICI] = @BANCOOFICI,[BANCOPROVI] = @BANCOPROVI,[BANCODIREC] = @BANCODIREC,[BANCOLOCAL] = @BANCOLOCAL, [BANCOIBAN] = @BANCOIBAN, [BANCOCODIG] = @BANCOCODIG," +
              " [BANCOENTID] = @BANCOENTID, [BANCOOFIC2] = @BANCOOFIC2, [BANCODC] = @BANCODC, [BANCON_CUE] = @BANCON_CUE,[BAJA] = @BAJA WHERE [IDCLIENTE] = @IDCLIENTE";
            }
            ClsConexionSql NuevaConexion = new ClsConexionSql(Consulta);

            try
            {
                if (NuevaConexion.SiConexionSql)
                {
                    //añadir guaradar a  qui
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@IDCLIENTE", this.idClienteTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@APODOCLIEN", this.apodoClienteTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@NOMBRECLIE", string.IsNullOrEmpty(this.nombreClienteTextBox.Text) ? (object)DBNull.Value : this.nombreClienteTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@DIRECCIONC", string.IsNullOrEmpty(this.direccionClienteTextBox.Text) ? (object)DBNull.Value : this.direccionClienteTextBox.Text); 
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@DNICLIENTE", string.IsNullOrEmpty(this.dniClienteTextBox.Text) ? (object)DBNull.Value : this.dniClienteTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@LOCALIDADC", string.IsNullOrEmpty(this.localidadClienteTextBox.Text) ? (object)DBNull.Value : this.localidadClienteTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@TELEFONOCL", string.IsNullOrEmpty(this.telefonoClienteTextBox.Text) ? (object)DBNull.Value : this.telefonoClienteTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@NUMEROCUEN", string.IsNullOrEmpty(this.NUMEROCUENTextBox.Text) ? (object)DBNull.Value : this.NUMEROCUENTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@MOVILCLIEN", string.IsNullOrEmpty(this.movilClienteTextBox.Text) ? (object)DBNull.Value : this.movilClienteTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@CORREOCLIE", string.IsNullOrEmpty(this.correoClienteTextBox.Text) ? (object)DBNull.Value : this.correoClienteTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@CODIGOPOST", string.IsNullOrEmpty(this.codigoPostalClienteTextBox.Text) ? (object)DBNull.Value : this.codigoPostalClienteTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@PAISCLIENT", string.IsNullOrEmpty(this.paisClienteComboBox1.Text) ? (object)DBNull.Value : this.paisClienteComboBox1.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@CALLECLIEN", string.IsNullOrEmpty(this.calleClienteTextBox.Text) ? (object)DBNull.Value : this.calleClienteTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@NUMEROCALL", string.IsNullOrEmpty(this.numeroCalleClienteTextBox.Text) ? (object)DBNull.Value : this.numeroCalleClienteTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@PROVINCIAC", string.IsNullOrEmpty(this.provinciaClienteComboBox1.Text) ? (object)DBNull.Value : this.provinciaClienteComboBox1.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@TARIFATIPO", string.IsNullOrEmpty(this.tarifaTipoClienteComboBox.Text) ? (object)DBNull.Value : this.tarifaTipoClienteComboBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@TIPODNI", string.IsNullOrEmpty(this.dniClienteTipoComboBox.Text) ? (object)DBNull.Value : this.dniClienteTipoComboBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@TIPOCLIENT", string.IsNullOrEmpty(this.tIPOCLIENTComboBox.Text) ? (object)DBNull.Value : this.tIPOCLIENTComboBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@DESCUENTOC", string.IsNullOrEmpty(this.dESCUENTOCTextBox.Text) ? (object)DBNull.Value : this.dESCUENTOCTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@PORTES", string.IsNullOrEmpty(this.pORTESComboBox.Text) ? (object)DBNull.Value : this.pORTESComboBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@BANCOOFICI", string.IsNullOrEmpty(this.bANCOOFICITextBox.Text) ? (object)DBNull.Value : this.bANCOOFICITextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@BANCOPROVI", string.IsNullOrEmpty(this.BancoProvincia.Text) ? (object)DBNull.Value : this.BancoProvincia.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@BANCODIREC", string.IsNullOrEmpty(this.bANCODIRECTextBox.Text) ? (object)DBNull.Value : this.bANCODIRECTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@BANCOLOCAL", string.IsNullOrEmpty(this.bANCOLOCALTextBox.Text) ? (object)DBNull.Value : this.bANCOLOCALTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@BANCOCODIG", string.IsNullOrEmpty(this.bANCOCODIGTextBox.Text) ? (object)DBNull.Value : this.bANCOCODIGTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@BANCOENTID", string.IsNullOrEmpty(this.bANCOENTIDTextBox.Text) ? (object)DBNull.Value : this.bANCOENTIDTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@BANCOOFIC2", string.IsNullOrEmpty(this.BANCOOFIC2TextBox.Text) ? (object)DBNull.Value : this.BANCOOFIC2TextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@BANCODC", string.IsNullOrEmpty(this.bANCODCTextBox.Text) ? (object)DBNull.Value : this.bANCODCTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@BANCOIBAN", string.IsNullOrEmpty(this.bANCOIBANTextBox.Text) ? (object)DBNull.Value : this.bANCOIBANTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@BANCON_CUE", string.IsNullOrEmpty(this.bANCON_CUETextBox.Text) ? (object)DBNull.Value : this.bANCON_CUETextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@BAJA", 0);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@FECHAALTAC", this.FechaAltaCliente.Text);
                    NuevaConexion.ComandoSql.ExecuteNonQuery();
                    RestaurarControlesForm();
                    MessageBox.Show("Guardado Correctamente", "EXITO");
                    if (NuevaConexion.CerrarConexionSql)
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                if (NuevaConexion.CerrarConexionSql)
                {

                }
                MessageBox.Show(ex.Message, "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        public FormClientes()
        {
            InitializeComponent();
            FormClientes.menu2CLIENTES2 = this;
        }

        private void FormClientes_MouseEnter(object sender, EventArgs e)
        {
            FormMenuPrincipal.menu2principal.panelventas.Visible = false;
            FormMenuPrincipal.menu2principal.panelSUBventas.Visible = false;
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

            try
            {
                if (FormMenuPrincipal.menu2principal.dsClientes != null)
                {
                    this.dtClientesBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsClientes;
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
            if (Directory.Exists(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal))
            {
                if (!File.Exists(ClasDatos.RutaMulti2))
                {

                    this.panelBotonesClientes.Enabled = false;
                    MessageBox.Show("Archivo : " + ClasDatos.RutaMulti2, "Falta Archivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (!File.Exists(ClasDatos.RutaMultidatos))
                {
                    MessageBox.Show("Falta Archivo De Configuracion", "ARCHIVO NO EXISTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


            }
            else
            {
                MessageBox.Show("Debe Restructurar Sistema", "DIRECTORIO " + ClasDatos.RutaDatosPrincipal + " NO EXISTE");
                this.panelBotonesClientes.Enabled = false;
                return;
            }

            this.FechaAltaCliente.Text = String.Format("{0:d/M/yyyy}", DateTime.Now);

        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            // panel2.Visible = false;

        }

        private void BtnGuardarCliente_Click(object sender, EventArgs e)
        {
            BORRARerrores();
            //email_bien_escrito();

            if (EspacioDiscosCli(ClasDatos.RutaMultidatos, 10))
            {
                if (VALIDARcampos())
                {
                    if (MessageBox.Show(" ¿Aceptar Guardar ? ", " GUARDAR ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        int i = 0;
                        foreach (DataGridViewRow fila in this.dtClientesDataGridView.Rows)
                        {
                            if (i == this.dtClientesDataGridView.CurrentCell.RowIndex)
                            {
                                goto seguir2;
                            }
                            if (fila.Cells[1].Value != null)
                            {
                                if (fila.Cells[1].Value.ToString() == this.apodoClienteTextBox.Text)
                                {
                                    this.apodoClienteTextBox.ReadOnly = false;
                                    this.apodoClienteTextBox.SelectAll();
                                    this.apodoClienteTextBox.Select(4, 4);
                                    MessageBox.Show(this.apodoClienteTextBox.Text, "Este Cliente Ya Existe", MessageBoxButtons.OK);
                                    return;
                                }
                            }
                        seguir2:
                            if (i == this.dtClientesDataGridView.Rows.Count)
                            {
                                break;
                            }
                            i = i + 1;
                        }
                        if (ClsConexionSql.SibaseDatosSql)
                        {
                            GuardarClientesSql();
                        }
                        else
                        {
                            GuardarClientesDb();
                        }

                    }

                }
            }


        }

        private void BtnSalirCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" ¿Salir Clientes ? ", " CLIENTES ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }

        }

        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {
            try
            {
                this.panelBotonesClientes.Tag = "Nuevo";
                this.dtClientesDataGridView.Refresh();
                this.dtClientesDataGridView.Sort(this.dtClientesDataGridView.Columns[0], ListSortDirection.Ascending);
                int numeroFILA = this.dtClientesDataGridView.Rows.Count;
                this.dtClientesBindingSource.AddNew();
                if (this.dtClientesDataGridView.Rows[0].Cells[0].Value != null)
                {
                    this.dtClientesDataGridView.Rows[0].Cells[0].Value = "1";
                }
                if (numeroFILA > 0)
                {
                    int VALORid = Convert.ToInt32(this.dtClientesDataGridView.Rows[numeroFILA - 1].Cells[0].Value) + 1;
                    this.dtClientesDataGridView.Rows[numeroFILA].Cells[0].Value = (VALORid);
                    this.idClienteTextBox.Text = Convert.ToString(VALORid);
                }
                this.FechaAltaCliente.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now);
                this.dtClientesDataGridView.Rows[numeroFILA].Selected = true;
                if (this.dtInicioMultiBindingSource.Count > 0)
                {
                    if (FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["SerieProvinciaInicio"].ToString() != string.Empty)
                    {
                        this.provinciaClienteComboBox1.Text = FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["SerieProvinciaInicio"].ToString();
                    }
                    else
                    {
                        this.provinciaClienteComboBox1.Text = "La Coruña";
                    }
                    if (FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["SeriePaisInicio"].ToString() != string.Empty)
                    {
                        this.paisClienteComboBox1.Text = FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["SeriePaisInicio"].ToString();
                    }
                    else
                    {
                        this.paisClienteComboBox1.Text = "España";
                    }
                }
                ModificarControlesForm();
                BORRARerrores();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelarCliente_Click(object sender, EventArgs e)
        {
            // this.dsClientes.DtClientes.Rows.Clear();
            if (this.dtClientesDataGridView.RowCount >= 0)
            {
                if (this.panelBotonesClientes.Tag.ToString() == "Nuevo")
                {
                    this.dtClientesDataGridView.Rows.RemoveAt(this.dtClientesDataGridView.CurrentCell.RowIndex);
                }

            }
            RestaurarControlesForm();

        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
      
            if (!File.Exists(ClasDatos.RutaBaseDatosDb))
            {
                MessageBox.Show(ClasDatos.RutaBaseDatosDb, "NO EXISTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ClasDatos.OkFacturar = false;
            ClasDatos.QUEform = "Clientes";
            FormBuscarClientes form = new FormBuscarClientes();
            form.ShowDialog();
        }

        private void FormClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.BtnGuardarCliente.Enabled == true)
            {
                e.Cancel = true;
            }
        }

        private void BtnBuscarClientes2_Click(object sender, EventArgs e)
        {

            this.panel3.Visible = true;
            this.panel2.Visible = true;
        }

        private void BtnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (this.dtClientesBindingSource.Count > 0)
            {
                if (MessageBox.Show(" ¿Eliminar Clientes ? ", " ELIMINAR ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (ClsConexionSql.SibaseDatosSql)
                    {
                        try
                        {
                            if (FormMenuPrincipal.menu2principal.InfoClientes.Text != string.Empty)
                            {
                                String TipoTabla ="["+ FormMenuPrincipal.menu2principal.InfoClientes.Text+"]" ;
                                string consulta = "Delete * from " + TipoTabla + "  WHERE ID= @ID";
                                ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
                                {
                                    if (NuevaConexion.SiConexionSql)
                                    {
                                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@ID", this.idClienteTextBox.Text);
                                        NuevaConexion.ComandoSql.ExecuteNonQuery();
                                        this.dtClientesDataGridView.Rows.RemoveAt(this.dtClientesDataGridView.CurrentCell.RowIndex);
                                        this.dtClientesDataGridView.Refresh();
                                        MessageBox.Show("Se Elimino Correctamente", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }

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
                        if (FormMenuPrincipal.menu2principal.InfoClientes.Text != string.Empty)
                        {
                            String TipoTabla = "[" + FormMenuPrincipal.menu2principal.InfoClientes.Text + "]";      
                            string consulta = "Delete * from " + TipoTabla + "  WHERE ID= @ID";
                            ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
                            {
                                if (NuevaConexion.SiConexionDb)
                                {
                                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@ID", this.idClienteTextBox.Text);
                                    NuevaConexion.ComandoDb.ExecuteNonQuery();
                                    this.dtClientesDataGridView.Rows.RemoveAt(this.dtClientesDataGridView.CurrentCell.RowIndex);
                                    this.dtClientesDataGridView.Refresh();
                                    MessageBox.Show("Se Elimino Correctamente", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                            }


                        }
                        MessageBox.Show("Eliminado con exito", "ELIMINAR");
                    }


                }

            }

        }

        private void BtnModificarCliente_Click(object sender, EventArgs e)
        {
            this.panelBotonesClientes.Tag = "Actualizar";
            if (this.dtClientesDataGridView.Rows.Count > 0)
            {
                ModificarControlesForm();
            }

        }

        private void BtnAceptarFINALBuscar_Click(object sender, EventArgs e)
        {
            this.panel2.Visible = false;

        }

        private void idClienteTextBox_DoubleClick(object sender, EventArgs e)
        {
            this.idClienteTextBox.Enabled = true;
        }

        private void idClienteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int numeroFILA = this.dtClientesDataGridView.Rows.Count;
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void idClienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtClientesDataGridView_Click(object sender, EventArgs e)
        {
            // dtClientesDataGridView.Enabled = true;
            if (this.panelBotonesClientes.Enabled == false)
            {

      

            }
        }

        private void nombreClienteTextBox_Click(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.nombreClienteTextBox, "");
        }

        private void apodoClienteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void dniClienteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void correoClienteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.correoClienteTextBox.Text))
            {
                if (!email_bien_escrito())
                {
                    MessageBox.Show("D.n.i No Valido", "INVALIDO");
                    this.correoClienteTextBox.Focus();
                }

            }


        }

        private void apodoClienteTextBox_Click(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.apodoClienteTextBox, "");
        }

        private void direccionClienteTextBox_Click(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.direccionClienteTextBox, "");
        }

        private void dniClienteTextBox_Click(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.dniClienteTextBox, "");
        }

        private void BtnImprimirCliente_Click(object sender, EventArgs e)
        {
            if (this.clientes2 == "1")
            {
                this.clientes2 = "2";
                ClasDatos.OkFacturar = false;
                ClasDatos.QUEform = "Clientes";
                FormImprimirTodo frm = new FormImprimirTodo();
                frm.FormClosed += (o, args) => this.clientes2 = "1";
                frm.ShowDialog();
                frm.BringToFront();

            }
        }

        private void tabPage2Clientes_Click(object sender, EventArgs e)
        {

        }

        private void direccionClienteTextBox_Leave(object sender, EventArgs e)
        {

            int i = 0;
            foreach (DataGridViewRow fila in this.dtClientesDataGridView.Rows)
            {
                if (i == this.dtClientesDataGridView.CurrentCell.RowIndex)
                {
                    goto seguir2;
                }
                if (fila.Cells[2].Value != null)
                {
                    if (fila.Cells[2].Value.ToString() == this.nombreClienteTextBox.Text)
                    {
                        this.nombreClienteTextBox.ReadOnly = false;
                        this.nombreClienteTextBox.SelectAll();
                        this.nombreClienteTextBox.Select(4, 4);
                        MessageBox.Show(this.nombreClienteTextBox.Text, "Este Cliente Ya Existe", MessageBoxButtons.OK);
                        return;
                    }
                }
            seguir2:
                if (i == this.dtClientesDataGridView.Rows.Count)
                {
                    break;
                }
                i = i + 1;
            }
        }

        private void dniClienteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (this.dniClienteTextBox.Text.Length < 4)
            {

                MessageBox.Show(this.dniClienteTextBox, "_ingresar Dni (( NO CORRECTO))");
            }
        }

        private void dESCUENTOCTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void dESCUENTOCTextBox_Leave(object sender, EventArgs e)
        {
            if (this.dESCUENTOCTextBox.Text != string.Empty)
            {
                double Ganancia = Convert.ToDouble(this.dESCUENTOCTextBox.Text);
                // this.dESCUENTOCTextBox.Text = Convert.ToString(Ganancia / 100);
            }
        }

        private void bANCOENTIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (this.bANCOENTIDTextBox.Text.Length >= 3)
            {
                this.BANCOOFIC2TextBox.Focus();
                this.BANCOOFIC2TextBox.Select(0, 0);
            }
        }

        private void BANCOOFIC2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (this.BANCOOFIC2TextBox.Text.Length >= 3)
            {
                this.bANCODCTextBox.Focus();
                this.bANCODCTextBox.Select(0, 0);
            }
        }

        private void bANCODCTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (this.bANCODCTextBox.Text.Length >= 1)
            {
                this.NUMEROCUENTextBox.Focus();
                this.NUMEROCUENTextBox.Select(0, 0);
            }
        }

        private void NUMEROCUENTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (this.NUMEROCUENTextBox.Text.Length >= 1)
            {
                //  BtnGeneral iban
            }
        }

        private void bANCOENTIDTextBox_Enter(object sender, EventArgs e)
        {
            if (this.bANCOENTIDTextBox.Text == string.Empty)
            {
                this.bANCOENTIDTextBox.Select(0, 0);
            }
        }
    }
}


