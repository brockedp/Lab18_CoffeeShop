#pragma checksum "C:\Users\Deno\Documents\Grand Circus\Labs\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Registration\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a268b62ae59d510b65fc34dfdfddcc4d6add6c1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registration_Index), @"mvc.1.0.view", @"/Views/Registration/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Registration/Index.cshtml", typeof(AspNetCore.Views_Registration_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a268b62ae59d510b65fc34dfdfddcc4d6add6c1b", @"/Views/Registration/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93989b773f77e2913c612ef3051e369fe276073b", @"/Views/_ViewImports.cshtml")]
    public class Views_Registration_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab18_CoffeeShop.Models.RegisterUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Registration\Index.cshtml"
  
    ViewData["Title"] = "Registration";

#line default
#line hidden
            BeginContext(50, 27, true);
            WriteLiteral("\r\n<h1>Registration</h1>\r\n\r\n");
            EndContext();
            BeginContext(122, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Registration\Index.cshtml"
 using (var form = Html.BeginForm())
{

#line default
#line hidden
            BeginContext(165, 19, true);
            WriteLiteral("    <div>\r\n        ");
            EndContext();
            BeginContext(185, 40, false);
#line 13 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Registration\Index.cshtml"
   Write(Html.LabelFor(coffee => coffee.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(225, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(236, 42, false);
#line 14 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Registration\Index.cshtml"
   Write(Html.TextBoxFor(coffee => coffee.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(278, 33, true);
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(312, 37, false);
#line 17 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Registration\Index.cshtml"
   Write(Html.LabelFor(coffee => coffee.Email));

#line default
#line hidden
            EndContext();
            BeginContext(349, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(360, 39, false);
#line 18 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Registration\Index.cshtml"
   Write(Html.TextBoxFor(coffee => coffee.Email));

#line default
#line hidden
            EndContext();
            BeginContext(399, 33, true);
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(433, 40, false);
#line 21 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Registration\Index.cshtml"
   Write(Html.LabelFor(coffee => coffee.Password));

#line default
#line hidden
            EndContext();
            BeginContext(473, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(484, 42, false);
#line 22 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Registration\Index.cshtml"
   Write(Html.TextBoxFor(coffee => coffee.Password));

#line default
#line hidden
            EndContext();
            BeginContext(526, 58, true);
            WriteLiteral("\r\n    </div>\r\n    <input type=\"submit\" value=\"Submit\" />\r\n");
            EndContext();
#line 25 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Registration\Index.cshtml"


}

#line default
#line hidden
            BeginContext(591, 4, true);
            WriteLiteral("\r\n\r\n");
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
