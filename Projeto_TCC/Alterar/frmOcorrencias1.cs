using Projeto_TCC;
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
    public partial class frmOcorrencias1 : Form
    {
        public frmOcorrencias1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOcorrencias2 alterar = new frmOcorrencias2();
            alterar.Closed += (s, args) => this.Close();
            alterar.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltDados menu = new frmAltDados();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }
    }
}
