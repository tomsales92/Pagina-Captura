#pragma checksum "C:\Users\esales\Documents\studio-pinxesa\Views\Home\Painel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce49ac8103d2f50ba1772a582e89bf44037b0c33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Painel), @"mvc.1.0.view", @"/Views/Home/Painel.cshtml")]
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
#line 1 "C:\Users\esales\Documents\studio-pinxesa\Views\_ViewImports.cshtml"
using Pagina_Captura;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esales\Documents\studio-pinxesa\Views\_ViewImports.cshtml"
using Pagina_Captura.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce49ac8103d2f50ba1772a582e89bf44037b0c33", @"/Views/Home/Painel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dd3ec5edb712585c36be0db1902ca14407c51c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Painel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pagina_Captura.Models.Aluno>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\esales\Documents\studio-pinxesa\Views\Home\Painel.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <style>

    * {
        margin: 0;
        padding: 0;
        box-sizing: border-box;
        outline: 0;
    }

    body {
        background: #797877;
        font-family: 'Roboto', sans-serif;
        font-size: 50px;
    }

    header {
        display: flex;
        flex-direction: column;
        align-items: center;
        justify-content: center;
    }

    h1 {
        padding-top: 20px;
        text-transform: uppercase;
        color: #d7b3b5;
        font-size: 100px;
        font-weight: 600;
        margin: 15px 0 15px 0;
    }

    header span {
        font-size: 60px;
        color: #d7b3b5;
    }

    .contato {
        display: flex;
        flex-direction:column;
        justify-content: center;

        margin: 10px;
        border: 3px solid #d7b3b5;
        border-radius: 15px;
        color: #fff;
        padding: 20px;

    }
    </style>

<div class=""container"">
    <header>
        <h1>Cadastros</h1>
        <span>Total d");
            WriteLiteral("e Inscrições: ");
#nullable restore
#line 60 "C:\Users\esales\Documents\studio-pinxesa\Views\Home\Painel.cshtml"
                              Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n    </header>\r\n\r\n");
#nullable restore
#line 64 "C:\Users\esales\Documents\studio-pinxesa\Views\Home\Painel.cshtml"
     foreach(var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"contato\">\r\n            <strong>");
#nullable restore
#line 68 "C:\Users\esales\Documents\studio-pinxesa\Views\Home\Painel.cshtml"
               Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            <br />\r\n            <span>Celular: ");
#nullable restore
#line 70 "C:\Users\esales\Documents\studio-pinxesa\Views\Home\Painel.cshtml"
                      Write(item.Celular);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <br />\r\n            <span>");
#nullable restore
#line 72 "C:\Users\esales\Documents\studio-pinxesa\Views\Home\Painel.cshtml"
             Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n");
#nullable restore
#line 74 "C:\Users\esales\Documents\studio-pinxesa\Views\Home\Painel.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pagina_Captura.Models.Aluno>> Html { get; private set; }
    }
}
#pragma warning restore 1591
