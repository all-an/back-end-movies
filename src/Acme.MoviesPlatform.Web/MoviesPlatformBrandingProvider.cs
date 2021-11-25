using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.MoviesPlatform.Web
{
    [Dependency(ReplaceServices = true)]
    public class MoviesPlatformBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "MoviesPlatform";
    }
}
