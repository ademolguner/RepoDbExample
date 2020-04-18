using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RepoDb;
using RepoDbExample.Business.Abstract;
using RepoDbExample.Business.Concrete.Managers;
using RepoDbExample.Core.DataAccess.RepoDb.DbConnectionOptions;
using RepoDbExample.DataAccess.Abstract;
using RepoDbExample.DataAccess.Concrete;
using RepoDbExample.DataAccess.Concrete.DbConnection;
using RepoDbExample.DataAccess.Concrete.DbConnection.MySqlDatabases;
using RepoDbExample.DataAccess.Concrete.DbConnection.PostgreSqLConnectionDatabases;
using RepoDbExample.DataAccess.Concrete.DbConnection.SqlConnectionDatabases;

namespace RepoDbExample.MvcWebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            

            services.AddTransient<IDatabaseConnectionFactory, NorthWindDbConnectionFactory>();
            services.AddTransient<IDatabaseConnectionFactory, AdemBlogDbConnectionFactory>();
            services.AddTransient<IDatabaseConnectionFactory, FinansDbConnectionFactory>();
            services.AddTransient<IDatabaseConnectionFactory, BookStoreDbConnectionFactory>();

            services.AddTransient<ICategoryService, CategoryManager>();
            services.AddTransient<ICategoryDal, CategoryDal>();


            services.AddTransient<ICashboxService, CashboxManager>();
            services.AddTransient<ICashboxDal, CashboxDal>();

            services.AddTransient<ITagService, TagManager>();
            services.AddTransient<ITagDal, TagDal>();

            services.AddTransient<IPostService, PostManager>();
            services.AddTransient<IPostDal, PostDal>();

            services.AddTransient<IBookService, BookManager>();
            services.AddTransient<IBookDal, BookDal>();

            SqlServerBootstrap.Initialize();
            PostgreSqlBootstrap.Initialize();
            MySqlBootstrap.Initialize();
            

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
             

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
       
    }
}
