using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RepoDb;
using RepoDb.Enumerations;
using RepoDbExample.Business.Abstract;
using RepoDbExample.Entites.Models.PostgreSql.Finans;
using RepoDbExample.Entites.Models.Sql.AdemBlogDb;
using RepoDbExample.Entites.Models.Sql.Northwind;
using RepoDbExample.MvcWebUI.Models;

namespace RepoDbExample.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly ICategoryService _categoryService;
        private readonly ICashboxService _cashboxService;
        private readonly ITagService _tagService;
        private readonly IPostService _postService;



        public HomeController(ICategoryService categoryService, ICashboxService cashboxService, ITagService tagService, IPostService postService)
        {

            _categoryService = categoryService;
            _cashboxService = cashboxService;
            _tagService = tagService;
            _postService = postService;
        }

        public IActionResult Index()
        {
            var sort = new[] { new OrderField("Title", RepoDb.Enumerations.Order.Ascending),
                               new OrderField("UserId", RepoDb.Enumerations.Order.Descending)
                             };

          //  var cashboxListem = _cashboxService.SiraliGetir(c => c.CashTypeId == 1, sort);

            var siraliPostListem = _postService.SiraliGetir(c => c.CategoryId == 5, sort);

            // var data = _tagService.GetById(14);
            var tagData = _tagService.GetByTagName("RepoDb");

            _categoryService.NewItem(new Entites.Models.Sql.Northwind.Category { CategoryName = "Testere", Description = "denem" });
            _categoryService.TumunuGetir();


            _tagService.NewTagItem(new Tag { TagName = "RepoDB" });
            _tagService.TumunuGetir();

            _cashboxService.NewItem(new Cashbox { CashTypeId = 1, TotalQuantity = 45 });
            _cashboxService.QueryAll();




            return View();
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
