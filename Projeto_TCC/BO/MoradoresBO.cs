using Projeto_TCC.DAO;
using Projeto_TCC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC.BO
{
    class MoradoresBO
    {
        public void Gravar(Moradores mor)
        {
            MoradorDAO morDao = new MoradorDAO();
            if ((mor.Nome != "") && (mor.DataNasc != null) && (mor.BA.Ba_Cod != 0))
            {
                morDao.Insert(mor);
            }
        }



        public void Deletar(Moradores mor)
        {
            MoradorDAO morDao = new MoradorDAO();

            if (mor.Nome != "")
            {
                morDao.Delete(mor);
            }
        }


        public void Editar(Moradores mor)
        {
            MoradorDAO morDao = new MoradorDAO();
            if (mor.Nome != "")
            {
                morDao.Update(mor);
            }
        }



        public void Buscar(Moradores cliente)
        {
            MoradorDAO morDao = new MoradorDAO();

            if (cliente.Nome != "")
            {

                var clienteTemp = morDao.BuscaPorNOME(cliente.Nome);

                cliente.Nome = clienteTemp.Nome;
                cliente.CodMorador = clienteTemp.CodMorador;

            }
        }









        


        public IList<Moradores> CONSULTA_MaiorIdade(Moradores moradores)
        {
            MoradorDAO morDao = new MoradorDAO();

            if (moradores.Nome != "")
            {
                IList<Moradores> moradoresTemp = morDao.CONSULTA_MaiorIdade(moradores.Nome);

                return moradoresTemp;
            }
            else
            {
                return null;
            }
        }




        public IList<Moradores> CONSULTA_MenorIdade(Moradores moradores)
        {
            MoradorDAO morDao = new MoradorDAO();


            if (moradores.Nome != "")
            {
                IList<Moradores> moradoresTemp = morDao.CONSULTA_MenorIdade(moradores.Nome);

                return moradoresTemp;
            }
            else
            {
                return null;
            }
        }
    }
}
