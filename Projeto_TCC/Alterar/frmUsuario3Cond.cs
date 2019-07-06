using Projeto_TCC.BO;
using Projeto_TCC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_TCC.Alterar
{
    public partial class frmUsuario3Cond : Form
    {
        public frmUsuario3Cond()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuario2Cond alt = new frmUsuario2Cond();
            alt.Closed += (s, args) => this.Close();
            alt.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Condominios condominios = new Condominios();
            CondominioBO condominioBO = new CondominioBO();

            condominios.Cond_Cnpj = Convert.ToInt64(txtCNPJ.Text);
            condominios.Cond_Nome = txtNome.Text;
            condominios.Cond_CEP = txtCEP.Text;
            condominios.Cond_Endereco = txtEndereco.Text;
            condominios.Cond_Bairro = txtBairro.Text;
            condominios.Cond_Cidade = txtCidade.Text;
            condominios.Cond_Telefone = mskTelefone.Text;

            condominioBO.Editar(condominios);
            MessageBox.Show("Condomínio editado com sucesso");

            txtCNPJ.Clear();
            txtNome.Clear();
            txtCEP.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            mskTelefone.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Condominios condominios = new Condominios();
            CondominioBO condominioBO = new CondominioBO();

            try
            {
                condominios.Cond_Cnpj = Convert.ToInt64(txtCNPJ.Text);
                condominioBO.Deletar(condominios);

                MessageBox.Show("Condominio excluído com sucesso");

                txtCNPJ.Clear();
                txtNome.Clear();
                txtCEP.Clear();
                txtEndereco.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                mskTelefone.Clear();
            }
            catch
            {
                MessageBox.Show("Preencha corretamente os campos e/ou verifique se esses dados não estão sendo usados");
            }
        }

        private void btnBuscarCEP_Click(object sender, EventArgs e)
        {
            try
            {
                var webService = new WSCorreios.AtendeClienteClient();
                var resposta = webService.consultaCEP(txtCEP.Text);

                txtEndereco.Text = resposta.end;
                txtBairro.Text = resposta.bairro;
                txtCidade.Text = resposta.cidade;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtEndereco.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
            }
        }
    }
}
