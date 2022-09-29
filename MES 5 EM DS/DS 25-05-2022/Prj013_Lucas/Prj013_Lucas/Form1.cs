using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj013_Lucas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma saída do programa", "ATENÇÃO",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboPratoPrincipal.Items.Add("Yakisoba Clássico");
            cboPratoPrincipal.Items.Add("Yakisoba de Camarão");
            cboPratoPrincipal.Items.Add("Yakimeshi");
            //Exibe o primeiro item do combo como padrão
            cboPratoPrincipal.SelectedIndex = 0;

            lstAcompanhamentos.Items.Add("Carne com Brócolis");
            lstAcompanhamentos.Items.Add("Frango Agridoce");
            lstAcompanhamentos.Items.Add("Carne com Legumes");
            lstAcompanhamentos.Items.Add("Frango Xadrez");
        }

        private void BtnPratoPrincipal_Click(object sender, EventArgs e)
        {
            //Verifica se o prato principal NÃO existee faz a inclusão.
            //Se já existir, exibe uma mensagem de alerta
            if (!lstPedido.Items.Contains(cboPratoPrincipal.Text))
            {
                lstPedido.Items.Add(cboPratoPrincipal.Text);
                lblItensPed.Text = Convert.ToString(lstPedido.Items.Count);
                btnAcompanh.Enabled = true;
            }
            else
            {
                MessageBox.Show("Este prato principal já existe no pedido!!!", "Atenção");
            }
        }

        private void BtnExcluirItens_Click(object sender, EventArgs e)
        {
            int itemExcluir = lstPedido.SelectedIndex;
            if (itemExcluir < 0)
            {
                MessageBox.Show("Nenhum item foi selecionado!!", "Atenção");
            }
            else
            {
                lstPedido.Items.RemoveAt(lstPedido.SelectedIndex);
                lblItensPed.Text = Convert.ToString(lstPedido.Items.Count);
            }
        }

        private void BtnAcompanh_Click(object sender, EventArgs e)
        {
            if (lstAcompanhamentos.SelectedIndex < 0)
            {
                MessageBox.Show("Precisa SELECIONAR o acompanhamento!!", "ATENÇÃO");
            }
            else
            {
                lstPedido.Items.Add(lstAcompanhamentos.Text);
                lblItensPed.Text = Convert.ToString(lstPedido.Items.Count);
            }
        }

        private void BtnNovPed_Click(object sender, EventArgs e)
        {
            lstPedido.Items.Clear();
            lblItensPed.Text = "0";
            cboPratoPrincipal.SelectedIndex = 0;
            lstAcompanhamentos.SelectedIndex = -1;
        }

    }
}
