using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj031_prova_26_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fornProdDataSet.Fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.fornProdDataSet.Fornecedores);
           
            
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            this.fornecedoresBindingSource.MoveLast();
        }

        private void BtnProx_Click(object sender, EventArgs e)
        {
            this.fornecedoresBindingSource.MoveNext();
        }

        private void BtnAnter_Click(object sender, EventArgs e)
        {
            this.fornecedoresBindingSource.MovePrevious();
        }

        private void BtnPrim_Click(object sender, EventArgs e)
        {
            this.fornecedoresBindingSource.MoveFirst();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Destravar();
            txtCodFornec.Focus();
            fornecedoresBindingSource.AddNew();
        }


        private void Destravar()
        {
           //Destrava as caixas de texto
            foreach (Control Controle in groupBox1.Controls)
            {
                if (Controle is TextBox)
                {
                    Controle.Enabled = true;
                }
            }
          
            //Travar botões
            groupBox3.Enabled = true;
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            //Falta implementar rotina para testar os campos de entrada!!!
            try
            {
                fornecedoresBindingSource.EndEdit();
                //Atualiza fisicamente o BD
                fornecedoresTableAdapter.Update(fornProdDataSet.Fornecedores);
                MessageBox.Show("Gravação efetuada com sucesso!!", "Mensagem");
                fornecedoresBindingSource.MoveFirst();
            }
            catch
            {
                MessageBox.Show("Erro Gravação!!", "ATENÇÃO");
            }
            Travar();
        }
        //Procedimento para travar controles
        private void Travar()
        {
            //Travar as caixas de texto
            foreach (Control Controle in groupBox3.Controls)
            {
                if (Controle is TextBox)
                {
                    Controle.Enabled = false;
                }
            }
           

            //Destravar botões
            groupBox2.Enabled = true;
            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Destravar();
            txtCodFornec.Enabled = false;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma exclusão do fornecedor??", "ATENÇÃO",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                fornecedoresBindingSource.RemoveCurrent();
                fornecedoresTableAdapter.Update(fornProdDataSet.Fornecedores);
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
