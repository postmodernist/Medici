using System.Collections.Generic;
using System.Threading.Tasks;
using LichtDataPack.Interfaces.Entity;

namespace ImageAlbum.Infrastructure.Interfaces
{
    public interface IGenericRepository<T> where T: class, IEntity
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int Id);
        Task<bool> AddAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(int Id);
    }
}