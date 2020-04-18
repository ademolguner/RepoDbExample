using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.AccessControl;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using Npgsql;
using RepoDb;
using RepoDb.Enumerations;
using RepoDb.Extensions;
using RepoDb.Interfaces;
using RepoDbExample.Business.Abstract;
using RepoDbExample.Core.DataAccess;
using RepoDbExample.Core.DataAccess.RepoDb;
using RepoDbExample.Core.DataAccess.RepoDb.DbConnectionOptions;
using RepoDbExample.DataAccess.Concrete.DbConnection.PostgreSqLConnectionDatabases;
using RepoDbExample.DataAccess.Concrete.DbConnection.SqlConnectionDatabases;
using RepoDbExample.Entites.Models.MySql.BookStore;
using RepoDbExample.Entites.Models.PostgreSql.Finans;
using RepoDbExample.Entites.Models.PostgreSql.Finans.ComplexTypes;
using RepoDbExample.Entites.Models.Sql.AdemBlogDb;
using RepoDbExample.Entites.Models.Sql.AdemBlogDb.ComplexTypes;
using RepoDbExample.Entites.Models.Sql.Northwind;
using RepoDbExample.MvcWebUI.Models;
using RepoDbExample.MvcWebUI.ViewModels;
using Order = RepoDbExample.Entites.Models.Sql.Northwind.Order;

namespace RepoDbExample.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly ICashboxService _cashboxService;
        private readonly ITagService _tagService;
        private readonly IPostService _postService;
        public QueryableRepositoryBase<PostInfo, AdemBlogDbConnectionFactory> postInfoRepo = new QueryableRepositoryBase<PostInfo, AdemBlogDbConnectionFactory>();
        public QueryableRepositoryBase<FinanceSummaryDto, FinansDbConnectionFactory> cashboxInfo = new QueryableRepositoryBase<FinanceSummaryDto, FinansDbConnectionFactory>();

        public readonly IBookService _bookService;
        public HomeController(ICategoryService categoryService, ICashboxService cashboxService, ITagService tagService, IPostService postService, IBookService bookService)
        {

            _categoryService = categoryService;
            _cashboxService = cashboxService;
            _tagService = tagService;
            _postService = postService;
            _bookService = bookService;
        }

        public IActionResult Index()
        { 
            HomeIndexViewModel homeIndexViewModel = new HomeIndexViewModel
            {
                BookList = GetBooks().ToList(),
                Cashboxes = GetFinancialCash()
            };
            return View(homeIndexViewModel);
        } 
           

        public ICollection<Book> GetBooks()
        {
            return _bookService.TumKitaplariGetir();

        }

        public List<FinanceSummaryDto> GetFinancialCash()
        {
            string finansQueryText = @"SELECT 
                                sum(cb.'TotalQuantity') as TotalQuantity ,
                                ct.'CashTypeName'
                                FROM public.'Cashbox'  as cb
                                inner JOIN 'CashType' as ct
                                ON cb.'CashTypeId' = ct.'CashTypeId'
                                group by
                                ct.'CashTypeName';";

            finansQueryText = finansQueryText.Replace('\'', '"');
            var midirRepoText = cashboxInfo.GetByExecuteTextQuery(finansQueryText, null);
            return midirRepoText.ToList();

        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
