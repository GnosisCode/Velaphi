using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Velaphi.EntityFrameworkCore
{
    public static class VelaphiDbContextModelCreatingExtensions
    {
        public static void ConfigureVelaphi(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(VelaphiConsts.DbTablePrefix + "YourEntities", VelaphiConsts.DbSchema);

            //    //...
            //});
        }
    }
}