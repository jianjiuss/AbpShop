using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace PZ.Shop.Data
{
    public class ShopDbMigrationService : ITransientDependency
    {
        private IDataSeeder dataSeeder;
        private IEnumerable<IShopDbSchemaMigrator> dbSchemaMigrators;

        public ShopDbMigrationService(
            IDataSeeder dataSeeder,
            IEnumerable<IShopDbSchemaMigrator> dbSchemaMigrators)
        {
            this.dataSeeder = dataSeeder;
            this.dbSchemaMigrators = dbSchemaMigrators;
        }

        public async Task MigrateAsync()
        {
            await MigrateDatabaseSchemaAsync();
            await SeedDataAsync();
        }

        private async Task SeedDataAsync()
        {
            await dataSeeder.SeedAsync(new DataSeedContext());
        }

        private async Task MigrateDatabaseSchemaAsync()
        {
            foreach (var migrator in dbSchemaMigrators)
            {
                await migrator.MigrateAsync();
            }
        }
    }
}
