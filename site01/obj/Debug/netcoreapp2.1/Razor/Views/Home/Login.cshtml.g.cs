#pragma checksum "C:\Users\andre\source\repos\site01\site01\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "921c91d8176253c326c40da9e0dd36f899bc1422"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Login.cshtml", typeof(AspNetCore.Views_Home_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"921c91d8176253c326c40da9e0dd36f899bc1422", @"/Views/Home/Login.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\andre\source\repos\site01\site01\Views\Home\Login.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 4 "C:\Users\andre\source\repos\site01\site01\Views\Home\Login.cshtml"
  
    ViewBag.Title = "Login";

#line default
#line hidden
            BeginContext(91, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\andre\source\repos\site01\site01\Views\Home\Login.cshtml"
 if (TempData["MensagemErro"] != null)
{

#line default
#line hidden
            BeginContext(136, 58, true);
            WriteLiteral("    <div class=\"alert alert-error\" role=\"alert\">\r\n        ");
            EndContext();
            BeginContext(195, 24, false);
#line 11 "C:\Users\andre\source\repos\site01\site01\Views\Home\Login.cshtml"
   Write(TempData["MensagemErro"]);

#line default
#line hidden
            EndContext();
            BeginContext(219, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 13 "C:\Users\andre\source\repos\site01\site01\Views\Home\Login.cshtml"
}

#line default
#line hidden
            BeginContext(236, 238, true);
            WriteLiteral("\r\n<form method=\"post\" action=\"/Home/Login\">\r\n    <div class=\"form-group\">\r\n        <label for=\"email\">Email</label>\r\n        <input type=\"text\" name=\"email\" value=\"\" class=\"form-control\" id=\"nome\" placeholder=\"Digite seu email\">\r\n        ");
            EndContext();
            BeginContext(475, 31, false);
#line 19 "C:\Users\andre\source\repos\site01\site01\Views\Home\Login.cshtml"
   Write(Html.ValidationMessage("email"));

#line default
#line hidden
            EndContext();
            BeginContext(506, 211, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"nome\">Senha</label>\r\n        <input type=\"password\" name=\"senha\" value=\"\" class=\"form-control\" id=\"senha\" placeholder=\"Digite sua senha\">\r\n        ");
            EndContext();
            BeginContext(718, 31, false);
#line 24 "C:\Users\andre\source\repos\site01\site01\Views\Home\Login.cshtml"
   Write(Html.ValidationMessage("senha"));

#line default
#line hidden
            EndContext();
            BeginContext(749, 92, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    <button type=\"submit\" class=\"btn btn-primary\">Enviar</button>\r\n</form>\r\n");
            EndContext();
            BeginContext(842, 16, false);
#line 29 "C:\Users\andre\source\repos\site01\site01\Views\Home\Login.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(858, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
