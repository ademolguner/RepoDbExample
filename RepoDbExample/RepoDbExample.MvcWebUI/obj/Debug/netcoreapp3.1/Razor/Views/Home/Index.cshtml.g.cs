#pragma checksum "D:\PROJELERIM\SOURCECONTROL\GIT\RepoDbExample\RepoDbExample\RepoDbExample.MvcWebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43d4e57943468372cd5551891c65e20d990d09e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\PROJELERIM\SOURCECONTROL\GIT\RepoDbExample\RepoDbExample\RepoDbExample.MvcWebUI\Views\_ViewImports.cshtml"
using RepoDbExample.MvcWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROJELERIM\SOURCECONTROL\GIT\RepoDbExample\RepoDbExample\RepoDbExample.MvcWebUI\Views\_ViewImports.cshtml"
using RepoDbExample.MvcWebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d4e57943468372cd5551891c65e20d990d09e5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92d802900f643f466f92a58f4856964e12d33758", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RepoDbExample.MvcWebUI.ViewModels.HomeIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\PROJELERIM\SOURCECONTROL\GIT\RepoDbExample\RepoDbExample\RepoDbExample.MvcWebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Dashboard Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Icon Cards-->\r\n<div class=\"row\">\r\n");
#nullable restore
#line 7 "D:\PROJELERIM\SOURCECONTROL\GIT\RepoDbExample\RepoDbExample\RepoDbExample.MvcWebUI\Views\Home\Index.cshtml"
      
        await Html.RenderPartialAsync("_FinansPartial", Model.Cashboxes);
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>



<!-- DataTables Example -->
<div class=""card mb-3"">
    <div class=""card-header"">
        <i class=""fas fa-table""></i>
        Data Table Example
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Position</th>
                        <th>Office</th>
                        <th>Age</th>
                        <th>Start date</th>
                        <th>Salary</th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>Name</th>
                        <th>Position</th>
                        <th>Office</th>
                        <th>Age</th>
                        <th>Start date</th>
                        <th>Salary</th>
                    </tr>
        ");
            WriteLiteral(@"        </tfoot>
                <tbody>
                    <tr>
                        <td>Tiger Nixon</td>
                        <td>System Architect</td>
                        <td>Edinburgh</td>
                        <td>61</td>
                        <td>2011/04/25</td>
                        <td>$320,800</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
    <div class=""card-footer small text-muted"">Updated yesterday at 11:59 PM</div>
</div>

<div class=""row"">
");
#nullable restore
#line 60 "D:\PROJELERIM\SOURCECONTROL\GIT\RepoDbExample\RepoDbExample\RepoDbExample.MvcWebUI\Views\Home\Index.cshtml"
      
        await Html.RenderPartialAsync("_BookPartial", Model.BookList);
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RepoDbExample.MvcWebUI.ViewModels.HomeIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
