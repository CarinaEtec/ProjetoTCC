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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnEnrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menuzin = new Menu();
            menuzin.Closed += (s, args) => this.Close();
            menuzin.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

