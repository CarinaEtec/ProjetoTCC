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
    public partial class frmAltMorador : Form
    {
        public frmAltMorador()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltMorador1 busca = new frmAltMorador1();
            busca.Closed += (s, args) => this.Close();
            busca.Show();
        }
    }
}
