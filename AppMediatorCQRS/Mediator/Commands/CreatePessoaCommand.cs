using MediatR;

namespace AppMediatorCQRS.Mediator.Commands
{
    public class CreatePessoaCommand : IRequest<string>
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
    }
}
