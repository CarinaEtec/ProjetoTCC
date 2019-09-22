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

namespace Projeto_TCC.Consultar
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
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
            Funcionarios func = new Funcionarios();
            FuncionariosBO funcBO = new FuncionariosBO();
            
            try
            {
                func.Nome = txtBusca.Text;
                dataGridView1.DataSource = funcBO.BuscarPorNOME(func);

                for (int i = 0; i == dataGridView1.RowCount; i++)
                {
                    MessageBox.Show("Nenhum usuário encontrado");
                    txtBusca.Clear();
                }

            }
            catch
            {
                MessageBox.Show("Preencha corretamente as informações");
            }
        }
    }
}
