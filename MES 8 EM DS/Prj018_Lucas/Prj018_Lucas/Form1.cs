using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj018_Lucas
{
    public partial class Exer018 : Form
    {
        
        string[] resulFinal = new string[10];

       

        public Exer018()
        {
            InitializeComponent();

            resulFinal[0] = "Aprovado";

            resulFinal[1] = "Aprovado";
            resulFinal[2] = "Retido";
            resulFinal[3] = "Desistente";
            resulFinal[4] = "Aprovado";
            resulFinal[5] = "Aprovado";
            resulFinal[6] = "Retido";
            resulFinal[7] = "Recuperação";
            resulFinal[8] = "Aprovado";
            resulFinal[9] = "Retido";







        }

        
        
       


        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            lblResp.Text = "";
            txtPesc.Text = "";
        }

        private void BtnConsu_Click(object sender, EventArgs e)
        {

            try
            {
                int busca = Convert.ToInt16(txtPesc.Text) - 1;
                if (busca >= resulFinal.Length)
                {
                    lblResp.Text = "Voce está forado paramentro, o numero não condiz com a quantidade de alunos";

                }
                else
                {
                    lblResp.Text = resulFinal[busca];
                }
            }
            catch
            {
                MessageBox.Show("você digitou algo incorreto com o programa", "CUIDADO");
                txtPesc.Text = "";
                lblResp.Text = "";
            }
            
            
          
            


        }
    }
}
