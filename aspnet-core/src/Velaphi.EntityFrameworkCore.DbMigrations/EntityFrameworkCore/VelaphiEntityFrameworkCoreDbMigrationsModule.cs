using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Velaphi.EntityFrameworkCore
{
    [DependsOn(
        typeof(VelaphiEntityFrameworkCoreModule)
        )]
    public class VelaphiEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<VelaphiMigrationsDbContext>();
        }
    }
}
