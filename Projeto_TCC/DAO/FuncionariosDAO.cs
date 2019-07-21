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
    class FuncionariosDAO
    {
        public void Insert(Funcionarios funcs) //INSERIR CONDOMÍNIOS
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText =
                "Insert into Funcionarios(Nome,Cpf,Funcao,Telefone,Celular,Senha) " +
                "values(@Nome,@Cpf,@Funcao,@Telefone,@Celular,@Senha)";

                comando.Parameters.AddWithValue("@Nome", funcs.Nome);
                comando.Parameters.AddWithValue("@Cpf", funcs.Cpf);
                comando.Parameters.AddWithValue("@Funcao", funcs.Funcao);
                comando.Parameters.AddWithValue("@Telefone", funcs.Telefone);
                comando.Parameters.AddWithValue("@Celular", funcs.Celular);
                comando.Parameters.AddWithValue("@Senha", funcs.Senha);


        ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }

        public void Delete(Funcionarios func)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Delete from Funcionarios where CPF=@CPF";

                comando.Parameters.AddWithValue("@CPF", func.Cpf);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }

        public void Update(Funcionarios func)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Update Funcionarios set Nome=@Nome," +
                    "Funcao=@Funcao, Telefone=@Telefone, Celular=@Celular, " +
                    "Senha=@Senha where CPF=@CPF";

                comando.Parameters.AddWithValue("@Nome", func.Nome);
                comando.Parameters.AddWithValue("@CPF", func.Cpf);
                comando.Parameters.AddWithValue("@Funcao", func.Funcao);
                comando.Parameters.AddWithValue("@Telefone", func.Telefone);
                comando.Parameters.AddWithValue("@Celular", func.Celular);
                comando.Parameters.AddWithValue("@Senha", func.Senha);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }



        public IList<Funcionarios> BuscaPorNome(string Nome)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Funcionarios where Nome like @Nome";

            comando.Parameters.AddWithValue("@Nome", "%" + Nome + "%");

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            IList<Funcionarios> func = new List<Funcionarios>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Funcionarios funcionarios = new Funcionarios();
                    funcionarios.Nome = (string)dr["Nome"];
                    funcionarios.Cpf = (long)dr["Cpf"];
                    funcionarios.Funcao = (string)dr["Funcao"];
                    funcionarios.Telefone = (string)dr["Telefone"];
                    funcionarios.Celular = (string)dr["Celular"];
                    funcionarios.Senha = (string)dr["Senha"];

                    func.Add(funcionarios);
                }
            }
            else
            {
                func = null;
            }
            return func;
        }
    }
}
