namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            imprimirToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            colarToolStripMenuItem = new ToolStripMenuItem();
            fonteToolStripMenuItem = new ToolStripMenuItem();
            negritoToolStripMenuItem = new ToolStripMenuItem();
            itálicoToolStripMenuItem = new ToolStripMenuItem();
            sublinhadoToolStripMenuItem = new ToolStripMenuItem();
            alinhamentoToolStripMenuItem = new ToolStripMenuItem();
            centralizarToolStripMenuItem = new ToolStripMenuItem();
            esquerdaToolStripMenuItem = new ToolStripMenuItem();
            direitaToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btn_Novo = new ToolStripButton();
            btn_Abrir = new ToolStripButton();
            btn_salvar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btn_copiar = new ToolStripButton();
            btn_colar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btn_Negrito = new ToolStripButton();
            btn_itálico = new ToolStripButton();
            btn_sublinhado = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btn_esquerda = new ToolStripButton();
            btn_meio = new ToolStripButton();
            btn_direita = new ToolStripButton();
            fontDialog1 = new FontDialog();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 58);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(782, 461);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, editarToolStripMenuItem, fonteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(782, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, salvarToolStripMenuItem, imprimirToolStripMenuItem, toolStripMenuItem1, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(75, 24);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(224, 26);
            newToolStripMenuItem.Text = "Novo";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(224, 26);
            openToolStripMenuItem.Text = "Abrir";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // salvarToolStripMenuItem
            // 
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.Size = new Size(224, 26);
            salvarToolStripMenuItem.Text = "Salvar";
            salvarToolStripMenuItem.Click += salvarToolStripMenuItem_Click;
            // 
            // imprimirToolStripMenuItem
            // 
            imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            imprimirToolStripMenuItem.Size = new Size(224, 26);
            imprimirToolStripMenuItem.Text = "Imprimir";
            imprimirToolStripMenuItem.Click += imprimirToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(221, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(224, 26);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copiarToolStripMenuItem, colarToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(62, 24);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.Size = new Size(136, 26);
            copiarToolStripMenuItem.Text = "Copiar";
            copiarToolStripMenuItem.Click += copiarToolStripMenuItem_Click;
            // 
            // colarToolStripMenuItem
            // 
            colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            colarToolStripMenuItem.Size = new Size(136, 26);
            colarToolStripMenuItem.Text = "Colar";
            colarToolStripMenuItem.Click += colarToolStripMenuItem_Click;
            // 
            // fonteToolStripMenuItem
            // 
            fonteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { negritoToolStripMenuItem, itálicoToolStripMenuItem, sublinhadoToolStripMenuItem, alinhamentoToolStripMenuItem });
            fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            fonteToolStripMenuItem.Size = new Size(60, 24);
            fonteToolStripMenuItem.Text = "Fonte";
            // 
            // negritoToolStripMenuItem
            // 
            negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            negritoToolStripMenuItem.Size = new Size(177, 26);
            negritoToolStripMenuItem.Text = "Negrito";
            negritoToolStripMenuItem.Click += negritoToolStripMenuItem_Click;
            // 
            // itálicoToolStripMenuItem
            // 
            itálicoToolStripMenuItem.Name = "itálicoToolStripMenuItem";
            itálicoToolStripMenuItem.Size = new Size(177, 26);
            itálicoToolStripMenuItem.Text = "Itálico";
            itálicoToolStripMenuItem.Click += itálicoToolStripMenuItem_Click;
            // 
            // sublinhadoToolStripMenuItem
            // 
            sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            sublinhadoToolStripMenuItem.Size = new Size(177, 26);
            sublinhadoToolStripMenuItem.Text = "Sublinhado";
            sublinhadoToolStripMenuItem.Click += sublinhadoToolStripMenuItem_Click;
            // 
            // alinhamentoToolStripMenuItem
            // 
            alinhamentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { centralizarToolStripMenuItem, esquerdaToolStripMenuItem, direitaToolStripMenuItem });
            alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            alinhamentoToolStripMenuItem.Size = new Size(177, 26);
            alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // centralizarToolStripMenuItem
            // 
            centralizarToolStripMenuItem.Name = "centralizarToolStripMenuItem";
            centralizarToolStripMenuItem.Size = new Size(163, 26);
            centralizarToolStripMenuItem.Text = "Centralizar";
            centralizarToolStripMenuItem.Click += centralizarToolStripMenuItem_Click;
            // 
            // esquerdaToolStripMenuItem
            // 
            esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            esquerdaToolStripMenuItem.Size = new Size(163, 26);
            esquerdaToolStripMenuItem.Text = "Esquerda";
            esquerdaToolStripMenuItem.Click += esquerdaToolStripMenuItem_Click;
            // 
            // direitaToolStripMenuItem
            // 
            direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            direitaToolStripMenuItem.Size = new Size(163, 26);
            direitaToolStripMenuItem.Text = "Direita";
            direitaToolStripMenuItem.Click += direitaToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_Novo, btn_Abrir, btn_salvar, toolStripSeparator1, btn_copiar, btn_colar, toolStripSeparator2, btn_Negrito, btn_itálico, btn_sublinhado, toolStripSeparator3, btn_esquerda, btn_meio, btn_direita });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(782, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_Novo
            // 
            btn_Novo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_Novo.Image = (Image)resources.GetObject("btn_Novo.Image");
            btn_Novo.ImageTransparentColor = Color.Magenta;
            btn_Novo.Name = "btn_Novo";
            btn_Novo.Size = new Size(29, 24);
            btn_Novo.Text = "Novo";
            btn_Novo.Click += btn_Novo_Click;
            // 
            // btn_Abrir
            // 
            btn_Abrir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_Abrir.Image = (Image)resources.GetObject("btn_Abrir.Image");
            btn_Abrir.ImageTransparentColor = Color.Magenta;
            btn_Abrir.Name = "btn_Abrir";
            btn_Abrir.Size = new Size(29, 24);
            btn_Abrir.Text = "Abrir";
            btn_Abrir.Click += btn_Abrir_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_salvar.Image = (Image)resources.GetObject("btn_salvar.Image");
            btn_salvar.ImageTransparentColor = Color.Magenta;
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(29, 24);
            btn_salvar.Text = "Salvar";
            btn_salvar.Click += btn_salvar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btn_copiar
            // 
            btn_copiar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_copiar.Image = (Image)resources.GetObject("btn_copiar.Image");
            btn_copiar.ImageTransparentColor = Color.Magenta;
            btn_copiar.Name = "btn_copiar";
            btn_copiar.Size = new Size(29, 24);
            btn_copiar.Text = "Copiar";
            btn_copiar.Click += btn_copiar_Click;
            // 
            // btn_colar
            // 
            btn_colar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_colar.Image = (Image)resources.GetObject("btn_colar.Image");
            btn_colar.ImageTransparentColor = Color.Magenta;
            btn_colar.Name = "btn_colar";
            btn_colar.Size = new Size(29, 24);
            btn_colar.Text = "Colar";
            btn_colar.Click += btn_colar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // btn_Negrito
            // 
            btn_Negrito.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_Negrito.Image = (Image)resources.GetObject("btn_Negrito.Image");
            btn_Negrito.ImageTransparentColor = Color.Magenta;
            btn_Negrito.Name = "btn_Negrito";
            btn_Negrito.Size = new Size(29, 24);
            btn_Negrito.Text = "Negrito";
            btn_Negrito.Click += btn_Negrito_Click;
            // 
            // btn_itálico
            // 
            btn_itálico.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_itálico.Image = (Image)resources.GetObject("btn_itálico.Image");
            btn_itálico.ImageTransparentColor = Color.Magenta;
            btn_itálico.Name = "btn_itálico";
            btn_itálico.Size = new Size(29, 24);
            btn_itálico.Text = "itálico";
            btn_itálico.Click += btn_itálico_Click;
            // 
            // btn_sublinhado
            // 
            btn_sublinhado.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_sublinhado.Image = (Image)resources.GetObject("btn_sublinhado.Image");
            btn_sublinhado.ImageTransparentColor = Color.Magenta;
            btn_sublinhado.Name = "btn_sublinhado";
            btn_sublinhado.Size = new Size(29, 24);
            btn_sublinhado.Text = "sublinhado";
            btn_sublinhado.Click += btn_sublinhado_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // btn_esquerda
            // 
            btn_esquerda.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_esquerda.Image = (Image)resources.GetObject("btn_esquerda.Image");
            btn_esquerda.ImageTransparentColor = Color.Magenta;
            btn_esquerda.Name = "btn_esquerda";
            btn_esquerda.Size = new Size(29, 24);
            btn_esquerda.Text = "esquerda";
            btn_esquerda.Click += btn_esquerda_Click;
            // 
            // btn_meio
            // 
            btn_meio.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_meio.Image = (Image)resources.GetObject("btn_meio.Image");
            btn_meio.ImageTransparentColor = Color.Magenta;
            btn_meio.Name = "btn_meio";
            btn_meio.Size = new Size(29, 24);
            btn_meio.Text = "meio";
            btn_meio.Click += btn_meio_Click;
            // 
            // btn_direita
            // 
            btn_direita.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_direita.Image = (Image)resources.GetObject("btn_direita.Image");
            btn_direita.ImageTransparentColor = Color.Magenta;
            btn_direita.Name = "btn_direita";
            btn_direita.Size = new Size(29, 24);
            btn_direita.Text = "direita";
            btn_direita.Click += btn_direita_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(toolStrip1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor de Texto";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem colarToolStripMenuItem;
        private ToolStripMenuItem fonteToolStripMenuItem;
        private ToolStripMenuItem negritoToolStripMenuItem;
        private ToolStripMenuItem itálicoToolStripMenuItem;
        private ToolStripMenuItem sublinhadoToolStripMenuItem;
        private ToolStripMenuItem alinhamentoToolStripMenuItem;
        private ToolStripMenuItem centralizarToolStripMenuItem;
        private ToolStripMenuItem esquerdaToolStripMenuItem;
        private ToolStripMenuItem direitaToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btn_Novo;
        private ToolStripButton btn_Abrir;
        private ToolStripButton btn_salvar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btn_copiar;
        private ToolStripButton btn_colar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btn_Negrito;
        private ToolStripButton btn_itálico;
        private ToolStripButton btn_sublinhado;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btn_esquerda;
        private ToolStripButton btn_meio;
        private ToolStripButton btn_direita;
        private FontDialog fontDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}