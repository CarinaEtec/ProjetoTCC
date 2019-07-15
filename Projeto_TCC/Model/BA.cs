﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC.Model
{
    class BA
    {
        private int ba_Cod;
        private string apto;
        private string bloco;
        private Condominios condominios;

        public BA()
        {
            Condominios = new Condominios();
        }

        public int Ba_Cod { get => ba_Cod; set => ba_Cod = value; }
        public string Apto { get => apto; set => apto = value; }
        public string Bloco { get => bloco; set => bloco = value; }
        internal Condominios Condominios { get => condominios; set => condominios = value; }
    }
}
