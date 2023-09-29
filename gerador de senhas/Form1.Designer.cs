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
            tb_senha = new TextBox();
            btn_gararSenha = new Button();
            btn_limpar = new Button();
            label1 = new Label();
            cb_oculto = new CheckBox();
            SuspendLayout();
            // 
            // tb_senha
            // 
            tb_senha.Location = new Point(12, 53);
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
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 3;
            label1.Text = "Senha:";
            // 
            // cb_oculto
            // 
            cb_oculto.AutoSize = true;
            cb_oculto.Location = new Point(332, 55);
            cb_oculto.Name = "cb_oculto";
            cb_oculto.Size = new Size(77, 24);
            cb_oculto.TabIndex = 4;
            cb_oculto.Text = "ocultar";
            cb_oculto.UseVisualStyleBackColor = true;
            cb_oculto.CheckedChanged += cb_oculto_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 349);
            Controls.Add(cb_oculto);
            Controls.Add(label1);
            Controls.Add(btn_limpar);
            Controls.Add(btn_gararSenha);
            Controls.Add(tb_senha);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_senha;
        private Button btn_gararSenha;
        private Button btn_limpar;
        private Label label1;
        private CheckBox cb_oculto;
    }
}