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
            frmAltCriancas1 pirralhos = new frmAltCriancas1();
            pirralhos.Closed += (s, args) => this.Close();
            pirralhos.Show();
        }

        private void btnAnimais_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltPets1 pets = new frmAltPets1();
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

        private void btnMoradores_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltMorador1 morador = new frmAltMorador1();
            morador.Closed += (s, args) => this.Close();
            morador.Show();
        }
    }
}
