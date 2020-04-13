using RepoDbExample.Business.Abstract;
using RepoDbExample.DataAccess.Abstract;
using RepoDbExample.Entites.Models.MySql.BookStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDbExample.Business.Concrete.Managers
{
    public class BookManager : IBookService
    {
        private readonly IBookDal _bookDal;
        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public List<Book> TumKitaplariGetir()
        {
            return _bookDal.GetList();
        }

        public List<Book> YazarinKitaplariniGetir(string authorName)
        {
            return _bookDal.GetList(c => c.Author == authorName);
        }
    }
}
