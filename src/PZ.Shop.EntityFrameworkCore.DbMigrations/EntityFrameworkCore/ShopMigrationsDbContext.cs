using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace PZ.Shop.EntityFrameworkCore
{
    /* This DbContext is only used for database migrations.
     * It is not used on runtime. See ShopDbContext for the runtime DbContext.
     * It is a unified model that includes configuration for
     * all used modules and your application.
     */
    public class ShopMigrationsDbContext : AbpDbContext<ShopMigrationsDbContext>
    {
        public ShopMigrationsDbContext(DbContextOptions<ShopMigrationsDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureShop();
        }
    }
}