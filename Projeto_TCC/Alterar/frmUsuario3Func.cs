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
    public partial class frmUsuario3Func : Form
    {
        public frmUsuario3Func()
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].DataGridView.Columns.Clear();
            }
            txtNome.Clear();
            mskCpf.Clear();
            cbbFuncao= null;
            mskTelefone.Clear();
            mskCelular.Clear();
            txtSenha.Clear();

            Funcionarios func = new Funcionarios();
            FuncionariosBO funcBO = new FuncionariosBO();

                try
                {
                    func.Nome = txtBusca.Text;
                    funcBO.BuscarPorNome(func);

                    if (func.Nome == "")
                    {
                        MessageBox.Show("Funcionário não encontrado");
                        txtBusca.Clear();
                    }
                    else
                    {
                        txtNome.Text = func.Nome;
                        mskCpf.Text = Convert.ToString(func.Cpf);
                        cbbFuncao.Text = func.Funcao;
                        mskTelefone.Text = func.Telefone;
                        mskCelular.Text = func.Celular;
                        txtSenha.Text = func.Senha;

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

        private void frmUsuario3Func_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Funcionarios func = new Funcionarios();
            FuncionariosBO funcBO = new FuncionariosBO();

            txtNome.Text = func.Nome;
            mskCpf.Text = Convert.ToString(func.Cpf);
            cbbFuncao.Text = func.Funcao;
            mskTelefone.Text = func.Telefone;
            mskCelular.Text = func.Celular;
            txtSenha.Text = func.Senha;

            funcBO.Editar(func);
            MessageBox.Show("Funcionário editado com sucesso");

            txtNome.Clear();
            mskCpf.Clear();
            cbbFuncao = null;
            mskTelefone.Clear();
            mskCelular.Clear();
            txtBusca.Clear();
            txtSenha.Clear();
            panel1.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].DataGridView.Columns.Clear();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Funcionarios func = new Funcionarios();
            FuncionariosBO funcBO = new FuncionariosBO();

            try
            {
                func.Cpf = Convert.ToInt64(mskCpf.Text);
                funcBO.Deletar(func);

                MessageBox.Show("Funcionário excluído com sucesso");

                txtNome.Clear();
                mskCpf.Clear();
                cbbFuncao = null;
                mskTelefone.Clear();
                mskCelular.Clear();
                txtBusca.Clear();
                txtSenha.Clear();
                panel1.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;


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
    }
}
