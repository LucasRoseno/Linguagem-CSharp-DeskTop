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
    public partial class FrmPai : Form
    {
        public FrmPai()
        {
            InitializeComponent();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {
            frmCadFornec abrirFornec = new frmCadFornec();
            abrirFornec.ShowDialog();
        }
    }
}
