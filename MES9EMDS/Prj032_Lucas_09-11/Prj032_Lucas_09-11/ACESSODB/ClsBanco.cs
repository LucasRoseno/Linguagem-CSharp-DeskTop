using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Prj032_Lucas_09_11.ACESSODB
{



    class ClsBanco
    {
        //Declaração da "variável" que contém informações
        //sobre o Banco de Dados: tipo, nome, caminho...
        string strConexao = Properties.Settings.Default.ConexaoBD;
        // ConexaoBD --> Projetos -->Propriedades -> Configuracao
        //Declaração da "variável" (objeto) de Conexão
        OleDbConnection conn = null;

        private int codUsuario;
        private int senha;
        private string nomeUsuario;

        public int CodUsuario { get => codUsuario; set => codUsuario = value; }
        public int Senha { get => senha; set => senha = value; }
        public string NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }
        OleDbCommand comando = new OleDbCommand();

        public ClsBanco() {

            conn = new OleDbConnection(strConexao);

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o arquivo: " + ex.ToString(), "ATENÇÃO");
            }

        }

        public int Gravar()
        {
            // Falta a validar as caixas textbox !!!!!!!!!!!!!!!!!!

            comando.CommandType = CommandType.Text;

            //declaração dos parametros/variáveis que serão utilizadas
            //no comando SQL. Os parâmetros recebem os dados dos Gets

            comando.Parameters.Add("@varCodigo", oleDbType: OleDbType.Integer).Value = codUsuario;
            comando.Parameters.Add("@varSenha", oleDbType: OleDbType.Integer).Value = senha;

            comando.Parameters.Add("varNome", oleDbType: OleDbType.VarChar, 50).Value = nomeUsuario;

            comando.CommandText = "Insert into tblUsuario (CodUsuario,Senha,NomeUsuario)" +
                " values (@varCodigo, @varSenha,@varNome)";

            comando.Connection = conn;

            //Executa a instrução
            int status = comando.ExecuteNonQuery();

            conn.Close();
            return status;

        }

        public DataTable ConsultarDados(byte tipoConsulta, int codigo, string Nome)
        {
            string strSql = "Select * from tblUsuario";

            if (tipoConsulta == 2)
            {
                //declaração dos parametros/variáveis que serão utilizadas
                //no comando SQL

                comando.Parameters.Add("@varCodigo", oleDbType: OleDbType.Integer).Value = codigo;
                strSql += " where CodUsuario = @varCodigo";
            }
            else if (tipoConsulta == 3)
            {

                comando.Parameters.Add("@varNome", oleDbType: OleDbType.VarChar, 50).Value = "%" + nomeUsuario + "%";
                strSql += " where NomeUsuario like @varNome";

            }
            strSql += " order by CodUsuario";
            comando.CommandType = CommandType.Text;
            comando.CommandText = strSql;
            comando.Connection = conn;

            DataSet MyDataSet = new DataSet();

            //cria e executa o comando SQL para preencher o Dateset
            OleDbDataAdapter MyAdapter = new OleDbDataAdapter(comando);
            MyAdapter.Fill(MyDataSet, "tabelaDataSet");
            // tabelaDataSet ----> tabela virtual
            conn.Close();
            return MyDataSet.Tables["tabelaDataSet"];



        }


        public int Alterar()
        {

            comando.CommandType = CommandType.Text;

            comando.Parameters.Add("@varSenha", oleDbType: OleDbType.Integer).Value = senha;
            comando.Parameters.Add("@varNome", oleDbType: OleDbType.VarChar, 50).Value = nomeUsuario;
            comando.Parameters.Add("@varCodigo", oleDbType: OleDbType.Integer).Value = codUsuario;

            comando.CommandText = "Update tblUsuario set Senha = @varSenha," +
                " NomeUsuario = @varNome" +
                " where CodUsuario = @varCodigo ";

            comando.Connection = conn;
            int status = comando.ExecuteNonQuery();
            conn.Close();
            return status;
        }

        public int Excluir()
        {

            comando.CommandType = CommandType.Text;
           
            comando.Parameters.Add("@varCodigo", oleDbType: OleDbType.Integer).Value = codUsuario;
            
            comando.CommandText = "Delete from tblUsuario where CodUsuario = @varCodigo";
            comando.Connection = conn;
            
            int status = comando.ExecuteNonQuery();
            //Fecha o banco
            conn.Close();
            return status;
        }

    }





}
