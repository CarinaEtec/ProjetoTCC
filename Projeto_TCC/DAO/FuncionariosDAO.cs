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

        public Funcionarios BuscaCPF(long cpf) 
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Funcionarios where cpf=@cpf";

            comando.Parameters.AddWithValue("@cpf", cpf);

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            Funcionarios funcionarios = new Funcionarios();
            if (dr.HasRows)
            {
                dr.Read();
                funcionarios.Nome = (string)dr["nome"];
                funcionarios.Cpf = (long)dr["cpf"];
                funcionarios.Funcao = (string)dr["funcao"];
                funcionarios.Telefone = (string)dr["Telefone"];
                funcionarios.Celular = (string)dr["Celular"];
                funcionarios.Senha = (string)dr["Senha"];
            }
            else
            {
                funcionarios = null;
            }
            return funcionarios;
        }

        public DataTable BuscaNome (string nome)
        {
            MySqlConnection con = ConexaoBanco.Conectar();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;

            //MySqlCommand cmd = CN.CreateCommand();
            MySqlDataAdapter da;

            comando.CommandText = "select nome, funcao as cargo, telefone, celular" +
                 " from Funcionarios where" +
                 " nome like @nome";

            try
            {
                comando = new MySqlCommand(comando.CommandText, con);

                comando.Parameters.AddWithValue("@nome", "%" + nome + "%");


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
