using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Extensions
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ApiControllerBase : Controller
    {
        private ISender _mediator = null;
        
        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
    }
}
