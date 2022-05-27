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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnContNum_Click(object sender, EventArgs e)
        {
            int contador = 0;
            string textOn = rchtxtText.Text;

            for (int i = 0; i < textOn.Length; i++)
                if (Char.IsNumber(textOn[i]))
                    contador++;

            MessageBox.Show($"Existe {contador.ToString()} numero(s)!");
        }

        private void btnFindSpace_Click(object sender, EventArgs e)
        {
            int contador = 0, i = 0;
            string textOn = rchtxtText.Text;
            while(contador < textOn.Length)
            {
                if(Char.IsWhiteSpace(textOn[contador]))
                    break;
                else
                   contador++;
            }
            MessageBox.Show($"O primeiro espaço começa na posição {contador.ToString()} da cadeia de caracter");
        }

        private void btnContLetters_Click(object sender, EventArgs e)
        {
            string arrayWord = rchtxtText.Text;
            int contador = 0;

            foreach (char letter in arrayWord)
                if(Char.IsLetter(letter))
                    contador++;

            MessageBox.Show($"Existe {contador.ToString()} letra(s)!");
        }
    }
}
