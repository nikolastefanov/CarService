#pragma checksum "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d834df8d5e407c01823cacdaefe2c5c055aec5a1"
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
#line 1 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\_ViewImports.cshtml"
using CarService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\_ViewImports.cshtml"
using CarService.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\_ViewImports.cshtml"
using CarService.Models.IssueTypes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Reviews;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Issues;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Cars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Mechanics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Works;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Orders;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d834df8d5e407c01823cacdaefe2c5c055aec5a1", @"/Views/Works/AllWorks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c683fb7eb1648abea98e30a6ff6e453845fc32e", @"/Views/_ViewImports.cshtml")]
    public class Views_Works_AllWorks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListingWorkViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
  
    this.ViewData["Title"] = "AllWorks";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container-fluid text-center\">\r\n\r\n    <h1>");
#nullable restore
#line 10 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
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
#line 22 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
                                                             Write(Model.CarId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Issue:");
#nullable restore
#line 22 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
                                                                                Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Description: ");
#nullable restore
#line 22 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
                                                                                                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n\r\n                <div class=\"d-flex justify-content-center\">\r\n                    <a class=\"btn btn-block btn-primary text-white mb-3\"");
            BeginWriteAttribute("href", " href=\"", 719, "\"", 778, 4);
            WriteAttributeValue("", 726, "/Works/AddWorks?issueId=", 726, 24, true);
#nullable restore
#line 26 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
WriteAttributeValue("", 750, Model.Id, 750, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 759, "&carId=", 759, 7, true);
#nullable restore
#line 26 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
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
#line 41 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
                             foreach (var work in Model.Works)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr class=\"table-light\">\r\n                                <td>");
#nullable restore
#line 45 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
                               Write(work.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <span class=\"card-title\"> ");
#nullable restore
#line 47 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
                                                         Write(work.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </td>

                                <td>
                                    <a class=""btn btn-block btn-primary text-white mb-3"" href=""/Orders/AddToOrder"">Add to Order</a>
                                </td>
                                <td>
                                    <a class=""btn btn-block btn-warning text-white mb-3""");
            BeginWriteAttribute("href", " href=\"", 2204, "\"", 2284, 6);
            WriteAttributeValue("", 2211, "/Works/EditWorks?workId=", 2211, 24, true);
#nullable restore
#line 54 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
WriteAttributeValue("", 2235, work.Id, 2235, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2243, "&issueId=", 2243, 9, true);
#nullable restore
#line 54 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
WriteAttributeValue("", 2252, work.IssueId, 2252, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2265, "&carId=", 2265, 7, true);
#nullable restore
#line 54 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
WriteAttributeValue("", 2272, Model.CarId, 2272, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit Work</a>\r\n                                </td>\r\n                                <td>\r\n                                    <a class=\"btn btn-block btn-danger text-white mb-3\"");
            BeginWriteAttribute("href", " href=\"", 2465, "\"", 2547, 6);
            WriteAttributeValue("", 2472, "/Works/DeleteWorks?workId=", 2472, 26, true);
#nullable restore
#line 57 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
WriteAttributeValue("", 2498, work.Id, 2498, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2506, "&issueId=", 2506, 9, true);
#nullable restore
#line 57 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
WriteAttributeValue("", 2515, work.IssueId, 2515, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2528, "&carId=", 2528, 7, true);
#nullable restore
#line 57 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
WriteAttributeValue("", 2535, Model.CarId, 2535, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete Work</a>\r\n                                </td>\r\n                             \r\n                            </tr>\r\n");
#nullable restore
#line 61 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService21CarMechanicIssue\CarService\Views\Works\AllWorks.cshtml"
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
