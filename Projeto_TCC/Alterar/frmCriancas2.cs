using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_TCC.Alterar
{
    public partial class frmCriancas2 : Form
    {
        public frmCriancas2()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCriancas1 busca = new frmCriancas1();
            busca.Closed += (s, args) => this.Close();
            busca.Show();
        }
    }
}
