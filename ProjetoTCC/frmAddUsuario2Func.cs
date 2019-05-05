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
    public partial class frmAddUsuario2Func : Form
    {
        public frmAddUsuario2Func()
        {
            InitializeComponent();
        }



        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmAddUsuario1 add = new frmAddUsuario1();
            add.Closed += (s, args) => this.Close();
            add.Show();
        }
    }
}
