using RepoDbExample.Core.DataAccess;
using RepoDbExample.Entites.Models.PostgreSql.Finans;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDbExample.DataAccess.Abstract
{
    public interface ICashboxDal : IRepository<Cashbox>
    {
    }
}
