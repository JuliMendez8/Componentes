namespace Browser
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
            this.tsBuscador = new System.Windows.Forms.ToolStrip();
            this.btnAtras = new System.Windows.Forms.ToolStripButton();
            this.btnAdelante = new System.Windows.Forms.ToolStripButton();
            this.btnRecargar = new System.Windows.Forms.ToolStripButton();
            this.btnInicio = new System.Windows.Forms.ToolStripButton();
            this.txtBusqueda = new System.Windows.Forms.ToolStripTextBox();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.wbBuscador = new System.Windows.Forms.WebBrowser();
            this.tsBuscador.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsBuscador
            // 
            this.tsBuscador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAtras,
            this.btnAdelante,
            this.btnRecargar,
            this.btnInicio,
            this.txtBusqueda,
            this.btnBuscar});
            this.tsBuscador.Location = new System.Drawing.Point(0, 0);
            this.tsBuscador.Name = "tsBuscador";
            this.tsBuscador.Size = new System.Drawing.Size(800, 25);
            this.tsBuscador.TabIndex = 0;
            this.tsBuscador.Text = "toolStrip1";
            // 
            // btnAtras
            // 
            this.btnAtras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(23, 22);
            this.btnAtras.Text = "toolStripButton1";
            this.btnAtras.ToolTipText = "Atrás";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAdelante
            // 
            this.btnAdelante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdelante.Image = ((System.Drawing.Image)(resources.GetObject("btnAdelante.Image")));
            this.btnAdelante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(23, 22);
            this.btnAdelante.Text = "toolStripButton2";
            this.btnAdelante.ToolTipText = "Adelante";
            this.btnAdelante.Click += new System.EventHandler(this.btnAdelante_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRecargar.Image = ((System.Drawing.Image)(resources.GetObject("btnRecargar.Image")));
            this.btnRecargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(23, 22);
            this.btnRecargar.Text = "toolStripButton3";
            this.btnRecargar.ToolTipText = "Recargar";
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(23, 22);
            this.btnInicio.Text = "toolStripButton4";
            this.btnInicio.ToolTipText = "Home";
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(600, 25);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 22);
            this.btnBuscar.Text = "toolStripButton1";
            this.btnBuscar.ToolTipText = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // wbBuscador
            // 
            this.wbBuscador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbBuscador.Location = new System.Drawing.Point(0, 25);
            this.wbBuscador.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBuscador.Name = "wbBuscador";
            this.wbBuscador.Size = new System.Drawing.Size(800, 425);
            this.wbBuscador.TabIndex = 1;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wbBuscador);
            this.Controls.Add(this.tsBuscador);
            this.Name = "frm1";
            this.Text = "Form1";
            this.tsBuscador.ResumeLayout(false);
            this.tsBuscador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsBuscador;
        private System.Windows.Forms.ToolStripButton btnAtras;
        private System.Windows.Forms.ToolStripButton btnAdelante;
        private System.Windows.Forms.ToolStripButton btnRecargar;
        private System.Windows.Forms.ToolStripButton btnInicio;
        private System.Windows.Forms.ToolStripTextBox txtBusqueda;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.WebBrowser wbBuscador;
    }
}

