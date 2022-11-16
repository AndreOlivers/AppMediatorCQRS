using MediatR;

namespace AppMediatorCQRS.Mediator.Notifications
{
    public class PessoaCreateNotification : INotification
    {
        public int Id { get; set; }
        public string  Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
    }
}
