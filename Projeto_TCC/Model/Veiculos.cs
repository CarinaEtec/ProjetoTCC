using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC.Model
{
    class Veiculos
    {
        private Moradores moradores;
        private string ve_Placa;
        private string ve_Modelo;
        private string ve_Cor;
        private BA bA;

        public Veiculos()
        {
            BA = new BA();
        }

        public string Ve_Placa { get => ve_Placa; set => ve_Placa = value; }
        public string Ve_Modelo { get => ve_Modelo; set => ve_Modelo = value; }
        public string Ve_Cor { get => ve_Cor; set => ve_Cor = value; }
        internal Moradores Moradores { get => moradores; set => moradores = value; }
        internal BA BA { get => bA; set => bA = value; }
    }
}
