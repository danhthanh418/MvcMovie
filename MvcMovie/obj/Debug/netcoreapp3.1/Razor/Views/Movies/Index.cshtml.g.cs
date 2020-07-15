#pragma checksum "D:\Project\MvcMovie\MvcMovie\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "696ff6004c89d645b525acb64636300843f2cd0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"696ff6004c89d645b525acb64636300843f2cd0a", @"/Views/Movies/Index.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcMovie.Models.MovieGenreViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Project\MvcMovie\MvcMovie\Views\Movies\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Movies index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n\r\n<form asp-controller=\"Movies\" asp-action=\"Index\" method=\"get\">\r\n    <p>\r\n        <select asp-for=\"MovieGenre\" asp-items=\"Model.Genres\">\r\n            <option");
            BeginWriteAttribute("value", " value=\"", 326, "\"", 334, 0);
            EndWriteAttribute();
            WriteLiteral(">All</option>\r\n        </select>\r\n        Title: <input type=\"text\" name=\"SearchString\">\r\n        <input type=\"submit\" value=\"Filter\" />\r\n    </p>\r\n</form>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "D:\Project\MvcMovie\MvcMovie\Views\Movies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Movies[0].Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "D:\Project\MvcMovie\MvcMovie\Views\Movies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Movies[0].ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "D:\Project\MvcMovie\MvcMovie\Views\Movies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Movies[0].Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "D:\Project\MvcMovie\MvcMovie\Views\Movies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Movies[0].Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 41 "D:\Project\MvcMovie\MvcMovie\Views\Movies\Index.cshtml"
         foreach (var item in Model.Movies)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "D:\Project\MvcMovie\MvcMovie\Views\Movies\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "D:\Project\MvcMovie\MvcMovie\Views\Movies\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "D:\Project\MvcMovie\MvcMovie\Views\Movies\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "D:\Project\MvcMovie\MvcMovie\Views\Movies\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1597, "\"", 1625, 2);
            WriteAttributeValue("", 1604, "/Movies/Edit/", 1604, 13, true);
#nullable restore
#line 57 "D:\Project\MvcMovie\MvcMovie\Views\Movies\Index.cshtml"
WriteAttributeValue("", 1617, item.Id, 1617, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1644, "\"", 1667, 1);
#nullable restore
#line 57 "D:\Project\MvcMovie\MvcMovie\Views\Movies\Index.cshtml"
WriteAttributeValue("", 1659, item.Id, 1659, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1703, "\"", 1734, 2);
            WriteAttributeValue("", 1710, "/Movies/Details/", 1710, 16, true);
#nullable restore
#line 58 "D:\Project\MvcMovie\MvcMovie\Views\Movies\Index.cshtml"
WriteAttributeValue("", 1726, item.Id, 1726, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1756, "\"", 1779, 1);
#nullable restore
#line 58 "D:\Project\MvcMovie\MvcMovie\Views\Movies\Index.cshtml"
WriteAttributeValue("", 1771, item.Id, 1771, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1818, "\"", 1848, 2);
            WriteAttributeValue("", 1825, "/Movies/Delete/", 1825, 15, true);
#nullable restore
#line 59 "D:\Project\MvcMovie\MvcMovie\Views\Movies\Index.cshtml"
WriteAttributeValue("", 1840, item.Id, 1840, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1869, "\"", 1892, 1);
#nullable restore
#line 59 "D:\Project\MvcMovie\MvcMovie\Views\Movies\Index.cshtml"
WriteAttributeValue("", 1884, item.Id, 1884, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 62 "D:\Project\MvcMovie\MvcMovie\Views\Movies\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcMovie.Models.MovieGenreViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
