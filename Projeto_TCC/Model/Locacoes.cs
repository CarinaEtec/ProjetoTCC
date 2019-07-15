﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC.Model
{
    class Locacoes
    {
        private int codLocacao;
        private Moradores moradores;
        private DateTime inicio;
        private DateTime termino;
        private BA bA;

        public Locacoes()
        {
            BA = new BA();
        }

        internal Moradores Moradores { get => moradores; set => moradores = value; }

        public int CodLocacao { get => codLocacao; set => codLocacao = value; }
        public DateTime Inicio { get => inicio; set => inicio = value; }
        public DateTime Termino { get => termino; set => termino = value; }
        internal BA BA { get => bA; set => bA = value; }

    }
}
