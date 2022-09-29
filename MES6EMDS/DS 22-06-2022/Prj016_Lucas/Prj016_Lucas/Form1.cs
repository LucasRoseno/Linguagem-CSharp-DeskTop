using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj016_Lucas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for(int i = 0; i<=10; i++)
            comboBox.Items.Add(i);


            comboBox.SelectedIndex = 0;

            /*  comboBox.Items.Add("01");
              comboBox.Items.Add("02");
              comboBox.Items.Add("03");
              comboBox.Items.Add("04");
              comboBox.Items.Add("05");
              comboBox.Items.Add("06");
              comboBox.Items.Add("07");
              comboBox.Items.Add("08");
              comboBox.Items.Add("09");
              comboBox.Items.Add("10");*/


        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            int concomb = Int16.Parse(comboBox.Text);
            int rep = 0;
            

            while (rep <= 10)
            {
                string fac = comboBox.Text + " * " + rep + " = ";
                listBox.Items.Add( fac + concomb * rep );
                rep++;
                
               
            }
            




        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            comboBox.Text = "";
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
