using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace PZ.Shop.Todos
{
    public class TodoDto :EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
