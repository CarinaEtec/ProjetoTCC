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
    public partial class frmLocacao : Form
    {
        public frmLocacao()
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
            Locacoes loc = new Locacoes();
            LocacoesBO locBO = new LocacoesBO();
            LocacoesDAO locDAO = new LocacoesDAO();

            if (rbtData.Checked)
            {
                //try
                //{
                loc.Inicio = Convert.ToDateTime(mskHorarioInicio.Text);

                dataGridView1.DataSource = locDAO.BuscaData(loc.Inicio);
                for (int i = 0; i == dataGridView1.RowCount; i++)
                {
                    MessageBox.Show("Nenhuma locação encontrada");
                    mskHorarioInicio.Clear();
                }
                //}
                //catch
                //{
                //    MessageBox.Show("Preencha corretamente as informações");
                //}
            }
            if (rbtApto.Checked)
            {
                try
                {
                    loc.BA.Apto = txtBusca.Text;

                    dataGridView1.DataSource = locDAO.BuscaApto(txtBusca.Text);
                    for (int i = 0; i == dataGridView1.RowCount; i++)
                    {
                        MessageBox.Show("Nenhuma locação encontrada");
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
                    loc.BA.Bloco = txtBusca.Text;

                    dataGridView1.DataSource = locDAO.BuscaBloco(txtBusca.Text);
                    for (int i = 0; i == dataGridView1.RowCount; i++)
                    {
                        MessageBox.Show("Nenhuma locação encontrada");
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
            mskHorarioInicio.Clear();
            mskHorarioInicio.Enabled = false;
            txtBusca.Enabled = true;
        }

        private void rbtApto_CheckedChanged(object sender, EventArgs e)
        {
            mskHorarioInicio.Clear();
            mskHorarioInicio.Enabled = false;
            txtBusca.Enabled = true;
        }

        private void rbtData_CheckedChanged(object sender, EventArgs e)
        {
            txtBusca.Clear();
            txtBusca.Enabled = false;
            mskHorarioInicio.Enabled = true;
            mskHorarioInicio.Clear();
        }
    }
}
