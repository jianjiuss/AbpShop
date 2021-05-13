using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using PZ.Shop.MultiTenancy;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;

namespace PZ.Shop
{
    [DependsOn(
        typeof(ShopDomainSharedModule),
        typeof(AbpDddDomainModule)
    )]
    public class ShopDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}
