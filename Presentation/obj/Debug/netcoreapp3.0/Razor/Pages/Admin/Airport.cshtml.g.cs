#pragma checksum "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Airport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1346ed166d581a998a49b5c2ffb54abaf1f2d227"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Presentation.Pages.Admin.Pages_Admin_Airport), @"mvc.1.0.razor-page", @"/Pages/Admin/Airport.cshtml")]
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
#line 1 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\_ViewImports.cshtml"
using Presentation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1346ed166d581a998a49b5c2ffb54abaf1f2d227", @"/Pages/Admin/Airport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d76d778d4c858045a827ae28cbb9bc28e1d5c23", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Airport : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Airport.cshtml"
  
  Layout = "_LayoutAdmin";
	ViewData["Title"] = "Admin Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""main-panel"">
  <!-- Airport content-wrapper -->
  <div class=""content-wrapper"">
     <!-- row button create -->
    <div class=""row"">
      <div class=""col-lg-12 stretch-card"">
        <a href=""#CreateAirportForm"" data-toggle=""modal"" id=""btCreateAirport"" type=""button"" class=""btn  btn-primary btn-lg btn-inverse-*"">
          <i class=""mdi mdi-upload""></i>Create Airport
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
                <div class=""input-group"">
                  <input type=""search"" class=""form-control"" placeholder=""Search Here"">
                  <button type=""button"" class=""btn btn-icons btn-rounded btn-outline-primary""><i class=""fa fa-search""></i></button>
                </div> 
              </div> 
   ");
            WriteLiteral(@"         </div>
            <h3 align=""center"">List of Airports </h3>
            <table class=""table table-bordered table-striped table-hover"" id=""TableAirport"">
            <thead>
              <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Address</th>
                <th></th>
              </tr>
            </thead>
            <tbody> 
");
#nullable restore
#line 43 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Airport.cshtml"
               foreach (var item in Model.ListAirports){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                <!-- <tr id=\"");
#nullable restore
#line 45 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Airport.cshtml"
                        Write(item.AirportId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"list-Airport\"> -->\r\n                  <td>");
#nullable restore
#line 46 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Airport.cshtml"
                 Write(item.AirportId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  <td>");
#nullable restore
#line 47 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Airport.cshtml"
                 Write(item.AirportName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  <td>");
#nullable restore
#line 48 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Airport.cshtml"
                 Write(item.Address.toString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  <td> \r\n                    <button");
            BeginWriteAttribute("id", "  id=\"", 1889, "\"", 1910, 1);
#nullable restore
#line 50 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Airport.cshtml"
WriteAttributeValue("", 1895, item.AirportId, 1895, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#EditAirportForm\"  type=\"button\" class=\"btn btn-dark btn-sm  btn-rounded EditAirport\"><i class=\"fa fa-cog\"></i></button>\r\n                    <button");
            BeginWriteAttribute("id", "  id=\"", 2094, "\"", 2115, 1);
#nullable restore
#line 51 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Airport.cshtml"
WriteAttributeValue("", 2100, item.AirportId, 2100, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-danger btn-sm  btn-rounded DeleteAirport\"><i class=\"fa fa-times\" ></i></button>\r\n                  </td>\r\n                </tr>\r\n");
#nullable restore
#line 54 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Airport.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"              </tbody>
            </table>
          </div>
        </div>
      </div>
    </div>
    <!-- end table Airport  -->

  </div> 
  <!-- end content_warper -->

 
</div>
<!-- end main body -->

<!--create Airport form  -->
<div class=""modal fade"" id=""CreateAirportForm"" role=""dialog"">
  <div class=""modal-dialog modal-dialog-centered modal-sm"">
    <div class=""modal-content"" >
      <div class=""modal-header"" style=""text-align:center !important; background-color:aliceblue;"">
        <h4 class=""modal-title"" style="" color:#000; font-weight: bold;font-size:34"">Create Airport</h4>
      </div>
		  <div class=""model-body"" style=""margin: 15px"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1346ed166d581a998a49b5c2ffb54abaf1f2d2278614", async() => {
                WriteLiteral(@"
          <div class=""form-group row"">
            <label class=""col-sm-3 col-form-label"">ID</label>
            <div class=""col-sm-9"">
              <input id=""CreateAirport-id"" type=""text"" class=""form-control""  placeholder=""Enter ID"">
            </div>
            <span style=""color: red bold"" class=""z-mak-id""></span>
          </div>
          <div class=""form-group row"">
            <label class=""col-sm-3 col-form-label"">Name</label>
            <div class=""col-sm-9"">
              <input id=""CreateAirport-name"" type=""text"" class=""form-control""  placeholder=""Enter name"">
            </div>
            <span style=""color: red bold"" class=""z-mak-name""></span>
          </div>
          <div class=""form-group row"">
            <label class=""col-sm-3 col-form-label"">Address</label>
            <div class=""col-sm-9"">
              <input id=""CreateAirport-address"" type=""text"" class=""form-control"" placeholder=""Enter address"">
            </div>
            <span style=""color: red bold"" cla");
                WriteLiteral("ss=\"z-mak-address\"></span>\r\n          </div>\r\n          <button  id=\"btsubmitCreateAirport\" class=\"btn btn-success mr-2\"><b>Create</b></button>\r\n          <button class=\"btn btn-light\" data-dismiss=\"modal\"><b>Cancel</b></button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
  </div>
</div>

 <!-- edit Airport form -->
<div class=""modal fade"" id=""EditAirportForm"" role=""dialog"">
  <div class=""modal-dialog modal-dialog-centered modal-sm"">
    <div class=""modal-content"" >
      <div class=""modal-header"" style=""text-align:center !important; background-color:aliceblue;"">
        <h4 class=""modal-title"" style="" color:#000; font-weight: bold;font-size:34"">Edit Airport</h4>
      </div>
      <div class=""model-body"" style=""margin: 15px"" id=""bodyEditAirport"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1346ed166d581a998a49b5c2ffb54abaf1f2d22711844", async() => {
                WriteLiteral(@"
          <div class=""form-group row"">
            <label class=""col-sm-3 col-form-label"">ID</label>
            <div class=""col-sm-9"">
              <input id=""EditAirport-id"" type=""text"" class=""form-control""  placeholder=""Enter ID"" disabled>
            </div>
            <span style=""color: red bold"" class=""z-mak-id""></span>
          </div>
          <div class=""form-group row"">
            <label class=""col-sm-3 col-form-label"">Name</label>
            <div class=""col-sm-9"">
              <input id=""EditAirport-name"" type=""text"" class=""form-control""  placeholder=""Enter name"">
            </div>
            <span style=""color: red bold"" class=""z-mak-name""></span>
          </div>
          <div class=""form-group row"">
            <label class=""col-sm-3 col-form-label"">Address</label>
            <div class=""col-sm-9"">
              <input id=""EditAirport-address"" type=""text"" class=""form-control"" placeholder=""Enter address"">
            </div>
            <span style=""color: red bold"" ");
                WriteLiteral("class=\"z-mak-address\"></span>\r\n          </div>\r\n          <button  id=\"btsubmitEditAirport\" class=\"btn btn-success mr-2\"><b>Update</b></button>\r\n          <button class=\"btn btn-light\" data-dismiss=\"modal\"><b>Cancel</b></button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n      </div>\r\n    </div>    \r\n  </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Presentation.Pages.Admin.AirportModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Presentation.Pages.Admin.AirportModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Presentation.Pages.Admin.AirportModel>)PageContext?.ViewData;
        public Presentation.Pages.Admin.AirportModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591