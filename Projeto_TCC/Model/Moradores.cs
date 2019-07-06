using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC.Model
{
    class Moradores
    {
        private int mo_CodMorador;
        private string mo_Nome;
        private DateTime mo_DataNasc;
        private string mo_Situacao;
        private string mo_Telefone;
        private string mo_Celular;
        private BA bA;

        public Moradores()
        {
            BA = new BA();
        }

        public int Mo_CodMorador { get => mo_CodMorador; set => mo_CodMorador = value; }
        public string Mo_Nome { get => mo_Nome; set => mo_Nome = value; }
        public DateTime Mo_DataNasc { get => mo_DataNasc; set => mo_DataNasc = value; }
        public string Mo_Situacao { get => mo_Situacao; set => mo_Situacao = value; }
        public string Mo_Telefone { get => mo_Telefone; set => mo_Telefone = value; }
        public string Mo_Celular { get => mo_Celular; set => mo_Celular = value; }
        internal BA BA { get => bA; set => bA = value; }
    }
}
