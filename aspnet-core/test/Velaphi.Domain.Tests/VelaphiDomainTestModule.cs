using Velaphi.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Velaphi
{
    [DependsOn(
        typeof(VelaphiEntityFrameworkCoreTestModule)
        )]
    public class VelaphiDomainTestModule : AbpModule
    {

    }
}