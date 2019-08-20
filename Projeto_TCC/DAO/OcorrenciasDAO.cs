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
    class OcorrenciasDAO
    {


        public void Insert(Ocorrencias ocorrencias)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Insert into Ocorrencias(CodMorador,Motivo,Data,BA_Cod) " +
                    "values(@CodMorador,@Motivo,@Data,@BA_Cod)";

                comando.Parameters.AddWithValue("@Motivo", ocorrencias.Motivo);
                comando.Parameters.AddWithValue("@Data", ocorrencias.Data);
                comando.Parameters.AddWithValue("@CodMorador", ocorrencias.Moradores.CodMorador);
                comando.Parameters.AddWithValue("@Ba_Cod", ocorrencias.BA.Ba_Cod);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }
    }
}

