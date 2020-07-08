#pragma checksum "C:\Users\USER\Desktop\nvc\Programming Course\Programming Course\Views\Bill\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93387df006b313ced1b126c4b11a3a0c17ec7ba7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bill_Index), @"mvc.1.0.view", @"/Views/Bill/Index.cshtml")]
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
#line 1 "C:\Users\USER\Desktop\nvc\Programming Course\Programming Course\Views\_ViewImports.cshtml"
using Programming_Course;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Desktop\nvc\Programming Course\Programming Course\Views\_ViewImports.cshtml"
using Programming_Course.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USER\Desktop\nvc\Programming Course\Programming Course\Views\_ViewImports.cshtml"
using Programming_Course.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\USER\Desktop\nvc\Programming Course\Programming Course\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93387df006b313ced1b126c4b11a3a0c17ec7ba7", @"/Views/Bill/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9edcf407e85c4195e950ce211b5f21e3e51dc012", @"/Views/_ViewImports.cshtml")]
    public class Views_Bill_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\USER\Desktop\nvc\Programming Course\Programming Course\Views\Bill\Index.cshtml"
  
    ViewBag.Title = "Employee Management";
    var bills = ViewBag.Bills as IEnumerable<Bill>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .table-hover tbody tr:hover td, .table-hover tbody tr:hover th {
        background-color: #f15a2b;
    }

    a:not([href]):not([tabindex]) {
        color: #f15a2b;
    }
</style>
<h3 class=""text-dark"" data-aos=""fade-up"" data-aos-duration=""3000"">Management &gt; Bill</h3>

<div class=""table-responsive"" data-aos=""fade-up"" data-aos-duration=""3000"">
    <table class=""table table-bordered table-striped table-hover mt-2 text-center  "" style=""width: auto; ""  id=""table"">
        <thead style=""background-color: #282880"">
            <tr class=""text-center text-light"">
                <th>ID</th>
                <th>Customer Name</th>
                <th>Customer Address</th>
                <th>Cusomer PhoneNumber</th>
                <th>Course </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 29 "C:\Users\USER\Desktop\nvc\Programming Course\Programming Course\Views\Bill\Index.cshtml"
             foreach (var bill in bills)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\USER\Desktop\nvc\Programming Course\Programming Course\Views\Bill\Index.cshtml"
                   Write(bill.billId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\USER\Desktop\nvc\Programming Course\Programming Course\Views\Bill\Index.cshtml"
                   Write(bill.customerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\USER\Desktop\nvc\Programming Course\Programming Course\Views\Bill\Index.cshtml"
                   Write(bill.customerAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\USER\Desktop\nvc\Programming Course\Programming Course\Views\Bill\Index.cshtml"
                   Write(bill.customerPhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "C:\Users\USER\Desktop\nvc\Programming Course\Programming Course\Views\Bill\Index.cshtml"
                   Write(bill.couresName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 38 "C:\Users\USER\Desktop\nvc\Programming Course\Programming Course\Views\Bill\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(\'#table\').dataTable({\r\n        }); \r\n            AOS.init();\r\n    </script>\r\n");
            }
            );
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