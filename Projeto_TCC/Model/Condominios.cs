using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC.Model
{
    class Condominios
    {
        private long cnpj;
        private string nome;
        private string cep;
        private string endereco;
        private string bairro;
        private string cidade;
        private string telefone;

        public long Cnpj { get => cnpj; set => cnpj = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}
