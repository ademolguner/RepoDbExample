using RepoDbExample.Core.DataAccess.RepoDb;
using RepoDbExample.DataAccess.Abstract;
using RepoDbExample.Entites.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDbExample.DataAccess.Concrete
{
   public class CategoryDal : RepoDbRepositoryBase<Category, NwDbConnectionFactory>, ICategoryDal
    {
        
    }
}
