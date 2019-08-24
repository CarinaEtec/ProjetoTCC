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
    public partial class frmObras2 : Form
    {
        public frmObras2()
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

        private void frmObras2_Load(object sender, EventArgs e)
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

            Obras obras = new Obras();
            ObrasBO obrasBO = new ObrasBO();

            try
            {
                obras.CodObras = Convert.ToInt16(txtCod.Text);
                obrasBO.Deletar(obras);

                MessageBox.Show("Obra excluída com sucesso");

                mskData.Clear();
                txtApto.Clear();
                txtBloco.Clear(); ;
                txtProprietario.Clear();

                txtBusca.Clear();
                panel1.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;

                txtCod.Clear();
            }
            catch
            {
                MessageBox.Show("Verifique os dados e tente novamente");
            }
        }
    }
}
