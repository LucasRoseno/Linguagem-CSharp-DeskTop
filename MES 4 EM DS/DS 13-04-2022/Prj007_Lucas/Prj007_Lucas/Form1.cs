using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj007_Lucas
{
    public partial class Form1 : Form
    {
        double valor1 = 0;
        double valor2 = 0;
        double resultado = 0;
        
        public Form1()
        {
            InitializeComponent();
            grpValores.Enabled = true;
            grpOperacoes.Enabled = false;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void BtnAjuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }


        private void BtnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = Convert.ToDouble(txtBox1.Text);
                valor2 = Convert.ToDouble(txtBox2.Text);
                MessageBox.Show("Valores ok!!!!", "Selecione a operação");
                grpValores.Enabled = false;
                grpOperacoes.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Digite apenas números!!!!", "ERRO - ATENÇÃO");
                txtBox1.SelectAll();
                txtBox1.Focus();
                txtBox2.SelectAll();
                
            }
        }

        private void BtnSom_Click(object sender, EventArgs e)
        {
            resultado = valor1 + valor2;
            lblResultado.Text = resultado.ToString();
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            resultado = valor1 - valor2;
            lblResultado.Text = resultado.ToString();
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            resultado = valor1 * valor2;
            lblResultado.Text = resultado.ToString();
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if (valor2 != 0)
            {
                resultado = valor1 / valor2;
                lblResultado.Text = resultado.ToString();
            }
            else
                lblResultado.Text = "****ERRO****";
        }


        private void BtnPot_Click(object sender, EventArgs e)
        {
            resultado = Math.Pow(valor1, valor2);
            lblResultado.Text = resultado.ToString();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            txtBox1.Text = "";
            txtBox2.Text = "";
            grpValores.Enabled = true;    
            grpOperacoes.Enabled = false;
            txtBox1.Focus();
            
        }

        private void LblExibir_Click(object sender, EventArgs e)
        {
            Form2 meuFormulario = new Form2();
            meuFormulario.Show();
            
        }
    }
    
}
