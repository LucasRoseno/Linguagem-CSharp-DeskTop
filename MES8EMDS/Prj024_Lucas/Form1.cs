using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj024_Lucas
{
    public partial class btnLimpar : Form
    {
        public btnLimpar()
        {
            InitializeComponent();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            ClsClassificados ObjConsult = new ClsClassificados();
            try {
                int NumInscricao = Convert.ToInt32(txtEntrada.Text);

                lblMostrar.Text = ObjConsult.Consultar();

            } catch {
                lblMostrar.Text = "Insira apenas numeros";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ClsClassificados Limp = new ClsClassificados();
            lblMostrar.Text = Limp.Limpar();
            txtEntrada.Text = Limp.Limpar();


        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
