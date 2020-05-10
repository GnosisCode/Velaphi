using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Velaphi.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(VelaphiHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class VelaphiConsoleApiClientModule : AbpModule
    {
        
    }
}
