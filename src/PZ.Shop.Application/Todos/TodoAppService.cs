using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace PZ.Shop.Todos
{
    public class TodoAppService :
        CrudAppService<Todo, TodoDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateTodoDto>,
        ITodoAppService
    {
        public TodoAppService(IRepository<Todo, Guid> repository) : base(repository)
        {
        }
    }
}
