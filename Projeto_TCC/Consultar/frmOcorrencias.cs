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

namespace Projeto_TCC.Consultar
{
    public partial class frmOcorrencias : Form
    {
        public frmOcorrencias()
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
            // CÓDIGO PARA VERIFICAR SE A BUSCA TEVE RESULTADOS
            //COMO O CÓDIGO DA BUSCA AINDA NÃO FOI CONCLUÍDO, NÃO VAI FUNCIONAR 
            //NA PARTE DE USUÁRIOS ESTÁ COMPLETO E FUNCIONANDO 

            Ocorrencias ocorrencias = new Ocorrencias();
            OcorrenciasBO ocorrenciasBO = new OcorrenciasBO();


            ocorrencias.Moradores.CodMorador = Convert.ToInt16(txtBusca.Text);
            ocorrencias.BA.Apto = txtBusca.Text;
            ocorrencias.BA.Bloco = txtBusca.Text;
            //dataGridView1.DataSource = morBO.BuscarPorNOME(mor);

            for (int i = 0; i == dataGridView1.RowCount; i++)
            {
                MessageBox.Show("Nenhuma obra encontrada");
                txtBusca.Clear();
            }
        }
    }
}
