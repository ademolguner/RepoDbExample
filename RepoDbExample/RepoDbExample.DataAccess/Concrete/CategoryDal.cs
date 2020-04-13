using RepoDbExample.Core.DataAccess.RepoDb;
using RepoDbExample.DataAccess.Abstract;
using RepoDbExample.DataAccess.Concrete.DbConnection.SqlConnectionDatabases;
using RepoDbExample.Entites.Models.Sql.Northwind;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDbExample.DataAccess.Concrete
{
    public class CategoryDal : DbRepositoryBase<Category, NorthWindDbConnectionFactory>, ICategoryDal
    {
        
    }
}
