using Application.UseCases.V1.TodoItemOperation;
using Application.UseCases.V1.TodoItemOperation.Commands;
using Application.UseCases.V1.TodoItemOperation.Queries;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Abstractions;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemController : ApiControllerBase
    {
        [HttpPost]
        public async Task<string> CreateTodoItem(CreateTodoItemCommand command) => await Mediator.Send(command);

        [HttpGet]
        public async Task<IEnumerable<TodoItemDto>> ListTodoItems() => await Mediator.Send(new GetAllTodoItemsQuery());
        
    }
}
