using Projeto_TCC.BO;
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

namespace Projeto_TCC.Consultar
{
    public partial class frmVeiculos : Form
    {
        public frmVeiculos()
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
            //CÓDIGO PARA VERIFICAR SE A BUSCA TEVE RESULTADOS
            //COMO O CÓDIGO DA BUSCA AINDA NÃO FOI CONCLUÍDO, NÃO VAI FUNCIONAR 
            //NA PARTE DE USUÁRIOS ESTÁ COMPLETO E FUNCIONANDO 

            Veiculos veiculos = new Veiculos();
            VeiculosBO veiculosBO = new VeiculosBO();
            VeiculosDAO veiculosdao = new VeiculosDAO();


            if (rbtPlaca.Checked)
            {
                try
                {
                    veiculos.Placa = mskPlaca.Text;

                    dataGridView1.DataSource = veiculosdao.BuscaPlaca(mskPlaca.Text);
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
                    veiculos.BA.Apto = txtBusca.Text;

                    dataGridView1.DataSource = veiculosdao.BuscaApto(txtBusca.Text);
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
                    veiculos.BA.Bloco = txtBusca.Text;

                    dataGridView1.DataSource = veiculosdao.BuscaBloco(txtBusca.Text);
                }
                catch
                {
                    MessageBox.Show("Preencha corretamente as informações");
                }
            }



        }

        private void frmVeiculos_Load(object sender, EventArgs e)
        {
            
        }

        private void rbtBloco_CheckedChanged(object sender, EventArgs e)
        {
            mskPlaca.Visible = false;
            txtBusca.Visible = true;
            txtBusca.Clear();
            mskPlaca.Clear();
        }

        private void rbtApto_CheckedChanged(object sender, EventArgs e)
        {
            mskPlaca.Visible = false;
            txtBusca.Visible = true;
            txtBusca.Clear();
            mskPlaca.Clear();
        }

        private void rbtPlaca_CheckedChanged(object sender, EventArgs e)
        {
            mskPlaca.Visible = true;
            txtBusca.Visible = false;
            txtBusca.Clear();
            mskPlaca.Clear();
        }
    }
}
