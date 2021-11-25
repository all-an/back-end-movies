using Acme.MoviesPlatform.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.MoviesPlatform
{
    [DependsOn(
        typeof(MoviesPlatformEntityFrameworkCoreTestModule)
        )]
    public class MoviesPlatformDomainTestModule : AbpModule
    {

    }
}