#pragma checksum "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService14CarMechanic\CarService\Views\Cars\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "010b03895ac27e6cf24f7dff198c59588a1b9ccb"
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
#line 1 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService14CarMechanic\CarService\Views\_ViewImports.cshtml"
using CarService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService14CarMechanic\CarService\Views\_ViewImports.cshtml"
using CarService.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService14CarMechanic\CarService\Views\_ViewImports.cshtml"
using CarService.Models.IssueTypes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService14CarMechanic\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Reviews;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService14CarMechanic\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Issues;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService14CarMechanic\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Cars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService14CarMechanic\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Mechanics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService14CarMechanic\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Works;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"010b03895ac27e6cf24f7dff198c59588a1b9ccb", @"/Views/Cars/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b9f25385640c698ea4aba020b3a202f3eac8ff1", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CarListingViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1 class=\"text-center mt-2\">My Cars</h1>\n<div class=\"row mt-2 mb-4\">\n    \n");
#nullable restore
#line 6 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService14CarMechanic\CarService\Views\Cars\All.cshtml"
     foreach (var car in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card col-6 col-lg-3 game-card\">\n        <img");
            BeginWriteAttribute("src", " src=\"", 208, "\"", 227, 1);
#nullable restore
#line 9 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService14CarMechanic\CarService\Views\Cars\All.cshtml"
WriteAttributeValue("", 214, car.ImageUrl, 214, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\n             class=\"card-img-top img-fluid card-image rounded\" data-toggle=\"tooltip\"\n             data-placement=\"bottom\"");
            BeginWriteAttribute("title", " title=\"", 350, "\"", 377, 2);
#nullable restore
#line 11 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService14CarMechanic\CarService\Views\Cars\All.cshtml"
WriteAttributeValue("", 358, car.Make, 358, 9, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService14CarMechanic\CarService\Views\Cars\All.cshtml"
WriteAttributeValue(" ", 367, car.Year, 368, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        <div class=\"card-body\">\n            <ul class=\"list-group list-group-flush\">\n                <li class=\"list-group-item text-center\">Plate # ");
#nullable restore
#line 14 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService14CarMechanic\CarService\Views\Cars\All.cshtml"
                                                           Write(car.PlateNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                <li class=""list-group-item"">
                    <span class=""bg-danger col-sm"">Remaining Issues: car.RemainingIssues</span>
                    <span class=""bg-success col-sm"">Fixed Issues: car.FixedIssues</span>
                </li>
            </ul>
            <a");
            BeginWriteAttribute("href", " href=\"", 835, "\"", 872, 2);
            WriteAttributeValue("", 842, "/Issues/AddIssue?carId=", 842, 23, true);
#nullable restore
#line 20 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService14CarMechanic\CarService\Views\Cars\All.cshtml"
WriteAttributeValue("", 865, car.Id, 865, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-block btn-primary\">Check issues</a>\n        </div>\n        <a");
            BeginWriteAttribute("href", " href=\"", 950, "\"", 981, 2);
            WriteAttributeValue("", 957, "/Cars/Edit?carId=", 957, 17, true);
#nullable restore
#line 22 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService14CarMechanic\CarService\Views\Cars\All.cshtml"
WriteAttributeValue("", 974, car.Id, 974, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-block btn-danger\">Edit car</a>\n    </div>\n");
#nullable restore
#line 24 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService14CarMechanic\CarService\Views\Cars\All.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CarListingViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
