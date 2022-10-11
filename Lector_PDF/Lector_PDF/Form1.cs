using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lector_PDF
{
    public partial class frm1 : Form
    {
        public string ruta = "";
        public frm1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            ofdAbrir.Filter = "Archivos PDF | *.pdf";

            if (ofdAbrir.ShowDialog() == DialogResult.OK)
            {
                AR_PDF.src = ofdAbrir.FileName;
            }
        }
    }
}
