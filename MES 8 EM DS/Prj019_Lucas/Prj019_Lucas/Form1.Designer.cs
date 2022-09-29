namespace Prj019_Lucas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecebe = new System.Windows.Forms.TextBox();
            this.btnConsul1 = new System.Windows.Forms.Button();
            this.btnConsul2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escola Técnica Estadual de São Paulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(54, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(455, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONSULTA RESULTADO DO VESTIBULINHO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label3.Location = new System.Drawing.Point(54, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de Inscrição:";
            // 
            // txtRecebe
            // 
            this.txtRecebe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtRecebe.Location = new System.Drawing.Point(275, 182);
            this.txtRecebe.Name = "txtRecebe";
            this.txtRecebe.Size = new System.Drawing.Size(100, 31);
            this.txtRecebe.TabIndex = 3;
            // 
            // btnConsul1
            // 
            this.btnConsul1.Location = new System.Drawing.Point(417, 185);
            this.btnConsul1.Name = "btnConsul1";
            this.btnConsul1.Size = new System.Drawing.Size(92, 37);
            this.btnConsul1.TabIndex = 4;
            this.btnConsul1.Text = "Consulta  com ARRAY";
            this.btnConsul1.UseVisualStyleBackColor = true;
            this.btnConsul1.Click += new System.EventHandler(this.BtnConsul1_Click);
            // 
            // btnConsul2
            // 
            this.btnConsul2.Location = new System.Drawing.Point(529, 182);
            this.btnConsul2.Name = "btnConsul2";
            this.btnConsul2.Size = new System.Drawing.Size(90, 40);
            this.btnConsul2.TabIndex = 5;
            this.btnConsul2.Text = "Consulta com IndexOF";
            this.btnConsul2.UseVisualStyleBackColor = true;
            this.btnConsul2.Click += new System.EventHandler(this.BtnConsul2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.groupBox1.Location = new System.Drawing.Point(59, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 139);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblStatus.Location = new System.Drawing.Point(35, 48);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(488, 34);
            this.lblStatus.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(79, 418);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(116, 45);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(462, 413);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(142, 55);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 475);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConsul2);
            this.Controls.Add(this.btnConsul1);
            this.Controls.Add(this.txtRecebe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRecebe;
        private System.Windows.Forms.Button btnConsul1;
        private System.Windows.Forms.Button btnConsul2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

