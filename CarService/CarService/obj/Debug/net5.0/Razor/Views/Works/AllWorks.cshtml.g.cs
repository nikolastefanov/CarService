#pragma checksum "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1118a2bf24263d68c3e9e99b46caa4c75b1ca72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Works_AllWorks), @"mvc.1.0.view", @"/Views/Works/AllWorks.cshtml")]
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
#line 1 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\_ViewImports.cshtml"
using CarService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\_ViewImports.cshtml"
using CarService.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\_ViewImports.cshtml"
using CarService.Models.IssueTypes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Reviews;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Issues;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Cars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Mechanics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Works;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Orders;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1118a2bf24263d68c3e9e99b46caa4c75b1ca72", @"/Views/Works/AllWorks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c683fb7eb1648abea98e30a6ff6e453845fc32e", @"/Views/_ViewImports.cshtml")]
    public class Views_Works_AllWorks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListingWorkViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
  
    this.ViewData["Title"] = "AllWorks";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container-fluid text-center\">\r\n\r\n    <h1>");
#nullable restore
#line 10 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
   Write(this.ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

</div>



<div class=""container"">
    <div class=""section"">
        <div class=""row"">
            <div class=""col-md-10 offset-md-1"">
                <div class=""page-header text-center"">
                    <h2 id=""tables"">Listed works for: </h2>
                    <h2 class=""font-weight-bold font-italic"">Car: ");
#nullable restore
#line 22 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
                                                             Write(Model.CarId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Issue:");
#nullable restore
#line 22 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
                                                                                Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Description: ");
#nullable restore
#line 22 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
                                                                                                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n\r\n                <div class=\"d-flex justify-content-center\">\r\n                    <a class=\"btn btn-block btn-primary text-white mb-3\"");
            BeginWriteAttribute("href", " href=\"", 719, "\"", 778, 4);
            WriteAttributeValue("", 726, "/Works/AddWorks?issueId=", 726, 24, true);
#nullable restore
#line 26 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
WriteAttributeValue("", 750, Model.Id, 750, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 759, "&carId=", 759, 7, true);
#nullable restore
#line 26 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
WriteAttributeValue("", 766, Model.CarId, 766, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Add a new Work</a>
                </div>

                <div class=""component"">
                    <table class=""table table-hover"">
                        <thead class="" table-active"">
                            <tr>
                                <th scope=""col"">Description</th>
                                <th scope=""col"">Price</th>
                                <th scope=""col"" class=""text-center"">Add to Order</th>
                                <th scope=""col"" class=""text-center"">Edit Work</th>
                                <th scope=""col"" class=""text-center"">Delete Work</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 41 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
                             foreach (var work in Model.Works)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr class=\"table-light\">\r\n                                <td>");
#nullable restore
#line 45 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
                               Write(work.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <span class=\"card-title\"> ");
#nullable restore
#line 47 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
                                                         Write(work.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </td>\r\n\r\n                                <td>\r\n                                    <a class=\"btn btn-block btn-primary text-white mb-3\"");
            BeginWriteAttribute("href", " href=\"", 1994, "\"", 2076, 6);
            WriteAttributeValue("", 2001, "/Orders/AddToOrder?workId=", 2001, 26, true);
#nullable restore
#line 51 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
WriteAttributeValue("", 2027, work.Id, 2027, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2035, "&issueId=", 2035, 9, true);
#nullable restore
#line 51 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
WriteAttributeValue("", 2044, work.IssueId, 2044, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2057, "&carId=", 2057, 7, true);
#nullable restore
#line 51 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
WriteAttributeValue("", 2064, Model.CarId, 2064, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Add to Order</a>\r\n                                </td>\r\n                                <td>\r\n                                    <a class=\"btn btn-block btn-warning text-white mb-3\"");
            BeginWriteAttribute("href", " href=\"", 2261, "\"", 2341, 6);
            WriteAttributeValue("", 2268, "/Works/EditWorks?workId=", 2268, 24, true);
#nullable restore
#line 54 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
WriteAttributeValue("", 2292, work.Id, 2292, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2300, "&issueId=", 2300, 9, true);
#nullable restore
#line 54 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
WriteAttributeValue("", 2309, work.IssueId, 2309, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2322, "&carId=", 2322, 7, true);
#nullable restore
#line 54 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
WriteAttributeValue("", 2329, Model.CarId, 2329, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit Work</a>\r\n                                </td>\r\n                                <td>\r\n                                    <a class=\"btn btn-block btn-danger text-white mb-3\"");
            BeginWriteAttribute("href", " href=\"", 2522, "\"", 2604, 6);
            WriteAttributeValue("", 2529, "/Works/DeleteWorks?workId=", 2529, 26, true);
#nullable restore
#line 57 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
WriteAttributeValue("", 2555, work.Id, 2555, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2563, "&issueId=", 2563, 9, true);
#nullable restore
#line 57 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
WriteAttributeValue("", 2572, work.IssueId, 2572, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2585, "&carId=", 2585, 7, true);
#nullable restore
#line 57 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
WriteAttributeValue("", 2592, Model.CarId, 2592, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete Work</a>\r\n                                </td>\r\n                             \r\n                            </tr>\r\n");
#nullable restore
#line 61 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService24CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListingWorkViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
