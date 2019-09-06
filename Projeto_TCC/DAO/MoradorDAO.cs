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
    class MoradorDAO
    {


        public void Insert(Moradores mor)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Insert into Moradores(nome,dataNasc,situacao,telefone,celular,Ba_Cod) " +
                    "values(@nome,@dataNasc,@situacao,@telefone,@celular,@Ba_Cod)";

                comando.Parameters.AddWithValue("@nome", mor.Nome);
                comando.Parameters.AddWithValue("@dataNasc", mor.DataNasc);
                comando.Parameters.AddWithValue("@situacao", mor.Situacao);
                comando.Parameters.AddWithValue("@telefone", mor.Telefone);
                comando.Parameters.AddWithValue("@celular", mor.Celular);
                comando.Parameters.AddWithValue("@Ba_Cod", mor.BA.Ba_Cod);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }

        public void Delete(Moradores mor)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Delete from Moradores where nome=@nome";

                comando.Parameters.AddWithValue("@nome", mor.Nome);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }

        public void Update(Moradores mor)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Update Moradores set nome=@nome, dataNasc=@dataNasc, situacao=@situacao, telefone=@telefone, " +
                    "celular=@celular, Ba_Cod=@Ba_Cod where nome=@nome";

                comando.Parameters.AddWithValue("@nome", mor.Nome);
                comando.Parameters.AddWithValue("@dataNasc", mor.DataNasc);
                comando.Parameters.AddWithValue("@situacao", mor.Situacao);
                comando.Parameters.AddWithValue("@telefone", mor.Telefone);
                comando.Parameters.AddWithValue("@celular", mor.Celular);
                comando.Parameters.AddWithValue("@Ba_Cod", mor.BA.Ba_Cod);


                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }

        }


        public Moradores BuscaPorNOME(string Nome)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Moradores where nome=@nome";

            comando.Parameters.AddWithValue("@nome", Nome);

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            Moradores cliente = new Moradores();
            if (dr.HasRows)
            {
                dr.Read();
                cliente.CodMorador = (int)dr["CodMorador"];
                cliente.Nome = (string)dr["Nome"];

            }
            else
            {
                cliente.CodMorador = 0;
                cliente.Nome = "";
            }
            return cliente;
        }

        public IList<Moradores> CONSULTA_MaiorIdade(string nome)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT* from MORADORES where(YEAR(FROM_DAYS(TO_DAYS(NOW())-TO_DAYS(DATANASC))) >= 18) AND nome like @nome";
            // comando.CommandText = "SELECT m.nome,  m.situacao, m.telefone, m.celular, ba.apto, ba.bloco from moradores m, ba ba where(YEAR(FROM_DAYS(TO_DAYS(NOW())-TO_DAYS(DATANASC))) >= 18) AND m.ba_cod=ba.ba_cod";

            comando.Parameters.AddWithValue("@nome", "%" + nome + "%");


            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            IList<Moradores> mor = new List<Moradores>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Moradores moradores = new Moradores();
                    moradores.Nome = (string)dr["nome"];
                    moradores.DataNasc = (DateTime)dr["DataNasc"];
                    moradores.Situacao = (string)dr["Situacao"];
                    moradores.Telefone = (string)dr["telefone"];
                    moradores.Celular = (string)dr["celular"];
                    moradores.BA.Ba_Cod = (int)dr["Ba_Cod"];
                    moradores.CodMorador = (int)dr["CodMorador"];
                    //moradores.BA.Apto = (string)dr["Apto"];
                    //  moradores.BA.Bloco = (string)dr["Bloco"];


                    mor.Add(moradores);
                }
            }
            else
            {
                mor = null;
            }
            return mor;
        }


        public IList<Moradores> CONSULTA_MenorIdade(string nome)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT* from MORADORES where(YEAR(FROM_DAYS(TO_DAYS(NOW())-TO_DAYS(DATANASC))) < 18) AND nome like @nome";

            comando.Parameters.AddWithValue("@nome", "%" + nome + "%");


            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            IList<Moradores> mor = new List<Moradores>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Moradores moradores = new Moradores();
                    moradores.CodMorador = (int)dr["CodMorador"];
                    moradores.Nome = (string)dr["nome"];
                    moradores.DataNasc = (DateTime)dr["DataNasc"];
                    moradores.Situacao = (string)dr["Situacao"];
                    moradores.Telefone = (string)dr["telefone"];
                    moradores.Celular = (string)dr["celular"];
                    moradores.BA.Ba_Cod = (int)dr["Ba_Cod"];
                    //moradores.BA.Apto = (string)dr["Apto"];
                  //  moradores.BA.Bloco = (string)dr["Bloco"];



                    mor.Add(moradores);
                }
            }
            else
            {
                mor = null;
            }
            return mor;
        }
    }

}
