using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.V1.TodoItemOperation.Commands
{

    public class CreateTodoItemCommand : IRequest<string>
    {
        public string Title { get; set; }
    }

    public class CreateTodoItemCommandHandler : IRequestHandler<CreateTodoItemCommand, string>
    {

        private readonly IApplicationDbContext _context;

        public CreateTodoItemCommandHandler(IApplicationDbContext context)
        {
            _context = context; 
        }

        public async Task<string> Handle(CreateTodoItemCommand request, CancellationToken cancellationToken)
        {
            var todoItem = new TodoItem()
            {
                Id = Guid.NewGuid().ToString(),
                Title = request.Title,
            };

            _context.TodoItems.Add(todoItem);

            await _context.SaveChangesAsync(cancellationToken);

            return todoItem.Id;
        }
    }
}
