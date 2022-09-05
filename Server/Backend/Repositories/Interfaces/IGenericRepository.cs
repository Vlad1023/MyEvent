using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        T Get(string id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Add(T entity);
        T Delete(T entity);
        T Update(T entity);
    }
}
