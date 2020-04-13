using RepoDbExample.Entites.Models.MySql.BookStore;
using RepoDbExample.Entites.Models.PostgreSql.Finans;
using RepoDbExample.Entites.Models.PostgreSql.Finans.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoDbExample.MvcWebUI.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<Book> BookList { get; set; }
        public List<FinanceSummaryDto> Cashboxes { get; set; }
    }
}
