﻿using System;
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
    public partial class frmAltVeiculos1 : Form
    {
        public frmAltVeiculos1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltVeiculos alterar = new frmAltVeiculos();
            alterar.Closed += (s, args) => this.Close();
            alterar.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltDados menu = new frmAltDados();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }
    }
}
