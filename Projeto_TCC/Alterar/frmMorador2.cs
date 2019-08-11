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
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
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

                mor.Nome = txtNome.Text;
                mor.DataNasc = Convert.ToDateTime(mskDataNasc.Text);
                mor.Situacao = txtSituacao.Text;
                mor.Telefone = mskTelefone.Text;
                mor.Celular = mskCelular.Text;
                mor.BA.Ba_Cod = Convert.ToInt16(txtApto.Text);

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
                mor.Nome = txtNome.Text;
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
            }

        }
    }
}
