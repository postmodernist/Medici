using System;
using Conversation.Domain.Interfaces;

namespace Conversation.Domain.Entities
{
    public class DeletedConversation: IEntity
    {
        public int Id { get; set; }
        public int ConversationId { get; set; }
        public int UserId { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}