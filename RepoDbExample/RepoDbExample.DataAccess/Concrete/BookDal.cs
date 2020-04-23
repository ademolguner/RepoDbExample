using RepoDbExample.Core.DataAccess;
using RepoDbExample.Core.DataAccess.RepoDb;
using RepoDbExample.DataAccess.Abstract;
using RepoDbExample.DataAccess.Concrete.DbConnection.MySqlDatabases;
using RepoDbExample.Entites.Models.MySql.BookStore;

namespace RepoDbExample.DataAccess.Concrete
{
    public class BookDal : DbRepositoryBase<Book, BookStoreDbConnectionFactory>, IBookDal
    {
    }
}