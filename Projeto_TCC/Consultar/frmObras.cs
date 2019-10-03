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
    public partial class frmObras : Form
    {
        public frmObras()
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
            Obras obras = new Obras();
            ObrasBO obrasBO = new ObrasBO();
            ObrasDAO obrasDAO = new ObrasDAO();

            if (rbtApto.Checked)
            {
                try
                {
                    obras.BA.Apto = txtBusca.Text;

                    dataGridView1.DataSource = obrasDAO.BuscaApto(txtBusca.Text);
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
                    obras.BA.Bloco = txtBusca.Text;

                    dataGridView1.DataSource = obrasDAO.BuscaBloco(txtBusca.Text);
                }
                catch
                {
                    MessageBox.Show("Preencha corretamente as informações");
                }
            }
        }
    }
}
