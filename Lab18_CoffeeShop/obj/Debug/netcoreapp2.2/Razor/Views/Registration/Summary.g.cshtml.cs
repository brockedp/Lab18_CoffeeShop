#pragma checksum "C:\Users\Deno\Documents\Grand Circus\Labs\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Registration\Summary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "062578f83602a5e29b5e795a997b994a46113e01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registration_Summary), @"mvc.1.0.view", @"/Views/Registration/Summary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Registration/Summary.cshtml", typeof(AspNetCore.Views_Registration_Summary))]
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
#line 1 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\_ViewImports.cshtml"
using Lab18_CoffeeShop;

#line default
#line hidden
#line 2 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\_ViewImports.cshtml"
using Lab18_CoffeeShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"062578f83602a5e29b5e795a997b994a46113e01", @"/Views/Registration/Summary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93989b773f77e2913c612ef3051e369fe276073b", @"/Views/_ViewImports.cshtml")]
    public class Views_Registration_Summary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab18_CoffeeShop.Models.RegisterUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Registration\Summary.cshtml"
  
    ViewData["Title"] = "Summary";

#line default
#line hidden
            BeginContext(45, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(96, 14, true);
            WriteLiteral("\r\n<h2>Welcome ");
            EndContext();
            BeginContext(111, 14, false);
#line 10 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Registration\Summary.cshtml"
       Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(125, 5, true);
            WriteLiteral("</h2>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab18_CoffeeShop.Models.RegisterUser> Html { get; private set; }
    }
}
#pragma warning restore 1591