using System.Collections.Generic;
using Bookmark.DAL.Interfaces.Entity;

namespace Bookmark.DAL.Entities
{
    public class Topic:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public IEnumerable<Bookmark> Bookmarks { get; set; }
    }
}