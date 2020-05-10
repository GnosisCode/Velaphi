using Velaphi.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Velaphi.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(VelaphiEntityFrameworkCoreDbMigrationsModule),
        typeof(VelaphiApplicationContractsModule)
        )]
    public class VelaphiDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
