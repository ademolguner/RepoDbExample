using RepoDbExample.Entites.Models.Sql.AdemBlogDb;
using System.Collections.Generic;

namespace RepoDbExample.Business.Abstract
{
    public interface ITagService
    {
        IEnumerable<Tag> TumunuGetir();

        void NewTagItem(Tag tag);

        Tag GetById(int id);

        Tag GetByTagName(string tagName);
    }
}