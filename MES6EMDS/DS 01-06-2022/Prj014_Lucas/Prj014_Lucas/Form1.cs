using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj014_Lucas
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

        private void BtnProcessar_Click(object sender, EventArgs e)
        {
            string nome = txtBoxNome.Text;
            string testeNome = nome.Trim();
            int qtdeCaracteres = testeNome.Length;
            if (nome != testeNome)
            {
                MessageBox.Show("Verifique a digitação do nome!!", "Atenção");
                txtBoxNome.SelectionStart = 0;
                txtBoxNome.SelectionLength = txtBoxNome.Text.Length;
                txtBoxNome.Focus();
            }
            else if(qtdeCaracteres < 10 || qtdeCaracteres > 60)
            {
                MessageBox.Show("Tamanho do nome está fora do padrão!!", "Atenção");
                txtBoxNome.SelectionStart = 0;
                txtBoxNome.SelectionLength = txtBoxNome.Text.Length;
                txtBoxNome.Focus();
            } else
            {
                int finalPrimeiroNome = testeNome.IndexOf(" ");
                lblPrimNome.Text = nome.Substring(0, finalPrimeiroNome);
                lblTotCaracteres.Text = qtdeCaracteres.ToString();
                string eMail = txtBoxEmail.Text;
                int finalNomeEmail = eMail.IndexOf("@");
                int totTamanhoEmail = eMail.Length;
                int totTamanhoDominio = totTamanhoEmail - finalNomeEmail;

                if (finalNomeEmail < 1) //indica que o "@" não foi inserido
                {
                    MessageBox.Show("Verifique o e-mail!!", "Atenção");
                    txtBoxEmail.SelectionStart = 0;
                    txtBoxEmail.SelectionLength = txtBoxEmail.Text.Length;
                    txtBoxEmail.Focus();
                } else{
                    lblEmail.Text = eMail.Substring(0, finalNomeEmail);
                    lblDominio.Text = eMail.Substring(finalNomeEmail + 1, totTamanhoDominio-1);
                }
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            lblDominio.Text = "";
            lblEmail.Text = "";
            lblPrimNome.Text = "";
            lblTotCaracteres.Text = "";
            txtBoxEmail.Text = "";
            txtBoxNome.Text = "";
        }
    }
}
