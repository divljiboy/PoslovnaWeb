using System;
using PINF.Data.Infrastructure;
using PINF.Model.Model;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace PINF.Data.Repositories
{
    public interface IUserRepository : IRepository<Korisnik>
    {
    }

    public class UserRepository : RepositoryBase<Korisnik>, IUserRepository
    {
        public UserRepository(IDbFactory dbFactory) :
            base(dbFactory)
        {
        }
    }
}
