using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convert_UmaCamada_for_DuasCamadas
{
    public partial class Form1 : Form
    {

        string strConexao = Properties.Settings.Default.ConexaoBD;
        string strSql = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            //Falta validar se o codigo do produto foi digitado e se é numérico!!
            int varCodProduto = Convert.ToInt32(TxtCodProduto.Text);
            //cria a conexão com o banco de dados
            OleDbConnection conexao = new OleDbConnection(strConexao);
            //define a instrução SQL
            strSql = "SELECT Produtos.CodProd, Produtos.Descricao, " +
            " Produtos.QtdeMaxima, Produtos.QtdeEstoque " +
            "FROM Produtos " +
            "Where Produtos.CodProd = " + varCodProduto;
            //exibe a instrução SQL para testes iniciais, para conferência do comando....
            // MessageBox.Show(strSql);
            //cria o objeto command para executar a instruçao sql
            OleDbCommand comando = new OleDbCommand(strSql, conexao);
            //abre a conexao
            conexao.Open();
            //define o tipo do comando
            comando.CommandType = CommandType.Text;

            //cria o objeto DataReader e executa o comando SQL
            OleDbDataReader myDataReader = comando.ExecuteReader();
            //Realiza a leitura do DataReader. Isto se faz necessário para que os dados nele armanezados
            //possam ser manipulados
            myDataReader.Read();
            //Se o comando de leitura retornou com algum registro, exibe os dados, caso contrário, exibe mensagem
            //de alerta
            if (myDataReader.HasRows)
            {
                LblDescricao.Text = myDataReader["Descricao"].ToString();
                LblEstoque.Text = myDataReader["QtdeEstoque"].ToString();
                LblMax.Text = myDataReader["QtdeMaxima"].ToString();
            }
            else
            {
                MessageBox.Show("Produto não localizado!!", "ATENÇÃO");
                TxtCodProduto.Text = "";
                TxtCodProduto.Focus();
            }
            //Fecha a conexao
            conexao.Close();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {//Neste procedimento falta implementar testes no TxtQuentidade para validar dado numérico e > 0
         //Falta também validar se após a entrada de mercadoria em estoque, se o estoque atualizado é maior que
         //a QtdeMaxima - isto não pode ocorrer
         //Falta verificar também se após a saída de mercadoria em estoque, se o estoque atualizado é negativo
         //isto não pode ocorrer!!
            int estoqueAtual = Convert.ToInt32(LblEstoque.Text);
            int qtdeEntrada = Convert.ToInt32(TxtQuantidade.Text);
            int estoqueAtualizado = 0;
            if (RdbEntrada.Checked == true)
            {
                estoqueAtualizado = estoqueAtual + qtdeEntrada;
            }
            else
            {
                estoqueAtualizado = estoqueAtual - qtdeEntrada;
            }
            //rotina para atualizar o estoque na base de dados
            //cria a conexão com o banco de dados. A variável strConexao está declarada na área de
            //variáveis globais - no início desta programação
            OleDbConnection conexao = new OleDbConnection(strConexao);

            //define a instrução SQL
            strSql = "UPDATE Produtos set QtdeEstoque=" + estoqueAtualizado + " where CodProd= " + TxtCodProduto.Text;
            //Instrução apenas para consulta ao comando SQL
            //MessageBox.Show(strSql);
            //Cria o comando que inicia a query
            OleDbCommand cmdQry = new OleDbCommand(strSql, conexao);
            // abre o banco
            conexao.Open();
            // executa a query
            cmdQry.ExecuteNonQuery();
            //
            MessageBox.Show("Dados Salvos com sucesso.");
            //fecha a conexao
            conexao.Close();
            //Limpar o formulário
            TxtCodProduto.Text = "";
            LblDescricao.Text = "";
            LblEstoque.Text = "";
            LblMax.Text = "";
            TxtQuantidade.Text = "";
            RdbEntrada.Checked = true;
            TxtCodProduto.Focus();

        }
    }
}
