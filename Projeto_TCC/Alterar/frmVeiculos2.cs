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
    public partial class frmVeiculos2 : Form
    {
        public frmVeiculos2()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltDados menu = new frmAltDados();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void frmVeiculos2_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;

            lblMoradorCod.Visible = false;
            lblBACod.Visible = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].DataGridView.Columns.Clear();
            }

            Veiculos veiculos = new Veiculos();
            VeiculosBO veiculosBO = new VeiculosBO();

            try
            {
                veiculos.Placa = mskPlaca.Text;
                veiculosBO.Deletar(veiculos);

                MessageBox.Show("Veículo excluído com sucesso");

                txtProprietario.Clear();
                txtApto.Clear();
                txtBloco.Clear(); ;
                mskPlaca.Clear();
                txtModelo.Clear();
                txtCor.Clear();
                txtBusca.Clear();

                panel1.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;

            }
            catch
            {
                MessageBox.Show("Verifique os dados e tente novamente");
            }

        }
    }
}
