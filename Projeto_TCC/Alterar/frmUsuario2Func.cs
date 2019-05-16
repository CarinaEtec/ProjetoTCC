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
    public partial class frmUsuario2Func : Form
    {
        public frmUsuario2Func()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuario3Func alterar = new frmUsuario3Func();
            alterar.Closed += (s, args) => this.Close();
            alterar.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltDados menuzinho = new frmAltDados();
            menuzinho.Closed += (s, args) => this.Close();
            menuzinho.Show();
        }
    }
}
