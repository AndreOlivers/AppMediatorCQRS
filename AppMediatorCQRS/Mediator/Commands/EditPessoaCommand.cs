using MediatR;

namespace AppMediatorCQRS.Mediator.Commands
{
    public class EditPessoaCommand : IRequest<string>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
    }
}
