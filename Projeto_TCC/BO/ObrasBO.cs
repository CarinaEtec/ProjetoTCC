using Projeto_TCC.DAO;
using Projeto_TCC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC.BO
{
    class ObrasBO
    {
        public void Gravar(Obras obras)
        {
            ObrasDAO obrasDao = new ObrasDAO();
            if ((obras.BA.Ba_Cod != 0) && (obras.Moradores.CodMorador != 0) && (obras.DataHora != null))
            {
                obrasDao.Insert(obras);
            }
        }
    }
}
