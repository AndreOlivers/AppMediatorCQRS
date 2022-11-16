using AppMediatorCQRS.Mediator.Notifications;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AppMediatorCQRS.Mediator.EventHandlers.PessoaEvent
{
    public class LogEventEditHandler : INotificationHandler<PessoaEditNotification>
    {
        public Task Handle(PessoaEditNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"Edição: '{notification.Id} - {notification.Nome} - {notification.Idade} - {notification.Sexo} - {notification.IsEfetivado}'");
            });
        }
    }
}
