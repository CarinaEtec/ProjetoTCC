using Projeto_TCC;
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
    public partial class frmUsuario1 : Form
    {
        public frmUsuario1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 add = new Form1();
            add.Closed += (s, args) => this.Close();
            add.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //try
            //{
                string valor = txtCpf.Text;
                if (ValidaCPF.IsCpf(valor))
                {
                    Funcionarios func = new Funcionarios();
                    FuncionariosBO funcBO = new FuncionariosBO();

                    txtNome.Text = func.Nome;
                    txtCpf.Text = Convert.ToString(func.Cpf);
                    txtFuncao.Text = func.Funcao;
                    mskTelefone.Text = func.Telefone;
                    mskCelular.Text = func.Celular;
                    txtSenha.Text = func.Senha;

                    funcBO.Gravar(func);
                    MessageBox.Show("Funcionário cadastrado com sucesso");

                    txtNome.Clear();
                    txtCpf.Clear();
                    txtFuncao.Clear();
                    mskTelefone.Clear();
                    mskCelular.Clear();
                    txtSenha.Clear();
                }
                else
                {
                    MessageBox.Show("CPF Inválido !");
                    txtCpf.Clear();
                }
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Verifique os dados e tente novamente");
            //    }
        }

        private void frmUsuario1_Load(object sender, EventArgs e)
        {

        }
    }
}
