using LichtDataPack.Interfaces.Entity;

namespace ImageAlbum.Domain.Entites
{
    public class Image:IEntity
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public int FileId { get; set; }
    }
}