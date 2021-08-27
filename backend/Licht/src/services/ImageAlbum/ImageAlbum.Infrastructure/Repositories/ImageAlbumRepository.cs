using ImageAlbum.Domain.Entites;
using ImageAlbum.Infrastructure.Interfaces;
using ImageAlbum.Infrastructure.MongoDbConfig;

namespace ImageAlbum.Infrastructure.Repositories
{
    public class ImageAlbumRepository: GenericRepository<ImageAlbumRecord>, IImageAlbumRepository
    {
        public ImageAlbumRepository(IMongoDbConfig config): base(config, "ImageAlbums")
        {
            
        }
    }
}