using Acme.MoviesPlatform.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.MoviesPlatform.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class MoviesPlatformPageModel : AbpPageModel
    {
        protected MoviesPlatformPageModel()
        {
            LocalizationResourceType = typeof(MoviesPlatformResource);
        }
    }
}