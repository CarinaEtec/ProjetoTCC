using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC.Model
{
    class Locacoes
    {
        private int lo_CodLocacao;
        private Moradores moradores;
        private DateTime lo_Inicio;
        private DateTime lo_Termino;
        private BA bA;

        public Locacoes()
        {
            BA = new BA();
        }

        public int Lo_CodLocacao { get => lo_CodLocacao; set => lo_CodLocacao = value; }
        internal Moradores Moradores { get => moradores; set => moradores = value; }
        public DateTime Lo_Inicio { get => lo_Inicio; set => lo_Inicio = value; }
        public DateTime Lo_Termino { get => lo_Termino; set => lo_Termino = value; }
        internal BA BA { get => bA; set => bA = value; }
    }
}
