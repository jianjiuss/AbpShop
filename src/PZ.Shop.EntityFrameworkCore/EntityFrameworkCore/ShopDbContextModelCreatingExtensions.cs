using Microsoft.EntityFrameworkCore;
using PZ.Shop.Todos;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

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

            builder.Entity<Todo>(b => 
            {
                b.ToTable("Todos");
                b.ConfigureByConvention();
                b.Property(t => t.Name);
            });
        }
    }
}