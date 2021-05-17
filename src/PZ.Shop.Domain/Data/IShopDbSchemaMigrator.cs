using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ.Shop.Data
{
    public interface IShopDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
