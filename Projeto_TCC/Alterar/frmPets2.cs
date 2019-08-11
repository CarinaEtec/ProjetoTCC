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
    public partial class frmPets2 : Form
    {
        public frmPets2()
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Pets pet = new Pets();
            PetsBO petBO = new PetsBO();

            try
            {
                pet.Nome = txtBusca.Text;

                //dataGridView1.DataSource = petBO.BuscarPorNOME(pet);
                panel1.Enabled = true;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Preencha corretamente as informações");
            }


        }

        private void frmPets2_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].DataGridView.Columns.Clear();
            }

            try
            {
                Pets mor = new Pets();
                PetsBO morBO = new PetsBO();

                mor.CodPet = Convert.ToInt16(txtCod.Text);
                mor.Nome = txtNome.Text;
                mor.Moradores.CodMorador = Convert.ToInt16(txtTutor.Text);
                mor.BA.Ba_Cod = Convert.ToInt16(txtApto.Text);
                mor.Especie = txtEspecie.Text;

                morBO.Editar(mor);
                MessageBox.Show("Pet editado com sucesso");

                txtNome.Clear();
                txtApto.Clear();
                txtBloco.Clear(); ;
                txtTutor.Clear();
                txtEspecie.Clear();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].DataGridView.Columns.Clear();
            }

            Pets pet = new Pets();
            PetsBO petBO = new PetsBO();

            try
            {
                pet.CodPet = Convert.ToInt16(txtCod.Text);
                petBO.Deletar(pet);

                MessageBox.Show("Pet excluído com sucesso");

                txtNome.Clear();
                txtApto.Clear();
                txtBloco.Clear(); ;
                txtTutor.Clear();
                txtEspecie.Clear();
                txtBusca.Clear();
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
