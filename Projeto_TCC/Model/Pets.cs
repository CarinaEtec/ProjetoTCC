using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC.Model
{
    class Pets
    {
        private int codPet;
        private string nome;
        private Moradores moradores;
        private string especie;
        private BA bA;

        public Pets()
        {
            BA = new BA();
        }

        public int CodPet { get => codPet; set => codPet = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Especie { get => especie; set => especie = value; }

        internal Moradores Moradores { get => moradores; set => moradores = value; }
        internal BA BA { get => bA; set => bA = value; }
    }
}
