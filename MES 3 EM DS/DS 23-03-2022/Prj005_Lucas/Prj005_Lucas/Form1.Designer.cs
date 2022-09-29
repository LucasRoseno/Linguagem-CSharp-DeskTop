namespace Prj005_Lucas
{
    partial class Frm_004
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
            this.label2 = new System.Windows.Forms.Label();
            this.LblMensagem = new System.Windows.Forms.Label();
            this.LblMostrar = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtSexo = new System.Windows.Forms.TextBox();
            this.BtnExibir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sexo";
            // 
            // LblMensagem
            // 
            this.LblMensagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensagem.Location = new System.Drawing.Point(76, 278);
            this.LblMensagem.Name = "LblMensagem";
            this.LblMensagem.Size = new System.Drawing.Size(127, 31);
            this.LblMensagem.TabIndex = 2;
            this.LblMensagem.Text = "Mensagem";
            // 
            // LblMostrar
            // 
            this.LblMostrar.BackColor = System.Drawing.SystemColors.Menu;
            this.LblMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrar.Location = new System.Drawing.Point(232, 278);
            this.LblMostrar.Name = "LblMostrar";
            this.LblMostrar.Size = new System.Drawing.Size(382, 31);
            this.LblMostrar.TabIndex = 3;
            // 
            // TxtNome
            // 
            this.TxtNome.BackColor = System.Drawing.SystemColors.Menu;
            this.TxtNome.Location = new System.Drawing.Point(171, 86);
            this.TxtNome.MaxLength = 50;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(429, 20);
            this.TxtNome.TabIndex = 0;
            this.TxtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // TxtSexo
            // 
            this.TxtSexo.BackColor = System.Drawing.SystemColors.Menu;
            this.TxtSexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtSexo.Location = new System.Drawing.Point(171, 125);
            this.TxtSexo.MaxLength = 1;
            this.TxtSexo.Name = "TxtSexo";
            this.TxtSexo.Size = new System.Drawing.Size(32, 20);
            this.TxtSexo.TabIndex = 1;
            // 
            // BtnExibir
            // 
            this.BtnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExibir.Location = new System.Drawing.Point(180, 184);
            this.BtnExibir.Name = "BtnExibir";
            this.BtnExibir.Size = new System.Drawing.Size(132, 59);
            this.BtnExibir.TabIndex = 3;
            this.BtnExibir.Text = "&EXIBIR";
            this.BtnExibir.UseVisualStyleBackColor = true;
            this.BtnExibir.Click += new System.EventHandler(this.BtnExibir_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "&LIMPAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(583, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 74);
            this.button3.TabIndex = 5;
            this.button3.Text = "&SAIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Frm_004
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnExibir);
            this.Controls.Add(this.TxtSexo);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblMostrar);
            this.Controls.Add(this.LblMensagem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_004";
            this.Text = "Quinto projeto - Estrutura Condicional";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblMensagem;
        private System.Windows.Forms.Label LblMostrar;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtSexo;
        private System.Windows.Forms.Button BtnExibir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

