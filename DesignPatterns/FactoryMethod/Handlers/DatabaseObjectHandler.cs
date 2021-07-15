using System;
using System.Configuration;

namespace DesignPatterns.FactoryMethod.Handlers
{
    public static class DatabaseObjectHandler
    {
        public static DatabaseFactory GetDatabase()
        {
            var settings = ConfigurationManager.ConnectionStrings[0];

            DatabaseFactory db = null;

            if (settings == null)
                throw new Exception("No se ha suministrado una conexion a la DB");

            var type = settings.ProviderName;

            switch (type)
            {
                case "System.Data.SqlClient":
                    db = new SqlServerFactory(settings);
                    break;

                case "System.Data.MySqlClient":
                    db = new MySQLFactory(settings);
                    break;
                default:
                    break;
            }

            return db;
        }
    }
}
