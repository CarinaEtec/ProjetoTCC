﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_TCC.BO;
using Projeto_TCC.DAO;
using Projeto_TCC.Model;

namespace Projeto_TCC.Consultar
{
    public partial class frmCriancas : Form
    {
        public frmCriancas()
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Moradores moradores = new Moradores();
            MoradoresBO moradoresBO = new MoradoresBO();
            MoradorDAO moradordao = new MoradorDAO();
            this.dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);

            if (rbtNome.Checked)
            {
                try
                {
                    moradores.Nome = txtBuscaNome.Text;
                    dataGridView1.DataSource = moradordao.BuscaMenor(txtBuscaNome.Text);

                    for (int i = 0; i == dataGridView1.RowCount; i++)
                    {
                        MessageBox.Show("Nenhuma criança encontrada");
                        txtBuscaNome.Clear();
                    }
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
                    moradores.BA.Apto = txtBusca.Text;
                    dataGridView1.DataSource = moradordao.BuscaAptoMenor(txtBusca.Text);

                    for (int i = 0; i == dataGridView1.RowCount; i++)
                    {
                        MessageBox.Show("Nenhuma criança encontrada");
                        txtBusca.Clear();
                    }
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
                    moradores.BA.Bloco = txtBusca.Text;
                    dataGridView1.DataSource = moradordao.BuscaBlocoMenor(txtBusca.Text);

                    for (int i = 0; i == dataGridView1.RowCount; i++)
                    {
                        MessageBox.Show("Nenhuma criança encontrada");
                        txtBusca.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Preencha corretamente as informações");
                }
            }
        }

        private void rbtBloco_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscaNome.Clear();
            txtBuscaNome.Enabled = false;
            txtBusca.Enabled = true;

        }

        private void rbtApto_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscaNome.Clear();
            txtBuscaNome.Enabled = false;
            txtBusca.Enabled = true;
        }

        private void rbtNome_CheckedChanged(object sender, EventArgs e)
        {
            txtBusca.Clear();
            txtBusca.Enabled = false;
            txtBuscaNome.Enabled = true;
            txtBuscaNome.Clear();
        }

        private void frmCriancas_Load(object sender, EventArgs e)
        {
            rbtApto.Checked = true;

        }
    }
}
