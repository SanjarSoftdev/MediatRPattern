using MediatR;
using MediatRPattern.Application.UseCases.Book.Commands;
using MediatRPattern.Application.UseCases.Book.Queries;
using Microsoft.AspNetCore.Mvc;

namespace MediatRPattern.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IMediator mediator;

        public BookController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook(CreateBookCommand command)
        {
            await mediator.Send(command);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            var result = await mediator.Send(new GetBookQuery());

            return Ok(result);
        }
    }
}
