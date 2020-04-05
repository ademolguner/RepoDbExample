using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RepoDbExample.Business.Abstract;
using RepoDbExample.Entites.Models.PostgreSql.Finans;
using RepoDbExample.Entites.Models.Sql.AdemBlogDb;
using RepoDbExample.Entites.Models.Sql.Northwind;
using RepoDbExample.MvcWebUI.Models;

namespace RepoDbExample.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryService _categoryService;
        private readonly ICashboxService _cashboxService;
        private readonly ITagService _tagService;



        public HomeController(ILogger<HomeController> logger, ICategoryService categoryService, ICashboxService cashboxService, ITagService tagService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _cashboxService = cashboxService;
            _tagService = tagService;
        }

        public IActionResult Index()
        {
            _categoryService.NewItem(new Entites.Models.Sql.Northwind.Category { CategoryName = "Testere", Description = "denem" });
             _categoryService.QueryAll();

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
