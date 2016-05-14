using PINF.Data.Infrastructure;
using PINF.Model.Model;

namespace PINF.Data.Repositories
{

    public interface IUserRoleRepository : IRepository<KorisnikUloga>
    {

    }

    public class UserRoleRepository : RepositoryBase<KorisnikUloga> , IUserRoleRepository
    {
        public UserRoleRepository(IDbFactory dbFactory) :
            base(dbFactory)
        {

        }
    }

}
