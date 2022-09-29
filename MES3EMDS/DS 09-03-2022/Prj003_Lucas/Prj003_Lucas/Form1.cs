using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj003_Lucas
{
    public partial class FrmExe003 : Form
    {
        public FrmExe003()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muito Obrigado!!", "Volte Sempre");
            Application.Exit();
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblResposta_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnExibir_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text == "")
            {
                MessageBox.Show("Você NÃO digitou seu nome", "CUIDADO");
                TxtNome.Focus();
            }
            else { 
                LblResposta.Text = TxtNome.Text;
                BtnLimpar.Enabled = true;
                BtnExibir.Enabled = false;
            }


        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LblResposta.Text = "";
            TxtNome.Text = "";
            BtnLimpar.Enabled = false;
            BtnExibir.Enabled = true;
            TxtNome.Focus();
        }
    }
}
