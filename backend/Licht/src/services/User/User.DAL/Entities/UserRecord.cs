using System;
using LichtDataPack.Interfaces.Entity;

namespace User.DAL.Entities
{
    public class UserRecord: IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}