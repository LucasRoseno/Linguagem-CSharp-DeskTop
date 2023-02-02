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
    public partial class FrmConsulta : Form
    {

        Form1 instanciaDoForm1 = new Form1();


        public FrmConsulta(Form1 frm1)
        {
            InitializeComponent();
            instanciaDoForm1 = frm1;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            //Gera a instancia da classe "ClsBanco".
            //Neste momento o construtor é executado e o banco aberto
            ClsBanco objBanco = new ClsBanco();

            byte tipoConsulta = 1;

            if(RdoCodigo.Checked == true)
            {
                tipoConsulta = 2;
                txtNome.Text = "";

            }else if(RdoNome.Checked == true){
                tipoConsulta = 3;
                txtCodigo.Text = "";
            }

            int codigo;
            try
            {
                codigo = Convert.ToInt32(txtCodigo.Text);
            }
            catch (Exception)
            {
                codigo = 0;
            }

            //OBS: No momento em que a instrução abaixo é digitada um erro ocorrerá, informando que o método "ConsultarDados"
            //não existe. O método poderá ser criado pelo próprio Visual Studio e "ajustado" manualmente

            DgvLista.DataSource = objBanco.ConsultarDados(tipoConsulta, codigo, txtNome.Text);

            if(DgvLista.RowCount == 0)
            {
                MessageBox.Show("Nenhum usuario encontrado!!", "Atenção");
            }
        }

        private void DgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //importante: No Form1 (FrmUsuarios) precisamos alterar as propriedades
            //MODIFIERS dos textbox para public para permissão de acesso

            instanciaDoForm1.txtCodUsuario.Text = DgvLista.CurrentRow.Cells[0].Value.ToString();
            instanciaDoForm1.txtSenhaUsuario.Text = DgvLista.CurrentRow.Cells[1].Value.ToString();
            instanciaDoForm1.txtNomeUsuario.Text = DgvLista.CurrentRow.Cells[2].Value.ToString();

            this.Close();
        }
    }
}
