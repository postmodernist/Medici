using System.Collections.Generic;

namespace LichtDataPack.Dtos.ImageAlbum
{
    public class ImageAlbumDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public IEnumerable<ImageDto> Images { get; set; }
    }
}