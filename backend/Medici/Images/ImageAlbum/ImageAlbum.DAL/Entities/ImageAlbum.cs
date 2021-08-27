using System.Collections.Generic;
using ImageAlbum.DAL.Infrastructure.Entity;

namespace ImageAlbum.DAL.Entities
{
    public class ImageAlbum: IEntity
    {
        public int Id { get; set; }
        public int OwnerId { get; set; } //can be used for societies and users.
        public OwnerType OwnerType {get;set;}
        public string Name { get; set; }
        public IEnumerable<Image> Images { get; set; }
        public bool CanBeDeleted { get; set; }
        public bool Hidden { get; set; }
    }
    public enum OwnerType{
        Society,
        User
    }
}