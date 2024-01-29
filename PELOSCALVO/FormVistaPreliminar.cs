using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PELOSCALVO
{
    public partial class FormVistaPreliminar : Form
    {
        public static bool OkVarios = false;
        public static FormVistaPreliminar menu2VistaPreliminar;
        public FormVistaPreliminar()
        {
            InitializeComponent();
            FormVistaPreliminar.menu2VistaPreliminar = this;
            // FormVistaPreliminar.OkVarios = OkVarios;
        }


        private void printNota_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            printPreviewControl1.ResetText();
            printPreviewControl1.Refresh();
            PictureBox logo = new PictureBox();
            logo.Image= FormFacturar.menu2FACTURAR.imagenEmpresaPicture2.Image;
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
            string EmpresaImpri = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtConfiguracionPrincipal"].Rows[NumeroEmpresa1]["EmpresaConfi"].ToString();
            // Bitmap logo1 = PELOSCALVO.Properties.Resources.logo;
            string Empresadire = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtConfiguracionPrincipal"].Rows[NumeroEmpresa1]["DireccionEmpresa"].ToString();
            // Bitmap aa   = con(FormFACTURAR.menu2FACTURAR.dsCONFIGURACCION.Tables["DtConfiguracionPrincipal"].Rows[NumeroEmpresa1]["ImagenEmpresa"].ToString());
            if (FormFacturar.menu2FACTURAR.RazonSocialFatu.Text != string.Empty)
            {
                ApodoImpr = FormFacturar.menu2FACTURAR.RazonSocialFatu.Text;
            }
            if (FormFacturar.menu2FACTURAR.NombreClienteFatu.Text != string.Empty)
            {
                nombreCliente = FormFacturar.menu2FACTURAR.NombreClienteFatu.Text;
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
            e.Graphics.DrawString(FormFacturar.menu2FACTURAR.DirecionClienteFatu.Text, BookAntiqua, Brushes.Black, margenIzqu - 70, 135 + saltoAbajo1);
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
            String NombreArchivo = FormFacturar.menu2FACTURAR.NombreClienteFatu.Text + " " + FormFacturar.menu2FACTURAR.DirecionClienteFatu.Text + " Nº " + FormFacturar.menu2FACTURAR.NumeroFactura.Text;
            //printNota.PrinterSettings.PrintFileName = "c:\\"+NombreArchivo +".Pdf";
            printPreviewControl1.Document.DocumentName = "c:\\" + NombreArchivo + ".Pdf";

        }


        private void FormVistaPreliminar_Load(object sender, EventArgs e)
        {

            printPreviewControl1.ResetText();
            if (ClasDatos.OkFacturar == true)
            {
                if (FormImprimirTodo.Menu2Imprimirtodo.MultiFormatoImprimir.SelectedIndex == 0)
                {
                    printPreviewControl1.Document = printNotaSimple;
                }
                if (FormImprimirTodo.Menu2Imprimirtodo.MultiFormatoImprimir.SelectedIndex ==1)
                {
                    printPreviewControl1.Document = printNota2;
                }
                if (FormImprimirTodo.Menu2Imprimirtodo.MultiFormatoImprimir.SelectedIndex == 2)
                {
                    printPreviewControl1.Document = printNota;
                }
                if (FormImprimirTodo.Menu2Imprimirtodo.MultiFormatoImprimir.Text == "Albaranes")
                {
                    printPreviewControl1.Document = printAlbaran;
                }

            }
            if (ClasDatos.OkFacturar == false)
            {

                if (ClasDatos.QUEform == "Articulos")
                {
                    printPreviewControl1.Dock = DockStyle.None;
                    this.Size = new Size(1200, 696);
                    printPreviewControl1.Document = printArticulos;
                    printArticulos.DefaultPageSettings.Landscape = true;
                    printPreviewControl1.Document.DefaultPageSettings.Landscape = true;
                    ClasDatos.count = 0;

                }
                if (ClasDatos.QUEform == "Clientes")
                {
                    //printPreviewControl1.Dock = DockStyle.None;
                    this.Size = new Size(1200, 696);
                    printClientes.DefaultPageSettings.Landscape = true;
                    printPreviewControl1.Document.DefaultPageSettings.Landscape = true;
                    printPreviewControl1.Document = printClientes;

                }
            }
            /// DtConfiguracionPrincipalBindingSource.DataSource = (FormFACTURAR.menu2FACTURAR.dtConfiguracionPrincipalBindingSource.Current);
        }


        private void BtnImprimirVistaPre_Click(object sender, EventArgs e)
        {
            String NombreArchivo = "";
            PrintDocument pd = new PrintDocument();
            if (ClasDatos.OkFacturar == true)
            {
                NombreArchivo = FormFacturar.menu2FACTURAR.NombreClienteFatu.Text + " " + FormFacturar.menu2FACTURAR.DirecionClienteFatu.Text + " Nº " + FormFacturar.menu2FACTURAR.NumeroFactura.Text;
                pd.PrintPage += new PrintPageEventHandler(printNota_PrintPage);
                pd.PrinterSettings.PrintFileName = "c:\\" + NombreArchivo + ".Pdf";
                printNota.DocumentName = NombreArchivo + ".Pdf";
            }
            if (ClasDatos.OkFacturar == false)
            {

                if (ClasDatos.QUEform == "Articulos")
                {
                    NombreArchivo = "Lista De Precios";
                    pd.PrintPage += new PrintPageEventHandler(printArticulos_PrintPage);
                }
                if (ClasDatos.QUEform == "Clientes")
                {
                    NombreArchivo = "Lista De Clientes";
                    pd.PrintPage += new PrintPageEventHandler(printClientes_PrintPage);
                }

                //printDialog1.Document.DocumentName = "aa" + ".Pdf";
                pd.PrinterSettings.PrintFileName = "c:\\" + NombreArchivo + ".Pdf";
                printNota.DocumentName = NombreArchivo + ".Pdf";
                // pd.PrinterSettings.DefaultPageSettings.Landscape = true;
            }

            DialogResult result = printDialog1.ShowDialog();
            pd.DocumentName = NombreArchivo + ".Pdf";
            pd.PrinterSettings.PrintFileName = "c:\\";
            if (result == DialogResult.OK)
            {
                FormVistaPreliminar.OkVarios = false;
                pd.PrinterSettings.DefaultPageSettings.Landscape = true;
                pd.Print();
            }
            else
            {
                FormVistaPreliminar.OkVarios = true;
            }
        }

        private void FormVistaPreliminar_FormClosed(object sender, FormClosedEventArgs e)
        {
            printPreviewControl1.ResetText();
        }

        private void printArticulos_PrintPage(object sender, PrintPageEventArgs e)
        {
            int saltoAbajo = 35;
            int SaltoDetallesAbj = 12;
            int i = 0;
            int AB = 0;
            //Font fntTxt1 = new Font("Song Ti", 10, FontStyle.Regular);//Cuerpo de texto
            //Font Arial10 = new Font("Arial", 10, FontStyle.Regular);//Cuerpo de texto
            //Font ArialNegrita12 = new Font("Arial", 12, FontStyle.Bold);//Cuerpo de texto
            //Font BookAntiqua = new Font("Book Antiqua", 12, FontStyle.Regular);//Cuerpo de texto   
            Font ArialNegrita10 = new Font("Arial", 10, FontStyle.Bold);//Cuerpo de texto
            Font titleFont = new Font("Cuerpo negro", 11, FontStyle.Bold);//Fuente del título           
            Font fntTxt = new Font("Song Ti", 10, FontStyle.Regular);//Cuerpo de texto                                                  
            Brush brush = new SolidBrush(Color.Black);//Cepillo de pintura           
            Pen pen = new Pen(Color.Black);           //Color de linea 
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
                i = ClasDatos.count;
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
                AB = ClasDatos.count / 40;
                printPreviewControl1.Rows = AB + 1;
                ClasDatos.count = 0;
            }


        }

        private void printClientes_PrintPage(object sender, PrintPageEventArgs e)
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
            Pen TñLinea = new Pen(Color.Black, 1);
            Pen TñLinea2 = new Pen(Color.Black, 2);
            // e.Graphics.DrawRectangle(TñLinea, 22, 194, 790, 870);
            e.Graphics.DrawString("400.00", ArialNegrita10, Brushes.Black, 750, 200, formato);
            e.Graphics.DrawString("40", ArialNegrita10, Brushes.Black, 750, 220, formato);
            e.Graphics.DrawString("888888.00", ArialNegrita10, Brushes.Black, 750, 240, formato);
            e.Graphics.DrawString("Iva", ArialNegrita10, Brushes.Black, 590, 40);
            e.Graphics.DrawString("Total", ArialNegrita10, Brushes.Black, 590, 60);
            e.HasMorePages = false;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            PaintEventArgs myPaintArgs = new PaintEventArgs(e.Graphics, new Rectangle(new Point(1, 1), this.Size));
            this.InvokePaint(FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView, myPaintArgs);
            e.HasMorePages = false;
        }

        private void printAlbaran_PrintPage(object sender, PrintPageEventArgs e)
        {

        }

        private void printPresupuesto_PrintPage(object sender, PrintPageEventArgs e)
        {

        }

        private void printNotaSimple_PrintPage(object sender, PrintPageEventArgs e)
        {

        }
    }
}
