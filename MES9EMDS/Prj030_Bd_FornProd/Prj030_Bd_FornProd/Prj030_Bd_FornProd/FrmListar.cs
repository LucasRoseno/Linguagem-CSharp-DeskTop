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
    public partial class FrmListar : Form
    {
        public FrmListar()
        {
            InitializeComponent();
        }

        private void FrmListar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fornProdDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.fornProdDataSet.Produtos);

        }

        private void BtnFecharList_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnListarGeral_Click(object sender, EventArgs e)
        {
            this.produtosTableAdapter.Fill(this.fornProdDataSet.Produtos);

        }

        private void BtnListarCompra_Click(object sender, EventArgs e)
        {
            this.produtosTableAdapter.FillByComprar(this.fornProdDataSet.Produtos);

            if(produtosBindingSource.Count == 0)
            {

                MessageBox.Show("Não existem produtos abaixo do estoque!!!", "ATENÇÃO");
            }
        }

        private void TxtDescricao_TextChanged(object sender, EventArgs e)
        {
            this.produtosTableAdapter.FillByConsultaRapida(this.fornProdDataSet.Produtos,
                "%" + txtDescricao.Text + "%");
        }
    }
}
