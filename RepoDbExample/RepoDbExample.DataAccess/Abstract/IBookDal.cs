using RepoDbExample.Core.DataAccess;
using RepoDbExample.Entites.Models.MySql.BookStore;

namespace RepoDbExample.DataAccess.Abstract
{
    public interface IBookDal : IRepository<Book>
    {
    }
}