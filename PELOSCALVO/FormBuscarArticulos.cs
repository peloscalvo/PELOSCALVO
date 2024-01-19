//using BarcodeStandard;
//using SkiaSharp;
using BarcodeLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Windows.Forms;
using ZXing;

namespace PELOSCALVO
{
    public partial class FormBuscarArticulos : Form
    {
        Boolean SiBaja = false;
        DataView verViev = default;
        public static FormBuscarArticulos MenuB;
        public FormBuscarArticulos()
        {
            InitializeComponent();
            MenuB = this;
        }
        public class OpcionCombo
        {
            public int Valor { get; set; }
            public string Texto { get; set; }
        }
        public class Opcionimagen
        {
            public Image Valor { get; set; }
        }
        public static class listas
        {
            public static List<Opcionimagen> lista = new List<Opcionimagen>();
        }
        private void FormBuscarArticulosEnFacturas_Load(object sender, EventArgs e)
        {
            if (FormMenuPrincipal.menu2principal.articulos != null)
            {
                this.dtArticulosBindingSource.DataSource = FormMenuPrincipal.menu2principal.articulos.DtArticulos;
                this.verViev = FormMenuPrincipal.menu2principal.articulos.DtArticulos.DefaultView;
            }
            if (FormMenuPrincipal.menu2principal.dsMultidatos != null)
            {
                this.dtInicioMultiBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMultidatos.DtInicioMulti;
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
                this.FiltrarBajasBuscar.SelectedIndex = 2;
                this.ListOpcion.SelectedIndex = 0;
                this.MinimumSize = new Size(1300, 506);
            }
            else
            {
                this.Width = 803;
                this.MinimumSize = new Size(803, 506);
            }
            int indice = 0;
            foreach (var nombre in Enum.GetNames(typeof(BarcodeLib.TYPE)))
            {
                this.ListaQr.Items.Add(new OpcionCombo() { Valor = indice, Texto = nombre });
                indice++;
            }
            indice = 0;
            foreach (var nombre in Enum.GetNames(typeof(ZXing.BarcodeFormat)))
            {
                this.ListaQr.Items.Add(new OpcionCombo() { Valor = indice, Texto = nombre });
                indice++;
            }
            if (FormMenuPrincipal.menu2principal.dsMultidatos.DtInicioMulti.Count > 0)
            {
                if (!string.IsNullOrEmpty(FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["CodigoBarras"].ToString()))
                {
                    this.ListaQr.Text = FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["CodigoBarras"].ToString();
                }
            }
            this.ListaQr.DisplayMember = "Texto";
            this.ListaQr.ValueMember = "Valor";
            this.ListaQr.SelectedIndex = 0;
            this.FormatoText.Text = "JPG";
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
                if (ClasDatos.QUEform == "Articulos")
                {
                    FormArticulos.menu2Articulos.FiltrarBajas.Text = this.FiltrarBajasBuscar.Text;
                }
            }
            this.ContadorDatos2.Text = string.Format("{0:N0" + "}", ((this.DataGridViewBuscarArticulos.Rows.Count).ToString()));

        }

        private void DataGridViewBuscarArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (ClasDatos.QUEform == "QR")
                {

                    try
                    {
                        if (this.ListCodigos.Enabled == true)
                        {


                            ListViewItem lvi = new ListViewItem();
                            if (!string.IsNullOrEmpty(this.DataGridViewBuscarArticulos.Rows[e.RowIndex].Cells[6].FormattedValue.ToString()))
                            {
                                lvi = this.ListCodigos.Items.Add(this.DataGridViewBuscarArticulos.Rows[e.RowIndex].Cells[6].FormattedValue.ToString());
                                if (!string.IsNullOrEmpty(this.DataGridViewBuscarArticulos.Rows[e.RowIndex].Cells[0].FormattedValue.ToString()))
                                {
                                    lvi.SubItems.Add(this.DataGridViewBuscarArticulos.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());

                                }

                            }
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(this.DataGridViewBuscarArticulos.Rows[e.RowIndex].Cells[6].FormattedValue.ToString()))
                            {
                                this.TituloText.Text = this.DataGridViewBuscarArticulos.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "LLENAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

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
                        int FilaDescuentosBuscar = FormFacturar.menu2FACTURAR.TipoTarifaFactu.SelectedIndex * 2 + 5;
                        if (FilaDescuentosBuscar > 6)
                        {
                            // FilaDescuentosBuscar=FilaDescuentosBuscar+2;
                        }
                        if (FormFacturar.menu2FACTURAR.TipoTarifaFactu.SelectedIndex > 6)
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


        }
        public static Bitmap convertirTextoImagen(string texto, int ancho, Color color)
        {
            Bitmap objBitmap = new Bitmap(1, 1);
            int Width = 0;
            int Height = 0;
            System.Drawing.Font objFont = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            Graphics objGraphics = Graphics.FromImage(objBitmap);
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
            if (this.ListOpcion.SelectedIndex == 0)
            {
                if (this.ListaQr.SelectedIndex <= 0)
                {
                    MessageBox.Show("Selecione Un Formato valido", "FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ListaQr.Focus();
                    return;
                }
            }
            else
            {
                if (this.ListaQr2.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecione Un Formato valido", "FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ListaQr.Focus();
                    return;
                }
            }
            if (String.IsNullOrEmpty(this.TituloText.Text))
            {
                MessageBox.Show("Campo De Titulo vacio", "CAMPO VACIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TituloText.Focus();
                return;
            }
            if (String.IsNullOrEmpty(this.Anchotext.Text))
            {
                MessageBox.Show("Campo De Ancho vacio", "CAMPO VACIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Anchotext.Focus();
                return;
            }
            if (String.IsNullOrEmpty(this.AltoText.Text))
            {
                MessageBox.Show("Campo De Alto vacio", "CAMPO VACIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.AltoText.Focus();
                return;
            }
            try
            {
                int Ancho = Convert.ToInt32(this.Anchotext.Text);
                int Alto = Convert.ToInt32(this.AltoText.Text);
                if (this.ListOpcion.SelectedIndex == 0)
                {
                    Image imagenCodigo;
                    int indice = (this.ListaQr.SelectedItem as OpcionCombo).Valor;
                    BarcodeLib.TYPE tipoCodigo = (BarcodeLib.TYPE)indice;
                    Barcode codigo = new Barcode();
                    codigo.IncludeLabel = true;
                    imagenCodigo = codigo.Encode(tipoCodigo, this.TituloText.Text.Trim(), Color.Black, Color.White, Ancho, Alto);
                    codigo.Alignment = AlignmentPositions.CENTER;
                    Bitmap imagenTitulo = convertirTextoImagen(this.TituloText.Text.Trim(), Ancho, Color.White);
                    int alto_imagen_nuevo = imagenCodigo.Height + imagenTitulo.Height;
                    Bitmap imagenNueva = new Bitmap(Ancho, alto_imagen_nuevo);
                    Graphics dibujar = Graphics.FromImage(imagenNueva);
                    dibujar.DrawImage(imagenTitulo, new Point(0, 0));
                    dibujar.DrawImage(imagenCodigo, new Point(0, imagenTitulo.Height));
                    this.PitureQr.Image = imagenCodigo;

                }
                else
                {
                    FormBuscarArticulos.listas.lista.Clear();
                    BarcodeWriter br = new BarcodeWriter();
                    int indice2 = (this.ListaQr.SelectedItem as OpcionCombo).Valor;
                    BarcodeFormat FormatoBr = (BarcodeFormat)indice2;
                    br.Format = FormatoBr;
                    Bitmap bm = new Bitmap(br.Write(this.TituloText.Text), Ancho, Alto);
                    this.PitureQr.Image = bm;
                }

                // MessageBox.Show("Codigo generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR APP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListCodigos_Click(object sender, EventArgs e)
        {
            try
            {
                int I = this.ListCodigos.FocusedItem.Index;
                if (!String.IsNullOrEmpty(this.ListCodigos.Items[I].SubItems[1].Text))
                {
                    this.TituloText.Text = this.ListCodigos.Items[I].SubItems[1].Text;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR APP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Limpiar Listado ? ", " BORRAR TODO EL LISTADO ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    this.ListCodigos.Items.Clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "ERROR APP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCodifiCar_Click(object sender, EventArgs e)
        {
            if (this.ListOpcion.SelectedIndex == 0)
            {
                if (this.ListaQr.SelectedIndex <= 0)
                {
                    MessageBox.Show("Selecione Un Formato valido", "FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ListaQr.Focus();
                    return;
                }
            }
            else
            {
                if (this.ListaQr2.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecione Un Formato valido", "FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ListaQr.Focus();
                    return;
                }

            }
            if (this.FormatoText.SelectedIndex != 4)
            {
                if (String.IsNullOrEmpty(this.TituloText.Text))
                {
                    MessageBox.Show("Campo De Titulo vacio", "CAMPO VACIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.TituloText.Focus();
                    return;
                }
            }
            if (String.IsNullOrEmpty(this.Anchotext.Text))
            {
                MessageBox.Show("Campo De Ancho vacio", "CAMPO VACIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Anchotext.Focus();
                return;
            }
            if (String.IsNullOrEmpty(this.AltoText.Text))
            {
                MessageBox.Show("Campo De Alto vacio", "CAMPO VACIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.AltoText.Focus();
                return;
            }
            if (MessageBox.Show(" Aceptar Guardar  ", " GUARDAR CODIGO BARRAS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    FormBuscarArticulos.listas.lista.Clear();
                    int Ancho = Convert.ToInt32(this.Anchotext.Text);
                    int Alto = Convert.ToInt32(this.AltoText.Text);
                    if (this.ListOpcion.SelectedIndex == 0)
                    {
                        Image imagenCodigo = null;
                        Bitmap imagenTitulo;
                        Bitmap imagenNueva;
                        int alto_imagen_nuevo = 0;
                        Graphics dibujar;
                        int indice = (this.ListaQr.SelectedItem as OpcionCombo).Valor;
                        BarcodeLib.TYPE tipoCodigo = (BarcodeLib.TYPE)indice;
                        Barcode codigo = new Barcode();
                        codigo.IncludeLabel = true;
                        int I;
                        //Bitmap BTM = new Bitmap(0, 0);

                        if (this.FormatoText.SelectedIndex == 4)
                        {
                            foreach (ListViewItem item2 in this.ListCodigos.Items)
                            {
                                // I = item2.Index;

                                imagenCodigo = codigo.Encode(tipoCodigo, item2.SubItems[1].Text, Color.Black, Color.White, Ancho, Alto);
                                codigo.Alignment = AlignmentPositions.CENTER;
                                imagenTitulo = convertirTextoImagen(item2.SubItems[1].Text, Ancho, Color.White);
                                alto_imagen_nuevo = imagenCodigo.Height + imagenTitulo.Height;
                                imagenNueva = new Bitmap(Ancho, alto_imagen_nuevo);
                                dibujar = Graphics.FromImage(imagenNueva);
                                dibujar.DrawImage(imagenTitulo, new Point(0, 0));
                                dibujar.DrawImage(imagenCodigo, new Point(0, imagenTitulo.Height));
                                Opcionimagen ImagenPdf = new Opcionimagen();
                                ImagenPdf.Valor = imagenCodigo;
                                FormBuscarArticulos.listas.lista.Add(ImagenPdf);

                            }
                        }
                        else
                        {
                            imagenCodigo = codigo.Encode(tipoCodigo, this.TituloText.Text.Trim(), Color.Black, Color.White, Ancho, Alto);
                            codigo.Alignment = AlignmentPositions.CENTER;
                            imagenTitulo = convertirTextoImagen(this.TituloText.Text.Trim(), Ancho, Color.White);
                            alto_imagen_nuevo = imagenCodigo.Height + imagenTitulo.Height;
                            imagenNueva = new Bitmap(Ancho, alto_imagen_nuevo);
                            // imagenNueva = BTM(Ancho, alto_imagen_nuevo);
                            dibujar = Graphics.FromImage(imagenNueva);
                            dibujar.DrawImage(imagenTitulo, new Point(0, 0));
                            dibujar.DrawImage(imagenCodigo, new Point(0, imagenTitulo.Height));
                        }
                        this.PitureQr.Image = imagenCodigo;
                    }
                    else
                    {
                        Bitmap bm = null;
                        int indice = (this.ListaQr.SelectedItem as OpcionCombo).Valor;
                        BarcodeWriter br = new BarcodeWriter();
                        BarcodeFormat FormatoBr = (BarcodeFormat)indice;
                        br.Format = FormatoBr;
                        if (this.FormatoText.SelectedIndex == 4)
                        {

                            //br.Format = FormatoBr;
                            foreach (ListViewItem item2 in this.ListCodigos.Items)
                            {
                                bm = new Bitmap(br.Write(item2.SubItems[1].Text), Ancho, Alto);
                                Opcionimagen ImagenPdf = new Opcionimagen();
                                ImagenPdf.Valor = bm;
                                FormBuscarArticulos.listas.lista.Add(ImagenPdf);
                            }
                            this.PitureQr.Image = bm;
                        }
                        else
                        {

                            bm = new Bitmap(br.Write(this.TituloText.Text), Ancho, Alto);
                            this.PitureQr.Image = bm;

                        }

                    }



                    if (this.FormatoText.SelectedIndex == 4)
                    {

                        PrintDocument PD = new PrintDocument();
                        PD.PrintPage += new PrintPageEventHandler(PrintBarras_PrintPage);
                        PD.DocumentName = string.Format("{0}", "codigos Barras App");
                        //  int Fila= FormBuscarArticulos.listas.lista.Count
                        //PD.PrinterSettings.FromPage = Fila/2;
                        // PD.Print();

                    }
                    else
                    {
                        SaveFileDialog ventana_dialogo = new SaveFileDialog();
                        ventana_dialogo.FileName = string.Format("{0}", this.TituloText.Text.Trim()) + "." + this.FormatoText.Text;
                        ventana_dialogo.Filter = "Image Files(*.JPG;*.PNG;*.GIF)|*.JPG;*.PNG;*.GIF|All files (*.*)|*.*";

                        if (ventana_dialogo.ShowDialog() == DialogResult.OK)
                        {
                            if (this.FormatoText.SelectedIndex == 0)
                            {
                                this.PitureQr.Image.Save(ventana_dialogo.FileName, ImageFormat.Jpeg);

                            }
                            if (this.FormatoText.SelectedIndex == 1)
                            {
                                this.PitureQr.Image.Save(ventana_dialogo.FileName, ImageFormat.Png);
                            }
                            if (this.FormatoText.SelectedIndex == 2)
                            {
                                this.PitureQr.Image.Save(ventana_dialogo.FileName, ImageFormat.Gif);
                            }
                            if (this.FormatoText.SelectedIndex == 3)
                            {
                                this.PitureQr.Image.Save(ventana_dialogo.FileName, ImageFormat.Bmp);
                            }
                        }


                    }

                    MessageBox.Show("Codigo generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR APP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw new Exception(ex.Message.ToString());
                }
            }
        }

        private void Anchotext_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AltoText_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BtnVerCodigo_Click(object sender, EventArgs e)
        {
            FormCodigoBarrras frm = new FormCodigoBarrras();
            FormCodigoBarrras.MenuB.PanelCodigoBarra.Image = this.PitureQr.Image;
            frm.ShowDialog();
            frm.BringToFront();

        }

        private void PrintBarras_PrintPage(object sender, PrintPageEventArgs e)
        {
            int BB = 25;
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

            // item2.SubItems.
            try
            {
                e.Graphics.DrawString("lISTADO DE CODIGO BARRAS ", titleFont, Brushes.Black, xPos + 40, 6);
                foreach (var item in FormBuscarArticulos.listas.lista)
                {
                    // e.Graphics.DrawString("---------------------------", Arial10, Brushes.Black, new Point(BB, BB));
                    e.Graphics.DrawImage(item.Valor, new Point(0, BB));
                    BB = BB + item.Valor.Height + 14;
                    e.HasMorePages = BB > e.PageBounds.Bottom;
                }
                // e.Graphics.DrawImage(this.PitureQr.Image, e.PageBounds);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void MenuListaClick(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                string NombreItem = e.ClickedItem.Name.ToString();
                if (NombreItem.Contains("DuplicarLinea"))
                {
                    NombreItem = NombreItem.Replace("DuplicarLinea", "");

                }
                if (NombreItem.Contains("Lineablanco"))
                {
                    NombreItem = NombreItem.Replace("Lineablanco", "");

                }
                if (NombreItem.Contains("EliminarLinea"))
                {
                    NombreItem = NombreItem.Replace("EliminarLinea", "");
                    int I = this.ListCodigos.FocusedItem.Index;
                    this.ListCodigos.Items.RemoveAt(I);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void ListCodigos_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                int posicion = this.ListCodigos.HitTest(e.X, e.Y).Item.Index;
                if (posicion > -1)
                {
                    menu.Items.Add("Duplicar Linea").Name = "DuplicarLinea" + posicion;
                    menu.Items.Add("Eliminar Linea").Name = "EliminarLinea" + posicion;
                }
                menu.Show(this.ListCodigos, e.X, e.Y);
                menu.ItemClicked += new ToolStripItemClickedEventHandler(MenuListaClick);
            }
        }

        private void FormatoText_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.FormatoText.SelectedIndex == 0)
            { 

            }
                if (this.FormatoText.SelectedIndex == 4)
            {
                this.ListCodigos.Enabled = true;
                this.BtnLimpiar.Visible = true;
                this.TituloText.Visible = false;
                this.BtnCodifiCar.Image = PELOSCALVO.Properties.Resources.Pdf;

            }
            else
            {
                this.ListCodigos.Enabled = false;
                this.BtnLimpiar.Visible = false;
                this.TituloText.Visible = true;
                this.BtnCodifiCar.Image = PELOSCALVO.Properties.Resources.iconmonstr_check_mark_9_24;
            }

        }

        private void BtnPrueba_Click(object sender, EventArgs e)
        {
            if (this.ListaQr2.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione Un Formato valido", "FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ListaQr.Focus();
                return;
            }
            if (String.IsNullOrEmpty(this.TituloText.Text))
            {
                MessageBox.Show("Campo De Titulo vacio", "CAMPO VACIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TituloText.Focus();
                return;
            }
            if (String.IsNullOrEmpty(this.Anchotext.Text))
            {
                MessageBox.Show("Campo De Ancho vacio", "CAMPO VACIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Anchotext.Focus();
                return;
            }
            if (String.IsNullOrEmpty(this.AltoText.Text))
            {
                MessageBox.Show("Campo De Alto vacio", "CAMPO VACIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.AltoText.Focus();
                return;
            }
            FormBuscarArticulos.listas.lista.Clear();
            int Ancho = Convert.ToInt32(this.Anchotext.Text);
            int Alto = Convert.ToInt32(this.AltoText.Text);
            BarcodeWriter br = new BarcodeWriter();
            int indice = (this.ListaQr.SelectedItem as OpcionCombo).Valor;
            BarcodeFormat FormatoBr = (BarcodeFormat)indice;
            br.Format = FormatoBr;
            Bitmap bm = new Bitmap(br.Write(this.TituloText.Text), Ancho, Alto);
            this.PitureQr.Image = bm;
        }

        private void ListOpcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ListOpcion.SelectedIndex == 0)
            {
                this.ListaQr.BringToFront();
               // this.ListaQr2.Visible = false;
            }
            else
            {
                this.ListaQr2.BringToFront();
                //this.ListaQr.
            }
        }
    }
}



