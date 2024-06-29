using MediatRPattern.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MediatRPattern.Application.Abstractions
{
    public interface IApplicationDBContext
    {
        DbSet<Book> Books { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
