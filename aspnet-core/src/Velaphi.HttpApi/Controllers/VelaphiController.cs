using Velaphi.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Velaphi.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class VelaphiController : AbpController
    {
        protected VelaphiController()
        {
            LocalizationResource = typeof(VelaphiResource);
        }
    }
}