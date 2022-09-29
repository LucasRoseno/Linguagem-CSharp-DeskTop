using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj005_Lucas
{
    public partial class Frm_004 : Form
    {
        public Frm_004()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnExibir_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text == "")
            {
                MessageBox.Show("Insira seu nome", "ATENÇÃO");
                TxtNome.Focus();
            }
          
         
           else if (TxtSexo.Text == "M")
            {
                LblMostrar.Text = "Seja bem vindO " + TxtNome.Text;
            }
             
           else if (TxtSexo.Text == "F")
            {
                LblMostrar.Text = "Seja bem vindA " + TxtNome.Text;
            }
              // else if (TxtSexo.Text != "F" + "M")
              else //if(TxtSexo.TEXT)
                    {
                    MessageBox.Show("Insira apenas M ou F", "Cuidado");
                    TxtSexo.Focus();

                    }
            // ELSE IF (TXT.SEXO != "M" && TXT.SEXO != "F"){ MessageBox.show ("Erro", ) \\||||||||||||||||||

            
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TxtSexo.Text = "";
            TxtNome.Text = "";
            LblMostrar.Text = "";
            TxtNome.Focus();
        }
    }
}
