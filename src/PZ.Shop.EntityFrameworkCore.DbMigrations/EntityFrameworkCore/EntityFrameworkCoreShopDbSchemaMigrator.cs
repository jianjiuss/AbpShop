using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PZ.Shop.Data;
using Volo.Abp.DependencyInjection;

namespace PZ.Shop.EntityFrameworkCore
{
    public class EntityFrameworkCoreShopDbSchemaMigrator
        : IShopDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreShopDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ShopMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ShopMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}