using Prj027_Lucas_ClasseAbstratas.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj027_Lucas_ClasseAbstratas.Formulario
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIncluirp_Click(object sender, EventArgs e)
        {
            ClsProfessor ObjProfessor = new ClsProfessor();
            ObjProfessor.Cpf = txtCpfp.Text;
            ObjProfessor.Nome = txtNomep.Text;
            ObjProfessor.Licenciatura = txtLicenciaturap.Text;
            ObjProfessor.Endereco = txtEnderecop.Text;
            ObjProfessor.Categoria = txtCategoriap.Text;

            lblMostrar.Text = ObjProfessor.Incluir();

        }

        private void BtnExcluirp_Click(object sender, EventArgs e)
        {
            ClsProfessor ObjProfessor = new ClsProfessor();

            if(txtCpfp.Text != "")
            {
                ObjProfessor.Cpf = txtCpfp.Text;
                lblMostrar.Text = ObjProfessor.Excluir();
            }
            else
            {
                lblMostrar.Text = "ATENÇÃO: Digite o número do CPF para exclusão!! ";
            }
        }

        private void BtnIncluirA_Click(object sender, EventArgs e)
        {
            ClsAluno ObjAluno = new ClsAluno();

            ObjAluno.Nome = txtNomea.Text;
            ObjAluno.Cpf = txtCpfa.Text;
            ObjAluno.Endereco = txtEnderecoa.Text;
            ObjAluno.Turma = txtTurmaA.Text;
            ObjAluno.Curso = txtCursoa.Text;

            lblMostrar.Text = ObjAluno.Incluir();
        }

        private void BtnExcluira_Click(object sender, EventArgs e)
        {
            ClsAluno ObjAluno = new ClsAluno();

            if(txtCpfa.Text != "")
            {
                ObjAluno.Cpf = txtCpfa.Text;
                lblMostrar.Text = ObjAluno.Excluir();
            }
            else
            {
                lblMostrar.Text = "ATENÇÃO: Digite o número do CPF para exclusão!! ";
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0) {

                foreach ( TextBox CaixaTexto in groupA.Controls)
                {
                    CaixaTexto.Text = "";
                }

            }
            else
            {
                foreach(TextBox caixaTexto in groupP.Controls)
                {
                    caixaTexto.Text = "";
                }
            }
            lblMostrar.Text = "";
        }
    }
}
