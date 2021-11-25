using System;
using System.Collections.Generic;
using System.Text;
using Acme.MoviesPlatform.Localization;
using Volo.Abp.Application.Services;

namespace Acme.MoviesPlatform
{
    /* Inherit your application services from this class.
     */
    public abstract class MoviesPlatformAppService : ApplicationService
    {
        protected MoviesPlatformAppService()
        {
            LocalizationResource = typeof(MoviesPlatformResource);
        }
    }
}
