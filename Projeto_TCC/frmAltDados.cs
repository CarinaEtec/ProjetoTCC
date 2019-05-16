using Projeto_TCC;
using Projeto_TCC.Alterar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_TCC
{
    public partial class frmAltDados : Form
    {
        public frmAltDados()
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

        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuario1 usu = new frmUsuario1();
            usu.Closed += (s, args) => this.Close();
            usu.Show();
        }

        private void btnMoradores_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMorador1 morador = new frmMorador1();
            morador.Closed += (s, args) => this.Close();
            morador.Show();
        }

        private void btnCriancas_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmCriancas1 pirralhos = new frmCriancas1();
            pirralhos.Closed += (s, args) => this.Close();
            pirralhos.Show();
        }

        private void btnAnimais_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmPets1 pets = new frmPets1();
            pets.Closed += (s, args) => this.Close();
            pets.Show();
        }

        private void btnLocacao_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmLocacao1 locacao = new frmLocacao1();
            locacao.Closed += (s, args) => this.Close();
            locacao.Show();
        }

        private void btnOcorrencias_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmOcorrencias1 ocorrencias = new frmOcorrencias1();
            ocorrencias.Closed += (s, args) => this.Close();
            ocorrencias.Show();
        }

        private void btnVeiculos_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmVeiculos1 veiculos = new frmVeiculos1();
            veiculos.Closed += (s, args) => this.Close();
            veiculos.Show();
        }

        private void btnObras_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmObras1 obras = new frmObras1();
            obras.Closed += (s, args) => this.Close();
            obras.Show();
        }
    }
}
