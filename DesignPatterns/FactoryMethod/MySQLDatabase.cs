using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace DesignPatterns.FactoryMethod
{
    public class MySQLDatabase : IDatabase
    {
        private MySqlConnection _con;
        private readonly ConnectionStringSettings _settings;

        public MySQLDatabase(ConnectionStringSettings settings)
        {
            _settings = settings;
        }

        public void Close()
        {
            _con.Close();
        }

        public void Connect()
        {
            _con = new MySqlConnection(_settings.ConnectionString);
        }

        public void Open()
        {
            _con.Open();
        }
    }
}
