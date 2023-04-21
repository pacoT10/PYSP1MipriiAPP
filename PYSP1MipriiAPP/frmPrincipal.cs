using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PYSP1MipriiAPP
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCargaDeDatosEnLaAlacena ventanaAlacena = new frmCargaDeDatosEnLaAlacena();

            ventanaAlacena.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGastos ventanaGastos = new frmGastos();
           
            ventanaGastos.ShowDialog();
        }
    }
}
