namespace Prj022_Lucas
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
            this.components = new System.ComponentModel.Container();
            this.lblData = new System.Windows.Forms.Label();
            this.lblDataSema = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoBd = new System.Windows.Forms.RadioButton();
            this.rdoWeb = new System.Windows.Forms.RadioButton();
            this.rdoDtcc = new System.Windows.Forms.RadioButton();
            this.txtNumChama = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblData.Location = new System.Drawing.Point(48, 27);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(115, 35);
            this.lblData.TabIndex = 0;
            // 
            // lblDataSema
            // 
            this.lblDataSema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDataSema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblDataSema.Location = new System.Drawing.Point(232, 27);
            this.lblDataSema.Name = "lblDataSema";
            this.lblDataSema.Size = new System.Drawing.Size(184, 35);
            this.lblDataSema.TabIndex = 1;
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblHora.Location = new System.Drawing.Point(484, 27);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(115, 35);
            this.lblHora.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoDtcc);
            this.groupBox2.Controls.Add(this.rdoWeb);
            this.groupBox2.Controls.Add(this.rdoBd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox2.Location = new System.Drawing.Point(324, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 169);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Componente Curricular";
            // 
            // rdoBd
            // 
            this.rdoBd.AutoSize = true;
            this.rdoBd.Location = new System.Drawing.Point(23, 46);
            this.rdoBd.Name = "rdoBd";
            this.rdoBd.Size = new System.Drawing.Size(169, 24);
            this.rdoBd.TabIndex = 0;
            this.rdoBd.TabStop = true;
            this.rdoBd.Text = "Banco de Dados III";
            this.rdoBd.UseVisualStyleBackColor = true;
            // 
            // rdoWeb
            // 
            this.rdoWeb.AutoSize = true;
            this.rdoWeb.Location = new System.Drawing.Point(23, 77);
            this.rdoWeb.Name = "rdoWeb";
            this.rdoWeb.Size = new System.Drawing.Size(122, 24);
            this.rdoWeb.TabIndex = 1;
            this.rdoWeb.TabStop = true;
            this.rdoWeb.Text = "Prog. Web III";
            this.rdoWeb.UseVisualStyleBackColor = true;
            // 
            // rdoDtcc
            // 
            this.rdoDtcc.AutoSize = true;
            this.rdoDtcc.Location = new System.Drawing.Point(23, 108);
            this.rdoDtcc.Name = "rdoDtcc";
            this.rdoDtcc.Size = new System.Drawing.Size(74, 24);
            this.rdoDtcc.TabIndex = 2;
            this.rdoDtcc.TabStop = true;
            this.rdoDtcc.Text = "DTCC";
            this.rdoDtcc.UseVisualStyleBackColor = true;
            // 
            // txtNumChama
            // 
            this.txtNumChama.Location = new System.Drawing.Point(36, 46);
            this.txtNumChama.Name = "txtNumChama";
            this.txtNumChama.Size = new System.Drawing.Size(113, 26);
            this.txtNumChama.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(36, 100);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(113, 40);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.txtNumChama);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox1.Location = new System.Drawing.Point(52, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 169);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Número de Chamada";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblResult);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox3.Location = new System.Drawing.Point(64, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 113);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RESULTADO";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblResult.Location = new System.Drawing.Point(7, 42);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(155, 31);
            this.lblResult.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(347, 310);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(134, 36);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(347, 371);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(134, 34);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblDataSema);
            this.Controls.Add(this.lblData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblDataSema;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoDtcc;
        private System.Windows.Forms.RadioButton rdoWeb;
        private System.Windows.Forms.RadioButton rdoBd;
        private System.Windows.Forms.TextBox txtNumChama;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

