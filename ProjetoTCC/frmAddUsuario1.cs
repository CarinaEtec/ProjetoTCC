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
    public partial class frmAddUsuario1 : Form
    {
        public frmAddUsuario1()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddDados add = new frmAddDados();
            add.Closed += (s, args) => this.Close();
            add.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCondominio_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddUsuario2Cond add = new frmAddUsuario2Cond();
            add.Closed += (s, args) => this.Close();
            add.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddUsuario2Func add = new frmAddUsuario2Func();
            add.Closed += (s, args) => this.Close();
            add.Show();
        }
    }
}
