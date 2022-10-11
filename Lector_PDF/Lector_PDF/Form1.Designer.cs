namespace Lector_PDF
{
    partial class frm1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1));
            this.AR_PDF = new AxAcroPDFLib.AxAcroPDF();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.ofdAbrir = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.AR_PDF)).BeginInit();
            this.SuspendLayout();
            // 
            // AR_PDF
            // 
            this.AR_PDF.Enabled = true;
            this.AR_PDF.Location = new System.Drawing.Point(12, 12);
            this.AR_PDF.Name = "AR_PDF";
            this.AR_PDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AR_PDF.OcxState")));
            this.AR_PDF.Size = new System.Drawing.Size(630, 426);
            this.AR_PDF.TabIndex = 0;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(675, 12);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(95, 75);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "ABRIR";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // ofdAbrir
            // 
            this.ofdAbrir.FileName = "openFileDialog1";
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.AR_PDF);
            this.Name = "frm1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AR_PDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF AR_PDF;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.OpenFileDialog ofdAbrir;
    }
}

