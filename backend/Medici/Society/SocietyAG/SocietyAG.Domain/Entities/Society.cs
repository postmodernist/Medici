using SocietyAG.Domain.Interfaces;

namespace SocietyAG.Domain.Entities
{
    public class Society: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AvatarId { get; set; }
    }
}