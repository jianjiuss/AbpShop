using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace PZ.Shop.Todos
{
    public class Todo : AggregateRoot<Guid>
    {
        public string Name { get; set; }
    }
}
