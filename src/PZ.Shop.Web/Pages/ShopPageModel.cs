using PZ.Shop.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace PZ.Shop.Web.Pages
{
    public abstract class ShopPageModel : AbpPageModel
    {
        protected ShopPageModel()
        {
            LocalizationResourceType = typeof(ShopResource);
        }
    }
}