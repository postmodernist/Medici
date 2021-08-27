using System.Collections.Generic;
using System.Threading.Tasks;
using ImageAlbum.Domain.Entites;
using ImageAlbum.Infrastructure.Interfaces;
using ImageAlbum.Infrastructure.MongoDbConfig;
using ImageAlbum.Infrastructure.Repositories;

namespace ImageAlbum.Infrastructure.Services
{
    public class ImageAlbumService: IImageAlbumService
    {
        private ImageAlbumRepository _repository;

        public ImageAlbumService(IMongoDbConfig config)
        {
            _repository = new ImageAlbumRepository(config);
        }
        public async Task<IEnumerable<ImageAlbumRecord>> GetAllAlbums()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<ImageAlbumRecord> GetAlbumById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<bool> AddAlbum(ImageAlbumRecord album)
        {
            var result = await _repository.AddAsync(album);
            return result;
        }

        public async Task<bool> UpdateAlbum(ImageAlbumRecord album)
        {
            var result = await _repository.UpdateAsync(album);
            return result;
        }

        public Task<bool> DeleteAlbum(int id)
        {
            var result = _repository.DeleteAsync(id);
            return result;
        }
    }
}