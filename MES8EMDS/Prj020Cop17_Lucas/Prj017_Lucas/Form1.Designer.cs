namespace Prj017_Lucas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNum = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVerificar2 = new System.Windows.Forms.Button();
            this.btnVerificar3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(271, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite Um Numero";
            // 
            // txtBoxNum
            // 
            this.txtBoxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtBoxNum.Location = new System.Drawing.Point(441, 51);
            this.txtBoxNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNum.Name = "txtBoxNum";
            this.txtBoxNum.Size = new System.Drawing.Size(89, 26);
            this.txtBoxNum.TabIndex = 1;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnVerificar.Location = new System.Drawing.Point(724, 46);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(100, 30);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar I";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResposta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox1.Location = new System.Drawing.Point(249, 130);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(395, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado da Análise";
            // 
            // lblResposta
            // 
            this.lblResposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblResposta.Location = new System.Drawing.Point(37, 43);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(303, 38);
            this.lblResposta.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(295, 313);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(122, 56);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(630, 313);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(122, 56);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnVerificar2
            // 
            this.btnVerificar2.Location = new System.Drawing.Point(724, 83);
            this.btnVerificar2.Name = "btnVerificar2";
            this.btnVerificar2.Size = new System.Drawing.Size(100, 25);
            this.btnVerificar2.TabIndex = 6;
            this.btnVerificar2.Text = "Verificar II";
            this.btnVerificar2.UseVisualStyleBackColor = true;
            this.btnVerificar2.Click += new System.EventHandler(this.BtnVerificar2_Click);
            // 
            // btnVerificar3
            // 
            this.btnVerificar3.Location = new System.Drawing.Point(724, 114);
            this.btnVerificar3.Name = "btnVerificar3";
            this.btnVerificar3.Size = new System.Drawing.Size(100, 26);
            this.btnVerificar3.TabIndex = 7;
            this.btnVerificar3.Text = "Verificar III";
            this.btnVerificar3.UseVisualStyleBackColor = true;
            this.btnVerificar3.Click += new System.EventHandler(this.BtnVerificar3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1018, 547);
            this.Controls.Add(this.btnVerificar3);
            this.Controls.Add(this.btnVerificar2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtBoxNum);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Procurando Numeros primos";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNum;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVerificar2;
        private System.Windows.Forms.Button btnVerificar3;
    }
}

