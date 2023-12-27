using pdfforge.PDF;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormImprimirTodo : Form
    {
        public static FormImprimirTodo Menu2Imprimirtodo;
        string Continuar1 = "1";
        string Continuar2 = "1";
        public FormImprimirTodo()
        {
            InitializeComponent();
            FormImprimirTodo.Menu2Imprimirtodo = this;
        }
        private void FormImprimirTodo_Load(object sender, EventArgs e)
        {
            this.Formatoimpresion.Text = "Impresora";
            this.TipoDocumento.Text = "Documento";
            this.MultiFormatoImprimir.Text = "Formato Simple";
            if (ClasDatos.OkFacturar == true)
            {
                if (ClasDatos.NombreFactura == "Albaran")
                {
                    this.MultiFormatoImprimir.Items.Add("Albaran");
                    this.MultiFormatoImprimir.Text = "Albaran";
                    this.MultiFormatoImprimir.Enabled = false;
                }
                if (ClasDatos.NombreFactura == "Nota2")
                {
                    this.MultiFormatoImprimir.Items.Add("Nota 2");
                    this.MultiFormatoImprimir.Text = "Nota 2";
                    this.MultiFormatoImprimir.Enabled = false;
                }
                this.tabPageControlArticulos.Parent = null;
            }
            if (ClasDatos.OkFacturar == false)
            {
                if (ClasDatos.QUEform == "Articulos")
                {
                    this.GroupValores.Visible = false;
                    // tabPageControlFacturar.Parent = null;
                }
            }


        }
        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font titleFont = new Font("Cuerpo negro", 11, System.Drawing.FontStyle.Bold);//Fuente del título           
            Font fntTxt = new Font("Song Ti", 10, System.Drawing.FontStyle.Regular);//Cuerpo de texto         
            Font fntTxt1 = new Font("Song Ti", 8, System.Drawing.FontStyle.Regular);//Cuerpo de texto           
            System.Drawing.Brush brush = new SolidBrush(System.Drawing.Color.Black);//Cepillo de pintura           
            System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.Black);           //Color de linea   
            Font prFont = new Font("Arial", 24, FontStyle.Bold);
            Single xPos = e.MarginBounds.Left; // imprimimos la cadena en el margen izquierdo          
            Single yPos = prFont.GetHeight(e.Graphics); // la posición superior
            e.Graphics.FillRectangle(Brushes.Transparent, new System.Drawing.Rectangle(100, 150, 600, 600));
            e.Graphics.DrawString(FormFacturar.menu2FACTURAR.nombreTextBox.Text, prFont, Brushes.Black, xPos, yPos);
            e.Graphics.DrawString(FormFacturar.menu2FACTURAR.direccionTextBox.Text, prFont, Brushes.Black, xPos, yPos + yPos);
            e.Graphics.DrawString(FormFacturar.menu2FACTURAR.apodoTextBox.Text, prFont, Brushes.Black, xPos, yPos);
            e.Graphics.DrawString("Colegio de Técnicos Automotrices de Beijing", titleFont, brush, new System.Drawing.Point(20, 10));
            e.Graphics.DrawString("Número de activo:", fntTxt, brush, new System.Drawing.Point(20, 31));
            e.Graphics.DrawString("123456789123465", fntTxt, brush, new System.Drawing.Point(80, 31));
            e.Graphics.DrawString("Número de serie del activo:", fntTxt, brush, new System.Drawing.Point(20, 46));
            e.Graphics.DrawString("123456789131321", fntTxt, brush, new System.Drawing.Point(80, 46));
            e.HasMorePages = false;
        }

        private void BtnSalirImprimirTodo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnImprimirTodo_Click(object sender, EventArgs e)
        {
            string NombreArchivo = "";
            string ContraseñaPdf = "PAIS";
            
          
            PrintDocument pd = new PrintDocument();
            if (ClasDatos.OkFacturar == true)
            {
                if (FormFacturar.menu2FACTURAR.apodoTextBox.Text != string.Empty)
                {
                    ContraseñaPdf = FormFacturar.menu2FACTURAR.apodoTextBox.Text;
                }
                NombreArchivo = FormFacturar.menu2FACTURAR.nombreTextBox.Text + " (" + FormFacturar.menu2FACTURAR.apodoTextBox.Text + ") " + FormFacturar.menu2FACTURAR.direccionTextBox.Text + " Nº " + FormFacturar.menu2FACTURAR.NumeroFactura.Text;
                if (MultiFormatoImprimir.SelectedIndex == 0)
                {
                    pd.PrintPage += new PrintPageEventHandler(printNotaFull_PrintPage);
                }
                if (MultiFormatoImprimir.SelectedIndex == 1)
                {
                    pd.PrintPage += new PrintPageEventHandler(printNotaFull_PrintPage);
                }
                if (MultiFormatoImprimir.SelectedIndex == 2)
                {
                    pd.PrintPage += new PrintPageEventHandler(printNota2Full_PrintPage);
                }
                if (MultiFormatoImprimir.Text == "Albaran")
                {
                    pd.PrintPage += new PrintPageEventHandler(printPresupuestoFull_PrintPage);
                }

            }
            if (ClasDatos.OkFacturar == false)
            {

                if (ClasDatos.QUEform == "Articulos")
                {
                    pd.PrintPage += new PrintPageEventHandler(printArticulosFull_PrintPage);
                    NombreArchivo = "Lista De Articulos";
                }
                if (ClasDatos.QUEform == "Clientes")
                {
                    pd.PrintPage += new PrintPageEventHandler(printClientesFull_PrintPage);
                    NombreArchivo = "Lista De Clientes";
                }
            }
            if (this.TipoDocumento.SelectedIndex == 0)
            {

                if (this.Formatoimpresion.SelectedIndex == 0)
                {

                    DialogResult result = this.printDialog1.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        // object[] results = new object[]{
                        //  pageSetupDialog1.PageSettings.Margins,
                        // pageSetupDialog1.PageSettings.PaperSize,
                        //pageSetupDialog1.PageSettings.Landscape,
                        //  pageSetupDialog1.PrinterSettings.PrinterName,
                        // pageSetupDialog1.PrinterSettings.PrintRange};
                       // pd.PrintPage += new PrintPageEventHandler(PrintDocument1_PrintPage);
                        pd.Print();

                    }
                }
                if (this.Formatoimpresion.SelectedIndex == 1)
                {

                    if (this.Continuar2 == "1")
                    {
                        this.Continuar2 = "2";
                        FormVistaPreliminar frm2 = new FormVistaPreliminar();
                        frm2.FormClosed += (o, args) => this.Continuar2 = "1";
                        frm2.ShowDialog();
                        frm2.BringToFront();

                    }
                }
                if (this.Formatoimpresion.SelectedIndex == 2)
                {
                    string VariableDt = "Archivos Pdf Del Año ";
                    string VariableDtPASS = "Archivos Pdf Encriptados Del Año ";
                    string RutaArchivoSalida = Path.Combine(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + VariableDt + DateTime.Now.Year + "\\" + NombreArchivo);
                    string RutaArchivoSalidaPASS = Path.Combine(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + VariableDt + DateTime.Now.Year + "\\" + NombreArchivo);
                    pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                    pd.PrinterSettings.PrintFileName = RutaArchivoSalidaPASS + ".Pdf";
                    pd.PrinterSettings.PrintToFile = true;
                    pd.Print();
 
                    if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" +VariableDt + DateTime.Now.Year))
                    {
                        DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal);
                        dir.CreateSubdirectory(VariableDt + DateTime.Now.Year);
                    }
                    if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + VariableDtPASS + DateTime.Now.Year))
                    {
                        DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal);
                        dir.CreateSubdirectory(VariableDtPASS + DateTime.Now.Year);
                    }

                    if (ClasDatos.OkFacturar == true)
                    {
                        if (File.Exists(RutaArchivoSalidaPASS + ".Pdf"))
                        {
                            
                            PDF PdfEncriptar = new PDF();
                            PDFEncryptor enc = new PDFEncryptor();
                            enc.AllowAssembly = false;
                            enc.AllowCopy = false;
                            enc.AllowFillIn = false;
                            enc.AllowModifyAnnotations = false;
                            enc.AllowModifyContents = false;
                            enc.AllowPrinting = true;
                            enc.AllowPrintingHighResolution = false;
                            enc.AllowScreenreaders = true;
                            enc.EncryptionMethod = 2;
                            enc.OwnerPassword = "PAISPDF";
                            enc.UserPassword = ContraseñaPdf;
                            //Thread.Sleep(5000); //tiempo de pausa
                            PdfEncriptar.EncryptPDFFile(RutaArchivoSalidaPASS + ".Pdf", RutaArchivoSalida + ".Pdf", ref enc);
                            //File.Delete(Ruta_Y_Archi_Temp + ".Pdf");
                            pd.Dispose();
                        }
                    }

                    if (File.Exists(RutaArchivoSalida+".Pdf"))
                    {
                        MessageBox.Show("Archivo Guardado", "GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No Se Encipto Correctamente", "GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                if (this.Formatoimpresion.SelectedIndex == 3)
                {

                    this.printPreviewDialog1.ShowDialog();
                }
                if (this.Formatoimpresion.SelectedIndex == 4)
                {
                    this.printPreviewDialog1.Document = this.printDocument1;
                    this.printPreviewDialog1.ShowDialog();
                }
                if (this.Formatoimpresion.SelectedIndex == 5)
                {

                }
                if (this.Formatoimpresion.SelectedIndex == 6)
                {
                    //printPreviewDialog1.Document = printDocument1;

                }
                if (this.Formatoimpresion.SelectedIndex == 7)
                {

                    // printPreviewDialog1.ShowDialog();
                }

                if (this.MultiFormatoImprimir.SelectedIndex == 1)
                {
                    if (this.listFormatoImpresiones.SelectedIndex == 1)
                    {
                        FormReporteFactura frm = new FormReporteFactura();
                        if (this.Continuar1 == "1")
                        {
                            this.Continuar1 = "2";
                            frm.FormClosed += (o, args) => this.Continuar1 = "1";
                            frm.Show();
                            frm.BringToFront();

                        }
                    }

                }

            }





        }


        private void Formatoimpresion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Formatoimpresion.SelectedIndex > -1)
            {
                if (this.Formatoimpresion.SelectedIndex == 0)
                {
                    this.BtnImprimirTodo.Text = "Imprimir";
                    this.BtnImprimirTodo.Image = PELOSCALVO.Properties.Resources.IMPRSORA32;
                }
                if (this.Formatoimpresion.SelectedIndex == 1)
                {
                    this.BtnImprimirTodo.Text = "Preliminar";
                    this.BtnImprimirTodo.Image = PELOSCALVO.Properties.Resources.VistaPrevia32;
                }
                if (this.Formatoimpresion.SelectedIndex == 2)
                {
                    this.BtnImprimirTodo.Text = "P.D.F";
                    this.BtnImprimirTodo.Image = PELOSCALVO.Properties.Resources.PDF32;
                }
                if (this.Formatoimpresion.SelectedIndex == 3)
                {
                    this.BtnImprimirTodo.Text = "W.O.R.D";
                    this.BtnImprimirTodo.Image = PELOSCALVO.Properties.Resources.Word32;
                }
                if (this.Formatoimpresion.SelectedIndex == 4)
                {
                    this.BtnImprimirTodo.Text = "H.T.M.L";
                    this.BtnImprimirTodo.Image = PELOSCALVO.Properties.Resources.Html32;
                }
                if (this.Formatoimpresion.SelectedIndex == 5)
                {

                    this.BtnImprimirTodo.Image = PELOSCALVO.Properties.Resources.Excel32;
                }
                if (this.Formatoimpresion.SelectedIndex == 6)
                {
                    this.BtnImprimirTodo.Text = "EXCEL";
                    this.BtnImprimirTodo.Image = PELOSCALVO.Properties.Resources.PowerPoint32;
                }
                if (this.Formatoimpresion.SelectedIndex == 7)
                {
                    this.BtnImprimirTodo.Text = "X.M.L";
                    this.BtnImprimirTodo.Image = PELOSCALVO.Properties.Resources.Xml32;
                }

            }
        }

        private void TipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.TipoDocumento.SelectedIndex > -1)
            {
                if (this.TipoDocumento.SelectedIndex == 2)
                {
                    this.listFormatoImpresiones.Enabled = true;
                    this.MultiFormatoImprimir.Enabled = false;
                }
                else
                {
                    this.listFormatoImpresiones.Enabled = false;
                    this.MultiFormatoImprimir.Enabled = true;
                }
            }

        }

        private void MultiFormatoImprimir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.MultiFormatoImprimir.SelectedIndex > -1)
            {
                if (this.MultiFormatoImprimir.SelectedIndex == 1)
                {
                    this.Formatoimpresion.Text = "Impresora";
                    this.TipoDocumento.Text = "Documento";
                    this.BtnImprimirTodo.Image = PELOSCALVO.Properties.Resources.IMPRSORA32;
                    this.Formatoimpresion.Enabled = false;
                    this.TipoDocumento.Enabled = false;
                    this.listFormatoImpresiones.Enabled = false;
                }
                else
                {
                    this.Formatoimpresion.Enabled = true;
                    this.TipoDocumento.Enabled = true;
                    this.listFormatoImpresiones.Enabled = false;
                    this.listFormatoImpresiones.Enabled = true;
                }
            }
        }

        private void CheckBoxValorado_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxValorado.ThreeState == true)
            {
                this.checkBoxValorado.ThreeState = false;
                this.checkBoxValorado.Text = "Valoraro";
            }
            else
            {
                this.checkBoxValorado.ThreeState = true;
                this.checkBoxValorado.Text = "Sin Valor";
            }
        }

        private void CheckBoxDtsEmpsa_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxDtsEmpsa.ThreeState == true)
            {
                this.checkBoxDtsEmpsa.ThreeState = false;
                this.checkBoxDtsEmpsa.Text = "Oculto";
            }
            else
            {
                this.checkBoxDtsEmpsa.ThreeState = true;
                this.checkBoxDtsEmpsa.Text = "Visible";
            }
        }

        private void CheckBoxLogoEmpsa_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxLogoEmpsa.ThreeState == true)
            {
                this.checkBoxLogoEmpsa.ThreeState = false;
                this.checkBoxLogoEmpsa.Text = "Oculto";
            }
            else
            {
                this.checkBoxLogoEmpsa.ThreeState = true;
                this.checkBoxLogoEmpsa.Text = "Visible";
            }
        }

        private void printNotaFull_PrintPage(object sender, PrintPageEventArgs e)
        {
            PictureBox logo = new PictureBox();
            logo.Image = FormFacturar.menu2FACTURAR.imagenEmpresaPicture2.Image;
            //StringFormat stringFormat = new StringFormat();
            //stringFormat.Alignment = StringAlignment.Center;
            //stringFormat.LineAlignment = StringAlignment.Center;
            //var format = new StringFormat() { Alignment = StringAlignment.Far };
            //var rect = new RectangleF(1,1000,790,870);
            // StringFormat flags = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            StringFormat formato = new StringFormat
            {
                Alignment = StringAlignment.Far,
                LineAlignment = StringAlignment.Near
            };
            int margenIzqu = e.MarginBounds.Left;
            int margenDere = e.MarginBounds.Right;
            int NumeroEmpresa1 = FormFacturar.menu2FACTURAR.EmpresaPrincipal.SelectedIndex;
            string ApodoImpr = "";
            string nombreCliente = "";
            string EmpresaImpri = FormFacturar.menu2FACTURAR.dsCONFIGURACCION.Tables["DtConfiguracionPrincipal"].Rows[NumeroEmpresa1]["EmpresaConfi"].ToString();
            // Bitmap logo1 = PELOSCALVO.Properties.Resources.logo;
            string Empresadire = FormFacturar.menu2FACTURAR.dsCONFIGURACCION.Tables["DtConfiguracionPrincipal"].Rows[NumeroEmpresa1]["DireccionEmpresa"].ToString();
            // Bitmap aa   = con(FormFACTURAR.menu2FACTURAR.dsCONFIGURACCION.Tables["DtConfiguracionPrincipal"].Rows[NumeroEmpresa1]["ImagenEmpresa"].ToString());
            if (FormFacturar.menu2FACTURAR.apodoTextBox.Text != string.Empty)
            {
                ApodoImpr = FormFacturar.menu2FACTURAR.apodoTextBox.Text;
            }
            if (FormFacturar.menu2FACTURAR.nombreTextBox.Text != string.Empty)
            {
                nombreCliente = FormFacturar.menu2FACTURAR.nombreTextBox.Text;
            }
            Font titleFont = new Font("Cuerpo negro", 11, FontStyle.Bold);//Fuente del título           
            Font fntTxt = new Font("Song Ti", 9, FontStyle.Regular);//Cuerpo de texto         
            Font fntTxt1 = new Font("Song Ti", 10, FontStyle.Regular);//Cuerpo de texto
            Font Arial10 = new Font("Arial", 10, FontStyle.Regular);//Cuerpo de texto
            Font ArialNegrita12 = new Font("Arial", 12, FontStyle.Bold);//Cuerpo de texto
            Font ArialNegrita10 = new Font("Arial", 10, FontStyle.Bold);//Cuerpo de texto
            Font BookAntiqua = new Font("Book Antiqua", 12, FontStyle.Regular);//Cuerpo de texto                                           
            Pen pen = new Pen(Color.Black);           //Color de linea   
            Font Arial24 = new Font("Arial", 24, FontStyle.Bold);
            // printDocument1 pd = new PrintDocument1();         
            Single xPos = e.MarginBounds.Left; // imprimimos la cadena en el margen izquierdo
            Single YPosText = e.MarginBounds.Left; // imprimimos la cadena en el margen izquierdo
            Single XposRectang = e.MarginBounds.Left; // imprimimos la cadena en el margen izquierdo                                  
            Single YposRectang = e.MarginBounds.Left; // imprimimos la cadena en el margen izquierdo 
            Single yPos = Arial24.GetHeight(e.Graphics); // la posición superior
            Pen TñLinea = new Pen(Color.Black, 1);
            Pen TñLinea2 = new Pen(Color.Black, 2);
            int saltoAbajo1 = 11;
            int SaltoDetallesAbj = 17;
            int saltoAbajo = 230;
            //e.Graphics.FillRectangle(Brushes.Red, new Rectangle(100, 150, 600, 600));
            if (FormImprimirTodo.Menu2Imprimirtodo.checkBoxDtsEmpsa.ThreeState == true)
            {
                e.Graphics.DrawString(EmpresaImpri, titleFont, Brushes.Black, 600, 15);
                e.Graphics.DrawString(Empresadire, BookAntiqua, Brushes.Black, 680, 25);
            }
            if (FormImprimirTodo.Menu2Imprimirtodo.checkBoxLogoEmpsa.ThreeState == true)
            {
                e.Graphics.DrawImage(logo.Image, 22, 4, 430, 130);
            }
            //e.Graphics.DrawImage(LogoEmpresaImpr, 5, 5, 90, 80);

            e.Graphics.DrawRectangle(TñLinea2, 25, 135, 595, 70);
            e.Graphics.DrawRectangle(TñLinea2, 655, 135, 160, 70);
            e.Graphics.DrawRectangle(TñLinea, 22, 240, 795, 814);
            e.Graphics.DrawRectangle(TñLinea2, 655, 1080, 150, 70);
            e.Graphics.DrawString(nombreCliente + " -- " + ApodoImpr, BookAntiqua, Brushes.Black, margenIzqu - 70, 135);
            e.Graphics.DrawString("Fecha:" + FormFacturar.menu2FACTURAR.FechaFactura.Text, Arial10, Brushes.Black, 658, 135 + saltoAbajo1);
            // e.Graphics.DrawString(FormFACTURAR.menu2FACTURAR.fechaFacturaTextBox.Text, Arial10, Brushes.Black, 740, 90 + saltoAbajo1,formato);
            saltoAbajo1 = saltoAbajo1 + 13;
            e.Graphics.DrawString("Numero:" + FormFacturar.menu2FACTURAR.NumeroFactura.Text, Arial10, Brushes.Black, 658, 141 + saltoAbajo1);
            //e.Graphics.DrawString(FormFACTURAR.menu2FACTURAR.numeroFacturaTextBox.Text, Arial10, Brushes.Black, 740,112 + saltoAbajo1,formato);
            e.Graphics.DrawString(FormFacturar.menu2FACTURAR.direccionTextBox.Text, BookAntiqua, Brushes.Black, margenIzqu - 70, 135 + saltoAbajo1);
            // saltoAbajo1 = saltoAbajo1 + saltoAbajo1;
            int saltoref = 220;
            int iab = 0;
            e.Graphics.DrawString("Referencia", Arial10, Brushes.Black, 32, saltoref);
            e.Graphics.DrawString("Cantidad", Arial10, Brushes.Black, 155, saltoref);
            e.Graphics.DrawString("Descripccion", Arial10, Brushes.Black, 280, saltoref);
            e.Graphics.DrawString("Precio", Arial10, Brushes.Black, 615, saltoref);
            e.Graphics.DrawString("Desc/", Arial10, Brushes.Black, 664, saltoref);
            e.Graphics.DrawString("Iva", Arial10, Brushes.Black, 708, saltoref);
            e.Graphics.DrawString("Importe", Arial10, Brushes.Black, 760, saltoref);
            foreach (DataGridViewRow row in FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView.Rows)
            {
                //Referencia
                e.Graphics.DrawString(row.Cells[0].FormattedValue.ToString(), fntTxt, Brushes.Black, margenIzqu - 76, saltoAbajo + SaltoDetallesAbj);
                // Cantidad
                e.Graphics.DrawString(row.Cells[2].FormattedValue.ToString(), fntTxt, Brushes.Black, 215, SaltoDetallesAbj + saltoAbajo, formato);
                //Descripcion
                e.Graphics.DrawString(row.Cells[3].FormattedValue.ToString(), fntTxt, Brushes.Black, 220, saltoAbajo + SaltoDetallesAbj);
                e.Graphics.DrawString(row.Cells[4].FormattedValue.ToString(), fntTxt, Brushes.Black, 660, SaltoDetallesAbj + saltoAbajo, formato);
                //Descuento
                //rect = new RectangleF(1, SaltoDetallesAbj + 195, 620, 870);
                e.Graphics.DrawString(row.Cells[5].FormattedValue.ToString(), fntTxt, Brushes.Black, 700, SaltoDetallesAbj + saltoAbajo, formato);
                //iva
                e.Graphics.DrawString(row.Cells[6].FormattedValue.ToString(), fntTxt, Brushes.Black, 712, saltoAbajo + SaltoDetallesAbj);

                if (FormImprimirTodo.Menu2Imprimirtodo.checkBoxValorado.ThreeState == false)//Importe
                {
                    e.Graphics.DrawString((row.Cells[7].FormattedValue.ToString()), fntTxt, Brushes.Black, margenDere + 89, saltoAbajo + SaltoDetallesAbj, formato);
                }
                iab = iab + 1;
                SaltoDetallesAbj = SaltoDetallesAbj + 18;
            }
            e.Graphics.DrawString(FormFacturar.menu2FACTURAR.subTotal.Text, ArialNegrita10, Brushes.Black, 795, 1090, formato);
            //rect = new RectangleF(1, 1110, 795, 870);
            e.Graphics.DrawString(FormFacturar.menu2FACTURAR.baseIva.Text, ArialNegrita10, Brushes.Black, 795, 1110, formato);
            // rect = new RectangleF(1, 1130, 795, 870);
            e.Graphics.DrawString(FormFacturar.menu2FACTURAR.TotalFactura1.Text, ArialNegrita10, Brushes.Black, 795, 1130, formato);
            e.Graphics.DrawString("Sub Total", ArialNegrita10, Brushes.Black, 588, 1090);
            e.Graphics.DrawString("Iva", ArialNegrita10, Brushes.Black, 588, 1110);
            e.Graphics.DrawString("Total", ArialNegrita10, Brushes.Black, 588, 1130);
            e.HasMorePages = false;
            String NombreArchivo = FormFacturar.menu2FACTURAR.nombreTextBox.Text + " " + FormFacturar.menu2FACTURAR.direccionTextBox.Text + " Nº " + FormFacturar.menu2FACTURAR.NumeroFactura.Text;
        }

        private void printNota2Full_PrintPage(object sender, PrintPageEventArgs e)
        {
            PaintEventArgs myPaintArgs = new PaintEventArgs(e.Graphics, new Rectangle(new Point(1, 1), this.Size));
            InvokePaint(FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView, myPaintArgs);
            e.HasMorePages = false;
        }

        private void printClientesFull_PrintPage(object sender, PrintPageEventArgs e)
        {
            StringFormat formato = new StringFormat
            {
                Alignment = StringAlignment.Far,
                LineAlignment = StringAlignment.Near
            };
            Font titleFont = new Font("Cuerpo negro", 11, FontStyle.Bold);//Fuente del título           
            Font fntTxt = new Font("Song Ti", 10, FontStyle.Regular);//Cuerpo de texto         
            Font fntTxt1 = new Font("Song Ti", 10, FontStyle.Regular);//Cuerpo de texto
            Font Arial10 = new Font("Arial", 10, FontStyle.Regular);//Cuerpo de texto
            Font ArialNegrita12 = new Font("Arial", 12, FontStyle.Bold);//Cuerpo de texto
            Font ArialNegrita10 = new Font("Arial", 10, FontStyle.Bold);//Cuerpo de texto
            Font BookAntiqua = new Font("Book Antiqua", 12, FontStyle.Regular);//Cuerpo de texto                                                        //
            Brush brush = new SolidBrush(Color.Black);//Cepillo de pintura           
            Pen pen = new Pen(Color.Black);           //Color de linea 
            Pen TñLinea2 = new Pen(Color.Black, 2);
            // e.Graphics.DrawRectangle(TñLinea, 22, 194, 790, 870);
            e.Graphics.DrawString("400.00", ArialNegrita10, Brushes.Black, 750, 200, formato);
            e.Graphics.DrawString("40", ArialNegrita10, Brushes.Black, 750, 220, formato);
            e.Graphics.DrawString("888888.00", ArialNegrita10, Brushes.Black, 750, 240, formato);
            e.Graphics.DrawString("Iva", ArialNegrita10, Brushes.Black, 590, 40);
            e.Graphics.DrawString("Total", ArialNegrita10, Brushes.Black, 590, 60);
            e.HasMorePages = false;
        }

        private void printArticulosFull_PrintPage(object sender, PrintPageEventArgs e)
        {
            int saltoAbajo = 35;
            int SaltoDetallesAbj = 12;
            int i = 0;
            //Font fntTxt1 = new Font("Song Ti", 10, FontStyle.Regular);//Cuerpo de texto
            //Font Arial10 = new Font("Arial", 10, FontStyle.Regular);//Cuerpo de texto
            //Font ArialNegrita12 = new Font("Arial", 12, FontStyle.Bold);//Cuerpo de texto
            //Font BookAntiqua = new Font("Book Antiqua", 12, FontStyle.Regular);//Cuerpo de texto   
            Font ArialNegrita10 = new Font("Arial", 10, FontStyle.Bold);//Cuerpo de texto
            Font titleFont = new Font("Cuerpo negro", 11, FontStyle.Bold);//Fuente del título           
            Font fntTxt = new Font("Song Ti", 10, FontStyle.Regular);//Cuerpo de texto                                                  
            //Brush brush = new SolidBrush(Color.Black);//Cepillo de pintura           
            //Pen pen = new Pen(Color.Black);           //Color de linea 
            StringFormat formato = new StringFormat
            {
                Alignment = StringAlignment.Far,
                LineAlignment = StringAlignment.Near
            };
            e.Graphics.DrawString("Referencia", ArialNegrita10, Brushes.Black, 10, 10);
            e.Graphics.DrawString("Descripccion", ArialNegrita10, Brushes.Black, 200, 10);
            e.Graphics.DrawString("COSTE", ArialNegrita10, Brushes.Black, 590, 10);
            e.Graphics.DrawString("P.V.P", ArialNegrita10, Brushes.Black, 675, 10);
            // e.Graphics.DrawString("P.V.P", ArialNegrita10, Brushes.Black, 610, 10);
            e.Graphics.DrawString("CASTY", ArialNegrita10, Brushes.Black, 700, 10);
            e.Graphics.DrawString("SUAREZ", ArialNegrita10, Brushes.Black, 780, 10);
            e.Graphics.DrawString("BENITO", ArialNegrita10, Brushes.Black, 870, 10);
            e.Graphics.DrawString("VALENTE", ArialNegrita10, Brushes.Black, 970, 10);
            e.Graphics.DrawString("PLUS", ArialNegrita10, Brushes.Black, 1170, 10);
            e.Graphics.DrawString("FAMILIA", ArialNegrita10, Brushes.Black, 1270, 10);
            if (ClasDatos.count >= 40)
            {
                //goto Etiqueta1;
            }
            //foreach(DataRow FILA in FormFACTURAR.menu2FACTURAR.dtDetallesFacturaBindingSource)
            for (i = ClasDatos.count; i <= FormArticulos.menu2Articulos.dtPreciosDataGridView.Rows.Count - 1; i++)
            {
                if (FormArticulos.menu2Articulos.dtPreciosDataGridView.Rows[i].Cells[1].Value != null)
                {
                    e.Graphics.DrawString(FormArticulos.menu2Articulos.dtPreciosDataGridView.Rows[i].Cells[1].Value.ToString(), fntTxt, Brushes.Black, 10, saltoAbajo + SaltoDetallesAbj);

                }
                if (FormArticulos.menu2Articulos.dtPreciosDataGridView.Rows[i].Cells[2].Value != null)
                {
                    e.Graphics.DrawString(FormArticulos.menu2Articulos.dtPreciosDataGridView.Rows[i].Cells[2].Value.ToString(), fntTxt, Brushes.Black, 200, saltoAbajo + SaltoDetallesAbj);

                }
                if (FormImprimirTodo.Menu2Imprimirtodo.checkArticulosCoste.ThreeState == false)
                {
                    if (FormArticulos.menu2Articulos.dtPreciosDataGridView.Rows[i].Cells[3].Value != null)
                    {
                        if (FormArticulos.menu2Articulos.dtPreciosDataGridView.Rows[i].Cells[3].Value != DBNull.Value)
                        {

                            e.Graphics.DrawString(FormArticulos.menu2Articulos.dtPreciosDataGridView.Rows[i].Cells[3].FormattedValue.ToString(), fntTxt, Brushes.Black, 590, saltoAbajo + SaltoDetallesAbj, formato);

                        }
                    }

                }

                e.Graphics.DrawString(FormArticulos.menu2Articulos.dtPreciosDataGridView.Rows[i].Cells[6].FormattedValue.ToString(), fntTxt, Brushes.Black, 700, saltoAbajo + SaltoDetallesAbj, formato);
                if (FormImprimirTodo.Menu2Imprimirtodo.checkPreciosCastyImpri.ThreeState == false)
                {
                    if (FormArticulos.menu2Articulos.dtPreciosDataGridView.Rows[i].Cells[6].Value != null)
                    {
                        if (FormArticulos.menu2Articulos.dtPreciosDataGridView.Rows[i].Cells[6].Value != DBNull.Value)
                        {
                            e.Graphics.DrawString(FormArticulos.menu2Articulos.dtPreciosDataGridView.Rows[i].Cells[6].FormattedValue.ToString(), fntTxt, Brushes.Black, 800, saltoAbajo + SaltoDetallesAbj, formato);
                        }
                    }

                }
                if (FormImprimirTodo.Menu2Imprimirtodo.checkPreciosSuarezImpr.ThreeState == false)
                {
                    e.Graphics.DrawString(FormArticulos.menu2Articulos.dtPreciosDataGridView.Rows[i].Cells[7].FormattedValue.ToString(), fntTxt, Brushes.Black, 900, saltoAbajo + SaltoDetallesAbj, formato);
                }
                if (FormImprimirTodo.Menu2Imprimirtodo.checkPreciosBenitoImpri.ThreeState == false)
                {
                    e.Graphics.DrawString(FormArticulos.menu2Articulos.dtPreciosDataGridView.Rows[i].Cells[8].FormattedValue.ToString(), fntTxt, Brushes.Black, 1000, saltoAbajo + SaltoDetallesAbj, formato);
                }
                if (FormImprimirTodo.Menu2Imprimirtodo.checkPreciosValenteImpri.ThreeState == false)
                {
                    e.Graphics.DrawString(FormArticulos.menu2Articulos.dtPreciosDataGridView.Rows[i].Cells[9].FormattedValue.ToString(), fntTxt, Brushes.Black, 1100, saltoAbajo + SaltoDetallesAbj, formato);
                }
                if (FormImprimirTodo.Menu2Imprimirtodo.checkPreciosValenteImpri.ThreeState == false)
                {
                    e.Graphics.DrawString(FormArticulos.menu2Articulos.dtPreciosDataGridView.Rows[i].Cells[10].FormattedValue.ToString(), fntTxt, Brushes.Black, 1300, saltoAbajo + SaltoDetallesAbj, formato);
                }
                // e.Graphics.DrawString(FormARTICULOS.menu2Articulos.dtPreciosDataGridView.Rows[i].Cells[11].FormattedValue.ToString(), fntTxt, Brushes.Black, 1300, saltoAbajo + SaltoDetallesAbj, formato);

                SaltoDetallesAbj = SaltoDetallesAbj + 20;
            }
            if (FormVistaPreliminar.OkVarios == true)
            {
                FormVistaPreliminar.OkVarios = false;
                e.HasMorePages = false;
                return;
            }

            if (SaltoDetallesAbj >= e.MarginBounds.Bottom || ClasDatos.count <= FormArticulos.menu2Articulos.dtPreciosDataGridView.Rows.Count - 40)
            {
                //if(printDialog1.)
                e.HasMorePages = true;
                ClasDatos.count = ClasDatos.count + 40;

            }
            else
            {
                e.HasMorePages = false;
                ClasDatos.count = 0;
            }
        }

        private void printAlbaranFull_PrintPage(object sender, PrintPageEventArgs e)
        {

        }

        private void printPresupuestoFull_PrintPage(object sender, PrintPageEventArgs e)
        {

        }
    }
}
