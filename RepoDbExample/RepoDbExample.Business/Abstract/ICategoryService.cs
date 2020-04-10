using RepoDbExample.Entites.Models.Sql.Northwind;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDbExample.Business.Abstract
{
    public interface ICategoryService
    {
        void NewItem(Category category);

        IEnumerable<Category> TumunuGetir();
    }
}
