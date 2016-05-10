using PINF.Model.Model;
using System.Linq;
using System.Data.Entity;

namespace PINF.Data.Extensions
{
    public static class BuildExtensions
    {
        public static IQueryable<User> BuildUser(this IQueryable<User> query)
        {
            return query.
                Include(x => x.Role);
        }

    }
}
