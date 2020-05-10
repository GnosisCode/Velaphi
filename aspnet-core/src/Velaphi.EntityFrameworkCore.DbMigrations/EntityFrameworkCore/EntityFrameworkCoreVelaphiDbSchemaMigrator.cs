using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Velaphi.Data;
using Volo.Abp.DependencyInjection;

namespace Velaphi.EntityFrameworkCore
{
    public class EntityFrameworkCoreVelaphiDbSchemaMigrator
        : IVelaphiDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreVelaphiDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the VelaphiMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<VelaphiMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}