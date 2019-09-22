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
            FuncionariosDAO funcDAO = new FuncionariosDAO();


            try
            {
                func.Nome = txtBusca.Text;
                dataGridView1.DataSource = funcDAO.BuscaNome(txtBusca.Text);
              
            }
            catch
            {
                MessageBox.Show("Preencha corretamente as informações");
            }
        }
    }
}
