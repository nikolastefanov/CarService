#pragma checksum "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Orders\AllOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e778702909e4d273cab5e11107028d8947e10135"
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
#line 1 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\_ViewImports.cshtml"
using CarService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\_ViewImports.cshtml"
using CarService.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\_ViewImports.cshtml"
using CarService.Models.IssueTypes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Reviews;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Issues;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Cars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Mechanics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Works;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Orders\AllOrders.cshtml"
using CarService.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Orders\AllOrders.cshtml"
using CarService.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Orders\AllOrders.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e778702909e4d273cab5e11107028d8947e10135", @"/Views/Orders/AllOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c683fb7eb1648abea98e30a6ff6e453845fc32e", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_AllOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllOrdersViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Orders\AllOrders.cshtml"
  
    this.ViewData["Title"] = "AllOrders";

    var userIsAdmin = User.IsAdmin();

 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container-fluid text-center\">\r\n\r\n    <h1>");
#nullable restore
#line 19 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Orders\AllOrders.cshtml"
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
                    <h3 id=""tables"">Listed orders for: </h3>
                    <h4 class=""font-weight-bold font-italic"">UserName: ");
#nullable restore
#line 30 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Orders\AllOrders.cshtml"
                                                                  Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                </div>

                <div class=""component"">
                    <table class=""table table-hover"">
                        <thead class="" table-active"">
                            <tr>
                                <th scope=""col"">TotalPrice</th>
                                <th scope=""col"" class=""text-center"">CreateOn</th>
                                <th scope=""col"" class=""text-center"">Details Order</th>
");
#nullable restore
#line 40 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Orders\AllOrders.cshtml"
                                if (userIsAdmin)
                               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <th scope=\"col\" class=\"text-center\">Delete Order</th>\r\n");
#nullable restore
#line 43 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Orders\AllOrders.cshtml"
                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 47 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Orders\AllOrders.cshtml"
                             foreach (var order in Model.Orders)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"table-light\">\r\n                    <td>");
#nullable restore
#line 51 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Orders\AllOrders.cshtml"
                   Write(order.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <span class=\"card-title\"> ");
#nullable restore
#line 53 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Orders\AllOrders.cshtml"
                                             Write(order.CreateOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </td>\r\n\r\n                    <td>\r\n                        <a class=\"btn btn-block btn-primary text-white mb-3\"");
            BeginWriteAttribute("href", " href=\"", 1886, "\"", 1952, 4);
            WriteAttributeValue("", 1893, "/Orders/DetailsOrder?orderId=", 1893, 29, true);
#nullable restore
#line 57 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Orders\AllOrders.cshtml"
WriteAttributeValue("", 1922, order.Id, 1922, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1931, "&userId=", 1931, 8, true);
#nullable restore
#line 57 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Orders\AllOrders.cshtml"
WriteAttributeValue("", 1939, order.UserId, 1939, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details Order</a>\r\n                    </td>\r\n\r\n");
#nullable restore
#line 60 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Orders\AllOrders.cshtml"
                     if (userIsAdmin)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <td>\r\n                          <a class=\"btn btn-block btn-warning text-white mb-3\"");
            BeginWriteAttribute("href", " href=\"", 2170, "\"", 2235, 4);
            WriteAttributeValue("", 2177, "/Orders/DeleteOrder?orderId=", 2177, 28, true);
#nullable restore
#line 63 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Orders\AllOrders.cshtml"
WriteAttributeValue("", 2205, order.Id, 2205, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2214, "&userId=", 2214, 8, true);
#nullable restore
#line 63 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Orders\AllOrders.cshtml"
WriteAttributeValue("", 2222, order.UserId, 2222, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete Order</a>\r\n                      </td>");
#nullable restore
#line 64 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Orders\AllOrders.cshtml"
                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>");
#nullable restore
#line 65 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Orders\AllOrders.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; }
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
