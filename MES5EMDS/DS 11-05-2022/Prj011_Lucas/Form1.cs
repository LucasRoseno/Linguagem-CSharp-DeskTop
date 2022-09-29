using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj011_Lucas
{
    public partial class Form1 : Form
    {
        int totalDias;
        int valorDesconto;
        int totValorDiarias;
        int subTotal;
        int su1 = 0;
        int totalServico;
        int pagar;
        public Form1()
        {
            InitializeComponent();
            dataSaida.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //dataEntrada.Text = new DateTime();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime dataAtual = Convert.ToDateTime(dataSaida.Text);
                DateTime dataEntr = Convert.ToDateTime(dataEntrada.Text);
                totalDias = ((dataAtual).Subtract(dataEntr)).Days;
                lblTotHosp.Text = totalDias.ToString();
            }

            catch
            {
                MessageBox.Show("Digite data correta", "ERRO!!!!");
            }
            if (totalDias <= 0)
            {
                lblTotPag.Text = "";
                lblTotHosp.Text = "";
                lblSubTot.Text = "";
                lblTotServ.Text = "";
                lblDesc.Text = "";
                lblValDia.Text = "";
                dataEntrada.Text = "";
                MessageBox.Show("Você digitou uma data futura ou presente, digite apenas datas passadas", "ERRO!!!!");

            }
            else
            {

                if (radSimples.Checked == true)
                {
                    totValorDiarias = totalDias * 150;
                    lblValDia.Text = totValorDiarias.ToString("C2");
                }
                else
                {
                    totValorDiarias = totalDias * 280;
                    lblValDia.Text = totValorDiarias.ToString("C2");

                }


                if (rdoAVista.Checked == true)
                {
                    valorDesconto = (totValorDiarias * 10) / 100;
                    lblDesc.Text = valorDesconto.ToString("C2");
                }
                else
                {
                    valorDesconto = totValorDiarias;
                    lblDesc.Text = valorDesconto.ToString("C2");
                }
                subTotal = totValorDiarias - valorDesconto;
                lblSubTot.Text = subTotal.ToString("C2");


                if (chkSer1.Checked == true)
                    su1 = su1 + 50;
                else { su1 = 0; }
                if (chkSer2.Checked == true)
                    su1 = su1 + 80;
                else { su1 = 0; }
                if (chkSer3.Checked == true)
                    su1 = su1 + 120;
                else { su1 = 0; }
                if (chkSer4.Checked == true)
                    su1 = su1 + 200;
                else { su1 = 0; }

                totalServico = su1;
                lblTotServ.Text = totalServico.ToString("C2");

                pagar = subTotal + totalServico;
                lblTotPag.Text = pagar.ToString("C2");

            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            chkSer1.Checked = false;
            chkSer2.Checked = false;
            chkSer3.Checked = false;
            chkSer4.Checked = false;
            lblTotPag.Text = "";
            lblTotHosp.Text = "";
            lblSubTot.Text = "";
            lblTotServ.Text = "";
            lblDesc.Text = "";
            lblValDia.Text = "";
            radDuplo.Checked = false;
            radSimples.Checked = false;
            rdoAVista.Checked = false;
            rdoParce.Checked = false;
            dataEntrada.Text = "";
        }
    }
}
