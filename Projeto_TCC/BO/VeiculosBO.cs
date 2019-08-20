using Projeto_TCC.DAO;
using Projeto_TCC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC.BO
{
    class VeiculosBO
    {
        public void Gravar(Veiculos veiculos)
        {
            VeiculosDAO veiculosDao = new VeiculosDAO();
            if ((veiculos.BA.Ba_Cod != 0) && (veiculos.Moradores.CodMorador != 0) && (veiculos.Placa != ""))
            {
                veiculosDao.Insert(veiculos);
            }
        }
    }
}
