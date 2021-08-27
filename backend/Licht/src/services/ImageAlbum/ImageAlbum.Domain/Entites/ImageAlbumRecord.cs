using System.Collections.Generic;
using LichtDataPack.Interfaces.Entity;

namespace ImageAlbum.Domain.Entites
{
    public class ImageAlbumRecord: IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public IEnumerable<Image> Images { get; set; }
    }
}