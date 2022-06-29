using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtivdTreinamentoTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nbase = 0;
            double naltura = 0;
            double resultado = 0;

            if(txtAltura.Text != "" && txtBase.Text != "")
            {
                naltura = double.Parse(txtAltura.Text);
                nbase = double.Parse(txtBase.Text);
            }
            resultado = nbase * naltura / 2;

            lblResultado.Text = resultado.ToString();




        }
    }
}
