﻿using Projeto_TCC.BO;
using Projeto_TCC.DAO;
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
            FuncionariosDAO funcDAO = new FuncionariosDAO();

            if (rbtNome.Checked)
            {

                try
                {
                    func.Nome = txtBusca.Text;

                    dataGridView1.DataSource = funcDAO.BuscaNome(txtBusca.Text);
                }
                catch
                {
                    MessageBox.Show("Preencha corretamente as informações");
                }
            }
            if (rbtCPF.Checked)
            {

                try
                {
                    func.Cpf = Convert.ToInt64(mskBuscaCPF.Text);
                    funcBO.BuscaCPF(func);


                    if (func.Cpf == 0)
                    {
                        MessageBox.Show("Funcionário não encontrado");

                    }
                    else
                    {
                        txtNome.Text = func.Nome;
                        mskCPF.Text = Convert.ToString(func.Cpf);
                        func.Funcao = cbbFuncao.SelectedItem.ToString();
                        mskTelefone.Text = func.Telefone;
                        mskCelular.Text = func.Celular;
                        txtSenha.Text = func.Senha;

                        panel1.Enabled = true;
                        btnAlterar.Enabled = true;
                        btnExcluir.Enabled = true;
                        mskBuscaCPF.Clear();

                        mskBuscaCPF.Visible = false;
                        txtBusca.Visible = true;
                        txtBusca.Enabled = true;
                        rbtNome.Checked = true;
                        rbtCPF.Checked = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Preencha corretamente as informações");
                }

            }
        }

        private void frmUsuario3Func_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;

            mskBuscaCPF.Visible = false;
            rbtNome.Checked = true;

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
                func.Funcao = cbbFuncao.SelectedItem.ToString();
                func.Telefone = mskTelefone.Text;
                func.Celular = mskCelular.Text;
                func.Senha = txtSenha.Text;

                funcBO.Editar(func);
                MessageBox.Show("Funcionário editado com sucesso");

                txtNome.Clear();
                mskCPF.Clear();
                cbbFuncao.SelectedIndex = -1; 
                mskTelefone.Clear();
                mskCelular.Clear();
                txtBusca.Clear();
                txtSenha.Clear();
                panel1.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Verifique os dados e tente novamente");
            }       
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

                txtNome.Clear();
                mskCPF.Clear();
                cbbFuncao.SelectedIndex = -1; //
                mskTelefone.Clear();
                mskCelular.Clear();
                txtBusca.Clear();
                txtSenha.Clear();
                panel1.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Preencha corretamente os campos e/ou verifique se esses dados não estão sendo usados");
            }           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void rbtNome_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].DataGridView.Columns.Clear();
            }

            txtBusca.Visible=true;
            mskBuscaCPF.Visible = false;

            txtBusca.Clear();
            txtBusca.Enabled = true;

            mskBuscaCPF.Clear();
            mskBuscaCPF.Enabled = false;
        }

        private void rbtCPF_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].DataGridView.Columns.Clear();
            }

            txtBusca.Visible = false;
            mskBuscaCPF.Visible = true;
            txtBusca.Clear();
            txtBusca.Enabled = false;

            mskBuscaCPF.Clear();
            mskBuscaCPF.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
