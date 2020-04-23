using RepoDbExample.Business.Abstract;
using RepoDbExample.DataAccess.Abstract;
using RepoDbExample.Entites.Models.Sql.Northwind;
using System.Collections.Generic;

namespace RepoDbExample.Business.Concrete.Managers
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal) => _categoryDal = categoryDal;

        public List<Category> TumKategorilerim()
        {
            return _categoryDal.GetList();
        }
    }
}