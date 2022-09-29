namespace Prj013_Lucas
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
            this.cboPratoPrincipal = new System.Windows.Forms.ComboBox();
            this.lstAcompanhamentos = new System.Windows.Forms.ListBox();
            this.btnPratoPrincipal = new System.Windows.Forms.Button();
            this.btnAcompanh = new System.Windows.Forms.Button();
            this.lstPedido = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluirItens = new System.Windows.Forms.Button();
            this.lblItensPed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNovPed = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prato Principal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Acompanhamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(373, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "RESTAURANTE SUH - COMIDA CHINESA";
            // 
            // cboPratoPrincipal
            // 
            this.cboPratoPrincipal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPratoPrincipal.FormattingEnabled = true;
            this.cboPratoPrincipal.Location = new System.Drawing.Point(317, 79);
            this.cboPratoPrincipal.Name = "cboPratoPrincipal";
            this.cboPratoPrincipal.Size = new System.Drawing.Size(121, 21);
            this.cboPratoPrincipal.Sorted = true;
            this.cboPratoPrincipal.TabIndex = 3;
            // 
            // lstAcompanhamentos
            // 
            this.lstAcompanhamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAcompanhamentos.FormattingEnabled = true;
            this.lstAcompanhamentos.ItemHeight = 16;
            this.lstAcompanhamentos.Location = new System.Drawing.Point(317, 129);
            this.lstAcompanhamentos.Name = "lstAcompanhamentos";
            this.lstAcompanhamentos.Size = new System.Drawing.Size(149, 20);
            this.lstAcompanhamentos.TabIndex = 4;
            // 
            // btnPratoPrincipal
            // 
            this.btnPratoPrincipal.Location = new System.Drawing.Point(472, 76);
            this.btnPratoPrincipal.Name = "btnPratoPrincipal";
            this.btnPratoPrincipal.Size = new System.Drawing.Size(171, 34);
            this.btnPratoPrincipal.TabIndex = 5;
            this.btnPratoPrincipal.Text = "Incluir Prato Principal";
            this.btnPratoPrincipal.UseVisualStyleBackColor = true;
            this.btnPratoPrincipal.Click += new System.EventHandler(this.BtnPratoPrincipal_Click);
            // 
            // btnAcompanh
            // 
            this.btnAcompanh.Location = new System.Drawing.Point(472, 125);
            this.btnAcompanh.Name = "btnAcompanh";
            this.btnAcompanh.Size = new System.Drawing.Size(171, 34);
            this.btnAcompanh.TabIndex = 6;
            this.btnAcompanh.Text = "Incluir acompanhamento";
            this.btnAcompanh.UseVisualStyleBackColor = true;
            this.btnAcompanh.Click += new System.EventHandler(this.BtnAcompanh_Click);
            // 
            // lstPedido
            // 
            this.lstPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPedido.FormattingEnabled = true;
            this.lstPedido.ItemHeight = 20;
            this.lstPedido.Location = new System.Drawing.Point(6, 42);
            this.lstPedido.Name = "lstPedido";
            this.lstPedido.Size = new System.Drawing.Size(262, 124);
            this.lstPedido.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluirItens);
            this.groupBox1.Controls.Add(this.lblItensPed);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lstPedido);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(150, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 202);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PEDIDO";
            // 
            // btnExcluirItens
            // 
            this.btnExcluirItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirItens.Location = new System.Drawing.Point(288, 140);
            this.btnExcluirItens.Name = "btnExcluirItens";
            this.btnExcluirItens.Size = new System.Drawing.Size(183, 39);
            this.btnExcluirItens.TabIndex = 11;
            this.btnExcluirItens.Text = "Excluir Item do Pedido";
            this.btnExcluirItens.UseVisualStyleBackColor = true;
            this.btnExcluirItens.Click += new System.EventHandler(this.BtnExcluirItens_Click);
            // 
            // lblItensPed
            // 
            this.lblItensPed.AutoSize = true;
            this.lblItensPed.Location = new System.Drawing.Point(338, 99);
            this.lblItensPed.Name = "lblItensPed";
            this.lblItensPed.Size = new System.Drawing.Size(26, 25);
            this.lblItensPed.TabIndex = 10;
            this.lblItensPed.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total de Itens no Pedido:";
            // 
            // btnNovPed
            // 
            this.btnNovPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovPed.Location = new System.Drawing.Point(150, 467);
            this.btnNovPed.Name = "btnNovPed";
            this.btnNovPed.Size = new System.Drawing.Size(221, 47);
            this.btnNovPed.TabIndex = 9;
            this.btnNovPed.Text = "Novo Pedido";
            this.btnNovPed.UseVisualStyleBackColor = true;
            this.btnNovPed.Click += new System.EventHandler(this.BtnNovPed_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(428, 467);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(221, 47);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 526);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovPed);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAcompanh);
            this.Controls.Add(this.btnPratoPrincipal);
            this.Controls.Add(this.lstAcompanhamentos);
            this.Controls.Add(this.cboPratoPrincipal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPratoPrincipal;
        private System.Windows.Forms.ListBox lstAcompanhamentos;
        private System.Windows.Forms.Button btnPratoPrincipal;
        private System.Windows.Forms.Button btnAcompanh;
        private System.Windows.Forms.ListBox lstPedido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcluirItens;
        private System.Windows.Forms.Label lblItensPed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNovPed;
        private System.Windows.Forms.Button btnSair;
    }
}

