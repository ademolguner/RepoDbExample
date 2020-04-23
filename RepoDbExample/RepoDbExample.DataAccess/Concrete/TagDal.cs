﻿using RepoDbExample.Core.DataAccess.RepoDb;
using RepoDbExample.DataAccess.Abstract;
using RepoDbExample.DataAccess.Concrete.DbConnection.SqlConnectionDatabases;
using RepoDbExample.Entites.Models.Sql.AdemBlogDb;

namespace RepoDbExample.DataAccess.Concrete
{
    public class TagDal : DbRepositoryBase<Tag, AdemBlogDbConnectionFactory>, ITagDal
    {
    }
}