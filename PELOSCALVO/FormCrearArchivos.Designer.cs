
namespace PELOSCALVO
{
    partial class FormCrearArchivos
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
            System.Windows.Forms.Label tipoExtensionArticulosLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearArchivos));
            this.panelArticulos = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreArchivoClonar = new System.Windows.Forms.Label();
            this.tipoExtension = new System.Windows.Forms.ComboBox();
            this.SerieCrear = new System.Windows.Forms.ComboBox();
            this.dsCONFIGURACCION = new PELOSCALVO.DsCONFIGURACCION();
            this.BtnCrearArchivoDatos = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            tipoExtensionArticulosLabel = new System.Windows.Forms.Label();
            this.panelArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).BeginInit();
            this.SuspendLayout();
            // 
            // tipoExtensionArticulosLabel
            // 
            tipoExtensionArticulosLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tipoExtensionArticulosLabel.AutoSize = true;
            tipoExtensionArticulosLabel.Location = new System.Drawing.Point(245, 207);
            tipoExtensionArticulosLabel.Name = "tipoExtensionArticulosLabel";
            tipoExtensionArticulosLabel.Size = new System.Drawing.Size(56, 13);
            tipoExtensionArticulosLabel.TabIndex = 29;
            tipoExtensionArticulosLabel.Text = "Extension:";
            // 
            // panelArticulos
            // 
            this.panelArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelArticulos.BackColor = System.Drawing.Color.DarkSalmon;
            this.panelArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelArticulos.Controls.Add(this.label1);
            this.panelArticulos.Controls.Add(this.label2);
            this.panelArticulos.Controls.Add(this.NombreArchivoClonar);
            this.panelArticulos.Controls.Add(tipoExtensionArticulosLabel);
            this.panelArticulos.Controls.Add(this.tipoExtension);
            this.panelArticulos.Controls.Add(this.SerieCrear);
            this.panelArticulos.Location = new System.Drawing.Point(12, 68);
            this.panelArticulos.Name = "panelArticulos";
            this.panelArticulos.Size = new System.Drawing.Size(742, 251);
            this.panelArticulos.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Archivo Base:";
            // 
            // NombreArchivoClonar
            // 
            this.NombreArchivoClonar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NombreArchivoClonar.AutoSize = true;
            this.NombreArchivoClonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreArchivoClonar.Location = new System.Drawing.Point(329, 149);
            this.NombreArchivoClonar.Name = "NombreArchivoClonar";
            this.NombreArchivoClonar.Size = new System.Drawing.Size(53, 18);
            this.NombreArchivoClonar.TabIndex = 31;
            this.NombreArchivoClonar.Text = "Tarifa1";
            // 
            // tipoExtension
            // 
            this.tipoExtension.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tipoExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoExtension.Enabled = false;
            this.tipoExtension.FormattingEnabled = true;
            this.tipoExtension.Items.AddRange(new object[] {
            "DBF",
            "mdb",
            "accdb"});
            this.tipoExtension.Location = new System.Drawing.Point(316, 204);
            this.tipoExtension.Name = "tipoExtension";
            this.tipoExtension.Size = new System.Drawing.Size(124, 21);
            this.tipoExtension.TabIndex = 30;
            // 
            // SerieCrear
            // 
            this.SerieCrear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SerieCrear.Cursor = System.Windows.Forms.Cursors.Default;
            this.SerieCrear.DisplayMember = "A";
            this.SerieCrear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SerieCrear.FormattingEnabled = true;
            this.SerieCrear.Items.AddRange(new object[] {
            "Nuevo o Vacio"});
            this.SerieCrear.Location = new System.Drawing.Point(316, 181);
            this.SerieCrear.Name = "SerieCrear";
            this.SerieCrear.Size = new System.Drawing.Size(217, 21);
            this.SerieCrear.TabIndex = 24;
            // 
            // dsCONFIGURACCION
            // 
            this.dsCONFIGURACCION.DataSetName = "DsCONFIGURACCION";
            this.dsCONFIGURACCION.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnCrearArchivoDatos
            // 
            this.BtnCrearArchivoDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCrearArchivoDatos.Location = new System.Drawing.Point(601, 359);
            this.BtnCrearArchivoDatos.Name = "BtnCrearArchivoDatos";
            this.BtnCrearArchivoDatos.Size = new System.Drawing.Size(123, 58);
            this.BtnCrearArchivoDatos.TabIndex = 29;
            this.BtnCrearArchivoDatos.Text = "Clonar o Crear";
            this.BtnCrearArchivoDatos.UseVisualStyleBackColor = true;
            this.BtnCrearArchivoDatos.Click += new System.EventHandler(this.BtnCrearArchivoDatos_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(283, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(206, 39);
            this.labelInfo.TabIndex = 32;
            this.labelInfo.Text = "vacio               1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nuevo Archivo a crear:";
            // 
            // FormCrearArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 429);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.BtnCrearArchivoDatos);
            this.Controls.Add(this.panelArticulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCrearArchivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear Archivos";
            this.Load += new System.EventHandler(this.FormCrearArchivos_Load);
            this.panelArticulos.ResumeLayout(false);
            this.panelArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelArticulos;
        public System.Windows.Forms.ComboBox tipoExtension;
        public System.Windows.Forms.ComboBox SerieCrear;
        private DsCONFIGURACCION dsCONFIGURACCION;
        private System.Windows.Forms.Button BtnCrearArchivoDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NombreArchivoClonar;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label label1;
    }
}