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
            if ((condominios.Cond_Cnpj != 0) && (condominios.Cond_Nome != ""))
            {
                condominioDao.Insert(condominios);
            }
        }

        public void Deletar(Condominios condominios)
        {
            CondominioDAO condominioDao = new CondominioDAO();

            if (condominios.Cond_Cnpj != 0)
            {
                condominioDao.Delete(condominios);
            }
        }

        public void Editar(Condominios condominios)
        {
            CondominioDAO condominioDao = new CondominioDAO();
            if (condominios.Cond_Cnpj != 0)
            {
                condominioDao.Update(condominios);
            }
        }
    }
}
