using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC.Model
{
    class Ocorrencias
    {
        private int codOcorrencia;
        private Moradores moradores;
        private string motivo;
        private DateTime data;
        private BA bA;

        public Ocorrencias()
        {
            BA = new BA();
        }

        public int CodOcorrencia { get => codOcorrencia; set => codOcorrencia = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public DateTime Data { get => data; set => data = value; }
        internal Moradores Moradores { get => moradores; set => moradores = value; }
        internal BA BA { get => bA; set => bA = value; }
    }
}
