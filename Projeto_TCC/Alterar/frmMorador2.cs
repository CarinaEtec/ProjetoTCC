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
    public partial class frmMorador2 : Form
    {
        public frmMorador2()
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

        private void frmMorador2_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel2.Visible = true;

            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;

            lblMoradorCod.Visible = false;
            lblBACod.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Moradores mor = new Moradores();
            MoradoresBO morBO = new MoradoresBO();
            MoradorDAO DAO = new MoradorDAO();

            if (rbtNome.Checked)
            {
                try
                {
                    mor.Nome = txtBusca.Text;

                    dataGridView1.DataSource = DAO.BuscaMaior(txtBusca.Text);
                }
                catch
                {
                    MessageBox.Show("Preencha corretamente as informações");
                }
            }

            if (rbtApto.Checked)
            {
                try
                {
                    mor.BA.Apto = txtBusca.Text;

                    dataGridView1.DataSource = DAO.BuscaAptoMaior(txtBusca.Text);
                }
                catch
                {
                    MessageBox.Show("Preencha corretamente as informações");
                }
            }
            if (rbtBloco.Checked)
            {
                try
                {
                    mor.BA.Bloco = txtBusca.Text;

                    dataGridView1.DataSource = DAO.BuscaBlocoMaior(txtBusca.Text);
                }
                catch
                {
                    MessageBox.Show("Preencha corretamente as informações");
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].DataGridView.Columns.Clear();
            }

            try
            {
                Moradores mor = new Moradores();
                MoradoresBO morBO = new MoradoresBO();

                mor.CodMorador = Convert.ToInt16(lblMoradorCod.Text);
                mor.Nome = txtNome.Text;
                mor.DataNasc = Convert.ToDateTime(mskDataNasc.Text);
                mor.Situacao = txtSituacao.Text;
                mor.Telefone = mskTelefone.Text;
                mor.Celular = mskCelular.Text;
                mor.BA.Ba_Cod = Convert.ToInt16(lblBACod.Text);

                morBO.Editar(mor);
                MessageBox.Show("Morador editado com sucesso");

                txtNome.Clear();
                mskDataNasc.Clear();
                txtSituacao.Clear();
                mskTelefone.Clear();
                mskCelular.Clear();
                txtApto.Clear();
                txtBloco.Clear();
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
            Moradores mor = new Moradores();
            MoradoresBO morBO = new MoradoresBO();

            try
            {
                mor.CodMorador = Convert.ToInt16(lblMoradorCod.Text);
                morBO.Deletar(mor);

                MessageBox.Show("Morador excluído com sucesso");

                txtNome.Clear();
                mskDataNasc.Clear();
                txtSituacao.Clear();
                mskTelefone.Clear();
                mskCelular.Clear();
                txtApto.Clear();
                txtBloco.Clear();
                panel1.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Preencha corretamente os campos e/ou verifique se esses dados não estão sendo usados");
                txtNome.Clear();
                mskDataNasc.Clear();
                txtSituacao.Clear();
                mskTelefone.Clear();
                mskCelular.Clear();
                txtApto.Clear();
                txtBloco.Clear();
                panel1.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linhaSelecionada;
            linhaSelecionada = dataGridView1.CurrentRow;

            txtApto.Text = linhaSelecionada.Cells[0].Value.ToString();
            txtBloco.Text = linhaSelecionada.Cells[1].Value.ToString();
            txtNome.Text = linhaSelecionada.Cells[2].Value.ToString();
            txtSituacao.Text = linhaSelecionada.Cells[3].Value.ToString();
            mskTelefone.Text = linhaSelecionada.Cells[4].Value.ToString();
            mskCelular.Text = linhaSelecionada.Cells[5].Value.ToString();
            mskDataNasc.Text = linhaSelecionada.Cells[6].Value.ToString();

            panel1.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;

            try
            {
                //puxar codigo do BA
                BA ba = new BA();
                BABO babo = new BABO();

                ba.Apto = txtApto.Text;
                ba.Bloco = txtBloco.Text;

                babo.BuscaCodBA(ba);
                lblBACod.Text = Convert.ToString(ba.Ba_Cod);

                //puxar codigo do MORADOR
                Moradores mor = new Moradores();
                MoradoresBO morBO = new MoradoresBO();

                mor.Nome = txtNome.Text;
                morBO.Buscar(mor);

                lblMoradorCod.Text = Convert.ToString(mor.CodMorador);
            }
            catch
            {
                MessageBox.Show("Verifique os dados e tente novamente");
            }
        }
    }
}
