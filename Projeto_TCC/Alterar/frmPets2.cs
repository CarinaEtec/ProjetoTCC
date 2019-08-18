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

            lblMoradorCod.Visible = false;
            lblBACod.Visible = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].DataGridView.Columns.Clear();
            }


            try
            {
                //pega codigo bloco apartamento
                BA ba = new BA();
                BABO babo = new BABO();

                ba.Apto = txtApto.Text;
                ba.Bloco = txtBloco.Text;

                babo.BuscaCodBA(ba);

                if ((ba.Bloco == "") && (ba.Apto == ""))
                {
                    MessageBox.Show("Bloco/Apartamento não encontrado");
                }

                else
                {
                    lblBACod.Text = Convert.ToString(ba.Ba_Cod);


                    try
                    {   //pega codigo morador
                        Moradores mor = new Moradores();
                        MoradoresBO morBO = new MoradoresBO();


                        mor.Nome = txtTutor.Text;
                        morBO.Buscar(mor);

                        if (mor.Nome == "")
                        {
                            MessageBox.Show("Tutor não encontrado");
                            txtTutor.Clear();
                        }

                        else
                        {
                            lblMoradorCod.Text = Convert.ToString(mor.CodMorador);
                            //altera o pet
                            try
                            {
                                Pets pets = new Pets();
                                PetsBO petsBO = new PetsBO();

                                pets.CodPet = Convert.ToInt16(txtCod.Text);
                                pets.Nome = txtNome.Text;
                                pets.Moradores.CodMorador = Convert.ToInt16(lblMoradorCod.Text);
                                pets.BA.Ba_Cod = Convert.ToInt16(lblBACod.Text);
                                pets.Especie = txtEspecie.Text;

                                petsBO.Editar(pets);
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
                                txtCod.Clear();
                            }
                            catch
                            {
                                MessageBox.Show("Verifique os dados e tente novamente");
                            }
                        }
                    }

                    catch
                    {
                        MessageBox.Show("Verifique os dados e tente novamente");
                    }
                }

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

                txtCod.Clear();
            }
            catch
            {
                MessageBox.Show("Verifique os dados e tente novamente");
            }

        }
    }
}
