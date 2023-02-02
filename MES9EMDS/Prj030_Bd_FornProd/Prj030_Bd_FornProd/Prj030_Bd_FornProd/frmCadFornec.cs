using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj030_Bd_FornProd
{
    public partial class frmCadFornec : Form
    {
        public frmCadFornec()
        {
            InitializeComponent();
        }

        private void FrmCadFornec_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fornProdDataSet.Fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.fornProdDataSet.Fornecedores);

        }
    }
}
