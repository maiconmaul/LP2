namespace PCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Validacao camposValidos()
        {
            if (!Double.TryParse(txtNumeroA.Text, out double numA))
            {
                MessageBox.Show("Campo numero 1 inválido");
                txtNumeroA.Focus();
                return new(false);
            }
            if (!Double.TryParse(txtNumeroB.Text, out double numB))
            {
                MessageBox.Show("Campo numero 2 inválido");
                txtNumeroB.Focus();
                return new(false);
            }

            return new(true, numA, numB);
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            var validacao = camposValidos();
            if (validacao.valido)
            {
                var numeroA = validacao.numeroA;
                var numeroB = validacao.numeroB;
                var resultado = numeroA + numeroB;
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            var validacao = camposValidos();
            if (validacao.valido)
            {
                var numeroA = validacao.numeroA;
                var numeroB = validacao.numeroB;
                var resultado = numeroA - numeroB;
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            var validacao = camposValidos();
            if (validacao.valido)
            {
                var numeroA = validacao.numeroA;
                var numeroB = validacao.numeroB;
                var resultado = numeroA * numeroB;
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            var validacao = camposValidos();
            if (validacao.numeroA == 0)
            {
                MessageBox.Show("Divisao não pode-se utilizar número 0");
                txtNumeroA.Focus();
            }
            else if (validacao.numeroB == 0)
            {
                MessageBox.Show("Divisao não pode-se utilizar número 0");
                txtNumeroB.Focus();
            }
            else if (validacao.valido)
            {
                var numeroA = validacao.numeroA;
                var numeroB = validacao.numeroB;
                var resultado = numeroA / numeroB;
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumeroA.Clear();
            txtNumeroB.Clear();
            txtResultado.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNumeroA_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNumeroA.Text, out double numA))
            {
                MessageBox.Show("Campo numero 1 inválido");
            }
        }

        private void txtNumeroB_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNumeroB.Text, out double numB))
            {
                MessageBox.Show("Campo numero 2 inválido");
            }
        }
    }
}

public class Validacao
{
    public bool valido { get; set; } = false;
    public double numeroA { get; set; } = 0;
    public double numeroB { get; set; } = 0;

    public Validacao(bool valido, double numeroA = 0, double numeroB = 0)
    {
        this.valido = valido;
        this.numeroA = numeroA;
        this.numeroB = numeroB;
    }
}