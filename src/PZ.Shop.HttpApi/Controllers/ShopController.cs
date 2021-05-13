using PZ.Shop.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PZ.Shop.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ShopController : AbpController
    {
        protected ShopController()
        {
            LocalizationResource = typeof(ShopResource);
        }
    }
}