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

namespace Projeto_TCC.Adicionar
{
    public partial class frmUsuario2Cond : Form
    {
        public frmUsuario2Cond()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuario1 add = new frmUsuario1();
            add.Closed += (s, args) => this.Close();
            add.Show();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            try
            {
                string valor = txtCNPJ.Text;
                if (ValidaCNPJ.IsCnpj(valor))
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

                    condominioBO.Gravar(condominios);
                    MessageBox.Show("Condomínio cadastrado com sucesso");


                    this.Hide();
                    frmUsuario3Cond add = new frmUsuario3Cond();
                    add.Closed += (s, args) => this.Close();
                    add.Show();
                }
                else
                {
                    MessageBox.Show("CNPJ Inválido !");
                    txtCNPJ.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Verifique os dados e tente novamente");
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
