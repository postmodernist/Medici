using User.DAL.Infrastruture;
using User.DAL.Interfaces;
using User.DAL.Repositories;

namespace User.DAL.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserSubscriptionRepository _userSubscriptionRepository;

        public UnitOfWork()
        {
            _userRepository = new UserRepository(new UserDbContext());
            _userSubscriptionRepository = new UserSubscriptionRepository(new UserDbContext());
        }
        public IUserRepository UserRepository { get { return _userRepository; } }
        public IUserSubscriptionRepository UserSubscriptionRepository { get { return _userSubscriptionRepository; } }
    }
}