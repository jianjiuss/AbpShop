using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace PZ.Shop
{
    [Dependency(ReplaceServices = true)]
    public class ShopBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Shop";
    }
}
