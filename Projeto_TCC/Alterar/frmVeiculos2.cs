﻿using System;
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
            frmVeiculos1 alterar = new frmVeiculos1();
            alterar.Closed += (s, args) => this.Close();
            alterar.Show();
        }
    }
}
