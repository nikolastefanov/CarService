#pragma checksum "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService8\CarService\Views\Cars\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5a8324771e3ee8cf5c177e637ce5e7b97184a36"
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
#line 1 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService8\CarService\Views\_ViewImports.cshtml"
using CarService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService8\CarService\Views\_ViewImports.cshtml"
using CarService.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService8\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService8\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Reviews;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService8\CarService\Views\_ViewImports.cshtml"
using CarService.Models.Issues;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5a8324771e3ee8cf5c177e637ce5e7b97184a36", @"/Views/Cars/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d36d0645976ac8546b0c16e9248bb9902ed1e86", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1 class=""text-center mt-2"">My Cars</h1>
<div class=""row mt-2 mb-4"">
    
    
        <div class=""card col-6 col-lg-3 game-card"">
            <img src=""car.Image""
                 class=""card-img-top img-fluid card-image rounded"" data-toggle=""tooltip""
                 data-placement=""bottom"" title=""car.Year car.Model"">
            <div class=""card-body"">
                <ul class=""list-group list-group-flush"">
                    <li class=""list-group-item text-center"">Plate # car.PlateNumber</li>
                    <li class=""list-group-item"">
                        <span class=""bg-danger col-sm"">Remaining Issues: car.RemainingIssues</span>
                        <span class=""bg-success col-sm"">Fixed Issues: car.FixedIssues</span>
                    </li>
                </ul>
                <a href=""/Issues/CarIssues?carId=car.Id"" class=""btn btn-block btn-primary"">Check issues</a>
            </div>
        </div>
    

</div>");
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
