using Acme.MoviesPlatform.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Acme.MoviesPlatform.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(MoviesPlatformEntityFrameworkCoreModule),
        typeof(MoviesPlatformApplicationContractsModule)
        )]
    public class MoviesPlatformDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
