#pragma checksum "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Phone\PhoneDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c077e646e96e38e118f104ac61af031d36faccb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Phone_PhoneDetails), @"mvc.1.0.view", @"/Views/Phone/PhoneDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c077e646e96e38e118f104ac61af031d36faccb0", @"/Views/Phone/PhoneDetails.cshtml")]
    public class Views_Phone_PhoneDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebStore.Models.PhoneView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Phone\PhoneDetails.cshtml"
  
    ViewData["Title"] = "PhoneDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>PhoneDetails</h1>\n\n<div>\n    <h4>PhoneView</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 14 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Phone\PhoneDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 17 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Phone\PhoneDetails.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 20 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Phone\PhoneDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Manufacturer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 23 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Phone\PhoneDetails.cshtml"
       Write(Html.DisplayFor(model => model.Manufacturer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 26 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Phone\PhoneDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 29 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Phone\PhoneDetails.cshtml"
       Write(Html.DisplayFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 32 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Phone\PhoneDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 35 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Phone\PhoneDetails.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
#nullable restore
#line 40 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Phone\PhoneDetails.cshtml"
Write(Html.ActionLink("Back to List", "PhoneList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebStore.Models.PhoneView> Html { get; private set; }
    }
}
#pragma warning restore 1591
