using System.Configuration;

namespace DesignPatterns.FactoryMethod
{
    public abstract class DatabaseFactory
    {
        public abstract IDatabase CreateObject();
    }
}
