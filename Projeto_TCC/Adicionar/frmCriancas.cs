﻿using Projeto_TCC;
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
    public partial class frmCriancas : Form
    {
        public frmCriancas()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddDados add = new frmAddDados();
            add.Closed += (s, args) => this.Close();
            add.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //puxar codigo do ba
                BA ba = new BA();
                BABO babo = new BABO();

                ba.Apto = txtApto.Text;
                ba.Bloco = txtBloco.Text;

                babo.BuscaCodBA(ba);

                if ((ba.Bloco == "") && (ba.Apto == ""))
                {
                    MessageBox.Show("Bloco/Apartamento não encontrado");
                    txtApto.Clear();
                    txtBloco.Clear();
                }

                else
                {
                    lblBACod.Text = Convert.ToString(ba.Ba_Cod);
                    try
                    {
                        Moradores mor = new Moradores();
                        MoradoresBO morBO = new MoradoresBO();

                        mor.Nome = txtNome.Text;

                        if ((mor.Nome == "") || (mor.Nome == null))
                        {
                            MessageBox.Show("Nome da criança não identificado");
                        }
                        else
                        {

                            mor.Nome = txtNome.Text;
                            mor.DataNasc = Convert.ToDateTime(mskDataNasc.Text);
                            mor.Situacao = cbbSituacao.SelectedItem.ToString();
                            mor.Telefone = mskTelefone.Text;
                            mor.Celular = mskCelular.Text;
                            mor.BA.Ba_Cod = Convert.ToInt16(lblBACod.Text);

                            morBO.Gravar(mor);
                            MessageBox.Show("Criança cadastrada com sucesso");

                            txtApto.Clear();
                            txtBloco.Clear();
                            txtNome.Clear();
                            mskDataNasc.Clear();
                            mskTelefone.Clear();
                            mskCelular.Clear();

                            cbbSituacao.SelectedIndex = -1;
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Verifique os dados e tente novamente");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Verifique os dados e tente novamente");
            }
        }

        private void frmCriancas_Load(object sender, EventArgs e)
        {
            lblBACod.Visible = false;
        }
    }
}
