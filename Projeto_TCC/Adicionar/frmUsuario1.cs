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

namespace Projeto_TCC.Adicionar
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
            frmUsuario2Cond add = new frmUsuario2Cond();
            add.Closed += (s, args) => this.Close();
            add.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuario2Func add = new frmUsuario2Func();
            add.Closed += (s, args) => this.Close();
            add.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddDados add = new frmAddDados();
            add.Closed += (s, args) => this.Close();
            add.Show();
        }
    }
}
