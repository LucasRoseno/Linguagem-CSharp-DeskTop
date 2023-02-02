using Prj032_Lucas_09_11.ACESSODB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj032_Lucas_09_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            ClsBanco objBanco = new ClsBanco();

            //Transfere os dados das caixas de texto para as propriedades
            //sets da classe
            objBanco.CodUsuario = Convert.ToInt32(txtCodUsuario.Text);
            objBanco.NomeUsuario = txtNomeUsuario.Text;
            objBanco.Senha = Convert.ToInt32(txtSenhaUsuario.Text);

            int status = objBanco.Gravar();
            if(status != 0)
            {
                MessageBox.Show("Gravação bem sucedida!!", "SUCESSO");
            }
            else
            {
                MessageBox.Show("Erro na gravação!!", "*** ERRO ***");
            }
            LimparCampos();

            
        }
        private void LimparCampos()
        {
            txtCodUsuario.Text = "";
            txtNomeUsuario.Text = "";
            txtSenhaUsuario.Text = "";
            txtCodUsuario.Focus();
        }

        private void BtnConsulta_Click(object sender, EventArgs e)

        {
            //Observe o parametro "This" ao final. Indica que estamos transferindo o formulário atual (FrmUsuarios) como
            //parametro para o formulário "FrmConsulta". No momento da escrita desta instrução um erro será sinalizado
            //pois, no momento, o FrmConsulta não está "preparado" para receber dados de parametro. Esta implementação do
            //parametro será feita logo em seguida no próprio formulário FrmConsulta
            FrmConsulta MyFrmConsulta = new FrmConsulta(this);
            MyFrmConsulta.ShowDialog();

        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            ClsBanco objBanco = new ClsBanco();

            objBanco.CodUsuario = Convert.ToInt32(txtCodUsuario.Text);
            objBanco.Senha = Convert.ToInt32(txtSenhaUsuario.Text);
            objBanco.NomeUsuario = txtNomeUsuario.Text;

            int status = objBanco.Alterar();
            if(status != 0)
            {
                MessageBox.Show("Alteração bem sucedida!!", "SUCESSO");
            }
            else
            {
                MessageBox.Show("Erro na alteração dos dados!!", "*** ERRO ***");
            }
            LimparCampos();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            ClsBanco objBanco = new ClsBanco();


            objBanco.CodUsuario = Convert.ToInt32(txtCodUsuario.Text);

            int status;
            status = objBanco.Excluir();
            //Verifica o retorno da exclusão
            
            if (status != 0)
            {
                MessageBox.Show("Exclusão bem sucedida!!", "SUCESSO");
            }
            else
            {
                MessageBox.Show("Erro na exclusão do usuário!!", "***ERRO * **");
            }
            LimparCampos();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

