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
    public partial class frmObras2 : Form
    {
        public frmObras2()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmObras1 alteracao = new frmObras1();
            alteracao.Closed += (s, args) => this.Close();
            alteracao.Show();
        }
    }
}
