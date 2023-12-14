namespace EX5WF
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConverter = new System.Windows.Forms.Button();
            this.txtCotacao = new System.Windows.Forms.TextBox();
            this.txtReais = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(323, 321);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 23);
            this.btnConverter.TabIndex = 0;
            this.btnConverter.Text = "Conversor";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // txtCotacao
            // 
            this.txtCotacao.Location = new System.Drawing.Point(298, 143);
            this.txtCotacao.Name = "txtCotacao";
            this.txtCotacao.Size = new System.Drawing.Size(122, 20);
            this.txtCotacao.TabIndex = 1;
            // 
            // txtReais
            // 
            this.txtReais.Location = new System.Drawing.Point(298, 254);
            this.txtReais.Name = "txtReais";
            this.txtReais.Size = new System.Drawing.Size(122, 20);
            this.txtReais.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(305, 127);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(93, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Cotação do Dolar:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(295, 238);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(125, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "quanto deseja converter:";
            // 
            // txtR
            // 
            this.txtR.Enabled = false;
            this.txtR.Location = new System.Drawing.Point(298, 382);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(122, 20);
            this.txtR.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtReais);
            this.Controls.Add(this.txtCotacao);
            this.Controls.Add(this.btnConverter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.TextBox txtCotacao;
        private System.Windows.Forms.TextBox txtReais;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtR;
    }
}

