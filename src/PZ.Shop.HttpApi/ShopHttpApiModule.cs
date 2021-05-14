using Localization.Resources.AbpUi;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
namespace PZ.Shop
{
    [DependsOn(
        typeof(ShopApplicationContractsModule)
        )]
    public class ShopHttpApiModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}
