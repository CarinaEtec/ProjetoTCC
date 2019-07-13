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
            frmUsuario3Cond alt = new frmUsuario3Cond();
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
            frmUsuario3Func alt = new frmUsuario3Func();
            alt.Closed += (s, args) => this.Close();
            alt.Show();
        }
    }
}
