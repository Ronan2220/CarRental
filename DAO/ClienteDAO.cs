using CarRental.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace CarRental.DAO
{
    class ClienteDAO
    {
        public bool adicionaCliente(Cliente cliente)
        {
            try
            {
                //instrução de insert no banco:
                string query = "INSERT INTO cliente(nome, cpf, data_nasc) " +
                    "VALUES(@nome, @cpf, @data_nasc)";

                //cria a conexão:
                MySqlConnection conn = Conexao.GetConnection();

                //abre a conexão com o banco:
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }

                //Criar um objeto do tipo "MySQLCommand" com a instrução que definimos:
                MySqlCommand cmd = new MySqlCommand(query, conn);

                //define os parâmetros da query:
                cmd.Parameters.Add(new MySqlParameter("@nome", cliente.Nome));
                cmd.Parameters.Add(new MySqlParameter("@cpf", cliente.Cpf));
                cmd.Parameters.Add(new MySqlParameter("@data_nasc", cliente.Data_Nasc));

                //executa o comando:
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Cliente> GetClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            String query = "SELECT id_cliente, cpf, nome, data_nasc " +
                "FROM cliente ORDER BY nome;";

            MySqlConnection conn = Conexao.GetConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dtr = null;

            try
            {
                conn.Open();
                dtr = cmd.ExecuteReader();

                while (dtr.Read())
                {
                    Cliente c = new Cliente();
                    c.Cpf = dtr.GetString("cpf");
                    c.Nome = dtr.GetString("nome");
                   // c.idCliente = dtr.GetInt32("id_cliente");
                    c.Data_Nasc = dtr.GetDateTime("data_nasc");

                    clientes.Add(c);
                }
            }
            catch
            {

            }

            conn.Close();
            return clientes;
        }
    }
}






}
