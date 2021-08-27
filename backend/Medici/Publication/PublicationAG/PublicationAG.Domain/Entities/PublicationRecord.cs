using PublicationAG.Domain.Interfaces;

namespace PublicationAG.Domain.Entities
{
    public class PublicationRecord: IEntity
    {
        public int Id { get; set; }
        public PublicationType PublicationType { get; set; }
        public int ProxyId { get; set; }
    }
}