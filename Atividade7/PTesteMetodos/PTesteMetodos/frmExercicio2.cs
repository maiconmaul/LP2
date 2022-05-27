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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            if(string.Compare(txtPalavra1.Text,txtPalavra2.Text, true) == 0)
            {
                MessageBox.Show("Sao iguais!");
            }
            else
                MessageBox.Show("Sao diferentes!");
        }

        private void btnInserir1_Click(object sender, EventArgs e)
        {
            int half = txtPalavra2.Text.Length / 2;

            txtPalavra2.Text = txtPalavra2.Text.Substring(0, half) + txtPalavra1.Text + txtPalavra2.Text.Substring(half, txtPalavra2.Text.Length - half);
        }

        private void btnInserir2_Click(object sender, EventArgs e)
        {
            int half = txtPalavra1.Text.Length / 2;
            txtPalavra2.Text = txtPalavra1.Text.Insert(half, "**");

        }
    }
}
