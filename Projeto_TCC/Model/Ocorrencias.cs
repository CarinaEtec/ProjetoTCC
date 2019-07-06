using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC.Model
{
    class Ocorrencias
    {
        private int oc_CodOcorrencia;
        private Moradores moradores;
        private string oc_motivo;
        private DateTime oc_Data;
        private BA bA;

        public Ocorrencias()
        {
            BA = new BA();
        }

        public int Oc_CodOcorrencia { get => oc_CodOcorrencia; set => oc_CodOcorrencia = value; }
        public string Oc_motivo { get => oc_motivo; set => oc_motivo = value; }
        public DateTime Oc_Data { get => oc_Data; set => oc_Data = value; }
        internal Moradores Moradores { get => moradores; set => moradores = value; }
        internal BA BA { get => bA; set => bA = value; }
    }
}
