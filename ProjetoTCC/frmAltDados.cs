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

        private void btnLocacao_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltLocacao1 locacao = new frmAltLocacao1();
            locacao.Closed += (s, args) => this.Close();
            locacao.Show();
        }

        private void btnOcorrencias_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltOcorrencias1 ocorrencias = new frmAltOcorrencias1();
            ocorrencias.Closed += (s, args) => this.Close();
            ocorrencias.Show();
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltVeiculos1 veiculos = new frmAltVeiculos1();
            veiculos.Closed += (s, args) => this.Close();
            veiculos.Show();
        }

        private void btnObras_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltObras1 obras = new frmAltObras1();
            obras.Closed += (s, args) => this.Close();
            obras.Show();
        }
    }
}
