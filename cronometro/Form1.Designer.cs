namespace cronometro
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btn_iniciar = new Button();
            btn_pausar = new Button();
            btn_zerar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._71397;
            pictureBox1.Location = new Point(72, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 255);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(139, 164);
            label1.Name = "label1";
            label1.Size = new Size(142, 46);
            label1.TabIndex = 1;
            label1.Text = "00:00:00";
            // 
            // btn_iniciar
            // 
            btn_iniciar.Location = new Point(60, 337);
            btn_iniciar.Name = "btn_iniciar";
            btn_iniciar.Size = new Size(94, 29);
            btn_iniciar.TabIndex = 2;
            btn_iniciar.Text = "Iniciar";
            btn_iniciar.UseVisualStyleBackColor = true;
            btn_iniciar.Click += btn_iniciar_Click;
            // 
            // btn_pausar
            // 
            btn_pausar.Location = new Point(160, 337);
            btn_pausar.Name = "btn_pausar";
            btn_pausar.Size = new Size(94, 29);
            btn_pausar.TabIndex = 3;
            btn_pausar.Text = "Pausar";
            btn_pausar.UseVisualStyleBackColor = true;
            btn_pausar.Click += btn_pausar_Click;
            // 
            // btn_zerar
            // 
            btn_zerar.Location = new Point(260, 337);
            btn_zerar.Name = "btn_zerar";
            btn_zerar.Size = new Size(94, 29);
            btn_zerar.TabIndex = 4;
            btn_zerar.Text = "Zerar";
            btn_zerar.UseVisualStyleBackColor = true;
            btn_zerar.Click += btn_zerar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 448);
            Controls.Add(btn_zerar);
            Controls.Add(btn_pausar);
            Controls.Add(btn_iniciar);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Cronometro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_iniciar;
        private Button btn_pausar;
        private Button btn_zerar;
    }
}