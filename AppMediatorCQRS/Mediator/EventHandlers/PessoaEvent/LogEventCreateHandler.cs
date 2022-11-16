using AppMediatorCQRS.Mediator.Notifications;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AppMediatorCQRS.Mediator.EventHandlers.PessoaEvent
{
    public class LogEventCreateHandler : INotificationHandler<PessoaCreateNotification>
    {
        public Task Handle(PessoaCreateNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"CRIACAO: '{notification.Id} - {notification.Nome} - {notification.Idade} - {notification.Sexo}'");
            });
        }
    }
}
