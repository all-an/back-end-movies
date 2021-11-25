using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.MoviesPlatform.Data
{
    /* This is used if database provider does't define
     * IMoviesPlatformDbSchemaMigrator implementation.
     */
    public class NullMoviesPlatformDbSchemaMigrator : IMoviesPlatformDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}