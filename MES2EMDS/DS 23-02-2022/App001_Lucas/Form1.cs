using System;
using System.Windows.Forms;

namespace App001_Lucas
{
    public partial class FrmApp001 : Form
    {
        public FrmApp001()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit(); //FECHAR APLICAÇÃO
        }

        private void Btn_Sub_Click(object sender, EventArgs e)
        {
            String v1 = txt_Inserir1.Text;
            Double val1 = Double.Parse(v1); //converte para double

            String v2 = txt_Inserir2.Text;
            Double val2 = Double.Parse(v2); //converte para double

            //Console.WriteLine(val1 - val2);
            Double t = val1 - val2;
            // lblTotal 
            lbl_Result.Text = t + "";

        }

        private void Btn_Soma_Click(object sender, EventArgs e)
        {
            String v1 = txt_Inserir1.Text;
            Double val1 = Double.Parse(v1); //converte para double

            String v2 = txt_Inserir2.Text;
            Double val2 = Double.Parse(v2); //converte para double

            //Console.WriteLine(val1 + val2);
            Double t = val1 + val2;
            // lblTotal 
            lbl_Result.Text = t + "";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Mult_Click(object sender, EventArgs e)
        {
            String v1 = txt_Inserir1.Text;
            Double val1 = Double.Parse(v1); //converte para double

            String v2 = txt_Inserir2.Text;
            Double val2 = Double.Parse(v2); //converte para double

            //Console.WriteLine(val1 * val2);
            Double t = val1 * val2;
            // lblTotal 
            lbl_Result.Text = t + "";
        }

        private void Btn_Div_Click(object sender, EventArgs e)
        {
            String v1 = txt_Inserir1.Text;
            Double val1 = Double.Parse(v1); //converte para double

            String v2 = txt_Inserir2.Text;
            Double val2 = Double.Parse(v2); //converte para double

            //Console.WriteLine(val1 / val2);
            Double t = val1 / val2;
            // lblTotal 
            lbl_Result.Text = t + "";
        }

        private void Btn_Pot_Click(object sender, EventArgs e)
        {
            String v1 = txt_Inserir1.Text;
            Double val1 = Double.Parse(v1); //converte para double

            String v2 = txt_Inserir2.Text;
            Double val2 = Double.Parse(v2); //converte para double

            //Console.WriteLine(val1 ^ val2);
            Double t = Math.Pow(val1, val2);
            // lblTotal 
            lbl_Result.Text = t + "";
        }
    }
}
