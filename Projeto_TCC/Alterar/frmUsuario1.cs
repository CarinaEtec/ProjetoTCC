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
    public partial class frmUsuario1 : Form
    {
        public frmUsuario1()
        {
            InitializeComponent();
        }

        private void btnCondominio_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuario2Cond alt = new frmUsuario2Cond();
            alt.Closed += (s, args) => this.Close();
            alt.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltDados alt = new frmAltDados();
            alt.Closed += (s, args) => this.Close();
            alt.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuario2Func alt = new frmUsuario2Func();
            alt.Closed += (s, args) => this.Close();
            alt.Show();
        }
    }
}
