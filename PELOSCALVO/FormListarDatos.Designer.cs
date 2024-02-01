
namespace PELOSCALVO
{
    partial class FormListarDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListarDatos));
            this.ListadoDatos2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ListadoDatos2
            // 
            this.ListadoDatos2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ListadoDatos2.FormattingEnabled = true;
            this.ListadoDatos2.Location = new System.Drawing.Point(0, 82);
            this.ListadoDatos2.Name = "ListadoDatos2";
            this.ListadoDatos2.Size = new System.Drawing.Size(800, 368);
            this.ListadoDatos2.TabIndex = 0;
            // 
            // FormListarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListadoDatos2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListarDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.FormListarDatos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox ListadoDatos2;
    }
}