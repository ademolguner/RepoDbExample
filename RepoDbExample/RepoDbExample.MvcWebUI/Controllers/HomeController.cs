using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RepoDbExample.Business.Abstract;
using RepoDbExample.Entites.Models.PostgreSql.Finans;
using RepoDbExample.Entites.Models.Sql.Northwind;
using RepoDbExample.MvcWebUI.Models;

namespace RepoDbExample.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryService _categoryService;
        private readonly ICashboxService _cashboxService;



        public HomeController(ILogger<HomeController> logger, ICategoryService categoryService, ICashboxService cashboxService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _cashboxService = cashboxService;
        }

        public IActionResult Index()
        {
            //     _categoryService.NewItem(new Category { CategoryName = "Testere", Description = "denem" });
            //   _categoryService.QueryAll(new Category { CategoryName = "Testere", Description = "denem", CategoryID = 9 });

            _cashboxService.NewItem(new Cashbox { CashTypeId = 1, TotalQuantity = 45 });

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
