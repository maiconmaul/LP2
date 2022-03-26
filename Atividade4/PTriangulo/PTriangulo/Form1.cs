using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtArestaA.Text, out double arestaA))
            {
                MessageBox.Show("Aresta A é inválida.");
                return;
            }
            if (!double.TryParse(txtArestaB.Text, out double arestaB))
            {
                MessageBox.Show("Aresta B é inválida.");
                return;
            }
            if (!double.TryParse(txtArestaC.Text, out double arestaC))
            {
                MessageBox.Show("Aresta C é inválida.");
                return;
            }

            bool condicaoA = (Math.Abs(arestaB - arestaC) < arestaA && arestaA < arestaB + arestaC);
            bool condicaoB = (Math.Abs(arestaA - arestaC) < arestaB && arestaB < arestaA + arestaC);
            bool condicaoC = (Math.Abs(arestaA - arestaB) < arestaC && arestaC < arestaA + arestaB);
            if (condicaoA && condicaoB && condicaoC)
            {
                lblResultado.ForeColor = Color.Green;
                if (arestaA == arestaB && arestaA == arestaC)
                    lblResultado.Text = "Triangulo equilatero";
                else if (arestaA != arestaB && arestaA != arestaC && arestaB != arestaC)
                    lblResultado.Text = "Triângulo escaleno";
                else
                    lblResultado.Text = "Triângulo isóceles";
            }
            else
            {
                lblResultado.Text = "Triângulo inválido";
                lblResultado.ForeColor = Color.Red;
                MessageBox.Show("Os dados inseridos não condiz com a existência de um triângulo");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtArestaA_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtArestaA.Text, out double arestaA))
                MessageBox.Show("Aresta A é inválida.");

        }

        private void txtArestaB_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtArestaB.Text, out double arestaB))
                MessageBox.Show("Aresta B é inválida.");
        }

        private void txtArestaC_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtArestaC.Text, out double arestaC))
                MessageBox.Show("Aresta C é inválida.");
        }
    }
}
