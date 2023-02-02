namespace Prj030_Bd_FornProd
{
    partial class FrmProdutos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.cboRazaoSocial = new System.Windows.Forms.ComboBox();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornProdDataSet = new Prj030_Bd_FornProd.FornProdDataSet();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.txtQtdeMaxima = new System.Windows.Forms.TextBox();
            this.txtQtdeMinima = new System.Windows.Forms.TextBox();
            this.txtQtdeEstoque = new System.Windows.Forms.TextBox();
            this.txtDescProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpNavegacao = new System.Windows.Forms.GroupBox();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.produtosTableAdapter = new Prj030_Bd_FornProd.FornProdDataSetTableAdapters.ProdutosTableAdapter();
            this.fornecedoresTableAdapter = new Prj030_Bd_FornProd.FornProdDataSetTableAdapters.FornecedoresTableAdapter();
            this.groupBox1.SuspendLayout();
            this.grpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornProdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            this.grpNavegacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnListar);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnGravar);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.groupBox1.Location = new System.Drawing.Point(696, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 376);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(50, 301);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(109, 43);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "LISTAR";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(50, 235);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(109, 43);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(50, 170);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 43);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Location = new System.Drawing.Point(50, 97);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(109, 43);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "GRAVAR";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(50, 37);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(109, 43);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(296, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // grpDados
            // 
            this.grpDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpDados.Controls.Add(this.cboRazaoSocial);
            this.grpDados.Controls.Add(this.txtValorUnitario);
            this.grpDados.Controls.Add(this.txtQtdeMaxima);
            this.grpDados.Controls.Add(this.txtQtdeMinima);
            this.grpDados.Controls.Add(this.txtQtdeEstoque);
            this.grpDados.Controls.Add(this.txtDescProd);
            this.grpDados.Controls.Add(this.label3);
            this.grpDados.Controls.Add(this.txtCodProd);
            this.grpDados.Controls.Add(this.label8);
            this.grpDados.Controls.Add(this.label7);
            this.grpDados.Controls.Add(this.label6);
            this.grpDados.Controls.Add(this.label5);
            this.grpDados.Controls.Add(this.label4);
            this.grpDados.Controls.Add(this.label2);
            this.grpDados.Location = new System.Drawing.Point(54, 41);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(592, 376);
            this.grpDados.TabIndex = 2;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados Cadastrais";
            // 
            // cboRazaoSocial
            // 
            this.cboRazaoSocial.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtosBindingSource, "CodFornec", true));
            this.cboRazaoSocial.DataSource = this.fornecedoresBindingSource;
            this.cboRazaoSocial.DisplayMember = "RazaoSocial";
            this.cboRazaoSocial.Enabled = false;
            this.cboRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cboRazaoSocial.FormattingEnabled = true;
            this.cboRazaoSocial.Location = new System.Drawing.Point(215, 112);
            this.cboRazaoSocial.Name = "cboRazaoSocial";
            this.cboRazaoSocial.Size = new System.Drawing.Size(264, 28);
            this.cboRazaoSocial.TabIndex = 2;
            this.cboRazaoSocial.ValueMember = "CodFornec";
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.fornProdDataSet;
            // 
            // fornProdDataSet
            // 
            this.fornProdDataSet.DataSetName = "FornProdDataSet";
            this.fornProdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "Fornecedores";
            this.fornecedoresBindingSource.DataSource = this.fornProdDataSet;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "ValorUnitario", true));
            this.txtValorUnitario.Enabled = false;
            this.txtValorUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtValorUnitario.Location = new System.Drawing.Point(212, 276);
            this.txtValorUnitario.MaxLength = 10;
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(167, 26);
            this.txtValorUnitario.TabIndex = 6;
            // 
            // txtQtdeMaxima
            // 
            this.txtQtdeMaxima.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "QtdesMaxima", true));
            this.txtQtdeMaxima.Enabled = false;
            this.txtQtdeMaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtQtdeMaxima.Location = new System.Drawing.Point(215, 235);
            this.txtQtdeMaxima.MaxLength = 5;
            this.txtQtdeMaxima.Name = "txtQtdeMaxima";
            this.txtQtdeMaxima.Size = new System.Drawing.Size(90, 26);
            this.txtQtdeMaxima.TabIndex = 5;
            // 
            // txtQtdeMinima
            // 
            this.txtQtdeMinima.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "QtdesMinima", true));
            this.txtQtdeMinima.Enabled = false;
            this.txtQtdeMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtQtdeMinima.Location = new System.Drawing.Point(215, 187);
            this.txtQtdeMinima.MaxLength = 5;
            this.txtQtdeMinima.Name = "txtQtdeMinima";
            this.txtQtdeMinima.Size = new System.Drawing.Size(90, 26);
            this.txtQtdeMinima.TabIndex = 4;
            // 
            // txtQtdeEstoque
            // 
            this.txtQtdeEstoque.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "QtdesEstoque", true));
            this.txtQtdeEstoque.Enabled = false;
            this.txtQtdeEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtQtdeEstoque.Location = new System.Drawing.Point(215, 149);
            this.txtQtdeEstoque.MaxLength = 5;
            this.txtQtdeEstoque.Name = "txtQtdeEstoque";
            this.txtQtdeEstoque.Size = new System.Drawing.Size(90, 26);
            this.txtQtdeEstoque.TabIndex = 3;
            // 
            // txtDescProd
            // 
            this.txtDescProd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "Descricao", true));
            this.txtDescProd.Enabled = false;
            this.txtDescProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtDescProd.Location = new System.Drawing.Point(215, 76);
            this.txtDescProd.MaxLength = 50;
            this.txtDescProd.Name = "txtDescProd";
            this.txtDescProd.Size = new System.Drawing.Size(264, 26);
            this.txtDescProd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(21, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor Unitário";
            // 
            // txtCodProd
            // 
            this.txtCodProd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "CodProd", true));
            this.txtCodProd.Enabled = false;
            this.txtCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtCodProd.Location = new System.Drawing.Point(215, 37);
            this.txtCodProd.MaxLength = 5;
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(80, 26);
            this.txtCodProd.TabIndex = 0;
            this.txtCodProd.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(21, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 26);
            this.label8.TabIndex = 6;
            this.label8.Text = "Descrição do Produto";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(21, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 26);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nome do Fornecedor";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(21, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Quantidade Estoque";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(21, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quantidade Mínima";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(21, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantidade Máxima";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(21, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo do Produto";
            // 
            // grpNavegacao
            // 
            this.grpNavegacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpNavegacao.Controls.Add(this.btnUltimo);
            this.grpNavegacao.Controls.Add(this.btnProximo);
            this.grpNavegacao.Controls.Add(this.btnAnterior);
            this.grpNavegacao.Controls.Add(this.btnPrimeiro);
            this.grpNavegacao.Location = new System.Drawing.Point(79, 423);
            this.grpNavegacao.Name = "grpNavegacao";
            this.grpNavegacao.Size = new System.Drawing.Size(501, 74);
            this.grpNavegacao.TabIndex = 3;
            this.grpNavegacao.TabStop = false;
            this.grpNavegacao.Text = "Navegações";
            // 
            // btnUltimo
            // 
            this.btnUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnUltimo.Location = new System.Drawing.Point(324, 19);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(58, 49);
            this.btnUltimo.TabIndex = 3;
            this.btnUltimo.Text = ">|";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.BtnUltimo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnProximo.Location = new System.Drawing.Point(222, 19);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(58, 49);
            this.btnProximo.TabIndex = 2;
            this.btnProximo.Text = ">";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnAnterior.Location = new System.Drawing.Point(146, 19);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(58, 49);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnPrimeiro.Location = new System.Drawing.Point(46, 19);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(58, 49);
            this.btnPrimeiro.TabIndex = 0;
            this.btnPrimeiro.Text = "|<";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.BtnPrimeiro_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnFechar.Location = new System.Drawing.Point(696, 423);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(159, 68);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(908, 509);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.grpNavegacao);
            this.Controls.Add(this.grpDados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornProdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            this.grpNavegacao.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.TextBox txtQtdeMaxima;
        private System.Windows.Forms.TextBox txtQtdeMinima;
        private System.Windows.Forms.TextBox txtQtdeEstoque;
        private System.Windows.Forms.TextBox txtDescProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboRazaoSocial;
        private System.Windows.Forms.GroupBox grpNavegacao;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnFechar;
        private FornProdDataSet fornProdDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private FornProdDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private FornProdDataSetTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
    }
}

