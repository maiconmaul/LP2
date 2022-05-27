using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMetodos
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumero2.Text, out int num2))
            {
                MessageBox.Show("Digite um numero maximo");
                return;
            }
            if (!int.TryParse(txtNumero1.Text, out int num1))
            {
                MessageBox.Show("Digite um numero minimo");
                return;
            }
            if (num2 > num1)
            {
                MessageBox.Show("o numero no maximo nao pode ser menor que o minimo");
                return;
            }

            Random randomNum = new Random();
            int result = randomNum.Next(num2, num1);
            MessageBox.Show(result.ToString());
        }
    }
}
