using AppMediatorCQRS.Interfaces;
using AppMediatorCQRS.Mediator.Commands;
using AppMediatorCQRS.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AppMediatorCQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IMediator _mediador;
        private readonly IRepository<Models.Pessoa> _repository;

        public PessoaController(IMediator mediador, IRepository<Pessoa> repository)
        {
            _mediador = mediador;
            _repository = repository;
        }

        #region GET
        [HttpGet]
        public async Task<IActionResult> GetAllPessoa()
        {
            return Ok(await _repository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetIdPessoa(int id)
        {
            return Ok(await _repository.GetById(id));
        }
        #endregion

        #region POST
        [HttpPost]
        public async Task<IActionResult> PostPessoa(CreatePessoaCommand command)
        {
            var response = await _mediador.Send(command);
            return Ok(response);
        }
        #endregion

        #region POST
        [HttpPut]
        public async Task<IActionResult> PutPessoa(EditPessoaCommand command)
        {
            var response = await _mediador.Send(command);
            return Ok(response);
        }
        #endregion

        #region DELETE
        [HttpPut("{id}")]
        public async Task<IActionResult> DeletePessoa(int id)
        {
            var pessoaId = new DeletePessoaCommand { Id = id };
            var result = await _mediador.Send(pessoaId);
            return Ok(result);
        }
        #endregion
    }
}
