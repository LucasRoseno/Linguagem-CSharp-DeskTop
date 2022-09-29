namespace Prj007_Lucas
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.lblExibir = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grpOperacoes = new System.Windows.Forms.GroupBox();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnSom = new System.Windows.Forms.Button();
            this.btnPot = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpValores = new System.Windows.Forms.GroupBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpOperacoes.SuspendLayout();
            this.grpValores.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExibir
            // 
            this.lblExibir.AutoSize = true;
            this.lblExibir.Location = new System.Drawing.Point(492, -40);
            this.lblExibir.Name = "lblExibir";
            this.lblExibir.Size = new System.Drawing.Size(35, 13);
            this.lblExibir.TabIndex = 11;
            this.lblExibir.Text = "label4";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(376, 436);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(167, 60);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "<VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.Location = new System.Drawing.Point(234, 436);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(118, 60);
            this.btnAjuda.TabIndex = 9;
            this.btnAjuda.Text = "AJUDA";
            this.btnAjuda.UseVisualStyleBackColor = false;
            this.btnAjuda.Click += new System.EventHandler(this.BtnAjuda_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(90, 436);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(118, 60);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // grpOperacoes
            // 
            this.grpOperacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpOperacoes.Controls.Add(this.btnDiv);
            this.grpOperacoes.Controls.Add(this.btnMult);
            this.grpOperacoes.Controls.Add(this.btnSub);
            this.grpOperacoes.Controls.Add(this.btnSom);
            this.grpOperacoes.Controls.Add(this.btnPot);
            this.grpOperacoes.Controls.Add(this.lblResultado);
            this.grpOperacoes.Controls.Add(this.label3);
            this.grpOperacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOperacoes.Location = new System.Drawing.Point(77, 234);
            this.grpOperacoes.Name = "grpOperacoes";
            this.grpOperacoes.Size = new System.Drawing.Size(515, 169);
            this.grpOperacoes.TabIndex = 7;
            this.grpOperacoes.TabStop = false;
            this.grpOperacoes.Text = "Operações aritméticas";
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(245, 44);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(54, 47);
            this.btnDiv.TabIndex = 11;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.BtnSom_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(167, 44);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(54, 47);
            this.btnMult.TabIndex = 10;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.BtnSom_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(97, 44);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(54, 47);
            this.btnSub.TabIndex = 9;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.BtnSom_Click);
            // 
            // btnSom
            // 
            this.btnSom.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSom.Location = new System.Drawing.Point(30, 44);
            this.btnSom.Name = "btnSom";
            this.btnSom.Size = new System.Drawing.Size(54, 47);
            this.btnSom.TabIndex = 8;
            this.btnSom.Text = "+";
            this.btnSom.UseVisualStyleBackColor = true;
            this.btnSom.Click += new System.EventHandler(this.BtnSom_Click);
            // 
            // btnPot
            // 
            this.btnPot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPot.Location = new System.Drawing.Point(336, 44);
            this.btnPot.Name = "btnPot";
            this.btnPot.Size = new System.Drawing.Size(130, 47);
            this.btnPot.TabIndex = 7;
            this.btnPot.Text = "Potência";
            this.btnPot.UseVisualStyleBackColor = true;
            this.btnPot.Click += new System.EventHandler(this.BtnSom_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblResultado.Location = new System.Drawing.Point(307, 115);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(159, 29);
            this.lblResultado.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(93, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Resultado da Operação:";
            // 
            // grpValores
            // 
            this.grpValores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grpValores.Controls.Add(this.txtBox2);
            this.grpValores.Controls.Add(this.txtBox1);
            this.grpValores.Controls.Add(this.label2);
            this.grpValores.Controls.Add(this.label1);
            this.grpValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpValores.Location = new System.Drawing.Point(77, 23);
            this.grpValores.Name = "grpValores";
            this.grpValores.Size = new System.Drawing.Size(325, 169);
            this.grpValores.TabIndex = 6;
            this.grpValores.TabStop = false;
            this.grpValores.Text = "Valores";
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(236, 86);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(80, 26);
            this.txtBox2.TabIndex = 3;
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(236, 46);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(80, 26);
            this.txtBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(50, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o 2° Valor.........:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o 1° Valor.........:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblData.Location = new System.Drawing.Point(464, 63);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(100, 23);
            this.lblData.TabIndex = 13;
            this.lblData.Click += new System.EventHandler(this.LblData_Click);
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblHora.Location = new System.Drawing.Point(464, 109);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(100, 23);
            this.lblHora.TabIndex = 14;
            // 
            // lblDia
            // 
            this.lblDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblDia.Location = new System.Drawing.Point(464, 159);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(100, 23);
            this.lblDia.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 565);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblExibir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAjuda);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.grpOperacoes);
            this.Controls.Add(this.grpValores);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpOperacoes.ResumeLayout(false);
            this.grpValores.ResumeLayout(false);
            this.grpValores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExibir;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox grpOperacoes;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnSom;
        private System.Windows.Forms.Button btnPot;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpValores;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Timer timer1;
    }
}