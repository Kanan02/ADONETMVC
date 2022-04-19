using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdoNetMVC.Repositories.Abstract
{
    public interface IRepository<T>
    {
        Task<int> Add(T entity);
        Task<int> Delete(int id);
        Task<int> Edit(T entity);
        Task<T> Get(int id);
        Task<IEnumerable<T>> Get();

    }
}
