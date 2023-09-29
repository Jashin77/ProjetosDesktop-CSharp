namespace gerador_de_senhas
{
    public partial class Form1 : Form
    {
        private string valorOriginal = "";
        public Form1()
        {
            InitializeComponent();
        }
        static string GerarPalavraAleatoria(int comprimento)
        {
            Random random = new Random();
            const string caracteresPossiveis = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789*$#@.&%";

            char[] palavra = new char[comprimento];

            for (int i = 0; i < comprimento; i++)
            {
                int index = random.Next(caracteresPossiveis.Length);
                palavra[i] = caracteresPossiveis[index];
            }

            return new string(palavra);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_senha.Text == "")
            {
                if (radioButton1.Checked == true)
                {
                    int length = 10;
                    string palavraAleatoria = GerarPalavraAleatoria(length);
                    tb_senha.Text = palavraAleatoria;
                }
                else if (radioButton2.Checked == true)
                {
                    int length = 8;
                    string palavraAleatoria = GerarPalavraAleatoria(length);
                    tb_senha.Text = palavraAleatoria;
                }
                else if (radioButton3.Checked == true)
                {
                    int length = 6;
                    string palavraAleatoria = GerarPalavraAleatoria(length);
                    tb_senha.Text = palavraAleatoria;
                }

            }
            valorOriginal = tb_senha.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_senha.Clear();
        }

        private void cb_oculto_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_oculto.Checked)
            {
                valorOriginal = tb_senha.Text;
                tb_senha.Text = new string('*', tb_senha.Text.Length);
                cb_oculto.Text = "oculto";
            }
            else
            {
                tb_senha.Text = valorOriginal;
                cb_oculto.Text = "ocultar";
            }
        }

        private void btn_copiar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_senha.Text))
            {
                Clipboard.SetText(tb_senha.Text);
                MessageBox.Show("Texto copiado para a área de transferência.");
            }
            else
            {
                MessageBox.Show("O campo de texto está vazio. Nada para copiar.");
            }
        }

    }
}