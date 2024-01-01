using Comun;
using ComunApp;
using Conexiones;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace PELOSCALVO
{
    public partial class FormFacturar : Form
    {
        public static FormFacturar menu2FACTURAR;
        string SoloNumerosText = "";
        string a = "1";
        public FormFacturar()
        {
            InitializeComponent();
            FormFacturar.menu2FACTURAR = this;
            ToolTip InfoEliminar = new ToolTip();
            InfoEliminar.SetToolTip(this.BtnEliminarFactura, "Eliminar Factura");
            InfoEliminar.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            InfoEliminar.IsBalloon = true;
            ToolTip Info = new ToolTip();
            Info.SetToolTip(this.BtnNuevoFactura, "Nueva Factura");
            Info.SetToolTip(this.BtnModificarFactura, "Moodificar Factura");
            Info.SetToolTip(this.BtnBuscarFactura, "Buscar Factura");
            // Info.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
        }
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

            try
            {
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
                            this.subTotal.Text = string.Format("{0:C" + this.NumPrecio.Value + "}", (0));
                            this.baseIva.Text = string.Format("{0:C" + this.NumPrecio.Value + "}", (0));
                            this.TotalFactura1.Text = string.Format("{0:C" + this.NumPrecio.Value + "}", (0));
                        }
                        else
                        {
                            this.subTotal.Text = string.Format("{0:C" + this.NumPrecio.Value + "}", (TTotalSuma));
                            this.baseIva.Text = string.Format("{0:C" + this.NumPrecio.Value + "}", (TTotalSuma - sumaIva));
                            this.TotalFactura1.Text = string.Format("{0:C" + this.NumPrecio.Value + "}", (TTotalSuma + (TTotalSuma - sumaIva)));
                        }
                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "CALCULAR IMPORTES");
            }

        }
        private void LlenarGrid(DataGridView dataGrid, int valor)
        {
            int II = 0;
            try
            {
                // dtDetallesFacturaBindingSource.Clear();
                foreach (var item in ClasDetalleGrid.Listadetalle1.lista)
                {
                    if (valor == 1)
                    {
                        if (dataGrid.RowCount > ClasDetalleGrid.Listadetalle1.lista.Count + 1)
                        {
                            // this.dtDetallesFacturaBindingSource.RemoveCurrent();
                            this.dtDetallesFacturaDataGridView.Rows.RemoveAt(this.dtDetallesFacturaDataGridView.RowCount);
                        }
                        if (this.dtDetallesFacturaDataGridView.RowCount < ClasDetalleGrid.Listadetalle1.lista.Count + 1)
                        {
                            this.dtDetallesFacturaBindingSource.AddNew();
                        }

                    }
                    else
                    {
                        if (dataGrid.RowCount > ClasDetalleGrid.Listadetalle2.lista.Count + 1)
                        {
                            // this.dtDetallesFactura2BindingSource.RemoveCurrent();
                            this.dtDetallesFacturaDataGridView2.Rows.RemoveAt(this.dtDetallesFacturaDataGridView2.RowCount);
                        }
                        if (dataGrid.RowCount < ClasDetalleGrid.Listadetalle2.lista.Count + 1)
                        {
                            this.dtDetallesFactura2BindingSource.AddNew();
                        }

                    }


                    if (!string.IsNullOrEmpty(item.Referencia))
                    {
                        dataGrid.Rows[II].Cells[0].Value = item.Referencia;
                    }
                    if (!string.IsNullOrEmpty(item.Cantidad))
                    {
                        dataGrid.Rows[II].Cells[2].Value = item.Cantidad;
                    }
                    if (!string.IsNullOrEmpty(item.Descripcci))
                    {
                        dataGrid.Rows[II].Cells[3].Value = item.Descripcci;
                    }
                    if (!string.IsNullOrEmpty(item.Precio))
                    {
                        dataGrid.Rows[II].Cells[4].Value = item.Precio;
                    }
                    if (!string.IsNullOrEmpty(item.Descuento))
                    {
                        dataGrid.Rows[II].Cells[5].Value = item.Descuento;
                    }
                    if (!string.IsNullOrEmpty(item.Iva))
                    {
                        dataGrid.Rows[II].Cells[6].Value = item.Iva;
                    }
                    if (!string.IsNullOrEmpty(item.Importe))
                    {
                        dataGrid.Rows[II].Cells[7].Value = item.Importe;
                    }
                    II++;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void ExtraerGrid(DataGridView dataGrid, int valor)
        {
            try
            {
                int V = 0;
                if (valor == 1)
                {
                    ClasDetalleGrid.Listadetalle1.lista.Clear();
                }
                else
                {
                    ClasDetalleGrid.Listadetalle2.lista.Clear();
                }

                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    if (V >= dataGrid.RowCount - 1)
                    {
                        break;
                    }
                    ClasDetalleGrid.Detalle item = new ClasDetalleGrid.Detalle();
                    if (row.Cells[0].Value.ToString() != string.Empty)
                    {
                        item.Referencia = row.Cells[0].Value.ToString();
                    }
                    if (row.Cells[2].Value.ToString() != string.Empty)
                    {
                        item.Cantidad = row.Cells[2].Value.ToString();
                    }
                    if (row.Cells[3].Value.ToString() != string.Empty)
                    {
                        item.Descripcci = row.Cells[3].Value.ToString();
                    }
                    if (row.Cells[4].Value.ToString() != string.Empty)
                    {
                        item.Precio = row.Cells[4].Value.ToString();
                    }
                    if (row.Cells[5].Value.ToString() != string.Empty)
                    {
                        item.Descuento = row.Cells[5].Value.ToString();
                    }
                    if (valor == 1)
                    {
                        if (row.Cells[6].Value.ToString() != string.Empty)
                        {
                            item.Iva = row.Cells[6].Value.ToString();
                        }
                    }
                    if (valor == 1)
                    {
                        if (row.Cells[7].Value.ToString() != string.Empty)
                        {
                            item.Importe = row.Cells[7].Value.ToString();
                        }
                    }
                    else
                    {
                        if (row.Cells[6].Value.ToString() != string.Empty)
                        {
                            item.Importe = row.Cells[6].Value.ToString();
                        }
                    }

                    if (valor == 1)
                    {
                        ClasDetalleGrid.Listadetalle1.lista.Add(item);
                    }
                    else
                    {
                        ClasDetalleGrid.Listadetalle2.lista.Add(item);
                    }

                    V++;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
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
            if (String.IsNullOrEmpty(this.AlmacenTxt.Text))
            {
                ok = false;
                this.errorProvider1.SetError(this.AlmacenTxt, "_ingresar Almacen (( minimo 1 Caracteres))");
            }
            return ok;

        }
        private void BORRARerrores()
        {
            this.errorProvider1.SetError(this.apodoTextBox, "");
            this.errorProvider1.SetError(this.nombreTextBox, "");
            this.errorProvider1.SetError(this.direccionTextBox, "");
            this.errorProvider1.SetError(this.dniTextBox, "");
            this.errorProvider1.SetError(this.NumeroFactura, "");
        }


        public void GuardarFactuDB()
        {
            Random r = new Random();
            int Id_valor = r.Next(3, 99999);
            string VALIDAR_DATOS = "";
            string VALIDAR_Dtfactura = "  Se Guardo Correctamente";
            string VALIDAR_Dtdetalle = "  Se Guardo Correctamente";
            string VALIDAR_Dtdetalle2 = "";
            string Consulta = "";
            int EnlaceDtconfi = 0;
            int Id = this.ejerciciosDeAñoComboBox.SelectedIndex + 1;
            if (!String.IsNullOrEmpty(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtConfi"].Rows[Id]["IdEnlace"].ToString()))
            {
                EnlaceDtconfi = Convert.ToInt32(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtConfi"].Rows[Id]["IdEnlace"].ToString());
            }
            else
            {
                panelBotones.Enabled = false;
                MessageBox.Show("No Se Puede Continuar", "ERROR FALTAN DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string ConsultaEliminar = "DELETE FROM [DtDetalles_" + ClasDatos.NombreFactura + "] WHERE [EnlaceDetalle]= '@EnlaceFactu'";
            string ConsultaEliminar2 = "DELETE FROM [DtDetalles2_" + ClasDatos.NombreFactura + "] WHERE [EnlaceDetalle]='@EnlaceFactu'";
            string ConsultaDetalle = "INSERT INTO [DtDetalles_" + ClasDatos.NombreFactura + "] ([ReferenciaDetalle],[CantidadDetalle],[DescripccionDetalle]," +
             " [PrecioDetalle],[DescuentoDetalle],[IvaDetalle] ,[ImporteDetalle],[EnlaceDetalle])" +
             " VALUES( @ReferenciaDetalle, @CantidadDetalle, @DescripccionDetalle, @PrecioDetalle, " +
             " @DescuentoDetalle, @IvaDetalle, @ImporteDetalle, @EnlaceDetalle) ";

            string ConsultaDetalle2 = "INSERT INTO [DtDetalles2_" + ClasDatos.NombreFactura + "] ([ReferenciaDetalle],[CantidadDetalle],[DescripccionDetalle]" +
                         " ,[PrecioDetalle],[DescuentoDetalle],[ImporteDetalle],[EnlaceDetalle])" +
                         " VALUES( @ReferenciaDetalle, @CantidadDetalle, @DescripccionDetalle, @PrecioDetalle, " +
                         " @DescuentoDetalle, @ImporteDetalle, @EnlaceDetalle) ";
            if (this.panelBotones.Tag.ToString() == "Nuevo")
            {
                Consulta = "INSERT INTO [Dt" + ClasDatos.NombreFactura + "]([EnlaceFactura],[NumeroFactura],[Apodo] ,[Nombre],[Direccion],[Calle]" +
                ",[NumeroCalle] ,[Dni],[Localidad],[Provincia],[CodigoPostal],[NonbreAlmacen]" +
                ",[IvaImpuesto],[SubTotal],[BaseIva] ,[TotalFactura],[TotalFactura2],[Pais_Fact]" +
                " ,[TipoNOTA],[Obra_factu],[EjercicioTipo],[SerieTipo],[EmpresaEnlace],[FechaFactura],[FechaCobro],[CobradaFactura],[EnlaceDtconfi])" +
               " VALUES(@EnlaceFactura, @NumeroFactura, @Apodo, @Nombre, @Direccion, @Calle, " +
               "@NumeroCalle, @Dni, @Localidad, @Provincia, @CodigoPostal, @NonbreAlmacen," +
                " @IvaImpuesto, @SubTotal, @BaseIva, @TotalFactura, @TotalFactura2," +
                " @Pais_Fact, @TipoNOTA, @Obra_factu, @EjercicioTipo,@SerieTipo,@EmpresaEnlace, @FechaFactura, @FechaCobro, @CobradaFactura, @EnlaceDtconfi)";

            }
            else
            {
                Consulta = "UPDATE [Dt" + ClasDatos.NombreFactura + "] SET [EnlaceFactura]= @EnlaceFactura, [NumeroFactura] = @NumeroFactura,[Apodo] = @Apodo,[Nombre] = @Nombre," +
               " [Direccion] = @Direccion, [Calle] = @Calle, [NumeroCalle] = @NumeroCalle, [Dni] = @Dni," +
               " [Localidad] = @Localidad, [Provincia] = @Provincia,[CodigoPostal] = @CodigoPostal, " +
               " [NonbreAlmacen] = @NonbreAlmacen, [IvaImpuesto] = @IvaImpuesto, [SubTotal] = @SubTotal," +
               " [BaseIva] = @BaseIva, [TotalFactura] = @TotalFactura, [TotalFactura2] = @TotalFactura2, " +
               " [Pais_Fact] = @Pais_Fact,[TipoNOTA] = @TipoNOTA, [Obra_factu] = @Obra_factu, [EjercicioTipo] = @EjercicioTipo," +
               "[SerieTipo]= @SerieTipo,[EmpresaEnlace]=@EmpresaEnlace, [FechaFactura] = @FechaFactura ,[FechaCobro] = @FechaCobro , [CobradaFactura] = @CobradaFactura, [EnlaceDtconfi] = @EnlaceDtconfi WHERE [EnlaceFactura] = @EnlaceFactura";

            }

            ClsConexionDb NuevaConexion = new ClsConexionDb(Consulta);


            if (NuevaConexion.SiConexionDb)
            {
                NuevaConexion.ComandoDb.Parameters.AddWithValue("@EnlaceFactura", string.IsNullOrEmpty(this.EnlaceFactu.Text) ? (object)DBNull.Value : this.EnlaceFactu.Text);
                NuevaConexion.ComandoDb.Parameters.AddWithValue("@NumeroFactura", string.IsNullOrEmpty(this.NumeroFactura.Text) ? (object)DBNull.Value : Convert.ToInt32(this.NumeroFactura.Text));
                NuevaConexion.ComandoDb.Parameters.AddWithValue("@Apodo", string.IsNullOrEmpty(this.apodoTextBox.Text) ? (object)DBNull.Value : this.apodoTextBox.Text);
                NuevaConexion.ComandoDb.Parameters.AddWithValue("@Nombre", string.IsNullOrEmpty(this.nombreTextBox.Text) ? (object)DBNull.Value : this.nombreTextBox.Text);
                NuevaConexion.ComandoDb.Parameters.AddWithValue("@Direccion", string.IsNullOrEmpty(this.direccionTextBox.Text) ? (object)DBNull.Value : this.direccionTextBox.Text);
                NuevaConexion.ComandoDb.Parameters.AddWithValue("@Calle", string.IsNullOrEmpty(this.calleTextBox.Text) ? (object)DBNull.Value : this.calleTextBox.Text);
                NuevaConexion.ComandoDb.Parameters.AddWithValue("@NumeroCalle", string.IsNullOrEmpty(this.numeroCalleTextBox.Text) ? (object)DBNull.Value : this.numeroCalleTextBox.Text);
                NuevaConexion.ComandoDb.Parameters.AddWithValue("@Dni", string.IsNullOrEmpty(this.dniTextBox.Text) ? (object)DBNull.Value : this.dniTextBox.Text);
                NuevaConexion.ComandoDb.Parameters.AddWithValue("@Localidad", string.IsNullOrEmpty(this.localidadTextBox.Text) ? (object)DBNull.Value : this.localidadTextBox.Text);
                NuevaConexion.ComandoDb.Parameters.AddWithValue("@Provincia", string.IsNullOrEmpty(this.provinciaComboBox.Text) ? (object)DBNull.Value : this.provinciaComboBox.Text);
                NuevaConexion.ComandoDb.Parameters.AddWithValue("@CodigoPostal", string.IsNullOrEmpty(this.codigoPostalTextBox.Text) ? (object)DBNull.Value : this.codigoPostalTextBox.Text);
                NuevaConexion.ComandoDb.Parameters.AddWithValue("@NonbreAlmacen", string.IsNullOrEmpty(this.AlmacenTxt.Text) ? (object)DBNull.Value : this.AlmacenTxt.Text);
                NuevaConexion.ComandoDb.Parameters.AddWithValue("@IvaImpuesto", string.IsNullOrEmpty(this.tipoInpuestoIVANumericUpDown.Value.ToString()) ? (object)DBNull.Value : Convert.ToInt32(this.tipoInpuestoIVANumericUpDown.Value.ToString()));
                NuevaConexion.ComandoDb.Parameters.AddWithValue("@SubTotal", string.IsNullOrEmpty(this.subTotal.Text) ? (object)DBNull.Value : Convert.ToDouble(this.subTotal.Text.Replace("€", "")));
                NuevaConexion.ComandoDb.Parameters.AddWithValue("@BaseIva", string.IsNullOrEmpty(this.baseIva.Text) ? (object)DBNull.Value : Convert.ToDouble(this.baseIva.Text.Replace("€", "")));
                NuevaConexion.ComandoDb.Parameters.AddWithValue("@TotalFactura", string.IsNullOrEmpty(this.TotalFactura1.Text) ? (object)DBNull.Value : Convert.ToDouble(this.TotalFactura1.Text.Replace("€", "")));
                NuevaConexion.ComandoDb.Parameters.AddWithValue("@TotalFactura2", string.IsNullOrEmpty(this.TotalFactura2.Text) ? (object)DBNull.Value : Convert.ToDouble(this.TotalFactura2.Text.Replace("€", "")));
                NuevaConexion.ComandoDb.Parameters.AddWithValue("@Pais_Fact", string.IsNullOrEmpty(this.pais_FactComboBox.Text) ? (object)DBNull.Value : this.pais_FactComboBox.Text);
                NuevaConexion.ComandoDb.Parameters.AddWithValue("@TipoNOTA", string.IsNullOrEmpty(this.TipoNota.Text) ? (object)DBNull.Value : this.TipoNota.Text);
                NuevaConexion.ComandoDb.Parameters.AddWithValue("@Obra_factu", string.IsNullOrEmpty(this.obrasComboBox.Text) ? (object)DBNull.Value : this.obrasComboBox.Text);
                NuevaConexion.ComandoDb.Parameters.AddWithValue("@EjercicioTipo", string.IsNullOrEmpty(this.ejerciciosDeAñoComboBox.Text) ? (object)DBNull.Value : this.ejerciciosDeAñoComboBox.Text);
                NuevaConexion.ComandoDb.Parameters.AddWithValue("@SerieTipo", string.IsNullOrEmpty(this.SerieText.Text) ? (object)DBNull.Value : this.SerieText.Text);
                NuevaConexion.ComandoDb.Parameters.AddWithValue("@EmpresaEnlace", string.IsNullOrEmpty(this.Id_Empresa.Text) ? (object)DBNull.Value : this.Id_Empresa.Text);
                NuevaConexion.ComandoDb.Parameters.AddWithValue("@FechaFactura", string.IsNullOrEmpty(this.FechaFactura.Text) ? (object)DBNull.Value : this.FechaFactura.Text);


                if (this.cobradaFacturaCheckBox.Checked)
                {
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@FechaCobro", string.IsNullOrEmpty(this.fechaCobroText.Text) ? (object)DBNull.Value : this.fechaCobroText.Text);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@CobradaFactura", "Cobrado");///canbiar valor a cobrada
                }
                else
                {
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@FechaCobro", DBNull.Value);
                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@CobradaFactura", (object)DBNull.Value);///canbiar valor a cobrada
                }
                NuevaConexion.ComandoDb.Parameters.AddWithValue("@EnlaceDtconfi", string.IsNullOrEmpty(EnlaceDtconfi.ToString()) ? (object)DBNull.Value : EnlaceDtconfi);
                try
                {
                    NuevaConexion.ComandoDb.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    VALIDAR_DATOS = "ERROR";
                    VALIDAR_Dtfactura = " Tabla" + ClasDatos.NombreFactura + "  no Se guardo ((ERROR))";
                    MessageBox.Show(ex.Message, "ERROR AL GUARDAR DATOS TABLA PRINCIPAL");
                }
                finally
                {
                    if (NuevaConexion.CerrarConexionDB)
                    {

                    }
                }
                NuevaConexion.ComandoDb.Parameters.Clear();

                if (this.panelBotones.Tag.ToString() == "Modificar")
                {

                    if (this.dtNuevaFacturaDataGridView.RowCount > 0)
                    {
                        ClsConexionDb ConexionDetalleEliminar = new ClsConexionDb(ConsultaEliminar);
                        if (ConexionDetalleEliminar.SiConexionDb)
                        {
                            try
                            {
                                ConexionDetalleEliminar.ComandoDb.Parameters.AddWithValue("@EnlaceFactu", this.EnlaceFactu.Text);
                                ConexionDetalleEliminar.ComandoDb.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message, "ERROR AL GUARDAR ELIMINANDO DATOS1");
                            }
                            finally
                            {
                                if (ConexionDetalleEliminar.CerrarConexionDB)
                                {
                                    ConexionDetalleEliminar.ComandoDb.Parameters.Clear();
                                }
                            }
                        }

                    }
                }

                if (this.dtDetallesFacturaDataGridView.RowCount >= 0)
                {
                    ClsConexionDb NuevaConexionDetalle = new ClsConexionDb(ConsultaDetalle);
                    if (NuevaConexionDetalle.SiConexionDb)
                    {
                        try
                        {
                            foreach (DataGridViewRow FilaGri in this.dtDetallesFacturaDataGridView.Rows)
                            {
                                if (this.dtDetallesFacturaDataGridView.AllowUserToAddRows == true)
                                {
                                    if (FilaGri.Index == this.dtDetallesFacturaDataGridView.RowCount - 1)
                                    {
                                        break;
                                    }
                                }

                                NuevaConexionDetalle.ComandoDb.Parameters.AddWithValue("@ReferenciaDetalle", string.IsNullOrEmpty(FilaGri.Cells[0].Value.ToString()) ? (object)DBNull.Value : FilaGri.Cells[0].Value.ToString());
                                NuevaConexionDetalle.ComandoDb.Parameters.AddWithValue("@CantidadDetalle", string.IsNullOrEmpty(FilaGri.Cells[2].Value.ToString()) ? (object)DBNull.Value : Convert.ToDouble(FilaGri.Cells[2].Value.ToString()));
                                NuevaConexionDetalle.ComandoDb.Parameters.AddWithValue("@DescripccionDetalle", string.IsNullOrEmpty(FilaGri.Cells[3].Value.ToString()) ? (object)DBNull.Value : FilaGri.Cells[3].Value.ToString());
                                NuevaConexionDetalle.ComandoDb.Parameters.AddWithValue("@PrecioDetalle", string.IsNullOrEmpty(FilaGri.Cells[4].Value.ToString()) ? (object)DBNull.Value : Convert.ToDouble(FilaGri.Cells[4].Value.ToString()));
                                NuevaConexionDetalle.ComandoDb.Parameters.AddWithValue("@DescuentoDetalle", string.IsNullOrEmpty(FilaGri.Cells[5].Value.ToString()) ? (object)DBNull.Value : Convert.ToDouble(FilaGri.Cells[5].Value.ToString()) * 100);
                                NuevaConexionDetalle.ComandoDb.Parameters.AddWithValue("@IvaDetalle", string.IsNullOrEmpty(FilaGri.Cells[6].Value.ToString()) ? (object)DBNull.Value : Convert.ToDouble(FilaGri.Cells[6].Value.ToString()));
                                NuevaConexionDetalle.ComandoDb.Parameters.AddWithValue("@ImporteDetalle", string.IsNullOrEmpty(FilaGri.Cells[7].Value.ToString()) ? (object)DBNull.Value : Convert.ToDouble(FilaGri.Cells[7].Value.ToString()));
                                NuevaConexionDetalle.ComandoDb.Parameters.AddWithValue("@EnlaceDetalle", string.IsNullOrEmpty(FilaGri.Cells[8].Value.ToString()) ? (object)DBNull.Value : FilaGri.Cells[8].Value.ToString());
                                NuevaConexionDetalle.ComandoDb.ExecuteNonQuery();
                                NuevaConexionDetalle.ComandoDb.Parameters.Clear();
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
                            if (NuevaConexionDetalle.CerrarConexionDB)
                            {
                                NuevaConexionDetalle.ComandoDb.Parameters.Clear();
                            }
                        }
                    }
                }

                if (this.dtDetallesFacturaDataGridView2.RowCount >= 0 && ClasDatos.NombreFactura == "Nota2")
                {
                    if (this.panelBotones.Tag.ToString() == "Modificar")
                    {

                        if (this.dtNuevaFacturaDataGridView.RowCount >= 0)
                        {
                            ClsConexionDb ConexionDetalleEliminar2 = new ClsConexionDb(ConsultaEliminar2);
                            if (ConexionDetalleEliminar2.SiConexionDb)
                            {
                                try
                                {
                                    ConexionDetalleEliminar2.ComandoDb.Parameters.AddWithValue("@EnlaceFactu", this.EnlaceFactu.Text);
                                    ConexionDetalleEliminar2.ComandoDb.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.Message, "ERROR AL GUARDAR ELIMINANDO DATOS2");
                                }
                                finally
                                {
                                    if (ConexionDetalleEliminar2.CerrarConexionDB)
                                    {
                                        ConexionDetalleEliminar2.ComandoDb.Parameters.Clear();
                                    }
                                }
                            }
                        }
                    }
                    ClsConexionDb NuevaConexionDetalle = new ClsConexionDb(ConsultaDetalle2);
                    if (NuevaConexionDetalle.SiConexionDb)
                    {
                        try
                        {
                            foreach (DataGridViewRow FilaGri in this.dtDetallesFacturaDataGridView2.Rows)
                            {
                                if (this.dtDetallesFacturaDataGridView2.AllowUserToAddRows == true)
                                {
                                    if (FilaGri.Index == this.dtDetallesFacturaDataGridView2.RowCount - 1)
                                    {
                                        break;
                                    }
                                }

                                NuevaConexionDetalle.ComandoDb.Parameters.AddWithValue("@ReferenciaDetalle", string.IsNullOrEmpty(FilaGri.Cells[0].Value.ToString()) ? (object)DBNull.Value : FilaGri.Cells[0].Value.ToString());
                                NuevaConexionDetalle.ComandoDb.Parameters.AddWithValue("@CantidadDetalle", string.IsNullOrEmpty(FilaGri.Cells[2].Value.ToString()) ? (object)DBNull.Value : Convert.ToDouble(FilaGri.Cells[2].Value.ToString()));
                                NuevaConexionDetalle.ComandoDb.Parameters.AddWithValue("@DescripccionDetalle", string.IsNullOrEmpty(FilaGri.Cells[3].Value.ToString()) ? (object)DBNull.Value : FilaGri.Cells[3].Value.ToString());
                                NuevaConexionDetalle.ComandoDb.Parameters.AddWithValue("@PrecioDetalle", string.IsNullOrEmpty(FilaGri.Cells[4].Value.ToString()) ? (object)DBNull.Value : Convert.ToDouble(FilaGri.Cells[4].Value.ToString()));
                                NuevaConexionDetalle.ComandoDb.Parameters.AddWithValue("@DescuentoDetalle", string.IsNullOrEmpty(FilaGri.Cells[5].Value.ToString()) ? (object)DBNull.Value : Convert.ToDouble(FilaGri.Cells[5].Value.ToString()) * 100);
                                NuevaConexionDetalle.ComandoDb.Parameters.AddWithValue("@ImporteDetalle", string.IsNullOrEmpty(FilaGri.Cells[6].Value.ToString()) ? (object)DBNull.Value : Convert.ToDouble(FilaGri.Cells[6].Value.ToString()));
                                NuevaConexionDetalle.ComandoDb.Parameters.AddWithValue("@EnlaceDetalle", string.IsNullOrEmpty(FilaGri.Cells[7].Value.ToString()) ? (object)DBNull.Value : FilaGri.Cells[7].Value.ToString());
                                NuevaConexionDetalle.ComandoDb.ExecuteNonQuery();
                                NuevaConexionDetalle.ComandoDb.Parameters.Clear();
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
                            if (NuevaConexionDetalle.CerrarConexionDB)
                            {
                                NuevaConexionDetalle.ComandoDb.Parameters.Clear();
                            }
                        }

                    }
                }
                if (this.panelBotones.Tag.ToString() == "Modificar")
                {
                    GuardarRestaurarStockDb();
                }
                GuardarStockDb(this.dtDetallesFacturaDataGridView);
            }

            if (VALIDAR_DATOS == "ERROR")
            {
                MessageBox.Show(VALIDAR_Dtfactura + "\n" + VALIDAR_Dtdetalle + "\n" + VALIDAR_Dtdetalle2, "GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // RestaraurarOjetosFatu();
                this.BtnCancelarfactura.Enabled = true;
            }
            else
            {
                this.dtDetallesFacturaBindingSource.EndEdit();
                this.dtNuevaFacturaBindingSource.EndEdit();
                this.dtDetallesFactura2BindingSource.EndEdit();
                Validate();
                MessageBox.Show("Guardado Correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RestaraurarOjetosFatu();
            }
        }

        public void GuardarFactuSql()
        {
            Random r = new Random();
            int Id_valor = r.Next(3, 99999);
            string VALIDAR_DATOS = "";
            string VALIDAR_Dtfactura = "  Se Guardo Correctamente";
            string VALIDAR_Dtdetalle = "  Se Guardo Correctamente";
            string VALIDAR_Dtdetalle2 = "";
            string Consulta = "";
            int EnlaceDtconfi = 0;
            int Id = this.ejerciciosDeAñoComboBox.SelectedIndex + 1;
            if (!String.IsNullOrEmpty( FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtConfi"].Rows[Id]["EnlaceDtconfi"].ToString()))
            {
                EnlaceDtconfi = Convert.ToInt32(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtConfi"].Rows[Id]["EnlaceDtconfi"].ToString());
            }
            else
            {
                panelBotones.Enabled = false;
                MessageBox.Show("No Se Puede Continuar", "ERROR FALTAN DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string ConsultaEliminar = "DELETE FROM [DtDetalles_" + ClasDatos.NombreFactura + "] WHERE [EnlaceDetalle]= '@EnlaceFactu'";
            string ConsultaEliminar2 = "DELETE FROM [DtDetalles2_" + ClasDatos.NombreFactura + "] WHERE [EnlaceDetalle]='@EnlaceFactu'";
            string ConsultaDetalle = "INSERT INTO [DtDetalles_" + ClasDatos.NombreFactura + "] ([ReferenciaDetalle],[CantidadDetalle],[DescripccionDetalle]," +
              " [PrecioDetalle],[DescuentoDetalle],[IvaDetalle] ,[ImporteDetalle],[EnlaceDetalle])" +
              " VALUES( @ReferenciaDetalle, @CantidadDetalle, @DescripccionDetalle, @PrecioDetalle, " +
              " @DescuentoDetalle, @IvaDetalle, @ImporteDetalle, @EnlaceDetalle) ";

            string ConsultaDetalle2 = "INSERT INTO [DtDetalles2_" + ClasDatos.NombreFactura + "] ([ReferenciaDetalle],[CantidadDetalle],[DescripccionDetalle]" +
                 " ,[PrecioDetalle],[DescuentoDetalle],[ImporteDetalle],[EnlaceDetalle])" +
                 " VALUES( @ReferenciaDetalle, @CantidadDetalle, @DescripccionDetalle, @PrecioDetalle, " +
                 " @DescuentoDetalle, @ImporteDetalle, @EnlaceDetalle) ";
            if (this.panelBotones.Tag.ToString() == "Nuevo")
            {
                Consulta = "INSERT INTO [Dt" + ClasDatos.NombreFactura + "]([EnlaceFactura],[NumeroFactura],[Apodo] ,[Nombre],[Direccion],[Calle]" +
                ",[NumeroCalle] ,[Dni],[Localidad],[Provincia],[CodigoPostal],[NonbreAlmacen]" +
                ",[IvaImpuesto],[SubTotal],[BaseIva] ,[TotalFactura],[TotalFactura2],[Pais_Fact]" +
                " ,[TipoNOTA],[Obra_factu],[EjercicioTipo],[SerieTipo],[EmpresaEnlace],[FechaFactura],[FechaCobro],[CobradaFactura],[EnlaceDtconfi])" +
               " VALUES(@EnlaceFactura, @NumeroFactura, @Apodo, @Nombre, @Direccion, @Calle, " +
               "@NumeroCalle, @Dni, @Localidad, @Provincia, @CodigoPostal, @NonbreAlmacen," +
                " @IvaImpuesto, @SubTotal, @BaseIva, @TotalFactura, @TotalFactura2," +
                " @Pais_Fact, @TipoNOTA, @Obra_factu, @EjercicioTipo,@SerieTipo,@EmpresaEnlace, @FechaFactura, @FechaCobro, @CobradaFactura,@EnlaceDtconfi)";

            }
            else
            {
                Consulta = "UPDATE [Dt" + ClasDatos.NombreFactura + "] SET [EnlaceFactura]= @EnlaceFactura, [NumeroFactura] = @NumeroFactura,[Apodo] = @Apodo,[Nombre] = @Nombre," +
               " [Direccion] = @Direccion, [Calle] = @Calle, [NumeroCalle] = @NumeroCalle, [Dni] = @Dni," +
               " [Localidad] = @Localidad, [Provincia] = @Provincia,[CodigoPostal] = @CodigoPostal, " +
               " [NonbreAlmacen] = @NonbreAlmacen, [IvaImpuesto] = @IvaImpuesto, [SubTotal] = @SubTotal," +
               " [BaseIva] = @BaseIva, [TotalFactura] = @TotalFactura, [TotalFactura2] = @TotalFactura2, " +
               " [Pais_Fact] = @Pais_Fact,[TipoNOTA] = @TipoNOTA, [Obra_factu] = @Obra_factu, [EjercicioTipo] = @EjercicioTipo," +
               "[SerieTipo]= @SerieTipo,[EmpresaEnlace]=@EmpresaEnlace, [FechaFactura] = @FechaFactura ,[FechaCobro] = @FechaCobro , [CobradaFactura] = @CobradaFactura, [EnlaceDtconfi] = @EnlaceDtconfi WHERE [EnlaceFactura] = @EnlaceFactura";

            }

            ClsConexionSql NuevaConexion = new ClsConexionSql(Consulta);


            if (NuevaConexion.SiConexionSql)
            {
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@EnlaceFactura", string.IsNullOrEmpty(this.EnlaceFactu.Text) ? (object)DBNull.Value : this.EnlaceFactu.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@NumeroFactura", string.IsNullOrEmpty(this.NumeroFactura.Text) ? (object)DBNull.Value : Convert.ToInt32(this.NumeroFactura.Text));
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@Apodo", string.IsNullOrEmpty(this.apodoTextBox.Text) ? (object)DBNull.Value : this.apodoTextBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@Nombre", string.IsNullOrEmpty(this.nombreTextBox.Text) ? (object)DBNull.Value : this.nombreTextBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@Direccion", string.IsNullOrEmpty(this.direccionTextBox.Text) ? (object)DBNull.Value : this.direccionTextBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@Calle", string.IsNullOrEmpty(this.calleTextBox.Text) ? (object)DBNull.Value : this.calleTextBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@NumeroCalle", string.IsNullOrEmpty(this.numeroCalleTextBox.Text) ? (object)DBNull.Value : this.numeroCalleTextBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@Dni", string.IsNullOrEmpty(this.dniTextBox.Text) ? (object)DBNull.Value : this.dniTextBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@Localidad", string.IsNullOrEmpty(this.localidadTextBox.Text) ? (object)DBNull.Value : this.localidadTextBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@Provincia", string.IsNullOrEmpty(this.provinciaComboBox.Text) ? (object)DBNull.Value : this.provinciaComboBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@CodigoPostal", string.IsNullOrEmpty(this.codigoPostalTextBox.Text) ? (object)DBNull.Value : this.codigoPostalTextBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@NonbreAlmacen", string.IsNullOrEmpty(this.AlmacenTxt.Text) ? (object)DBNull.Value : this.AlmacenTxt.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@IvaImpuesto", string.IsNullOrEmpty(this.tipoInpuestoIVANumericUpDown.Value.ToString()) ? (object)DBNull.Value : Convert.ToInt32(this.tipoInpuestoIVANumericUpDown.Value.ToString()));
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@SubTotal", string.IsNullOrEmpty(this.subTotal.Text) ? (object)DBNull.Value : Convert.ToDouble(this.subTotal.Text.Replace("€", "")));
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@BaseIva", string.IsNullOrEmpty(this.baseIva.Text) ? (object)DBNull.Value : Convert.ToDouble(this.baseIva.Text.Replace("€", "")));
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@TotalFactura", string.IsNullOrEmpty(this.TotalFactura1.Text) ? (object)DBNull.Value : Convert.ToDouble(this.TotalFactura1.Text.Replace("€", "")));
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@TotalFactura2", string.IsNullOrEmpty(this.TotalFactura2.Text) ? (object)DBNull.Value : Convert.ToDouble(this.TotalFactura2.Text.Replace("€", "")));
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@Pais_Fact", string.IsNullOrEmpty(this.pais_FactComboBox.Text) ? (object)DBNull.Value : this.pais_FactComboBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@TipoNOTA", string.IsNullOrEmpty(this.TipoNota.Text) ? (object)DBNull.Value : this.TipoNota.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@Obra_factu", string.IsNullOrEmpty(this.obrasComboBox.Text) ? (object)DBNull.Value : this.obrasComboBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@EjercicioTipo", string.IsNullOrEmpty(this.ejerciciosDeAñoComboBox.Text) ? (object)DBNull.Value : this.ejerciciosDeAñoComboBox.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@SerieTipo", string.IsNullOrEmpty(this.SerieText.Text) ? (object)DBNull.Value : this.SerieText.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@EmpresaEnlace", string.IsNullOrEmpty(this.Id_Empresa.Text) ? (object)DBNull.Value : this.Id_Empresa.Text);
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@FechaFactura", string.IsNullOrEmpty(this.FechaFactura.Text) ? (object)DBNull.Value : this.FechaFactura.Text);


                if (this.cobradaFacturaCheckBox.Checked)
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@FechaCobro", string.IsNullOrEmpty(this.fechaCobroText.Text) ? (object)DBNull.Value : this.fechaCobroText.Text);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@CobradaFactura", "Cobrado");///canbiar valor a cobrada
                }
                else
                {
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@FechaCobro", DBNull.Value);
                    NuevaConexion.ComandoSql.Parameters.AddWithValue("@CobradaFactura", (object)DBNull.Value);///canbiar valor a cobrada
                }
                NuevaConexion.ComandoSql.Parameters.AddWithValue("@EnlaceDtconfi", string.IsNullOrEmpty(EnlaceDtconfi.ToString()) ? (object)DBNull.Value : EnlaceDtconfi);
                try
                {
                    NuevaConexion.ComandoSql.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    VALIDAR_DATOS = "ERROR";
                    VALIDAR_Dtfactura = " Tabla" + ClasDatos.NombreFactura + "  no Se guardo ((ERROR))";
                    MessageBox.Show(ex.Message, "ERROR AL GUARDAR DATOS TABLA PRINCIPAL");
                }
                finally
                {
                    if (NuevaConexion.CerrarConexionSql)
                    {

                    }
                }
                NuevaConexion.ComandoSql.Parameters.Clear();

                if (this.panelBotones.Tag.ToString() == "Modificar")
                {

                    if (this.dtNuevaFacturaDataGridView.RowCount > 0)
                    {
                        ClsConexionSql ConexionDetalleEliminar = new ClsConexionSql(ConsultaEliminar);
                        if (ConexionDetalleEliminar.SiConexionSql)
                        {
                            try
                            {
                                ConexionDetalleEliminar.ComandoSql.Parameters.AddWithValue("@EnlaceFactu", this.EnlaceFactu.Text);
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

                if (this.dtDetallesFacturaDataGridView2.RowCount >= 0 && ClasDatos.Datos1Datos2 == "Nota2")
                {
                    if (this.panelBotones.Tag.ToString() == "Modificar")
                    {

                        if (this.dtNuevaFacturaDataGridView.RowCount >= 0)
                        {
                            ClsConexionSql ConexionDetalleEliminar2 = new ClsConexionSql(ConsultaEliminar2);
                            if (ConexionDetalleEliminar2.SiConexionSql)
                            {
                                try
                                {
                                    ConexionDetalleEliminar2.ComandoSql.Parameters.AddWithValue("@EnlaceFactu", this.EnlaceFactu.Text);
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
                MessageBox.Show(VALIDAR_Dtfactura + "\n" + VALIDAR_Dtdetalle + "\n" + VALIDAR_Dtdetalle2, "GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // RestaraurarOjetosFatu();
                this.BtnCancelarfactura.Enabled = true;
            }
            else
            {
                this.dtDetallesFacturaBindingSource.EndEdit();
                this.dtNuevaFacturaBindingSource.EndEdit();
                this.dtDetallesFactura2BindingSource.EndEdit();
                Validate();
                MessageBox.Show("Guardado Correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RestaraurarOjetosFatu();
            }
        }


        private void BtnNuevoFactura_Click(object sender, EventArgs e)
        {
            int VALORid = 1;
            int VALOR_MAS = 1;
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
                            this.NumeroFactura.Text = VALORid.ToString();
                        }
                        else
                        {
                            VALORid = Convert.ToInt32(this.dtNuevaFacturaDataGridView.Rows[numeroFILA - 1].Cells[0].Value) + 1;
                            this.dtNuevaFacturaDataGridView.Rows[numeroFILA].Cells[0].Value = (VALORid);
                            this.NumeroFactura.Text = VALORid.ToString();

                        }
                    }
                    Salto_Atras:
                    Random r = new Random();
                    VALOR_MAS = r.Next(5, 10000);
                    this.EnlaceFactu.Text = this.Id_Empresa.Text + "/" + this.ejerciciosDeAñoComboBox.Text + "/" + this.SerieText.Text + VALORid + " / " + VALOR_MAS;
                    this.FechaFactura.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now);
                    this.dtNuevaFacturaDataGridView.Rows[this.dtNuevaFacturaDataGridView.Rows.Count - 1].Selected = true;
                    // this.dtNuevaFacturaDataGridView.UseWaitCursor = true;
                    if (!ClasSi_Existe_Fatu.Buscar_Fatu_Sql(this.EnlaceFactu.Text, ClasDatos.NombreFactura))
                    {
                        this.EnlaceFactu.Text = "";
                        goto Salto_Atras;
                        // return;
                    }

                    this.dtNuevaFacturaBindingSource.EndEdit();

                    if (FormMenuPrincipal.menu2principal.dsMultidatos.DtInicioMulti.Count > 0)
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
                    if (this.AlmacenTxt.Items.Count > 0)
                    {
                        this.AlmacenTxt.SelectedIndex = 0;
                    }
                    if (this.obrasComboBox.Items.Count > 0)
                    {
                        this.obrasComboBox.SelectedIndex = 0;
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
            if (this.Id_Empresa.Text == string.Empty & this.EmpresaPrincipal.Text == string.Empty)
            {
                MessageBox.Show("Falta  Empresa", "EMPRESA");
                return;
            }
            if (this.ejerciciosDeAñoComboBox.Text == string.Empty)
            {
                MessageBox.Show("Debe Crear Ejercicio De Esta Empresa", "Falta Ejercicio");
                return;
            }
            if (this.SerieText.Text == string.Empty)
            {
                MessageBox.Show("No Existe Ninguna Serie", "NO EXISTE SERIE");
                return;
            }
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
                        this.dsFacturas.DtNuevaFactura.Rows[FILAcelda]["CobradaFactura"] = "Cobrado";
                    }
                    else
                    {
                        //this.dtNuevaFacturaDataGridView.Rows[FILAcelda].Cells[13].Value = "";
                        this.dsFacturas.DtNuevaFactura.Rows[FILAcelda]["FechaCobro"] = "";
                    }

                    if (ClsConexionSql.SibaseDatosSql)
                    {
                        GuardarFactuSql();

                    }
                    else
                    {
                        try
                        {
                            if (File.Exists(ClasDatos.RutaBaseDatosDb))
                            {
                                GuardarFactuDB();
                                
                            }
                            else
                            {
                                MessageBox.Show(ClasDatos.RutaBaseDatosDb, "ARCHIVO NO SE ENCUENTRA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            // RestaraurarOjetosFatu();


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
            this.FechaFactura.Enabled = false;
            this.AlmacenTxt.Enabled = false;
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
            this.panelBotones.Enabled = false;
            this.PanelArriba.Enabled = false;
            this.BtnBuscarClientesFact.Enabled = true;
            this.dtNuevaFacturaDataGridView.Enabled = false;
            this.dtDetallesFacturaDataGridView.ReadOnly = false;
            this.dtDetallesFacturaDataGridView2.ReadOnly = false;
            this.dtNuevaFacturaDataGridView.UseWaitCursor = true;
            this.cobradaFacturaCheckBox.Enabled = true;
            this.FechaFactura.Enabled = true;
            this.AlmacenTxt.Enabled = true;
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
                    }
                    else
                    {
                        LlenarGrid(this.dtDetallesFacturaDataGridView, 1);
                        if (ClasDatos.NombreFactura == "Nota2")
                        {
                            LlenarGrid(this.dtDetallesFacturaDataGridView2, 2);
                        }
                    }
                }
                this.dtDetallesFacturaDataGridView.Refresh();
                this.dtNuevaFacturaDataGridView.Focus();

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
                this.NumeroFactura.Enabled = false;
                this.panelBotones.Tag = "Modificar";
                ExtraerGrid(this.dtDetallesFacturaDataGridView, 1);
                if (ClasDatos.NombreFactura == "Nota2")
                {
                    ExtraerGrid(this.dtDetallesFacturaDataGridView2, 2);
                }
            }
        }

        private void ActualizarFacturaSql()
        {
            // string consulta = "SELECT * from DtNuevaFactura";
            if (this.Id_Empresa.Text != string.Empty)
            {


                string consulta = "select * FROM [Dt" + ClasDatos.NombreFactura + "]" + " where  [EmpresaEnlace] = '" + this.Id_Empresa.Text + "'";
                string consultaDetalle = "SELECT * from [DtDetalles_" + ClasDatos.NombreFactura + "]";
                string consultaDetalle2 = "SELECT * from [DtDetalles2_" + ClasDatos.NombreFactura + "]";
                ClsConexionSql NuevaConexion = new ClsConexionSql(consulta);

                try
                {
                    if (NuevaConexion.SiConexionSql)
                    {

                        SqlDataAdapter AdactaPelos = new SqlDataAdapter(consulta, ClsConexionSql.CadenaConexion);
                        AdactaPelos.Fill(this.dsFacturas.DtNuevaFactura);
                        AdactaPelos = new SqlDataAdapter(consultaDetalle, ClsConexionSql.CadenaConexion);
                        AdactaPelos.Fill(this.dsFacturas.DtDetallesFactura);

                        if (ClasDatos.NombreFactura == "Nota2")
                        {
                            AdactaPelos = new SqlDataAdapter(consultaDetalle2, ClsConexionSql.CadenaConexion);
                            AdactaPelos.Fill(this.dsFacturas.DtDetallesFactura2);
                        }
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
        }
        private void FormFACTURAR_Load(object sender, EventArgs e)
        {
            this.SerieText.Text = "A";
            this.TipoNota.Text = ClasDatos.NombreFactura;
            this.Text = ClasDatos.NombreFactura;
            // ClasDatos.ArchivoInicioFacturas = Directory.GetCurrentDirectory() + "\\" + ClasDatos.RutaDatosPrincipal + "\\" + ClasDatos.NombreFactura + FormMenuPrincipal.menu2principal.InfoExtension.Text;
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
                    this.dtConfiguracionPrincipalBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfiguracionPrincipal;
                    this.dtConfiBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtConfi;
                    this.dtTarifaTipoBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtTarifaTipo;
                    this.dtAlmacenesBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsCONFIGURACCION.DtAlmacenes;
                }
                if (FormMenuPrincipal.menu2principal.dsMulti2 != null)
                {
                    this.dtObrasBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2.DtObras;
                    this.dtPaisesBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2.DtPaises;
                    // this.dtProvinciasBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMulti2.DtProvincias;
                }
                if (FormMenuPrincipal.menu2principal.dsMultidatos != null)
                {
                    this.dtInicioMultiBindingSource.DataSource = FormMenuPrincipal.menu2principal.dsMultidatos.DtInicioMulti;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

            if (File.Exists(ClasDatos.RutaBaseDatosDb))
            {
                if (FormMenuPrincipal.menu2principal.dsMultidatos.DtInicioMulti.Count > 0)
                {
                    // this.empresaENLACEComboBox.Focus();
                    if (FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["EjercicioInicio"].ToString() != string.Empty)
                    {
                        this.EmpresaPrincipal.Text = FormMenuPrincipal.menu2principal.dsMultidatos.Tables["DtInicioMulti"].Rows[0]["EmpresaInicio"].ToString();
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



                }


            }

            else
            {
                MessageBox.Show("Falta Archivo De Datos", "ARCHIVO NO EXISTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            if (this.dtConfiBindingSource.Count < 1)
            {

                this.panelBotones.Enabled = false;
                MessageBox.Show("Debe Crear Ejercicio", "NUEVO");
            }
            if (this.dtNuevaFacturaBindingSource.Count > 0)
            {

                if (this.subTotal.Text != string.Empty)
                {
                    this.subTotal.Text = string.Format("{0:C" + this.NumPrecio.Value + "}", (this.subTotal.Text));
                    this.subTotal.Text = this.subTotal.Text.ToString();
                    this.baseIva.Text = string.Format("{0:C" + this.NumPrecio.Value + "}", (this.baseIva.Text));
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

            if (ClasDatos.NombreFactura == "Nota2")
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
            if (this.Id_Empresa.Text == string.Empty)
            {
                MessageBox.Show("Faltan Datos o Datos Erradicos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.panelBotones.Enabled = false;
            }
            if (this.SerieText.Text == string.Empty)
            {
                this.SerieText.Text = "A";
            }

            FiltrarFactura();
            if (ClsConexionSql.SibaseDatosSql)
            {
                ActualizarFacturaSql();

            }
            else
            {
                if (File.Exists(ClasDatos.RutaBaseDatosDb))
                {
                    ActualizarFaturas_DB();
                }
                else
                {
                    MessageBox.Show(ClasDatos.RutaBaseDatosDb, "ARCHIVO NO EXISTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.panelBotones.Enabled = false;
                    return;
                }
            }
            // this.NombreEmpresaReguistro.Visible = false;
            this.PanelArriba.Tag = "SI";
            FiltrarFactura();
        }
        private void GuardarRestaurarStockDb()
        {

            int Id_Almacen = 0;
            int FilaALMACEN = Convert.ToInt32(this.AlmacenTxt.SelectedIndex);
            if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtAlmacenes"].Rows[FilaALMACEN]["Id"].ToString() != string.Empty)
            {
                Id_Almacen = Convert.ToInt32(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtAlmacenes"].Rows[FilaALMACEN]["Id"].ToString());
            }
            string Enlace = this.Id_Empresa.Text + "/" + this.AlmacenTxt.Text;
            string consulta = "SELECT [Referencia],[Stock],[Enlace] from [DtMovimientos]" + "Where  Referencia= @Referencia  and  Enlace= @Enlace ";
            string Nueva = "INSERT INTO  [DtMovimientos] (Referencia,Stock,Enlace,Id_Empresa,Id_Almacen) VALUES(@Referencia,@Stock,@Enlace,@Id_Empresa,@Id_Almacen)";
            string Modificar = "UPDATE[DtMovimientos] SET[Referencia] = @Referencia,[Stock] = @Stock ,[Enlace] = @Enlace" +
               ",[Id_Empresa] = @Id_Empresa,[Id_Almacen] = @Id_Almacen WHERE  Referencia= @Referencia  and  Enlace= @Enlace ";
            int Stock = 0;
            //int FilaStock = 0;
            OleDbDataReader reader;
            ClsConexionDb ConexionStock = new ClsConexionDb(consulta);
            ClsConexionDb ConexionNueva = new ClsConexionDb(Nueva);
            ClsConexionDb ConexionModificar = new ClsConexionDb(Modificar);
            try
            {
                if (ConexionStock.SiConexionDb)
                {
                    foreach (var Fila in ClasDetalleGrid.Listadetalle1.lista)
                    {

                        if (!string.IsNullOrEmpty(Fila.Referencia))
                        {
                            // ConexionStock = new ClsConexionDb(consulta);

                            ConexionStock.ComandoDb.Parameters.AddWithValue("@Referencia", Fila.Referencia);
                            ConexionStock.ComandoDb.Parameters.AddWithValue("@Enlace", string.IsNullOrEmpty(Enlace) ? (object)DBNull.Value : Enlace);
                            // ConexionStock.ComandoDb.Parameters.AddWithValue("@Stock", FilaStock);
                            reader = ConexionStock.ComandoDb.ExecuteReader();

                            if (reader.HasRows)
                            {

                                if (ConexionModificar.SiConexionDb)
                                {
                                    //reader = ConexionStock.ComandoDb.ExecuteReader();
                                    if (reader.HasRows)
                                    {
                                        if (!string.IsNullOrEmpty(Fila.Cantidad))
                                        {
                                            while (reader.Read())
                                            {
                                                Stock = Convert.ToInt32(reader["Stock"]) + Convert.ToInt32(Fila.Cantidad);
                                            }
                                        }
                                    }
                                    ConexionModificar.ComandoDb.Parameters.AddWithValue("@Referencia", string.IsNullOrEmpty(Fila.Referencia) ? (object)DBNull.Value : Fila.Referencia);
                                    ConexionModificar.ComandoDb.Parameters.AddWithValue("@Stock", Stock);
                                    ConexionModificar.ComandoDb.Parameters.AddWithValue("@Enlace", string.IsNullOrEmpty(Enlace) ? (object)DBNull.Value : Enlace);
                                    ConexionModificar.ComandoDb.Parameters.AddWithValue("@Id_Empresa", string.IsNullOrEmpty(this.Id_Empresa.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Id_Empresa.Text));
                                    ConexionModificar.ComandoDb.Parameters.AddWithValue("@Id_Almacen", Id_Almacen);
                                    ConexionModificar.ComandoDb.ExecuteNonQuery();
                                    ConexionModificar.ComandoDb.Parameters.Clear();
                                }
                            }
                            else
                            {

                                if (ConexionNueva.SiConexionDb)
                                {
                                    ConexionNueva.ComandoDb.Parameters.AddWithValue("@Referencia", string.IsNullOrEmpty(Fila.Referencia) ? (object)DBNull.Value : Fila.Referencia);
                                    ConexionNueva.ComandoDb.Parameters.AddWithValue("@Stock", Stock);
                                    ConexionNueva.ComandoDb.Parameters.AddWithValue("@Enlace", string.IsNullOrEmpty(Enlace) ? (object)DBNull.Value : Enlace);
                                    ConexionNueva.ComandoDb.Parameters.AddWithValue("@Id_Empresa", string.IsNullOrEmpty(this.Id_Empresa.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Id_Empresa.Text));
                                    ConexionNueva.ComandoDb.Parameters.AddWithValue("@Id_Almacen", Id_Almacen);
                                    ConexionNueva.ComandoDb.ExecuteNonQuery();
                                    ConexionNueva.ComandoDb.Parameters.Clear();


                                }
                            }
                        }
                        ConexionStock.ComandoDb.Parameters.Clear();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            ConexionStock.ComandoDb.Parameters.Clear();
            if (ConexionStock.CerrarConexionDB)
            {

            }
            if (ConexionNueva.CerrarConexionDB)
            {

            }
            if (ConexionModificar.CerrarConexionDB)
            {

            }
        }
        private void GuardarStockDb(DataGridView Datagri4)
        {
            int Id_Almacen = 0;
            int FilaALMACEN = Convert.ToInt32(this.AlmacenTxt.SelectedIndex);
            if (FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtAlmacenes"].Rows[FilaALMACEN]["Id"].ToString() != string.Empty)
            {
                Id_Almacen = Convert.ToInt32(FormMenuPrincipal.menu2principal.dsCONFIGURACCION.Tables["DtAlmacenes"].Rows[FilaALMACEN]["Id"].ToString());
            }
            string Enlace = this.Id_Empresa.Text + "/" + this.AlmacenTxt.Text;
            string consulta = "SELECT [Referencia],[Stock],[Enlace] from [DtMovimientos]" + "Where  Referencia= @Referencia  and  Enlace= @Enlace ";
            string Nueva = "INSERT INTO  [DtMovimientos] (Referencia,Stock,Enlace,Id_Empresa,Id_Almacen) VALUES(@Referencia,@Stock,@Enlace,@Id_Empresa,@Id_Almacen)";
            string Modificar = "UPDATE[DtMovimientos] SET[Referencia] = @Referencia,[Stock] = @Stock ,[Enlace] = @Enlace" +
               ",[Id_Empresa] = @Id_Empresa,[Id_Almacen] = @Id_Almacen WHERE  Referencia= @Referencia  and  Enlace= @Enlace ";
            int Stock = 0;
            //int FilaStock = 0;
            OleDbDataReader reader;
            ClsConexionDb ConexionStock = new ClsConexionDb(consulta);
            ClsConexionDb ConexionNueva = new ClsConexionDb(Nueva);
            ClsConexionDb ConexionModificar = new ClsConexionDb(Modificar);
            try
            {
                if (ConexionStock.SiConexionDb)
                {
                    foreach (DataGridViewRow Fila in Datagri4.Rows)
                    {
                        if (Fila.Index == Datagri4.RowCount - 1)
                        {
                            break;
                        }
                        if (!string.IsNullOrEmpty(Fila.Cells[0].Value.ToString()))
                        {
                            // ConexionStock = new ClsConexionDb(consulta);

                            ConexionStock.ComandoDb.Parameters.AddWithValue("@Referencia", Fila.Cells[0].Value.ToString());
                            ConexionStock.ComandoDb.Parameters.AddWithValue("@Enlace", string.IsNullOrEmpty(Enlace) ? (object)DBNull.Value : Enlace);
                            // ConexionStock.ComandoDb.Parameters.AddWithValue("@Stock", FilaStock);
                            reader = ConexionStock.ComandoDb.ExecuteReader();

                            if (reader.HasRows)
                            {

                                if (ConexionModificar.SiConexionDb)
                                {
                                    //reader = ConexionStock.ComandoDb.ExecuteReader();
                                    if (reader.HasRows)
                                    {
                                        if (!string.IsNullOrEmpty(Fila.Cells[2].Value.ToString()))
                                        {
                                            while (reader.Read())
                                            {
                                                Stock = Convert.ToInt32(reader["Stock"]) - Convert.ToInt32(Fila.Cells[2].Value.ToString());
                                            }
                                        }
                                    }
                                    ConexionModificar.ComandoDb.Parameters.AddWithValue("@Referencia", string.IsNullOrEmpty(Fila.Cells[0].Value.ToString()) ? (object)DBNull.Value : Fila.Cells[0].Value.ToString());
                                    ConexionModificar.ComandoDb.Parameters.AddWithValue("@Stock", Stock);
                                    ConexionModificar.ComandoDb.Parameters.AddWithValue("@Enlace", string.IsNullOrEmpty(Enlace) ? (object)DBNull.Value : Enlace);
                                    ConexionModificar.ComandoDb.Parameters.AddWithValue("@Id_Empresa", string.IsNullOrEmpty(this.Id_Empresa.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Id_Empresa.Text));
                                    ConexionModificar.ComandoDb.Parameters.AddWithValue("@Id_Almacen", Id_Almacen);
                                    ConexionModificar.ComandoDb.ExecuteNonQuery();
                                    ConexionModificar.ComandoDb.Parameters.Clear();
                                }
                            }
                            else
                            {

                                if (ConexionNueva.SiConexionDb)
                                {
                                    ConexionNueva.ComandoDb.Parameters.AddWithValue("@Referencia", string.IsNullOrEmpty(Fila.Cells[0].Value.ToString()) ? (object)DBNull.Value : Fila.Cells[0].Value.ToString());
                                    ConexionNueva.ComandoDb.Parameters.AddWithValue("@Stock", Stock);
                                    ConexionNueva.ComandoDb.Parameters.AddWithValue("@Enlace", string.IsNullOrEmpty(Enlace) ? (object)DBNull.Value : Enlace);
                                    ConexionNueva.ComandoDb.Parameters.AddWithValue("@Id_Empresa", string.IsNullOrEmpty(this.Id_Empresa.Text) ? (object)DBNull.Value : Convert.ToInt32(this.Id_Empresa.Text));
                                    ConexionNueva.ComandoDb.Parameters.AddWithValue("@Id_Almacen", Id_Almacen);
                                    ConexionNueva.ComandoDb.ExecuteNonQuery();
                                    ConexionNueva.ComandoDb.Parameters.Clear();


                                }
                            }
                        }
                        ConexionStock.ComandoDb.Parameters.Clear();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            ConexionStock.ComandoDb.Parameters.Clear();
            if (ConexionStock.CerrarConexionDB)
            {

            }
            if (ConexionNueva.CerrarConexionDB)
            {

            }
            if (ConexionModificar.CerrarConexionDB)
            {

            }
        }
        private void ActualizarFaturas_DB()
        {
            if (File.Exists(ClasDatos.RutaBaseDatosDb))
            {
                if (this.Id_Empresa.Text != string.Empty && this.ejerciciosDeAñoComboBox.Text != string.Empty && this.SerieText.Text != string.Empty)
                {
                    this.dtDetallesFacturaBindingSource.Clear();
                    this.dtDetallesFactura2BindingSource.Clear();
                    this.dsFacturas.Clear();
                    // dtNuevaFacturaBindingSource.Clear();
                    string consulta = "select * FROM [Dt" + ClasDatos.NombreFactura + "]" + " where  [EmpresaEnlace] = '" + this.Id_Empresa.Text + "'";
                    string consultaDetalle = "SELECT * from DtDetalles_" + ClasDatos.NombreFactura;

                    string consultaDetalle2 = "SELECT * from DtDetalles2_" + ClasDatos.NombreFactura;
                    ClsConexionDb NuevaConexion = new ClsConexionDb(consulta);
                    OleDbDataAdapter AdactaPelos = new OleDbDataAdapter(consulta, ClsConexionDb.CadenaConexion);
                    try
                    {
                        if (NuevaConexion.SiConexionDb)
                        {
                            FiltrarFactura();
                            AdactaPelos.Fill(this.dsFacturas.DtNuevaFactura);
                            // this.InfoTxt2.Text = this.dtNuevaFacturaBindingSource.Count.ToString();
                            if (this.dtNuevaFacturaBindingSource.Count > 0)
                            {
                                AdactaPelos = new OleDbDataAdapter(consultaDetalle, ClsConexionDb.CadenaConexion);
                                AdactaPelos.Fill(this.dsFacturas.DtDetallesFactura);
                                if (ClasDatos.NombreFactura == "Nota2")
                                {
                                    AdactaPelos = new OleDbDataAdapter(consultaDetalle2, ClsConexionDb.CadenaConexion);
                                    AdactaPelos.Fill(this.dsFacturas.DtDetallesFactura2);
                                }
                            }
                            AdactaPelos.Dispose();
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
                            AdactaPelos.Dispose();
                        }
                    }

                }
            }
            else
            {
                this.panelBotones.Enabled = false;
                MessageBox.Show("Archivo : " + ClasDatos.RutaBaseDatosDb, "Falta Archivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
        }
        private void EmpresaENLACEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void EjerciciosDeAñoComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.PanelArriba.Tag.ToString() == "SI")
            {
                FiltrarFactura();
            }
        }
        private void FiltrarFactura()
        {

            //this.dsCONFIGURACCION.DtDetallesFactura.Clear();
            // this.dsCONFIGURACCION.DtDetallesFactura2.Clear();
            // this.dsCONFIGURACCION.DtNuevaFactura.Clear();
            if (this.Id_Empresa.Text != string.Empty && this.ejerciciosDeAñoComboBox.Text != string.Empty && this.SerieText.Text != string.Empty)
            {
                try
                {

                    string Enlace = this.Id_Empresa.Text + "/" + this.ejerciciosDeAñoComboBox.Text + "/" + this.SerieText.Text;
                    this.dtNuevaFacturaBindingSource.Filter = "( [EnlaceFactura]   LIKE '" + Enlace + "%'" + ")";
                    this.dtNuevaFacturaDataGridView.Refresh();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }


            }



        }
        private void SerieText_SelectedIndexChanged(object sender, EventArgs e)
        {

            FiltrarFactura();


        }

        private void DtDetallesFacturaDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (this.dtDetallesFacturaDataGridView.CurrentCell.ColumnIndex == 2 || this.dtDetallesFacturaDataGridView.CurrentCell.ColumnIndex == 4 || this.dtDetallesFacturaDataGridView.CurrentCell.ColumnIndex == 5)
            {
                // dtDetallesFacturaDataGridView.CurrentCell.EditedFormattedValue.ToString();
                if (e.KeyChar == 46)
                {
                    e.KeyChar = ',';
                }
                if (e.KeyChar == (char)46)
                {
                    e.KeyChar = ',';
                }
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

                if (this.BtnGuardarFactura.Enabled == true)
                {
                    if (e.ColumnIndex == 1)
                    {
                        if (this.dtArticulosBindingSource.Count < 0)
                        {
                            MessageBox.Show(" Archivo ARTICULOS No Existe O  VACIO ", " FALTA O VACIO ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            ClasDatos.ValorBuscado = e.RowIndex;
                            int numeroFILA = this.dtNuevaFacturaDataGridView.Rows.Count;
                            if (numeroFILA > 0)
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
                    try
                    {
                        if (e.ColumnIndex == 0 || e.ColumnIndex == 2 || e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6)
                        {
                            if (string.IsNullOrEmpty(this.dtDetallesFacturaDataGridView.CurrentCell.Value.ToString()))
                            {
                                this.SoloNumerosText = this.dtDetallesFacturaDataGridView.CurrentCell.Value.ToString();
                            }

                        }
                        if (e.ColumnIndex == 2 || e.ColumnIndex == 4 || e.ColumnIndex == 5)
                        {
                            if (string.IsNullOrEmpty(this.dtDetallesFacturaDataGridView.CurrentCell.Value.ToString()))
                            {
                                this.dtDetallesFacturaDataGridView.CurrentCell.Value = 0;
                            }
                            this.dtDetallesFacturaDataGridView.BeginEdit(true);
                        }
                    }
                    catch (Exception)
                    {

                        // throw;
                    }
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

                try
                {
                    if (e.ColumnIndex == 2 || e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 5)
                    {
                        if (this.dtDetallesFacturaDataGridView.CurrentCell.Value.ToString() == "0")
                        {
                            this.dtDetallesFacturaDataGridView.CurrentCell.Value = DBNull.Value;
                        }

                    }
                    if (e.ColumnIndex == 5)
                    {
                        if (!String.IsNullOrEmpty(this.dtDetallesFacturaDataGridView.CurrentCell.Value.ToString()))
                        {
                            // this.dtDetallesFacturaDataGridView.CurrentCell.Value = Convert.ToDouble(this.dtDetallesFacturaDataGridView.CurrentCell.Value.ToString()) / 100;
                        }

                    }
                }
                catch (Exception)
                {

                    // throw;
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
                    this.fechaCobroText.Text = "";
                    this.fechaCobroText.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now);
                    // dtfacturas.DtNuevaFactura.Rows[FILAcelda]["CobradaFactura"] = "Cobrado";
                }
                else
                {
                    this.fechaCobroText.Text = "";
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
                        if (this.dtNuevaFacturaDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString() == "Cobrado")
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
            if (this.BtnGuardarFactura.Enabled == true)
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
                    if (!ClsConexionSql.SibaseDatosSql)
                    {
                        if (!File.Exists(ClasDatos.RutaBaseDatosDb))
                        {
                            MessageBox.Show(" Archivo ARTICULOS No Existe ", " FALTA ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
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
                    if (!string.IsNullOrEmpty(this.dtDetallesFacturaDataGridView2.CurrentCell.Value.ToString()))
                    {
                        this.SoloNumerosText = this.dtDetallesFacturaDataGridView2.CurrentCell.Value.ToString();
                    }
                    else
                    {
                        this.dtDetallesFacturaDataGridView2.CurrentCell.Value = 0;
                        this.dtDetallesFacturaDataGridView2.BeginEdit(true);
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
            if (e.ColumnIndex == 2 || e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 5)
            {
                if (this.dtDetallesFacturaDataGridView2.CurrentCell.Value.ToString() == "0")
                {
                    this.dtDetallesFacturaDataGridView2.CurrentCell.Value = DBNull.Value;
                }

            }
            if (e.ColumnIndex == 5)
            {
                if (!String.IsNullOrEmpty(this.dtDetallesFacturaDataGridView2.CurrentCell.Value.ToString()))
                {
                    this.dtDetallesFacturaDataGridView2.CurrentCell.Value = Convert.ToDouble(this.dtDetallesFacturaDataGridView2.CurrentCell.Value.ToString()) / 100;
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

            if (FormMenuPrincipal.menu2principal.dsClientes.DtClientes.Count < 0)
            {

                MessageBox.Show("No Hay Clientes", " ARCHIVO NO EXISTE O VACIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ClasDatos.ValorBuscado = this.dtNuevaFacturaDataGridView.CurrentCell.RowIndex;
            if (this.dtNuevaFacturaDataGridView.Rows.Count >= 0)
            {

                ClasDatos.OkFacturar = true;
                ClasDatos.Datos1Datos2 = "Nota1";
                // dtNuevaFacturaDataGridView.CurrentCell.Selected = false;
                FormBuscarClientes frm = new FormBuscarClientes();
                // frm.FormClosed += (o, args) => numeroFILA = 1;
                frm.ShowDialog();
                frm.BringToFront();
            }
        }

        private void DtDetallesFacturaDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.dtDetallesFacturaDataGridView.CurrentCell.RowIndex > -1)
            {
                if (e.KeyCode == Keys.Down)
                {
                    if (this.dtDetallesFacturaDataGridView.CurrentCell.ColumnIndex == 0)
                    {

                        if (this.dtDetallesFacturaDataGridView.CurrentCell.RowIndex == this.dtDetallesFacturaDataGridView.RowCount - 1)
                        {
                            this.dtDetallesFacturaBindingSource.AddNew();
                        }
                    }
                }
                // dtDetallesFacturaBindingSource.AddNew();
            }
        }


        private void BtnEnviarMailFactura_Click(object sender, EventArgs e)
        {

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
            if (ClasDatos.NombreFactura == "Nota2")
            {
                this.dtDetallesFacturaDataGridView2.Columns[6].DefaultCellStyle.Format = "C" + this.Numimporte.Value;
            }


        }

        private void NumTotales_ValueChanged(object sender, EventArgs e)
        {
            this.baseIva.Text = string.Format("{0:C" + this.NumTotales.Value + "}", this.baseIva.Text);
            this.TotalFactura1.Text = string.Format("{0:C" + this.NumTotales.Value + "}", this.TotalFactura1.Text.ToString());
            this.subTotal.Text = string.Format("{0:C" + this.NumTotales.Value + "}", this.subTotal.Text);
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
                // MessageBox.Show("Pvp1" + "\n" + "Pvp2" + "\n" + "Plus" + "\n" + "Iva", "NO VALIDO", MessageBoxButtons.OK);
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
                    String Consulta = "DELETE FROM [Dt" + ClasDatos.NombreFactura + "] WHERE EnlaceFactura= @EnlaceFactura ";
                    if (ClsConexionSql.SibaseDatosSql)
                    {

                        ClsConexionSql NuevaConexion = new ClsConexionSql(Consulta);
                        if (NuevaConexion.SiConexionSql)
                        {
                            try
                            {
                                NuevaConexion.ComandoSql.Parameters.AddWithValue("@EnlaceFactura", this.EnlaceFactu.Text);
                                NuevaConexion.ComandoSql.ExecuteNonQuery();
                                this.dtNuevaFacturaDataGridView.Rows.RemoveAt(this.dtNuevaFacturaDataGridView.CurrentCell.RowIndex);
                                this.dtNuevaFacturaBindingSource.EndEdit();
                                Validate();
                                MessageBox.Show("Eliminado con exito", "ELIMINAR");
                                this.dtNuevaFacturaDataGridView.Refresh();
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message, "ERROR ELIMINAR FACTURA");
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
                        if (File.Exists(ClasDatos.RutaBaseDatosDb))
                        {
                            ClsConexionDb NuevaConexion = new ClsConexionDb(Consulta);
                            if (NuevaConexion.SiConexionDb)
                            {
                                try
                                {
                                    NuevaConexion.ComandoDb.Parameters.AddWithValue("@EnlaceFactura", this.EnlaceFactu.Text);
                                    NuevaConexion.ComandoDb.ExecuteNonQuery();
                                    this.dtNuevaFacturaDataGridView.Rows.RemoveAt(this.dtNuevaFacturaDataGridView.CurrentCell.RowIndex);
                                    this.dtNuevaFacturaBindingSource.EndEdit();
                                    Validate();
                                    MessageBox.Show("Eliminado con exito", "ELIMINAR");
                                    this.dtNuevaFacturaDataGridView.Refresh();
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.Message, "ERROR ELIMINAR FACTURA");
                                }
                                finally
                                {
                                    if (NuevaConexion.CerrarConexionDB)
                                    {

                                    }
                                }
                            }

                        }
                    }


                }

            }
        }

        private void dtDetallesFacturaDataGridView2_Validated(object sender, EventArgs e)
        {
            if (this.dtDetallesFacturaDataGridView2.CurrentCell.RowIndex >= 0)
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


                    // this.dtDetallesFacturaBindingSource.Insert(Fila, this.dtDetallesFacturaDataGridView.Rows[Fila].Cells[2].Value.ToString());
                    //dtDetallesFacturaDataGridView.Rows.Insert(0, dtDetallesFacturaDataGridView.Rows[Fila].Cells[2].Value );
                    // borrar(int.Parse(id));

                }
                if (NombreItem.Contains("Lineablanco"))
                {
                    NombreItem = NombreItem.Replace("Lineablanco", "");
                    Fila = this.dtDetallesFacturaDataGridView.CurrentCell.RowIndex + 1;
                    // DataTable dt = (DataTable)dsFacturas.DtDetallesFactura;
                    // DataTable dt = new DataTable();
                    var row = this.dsFacturas.DtDetallesFactura.NewRow();
                    // this.dtDetallesFacturaDataGridView.Rows.Add(Fila, row);
                    this.dtDetallesFacturaBindingSource.Insert(Fila, row);
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
                    NombreItem = NombreItem.Replace("DuplicarArticulo", "");
                    Fila = this.dtDetallesFacturaDataGridView.CurrentCell.RowIndex + 1;
                    var row = this.dsFacturas.DtDetallesFactura.NewRow();

                    this.dtDetallesFacturaBindingSource.Insert(Fila, row);
                    if (!string.IsNullOrEmpty(this.dtDetallesFacturaDataGridView.Rows[Fila].Cells[3].Value.ToString()))
                    {
                        this.dtDetallesFacturaDataGridView.Rows[Fila + 1].Cells[3].Value = this.dtDetallesFacturaDataGridView.Rows[Fila].Cells[3].Value;
                    }

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
            if (this.BtnGuardarFactura.Enabled == true)
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
            ClasValidarDni.ValidarDni(this.dniTextBox.Text);
        }

        private void ejerciciosDeAñoComboBox_Click(object sender, EventArgs e)
        {

        }

        private void SerieText_Click(object sender, EventArgs e)
        {
            // this.PanelArriba.Tag = "SI";
        }

        private void tipoInpuestoIVALabel1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void EmpresaPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            // FiltrarFactura();

        }

        private void EmpresaPrincipal_Enter(object sender, EventArgs e)
        {
            // this.PanelArriba.Tag = "SI";
        }

        private void NombreEmpresaReguistro_TextChanged(object sender, EventArgs e)
        {
            FiltrarFactura();
            if (this.PanelArriba.Tag.ToString() == "SI")
            {


                if (ClsConexionSql.SibaseDatosSql)
                {
                    ActualizarFacturaSql();
                }
                else
                {
                    ActualizarFaturas_DB();
                }
            }
        }

        private void EmpresaPrincipal_MouseEnter(object sender, EventArgs e)
        {
            //this.PanelArriba.Tag = "SI";
            // NombreEmpresaConfi.Visible = true;
            // NombreEmpresaConfi.ForeColor = color;

        }

        private void EmpresaPrincipal_SelectedValueChanged(object sender, EventArgs e)
        {
            // FiltrarFactura();
        }

        private void EmpresaPrincipal_MouseLeave(object sender, EventArgs e)
        {
            // NombreEmpresaConfi.Visible = false;
        }

        private void ejerciciosDeAñoComboBox_Click_1(object sender, EventArgs e)
        {
            // this.PanelArriba.Tag = "SI";
        }

        private void EmpresaPrincipal_Click(object sender, EventArgs e)
        {
            //this.PanelArriba.Tag = "SI";
        }

        private void EmpresaReguistro_Click(object sender, EventArgs e)
        {

        }

        private void AlmacenTxt_Click(object sender, EventArgs e)
        {
            this.AlmacenTxt.DroppedDown = true;
        }

        private void dtDetallesFacturaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}








