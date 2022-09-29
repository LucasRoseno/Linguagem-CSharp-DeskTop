using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj023_POO_LPOO_Lucas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            //Gera a instância da da classe e nesse momento, o mentodo construtor é executado
            ClsOperacao ObjOperacao = new ClsOperacao();

            ObjOperacao.Valor1 = Convert.ToInt32(txtVal1.Text);
            ObjOperacao.Valor2 = Convert.ToInt32(txtVal2.Text);



            lblResult.Text = ObjOperacao.Somar().ToString();
        }
    }
}
