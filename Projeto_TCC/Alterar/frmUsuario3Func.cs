﻿using Projeto_TCC.BO;
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
            Funcionarios func = new Funcionarios();
            FuncionariosBO funcBO = new FuncionariosBO();

            try
            {
                func.Nome = txtBusca.Text;

                dataGridView1.DataSource = funcBO.BuscarPorNOME(func);
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
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].DataGridView.Columns.Clear();
            }

            try
            {
                Funcionarios func = new Funcionarios();
                FuncionariosBO funcBO = new FuncionariosBO();

                func.Nome = txtNome.Text;
                func.Cpf = Convert.ToInt64(mskCPF.Text);
                func.Funcao = txtFuncao.Text;
                func.Telefone = mskTelefone.Text;
                func.Celular = mskCelular.Text;
                func.Senha = txtSenha.Text;

                funcBO.Editar(func);
                MessageBox.Show("Funcionário editado com sucesso");
            }
            catch
            {
                MessageBox.Show("Verifique os dados e tente novamente");
            }


            txtNome.Clear();
            mskCPF.Clear();
            txtFuncao.Clear(); ;
            mskTelefone.Clear();
            mskCelular.Clear();
            txtBusca.Clear();
            txtSenha.Clear();
            panel1.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].DataGridView.Columns.Clear();
            }

            Funcionarios func = new Funcionarios();
            FuncionariosBO funcBO = new FuncionariosBO();

            try
            {
                func.Cpf = Convert.ToInt64(mskCPF.Text);
                funcBO.Deletar(func);

                MessageBox.Show("Funcionário excluído com sucesso");
            }
            catch
            {
                MessageBox.Show("Preencha corretamente os campos e/ou verifique se esses dados não estão sendo usados");
            }
            txtNome.Clear();
            mskCPF.Clear();
            txtFuncao.Clear(); ;
            mskTelefone.Clear();
            mskCelular.Clear();
            txtBusca.Clear();
            txtSenha.Clear();
            panel1.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linhaSelecionada;
            linhaSelecionada = dataGridView1.CurrentRow;

            txtNome.Text = linhaSelecionada.Cells[0].Value.ToString();
            mskCPF.Text = linhaSelecionada.Cells[1].Value.ToString();
            txtFuncao.Text = linhaSelecionada.Cells[2].Value.ToString();
            mskTelefone.Text = linhaSelecionada.Cells[3].Value.ToString();
            mskCelular.Text = linhaSelecionada.Cells[4].Value.ToString();
            txtSenha.Text = linhaSelecionada.Cells[5].Value.ToString();
            

            panel1.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }
    }
}
