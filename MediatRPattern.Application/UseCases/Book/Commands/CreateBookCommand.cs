using MediatR;
using MediatRPattern.Application.Abstractions;

namespace MediatRPattern.Application.UseCases.Book.Commands
{
    public class CreateBookCommand : IRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }

    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand>
    {
        private readonly IApplicationDBContext _context;

        public CreateBookCommandHandler(IApplicationDBContext context)
        {
            _context = context;
        }

        public Task Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
