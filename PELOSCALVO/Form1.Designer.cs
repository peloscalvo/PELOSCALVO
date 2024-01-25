
namespace PELOSCALVO
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "User",
            "valor"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Pass");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passs = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Ccc = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolArchivo,
            this.toolCopiaSeguridad,
            this.ayudaToolStripMenuItem});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(642, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(112, 504);
            this.menuStrip.TabIndex = 46;
            this.menuStrip.Text = "menuStrip1";
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
            this.toolArchivo.Size = new System.Drawing.Size(99, 19);
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
            // 
            // crearBaseDatosSqlLocalToolStripMenuItem
            // 
            this.crearBaseDatosSqlLocalToolStripMenuItem.Name = "crearBaseDatosSqlLocalToolStripMenuItem";
            this.crearBaseDatosSqlLocalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearBaseDatosSqlLocalToolStripMenuItem.Text = "&Base Datos Sql ";
            // 
            // imprimirReportesToolStripMenuItem
            // 
            this.imprimirReportesToolStripMenuItem.Name = "imprimirReportesToolStripMenuItem";
            this.imprimirReportesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimirReportesToolStripMenuItem.Text = "&Imprimir Reportes";
            // 
            // toolCopiaSeguridad
            // 
            this.toolCopiaSeguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCopiaSeguridadToolStripMenuItem,
            this.restaurarCopiaToolStripMenuItem});
            this.toolCopiaSeguridad.Name = "toolCopiaSeguridad";
            this.toolCopiaSeguridad.Size = new System.Drawing.Size(99, 19);
            this.toolCopiaSeguridad.Text = "Copia Seguridad";
            // 
            // crearCopiaSeguridadToolStripMenuItem
            // 
            this.crearCopiaSeguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCopiaSimpleToolStripMenuItem,
            this.crearCopiaCompletaToolStripMenuItem1});
            this.crearCopiaSeguridadToolStripMenuItem.Name = "crearCopiaSeguridadToolStripMenuItem";
            this.crearCopiaSeguridadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // 
            // restaurarCopiaToolStripMenuItem
            // 
            this.restaurarCopiaToolStripMenuItem.Name = "restaurarCopiaToolStripMenuItem";
            this.restaurarCopiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restaurarCopiaToolStripMenuItem.Text = "Restaurar Copia";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.índiceToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(99, 19);
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
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(39, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(158, 130);
            this.listView1.TabIndex = 47;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USER,
            this.Passs,
            this.Ccc});
            this.dataGridView1.Location = new System.Drawing.Point(69, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(612, 231);
            this.dataGridView1.TabIndex = 48;
            // 
            // USER
            // 
            this.USER.FillWeight = 200F;
            this.USER.HeaderText = "user";
            this.USER.Name = "USER";
            this.USER.Width = 200;
            // 
            // Passs
            // 
            this.Passs.HeaderText = "Pass";
            this.Passs.Name = "Passs";
            this.Passs.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Passs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Ccc
            // 
            this.Ccc.HeaderText = "cccc";
            this.Ccc.Name = "Ccc";
            this.Ccc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ccc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 504);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Passs;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ccc;
    }
}