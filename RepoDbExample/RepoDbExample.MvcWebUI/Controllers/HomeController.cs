using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RepoDb;
using RepoDb.Enumerations;
using RepoDbExample.Business.Abstract;
using RepoDbExample.Core.DataAccess;
using RepoDbExample.Core.DataAccess.RepoDb;
using RepoDbExample.Core.DataAccess.RepoDb.DbConnectionOptions;
using RepoDbExample.DataAccess.Concrete.DbConnection.SqlConnectionDatabases;
using RepoDbExample.Entites.Models.PostgreSql.Finans;
using RepoDbExample.Entites.Models.Sql.AdemBlogDb;
using RepoDbExample.Entites.Models.Sql.AdemBlogDb.ComplexTypes;
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
        //private readonly IQueryableRepository<PostInfo> _queryableRepository;
        public QueryableRepositoryBase<PostInfo, AoBlogDbConnectionFactory> postInfoRepo = new QueryableRepositoryBase<PostInfo, AoBlogDbConnectionFactory>();

        public HomeController(ICategoryService categoryService, ICashboxService cashboxService, ITagService tagService, IPostService postService
            //, IQueryableRepository<PostInfo> queryableRepository
            )
        {

            _categoryService = categoryService;
            _cashboxService = cashboxService;
            _tagService = tagService;
            _postService = postService;
        }

        public IActionResult Index()
        {

            #region yardımcı test kodları
            //Type myType = typeof(Post);

            //var myPropInfo2 = myType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            //foreach (var item in myPropInfo2)
            //{

            //}

            // Get the PropertyInfo by passing the property name and specifying the BindingFlags.
            //PropertyInfo myPropInfo = myType.GetProperty("Title", BindingFlags.Public | BindingFlags.Instance);
            //var propName = typeof(Post).GetProperty(new Post().Title, BindingFlags.Public | BindingFlags.Instance).Name;

            //new Post().Title
            //   GetType(new Post).GetProperty(new Post().Title).GetValue(gCases(CaseIndex).GenInfo, Nothing)
            #endregion


            string queryText =  @" select 
                                          p.PostId,
                                          p.Title,
                                          c.CategoryId,
                                          c.CategoryName
                                     FROM [AdemBlogDb].[dbo].[Post]  as p
                               inner join [AdemBlogDb].[dbo].[Category] as c on c.CategoryId=p.CategoryId";

            var midirRepoText = postInfoRepo.GetByExecuteTextQuery(queryText, null);
            var midirRepoProcedure = postInfoRepo.GetByExecuteStoredProcedureQuery("[dbo].[PostInfoList]", null);


            var postListem1 = _postService.TumPostlariGetir();

            var postListem2 = _postService.TumPostlariGetir_Where(true);

            var postListem3 = _postService.TumPostlariGetir_Order(RepoDb.Enumerations.Order.Ascending, RepoDb.Enumerations.Order.Descending);

            var postListem4 = _postService.TumPostlariGetir_Where_Order(5, false, RepoDb.Enumerations.Order.Ascending);

            var postListem5 = _postService.TumPostlariGetir_Adet(3);

            var postListem6 = _postService.TumPostlariGetir_Where_Adet(true, 3);

            var postListem7 = _postService.TumPostlariGetir_Order_Adet(RepoDb.Enumerations.Order.Ascending, 3);

            var postListem8 = _postService.TumPostlariGetir_Where_Order_Adet(5, true, RepoDb.Enumerations.Order.Ascending, RepoDb.Enumerations.Order.Descending, 3);                                         




             


            var data = _tagService.GetById(14);
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
