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
                "Insert into BA(Apto,Bloco,Cnpj) " +
                "values(@Apto,@Bloco,@Cnpj)";

                comando.Parameters.AddWithValue("@Apto", ba.Apto);
                comando.Parameters.AddWithValue("@Bloco", ba.Bloco);
                comando.Parameters.AddWithValue("@Cnpj", ba.Condominios.Cnpj);
                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }
    }
}
