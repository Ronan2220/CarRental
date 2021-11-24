using System;
using MySql.Data.MySqlClient;

namespace CarRental
{
    class Conexao
    {
        const String server = "localhost";
        const String user = "root";
        const String pass = null;
        const String database = "db_rentalcar";
        //const String port = "3360"; //APENAS se você trocou a porta do MySQL



        public static MySqlConnection GetConnection()
        {
            try
            {
                //Monsta uma string de conexão com os parâmtros acima:
                String myConnString = $"server={server};uid={user};pwd={pass};database={database}";
                //Cria uma instância da Classe de conexão do MySQL:
                MySqlConnection conn = new MySqlConnection();
                //Define a string de conexão do objeto:
                conn.ConnectionString = myConnString;
                //retorna a conexão:
                return conn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
