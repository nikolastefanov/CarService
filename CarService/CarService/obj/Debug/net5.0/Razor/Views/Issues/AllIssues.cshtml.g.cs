#pragma checksum "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a56e847d55cc417eb680495159a1552567ba17eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Issues_AllIssues), @"mvc.1.0.view", @"/Views/Issues/AllIssues.cshtml")]
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
#line 1 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
using CarService.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
using CarService.Services.Mechanics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
using CarService.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a56e847d55cc417eb680495159a1552567ba17eb", @"/Views/Issues/AllIssues.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c683fb7eb1648abea98e30a6ff6e453845fc32e", @"/Views/_ViewImports.cshtml")]
    public class Views_Issues_AllIssues : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarIssuesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 12 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
   
    var userId = User.Id();
    var userIsMechanic = Mechanics.IsMechanic(userId);
    var userIsAdmin = User.IsAdmin();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container"">
    <div class=""section"">
        <div class=""row"">
            <div class=""col-md-10 offset-md-1"">
                <div class=""page-header text-center"">
                    <h3 id=""tables"">Listed issues for: </h3>
                    <h4 class=""font-weight-bold font-italic"">");
#nullable restore
#line 25 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
                                                        Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
                                                                    Write(Model.Make);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
                                                                                Write(Model.ModelCar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                </div>\n\n                <div class=\"d-flex justify-content-center\">\n                    <a class=\"btn btn-block btn-primary text-white mb-3\"");
            BeginWriteAttribute("href", " href=\"", 914, "\"", 953, 2);
            WriteAttributeValue("", 921, "/Issues/AddIssue?carId=", 921, 23, true);
#nullable restore
#line 29 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
WriteAttributeValue("", 944, Model.Id, 944, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Add a new Issue</a>
                </div>

                <div class=""component"">
                    <table class=""table table-hover"">
                        <thead class="" table-active"">
                            <tr>
                                <th scope=""col"">Description</th>
                                <th scope=""col"">Is it fixed?</th>
");
#nullable restore
#line 38 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
                                 if (userIsMechanic || userIsAdmin)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <th scope=\"col\" class=\"text-center\">Fix Issue</th>\n                                <th scope=\"col\" class=\"text-center\">Add Work</th>\n");
#nullable restore
#line 42 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
                                 if (userIsAdmin)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <th scope=\"col\" class=\"text-center\">Edit Issue</th>\n                                <th scope=\"col\" class=\"text-center\">Delete Issue</th>\n");
#nullable restore
#line 47 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\n                        </thead>\n                        <tbody>\n");
#nullable restore
#line 51 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
                             foreach (var issue in Model.Issues)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"table-light\">\n                    <td>");
#nullable restore
#line 54 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
                   Write(issue.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>\n");
#nullable restore
#line 56 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
                         if (issue.IsFixed)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                             <span>Yes</span>\n");
#nullable restore
#line 59 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
                         if (!issue.IsFixed)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>Not yet</span>\n");
#nullable restore
#line 63 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\n                  \n");
#nullable restore
#line 66 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
                     if (userIsMechanic || userIsAdmin)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\n                        <a class=\"btn btn-block btn-primary text-white mb-3\"");
            BeginWriteAttribute("href", " href=\"", 2723, "\"", 2778, 4);
            WriteAttributeValue("", 2730, "/Issues/Fix?issueId=", 2730, 20, true);
#nullable restore
#line 69 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
WriteAttributeValue("", 2750, issue.Id, 2750, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2759, "&carId=", 2759, 7, true);
#nullable restore
#line 69 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
WriteAttributeValue("", 2766, issue.CarId, 2766, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Fix Issue</a>\n                    </td>\n");
            WriteLiteral("                    <td>\n                        <a class=\"btn btn-block btn-primary text-white mb-3\"");
            BeginWriteAttribute("href", " href=\"", 2922, "\"", 2981, 4);
            WriteAttributeValue("", 2929, "/Works/AddWorks?issueId=", 2929, 24, true);
#nullable restore
#line 73 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
WriteAttributeValue("", 2953, issue.Id, 2953, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2962, "&carId=", 2962, 7, true);
#nullable restore
#line 73 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
WriteAttributeValue("", 2969, issue.CarId, 2969, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Add Work</a>\n                    </td>\n");
#nullable restore
#line 75 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
                     if (userIsAdmin)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\n                        <a class=\"btn btn-block btn-warning text-white mb-3\"");
            BeginWriteAttribute("href", " href=\"", 3206, "\"", 3267, 4);
            WriteAttributeValue("", 3213, "/Issues/EditIssue?issueId=", 3213, 26, true);
#nullable restore
#line 79 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
WriteAttributeValue("", 3239, issue.Id, 3239, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3248, "&carId=", 3248, 7, true);
#nullable restore
#line 79 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
WriteAttributeValue("", 3255, issue.CarId, 3255, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit Issue</a>\n                    </td>\n");
            WriteLiteral("                    <td>\n                        <a class=\"btn btn-block btn-danger text-white mb-3\"");
            BeginWriteAttribute("href", " href=\"", 3411, "\"", 3474, 4);
            WriteAttributeValue("", 3418, "/Issues/DeleteIssue?issueId=", 3418, 28, true);
#nullable restore
#line 83 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
WriteAttributeValue("", 3446, issue.Id, 3446, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3455, "&carId=", 3455, 7, true);
#nullable restore
#line 83 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
WriteAttributeValue("", 3462, issue.CarId, 3462, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete Issue</a>\n                    </td>\n");
#nullable restore
#line 85 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\n");
#nullable restore
#line 87 "C:\Users\HP\Documents\Kurs_SoftUni\A_C#_ASP_NET_Core_may_2021_my\CarServiceMy\CarService43\CarService\Views\Issues\AllIssues.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </tbody>\n                    </table>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarIssuesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
