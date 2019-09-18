﻿using MySql.Data.MySqlClient;
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
                "Insert into BA(Apto,Bloco) values(@Apto,@Bloco)";

                comando.Parameters.AddWithValue("@Apto", ba.Apto);
                comando.Parameters.AddWithValue("@Bloco", ba.Bloco);
                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }



        //comando.CommandText = "select bloco from ba where apto = 0";

        public BA BuscaCodBA(string Apto, string Bloco)

        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from BA where Bloco=@Bloco AND Apto=@Apto";


            comando.Parameters.AddWithValue("@Bloco", Bloco);
            comando.Parameters.AddWithValue("@Apto", Apto);


            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            BA ba = new BA();
            if (dr.HasRows)
            {
                dr.Read();
                ba.Ba_Cod = (int)dr["Ba_Cod"];
                ba.Apto = (string)dr["Apto"];
                ba.Bloco = (string)dr["Bloco"];
            }
            else
            {
                ba.Ba_Cod = 0;
                ba.Apto = "";
                ba.Bloco = "";
            }
            return ba;
        }
    }
}
