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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnContSpace_Click(object sender, EventArgs e)
        {
            int contador = 0;
            string Text = rchtextTexto.Text;

            for(int i = 0; i < Text.Length; i++)
            {
                if (Char.IsWhiteSpace(Text[i]))
                {
                    contador++;
                }
            }
            MessageBox.Show($"Tem {contador} espaços em branco");
        }

        private void btnContR_Click(object sender, EventArgs e)
        {
            int contador = 0;
            string texto = rchtextTexto.Text;

            foreach(char letter in texto)
            {
                if('R' == Char.ToUpper(letter))
                {
                    contador++;
                }
            }
            MessageBox.Show($"Tem {contador} R no texto");
        }

        private void btnContSequel_Click(object sender, EventArgs e)
        {
            int contador = 0;
            string texto = rchtextTexto.Text.Replace(" ","");

            for(int i = 1; i < texto.Length; i++)
            if (texto[i] == texto[i - 1])
            {
                    contador++;
            }

        MessageBox.Show($"Tem {contador} conjunto de letras seguidas");
        }
    }
}
