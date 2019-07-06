using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC.Model
{
    class BA
    {
        private int ba_Cod;
        private string ba_Apto;
        private string ba_Bloco;
        private Condominios condominios;

        public BA()
        {
            Condominios = new Condominios();
        }

        public int Ba_Cod { get => ba_Cod; set => ba_Cod = value; }
        public string Ba_Apto { get => ba_Apto; set => ba_Apto = value; }
        public string Ba_Bloco { get => ba_Bloco; set => ba_Bloco = value; }
        internal Condominios Condominios { get => condominios; set => condominios = value; }
    }
}
