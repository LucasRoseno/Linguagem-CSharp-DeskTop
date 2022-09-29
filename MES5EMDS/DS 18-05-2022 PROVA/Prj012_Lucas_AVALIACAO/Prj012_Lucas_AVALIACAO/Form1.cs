using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj012_Lucas_AVALIACAO
{
    public partial class Form1 : Form
    {
        double val1 = 0;
        double val2 = 0;
        double media = 0;
        
        public Form1()
        {
            InitializeComponent();
            btnMedia.Enabled = false;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Text = "";
            txtValor2.Text = "";
            lblMedia.Text = "";
            lblSeq.Text = "";
            btnValidar.Enabled = true;
            btnMedia.Enabled = false;
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                val1 = Convert.ToDouble(txtValor1.Text);
                val2 = Convert.ToDouble(txtValor2.Text);
                MessageBox.Show("Valores ok!!!!", "Selecione a operação");
                btnValidar.Enabled = false;
                btnMedia.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Digite apenas números!!!! E agora limpe tudo", "ERRO - ATENÇÃO");
                txtValor1.SelectAll();
                txtValor1.Focus();
                txtValor2.SelectAll();
                btnValidar.Enabled = false;
                btnMedia.Enabled = false;
            }
            

        }

        private void BtnMedia_Click(object sender, EventArgs e)
        {
            Double media = (val1 + val2)/2;
            lblMedia.Text = media + "";

            if(val2>= val1)
            {
                lblSeq.Text = val1 + "        " + media + "        " + val2;
            }
            else
            {
                lblSeq.Text = val2 + "        " + media + "        " + val1;
            }

            
        }
    }
}
