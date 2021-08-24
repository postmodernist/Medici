using ImageAlbum.DAL.Infrastructure.Entity;

namespace ImageAlbum.DAL.Entities
{
    public class Image: IEntity
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public int ResourceId { get; set; }
        public int ResourceUri { get; set; }
    }
}