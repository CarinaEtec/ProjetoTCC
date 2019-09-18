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
    class LocacoesDAO
    {
        public void Insert(Locacoes loc)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Insert into Locacoes(CodMorador,Inicio,Termino,BA_Cod) " +
                    "values(@CodMorador,@Inicio,@Termino,@BA_Cod)";

                comando.Parameters.AddWithValue("@Inicio", loc.Inicio);
                comando.Parameters.AddWithValue("@Termino", loc.Termino);
                comando.Parameters.AddWithValue("@CodMorador", loc.Moradores.CodMorador);
                comando.Parameters.AddWithValue("@Ba_Cod", loc.BA.Ba_Cod);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }

        public void Delete(Locacoes loc)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Delete from Locacoes where CodLocacao=@CodLocacao";

                comando.Parameters.AddWithValue("@CodLocacao", loc.CodLocacao);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }

        public void Update(Locacoes loc)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Update Locacoes set CodMorador=@CodMorador, Inicio=@Inicio, Termino=@Termino, " +
                    "Ba_Cod=@Ba_Cod where CodLocacao=@CodLocacao";

                comando.Parameters.AddWithValue("@CodLocacao", loc.CodLocacao);
                comando.Parameters.AddWithValue("@CodMorador", loc.Moradores.CodMorador);
                comando.Parameters.AddWithValue("@Inicio", loc.Inicio);
                comando.Parameters.AddWithValue("@Termino", loc.Termino);
                comando.Parameters.AddWithValue("@Ba_Cod", loc.BA.Ba_Cod);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }




        //SELECT M.NOME, L.INICIO, L.TERMINO, BA.BLOCO, BA.APTO FROM MORADORES M, locacoes L, BA BA
        //WHERE L.CODMORADOR=M.CODMORADOR AND L.BA_COD= BA.BA_COD;
    }
}
