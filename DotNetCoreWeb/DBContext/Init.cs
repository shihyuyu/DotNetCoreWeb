using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWeb.DBContext
{
    public class Init
    {
        public static DbContextOptions<DAO> DbContextOptions { get; }

        public static string ConnectionString { get; }

        static Init()
        {

            var configuration = new ConfigurationBuilder().AddJsonFile(Directory.GetCurrentDirectory() + "\\appsettings.json").Build();

            ConnectionString = configuration.GetConnectionString("MSSQL");
            DbContextOptions = new DbContextOptionsBuilder<DAO>().UseSqlServer(ConnectionString).Options;
        }
    }
}