#pragma checksum "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService49OrderDelete\CarService\Views\Orders\DetailsOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8bd05e36e51ae181be040dde83c588e07f376e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_DetailsOrder), @"mvc.1.0.view", @"/Views/Orders/DetailsOrder.cshtml")]
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
#line 1 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService49OrderDelete\CarService\Views\_ViewImports.cshtml"
using CarService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService49OrderDelete\CarService\Views\_ViewImports.cshtml"
using CarService.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService49OrderDelete\CarService\Views\_ViewImports.cshtml"
using CarService.Models.IssueTypes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService49OrderDelete\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Reviews;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService49OrderDelete\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Issues;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService49OrderDelete\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Cars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService49OrderDelete\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Mechanics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService49OrderDelete\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Works;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService49OrderDelete\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Orders;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8bd05e36e51ae181be040dde83c588e07f376e7", @"/Views/Orders/DetailsOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c683fb7eb1648abea98e30a6ff6e453845fc32e", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_DetailsOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DetailsOrderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService49OrderDelete\CarService\Views\Orders\DetailsOrder.cshtml"
   
    this.ViewData["Title"] = "Details Order";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container-fluid text-center\">\r\n\r\n    <h2>");
#nullable restore
#line 10 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService49OrderDelete\CarService\Views\Orders\DetailsOrder.cshtml"
   Write(this.ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

</div>


<div class=""container"">
    <div class=""section"">
        <div class=""row"">
            <div class=""col-md-10 offset-md-1"">
                <div class=""page-header text-center"">
                    <h2 id=""tables"">Listed order for: </h2>
                    <h3 class=""font-weight-bold font-italic"">Name: ");
#nullable restore
#line 21 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService49OrderDelete\CarService\Views\Orders\DetailsOrder.cshtml"
                                                              Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n                    <h3 class=\"font-weight-bold font-italic\"> Price: ");
#nullable restore
#line 22 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService49OrderDelete\CarService\Views\Orders\DetailsOrder.cshtml"
                                                                Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("  Create: ");
#nullable restore
#line 22 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService49OrderDelete\CarService\Views\Orders\DetailsOrder.cshtml"
                                                                                           Write(Model.CreateOn);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                </div>

                <div class=""component"">
                    <table class=""table table-hover"">
                        <thead class="" table-active"">
                            <tr>
                                <th scope=""col"">Description</th>
                                <th scope=""col"">Price To Work</th>
                          
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 35 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService49OrderDelete\CarService\Views\Orders\DetailsOrder.cshtml"
                             foreach (var work in Model.Works)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"table-light\">\r\n                                    <td>");
#nullable restore
#line 38 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService49OrderDelete\CarService\Views\Orders\DetailsOrder.cshtml"
                                   Write(work.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                    <td>");
#nullable restore
#line 40 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService49OrderDelete\CarService\Views\Orders\DetailsOrder.cshtml"
                                   Write(work.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    \r\n                                </tr>\r\n");
#nullable restore
#line 43 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService49OrderDelete\CarService\Views\Orders\DetailsOrder.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>

                
                    <a class=""btn btn-block btn-primary text-white mb-3"" href=""/Orders/AllOrders"">All Orders</a>
               
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetailsOrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
