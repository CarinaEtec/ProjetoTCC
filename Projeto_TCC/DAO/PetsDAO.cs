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
    class PetsDAO
    {
        public void Insert(Pets pets)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Insert into Pets(nome,CodMorador,Especie,BA_Cod) " +
                    "values(@nome,@CodMorador,@Especie,@BA_Cod)";

                comando.Parameters.AddWithValue("@nome", pets.Nome);
                comando.Parameters.AddWithValue("@CodMorador", pets.Moradores.CodMorador);
                comando.Parameters.AddWithValue("@Especie", pets.Especie);
                comando.Parameters.AddWithValue("@Ba_Cod", pets.BA.Ba_Cod);


                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }





        public void Delete(Pets pets)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Delete from Pets where CodPet=@CodPet";

                comando.Parameters.AddWithValue("@CodPet", pets.CodPet);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }

        public void Update(Pets pets)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Update Pets set nome=@nome, CodMorador=@CodMorador, Especie=@Especie, " +
                    "Ba_Cod=@Ba_Cod where CodPet=@CodPet";

                comando.Parameters.AddWithValue("@nome", pets.Nome);
                comando.Parameters.AddWithValue("@CodMorador", pets.Moradores.CodMorador);
                comando.Parameters.AddWithValue("@Especie", pets.Especie);
                comando.Parameters.AddWithValue("@Ba_Cod", pets.BA.Ba_Cod);
                comando.Parameters.AddWithValue("@CodPet", pets.CodPet);


                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }

        }



    }

    }
