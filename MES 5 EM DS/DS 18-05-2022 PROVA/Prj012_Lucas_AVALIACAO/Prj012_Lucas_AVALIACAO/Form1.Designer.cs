namespace Prj012_Lucas_AVALIACAO
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
            this.grpBoxCenter = new System.Windows.Forms.GroupBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.lblMedia = new System.Windows.Forms.Label();
            this.grpBoxSup = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grpBoxSeq = new System.Windows.Forms.GroupBox();
            this.lblSeq = new System.Windows.Forms.Label();
            this.grpBoxCenter.SuspendLayout();
            this.grpBoxSup.SuspendLayout();
            this.grpBoxSeq.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxCenter
            // 
            this.grpBoxCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpBoxCenter.Controls.Add(this.btnValidar);
            this.grpBoxCenter.Controls.Add(this.btnMedia);
            this.grpBoxCenter.Controls.Add(this.label2);
            this.grpBoxCenter.Controls.Add(this.label1);
            this.grpBoxCenter.Controls.Add(this.txtValor2);
            this.grpBoxCenter.Controls.Add(this.txtValor1);
            this.grpBoxCenter.Controls.Add(this.lblMedia);
            this.grpBoxCenter.Location = new System.Drawing.Point(119, 79);
            this.grpBoxCenter.Name = "grpBoxCenter";
            this.grpBoxCenter.Size = new System.Drawing.Size(686, 144);
            this.grpBoxCenter.TabIndex = 0;
            this.grpBoxCenter.TabStop = false;
            this.grpBoxCenter.Text = "Media";
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(303, 48);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(89, 53);
            this.btnValidar.TabIndex = 6;
            this.btnValidar.Text = "VALIDAR";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.BtnValidar_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedia.Location = new System.Drawing.Point(421, 48);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(81, 51);
            this.btnMedia.TabIndex = 5;
            this.btnMedia.Text = "FAZER MEDIA";
            this.btnMedia.UseVisualStyleBackColor = false;
            this.btnMedia.Click += new System.EventHandler(this.BtnMedia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Insira o segundo valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insira o primeiro valor";
            // 
            // txtValor2
            // 
            this.txtValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor2.Location = new System.Drawing.Point(180, 79);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(77, 26);
            this.txtValor2.TabIndex = 2;
            // 
            // txtValor1
            // 
            this.txtValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor1.Location = new System.Drawing.Point(180, 43);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(77, 26);
            this.txtValor1.TabIndex = 1;
            // 
            // lblMedia
            // 
            this.lblMedia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(556, 50);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(93, 49);
            this.lblMedia.TabIndex = 0;
            this.lblMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBoxSup
            // 
            this.grpBoxSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpBoxSup.Controls.Add(this.btnSair);
            this.grpBoxSup.Controls.Add(this.btnLimpar);
            this.grpBoxSup.Location = new System.Drawing.Point(605, 300);
            this.grpBoxSup.Name = "grpBoxSup";
            this.grpBoxSup.Size = new System.Drawing.Size(200, 148);
            this.grpBoxSup.TabIndex = 1;
            this.grpBoxSup.TabStop = false;
            this.grpBoxSup.Text = "Suporte";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(57, 97);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(94, 45);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(57, 19);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(94, 45);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // grpBoxSeq
            // 
            this.grpBoxSeq.Controls.Add(this.lblSeq);
            this.grpBoxSeq.Location = new System.Drawing.Point(119, 319);
            this.grpBoxSeq.Name = "grpBoxSeq";
            this.grpBoxSeq.Size = new System.Drawing.Size(325, 100);
            this.grpBoxSeq.TabIndex = 2;
            this.grpBoxSeq.TabStop = false;
            this.grpBoxSeq.Text = "Sequencia de numeros";
            // 
            // lblSeq
            // 
            this.lblSeq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeq.Location = new System.Drawing.Point(71, 31);
            this.lblSeq.Name = "lblSeq";
            this.lblSeq.Size = new System.Drawing.Size(233, 39);
            this.lblSeq.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 640);
            this.Controls.Add(this.grpBoxSeq);
            this.Controls.Add(this.grpBoxSup);
            this.Controls.Add(this.grpBoxCenter);
            this.Name = "Form1";
            this.Text = "Avaliacao de DS 18-05-2022";
            this.grpBoxCenter.ResumeLayout(false);
            this.grpBoxCenter.PerformLayout();
            this.grpBoxSup.ResumeLayout(false);
            this.grpBoxSeq.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxCenter;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.GroupBox grpBoxSup;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.GroupBox grpBoxSeq;
        private System.Windows.Forms.Label lblSeq;
    }
}

