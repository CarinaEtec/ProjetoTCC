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
            Form1 inicio = new Form1();
            inicio.Closed += (s, args) => this.Close();
            inicio.Show();
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

                    condominios.Cnpj = Convert.ToInt64(txtCNPJ.Text);
                    condominios.Nome = txtNome.Text;
                    condominios.Cep = txtCEP.Text;
                    condominios.Endereco = txtEndereco.Text;
                    condominios.Bairro = txtBairro.Text;
                    condominios.Cidade = txtCidade.Text;
                    condominios.Telefone = mskTelefone.Text;

                    condominioBO.Gravar(condominios);
                    MessageBox.Show("Condomínio cadastrado com sucesso");

                    txtCNPJ.Clear();
                    txtNome.Clear();
                    txtCEP.Clear();
                    txtEndereco.Clear();
                    txtBairro.Clear();
                    txtCidade.Clear();
                    mskTelefone.Clear();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuario3Cond add = new frmUsuario3Cond();
            add.Closed += (s, args) => this.Close();
            add.Show();
        }
    }
}
