using RepoDbExample.Entites.Models.MySql.BookStore;
using RepoDbExample.Entites.Models.PostgreSql.Finans.ComplexTypes;
using RepoDbExample.Entites.Models.Sql.AdemBlogDb.ComplexTypes;
using System.Collections.Generic;

namespace RepoDbExample.MvcWebUI.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<Book> BookList { get; set; }
        public List<FinanceSummaryDto> Cashboxes { get; set; }
        public List<PostInfoDto> Posts { get; set; }
    }
}