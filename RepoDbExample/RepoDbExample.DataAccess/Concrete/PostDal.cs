using RepoDb;
using RepoDbExample.Core.DataAccess;
using RepoDbExample.Core.DataAccess.RepoDb;
using RepoDbExample.DataAccess.Abstract;
using RepoDbExample.DataAccess.Concrete.DbConnection.SqlConnectionDatabases;
using RepoDbExample.Entites.Models.Sql.AdemBlogDb;
using RepoDbExample.Entites.Models.Sql.AdemBlogDb.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RepoDbExample.DataAccess.Concrete
{
    public class PostDal : DbRepositoryBase<Post, AdemBlogDbConnectionFactory>,  IPostDal
    {
    }
}
