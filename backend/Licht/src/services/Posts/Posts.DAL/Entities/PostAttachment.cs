using LichtDataPack.Interfaces.Entity;

namespace Posts.DAL.Entities
{
    public class PostAttachment: IEntity
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int ImageAlbumId { get; set; }
    }
}