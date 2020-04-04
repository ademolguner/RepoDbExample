using RepoDbExample.Core.DataAccess.RepoDb;
using RepoDbExample.DataAccess.Abstract;
using RepoDbExample.DataAccess.Concrete.DbConnection.PostgreSqLConnectionDatabases;
using RepoDbExample.Entites.Models.PostgreSql.Finans;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDbExample.DataAccess.Concrete
{
  public  class CashboxDal : PostgreSqlRepositoryBase<Cashbox, FinansDbConnectionFactory>, ICashboxDal
    {
    }
}
