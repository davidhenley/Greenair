#pragma checksum "D:\Code\C#\Greenair\Presentation\Pages\Admin\Flight.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d7e120248785f6ac682e295f08afbc2172b4cff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Presentation.Pages.Admin.Pages_Admin_Flight), @"mvc.1.0.razor-page", @"/Pages/Admin/Flight.cshtml")]
namespace Presentation.Pages.Admin
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
#line 1 "D:\Code\C#\Greenair\Presentation\Pages\_ViewImports.cshtml"
using Presentation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d7e120248785f6ac682e295f08afbc2172b4cff", @"/Pages/Admin/Flight.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d76d778d4c858045a827ae28cbb9bc28e1d5c23", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Flight : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("SearchFlight"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search Here"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "searchString", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Code\C#\Greenair\Presentation\Pages\Admin\Flight.cshtml"
  
  Layout = "_LayoutAdmin";
	ViewData["Title"] = "Admin Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""main-panel"">
  <div class=""content-wrapper"">
     <!-- row button create -->
    <div class=""row"">
      <div class=""col-lg-12 stretch-card"">
        <a href=""#CreateFlightForm"" data-toggle=""modal"" id=""btCreateFlight"" type=""button"" class=""btn  btn-primary btn-lg btn-inverse-*"">
          <i class=""mdi mdi-upload""></i>Create Flight
        </a>
      </div>
    </div>
    <!-- row table -->
    <div class=""row"">
      <div class=""col-lg-12 stretch-card"">
        <div class=""card"">
          <div class=""card-body"">
            <div class=""form-group row"">
              <div class=""col-sm-7""></div>
              <div class=""col-sm-5"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d7e120248785f6ac682e295f08afbc2172b4cff5728", async() => {
                WriteLiteral("\r\n                  <div class=\"input-group\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3d7e120248785f6ac682e295f08afbc2172b4cff6055", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 27 "D:\Code\C#\Greenair\Presentation\Pages\Admin\Flight.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchString);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <button type=\"submit\" id=\"btsubmitSearchFlight\" class=\"btn btn-icons btn-rounded btn-outline-primary\"><i class=\"fa fa-search\"></i></button>\r\n                  </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" 
              </div> 
            </div>
            <h3 align=""center"">List of Flights </h3>
            <table class=""table table-bordered table-striped table-hover"" id=""TableFlight"">
            <thead>
              <tr>
                <th>ID</th>
                <th>Status</th>
                <th>Plane ID</th>
                <th></th>
              </tr>
            </thead>
            <tbody> 
");
#nullable restore
#line 44 "D:\Code\C#\Greenair\Presentation\Pages\Admin\Flight.cshtml"
               foreach (var item in Model.ListFlights){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                <!-- <tr id=\"");
#nullable restore
#line 46 "D:\Code\C#\Greenair\Presentation\Pages\Admin\Flight.cshtml"
                        Write(item.FlightId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"list-Flight\"> -->\r\n                  <td>");
#nullable restore
#line 47 "D:\Code\C#\Greenair\Presentation\Pages\Admin\Flight.cshtml"
                 Write(item.FlightId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  <td>");
#nullable restore
#line 48 "D:\Code\C#\Greenair\Presentation\Pages\Admin\Flight.cshtml"
                 Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  <td>");
#nullable restore
#line 49 "D:\Code\C#\Greenair\Presentation\Pages\Admin\Flight.cshtml"
                 Write(item.PlaneId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  <td> \r\n                    <button");
            BeginWriteAttribute("id", "  id=\"", 1975, "\"", 1995, 1);
#nullable restore
#line 51 "D:\Code\C#\Greenair\Presentation\Pages\Admin\Flight.cshtml"
WriteAttributeValue("", 1981, item.FlightId, 1981, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#EditFlightForm\"  type=\"button\" class=\"btn btn-dark btn-sm  btn-rounded EditFlight\"><i class=\"fa fa-cog\"></i></button>\r\n                    <button");
            BeginWriteAttribute("id", "  id=\"", 2177, "\"", 2197, 1);
#nullable restore
#line 52 "D:\Code\C#\Greenair\Presentation\Pages\Admin\Flight.cshtml"
WriteAttributeValue("", 2183, item.FlightId, 2183, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-danger btn-sm  btn-rounded DeleteFlight\"><i class=\"fa fa-times\" ></i></button>\r\n                  </td>\r\n                </tr>\r\n");
#nullable restore
#line 55 "D:\Code\C#\Greenair\Presentation\Pages\Admin\Flight.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("              </tbody>\r\n            </table>\r\n            \r\n            \r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <!-- end table Flight  -->\r\n\r\n  </div> \r\n  <!-- end content_warper -->\r\n</div>\r\n<!-- end main body -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Presentation.Pages.Admin.FlightModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Presentation.Pages.Admin.FlightModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Presentation.Pages.Admin.FlightModel>)PageContext?.ViewData;
        public Presentation.Pages.Admin.FlightModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
