using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace PZ.Shop.Web.Pages
{
    public class IndexModel : ShopPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}