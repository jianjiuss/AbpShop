using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace PZ.Shop
{
    [DependsOn(
        typeof(ShopApplicationContractsModule)
    )]
    public class ShopHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Default";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(ShopApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
