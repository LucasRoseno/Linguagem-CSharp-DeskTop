namespace Prj002_Lucas
{
    partial class FrmExe002
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
            this.LblMensagem = new System.Windows.Forms.Label();
            this.BtnMensagem1 = new System.Windows.Forms.Button();
            this.BtnMensagem2 = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblMensagem
            // 
            this.LblMensagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMensagem.Font = new System.Drawing.Font("Leelawadee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensagem.Location = new System.Drawing.Point(120, 50);
            this.LblMensagem.Name = "LblMensagem";
            this.LblMensagem.Size = new System.Drawing.Size(632, 86);
            this.LblMensagem.TabIndex = 0;
            // 
            // BtnMensagem1
            // 
            this.BtnMensagem1.BackColor = System.Drawing.SystemColors.Control;
            this.BtnMensagem1.Location = new System.Drawing.Point(202, 248);
            this.BtnMensagem1.Name = "BtnMensagem1";
            this.BtnMensagem1.Size = new System.Drawing.Size(139, 53);
            this.BtnMensagem1.TabIndex = 1;
            this.BtnMensagem1.Text = " Mensagem 1";
            this.BtnMensagem1.UseVisualStyleBackColor = false;
            this.BtnMensagem1.Click += new System.EventHandler(this.BtnMensagem1_Click);
            // 
            // BtnMensagem2
            // 
            this.BtnMensagem2.Enabled = false;
            this.BtnMensagem2.Location = new System.Drawing.Point(388, 248);
            this.BtnMensagem2.Name = "BtnMensagem2";
            this.BtnMensagem2.Size = new System.Drawing.Size(139, 54);
            this.BtnMensagem2.TabIndex = 2;
            this.BtnMensagem2.Text = "Mensagem 2";
            this.BtnMensagem2.UseVisualStyleBackColor = true;
            this.BtnMensagem2.Click += new System.EventHandler(this.BtnMensagem2_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnSair.Location = new System.Drawing.Point(594, 246);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(93, 55);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // FrmExe002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnMensagem2);
            this.Controls.Add(this.BtnMensagem1);
            this.Controls.Add(this.LblMensagem);
            this.MaximizeBox = false;
            this.Name = "FrmExe002";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Segundo Projeto";
            this.Load += new System.EventHandler(this.FrmExe002_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblMensagem;
        private System.Windows.Forms.Button BtnMensagem1;
        private System.Windows.Forms.Button BtnMensagem2;
        private System.Windows.Forms.Button BtnSair;
    }
}

