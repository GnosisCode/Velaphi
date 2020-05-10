using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Velaphi.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class VelaphiMigrationsDbContextFactory : IDesignTimeDbContextFactory<VelaphiMigrationsDbContext>
    {
        public VelaphiMigrationsDbContext CreateDbContext(string[] args)
        {
            VelaphiEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<VelaphiMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new VelaphiMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
