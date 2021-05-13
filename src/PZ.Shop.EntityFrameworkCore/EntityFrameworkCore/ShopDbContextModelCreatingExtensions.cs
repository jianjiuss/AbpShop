using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace PZ.Shop.EntityFrameworkCore
{
    public static class ShopDbContextModelCreatingExtensions
    {
        public static void ConfigureShop(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(ShopConsts.DbTablePrefix + "YourEntities", ShopConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}