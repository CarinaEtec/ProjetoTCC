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
    class ObrasDAO
    {
        public void Insert(Obras obras)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Insert into Obras(CodMorador,DataHora,BA_Cod) " +
                    "values(@CodMorador,@DataHora,@BA_Cod)";

                comando.Parameters.AddWithValue("@DataHora", obras.DataHora);
                comando.Parameters.AddWithValue("@CodMorador", obras.Moradores.CodMorador);
                comando.Parameters.AddWithValue("@Ba_Cod", obras.BA.Ba_Cod);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }
    }
}

