using AppMediatorCQRS.Interfaces;
using AppMediatorCQRS.Mediator.Commands;
using AppMediatorCQRS.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AppMediatorCQRS.Mediator.Handlers
{
    public class PessoaDeleteCommandHandler : IRequestHandler<DeletePessoaCommand, string>
    {
        private readonly IMediator _mediator;
        private readonly IRepository<Pessoa> _repository;

        public PessoaDeleteCommandHandler(IMediator mediator, IRepository<Pessoa> repository)
        {
            _mediator = mediator;
            _repository = repository;
        }

        public async Task<string> Handle(DeletePessoaCommand request, CancellationToken cancellationToken)
        {
            try
            {
                await _repository.Delete(request.Id);
                return await Task.FromResult("Pessoa excluída com sucesso");
            }
            catch (Exception e)
            {
                return await Task.FromResult("Pessoa excluída com sucesso");
            }
        }
    }
}
