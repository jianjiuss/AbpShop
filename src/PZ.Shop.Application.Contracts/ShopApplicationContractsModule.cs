using Volo.Abp.Application;
using Volo.Abp.Modularity;

namespace PZ.Shop
{
    [DependsOn(
        typeof(ShopDomainSharedModule),
        typeof(AbpDddApplicationContractsModule)
    )]
    public class ShopApplicationContractsModule : AbpModule
    {
    }
}
