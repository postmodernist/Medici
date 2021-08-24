using System;
using User.Domain.Interfaces;

namespace User.Domain.Entity
{
    public class User: IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int AvatarId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime RegisterAt { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Status { get; set; }

    }
}