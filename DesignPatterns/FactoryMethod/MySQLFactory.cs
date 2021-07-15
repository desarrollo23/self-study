using System.Configuration;

namespace DesignPatterns.FactoryMethod
{
    public class MySQLFactory : DatabaseFactory
    {
        private readonly ConnectionStringSettings _settings;
        public MySQLFactory(ConnectionStringSettings settings)
        {
            _settings = settings;
        }
        public override IDatabase CreateObject()
        {
            return new MySQLDatabase(_settings);
        }
    }
}
