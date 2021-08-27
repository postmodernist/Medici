using Friend.DAL.Infrastructure.Entity;

namespace Friend.DAL.Entities
{
    public class FriendRequest: IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CandidateId { get; set; }
        public RequestStatus Status { get; set; }
    }

    public enum RequestStatus
    {
        InProgress,
        Allowed,
        NotAllowed
    }
}