using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(MskbxAltura.Text, out double altura))
            {
                MessageBox.Show("Altura inválida!");
                MskbxAltura.Focus();
                return;
            }
            if (!Double.TryParse(MskbxPeso.Text, out double peso))
            {
                MessageBox.Show("Peso inválido!");
                MskbxPeso.Focus();
                return;
            }

            var resultado = peso / Math.Pow(altura, 2);
            resultado = Math.Round(resultado, 1);
            string mensagem = "";
            Color cor = Color.Black;
            switch(resultado)
            {
                case double n when (n <= 18.5):
                    mensagem = "Magreza";
                    cor = Color.Red;
                    break;
                case double n when (n > 18.5 && n <= 24.9):
                    mensagem = "Normal";
                    cor = Color.Green;
                    break;
                case double n when (n > 24.9 && n <= 29.9):
                    mensagem = "Sobrepeso (I)";
                    cor = Color.Red;
                    break;
                case double n when (n > 29.9 && n <= 39.9):
                    mensagem = "Obesidade (II)";
                    cor = Color.Red;
                    break;
                case double n when (n > 40.0):
                    mensagem = "Obesidade Grave (III)";
                    cor = Color.Red;
                    break;
            }

            LblResultado.Text = resultado.ToString() + " -> " + mensagem;
            LblResultado.ForeColor = cor;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MskbxAltura_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(MskbxAltura.Text, out double peso))
                MessageBox.Show("Altura inválida!");
        }

        private void MskbxPeso_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(MskbxPeso.Text, out double peso))
                MessageBox.Show("Peso inválido!");
        }
    }
}
