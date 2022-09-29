﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj017_Lucas
{
    public partial class Form1 : Form
    {


        private void VerificarI()
        {
            int x = int.Parse(txtBoxNum.Text);
            if (x <= 1)
            {
                lblResposta.Text = " não é primo";
                return;
            }
            if (x == 2)
            {
                lblResposta.Text = " É primo";
                return;

            }

            for (int divisor = 2; divisor < x; divisor++)
            {

                int resto = x % divisor;

                if (resto == 0)
                {
                    lblResposta.Text = "Não é primo";
                    return;
                }

            }

            lblResposta.Text = "Primo";
        }


        private void VerificarII(int numero)
        {

            
            if (numero <= 1)
            {
                lblResposta.Text = " não é primo";
                return;
            }
            if (numero == 2)
            {
                lblResposta.Text = " É primo";
                return;

            }

            for (int divisor = 2; divisor < numero; divisor++)
            {

                int resto = numero % divisor;

                if (resto == 0)
                {
                    lblResposta.Text = "Não é primo";
                    return;
                }

            }

            lblResposta.Text = "Primo";
        }

        private string VerificarIII(int numero) {

            
            if (numero <= 1)
            {
                
                return lblResposta.Text = " não é primo";
            }

            if (numero == 2)
            {
                
                return lblResposta.Text = " É primo";

            }

            for (int divisor = 2; divisor < numero; divisor++)
            {

                int resto = numero % divisor;

                if (resto == 0)
                {
                    
                    return lblResposta.Text = "Não é primo";
                }

            }

           return  "Primo";

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            lblResposta.Text = "";
            txtBoxNum.Text = "";
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            VerificarI();
         
           
        }

        private void BtnVerificar2_Click(object sender, EventArgs e)
        {
            VerificarII(Convert.ToInt32(txtBoxNum.Text));
        }

        private void BtnVerificar3_Click(object sender, EventArgs e)
        {
            lblResposta.Text = VerificarIII(Convert.ToInt32(txtBoxNum.Text));
        }
    }
}
