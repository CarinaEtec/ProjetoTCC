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
            frmAltDados menuzinho = new frmAltDados();
            menuzinho.Closed += (s, args) => this.Close();
            menuzinho.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
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

            condominioBO.Editar(condominios);
            MessageBox.Show("Condomínio editado com sucesso");

            txtCNPJ.Clear();
            txtNome.Clear();
            txtCEP.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            mskTelefone.Clear();
            txtBusca.Clear();

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].DataGridView.Columns.Clear();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Condominios condominios = new Condominios();
            CondominioBO condominioBO = new CondominioBO();

            try
            {
                condominios.Cnpj = Convert.ToInt64(txtCNPJ.Text);
                condominioBO.Deletar(condominios);

                MessageBox.Show("Condominio excluído com sucesso");

                txtCNPJ.Clear();
                txtNome.Clear();
                txtCEP.Clear();
                txtEndereco.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                mskTelefone.Clear();
                txtBusca.Clear();


                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].DataGridView.Columns.Clear();
                }
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

        private void frmUsuario3Cond_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel2.Visible = true;

            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }

       
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].DataGridView.Columns.Clear();
            }
            txtCNPJ.Clear();
            txtNome.Clear();
            txtCEP.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            mskTelefone.Clear();

            Condominios cond = new Condominios();
            CondominioBO condBO = new CondominioBO();

            if (rbtCNPJ.Checked)
            {
                try
                {
                    cond.Cnpj = Convert.ToInt64(txtBusca.Text);
                    condBO.BuscarCNPJ(cond);

                    if (cond.Nome == "")
                    {
                        MessageBox.Show("Condomínio não encontrado");
                        txtBusca.Clear();
                    }
                    else
                    {
                        txtNome.Text = cond.Nome;
                        txtCNPJ.Text = Convert.ToString(cond.Cnpj);
                        txtCEP.Text = cond.Cep;
                        txtEndereco.Text = cond.Endereco;
                        txtBairro.Text = cond.Bairro;
                        txtCidade.Text = cond.Cidade;
                        mskTelefone.Text = cond.Telefone;

                        panel1.Enabled = true;
                        btnAlterar.Enabled = true;
                        btnExcluir.Enabled = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Preencha corretamente as informações");

                }
            }
            else if (rbtNome.Checked)
            {
                try
                {
                    cond.Nome = txtBusca.Text;
                    dataGridView1.DataSource = condBO.BuscarPorNome(cond);
                }
                catch
                {
                    MessageBox.Show("Preencha os dados corretamente");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linhaSelecionada;
            linhaSelecionada = dataGridView1.CurrentRow;


            txtCNPJ.Text = linhaSelecionada.Cells[0].Value.ToString();
            txtNome.Text = linhaSelecionada.Cells[1].Value.ToString();
            txtCEP.Text = linhaSelecionada.Cells[2].Value.ToString();
            txtEndereco.Text = linhaSelecionada.Cells[3].Value.ToString();
            txtBairro.Text = linhaSelecionada.Cells[4].Value.ToString();
            txtCidade.Text = linhaSelecionada.Cells[5].Value.ToString();
            mskTelefone.Text = linhaSelecionada.Cells[6].Value.ToString();

            panel1.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }
    }
}
