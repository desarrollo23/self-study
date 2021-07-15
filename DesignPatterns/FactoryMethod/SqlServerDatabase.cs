using System.Configuration;
using System.Data.SqlClient;

namespace DesignPatterns.FactoryMethod
{
    public class SqlServerDatabase : IDatabase
    {
        private SqlConnection _con;
        private readonly ConnectionStringSettings _settings;

        public SqlServerDatabase(ConnectionStringSettings settings)
        {
            _settings = settings;
        }

        public void Close()
        {
            _con.Close();
        }

        public void Connect()
        {
            _con = new SqlConnection(_settings.ConnectionString);
        }

        public void Open()
        {
            _con.Open();
        }
    }
}
