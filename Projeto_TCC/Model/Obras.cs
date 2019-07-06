using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC.Model
{
    class Obras
    {
        private int ob_CodObras;
        private Moradores moradores;
        private DateTime ob_DataHora;
        private BA bA;

        public Obras()
        {
            BA = new BA();
        }

        public int Ob_CodObras { get => ob_CodObras; set => ob_CodObras = value; }
        public DateTime Ob_DataHora { get => ob_DataHora; set => ob_DataHora = value; }
        internal Moradores Moradores { get => moradores; set => moradores = value; }
        internal BA BA { get => bA; set => bA = value; }
    }
}
