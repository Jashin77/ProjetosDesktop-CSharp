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
                int length = 10;
                string palavraAleatoria = GerarPalavraAleatoria(length);
                tb_senha.Text = palavraAleatoria;
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
    }
}