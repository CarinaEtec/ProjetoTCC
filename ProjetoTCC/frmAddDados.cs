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
    public partial class frmAddDados : Form
    {
        public frmAddDados()
        {
            InitializeComponent();
        }

        private void btnCriancas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddCriancas pirralhos = new frmAddCriancas();
            pirralhos.Closed += (s, args) => this.Close();
            pirralhos.Show();
        }

        private void btnAnimais_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddPets pets = new frmAddPets();
            pets.Closed += (s, args) => this.Close();
            pets.Show();
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
