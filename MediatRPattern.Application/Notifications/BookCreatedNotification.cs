using MediatR;
using MediatRPattern.Domain.Entities;

namespace MediatRPattern.Application.Notifications
{
    public class BookCreatedNotification : Book, INotification
    {
    }

    public class BookCreatedNotificationHandler : INotificationHandler<BookCreatedNotification>
    {
        public Task Handle(BookCreatedNotification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Salom. new book created with id - {notification.Id} and with title - {notification.Title}");
            return Task.CompletedTask;
        }
    }

    public class BookCreatedNotificationHandler2 : INotificationHandler<BookCreatedNotification>
    {
        public Task Handle(BookCreatedNotification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Salom. 2 - handler");
            return Task.CompletedTask;
        }
    }
}
