using AutoMapper;
using Domain.Entities;

namespace Application.UseCases.V1.TodoItemOperation
{
    public class TodoItemProfile : Profile
    {
        public TodoItemProfile()
        {
            CreateMap<TodoItem, TodoItemDto>();
        }
    }
}
