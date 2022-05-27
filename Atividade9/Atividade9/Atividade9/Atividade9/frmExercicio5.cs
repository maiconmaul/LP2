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
using System.Collections;

namespace Atividade9
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            string[] arrayNames = new string[1];
            int[] qtdLetter = new int[1];
          

            name = Interaction.InputBox("INFORME UM NOME", "CONTADOR DE LETRAS EM UM NOME");
            for (int i = 0; i < arrayNames.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Informe uma letra valida");
                    i -= 1;
                }
                else
                {
                    qtdLetter[i] = name.Replace(" ", "").Length;
                    arrayNames[i] = name;
                }
            }
            lstbxContWordNames.Items.Add("O nome: " + arrayNames[0].ToString() + " tem " + qtdLetter[0].ToString() + " caracteres");
            
        }
    }
    }
