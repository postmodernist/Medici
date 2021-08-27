using System.Collections.Generic;
using System.Threading.Tasks;
using Order.DAL.Interfaces.Entity;

namespace Order.DAL.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T: IEntity
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T> GetById(int id);
        public Task<T> Update(T entity);
        public Task<T> Delete(int id);
        public Task<T> Add(T entity);

    }
}