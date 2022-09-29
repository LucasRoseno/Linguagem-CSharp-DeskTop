using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj028_BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TabelaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabelaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancoDadosDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bancoDadosDataSet.Tabela'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaTableAdapter.Fill(this.bancoDadosDataSet.Tabela);

        }
    }
}
