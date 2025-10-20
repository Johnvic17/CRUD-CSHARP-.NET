using System;
using MySql.Data.MySqlClient;

namespace MinhaEmpresa.Dados
{
    public class Conexao
    {
        // copiei do PDF da AF disponibilizado no AVA.

        // String de conexão com as informações do servidor MySQL.
        private static string connectionString = "server=localhost;database=EmpresaDB;port=3306;uid=root;pwd=;";

        // Método que retorna uma nova conexão MySQL usando a string de conexão definida.
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
