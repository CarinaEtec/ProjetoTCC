using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC.Model
{
    class Pets
    {
        private int pet_CodPet;
        private string pet_Nome;
        private Moradores moradores;
        private string pet_Especie;
        private BA bA;

        public Pets()
        {
            BA = new BA();
        }

        public int Pet_CodPet { get => pet_CodPet; set => pet_CodPet = value; }
        public string Pet_Nome { get => pet_Nome; set => pet_Nome = value; }
        public string Pet_Especie { get => pet_Especie; set => pet_Especie = value; }
        internal Moradores Moradores { get => moradores; set => moradores = value; }
        internal BA BA { get => bA; set => bA = value; }
    }
}
