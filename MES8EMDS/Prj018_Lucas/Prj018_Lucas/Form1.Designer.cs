namespace Prj018_Lucas
{
    partial class Exer018
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
            this.txtPesc = new System.Windows.Forms.TextBox();
            this.btnConsu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResp = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(250, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "COLÉGIO MODELO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(85, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(506, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "TERMINAL DE CONSULTA - RESULTADOS FINAIS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label3.Location = new System.Drawing.Point(48, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de Chamada";
            // 
            // txtPesc
            // 
            this.txtPesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtPesc.Location = new System.Drawing.Point(269, 175);
            this.txtPesc.Name = "txtPesc";
            this.txtPesc.Size = new System.Drawing.Size(54, 23);
            this.txtPesc.TabIndex = 3;
            // 
            // btnConsu
            // 
            this.btnConsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnConsu.Location = new System.Drawing.Point(391, 165);
            this.btnConsu.Name = "btnConsu";
            this.btnConsu.Size = new System.Drawing.Size(153, 42);
            this.btnConsu.TabIndex = 4;
            this.btnConsu.Text = "CONSULTAR";
            this.btnConsu.UseVisualStyleBackColor = true;
            this.btnConsu.Click += new System.EventHandler(this.BtnConsu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.lblResp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox1.Location = new System.Drawing.Point(105, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 157);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado Final";
            // 
            // lblResp
            // 
            this.lblResp.Location = new System.Drawing.Point(6, 37);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(637, 32);
            this.lblResp.TabIndex = 0;
            this.lblResp.Text = "*";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnLimpar.Location = new System.Drawing.Point(172, 440);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 45);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSair.Location = new System.Drawing.Point(415, 435);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(106, 50);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Exer018
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConsu);
            this.Controls.Add(this.txtPesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Exer018";
            this.Text = "Exe018";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPesc;
        private System.Windows.Forms.Button btnConsu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResp;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

