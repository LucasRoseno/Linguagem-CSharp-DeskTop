using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj015_Lucas
{
    public partial class Form1 : Form
    {
        int cont;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn11_Click(object sender, EventArgs e)
        {
            lblMostrar.Text += (sender as Button).Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = "";
            chbAgua.Checked = false;
            chbAr.Checked = false;
            chbMetal.Checked = false;
            chbFogo.Checked = false;
            chbTerra.Checked = false;
            


        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            string plv = lblMostrar.Text;
            

            switch (plv)
            {
                case "FOGO":
                    chbFogo.Checked = true;
                    
                    cont += 1;
                    break;

                case "AGUA":
                    chbAgua.Checked = true;
                    cont += 1;
                    break;

                case "TERRA":
                    chbTerra.Checked = true;
                    cont += 1;
                    break;

                case "METAL":
                    chbMetal.Checked = true;
                    cont += 1;
                    break;

                case "AR":
                    chbAr.Checked = true;
                    cont += 1;
                    break;

                default:
                    MessageBox.Show("A palavra digitada não está no Banco de Dados", "ERRO");
                    break;
            }

            lblMostrar.Text = "";
            if (cont == 5)
            {
                MessageBox.Show("Você conseguiu concluir todo o caça palavra, continue assim", "PARABÉNS");
                lblMostrar.Text = "";
                chbAgua.Checked = false;
                chbAr.Checked = false;
                chbMetal.Checked = false;
                chbFogo.Checked = false;
                chbTerra.Checked = false;
                cont = 0;
            }


        }
    }
}
