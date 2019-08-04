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


    }
}
