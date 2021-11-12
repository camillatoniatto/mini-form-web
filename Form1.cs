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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = txtBox.Text;
            txtBox.Text = "";
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            Form2 calc = new Form2();
            calc.Show();
        }
    }
}
