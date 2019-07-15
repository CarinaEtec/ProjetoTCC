using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC.Model
{
    class Obras
    {
        private int codObras;
        private Moradores moradores;
        private DateTime dataHora;
        private BA bA;

        public Obras()
        {
            BA = new BA();
        }

        public int CodObras { get => codObras; set => codObras = value; }
        public DateTime DataHora { get => dataHora; set => dataHora = value; }
        internal Moradores Moradores { get => moradores; set => moradores = value; }
        internal BA BA { get => bA; set => bA = value; }
    }
}
