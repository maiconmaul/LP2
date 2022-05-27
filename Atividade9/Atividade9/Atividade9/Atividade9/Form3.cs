using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Atividade9
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            double faturaMensal = 0;
            int[] quantity = new int[10];
            double[] price = new double[10];
            string cadastroQtd, cadastroPrc;
            int i = 0;

            for (int x = 0; x < 10; x++)
            {
                cadastroQtd = Interaction.InputBox("PRODUTO Nº " + (x + 1) + " Informe a Quantidade de itens", "Cadastro de produto");
                if (cadastroQtd == "")
                {                          
                    break;
                }
                else if (!int.TryParse(cadastroQtd, out quantity[x]) || quantity[x] < 0)
                {
                    MessageBox.Show("Digite um numero valido");
                    x -= 1;
                }
                else
                {
                    listQtd.Items.Add(quantity[x]);
                    while (true)                   
                    {
                            cadastroPrc = Interaction.InputBox("PRODUTO Nº " + (i + 1) + " Informe o Preço do(s) itens", "Cadastro de produto");
                            if (cadastroPrc == "")
                            {
                            break;
                            }
                            else if (!double.TryParse(cadastroPrc, out price[i]) || price[i] < 0)
                            {
                                MessageBox.Show("Digite um numero valido");
                                i -= 1;
                            }
                            else
                            {
                            listPrc.Items.Add(cadastroPrc);
                            faturaMensal += price[i] * quantity[i];
                            txtResult.Text = faturaMensal.ToString("C2");
                            }
                        i++;
                        break;
                    }
                }
            }
        }
    }
}
