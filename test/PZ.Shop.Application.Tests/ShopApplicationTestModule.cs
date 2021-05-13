using Volo.Abp.Modularity;

namespace PZ.Shop
{
    [DependsOn(
        typeof(ShopApplicationModule),
        typeof(ShopDomainTestModule)
        )]
    public class ShopApplicationTestModule : AbpModule
    {

    }
}