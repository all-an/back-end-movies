using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.MoviesPlatform.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.MoviesPlatform.EntityFrameworkCore
{
    public class EntityFrameworkCoreMoviesPlatformDbSchemaMigrator
        : IMoviesPlatformDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreMoviesPlatformDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the MoviesPlatformDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<MoviesPlatformDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
