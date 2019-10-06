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
    public partial class frmObras2 : Form
    {
        public frmObras2()
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

        private void frmObras2_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel2.Visible = true;

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


            // CÓDIGO PARA VERIFICAR SE A BUSCA TEVE RESULTADOS
            //COMO O CÓDIGO DA BUSCA AINDA NÃO FOI CONCLUÍDO, NÃO VAI FUNCIONAR 
            //NA PARTE DE USUÁRIOS ESTÁ COMPLETO E FUNCIONANDO 

            Obras obras = new Obras();
            ObrasBO obrasBO = new ObrasBO();

            obras.DataHora = Convert.ToDateTime(txtBusca.Text);
            obras.BA.Apto = txtBusca.Text;
            obras.BA.Bloco = txtBusca.Text;
            //dataGridView1.DataSource = morBO.BuscarPorNOME(mor);

            for (int i = 0; i == dataGridView1.RowCount; i++)
            {
                MessageBox.Show("Nenhuma obra encontrada");
                txtBusca.Clear();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].DataGridView.Columns.Clear();
            }

            Obras obras = new Obras();
            ObrasBO obrasBO = new ObrasBO();

            try
            {
                obras.CodObras = Convert.ToInt16(txtCod.Text);
                obrasBO.Deletar(obras);

                MessageBox.Show("Obra excluída com sucesso");

                mskData.Clear();
                txtApto.Clear();
                txtBloco.Clear(); ;
                txtProprietario.Clear();

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
                            Obras obras = new Obras();
                            ObrasBO obrasBO = new ObrasBO();


                            obras.Moradores.CodMorador = Convert.ToInt16(lblMoradorCod.Text);
                            obras.BA.Ba_Cod = Convert.ToInt16(lblBACod.Text);
                            obras.DataHora = Convert.ToDateTime(mskData.Text);
                            obras.CodObras = Convert.ToInt16(txtCod.Text);

                            obrasBO.Editar(obras);
                            MessageBox.Show("Obra editada com sucesso");

                            txtProprietario.Clear();
                            txtApto.Clear();
                            txtBloco.Clear();
                            mskData.Clear();

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
    }
}
