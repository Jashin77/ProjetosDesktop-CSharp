using System;

namespace cronometro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int segundos = 0;
        private int milissegundos = 0;
        private bool emExecucao = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            milissegundos += 100;
            if (milissegundos >= 1000)
            {
                milissegundos = 0;
                segundos++;
            }
            AtualizarTempoDecorrido();
        }

        private void AtualizarTempoDecorrido()
        {
            TimeSpan tempoDecorrido = new TimeSpan(0, 0, segundos);
            label1.Text = tempoDecorrido.ToString(@"hh\:mm\:ss");
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            emExecucao = true;
            timer1.Start();
        }

        private void btn_pausar_Click(object sender, EventArgs e)
        {
            emExecucao = false;
            timer1.Stop();
        }

        private void btn_zerar_Click(object sender, EventArgs e)
        {
            segundos = 0;
            milissegundos = 0;
            AtualizarTempoDecorrido();
            emExecucao = false;
            timer1.Stop();
        }
    }
}



