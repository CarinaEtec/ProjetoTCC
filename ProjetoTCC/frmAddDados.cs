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



        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menuzinho = new frmMenu();
            menuzinho.Closed += (s, args) => this.Close();
            menuzinho.Show();
        }

        private void btnMoradores_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmAddMorador morador = new frmAddMorador();
            morador.Closed += (s, args) => this.Close();
            morador.Show();
        }

        private void btnCriancas_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmAddCriancas pirralhos = new frmAddCriancas();
            pirralhos.Closed += (s, args) => this.Close();
            pirralhos.Show();
        }

        private void btnAnimais_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmAddPets pets = new frmAddPets();
            pets.Closed += (s, args) => this.Close();
            pets.Show();
        }

        private void btnLocacao_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmAddLocacao add = new frmAddLocacao();
            add.Closed += (s, args) => this.Close();
            add.Show();
        }

        private void btnOcorrencias_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmAddOcorrencia add = new frmAddOcorrencia();
            add.Closed += (s, args) => this.Close();
            add.Show();
        }

        private void btnVeiculos_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmAddVeiculos add = new frmAddVeiculos();
            add.Closed += (s, args) => this.Close();
            add.Show();
        }

        private void btnObras_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmAddObras add = new frmAddObras();
            add.Closed += (s, args) => this.Close();
            add.Show();
        }

        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmAddUsuario1 add = new frmAddUsuario1();
            add.Closed += (s, args) => this.Close();
            add.Show();
        }
    }
} 
