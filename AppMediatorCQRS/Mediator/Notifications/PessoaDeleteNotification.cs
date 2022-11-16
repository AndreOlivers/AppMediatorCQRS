using MediatR;

namespace AppMediatorCQRS.Mediator.Notifications
{
    public class PessoaDeleteNotification : INotification
    {
        public int Id { get; set; }
        public bool IsEfetivado { get; set; }
    }
}
