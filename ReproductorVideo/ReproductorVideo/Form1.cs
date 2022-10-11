using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReproductorVideo
{
    public partial class frmReproductor : Form
    {
        public string ruta = "";
        public frmReproductor()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (OFDEscoger.ShowDialog() == DialogResult.OK)
            {
                ruta = OFDEscoger.FileName;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            WPMReproductor.URL = ruta;
            WPMReproductor.Ctlcontrols.play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            WPMReproductor.Ctlcontrols.pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            WPMReproductor.Ctlcontrols.stop();
        }

        private void TBVolume_Scroll(object sender, EventArgs e)
        {
            WPMReproductor.settings.volume = TBVolume.Value;
            lblVolume.Text = TBVolume.Value.ToString();
        }

        private void WPMReproductor_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (WPMReproductor.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                PROGbProgress.Maximum = (int)WPMReproductor.Ctlcontrols.currentItem.duration;
                tmrReproduce.Start();
            }
            else if (WPMReproductor.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                tmrReproduce.Stop();
            }
            else if(WPMReproductor.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                tmrReproduce.Stop();
                PROGbProgress.Value = 0;
            }
        }

        private void tmrReproduce_Tick(object sender, EventArgs e)
        {
            if (WPMReproductor.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                PROGbProgress.Value = (int)WPMReproductor.Ctlcontrols.currentPosition;
            }
        }
    }
}
