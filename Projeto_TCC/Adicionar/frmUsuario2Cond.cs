using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_TCC.Adicionar
{
    public partial class frmUsuario2Cond : Form
    {
        public frmUsuario2Cond()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuario1 add = new frmUsuario1();
            add.Closed += (s, args) => this.Close();
            add.Show();
        }
    }
}
