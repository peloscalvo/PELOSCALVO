using ComunApp;
using Conexiones;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;


namespace PELOSCALVO
{
    public partial class FormFacturar : Form
    {
        public static FormFacturar menu2FACTURAR;
        string SoloNumerosText = "";
        string a = "1";

        private void CalcularImportes(DataGridView DatagriCalcular)
        {
            double cantidad = 0;
            double precio = 0;
            double descuento = 0;
            double importe;
            double TTotalSuma = 0;
            double sumaIva = 0;
            int columna = 7;
            int columna2 = 6;

            if (this.tabControl1Factura.SelectedIndex == 2)
            {
                columna = 6;
                columna2 = 6;
            }
            if (DatagriCalcular.CurrentCell.RowIndex > -1)
            {
                if (ClasDatos.NombreFactura == "Albaranes")
                {
                    if (DatagriCalcular.CurrentCell.RowIndex >= 40)
                    {
                        DatagriCalcular.AllowUserToAddRows = false;
                    }
                }

                int FILAcelda = DatagriCalcular.CurrentCell.RowIndex;
                if (DatagriCalcular.Rows[FILAcelda].Cells[2].Value != DBNull.Value && DatagriCalcular.Rows[FILAcelda].Cells[2].Value.ToString() != string.Empty && DatagriCalcular.Rows[FILAcelda].Cells[2].Value.ToString() != null)
                {
                    cantidad = Convert.ToDouble(DatagriCalcular.Rows[FILAcelda].Cells[2].Value);
                }
                if (DatagriCalcular.Rows[FILAcelda].Cells[4].Value != DBNull.Value && DatagriCalcular.Rows[FILAcelda].Cells[4].Value.ToString() != string.Empty && DatagriCalcular.Rows[FILAcelda].Cells[4].Value.ToString() != null)
                {
                    precio = Convert.ToDouble(DatagriCalcular.Rows[FILAcelda].Cells[4].Value);

                }
                if (DatagriCalcular.Rows[FILAcelda].Cells[5].Value != DBNull.Value && DatagriCalcular.Rows[FILAcelda].Cells[5].Value.ToString() != string.Empty)
                {
                    descuento = Convert.ToDouble(DatagriCalcular.Rows[FILAcelda].Cells[5].Value);
                }
                if (DatagriCalcular.Rows[FILAcelda].Cells[6].Value == DBNull.Value || DatagriCalcular.Rows[FILAcelda].Cells[6].Value.ToString() == string.Empty)
                {
                    DatagriCalcular.Rows[FILAcelda].Cells[6].Value = this.tipoInpuestoIVANumericUpDown.Value;
                }

                importe = precio * cantidad - (precio * cantidad) * ((descuento / 100));
                DatagriCalcular.CurrentRow.Cells[columna].Value = importe.ToString();




                foreach (DataGridViewRow row in DatagriCalcular.Rows)
                {

                    if (row.Cells[columna].Value != null && row.Cells[columna].Value != DBNull.Value && row.Cells[columna].Value.ToString() != string.Empty)
                    {

                        TTotalSuma += (Double)row.Cells[columna].Value;


                        if (row.Cells[columna2].Value != DBNull.Value && row.Cells[columna2].Value != null && row.Cells[columna2].Value.ToString() != string.Empty)
                        {

                            sumaIva += (Double)row.Cells[columna].Value - ((Double)row.Cells[columna].Value * (Convert.ToDouble(row.Cells[columna2].Value) / 100));
                        }

                    }
                }
                if (DatagriCalcular.Rows[FILAcelda].Cells[4].Value == DBNull.Value || DatagriCalcular.Rows[FILAcelda].Cells[2].Value == DBNull.Value)
                {
                    DatagriCalcular.Rows[FILAcelda].Cells[columna].Value = DBNull.Value;
                }
                if (this.tabControl1Factura.SelectedIndex == 2)
                {
                    this.TotalFactura2.Text = string.Format("{0:C" + this.NumPrecio.Value + "}", (TTotalSuma));
                }
                else
                {
                    if (TTotalSuma == 0)
                    {
                        this.subTotalLabel2.Text = string.Format("{0:C" + this.NumPrecio.Value + "}", (0));
                        this.baseIvaLabel2.Text = string.Format("{0:C" + this.NumPrecio.Value + "}", (0));
                        this.TotalFactura1.Text = string.Format("{0:C" + this.NumPrecio.Value + "}", (0));
                    }
                    else
                    {
                        this.subTotalLabel2.Text = string.Format("{0:C" + this.NumPrecio.Value + "}", (TTotalSuma));
                        this.baseIvaLabel2.Text = string.Format("{0:C" + this.NumPrecio.Value + "}", (TTotalSuma - sumaIva));
                        this.TotalFactura1.Text = string.Format("{0:C" + this.NumPrecio.Value + "}", (TTotalSuma + (TTotalSuma - sumaIva)));
                    }
                }


            }

        }
        private void analizarStock(DataGridView DatagriStock)
        {
            int Fila2 = 0;
            foreach (DataGridViewRow filaStock in DatagriStock.Rows)
            {
                if (filaStock.Cells[0].Value.ToString() != string.Empty)
                {
                    Fila2 = (int)filaStock.Cells[0].Value;
                }

            }

        }
        private bool VALIDARcampos()
        {
            bool ok = true;
            if (this.apodoTextBox.Text.Length < 4)
            {
                ok = false;
                this.errorProvider1.SetError(this.apodoTextBox, "_ingresar Razon Social (( minimo 4 Caracteres))");
            }
            if (this.nombreTextBox.Text.Length < 4)
            {
                ok = false;
                this.errorProvider1.SetError(this.nombreTextBox, "_ingresar NOMBRE (( minimo 4 Caracteres))");
            }
            if (this.direccionTextBox.Text.Length < 4)
            {
                ok = false;
                this.errorProvider1.SetError(this.direccionTextBox, "_ingresar Direcion (( minimo 4 Caracteres))");
            }
            if (this.dniTextBox.Text.Length < 4)
            {
                ok = false;
                this.errorProvider1.SetError(this.dniTextBox, "_ingresar Dni (( minimo 4 Caracteres))");
            }

            return ok;

        }
        private void BORRARerrores()
        {
            this.errorProvider1.SetError(this.apodoTextBox, "");
            this.errorProvider1.SetError(this.nombreTextBox, "");
            this.errorProvider1.SetError(this.direccionTextBox, "");
            this.errorProvider1.SetError(this.dniTextBox, "");
            this.errorProvider1.SetError(this.numeroFacturaTextBox, "");
        }



        public void GuardarFactuSql()
        {
            string VALIDAR_DATOS = "";
            string VALIDAR_Dtfactura = "  Se Guardo Correctamente";
            string VALIDAR_Dtdetalle = "  Se Guardo Correctamente";
            string VALIDAR_Dtdetalle2 = "";
            string Consulta = "";
            string ConsultaEliminar = "DELETE FROM [DtDetallesFactura] WHERE [EnlaceDetalle]=" + this.EnlaceFactu.Text;
            string ConsultaEliminar2 = "DELETE FROM [DtDetallesFactura2] WHERE [EnlaceDetalle]=" + this.EnlaceFactu.Text;
            string ConsultaDetalle = "INSERT INTO [DtDetallesFactura] ([ReferenciaDetalle],[CantidadDetalle],[DescripccionDetalle]" +
             " ,[DescuentoDetalle],[PrecioDetalle],[IvaDetalle] ,[ImporteDetalle],[EnlaceDetalle])" +
             " VALUES( @ReferenciaDetalle, @CantidadDetalle, @DescripccionDetalle, @DescuentoDetalle, " +
             " @PrecioDetalle, @IvaDetalle, @ImporteDetalle, @EnlaceDetalle) ";

            string ConsultaDetalle2 = "INSERT INTO [DtDetallesFactura2] ([ReferenciaDetalle],[CantidadDetalle],[DescripccionDetalle]" +
                         " ,[DescuentoDetalle],[PrecioDetalle],[ImporteDetalle],[EnlaceDetalle])" +
                         " VALUES( @ReferenciaDetalle, @CantidadDetalle, @DescripccionDetalle, @DescuentoDetalle, " +
                         " @PrecioDetalle, @ImporteDetalle, @EnlaceDetalle) ";
            if (this.panelBotones.Tag.ToString() == "Nuevo")
            {
                Consulta = "INSERT INTO [DtNuevaFactura]([EnlaceFactura],[NumeroFactura],[Apodo] ,[Nombre],[Direccion],[Calle]" +
                ",[NumeroCalle] ,[Dni],[Localidad],[Provincia],[CodigoPostal],[NonbreAlmacen],[FechaFactura]" +
                ",[IvaImpuesto],[SubTotal],[BaseIva] ,[TotalFactura],[CobradaFactura],[FechaCobro],[Pais_Fact]" +
                " ,[TotalFactura2],[TipoNOTA],[Obra_factu],[EjercicioTipo],[SerieTipo],[EmpresaEnlace]) VALUES(@EnlaceFactura, @NumeroFactura, @Apodo, @Nombre, @Direccion," +
                " @Calle, @NumeroCalle, @Dni, @Localidad, @Provincia, @CodigoPostal, @NonbreAlmacen, @FechaFactura," +
                " @IvaImpuesto, @SubTotal, @BaseIva, @TotalFactura, @CobradaFactura, @FechaCobro," +
                " @Pais_Fact, @TotalFactura2, @TipoNOTA, @Obra_factu, @EjercicioTipo,@SerieTipo,@EmpresaEnlace)";

            }
            else
            {
                Consulta = "UPDATE [DtNuevaFactura] SET [EnlaceFactura]= @EnlaceFactura [NumeroFactura] = @NumeroFactura,[Apodo] = @Apodo,[Nombre] = @Nombre," +
               " [Direccion] = @Direccion, [Calle] = @Calle, [NumeroCalle] = @NumeroCalle, [Dni] = @Dni," +
               " [Localidad] = @Localidad, [Provincia] = @Provincia,[CodigoPostal] = @CodigoPostal, " +
               " [NonbreAlmacen] = @NonbreAlmacen, [FechaFactura] = @FechaFactura, [IvaImpuesto] = @IvaImpuesto, " +
               " [SubTotal] = @SubTotal, [BaseIva] = @BaseIva, [TotalFactura] = @TotalFactura, [CobradaFactura] = @CobradaFactura, " +
               " [FechaCobro] = @FechaCobro,  [Pais_Fact] = @Pais_Fact, [TotalFactura2] = @TotalFactura2," +
               " [TipoNOTA] = @TipoNOTA, [Obra_factu] = @Obra_factu, [EjercicioTipo] = @EjercicioTipo,[SerieTipo]= @SerieTipo,[SerieTipo]= @SerieTipo,[EmpresaEnlace]=@EmpresaEnlace WHERE[EnlaceFactura] = @EnlaceFactura";

            }

            ClsConexionSql NuevaConexion = new ClsConexionSql(Consulta);


            if (NuevaConexion.SiConexionSql)
            {
                //añadir guaradar a  qui
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@EnlaceFactura", string.IsNullOrEmpty(this.EnlaceFactu.Text) ? (object)DBNull.Value : this.EnlaceFactu.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@NumeroFactura", string.IsNullOrEmpty(this.numeroFacturaTextBox.Text) ? (object)DBNull.Value : this.numeroFacturaTextBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@Apodo", string.IsNullOrEmpty(this.apodoTextBox.Text) ? (object)DBNull.Value : this.apodoTextBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@Direccion", string.IsNullOrEmpty(this.direccionTextBox.Text) ? (object)DBNull.Value : this.direccionTextBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@Nombre", string.IsNullOrEmpty(this.nombreTextBox.Text) ? (object)DBNull.Value : this.nombreTextBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@Dni", string.IsNullOrEmpty(this.dniTextBox.Text) ? (object)DBNull.Value : this.dniTextBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@Calle", string.IsNullOrEmpty(this.calleTextBox.Text) ? (object)DBNull.Value : this.calleTextBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@NumeroCalle", string.IsNullOrEmpty(this.numeroCalleTextBox.Text) ? (object)DBNull.Value : this.numeroCalleTextBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@Localidad", string.IsNullOrEmpty(this.localidadTextBox.Text) ? (object)DBNull.Value : this.localidadTextBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@Provincia", string.IsNullOrEmpty(this.provinciaComboBox.Text) ? (object)DBNull.Value : this.provinciaComboBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@CodigoPostal", string.IsNullOrEmpty(this.codigoPostalTextBox.Text) ? (object)DBNull.Value : this.codigoPostalTextBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@NonbreAlmacen", string.IsNullOrEmpty(this.nonbreAlmacenComboBox.Text) ? (object)DBNull.Value : this.nonbreAlmacenComboBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@IvaImpuesto", string.IsNullOrEmpty(this.tipoInpuestoIVANumericUpDown.Text) ? (object)DBNull.Value : this.tipoInpuestoIVANumericUpDown.Value);
                // this.subTotalLabel2.Text = this.subTotalLabel2.Text.Replace("€", "");
                //this.baseIvaLabel2.Text = this.baseIvaLabel2.Text.Replace("€", "");
                // this.TotalFactura1.Text = this.TotalFactura1.Text.Replace("€", "");

                if (this.FechaFacturaDate.Text != string.Empty)
                {

                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@FechaFactura", this.FechaFacturaDate.Text);
                }
                else
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@FechaFactura", String.Format("{0:dd/MM/yyyy}", DateTime.Now));
                }

                if (this.cobradaFacturaCheckBox.Checked)
                {
                    if (this.fechaCobroMaskedTextBox.Text != string.Empty)
                    {

                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@FechaCobro", this.fechaCobroMaskedTextBox.Text);
                    }
                    else
                    {
                        NuevaConexion.ComandoSql.Parameters.AddWithValue("@FechaCobro", String.Format("{0:dd/MM/yyyy}", DateTime.Now));
                    }
                }
                else
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@FechaCobro", "");
                }

                NuevaConexion.ComandoSql.Parameters.AddWithValue("@Pais_Fact", string.IsNullOrEmpty(this.pais_FactComboBox.Text) ? (object)DBNull.Value : this.pais_FactComboBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@BaseIva", string.IsNullOrEmpty(this.baseIvaLabel2.Text) ? 0 : Convert.ToDouble(this.baseIvaLabel2.Text.Replace("€", "")));
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@TotalFactura", string.IsNullOrEmpty(this.TotalFactura1.Text) ? 0 : Convert.ToDouble(this.TotalFactura1.Text.Replace("€", "")));
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@TotalFactura2", string.IsNullOrEmpty(this.TotalFactura2.Text) ? 0 : Convert.ToDouble(this.TotalFactura2.Text.Replace("€", "")));
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@SubTotal", string.IsNullOrEmpty(this.subTotalLabel2.Text) ? 0 : Convert.ToDouble(this.subTotalLabel2.Text.Replace("€", "")));
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@Obra_factu", string.IsNullOrEmpty(this.obrasComboBox.Text) ? "A" : this.obrasComboBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@TipoNOTA", string.IsNullOrEmpty(this.labelTipoNota.Text) ? (object)DBNull.Value : this.labelTipoNota.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@SerieTipo", string.IsNullOrEmpty(this.SerieText.Text) ? "A" : this.SerieText.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@EjercicioTipo", string.IsNullOrEmpty(this.ejerciciosDeAñoComboBox.Text) ? (object)DBNull.Value : this.ejerciciosDeAñoComboBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@EmpresaEnlace", string.IsNullOrEmpty(this.NombreEmpresaReguistro.Text) ? (object)DBNull.Value : this.NombreEmpresaReguistro.Text);
                if (this.cobradaFacturaCheckBox.Checked == true)
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@CobradaFactura", "Cobrado");///canbiar valor a cobrada
                }
                else
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@CobradaFactura", "");///canbiar valor a cobrada
                }
                try
                {
                    NuevaConexion.ComandoSql.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    VALIDAR_DATOS = "ERROR";
                    VALIDAR_Dtfactura = " Tabla DTfactura no Se guardo ((ERROR))";
                    MessageBox.Show(ex.Message, "ERROR AL GUARDAR DATOS TABLA PRINCIPAL");
                }
                finally
                {
                    if (NuevaConexion.CerrarConexionSql)
                    {

                    }
                }
                NuevaConexion.ComandoSql.Parameters.Clear();

                // CalcularImportes(this.dtDetallesFacturaDataGridView);
                if (NuevaConexion.CerrarConexionSql)
                {
                    //Cierra sin mas
                }
                if (this.panelBotones.Tag.ToString() != "Nuevo")
                {

                    if (this.dtNuevaFacturaDataGridView.RowCount > 0)
                    {
                        ClsConexionSql ConexionDetalleEliminar = new ClsConexionSql(ConsultaEliminar);
                        if (ConexionDetalleEliminar.SiConexionSql)
                        {
                            try
                            {
                                ConexionDetalleEliminar.ComandoSql.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message, "ERROR AL GUARDAR ELIMINANDO DATOS1");
                            }
                            finally
                            {
                                if (ConexionDetalleEliminar.CerrarConexionSql)
                                {
                                    ConexionDetalleEliminar.ComandoSql.Parameters.Clear();
                                }
                            }
                        }

                    }
                }

                if (this.dtDetallesFacturaDataGridView.RowCount >= 0)
                {
                    ClsConexionSql NuevaConexionDetalle = new ClsConexionSql(ConsultaDetalle);
                    if (NuevaConexionDetalle.SiConexionSql)
                    {
                        try
                        {
                            int i = 0;
                            foreach (DataGridViewRow FilaGri in this.dtDetallesFacturaDataGridView.Rows)
                            {
                                if (i == this.dtDetallesFacturaDataGridView.RowCount - 1)
                                {
                                    break;
                                }
                                NuevaConexionDetalle.ComandoSql.Parameters.AddWithValue("@ReferenciaDetalle", string.IsNullOrEmpty(FilaGri.Cells[0].Value.ToString()) ? (object)DBNull.Value : FilaGri.Cells[0].Value.ToString());
                                NuevaConexionDetalle.ComandoSql.Parameters.AddWithValue("@CantidadDetalle", string.IsNullOrEmpty(FilaGri.Cells[2].Value.ToString()) ? (object)DBNull.Value : Convert.ToDouble(FilaGri.Cells[2].Value.ToString()));
                                NuevaConexionDetalle.ComandoSql.Parameters.AddWithValue("@DescripccionDetalle", string.IsNullOrEmpty(FilaGri.Cells[3].Value.ToString()) ? (object)DBNull.Value : FilaGri.Cells[3].Value.ToString());
                                NuevaConexionDetalle.ComandoSql.Parameters.AddWithValue("@PrecioDetalle", string.IsNullOrEmpty(FilaGri.Cells[4].Value.ToString()) ? (object)DBNull.Value : Convert.ToDouble(FilaGri.Cells[4].Value.ToString()));
                                NuevaConexionDetalle.ComandoSql.Parameters.AddWithValue("@DescuentoDetalle", string.IsNullOrEmpty(FilaGri.Cells[5].Value.ToString()) ? (object)DBNull.Value : Convert.ToDouble(FilaGri.Cells[5].Value.ToString()));
                                NuevaConexionDetalle.ComandoSql.Parameters.AddWithValue("@IvaDetalle", string.IsNullOrEmpty(FilaGri.Cells[6].Value.ToString()) ? (object)DBNull.Value : Convert.ToDouble(FilaGri.Cells[6].Value.ToString()));
                                NuevaConexionDetalle.ComandoSql.Parameters.AddWithValue("@ImporteDetalle", string.IsNullOrEmpty(FilaGri.Cells[7].Value.ToString()) ? (object)DBNull.Value : Convert.ToDouble(FilaGri.Cells[7].Value.ToString()));
                                NuevaConexionDetalle.ComandoSql.Parameters.AddWithValue("@EnlaceDetalle", string.IsNullOrEmpty(FilaGri.Cells[8].Value.ToString()) ? (object)DBNull.Value : FilaGri.Cells[8].Value.ToString());
                                NuevaConexionDetalle.ComandoSql.ExecuteNonQuery();
                                NuevaConexionDetalle.ComandoSql.Parameters.Clear();
                                i++;
                            }

                        }
                        catch (Exception ex)
                        {
                            VALIDAR_DATOS = "ERROR";
                            VALIDAR_Dtdetalle = " Tabla Dtdetalle no Se guardo ((ERROR))";
                            MessageBox.Show(ex.Message, "ERROR AL GUARDAR dtdetalle1");
                        }
                        finally
                        {
                            if (NuevaConexionDetalle.CerrarConexionSql)
                            {

                            }
                        }
                    }
                }

                if (this.dtDetallesFacturaDataGridView2.RowCount >= 0 && ClasDatos.Datos1Datos2 == "Nota 2")
                {
                    if (this.panelBotones.Tag.ToString() != "Nuevo")
                    {

                        if (this.dtNuevaFacturaDataGridView.RowCount >= 0)
                        {
                            ClsConexionSql ConexionDetalleEliminar2 = new ClsConexionSql(ConsultaEliminar2);
                            if (ConexionDetalleEliminar2.SiConexionSql)
                            {
                                try
                                {
                                    ConexionDetalleEliminar2.ComandoSql.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.Message, "ERROR AL GUARDAR ELIMINANDO DATOS2");
                                }
                                finally
                                {
                                    if (ConexionDetalleEliminar2.CerrarConexionSql)
                                    {
                                        ConexionDetalleEliminar2.ComandoSql.Parameters.Clear();
                                    }
                                }
                            }
                        }
                    }
                    ClsConexionSql NuevaConexionDetalle = new ClsConexionSql(ConsultaDetalle2);
                    if (NuevaConexionDetalle.SiConexionSql)
                    {
                        try
                        {
                            int i = 0;
                            foreach (DataGridViewRow FilaGri in this.dtDetallesFacturaDataGridView2.Rows)
                            {
                                if (i == this.dtDetallesFacturaDataGridView2.RowCount - 1)
                                {
                                    break;
                                }
                                NuevaConexionDetalle.ComandoSql.Parameters.AddWithValue("@ReferenciaDetalle", string.IsNullOrEmpty(FilaGri.Cells[0].Value.ToString()) ? (object)DBNull.Value : FilaGri.Cells[0].Value.ToString());
                                NuevaConexionDetalle.ComandoSql.Parameters.AddWithValue("@CantidadDetalle", string.IsNullOrEmpty(FilaGri.Cells[2].Value.ToString()) ? (object)DBNull.Value : Convert.ToDouble(FilaGri.Cells[2].Value.ToString()));
                                NuevaConexionDetalle.ComandoSql.Parameters.AddWithValue("@DescripccionDetalle", string.IsNullOrEmpty(FilaGri.Cells[3].Value.ToString()) ? (object)DBNull.Value : FilaGri.Cells[3].Value.ToString());
                                NuevaConexionDetalle.ComandoSql.Parameters.AddWithValue("@DescuentoDetalle", string.IsNullOrEmpty(FilaGri.Cells[5].Value.ToString()) ? (object)DBNull.Value : Convert.ToDouble(FilaGri.Cells[5].Value.ToString()));
                                NuevaConexionDetalle.ComandoSql.Parameters.AddWithValue("@PrecioDetalle", string.IsNullOrEmpty(FilaGri.Cells[4].Value.ToString()) ? (object)DBNull.Value : Convert.ToDouble(FilaGri.Cells[4].Value.ToString()));
                                NuevaConexionDetalle.ComandoSql.Parameters.AddWithValue("@ImporteDetalle", string.IsNullOrEmpty(FilaGri.Cells[6].Value.ToString()) ? (object)DBNull.Value : Convert.ToDouble(FilaGri.Cells[6].Value.ToString()));
                                NuevaConexionDetalle.ComandoSql.Parameters.AddWithValue("@EnlaceDetalle", string.IsNullOrEmpty(FilaGri.Cells[7].Value.ToString()) ? (object)DBNull.Value : FilaGri.Cells[7].Value.ToString());
                                NuevaConexionDetalle.ComandoSql.ExecuteNonQuery();
                                NuevaConexionDetalle.ComandoSql.Parameters.Clear();
                                i++;
                                 VALIDAR_Dtdetalle2 = "  Se Guardo Correctamente";
                            }


                        }
                        catch (Exception ex)
                        {
                            VALIDAR_DATOS = "ERROR";
                            VALIDAR_Dtdetalle2 = " Tabla Dtdetalle2 no Se guardo ((ERROR))";
                            MessageBox.Show(ex.Message, "ERROR AL GUARDAR dtdetalle2");
                        }
                        finally
                        {
                            if (NuevaConexionDetalle.CerrarConexionSql)
                            {

                            }
                        }

                    }
                }

            }

            if (VALIDAR_DATOS == "ERROR")
            {
                MessageBox.Show( VALIDAR_Dtfactura +"\n"+VALIDAR_Dtdetalle+"\n"+VALIDAR_Dtdetalle2, "GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // RestaraurarOjetosFatu();
                BtnCancelarfactura.Enabled = true;
            }
            else
            {
                MessageBox.Show("Guardado Correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RestaraurarOjetosFatu();
            }



        }
        public FormFacturar()
        {
            InitializeComponent();
            FormFacturar.menu2FACTURAR = this;
        }

        private void BtnNuevoFactura_Click(object sender, EventArgs e)
        {
            int VALORid = 1;
            this.tabControl1Factura.SelectedIndex = 0;
            if (this.dtConfiguracionPrincipalBindingSource.Count <= 0)
            {
                MessageBox.Show("Debe al Menos Crear Una Empresa", "EMPRESA");
                return;
            }
            if (this.dtConfiguracionPrincipalDtConfiBindingSource.Count <= 0)
            {
                MessageBox.Show("Debe Crear Ejercicio De Esta Empresa", "Falta Ejercicio");
                return;
            }
            if (this.SerieText.Text == string.Empty)
            {
                MessageBox.Show("No Existe Ninguna Serie", "NO EXISTE SERIE");
                return;
            }
            try
            {
                this.dtNuevaFacturaDataGridView.Refresh();
                this.dtNuevaFacturaDataGridView.Sort(this.dtNuevaFacturaDataGridView.Columns[0], ListSortDirection.Ascending);
                int numeroFILA = this.dtNuevaFacturaDataGridView.Rows.Count;
                this.dtNuevaFacturaBindingSource.AddNew();
                if (this.dtNuevaFacturaDataGridView.RowCount >= 0)
                {
                    if (this.dtNuevaFacturaDataGridView.CurrentCell.RowIndex == 0)
                    {
                        this.dtNuevaFacturaDataGridView.Rows[0].Cells[0].Value = "1";
                    }
                    if (numeroFILA > 0)
                    {
                        if (this.dtNuevaFacturaDataGridView.Rows[numeroFILA - 1].Cells[0].Value.ToString() == string.Empty)
                        {
                            Random rR = new Random();
                            VALORid = rR.Next(5000, 100000000);
                            this.dtNuevaFacturaDataGridView.Rows[numeroFILA].Cells[0].Value = (VALORid);
                            this.numeroFacturaTextBox.Text = VALORid.ToString();
                        }
                        else
                        {
                            VALORid = Convert.ToInt32(this.dtNuevaFacturaDataGridView.Rows[numeroFILA - 1].Cells[0].Value) + 1;
                            this.dtNuevaFacturaDataGridView.Rows[numeroFILA].Cells[0].Value = (VALORid);
                            this.numeroFacturaTextBox.Text = VALORid.ToString();

                        }
                    }
                Salto_Atras:
                    Random r = new Random();
                    int VALOR_MAS = r.Next(50000, 100000000);
                    this.EnlaceFactu.Text = this.NombreEmpresaReguistro.Text + " " + this.ejerciciosDeAñoComboBox.Text + " / " + this.SerieText.Text + VALORid + " / " + VALOR_MAS;
                    this.FechaFacturaDate.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now);
                    this.dtNuevaFacturaDataGridView.Rows[this.dtNuevaFacturaDataGridView.Rows.Count - 1].Selected = true;
                    // this.dtNuevaFacturaDataGridView.UseWaitCursor = true;
                    if (!ClasSi_Existe_Fatu.Buscar_Fatu_Sql(this.EnlaceFactu.Text))
                    {
                        this.EnlaceFactu.Text = "";
                        goto Salto_Atras;
                        // return;
                    }

                    this.dtNuevaFacturaBindingSource.EndEdit();

                    if (FormMenuPrincipal.menu2principal.dsMultidatos.DtArchivoDatosMulti.Count > 0)
                    {
                        if (FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["SerieProvinciaInicio"].ToString() != string.Empty)
                        {
                            this.provinciaComboBox.Text = FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["SerieProvinciaInicio"].ToString();
                        }
                        if (FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["SeriePaisInicio"].ToString() != string.Empty)
                        {
                            this.pais_FactComboBox.Text = FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["SeriePaisInicio"].ToString();
                        }
                    }
                    ModificarOjetosFatu();
                    BORRARerrores();

                    this.apodoTextBox.Focus();
                    // this.numeroFacturaTextBox.Enabled = false;
                    this.panelBotones.Tag = "Nuevo";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        private void BtnGuardarFactura_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.EnlaceFactu.Text))
            {
                MessageBox.Show("Datos Erradicos ", "FALTA ENLACE FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.tabControl1Factura.SelectedIndex = 0;
            BORRARerrores();
            //email_bien_escrito();
            if (VALIDARcampos())
            {
                if (this.dtDetallesFacturaBindingSource.Count < 1)
                {
                    this.tabControl1Factura.SelectedIndex = 1;
                    return;
                }
                if (ClasDatos.NombreFactura == "Nota 2")
                {
                    if (this.dtDetallesFactura2BindingSource.Count < 1)
                    {
                        this.tabControl1Factura.SelectedIndex = 2;
                        return;
                    }
                }
                if (MessageBox.Show(" ¿Aceptar Guardar ? ", " GUARDAR ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    int FILAcelda = this.dtNuevaFacturaDataGridView.CurrentCell.RowIndex;
                    if (this.cobradaFacturaCheckBox.Checked == true)
                    {
                        this.dsfacturas.DtNuevaFactura.Rows[FILAcelda]["CobradaFactura"] = "Cobrado";
                    }
                    else
                    {
                        this.dtNuevaFacturaDataGridView.Rows[FILAcelda].Cells[13].Value = "";
                        this.dsfacturas.DtNuevaFactura.Rows[FILAcelda]["FechaCobro"] = "";
                    }

                    if (ClsConexionSql.SibaseDatosSql)
                    {
                        GuardarFactuSql();
                    }
                    else
                    {
                        try
                        {
                            ClasDatos.ArchivoInicioFacturas = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + ClasDatos.RutaFactura + "\\" + ClasDatos.NombreFactura + "-" + this.NombreEmpresaReguistro.Text + this.ejerciciosDeAñoComboBox.Text + this.SerieText.Text + ".Xml";
                            if (File.Exists(ClasDatos.ArchivoInicioFacturas))
                            {
                                this.dsfacturas.Tables["DtNuevaFactura"].Rows[FILAcelda]["TipoNOTA"] = ClasDatos.NombreFactura;
                                this.dsfacturas.Tables["DtNuevaFactura"].Rows[FILAcelda]["IvaImpuesto"] = this.tipoInpuestoIVANumericUpDown.Value;

                                this.dtNuevaFacturaDataGridView.EndEdit();
                                this.dtDetallesFacturaDataGridView.EndEdit();
                                this.dtDetallesFacturaDataGridView2.EndEdit();
                                this.dtDetallesFacturaBindingSource.EndEdit();
                                this.dtDetallesFactura2BindingSource.EndEdit();
                                Validate();
                                this.dsfacturas.WriteXml(ClasDatos.ArchivoInicioFacturas);

                            }
                            else
                            {
                                this.dsfacturas.Tables["DtNuevaFactura"].Rows[FILAcelda]["TipoNOTA"] = ClasDatos.NombreFactura;
                                this.dsfacturas.Tables["DtNuevaFactura"].Rows[FILAcelda]["IvaImpuesto"] = this.tipoInpuestoIVANumericUpDown.Value;

                                this.dtNuevaFacturaDataGridView.EndEdit();
                                this.dtDetallesFacturaDataGridView.EndEdit();
                                this.dtDetallesFacturaDataGridView2.EndEdit();
                                this.dtDetallesFacturaBindingSource.EndEdit();
                                this.dtDetallesFactura2BindingSource.EndEdit();
                                Validate();
                                FormMenuPrincipal.menu2principal.CrearArchivosXml(ClasDatos.ArchivoInicioFacturas);
                                this.dsfacturas.WriteXml(ClasDatos.ArchivoInicioFacturas);

                            }
                            RestaraurarOjetosFatu();
                            MessageBox.Show("Guardado Correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message, "ERROR AL GUARDAR DATOS A ARCHIVO XML");
                        }
                    }



                }

            }
        }
        private void RestaraurarOjetosFatu()
        {
            //this.numeroFacturaTextBox.Enabled = false;
            this.BtnGuardarFactura.Enabled = false;
            this.BtnCancelarfactura.Enabled = false;
            this.panelBotones.Enabled = true;
            this.PanelArriba.Enabled = true;
            this.BtnBuscarClientesFact.Enabled = false;
            this.dtDetallesFacturaDataGridView.ReadOnly = true;
            this.dtDetallesFacturaDataGridView2.ReadOnly = true;
            this.dtNuevaFacturaDataGridView.Enabled = true;
            this.dtNuevaFacturaDataGridView.UseWaitCursor = false;
            this.cobradaFacturaCheckBox.Enabled = false;
            this.FechaFacturaDate.Enabled = false;
            foreach (Control ctrl in this.tabPage1Factura.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = false;
                    ctrl.ForeColor = Color.Black;
                }
                if (ctrl is ComboBox)
                {
                    ctrl.Enabled = false;
                    ctrl.ForeColor = Color.Black;
                }
            }
            foreach (Control ctrl in this.tabPage2Factura.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = false;

                }
            }
        }
        private void ModificarOjetosFatu()
        {
            this.dtNuevaFacturaDataGridView.Refresh();
            this.dtDetallesFacturaDataGridView.Refresh();
            this.dtDetallesFacturaDataGridView2.Refresh();
            this.BtnGuardarFactura.Enabled = true;
            this.BtnCancelarfactura.Enabled = true;
            this.panelBotones.Enabled = true;
            this.PanelArriba.Enabled = false;
            this.BtnBuscarClientesFact.Enabled = true;
            this.dtNuevaFacturaDataGridView.Enabled = false;
            this.dtDetallesFacturaDataGridView.ReadOnly = false;
            this.dtDetallesFacturaDataGridView2.ReadOnly = false;
            this.dtNuevaFacturaDataGridView.UseWaitCursor = true;
            this.cobradaFacturaCheckBox.Enabled = true;
            this.FechaFacturaDate.Enabled = true;
            this.dtNuevaFacturaDataGridView.Focus();
            foreach (Control ctrl in this.tabPage1Factura.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = true;
                    ctrl.ForeColor = Color.FromArgb(153, 40, 7);

                }
                if (ctrl is ComboBox)
                {
                    ctrl.Enabled = true;
                    ctrl.ForeColor = Color.FromArgb(153, 40, 7);
                }
            }
            foreach (Control ctrl in this.tabPage2Factura.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = true;

                }
            }

        }
        private void BtnCancelarfactura_Click(object sender, EventArgs e)
        {

            BORRARerrores();
            try
            {
                if (this.dtNuevaFacturaDataGridView.RowCount >= 0)
                {
                    if (this.panelBotones.Tag.ToString() == "Nuevo")
                    {
                        this.dtNuevaFacturaDataGridView.Rows.RemoveAt(this.dtNuevaFacturaDataGridView.CurrentCell.RowIndex);
                        this.dtDetallesFacturaBindingSource.Clear();
                        this.dtDetallesFactura2BindingSource.Clear();
                    }
                    else
                    {
                        ActualizarFacturaSql();
                    }

                }

                this.dtDetallesFacturaDataGridView.Refresh();
                this.dtNuevaFacturaDataGridView.Focus();
                // this.dtfacturas.DtDetallesFactura.Rows.Clear();
                // this.dtfacturas.DtDetallesFactura2.Rows.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            RestaraurarOjetosFatu();


        }

        private void BtnSalirFactura_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" ¿Salir Facturar ? ", " FACTURA ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void BtnModificarFactura_Click(object sender, EventArgs e)
        {
            if (this.dtNuevaFacturaDataGridView.Rows.Count > 0)
            {
                this.tabControl1Factura.SelectedIndex = 0;
                ModificarOjetosFatu();
                this.apodoTextBox.Focus();
                this.numeroFacturaTextBox.Enabled = false;
                this.panelBotones.Tag = "Modificar";
            }
        }

        private void ActualizarFacturaSql()
        {
            // string consulta = "SELECT * from DtNuevaFactura";
            string consulta = "select * FROM Dt"+ClasDatos.NombreFactura+" where  EmpresaEnlace = '" + this.NombreEmpresaReguistro.Text + " and" + "' Dt"+ClasDatos.NombreFactura+".EjercicioTipo ' = " + this.ejerciciosDeAñoComboBox.Text + " and " + "' Dt" + ClasDatos.NombreFactura + ".SerieTipo ' = " + this.SerieText.Text + "'";
            string consultaDetalle = "SELECT * from DtDetalles_" + ClasDatos.NombreFactura ;
            string consultaDetalle2 = "SELECT * from DtDetalles2_" + ClasDatos.NombreFactura;
            ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);

            try
            {
                if (NuevaConexion.SiConexionSql)
                {
                    SqlDataAdapter AdactaPelos = new SqlDataAdapter(consulta, ClsConexionSql.CadenaConexion);
                    AdactaPelos.Fill(this.dsfacturas.DtNuevaFactura);
                    AdactaPelos = new SqlDataAdapter(consultaDetalle, ClsConexionSql.CadenaConexion);
                    AdactaPelos.Fill(this.dsfacturas.DtDetallesFactura);
                    AdactaPelos = new SqlDataAdapter(consultaDetalle2, ClsConexionSql.CadenaConexion);
                    AdactaPelos.Fill(this.dsfacturas.DtDetallesFactura2);
                    AdactaPelos.Dispose();
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
        private void FormFACTURAR_Load(object sender, EventArgs e)
        {

            this.labelTipoNota.Text = ClasDatos.NombreFactura;
            this.Text = ClasDatos.NombreFactura;

            try
            {
                if (FormMenuPrincipal.menu2principal.articulos != null)
                {
                    this.dtArticulosBindingSource.DataSource = FormMenuPrincipal.menu2principal.articulos;
                }
                if (FormMenuPrincipal.menu2principal.dsClientes != null)
                {
                    this.dtClientesBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsClientes;
                }
                if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION != null)
                {
                    this.dtConfiguracionPrincipalBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION;
                    this.dtConfiBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION;
                    this.dtConfiguracionPrincipalBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION;
                    this.dtTarifaTipoBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION;

                }
                if (FormMenuPrincipal.menu2principal.dsMulti2 != null)
                {
                    this.dtObrasBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2;
                    this.dtProvinciasBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2;
                    this.dtPaisesBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2;
                    this.dtObrasBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2;
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
                    this.panelBotones.Enabled = false;
                    MessageBox.Show("Archivo : " + ClasDatos.RutaConfiguracionXml, "Falta Archivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }

                if (File.Exists(ClasDatos.RutaMultidatos))
                {
                    if (FormMenuPrincipal.menu2principal.dsMultidatos.DtInicioMulti.Count > 0)
                    {
                        // this.empresaENLACEComboBox.Focus();
                        if (FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["EjercicioInicio"].ToString() != string.Empty)
                        {
                            this.empresaENLACEComboBox.Text = FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["EmpresaInicio"].ToString();
                        }
                        if (FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["EjercicioInicio"].ToString() != string.Empty)
                        {
                            this.ejerciciosDeAñoComboBox.Text = FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["EjercicioInicio"].ToString();
                        }
                        if (FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["SerieInicio"].ToString() != string.Empty)
                        {
                            this.SerieText.Text = FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["SerieInicio"].ToString();
                        }
                        else
                        {
                            this.SerieText.Text = "A";
                        }


                        if (ClsConexionSql.SibaseDatosSql == false)
                        {

                            ClasDatos.ArchivoInicioFacturas = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + ClasDatos.RutaFactura + "\\" + ClasDatos.NombreFactura + "-" + this.NombreEmpresaReguistro.Text + this.ejerciciosDeAñoComboBox.Text + this.SerieText.Text + ".Xml";

                            string path = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + ClasDatos.RutaFactura;
                            if (Directory.Exists(path))
                            {
                                if (File.Exists(ClasDatos.ArchivoInicioFacturas))
                                {
                                    this.dsfacturas.ReadXml(ClasDatos.ArchivoInicioFacturas);

                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe Restructurar Sistema", "DIRECTORIO    " + ClasDatos.RutaFactura + "  NO EXISTE");
                                this.panelBotones.Enabled = false;
                                return;
                            }


                        }
                        else  //// si es sql activar letra
                        {

                        }

                    }

                }
                else
                {
                    MessageBox.Show("Falta Archivo De Datos", "ARCHIVO NO EXISTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }

            if (this.dtConfiBindingSource.Count > 0)
            {

                if (ClasDatos.NombreFactura == "Nota 2")
                {
                    // tabControl1Factura.TabPages.Insert(1, tabPage4Factura);
                    this.dtDetallesFacturaDataGridView.Columns[6].DefaultCellStyle.Format = "C" + this.NumPrecio.Value;
                    this.TotalFactura2.Visible = true;

                }
                else
                {
                    this.tabPage4Factura.Parent = null;
                    this.TotalFactura2.Visible = false;
                }

            }
            else
            {
                this.panelBotones.Enabled = false;
                MessageBox.Show("Debe Crear Ejercicio", "NUEVO");
            }
            this.BtnBuscarClientesFact.Enabled = false;
            if (this.dtNuevaFacturaBindingSource.Count > 0)
            {

                if (this.subTotalLabel2.Text != string.Empty)
                {
                    this.subTotalLabel2.Text = string.Format("{0:C" + this.NumPrecio.Value + "}", (this.subTotalLabel2.Text));
                    this.subTotalLabel2.Text = this.subTotalLabel2.Text.ToString();
                    this.baseIvaLabel2.Text = string.Format("{0:C" + this.NumPrecio.Value + "}", (this.baseIvaLabel2.Text));
                    this.TotalFactura1.Text = string.Format("{0:C" + this.NumPrecio.Value + "}", (this.TotalFactura1.Text));
                }
                this.dtDetallesFacturaDataGridView.Columns["ImporteDetalle"].DefaultCellStyle.Format = "C" + this.NumPrecio.Value;

                if (this.dtNuevaFacturaDataGridView.Rows[0].Cells[13].Value.ToString() == "Cobrado")
                {
                    this.cobradaFacturaCheckBox.Checked = true;
                }
                else
                {
                    this.cobradaFacturaCheckBox.Checked = false;
                }

            }
            if (ClsConexionSql.SibaseDatosSql)
            {

                ActualizarFacturaSql();
                // ActualizarPrincipal();
            }
            else
            {
                if (Directory.Exists(Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal))
                {
                    if (!File.Exists(ClasDatos.RutaConfiguracionXml))
                    {
                        this.panelBotones.Enabled = false;
                        MessageBox.Show("Archivo : " + ClasDatos.RutaConfiguracionXml, "Falta Archivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;


                    }

                }
            }
            if (this.NombreEmpresaReguistro.Text == string.Empty)
            {
                MessageBox.Show("Faltan Datos o Datos Erradicos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.panelBotones.Enabled = false;
            }
            if (this.SerieText.Text == string.Empty)
            {
                this.SerieText.Text = "A";
            }
            this.NombreEmpresaReguistro.Visible = false;
            // this.PanelArriba.Tag = "SI";
        }

        private void EmpresaENLACEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string EmpresaV = "NO";
            if (this.PanelArriba.Tag.ToString() == "SI")
            {
                if (this.empresaENLACEComboBox.SelectedIndex >= 0)
                {

                    if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtConfiguracionPrincipal"].Rows[this.empresaENLACEComboBox.SelectedIndex]["NombreEmpresaReguistro"].ToString() != string.Empty)
                    {
                      //  EmpresaV = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtConfiguracionPrincipal"].Rows[this.empresaENLACEComboBox.SelectedIndex]["NombreEmpresaReguistro"].ToString();
                        // this.NombreEmpresaReguistro.Text = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtConfiguracionPrincipal"].Rows[this.empresaENLACEComboBox.SelectedIndex]["NombreEmpresaReguistro"].ToString();
                    }
                    if (EmpresaV == string.Empty)
                    {
                        MessageBox.Show("Faltan Datos o Datos Erradicos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // ClasDatos.ArchivoInicioFacturas = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + ClasDatos.RutaFactura + "\\" + ClasDatos.NombreFactura + "-" + this.NombreEmpresaReguistro.Text + this.ejerciciosDeAñoComboBox.Text + this.SerieText.Text + ".Xml";
                    this.dtNuevaFacturaDataGridView.Refresh();

                }

                this.dsfacturas.Clear();

                if (ClsConexionSql.SibaseDatosSql)
                {
                    ActualizarFacturaSql();
                }
                else
                {
                    if (File.Exists(ClasDatos.ArchivoInicioFacturas))
                    {
                        this.dsfacturas.ReadXml(ClasDatos.ArchivoInicioFacturas);
                    }
                }


            }
        }

        private void EjerciciosDeAñoComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.PanelArriba.Tag.ToString() == "SI")
            {
                if (this.empresaENLACEComboBox.SelectedIndex >= 0)
                {

                    if (this.NombreEmpresaReguistro.Text == string.Empty)
                    {
                        MessageBox.Show("Faltan Datos o Datos Erradicos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    ClasDatos.ArchivoInicioFacturas = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + ClasDatos.RutaFactura + "\\" + ClasDatos.NombreFactura + "-" + this.NombreEmpresaReguistro.Text + this.ejerciciosDeAñoComboBox.Text + this.SerieText.Text + ".Xml";
                    this.dtNuevaFacturaDataGridView.Refresh();

                }

                this.dsfacturas.Clear();

                if (ClsConexionSql.SibaseDatosSql)
                {
                    ActualizarFacturaSql();
                }
                else
                {
                    if (File.Exists(ClasDatos.ArchivoInicioFacturas))
                    {
                        this.dsfacturas.ReadXml(ClasDatos.ArchivoInicioFacturas);
                    }
                }
            }
        }

        private void SerieText_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.PanelArriba.Tag.ToString() == "SI")
            {
                if (this.panelBotones.Enabled == true)
                {
                    if (this.SerieText.SelectedIndex >= 0)
                    {

                        if (this.NombreEmpresaReguistro.Text == string.Empty)
                        {
                            MessageBox.Show("Faltan Datos o Datos Erradicos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        ClasDatos.ArchivoInicioFacturas = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + ClasDatos.RutaFactura + "\\" + ClasDatos.NombreFactura + "-" + this.NombreEmpresaReguistro.Text + this.ejerciciosDeAñoComboBox.Text + this.SerieText.Text + ".Xml";
                        this.dtNuevaFacturaDataGridView.Refresh();

                    }

                }

                this.dsfacturas.Clear();
                if (ClsConexionSql.SibaseDatosSql)
                {
                    ActualizarFacturaSql();
                }
                else
                {
                    if (File.Exists(ClasDatos.ArchivoInicioFacturas))
                    {
                        this.dsfacturas.ReadXml(ClasDatos.ArchivoInicioFacturas);
                    }
                }
            }
        }

        private void DtDetallesFacturaDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (this.dtDetallesFacturaDataGridView.CurrentCell.ColumnIndex == 2 || this.dtDetallesFacturaDataGridView.CurrentCell.ColumnIndex == 4 || this.dtDetallesFacturaDataGridView.CurrentCell.ColumnIndex == 5)
            {
                // dtDetallesFacturaDataGridView.CurrentCell.EditedFormattedValue.ToString();

                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                    // this.SoloNumerosText += (e.KeyChar.ToString());
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                    this.SoloNumerosText = "";
                }
                else if ((e.KeyChar == ',') && (!this.dtDetallesFacturaDataGridView.CurrentCell.EditedFormattedValue.ToString().Contains(",")))
                {
                    e.Handled = false;
                    //  this.SoloNumerosText = (e.KeyChar.ToString());

                }

                else
                {
                    e.Handled = true;
                }
                if (this.dtDetallesFacturaDataGridView.CurrentCell.ColumnIndex == 2 || this.dtDetallesFacturaDataGridView.CurrentCell.ColumnIndex == 4)
                {
                    if ((e.KeyChar == '-') && (!this.dtDetallesFacturaDataGridView.CurrentCell.EditedFormattedValue.ToString().Contains("-")))
                    {
                        e.Handled = false;
                        // this.SoloNumerosText = (e.KeyChar.ToString());

                    }

                }

            }
            if (this.dtDetallesFacturaDataGridView.CurrentCell.ColumnIndex == 0)
            {


            }
        }

        private void DtDetallesFacturaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 1)
                {
                    if (this.dtArticulosBindingSource.Count < 0)
                    {
                        MessageBox.Show(" Archivo ARTICULOS No Existe O  VACIO ", " FALTA O VACIO ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        ClasDatos.ValorBuscado = e.RowIndex;
                        int numeroFILA = this.dtNuevaFacturaDataGridView.Rows.Count;
                        if (numeroFILA > 0)
                        {
                            if (this.BtnGuardarFactura.Enabled == true)
                            {
                                ClasDatos.OkFacturar = true;
                                ClasDatos.Datos1Datos2 = "Nota1";
                                // dtNuevaFacturaDataGridView.CurrentCell.Selected = false;
                                FormBuscarArticulos frm = new FormBuscarArticulos();
                                frm.FormClosed += (o, args) => numeroFILA = 1;
                                frm.FormClosed += (o, args) => CalcularImportes(this.dtDetallesFacturaDataGridView);
                                frm.Show();
                                frm.BringToFront();


                            }
                        }
                    }



                }
                if (e.ColumnIndex == 0 || e.ColumnIndex == 2 || e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6)
                {
                    if (this.dtDetallesFacturaDataGridView.CurrentCell.Value != null)
                    {
                        this.SoloNumerosText = this.dtDetallesFacturaDataGridView.CurrentCell.Value.ToString();
                    }

                }
                if (e.ColumnIndex == 2 || e.ColumnIndex == 4 || e.ColumnIndex == 5)
                {
                    if (this.dtDetallesFacturaDataGridView.CurrentCell.Value.ToString() == String.Empty)
                    {
                        this.dtDetallesFacturaDataGridView.CurrentCell.Value = 0;
                    }
                    this.dtDetallesFacturaDataGridView.BeginEdit(true);
                }
            }



        }

        private void DtDetallesFacturaDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewTextBoxEditingControl)
            {
                // AddHandler e.Control.KeyDown, AddressOf cell_KeyDown
                DataGridViewTextBoxEditingControl tb = e.Control as DataGridViewTextBoxEditingControl;
                tb.KeyPress -= DtDetallesFacturaDataGridView_KeyPress;
                tb.KeyPress += new KeyPressEventHandler(DtDetallesFacturaDataGridView_KeyPress);

            }
        }

        private void DtDetallesFacturaDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (this.BtnGuardarFactura.Enabled == false)
            {

                return;
            }
            if (this.dtDetallesFacturaDataGridView.Rows.Count > 0)
            {
                if (e.RowIndex > -1)
                {
                    if (e.ColumnIndex == 0)
                    {

                        if (this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[0].EditedFormattedValue.ToString() != string.Empty)
                        {
                            string Referencia = this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[0].EditedFormattedValue.ToString();
                            Referencia = Referencia.ToUpper();
                            this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[0].Value = Referencia.ToUpper();

                        }

                    }

                }
                if (e.ColumnIndex == 0)
                {
                    int FilaDescuentos = this.tarifaTipoComboBox.SelectedIndex * 2 + 5;
                    if (FilaDescuentos > 6)
                    {
                        // FilaDescuentos=FilaDescuentos +2;
                    }
                    if (this.tarifaTipoComboBox.SelectedIndex > 6)
                    {
                        FilaDescuentos = 6;
                    }

                    byte SIexiste = 0;
                    int I;
                    try
                    {
                        if (this.dtArticulosBindingSource.Count > 0)
                        {
                            I = 0;
                            if (this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != string.Empty)
                            {
                                foreach (DataRow fila in FormMenuPrincipal.menu2principal.articulos.DtArticulos.Rows)
                                {
                                    if (this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString().Equals(fila["Referencia"].ToString(), StringComparison.OrdinalIgnoreCase))
                                    {
                                        if (FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[I]["Referencia"].ToString() == this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString())
                                        {
                                            SIexiste = 1;
                                            if (FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[I]["Descripcci"].ToString() != String.Empty)
                                            {
                                                this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[3].Value = FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[I]["Descripcci"].ToString();
                                            }
                                            if (this.CheckDescuentos.Checked == false)
                                            {
                                                if (FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[I][FilaDescuentos] != DBNull.Value && FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[I][FilaDescuentos].ToString() != string.Empty)
                                                {
                                                    this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[4].Value = FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[I][FilaDescuentos].ToString();
                                                    this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[5].Value = DBNull.Value;
                                                }



                                            }

                                            if (this.CheckDescuentos.Checked == true)
                                            {
                                                if (FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[I]["Pvp1"] != DBNull.Value && FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[I]["Pvp1"].ToString() != string.Empty)
                                                {
                                                    this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[4].Value = FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[I]["Pvp1"].ToString();
                                                }
                                                else
                                                {
                                                    this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[4].Value = DBNull.Value;
                                                }

                                                if (FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[I][FilaDescuentos].ToString() != String.Empty && FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[I][FilaDescuentos] != DBNull.Value)
                                                {
                                                    this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[5].Value = FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[I][FilaDescuentos].ToString();
                                                }
                                                else
                                                {
                                                    this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[5].Value = DBNull.Value;
                                                }




                                            }

                                        }





                                    }

                                    I++;
                                }

                                if (SIexiste == 0)
                                {
                                    MessageBox.Show(this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(), "NO SE ENCONTRO ARTICULO");
                                    this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[0].Value = string.Empty;
                                }
                                if (this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString() == string.Empty || this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[2].Value == DBNull.Value)
                                {
                                    this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[2].Value = 0;

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }

                if (e.ColumnIndex == 2 || e.ColumnIndex == 4 || e.ColumnIndex == 5)
                {
                    if (this.dtDetallesFacturaDataGridView.CurrentCell.Value.ToString() == "0")
                    {
                        this.dtDetallesFacturaDataGridView.CurrentCell.Value = DBNull.Value;
                    }

                }
            }
            CalcularImportes(this.dtDetallesFacturaDataGridView);
        }

        private void BtnBuscarFactura_Click(object sender, EventArgs e)
        {

        }

        private void DtDetallesFacturaDataGridView_MouseEnter(object sender, EventArgs e)
        {
            FormMenuPrincipal.menu2principal.panelventas.Visible = false;
            FormMenuPrincipal.menu2principal.panelSUBventas.Visible = false;
        }

        private void TabPage1_MouseEnter(object sender, EventArgs e)
        {
            FormMenuPrincipal.menu2principal.panelventas.Visible = false;
            FormMenuPrincipal.menu2principal.panelSUBventas.Visible = false;
        }

        private void CobradaFacturaCheckBox_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void CobradaFacturaCheckBox_CheckStateChanged(object sender, EventArgs e)
        {

            if (this.dtNuevaFacturaBindingSource.Count >= 0)
            {

                //int FILAcelda = dtNuevaFacturaDataGridView.CurrentCell.RowIndex;

                if (this.cobradaFacturaCheckBox.Checked == true)
                {
                    this.fechaCobroMaskedTextBox.Text = "";
                    this.fechaCobroMaskedTextBox.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now);
                    // dtfacturas.DtNuevaFactura.Rows[FILAcelda]["CobradaFactura"] = "Cobrado";
                }
                else
                {
                    this.fechaCobroMaskedTextBox.Text = "";
                }
            }


        }

        private void DtNuevaFacturaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (this.panelBotones.Enabled == true)
                {
                    this.dtDetallesFacturaDataGridView.Columns["ImporteDetalle"].DefaultCellStyle.Format = "C" + this.NumPrecio.Value;
                    // dtNuevaFacturaDataGridView.Cursor = Cursors.AppStarting;
                    // Thread.Sleep(2000);
                    // dtNuevaFacturaDataGridView.Enabled = false;
                    // dtNuevaFacturaDataGridView.Cursor = Cursors.Default;
                    if (this.dtNuevaFacturaDataGridView.RowCount >= 0)
                    {
                        if (this.dtNuevaFacturaDataGridView.Rows[e.RowIndex].Cells[13].Value.ToString() == "Cobrado")
                        {
                            this.cobradaFacturaCheckBox.Checked = true;
                        }
                        else
                        {
                            this.cobradaFacturaCheckBox.Checked = false;
                        }

                    }
                }

            }


        }

        private void DtNuevaFacturaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DtNuevaFacturaDataGridView_MouseEnter(object sender, EventArgs e)
        {
            FormMenuPrincipal.menu2principal.panelventas.Visible = false;
            FormMenuPrincipal.menu2principal.panelSUBventas.Visible = false;
        }

        private void DtDetallesFacturaDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {

                this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[2].Value = DBNull.Value;
                this.dtDetallesFacturaDataGridView.CancelEdit();
                this.dtDetallesFacturaDataGridView.EndEdit();
                //MessageBox.Show(" Datos no Validos ", " CANTIDAD ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (e.ColumnIndex == 4)
            {

                this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[4].Value = DBNull.Value;
                this.dtDetallesFacturaDataGridView.CancelEdit();
                this.dtDetallesFacturaDataGridView.EndEdit();

            }
            else if (e.ColumnIndex == 5)
            {
                this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[5].Value = DBNull.Value;
                this.dtDetallesFacturaDataGridView.CancelEdit();
                this.dtDetallesFacturaDataGridView.EndEdit();
            }
            else if (e.ColumnIndex == 6)
            {
                this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[6].Value = DBNull.Value;
                this.dtDetallesFacturaDataGridView.CancelEdit();
                this.dtDetallesFacturaDataGridView.EndEdit();
            }
            else
            {
                MessageBox.Show(" No Validos ", " ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void BtnImprimirFactura_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i <= dtDetallesFacturaDataGridView.RowCount-1; i++)
            //{
            //  dt.Rows.Add(dtDetallesFacturaDataGridView.Rows[i].Cells[0].Value, dtDetallesFacturaDataGridView.Rows[i].Cells[1].Value,
            //     dtDetallesFacturaDataGridView.Rows[i].Cells[2].Value, dtDetallesFacturaDataGridView.Rows[i].Cells[3].Value, 
            //       dtDetallesFacturaDataGridView.Rows[i].Cells[4].Value, dtDetallesFacturaDataGridView.Rows[i].Cells[5].Value, dtDetallesFacturaDataGridView.Rows[i].Cells[6].Value);

            // }
            //FormReporteFactura.menu2Reporte.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("", dt));   
            if (this.dtNuevaFacturaBindingSource.Count <= 0)
            {
                MessageBox.Show("Nada Que Imprimir ", " IMPRIMIR ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (this.a == "1")
            {
                this.a = "2";
                ClasDatos.OkFacturar = true;
                ClasDatos.QUEform = "Facturar";
                FormImprimirTodo frm = new FormImprimirTodo();
                frm.FormClosed += (o, args) => this.a = "1";
                frm.ShowDialog();
                frm.BringToFront();

            }
        }

        private void FormFACTURAR_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.PanelArriba.Tag = "N0";
            if (this.BtnGuardarFactura.Enabled == true & this.BtnSalirFactura.Visible == false)
            {
                e.Cancel = true;
            }

        }

        private void DtDetallesFacturaDataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 1)
                {
                    if (!File.Exists(ClasDatos.Articulos))
                    {
                        MessageBox.Show(" Archivo ARTICULOS No Existe ", " FALTA ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    ClasDatos.ValorBuscado = e.RowIndex;
                    int numeroFILA = this.dtNuevaFacturaDataGridView.Rows.Count;
                    if (numeroFILA > 0)
                    {
                        if (this.BtnGuardarFactura.Enabled == true)
                        {
                            ClasDatos.OkFacturar = true;
                            ClasDatos.Datos1Datos2 = "Nota2";
                            this.dtNuevaFacturaDataGridView.CurrentCell.Selected = false;
                            FormBuscarArticulos frm = new FormBuscarArticulos();
                            frm.FormClosed += (o, args) => numeroFILA = 1;
                            frm.FormClosed += (o, args) => CalcularImportes(this.dtDetallesFacturaDataGridView2);
                            frm.ShowDialog();
                            frm.BringToFront();


                        }
                    }


                }
                if (e.ColumnIndex == 2 || e.ColumnIndex == 4 || e.ColumnIndex == 5)
                {
                    if (this.dtDetallesFacturaDataGridView2.CurrentCell.Value != null)
                    {
                        this.SoloNumerosText = this.dtDetallesFacturaDataGridView2.CurrentCell.Value.ToString();
                    }

                }
            }
        }

        private void DtDetallesFacturaDataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 2 || e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6)
                {
                    CalcularImportes(this.dtDetallesFacturaDataGridView2);

                }
            }

        }

        private void DtDetallesFacturaDataGridView2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.dtDetallesFacturaDataGridView2.CurrentCell.ColumnIndex == 2 || this.dtDetallesFacturaDataGridView2.CurrentCell.ColumnIndex == 4 || this.dtDetallesFacturaDataGridView2.CurrentCell.ColumnIndex == 5)
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                    this.SoloNumerosText += (e.KeyChar.ToString());
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                    this.SoloNumerosText = "";
                }
                else if ((e.KeyChar == ',') && (!this.SoloNumerosText.Contains(",")))
                {
                    e.Handled = false;
                    this.SoloNumerosText = (e.KeyChar.ToString());

                }

                else
                {
                    e.Handled = true;
                }
                if (this.dtDetallesFacturaDataGridView2.CurrentCell.ColumnIndex == 2 || this.dtDetallesFacturaDataGridView2.CurrentCell.ColumnIndex == 4)
                {
                    if ((e.KeyChar == '-') && (!this.SoloNumerosText.Contains("-")))
                    {
                        e.Handled = false;
                        this.SoloNumerosText = (e.KeyChar.ToString());

                    }

                }

            }
        }

        private void DtDetallesFacturaDataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                this.dtDetallesFacturaDataGridView2.Rows[e.RowIndex].Cells[2].Value = DBNull.Value;
                this.dtDetallesFacturaDataGridView2.CancelEdit();
                this.dtDetallesFacturaDataGridView2.EndEdit();
            }
            else if (e.ColumnIndex == 4)
            {

                this.dtDetallesFacturaDataGridView2.Rows[e.RowIndex].Cells[4].Value = DBNull.Value;
                this.dtDetallesFacturaDataGridView2.CancelEdit();
                this.dtDetallesFacturaDataGridView2.EndEdit();
            }
            else if (e.ColumnIndex == 5)
            {
                this.dtDetallesFacturaDataGridView2.Rows[e.RowIndex].Cells[5].Value = DBNull.Value;
                this.dtDetallesFacturaDataGridView2.CancelEdit();
                this.dtDetallesFacturaDataGridView2.EndEdit();
            }

            else
            {
                MessageBox.Show(" No Validos ", " ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DtDetallesFacturaDataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewTextBoxEditingControl)
            {
                DataGridViewTextBoxEditingControl tb = e.Control as DataGridViewTextBoxEditingControl;
                tb.KeyPress -= DtDetallesFacturaDataGridView2_KeyPress;
                tb.KeyPress += new KeyPressEventHandler(DtDetallesFacturaDataGridView2_KeyPress);
            }
        }

        private void TabControl1Factura_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.tabControl1Factura.TabPages.Count == 4)
            {
                if (this.tabControl1Factura.SelectedIndex == 2)
                {
                    this.panelTotales.Visible = false;
                    this.TotalFactura1.Visible = false;
                    this.TotalFactura2.Visible = true;

                }
                else
                {
                    this.panelTotales.Visible = true;
                    this.TotalFactura1.Visible = true;
                    this.TotalFactura2.Visible = false;
                }

            }
        }

        private void BtnBuscarClientesFact_Click(object sender, EventArgs e)
        {
            if (this.dtDetallesFacturaBindingSource.Count < 0 || this.dtDetallesFactura2BindingSource.Count < 0)
            {
                return;
            }

            if (FormMenuPrincipal.menu2principal.articulos.DtArticulos.Count < 1)
            {

                MessageBox.Show("No Hay Clientes", " ARCHIVO NO EXISTE O VACIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ClasDatos.ValorBuscado = this.dtNuevaFacturaDataGridView.CurrentCell.RowIndex;
            int numeroFILA = this.dtNuevaFacturaDataGridView.Rows.Count;
            if (numeroFILA >= 0)
            {

                ClasDatos.OkFacturar = true;
                ClasDatos.Datos1Datos2 = "Nota1";
                // dtNuevaFacturaDataGridView.CurrentCell.Selected = false;
                FormBuscarClientes frm = new FormBuscarClientes();
                frm.FormClosed += (o, args) => numeroFILA = 1;
                frm.ShowDialog();
                frm.BringToFront();
            }
        }

        private void DtDetallesFacturaDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.dtDetallesFacturaDataGridView.CurrentCell.RowIndex == this.dtDetallesFacturaBindingSource.Count - 1)
            {
                // dtDetallesFacturaBindingSource.AddNew();
            }
        }


        private void BtnEnviarMailFactura_Click(object sender, EventArgs e)
        {
            // int I = 5;
            // MessageBox.Show(dtDetallesFacturaDataGridView.Rows[I].Cells[7].FormattedValue.ToString());
            MessageBox.Show(this.dtDetallesFacturaBindingSource.ToString());
            MessageBox.Show(this.dsfacturas.DtDetallesFactura.Rows[4][0].ToString());
            MessageBox.Show(this.dtDetallesFacturaBindingSource.DataMember.ToString());
        }



        private void BuscarReferencia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.dtNuevaFacturaDataGridView.Rows.Count < 0)
                {
                    return;
                }
                int fila = this.dtDetallesFacturaDataGridView.CurrentCell.RowIndex;
                if (fila == 0)
                {
                    if (this.dtArticulosBindingSource.Count > 0)
                    {
                        for (int I = 0; I <= this.dtArticulosBindingSource.Count - 1; I++)
                        {

                            if (FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[I]["Referencia"].ToString().Contains(this.dtDetallesFacturaDataGridView.Rows[fila].Cells[0].Value.ToString()))
                            {
                                this.dtDetallesFacturaDataGridView.Rows[fila].Cells[0].Value = FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[I]["Referencia"].ToString();
                                this.dtDetallesFacturaDataGridView.Rows[fila].Cells[3].Value = FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[I]["Descripcci"].ToString();
                                this.dtDetallesFacturaDataGridView.Rows[fila].Cells[4].Value = FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[I]["Pvp1"].ToString();
                            }
                        }

                    }
                }
            }
            catch (Exception)
            {

                // throw;
            }
        }




        private void NumDescuento_ValueChanged(object sender, EventArgs e)
        {
            this.dtDetallesFacturaDataGridView.Columns[5].DefaultCellStyle.Format = "N" + this.NumDescuento.Value;
            this.dtDetallesFacturaDataGridView2.Columns[5].DefaultCellStyle.Format = "N" + this.NumDescuento.Value;

        }

        private void Numimporte_ValueChanged(object sender, EventArgs e)
        {

            this.dtDetallesFacturaDataGridView.Columns["ImporteDetalle"].DefaultCellStyle.Format = "C" + this.Numimporte.Value;
            if (ClasDatos.NombreFactura == "Nota 2")
            {

                this.dtDetallesFacturaDataGridView2.Columns[6].DefaultCellStyle.Format = "C" + this.Numimporte.Value;

            }


        }

        private void NumTotales_ValueChanged(object sender, EventArgs e)
        {
            this.baseIvaLabel2.Text = string.Format("{0:C" + this.NumTotales.Value + "}", this.baseIvaLabel2.Text);
            this.TotalFactura1.Text = string.Format("{0:C" + this.NumTotales.Value + "}", this.TotalFactura1.Text.ToString());
            this.subTotalLabel2.Text = string.Format("{0:C" + this.NumTotales.Value + "}", this.subTotalLabel2.Text);
            CalcularImportes(this.dtDetallesFacturaDataGridView);
            if (ClasDatos.NombreFactura == "Nota 2")
            {
                CalcularImportes(this.dtDetallesFacturaDataGridView2);
            }

            Validate();
        }

        private void NumPrecio_ValueChanged(object sender, EventArgs e)
        {
            this.dtDetallesFacturaDataGridView.Columns[4].DefaultCellStyle.Format = "C" + this.NumPrecio.Value;
            this.dtDetallesFacturaDataGridView2.Columns[4].DefaultCellStyle.Format = "C" + this.NumPrecio.Value;
        }

        private void CheckDescuentos_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void AñadirId()
        {
            int ii = 0;
            foreach (DataRow fila in FormMenuPrincipal.menu2principal.articulos.DtArticulos.Rows)
            {
                FormMenuPrincipal.menu2principal.articulos.Tables["DtArticulos"].Rows[ii]["IdFILA"] = ii.ToString();
                ii++;
            }

        }
        private void CheckDescuentos_Click(object sender, EventArgs e)
        {
            if (this.tarifaTipoComboBox.SelectedIndex < 2 || this.tarifaTipoComboBox.SelectedIndex > 5)
            {
                MessageBox.Show("Pvp1" + "\n" + "Pvp2" + "\n" + "Plus" + "\n" + "Iva", "NO VALIDO", MessageBoxButtons.OK);
                return;
            }
            if (this.CheckDescuentos.Checked == false)
            {
                this.CheckDescuentos.Text = "Añadiendo Descuento";
                this.CheckDescuentos.Checked = true;
            }
            else
            {
                this.CheckDescuentos.Text = "Añadiendo Precio";
                this.CheckDescuentos.Checked = false;
            }
        }

        private void TarifaTipoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tarifaTipoComboBox.SelectedIndex < 2 || this.tarifaTipoComboBox.SelectedIndex > 5)
            {
                this.CheckDescuentos.Checked = false;
            }
        }

        private void DtDetallesFacturaDataGridView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 0)
                {

                    if (this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[0].EditedFormattedValue.ToString() != string.Empty)
                    {
                        string Referencia = this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[0].EditedFormattedValue.ToString();
                        //Referencia.ToUpper((System.Globalization.CultureInfo)this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[0].Value);
                        // Referencia = Referencia.ToUpper();
                        //this.dtDetallesFacturaDataGridView.Rows[e.RowIndex].Cells[0].Value = Referencia.ToUpper();

                    }

                }

            }
        }


        private void Pais_FactComboBox_Click(object sender, EventArgs e)
        {
            this.pais_FactComboBox.DroppedDown = true;
            this.pais_FactComboBox.SelectAll();
        }

        private void ProvinciaComboBox_Click(object sender, EventArgs e)
        {
            this.provinciaComboBox.DroppedDown = true;
            // provinciaComboBox.SelectAll();
        }

        private void obrasComboBox_Click(object sender, EventArgs e)
        {
            this.obrasComboBox.DroppedDown = true;
        }

        private void dtDetallesFacturaDataGridView_Validating(object sender, CancelEventArgs e)
        {

        }

        private void dtDetallesFacturaDataGridView_Validated(object sender, EventArgs e)
        {
            if (this.dtDetallesFacturaBindingSource.Count > 0)
            {
                if (this.dtDetallesFacturaDataGridView.CurrentCell.ColumnIndex == 2 || this.dtDetallesFacturaDataGridView.CurrentCell.ColumnIndex == 4)
                {
                    int i = this.dtDetallesFacturaDataGridView.CurrentCell.RowIndex;
                    if (this.dtDetallesFacturaDataGridView.Rows[i].Cells[4].Value.ToString() == "0" || this.dtDetallesFacturaDataGridView.Rows[i].Cells[2].Value.ToString() == "0")
                    {
                        this.dtDetallesFacturaDataGridView.Rows[i].Cells[7].Value = DBNull.Value;
                    }
                }
            }

        }

        private void BtnEliminarFactura_Click(object sender, EventArgs e)
        {
            if (this.dtDetallesFacturaDataGridView.Rows.Count > 0)
            {
                if (MessageBox.Show(" ¿Eliminar: " + ClasDatos.NombreFactura, " ELIMINAR ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    // this.dtfacturas.DtNuevaFactura.ChildRelations.RemoveAt(this.dtDetallesFacturaDataGridView.CurrentCell.RowIndex);

                    if (ClsConexionSql.SibaseDatosSql)
                    {
                        String Consulta = "DELETE FROM [DtNuevaFactura] WHERE ElaceFactura=" + Convert.ToInt32(this.EnlaceFactu.Text);

                        ClsConexionSql NuevaConexion = new ClsConexionSql(Consulta);
                        if (NuevaConexion.SiConexionSql)
                        {
                            try
                            {
                                NuevaConexion.ComandoSql.ExecuteNonQuery();
                                this.dtNuevaFacturaDataGridView.Rows.RemoveAt(this.dtNuevaFacturaDataGridView.CurrentCell.RowIndex);
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message, "ERROR AL GUARDAR DATOS TABLA DETALLE2");
                            }
                            finally
                            {
                                if (NuevaConexion.CerrarConexionSql)
                                {

                                }
                            }
                        }
                    }
                    else
                    {
                        if (File.Exists(ClasDatos.ArchivoInicioFacturas))
                        {
                            //this.dtfacturas.DtDetallesFactura.Clear();
                            //dtDetallesFacturaBindingSource.AddNew();
                            int FILA = this.dtNuevaFacturaDataGridView.CurrentCell.RowIndex;
                            int TFilas = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfiguracionPrincipal.Count;
                            XmlDocument doc = new XmlDocument();
                            if (File.Exists(ClasDatos.ArchivoInicioFacturas))
                            {
                                doc.Load(ClasDatos.ArchivoInicioFacturas);
                                try
                                {
                                    foreach (XmlNode n1 in doc.DocumentElement.ChildNodes)
                                    {
                                        XmlNodeList elemList = doc.GetElementsByTagName("DtDetallesFactura");
                                        //MessageBox.Show(NombreEmpresa7.ToString()+1);
                                        foreach (XmlNode n2 in elemList)
                                        {
                                            if (n2.ChildNodes.Item(0).Name == "EnlaceDetalle")
                                            {
                                                String NombreId = n2.ChildNodes.Item(0).InnerText;
                                                //MessageBox.Show(n2.ChildNodes.Item(0).Value+ n2.ChildNodes.Item(1).Value);
                                                if (NombreId.ToString() == this.numeroFacturaTextBox.Text.ToString())
                                                {

                                                    // n2.RemoveAll();
                                                    //  MessageBox.Show(this.empresaConfiTextBox.Text.ToString(), "YA EXISTE ESTA EMPRESA", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                                }



                                            }

                                        }

                                    }
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.Message.ToString());
                                }
                            }


                            this.dtDetallesFacturaDataGridView.Rows.RemoveAt(this.dtDetallesFacturaDataGridView.RowCount - 2);
                            this.dtDetallesFacturaBindingSource.AddNew();
                            this.dtNuevaFacturaDataGridView.Rows.RemoveAt(this.dtNuevaFacturaDataGridView.CurrentCell.RowIndex);
                            this.dsfacturas.WriteXml(ClasDatos.ArchivoInicioFacturas);
                            this.dtNuevaFacturaDataGridView.EndEdit();
                            this.dtDetallesFacturaDataGridView.EndEdit();
                        }
                    }

                    MessageBox.Show("Eliminado con exito", "ELIMINAR");
                    this.dtNuevaFacturaDataGridView.Refresh();
                }

            }
        }

        private void dtDetallesFacturaDataGridView2_Validated(object sender, EventArgs e)
        {
            if (this.dtDetallesFacturaDataGridView2.CurrentCell.ColumnIndex == 2 || this.dtDetallesFacturaDataGridView2.CurrentCell.ColumnIndex == 4)
            {
                int i = this.dtDetallesFacturaDataGridView2.CurrentCell.RowIndex;
                if (this.dtDetallesFacturaDataGridView2.Rows[i].Cells[4].Value.ToString() == "0" || this.dtDetallesFacturaDataGridView2.Rows[i].Cells[2].Value.ToString() == "0")
                {
                    this.dtDetallesFacturaDataGridView2.Rows[i].Cells[6].Value = DBNull.Value;
                }
            }

        }
        private void MenuDatagriClick(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                string NombreItem = e.ClickedItem.Name.ToString();
                int Fila = this.dtDetallesFacturaDataGridView.CurrentCell.RowIndex;
                if (NombreItem.Contains("DuplicarLinea"))
                {
                    NombreItem = NombreItem.Replace("DuplicarLinea", "");
                    //  this.dtDetallesFacturaBindingSource.Insert(1, this.dtDetallesFacturaBindingSource.AddNew());


                    //  this.dtDetallesFacturaBindingSource.Insert(Fila, this.dtDetallesFacturaDataGridView.Rows[Fila].Cells[2].Value.ToString());
                    //dtDetallesFacturaDataGridView.Rows.Insert(0, dtDetallesFacturaDataGridView.Rows[Fila].Cells[2].Value );
                    // borrar(int.Parse(id));

                }
                if (NombreItem.Contains("Lineablanco"))
                {
                    NombreItem = NombreItem.Replace("Lineablanco", "");

                }
                if (NombreItem.Contains("Nueva linea En Blanco"))
                {
                    NombreItem = NombreItem.Replace("Nueva linea En Blanco", "");
                    Fila = this.dtDetallesFacturaDataGridView.CurrentCell.RowIndex+1;
                    // DataRow FilaNueva = new DataTable(dtd);
                    DataTable dt = (DataTable)this.dtDetallesFacturaBindingSource.DataSource;
                    var row = dt.NewRow();
                    //this.dtDetallesFacturaBindingSource.Insert(Fila, row);
                    this.dtDetallesFacturaDataGridView.Rows.Add(Fila, row);
                }
                if (NombreItem.Contains("EliminarLinea"))
                {
                    // NombreItem = NombreItem.Replace("EliminarLinea", "");
                    Fila = this.dtDetallesFacturaDataGridView.CurrentCell.RowIndex;
                    // dtDetallesFacturaBindingSource.RemoveCurrent();
                    this.dtDetallesFacturaDataGridView.Rows.RemoveAt(Fila);
                }
                if (NombreItem.Contains("DuplicarArticulo"))
                {
                    // NombreItem = NombreItem.Replace("DuplicarArticulo", "");
                    Fila = this.dtDetallesFacturaDataGridView.CurrentCell.RowIndex;

                }
                if (NombreItem.Contains("NuevoArticulo"))
                {
                    this.dtDetallesFacturaBindingSource.AddNew();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void dtDetallesFacturaDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                int posicion = this.dtDetallesFacturaDataGridView.HitTest(e.X, e.Y).RowIndex;
                if (posicion > -1)
                {
                    menu.Items.Add("Duplicar Linea").Name = "DuplicarLinea" + posicion;
                    menu.Items.Add("nueva Linea en Blanco").Name = "Lineablanco" + posicion;
                    menu.Items.Add("Eliminar Linea").Name = "EliminarLinea" + posicion;
                    menu.Items.Add("Duplicar Esta Linea").Name = "DuplicarArticulo" + posicion;
                    menu.Items.Add("Nuevo Articulo").Name = "NuevoArticulo" + posicion;
                }
                menu.Show(this.dtDetallesFacturaDataGridView, e.X, e.Y);
                menu.ItemClicked += new ToolStripItemClickedEventHandler(MenuDatagriClick);
            }
        }
        public Boolean email_bien_escritoFactu()
        {
            String expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(this.dniTextBox.Text, expresion))
            {
                if (Regex.Replace(this.dniTextBox.Text, expresion, String.Empty).Length == 0)
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
        private void dniTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.dniTextBox.Text))
            {
                if (!email_bien_escritoFactu())
                {
                    MessageBox.Show("D.n.i No Valido", "INVALIDO");
                    //this.dniTextBox.Focus();
                }

            }
        }

        private void empresaENLACEComboBox_MouseEnter(object sender, EventArgs e)
        {
            this.NombreEmpresaReguistro.Visible = true;
        }

        private void empresaENLACEComboBox_MouseLeave(object sender, EventArgs e)
        {
            this.NombreEmpresaReguistro.Visible = false;
        }

        private void empresaENLACEComboBox_Click(object sender, EventArgs e)
        {
            this.PanelArriba.Tag = "SI";
        }

        private void ejerciciosDeAñoComboBox_Click(object sender, EventArgs e)
        {
            this.PanelArriba.Tag = "SI";
        }

        private void SerieText_Click(object sender, EventArgs e)
        {
            this.PanelArriba.Tag = "SI";
        }

        private void tipoInpuestoIVALabel1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show(this.NombreEmpresaReguistro.Text);
        }

        private void empresaENLACEComboBox_Leave(object sender, EventArgs e)
        {
            ClasDatos.ArchivoInicioFacturas = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + ClasDatos.RutaFactura + "\\" + ClasDatos.NombreFactura + "-" + this.NombreEmpresaReguistro.Text + this.ejerciciosDeAñoComboBox.Text + this.SerieText.Text + ".Xml";
            //MessageBox.Show(ClasDatos.ArchivoInicioFacturas);
        }

        private void empresaENLACEComboBox_Validated(object sender, EventArgs e)
        {
            ClasDatos.ArchivoInicioFacturas = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + ClasDatos.RutaFactura + "\\" + ClasDatos.NombreFactura + "-" + this.NombreEmpresaReguistro.Text + this.ejerciciosDeAñoComboBox.Text + this.SerieText.Text + ".Xml";
        }
    }
}








