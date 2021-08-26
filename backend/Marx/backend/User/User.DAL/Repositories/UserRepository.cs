using User.DAL.Entities;
using User.DAL.Infrastructure;
using User.DAL.Interfaces.Repositories;

namespace User.DAL.Repositories
{
    public class UserRepository:GenericRepository<UserRecord> ,IUserRepository
    {
        private readonly UserDbContext _context;
        public UserRepository(UserDbContext context):base(context)
        {
            _context = context;
        }
    }
}