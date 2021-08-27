using Settings.DAL.Interfaces.Entities;

namespace Settings.DAL.Entities
{
    public class SocietySettingRecord:IEntity
    {
        public int Id { get; set; }
        public int SocietyId { get; set; }
        //TODO Add settings property 
    }
}