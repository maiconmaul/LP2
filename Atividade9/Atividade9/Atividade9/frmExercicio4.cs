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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[20,3];
            string inputGrades;
            double average = 0;
            


            for(int y = 0; y < 20; y++)
            {
                for(int x = 0; x < 3; x++)
                {
                    inputGrades = Interaction.InputBox("informe as três notas:"+"Prova Nº"+(x+1)+ " ALUNO "+(y+1), "CALCULAR MEDIA DAS NOTAS");
                    if(inputGrades == "")
                    {
                        
                        break;
                    }
                    else if(!double.TryParse(inputGrades, out notas[y,x]) || notas[y,x] < 0 || notas[y,x] > 10)
                    {
                        MessageBox.Show("Digite um numero valido ou informe nota menor que 10 e maior que zero");
                        x -= 1;
                    }
                }
                
                average = (notas[y,0] + notas[y,1] + notas[y,2]) / 3;
                    lstbxAverageStudents.Items.Add( "\nAluno " + (y+1) + ": Média é:" + average.ToString("N2"));            
            }
        }
    }
}
