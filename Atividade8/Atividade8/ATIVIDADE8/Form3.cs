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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            double H = 0;

            if(!int.TryParse(txtNumbers.Text, out int N))
            {
                MessageBox.Show("Digite um numero valido");
                return;
            }

            if(N <= 0)
                MessageBox.Show("Digite um numero maior que zero");
            else
            {
                for(double i = 1; i <= N; i++)
                {
                    H += 1 / i ;

                    MessageBox.Show($"{H}");
                }
                
            }
        }
    }
}
