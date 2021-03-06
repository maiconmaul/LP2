using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio1"];

            if (fc != null)
                fc.Close();

            frmExercicio1 objform = new frmExercicio1();
            objform.MdiParent = this;
            objform.WindowState = FormWindowState.Maximized;
            objform.ControlBox = false;
            objform.Show();
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio2"];

            if (fc != null)
                fc.Close();

            frmExercicio2 objform = new frmExercicio2();
            objform.MdiParent = this;
            objform.WindowState = FormWindowState.Maximized;
            objform.ControlBox = false;
            objform.Show();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio3"];

            if (fc != null)
                fc.Close();

            frmExercicio3 objform = new frmExercicio3();
            objform.MdiParent = this;
            objform.WindowState = FormWindowState.Maximized;
            objform.ControlBox = false;
            objform.Show();
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio4"];

            if (fc != null)
                fc.Close();

            frmExercicio4 objform = new frmExercicio4();
            objform.MdiParent = this;
            objform.ControlBox = false;
            objform.WindowState = FormWindowState.Maximized;
            objform.Show();
        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio5"];

            if (fc != null)
                fc.Close();

            frmExercicio5 objform = new frmExercicio5();
            objform.MdiParent = this;
            objform.WindowState = FormWindowState.Maximized;
            objform.ControlBox = false;
            objform.Show();
        }

        private void exercicio3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Exercicio_3"];

            if (fc != null)
                fc.Close();

            Exercicio_3 objform = new Exercicio_3();
            objform.MdiParent = this;
            objform.WindowState = FormWindowState.Maximized;
            objform.ControlBox = false;
            objform.Show();
        }
    }
}
