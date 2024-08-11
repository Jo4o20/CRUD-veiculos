using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVeiculos.Data
{
    public class ConexaoBD
    {
        private static string connectionString = "Server=localhost;Database=cadastro_veiculos;Uid=root;Pwd=1234;";

        public static MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(connectionString);
                conexao.Open();
                return conexao;
            }
            catch (MySqlException ex)
            {
                // Tratar erros de conexão, se necessário
                Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
                return null;
            }
        }
    }
}
