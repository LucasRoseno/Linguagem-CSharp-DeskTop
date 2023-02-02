namespace Prj030_Bd_FornProd
{
    partial class FrmListar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnListarGeral = new System.Windows.Forms.Button();
            this.btnListarCompra = new System.Windows.Forms.Button();
            this.btnFecharList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codFornecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdesEstoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdesMinimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdesMaximaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornProdDataSet = new Prj030_Bd_FornProd.FornProdDataSet();
            this.produtosTableAdapter = new Prj030_Bd_FornProd.FornProdDataSetTableAdapters.ProdutosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornProdDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarGeral
            // 
            this.btnListarGeral.Location = new System.Drawing.Point(86, 364);
            this.btnListarGeral.Name = "btnListarGeral";
            this.btnListarGeral.Size = new System.Drawing.Size(111, 51);
            this.btnListarGeral.TabIndex = 0;
            this.btnListarGeral.Text = "Listar Geral";
            this.btnListarGeral.UseVisualStyleBackColor = true;
            this.btnListarGeral.Click += new System.EventHandler(this.BtnListarGeral_Click);
            // 
            // btnListarCompra
            // 
            this.btnListarCompra.Location = new System.Drawing.Point(293, 364);
            this.btnListarCompra.Name = "btnListarCompra";
            this.btnListarCompra.Size = new System.Drawing.Size(111, 51);
            this.btnListarCompra.TabIndex = 1;
            this.btnListarCompra.Text = "Listar Compra";
            this.btnListarCompra.UseVisualStyleBackColor = true;
            this.btnListarCompra.Click += new System.EventHandler(this.BtnListarCompra_Click);
            // 
            // btnFecharList
            // 
            this.btnFecharList.Location = new System.Drawing.Point(522, 364);
            this.btnFecharList.Name = "btnFecharList";
            this.btnFecharList.Size = new System.Drawing.Size(111, 51);
            this.btnFecharList.TabIndex = 2;
            this.btnFecharList.Text = "Fechar";
            this.btnFecharList.UseVisualStyleBackColor = true;
            this.btnFecharList.Click += new System.EventHandler(this.BtnFecharList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProdDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.codFornecDataGridViewTextBoxColumn,
            this.qtdesEstoqueDataGridViewTextBoxColumn,
            this.qtdesMinimaDataGridViewTextBoxColumn,
            this.qtdesMaximaDataGridViewTextBoxColumn,
            this.valorUnitarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produtosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(746, 276);
            this.dataGridView1.TabIndex = 3;
            // 
            // codProdDataGridViewTextBoxColumn
            // 
            this.codProdDataGridViewTextBoxColumn.DataPropertyName = "CodProd";
            this.codProdDataGridViewTextBoxColumn.HeaderText = "CodProd";
            this.codProdDataGridViewTextBoxColumn.Name = "codProdDataGridViewTextBoxColumn";
            this.codProdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codFornecDataGridViewTextBoxColumn
            // 
            this.codFornecDataGridViewTextBoxColumn.DataPropertyName = "CodFornec";
            this.codFornecDataGridViewTextBoxColumn.HeaderText = "CodFornec";
            this.codFornecDataGridViewTextBoxColumn.Name = "codFornecDataGridViewTextBoxColumn";
            this.codFornecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtdesEstoqueDataGridViewTextBoxColumn
            // 
            this.qtdesEstoqueDataGridViewTextBoxColumn.DataPropertyName = "QtdesEstoque";
            this.qtdesEstoqueDataGridViewTextBoxColumn.HeaderText = "QtdesEstoque";
            this.qtdesEstoqueDataGridViewTextBoxColumn.Name = "qtdesEstoqueDataGridViewTextBoxColumn";
            this.qtdesEstoqueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtdesMinimaDataGridViewTextBoxColumn
            // 
            this.qtdesMinimaDataGridViewTextBoxColumn.DataPropertyName = "QtdesMinima";
            this.qtdesMinimaDataGridViewTextBoxColumn.HeaderText = "QtdesMinima";
            this.qtdesMinimaDataGridViewTextBoxColumn.Name = "qtdesMinimaDataGridViewTextBoxColumn";
            this.qtdesMinimaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtdesMaximaDataGridViewTextBoxColumn
            // 
            this.qtdesMaximaDataGridViewTextBoxColumn.DataPropertyName = "QtdesMaxima";
            this.qtdesMaximaDataGridViewTextBoxColumn.HeaderText = "QtdesMaxima";
            this.qtdesMaximaDataGridViewTextBoxColumn.Name = "qtdesMaximaDataGridViewTextBoxColumn";
            this.qtdesMaximaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorUnitarioDataGridViewTextBoxColumn
            // 
            this.valorUnitarioDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitario";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.valorUnitarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.valorUnitarioDataGridViewTextBoxColumn.HeaderText = "ValorUnitario";
            this.valorUnitarioDataGridViewTextBoxColumn.Name = "valorUnitarioDataGridViewTextBoxColumn";
            this.valorUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
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
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.Location = new System.Drawing.Point(63, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Consulta Rápida: ";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtDescricao.Location = new System.Drawing.Point(213, 19);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(222, 26);
            this.txtDescricao.TabIndex = 5;
            this.txtDescricao.TextChanged += new System.EventHandler(this.TxtDescricao_TextChanged);
            // 
            // FrmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFecharList);
            this.Controls.Add(this.btnListarCompra);
            this.Controls.Add(this.btnListarGeral);
            this.MinimizeBox = false;
            this.Name = "FrmListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relação de Produtos";
            this.Load += new System.EventHandler(this.FrmListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornProdDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarGeral;
        private System.Windows.Forms.Button btnListarCompra;
        private System.Windows.Forms.Button btnFecharList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FornProdDataSet fornProdDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private FornProdDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFornecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdesEstoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdesMinimaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdesMaximaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
    }
}