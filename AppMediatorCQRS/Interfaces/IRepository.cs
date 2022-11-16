using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppMediatorCQRS.Interfaces
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(int id);

        Task Create(T item);

        Task Edit(T item);

        Task Delete(int id);
    }
}
