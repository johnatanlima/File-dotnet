#pragma checksum "C:\Users\johw2\Desktop\Workspace .NET Core\File-dotnet\Projeto-File\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d1ae52ade442b0bf8986e5924d0709d4eeb28b4"
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
#line 1 "C:\Users\johw2\Desktop\Workspace .NET Core\File-dotnet\Projeto-File\Views\_ViewImports.cshtml"
using Projeto_File;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\johw2\Desktop\Workspace .NET Core\File-dotnet\Projeto-File\Views\_ViewImports.cshtml"
using Projeto_File.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d1ae52ade442b0bf8986e5924d0709d4eeb28b4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d062041080c139022b8061ae4358aa6a952ea44c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Projeto_File.Models.Hospital>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\johw2\Desktop\Workspace .NET Core\File-dotnet\Projeto-File\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h3");
            BeginWriteAttribute("class", " class=\"", 332, "\"", 340, 0);
            EndWriteAttribute();
            WriteLiteral("> Última Imagem adicionada </h3>\r\n   \r\n");
            WriteLiteral("             <img width=\"300\" height=\"300\" class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 457, "\"", 512, 1);
#nullable restore
#line 17 "C:\Users\johw2\Desktop\Workspace .NET Core\File-dotnet\Projeto-File\Views\Home\Index.cshtml"
WriteAttributeValue("", 463, Url.Action("BuscarHospital", "Hospitais", Model), 463, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />  \r\n");
            WriteLiteral("        </div>\r\n    <div class=\"col-2\"> conteudo </div>\r\n   <aside class=\"col-lg-6 collgfloat-md-right border-dark\">\r\n       \r\n   </aside>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projeto_File.Models.Hospital> Html { get; private set; }
    }
}
#pragma warning restore 1591
