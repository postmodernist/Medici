using User.DAL.Entities;
using User.DAL.Infrastruture;
using User.DAL.Interfaces;

namespace User.DAL.Repositories
{
    public class UserRepository: GenericRepository<UserRecord> , IUserRepository
    {
        private readonly UserDbContext _context = new UserDbContext();
        public UserRepository(UserDbContext _context) : base(_context)
        {
        }
    }
}