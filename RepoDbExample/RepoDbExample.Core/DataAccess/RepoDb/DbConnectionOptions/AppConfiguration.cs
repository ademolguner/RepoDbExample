
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
            _connectionString = root.GetSection("ConnectionStrings").GetSection(databaseConnectionName.ToString()).Value;
            var appSetting = root.GetSection("ApplicationSettings");
        }
        public string ConnectionString
        {
            get => _connectionString;
        }



    }
}
