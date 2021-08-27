using DiscussionBoard.DAL.Interfaces.Entity;

namespace DiscussionBoard.DAL.Entities
{
    public class DiscussionBoard:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SocietyId { get; set; }
        public int MessageCount { get; set; } 
    }
}