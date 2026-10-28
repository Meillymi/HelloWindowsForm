using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(txtPeso.Text);
            double altura = double.Parse(txtAltura.Text);
            double imc = peso / (altura * altura);
            lblResultado.Text = $"IMC CALCULADO: {imc:F2}";

            if( imc <= 24.9 && imc >= 18.5)
            {
                lblObs.Text = ("(18,5 - 24,9) Peso normal");
            }
            else if (imc <= 29.9 && imc >= 25)
            {
                lblObs.Text = ("(25 - 29,9) Sobrepeso");
            }
            else if (imc <= 34.9 && imc >= 30)
            {
                lblObs.Text = ("(30 - 34,9) Obesidade Grau I");
            }
            else if (imc <= 39.9 && imc >= 35)
            {
                lblObs.Text = ("(35 - 39,9) Obesidade Grau II");
            }
            else if (imc >= 40)
            {
                lblObs.Text = ("Acima de 40: Obesidade Grau III ou mais");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
