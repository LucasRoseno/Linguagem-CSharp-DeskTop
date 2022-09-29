using Prj027_Lucas_ClasseAbstratas.Formulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj027_Lucas_ClasseAbstratas
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void MnuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MnuCadastro_Click(object sender, EventArgs e)
        {
            FrmCadastro MeuCadstro = new FrmCadastro();
            MeuCadstro.MdiParent = this;
            MeuCadstro.Show();
        }
    }
}
