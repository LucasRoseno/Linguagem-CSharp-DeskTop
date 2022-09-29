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
    public partial class Form2 : Form
    {

        double valor1s = 0;
        double valor2s = 0;
        double resultadoSec = 0;
        string operacao;
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnSom_Click(object sender, EventArgs e)
        {
            try
            {
                valor1s = Convert.ToDouble(txtBox1.Text);
                valor2s = Convert.ToDouble(txtBox2.Text);

                operacao = (sender as Button).Text;
                switch (operacao)
                {
                    case "+":
                        {
                            
                            resultadoSec = valor1s + valor2s;
                            lblResultado.Text = resultadoSec.ToString();
                            break;
                        }
                    case "-":
                        {

                            resultadoSec = valor1s - valor2s;
                            lblResultado.Text = resultadoSec.ToString();
                            break;
                        }
                    case "*":
                        {

                            resultadoSec = valor1s * valor2s;
                            lblResultado.Text = resultadoSec.ToString();
                            break;
                        }
                    case "/":
                        {
                            if (valor2s == 0)
                            {
                                lblResultado.Text = "Não dividiras por 0";
                            }
                            else
                            {
                                resultadoSec = valor1s / valor2s;
                                lblResultado.Text = resultadoSec.ToString();
                            }
                            break;
                        }
                    case "Potência":
                        {
                            resultadoSec = Math.Pow(valor1s, valor2s);
                            lblResultado.Text = resultadoSec.ToString();
                            break;
                        }

                }

               
            }
            catch
            {

            }
        }

      

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            txtBox1.Text = "";
            txtBox2.Text = "";
            grpValores.Enabled = true;
            txtBox1.Focus();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

       

        private void BtnAjuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void LblData_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            lblData.Text = DateTime.Now.ToString("dd:MM:yyyy");
            lblDia.Text = DateTime.Now.ToString("dddd").ToUpper();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
           lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
