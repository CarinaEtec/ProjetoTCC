using MySql.Data.MySqlClient;
using Projeto_TCC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCC.DAO
{
    class BADAO
    {
        public void Insert(BA ba) //INSERIR BLOCO/APTO
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText =
                "Insert into BA(ba_Apto,ba_Bloco,cond_Cnpj) " +
                "values(@ba_Apto,@ba_Bloco,@cond_Cnpj)";

                comando.Parameters.AddWithValue("@ba_Apto", ba.Ba_Apto);
                comando.Parameters.AddWithValue("@ba_Bloco", ba.Ba_Bloco);
                comando.Parameters.AddWithValue("@cond_Cnpj", ba.Condominios.Cond_Cnpj);
                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }
    }
}
