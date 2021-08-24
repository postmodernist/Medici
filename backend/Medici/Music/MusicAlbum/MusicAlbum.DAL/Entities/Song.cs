using MusicAlbum.DAL.Interfaces;

namespace MusicAlbum.DAL.Entities
{
    public class Song: IEntity
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public int AlbumId { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int ResourceId { get; set; }
        public string ResourceUri { get; set; }
    }
}