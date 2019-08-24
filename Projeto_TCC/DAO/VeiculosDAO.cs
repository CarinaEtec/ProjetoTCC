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
    class VeiculosDAO
    {

        public void Insert(Veiculos veiculos)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Insert into Veiculos(CodMorador,Placa,Modelo,Cor,BA_Cod) " +
                    "values(@CodMorador,@Placa,@Modelo,@Cor,@BA_Cod)";

                comando.Parameters.AddWithValue("@Placa", veiculos.Placa);
                comando.Parameters.AddWithValue("@Modelo", veiculos.Modelo);
                comando.Parameters.AddWithValue("@Cor", veiculos.Cor);
                comando.Parameters.AddWithValue("@CodMorador", veiculos.Moradores.CodMorador);
                comando.Parameters.AddWithValue("@Ba_Cod", veiculos.BA.Ba_Cod);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }

        public void Delete(Veiculos veiculos)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Delete from Veiculos where Placa=@Placa";

                comando.Parameters.AddWithValue("@Placa", veiculos.Placa);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }
    }
}

