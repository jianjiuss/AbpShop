using PZ.Shop.Todos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace PZ.Shop.Data
{
    public class ShopDataSeederContributor
        : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Todo, Guid> todoRepository;

        public ShopDataSeederContributor(
            IRepository<Todo, Guid> todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if(await todoRepository.GetCountAsync() == 0)
            {
                await todoRepository.InsertAsync(new Todo() { Name = "jian"});
            }
        }
    }
}
