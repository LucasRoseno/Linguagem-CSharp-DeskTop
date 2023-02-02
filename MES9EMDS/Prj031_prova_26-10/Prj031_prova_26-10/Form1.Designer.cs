namespace Prj031_prova_26_10
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRazaoFornec = new System.Windows.Forms.TextBox();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornProdDataSet = new Prj031_prova_26_10.FornProdDataSet();
            this.txtCodFornec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnProx = new System.Windows.Forms.Button();
            this.btnAnter = new System.Windows.Forms.Button();
            this.btnPrim = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fornecedoresTableAdapter = new Prj031_prova_26_10.FornProdDataSetTableAdapters.FornecedoresTableAdapter();
            this.tableAdapterManager = new Prj031_prova_26_10.FornProdDataSetTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornProdDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRazaoFornec);
            this.groupBox1.Controls.Add(this.txtCodFornec);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(88, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Cadastrais";
            // 
            // txtRazaoFornec
            // 
            this.txtRazaoFornec.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "RazaoSocial", true));
            this.txtRazaoFornec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtRazaoFornec.Location = new System.Drawing.Point(201, 88);
            this.txtRazaoFornec.Name = "txtRazaoFornec";
            this.txtRazaoFornec.Size = new System.Drawing.Size(329, 26);
            this.txtRazaoFornec.TabIndex = 3;
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "Fornecedores";
            this.fornecedoresBindingSource.DataSource = this.fornProdDataSet;
            // 
            // fornProdDataSet
            // 
            this.fornProdDataSet.DataSetName = "FornProdDataSet";
            this.fornProdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCodFornec
            // 
            this.txtCodFornec.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "CodFornec", true));
            this.txtCodFornec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtCodFornec.Location = new System.Drawing.Point(207, 38);
            this.txtCodFornec.Name = "txtCodFornec";
            this.txtCodFornec.Size = new System.Drawing.Size(183, 26);
            this.txtCodFornec.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label3.Location = new System.Drawing.Point(15, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome do Fornecedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.Location = new System.Drawing.Point(29, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cod do Fornecedor:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUltimo);
            this.groupBox2.Controls.Add(this.btnProx);
            this.groupBox2.Controls.Add(this.btnAnter);
            this.groupBox2.Controls.Add(this.btnPrim);
            this.groupBox2.Location = new System.Drawing.Point(88, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Navegação";
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(517, 20);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(59, 56);
            this.btnUltimo.TabIndex = 3;
            this.btnUltimo.Text = ">|";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.BtnUltimo_Click);
            // 
            // btnProx
            // 
            this.btnProx.Location = new System.Drawing.Point(331, 20);
            this.btnProx.Name = "btnProx";
            this.btnProx.Size = new System.Drawing.Size(59, 56);
            this.btnProx.TabIndex = 2;
            this.btnProx.Text = ">";
            this.btnProx.UseVisualStyleBackColor = true;
            this.btnProx.Click += new System.EventHandler(this.BtnProx_Click);
            // 
            // btnAnter
            // 
            this.btnAnter.Location = new System.Drawing.Point(201, 19);
            this.btnAnter.Name = "btnAnter";
            this.btnAnter.Size = new System.Drawing.Size(59, 56);
            this.btnAnter.TabIndex = 1;
            this.btnAnter.Text = "<";
            this.btnAnter.UseVisualStyleBackColor = true;
            this.btnAnter.Click += new System.EventHandler(this.BtnAnter_Click);
            // 
            // btnPrim
            // 
            this.btnPrim.Location = new System.Drawing.Point(53, 20);
            this.btnPrim.Name = "btnPrim";
            this.btnPrim.Size = new System.Drawing.Size(59, 56);
            this.btnPrim.TabIndex = 0;
            this.btnPrim.Text = "|<";
            this.btnPrim.UseVisualStyleBackColor = true;
            this.btnPrim.Click += new System.EventHandler(this.BtnPrim_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExcluir);
            this.groupBox3.Controls.Add(this.btnEditar);
            this.groupBox3.Controls.Add(this.btnGravar);
            this.groupBox3.Controls.Add(this.btnNovo);
            this.groupBox3.Location = new System.Drawing.Point(88, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(693, 82);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operações";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(537, 19);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(95, 43);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(384, 19);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(95, 43);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(229, 19);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(95, 43);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(33, 19);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(95, 43);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(356, 428);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(153, 65);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(322, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cadastro de Fornecedores";
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FornecedoresTableAdapter = this.fornecedoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = Prj031_prova_26_10.FornProdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornProdDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnProx;
        private System.Windows.Forms.Button btnAnter;
        private System.Windows.Forms.Button btnPrim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtRazaoFornec;
        private System.Windows.Forms.TextBox txtCodFornec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private FornProdDataSet fornProdDataSet;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private FornProdDataSetTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private FornProdDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

