using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj021_Prova17_08_2022_Lucas
{


    public partial class Form1 : Form
    {
        int numero;
        private string Verificar(int numero)
        {
            int resto = numero % 2;
            if(resto == 0)
            {
                return LblResposta.Text = "O numero " + numero + " é PAR";
            }
            else
            {
                return LblResposta.Text = "O numero " + numero + " é IMPAR";
            }

           
        }
        private void Limpar()
        {

           
            
          TxtNumero.Text = "";
          

          LblResposta.Text = "";
        
        }

        public Form1()
        {
            InitializeComponent();
        }


        

        private void BtnVerificar_Click(object sender, EventArgs e)
        {

                try
                {
                numero = Convert.ToInt32(TxtNumero.Text);
                LblResposta.Text = Verificar(numero);

                }

                catch {

                LblResposta.Text = "Houve um erro na inserção do numero";
                Limpar();
            }


               
            
            

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
