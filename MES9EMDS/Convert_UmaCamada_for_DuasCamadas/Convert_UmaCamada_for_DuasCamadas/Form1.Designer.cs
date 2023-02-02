namespace Convert_UmaCamada_for_DuasCamadas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblEstoque = new System.Windows.Forms.TextBox();
            this.LblDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RdbSaida = new System.Windows.Forms.RadioButton();
            this.RdbEntrada = new System.Windows.Forms.RadioButton();
            this.btnGravar = new System.Windows.Forms.Button();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtCodProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(222, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrada e saida de produtos e Estoque";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.LblMax);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LblEstoque);
            this.groupBox1.Controls.Add(this.LblDescricao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox1.Location = new System.Drawing.Point(120, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado de Pesquisa";
            // 
            // LblMax
            // 
            this.LblMax.Location = new System.Drawing.Point(422, 73);
            this.LblMax.Name = "LblMax";
            this.LblMax.Size = new System.Drawing.Size(66, 26);
            this.LblMax.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantidade Max:";
            // 
            // LblEstoque
            // 
            this.LblEstoque.Location = new System.Drawing.Point(188, 79);
            this.LblEstoque.Name = "LblEstoque";
            this.LblEstoque.Size = new System.Drawing.Size(66, 26);
            this.LblEstoque.TabIndex = 3;
            // 
            // LblDescricao
            // 
            this.LblDescricao.Location = new System.Drawing.Point(211, 25);
            this.LblDescricao.Name = "LblDescricao";
            this.LblDescricao.Size = new System.Drawing.Size(277, 26);
            this.LblDescricao.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quantidade Estoque:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descrição do Produto:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.RdbSaida);
            this.groupBox2.Controls.Add(this.RdbEntrada);
            this.groupBox2.Controls.Add(this.btnGravar);
            this.groupBox2.Controls.Add(this.TxtQuantidade);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox2.Location = new System.Drawing.Point(120, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 91);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movimento de Produto";
            // 
            // RdbSaida
            // 
            this.RdbSaida.AutoSize = true;
            this.RdbSaida.Location = new System.Drawing.Point(31, 52);
            this.RdbSaida.Name = "RdbSaida";
            this.RdbSaida.Size = new System.Drawing.Size(69, 24);
            this.RdbSaida.TabIndex = 10;
            this.RdbSaida.TabStop = true;
            this.RdbSaida.Text = "Saída";
            this.RdbSaida.UseVisualStyleBackColor = true;
            // 
            // RdbEntrada
            // 
            this.RdbEntrada.AutoSize = true;
            this.RdbEntrada.Location = new System.Drawing.Point(31, 26);
            this.RdbEntrada.Name = "RdbEntrada";
            this.RdbEntrada.Size = new System.Drawing.Size(85, 24);
            this.RdbEntrada.TabIndex = 9;
            this.RdbEntrada.TabStop = true;
            this.RdbEntrada.Text = "Entrada";
            this.RdbEntrada.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(424, 43);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 42);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.Location = new System.Drawing.Point(339, 25);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(66, 26);
            this.TxtQuantidade.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantidade";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.button2.Location = new System.Drawing.Point(284, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "FECHAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // TxtCodProduto
            // 
            this.TxtCodProduto.Location = new System.Drawing.Point(322, 83);
            this.TxtCodProduto.Name = "TxtCodProduto";
            this.TxtCodProduto.Size = new System.Drawing.Size(116, 20);
            this.TxtCodProduto.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label6.Location = new System.Drawing.Point(147, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Codigo do Produto:";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(478, 70);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 42);
            this.btnPesquisa.TabIndex = 11;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.BtnPesquisa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.TxtCodProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox LblMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LblEstoque;
        private System.Windows.Forms.TextBox LblDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RdbSaida;
        private System.Windows.Forms.RadioButton RdbEntrada;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtCodProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPesquisa;
    }
}

