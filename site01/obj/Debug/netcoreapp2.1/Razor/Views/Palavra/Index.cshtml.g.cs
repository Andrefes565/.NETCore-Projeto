#pragma checksum "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d72c2e12ea9e3b663bf78c14ec1de08dda7fdf5"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d72c2e12ea9e3b663bf78c14ec1de08dda7fdf5", @"/Views/Palavra/Index.cshtml")]
    public class Views_Palavra_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<site01.Models.Palavra>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(63, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(92, 320, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edf87d2260774c7b9c405e17db64b3b6", async() => {
                BeginContext(98, 307, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Listagem</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"" integrity=""sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk"" crossorigin=""anonymous"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(412, 7, true);
            WriteLiteral("\r\n   \r\n");
            EndContext();
            BeginContext(419, 1156, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e5b6b29e4744a3491d9ade9c7d3df65", async() => {
                BeginContext(425, 149, true);
                WriteLiteral("\r\n\r\n    \r\n    <div class=\"container\">\r\n        <a href=\"/Palavra/Cadastrar\" class=\"btn btn-primary\">Cadastrar</a>\r\n        <span>Total de Registros: ");
                EndContext();
                BeginContext(575, 11, false);
#line 20 "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml"
                             Write(Model.Count);

#line default
#line hidden
                EndContext();
                BeginContext(586, 357, true);
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
#line 31 "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml"
                 foreach (var palavra in Model)
                {

#line default
#line hidden
                BeginContext(1011, 66, true);
                WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
                EndContext();
                BeginContext(1078, 10, false);
#line 34 "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml"
                                   Write(palavra.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1088, 35, true);
                WriteLiteral("</th>\r\n                        <td>");
                EndContext();
                BeginContext(1124, 12, false);
#line 35 "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml"
                       Write(palavra.Nome);

#line default
#line hidden
                EndContext();
                BeginContext(1136, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1172, 13, false);
#line 36 "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml"
                       Write(palavra.Nivel);

#line default
#line hidden
                EndContext();
                BeginContext(1185, 67, true);
                WriteLiteral("</td>\r\n                        <td>\r\n                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1252, "\"", 1289, 2);
                WriteAttributeValue("", 1259, "/Palavra/Atualizar/", 1259, 19, true);
#line 38 "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml"
WriteAttributeValue("", 1278, palavra.Id, 1278, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1290, 69, true);
                WriteLiteral(" class=\"btn btn-secondary\">Editar</a>\r\n                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1359, "\"", 1394, 2);
                WriteAttributeValue("", 1366, "/Palavra/Excluir/", 1366, 17, true);
#line 39 "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml"
WriteAttributeValue("", 1383, palavra.Id, 1383, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1395, 98, true);
                WriteLiteral(" class=\"btn btn-secondary\">Excluir</a>\r\n                        </td>\r\n                    </tr>\r\n");
                EndContext();
#line 42 "C:\Users\andre\source\repos\site01\site01\Views\Palavra\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(1512, 56, true);
                WriteLiteral("\r\n\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1575, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<site01.Models.Palavra>> Html { get; private set; }
    }
}
#pragma warning restore 1591
