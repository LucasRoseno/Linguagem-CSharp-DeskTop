using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj002_Lucas
{
    public partial class FrmExe002 : Form
    {
        public FrmExe002()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmExe002_Load(object sender, EventArgs e)
        {

        }

        private void BtnMensagem1_Click(object sender, EventArgs e)
        {
            LblMensagem.Text = "Se você não faz o que gosta.... Clique no botão \"Mensagem2\"";
            BtnMensagem2.Enabled = true;
            BtnMensagem1.Enabled = false;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMensagem2_Click(object sender, EventArgs e)
        {
            LblMensagem.Text = "Aprenda a gostar do que faz.... Será melhor para \n você!! Volte agora para a \"Mensagem 1\".";
            BtnMensagem1.Enabled = true;
            BtnMensagem2.Enabled = false;
        }
    }
}
