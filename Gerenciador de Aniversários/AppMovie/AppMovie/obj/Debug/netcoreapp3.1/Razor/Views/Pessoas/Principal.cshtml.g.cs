#pragma checksum "C:\Users\T-Gamer\Desktop\Engenharia de Software\Programas C#\AppMovie\AppMovie\Views\Pessoas\Principal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9e38e7bae01fc372f5881d33ec06cc20957437a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoas_Principal), @"mvc.1.0.view", @"/Views/Pessoas/Principal.cshtml")]
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
#line 1 "C:\Users\T-Gamer\Desktop\Engenharia de Software\Programas C#\AppMovie\AppMovie\Views\_ViewImports.cshtml"
using AppMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\T-Gamer\Desktop\Engenharia de Software\Programas C#\AppMovie\AppMovie\Views\_ViewImports.cshtml"
using AppMovie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9e38e7bae01fc372f5881d33ec06cc20957437a", @"/Views/Pessoas/Principal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99149aa7e762728752275ee51ee7d997661d9f2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Pessoas_Principal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppMovie.Models.Pessoa>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\T-Gamer\Desktop\Engenharia de Software\Programas C#\AppMovie\AppMovie\Views\Pessoas\Principal.cshtml"
  
    ViewData["Title"] = "Principal";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Principal</h1>\r\n\r\n<h4>Aniversariantes do dia!</h4>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\T-Gamer\Desktop\Engenharia de Software\Programas C#\AppMovie\AppMovie\Views\Pessoas\Principal.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\T-Gamer\Desktop\Engenharia de Software\Programas C#\AppMovie\AppMovie\Views\Pessoas\Principal.cshtml"
           Write(Html.DisplayNameFor(model => model.Sobrenome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\T-Gamer\Desktop\Engenharia de Software\Programas C#\AppMovie\AppMovie\Views\Pessoas\Principal.cshtml"
           Write(Html.DisplayNameFor(model => model.Nascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 26 "C:\Users\T-Gamer\Desktop\Engenharia de Software\Programas C#\AppMovie\AppMovie\Views\Pessoas\Principal.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\T-Gamer\Desktop\Engenharia de Software\Programas C#\AppMovie\AppMovie\Views\Pessoas\Principal.cshtml"
             if (item.Nascimento.Day == DateTime.Today.Day && item.Nascimento.Month == DateTime.Today.Month)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 32 "C:\Users\T-Gamer\Desktop\Engenharia de Software\Programas C#\AppMovie\AppMovie\Views\Pessoas\Principal.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 35 "C:\Users\T-Gamer\Desktop\Engenharia de Software\Programas C#\AppMovie\AppMovie\Views\Pessoas\Principal.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Sobrenome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 38 "C:\Users\T-Gamer\Desktop\Engenharia de Software\Programas C#\AppMovie\AppMovie\Views\Pessoas\Principal.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 41 "C:\Users\T-Gamer\Desktop\Engenharia de Software\Programas C#\AppMovie\AppMovie\Views\Pessoas\Principal.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\T-Gamer\Desktop\Engenharia de Software\Programas C#\AppMovie\AppMovie\Views\Pessoas\Principal.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<h4>Próximos aniversários!</h4>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 51 "C:\Users\T-Gamer\Desktop\Engenharia de Software\Programas C#\AppMovie\AppMovie\Views\Pessoas\Principal.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 54 "C:\Users\T-Gamer\Desktop\Engenharia de Software\Programas C#\AppMovie\AppMovie\Views\Pessoas\Principal.cshtml"
           Write(Html.DisplayNameFor(model => model.Sobrenome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 57 "C:\Users\T-Gamer\Desktop\Engenharia de Software\Programas C#\AppMovie\AppMovie\Views\Pessoas\Principal.cshtml"
           Write(Html.DisplayNameFor(model => model.Nascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 63 "C:\Users\T-Gamer\Desktop\Engenharia de Software\Programas C#\AppMovie\AppMovie\Views\Pessoas\Principal.cshtml"
         foreach (var item in Model.OrderBy(p => p.DiasParaNiver(p.Nascimento)))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\T-Gamer\Desktop\Engenharia de Software\Programas C#\AppMovie\AppMovie\Views\Pessoas\Principal.cshtml"
             if (item.DiasParaNiver(item.Nascimento) != 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 69 "C:\Users\T-Gamer\Desktop\Engenharia de Software\Programas C#\AppMovie\AppMovie\Views\Pessoas\Principal.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 72 "C:\Users\T-Gamer\Desktop\Engenharia de Software\Programas C#\AppMovie\AppMovie\Views\Pessoas\Principal.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Sobrenome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 75 "C:\Users\T-Gamer\Desktop\Engenharia de Software\Programas C#\AppMovie\AppMovie\Views\Pessoas\Principal.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 78 "C:\Users\T-Gamer\Desktop\Engenharia de Software\Programas C#\AppMovie\AppMovie\Views\Pessoas\Principal.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\T-Gamer\Desktop\Engenharia de Software\Programas C#\AppMovie\AppMovie\Views\Pessoas\Principal.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppMovie.Models.Pessoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
