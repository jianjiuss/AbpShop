using AutoMapper;
using PZ.Shop.Todos;

namespace PZ.Shop
{
    public class ShopApplicationAutoMapperProfile : Profile
    {
        public ShopApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Todo, TodoDto>();
            CreateMap<CreateUpdateTodoDto, Todo>();
        }
    }
}
