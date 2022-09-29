namespace App001_Lucas
{
    partial class FrmApp001
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
            this.lbl_Mensagem = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.btn_Soma = new System.Windows.Forms.Button();
            this.lbl_Inserir = new System.Windows.Forms.Label();
            this.txt_Inserir1 = new System.Windows.Forms.TextBox();
            this.lbl_Inserir2 = new System.Windows.Forms.Label();
            this.txt_Inserir2 = new System.Windows.Forms.TextBox();
            this.btn_Sub = new System.Windows.Forms.Button();
            this.btn_Mult = new System.Windows.Forms.Button();
            this.btn_Div = new System.Windows.Forms.Button();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.btn_Pot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Mensagem
            // 
            this.lbl_Mensagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Mensagem.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Mensagem.Location = new System.Drawing.Point(43, 69);
            this.lbl_Mensagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Mensagem.Name = "lbl_Mensagem";
            this.lbl_Mensagem.Size = new System.Drawing.Size(398, 121);
            this.lbl_Mensagem.TabIndex = 0;
            this.lbl_Mensagem.Text = "23/02/2022\r\nSeja bem vindo ao mundo da Programação\r\n\r\nMãããããããe, EU SOU PROGRAMAD" +
    "OOOOOOOOOOOOR\r\nUUUHHHHHHHHHUUUUUUUUUUUUUUUU";
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnSair.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(499, 487);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(215, 106);
            this.BtnSair.TabIndex = 1;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btn_Soma
            // 
            this.btn_Soma.Location = new System.Drawing.Point(63, 464);
            this.btn_Soma.Name = "btn_Soma";
            this.btn_Soma.Size = new System.Drawing.Size(99, 31);
            this.btn_Soma.TabIndex = 2;
            this.btn_Soma.Text = "Somar";
            this.btn_Soma.UseVisualStyleBackColor = true;
            this.btn_Soma.Click += new System.EventHandler(this.Btn_Soma_Click);
            // 
            // lbl_Inserir
            // 
            this.lbl_Inserir.AutoSize = true;
            this.lbl_Inserir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Inserir.Location = new System.Drawing.Point(43, 252);
            this.lbl_Inserir.Name = "lbl_Inserir";
            this.lbl_Inserir.Size = new System.Drawing.Size(195, 19);
            this.lbl_Inserir.TabIndex = 3;
            this.lbl_Inserir.Text = "Insira o primeiro numero";
            // 
            // txt_Inserir1
            // 
            this.txt_Inserir1.Location = new System.Drawing.Point(49, 275);
            this.txt_Inserir1.Name = "txt_Inserir1";
            this.txt_Inserir1.Size = new System.Drawing.Size(151, 26);
            this.txt_Inserir1.TabIndex = 4;
            // 
            // lbl_Inserir2
            // 
            this.lbl_Inserir2.AutoSize = true;
            this.lbl_Inserir2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Inserir2.Location = new System.Drawing.Point(49, 319);
            this.lbl_Inserir2.Name = "lbl_Inserir2";
            this.lbl_Inserir2.Size = new System.Drawing.Size(200, 19);
            this.lbl_Inserir2.TabIndex = 5;
            this.lbl_Inserir2.Text = "Insira o segundo numero";
            // 
            // txt_Inserir2
            // 
            this.txt_Inserir2.Location = new System.Drawing.Point(49, 343);
            this.txt_Inserir2.Name = "txt_Inserir2";
            this.txt_Inserir2.Size = new System.Drawing.Size(151, 26);
            this.txt_Inserir2.TabIndex = 6;
            this.txt_Inserir2.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // btn_Sub
            // 
            this.btn_Sub.Location = new System.Drawing.Point(190, 464);
            this.btn_Sub.Name = "btn_Sub";
            this.btn_Sub.Size = new System.Drawing.Size(75, 31);
            this.btn_Sub.TabIndex = 7;
            this.btn_Sub.Text = "Subtrair";
            this.btn_Sub.UseVisualStyleBackColor = true;
            this.btn_Sub.Click += new System.EventHandler(this.Btn_Sub_Click);
            // 
            // btn_Mult
            // 
            this.btn_Mult.Location = new System.Drawing.Point(63, 501);
            this.btn_Mult.Name = "btn_Mult";
            this.btn_Mult.Size = new System.Drawing.Size(99, 31);
            this.btn_Mult.TabIndex = 8;
            this.btn_Mult.Text = "Multiplicar";
            this.btn_Mult.UseVisualStyleBackColor = true;
            this.btn_Mult.Click += new System.EventHandler(this.Btn_Mult_Click);
            // 
            // btn_Div
            // 
            this.btn_Div.Location = new System.Drawing.Point(190, 503);
            this.btn_Div.Name = "btn_Div";
            this.btn_Div.Size = new System.Drawing.Size(75, 29);
            this.btn_Div.TabIndex = 9;
            this.btn_Div.Text = "Dividir";
            this.btn_Div.UseVisualStyleBackColor = true;
            this.btn_Div.Click += new System.EventHandler(this.Btn_Div_Click);
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(49, 394);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(68, 20);
            this.lbl_Valor.TabIndex = 10;
            this.lbl_Valor.Text = "O valor é:";
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(145, 394);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(17, 20);
            this.lbl_Result.TabIndex = 11;
            this.lbl_Result.Text = "#";
            // 
            // btn_Pot
            // 
            this.btn_Pot.Location = new System.Drawing.Point(306, 464);
            this.btn_Pot.Name = "btn_Pot";
            this.btn_Pot.Size = new System.Drawing.Size(75, 31);
            this.btn_Pot.TabIndex = 12;
            this.btn_Pot.Text = "Potencia";
            this.btn_Pot.UseVisualStyleBackColor = true;
            this.btn_Pot.Click += new System.EventHandler(this.Btn_Pot_Click);
            // 
            // FrmApp001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 607);
            this.Controls.Add(this.btn_Pot);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.lbl_Valor);
            this.Controls.Add(this.btn_Div);
            this.Controls.Add(this.btn_Mult);
            this.Controls.Add(this.btn_Sub);
            this.Controls.Add(this.txt_Inserir2);
            this.Controls.Add(this.lbl_Inserir2);
            this.Controls.Add(this.txt_Inserir1);
            this.Controls.Add(this.lbl_Inserir);
            this.Controls.Add(this.btn_Soma);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.lbl_Mensagem);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmApp001";
            this.Text = "Primeiro Projeto";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaptionText;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Mensagem;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button btn_Soma;
        private System.Windows.Forms.Label lbl_Inserir;
        private System.Windows.Forms.TextBox txt_Inserir1;
        private System.Windows.Forms.Label lbl_Inserir2;
        private System.Windows.Forms.TextBox txt_Inserir2;
        private System.Windows.Forms.Button btn_Sub;
        private System.Windows.Forms.Button btn_Mult;
        private System.Windows.Forms.Button btn_Div;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Button btn_Pot;
    }
}

