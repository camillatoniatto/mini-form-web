using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tds
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bntSomar_Click(object sender, EventArgs e)
        {
            int valorA = Convert.ToInt32(txtValorA.Text);
            int valorB = Convert.ToInt32(txtValorB.Text);
            int soma = valorA + valorB;
            lblResultado.Text = Convert.ToString(soma);
            txtValorA.Text = "";
            txtValorB.Text = "";
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int valorA = Convert.ToInt32(txtValorA.Text);
            int valorB = Convert.ToInt32(txtValorB.Text);
            int subtrair = valorA - valorB;
            lblResultado.Text = Convert.ToString(subtrair);
            txtValorA.Text = "";
            txtValorB.Text = "";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int valorA = Convert.ToInt32(txtValorA.Text);
            int valorB = Convert.ToInt32(txtValorB.Text);
            int multi = valorA * valorB;
            lblResultado.Text = Convert.ToString(multi);
            txtValorA.Text = "";
            txtValorB.Text = "";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int valorA = Convert.ToInt32(txtValorA.Text);
            int valorB = Convert.ToInt32(txtValorB.Text);
            int div = valorA / valorB;
            lblResultado.Text = Convert.ToString(div);
            txtValorA.Text = "";
            txtValorB.Text = "";
        }
    }
}
