using AppMediatorCQRS.Interfaces;
using AppMediatorCQRS.Mediator.Commands;
using AppMediatorCQRS.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AppMediatorCQRS.Mediator.Handlers
{
    public class PessoaEditCommandHandler : IRequestHandler<EditPessoaCommand, string>
    {
        private readonly IMediator _mediator;
        private readonly IRepository<Pessoa> _repository;

        public PessoaEditCommandHandler(IMediator mediator, IRepository<Pessoa> repository)
        {
            _mediator = mediator;
            _repository = repository;
        }
        
        public async Task<string> Handle(EditPessoaCommand request, CancellationToken cancellationToken)
        {
            var pessoa = new Pessoa { Id = request.Id, Nome = request.Nome, Idade = request.Idade, Sexo = request.Sexo };
            try
            {
                await _repository.Edit(pessoa);
                return await Task.FromResult("Pessoa editada com sucesso");
            }
            catch (Exception e)
            {
                return await Task.FromResult("Ocorreu um erro no momento da edição");
            }
        }
    }
}
