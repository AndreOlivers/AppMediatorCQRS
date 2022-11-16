using MediatR;

namespace AppMediatorCQRS.Mediator.Notifications
{
    public class ErrorNotification : INotification
    {
        public string Excecao { get; set; }
        public string PilhaErro { get; set; }
    }
}
