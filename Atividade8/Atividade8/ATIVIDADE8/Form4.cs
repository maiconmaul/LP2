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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnExceute_Click(object sender, EventArgs e)
        {
            string text = txtVerify.Text.Replace(" ","");
            char[] arrayword = text.ToCharArray();
            Array.Reverse(arrayword);
            string auxText = txtVerify.Text.Replace(" ","");

            text = "";

            foreach(char letter in arrayword)
            {
                text = text + letter.ToString();
            }

            if(String.Compare(auxText, text, true) == 0)
            {
                MessageBox.Show("O texto é um palindromo");
            }
            else
            {
                MessageBox.Show("O texto não é um palindromo");
            }
        }
    }
}
