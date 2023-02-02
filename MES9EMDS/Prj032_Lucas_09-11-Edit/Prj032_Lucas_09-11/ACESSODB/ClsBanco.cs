using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
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
        
        SqlConnection conn = null;

        private int codUsuario;
        private int senha;
        private string nomeUsuario;

        public int CodUsuario { get => codUsuario; set => codUsuario = value; }
        public int Senha { get => senha; set => senha = value; }
        public string NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }
        SqlCommand comando = new SqlCommand();

        public ClsBanco() {

            conn = new SqlConnection(strConexao);

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

            comando.Parameters.Add("@varCodigo",  SqlDbType.Int).Value = codUsuario;
            comando.Parameters.Add("@varSenha",  SqlDbType.Int).Value = senha;

            comando.Parameters.Add("varNome", SqlDbType.VarChar, 50).Value = nomeUsuario;

            comando.CommandText = "Insert into Usuarios (CodUsuario,Senha,NomeUsuario)" +
                " values (@varCodigo, @varSenha,@varNome)";

            comando.Connection = conn;

            //Executa a instrução
            int status = comando.ExecuteNonQuery();

            conn.Close();
            return status;

        }

        public DataTable ConsultarDados(byte tipoConsulta, int codigo, string Nome)
        {
            string strSql = "Select * from Usuarios";

            if (tipoConsulta == 2)
            {
                //declaração dos parametros/variáveis que serão utilizadas
                //no comando SQL

                comando.Parameters.Add("@varCodigo", SqlDbType.Int).Value = codigo;
                strSql += " where CodUsuario = @varCodigo";
            }
            else if (tipoConsulta == 3)
            {

                comando.Parameters.Add("@varNome",  SqlDbType.VarChar, 50).Value = "%" + nomeUsuario + "%";
                strSql += " where NomeUsuario like @varNome";

            }
            strSql += " order by CodUsuario";
            comando.CommandType = CommandType.Text;
            comando.CommandText = strSql;
            comando.Connection = conn;

            DataSet MyDataSet = new DataSet();

            //cria e executa o comando SQL para preencher o Dateset
            SqlDataAdapter MyAdapter = new SqlDataAdapter(comando);
            MyAdapter.Fill(MyDataSet, "tabelaDataSet");
            // tabelaDataSet ----> tabela virtual
            conn.Close();
            return MyDataSet.Tables["tabelaDataSet"];



        }


        public int Alterar()
        {

            comando.CommandType = CommandType.Text;

            comando.Parameters.Add("@varSenha", SqlDbType.Int).Value = senha;
            comando.Parameters.Add("@varNome",  SqlDbType.VarChar, 50).Value = nomeUsuario;
            comando.Parameters.Add("@varCodigo",  SqlDbType.Int).Value = codUsuario;

            comando.CommandText = "Update Usuarios set Senha = @varSenha," +
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
           
            comando.Parameters.Add("@varCodigo", SqlDbType.Int).Value = codUsuario;
            
            comando.CommandText = "Delete from Usuarios where CodUsuario = @varCodigo";
            comando.Connection = conn;
            
            int status = comando.ExecuteNonQuery();
            //Fecha o banco
            conn.Close();
            return status;
        }

    }





}
