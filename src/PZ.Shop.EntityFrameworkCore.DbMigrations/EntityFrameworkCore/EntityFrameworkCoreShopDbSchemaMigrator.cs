using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PZ.Shop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace PZ.Shop.EntityFrameworkCore
{
    public class EntityFrameworkCoreShopDbSchemaMigrator
        : IShopDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider serviceProvider;

        public EntityFrameworkCoreShopDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            await serviceProvider
                .GetRequiredService<ShopMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
