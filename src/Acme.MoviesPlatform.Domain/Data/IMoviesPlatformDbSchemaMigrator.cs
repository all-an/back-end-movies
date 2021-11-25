using System.Threading.Tasks;

namespace Acme.MoviesPlatform.Data
{
    public interface IMoviesPlatformDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
