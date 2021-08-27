namespace User.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        public IUserRepository UserRepository { get; }

        public IUserSubscriptionRepository UserSubscriptionRepository { get; }
    }
}