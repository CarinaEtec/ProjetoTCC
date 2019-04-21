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
    public partial class frmAltVeiculos : Form
    {
        public frmAltVeiculos()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltVeiculos1 busca = new frmAltVeiculos1();
            busca.Closed += (s, args) => this.Close();
            busca.Show();
        }
    }
}
