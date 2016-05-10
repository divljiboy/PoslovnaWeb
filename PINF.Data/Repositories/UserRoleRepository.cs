using PINF.Data.Infrastructure;
using PINF.Model.Model;

namespace PINF.Data.Repositories
{

    public interface IUserRoleRepository : IRepository<UserRole>
    {

    }

    public class UserRoleRepository : RepositoryBase<UserRole> , IUserRoleRepository
    {
        public UserRoleRepository(IDbFactory dbFactory) :
            base(dbFactory)
        {

        }
    }

}
