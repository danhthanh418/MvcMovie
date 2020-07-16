#pragma checksum "D:\Projects\MvcMovie\MvcMovie\Views\Movies\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24145185f08cadeb5f9e32f7b016b638be47e750"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Create), @"mvc.1.0.view", @"/Views/Movies/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24145185f08cadeb5f9e32f7b016b638be47e750", @"/Views/Movies/Create.cshtml")]
    public class Views_Movies_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcMovie.Models.Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects\MvcMovie\MvcMovie\Views\Movies\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Movie</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"" method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Title"" class=""control-label"">");
#nullable restore
#line 16 "D:\Projects\MvcMovie\MvcMovie\Views\Movies\Create.cshtml"
                                                        Write(Html.DisplayNameFor(modelItem => Model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                <input asp-for=""Title"" class=""form-control"" />
                <span asp-validation-for=""Title"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ReleaseDate"" class=""control-label"">");
#nullable restore
#line 21 "D:\Projects\MvcMovie\MvcMovie\Views\Movies\Create.cshtml"
                                                              Write(Html.DisplayNameFor(modelItem => Model.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                <input asp-for=""ReleaseDate"" class=""form-control"" />
                <span asp-validation-for=""ReleaseDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Genre"" class=""control-label"">");
#nullable restore
#line 26 "D:\Projects\MvcMovie\MvcMovie\Views\Movies\Create.cshtml"
                                                        Write(Html.DisplayNameFor(modelItem => Model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                <input asp-for=""Genre"" class=""form-control"" />
                <span asp-validation-for=""Genre"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Price"" class=""control-label"">");
#nullable restore
#line 31 "D:\Projects\MvcMovie\MvcMovie\Views\Movies\Create.cshtml"
                                                        Write(Html.DisplayNameFor(modelItem => Model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                <input asp-for=""Price"" class=""form-control"" />
                <span asp-validation-for=""Price"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 47 "D:\Projects\MvcMovie\MvcMovie\Views\Movies\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcMovie.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
