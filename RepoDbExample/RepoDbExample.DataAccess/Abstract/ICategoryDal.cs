using RepoDbExample.Core.DataAccess;
using RepoDbExample.Entites.Models.Sql.Northwind;

namespace RepoDbExample.DataAccess.Abstract
{
    public interface ICategoryDal : IRepository<Category>
    {
    }
}