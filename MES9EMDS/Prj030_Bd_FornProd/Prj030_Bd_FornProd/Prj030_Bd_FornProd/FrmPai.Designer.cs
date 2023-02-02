namespace Prj030_Bd_FornProd
{
    partial class FrmPai
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PagFornec = new System.Windows.Forms.TabPage();
            this.tabProd = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PagFornec);
            this.tabControl1.Controls.Add(this.tabProd);
            this.tabControl1.Location = new System.Drawing.Point(22, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(737, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // PagFornec
            // 
            this.PagFornec.Location = new System.Drawing.Point(4, 22);
            this.PagFornec.Name = "PagFornec";
            this.PagFornec.Padding = new System.Windows.Forms.Padding(3);
            this.PagFornec.Size = new System.Drawing.Size(729, 400);
            this.PagFornec.TabIndex = 0;
            this.PagFornec.Text = "Cadastro Do Fornecedor";
            this.PagFornec.UseVisualStyleBackColor = true;
            this.PagFornec.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // tabProd
            // 
            this.tabProd.Location = new System.Drawing.Point(4, 22);
            this.tabProd.Name = "tabProd";
            this.tabProd.Padding = new System.Windows.Forms.Padding(3);
            this.tabProd.Size = new System.Drawing.Size(729, 400);
            this.tabProd.TabIndex = 1;
            this.tabProd.Text = "Cadastro do Produto";
            this.tabProd.UseVisualStyleBackColor = true;
            // 
            // FrmPai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmPai";
            this.Text = "FrmPai";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PagFornec;
        private System.Windows.Forms.TabPage tabProd;
    }
}