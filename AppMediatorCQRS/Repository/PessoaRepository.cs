using AppMediatorCQRS.Interfaces;
using AppMediatorCQRS.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMediatorCQRS.Repository
{
    public class PessoaRepository : IRepository<Pessoa>
    {
        private static Dictionary<int, Pessoa> pessoas = new Dictionary<int, Pessoa>();

        public async Task<IEnumerable<Pessoa>> GetAll()
        {
            return await Task.Run(() => pessoas.Values.ToList());
        }

        public async Task<Pessoa> GetById(int id)
        {
            return await Task.Run(() => pessoas.GetValueOrDefault(id));
        }

        public async Task Create(Pessoa pessoa)
        {
            await Task.Run(() => pessoas.Add(pessoa.Id, pessoa));
        }
        public async Task Edit(Pessoa pessoa)
        {
            await Task.Run(() =>
            {
                pessoas.Remove(pessoa.Id);
                pessoas.Add(pessoa.Id, pessoa);
            });
        }

        public async Task Delete(int id)
        {
            await Task.Run(() => pessoas.Remove(id));
        }
    }
}
