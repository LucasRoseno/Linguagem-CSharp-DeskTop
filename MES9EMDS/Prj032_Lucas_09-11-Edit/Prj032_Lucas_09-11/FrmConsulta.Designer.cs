namespace Prj032_Lucas_09_11
{
    partial class FrmConsulta
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.RdoNome = new System.Windows.Forms.RadioButton();
            this.RdoCodigo = new System.Windows.Forms.RadioButton();
            this.RdoGeral = new System.Windows.Forms.RadioButton();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label1.Location = new System.Drawing.Point(129, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTAGEM DO CADASTRO DE USUÁRIO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.RdoNome);
            this.groupBox1.Controls.Add(this.RdoCodigo);
            this.groupBox1.Controls.Add(this.RdoGeral);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(122, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecionar o tipo da Consulta";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(371, 71);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(113, 27);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar >>";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(210, 113);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(140, 24);
            this.txtNome.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(218, 74);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 24);
            this.txtCodigo.TabIndex = 3;
            // 
            // RdoNome
            // 
            this.RdoNome.AutoSize = true;
            this.RdoNome.Location = new System.Drawing.Point(43, 113);
            this.RdoNome.Name = "RdoNome";
            this.RdoNome.Size = new System.Drawing.Size(161, 22);
            this.RdoNome.TabIndex = 2;
            this.RdoNome.TabStop = true;
            this.RdoNome.Text = "Consultar por Nome";
            this.RdoNome.UseVisualStyleBackColor = true;
            // 
            // RdoCodigo
            // 
            this.RdoCodigo.AutoSize = true;
            this.RdoCodigo.Location = new System.Drawing.Point(43, 73);
            this.RdoCodigo.Name = "RdoCodigo";
            this.RdoCodigo.Size = new System.Drawing.Size(168, 22);
            this.RdoCodigo.TabIndex = 1;
            this.RdoCodigo.TabStop = true;
            this.RdoCodigo.Text = "Consultar por Código";
            this.RdoCodigo.UseVisualStyleBackColor = true;
            // 
            // RdoGeral
            // 
            this.RdoGeral.AutoSize = true;
            this.RdoGeral.Location = new System.Drawing.Point(43, 36);
            this.RdoGeral.Name = "RdoGeral";
            this.RdoGeral.Size = new System.Drawing.Size(130, 22);
            this.RdoGeral.TabIndex = 0;
            this.RdoGeral.TabStop = true;
            this.RdoGeral.Text = "LISTAR GERAL";
            this.RdoGeral.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnVoltar.Location = new System.Drawing.Point(304, 498);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(113, 27);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "<< Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // DgvLista
            // 
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Location = new System.Drawing.Point(134, 240);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.Size = new System.Drawing.Size(482, 229);
            this.DgvLista.TabIndex = 7;
            this.DgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLista_CellContentClick);
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.DgvLista);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsulta";
            this.Text = "FrmConsulta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdoNome;
        private System.Windows.Forms.RadioButton RdoCodigo;
        private System.Windows.Forms.RadioButton RdoGeral;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView DgvLista;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtCodigo;
    }
}