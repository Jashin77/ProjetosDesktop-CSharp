
using System.Data;

namespace Calculadora_CSharp
{
    public partial class Form1 : Form
    {
        double resultado;
        public Form1()
        {
            InitializeComponent();
        }
        static double CalcularExpressao(string expressao)
        {
            try
            {
                DataTable table = new DataTable();
                DataColumn column = new DataColumn("expressao", typeof(double), expressao);
                table.Columns.Add(column);
                DataRow row = table.NewRow();
                table.Rows.Add(row);

                return (double)row["expressao"];
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao calcular expressão: {ex.Message}");
                return 0;
            }
        }

        private void btn_Igual_Click(object sender, EventArgs e)
        {
            resultado = CalcularExpressao(textBox1.Text);
            textBox1.Text = resultado.ToString();
        }

        private void btn_um_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btn_dois_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btn_tres_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn_quatro_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btn_cinco_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btn_seis_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn_sete_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btn_oito_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn_nove_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void btn_ponto_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void btn_Mais_Click(object sender, EventArgs e)
        {
            textBox1.Text += " + ";
        }

        private void btn_menos_Click(object sender, EventArgs e)
        {
            textBox1.Text += " - ";
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            textBox1.Text += " * ";
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            textBox1.Text += " / ";
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}