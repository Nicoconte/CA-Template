using AutoMapper;
using Domain.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Mappings
{
    public class TodoItemMapper : Profile
    {
        public TodoItemMapper()
        {
            CreateMap<TodoItem, TodoItemDto>();
        }
    }
}
