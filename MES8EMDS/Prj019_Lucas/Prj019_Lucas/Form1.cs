using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj019_Lucas
{
    public partial class Form1 : Form
    {
        int[] inscricao = { 11, 22, 33, 44, 55, 66, 77, 88, 99, 1010 };

       
        public Form1()
        {
            InitializeComponent();

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            txtRecebe.Text = "";
        }

        private void BtnConsul1_Click(object sender, EventArgs e)
        {
            int tamanhoInscri = inscricao.Length;

            

            try
            {
                int pesc = Convert.ToInt32(txtRecebe.Text);

                for (int i = 0; i <= tamanhoInscri; i++) {



                    if (pesc == inscricao[i])
                    {
                        i++;
                      
                        lblStatus.Text = "PARABÉNS, VOCÊ FOI CLASSIDICADO NA POSIÇÃO " + i.ToString() ;
                        return;
                    }
                    
                    
                   

                    
                }

                lblStatus.Text = "Esse número se encontra na lista de espera";

            }
            catch (Exception)
            {
                MessageBox.Show("você digitou algo incorreto com o programa", "CUIDADO");
                txtRecebe.Text = "";
                lblStatus.Text = "";

            }

        }

        private void BtnConsul2_Click(object sender, EventArgs e)
        {
            try
            {
                int pesc = Convert.ToInt32(txtRecebe.Text);
                int posicao = Array.IndexOf(inscricao, pesc);

                if(posicao < 0)
                {
                    lblStatus.Text = "LISTA DE ESPERA";
                }
                else
                {
                    posicao = posicao + 1;
                    lblStatus.Text = "Você foi classificado na posição" + posicao.ToString();
                }
            }
            catch
            {
                MessageBox.Show("você digitou algo incorreto com o programa", "CUIDADO");
                txtRecebe.Text = "";
                lblStatus.Text = "";
            }

        }
    }
}
