#pragma checksum "C:\Users\matti\Desktop\Fitness planner\FitnessplannerFontysS2\PresentationLayer2\Views\Myreservation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7c8045c1bb10ae1bcaeca6bc15ce5bc7bf5c239"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Myreservation_Index), @"mvc.1.0.view", @"/Views/Myreservation/Index.cshtml")]
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
#line 1 "C:\Users\matti\Desktop\Fitness planner\FitnessplannerFontysS2\PresentationLayer2\Views\_ViewImports.cshtml"
using PresentationLayer2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\matti\Desktop\Fitness planner\FitnessplannerFontysS2\PresentationLayer2\Views\_ViewImports.cshtml"
using PresentationLayer2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7c8045c1bb10ae1bcaeca6bc15ce5bc7bf5c239", @"/Views/Myreservation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a62acbf5300d33e45c899022f6f1c2536c785da1", @"/Views/_ViewImports.cshtml")]
    public class Views_Myreservation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PresentationLayer2.Models.MyreservationViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeProgram", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cancel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\matti\Desktop\Fitness planner\FitnessplannerFontysS2\PresentationLayer2\Views\Myreservation\Index.cshtml"
  
    ViewData["Title"] = "MyReservations";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron-fluid\">\r\n    <h1 class=\"text-center\">");
#nullable restore
#line 8 "C:\Users\matti\Desktop\Fitness planner\FitnessplannerFontysS2\PresentationLayer2\Views\Myreservation\Index.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\matti\Desktop\Fitness planner\FitnessplannerFontysS2\PresentationLayer2\Views\Myreservation\Index.cshtml"
 if (TempData["ProgramChanged"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        <strong> Succes! </strong>  ");
#nullable restore
#line 14 "C:\Users\matti\Desktop\Fitness planner\FitnessplannerFontysS2\PresentationLayer2\Views\Myreservation\Index.cshtml"
                               Write(TempData["ProgramChanged"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 16 "C:\Users\matti\Desktop\Fitness planner\FitnessplannerFontysS2\PresentationLayer2\Views\Myreservation\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\matti\Desktop\Fitness planner\FitnessplannerFontysS2\PresentationLayer2\Views\Myreservation\Index.cshtml"
 if (TempData["ReservationCancelled"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        <strong> Succes! </strong>  ");
#nullable restore
#line 20 "C:\Users\matti\Desktop\Fitness planner\FitnessplannerFontysS2\PresentationLayer2\Views\Myreservation\Index.cshtml"
                               Write(TempData["ReservationCancelled"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 22 "C:\Users\matti\Desktop\Fitness planner\FitnessplannerFontysS2\PresentationLayer2\Views\Myreservation\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n\r\n</p>\r\n<table class=\"table table-bordered\">\r\n    <thead class=\"thead-light\">\r\n        <tr>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\matti\Desktop\Fitness planner\FitnessplannerFontysS2\PresentationLayer2\Views\Myreservation\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Day));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\matti\Desktop\Fitness planner\FitnessplannerFontysS2\PresentationLayer2\Views\Myreservation\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Timeslot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "C:\Users\matti\Desktop\Fitness planner\FitnessplannerFontysS2\PresentationLayer2\Views\Myreservation\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Currentreservation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "C:\Users\matti\Desktop\Fitness planner\FitnessplannerFontysS2\PresentationLayer2\Views\Myreservation\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Maxreservations));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 48 "C:\Users\matti\Desktop\Fitness planner\FitnessplannerFontysS2\PresentationLayer2\Views\Myreservation\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Programname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 57 "C:\Users\matti\Desktop\Fitness planner\FitnessplannerFontysS2\PresentationLayer2\Views\Myreservation\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 67 "C:\Users\matti\Desktop\Fitness planner\FitnessplannerFontysS2\PresentationLayer2\Views\Myreservation\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Day));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 70 "C:\Users\matti\Desktop\Fitness planner\FitnessplannerFontysS2\PresentationLayer2\Views\Myreservation\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Timeslot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 73 "C:\Users\matti\Desktop\Fitness planner\FitnessplannerFontysS2\PresentationLayer2\Views\Myreservation\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Currentreservation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 76 "C:\Users\matti\Desktop\Fitness planner\FitnessplannerFontysS2\PresentationLayer2\Views\Myreservation\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Maxreservations));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 79 "C:\Users\matti\Desktop\Fitness planner\FitnessplannerFontysS2\PresentationLayer2\Views\Myreservation\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Programname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7c8045c1bb10ae1bcaeca6bc15ce5bc7bf5c23910541", async() => {
                WriteLiteral("ChangeProgram");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Users\matti\Desktop\Fitness planner\FitnessplannerFontysS2\PresentationLayer2\Views\Myreservation\Index.cshtml"
                                                    WriteLiteral(item.BookingID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7c8045c1bb10ae1bcaeca6bc15ce5bc7bf5c23912774", async() => {
                WriteLiteral("Cancel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "C:\Users\matti\Desktop\Fitness planner\FitnessplannerFontysS2\PresentationLayer2\Views\Myreservation\Index.cshtml"
                                             WriteLiteral(item.BookingID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 89 "C:\Users\matti\Desktop\Fitness planner\FitnessplannerFontysS2\PresentationLayer2\Views\Myreservation\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PresentationLayer2.Models.MyreservationViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
