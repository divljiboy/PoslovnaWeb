using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Data.Infrastructure
{
    public class DbFactory : Disposable , IDbFactory
    {
        PINFContext dbContext;

        public PINFContext Init()
        {
            return dbContext ?? (dbContext = new PINFContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }

    }
}
