using RepoDb;
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

        public Tag GetById(int id)
        {
            return _tagDal.Get(x => x.TagId == id);
        }

        public Tag GetByTagName(string tagName)
        {
            return _tagDal.Get(c => c.TagName == tagName);
        }

        public void NewTagItem(Tag tag)
        {
            _tagDal.Insert(tag);
        }

        public IEnumerable<Tag> TumunuGetir()
        {
            return _tagDal.GetList();
        }
    }
}
