using System.Collections.Generic;
using System.Threading.Tasks;
using ImageAlbum.Domain.Entites;

namespace ImageAlbum.Infrastructure.Interfaces
{
    public interface IImageAlbumService
    {
        public Task<IEnumerable<ImageAlbumRecord>> GetAllAlbums();
        public Task<ImageAlbumRecord> GetAlbumById(int id);
        public Task<bool> AddAlbum(ImageAlbumRecord album);
        public Task<bool> UpdateAlbum(ImageAlbumRecord album);
        public Task<bool> DeleteAlbum(int id);
    }
}