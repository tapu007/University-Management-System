#pragma checksum "C:\Users\User\source\repos\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2b9374196de3cdb82ef9173204e433ee8a4b54c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DepartmentWiseCourse), @"mvc.1.0.view", @"/Views/Shared/_DepartmentWiseCourse.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_DepartmentWiseCourse.cshtml", typeof(AspNetCore.Views_Shared__DepartmentWiseCourse))]
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
#line 1 "C:\Users\User\source\repos\UniversityApp\UniversityApp\Views\_ViewImports.cshtml"
using UniversityApp;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\UniversityApp\UniversityApp\Views\_ViewImports.cshtml"
using UniversityApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2b9374196de3cdb82ef9173204e433ee8a4b54c", @"/Views/Shared/_DepartmentWiseCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ad95a638237f3f256aa08dc63160873bdeb208b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__DepartmentWiseCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<University.Models.EntityModels.Course>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 136, true);
            WriteLiteral("\r\n<table class=\"table table-bordered table-active\">\r\n    <thead>\r\n        <tr class=\"label-primary\">\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(196, 46, false);
#line 7 "C:\Users\User\source\repos\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml"
           Write(Html.DisplayNameFor(model => model.CourseCode));

#line default
#line hidden
            EndContext();
            BeginContext(242, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(298, 46, false);
#line 10 "C:\Users\User\source\repos\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml"
           Write(Html.DisplayNameFor(model => model.CourseName));

#line default
#line hidden
            EndContext();
            BeginContext(344, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(400, 42, false);
#line 13 "C:\Users\User\source\repos\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml"
           Write(Html.DisplayNameFor(model => model.Credit));

#line default
#line hidden
            EndContext();
            BeginContext(442, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(498, 48, false);
#line 16 "C:\Users\User\source\repos\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml"
           Write(Html.DisplayNameFor(model => model.DepartmentId));

#line default
#line hidden
            EndContext();
            BeginContext(546, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(602, 46, false);
#line 19 "C:\Users\User\source\repos\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml"
           Write(Html.DisplayNameFor(model => model.SemesterId));

#line default
#line hidden
            EndContext();
            BeginContext(648, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 25 "C:\Users\User\source\repos\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(783, 75, true);
            WriteLiteral("            <tr class=\"active\">\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(859, 15, false);
#line 29 "C:\Users\User\source\repos\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml"
               Write(item.CourseCode);

#line default
#line hidden
            EndContext();
            BeginContext(874, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(942, 15, false);
#line 32 "C:\Users\User\source\repos\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml"
               Write(item.CourseName);

#line default
#line hidden
            EndContext();
            BeginContext(957, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1025, 11, false);
#line 35 "C:\Users\User\source\repos\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml"
               Write(item.Credit);

#line default
#line hidden
            EndContext();
            BeginContext(1036, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1104, 17, false);
#line 38 "C:\Users\User\source\repos\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml"
               Write(item.DepartmentId);

#line default
#line hidden
            EndContext();
            BeginContext(1121, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1189, 15, false);
#line 41 "C:\Users\User\source\repos\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml"
               Write(item.SemesterId);

#line default
#line hidden
            EndContext();
            BeginContext(1204, 61, true);
            WriteLiteral("\r\n                </td>\r\n               \r\n            </tr>\r\n");
            EndContext();
#line 45 "C:\Users\User\source\repos\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml"
        }

#line default
#line hidden
            BeginContext(1276, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<University.Models.EntityModels.Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
