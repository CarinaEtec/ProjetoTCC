using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_TCC.BO;
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
            if (rbtNome.Checked)
            {
                Moradores moradores = new Moradores();
                MoradoresBO moradoresBO = new MoradoresBO();

                //try
                //{
                    moradores.Nome = txtBusca.Text;

                    dataGridView1.DataSource = moradoresBO.CONSULTA_MenorIdade(moradores);
                //}
                //catch
                //{
                //    MessageBox.Show("Preencha corretamente as informações");
                //}
            }
        }
    }
}
