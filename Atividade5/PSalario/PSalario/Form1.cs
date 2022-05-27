using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (!CamposValidos())
                return;

            double salarioBruto = double.Parse(mskbxSalBruto.Text);
            int qtdFilhos = int.Parse(cbxQtdFilhos.SelectedItem.ToString());
            double descontoInss = CalcularDescontoInss(salarioBruto);
            double descontoIrpf = CalcularImpostoRenda(salarioBruto);
            double salFamilia = CalcularSalarioFamilia(salarioBruto, qtdFilhos);

            txtDescInss.Text = descontoInss.ToString("C");
            txtDescIrpf.Text = descontoIrpf == 0 ? "Isento" : descontoIrpf.ToString("C");
            txtSalFamilia.Text = salFamilia.ToString("C");

            double salLiquido = salarioBruto - descontoInss - descontoIrpf + salFamilia;
            txtSalLiquido.Text = salLiquido.ToString("C");
            string estCivil = ckbxCasado.Checked ? "casado(a)" : "solteiro(a)";
            string sexo = rbtnMasc.Checked ? "o Sr." : "a Sra.";

            lblDados.Text = "Os descontos do salário d" + sexo + " " +  txtNome.Text + " que é " + estCivil + " e que tem " + qtdFilhos + " filhos(s) são:";
        }

        private double CalcularSalarioFamilia(double salarioBruto, int qtdFilhos)
        {
            double salFamilia = 0.0;

            if (salarioBruto <= 435.52)
                salFamilia = (qtdFilhos * 22.33);
            else if (salarioBruto <= 654.61)
                salFamilia = (qtdFilhos * 15.74);

            return salFamilia;
        }

        private double CalcularImpostoRenda(double salarioBruto)
        {
            double descontoIrpf = 0.0;
            if (salarioBruto <= 1257.12)
                txtAliquotaIrpf.Text = "Isento";
            else if (salarioBruto <= 2512.08)
            {
                txtAliquotaIrpf.Text = "15.00%";
                descontoIrpf = (15.00 / 100) * salarioBruto;
            }
            else
            {
                txtAliquotaIrpf.Text = "27.5%";
                descontoIrpf = (27.5 / 100) * salarioBruto;
            }
            return descontoIrpf;
        }

        private double CalcularDescontoInss(double salarioBruto)
        {
            double descontoInss;
            if (salarioBruto <= 800.47)
            {
                txtAliquotaInss.Text = "7.65%";
                descontoInss = (7.65 / 100) * salarioBruto;
            }
            else if (salarioBruto <= 1050)
            {
                txtAliquotaInss.Text = "8.65%";
                descontoInss = (8.65 / 100) * salarioBruto;
            }
            else if (salarioBruto <= 1400.77)
            {
                txtAliquotaInss.Text = "9.00%";
                descontoInss = (9.00 / 100) * salarioBruto;
            }
            else if (salarioBruto <= 2801.56)
            {
                txtAliquotaInss.Text = "11.00%";
                descontoInss = (11.00 / 100) * salarioBruto;
            }
            else
            {
                txtAliquotaInss.Text = "Teto";
                descontoInss = 308.17;
            }
            return descontoInss;
        }

        private bool CamposValidos()
        {
            if (String.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Digite um nome válido.");
                return false;
            }
            if (cbxQtdFilhos.SelectedIndex < 0 || !int.TryParse(cbxQtdFilhos.SelectedItem.ToString(), out int qtdFilhos))
            {
                MessageBox.Show("Selecione a quantidade de filhos.");
                return false;
            }
            if (!double.TryParse(mskbxSalBruto.Text, out double salarioBruto))
            {
                MessageBox.Show("Sálario inválido.");
                return false;
            }
            return true;
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Digite um nome válido.");
            }
        }
    }
}
