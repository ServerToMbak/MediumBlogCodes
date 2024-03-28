using UOWAndGenericRepoısitory.Entities;

namespace UOWAndGenericRepoısitory.Data
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
