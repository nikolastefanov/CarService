#pragma checksum "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService31AdimArea2\CarService\Views\Orders\AllOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92f8fd527193ad67311481e29d93d15bee429c85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_AllOrders), @"mvc.1.0.view", @"/Views/Orders/AllOrders.cshtml")]
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
#line 1 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService31AdimArea2\CarService\Views\_ViewImports.cshtml"
using CarService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService31AdimArea2\CarService\Views\_ViewImports.cshtml"
using CarService.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService31AdimArea2\CarService\Views\_ViewImports.cshtml"
using CarService.Models.IssueTypes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService31AdimArea2\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Reviews;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService31AdimArea2\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Issues;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService31AdimArea2\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Cars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService31AdimArea2\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Mechanics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService31AdimArea2\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Works;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService31AdimArea2\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Orders;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92f8fd527193ad67311481e29d93d15bee429c85", @"/Views/Orders/AllOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c683fb7eb1648abea98e30a6ff6e453845fc32e", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_AllOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllOrdersViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService31AdimArea2\CarService\Views\Orders\AllOrders.cshtml"
  
    this.ViewData["Title"] = "AllOrders";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container-fluid text-center\">\r\n\r\n    <h1>");
#nullable restore
#line 10 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService31AdimArea2\CarService\Views\Orders\AllOrders.cshtml"
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
                    <h2 id=""tables"">Listed orders for: </h2>
                    <h2 class=""font-weight-bold font-italic"">UserName: ");
#nullable restore
#line 22 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService31AdimArea2\CarService\Views\Orders\AllOrders.cshtml"
                                                                  Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                </div>              

                <div class=""component"">
                    <table class=""table table-hover"">
                        <thead class="" table-active"">
                            <tr>
                                <th scope=""col"">TotalPrice</th>
                                <th scope=""col"" class=""text-center"">CreateOn</th>
                                <th scope=""col"" class=""text-center"">Details Order</th>
                                <th scope=""col"" class=""text-center"">Delete Order</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 36 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService31AdimArea2\CarService\Views\Orders\AllOrders.cshtml"
                             foreach (var order in Model.Orders)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"table-light\">\r\n                                    <td>");
#nullable restore
#line 40 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService31AdimArea2\CarService\Views\Orders\AllOrders.cshtml"
                                   Write(order.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <span class=\"card-title\"> ");
#nullable restore
#line 42 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService31AdimArea2\CarService\Views\Orders\AllOrders.cshtml"
                                                             Write(order.CreateOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </td>\r\n\r\n                                    <td>\r\n                                        <a class=\"btn btn-block btn-primary text-white mb-3\"");
            BeginWriteAttribute("href", " href=\"", 1702, "\"", 1768, 4);
            WriteAttributeValue("", 1709, "/Orders/DetailsOrder?orderId=", 1709, 29, true);
#nullable restore
#line 46 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService31AdimArea2\CarService\Views\Orders\AllOrders.cshtml"
WriteAttributeValue("", 1738, order.Id, 1738, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1747, "&userId=", 1747, 8, true);
#nullable restore
#line 46 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService31AdimArea2\CarService\Views\Orders\AllOrders.cshtml"
WriteAttributeValue("", 1755, order.UserId, 1755, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details Order</a>\r\n                                    </td>\r\n                                    <td>\r\n                                        <a class=\"btn btn-block btn-warning text-white mb-3\"");
            BeginWriteAttribute("href", " href=\"", 1966, "\"", 2031, 4);
            WriteAttributeValue("", 1973, "/Orders/DeleteOrder?orderId=", 1973, 28, true);
#nullable restore
#line 49 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService31AdimArea2\CarService\Views\Orders\AllOrders.cshtml"
WriteAttributeValue("", 2001, order.Id, 2001, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2010, "&userId=", 2010, 8, true);
#nullable restore
#line 49 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService31AdimArea2\CarService\Views\Orders\AllOrders.cshtml"
WriteAttributeValue("", 2018, order.UserId, 2018, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete Order</a>\r\n                                    \r\n                                </tr>\r\n");
#nullable restore
#line 52 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService31AdimArea2\CarService\Views\Orders\AllOrders.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllOrdersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
