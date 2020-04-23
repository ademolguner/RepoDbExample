using RepoDbExample.Entites.Models.Sql.Northwind;
using System.Collections.Generic;

namespace RepoDbExample.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> TumKategorilerim();
    }
}