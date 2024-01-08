
namespace PELOSCALVO
{
    partial class FormBuscar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscar));
            this.DataGridBuscar = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buscador2 = new System.Windows.Forms.TextBox();
            this.TipoBuscar2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ContadorBus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridBuscar
            // 
            this.DataGridBuscar.AllowUserToAddRows = false;
            this.DataGridBuscar.AllowUserToDeleteRows = false;
            this.DataGridBuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridBuscar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Dato,
            this.IdFila});
            this.DataGridBuscar.Location = new System.Drawing.Point(2, 63);
            this.DataGridBuscar.Name = "DataGridBuscar";
            this.DataGridBuscar.ReadOnly = true;
            this.DataGridBuscar.RowHeadersVisible = false;
            this.DataGridBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridBuscar.Size = new System.Drawing.Size(796, 300);
            this.DataGridBuscar.TabIndex = 0;
            this.DataGridBuscar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridBuscar_CellDoubleClick);
            // 
            // Id
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.FillWeight = 120F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Dato
            // 
            this.Dato.FillWeight = 300F;
            this.Dato.HeaderText = "Dato";
            this.Dato.Name = "Dato";
            this.Dato.ReadOnly = true;
            // 
            // IdFila
            // 
            this.IdFila.HeaderText = "IdFila";
            this.IdFila.Name = "IdFila";
            this.IdFila.ReadOnly = true;
            // 
            // Buscador2
            // 
            this.Buscador2.Location = new System.Drawing.Point(220, 12);
            this.Buscador2.Name = "Buscador2";
            this.Buscador2.Size = new System.Drawing.Size(366, 20);
            this.Buscador2.TabIndex = 1;
            this.Buscador2.TextChanged += new System.EventHandler(this.Buscador2_TextChanged);
            // 
            // TipoBuscar2
            // 
            this.TipoBuscar2.FormattingEnabled = true;
            this.TipoBuscar2.Items.AddRange(new object[] {
            "Todos",
            "Id",
            "Dato"});
            this.TipoBuscar2.Location = new System.Drawing.Point(4, 12);
            this.TipoBuscar2.Name = "TipoBuscar2";
            this.TipoBuscar2.Size = new System.Drawing.Size(195, 21);
            this.TipoBuscar2.TabIndex = 2;
            this.TipoBuscar2.Text = "Todos";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reguistros #";
            // 
            // ContadorBus
            // 
            this.ContadorBus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ContadorBus.AutoSize = true;
            this.ContadorBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContadorBus.Location = new System.Drawing.Point(141, 383);
            this.ContadorBus.Name = "ContadorBus";
            this.ContadorBus.Size = new System.Drawing.Size(19, 20);
            this.ContadorBus.TabIndex = 11;
            this.ContadorBus.Text = "0";
            this.ContadorBus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContadorBus);
            this.Controls.Add(this.Buscador2);
            this.Controls.Add(this.TipoBuscar2);
            this.Controls.Add(this.DataGridBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 468);
            this.MinimumSize = new System.Drawing.Size(816, 468);
            this.Name = "FormBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.FormBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridBuscar;
        private System.Windows.Forms.TextBox Buscador2;
        private System.Windows.Forms.ComboBox TipoBuscar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ContadorBus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dato;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFila;
    }
}