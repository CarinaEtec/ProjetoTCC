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
        public void Gravar(Funcionarios func) //GRAVAR NOVO func
        {
            FuncionariosDAO funcDao = new FuncionariosDAO();
            if ((func.Cpf != 0) && (func.Nome != ""))
            {
                funcDao.Insert(func);
            }
        }
        public void Deletar(Funcionarios func) 
        {
            FuncionariosDAO funcDao = new FuncionariosDAO();

            if (func.Cpf != 0)
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
        public IList<Funcionarios> BuscarPorNome(Funcionarios func)
        {
            FuncionariosDAO funcDao = new FuncionariosDAO();

            if (func.Nome != "")
            {
                IList<Funcionarios> funcTemp = funcDao.BuscaPorNome(func.Nome);
                return funcTemp;
            }
            else
            {
                return null;
            }
        }
    }
}
