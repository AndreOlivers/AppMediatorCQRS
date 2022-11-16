using AppMediatorCQRS.Mediator.Notifications;
using System;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AppMediatorCQRS.Mediator.EventHandlers.PessoaEvent
{
    public class LogErrorNotification : INotificationHandler<ErrorNotification>
    {
        public Task Handle(ErrorNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"ERRO: '{notification.Excecao} \n {notification.PilhaErro}'");
            });
        }
    }
}
