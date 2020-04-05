using RepoDbExample.Business.Abstract;
using RepoDbExample.DataAccess.Abstract;
using RepoDbExample.Entites.Models.Sql.AdemBlogDb;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDbExample.Business.Concrete.Managers
{
    public class TagManager : ITagService
    {

        private readonly ITagDal _tagDal;

        public TagManager(ITagDal tagDal)
        {
            _tagDal = tagDal;
        }



        public void NewTagItem(Tag tag)
        {
            _tagDal.Insert(tag);
        }

        public IEnumerable<Tag> TumunuGetir()
        {
            return _tagDal.QueryAll();
        }
    }
}
