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
    public partial class frmOcorrencias2 : Form
    {
        public frmOcorrencias2()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltDados menu = new frmAltDados();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void frmOcorrencias2_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel2.Visible = true;

            btnAlterar.Enabled = false;

            lblMoradorCod.Visible = false;
            lblBACod.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            btnAlterar.Enabled = true;
        }
    }
}
