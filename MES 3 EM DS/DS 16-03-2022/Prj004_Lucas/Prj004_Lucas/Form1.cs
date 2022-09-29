using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj004_Lucas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            lbl_Mostrar.Text = label1.Text + txtBox1.Text +"\n"; // \n = quebra de linha
            
            lbl_Mostrar.Text += label2.Text + txtBox2.Text + "\n";

            lbl_Mostrar.Text += label3.Text + txtBox3.Text + "\n";

            lbl_Mostrar.Text += label4.Text + txtBox4.Text + "\n";

            lbl_Mostrar.Text += label5.Text + txtBox5.Text + "\n";

            lbl_Mostrar.Text += label6.Text + txtBox6.Text + "\n";

            lbl_Mostrar.Text += label7.Text + txtBox7.Text + "\n";

            btn_Limpar.Enabled = true;
            btn_Enviar.Enabled = false;
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            txtBox1.Text = "";
            txtBox2.Text = "";
            txtBox3.Text = "";
            txtBox4.Text = "";
            txtBox5.Text = "";
            txtBox6.Text = "";
            txtBox7.Text = "";
            lbl_Mostrar.Text = "";

            btn_Limpar.Enabled = false;
            btn_Enviar.Enabled = true;
        }

        private void TxtBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
