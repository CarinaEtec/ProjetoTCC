using Projeto_TCC.DAO;
using Projeto_TCC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC.BO
{
    class FuncionariosBO
    {
        public void Gravar(Funcionarios func)
        {
            FuncionariosDAO funcDao = new FuncionariosDAO();
            if ((func.Nome != "") && (func.Cpf != 0))
            {
                funcDao.Insert(func);
            }
        }

        public IList<Funcionarios> BuscarPorNOME(Funcionarios func)
        {
            FuncionariosDAO funcDao = new FuncionariosDAO();



            if (func.Nome != "")
            {
                IList<Funcionarios> funcTemp = funcDao.BuscarPorNOME(func.Nome);
                return funcTemp;
            }
            else
            {
                return null;

            }
        }

        public void Deletar(Funcionarios func)
        {
            FuncionariosDAO funcDao = new FuncionariosDAO();

            if (func.Cpf > 0)
            {
                funcDao.Delete(func);
            }
        }


        public void Editar(Funcionarios func)
        {
            FuncionariosDAO funcDao = new FuncionariosDAO();
            if (func.Cpf != 0)
            {
                funcDao.Update(func);
            }
        }

        public void BuscaPorCPF(Funcionarios func)
        {
            FuncionariosDAO funcDao = new FuncionariosDAO();
            if (func.Cpf != 0)
            {
                var funcTemp = funcDao.BuscaPorCPF(func.Cpf);

                func.Nome = funcTemp.Nome;
                func.Funcao = funcTemp.Funcao;
                func.Telefone = funcTemp.Telefone;
                func.Celular = funcTemp.Celular;
                func.Senha = funcTemp.Senha;

            }

        }



    }
}
