using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj006_Lucas
{
    public partial class Form1 : Form
    {
        String nome1 = "";
        String nome2 = "";
        Byte idade1 ;
        byte idade2 ;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd:MM:yyyy");
            lblDia.Text = DateTime.Now.ToString("dddd").ToUpper();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");

        }

       

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void TxtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != 08 && (e.KeyChar < 48 || e.KeyChar >57)){

                e.KeyChar = (char)0;
            }

        }

        private void TxtIdade2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 08 && (e.KeyChar < 48 || e.KeyChar > 57))
            {

                e.KeyChar = (char)0;
            }
        }

        private void Btn_Exibir_Click(object sender, EventArgs e)
        {
            if( (txtNome1.Text == "") || (txtNome2.Text =="")||
               (txtIdade.Text == "") || (txtIdade2.Text == ""   ))
            {
                MessageBox.Show("Preencha TODOS os campos!!", "ATENÇÃO");
                txtNome1.SelectAll();
                txtNome1.Focus();
            }
            else
            {
                nome1 = txtNome1.Text;
                idade1 = Convert.ToByte(txtIdade.Text);

                nome2 = txtNome2.Text;
                idade1 = Convert.ToByte(txtIdade2.Text);

                if (idade1 == idade2)
                {
                    MessageBox.Show("Alunos com a mesma idade!!!!", "Atenção");
                    btn_Exibir.Enabled = false;
                    btnLimpar.Enabled = true;
                }
                else if (idade1 < idade2)
                {
                    lblNomeMenor.Text = nome1;
                    lblIdadeMenor.Text = idade1.ToString();
                    btn_Exibir.Enabled = false;
                    btnLimpar.Enabled = true;

                }
                else
                {
                    lblNomeMenor.Text = nome2;
                    lblIdadeMenor.Text = idade2.ToString();
                    btn_Exibir.Enabled = false;
                    btnLimpar.Enabled = true;
                }

            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            lblNomeMenor.Text = "";
            lblIdadeMenor.Text = "";
            txtNome1.Text = "";
            txtNome2.Text = "";
            txtIdade.Text = "";
            txtIdade2.Text = "";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {

        }

        private void LblData_Click(object sender, EventArgs e)
        {

        }
    }
}
