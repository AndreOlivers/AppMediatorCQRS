using AppMediatorCQRS.Mediator.Notifications;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AppMediatorCQRS.Mediator.EventHandlers.PessoaEvent
{
    public class LogEventDeleteHandler : INotificationHandler<PessoaDeleteNotification>
    {
        public Task Handle(PessoaDeleteNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"EXCLUSAO: '{notification.Id} - {notification.IsEfetivado}'");
            });
        }
    }
}
