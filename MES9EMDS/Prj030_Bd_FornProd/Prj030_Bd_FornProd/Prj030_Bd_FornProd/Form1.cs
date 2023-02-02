using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj030_Bd_FornProd
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fornProdDataSet.Fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.fornProdDataSet.Fornecedores);
            // TODO: esta linha de código carrega dados na tabela 'fornProdDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.fornProdDataSet.Produtos);

        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            this.produtosBindingSource.MoveNext();
            //OBS: O this é opcional, mas agiliza o processo de digitação.
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            this.produtosBindingSource.MovePrevious();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            this.produtosBindingSource.MoveLast();
        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            this.produtosBindingSource.MoveFirst();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Destravar();
            txtCodProd.Focus();
            produtosBindingSource.AddNew();
        }

        private void Destravar()
        {
            //Destrava as caixas de texto
            foreach (Control Controle in grpDados.Controls)
            {
                if (Controle is TextBox)
                {
                    Controle.Enabled = true;
                }
            }
            cboRazaoSocial.Enabled = true;
            //Travar botões
            grpNavegacao.Enabled = false;
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnListar.Enabled = false;
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {

            int qtde_Estoque = int.Parse(txtQtdeEstoque.Text);
            int qtde_Max = int.Parse(txtQtdeMaxima.Text);
            int qtde_Min = int.Parse(txtQtdeMinima.Text);
            int valUnit = int.Parse(txtValorUnitario.Text);
            var razaoSocial = cboRazaoSocial.Text;

            if(qtde_Estoque>=0 && qtde_Max>=qtde_Estoque ||
                qtde_Max < qtde_Min || valUnit>0 || razaoSocial == "")
            {
                MessageBox.Show("A rotina não permite voce gravar nessas circunstâncias", "ATENÇÃO");
            }
            else
            {
                //Falta implementar rotina para testar os campos de entrada!!!
                try
                {
                    produtosBindingSource.EndEdit();
                    //Atualiza fisicamente o BD
                    produtosTableAdapter.Update(fornProdDataSet.Produtos);
                    MessageBox.Show("Gravação efetuada com sucesso!!", "Mensagem");
                    produtosBindingSource.MoveFirst();
                }
                catch
                {
                    MessageBox.Show("Erro Gravação!!", "ATENÇÃO");
                }
                Travar();


            }
          
        }
        //Procedimento para travar controles
        private void Travar()
        {
            //Travar as caixas de texto
            foreach (Control Controle in grpDados.Controls)
            {
                if (Controle is TextBox)
                {
                    Controle.Enabled = false;
                }
            }
            cboRazaoSocial.Enabled = false;

            //Destravar botões
            grpNavegacao.Enabled = true;
            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnListar.Enabled = true;


        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Destravar();
            txtCodProd.Enabled = false;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            int estoq = int.Parse(txtQtdeEstoque.Text);
            if(estoq== 0)
            {
                if (MessageBox.Show("Confirma exclusão do produto??", "ATENÇÃO",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    produtosBindingSource.RemoveCurrent();
                    produtosTableAdapter.Update(fornProdDataSet.Produtos);
                }
            }
            else
            {
                MessageBox.Show("O estoque ainda possui itens, ao acabar", "ATENÇÃO");
                txtQtdeEstoque.Focus();
            }




            
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            FrmListar MeuListar = new FrmListar();
            MeuListar.ShowDialog();

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
