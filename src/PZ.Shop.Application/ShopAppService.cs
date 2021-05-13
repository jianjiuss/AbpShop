using System;
using System.Collections.Generic;
using System.Text;
using PZ.Shop.Localization;
using Volo.Abp.Application.Services;

namespace PZ.Shop
{
    /* Inherit your application services from this class.
     */
    public abstract class ShopAppService : ApplicationService
    {
        protected ShopAppService()
        {
            LocalizationResource = typeof(ShopResource);
        }
    }
}
