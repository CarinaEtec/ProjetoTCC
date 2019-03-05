using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTCC
{
    public partial class AddDados : Form
    {
        public AddDados()
        {
            InitializeComponent();
        }                                                                                                                                                                                

        private void AddDados_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menuzinho = new Menu();
            menuzinho.Closed += (s, args) => this.Close();
            menuzinho.Show();
        }

        private void btnCriancas_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCriancas pirralhos = new AddCriancas();
            pirralhos.Closed += (s, args) => this.Close();
            pirralhos.Show();
        }

        private void btnAnimais_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPets pets = new AddPets();
            pets.Closed += (s, args) => this.Close();
            pets.Show();
        }
    }
}
