﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        PINFContext Init();
    }
}
