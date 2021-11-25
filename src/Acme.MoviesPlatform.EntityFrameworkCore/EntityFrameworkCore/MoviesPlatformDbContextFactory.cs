using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.MoviesPlatform.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class MoviesPlatformDbContextFactory : IDesignTimeDbContextFactory<MoviesPlatformDbContext>
    {
        public MoviesPlatformDbContext CreateDbContext(string[] args)
        {
            MoviesPlatformEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<MoviesPlatformDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new MoviesPlatformDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Acme.MoviesPlatform.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
