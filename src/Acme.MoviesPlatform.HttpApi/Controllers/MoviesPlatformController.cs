using Acme.MoviesPlatform.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.MoviesPlatform.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class MoviesPlatformController : AbpController
    {
        protected MoviesPlatformController()
        {
            LocalizationResource = typeof(MoviesPlatformResource);
        }
    }
}