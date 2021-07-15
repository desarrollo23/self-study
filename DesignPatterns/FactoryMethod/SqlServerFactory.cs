using System.Configuration;

namespace DesignPatterns.FactoryMethod
{
    public class SqlServerFactory : DatabaseFactory
    {
        private readonly ConnectionStringSettings _settings;

        public SqlServerFactory(ConnectionStringSettings settings)
        {
            _settings = settings;
        }
        public override IDatabase CreateObject()
        {
            return new SqlServerDatabase(_settings);
        }
    }
}
