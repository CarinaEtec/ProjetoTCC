using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC.Model
{
    class Funcionarios
    {
        private string func_Nome;
        private long func_Cpf;
        private Condominios condominios;
        private string func_Funcao;
        private string func_Telefone;
        private string func_Celular;
        private string func_Senha;

        public Funcionarios()
        {
            Condominios = new Condominios();
        }

        public string Func_Nome { get => func_Nome; set => func_Nome = value; }
        public long Func_Cpf { get => func_Cpf; set => func_Cpf = value; }
        public string Func_Funcao { get => func_Funcao; set => func_Funcao = value; }
        public string Func_Telefone { get => func_Telefone; set => func_Telefone = value; }
        public string Func_Celular { get => func_Celular; set => func_Celular = value; }
        public string Func_Senha { get => func_Senha; set => func_Senha = value; }
        internal Condominios Condominios { get => condominios; set => condominios = value; }
    }
}
