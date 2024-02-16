
namespace PELOSCALVO
{
    partial class FormBuscarClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarClientes));
            this.dsClientes = new PELOSCALVO.DsClientes();
            this.dtClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtClientes2DataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPODOCLIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRECLIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRECCIONCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONOCLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOVILCLIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cORREOCLIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOCALIDADCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNICLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODIGOPOSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAISCLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAALTACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cALLECLIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEROCALLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROVINCIACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tARIFATIPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPODNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOCLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCUENTOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEROCUENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pORTESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANCOOFICIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANCOPROVIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANCODIRECDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANCOLOCALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANCOIBANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANCOCODIGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANCOENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANCOOFIC2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANCODCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANCONCUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPObuscarCLIENTESfoma = new System.Windows.Forms.ComboBox();
            this.BuscarClientesText = new System.Windows.Forms.TextBox();
            this.ContadorDatosCli = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancelarBCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes2DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dsClientes
            // 
            this.dsClientes.DataSetName = "DsClientes";
            this.dsClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtClientesBindingSource
            // 
            this.dtClientesBindingSource.DataMember = "DtClientes";
            this.dtClientesBindingSource.DataSource = this.dsClientes;
            // 
            // dtClientes2DataGridView
            // 
            this.dtClientes2DataGridView.AllowUserToAddRows = false;
            this.dtClientes2DataGridView.AllowUserToDeleteRows = false;
            this.dtClientes2DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtClientes2DataGridView.AutoGenerateColumns = false;
            this.dtClientes2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtClientes2DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtClientes2DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtClientes2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtClientes2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.aPODOCLIENDataGridViewTextBoxColumn,
            this.nOMBRECLIEDataGridViewTextBoxColumn,
            this.dIRECCIONCDataGridViewTextBoxColumn,
            this.tELEFONOCLDataGridViewTextBoxColumn,
            this.mOVILCLIENDataGridViewTextBoxColumn,
            this.cORREOCLIEDataGridViewTextBoxColumn,
            this.lOCALIDADCDataGridViewTextBoxColumn,
            this.DNICLIENTE,
            this.cODIGOPOSTDataGridViewTextBoxColumn,
            this.pAISCLIENTDataGridViewTextBoxColumn,
            this.fECHAALTACDataGridViewTextBoxColumn,
            this.cALLECLIENDataGridViewTextBoxColumn,
            this.nUMEROCALLDataGridViewTextBoxColumn,
            this.pROVINCIACDataGridViewTextBoxColumn,
            this.tARIFATIPODataGridViewTextBoxColumn,
            this.tIPODNIDataGridViewTextBoxColumn,
            this.tIPOCLIENTDataGridViewTextBoxColumn,
            this.dESCUENTOCDataGridViewTextBoxColumn,
            this.nUMEROCUENDataGridViewTextBoxColumn,
            this.pORTESDataGridViewTextBoxColumn,
            this.bANCOOFICIDataGridViewTextBoxColumn,
            this.bANCOPROVIDataGridViewTextBoxColumn,
            this.bANCODIRECDataGridViewTextBoxColumn,
            this.bANCOLOCALDataGridViewTextBoxColumn,
            this.bANCOIBANDataGridViewTextBoxColumn,
            this.bANCOCODIGDataGridViewTextBoxColumn,
            this.bANCOENTIDDataGridViewTextBoxColumn,
            this.bANCOOFIC2DataGridViewTextBoxColumn,
            this.bANCODCDataGridViewTextBoxColumn,
            this.bANCONCUEDataGridViewTextBoxColumn,
            this.IdFila});
            this.dtClientes2DataGridView.DataSource = this.dtClientesBindingSource;
            this.dtClientes2DataGridView.Location = new System.Drawing.Point(18, 54);
            this.dtClientes2DataGridView.Name = "dtClientes2DataGridView";
            this.dtClientes2DataGridView.ReadOnly = true;
            this.dtClientes2DataGridView.RowHeadersVisible = false;
            this.dtClientes2DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtClientes2DataGridView.Size = new System.Drawing.Size(957, 324);
            this.dtClientes2DataGridView.TabIndex = 2;
            this.dtClientes2DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtClientes2DataGridView_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Numero";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // aPODOCLIENDataGridViewTextBoxColumn
            // 
            this.aPODOCLIENDataGridViewTextBoxColumn.DataPropertyName = "APODOCLIEN";
            this.aPODOCLIENDataGridViewTextBoxColumn.FillWeight = 250F;
            this.aPODOCLIENDataGridViewTextBoxColumn.HeaderText = "Razon Social";
            this.aPODOCLIENDataGridViewTextBoxColumn.Name = "aPODOCLIENDataGridViewTextBoxColumn";
            this.aPODOCLIENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBRECLIEDataGridViewTextBoxColumn
            // 
            this.nOMBRECLIEDataGridViewTextBoxColumn.DataPropertyName = "NOMBRECLIE";
            this.nOMBRECLIEDataGridViewTextBoxColumn.FillWeight = 300F;
            this.nOMBRECLIEDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nOMBRECLIEDataGridViewTextBoxColumn.Name = "nOMBRECLIEDataGridViewTextBoxColumn";
            this.nOMBRECLIEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIRECCIONCDataGridViewTextBoxColumn
            // 
            this.dIRECCIONCDataGridViewTextBoxColumn.DataPropertyName = "DIRECCIONC";
            this.dIRECCIONCDataGridViewTextBoxColumn.FillWeight = 220F;
            this.dIRECCIONCDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.dIRECCIONCDataGridViewTextBoxColumn.Name = "dIRECCIONCDataGridViewTextBoxColumn";
            this.dIRECCIONCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tELEFONOCLDataGridViewTextBoxColumn
            // 
            this.tELEFONOCLDataGridViewTextBoxColumn.DataPropertyName = "TELEFONOCL";
            this.tELEFONOCLDataGridViewTextBoxColumn.HeaderText = "TELEFONOCL";
            this.tELEFONOCLDataGridViewTextBoxColumn.Name = "tELEFONOCLDataGridViewTextBoxColumn";
            this.tELEFONOCLDataGridViewTextBoxColumn.ReadOnly = true;
            this.tELEFONOCLDataGridViewTextBoxColumn.Visible = false;
            // 
            // mOVILCLIENDataGridViewTextBoxColumn
            // 
            this.mOVILCLIENDataGridViewTextBoxColumn.DataPropertyName = "MOVILCLIEN";
            this.mOVILCLIENDataGridViewTextBoxColumn.HeaderText = "MOVILCLIEN";
            this.mOVILCLIENDataGridViewTextBoxColumn.Name = "mOVILCLIENDataGridViewTextBoxColumn";
            this.mOVILCLIENDataGridViewTextBoxColumn.ReadOnly = true;
            this.mOVILCLIENDataGridViewTextBoxColumn.Visible = false;
            // 
            // cORREOCLIEDataGridViewTextBoxColumn
            // 
            this.cORREOCLIEDataGridViewTextBoxColumn.DataPropertyName = "CORREOCLIE";
            this.cORREOCLIEDataGridViewTextBoxColumn.HeaderText = "CORREOCLIE";
            this.cORREOCLIEDataGridViewTextBoxColumn.Name = "cORREOCLIEDataGridViewTextBoxColumn";
            this.cORREOCLIEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cORREOCLIEDataGridViewTextBoxColumn.Visible = false;
            // 
            // lOCALIDADCDataGridViewTextBoxColumn
            // 
            this.lOCALIDADCDataGridViewTextBoxColumn.DataPropertyName = "LOCALIDADC";
            this.lOCALIDADCDataGridViewTextBoxColumn.HeaderText = "LOCALIDADC";
            this.lOCALIDADCDataGridViewTextBoxColumn.Name = "lOCALIDADCDataGridViewTextBoxColumn";
            this.lOCALIDADCDataGridViewTextBoxColumn.ReadOnly = true;
            this.lOCALIDADCDataGridViewTextBoxColumn.Visible = false;
            // 
            // DNICLIENTE
            // 
            this.DNICLIENTE.DataPropertyName = "DNICLIENTE";
            this.DNICLIENTE.HeaderText = "D.n.i";
            this.DNICLIENTE.Name = "DNICLIENTE";
            this.DNICLIENTE.ReadOnly = true;
            // 
            // cODIGOPOSTDataGridViewTextBoxColumn
            // 
            this.cODIGOPOSTDataGridViewTextBoxColumn.DataPropertyName = "CODIGOPOST";
            this.cODIGOPOSTDataGridViewTextBoxColumn.HeaderText = "CODIGOPOST";
            this.cODIGOPOSTDataGridViewTextBoxColumn.Name = "cODIGOPOSTDataGridViewTextBoxColumn";
            this.cODIGOPOSTDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODIGOPOSTDataGridViewTextBoxColumn.Visible = false;
            // 
            // pAISCLIENTDataGridViewTextBoxColumn
            // 
            this.pAISCLIENTDataGridViewTextBoxColumn.DataPropertyName = "PAISCLIENT";
            this.pAISCLIENTDataGridViewTextBoxColumn.HeaderText = "PAISCLIENT";
            this.pAISCLIENTDataGridViewTextBoxColumn.Name = "pAISCLIENTDataGridViewTextBoxColumn";
            this.pAISCLIENTDataGridViewTextBoxColumn.ReadOnly = true;
            this.pAISCLIENTDataGridViewTextBoxColumn.Visible = false;
            // 
            // fECHAALTACDataGridViewTextBoxColumn
            // 
            this.fECHAALTACDataGridViewTextBoxColumn.DataPropertyName = "FECHAALTAC";
            this.fECHAALTACDataGridViewTextBoxColumn.HeaderText = "Fecha Alta";
            this.fECHAALTACDataGridViewTextBoxColumn.Name = "fECHAALTACDataGridViewTextBoxColumn";
            this.fECHAALTACDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cALLECLIENDataGridViewTextBoxColumn
            // 
            this.cALLECLIENDataGridViewTextBoxColumn.DataPropertyName = "CALLECLIEN";
            this.cALLECLIENDataGridViewTextBoxColumn.FillWeight = 52.31599F;
            this.cALLECLIENDataGridViewTextBoxColumn.HeaderText = "CALLECLIEN";
            this.cALLECLIENDataGridViewTextBoxColumn.Name = "cALLECLIENDataGridViewTextBoxColumn";
            this.cALLECLIENDataGridViewTextBoxColumn.ReadOnly = true;
            this.cALLECLIENDataGridViewTextBoxColumn.Visible = false;
            // 
            // nUMEROCALLDataGridViewTextBoxColumn
            // 
            this.nUMEROCALLDataGridViewTextBoxColumn.DataPropertyName = "NUMEROCALL";
            this.nUMEROCALLDataGridViewTextBoxColumn.FillWeight = 52.31599F;
            this.nUMEROCALLDataGridViewTextBoxColumn.HeaderText = "NUMEROCALL";
            this.nUMEROCALLDataGridViewTextBoxColumn.Name = "nUMEROCALLDataGridViewTextBoxColumn";
            this.nUMEROCALLDataGridViewTextBoxColumn.ReadOnly = true;
            this.nUMEROCALLDataGridViewTextBoxColumn.Visible = false;
            // 
            // pROVINCIACDataGridViewTextBoxColumn
            // 
            this.pROVINCIACDataGridViewTextBoxColumn.DataPropertyName = "PROVINCIAC";
            this.pROVINCIACDataGridViewTextBoxColumn.FillWeight = 52.31599F;
            this.pROVINCIACDataGridViewTextBoxColumn.HeaderText = "PROVINCIAC";
            this.pROVINCIACDataGridViewTextBoxColumn.Name = "pROVINCIACDataGridViewTextBoxColumn";
            this.pROVINCIACDataGridViewTextBoxColumn.ReadOnly = true;
            this.pROVINCIACDataGridViewTextBoxColumn.Visible = false;
            // 
            // tARIFATIPODataGridViewTextBoxColumn
            // 
            this.tARIFATIPODataGridViewTextBoxColumn.DataPropertyName = "TARIFATIPO";
            this.tARIFATIPODataGridViewTextBoxColumn.FillWeight = 52.31599F;
            this.tARIFATIPODataGridViewTextBoxColumn.HeaderText = "TARIFATIPO";
            this.tARIFATIPODataGridViewTextBoxColumn.Name = "tARIFATIPODataGridViewTextBoxColumn";
            this.tARIFATIPODataGridViewTextBoxColumn.ReadOnly = true;
            this.tARIFATIPODataGridViewTextBoxColumn.Visible = false;
            // 
            // tIPODNIDataGridViewTextBoxColumn
            // 
            this.tIPODNIDataGridViewTextBoxColumn.DataPropertyName = "TIPODNI";
            this.tIPODNIDataGridViewTextBoxColumn.FillWeight = 52.31599F;
            this.tIPODNIDataGridViewTextBoxColumn.HeaderText = "TIPODNI";
            this.tIPODNIDataGridViewTextBoxColumn.Name = "tIPODNIDataGridViewTextBoxColumn";
            this.tIPODNIDataGridViewTextBoxColumn.ReadOnly = true;
            this.tIPODNIDataGridViewTextBoxColumn.Visible = false;
            // 
            // tIPOCLIENTDataGridViewTextBoxColumn
            // 
            this.tIPOCLIENTDataGridViewTextBoxColumn.DataPropertyName = "TIPOCLIENT";
            this.tIPOCLIENTDataGridViewTextBoxColumn.FillWeight = 52.31599F;
            this.tIPOCLIENTDataGridViewTextBoxColumn.HeaderText = "TIPOCLIENT";
            this.tIPOCLIENTDataGridViewTextBoxColumn.Name = "tIPOCLIENTDataGridViewTextBoxColumn";
            this.tIPOCLIENTDataGridViewTextBoxColumn.ReadOnly = true;
            this.tIPOCLIENTDataGridViewTextBoxColumn.Visible = false;
            // 
            // dESCUENTOCDataGridViewTextBoxColumn
            // 
            this.dESCUENTOCDataGridViewTextBoxColumn.DataPropertyName = "DESCUENTOC";
            this.dESCUENTOCDataGridViewTextBoxColumn.FillWeight = 52.31599F;
            this.dESCUENTOCDataGridViewTextBoxColumn.HeaderText = "DESCUENTOC";
            this.dESCUENTOCDataGridViewTextBoxColumn.Name = "dESCUENTOCDataGridViewTextBoxColumn";
            this.dESCUENTOCDataGridViewTextBoxColumn.ReadOnly = true;
            this.dESCUENTOCDataGridViewTextBoxColumn.Visible = false;
            // 
            // nUMEROCUENDataGridViewTextBoxColumn
            // 
            this.nUMEROCUENDataGridViewTextBoxColumn.DataPropertyName = "NUMEROCUEN";
            this.nUMEROCUENDataGridViewTextBoxColumn.FillWeight = 52.31599F;
            this.nUMEROCUENDataGridViewTextBoxColumn.HeaderText = "NUMEROCUEN";
            this.nUMEROCUENDataGridViewTextBoxColumn.Name = "nUMEROCUENDataGridViewTextBoxColumn";
            this.nUMEROCUENDataGridViewTextBoxColumn.ReadOnly = true;
            this.nUMEROCUENDataGridViewTextBoxColumn.Visible = false;
            // 
            // pORTESDataGridViewTextBoxColumn
            // 
            this.pORTESDataGridViewTextBoxColumn.DataPropertyName = "PORTES";
            this.pORTESDataGridViewTextBoxColumn.FillWeight = 52.31599F;
            this.pORTESDataGridViewTextBoxColumn.HeaderText = "PORTES";
            this.pORTESDataGridViewTextBoxColumn.Name = "pORTESDataGridViewTextBoxColumn";
            this.pORTESDataGridViewTextBoxColumn.ReadOnly = true;
            this.pORTESDataGridViewTextBoxColumn.Visible = false;
            // 
            // bANCOOFICIDataGridViewTextBoxColumn
            // 
            this.bANCOOFICIDataGridViewTextBoxColumn.DataPropertyName = "BANCOOFICI";
            this.bANCOOFICIDataGridViewTextBoxColumn.FillWeight = 52.31599F;
            this.bANCOOFICIDataGridViewTextBoxColumn.HeaderText = "BANCOOFICI";
            this.bANCOOFICIDataGridViewTextBoxColumn.Name = "bANCOOFICIDataGridViewTextBoxColumn";
            this.bANCOOFICIDataGridViewTextBoxColumn.ReadOnly = true;
            this.bANCOOFICIDataGridViewTextBoxColumn.Visible = false;
            // 
            // bANCOPROVIDataGridViewTextBoxColumn
            // 
            this.bANCOPROVIDataGridViewTextBoxColumn.DataPropertyName = "BANCOPROVI";
            this.bANCOPROVIDataGridViewTextBoxColumn.FillWeight = 52.31599F;
            this.bANCOPROVIDataGridViewTextBoxColumn.HeaderText = "BANCOPROVI";
            this.bANCOPROVIDataGridViewTextBoxColumn.Name = "bANCOPROVIDataGridViewTextBoxColumn";
            this.bANCOPROVIDataGridViewTextBoxColumn.ReadOnly = true;
            this.bANCOPROVIDataGridViewTextBoxColumn.Visible = false;
            // 
            // bANCODIRECDataGridViewTextBoxColumn
            // 
            this.bANCODIRECDataGridViewTextBoxColumn.DataPropertyName = "BANCODIREC";
            this.bANCODIRECDataGridViewTextBoxColumn.HeaderText = "BANCODIREC";
            this.bANCODIRECDataGridViewTextBoxColumn.Name = "bANCODIRECDataGridViewTextBoxColumn";
            this.bANCODIRECDataGridViewTextBoxColumn.ReadOnly = true;
            this.bANCODIRECDataGridViewTextBoxColumn.Visible = false;
            // 
            // bANCOLOCALDataGridViewTextBoxColumn
            // 
            this.bANCOLOCALDataGridViewTextBoxColumn.DataPropertyName = "BANCOLOCAL";
            this.bANCOLOCALDataGridViewTextBoxColumn.HeaderText = "BANCOLOCAL";
            this.bANCOLOCALDataGridViewTextBoxColumn.Name = "bANCOLOCALDataGridViewTextBoxColumn";
            this.bANCOLOCALDataGridViewTextBoxColumn.ReadOnly = true;
            this.bANCOLOCALDataGridViewTextBoxColumn.Visible = false;
            // 
            // bANCOIBANDataGridViewTextBoxColumn
            // 
            this.bANCOIBANDataGridViewTextBoxColumn.DataPropertyName = "BANCOIBAN";
            this.bANCOIBANDataGridViewTextBoxColumn.HeaderText = "BANCOIBAN";
            this.bANCOIBANDataGridViewTextBoxColumn.Name = "bANCOIBANDataGridViewTextBoxColumn";
            this.bANCOIBANDataGridViewTextBoxColumn.ReadOnly = true;
            this.bANCOIBANDataGridViewTextBoxColumn.Visible = false;
            // 
            // bANCOCODIGDataGridViewTextBoxColumn
            // 
            this.bANCOCODIGDataGridViewTextBoxColumn.DataPropertyName = "BANCOCODIG";
            this.bANCOCODIGDataGridViewTextBoxColumn.HeaderText = "BANCOCODIG";
            this.bANCOCODIGDataGridViewTextBoxColumn.Name = "bANCOCODIGDataGridViewTextBoxColumn";
            this.bANCOCODIGDataGridViewTextBoxColumn.ReadOnly = true;
            this.bANCOCODIGDataGridViewTextBoxColumn.Visible = false;
            // 
            // bANCOENTIDDataGridViewTextBoxColumn
            // 
            this.bANCOENTIDDataGridViewTextBoxColumn.DataPropertyName = "BANCOENTID";
            this.bANCOENTIDDataGridViewTextBoxColumn.HeaderText = "BANCOENTID";
            this.bANCOENTIDDataGridViewTextBoxColumn.Name = "bANCOENTIDDataGridViewTextBoxColumn";
            this.bANCOENTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bANCOENTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bANCOOFIC2DataGridViewTextBoxColumn
            // 
            this.bANCOOFIC2DataGridViewTextBoxColumn.DataPropertyName = "BANCOOFIC2";
            this.bANCOOFIC2DataGridViewTextBoxColumn.HeaderText = "BANCOOFIC2";
            this.bANCOOFIC2DataGridViewTextBoxColumn.Name = "bANCOOFIC2DataGridViewTextBoxColumn";
            this.bANCOOFIC2DataGridViewTextBoxColumn.ReadOnly = true;
            this.bANCOOFIC2DataGridViewTextBoxColumn.Visible = false;
            // 
            // bANCODCDataGridViewTextBoxColumn
            // 
            this.bANCODCDataGridViewTextBoxColumn.DataPropertyName = "BANCODC";
            this.bANCODCDataGridViewTextBoxColumn.HeaderText = "BANCODC";
            this.bANCODCDataGridViewTextBoxColumn.Name = "bANCODCDataGridViewTextBoxColumn";
            this.bANCODCDataGridViewTextBoxColumn.ReadOnly = true;
            this.bANCODCDataGridViewTextBoxColumn.Visible = false;
            // 
            // bANCONCUEDataGridViewTextBoxColumn
            // 
            this.bANCONCUEDataGridViewTextBoxColumn.DataPropertyName = "BANCON_CUE";
            this.bANCONCUEDataGridViewTextBoxColumn.HeaderText = "BANCON_CUE";
            this.bANCONCUEDataGridViewTextBoxColumn.Name = "bANCONCUEDataGridViewTextBoxColumn";
            this.bANCONCUEDataGridViewTextBoxColumn.ReadOnly = true;
            this.bANCONCUEDataGridViewTextBoxColumn.Visible = false;
            // 
            // IdFila
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.IdFila.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdFila.HeaderText = "ID";
            this.IdFila.Name = "IdFila";
            this.IdFila.ReadOnly = true;
            // 
            // TIPObuscarCLIENTESfoma
            // 
            this.TIPObuscarCLIENTESfoma.FormattingEnabled = true;
            this.TIPObuscarCLIENTESfoma.Items.AddRange(new object[] {
            "Todos",
            "Razon Social",
            "Nombre",
            "Direccion",
            "Dni",
            "Telefono",
            "Movil"});
            this.TIPObuscarCLIENTESfoma.Location = new System.Drawing.Point(12, 12);
            this.TIPObuscarCLIENTESfoma.Name = "TIPObuscarCLIENTESfoma";
            this.TIPObuscarCLIENTESfoma.Size = new System.Drawing.Size(195, 21);
            this.TIPObuscarCLIENTESfoma.TabIndex = 3;
            this.TIPObuscarCLIENTESfoma.Text = "Todos";
            this.TIPObuscarCLIENTESfoma.SelectedIndexChanged += new System.EventHandler(this.TIPObuscarCLIENTESfoma_SelectedIndexChanged);
            // 
            // BuscarClientesText
            // 
            this.BuscarClientesText.Location = new System.Drawing.Point(228, 12);
            this.BuscarClientesText.Name = "BuscarClientesText";
            this.BuscarClientesText.Size = new System.Drawing.Size(366, 20);
            this.BuscarClientesText.TabIndex = 4;
            this.BuscarClientesText.Click += new System.EventHandler(this.BuscarClientesText_Click);
            this.BuscarClientesText.TextChanged += new System.EventHandler(this.BuscarClientesText_TextChanged);
            // 
            // ContadorDatosCli
            // 
            this.ContadorDatosCli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ContadorDatosCli.AutoSize = true;
            this.ContadorDatosCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContadorDatosCli.Location = new System.Drawing.Point(338, 416);
            this.ContadorDatosCli.Name = "ContadorDatosCli";
            this.ContadorDatosCli.Size = new System.Drawing.Size(19, 20);
            this.ContadorDatosCli.TabIndex = 5;
            this.ContadorDatosCli.Text = "0";
            this.ContadorDatosCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Reguistros #";
            // 
            // BtnCancelarBCliente
            // 
            this.BtnCancelarBCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelarBCliente.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelarBCliente.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelarBCliente.FlatAppearance.BorderSize = 0;
            this.BtnCancelarBCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancelarBCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnCancelarBCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarBCliente.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarBCliente.Image = global::PELOSCALVO.Properties.Resources.Cancelar;
            this.BtnCancelarBCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarBCliente.Location = new System.Drawing.Point(886, 407);
            this.BtnCancelarBCliente.Name = "BtnCancelarBCliente";
            this.BtnCancelarBCliente.Size = new System.Drawing.Size(89, 42);
            this.BtnCancelarBCliente.TabIndex = 33;
            this.BtnCancelarBCliente.Text = "Cancelar";
            this.BtnCancelarBCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelarBCliente.UseVisualStyleBackColor = false;
            this.BtnCancelarBCliente.Click += new System.EventHandler(this.BtnCancelarBCliente_Click);
            // 
            // FormBuscarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelarBCliente;
            this.ClientSize = new System.Drawing.Size(997, 465);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancelarBCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContadorDatosCli);
            this.Controls.Add(this.BuscarClientesText);
            this.Controls.Add(this.TIPObuscarCLIENTESfoma);
            this.Controls.Add(this.dtClientes2DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormBuscarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar cliente";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormBuscarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes2DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DsClientes dsClientes;
        private System.Windows.Forms.BindingSource dtClientesBindingSource;
        private System.Windows.Forms.DataGridView dtClientes2DataGridView;
        private System.Windows.Forms.ComboBox TIPObuscarCLIENTESfoma;
        private System.Windows.Forms.TextBox BuscarClientesText;
        private System.Windows.Forms.Label ContadorDatosCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancelarBCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apodoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movilClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniClienteTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPostalClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAltaClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calleClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCalleClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciaClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifaTipoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNICLIENT2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPODOCLIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRECLIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONOCLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOVILCLIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cORREOCLIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCALIDADCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNICLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGOPOSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAISCLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAALTACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cALLECLIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEROCALLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROVINCIACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tARIFATIPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPODNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOCLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCUENTOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEROCUENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pORTESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bANCOOFICIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bANCOPROVIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bANCODIRECDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bANCOLOCALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bANCOIBANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bANCOCODIGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bANCOENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bANCOOFIC2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bANCODCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bANCONCUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFila;
    }
}