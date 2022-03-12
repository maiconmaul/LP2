namespace PVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtRaio_Validated(object sender, EventArgs e)
        {
            double raio;
            if (!Double.TryParse(txtRaio.Text, out raio))
                MessageBox.Show("Raio inválido");
            else if (raio <= 0)
                MessageBox.Show("O raio deve ser maior que 0");
        }

        private void txtAltura_Validated(object sender, EventArgs e)
        {
            double altura;
            if (!Double.TryParse(txtRaio.Text, out altura))
                MessageBox.Show("altura inválida");
            else if (altura <= 0)
                MessageBox.Show("A altura deve ser maior que 0");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (!Double.TryParse(txtRaio.Text, out double raio) || raio <= 0)
            {
                MessageBox.Show("Raio inválido. O raio deve ser maior que 0");
                txtRaio.Focus();
            }
            else if (!Double.TryParse(txtAltura.Text, out double altura) || altura <= 0)
            {
                MessageBox.Show("altura inválida. A altura deve ser maior que 0");
                txtAltura.Focus();
            }
            else
            {
                double volume = Math.PI * (raio * raio) * altura;
                txtVolume.Text = volume.ToString("N2");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}