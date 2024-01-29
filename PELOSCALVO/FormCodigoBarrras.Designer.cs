
namespace PELOSCALVO
{
    partial class FormCodigoBarrras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCodigoBarrras));
            this.PanelCodigoBarra = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PanelCodigoBarra)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelCodigoBarra
            // 
            this.PanelCodigoBarra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCodigoBarra.Location = new System.Drawing.Point(0, 0);
            this.PanelCodigoBarra.Name = "PanelCodigoBarra";
            this.PanelCodigoBarra.Size = new System.Drawing.Size(735, 484);
            this.PanelCodigoBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PanelCodigoBarra.TabIndex = 0;
            this.PanelCodigoBarra.TabStop = false;
            // 
            // FormCodigoBarrras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 484);
            this.Controls.Add(this.PanelCodigoBarra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCodigoBarrras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Codigo Barras";
            this.Load += new System.EventHandler(this.FormCodigoBarrras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelCodigoBarra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox PanelCodigoBarra;
    }
}