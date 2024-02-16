
namespace PELOSCALVO
{
    partial class FormComfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComfiguracion));
            this.dtConfiguracionPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCONFIGURACCION = new PELOSCALVO.DsCONFIGURACCION();
            this.dtConfiguracionPrincipalDtConfiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMultidatos = new PELOSCALVO.DsMultidatos();
            this.dtConfiDtTarifaTipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtInicioMultiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtPaisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMulti2 = new PELOSCALVO.DsMulti2();
            this.dtProvinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtConfiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1Confi = new System.Windows.Forms.ErrorProvider(this.components);
            this.idTarifaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifaTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enlaceTarifaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.dtObrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtNombresTablasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMultidatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idProveedoresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRestructurar = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirBaseDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirPdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirBaseDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearBaseDatosSqlLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCopiaSeguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCopiaSeguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCopiaSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCopiaCompletaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarCopiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.índiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSalirConfi = new System.Windows.Forms.Button();
            this.dtTarifaTipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalDtConfiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiDtTarifaTipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMulti2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProvinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1Confi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtObrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNombresTablasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatosBindingSource)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarifaTipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtConfiguracionPrincipalBindingSource
            // 
            this.dtConfiguracionPrincipalBindingSource.DataMember = "DtConfiguracionPrincipal";
            this.dtConfiguracionPrincipalBindingSource.DataSource = this.dsCONFIGURACCION;
            // 
            // dsCONFIGURACCION
            // 
            this.dsCONFIGURACCION.DataSetName = "DsCONFIGURACCION";
            this.dsCONFIGURACCION.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtConfiguracionPrincipalDtConfiBindingSource
            // 
            this.dtConfiguracionPrincipalDtConfiBindingSource.DataMember = "FK_DtConfiguracionPrincipal_DtConfi";
            this.dtConfiguracionPrincipalDtConfiBindingSource.DataSource = this.dtConfiguracionPrincipalBindingSource;
            // 
            // dsMultidatos
            // 
            this.dsMultidatos.DataSetName = "DsMultidatos";
            this.dsMultidatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtConfiDtTarifaTipoBindingSource
            // 
            this.dtConfiDtTarifaTipoBindingSource.DataMember = "FK_DtConfiguracionPrincipal_DtTarifaTipo";
            this.dtConfiDtTarifaTipoBindingSource.DataSource = this.dtConfiguracionPrincipalBindingSource;
            // 
            // dtInicioMultiBindingSource
            // 
            this.dtInicioMultiBindingSource.DataMember = "DtInicioMulti";
            this.dtInicioMultiBindingSource.DataSource = this.dsMultidatos;
            // 
            // dtPaisesBindingSource
            // 
            this.dtPaisesBindingSource.DataMember = "DtPaises";
            this.dtPaisesBindingSource.DataSource = this.dsMulti2;
            // 
            // dsMulti2
            // 
            this.dsMulti2.DataSetName = "DsMulti2";
            this.dsMulti2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtProvinciasBindingSource
            // 
            this.dtProvinciasBindingSource.DataMember = "DtProvincias";
            this.dtProvinciasBindingSource.DataSource = this.dsMulti2;
            // 
            // dtConfiBindingSource
            // 
            this.dtConfiBindingSource.DataMember = "DtConfi";
            this.dtConfiBindingSource.DataSource = this.dsCONFIGURACCION;
            // 
            // errorProvider1Confi
            // 
            this.errorProvider1Confi.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1Confi.ContainerControl = this;
            // 
            // idTarifaDataGridViewTextBoxColumn
            // 
            this.idTarifaDataGridViewTextBoxColumn.DataPropertyName = "IdTarifa";
            this.idTarifaDataGridViewTextBoxColumn.HeaderText = "IdTarifa";
            this.idTarifaDataGridViewTextBoxColumn.Name = "idTarifaDataGridViewTextBoxColumn";
            // 
            // tarifaTipoDataGridViewTextBoxColumn
            // 
            this.tarifaTipoDataGridViewTextBoxColumn.DataPropertyName = "TarifaTipo";
            this.tarifaTipoDataGridViewTextBoxColumn.HeaderText = "TarifaTipo";
            this.tarifaTipoDataGridViewTextBoxColumn.Name = "tarifaTipoDataGridViewTextBoxColumn";
            // 
            // enlaceTarifaDataGridViewTextBoxColumn
            // 
            this.enlaceTarifaDataGridViewTextBoxColumn.DataPropertyName = "EnlaceTarifa";
            this.enlaceTarifaDataGridViewTextBoxColumn.HeaderText = "EnlaceTarifa";
            this.enlaceTarifaDataGridViewTextBoxColumn.Name = "enlaceTarifaDataGridViewTextBoxColumn";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "Selección de nuevo elemento";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Location = new System.Drawing.Point(781, 2);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.miniToolStrip.Size = new System.Drawing.Size(783, 24);
            this.miniToolStrip.TabIndex = 45;
            // 
            // dtObrasBindingSource
            // 
            this.dtObrasBindingSource.DataMember = "DtObras";
            this.dtObrasBindingSource.DataSource = this.dsMulti2;
            // 
            // dtNombresTablasBindingSource
            // 
            this.dtNombresTablasBindingSource.DataMember = "DtNombresTablas";
            this.dtNombresTablasBindingSource.DataSource = this.dsMultidatosBindingSource;
            // 
            // dsMultidatosBindingSource
            // 
            this.dsMultidatosBindingSource.DataSource = this.dsMultidatos;
            this.dsMultidatosBindingSource.Position = 0;
            // 
            // idProveedoresDataGridViewTextBoxColumn
            // 
            this.idProveedoresDataGridViewTextBoxColumn.DataPropertyName = "Id_Proveedores";
            this.idProveedoresDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idProveedoresDataGridViewTextBoxColumn.Name = "idProveedoresDataGridViewTextBoxColumn";
            this.idProveedoresDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProveedoresDataGridViewTextBoxColumn.Width = 153;
            // 
            // BtnRestructurar
            // 
            this.BtnRestructurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(1)))));
            this.BtnRestructurar.FlatAppearance.BorderSize = 0;
            this.BtnRestructurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.BtnRestructurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.BtnRestructurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRestructurar.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestructurar.Image = global::PELOSCALVO.Properties.Resources.Flecha_Derecha;
            this.BtnRestructurar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRestructurar.Location = new System.Drawing.Point(680, 297);
            this.BtnRestructurar.Name = "BtnRestructurar";
            this.BtnRestructurar.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.BtnRestructurar.Size = new System.Drawing.Size(277, 42);
            this.BtnRestructurar.TabIndex = 47;
            this.BtnRestructurar.Text = "RESTRUCTURAR ARCHIVOS";
            this.BtnRestructurar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnRestructurar.UseVisualStyleBackColor = false;
            this.BtnRestructurar.Click += new System.EventHandler(this.BtnRestructurar_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolArchivo,
            this.toolCopiaSeguridad,
            this.ayudaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip.TabIndex = 45;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.MouseLeave += new System.EventHandler(this.menuStrip_MouseLeave);
            // 
            // toolArchivo
            // 
            this.toolArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem,
            this.abrirBaseDatosToolStripMenuItem,
            this.abrirPdfToolStripMenuItem,
            this.añadirBaseDatosToolStripMenuItem,
            this.crearBaseDatosSqlLocalToolStripMenuItem,
            this.imprimirReportesToolStripMenuItem});
            this.toolArchivo.Name = "toolArchivo";
            this.toolArchivo.Size = new System.Drawing.Size(60, 20);
            this.toolArchivo.Text = "Archivo";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verToolStripMenuItem.Text = "&Ver";
            // 
            // abrirBaseDatosToolStripMenuItem
            // 
            this.abrirBaseDatosToolStripMenuItem.Name = "abrirBaseDatosToolStripMenuItem";
            this.abrirBaseDatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirBaseDatosToolStripMenuItem.Text = "&Abrir Base Datos";
            // 
            // abrirPdfToolStripMenuItem
            // 
            this.abrirPdfToolStripMenuItem.Name = "abrirPdfToolStripMenuItem";
            this.abrirPdfToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirPdfToolStripMenuItem.Text = "&Abrir P.d.f";
            // 
            // añadirBaseDatosToolStripMenuItem
            // 
            this.añadirBaseDatosToolStripMenuItem.Name = "añadirBaseDatosToolStripMenuItem";
            this.añadirBaseDatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.añadirBaseDatosToolStripMenuItem.Text = "&Base Datos Db Local";
            this.añadirBaseDatosToolStripMenuItem.Click += new System.EventHandler(this.añadirBaseDatosToolStripMenuItem_Click);
            // 
            // crearBaseDatosSqlLocalToolStripMenuItem
            // 
            this.crearBaseDatosSqlLocalToolStripMenuItem.Name = "crearBaseDatosSqlLocalToolStripMenuItem";
            this.crearBaseDatosSqlLocalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearBaseDatosSqlLocalToolStripMenuItem.Text = "&Base Datos Sql ";
            this.crearBaseDatosSqlLocalToolStripMenuItem.Click += new System.EventHandler(this.crearBaseDatosSqlLocalToolStripMenuItem_Click);
            // 
            // imprimirReportesToolStripMenuItem
            // 
            this.imprimirReportesToolStripMenuItem.Name = "imprimirReportesToolStripMenuItem";
            this.imprimirReportesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimirReportesToolStripMenuItem.Text = "&Imprimir Reportes";
            this.imprimirReportesToolStripMenuItem.Click += new System.EventHandler(this.imprimirReportesToolStripMenuItem_Click);
            // 
            // toolCopiaSeguridad
            // 
            this.toolCopiaSeguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCopiaSeguridadToolStripMenuItem,
            this.restaurarCopiaToolStripMenuItem});
            this.toolCopiaSeguridad.Name = "toolCopiaSeguridad";
            this.toolCopiaSeguridad.Size = new System.Drawing.Size(106, 20);
            this.toolCopiaSeguridad.Text = "Copia Seguridad";
            // 
            // crearCopiaSeguridadToolStripMenuItem
            // 
            this.crearCopiaSeguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCopiaSimpleToolStripMenuItem,
            this.crearCopiaCompletaToolStripMenuItem1});
            this.crearCopiaSeguridadToolStripMenuItem.Name = "crearCopiaSeguridadToolStripMenuItem";
            this.crearCopiaSeguridadToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.crearCopiaSeguridadToolStripMenuItem.Text = "Crear copia";
            // 
            // crearCopiaSimpleToolStripMenuItem
            // 
            this.crearCopiaSimpleToolStripMenuItem.Name = "crearCopiaSimpleToolStripMenuItem";
            this.crearCopiaSimpleToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.crearCopiaSimpleToolStripMenuItem.Text = "Crear copia Simple";
            // 
            // crearCopiaCompletaToolStripMenuItem1
            // 
            this.crearCopiaCompletaToolStripMenuItem1.Name = "crearCopiaCompletaToolStripMenuItem1";
            this.crearCopiaCompletaToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.crearCopiaCompletaToolStripMenuItem1.Text = "Crear Copia Completa";
            this.crearCopiaCompletaToolStripMenuItem1.Click += new System.EventHandler(this.crearCopiaCompletaToolStripMenuItem1_Click);
            // 
            // restaurarCopiaToolStripMenuItem
            // 
            this.restaurarCopiaToolStripMenuItem.Name = "restaurarCopiaToolStripMenuItem";
            this.restaurarCopiaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.restaurarCopiaToolStripMenuItem.Text = "Restaurar Copia";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.índiceToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ay&uda";
            // 
            // índiceToolStripMenuItem
            // 
            this.índiceToolStripMenuItem.Name = "índiceToolStripMenuItem";
            this.índiceToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.índiceToolStripMenuItem.Text = "Índic&e";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.buscarToolStripMenuItem.Text = "&Buscar";
            // 
            // BtnSalirConfi
            // 
            this.BtnSalirConfi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalirConfi.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalirConfi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalirConfi.FlatAppearance.BorderSize = 0;
            this.BtnSalirConfi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnSalirConfi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnSalirConfi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalirConfi.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirConfi.Image = global::PELOSCALVO.Properties.Resources.Salir;
            this.BtnSalirConfi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalirConfi.Location = new System.Drawing.Point(915, 465);
            this.BtnSalirConfi.Name = "BtnSalirConfi";
            this.BtnSalirConfi.Size = new System.Drawing.Size(77, 63);
            this.BtnSalirConfi.TabIndex = 13;
            this.BtnSalirConfi.Text = "Salir";
            this.BtnSalirConfi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalirConfi.UseVisualStyleBackColor = false;
            this.BtnSalirConfi.Click += new System.EventHandler(this.BtnSalirTipoTarifa_Click);
            // 
            // dtTarifaTipoBindingSource
            // 
            this.dtTarifaTipoBindingSource.DataMember = "DtTarifaTipo";
            this.dtTarifaTipoBindingSource.DataSource = this.dsCONFIGURACCION;
            // 
            // FormComfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 556);
            this.Controls.Add(this.BtnSalirConfi);
            this.Controls.Add(this.BtnRestructurar);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(32, 39);
            this.Name = "FormComfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Comfiguracion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormComfiguracion_FormClosing);
            this.Load += new System.EventHandler(this.FormComfiguracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalDtConfiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiDtTarifaTipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMulti2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProvinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1Confi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtObrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNombresTablasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatosBindingSource)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarifaTipoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource dtConfiBindingSource;
        private DsCONFIGURACCION dsCONFIGURACCION;
        private System.Windows.Forms.BindingSource dtConfiguracionPrincipalBindingSource;
        private System.Windows.Forms.BindingSource dtConfiDtTarifaTipoBindingSource;
        private System.Windows.Forms.BindingSource dtConfiguracionPrincipalDtConfiBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1Confi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTarifaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifaTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enlaceTarifaDataGridViewTextBoxColumn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DsMultidatos dsMultidatos;
        private System.Windows.Forms.BindingSource dtInicioMultiBindingSource;
        private System.Windows.Forms.BindingSource dtProvinciasBindingSource;
        private System.Windows.Forms.BindingSource dtPaisesBindingSource;
        private System.Windows.Forms.MenuStrip miniToolStrip;
        private System.Windows.Forms.BindingSource dtObrasBindingSource;
        private DsMulti2 dsMulti2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedoresDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dtNombresTablasBindingSource;
        private System.Windows.Forms.BindingSource dsMultidatosBindingSource;
        private System.Windows.Forms.Button BtnRestructurar;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolArchivo;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirBaseDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirPdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirBaseDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearBaseDatosSqlLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolCopiaSeguridad;
        private System.Windows.Forms.ToolStripMenuItem crearCopiaSeguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCopiaSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCopiaCompletaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restaurarCopiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem índiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.Button BtnSalirConfi;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiaProductosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource dtTarifaTipoBindingSource;
    }
}