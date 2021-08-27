using Settings.DAL.Interfaces.Entities;

namespace Settings.DAL.Entities
{
    public class UserSettingRecord: IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        //TODO add setting property 
    }
}