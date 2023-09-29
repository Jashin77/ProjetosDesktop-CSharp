namespace gerador_de_senhas
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
            tb_senha = new TextBox();
            btn_gararSenha = new Button();
            btn_limpar = new Button();
            label1 = new Label();
            cb_oculto = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            btn_copiar = new Button();
            SuspendLayout();
            // 
            // tb_senha
            // 
            tb_senha.Location = new Point(12, 36);
            tb_senha.Name = "tb_senha";
            tb_senha.Size = new Size(314, 27);
            tb_senha.TabIndex = 0;
            // 
            // btn_gararSenha
            // 
            btn_gararSenha.Location = new Point(18, 275);
            btn_gararSenha.Name = "btn_gararSenha";
            btn_gararSenha.Size = new Size(314, 27);
            btn_gararSenha.TabIndex = 1;
            btn_gararSenha.Text = "Gerar Senha";
            btn_gararSenha.UseVisualStyleBackColor = true;
            btn_gararSenha.Click += button1_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(18, 308);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(314, 29);
            btn_limpar.TabIndex = 2;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 3;
            label1.Text = "Senha:";
            // 
            // cb_oculto
            // 
            cb_oculto.AutoSize = true;
            cb_oculto.Location = new Point(432, 39);
            cb_oculto.Name = "cb_oculto";
            cb_oculto.Size = new Size(77, 24);
            cb_oculto.TabIndex = 4;
            cb_oculto.Text = "ocultar";
            cb_oculto.UseVisualStyleBackColor = true;
            cb_oculto.CheckedChanged += cb_oculto_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(24, 80);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(180, 24);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "senha de 10 caracteres";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(24, 110);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(172, 24);
            radioButton2.TabIndex = 6;
            radioButton2.Text = "senha de 8 caracteres";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(24, 140);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(172, 24);
            radioButton3.TabIndex = 7;
            radioButton3.Text = "senha de 6 caracteres";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // btn_copiar
            // 
            btn_copiar.Location = new Point(332, 36);
            btn_copiar.Name = "btn_copiar";
            btn_copiar.Size = new Size(94, 29);
            btn_copiar.TabIndex = 8;
            btn_copiar.Text = "Copiar!";
            btn_copiar.UseVisualStyleBackColor = true;
            btn_copiar.Click += btn_copiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(515, 349);
            Controls.Add(btn_copiar);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(cb_oculto);
            Controls.Add(label1);
            Controls.Add(btn_limpar);
            Controls.Add(btn_gararSenha);
            Controls.Add(tb_senha);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Gerador de Senhas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_senha;
        private Button btn_gararSenha;
        private Button btn_limpar;
        private Label label1;
        private CheckBox cb_oculto;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button btn_copiar;
    }
}