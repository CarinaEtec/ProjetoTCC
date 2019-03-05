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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAptos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Aptos apto = new Aptos();
            apto.Closed += (s, args) => this.Close();
            apto.Show();
        }

        private void btnOcorrencias_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ocorrencias advertencias = new Ocorrencias();
            advertencias.Closed += (s, args) => this.Close();
            advertencias.Show();
        }

        private void btnBlocos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Blocos bloc = new Blocos();
            bloc.Closed += (s, args) => this.Close();
            bloc.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCriancas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Criancas crias = new Criancas();
            crias.Closed += (s, args) => this.Close();
            crias.Show();
        }

        private void btnLocacao_Click(object sender, EventArgs e)
        {
            this.Hide();
            Locacao lazer = new Locacao();
            lazer.Closed += (s, args) => this.Close();
            lazer.Show();
        }

        private void btnAnimais_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pets doguinho = new Pets();
            doguinho.Closed += (s, args) => this.Close();
            doguinho.Show();
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Veiculos veiculos = new Veiculos();
            veiculos.Closed += (s, args) => this.Close();
            veiculos.Show();
        }

        private void btnObras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Obras obras = new Obras();
            obras.Closed += (s, args) => this.Close();
            obras.Show();
        }

        private void btnAdicionarDados_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDados add = new AddDados();
            add.Closed += (s, args) => this.Close();
            add.Show();
        }
    }
}
