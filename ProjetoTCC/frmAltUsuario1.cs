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
    public partial class frmAltUsuario1 : Form
    {
        public frmAltUsuario1()
        {
            InitializeComponent();
        }

        private void btnCondominio_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltUsuario2Cond alt = new frmAltUsuario2Cond();
            alt.Closed += (s, args) => this.Close();
            alt.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltUsuario2Func alt = new frmAltUsuario2Func();
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
    }
}
