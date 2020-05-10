using System.Threading.Tasks;

namespace Velaphi.Data
{
    public interface IVelaphiDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
