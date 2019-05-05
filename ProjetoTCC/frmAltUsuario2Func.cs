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
    public partial class frmAltUsuario2Func : Form
    {
        public frmAltUsuario2Func()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltUsuario1 alt = new frmAltUsuario1();
            alt.Closed += (s, args) => this.Close();
            alt.Show();
        }
    }
}
