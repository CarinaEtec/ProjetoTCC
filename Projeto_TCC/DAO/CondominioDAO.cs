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
    class CondominioDAO
    {

        public void Insert(Condominios condominios) //INSERIR CONDOMÍNIOS
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(); 
                comando.CommandType = CommandType.Text; 
                comando.CommandText =
                "Insert into Condominios(Cnpj,Nome,CEP,Endereco,Bairro,Cidade,Telefone) " +
                "values(@Cnpj,@Nome,@CEP,@Endereco,@Bairro,@Cidade,@Telefone)";

                comando.Parameters.AddWithValue("@Cnpj", condominios.Cnpj);
                comando.Parameters.AddWithValue("@Nome", condominios.Nome);
                comando.Parameters.AddWithValue("@CEP", condominios.Cep);
                comando.Parameters.AddWithValue("@Endereco", condominios.Endereco);
                comando.Parameters.AddWithValue("@Bairro", condominios.Bairro);
                comando.Parameters.AddWithValue("@Cidade", condominios.Cidade);
                comando.Parameters.AddWithValue("@Telefone", condominios.Telefone);

                ConexaoBanco.CRUD(comando); 
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }


        public void Delete(Condominios condominios)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Delete from Condominios where Cnpj=@Cnpj";

                comando.Parameters.AddWithValue("@Cnpj", condominios.Cnpj);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }

        public void Update(Condominios condominios)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Update condominios set Nome=@Nome, CEP=@CEP, " +
                    "Endereco=@Endereco, Bairro=@Bairro, Cidade=@Cidade, " +
                    "Telefone=@Telefone where Cnpj=@Cnpj";

                comando.Parameters.AddWithValue("@Cnpj", condominios.Cnpj);
                comando.Parameters.AddWithValue("@Nome", condominios.Nome);
                comando.Parameters.AddWithValue("@CEP", condominios.Cep);
                comando.Parameters.AddWithValue("@Endereco", condominios.Endereco);
                comando.Parameters.AddWithValue("@Bairro", condominios.Bairro);
                comando.Parameters.AddWithValue("@Cidade", condominios.Cidade);
                comando.Parameters.AddWithValue("@Telefone", condominios.Telefone);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }

        }


        public Condominios BuscaPorCNPJ(long Cnpj)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from condominios where Cnpj=@Cnpj";

            comando.Parameters.AddWithValue("@Cnpj", Cnpj);

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            Condominios cond = new Condominios();
            if (dr.HasRows)
            {
                dr.Read();
                cond.Cnpj = (long)dr["Cnpj"];
                cond.Nome = (string)dr["Nome"];
                cond.Cep = (string)dr["CEP"];
                cond.Endereco = (string)dr["Endereco"];
                cond.Bairro = (string)dr["Bairro"];
                cond.Cidade = (string)dr["Cidade"];
                cond.Telefone = (string)dr["Telefone"];
             }
              else
            {
                cond.Cnpj = 0;
                cond.Nome = "";
                cond.Cep = "";
                cond.Endereco = "";
                cond.Bairro = "";
                cond.Cidade = "";
                cond.Telefone = "";
            }
            return cond;
        }



        public IList<Condominios> BuscaPorNome(string Nome)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Condominios where Nome like @Nome";
            


            comando.Parameters.AddWithValue("@Nome", "%" + Nome + "%");

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            IList<Condominios> cond = new List<Condominios>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Condominios condominios = new Condominios();
                    condominios.Cnpj = (long)dr["Cnpj"];
                    condominios.Nome = (string)dr["Nome"];
                    condominios.Cep = (string)dr["CEP"];
                    condominios.Endereco = (string)dr["Endereco"];
                    condominios.Bairro = (string)dr["Bairro"];
                    condominios.Cidade = (string)dr["Cidade"];
                    condominios.Telefone = (string)dr["Telefone"];

                    cond.Add(condominios);
                }
            }
            else
            {
                cond = null;

            }
            return cond;
        }

    }
}
