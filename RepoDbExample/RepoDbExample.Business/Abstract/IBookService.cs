using RepoDbExample.Entites.Models.MySql.BookStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDbExample.Business.Abstract
{
   public interface IBookService
    {
        List<Book> TumKitaplariGetir();
        List<Book> YazarinKitaplariniGetir(string authorName);
    }
}
