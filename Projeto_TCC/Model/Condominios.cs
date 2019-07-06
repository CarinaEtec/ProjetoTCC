using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC.Model
{
    class Condominios
    {
        private long cond_Cnpj;
        private string cond_Nome;
        private string cond_CEP;
        private string cond_Endereco;
        private string cond_Bairro;
        private string cond_Cidade;
        private string cond_Telefone;

        public long Cond_Cnpj { get => cond_Cnpj; set => cond_Cnpj = value; }
        public string Cond_Nome { get => cond_Nome; set => cond_Nome = value; }
        public string Cond_CEP { get => cond_CEP; set => cond_CEP = value; }
        public string Cond_Endereco { get => cond_Endereco; set => cond_Endereco = value; }
        public string Cond_Bairro { get => cond_Bairro; set => cond_Bairro = value; }
        public string Cond_Cidade { get => cond_Cidade; set => cond_Cidade = value; }
        public string Cond_Telefone { get => cond_Telefone; set => cond_Telefone = value; }
    }
}
