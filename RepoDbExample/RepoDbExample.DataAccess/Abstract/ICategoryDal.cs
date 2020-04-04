using RepoDbExample.Core.DataAccess; 
using RepoDbExample.Entites.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDbExample.DataAccess.Abstract
{
    public interface ICategoryDal : IRepoDbRepository<Category>
    {
    }
}
