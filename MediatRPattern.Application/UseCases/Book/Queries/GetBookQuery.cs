using MediatR;
using MediatRPattern.Application.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace MediatRPattern.Application.UseCases.Book.Queries
{
    using MediatRPattern.Domain.Entities;

    public class GetBookQuery : IRequest<List<Book>>
    {
    }

    public class GetBookQueryHandler : IRequestHandler<GetBookQuery, List<Book>>
    {
        private readonly IApplicationDBContext context;

        public GetBookQueryHandler(IApplicationDBContext context)
        {
            this.context = context;
        }

        public async Task<List<Book>> Handle(GetBookQuery request, CancellationToken cancellationToken)
        {
            var books = await context.Books
                .Select(b => new Book
                {
                    Id = b.Id,
                    Title = b.Title,
                    Description = b.Description,
                    Author = b.Author,
                })
                .ToListAsync(cancellationToken);

            return books;
        }
    }
}
