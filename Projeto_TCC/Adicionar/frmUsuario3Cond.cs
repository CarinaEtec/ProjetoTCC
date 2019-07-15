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
    public partial class frmUsuario3Cond : Form
    {
        public frmUsuario3Cond()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuario1 fim = new frmUsuario1();
            fim.Closed += (s, args) => this.Close();
            fim.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuario2Cond add = new frmUsuario2Cond();
            add.Closed += (s, args) => this.Close();
            add.Show();
        }

        private void btnSalvarBloco_Click(object sender, EventArgs e)
        {
            try
            {
                    BA ba = new BA();
                    BABO baBO = new BABO();

                    ba.Bloco = txtBloco.Text;
                    ba.Apto = "0";
                    ba.Condominios.Cnpj = Convert.ToInt64(txtCNPJ.Text);

                    baBO.Gravar(ba);
                    MessageBox.Show("Bloco cadastrado com sucesso");

                    grpCadApto.Visible = true;
            }
            catch
            {
                MessageBox.Show("Verifique os dados e tente novamente");
            }

        }

        private void frmUsuario3Cond_Load(object sender, EventArgs e)
        {
            grpCadApto.Visible = false;
        }
    }
}
