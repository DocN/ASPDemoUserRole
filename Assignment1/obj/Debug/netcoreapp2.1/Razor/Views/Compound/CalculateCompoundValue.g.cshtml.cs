#pragma checksum "C:\ASP\A1\Assignment1\Views\Compound\CalculateCompoundValue.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3213811221c7e85db2db9d442ad17dcdaa5c6510"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Compound_CalculateCompoundValue), @"mvc.1.0.view", @"/Views/Compound/CalculateCompoundValue.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Compound/CalculateCompoundValue.cshtml", typeof(AspNetCore.Views_Compound_CalculateCompoundValue))]
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
#line 1 "C:\ASP\A1\Assignment1\Views\_ViewImports.cshtml"
using Assignment1;

#line default
#line hidden
#line 2 "C:\ASP\A1\Assignment1\Views\_ViewImports.cshtml"
using Assignment1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3213811221c7e85db2db9d442ad17dcdaa5c6510", @"/Views/Compound/CalculateCompoundValue.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85f0efab5ddbb0a5c18cf004c4d9e07516f4dd0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Compound_CalculateCompoundValue : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\ASP\A1\Assignment1\Views\Compound\CalculateCompoundValue.cshtml"
  
    ViewData["Title"] = "CalculateCompoundValue";

#line default
#line hidden
            BeginContext(60, 407, true);
            WriteLiteral(@"<div class=""container centerText"">
    <div class=""row"">
        <div class=""col-lg-3""></div>
        <div class=""col-lg-6"">
            <img class=""img-responsive"" src=""https://www.thecalculatorsite.com/images/compound-interest-formula-diagram.png"" />
        </div>
        <div class=""col-lg-3""></div>
    </div>
    <div class=""row"">
        <div class=""col-lg-12"">
            <h1>Principal: ");
            EndContext();
            BeginContext(468, 15, false);
#line 15 "C:\ASP\A1\Assignment1\Views\Compound\CalculateCompoundValue.cshtml"
                      Write(Model.Principal);

#line default
#line hidden
            EndContext();
            BeginContext(483, 113, true);
            WriteLiteral("</h1>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <h1>Rate: ");
            EndContext();
            BeginContext(597, 10, false);
#line 20 "C:\ASP\A1\Assignment1\Views\Compound\CalculateCompoundValue.cshtml"
                 Write(Model.Rate);

#line default
#line hidden
            EndContext();
            BeginContext(607, 115, true);
            WriteLiteral("</h1>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <h1>Number: ");
            EndContext();
            BeginContext(723, 12, false);
#line 25 "C:\ASP\A1\Assignment1\Views\Compound\CalculateCompoundValue.cshtml"
                   Write(Model.Number);

#line default
#line hidden
            EndContext();
            BeginContext(735, 113, true);
            WriteLiteral("</h1>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <h1>Time: ");
            EndContext();
            BeginContext(849, 10, false);
#line 30 "C:\ASP\A1\Assignment1\Views\Compound\CalculateCompoundValue.cshtml"
                 Write(Model.Time);

#line default
#line hidden
            EndContext();
            BeginContext(859, 115, true);
            WriteLiteral("</h1>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <h1>Result: ");
            EndContext();
            BeginContext(975, 12, false);
#line 35 "C:\ASP\A1\Assignment1\Views\Compound\CalculateCompoundValue.cshtml"
                   Write(Model.Result);

#line default
#line hidden
            EndContext();
            BeginContext(987, 47, true);
            WriteLiteral("</h1>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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