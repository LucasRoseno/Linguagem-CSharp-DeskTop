using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj010_Lucas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblDia.Text = DateTime.Now.ToString("dddd");

            cboInstrucao.Items.Add("Ens. Fundamental Incompleto");
            cboInstrucao.Items.Add("Ens. Fundamental Completo");
            cboInstrucao.Items.Add("Ensino Médio Incompleto");
            cboInstrucao.Items.Add("Ensino Médio Completo");
            cboInstrucao.Items.Add("Ensino Superior Incompleto");
            cboInstrucao.Items.Add("Ensino Superior Completo");
            cboInstrucao.Items.Add("Pós Graduação");
        }

        private void CboInstrucao_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    e.KeyChar = (char)0;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            dtpDataNascto.Text = DateTime.Now.ToString("dd/MM/yyyy");
            rdoMasc.Checked = true;
            cboInstrucao.Text = "Selecione...";
            chkLer.Checked = false;
            chkCaminhar.Checked = false;
            chkViajar.Checked = false;
            chkDancar.Checked = false;
            chkNadar.Checked = false;
            chkCantar.Checked = false;
            lstResposta.Items.Clear();
            txtNome.Focus();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
     

            lstResposta.Items.Clear();
            if (txtNome.Text == "")
            {
                MessageBox.Show("Digite o nome!!", "Atenção");
                txtNome.Focus();
                return;
            }
            
            lstResposta.Items.Add(txtNome.Text);

            DateTime dataAtual = Convert.ToDateTime(lblData.Text);
            DateTime dataNascimento = Convert.ToDateTime(dtpDataNascto.Text);

            if (dataNascimento >= dataAtual) {
                MessageBox.Show("Data Nascimento incorreta!!!", "ATENÇÃO");
                dtpDataNascto.Focus();
                return;
            }
            lstResposta.Items.Add(dtpDataNascto.Text);

            if (cboInstrucao.Text == "Selecione....")
            {
                MessageBox.Show("Selecione o grau de instrução!!", "Atenção");
                cboInstrucao.Focus();
                return;
            }
            lstResposta.Items.Add(cboInstrucao.Text);
            if (rdoMasc.Checked == true)
            {
                lstResposta.Items.Add("Sexo Masculino");
            } else
            {
               lstResposta.Items.Add("Sexo Feminino");
            }

            lstResposta.Items.Add("----------------------");

            lstResposta.Items.Add("Preferências Pessoais são:");
            if (chkLer.Checked == true)
             lstResposta.Items.Add("Ler"); 
            if (chkCaminhar.Checked == true)
                lstResposta.Items.Add("Caminhar"); 
            if (chkViajar.Checked == true)
            lstResposta.Items.Add("Viajar");
            if (chkDancar.Checked == true)
                lstResposta.Items.Add("Dançar"); 
            if (chkNadar.Checked == true)
                lstResposta.Items.Add("Nadar"); 
            if (chkCantar.Checked == true)
                lstResposta.Items.Add("Cantar"); 
        }

        private void CboInstrucao_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;

        }
    }
}