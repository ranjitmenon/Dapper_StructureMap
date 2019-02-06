﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.DAL
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection();
    }
}
