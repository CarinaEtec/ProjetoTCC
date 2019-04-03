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
    public partial class frmAltDados : Form
    {
        public frmAltDados()
        {
            InitializeComponent();
        }

        private void btnCriancas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltCriancas pirralhos = new frmAltCriancas();
            pirralhos.Closed += (s, args) => this.Close();
            pirralhos.Show();
        }

        private void btnAnimais_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltPets pets = new frmAltPets();
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
