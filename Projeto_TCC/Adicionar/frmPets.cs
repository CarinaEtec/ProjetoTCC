using Projeto_TCC;
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

namespace Projeto_TCC.Adicionar
{
    public partial class frmPets : Form
    {
        public frmPets()
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
            //BA ba = new BA();
            //BADAO baDao = new BADAO();

            ////try
            ////{
            //    ba.Apto = txtApto.Text;
            //    ba.Bloco = txtBloco.Text;

            //    baDao.BuscaCodBA(ba.Apto, ba.Bloco);

            //    if ((ba.Apto == "") && (ba.Bloco == ""))
            //    {
            //        MessageBox.Show("Apto/Bloco não encontrado");
            //        txtApto.Clear();
            //        txtBloco.Clear();
            //    }
            //    else
            //    {
            //    // lblBACod.Text = Convert.ToString(ba.Ba_Cod);
            //    txtTutor.Text = Convert.ToString(ba.Ba_Cod);
            //}
            ////}





            try
            {
                Pets mor = new Pets();
                PetsBO morBO = new PetsBO();

                mor.Nome = txtNome.Text;
                mor.Moradores.CodMorador = Convert.ToInt16(txtTutor.Text);
                mor.BA.Ba_Cod = Convert.ToInt16(txtApto.Text);
                mor.Especie = txtEspecie.Text;

                morBO.Gravar(mor);
                MessageBox.Show("Pet cadastrado com sucesso");

                txtNome.Clear();
                txtApto.Clear();
                txtBloco.Clear();
                txtTutor.Clear();
                txtEspecie.Clear();
            }
            catch
            {
                MessageBox.Show("Verifique os dados e tente novamente");
            }
        }
    }
}
