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
    public partial class frmGastos : Form
    {
        //Declaracion de variables globales

        Decimal varDeposito = 0, varAlquiler = 0, varImpuestos = 0, varComida = 0, varOtrosGastos = 0 , varSaldorestante; 

        
        public frmGastos()
        {
            InitializeComponent();
        }

        private void txtComida_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Deposito_Click(object sender, EventArgs e)
        {

        }

        private void mrcIngreso_Enter(object sender, EventArgs e)
        {

        }

        private void frmGastos_Load(object sender, EventArgs e)
        {
           
        }

        private void CmdCalcular_Click(object sender, EventArgs e)
        {
            varDeposito = Convert.ToDecimal(txtDeposito.Text);
            varAlquiler = Convert.ToDecimal(txtAlquiler.Text);
            varComida = Convert.ToDecimal(txtComida.Text);
            varImpuestos = Convert.ToDecimal(txtImpuesto.Text);
            varOtrosGastos = Convert.ToDecimal(txtOtrosgastos.Text);

            varSaldorestante = varDeposito - (varAlquiler + varComida + varImpuestos + varOtrosGastos);

            lblResultado.Text = varSaldorestante .ToString();

        }
    }
}
