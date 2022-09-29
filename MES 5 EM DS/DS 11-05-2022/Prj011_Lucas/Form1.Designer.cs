namespace Prj011_Lucas
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
            this.lblDia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radDuplo = new System.Windows.Forms.RadioButton();
            this.radSimples = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSer4 = new System.Windows.Forms.CheckBox();
            this.chkSer3 = new System.Windows.Forms.CheckBox();
            this.chkSer2 = new System.Windows.Forms.CheckBox();
            this.chkSer1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataSaida = new System.Windows.Forms.MaskedTextBox();
            this.dataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdoParce = new System.Windows.Forms.RadioButton();
            this.rdoAVista = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTotHosp = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblSubTot = new System.Windows.Forms.Label();
            this.lblTotPag = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTotServ = new System.Windows.Forms.Label();
            this.lblValDia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDia.Location = new System.Drawing.Point(12, 31);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(107, 49);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(492, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "HOTEL MOSCABESSA - FECHAMENTO DE CONTA CHECKOUT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblHora.Location = new System.Drawing.Point(638, 31);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(150, 49);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "label3";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.radDuplo);
            this.groupBox1.Controls.Add(this.radSimples);
            this.groupBox1.Location = new System.Drawing.Point(15, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Quarto";
            // 
            // radDuplo
            // 
            this.radDuplo.AutoSize = true;
            this.radDuplo.Location = new System.Drawing.Point(19, 64);
            this.radDuplo.Name = "radDuplo";
            this.radDuplo.Size = new System.Drawing.Size(106, 17);
            this.radDuplo.TabIndex = 1;
            this.radDuplo.TabStop = true;
            this.radDuplo.Text = "Duplo R$ 280,00";
            this.radDuplo.UseVisualStyleBackColor = true;
            // 
            // radSimples
            // 
            this.radSimples.AutoSize = true;
            this.radSimples.Location = new System.Drawing.Point(19, 32);
            this.radSimples.Name = "radSimples";
            this.radSimples.Size = new System.Drawing.Size(114, 17);
            this.radSimples.TabIndex = 0;
            this.radSimples.TabStop = true;
            this.radSimples.Text = "Simples R$ 150,00";
            this.radSimples.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.chkSer4);
            this.groupBox2.Controls.Add(this.chkSer3);
            this.groupBox2.Controls.Add(this.chkSer2);
            this.groupBox2.Controls.Add(this.chkSer1);
            this.groupBox2.Location = new System.Drawing.Point(241, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serviços Utilizados";
            // 
            // chkSer4
            // 
            this.chkSer4.AutoSize = true;
            this.chkSer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSer4.Location = new System.Drawing.Point(166, 54);
            this.chkSer4.Name = "chkSer4";
            this.chkSer4.Size = new System.Drawing.Size(151, 20);
            this.chkSer4.TabIndex = 3;
            this.chkSer4.Text = "Serviço 4 - R$ 200,00";
            this.chkSer4.UseVisualStyleBackColor = true;
            // 
            // chkSer3
            // 
            this.chkSer3.AutoSize = true;
            this.chkSer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSer3.Location = new System.Drawing.Point(166, 19);
            this.chkSer3.Name = "chkSer3";
            this.chkSer3.Size = new System.Drawing.Size(151, 20);
            this.chkSer3.TabIndex = 2;
            this.chkSer3.Text = "Serviço 3 - R$ 120,00";
            this.chkSer3.UseVisualStyleBackColor = true;
            // 
            // chkSer2
            // 
            this.chkSer2.AutoSize = true;
            this.chkSer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSer2.Location = new System.Drawing.Point(16, 54);
            this.chkSer2.Name = "chkSer2";
            this.chkSer2.Size = new System.Drawing.Size(144, 20);
            this.chkSer2.TabIndex = 1;
            this.chkSer2.Text = "Serviço 2 - R$ 80,00";
            this.chkSer2.UseVisualStyleBackColor = true;
            // 
            // chkSer1
            // 
            this.chkSer1.AutoSize = true;
            this.chkSer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSer1.Location = new System.Drawing.Point(16, 19);
            this.chkSer1.Name = "chkSer1";
            this.chkSer1.Size = new System.Drawing.Size(144, 20);
            this.chkSer1.TabIndex = 0;
            this.chkSer1.Text = "Serviço 1 - R$ 50,00";
            this.chkSer1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.dataSaida);
            this.groupBox3.Controls.Add(this.dataEntrada);
            this.groupBox3.Location = new System.Drawing.Point(595, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(193, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datas:";
            // 
            // dataSaida
            // 
            this.dataSaida.Location = new System.Drawing.Point(25, 64);
            this.dataSaida.Mask = "00/00/0000";
            this.dataSaida.Name = "dataSaida";
            this.dataSaida.Size = new System.Drawing.Size(100, 20);
            this.dataSaida.TabIndex = 1;
            this.dataSaida.ValidatingType = typeof(System.DateTime);
            // 
            // dataEntrada
            // 
            this.dataEntrada.Location = new System.Drawing.Point(25, 19);
            this.dataEntrada.Mask = "00/00/0000";
            this.dataEntrada.Name = "dataEntrada";
            this.dataEntrada.Size = new System.Drawing.Size(100, 20);
            this.dataEntrada.TabIndex = 0;
            this.dataEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox4.Controls.Add(this.rdoParce);
            this.groupBox4.Controls.Add(this.rdoAVista);
            this.groupBox4.Location = new System.Drawing.Point(15, 230);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(295, 41);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Forma de Pagamento";
            // 
            // rdoParce
            // 
            this.rdoParce.AutoSize = true;
            this.rdoParce.Location = new System.Drawing.Point(171, 18);
            this.rdoParce.Name = "rdoParce";
            this.rdoParce.Size = new System.Drawing.Size(73, 17);
            this.rdoParce.TabIndex = 1;
            this.rdoParce.TabStop = true;
            this.rdoParce.Text = "Parcelado";
            this.rdoParce.UseVisualStyleBackColor = true;
            // 
            // rdoAVista
            // 
            this.rdoAVista.AutoSize = true;
            this.rdoAVista.Location = new System.Drawing.Point(7, 18);
            this.rdoAVista.Name = "rdoAVista";
            this.rdoAVista.Size = new System.Drawing.Size(158, 17);
            this.rdoAVista.TabIndex = 0;
            this.rdoAVista.TabStop = true;
            this.rdoAVista.Text = "A VISTA - 10% DESCONTO";
            this.rdoAVista.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox5.Controls.Add(this.lblTotHosp);
            this.groupBox5.Location = new System.Drawing.Point(588, 220);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 51);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total de Dias Hospedados:";
            // 
            // lblTotHosp
            // 
            this.lblTotHosp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotHosp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotHosp.Location = new System.Drawing.Point(62, 20);
            this.lblTotHosp.Name = "lblTotHosp";
            this.lblTotHosp.Size = new System.Drawing.Size(48, 28);
            this.lblTotHosp.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox6.Controls.Add(this.lblSubTot);
            this.groupBox6.Controls.Add(this.lblTotPag);
            this.groupBox6.Controls.Add(this.lblDesc);
            this.groupBox6.Controls.Add(this.lblTotServ);
            this.groupBox6.Controls.Add(this.lblValDia);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(60, 297);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(682, 100);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "RESULTADOS";
            // 
            // lblSubTot
            // 
            this.lblSubTot.BackColor = System.Drawing.Color.White;
            this.lblSubTot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTot.Location = new System.Drawing.Point(528, 18);
            this.lblSubTot.Name = "lblSubTot";
            this.lblSubTot.Size = new System.Drawing.Size(100, 20);
            this.lblSubTot.TabIndex = 9;
            // 
            // lblTotPag
            // 
            this.lblTotPag.BackColor = System.Drawing.Color.White;
            this.lblTotPag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotPag.Location = new System.Drawing.Point(361, 59);
            this.lblTotPag.Name = "lblTotPag";
            this.lblTotPag.Size = new System.Drawing.Size(100, 23);
            this.lblTotPag.TabIndex = 8;
            // 
            // lblDesc
            // 
            this.lblDesc.BackColor = System.Drawing.Color.White;
            this.lblDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(345, 20);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(100, 23);
            this.lblDesc.TabIndex = 7;
            // 
            // lblTotServ
            // 
            this.lblTotServ.BackColor = System.Drawing.Color.White;
            this.lblTotServ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotServ.Location = new System.Drawing.Point(123, 57);
            this.lblTotServ.Name = "lblTotServ";
            this.lblTotServ.Size = new System.Drawing.Size(100, 23);
            this.lblTotServ.TabIndex = 6;
            // 
            // lblValDia
            // 
            this.lblValDia.BackColor = System.Drawing.Color.White;
            this.lblValDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValDia.Location = new System.Drawing.Point(123, 20);
            this.lblValDia.Name = "lblValDia";
            this.lblValDia.Size = new System.Drawing.Size(100, 23);
            this.lblValDia.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(462, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sub Total:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(255, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "TOTAL A PAGAR:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(255, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "DESCONTO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(23, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total Serviços";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor das Diárias";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(369, 230);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(105, 41);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(174, 415);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 35);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(525, 415);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(114, 35);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDia);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDuplo;
        private System.Windows.Forms.RadioButton radSimples;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox dataSaida;
        private System.Windows.Forms.MaskedTextBox dataEntrada;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoParce;
        private System.Windows.Forms.RadioButton rdoAVista;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblTotHosp;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblSubTot;
        private System.Windows.Forms.Label lblTotPag;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblTotServ;
        private System.Windows.Forms.Label lblValDia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.CheckBox chkSer4;
        private System.Windows.Forms.CheckBox chkSer3;
        private System.Windows.Forms.CheckBox chkSer2;
        private System.Windows.Forms.CheckBox chkSer1;
    }
}

