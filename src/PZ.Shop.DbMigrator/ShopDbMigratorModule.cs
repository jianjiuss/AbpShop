using PZ.Shop.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace PZ.Shop.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ShopEntityFrameworkCoreDbMigrationsModule),
        typeof(ShopApplicationContractsModule)
        )]
    public class ShopDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
