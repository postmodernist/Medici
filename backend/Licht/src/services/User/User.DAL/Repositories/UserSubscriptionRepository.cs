using User.DAL.Entities;
using User.DAL.Infrastruture;
using User.DAL.Interfaces;

namespace User.DAL.Repositories
{
    public class UserSubscriptionRepository: GenericRepository<UserSubscription>, IUserSubscriptionRepository
    {
        public UserSubscriptionRepository(UserDbContext context ) : base(context)
        {
        }
    }
}