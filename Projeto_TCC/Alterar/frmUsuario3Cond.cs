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
    public partial class frmUsuario3Cond : Form
    {
        public frmUsuario3Cond()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuario2Cond alt = new frmUsuario2Cond();
            alt.Closed += (s, args) => this.Close();
            alt.Show();
        }
    }
}
