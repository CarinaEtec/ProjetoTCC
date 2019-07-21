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
        public void Insert(Funcionarios func)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Insert into Funcionarios(nome,cpf,funcao,telefone,celular,senha) " +
                    "values(@nome,@cpf,@funcao,@telefone,@celular,@senha)";

                comando.Parameters.AddWithValue("@nome", func.Nome);
                comando.Parameters.AddWithValue("@cpf", func.Cpf);
                comando.Parameters.AddWithValue("@funcao", func.Funcao);
                comando.Parameters.AddWithValue("@telefone", func.Telefone);
                comando.Parameters.AddWithValue("@celular", func.Celular);
                comando.Parameters.AddWithValue("@senha", func.Senha);

        ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }

        public IList<Funcionarios> BuscarPorNOME(string nome)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Funcionarios where nome like @nome";

            comando.Parameters.AddWithValue("@nome", "%" + nome + "%");

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            IList<Funcionarios> funcs = new List<Funcionarios>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Funcionarios funcionarios = new Funcionarios();
                    funcionarios.Nome = (string)dr["nome"];
                    funcionarios.Cpf = (long)dr["cpf"];
                    funcionarios.Funcao = (string)dr["Funcao"];
                    funcionarios.Telefone = (string)dr["telefone"];
                    funcionarios.Celular = (string)dr["celular"];
                    funcionarios.Senha = (string)dr["senha"];

                    funcs.Add(funcionarios);
                }
            }
            else
            {
                funcs = null;

            }
            return funcs;
        }

        public void Delete(Funcionarios func)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Delete from Funcionarios where cpf=@cpf";

                comando.Parameters.AddWithValue("@cpf", func.Cpf);

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
                comando.CommandText = "Update Funcionarios set nome=@nome, funcao=@funcao, telefone=@telefone, " +
                    "celular=@celular, senha=@senha where cpf=@cpf";

                comando.Parameters.AddWithValue("@nome", func.Nome);
                comando.Parameters.AddWithValue("@cpf", func.Cpf);
                comando.Parameters.AddWithValue("@funcao", func.Funcao);
                comando.Parameters.AddWithValue("@telefone", func.Telefone);
                comando.Parameters.AddWithValue("@celular", func.Celular);
                comando.Parameters.AddWithValue("@senha", func.Senha);


                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }

        }

    }
}
