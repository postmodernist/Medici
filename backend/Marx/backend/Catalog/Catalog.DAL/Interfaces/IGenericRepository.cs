using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.DAL.Interfaces
{
    public interface IGenericRepository<T> where T: class, IEntity
    {
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetByIdAsync(int Id);
        public Task<T> AddAsync(T entity);
        public Task<T> UpdateAsync(T entity);
        public Task DeleteAsync(int Id);
    }
}