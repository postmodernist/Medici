using System.Collections.Generic;
using Library.DAL.Interfaces.Entity;

namespace Library.DAL.Entites
{
    public class Library:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public IEnumerable<LibraryItem> Items { get; set; }
    }
}