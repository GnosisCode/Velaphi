using Velaphi.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Velaphi.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class VelaphiPageModel : AbpPageModel
    {
        protected VelaphiPageModel()
        {
            LocalizationResourceType = typeof(VelaphiResource);
        }
    }
}