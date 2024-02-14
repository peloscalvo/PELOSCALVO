using Comun;
using Conexiones;
using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
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
            if (this.ApodoClienteTex.Text.Length < 4)
            {
                ok = false;
                this.errorProvider1.SetError(this.ApodoClienteTex, "_ingresar Razon Social (( minimo 4 Caracteres))");
            }
            if (this.NombreCliente.Text.Length < 4)
            {
                ok = false;
                this.errorProvider1.SetError(this.NombreCliente, "_ingresar NOMBRE (( minimo 4 Caracteres))");
            }
            if (this.DirecionCliente.Text.Length < 4)
            {
                ok = false;
                this.errorProvider1.SetError(this.DirecionCliente, "_ingresar Direcion (( minimo 4 Caracteres))");
            }

            if (string.IsNullOrEmpty(this.Id_Clientes.Text))
            {
                ok = false;
                this.errorProvider1.SetError(this.Id_Clientes, "_ingresar Falta Id (( minimo 1 Caracteres))");
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
            this.errorProvider1.SetError(this.ApodoClienteTex, "");
            this.errorProvider1.SetError(this.NombreCliente, "");
            this.errorProvider1.SetError(this.DirecionCliente, "");
            this.errorProvider1.SetError(this.dniClienteTextBox, "");
            this.errorProvider1.SetError(this.Id_Clientes, "");
            this.errorProvider1.SetError(this.provinciaClienteComboBox1, "");
            this.errorProvider1.SetError(this.paisClienteComboBox1, "");
        }

        public Boolean email_bien_escrito()
        {
            String expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(this.CorreoClienteText.Text, expresion))
            {
                if (Regex.Replace(this.CorreoClienteText.Text, expresion, String.Empty).Length == 0)
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
            // this.Id_Clientes.Enabled = true;
            this.panelBotonesClientes.Enabled = false;
            this.BtnGuardarCliente.Enabled = true;
            this.BtnCancelarCliente.Enabled = true;
            this.dtClientesDataGridView.Enabled = false;
            this.panelCuenta.Enabled = true;
            foreach (Control ctrl in this.PageCliente1.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = true;

                }
            }
            foreach (Control ctrl in this.PageCliente2.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = true;

                }
            }
            foreach (Control ctrl in this.PageCliente2.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ctrl.Enabled = true;

                }
            }

            foreach (Control ctrl in this.PageCliente3.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = true;
                }
            }
            this.panelCuenta.Enabled = true;
            foreach (Control ctrl in this.PageCliente3.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ctrl.Enabled = true;
                }
            }
            // this.Id_Clientes.Enabled = false;

        }
        private void RestaurarControlesForm()
        {
            this.dtClientesDataGridView.Refresh();
            foreach (Control ctrl in this.PageCliente1.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = false;

                }
            }
            foreach (Control ctrl in this.PageCliente2.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = false;

                }
            }
            foreach (Control ctrl in this.PageCliente2.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ctrl.Enabled = false;

                }
            }
            foreach (Control ctrl in this.PageCliente3.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = false;
                }
            }
            foreach (Control ctrl in this.PageCliente3.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ctrl.Enabled = false;
                }
            }
            this.panelCuenta.Enabled = false;
            // this.Id_Clientes.Enabled = false;
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
        private void CargarCliente()
        {
            foreach (Control Texbox2 in PageCliente1.Controls)
            {
                if (Texbox2 is TextBox | Texbox2 is ComboBox)
                {
                    Texbox2.Text = string.Empty;
                    //MessageBox.Show(Texbox2.Name);
                }

            }
            foreach (Control Texbox2 in PageCliente2.Controls)
            {
                if (Texbox2 is TextBox | Texbox2 is ComboBox)
                {
                    Texbox2.Text = string.Empty;
 
                }

            }
            foreach (Control Texbox2 in PageCliente3.Controls)
            {
                if (Texbox2 is TextBox | Texbox2 is ComboBox)
                {
                    Texbox2.Text = string.Empty;

                }

            }
            FechaAltaCliente.Text = string.Empty;
            string Tabla = FormMenuPrincipal.menu2principal.InfoClientes.Text;
            string ConsultaCli = "SELECT [Id],[APODOCLIEN],[NOMBRECLIE] ,[DIRECCIONC],[TELEFONOCL],[MOVILCLIEN]" +
                ",[CORREOCLIE],[DNICLIENTE],[LOCALIDADC],[CODIGOPOST],[PAISCLIENT],[FECHAALTAC],[CALLECLIEN]" +
                ",[NUMEROCALL],[PROVINCIAC],[TARIFATIPO],[TIPODNI],[TIPOCLIENT],[DESCUENTOC],[NUMEROCUEN]" +
                ",[PORTES],[BANCOOFICI],[BANCOPROVI],[BANCODIREC],[BANCOLOCAL],[BANCOIBAN],[BANCOCODIG]" +
                ",[BANCOENTID],[BANCOOFIC2],[BANCODC],[BANCON_CUE],[BAJA] FROM[" + Tabla + "]  WHERE Id=" + Convert.ToInt32(this.Id_Clientes.Text);

            if (ClsConexionSql.SibaseDatosSql)
            {
                ClsConexionSql NuevaConexion = new ClsConexionSql(ConsultaCli);
                if (NuevaConexion.SiConexionSql)
                {
                    SqlDataReader leer = NuevaConexion.ComandoSql.ExecuteReader();
                    if (leer.HasRows)
                    {
                        if (leer.Read())
                        {
                            //  dtClientesBindingSource.Current. = leer.ToString();
                            if (!string.IsNullOrEmpty((leer["APODOCLIEN"]).ToString()))
                            {
                                ApodoClienteTex.Text = Convert.ToString(leer["APODOCLIEN"]);
                            }
                            if (!string.IsNullOrEmpty((leer["NOMBRECLIE"]).ToString()))
                            {
                                NombreCliente.Text = Convert.ToString(leer["NOMBRECLIE"]);
                            }
                            if (!string.IsNullOrEmpty((leer["DIRECCIONC"]).ToString()))
                            {
                                DirecionCliente.Text = Convert.ToString(leer["DIRECCIONC"]);
                            }
                            if (!string.IsNullOrEmpty((leer["TELEFONOCL"]).ToString()))
                            {
                                TelefonoClienteTextBox.Text = Convert.ToString(leer["TELEFONOCL"]);
                            }
                            if (!string.IsNullOrEmpty((leer["MOVILCLIEN"]).ToString()))
                            {
                                MovilClienteText.Text = Convert.ToString(leer["MOVILCLIEN"]);
                            }
                            if (!string.IsNullOrEmpty((leer["CORREOCLIE"]).ToString()))
                            {
                                CorreoClienteText.Text = Convert.ToString(leer["CORREOCLIE"]);
                            }
                            if (!string.IsNullOrEmpty((leer["DNICLIENTE"]).ToString()))
                            {
                                dniClienteTextBox.Text = Convert.ToString(leer["DNICLIENTE"]);
                            }
                            if (!string.IsNullOrEmpty((leer["LOCALIDADC"]).ToString()))
                            {
                                LocalidadClienteTxt.Text = Convert.ToString(leer["LOCALIDADC"]);
                            }
                            if (!string.IsNullOrEmpty((leer["CODIGOPOST"]).ToString()))
                            {
                                codigoPostalClienteTextBox.Text = Convert.ToString(leer["CODIGOPOST"]);
                            }
                            if (!string.IsNullOrEmpty((leer["PAISCLIENT"]).ToString()))
                            {
                                paisClienteComboBox1.Text = Convert.ToString(leer["PAISCLIENT"]);
                            }
                            if (!string.IsNullOrEmpty((leer["FECHAALTAC"]).ToString()))
                            {
                                FechaAltaCliente.Text = Convert.ToString(leer["FECHAALTAC"]);
                            }
                            if (!string.IsNullOrEmpty((leer["CALLECLIEN"]).ToString()))
                            {
                                CalleClienteTextBox.Text = Convert.ToString(leer["CALLECLIEN"]);
                            }
                            if (!string.IsNullOrEmpty((leer["NUMEROCALL"]).ToString()))
                            {
                                numeroCalleClienteTextBox.Text = Convert.ToString(leer["NUMEROCALL"]);
                            }
                            if (!string.IsNullOrEmpty((leer["PROVINCIAC"]).ToString()))
                            {
                                provinciaClienteComboBox1.Text = Convert.ToString(leer["PROVINCIAC"]);
                            }
                            if (!string.IsNullOrEmpty((leer["TARIFATIPO"]).ToString()))
                            {
                                TipoTarifa.Text = Convert.ToString(leer["TARIFATIPO"]);
                            }
                            if (!string.IsNullOrEmpty((leer["TIPODNI"]).ToString()))
                            {
                                TipoDocumento.Text = Convert.ToString(leer["TIPODNI"]);
                            }
                            if (!string.IsNullOrEmpty((leer["TIPOCLIENT"]).ToString()))
                            {
                                TipoCliente.Text = Convert.ToString(leer["TIPOCLIENT"]);
                            }
                            if (!string.IsNullOrEmpty((leer["DESCUENTOC"]).ToString()))
                            {
                                DescuentoCliente.Text = Convert.ToString(leer["DESCUENTOC"]);
                            }
                            if (!string.IsNullOrEmpty((leer["NUMEROCUEN"]).ToString()))
                            {
                                NUMEROCUENTextBox.Text = Convert.ToString(leer["NUMEROCUEN"]);
                            }
                            if (!string.IsNullOrEmpty((leer["PORTES"]).ToString()))
                            {
                                PortesTxt.Text = Convert.ToString(leer["PORTES"]);
                            }
                            if (!string.IsNullOrEmpty((leer["BANCOOFICI"]).ToString()))
                            {
                                bANCOOFICITextBox.Text = Convert.ToString(leer["BANCOOFICI"]);
                            }
                            if (!string.IsNullOrEmpty((leer["BANCOPROVI"]).ToString()))
                            {
                                BancoProvincia.Text = Convert.ToString(leer["BANCOPROVI"]);
                            }
                            if (!string.IsNullOrEmpty((leer["BANCODIREC"]).ToString()))
                            {
                                bANCODIRECTextBox.Text = Convert.ToString(leer["BANCODIREC"]);
                            }
                            if (!string.IsNullOrEmpty((leer["BANCOLOCAL"]).ToString()))
                            {
                                bANCOLOCALTextBox.Text = Convert.ToString(leer["BANCOLOCAL"]);
                            }
                            if (!string.IsNullOrEmpty((leer["BANCOIBAN"]).ToString()))
                            {
                                bANCOIBANTextBox.Text = Convert.ToString(leer["BANCOIBAN"]);
                            }
                            if (!string.IsNullOrEmpty((leer["BANCOCODIG"]).ToString()))
                            {
                                bANCOCODIGTextBox.Text = Convert.ToString(leer["BANCOCODIG"]);
                            }
                            if (!string.IsNullOrEmpty((leer["BANCOENTID"]).ToString()))
                            {
                                bANCOENTIDTextBox.Text = Convert.ToString(leer["BANCOENTID"]);
                            }
                            if (!string.IsNullOrEmpty((leer["BANCOOFIC2"]).ToString()))
                            {
                                BANCOOFIC2TextBox.Text = Convert.ToString(leer["BANCOOFIC2"]);
                            }
                            if (!string.IsNullOrEmpty((leer["BANCODC"]).ToString()))
                            {
                                bANCODCTextBox.Text = Convert.ToString(leer["BANCODC"]);
                            }
                            if (!string.IsNullOrEmpty((leer["BANCON_CUE"]).ToString()))
                            {
                                bANCON_CUETextBox.Text = Convert.ToString(leer["BANCON_CUE"]);
                            }
                            if (!string.IsNullOrEmpty((leer["BAJA"]).ToString()))
                            {
                                // ApodoClienteTex.Text = Convert.ToBoolean(leer["BAJA"]);
                            }
                            leer.Close();
                        }
                    }

                }
            }
            else
            {
                if (File.Exists(ClasDatos.RutaBaseDatosDb))
                {
                    ClsConexionDb NuevaConexion = new ClsConexionDb(ConsultaCli);
                    if (NuevaConexion.SiConexionDb)
                    {
                        OleDbDataReader leer = NuevaConexion.ComandoDb.ExecuteReader();
                        if (leer.HasRows)
                        {
                            if (leer.Read())
                            {
                                //  dtClientesBindingSource.Current. = leer.ToString();
                                if (!string.IsNullOrEmpty((leer["APODOCLIEN"]).ToString()))
                                {
                                    ApodoClienteTex.Text = Convert.ToString(leer["APODOCLIEN"]);
                                }
                                if (!string.IsNullOrEmpty((leer["NOMBRECLIE"]).ToString()))
                                {
                                    NombreCliente.Text = Convert.ToString(leer["NOMBRECLIE"]);
                                }
                                if (!string.IsNullOrEmpty((leer["DIRECCIONC"]).ToString()))
                                {
                                    DirecionCliente.Text = Convert.ToString(leer["DIRECCIONC"]);
                                }
                                if (!string.IsNullOrEmpty((leer["TELEFONOCL"]).ToString()))
                                {
                                    TelefonoClienteTextBox.Text = Convert.ToString(leer["TELEFONOCL"]);
                                }
                                if (!string.IsNullOrEmpty((leer["MOVILCLIEN"]).ToString()))
                                {
                                    MovilClienteText.Text = Convert.ToString(leer["MOVILCLIEN"]);
                                }
                                if (!string.IsNullOrEmpty((leer["CORREOCLIE"]).ToString()))
                                {
                                    CorreoClienteText.Text = Convert.ToString(leer["CORREOCLIE"]);
                                }
                                if (!string.IsNullOrEmpty((leer["DNICLIENTE"]).ToString()))
                                {
                                    dniClienteTextBox.Text = Convert.ToString(leer["DNICLIENTE"]);
                                }
                                if (!string.IsNullOrEmpty((leer["LOCALIDADC"]).ToString()))
                                {
                                    LocalidadClienteTxt.Text = Convert.ToString(leer["LOCALIDADC"]);
                                }
                                if (!string.IsNullOrEmpty((leer["CODIGOPOST"]).ToString()))
                                {
                                    codigoPostalClienteTextBox.Text = Convert.ToString(leer["CODIGOPOST"]);
                                }
                                if (!string.IsNullOrEmpty((leer["PAISCLIENT"]).ToString()))
                                {
                                    paisClienteComboBox1.Text = Convert.ToString(leer["PAISCLIENT"]);
                                }
                                if (!string.IsNullOrEmpty((leer["FECHAALTAC"]).ToString()))
                                {
                                    FechaAltaCliente.Text = Convert.ToString(leer["FECHAALTAC"]);
                                }
                                if (!string.IsNullOrEmpty((leer["CALLECLIEN"]).ToString()))
                                {
                                    CalleClienteTextBox.Text = Convert.ToString(leer["CALLECLIEN"]);
                                }
                                if (!string.IsNullOrEmpty((leer["NUMEROCALL"]).ToString()))
                                {
                                    numeroCalleClienteTextBox.Text = Convert.ToString(leer["NUMEROCALL"]);
                                }
                                if (!string.IsNullOrEmpty((leer["PROVINCIAC"]).ToString()))
                                {
                                    provinciaClienteComboBox1.Text = Convert.ToString(leer["PROVINCIAC"]);
                                }
                                if (!string.IsNullOrEmpty((leer["TARIFATIPO"]).ToString()))
                                {
                                    TipoTarifa.Text = Convert.ToString(leer["TARIFATIPO"]);
                                }
                                if (!string.IsNullOrEmpty((leer["TIPODNI"]).ToString()))
                                {
                                    TipoDocumento.Text = Convert.ToString(leer["TIPODNI"]);
                                }
                                if (!string.IsNullOrEmpty((leer["TIPOCLIENT"]).ToString()))
                                {
                                    TipoCliente.Text = Convert.ToString(leer["TIPOCLIENT"]);
                                }
                                if (!string.IsNullOrEmpty((leer["DESCUENTOC"]).ToString()))
                                {
                                    DescuentoCliente.Text = Convert.ToString(leer["DESCUENTOC"]);
                                }
                                if (!string.IsNullOrEmpty((leer["NUMEROCUEN"]).ToString()))
                                {
                                    NUMEROCUENTextBox.Text = Convert.ToString(leer["NUMEROCUEN"]);
                                }
                                if (!string.IsNullOrEmpty((leer["PORTES"]).ToString()))
                                {
                                    PortesTxt.Text = Convert.ToString(leer["PORTES"]);
                                }
                                if (!string.IsNullOrEmpty((leer["BANCOOFICI"]).ToString()))
                                {
                                    bANCOOFICITextBox.Text = Convert.ToString(leer["BANCOOFICI"]);
                                }
                                if (!string.IsNullOrEmpty((leer["BANCOPROVI"]).ToString()))
                                {
                                    BancoProvincia.Text = Convert.ToString(leer["BANCOPROVI"]);
                                }
                                if (!string.IsNullOrEmpty((leer["BANCODIREC"]).ToString()))
                                {
                                    bANCODIRECTextBox.Text = Convert.ToString(leer["BANCODIREC"]);
                                }
                                if (!string.IsNullOrEmpty((leer["BANCOLOCAL"]).ToString()))
                                {
                                    bANCOLOCALTextBox.Text = Convert.ToString(leer["BANCOLOCAL"]);
                                }
                                if (!string.IsNullOrEmpty((leer["BANCOIBAN"]).ToString()))
                                {
                                    bANCOIBANTextBox.Text = Convert.ToString(leer["BANCOIBAN"]);
                                }
                                if (!string.IsNullOrEmpty((leer["BANCOCODIG"]).ToString()))
                                {
                                    bANCOCODIGTextBox.Text = Convert.ToString(leer["BANCOCODIG"]);
                                }
                                if (!string.IsNullOrEmpty((leer["BANCOENTID"]).ToString()))
                                {
                                    bANCOENTIDTextBox.Text = Convert.ToString(leer["BANCOENTID"]);
                                }
                                if (!string.IsNullOrEmpty((leer["BANCOOFIC2"]).ToString()))
                                {
                                    BANCOOFIC2TextBox.Text = Convert.ToString(leer["BANCOOFIC2"]);
                                }
                                if (!string.IsNullOrEmpty((leer["BANCODC"]).ToString()))
                                {
                                    bANCODCTextBox.Text = Convert.ToString(leer["BANCODC"]);
                                }
                                if (!string.IsNullOrEmpty((leer["BANCON_CUE"]).ToString()))
                                {
                                    bANCON_CUETextBox.Text = Convert.ToString(leer["BANCON_CUE"]);
                                }
                                if (!string.IsNullOrEmpty((leer["BAJA"]).ToString()))
                                {
                                    // ApodoClienteTex.Text = Convert.ToBoolean(leer["BAJA"]);
                                }
                                leer.Close();
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Archivo No Se Encuentra", " FALLO AL GUARDAR ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   // this.panelBotonesClientes.Enabled = false;
                }
            }
        }
        private void GuardarClientesDb()
        {
            string DatoCliente = FormMenuPrincipal.menu2principal.InfoClientes.Text;
            string Consulta = "";
            if (this.panelBotonesClientes.Tag.ToString() == "Nuevo")
            {
                Consulta = "INSERT INTO [" + DatoCliente + "] ([Id], [APODOCLIEN], [NOMBRECLIE], [DIRECCIONC], [TELEFONOCL], " +
                "[MOVILCLIEN],[CORREOCLIE], [DNICLIENTE],[LOCALIDADC], [CODIGOPOST], [PAISCLIENT], [CALLECLIEN],[NUMEROCALL]," +
                "[PROVINCIAC], [TARIFATIPO], [TIPODNI], [TIPOCLIENT], [DESCUENTOC], [NUMEROCUEN], [PORTES],[BANCOOFICI], " +
                "[BANCOPROVI], [BANCODIREC], [BANCOLOCAL], [BANCOIBAN],[BANCOCODIG], [BANCOENTID], [BANCOOFIC2], [BANCODC]," +
                " [BANCON_CUE], [BAJA], [FECHAALTAC]) VALUES(@Id, @APODOCLIEN, @NOMBRECLIE, @DIRECCIONC, @TELEFONOCL, @MOVILCLIEN," +
                 " @CORREOCLIE, @DNICLIENTE, @LOCALIDADC, @CODIGOPOST, @PAISCLIENT, @CALLECLIEN,@NUMEROCALL, @PROVINCIAC, @TARIFATIPO, @TIPODNI," +
                 " @TIPOCLIENT, @DESCUENTOC, @NUMEROCUEN, @PORTES,@BANCOOFICI, @BANCOPROVI, @BANCODIREC, @BANCOLOCAL, @BANCOIBAN, @BANCOCODIG," +
                 " @BANCOENTID, @BANCOOFIC2, @BANCODC, @BANCON_CUE, @BAJA, @FECHAALTAC)";
            }
            else
            {
                Consulta = "UPDATE [" + DatoCliente + "]SET [Id]= @Id, [APODOCLIEN] = @APODOCLIEN,[NOMBRECLIE] = @NOMBRECLIE," +
              " [DIRECCIONC] = @DIRECCIONC, [TELEFONOCL] = @TELEFONOCL, [MOVILCLIEN] = @MOVILCLIEN, [CORREOCLIE] = @CORREOCLIE, [DNICLIENTE] = @DNICLIENTE,[LOCALIDADC] = @LOCALIDADC," +
              "[CODIGOPOST] = @CODIGOPOST,[PAISCLIENT] = @PAISCLIENT, [CALLECLIEN] = @CALLECLIEN,[NUMEROCALL]= @NUMEROCALL, [PROVINCIAC] = @PROVINCIAC," +
              " [TARIFATIPO] = @TARIFATIPO, [TIPODNI] = @TIPODNI,[TIPOCLIENT] = @TIPOCLIENT, [DESCUENTOC] = @DESCUENTOC, [NUMEROCUEN] = @NUMEROCUEN, [PORTES] = @PORTES," +
              "[BANCOOFICI] = @BANCOOFICI,[BANCOPROVI] = @BANCOPROVI,[BANCODIREC] = @BANCODIREC,[BANCOLOCAL] = @BANCOLOCAL, [BANCOIBAN] = @BANCOIBAN, [BANCOCODIG] = @BANCOCODIG," +
              " [BANCOENTID] = @BANCOENTID, [BANCOOFIC2] = @BANCOOFIC2, [BANCODC] = @BANCODC, [BANCON_CUE] = @BANCON_CUE,[BAJA] = @BAJA, [FECHAALTAC] = @FECHAALTAC WHERE [Id] = @Id";
            }
            ClsConexionDb NuevaConexion = new ClsConexionDb(Consulta);
            try
            {
                if (NuevaConexion.SiConexionDb)
                {
                    //añadir guaradar a  qui
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@Id", this.Id_Clientes.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@APODOCLIEN", this.ApodoClienteTex.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@NOMBRECLIE", string.IsNullOrEmpty(this.NombreCliente.Text) ? (object)DBNull.Value : this.NombreCliente.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@DIRECCIONC", string.IsNullOrEmpty(this.DirecionCliente.Text) ? (object)DBNull.Value : this.DirecionCliente.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@TELEFONOCL", string.IsNullOrEmpty(this.TelefonoClienteTextBox.Text) ? (object)DBNull.Value : this.TelefonoClienteTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@MOVILCLIEN", string.IsNullOrEmpty(this.MovilClienteText.Text) ? (object)DBNull.Value : this.MovilClienteText.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@CORREOCLIE", string.IsNullOrEmpty(this.CorreoClienteText.Text) ? (object)DBNull.Value : this.CorreoClienteText.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@DNICLIENTE", string.IsNullOrEmpty(this.dniClienteTextBox.Text) ? (object)DBNull.Value : this.dniClienteTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@LOCALIDADC", string.IsNullOrEmpty(this.LocalidadClienteTxt.Text) ? (object)DBNull.Value : this.LocalidadClienteTxt.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@CODIGOPOST", string.IsNullOrEmpty(this.codigoPostalClienteTextBox.Text) ? (object)DBNull.Value : this.codigoPostalClienteTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@PAISCLIENT", string.IsNullOrEmpty(this.paisClienteComboBox1.Text) ? (object)DBNull.Value : this.paisClienteComboBox1.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@CALLECLIEN", string.IsNullOrEmpty(this.CalleClienteTextBox.Text) ? (object)DBNull.Value : this.CalleClienteTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@NUMEROCALL", string.IsNullOrEmpty(this.numeroCalleClienteTextBox.Text) ? (object)DBNull.Value : this.numeroCalleClienteTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@PROVINCIAC", string.IsNullOrEmpty(this.provinciaClienteComboBox1.Text) ? (object)DBNull.Value : this.provinciaClienteComboBox1.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@TARIFATIPO", string.IsNullOrEmpty(this.TipoTarifa.Text) ? (object)DBNull.Value : this.TipoTarifa.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@TIPODNI", string.IsNullOrEmpty(this.TipoDocumento.Text) ? (object)DBNull.Value : this.TipoDocumento.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@TIPOCLIENT", string.IsNullOrEmpty(this.TipoCliente.Text) ? (object)DBNull.Value : this.TipoCliente.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@DESCUENTOC", string.IsNullOrEmpty(this.DescuentoCliente.Text) ? (object)DBNull.Value : this.DescuentoCliente.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@NUMEROCUEN", string.IsNullOrEmpty(this.NUMEROCUENTextBox.Text) ? (object)DBNull.Value : this.NUMEROCUENTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@PORTES", string.IsNullOrEmpty(this.PortesTxt.Text) ? (object)DBNull.Value : this.PortesTxt.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@BANCOOFICI", string.IsNullOrEmpty(this.bANCOOFICITextBox.Text) ? (object)DBNull.Value : this.bANCOOFICITextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@BANCOPROVI", string.IsNullOrEmpty(this.BancoProvincia.Text) ? (object)DBNull.Value : this.BancoProvincia.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@BANCODIREC", string.IsNullOrEmpty(this.bANCODIRECTextBox.Text) ? (object)DBNull.Value : this.bANCODIRECTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@BANCOLOCAL", string.IsNullOrEmpty(this.bANCOLOCALTextBox.Text) ? (object)DBNull.Value : this.bANCOLOCALTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@BANCOIBAN", string.IsNullOrEmpty(this.bANCOIBANTextBox.Text) ? (object)DBNull.Value : this.bANCOIBANTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@BANCOCODIG", string.IsNullOrEmpty(this.bANCOCODIGTextBox.Text) ? (object)DBNull.Value : this.bANCOCODIGTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@BANCOENTID", string.IsNullOrEmpty(this.bANCOENTIDTextBox.Text) ? (object)DBNull.Value : this.bANCOENTIDTextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@BANCOOFIC2", string.IsNullOrEmpty(this.BANCOOFIC2TextBox.Text) ? (object)DBNull.Value : this.BANCOOFIC2TextBox.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@BANCODC", string.IsNullOrEmpty(this.bANCODCTextBox.Text) ? (object)DBNull.Value : this.bANCODCTextBox.Text);
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
            string DatoCliente = FormMenuPrincipal.menu2principal.InfoClientes.Text;
            string Consulta = "";
            if (this.panelBotonesClientes.Tag.ToString() == "Nuevo")
            {
                Consulta = "INSERT INTO [" + DatoCliente + "] ([Id], [APODOCLIEN], [NOMBRECLIE], [DIRECCIONC], [TELEFONOCL], " +
                "[MOVILCLIEN],[CORREOCLIE], [DNICLIENTE],[LOCALIDADC], [CODIGOPOST], [PAISCLIENT], [CALLECLIEN],[NUMEROCALL]," +
                "[PROVINCIAC], [TARIFATIPO], [TIPODNI], [TIPOCLIENT], [DESCUENTOC], [NUMEROCUEN], [PORTES],[BANCOOFICI], " +
                "[BANCOPROVI], [BANCODIREC], [BANCOLOCAL], [BANCOIBAN],[BANCOCODIG], [BANCOENTID], [BANCOOFIC2], [BANCODC]," +
                " [BANCON_CUE], [BAJA], [FECHAALTAC]) VALUES(@IDCLIENTE, @APODOCLIEN, @NOMBRECLIE, @DIRECCIONC, @TELEFONOCL, @MOVILCLIEN," +
                 " @CORREOCLIE, @DNICLIENTE, @LOCALIDADC, @CODIGOPOST, @PAISCLIENT, @CALLECLIEN,@NUMEROCALL, @PROVINCIAC, @TARIFATIPO, @TIPODNI," +
                 " @TIPOCLIENT, @DESCUENTOC, @NUMEROCUEN, @PORTES,@BANCOOFICI, @BANCOPROVI, @BANCODIREC, @BANCOLOCAL, @BANCOIBAN, @BANCOCODIG," +
                 " @BANCOENTID, @BANCOOFIC2, @BANCODC, @BANCON_CUE, @BAJA, @FECHAALTAC)";

            }
            else
            {
                Consulta = "UPDATE [" + DatoCliente + "] SET [Id]= @Id, [APODOCLIEN] = @APODOCLIEN,[NOMBRECLIE] = @NOMBRECLIE," +
              " [DIRECCIONC] = @DIRECCIONC, [TELEFONOCL] = @TELEFONOCL, [MOVILCLIEN] = @MOVILCLIEN, [CORREOCLIE] = @CORREOCLIE, [DNICLIENTE] = @DNICLIENTE,[LOCALIDADC] = @LOCALIDADC," +
              "[CODIGOPOST] = @CODIGOPOST,[PAISCLIENT] = @PAISCLIENT, [CALLECLIEN] = @CALLECLIEN,[NUMEROCALL]= @NUMEROCALL, [PROVINCIAC] = @PROVINCIAC," +
              " [TARIFATIPO] = @TARIFATIPO, [TIPODNI] = @TIPODNI,[TIPOCLIENT] = @TIPOCLIENT, [DESCUENTOC] = @DESCUENTOC, [NUMEROCUEN] = @NUMEROCUEN, [PORTES] = @PORTES," +
              "[BANCOOFICI] = @BANCOOFICI,[BANCOPROVI] = @BANCOPROVI,[BANCODIREC] = @BANCODIREC,[BANCOLOCAL] = @BANCOLOCAL, [BANCOIBAN] = @BANCOIBAN, [BANCOCODIG] = @BANCOCODIG," +
              " [BANCOENTID] = @BANCOENTID, [BANCOOFIC2] = @BANCOOFIC2, [BANCODC] = @BANCODC, [BANCON_CUE] = @BANCON_CUE,[BAJA] = @BAJA, [FECHAALTAC] = @FECHAALTAC WHERE [Id] = @Id";
            }
            ClsConexionSql NuevaConexion = new ClsConexionSql(Consulta);

            try
            {
                if (NuevaConexion.SiConexionSql)
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", this.Id_Clientes.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@APODOCLIEN", this.ApodoClienteTex.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@NOMBRECLIE", string.IsNullOrEmpty(this.NombreCliente.Text) ? (object)DBNull.Value : this.NombreCliente.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@DIRECCIONC", string.IsNullOrEmpty(this.DirecionCliente.Text) ? (object)DBNull.Value : this.DirecionCliente.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@TELEFONOCL", string.IsNullOrEmpty(this.TelefonoClienteTextBox.Text) ? (object)DBNull.Value : this.TelefonoClienteTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@MOVILCLIEN", string.IsNullOrEmpty(this.MovilClienteText.Text) ? (object)DBNull.Value : this.MovilClienteText.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@CORREOCLIE", string.IsNullOrEmpty(this.CorreoClienteText.Text) ? (object)DBNull.Value : this.CorreoClienteText.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@DNICLIENTE", string.IsNullOrEmpty(this.dniClienteTextBox.Text) ? (object)DBNull.Value : this.dniClienteTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@LOCALIDADC", string.IsNullOrEmpty(this.LocalidadClienteTxt.Text) ? (object)DBNull.Value : this.LocalidadClienteTxt.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@CODIGOPOST", string.IsNullOrEmpty(this.codigoPostalClienteTextBox.Text) ? (object)DBNull.Value : this.codigoPostalClienteTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@PAISCLIENT", string.IsNullOrEmpty(this.paisClienteComboBox1.Text) ? (object)DBNull.Value : this.paisClienteComboBox1.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@CALLECLIEN", string.IsNullOrEmpty(this.CalleClienteTextBox.Text) ? (object)DBNull.Value : this.CalleClienteTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@NUMEROCALL", string.IsNullOrEmpty(this.numeroCalleClienteTextBox.Text) ? (object)DBNull.Value : this.numeroCalleClienteTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@PROVINCIAC", string.IsNullOrEmpty(this.provinciaClienteComboBox1.Text) ? (object)DBNull.Value : this.provinciaClienteComboBox1.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@TARIFATIPO", string.IsNullOrEmpty(this.TipoTarifa.Text) ? (object)DBNull.Value : this.TipoTarifa.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@TIPODNI", string.IsNullOrEmpty(this.TipoDocumento.Text) ? (object)DBNull.Value : this.TipoDocumento.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@TIPOCLIENT", string.IsNullOrEmpty(this.TipoCliente.Text) ? (object)DBNull.Value : this.TipoCliente.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@DESCUENTOC", string.IsNullOrEmpty(this.DescuentoCliente.Text) ? (object)DBNull.Value : this.DescuentoCliente.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@NUMEROCUEN", string.IsNullOrEmpty(this.NUMEROCUENTextBox.Text) ? (object)DBNull.Value : this.NUMEROCUENTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@PORTES", string.IsNullOrEmpty(this.PortesTxt.Text) ? (object)DBNull.Value : this.PortesTxt.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@BANCOOFICI", string.IsNullOrEmpty(this.bANCOOFICITextBox.Text) ? (object)DBNull.Value : this.bANCOOFICITextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@BANCOPROVI", string.IsNullOrEmpty(this.BancoProvincia.Text) ? (object)DBNull.Value : this.BancoProvincia.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@BANCODIREC", string.IsNullOrEmpty(this.bANCODIRECTextBox.Text) ? (object)DBNull.Value : this.bANCODIRECTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@BANCOLOCAL", string.IsNullOrEmpty(this.bANCOLOCALTextBox.Text) ? (object)DBNull.Value : this.bANCOLOCALTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@BANCOIBAN", string.IsNullOrEmpty(this.bANCOIBANTextBox.Text) ? (object)DBNull.Value : this.bANCOIBANTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@BANCOCODIG", string.IsNullOrEmpty(this.bANCOCODIGTextBox.Text) ? (object)DBNull.Value : this.bANCOCODIGTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@BANCOENTID", string.IsNullOrEmpty(this.bANCOENTIDTextBox.Text) ? (object)DBNull.Value : this.bANCOENTIDTextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@BANCOOFIC2", string.IsNullOrEmpty(this.BANCOOFIC2TextBox.Text) ? (object)DBNull.Value : this.BANCOOFIC2TextBox.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@BANCODC", string.IsNullOrEmpty(this.bANCODCTextBox.Text) ? (object)DBNull.Value : this.bANCODCTextBox.Text);
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
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION != null)
                {
                    this.dtConfiguracionPrincipalBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfiguracionPrincipal;
                    this.dtTarifaTipoBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtTarifaTipo;
                }
                if (FormMenuPrincipal.menu2principal.dsClientes != null)
                {
                    this.dtClientesBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsClientes;
                }
                if (FormMenuPrincipal.menu2principal.dsMulti2 != null)
                {
                    this.dtPaisesBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2.DtPaises;
                    // this.dtProvinciasBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2.DtProvincias;

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
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal))
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
            if (string.IsNullOrEmpty(Id_Clientes.Text))
            {
                MessageBox.Show("Falta Id ", " ERROR APP ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BORRARerrores();
            //email_bien_escrito();

            if (EspacioDiscosCli(Directory.GetCurrentDirectory(), 10))
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
                                if (fila.Cells[1].Value.ToString() == this.ApodoClienteTex.Text)
                                {
                                    this.ApodoClienteTex.ReadOnly = false;
                                    this.ApodoClienteTex.SelectAll();
                                    this.ApodoClienteTex.Select(4, 4);
                                    MessageBox.Show(this.ApodoClienteTex.Text, "Este Cliente Ya Existe", MessageBoxButtons.OK);
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
                            if (File.Exists(ClasDatos.RutaBaseDatosDb))
                            {
                                GuardarClientesDb();
                            }
                            else
                            {
                                MessageBox.Show("Archivo No Se Encuentra", " FALLO AL GUARDAR ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                this.panelBotonesClientes.Enabled = false;
                            }
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
                    this.Id_Clientes.Text = Convert.ToString(VALORid);
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
                PageCliente2.Focus();
                TipoDocumento.Text = "DNI";
                TipoTarifa.Text = "Pvp1";
                PortesTxt.Text = "Portes Pagados";
               TipoCliente.Text = "Particular";
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
            if (dtClientesBindingSource.Count > 0)
            {
                try
                {
                    if (this.panelBotonesClientes.Tag.ToString() == "Nuevo")
                    {
                        this.dtClientesDataGridView.Rows.RemoveAt(this.dtClientesDataGridView.CurrentCell.RowIndex);
                    }
                    else
                    {
                        CargarCliente();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (string.IsNullOrEmpty(Id_Clientes.Text))
                {
                    MessageBox.Show("Falta Id ", " ERROR APP ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show(" ¿Eliminar Clientes ? ", " ELIMINAR ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (ClsConexionSql.SibaseDatosSql)
                    {
                        try
                        {
                            if (FormMenuPrincipal.menu2principal.InfoClientes.Text != string.Empty)
                            {
                                String TipoTabla = "[" + FormMenuPrincipal.menu2principal.InfoClientes.Text + "]";
                                string consulta = "Delete * from " + TipoTabla + "  WHERE ID= @Id";
                                ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);
                                {
                                    if (NuevaConexion.SiConexionSql)
                                    {
                                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@Id", this.Id_Clientes.Text);
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

                            MessageBox.Show(ex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (File.Exists(ClasDatos.RutaBaseDatosDb))
                        {
                            if (FormMenuPrincipal.menu2principal.InfoClientes.Text != string.Empty)
                            {
                                try
                                {
                                    String TipoTabla = "[" + FormMenuPrincipal.menu2principal.InfoClientes.Text + "]";
                                    string consulta = "Delete * from " + TipoTabla + "  WHERE ID= @Id";
                                    ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
                                    {
                                        if (NuevaConexion.SiConexionDb)
                                        {
                                            NuevaConexion.ComandoDb.Parameters.AddWithValue("@ID", this.Id_Clientes.Text);
                                            NuevaConexion.ComandoDb.ExecuteNonQuery();
                                            this.dtClientesDataGridView.Rows.RemoveAt(this.dtClientesDataGridView.CurrentCell.RowIndex);
                                            this.dtClientesDataGridView.Refresh();
                                            MessageBox.Show("Se Elimino Correctamente", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }

                                    }
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }


                            }
                            MessageBox.Show("Eliminado con exito", "ELIMINAR");
                        }
                        else
                        {
                            MessageBox.Show("Archivo No Se Encuentra", " FALLO AL GUARDAR ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.panelBotonesClientes.Enabled = false;
                        }
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



        private void dtClientesDataGridView_Click(object sender, EventArgs e)
        {
            // dtClientesDataGridView.Enabled = true;
            if (this.panelBotonesClientes.Enabled == false)
            {



            }
        }

        private void nombreClienteTextBox_Click(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.NombreCliente, "");
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
            if (!string.IsNullOrEmpty(this.CorreoClienteText.Text))
            {
                if (!email_bien_escrito())
                {
                    MessageBox.Show("D.n.i No Valido", "INVALIDO");
                    // this.correoClienteTextBox.Focus();
                }

            }


        }

        private void apodoClienteTextBox_Click(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.ApodoClienteTex, "");
        }

        private void direccionClienteTextBox_Click(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.DirecionCliente, "");
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
                    if (fila.Cells[2].Value.ToString() == this.NombreCliente.Text)
                    {
                        this.NombreCliente.ReadOnly = false;
                        this.NombreCliente.SelectAll();
                        this.NombreCliente.Select(4, 4);
                        MessageBox.Show(this.NombreCliente.Text, "Este Cliente Ya Existe", MessageBoxButtons.OK);
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
            ClasValidarDni.ValidarDni(this.dniClienteTextBox.Text);
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
            if (this.DescuentoCliente.Text != string.Empty)
            {
                double Ganancia = Convert.ToDouble(this.DescuentoCliente.Text);
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

        private void dniClienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


