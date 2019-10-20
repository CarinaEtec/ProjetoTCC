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
    public partial class frmVeiculos2 : Form
    {
        public frmVeiculos2()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltDados menu = new frmAltDados();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void frmVeiculos2_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
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

            //CÓDIGO PARA VERIFICAR SE A BUSCA TEVE RESULTADOS
            //COMO O CÓDIGO DA BUSCA AINDA NÃO FOI CONCLUÍDO, NÃO VAI FUNCIONAR 
            //NA PARTE DE USUÁRIOS ESTÁ COMPLETO E FUNCIONANDO 

            Veiculos veiculos = new Veiculos();
            VeiculosBO veiculosBO = new VeiculosBO();


            veiculos.Placa = txtBusca.Text;
            //dataGridView1.DataSource = morBO.BuscarPorNOME(mor);

            for (int i = 0; i == dataGridView1.RowCount; i++)
            {
                MessageBox.Show("Nenhum veículo encontrado");
                txtBusca.Clear();
            }




        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].DataGridView.Columns.Clear();
            }

            Veiculos veiculos = new Veiculos();
            VeiculosBO veiculosBO = new VeiculosBO();

            try
            {
                veiculos.Placa = mskPlaca.Text;
                veiculosBO.Deletar(veiculos);

                MessageBox.Show("Veículo excluído com sucesso");

                txtProprietario.Clear();
                txtApto.Clear();
                txtBloco.Clear(); ;
                mskPlaca.Clear();
                txtModelo.Clear();
                cbbCor.SelectedIndex = -1;
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


                        mor.Nome = txtProprietario.Text;
                        morBO.Buscar(mor);

                        if (mor.Nome == "")
                        {
                            MessageBox.Show("Proprietário não encontrado");
                            txtProprietario.Clear();
                        }

                        else
                        {
                            lblMoradorCod.Text = Convert.ToString(mor.CodMorador);
                            //altera o pet
                            try
                            {
                                Veiculos veiculos = new Veiculos();
                                VeiculosBO veiculosBO = new VeiculosBO();

                                veiculos.Placa = mskPlaca.Text;
                                veiculos.Modelo = txtModelo.Text;
                                veiculos.Moradores.CodMorador = Convert.ToInt16(lblMoradorCod.Text);
                                veiculos.BA.Ba_Cod = Convert.ToInt16(lblBACod.Text);
                                veiculos.Cor = cbbCor.SelectedItem.ToString();

                                veiculosBO.Editar(veiculos);
                                MessageBox.Show("Veículo editado com sucesso");

                                mskPlaca.Clear();
                                txtApto.Clear();
                                txtBloco.Clear(); ;
                                txtModelo.Clear();
                                txtProprietario.Clear();
                                txtBusca.Clear();
                                cbbCor.SelectedIndex = -1;


                                panel1.Enabled = false;
                                btnAlterar.Enabled = false;
                                btnExcluir.Enabled = false;
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
    }
}
