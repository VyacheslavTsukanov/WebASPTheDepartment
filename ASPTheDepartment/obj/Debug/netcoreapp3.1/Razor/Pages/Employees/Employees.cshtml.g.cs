#pragma checksum "C:\Users\vtsuk\OneDrive\Рабочий стол\Proj - C#\WebASPTheDepartment\ASPTheDepartment\Pages\Employees\Employees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e69ec3712b7c708bbbb79abdfa8b45eccc28f5b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ASPTheDepartment.Pages.Employees.Pages_Employees_Employees), @"mvc.1.0.razor-page", @"/Pages/Employees/Employees.cshtml")]
namespace ASPTheDepartment.Pages.Employees
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
#line 1 "C:\Users\vtsuk\OneDrive\Рабочий стол\Proj - C#\WebASPTheDepartment\ASPTheDepartment\Pages\_ViewImports.cshtml"
using ASPTheDepartment;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e69ec3712b7c708bbbb79abdfa8b45eccc28f5b6", @"/Pages/Employees/Employees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d96ab7e8810a430e1b13a679066c7b30244525a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Employees_Employees : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\vtsuk\OneDrive\Рабочий стол\Proj - C#\WebASPTheDepartment\ASPTheDepartment\Pages\Employees\Employees.cshtml"
  
    ViewData["Title"] = "Employees";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Employees</h2>\r\n\r\n<h3>");
#nullable restore
#line 9 "C:\Users\vtsuk\OneDrive\Рабочий стол\Proj - C#\WebASPTheDepartment\ASPTheDepartment\Pages\Employees\Employees.cshtml"
Write(Model.Employees.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASPTheDepartment.Pages.Employees.EmployeesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ASPTheDepartment.Pages.Employees.EmployeesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ASPTheDepartment.Pages.Employees.EmployeesModel>)PageContext?.ViewData;
        public ASPTheDepartment.Pages.Employees.EmployeesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
