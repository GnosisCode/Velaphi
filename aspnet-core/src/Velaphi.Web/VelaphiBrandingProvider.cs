using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Velaphi.Web
{
    [Dependency(ReplaceServices = true)]
    public class VelaphiBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Velaphi";
    }
}
