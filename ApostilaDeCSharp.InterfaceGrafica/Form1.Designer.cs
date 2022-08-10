namespace ApostilaDeCSharp.InterfaceGrafica
{
    partial class Drive1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVoar = new System.Windows.Forms.Button();
            this.btnNadar = new System.Windows.Forms.Button();
            this.btnPular = new System.Windows.Forms.Button();
            this.btnCorrer = new System.Windows.Forms.Button();
            this.btnVirarAEsquerda = new System.Windows.Forms.Button();
            this.btnVirarADireita = new System.Windows.Forms.Button();
            this.btnAndar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtPontos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVoar
            // 
            this.btnVoar.Location = new System.Drawing.Point(52, 97);
            this.btnVoar.Name = "btnVoar";
            this.btnVoar.Size = new System.Drawing.Size(75, 23);
            this.btnVoar.TabIndex = 0;
            this.btnVoar.Text = "Voar";
            this.btnVoar.UseVisualStyleBackColor = true;
            this.btnVoar.Click += new System.EventHandler(this.btnVoar_Click);
            // 
            // btnNadar
            // 
            this.btnNadar.Location = new System.Drawing.Point(133, 97);
            this.btnNadar.Name = "btnNadar";
            this.btnNadar.Size = new System.Drawing.Size(75, 23);
            this.btnNadar.TabIndex = 1;
            this.btnNadar.Text = "Nadar";
            this.btnNadar.UseVisualStyleBackColor = true;
            this.btnNadar.Click += new System.EventHandler(this.btnNadar_Click);
            // 
            // btnPular
            // 
            this.btnPular.Location = new System.Drawing.Point(52, 126);
            this.btnPular.Name = "btnPular";
            this.btnPular.Size = new System.Drawing.Size(75, 23);
            this.btnPular.TabIndex = 2;
            this.btnPular.Text = "Pular";
            this.btnPular.UseVisualStyleBackColor = true;
            this.btnPular.Click += new System.EventHandler(this.btnPular_Click);
            // 
            // btnCorrer
            // 
            this.btnCorrer.Location = new System.Drawing.Point(133, 126);
            this.btnCorrer.Name = "btnCorrer";
            this.btnCorrer.Size = new System.Drawing.Size(75, 23);
            this.btnCorrer.TabIndex = 3;
            this.btnCorrer.Text = "Correr";
            this.btnCorrer.UseVisualStyleBackColor = true;
            this.btnCorrer.Click += new System.EventHandler(this.btnCorrer_Click);
            // 
            // btnVirarAEsquerda
            // 
            this.btnVirarAEsquerda.Location = new System.Drawing.Point(333, 126);
            this.btnVirarAEsquerda.Name = "btnVirarAEsquerda";
            this.btnVirarAEsquerda.Size = new System.Drawing.Size(118, 23);
            this.btnVirarAEsquerda.TabIndex = 4;
            this.btnVirarAEsquerda.Text = "Virar a Esquerda";
            this.btnVirarAEsquerda.UseVisualStyleBackColor = true;
            this.btnVirarAEsquerda.Click += new System.EventHandler(this.btnVirarAEsquerda_Click);
            // 
            // btnVirarADireita
            // 
            this.btnVirarADireita.Location = new System.Drawing.Point(214, 126);
            this.btnVirarADireita.Name = "btnVirarADireita";
            this.btnVirarADireita.Size = new System.Drawing.Size(113, 23);
            this.btnVirarADireita.TabIndex = 5;
            this.btnVirarADireita.Text = "Virar a Direita";
            this.btnVirarADireita.UseVisualStyleBackColor = true;
            this.btnVirarADireita.Click += new System.EventHandler(this.btnVirarADireita_Click);
            // 
            // btnAndar
            // 
            this.btnAndar.Location = new System.Drawing.Point(214, 97);
            this.btnAndar.Name = "btnAndar";
            this.btnAndar.Size = new System.Drawing.Size(75, 23);
            this.btnAndar.TabIndex = 6;
            this.btnAndar.Text = "Andar";
            this.btnAndar.UseVisualStyleBackColor = true;
            this.btnAndar.Click += new System.EventHandler(this.btnAndar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(295, 97);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 23);
            this.btnParar.TabIndex = 7;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(376, 97);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtPontos
            // 
            this.txtPontos.Location = new System.Drawing.Point(178, 29);
            this.txtPontos.Name = "txtPontos";
            this.txtPontos.Size = new System.Drawing.Size(148, 20);
            this.txtPontos.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total de Pontos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome do Personagem";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(178, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(148, 20);
            this.txtNome.TabIndex = 13;
            // 
            // Drive1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 236);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPontos);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnAndar);
            this.Controls.Add(this.btnVirarADireita);
            this.Controls.Add(this.btnVirarAEsquerda);
            this.Controls.Add(this.btnCorrer);
            this.Controls.Add(this.btnPular);
            this.Controls.Add(this.btnNadar);
            this.Controls.Add(this.btnVoar);
            this.Name = "Drive1";
            this.Text = "Drive 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoar;
        private System.Windows.Forms.Button btnNadar;
        private System.Windows.Forms.Button btnPular;
        private System.Windows.Forms.Button btnCorrer;
        private System.Windows.Forms.Button btnVirarAEsquerda;
        private System.Windows.Forms.Button btnVirarADireita;
        private System.Windows.Forms.Button btnAndar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtPontos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
    }
}

