using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC.Model
{
    class Funcionarios
    {
        private string nome;
        private long cpf;
        private Condominios condominios;
        private string funcao;
        private string telefone;
        private string celular;
        private string senha;

        public Funcionarios()
        {
            Condominios = new Condominios();
        }

        public string Nome { get => nome; set => nome = value; }
        public long Cpf { get => cpf; set => cpf = value; }
        internal Condominios Condominios { get => condominios; set => condominios = value; }
        public string Funcao { get => funcao; set => funcao = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
