#pragma checksum "D:\PROJELERIM\SOURCECONTROL\GIT\RepoDbExample\RepoDbExample\RepoDbExample.MvcWebUI\Views\Home\_PostListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53a5a45f2164548daffd87df4e51b3d1fe040d77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__PostListPartial), @"mvc.1.0.view", @"/Views/Home/_PostListPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53a5a45f2164548daffd87df4e51b3d1fe040d77", @"/Views/Home/_PostListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be3192156d491cfb17739250d9e16ba4143161c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__PostListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RepoDbExample.Entites.Models.Sql.AdemBlogDb.ComplexTypes.PostInfoDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""card mb-3"">
    <div class=""card-header"">
        <i class=""fas fa-table""></i>
       Makale Listem
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>Sıra</th>
                        <th>Baslık</th>
                        <th>Kategory</th>
                        <th>Tarih</th>
                        <th>Etiketler</th>
");
            WriteLiteral("                    </tr>\r\n                </thead>\r\n\r\n                <tbody>\r\n");
#nullable restore
#line 27 "D:\PROJELERIM\SOURCECONTROL\GIT\RepoDbExample\RepoDbExample\RepoDbExample.MvcWebUI\Views\Home\_PostListPartial.cshtml"
                       int rowNumber = 0;
                        foreach (var item in Model)
                        {
                            rowNumber += 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 32 "D:\PROJELERIM\SOURCECONTROL\GIT\RepoDbExample\RepoDbExample\RepoDbExample.MvcWebUI\Views\Home\_PostListPartial.cshtml"
                           Write(rowNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 33 "D:\PROJELERIM\SOURCECONTROL\GIT\RepoDbExample\RepoDbExample\RepoDbExample.MvcWebUI\Views\Home\_PostListPartial.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "D:\PROJELERIM\SOURCECONTROL\GIT\RepoDbExample\RepoDbExample\RepoDbExample.MvcWebUI\Views\Home\_PostListPartial.cshtml"
                           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 35 "D:\PROJELERIM\SOURCECONTROL\GIT\RepoDbExample\RepoDbExample\RepoDbExample.MvcWebUI\Views\Home\_PostListPartial.cshtml"
                           Write(item.CreatedDate.ToString("dd-MM-yyyy hh:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 36 "D:\PROJELERIM\SOURCECONTROL\GIT\RepoDbExample\RepoDbExample\RepoDbExample.MvcWebUI\Views\Home\_PostListPartial.cshtml"
                           Write(item.TagNames);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 39 "D:\PROJELERIM\SOURCECONTROL\GIT\RepoDbExample\RepoDbExample\RepoDbExample.MvcWebUI\Views\Home\_PostListPartial.cshtml"
                            }
                     

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RepoDbExample.Entites.Models.Sql.AdemBlogDb.ComplexTypes.PostInfoDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
