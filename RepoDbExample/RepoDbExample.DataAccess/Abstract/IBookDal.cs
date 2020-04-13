using RepoDbExample.Core.DataAccess;
using RepoDbExample.Entites.Models.MySql.BookStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDbExample.DataAccess.Abstract
{
   public interface IBookDal:IRepository<Book>
    {
    }
}
