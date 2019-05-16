using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_TCC.Consultar
{
    public partial class frmVeiculos : Form
    {
        public frmVeiculos()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menuzinho = new frmMenu();
            menuzinho.Closed += (s, args) => this.Close();
            menuzinho.Show();
        }
    }
}
