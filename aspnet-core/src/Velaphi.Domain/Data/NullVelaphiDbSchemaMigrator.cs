using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Velaphi.Data
{
    /* This is used if database provider does't define
     * IVelaphiDbSchemaMigrator implementation.
     */
    public class NullVelaphiDbSchemaMigrator : IVelaphiDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}