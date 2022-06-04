using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace sample.Controllers
{
    public abstract class sampleControllerBase: AbpController
    {
        protected sampleControllerBase()
        {
            LocalizationSourceName = sampleConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
