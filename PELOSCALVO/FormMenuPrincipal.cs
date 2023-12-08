
using Conexiones;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace PELOSCALVO
{
    public partial class FormMenuPrincipal : Form
    {
        public DataSet dsCorreos = new DataSet("Dscorreos");
        public DataTable DtCorreos = new DataTable("DtCorreos");
        public DataTable DtCorreosCliente = new DataTable("DtCorreosCliente");
        // public BindingSource CorreosBindisource = new BindingSource();
        public static FormMenuPrincipal menu2principal;
        public byte SiOpenFatu = 0;
        public byte SiOpenArti = 0;
        public byte SiOpenClie = 0;
        public byte SiOpenConfi = 0;
        byte SiOpenUser = 0;
        int V1, PX, PV;
        public FormMenuPrincipal()
        {

            this.DtCorreos.Columns.Add("Id",typeof(int));
            this.DtCorreos.Columns.Add("NombreEmpresa",typeof(string));
            this.DtCorreos.Columns.Add("CorreoEletronico", typeof(string));
            this.DtCorreos.Columns.Add("Usuario", typeof(string));
            this.DtCorreos.Columns.Add("Contraseña", typeof(string));
            this.DtCorreos.Columns.Add("smtp", typeof(string));
            this.DtCorreos.Columns.Add("Puerto", typeof(int));
            this.DtCorreos.Columns.Add("Timeof", typeof(int));
            this.dsCorreos.Tables.Add(this.DtCorreos);

            this.DtCorreosCliente.Columns.Add("Id",typeof(int));
            this.DtCorreosCliente.Columns.Add("RazonSocial", typeof(string));
            this.DtCorreosCliente.Columns.Add("EmpresaNombre", typeof(string));
            this.DtCorreosCliente.Columns.Add("Direcion", typeof(string));
            this.DtCorreosCliente.Columns.Add("CorreoEletronico_cli", typeof(string));
            this.dsCorreos.Tables.Add(this.DtCorreosCliente);
            // fila["NombreEmpresa"] = "faf";
            InitializeComponent();
            FormMenuPrincipal.menu2principal = this;
            SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            this.PanelInfo_P.Width = this.PanelInfo_P.Width = 0;
        }
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        public bool EspacioDiscosPrincipal(string nombreDisco, int Espacio)
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
        public void CrearArchivosXml(string ArchivoXml)
        {
            XmlDocument DOC = new XmlDocument();
            XmlElement RAIZ = DOC.CreateElement("a");
            DOC.AppendChild(RAIZ);
            DOC.Save(ArchivoXml);
            MessageBox.Show("Archivo Nuevo Creado"+ "\n" + ArchivoXml.ToString(), "SISTEMA GENERAL");
        }
        private void CrearArchivos_Xml_Principal()
        {
            if (EspacioDiscosPrincipal(ClasDatos.RutaMultidatos, 30))
            {
                try
                {
                    if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal))
                    {
                        DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());
                        dir.CreateSubdirectory(ClasDatos.RutaDatosPrincipal);
                        MessageBox.Show("Sistema Restructurado Con Exito", "SISTEMA GENERAL", MessageBoxButtons.OK);
                    }

                    for (int i = 1; i <= 5; i++)
                    {
                        if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + ClasDatos.RutaDatosPrincipal + " FN" + i))
                        {
                            DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal);
                            dir.CreateSubdirectory(ClasDatos.RutaDatosPrincipal + " FN" + i);
                            MessageBox.Show("Sistema Restructurado Con Exito", "SISTEMA FACTURACION", MessageBoxButtons.OK);
                        }
                    }
 
                    if (File.Exists(ClasDatos.RutaMultidatos))
                    {
                        this.dsMultidatos.ReadXml(ClasDatos.RutaMultidatos);


                    }
                    else
                    {
                        CrearArchivosXml(ClasDatos.RutaMultidatos);
                    }
     
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + "Servidores.Xml"))
                    {
                        this.dsServidor.ReadXml(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + "Servidores.Xml");


                    }
                    else
                    {
                        CrearArchivosXml(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + "Servidores.Xml");

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "SISTEMA ERROR", MessageBoxButtons.OK);

                }
            }
        }
        protected override void WndProc(ref Message m)
        {
            // return;////cambie para provar como fvafdasd dassssssssssssssssssssssss
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (this.sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            this.sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - this.tolerance, this.ClientRectangle.Height - this.tolerance, this.tolerance, this.tolerance);

            region.Exclude(this.sizeGripRectangle);
            this.panelContenedorPrincipal.Region = region;
            Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, this.sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.DarkGoldenrod, this.sizeGripRectangle);
        }


        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            this.V1 = 1;
            this.PX = e.X;
            this.PV = e.Y;

        }

        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.lx = this.Location.X;
            this.ly = this.Location.Y;
            this.sw = this.Size.Width;
            this.sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.btnMaximizar.Visible = false;
            this.btnNormal.Visible = true;

        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(this.sw, this.sh);
            this.Location = new Point(this.lx, this.ly);
            this.btnNormal.Visible = false;
            this.btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (this.SiOpenFatu == 0 & this.SiOpenArti == 0 & this.SiOpenClie == 0 & this.SiOpenConfi == 0)
            {
                if (MessageBox.Show("Cerrar Toda La Aplicacion", "CERRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (this.SiOpenFatu == 0 & this.SiOpenArti == 0 & this.SiOpenClie == 0 & this.SiOpenConfi == 0)
            {
                if (MessageBox.Show("Cerrar Toda La Aplicacion", "CERRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    //  Application.Exit();
                    Close();
                    //  Hide();

                }

            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (this.panelMenu.Width == 230)
            {
                this.tmContraerMenu.Start();
            }
            else if (this.panelMenu.Width == 55)
            {
                this.tmExpandirMenu.Start();
            }


        }

        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            if (this.panelMenu.Width >= 230)
                this.tmExpandirMenu.Stop();
            else
                this.panelMenu.Width = this.panelMenu.Width + 5;

        }

        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            if (this.panelMenu.Width <= 55)
                this.tmContraerMenu.Stop();
            else
                this.panelMenu.Width = this.panelMenu.Width - 5;
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                this.PanelInfo_P.Visible = true;
                this.PanelInfo_P.Width = this.PanelInfo_P.Width = 0;
                CrearArchivos_Xml_Principal();
            }
            catch (Exception)
            {

                // throw;
            }

        }

        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            if (ClsConexionSql.SibaseDatosSql == false)
            {
                if (this.InfoArticulo.Text == string.Empty && this.InfoClientes.Text == string.Empty && this.InfoExtension.Text == string.Empty)
                {
                    MessageBox.Show("Debe Configurar Una Conexion A Archivos", "CONEXION", MessageBoxButtons.OK);
                    return;
                }
            }
            FormClientes frm = new FormClientes();
            if (this.SiOpenClie == 0)
            {

                frm.TopLevel = false;
              //  frm.Dock = DockStyle.Fill;
                this.panelContenedorForm.Controls.Add(frm);
                //frm.FormBorderStyle = FormBorderStyle.None;
                frm.FormClosed += (o, args) => this.SiOpenClie = 0;
                frm.Show();
                frm.BringToFront();
                this.SiOpenClie = 1;
            }
            else
            {
                if (FormClientes.menu2CLIENTES2.WindowState == FormWindowState.Maximized)
                {
                    FormClientes.menu2CLIENTES2.WindowState = FormWindowState.Maximized;
                    FormClientes.menu2CLIENTES2.BringToFront();
                }
            }
        }

        private void btnMembresia_Click(object sender, EventArgs e)
        {
            FormEnviarCorreos frmCorreo = new FormEnviarCorreos();
            frmCorreo.ShowDialog();
        }

        private void btnARTICULOS_Click(object sender, EventArgs e)
        {
            if (ClsConexionSql.SibaseDatosSql == false)
            {
                if (this.InfoArticulo.Text == string.Empty && this.InfoClientes.Text == string.Empty && this.InfoExtension.Text == string.Empty)
                {
                    MessageBox.Show("Debe Configurar Una Conexion A Archivos", "CONEXION", MessageBoxButtons.OK);
                    return;
                }
            }
            if (this.SiOpenArti == 0)
            {
                FormArticulos frm = new FormArticulos();
                frm.TopLevel = false;
                // frm.Dock = DockStyle.Fill;
                frm.WindowState = FormWindowState.Maximized;
              //  frm.Anchor = System.Windows.Forms.AnchorStyles.None;
                this.panelContenedorForm.Controls.Add(frm);
                frm.FormClosed += (o, args) => this.SiOpenArti = 0;
                frm.Show();
                frm.BringToFront();
                this.SiOpenArti = 1;
            }
            else
            {

                if (FormArticulos.menu2Articulos.WindowState == FormWindowState.Maximized)
                {
                    FormArticulos.menu2Articulos.WindowState = FormWindowState.Maximized;
                    FormArticulos.menu2Articulos.BringToFront();
                }
            }
        }

        private void BtnVentas_MouseEnter(object sender, EventArgs e)
        {
            this.panelventas.Visible = true;
            this.panelventas.BringToFront();

        }

        private void btnMembresia_MouseEnter(object sender, EventArgs e)
        {
            this.panelventas.Visible = false;
            this.panelSUBventas.Visible = false;
        }

        private void btnUsuarios_MouseEnter(object sender, EventArgs e)
        {
            this.panelventas.Visible = false;
            this.panelSUBventas.Visible = false;
        }

        private void btnConfiguracion_MouseEnter(object sender, EventArgs e)
        {
            this.panelventas.Visible = false;
            this.panelSUBventas.Visible = false;

        }

        private void panelContenedorForm_MouseEnter(object sender, EventArgs e)
        {
            this.panelventas.Visible = false;
            this.panelSUBventas.Visible = false;
        }

        private void btnCrearFactura_Click(object sender, EventArgs e)
        {
            if (ClsConexionSql.SibaseDatosSql == false)
            {
                if (this.InfoArticulo.Text == string.Empty && this.InfoClientes.Text == string.Empty && this.InfoExtension.Text == string.Empty)
                {
                    MessageBox.Show("Debe Configurar Una Conexion A Archivos", "CONEXION", MessageBoxButtons.OK);
                    return;
                }
            }
            ClasDatos.NombreFactura = "Factura";
            ClasDatos.RutaFactura = ClasDatos.RutaDatosPrincipal + " FN5";
            FormFacturar frm = new FormFacturar();
            if (this.SiOpenFatu == 0)
            {
                this.panelMenu.Width = this.panelMenu.Width = 55;
                this.panel1.Height = this.panel1.Height = 0;
                frm.TopLevel = false;
              //  frm.Dock = DockStyle.Fill;
                this.panelContenedorForm.Controls.Add(frm);
                frm.FormClosed += (o, args) => this.SiOpenFatu = 0;
                frm.FormClosed += (o, args) => this.panel1.Height = this.panel1.Height = 25;
                frm.FormClosed += (o, args) => this.panelMenu.Width = this.panelMenu.Width = 230;
                frm.Show();
                frm.BringToFront();
                this.SiOpenFatu = 1;
            }
            else
            {
                // FormFACTURAR frm = new FormFACTURAR();
                frm.BringToFront();
                frm.WindowState = FormWindowState.Maximized;
            }
        }

        private void BtnCompras_MouseEnter(object sender, EventArgs e)
        {
            this.panelventas.Visible = false;
            this.panelSUBventas.Visible = false;
        }

        private void btnARTICULOS_MouseEnter(object sender, EventArgs e)
        {
            // panelventas.Visible = false;
            // panelSUBventas.Visible = false;
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {

            if (this.SiOpenConfi == 0)
            {
                FormComfiguracion frm = new FormComfiguracion();
                frm.TopLevel = false;
               // frm.Dock = DockStyle.Fill;
                this.panelContenedorForm.Controls.Add(frm);
                //frm.FormBorderStyle = FormBorderStyle.None;
                frm.FormClosed += (o, args) => this.SiOpenFatu = 0;
                frm.Show();
                frm.BringToFront();
                this.SiOpenFatu = 1;
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

            if (this.SiOpenUser == 0)
            {
                FormArticulos frm = new FormArticulos();
                frm.TopLevel = false;
              //  frm.Dock = DockStyle.Fill;
                this.panelContenedorForm.Controls.Add(frm);
                frm.FormClosed += (o, args) => this.SiOpenUser = 0;
                frm.Show();
                frm.BringToFront();
                this.SiOpenUser = 1;
            }
        }



        private void BtnCrearNotas_Click(object sender, EventArgs e)
        {
            if (ClsConexionSql.SibaseDatosSql == false)
            {
                if (this.InfoArticulo.Text == string.Empty && this.InfoClientes.Text == string.Empty && this.InfoExtension.Text == string.Empty)
                {
                    MessageBox.Show("Debe Configurar Una Conexion A Archivos", "CONEXION", MessageBoxButtons.OK);
                    return;
                }
            }
            if (this.SiOpenFatu == 0)
            {
                ClasDatos.RutaFactura = ClasDatos.RutaDatosPrincipal + " FN1";
                ClasDatos.NombreFactura = "Nota";
                FormFacturar frm = new FormFacturar();
                this.panelMenu.Width = this.panelMenu.Width = 55;
                this.panel1.Height = this.panel1.Height = 0;
                frm.TopLevel = false;
               // frm.Dock = DockStyle.Fill;
                this.panelContenedorForm.Controls.Add(frm);
                frm.FormClosed += (o, args) => this.SiOpenFatu = 0;
                frm.FormClosed += (o, args) => this.panel1.Height = this.panel1.Height = 25;
                frm.FormClosed += (o, args) => this.panelMenu.Width = this.panelMenu.Width = 230;
                frm.Show();
                frm.BringToFront();
                this.SiOpenFatu = 1;
            }
            else
            {
                if (FormFacturar.menu2FACTURAR.WindowState == FormWindowState.Maximized)
                {
                    FormFacturar.menu2FACTURAR.WindowState = FormWindowState.Maximized;
                    FormFacturar.menu2FACTURAR.BringToFront();
                }

            }
        }

        private void BtnCrearPresupustos_Click(object sender, EventArgs e)
        {
            if (ClsConexionSql.SibaseDatosSql == false)
            {
                if (this.InfoArticulo.Text == string.Empty && this.InfoClientes.Text == string.Empty && this.InfoExtension.Text == string.Empty)
                {
                    MessageBox.Show("Debe Configurar Una Conexion A Archivos", "CONEXION", MessageBoxButtons.OK);
                    return;
                }
            }
            if (this.SiOpenFatu == 0)
            {
                ClasDatos.NombreFactura = "Presupuesto";
                ClasDatos.RutaFactura = ClasDatos.RutaDatosPrincipal + " FN4";
                FormFacturar frm = new FormFacturar();
                this.panelMenu.Width = this.panelMenu.Width = 55;
                this.panel1.Height = this.panel1.Height = 0;
                frm.TopLevel = false;
               // frm.Dock = DockStyle.Fill;
                this.panelContenedorForm.Controls.Add(frm);
                frm.FormClosed += (o, args) => this.SiOpenFatu = 0;
                frm.FormClosed += (o, args) => this.panel1.Height = this.panel1.Height = 25;
                frm.FormClosed += (o, args) => this.panelMenu.Width = this.panelMenu.Width = 230;
                frm.Show();
                frm.BringToFront();
                this.SiOpenFatu = 1;

            }
        }

        private void BtnCrearNotas2_Click(object sender, EventArgs e)
        {
            if (ClsConexionSql.SibaseDatosSql == false)
            {
                if (this.InfoArticulo.Text == string.Empty && this.InfoClientes.Text == string.Empty && this.InfoExtension.Text == string.Empty)
                {
                    MessageBox.Show("Debe Configurar Una Conexion A Archivos", "CONEXION", MessageBoxButtons.OK);
                    return;
                }
            }
            if (this.SiOpenFatu == 0)
            {
                ClasDatos.NombreFactura = "Nota2";
                ClasDatos.RutaFactura = ClasDatos.RutaDatosPrincipal + " FN2";
                FormFacturar frm = new FormFacturar();
                this.panelMenu.Width = this.panelMenu.Width = 55;
                this.panel1.Height = this.panel1.Height = 0;
                frm.TopLevel = false;
               // frm.Dock = DockStyle.Fill;
                this.panelContenedorForm.Controls.Add(frm);
                frm.FormClosed += (o, args) => this.SiOpenFatu = 0;
                frm.FormClosed += (o, args) => this.panel1.Height = this.panel1.Height = 25;
                frm.FormClosed += (o, args) => this.panelMenu.Width = this.panelMenu.Width = 230;
                frm.Show();
                frm.BringToFront();
                this.SiOpenFatu = 1;

            }
        }

        private void BtnCrearAlbaranes_Click(object sender, EventArgs e)
        {
            if (ClsConexionSql.SibaseDatosSql == false)
            {
                if (this.InfoArticulo.Text == string.Empty && this.InfoClientes.Text == string.Empty && this.InfoExtension.Text == string.Empty)
                {
                    MessageBox.Show("Debe Configurar Una Conexion A Archivos", "CONEXION", MessageBoxButtons.OK);
                    return;
                }
            }
            if (this.SiOpenFatu == 0)
            {
                ClasDatos.NombreFactura = "Albaran";
                ClasDatos.RutaFactura = ClasDatos.RutaDatosPrincipal + " FN3";
                FormFacturar frm = new FormFacturar();
                this.panelMenu.Width = this.panelMenu.Width = 55;
                this.panel1.Height = this.panel1.Height = 0;
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                // this.panelContenedorForm.Controls.Add(frm);
                this.panelContenedorForm.Parent = frm;
                frm.FormClosed += (o, args) => this.SiOpenFatu = 0;
                frm.FormClosed += (o, args) => this.panel1.Height = this.panel1.Height = 25;
                frm.FormClosed += (o, args) => this.panelMenu.Width = this.panelMenu.Width = 230;
                frm.Show();
                frm.BringToFront();
                this.SiOpenFatu = 1;

            }
        }

        private void BtnCalculadora_Click_1(object sender, EventArgs e)
        {

            this.panelAplicaciones.Visible = false;
            this.panelAplicaciones.Tag = "stop";
            System.Diagnostics.Process.Start("Calc");
        }


        private void BtnCarpeteDatos_Click(object sender, EventArgs e)
        {
            this.panelAplicaciones.Visible = false;
            System.Diagnostics.Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\" + "Datos");
        }


        private void Logo2_MouseEnter(object sender, EventArgs e)
        {
            if (this.panelAplicaciones.Visible == false)
            {
                this.panelContenedorForm.Tag = "SEGUIR";
                this.panelAplicaciones.Visible = true;
            }
            else
            {
                this.panelAplicaciones.Visible = false;
            }
        }



        private void PanelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (Cursor.Position.Y >= 39)
            {
                this.panelAplicaciones.Visible = false;
            }

            if (this.V1 == 1)
            {
                SetDesktopLocation(MousePosition.X - this.PX, MousePosition.Y - this.PV);
            }
        }

        private void PanelBarraTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            this.V1 = 0;
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            if (ClsConexionSql.SibaseDatosSql == false)
            {
                if (this.InfoArticulo.Text == string.Empty && this.InfoClientes.Text == string.Empty && this.InfoExtension.Text == string.Empty)
                {
                    MessageBox.Show("Debe Configurar Una Conexion A Archivos", "CONEXION", MessageBoxButtons.OK);
                    return;
                }
            }
            PanelAcesosDire.Width = panelContenedorForm.Width;
            PanelAcesosDire.Height = panelContenedorForm.Height;
            if (BtnInfo.Tag.ToString() == "SI")
            {
                PanelAcesosDire.BringToFront();
                BtnInfo.Tag = "NO";
                PanelAcesosDire.Visible = true;
      
              
            }
            else
            {
                BtnInfo.Tag = "SI";
                PanelAcesosDire.Visible = false;
            }

        }

        private void TimerCerrarPanel_Tick(object sender, EventArgs e)
        {
            try
            {
                
                if (this.PanelInfo_P.Tag.ToString() == "ABRIR")
                {
             
                    if (this.PanelInfo_P.Width >= 864)
                    {
                        this.PanelInfo_P.Tag = "CERRAR";
                        this.TimerCerrarPanel.Stop();
                    }
                    else
                    {
                        this.PanelInfo_P.Width = this.PanelInfo_P.Width + 5;
                    }

                }
                else
                {
                    if (this.PanelInfo_P.Width <= 0)
                    {
                        this.TimerCerrarPanel.Stop();
                        this.PanelInfo_P.Tag = "ABRIR";
                    }
                    else
                    {
                        this.PanelInfo_P.Width = this.PanelInfo_P.Width - 5;
                    }
                }
            }
            catch (Exception)
            {

                // throw;
            }




        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FormBienvenida formulario = new FormBienvenida();
            formulario.Show();
        }

        private void BtnAbrirChrome_Click(object sender, EventArgs e)
        {
            try
            {
                panelAplicaciones.Visible = false;
                Process.Start("https://www.google.es/");
            }
            catch (Exception)
            {


            }
        }

        private void panelContenedorForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMenuPrincipal_MouseEnter(object sender, EventArgs e)
        {
            FormBienvenida.menu2.Close();
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PanelAcesosDire.Visible = false;
            FormEmpresas frm = new FormEmpresas();
            frm.TopLevel = false;
            // frm.Dock = DockStyle.Fill;
           // frm.WindowState = FormWindowState.Maximized;
            //frm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContenedorForm.Controls.Add(frm);
            frm.FormClosed += (o, args) => this.SiOpenArti = 0;
            frm.Show();
            frm.BringToFront();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProveedores frm = new FormProveedores();
            frm.TopLevel = false;
            this.panelContenedorForm.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
         
        }

        private void crearEjercioNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEjercicios frm = new FormEjercicios();
            frm.TopLevel = false;
            this.panelContenedorForm.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void BtnArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                this.PanelInfo_P.BringToFront();
                if (this.PanelInfo_P.Tag.ToString() == "ABRIR")
                {
                    this.ContadorFactu.Text = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfiguracionPrincipal.Count.ToString();
                    this.ContadorArticulos.Text = FormMenuPrincipal.menu2principal.articulos.DtArticulos.Count.ToString();
                    this.ContadorClientes.Text = FormMenuPrincipal.menu2principal.dsClientes.DtClientes.Count.ToString();                
                                   
                }
                this.TimerCerrarPanel.Start();
            }
            catch (Exception)
            {

                // throw;
            }
     
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlmacenes frm = new FormAlmacenes();
            frm.TopLevel = false;
            //frm.WindowState = FormWindowState.Maximized;
            this.panelContenedorForm.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void familiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFamiliaProductos frm = new FormFamiliaProductos();
            frm.TopLevel = false;
            this.panelContenedorForm.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void PanelInfo_P_MouseLeave(object sender, EventArgs e)
        {
            try
            {

                if (this.PanelInfo_P.Tag.ToString() == "ABRIR")
                {
                    this.ContadorFactu.Text = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfiguracionPrincipal.Count.ToString();
                    this.ContadorArticulos.Text = FormMenuPrincipal.menu2principal.articulos.DtArticulos.Count.ToString();
                    this.ContadorClientes.Text = FormMenuPrincipal.menu2principal.dsClientes.DtClientes.Count.ToString();
                    this.PanelInfo_P.Visible = true;
                    this.TimerCerrarPanel.Start();
                    this.PanelInfo_P.Tag = "CERRAR";
                }
                else
                {
                    this.PanelInfo_P.Tag = "ABRIR";
                }
            }
            catch (Exception)
            {

                // throw;
            }


        }

        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPaises frm = new FormPaises();
            frm.TopLevel = false;
            frm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContenedorForm.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void provinciasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormProvincias frm = new FormProvincias();
            frm.TopLevel = false;
            frm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContenedorForm.Controls.Add(frm);
            frm.Show();
            // frm.WindowState = FormWindowState.Maximized;
            frm.BringToFront();
        }

        private void AbrirObras_Click(object sender, EventArgs e)
        {
            FormObras frm = new FormObras();
            frm.TopLevel = false;
            this.panelContenedorForm.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void toolFamilia_Click(object sender, EventArgs e)
        {

        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void editarDescuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDescuentos frm = new FormDescuentos();
            frm.TopLevel = false;
            this.panelContenedorForm.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void almacenesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void PanelAcesosDire_MouseEnter(object sender, EventArgs e)
        {
            this.panelventas.Visible = false;
            this.panelSUBventas.Visible = false;
        }

        private void toolEmpresas_Click(object sender, EventArgs e)
        {

        }

        private void correosEletronicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCrearCorreos frm = new FormCrearCorreos();
            frm.TopLevel = false;
            this.panelContenedorForm.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void datosDeInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDatoInicio frm = new FormDatoInicio();
            frm.TopLevel = false;
            this.panelContenedorForm.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void BtnSql_Click(object sender, EventArgs e)
        {
 
            if (this.SiOpenFatu == 0 & this.SiOpenArti == 0 & this.SiOpenClie == 0 & this.SiOpenConfi == 0)
            {
                panelAplicaciones.Visible = false;
                FormBaseDatos frm = new FormBaseDatos();
                frm.ShowDialog();
                frm.BringToFront();

            }

        }

        private void BtnCarpetasPdf_Click(object sender, EventArgs e)
        {
            this.panelAplicaciones.Visible = false;
            string VariableDt = "Archivos Pdf Del Año ";
            if (Directory.Exists(Directory.GetCurrentDirectory() + "\\" + "Datos" + "\\" + VariableDt + DateTime.Now.Year))
            {
                System.Diagnostics.Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\" + "Datos" + "\\" + VariableDt + DateTime.Now.Year);
            }
            else
            {
                System.Diagnostics.Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            }

        }

        private void BtnFacturar_MouseEnter(object sender, EventArgs e)
        {
            if (this.panelSUBventas.Visible == false)
            {
                this.panelSUBventas.Visible = true;
                this.panelSUBventas.BringToFront();
            }
            else
            {
                this.panelSUBventas.Visible = false;

            }
        }

        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            if (this.panelContenedorForm.Tag.ToString() == "SEGUIR")
            {
                this.lbFecha.Text = DateTime.Now.ToLongDateString();
                this.lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
            }

            //brea;
        }

    }
}
