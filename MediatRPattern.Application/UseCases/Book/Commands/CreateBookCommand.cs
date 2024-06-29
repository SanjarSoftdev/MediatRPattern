using MediatR;
using MediatRPattern.Application.Abstractions;

namespace MediatRPattern.Application.UseCases.Book.Commands
{
    using MediatRPattern.Application.Notifications;
    using MediatRPattern.Domain.Entities;

    public class CreateBookCommand : IRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }

    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand>
    {
        private readonly IApplicationDBContext context;
        private readonly IMediator mediator;

        public CreateBookCommandHandler(IApplicationDBContext context, IMediator mediator)
        {
            this.context = context;
            this.mediator = mediator;
        }

        public async Task Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Book()
            {
                Title = request.Title,
                Description = request.Description,
                Author = request.Author,
            };
            context.Books.Add(book);
            await context.SaveChangesAsync();

            await mediator.Publish(new BookCreatedNotification()
            {
                Id = book.Id,
                Title = request.Title,
                Description = request.Description,
                Author = request.Author,
            });
        }
    }
}
