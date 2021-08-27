using System;
using Conversation.Domain.Interfaces;

namespace Conversation.Domain.Entities
{
    public class Conversation: IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}