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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCriancas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCriancas crias = new frmCriancas();
            crias.Closed += (s, args) => this.Close();
            crias.Show();
        }

        private void btnAptos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAptos apto = new frmAptos();
            apto.Closed += (s, args) => this.Close();
            apto.Show();
        }

        private void btnMoradores_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMoradores morador = new frmMoradores();
            morador.Closed += (s, args) => this.Close();
            morador.Show();
        }

        private void btnAnimais_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPets doguinho = new frmPets();
            doguinho.Closed += (s, args) => this.Close();
            doguinho.Show();
        }

        private void btnLocacao_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLocacao lazer = new frmLocacao();
            lazer.Closed += (s, args) => this.Close();
            lazer.Show();
        }

        private void btnOcorrencias_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOcorrencias advertencias = new frmOcorrencias();
            advertencias.Closed += (s, args) => this.Close();
            advertencias.Show();
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVeiculos veiculos = new frmVeiculos();
            veiculos.Closed += (s, args) => this.Close();
            veiculos.Show();
        }

        private void btnObras_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmObras obras = new frmObras();
            obras.Closed += (s, args) => this.Close();
            obras.Show();
        }

        private void btnAdicionarDados_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddDados add = new frmAddDados();
            add.Closed += (s, args) => this.Close();
            add.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltDados add = new frmAltDados();
            add.Closed += (s, args) => this.Close();
            add.Show();

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
