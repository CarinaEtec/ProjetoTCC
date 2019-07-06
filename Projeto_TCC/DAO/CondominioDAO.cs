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
                "Insert into Condominios(cond_Cnpj,cond_Nome,cond_CEP,cond_Endereco,cond_Bairro,cond_Cidade,cond_Telefone) " +
                "values(@cond_Cnpj,@cond_Nome,@cond_CEP,@cond_Endereco,@cond_Bairro,@cond_Cidade,@cond_Telefone)";

                comando.Parameters.AddWithValue("@cond_Cnpj", condominios.Cond_Cnpj);
                comando.Parameters.AddWithValue("@cond_Nome", condominios.Cond_Nome);
                comando.Parameters.AddWithValue("@cond_CEP", condominios.Cond_CEP);

                comando.Parameters.AddWithValue("@cond_Endereco", condominios.Cond_Endereco);
                comando.Parameters.AddWithValue("@cond_Bairro", condominios.Cond_Bairro);
                comando.Parameters.AddWithValue("@cond_Cidade", condominios.Cond_Cidade);
                comando.Parameters.AddWithValue("@cond_Telefone", condominios.Cond_Telefone);

                ConexaoBanco.CRUD(comando); 
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }

        }
    }
}
