using PZ.Shop.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace PZ.Shop
{
    [DependsOn(
        typeof(ShopEntityFrameworkCoreTestModule)
        )]
    public class ShopDomainTestModule : AbpModule
    {

    }
}