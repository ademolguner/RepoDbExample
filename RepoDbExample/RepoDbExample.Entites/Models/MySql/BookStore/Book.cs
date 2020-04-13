using RepoDbExample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDbExample.Entites.Models.MySql.BookStore
{
   public class Book: IMySqlEntityType
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public DateTime EditionYear { get; set; }
        public int Issue { get; set; }
        public string CoverImage { get; set; }
    }
}
