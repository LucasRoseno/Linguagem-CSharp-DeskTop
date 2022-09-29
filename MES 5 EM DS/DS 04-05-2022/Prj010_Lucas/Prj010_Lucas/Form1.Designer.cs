namespace Prj010_Lucas
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
            this.lblDia = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDataNascto = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboInstrucao = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdoFem = new System.Windows.Forms.RadioButton();
            this.rdoMasc = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkCantar = new System.Windows.Forms.CheckBox();
            this.chkNadar = new System.Windows.Forms.CheckBox();
            this.chkDancar = new System.Windows.Forms.CheckBox();
            this.chkViajar = new System.Windows.Forms.CheckBox();
            this.chkCaminhar = new System.Windows.Forms.CheckBox();
            this.chkLer = new System.Windows.Forms.CheckBox();
            this.lstResposta = new System.Windows.Forms.ListBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(57, 33);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(188, 36);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "lblData";
            // 
            // lblDia
            // 
            this.lblDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(268, 33);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(188, 36);
            this.lblDia.TabIndex = 1;
            this.lblDia.Text = "lblDia";
            // 
            // lblHora
            // 
            this.lblHora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(490, 33);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(188, 36);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "lblHora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "DADOS PESSOAIS";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Location = new System.Drawing.Point(57, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 56);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(21, 20);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(594, 26);
            this.txtNome.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.dtpDataNascto);
            this.groupBox2.Location = new System.Drawing.Point(57, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 55);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data de Nascimento";
            // 
            // dtpDataNascto
            // 
            this.dtpDataNascto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascto.Location = new System.Drawing.Point(43, 19);
            this.dtpDataNascto.Name = "dtpDataNascto";
            this.dtpDataNascto.Size = new System.Drawing.Size(133, 20);
            this.dtpDataNascto.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dtpDataNascto, "Você não nasceu hoje e nem amanhã ");
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.cboInstrucao);
            this.groupBox3.Location = new System.Drawing.Point(355, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 55);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grau de Instrução:";
            // 
            // cboInstrucao
            // 
            this.cboInstrucao.FormattingEnabled = true;
            this.cboInstrucao.Location = new System.Drawing.Point(31, 17);
            this.cboInstrucao.Name = "cboInstrucao";
            this.cboInstrucao.Size = new System.Drawing.Size(262, 21);
            this.cboInstrucao.TabIndex = 0;
            this.cboInstrucao.Text = "Selecione....";
            this.cboInstrucao.SelectedIndexChanged += new System.EventHandler(this.CboInstrucao_SelectedIndexChanged);
            this.cboInstrucao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboInstrucao_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.rdoFem);
            this.groupBox4.Controls.Add(this.rdoMasc);
            this.groupBox4.Location = new System.Drawing.Point(57, 220);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(231, 100);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // rdoFem
            // 
            this.rdoFem.AutoSize = true;
            this.rdoFem.Location = new System.Drawing.Point(14, 57);
            this.rdoFem.Name = "rdoFem";
            this.rdoFem.Size = new System.Drawing.Size(67, 17);
            this.rdoFem.TabIndex = 1;
            this.rdoFem.Text = "Feminino";
            this.rdoFem.UseVisualStyleBackColor = true;
            // 
            // rdoMasc
            // 
            this.rdoMasc.AutoSize = true;
            this.rdoMasc.Checked = true;
            this.rdoMasc.Location = new System.Drawing.Point(14, 20);
            this.rdoMasc.Name = "rdoMasc";
            this.rdoMasc.Size = new System.Drawing.Size(73, 17);
            this.rdoMasc.TabIndex = 0;
            this.rdoMasc.TabStop = true;
            this.rdoMasc.Text = "Masculino";
            this.rdoMasc.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox5.Controls.Add(this.chkCantar);
            this.groupBox5.Controls.Add(this.chkNadar);
            this.groupBox5.Controls.Add(this.chkDancar);
            this.groupBox5.Controls.Add(this.chkViajar);
            this.groupBox5.Controls.Add(this.chkCaminhar);
            this.groupBox5.Controls.Add(this.chkLer);
            this.groupBox5.Location = new System.Drawing.Point(355, 220);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(323, 100);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Preferências Pessoais";
            // 
            // chkCantar
            // 
            this.chkCantar.AutoSize = true;
            this.chkCantar.Location = new System.Drawing.Point(193, 57);
            this.chkCantar.Name = "chkCantar";
            this.chkCantar.Size = new System.Drawing.Size(57, 17);
            this.chkCantar.TabIndex = 5;
            this.chkCantar.Text = "Cantar";
            this.chkCantar.UseVisualStyleBackColor = true;
            // 
            // chkNadar
            // 
            this.chkNadar.AutoSize = true;
            this.chkNadar.Location = new System.Drawing.Point(193, 20);
            this.chkNadar.Name = "chkNadar";
            this.chkNadar.Size = new System.Drawing.Size(55, 17);
            this.chkNadar.TabIndex = 4;
            this.chkNadar.Text = "Nadar";
            this.chkNadar.UseVisualStyleBackColor = true;
            // 
            // chkDancar
            // 
            this.chkDancar.AutoSize = true;
            this.chkDancar.Location = new System.Drawing.Point(112, 57);
            this.chkDancar.Name = "chkDancar";
            this.chkDancar.Size = new System.Drawing.Size(61, 17);
            this.chkDancar.TabIndex = 3;
            this.chkDancar.Text = "Dançar";
            this.chkDancar.UseVisualStyleBackColor = true;
            // 
            // chkViajar
            // 
            this.chkViajar.AutoSize = true;
            this.chkViajar.Location = new System.Drawing.Point(112, 21);
            this.chkViajar.Name = "chkViajar";
            this.chkViajar.Size = new System.Drawing.Size(52, 17);
            this.chkViajar.TabIndex = 2;
            this.chkViajar.Text = "Viajar";
            this.chkViajar.UseVisualStyleBackColor = true;
            // 
            // chkCaminhar
            // 
            this.chkCaminhar.AutoSize = true;
            this.chkCaminhar.Location = new System.Drawing.Point(18, 57);
            this.chkCaminhar.Name = "chkCaminhar";
            this.chkCaminhar.Size = new System.Drawing.Size(70, 17);
            this.chkCaminhar.TabIndex = 1;
            this.chkCaminhar.Text = "Caminhar";
            this.chkCaminhar.UseVisualStyleBackColor = true;
            // 
            // chkLer
            // 
            this.chkLer.AutoSize = true;
            this.chkLer.Location = new System.Drawing.Point(18, 20);
            this.chkLer.Name = "chkLer";
            this.chkLer.Size = new System.Drawing.Size(41, 17);
            this.chkLer.TabIndex = 0;
            this.chkLer.Text = "Ler";
            this.chkLer.UseVisualStyleBackColor = true;
            // 
            // lstResposta
            // 
            this.lstResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResposta.FormattingEnabled = true;
            this.lstResposta.ItemHeight = 16;
            this.lstResposta.Location = new System.Drawing.Point(57, 326);
            this.lstResposta.Name = "lstResposta";
            this.lstResposta.Size = new System.Drawing.Size(462, 164);
            this.lstResposta.TabIndex = 9;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(548, 336);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(111, 31);
            this.btnListar.TabIndex = 10;
            this.btnListar.Text = "<<LISTAR";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(548, 384);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(111, 30);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(549, 432);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 34);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.Button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnListar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lstResposta);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpDataNascto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboInstrucao;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoFem;
        private System.Windows.Forms.RadioButton rdoMasc;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkCantar;
        private System.Windows.Forms.CheckBox chkNadar;
        private System.Windows.Forms.CheckBox chkDancar;
        private System.Windows.Forms.CheckBox chkViajar;
        private System.Windows.Forms.CheckBox chkCaminhar;
        private System.Windows.Forms.CheckBox chkLer;
        private System.Windows.Forms.ListBox lstResposta;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

