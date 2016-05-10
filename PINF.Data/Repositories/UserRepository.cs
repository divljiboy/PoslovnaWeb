using PINF.Data.Infrastructure;
using PINF.Model.Model;

namespace PINF.Data.Repositories
{
    public interface IUserRepository : IRepository<User>
    {

    }

    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IDbFactory dbFactory) :
            base(dbFactory)
        {

        }
    }
}
