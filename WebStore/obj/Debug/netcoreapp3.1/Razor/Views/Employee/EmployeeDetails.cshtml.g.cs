#pragma checksum "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Employee\EmployeeDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "246fe4550e8fa0c8c2eebe05f4ba2a9de796f76b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_EmployeeDetails), @"mvc.1.0.view", @"/Views/Employee/EmployeeDetails.cshtml")]
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
#line 1 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\_ViewImports.cshtml"
using WebStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\_ViewImports.cshtml"
using WebStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"246fe4550e8fa0c8c2eebe05f4ba2a9de796f76b", @"/Views/Employee/EmployeeDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b324a6e2d81b81761a4f4ba9d75a1f9d82a53ece", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_EmployeeDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebStore.Models.EmployeeView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Employee\EmployeeDetails.cshtml"
  
    ViewData["Title"] = "EmployeeDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>EmployeeDetails</h1>\n\n<div>\n    <h4>EmployeeView</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\" >\n            ");
#nullable restore
#line 14 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Employee\EmployeeDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 17 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Employee\EmployeeDetails.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 20 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Employee\EmployeeDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 23 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Employee\EmployeeDetails.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 26 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Employee\EmployeeDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.SurName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 29 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Employee\EmployeeDetails.cshtml"
       Write(Html.DisplayFor(model => model.SurName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 32 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Employee\EmployeeDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Patronymic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 35 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Employee\EmployeeDetails.cshtml"
       Write(Html.DisplayFor(model => model.Patronymic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 38 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Employee\EmployeeDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 41 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Employee\EmployeeDetails.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 44 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Employee\EmployeeDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 47 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Employee\EmployeeDetails.cshtml"
       Write(Html.DisplayFor(model => model.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
#nullable restore
#line 52 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Employee\EmployeeDetails.cshtml"
Write(Html.ActionLink("Back to List", "Employees"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebStore.Models.EmployeeView> Html { get; private set; }
    }
}
#pragma warning restore 1591