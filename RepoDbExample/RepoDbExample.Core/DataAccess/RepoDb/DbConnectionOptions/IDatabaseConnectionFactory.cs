using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace RepoDbExample.Core.DataAccess.RepoDb.DbConnectionOptions
{
   public  interface IDatabaseConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
