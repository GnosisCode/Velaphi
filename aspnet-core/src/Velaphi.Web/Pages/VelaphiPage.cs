using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Velaphi.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Velaphi.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits Velaphi.Web.Pages.VelaphiPage
     */
    public abstract class VelaphiPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<VelaphiResource> L { get; set; }
    }
}
