using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj026_Lucas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);

                ClsCalcular ObjResultado = new ClsCalcular();
                ObjResultado.Numero = numero;

                lblResultado.Text = ObjResultado.Verificar();
            }
            catch
            {
                lblResultado.Text = "HOUVE UM ERRO";
                
                txtNumero.Text = "";
            }

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            txtNumero.Text = "";
        }
    }
}
