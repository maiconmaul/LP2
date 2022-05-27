using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Atividade9
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void frmExercicio3_Load(object sender, EventArgs e)
        {

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            //string[] names = new string[];
            List <string> names = new List <string> { "Ana", "André", "Deborá", "Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thaís" };



            names.Remove("Otávio");
            foreach (string especName in names)
            {
                MessageBox.Show(especName.ToString());
            }

            
        }
    }
}
