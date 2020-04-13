using RepoDbExample.Core.DataAccess.RepoDb;
using RepoDbExample.DataAccess.Abstract;
using RepoDbExample.DataAccess.Concrete.DbConnection.MySqlDatabases;
using RepoDbExample.Entites.Models.MySql.BookStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDbExample.DataAccess.Concrete
{
    public class BookDal : DbRepositoryBase<Book, BookStoreDbConnectionFactory>, IBookDal
    {
    }
}
