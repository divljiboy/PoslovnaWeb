using PINF.Model.Model;
using System.Linq;
using System.Data.Entity;

namespace PINF.Data.Extensions
{
    public static class BuildExtensions
    {
        public static IQueryable<Korisnik> BuildUser(this IQueryable<Korisnik> query)
        {
            return query.
                Include(x => x.Role);
        }

    }
}
