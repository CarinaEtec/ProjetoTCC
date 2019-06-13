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
    public partial class frmUsuario3Cond : Form
    {
        public frmUsuario3Cond()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuario1 fim = new frmUsuario1();
            fim.Closed += (s, args) => this.Close();
            fim.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuario2Cond add = new frmUsuario2Cond();
            add.Closed += (s, args) => this.Close();
            add.Show();
        }

        private void btnSalvarBloco_Click(object sender, EventArgs e)
        {
            grpCadApto.Visible = true;

        }

        private void frmUsuario3Cond_Load(object sender, EventArgs e)
        {
            grpCadApto.Visible = false;
        }
    }
}
