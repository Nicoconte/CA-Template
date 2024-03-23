using Application.Common.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.UseCases.V1.TodoItemOperation.Queries
{
    public class GetAllTodoItemsQuery : IRequest<IEnumerable<TodoItemDto>>
    {
    }

    public class GetAllTodoItemsQueryHandler : IRequestHandler<GetAllTodoItemsQuery, IEnumerable<TodoItemDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetAllTodoItemsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TodoItemDto>> Handle(GetAllTodoItemsQuery request, CancellationToken cancellationToken)
        {
            return await _context.TodoItems
                .ProjectTo<TodoItemDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
