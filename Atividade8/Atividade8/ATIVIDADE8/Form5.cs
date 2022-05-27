using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE8
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double salarioBruto;

            if (!double.TryParse(txtSalary.Text, out double A))
            {
                MessageBox.Show("Digite numeros(salario)");
                return;
            }

            if (!int.TryParse(txtProduction.Text, out int producao))
            {
                MessageBox.Show("Digite numeros(produção)");
                return;
            }

            if (!double.TryParse(txtBonus.Text, out double bonus))
            {
                MessageBox.Show("Digite numeros(Gratificação)");
                return;
            }

            int B = producao >= 100 ? 1 : 0;
            int C = producao >= 120 ? 1 : 0;
            int D = producao >= 150 ? 1 : 0;

            salarioBruto = A + A * (0.05 * B + 0.1 * C + 0.1 * D) + bonus;

            if (salarioBruto <= 7000)
            {
                txtResultGrossWage.Text = salarioBruto.ToString("C2");

            }
            else if (salarioBruto > 7000 && bonus > 0 && producao >= 150)
            {
                txtResultGrossWage.Text = salarioBruto.ToString("C2");

            }
            else
            {
                txtResultGrossWage.Text = "Salário de deputado?";
            }
        }

        private void txtName_Validated(object sender, EventArgs e)
        {
            int numericValue;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("digite seu nome");
                txtName.Focus();
            }
            else
            {
                bool isNumber = int.TryParse(txtName.Text, out numericValue);
                if (isNumber == true)
                {
                    MessageBox.Show("Digite letras");
                    txtName.Focus();
                }

            }
        }
        private void txtRegistration_Validated(object sender, EventArgs e)
        {
            int matricul;
            if (!int.TryParse(txtRegistration.Text, out matricul))
            {
                MessageBox.Show("Digite numeros");
                txtRegistration.Focus();
            }
        }

        private void cbxFunction_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbxFunction.Text))
            {
                MessageBox.Show("Escolha o seu cargo");
                cbxFunction.Focus();
            }
        }
    }
}
