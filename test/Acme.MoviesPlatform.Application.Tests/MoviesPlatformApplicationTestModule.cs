using Volo.Abp.Modularity;

namespace Acme.MoviesPlatform
{
    [DependsOn(
        typeof(MoviesPlatformApplicationModule),
        typeof(MoviesPlatformDomainTestModule)
        )]
    public class MoviesPlatformApplicationTestModule : AbpModule
    {

    }
}