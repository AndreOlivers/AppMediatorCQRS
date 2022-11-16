using AppMediatorCQRS.Interfaces;
using AppMediatorCQRS.Mediator.Commands;
using AppMediatorCQRS.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AppMediatorCQRS.Mediator.Handlers
{
    public class PessoaCreateCommandHandler : IRequestHandler<CreatePessoaCommand, string>
    {
        private readonly IMediator _mediator;
        private readonly IRepository<Pessoa> _repository;

        public PessoaCreateCommandHandler(IMediator mediator, IRepository<Pessoa> repository)
        {
            _mediator = mediator;
            _repository = repository;
        }

        public async Task<string> Handle(CreatePessoaCommand request, CancellationToken cancellationToken)
        {
            var pessoa = new Pessoa { Nome = request.Nome, Idade = request.Idade, Sexo = request.Sexo };
            try
            {
                await _repository.Create(pessoa);

                return await Task.FromResult("Pessoa cadstrada com sucesso");
            }
            catch (Exception e)
            {
                return await Task.FromResult("Ocorreu um erro no momento da criação");
            }
        }
    }
}
