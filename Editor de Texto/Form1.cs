namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        StringReader leitura = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Novo()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }
        private void Salvar()
        {
            try
            {
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter streamWriter = new StreamWriter(arquivo);
                    streamWriter.Flush();
                    streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    streamWriter.Write(this.richTextBox1.Text);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO NA CRIAÇÂO DO ARQUIVO: " + ex.Message, "Erro ao gravar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Abrir()
        {
            this.openFileDialog1.Title = "Abrir Arquivo";
            openFileDialog1.InitialDirectory = @"D:\\Área de Trabalho\\repositorio\\ProjetosDesktop-CSharp\\Editor de Texto";

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream arquivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader streamReader = new StreamReader(arquivo);
                    streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Clear();
                    string linha = streamReader.ReadLine();
                    while (linha != null)
                    {
                        richTextBox1.Text += linha + "\n";
                        linha = streamReader.ReadLine();
                    }
                    streamReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO NA LEITURA DO ARQUIVO: " + ex.Message, "Erro ao ler o arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Copiar()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }
        private void Colar()
        {
            richTextBox1.Paste();
        }
        private void Regular()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool reg = false;

            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;
            reg = richTextBox1.Font.Bold;

            if (reg == false)
            {
                richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular);
            }
            else if (reg == true)
            {
                richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular);
            }
        }
        private void Negrito()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool n, i, s = false;

            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;
            richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular);

            if (n == false)
            {
                if (i == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (i == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (i == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold);
                }

            }
            else
            {
                if (i == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline);
                }
                else if (i == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic);
                }
            }
        }
        private void Italico()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool ita = false;

            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;
            ita = richTextBox1.Font.Italic;

            if (richTextBox1.SelectionFont != null)
            {
                bool estaEmItalico = richTextBox1.SelectionFont.Italic;

                FontStyle novoEstilo = estaEmItalico ? richTextBox1.SelectionFont.Style & ~FontStyle.Italic : richTextBox1.SelectionFont.Style | FontStyle.Italic;

                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, novoEstilo);
            }
        }
        public void Sublinhado()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool sub = false;

            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;
            sub = richTextBox1.Font.Underline;

            if (richTextBox1.SelectionFont != null)
            {
                bool estaSublinhado = richTextBox1.SelectionFont.Underline;

                FontStyle novoEstilo = estaSublinhado ? richTextBox1.SelectionFont.Style & ~FontStyle.Underline : richTextBox1.SelectionFont.Style | FontStyle.Underline;

                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, novoEstilo);
            }

        }
        private void AlinharEsquerda()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void AlinharDireita()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void Centralizar()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void Imprimir()
        {
            printDialog1.Document = printDocument1;
            string texto = this.richTextBox1.Text;
            leitura = new StringReader(texto);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void btn_copiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void btn_colar_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void btn_Negrito_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void btn_itálico_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void btn_sublinhado_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void btn_esquerda_Click(object sender, EventArgs e)
        {
            AlinharEsquerda();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharEsquerda();
        }

        private void btn_meio_Click(object sender, EventArgs e)
        {
            Centralizar();
        }

        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Centralizar();
        }

        private void btn_direita_Click(object sender, EventArgs e)
        {
            AlinharDireita();
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharDireita();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhasPage = 0;
            float PosY = 0;
            int cont = 0;
            float margemEsquerda = e.MarginBounds.Left - 50;
            float margemSuperior = e.MarginBounds.Top - 50;
            if (margemEsquerda < 5)
            {
                margemEsquerda = 20;
            }
            if (margemSuperior < 5)
            {
                margemSuperior = 20;
            }
            string linha = null;
            Font fonte = this.richTextBox1.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);
            linhasPage = e.MarginBounds.Height / fonte.GetHeight(e.Graphics);
            linha = leitura.ReadLine();
            while (cont < linhasPage)
            {
                PosY = (margemSuperior + (cont * fonte.GetHeight(e.Graphics)));
                e.Graphics.DrawString(linha, fonte, pincel, margemEsquerda, PosY, new StringFormat());
                cont += 1;
                linha = leitura.ReadLine();
            }
            if (linha != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            pincel.Dispose();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}