#pragma checksum "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Home\Employees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c14db4bffe2a5c674eb73beafa86ec46c3dc4d7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Employees), @"mvc.1.0.view", @"/Views/Home/Employees.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c14db4bffe2a5c674eb73beafa86ec46c3dc4d7e", @"/Views/Home/Employees.cshtml")]
    public class Views_Home_Employees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebStore.Models.EmployeeView>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Home\Employees.cshtml"
   ViewData["Title"] = "Employees"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Home\Employees.cshtml"
Write(Html.ActionLink("Список товаров", "PhoneList", "Phone"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 6 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Home\Employees.cshtml"
Write(Html.ActionLink("На главную", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Employees</h1>\n\n<p>\n    <a asp-action=\"Create\">Create New</a>\n</p>\n<table class=\"table\" border=\"1\" cellpadding=\"5\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 16 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Home\Employees.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 19 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Home\Employees.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 22 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Home\Employees.cshtml"
           Write(Html.DisplayNameFor(model => model.SurName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 25 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Home\Employees.cshtml"
           Write(Html.DisplayNameFor(model => model.Patronymic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 28 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Home\Employees.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 31 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Home\Employees.cshtml"
           Write(Html.DisplayNameFor(model => model.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 37 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Home\Employees.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>\n        ");
#nullable restore
#line 41 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Home\Employees.cshtml"
   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 44 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Home\Employees.cshtml"
   Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 47 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Home\Employees.cshtml"
   Write(Html.DisplayFor(modelItem => item.SurName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 50 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Home\Employees.cshtml"
   Write(Html.DisplayFor(modelItem => item.Patronymic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 53 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Home\Employees.cshtml"
   Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 56 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Home\Employees.cshtml"
   Write(Html.DisplayFor(modelItem => item.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 59 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Home\Employees.cshtml"
   Write(Html.ActionLink("Details", "EmployeeDetails", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n</tr>");
#nullable restore
#line 61 "C:\Users\Татьяна\Desktop\ххх\WebStore\WebStore\Views\Home\Employees.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebStore.Models.EmployeeView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
