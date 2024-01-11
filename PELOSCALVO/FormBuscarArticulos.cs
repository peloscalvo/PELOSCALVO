using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BarcodeStandard;
using SkiaSharp;

namespace PELOSCALVO
{
    public partial class FormBuscarArticulos : Form
    {
        Boolean SiBaja = false;
        DataView verViev = default;
        public FormBuscarArticulos()
        {
            InitializeComponent();
        }
        public class OpcionCombo
        {
            public int Valor { get; set; }
            public string Texto { get; set; }
        }
        private void FormBuscarArticulosEnFacturas_Load(object sender, EventArgs e)
        {
            if (FormMenuPrincipal.menu2principal.articulos != null)
            {
                this.dtArticulosBindingSource.DataSource = FormMenuPrincipal.menu2principal.articulos.DtArticulos;
                this.verViev = FormMenuPrincipal.menu2principal.articulos.DtArticulos.DefaultView;
            }
            else
            {
                MessageBox.Show("Faltan datos", "ARCHIVO ARTICULOS VACIO");
                return;
            }
            if (ClasDatos.OkFacturar == true)
            {
                this.FiltrarBajasBuscar.Text = "Articulos De Alta";
                this.FiltrarBajasBuscar.Visible = true;
                this.labelfiltrarBUSCAR.Visible = true;
                // this.dtArticulosBindingSource.DataSource = FormFACTURAR.menu2FACTURAR.dtArticulosBindingSource; 

            }

            if (ClasDatos.OkFacturar == false)
            {
                if (ClasDatos.QUEform == "Articulos")
                {
                    this.FiltrarBajasBuscar.Visible = true;
                    this.labelfiltrarBUSCAR.Visible = true;
                    // this.dtArticulosBindingSource.DataSource = FormARTICULOS.menu2Articulos.dtArticulosBindingSource;
                    this.FiltrarBajasBuscar.Text = FormArticulos.menu2Articulos.FiltrarBajas.Text;
                }
    
            }
            // final abrir articulos
            this.ContadorDatos2.Text = string.Format("{0:N0" + "}", ((this.dtArticulosBindingSource.Count).ToString()));
            AñadirIdBuscar();
            this.BuscarArticulosText.Focus();
            if (ClasDatos.QUEform == "QR")
            {
                this.Width = 1300;

            }
            int indice = 0;
            foreach (var nombre in Enum.GetNames(typeof(BarcodeStandard.Type)))
            {
                ListaQr.Items.Add(new OpcionCombo() { Valor = indice, Texto = nombre });
                indice++;
            }
            ListaQr.DisplayMember = "Texto";
            ListaQr.ValueMember = "Valor";
            ListaQr.SelectedIndex = 0;
        }
        public void AñadirIdBuscar()
        {
            int ii = 0;
            foreach (DataGridViewRow fila in this.DataGridViewBuscarArticulos.Rows)
            {
                fila.Cells["IdFila"].Value = ii.ToString();
                ii++;
            }

        }
        private void BuscarArticulosText_TextChanged(object sender, EventArgs e)
        {

            string Referencia = string.Concat("[", this.articulos.DtArticulos.Columns[1].ColumnName, "]");
            string Comcepto = string.Concat("[", this.articulos.DtArticulos.Columns[2].ColumnName, "]");
            string FAmilia = string.Concat("[", this.articulos.DtArticulos.Columns[20].ColumnName, "]");
            string baja = string.Concat("[", this.articulos.DtArticulos.Columns["Baja"].ColumnName, "]");

            int NumeroValidar;// = 1;
            if (this.FiltrarBajasBuscar.SelectedIndex >= 0)
            {
                if (this.TIPObuscarArticulos.SelectedIndex == 0)
                {
                    this.articulos.DtArticulos.DefaultView.Sort = Comcepto;

                    if (this.FiltrarBajasBuscar.SelectedIndex == 2)
                    {      
                        this.verViev.RowFilter = Referencia + " LIKE '%" + this.BuscarArticulosText.Text + "%'" + "OR" + Comcepto + " LIKE '%" + this.BuscarArticulosText.Text + "%'" + "OR" + FAmilia + " LIKE '%" + this.BuscarArticulosText.Text + "%'";
                    }
                    else
                    {
                        this.verViev.RowFilter = "(" + Referencia + " LIKE '%" + this.BuscarArticulosText.Text + "%'" + "and " + "[baja]" + "=" + this.SiBaja + ")" + "OR" + "(" + Comcepto + " LIKE '%" + this.BuscarArticulosText.Text + "%'" + "and " + "[baja]" + "=" + this.SiBaja + ")" + "OR" + "(" + FAmilia + " LIKE '%" + this.BuscarArticulosText.Text + "%'" + "and " + baja + "=" + this.SiBaja + ")";
                        // verViev.RowFilter = Referencia + " LIKE '%" + BuscarArticulosText.Text + "%'" + "OR" + Comcepto + " LIKE '%" + BuscarArticulosText.Text + "%'" + "OR" + FAmilia + " LIKE '%" + BuscarArticulosText.Text + "%'" + "and (" + baja + "=" + Convert.ToBoolean("true")+")";
                    }

                }

                if (this.TIPObuscarArticulos.SelectedIndex == 1)//referencia
                {
                    NumeroValidar = 1;
                    string fieldName = string.Concat("[", this.articulos.DtArticulos.Columns[NumeroValidar].ColumnName, "]");
                    {
                        this.verViev.RowFilter = fieldName + " LIKE '%" + this.BuscarArticulosText.Text + "%'" + "and " + "[baja]" + "=" + this.SiBaja;

                        this.DataGridViewBuscarArticulos.DataSource = this.verViev;
                    }
                    if (this.TIPObuscarArticulos.SelectedIndex == 2)//descripcion
                    {
                        NumeroValidar = 2;
                        fieldName = string.Concat("[", this.articulos.DtArticulos.Columns[NumeroValidar].ColumnName, "]");
                        this.articulos.DtArticulos.DefaultView.Sort = fieldName;

                        this.verViev.RowFilter = fieldName + " LIKE '%" + this.BuscarArticulosText.Text + "%'" + "and " + "[baja]" + "=" + this.SiBaja;         
                    }
                    if (this.TIPObuscarArticulos.SelectedIndex == 3)//familia
                    {
                        NumeroValidar = 20;
                        fieldName = string.Concat("[", this.articulos.DtArticulos.Columns[NumeroValidar].ColumnName, "]");
                        this.articulos.DtArticulos.DefaultView.Sort = fieldName;
                        this.verViev.RowFilter = fieldName + " LIKE '%" + this.BuscarArticulosText.Text + "%'" + "and " + "[baja]" + "=" + this.SiBaja;
                        // BuscarArticulosText.Text = TIPObuscarArticulos.Text;
                    }

                  
                }
            }
            this.DataGridViewBuscarArticulos.DataSource = this.verViev;
            this.ContadorDatos2.Text = string.Format("{0:N0" + "}", ((this.DataGridViewBuscarArticulos.Rows.Count).ToString()));
        }

        private void BuscarArticulosText_Click(object sender, EventArgs e)
        {
            //DataView view2 = articulos.DtArticulos.DefaultView;
            // DataGridViewBuscarArticulos.DataSource = view2;

        }


        private void TIPObuscarArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {

            // DataView view = articulos.DtArticulos.DefaultView;
            //  dtArticulosBindingSource.Filter = string.Empty;
            string buscarDato = this.BuscarArticulosText.Text;
            this.BuscarArticulosText.Text = "";
            this.BuscarArticulosText.Text = buscarDato.ToString();
            this.ContadorDatos2.Text = string.Format("{0:N0" + "}", ((this.dtArticulosBindingSource.Count).ToString()));
        }

        private void BtnCancelarBArticulo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FiltrarBajasBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.verViev == null)
            {
                return;
            }
            if (this.FiltrarBajasBuscar.SelectedIndex == 0)
            {
                this.SiBaja = false;
                string fieldName = string.Concat("[", this.articulos.DtArticulos.Columns["Baja"].ColumnName, "]");
                this.articulos.DtArticulos.DefaultView.Sort = fieldName;
                this.verViev.RowFilter = fieldName + "=" + this.SiBaja;

            }
            if (this.FiltrarBajasBuscar.SelectedIndex == 1)
            {
                this.SiBaja = true;
                string fieldName = string.Concat("[", this.articulos.DtArticulos.Columns["Baja"].ColumnName, "]");
                this.verViev.RowFilter = fieldName + "=" + this.SiBaja;

            }
            if (this.FiltrarBajasBuscar.SelectedIndex == 2)
            {
                this.verViev.RowFilter = "";

            }
            string Comcepto = string.Concat("[", this.articulos.DtArticulos.Columns[2].ColumnName, "]");
            this.verViev.Sort = Comcepto;
            this.DataGridViewBuscarArticulos.DataSource = this.verViev;
            string Valor33 = this.BuscarArticulosText.Text;
            this.BuscarArticulosText.Text = "";
            this.BuscarArticulosText.Text = Valor33;
            if (ClasDatos.OkFacturar == false)
            {
                FormArticulos.menu2Articulos.FiltrarBajas.Text = this.FiltrarBajasBuscar.Text;
            }
            this.ContadorDatos2.Text = string.Format("{0:N0" + "}", ((this.DataGridViewBuscarArticulos.Rows.Count).ToString()));

        }

        private void DataGridViewBuscarArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (ClasDatos.QUEform == "QR")
                {
                    return;

                }

                if (this.DataGridViewBuscarArticulos.Rows[e.RowIndex].Cells["IdFILA"].Value == DBNull.Value && this.DataGridViewBuscarArticulos.Rows[e.RowIndex].Cells["IdFILA"].Value.ToString() == string.Empty)
                {
                    MessageBox.Show("Faltan Datos ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                int filaId = Convert.ToInt32(this.DataGridViewBuscarArticulos.Rows[e.RowIndex].Cells["IdFILA"].Value);
                //int filaId = 11;
                if (ClasDatos.OkFacturar == true)
                {
                    try
                    {
                        int FilaDescuentosBuscar = FormFacturar.menu2FACTURAR.tarifaTipoComboBox.SelectedIndex * 2 + 5;
                        if (FilaDescuentosBuscar > 6)
                        {
                            // FilaDescuentosBuscar=FilaDescuentosBuscar+2;
                        }
                        if (FormFacturar.menu2FACTURAR.tarifaTipoComboBox.SelectedIndex > 6)
                        {
                            FilaDescuentosBuscar = 6;
                        }
                        if (ClasDatos.Datos1Datos2 != "Nota2")///todas las notas menos la 2
                        {

                            if (FormFacturar.menu2FACTURAR.dtDetallesFacturaBindingSource.Count < 0)
                            {
                                FormFacturar.menu2FACTURAR.dtDetallesFacturaBindingSource.AddNew();
                            }
                           // MessageBox.Show(FormFACTURAR.menu2FACTURAR.dtDetallesFacturaBindingSource.Count.ToString());
                 
                            FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView.Rows[ClasDatos.ValorBuscado].Cells[0].Value = this.DataGridViewBuscarArticulos.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();//referencia
                            FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView.Rows[ClasDatos.ValorBuscado].Cells[3].Value = this.DataGridViewBuscarArticulos.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();//descripcion
                            if (FormFacturar.menu2FACTURAR.CheckDescuentos.Checked == false)
                            {
                                if (FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[filaId][FilaDescuentosBuscar].ToString() != string.Empty && FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[filaId][FilaDescuentosBuscar] != DBNull.Value)
                                {
                                    FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView.Rows[ClasDatos.ValorBuscado].Cells[4].Value = FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[filaId][FilaDescuentosBuscar].ToString();//precio Buscado
                                    FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView.Rows[ClasDatos.ValorBuscado].Cells[5].Value = DBNull.Value;//DESCUENTO
                                }

                            }
                            if (FormFacturar.menu2FACTURAR.CheckDescuentos.Checked == true)
                            {
                                if (FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[filaId]["Pvp1"].ToString() != string.Empty && FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[filaId]["Pvp1"] != DBNull.Value)
                                {
                                    FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView.Rows[ClasDatos.ValorBuscado].Cells[4].Value = FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[filaId]["Pvp1"].ToString();//pvp1
                                }
                                else
                                {
                                    FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView.Rows[ClasDatos.ValorBuscado].Cells[4].Value = DBNull.Value;//PVP1 VACIO
                                }

                                if (FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[filaId][FilaDescuentosBuscar].ToString() != String.Empty && FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[filaId][FilaDescuentosBuscar] != DBNull.Value)
                                {
                                    FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView.Rows[ClasDatos.ValorBuscado].Cells[5].Value = FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[filaId][FilaDescuentosBuscar].ToString();//DESCUENETO SI TRUE
                                }
                                else
                                {
                                    FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView.Rows[ClasDatos.ValorBuscado].Cells[5].Value = DBNull.Value;//DESCUENTO SI VACIO
                                }

                                if (FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView.Rows[ClasDatos.ValorBuscado].Cells[2].Value.ToString() == string.Empty)
                                {
                                    FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView.Rows[ClasDatos.ValorBuscado].Cells[2].Value = 0;
                                }
                            }
                            FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView.Focus();
                            FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView.CurrentCell = FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView.Rows[ClasDatos.ValorBuscado].Cells[2];
                            FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView.BeginEdit(true);
                        }
                        if (ClasDatos.Datos1Datos2 == "Nota2")
                        {
                            if (FormFacturar.menu2FACTURAR.dtDetallesFactura2BindingSource.Count < 0)
                            {
                                FormFacturar.menu2FACTURAR.dtDetallesFactura2BindingSource.AddNew();
                            }
         

                            FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView2.Rows[ClasDatos.ValorBuscado].Cells[0].Value = this.DataGridViewBuscarArticulos.Rows[ClasDatos.ValorBuscado].Cells[0].FormattedValue.ToString();//REFERENCIA
                            FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView2.Rows[ClasDatos.ValorBuscado].Cells[3].Value = this.DataGridViewBuscarArticulos.Rows[ClasDatos.ValorBuscado].Cells[1].FormattedValue.ToString();//DESCRIPCION
                            if (FormFacturar.menu2FACTURAR.CheckDescuentos.Checked == true)
                            {
                                if (FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[filaId][FilaDescuentosBuscar].ToString() != string.Empty && FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[filaId][FilaDescuentosBuscar] != DBNull.Value)
                                {
                                    FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView2.Rows[ClasDatos.ValorBuscado].Cells[4].Value = FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[filaId][2].ToString();//pvp1
                                }
                                else
                                {
                                    FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView2.Rows[ClasDatos.ValorBuscado].Cells[4].Value = DBNull.Value;//PVP1 VACIO
                                }

                                if (FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[filaId][FilaDescuentosBuscar].ToString() != String.Empty && FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[filaId][FilaDescuentosBuscar] != DBNull.Value)
                                {
                                    FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView2.Rows[ClasDatos.ValorBuscado].Cells[5].Value = FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[filaId][FilaDescuentosBuscar].ToString();//DESCUENETO SI TRUE
                                }
                                else
                                {
                                    FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView2.Rows[ClasDatos.ValorBuscado].Cells[5].Value = DBNull.Value;//DESCUENTO SI VACIO
                                }


                            }
                            if (FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView2.Rows[ClasDatos.ValorBuscado].Cells[2].Value == DBNull.Value)
                            {
                                FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView2.Rows[ClasDatos.ValorBuscado].Cells[2].Value = 0;
                            }
                            FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView2.Focus();
                            FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView2.CurrentCell = FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView2.Rows[ClasDatos.ValorBuscado].Cells[2];
                            FormFacturar.menu2FACTURAR.dtDetallesFacturaDataGridView2.BeginEdit(true);
                        }
                    }
                    catch (Exception ex)
                    {


                        MessageBox.Show(ex.Message);
                    }
                }

                if (ClasDatos.OkFacturar == false)
                {
                    // FormARTICULOS.menu2Articulos.dtPreciosDataGridView.Rows[ClasDatos.ValorBuscado].Selected = true;


                    try
                    {
                        FormArticulos.menu2Articulos.dtPreciosDataGridView.CurrentCell = FormArticulos.menu2Articulos.dtPreciosDataGridView.Rows[filaId].Cells[0];
                        FormArticulos.menu2Articulos.dtPreciosDataGridView.CurrentCell.Selected = true;
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }


                }

                Close();
            }

        }

        private void DataGridViewBuscarArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    //ListView list = new ListView();
                    ListViewItem lvi = new ListViewItem();
                    ListCodigos.Items.Add(lvi);
                    if (!string.IsNullOrEmpty(DataGridViewBuscarArticulos.Rows[e.RowIndex].Cells[6].FormattedValue.ToString()))
                    {
                        ListCodigos.Items.Add(DataGridViewBuscarArticulos.Rows[e.RowIndex].Cells[6].FormattedValue.ToString());
                    }
                    if (!string.IsNullOrEmpty(DataGridViewBuscarArticulos.Rows[e.RowIndex].Cells[0].FormattedValue.ToString()))
                    {
                        lvi.SubItems.Add(DataGridViewBuscarArticulos.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "LLENAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static Bitmap convertirTextoImagen(string texto, int ancho, Color color)
        {
            //creamos el objeto imagen Bitmap
            Bitmap objBitmap = new Bitmap(1, 1);
            int Width = 0;
            int Height = 0;
            //formateamos la fuente (tipo de letra, tamaño)
            System.Drawing.Font objFont = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);

            //creamos un objeto Graphics a partir del Bitmap
            Graphics objGraphics = Graphics.FromImage(objBitmap);

            //establecemos el tamaño según la longitud del texto
            Width = ancho;
            Height = (int)objGraphics.MeasureString(texto, objFont).Height + 5;
            objBitmap = new Bitmap(objBitmap, new Size(Width, Height));

            objGraphics = Graphics.FromImage(objBitmap);

            objGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            objGraphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            objGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            objGraphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            StringFormat drawFormat = new StringFormat();
            objGraphics.Clear(color);

            drawFormat.Alignment = StringAlignment.Center;
            objGraphics.DrawString(texto, objFont, new SolidBrush(Color.Black), new RectangleF(0, (objBitmap.Height / 2) - (objBitmap.Height - 10), objBitmap.Width, objBitmap.Height), drawFormat);
            objGraphics.Flush();


            return objBitmap;
        }
        private void BtnCrearQr_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(TituloText.Text))
            {
                MessageBox.Show("Campo De Titulo vacio", "CAMPO VACIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TituloText.Focus();
                return;
            }
            try
            {
                SKImage imagenCodigo;
                int indice = (ListaQr.SelectedItem as OpcionCombo).Valor;
                BarcodeStandard.Type tipoCodigo = (BarcodeStandard.Type)indice;
                Barcode codigo = new Barcode();
                codigo.IncludeLabel = true;
                // codigo.LabelFont = LabelPositions.BOTTOMCENTER;
                //codigo.ForeColor = Color.FromArgb(1,11,1)
                imagenCodigo = codigo.Encode(tipoCodigo, TituloText.Text.Trim(), SKColors.Black, SKColors.White, 300, 100);
                Bitmap imagenTitulo = convertirTextoImagen(TituloText.Text.Trim(), 300, Color.White);
                int alto_imagen_nuevo = imagenCodigo.Height + imagenTitulo.Height;
                Bitmap imagenNueva = new Bitmap(300, alto_imagen_nuevo);
                Graphics dibujar = Graphics.FromImage(imagenNueva);
                SKBitmap dibujar2 = SKBitmap.FromImage(imagenCodigo);
                dibujar.DrawImage(imagenTitulo, new Point(0, 0));
                // dibujar.DrawImage(imagenCodigo, new Point(0, imagenTitulo.Height));
                //pictureBox1.BackgroundImage = imagenCodigo;
                PitureQr.BackgroundImage = imagenNueva;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR APP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


