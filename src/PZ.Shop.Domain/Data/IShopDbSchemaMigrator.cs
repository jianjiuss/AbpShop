using System.Threading.Tasks;

namespace PZ.Shop.Data
{
    public interface IShopDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
