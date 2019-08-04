using Projeto_TCC;
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
                Moradores mor = new Moradores();
                MoradoresBO morBO = new MoradoresBO();

                mor.Nome = txtNome.Text;
                mor.DataNasc = Convert.ToDateTime(mskDataNasc.Text);
                mor.Situacao = txtSituacao.Text;
                mor.Telefone = mskTelefone.Text;
                mor.Celular = mskCelular.Text;
                mor.BA.Ba_Cod = Convert.ToInt16(txtApto.Text);

                morBO.Gravar(mor);
                MessageBox.Show("Morador cadastrado com sucesso");

                txtApto.Clear();
                txtBloco.Clear();
                txtNome.Clear();
                mskDataNasc.Clear();
                txtSituacao.Clear();
                mskTelefone.Clear();
                mskCelular.Clear();
            }
            catch
            {
                MessageBox.Show("Verifique os dados e tente novamente");
            }
        }
    }
}
