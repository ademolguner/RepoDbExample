using RepoDbExample.Entites.Models.MySql.BookStore;
using System.Collections.Generic;

namespace RepoDbExample.Business.Abstract
{
    public interface IBookService
    {
        List<Book> TumKitaplariGetir();
    }
}