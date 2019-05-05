using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTCC
{
    public partial class frmAltCriancas : Form
    {
        public frmAltCriancas()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltCriancas1 busca = new frmAltCriancas1();
            busca.Closed += (s, args) => this.Close();
            busca.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
