using MusicAlbum.DAL.Interfaces;

namespace MusicAlbum.DAL.Entities
{
    public class MusicAlbum:IEntity
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public string Name { get; set; }
        public AlbumType AlbumType { get; set; }
        public int CoverAlbumId { get; set; }
        public int CoverImageId { get; set; }
    }
}