namespace ReproductorVideo
{
    partial class frmReproductor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReproductor));
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.TBVolume = new System.Windows.Forms.TrackBar();
            this.OFDEscoger = new System.Windows.Forms.OpenFileDialog();
            this.WPMReproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblVolume = new System.Windows.Forms.Label();
            this.PROGbProgress = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.tmrReproduce = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TBVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WPMReproductor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(12, 407);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(106, 31);
            this.btnChoose.TabIndex = 1;
            this.btnChoose.Text = "ESCOGER VIDEO";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(124, 407);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(126, 31);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "REPRODUCIR VIDEO";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(256, 407);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(126, 31);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "PAUSAR VIDEO";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(388, 407);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(126, 31);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "DETENER VIDEO";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // TBVolume
            // 
            this.TBVolume.Location = new System.Drawing.Point(566, 407);
            this.TBVolume.Maximum = 100;
            this.TBVolume.Name = "TBVolume";
            this.TBVolume.Size = new System.Drawing.Size(222, 45);
            this.TBVolume.TabIndex = 5;
            this.TBVolume.Scroll += new System.EventHandler(this.TBVolume_Scroll);
            // 
            // OFDEscoger
            // 
            this.OFDEscoger.FileName = "openFileDialog1";
            // 
            // WPMReproductor
            // 
            this.WPMReproductor.Enabled = true;
            this.WPMReproductor.Location = new System.Drawing.Point(12, 12);
            this.WPMReproductor.Name = "WPMReproductor";
            this.WPMReproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WPMReproductor.OcxState")));
            this.WPMReproductor.Size = new System.Drawing.Size(776, 389);
            this.WPMReproductor.TabIndex = 0;
            this.WPMReproductor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.WPMReproductor_PlayStateChange);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(547, 416);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(13, 13);
            this.lblVolume.TabIndex = 6;
            this.lblVolume.Text = "0";
            // 
            // PROGbProgress
            // 
            this.PROGbProgress.Location = new System.Drawing.Point(12, 356);
            this.PROGbProgress.Name = "PROGbProgress";
            this.PROGbProgress.Size = new System.Drawing.Size(776, 45);
            this.PROGbProgress.TabIndex = 7;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(23, 23);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(34, 13);
            this.lblProgress.TabIndex = 8;
            this.lblProgress.Text = "00:00";
            // 
            // tmrReproduce
            // 
            this.tmrReproduce.Tick += new System.EventHandler(this.tmrReproduce_Tick);
            // 
            // frmReproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.PROGbProgress);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.TBVolume);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.WPMReproductor);
            this.Name = "frmReproductor";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TBVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WPMReproductor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WPMReproductor;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TrackBar TBVolume;
        private System.Windows.Forms.OpenFileDialog OFDEscoger;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.ProgressBar PROGbProgress;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Timer tmrReproduce;
    }
}

