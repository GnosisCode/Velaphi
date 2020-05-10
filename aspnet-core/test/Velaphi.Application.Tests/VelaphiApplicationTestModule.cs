using Volo.Abp.Modularity;

namespace Velaphi
{
    [DependsOn(
        typeof(VelaphiApplicationModule),
        typeof(VelaphiDomainTestModule)
        )]
    public class VelaphiApplicationTestModule : AbpModule
    {

    }
}