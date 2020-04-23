using Microsoft.AspNetCore.Mvc;
using RepoDbExample.Business.Abstract;
using RepoDbExample.Core.DataAccess.RepoDb;
using RepoDbExample.DataAccess.Concrete.DbConnection.PostgreSqLConnectionDatabases;
using RepoDbExample.DataAccess.Concrete.DbConnection.SqlConnectionDatabases;
using RepoDbExample.Entites.Models.MySql.BookStore;
using RepoDbExample.Entites.Models.PostgreSql.Finans.ComplexTypes;
using RepoDbExample.Entites.Models.Sql.AdemBlogDb.ComplexTypes;
using RepoDbExample.Entites.Models.Sql.Northwind;
using RepoDbExample.MvcWebUI.Models;
using RepoDbExample.MvcWebUI.ViewModels;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace RepoDbExample.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IBookService _bookService;
        private readonly ICashboxService _cashboxService;

        public QueryableRepositoryBase<PostInfoDto, AdemBlogDbConnectionFactory> postInfoRepo = new QueryableRepositoryBase<PostInfoDto, AdemBlogDbConnectionFactory>();
        public QueryableRepositoryBase<FinanceSummaryDto, FinansDbConnectionFactory> cashboxInfo = new QueryableRepositoryBase<FinanceSummaryDto, FinansDbConnectionFactory>();

        public HomeController(ICategoryService categoryService, IBookService bookService, ICashboxService cashboxService)
        {
            _categoryService = categoryService ?? throw new System.ArgumentNullException(nameof(categoryService));
            _bookService = bookService ?? throw new System.ArgumentNullException(nameof(bookService));
            _cashboxService = cashboxService;
        }

        public IActionResult Index()
        {
            ViewBag.MenuList = _categoryService.TumKategorilerim();
            HomeIndexViewModel homeIndexViewModel = new HomeIndexViewModel
            {
                BookList = GetBooks(),
                Cashboxes = _cashboxService.GetFinancialCashDalOperationJoin(),// GetFinancialCash(),
                Posts = GetPostListInfo()
            };
            return View(homeIndexViewModel);
        }

        private List<PostInfoDto> GetPostListInfo()
        {
            string postListProcNameText = @"[dbo].[PostListInfo]";
            var postListResult = postInfoRepo.GetByExecuteStoredProcedureQuery(postListProcNameText, null);
            return postListResult.ToList();
        }

        private List<Book> GetBooks()
        {
            return _bookService.TumKitaplariGetir();
        }

        private List<Category> GetCategoryAllList()
        {
            return _categoryService.TumKategorilerim();
        }

        private List<FinanceSummaryDto> GetFinancialCash()
        {
            string finansQueryText = @"SELECT
                                          sum(cb.'TotalQuantity') as TotalQuantity ,
                                          ct.'CashTypeName'
                                    FROM public.'Cashbox'  as cb
                                    inner JOIN 'CashType' as ct
                                    ON cb.'CashTypeId' = ct.'CashTypeId'
                                    group by ct.'CashTypeName';";
            finansQueryText = finansQueryText.Replace('\'', '"');
            var midirRepoText = cashboxInfo.GetByExecuteTextQuery(finansQueryText, null);
            return midirRepoText.ToList();
        }
         
        public IActionResult MenuPartial()
        {
            var data = _categoryService.TumKategorilerim();
            return PartialView("_KategoriListPartial", data.ToList());
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