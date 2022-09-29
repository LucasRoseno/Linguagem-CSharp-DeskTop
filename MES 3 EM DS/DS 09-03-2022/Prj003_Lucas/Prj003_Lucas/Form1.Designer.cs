namespace Prj003_Lucas
{
    partial class FrmExe003
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
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnExibir = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.LblResposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(284, 86);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(182, 20);
            this.TxtNome.TabIndex = 0;
            this.TxtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite seu nome:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seja bem vindo(a):";
            // 
            // BtnExibir
            // 
            this.BtnExibir.Location = new System.Drawing.Point(284, 135);
            this.BtnExibir.Name = "BtnExibir";
            this.BtnExibir.Size = new System.Drawing.Size(108, 52);
            this.BtnExibir.TabIndex = 1;
            this.BtnExibir.Text = "Exibir";
            this.BtnExibir.UseVisualStyleBackColor = true;
            this.BtnExibir.Click += new System.EventHandler(this.BtnExibir_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.Red;
            this.BtnSair.Location = new System.Drawing.Point(586, 352);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(202, 86);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "&SAIR";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.Button2_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Enabled = false;
            this.BtnLimpar.Location = new System.Drawing.Point(136, 289);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(116, 71);
            this.BtnLimpar.TabIndex = 2;
            this.BtnLimpar.Text = "&Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // LblResposta
            // 
            this.LblResposta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResposta.Location = new System.Drawing.Point(303, 215);
            this.LblResposta.Name = "LblResposta";
            this.LblResposta.Size = new System.Drawing.Size(228, 33);
            this.LblResposta.TabIndex = 7;
            this.LblResposta.Click += new System.EventHandler(this.LblResposta_Click);
            // 
            // FrmExe003
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblResposta);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnExibir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNome);
            this.MinimizeBox = false;
            this.Name = "FrmExe003";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terceiro Projeto - Caixa de texto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnExibir;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Label LblResposta;
    }
}

