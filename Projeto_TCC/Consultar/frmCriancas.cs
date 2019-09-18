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
using Projeto_TCC.DAO;
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
                MoradorDAO moradordao = new MoradorDAO();

                try
                {
                    moradores.Nome = txtBusca.Text;

                    dataGridView1.DataSource = moradordao.BuscaMenor(txtBusca.Text);


                    // CÓDIGO PARA VERIFICAR SE A BUSCA TEVE RESULTADOS
                    //COMO O CÓDIGO DA BUSCA AINDA NÃO FOI CONCLUÍDO, NÃO VAI FUNCIONAR 
                    //NA PARTE DE USUÁRIOS ESTÁ COMPLETO E FUNCIONANDO 

                    for (int i = 0; i == dataGridView1.RowCount; i++)
                    {
                        MessageBox.Show("Nenhuma criança encontrada");
                        txtBusca.Clear();
                    }

                }
                catch
                {
                    MessageBox.Show("Preencha corretamente as informações");
                }
            }



            if (rbtApto.Checked)
            {
                Moradores moradores = new Moradores();
                MoradoresBO moradoresBO = new MoradoresBO();
                MoradorDAO moradordao = new MoradorDAO();

                try
                {
                    moradores.BA.Apto = txtBusca.Text;

                    dataGridView1.DataSource = moradordao.BuscaAptoMenor(txtBusca.Text);


                    // CÓDIGO PARA VERIFICAR SE A BUSCA TEVE RESULTADOS
                    //COMO O CÓDIGO DA BUSCA AINDA NÃO FOI CONCLUÍDO, NÃO VAI FUNCIONAR 
                    //NA PARTE DE USUÁRIOS ESTÁ COMPLETO E FUNCIONANDO 

                    for (int i = 0; i == dataGridView1.RowCount; i++)
                    {
                        MessageBox.Show("Nenhuma criança encontrada");
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
                Moradores moradores = new Moradores();
                MoradoresBO moradoresBO = new MoradoresBO();
                MoradorDAO moradordao = new MoradorDAO();

                try
                {
                    moradores.BA.Bloco = txtBusca.Text;

                    dataGridView1.DataSource = moradordao.BuscaBlocoMenor(txtBusca.Text);


                    // CÓDIGO PARA VERIFICAR SE A BUSCA TEVE RESULTADOS
                    //COMO O CÓDIGO DA BUSCA AINDA NÃO FOI CONCLUÍDO, NÃO VAI FUNCIONAR 
                    //NA PARTE DE USUÁRIOS ESTÁ COMPLETO E FUNCIONANDO 

                    for (int i = 0; i == dataGridView1.RowCount; i++)
                    {
                        MessageBox.Show("Nenhuma criança encontrada");
                        txtBusca.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Preencha corretamente as informações");
                }
            }
        }
    }
}
