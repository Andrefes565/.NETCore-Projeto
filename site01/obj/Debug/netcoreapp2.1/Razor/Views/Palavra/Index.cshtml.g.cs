#pragma checksum "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e76be7b2475d9176144c3d5835213b23f32cd921"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Palavra_Index), @"mvc.1.0.view", @"/Views/Palavra/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Palavra/Index.cshtml", typeof(AspNetCore.Views_Palavra_Index))]
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
#line 2 "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#line 3 "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e76be7b2475d9176144c3d5835213b23f32cd921", @"/Views/Palavra/Index.cshtml")]
    public class Views_Palavra_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<site01.Models.Palavra>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(105, 77, true);
            WriteLiteral("\r\n    <link href=\"/css/PagedList.css\" rel=\"stylesheet\" type=\"text/css\" />\r\n\r\n");
            EndContext();
#line 7 "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 10 "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml"
  
    ViewBag.Title = "Palavra - Listagem";

#line default
#line hidden
            BeginContext(286, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 16 "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml"
 if (TempData["Mensagem"] != null)
{

#line default
#line hidden
            BeginContext(331, 60, true);
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
            EndContext();
            BeginContext(392, 20, false);
#line 19 "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(412, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 21 "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml"
}

#line default
#line hidden
            BeginContext(429, 96, true);
            WriteLiteral("\r\n<a href=\"/Palavra/Cadastrar\" class=\"btn btn-primary\">Cadastrar</a>\r\n<span>Total de Registros: ");
            EndContext();
            BeginContext(526, 20, false);
#line 24 "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml"
                     Write(Model.TotalItemCount);

#line default
#line hidden
            EndContext();
            BeginContext(546, 277, true);
            WriteLiteral(@"</span>
<table class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Palavra</th>
            <th scope=""col"">Nível</th>
            <th scope=""col"">Ação</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 35 "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml"
         foreach (var palavra in Model)
        {

#line default
#line hidden
            BeginContext(875, 50, true);
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
            EndContext();
            BeginContext(926, 10, false);
#line 38 "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml"
                           Write(palavra.Id);

#line default
#line hidden
            EndContext();
            BeginContext(936, 27, true);
            WriteLiteral("</th>\r\n                <td>");
            EndContext();
            BeginContext(964, 12, false);
#line 39 "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml"
               Write(palavra.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(976, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1004, 13, false);
#line 40 "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml"
               Write(palavra.Nivel);

#line default
#line hidden
            EndContext();
            BeginContext(1017, 51, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1068, "\"", 1105, 2);
            WriteAttributeValue("", 1075, "/Palavra/Atualizar/", 1075, 19, true);
#line 42 "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml"
WriteAttributeValue("", 1094, palavra.Id, 1094, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1106, 61, true);
            WriteLiteral(" class=\"btn btn-secondary\">Editar</a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1167, "\"", 1202, 2);
            WriteAttributeValue("", 1174, "/Palavra/Excluir/", 1174, 17, true);
#line 43 "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml"
WriteAttributeValue("", 1191, palavra.Id, 1191, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1203, 82, true);
            WriteLiteral(" class=\"btn btn-secondary\">Excluir</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 46 "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1296, 30, true);
            WriteLiteral("\r\n\r\n    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(1327, 81, false);
#line 52 "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
            EndContext();
            BeginContext(1408, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<site01.Models.Palavra>> Html { get; private set; }
    }
}
#pragma warning restore 1591