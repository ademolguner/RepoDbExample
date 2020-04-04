using RepoDbExample.Entites.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDbExample.Business.Abstract
{
    public interface ICategoryService
    {
        void NewItem(Category category);

        IEnumerable<Category> QueryAll(Category category);
    }
}
