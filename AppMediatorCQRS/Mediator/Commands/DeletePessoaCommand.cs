using MediatR;

namespace AppMediatorCQRS.Mediator.Commands
{
    public class DeletePessoaCommand : IRequest<string>
    {
        public int Id { get; set; }
    }
}
