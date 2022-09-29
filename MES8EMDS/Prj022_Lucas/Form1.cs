using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj022_Lucas
{
    public partial class Form1 : Form
    {
        string[] bdList = {"I","R","B","I","I","R","R","B","MB","B" };
        string[] webList = { "B", "B", "MB", "MB", "B", "R", "R", "B", "B", "R" };
        string[] dtccList = { "MB", "MB", "B", "R", "I", "R", "B", "MB", "MB", "B" };

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblDataSema.Text = DateTime.Now.ToString("dddd");
            rdoBd.Checked = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            try {

                int numero = Convert.ToInt32(txtNumChama.Text);
                if (rdoBd.Checked == true)
                {

                    string bd = bdList[numero - 1];
                    lblResult.Text = bd;
                }
                if(rdoWeb.Checked == true)
                {
                    string wb = webList[numero - 1];
                    lblResult.Text = wb;
                }
                if(rdoDtcc.Checked == true)
                {
                    string dtcc = dtccList[numero - 1];
                    lblResult.Text = dtcc;
                }

            }
            catch {
                lblResult.Text = "ERRO";
            }


           
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            txtNumChama.Text = "";
            rdoBd.Checked = true;
            rdoDtcc.Checked = false;
            rdoWeb.Checked = false;
        }
    }
}
