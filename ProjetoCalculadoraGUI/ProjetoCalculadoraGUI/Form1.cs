namespace ProjetoCalculadoraGUI
{
    public partial class CalculadoraView : Form
    {
        public CalculadoraView()
        {
            InitializeComponent();
        }

        private void CalculadoraView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeroX = 0;
            int numeroY = 0; try
            {
                numeroX = int.Parse(txtNumeroX.Text);
            }
            catch (Exception e3)
            {
                MessageBox.Show("Erro");
                return;
            }
            try
            {
                numeroY = int.Parse(txtNumeroY.Text);
            }
            catch (Exception e3)
            {

                MessageBox.Show("Erro");
                return;
            }
            txtResultado.Text = "" + (numeroX + numeroY);

            {

            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int numeroX = 0;
            int numeroY = 0; try
            {
                numeroX = int.Parse(txtNumeroX.Text);
            }
            catch (Exception e3)
            {
                MessageBox.Show("Erro");
                return;
            }
            try
            {
                numeroY = int.Parse(txtNumeroY.Text);
            }
            catch (Exception e3)
            {

                MessageBox.Show("Erro");
                return;
            }
            txtResultado.Text = "" + (numeroX - numeroY);

            {

            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int numeroX = 0;
            int numeroY = 0; try
            {
                numeroX = int.Parse(txtNumeroX.Text);
            }
            catch (Exception e3)
            {
                MessageBox.Show("Erro");
                return;
            }
            try
            {
                numeroY = int.Parse(txtNumeroY.Text);
            }
            catch (Exception e3)
            {

                MessageBox.Show("Erro");
                return;
            }
            txtResultado.Text = "" + (numeroX * numeroY);

            {

            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int numeroX = 0;
            int numeroY = 0; try
            {
                numeroX = int.Parse(txtNumeroX.Text);
            }
            catch (Exception e3)
            {
                MessageBox.Show("Erro");
                return;
            }
            try
            {
                numeroY = int.Parse(txtNumeroY.Text);
            }
            catch (Exception e3)
            {

                MessageBox.Show("Erro");
                return;
            }
            txtResultado.Text = "" + (numeroX / numeroY);

            {

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar todos os campos de entrada e o resultado.
            txtNumeroX.Text = string.Empty;
            txtNumeroY.Text = string.Empty;
            txtResultado.Text = string.Empty;

            // Opcional: Colocar o foco no primeiro campo.
            txtNumeroX.Focus();
        }
    }
}
