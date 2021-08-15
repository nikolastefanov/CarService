#pragma checksum "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\Cars\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f01a197a1b1945f1104d38a747cf1ab73d63e6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_All), @"mvc.1.0.view", @"/Views/Cars/All.cshtml")]
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
#line 1 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\_ViewImports.cshtml"
using CarService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\_ViewImports.cshtml"
using CarService.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\_ViewImports.cshtml"
using CarService.Models.IssueTypes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Reviews;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Issues;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Cars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Mechanics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Works;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\Cars\All.cshtml"
using CarService.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\Cars\All.cshtml"
using CarService.Services.Mechanics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\Cars\All.cshtml"
using CarService.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\Cars\All.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f01a197a1b1945f1104d38a747cf1ab73d63e6f", @"/Views/Cars/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c683fb7eb1648abea98e30a6ff6e453845fc32e", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CarListingViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
            WriteLiteral("\n\n<h1 class=\"text-center mt-2\">My Cars</h1>\n<div class=\"row mt-2 mb-4\">\n\n");
#nullable restore
#line 16 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\Cars\All.cshtml"
     foreach (var car in Model)
    {
        var userId = User.Id();
        var userIsMechanic = Mechanics.IsMechanic(userId);
        var userIsAdmin = User.IsAdmin();



#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card col-6 col-lg-3 game-card\">\n        <img");
            BeginWriteAttribute("src", " src=\"", 598, "\"", 617, 1);
#nullable restore
#line 24 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\Cars\All.cshtml"
WriteAttributeValue("", 604, car.ImageUrl, 604, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\n             class=\"card-img-top img-fluid card-image rounded\" data-toggle=\"tooltip\"\n             data-placement=\"bottom\"");
            BeginWriteAttribute("title", " title=\"", 740, "\"", 767, 2);
#nullable restore
#line 26 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\Cars\All.cshtml"
WriteAttributeValue("", 748, car.Make, 748, 9, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\Cars\All.cshtml"
WriteAttributeValue(" ", 757, car.Year, 758, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        <div class=\"card-body\">\n            <ul class=\"list-group list-group-flush\">\n                <li class=\"list-group-item text-center\">Plate # ");
#nullable restore
#line 29 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\Cars\All.cshtml"
                                                           Write(car.PlateNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                <li class=\"list-group-item\">\n                    <span class=\"bg-danger col-sm\">Remaining Issues: ");
#nullable restore
#line 31 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\Cars\All.cshtml"
                                                                Write(car.RemainingIssues);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    <span class=\"bg-success col-sm\">Fixed Issues: ");
#nullable restore
#line 32 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\Cars\All.cshtml"
                                                             Write(car.FixedIssues);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </li>\n            </ul>\n\n");
#nullable restore
#line 36 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\Cars\All.cshtml"
             if (userIsMechanic && !userIsAdmin)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <a");
            BeginWriteAttribute("href", " href=\"", 1297, "\"", 1334, 2);
            WriteAttributeValue("", 1304, "/Issues/AddIssue?carId=", 1304, 23, true);
#nullable restore
#line 38 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\Cars\All.cshtml"
WriteAttributeValue("", 1327, car.Id, 1327, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-block btn-primary\">Check issues</a>\n");
#nullable restore
#line 39 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\Cars\All.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n               <a");
            BeginWriteAttribute("href", " href=\"", 1420, "\"", 1458, 2);
            WriteAttributeValue("", 1427, "/Issues/AllIssues?carId=", 1427, 24, true);
#nullable restore
#line 41 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\Cars\All.cshtml"
WriteAttributeValue("", 1451, car.Id, 1451, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-block btn-warning\">All issues to car</a>\n\n        </div>\n");
#nullable restore
#line 44 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\Cars\All.cshtml"
         if (userIsAdmin)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <a");
            BeginWriteAttribute("href", " href=\"", 1583, "\"", 1614, 2);
            WriteAttributeValue("", 1590, "/Cars/Edit?carId=", 1590, 17, true);
#nullable restore
#line 46 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\Cars\All.cshtml"
WriteAttributeValue("", 1607, car.Id, 1607, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-block btn-danger\">Edit car</a>\n");
#nullable restore
#line 47 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\Cars\All.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("   </div>\n");
#nullable restore
#line 49 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService38PrtialView\CarService\Views\Cars\All.cshtml"
   }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IMechanicsService Mechanics { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CarListingViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
