using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
            wbBuscador.Navigate("www.google.com");
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            wbBuscador.GoBack();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            wbBuscador.GoForward();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            wbBuscador.Refresh();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            wbBuscador.Navigate("www.google.com");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            wbBuscador.Navigate(txtBusqueda.Text);
        }
    }
}
