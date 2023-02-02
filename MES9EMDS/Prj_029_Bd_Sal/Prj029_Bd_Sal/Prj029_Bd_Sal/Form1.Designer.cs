namespace Prj029_Bd_Sal
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
            System.Windows.Forms.Label codigoFuncLabel;
            System.Windows.Forms.Label nomeFuncLabel;
            System.Windows.Forms.Label salarioFuncLabel;
            this.bancoSalDataSet = new Prj029_Bd_Sal.BancoSalDataSet();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionariosTableAdapter = new Prj029_Bd_Sal.BancoSalDataSetTableAdapters.FuncionariosTableAdapter();
            this.tableAdapterManager = new Prj029_Bd_Sal.BancoSalDataSetTableAdapters.TableAdapterManager();
            this.codigoFuncTextBox = new System.Windows.Forms.TextBox();
            this.nomeFuncTextBox = new System.Windows.Forms.TextBox();
            this.salarioFuncTextBox = new System.Windows.Forms.TextBox();
            this.btnSumSal = new System.Windows.Forms.Button();
            codigoFuncLabel = new System.Windows.Forms.Label();
            nomeFuncLabel = new System.Windows.Forms.Label();
            salarioFuncLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bancoSalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoFuncLabel
            // 
            codigoFuncLabel.AutoSize = true;
            codigoFuncLabel.Location = new System.Drawing.Point(136, 84);
            codigoFuncLabel.Name = "codigoFuncLabel";
            codigoFuncLabel.Size = new System.Drawing.Size(70, 13);
            codigoFuncLabel.TabIndex = 1;
            codigoFuncLabel.Text = "Codigo Func:";
            // 
            // nomeFuncLabel
            // 
            nomeFuncLabel.AutoSize = true;
            nomeFuncLabel.Location = new System.Drawing.Point(136, 110);
            nomeFuncLabel.Name = "nomeFuncLabel";
            nomeFuncLabel.Size = new System.Drawing.Size(65, 13);
            nomeFuncLabel.TabIndex = 3;
            nomeFuncLabel.Text = "Nome Func:";
            // 
            // salarioFuncLabel
            // 
            salarioFuncLabel.AutoSize = true;
            salarioFuncLabel.Location = new System.Drawing.Point(136, 136);
            salarioFuncLabel.Name = "salarioFuncLabel";
            salarioFuncLabel.Size = new System.Drawing.Size(69, 13);
            salarioFuncLabel.TabIndex = 5;
            salarioFuncLabel.Text = "Salario Func:";
            // 
            // bancoSalDataSet
            // 
            this.bancoSalDataSet.DataSetName = "BancoSalDataSet";
            this.bancoSalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "Funcionarios";
            this.funcionariosBindingSource.DataSource = this.bancoSalDataSet;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FuncionariosTableAdapter = this.funcionariosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Prj029_Bd_Sal.BancoSalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // codigoFuncTextBox
            // 
            this.codigoFuncTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "CodigoFunc", true));
            this.codigoFuncTextBox.Location = new System.Drawing.Point(212, 81);
            this.codigoFuncTextBox.Name = "codigoFuncTextBox";
            this.codigoFuncTextBox.Size = new System.Drawing.Size(56, 20);
            this.codigoFuncTextBox.TabIndex = 2;
            // 
            // nomeFuncTextBox
            // 
            this.nomeFuncTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "NomeFunc", true));
            this.nomeFuncTextBox.Location = new System.Drawing.Point(212, 107);
            this.nomeFuncTextBox.MaxLength = 50;
            this.nomeFuncTextBox.Name = "nomeFuncTextBox";
            this.nomeFuncTextBox.Size = new System.Drawing.Size(208, 20);
            this.nomeFuncTextBox.TabIndex = 4;
            // 
            // salarioFuncTextBox
            // 
            this.salarioFuncTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "SalarioFunc", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.salarioFuncTextBox.Location = new System.Drawing.Point(212, 133);
            this.salarioFuncTextBox.Name = "salarioFuncTextBox";
            this.salarioFuncTextBox.Size = new System.Drawing.Size(208, 20);
            this.salarioFuncTextBox.TabIndex = 6;
            // 
            // btnSumSal
            // 
            this.btnSumSal.Location = new System.Drawing.Point(124, 226);
            this.btnSumSal.Name = "btnSumSal";
            this.btnSumSal.Size = new System.Drawing.Size(117, 64);
            this.btnSumSal.TabIndex = 7;
            this.btnSumSal.Text = "Soma de todos os salarios";
            this.btnSumSal.UseVisualStyleBackColor = true;
            this.btnSumSal.Click += new System.EventHandler(this.BtnSumSal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSumSal);
            this.Controls.Add(codigoFuncLabel);
            this.Controls.Add(this.codigoFuncTextBox);
            this.Controls.Add(nomeFuncLabel);
            this.Controls.Add(this.nomeFuncTextBox);
            this.Controls.Add(salarioFuncLabel);
            this.Controls.Add(this.salarioFuncTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancoSalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BancoSalDataSet bancoSalDataSet;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private BancoSalDataSetTableAdapters.FuncionariosTableAdapter funcionariosTableAdapter;
        private BancoSalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox codigoFuncTextBox;
        private System.Windows.Forms.TextBox nomeFuncTextBox;
        private System.Windows.Forms.TextBox salarioFuncTextBox;
        private System.Windows.Forms.Button btnSumSal;
    }
}

