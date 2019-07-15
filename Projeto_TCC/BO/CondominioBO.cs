using Projeto_TCC.Alterar;
using Projeto_TCC.DAO;
using Projeto_TCC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC.BO
{
    class CondominioBO
    {
        public void Gravar(Condominios condominios) //GRAVAR NOVO CONDOMÍNIO
        {
            CondominioDAO condominioDao = new CondominioDAO();
            if ((condominios.Cnpj != 0) && (condominios.Nome != ""))
            {
                condominioDao.Insert(condominios);
            }
        }

        public void Deletar(Condominios condominios)
        {
            CondominioDAO condominioDao = new CondominioDAO();

            if (condominios.Cnpj != 0)
            {
                condominioDao.Delete(condominios);
            }
        }

        public void Editar(Condominios condominios)
        {
            CondominioDAO condominioDao = new CondominioDAO();
            if (condominios.Cnpj != 0)
            {
                condominioDao.Update(condominios);
            }
        }



        public void BuscarCNPJ(Condominios cond)
        {
            CondominioDAO condDao = new CondominioDAO();

            if (cond.Cnpj > 0)
            {

                var condTemp = condDao.BuscaPorCNPJ(cond.Cnpj);

                cond.Nome = condTemp.Nome;
                cond.Cep = condTemp.Cep;
                cond.Endereco = condTemp.Endereco;
                cond.Bairro = condTemp.Bairro;
                cond.Cidade = condTemp.Cidade;
                cond.Telefone = condTemp.Telefone;
            }
        }



        public IList<Condominios> BuscarPorNome(Condominios cond)
        {
            CondominioDAO condDao = new CondominioDAO();

            if (cond.Nome != "")
            {
                IList<Condominios> condTemp = condDao.BuscaPorNome(cond.Nome);
                return condTemp;
            }
            else
            {
                return null;
            }
        }

    }
}
