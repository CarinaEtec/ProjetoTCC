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

        public void Delete(Ocorrencias ocorrencias)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Delete from Ocorrencia where CodOcorrencia=@CodOcorrencia";

                comando.Parameters.AddWithValue("@CodOcorrencia", ocorrencias.CodOcorrencia);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }

        public void Update(Ocorrencias ocorrencias)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Update ocorrencias set Data=@Data, CodMorador=@CodMorador, Motivo=@Motivo, " +
                    "Ba_Cod=@Ba_Cod where CodOcorrencia=@CodOcorrencia";

                comando.Parameters.AddWithValue("@Data", ocorrencias.Data);
                comando.Parameters.AddWithValue("@CodMorador", ocorrencias.Moradores.CodMorador);
                comando.Parameters.AddWithValue("@Motivo", ocorrencias.Motivo);
                comando.Parameters.AddWithValue("@Ba_Cod", ocorrencias.BA.Ba_Cod);
                comando.Parameters.AddWithValue("@CodOcorrencia", ocorrencias.CodOcorrencia);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }

        public DataTable BuscaApto(string apto)
        {
            MySqlConnection con = ConexaoBanco.Conectar();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;

            MySqlDataAdapter da;

            comando.CommandText = "select m.nome,  ba.apto as apto, ba.bloco as bloco, o.motivo, o.data" +
                 " from MORADORES M, BA BA, ocorrencias o where" +
                 " apto like @apto and o.ba_cod = ba.ba_cod and o.CODMORADOR = M.CODMORADOR ";

            try
            {
                comando = new MySqlCommand(comando.CommandText, con);

                comando.Parameters.AddWithValue("@apto", "%" + apto + "%");


                da = new MySqlDataAdapter(comando);
                //
                DataTable dtDados = new DataTable();
                da.Fill(dtDados);
                return dtDados;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
        }


        public DataTable BuscaBloco(string bloco)
        {
            MySqlConnection con = ConexaoBanco.Conectar();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;

            MySqlDataAdapter da;

            comando.CommandText = "select m.nome,  ba.apto as apto, ba.bloco as bloco, o.motivo, o.data" +
                 " from MORADORES M, BA BA, ocorrencias o where" +
                 " bloco like @bloco and o.ba_cod = ba.ba_cod and o.CODMORADOR = M.CODMORADOR ";

            try
            {
                comando = new MySqlCommand(comando.CommandText, con);

                comando.Parameters.AddWithValue("@bloco", "%" + bloco + "%");


                da = new MySqlDataAdapter(comando);
                //
                DataTable dtDados = new DataTable();
                da.Fill(dtDados);
                return dtDados;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
        }












        public DataTable BuscaApto_COD(string apto)
        {
            MySqlConnection con = ConexaoBanco.Conectar();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;

            MySqlDataAdapter da;

            // comando.CommandText = "select m.nome as Nome,  ba.apto as Apto, ba.bloco as Bloco, o.Motivo as Motivo, o.Data as Data, o.codOcorrencia AS CodOcorrencia," +
            comando.CommandText = "select o.codOcorrencia, m.nome,  ba.apto as apto, ba.bloco as bloco, o.motivo, o.data" +
                 " from MORADORES M, BA BA, ocorrencias o where" +
                 " apto like @apto and o.ba_cod = ba.ba_cod and o.CODMORADOR = M.CODMORADOR ";

            try
            {
                comando = new MySqlCommand(comando.CommandText, con);

                comando.Parameters.AddWithValue("@apto", "%" + apto + "%");


                da = new MySqlDataAdapter(comando);
                //
                DataTable dtDados = new DataTable();
                da.Fill(dtDados);
                return dtDados;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
        }


        public DataTable BuscaBloco_COD(string bloco)
        {
            MySqlConnection con = ConexaoBanco.Conectar();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;

            MySqlDataAdapter da;

            comando.CommandText = "select  m.nome as Nome,  ba.apto as Apto, ba.bloco as Bloco, o.Motivo as Motivo, o.Data as Data, o.codOcorrencia AS CodOcorrencia," +
                 " from MORADORES M, BA BA, ocorrencias o where" +
                 " bloco like @bloco and o.ba_cod = ba.ba_cod and o.CODMORADOR = M.CODMORADOR ";

            try
            {
                comando = new MySqlCommand(comando.CommandText, con);

                comando.Parameters.AddWithValue("@bloco", "%" + bloco + "%");


                da = new MySqlDataAdapter(comando);
                //
                DataTable dtDados = new DataTable();
                da.Fill(dtDados);
                return dtDados;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
        }
    }
}

