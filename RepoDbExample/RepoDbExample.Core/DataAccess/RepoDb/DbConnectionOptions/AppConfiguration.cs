using Microsoft.Extensions.Configuration;
using System.IO;

namespace RepoDbExample.Core.DataAccess.RepoDb.DbConnectionOptions
{
    public class AppConfiguration
    {
        public readonly string _connectionString = string.Empty;

        public AppConfiguration(DatabaseConnectionName databaseConnectionName)
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);

            var root = configurationBuilder.Build();
            _connectionString = root.GetSection("ConnectionStrings")
                                    .GetSection(databaseConnectionName.ToString()).Value;
            _ = root.GetSection("ApplicationSettings");
        }

        public string ConnectionString
        {
            get => _connectionString;
        }
    }
}