using System;
using User.DAL.Interfaces;

namespace User.DAL.Entities
{
    public class UserRecord: IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string DeliveryAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Password { get; set; }
    }
}