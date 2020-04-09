using RepoDbExample.Business.Abstract;
using RepoDbExample.DataAccess.Abstract;
using RepoDbExample.Entites.Models.Sql.Northwind;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDbExample.Business.Concrete.Managers
{
    public class CategoryManager : ICategoryService
    {

        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }


        public void NewItem(Category category)
        {
            _categoryDal.Insert(category);
        }

        public IEnumerable<Category> QueryAll()
        {
           return  _categoryDal.GetList();
        }
    }
}
