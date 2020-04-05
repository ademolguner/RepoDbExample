using RepoDbExample.Core.DataAccess;
using RepoDbExample.Entites.Models.Sql.AdemBlogDb;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDbExample.DataAccess.Abstract
{

    public interface ITagDal : IRepository<Tag>
    {
    }
}
