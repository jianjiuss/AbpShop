using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace PZ.Shop.Todos
{
    public interface ITodoAppService :
        ICrudAppService<
            TodoDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateTodoDto>
    {
    }
}
