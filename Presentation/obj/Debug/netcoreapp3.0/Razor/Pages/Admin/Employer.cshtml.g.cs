#pragma checksum "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Employer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c2ccfea3c388cd6d0fa972118684a1be4b00b00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Presentation.Pages.Admin.Pages_Admin_Employer), @"mvc.1.0.razor-page", @"/Pages/Admin/Employer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c2ccfea3c388cd6d0fa972118684a1be4b00b00", @"/Pages/Admin/Employer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d76d778d4c858045a827ae28cbb9bc28e1d5c23", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Employer : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Employer.cshtml"
  
  Layout = "_LayoutAdmin";
	ViewData["Title"] = "Admin Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""main-panel"">
  <div class=""content-wrapper"">
     <!-- row search -->
    <div class=""row"">
    </div>
    <!-- row button insert -->
    <div class=""row"">
      <div class=""col-lg-12 stretch-card"">
        <a href=""#CreateEmployerForm"" data-toggle=""modal"" id=""btCreateEmployer"" type=""button"" class=""btn  btn-primary btn-lg btn-inverse-*"">
          <i class=""mdi mdi-upload""></i>Create Employer
        </a>
      </div>
    </div>
    <!-- row table -->
    <div class=""row"">
    <div class=""col-lg-12 stretch-card"">
      <div class=""card"">
        <div class=""card-body"">
          <h3 align=""center"">List of Employers </h3>
          <table class=""table table-bordered table-striped table-hover"">
           <thead>
            <tr>
              <th>ID</th>
              <th>First name</th>
              <th>Last name</th>
              <th>Job</th>
              <th>Salary</th>
              <th>Status</th>
              <th></th>
            </tr>
           </thead>
 ");
            WriteLiteral("          <tbody>\r\n             <!-- change to code later -->\r\n");
#nullable restore
#line 40 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Employer.cshtml"
              foreach (var item in Model.ListEmployers){

#line default
#line hidden
#nullable disable
            WriteLiteral("              <tr>\r\n                <td>");
#nullable restore
#line 42 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Employer.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 43 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Employer.cshtml"
               Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 44 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Employer.cshtml"
               Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 45 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Employer.cshtml"
               Write(item.Job);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 46 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Employer.cshtml"
               Write(item.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><label class=\"badge badge-warning\">item.Status</label></td>\r\n                <td> \r\n                  <button");
            BeginWriteAttribute("id", "  id=\"", 1612, "\"", 1626, 1);
#nullable restore
#line 49 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Employer.cshtml"
WriteAttributeValue("", 1618, item.Id, 1618, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#EditEmployerForm\"  type=\"button\" class=\"btn btn-dark btn-sm  btn-rounded EditEmployer\"><i class=\"fa fa-cog\"></i></button>\r\n                  <button");
            BeginWriteAttribute("id", "  id=\"", 1810, "\"", 1824, 1);
#nullable restore
#line 50 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Employer.cshtml"
WriteAttributeValue("", 1816, item.Id, 1816, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-danger btn-sm  btn-rounded DeleteEmployer\"><i class=\"fa fa-times\" ></i></button>\r\n                </td>\r\n              </tr>\r\n");
#nullable restore
#line 53 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Employer.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
          </table>
        </div>
      </div>
    </div>
    </div>
  </div> 
  <!-- end content_warper -->
</div>
<!-- end main body -->

<!--formcreate  -->
<div class=""modal fade"" id=""CreateEmployerForm"" role=""dialog"">
    <div class=""modal-dialog modal-dialog-centered modal-lg"">
        <div class=""modal-content"" >
            <div class=""modal-header"" style="" background-color:aliceblue;"">
                <h4 class=""modal-title"" style=""margin: 10px 0 10px 510px; color:#000; font-weight: bold;font-size:34"">New Employee</h4>
            </div>
		    <div class=""model-body"" style=""margin: 15px"">
				  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c2ccfea3c388cd6d0fa972118684a1be4b00b008959", async() => {
                WriteLiteral(@"
            <div class=""row"">
              <div class=""col-6"">
                <p style=""font-weight:600"" class=""card-description""> Personal info </p>
              </div>
              <div class=""col-6"">
                <p style=""font-weight:600"" class=""card-description"">Personal account </p>
              </div>
            </div>
            <div class=""row"">
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">First Name</label>
                  <div class=""col-sm-9"">
                    <input type=""text"" class=""form-control"" required/>
                  </div>
                </div>
              </div>
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Username</label>
                  <div class=""col-sm-9"">
                    <input type=""text"" class=""form-control"" required/>
                  </div>
");
                WriteLiteral(@"                </div>
              </div>
            </div>
            <div class=""row"">
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Last Name</label>
                  <div class=""col-sm-9"">
                    <input type=""text"" class=""form-control"" required/>
                  </div>
                </div>
              </div>
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Password</label>
                  <div class=""col-sm-9"">
                    <input type=""password"" class=""form-control"" required/>
                  </div>
                </div>
              </div>
            </div>
            <div class=""row"">
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Date of Birth</label>
                 ");
                WriteLiteral(@" <div class=""col-sm-9"">
                    <input type=""date"" class=""form-control"" placeholder=""dd/mm/yyyy"" />
                  </div>
                </div>
              </div>
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Enter Password</label>
                  <div class=""col-sm-9"">
                    <input type=""password"" class=""form-control"" required/>
                  </div>
                </div>
              </div>   
            </div>
            <div class=""row"">
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Phone</label>
                  <div class=""col-sm-9"">
                    <input type=""tel"" class=""form-control"" pattern=""0[0-9]{9,10}"" />
                  </div>
                </div>
              </div>
              <div class=""col-md-6"">
                <div class=""form-gr");
                WriteLiteral("oup row\">\r\n                  <label class=\"col-sm-3 col-form-label\">Status</label>\r\n                  <div class=\"col-sm-9\">\r\n                    <select class=\"form-control\">\r\n                      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c2ccfea3c388cd6d0fa972118684a1be4b00b0012720", async() => {
                    WriteLiteral("Active");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c2ccfea3c388cd6d0fa972118684a1be4b00b0013757", async() => {
                    WriteLiteral("Disable");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                  </div>
                </div>
              </div>
            </div>
            <div class=""row"">
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Address</label>
                  <div class=""col-sm-9"">
                    <input type=""text"" class=""form-control"" />
                  </div>
                </div>
              </div>
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Job</label>
                  <div class=""col-sm-9"">
                    <select class=""form-control"">
");
#nullable restore
#line 171 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Employer.cshtml"
                       foreach (var item in Model.ListJobs){

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c2ccfea3c388cd6d0fa972118684a1be4b00b0015819", async() => {
#nullable restore
#line 172 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Employer.cshtml"
                           Write(item.JobId);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" - \r\n                          ");
#nullable restore
#line 173 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Employer.cshtml"
                     Write(item.JobName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 174 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Employer.cshtml"
                      }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                  </div>
                </div>
              </div>            
            </div>
            <div class=""row"">
              <div class=""col-md-6"">
              </div>                 
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Salary</label>
                  <div class=""col-sm-9"">
                    <input type=""text"" class=""form-control"" />
                  </div>
                </div>
              </div>  
            </div>
            <div class=""row"" style="" display: flex; justify-content: flex-end;"">
              <button type=""submit"" class=""btn btn-success mr-2""><b>Create</b></button>
              <button class=""btn btn-light"" data-dismiss=""modal""><b>Cancel</b></button>
            </div>
          ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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

<!-- edit form -->
<div class=""modal fade"" id=""EditEmployerForm"" role=""dialog"">
    <div class=""modal-dialog modal-dialog-centered modal-lg"">
        <div class=""modal-content"" >
            <div class=""modal-header"" style="" background-color:aliceblue;"">
                <h4 class=""modal-title"" style=""margin: 10px 0 10px 510px; color:#000; font-weight: bold;font-size:34"">New Employee</h4>
            </div>
		    <div class=""model-body"" style=""margin: 15px"">
				  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c2ccfea3c388cd6d0fa972118684a1be4b00b0020115", async() => {
                WriteLiteral(@"
            <div class=""row"">
              <div class=""col-6"">
                <p style=""font-weight:600"" class=""card-description""> Personal info </p>
              </div>
              <div class=""col-6"">
                <p style=""font-weight:600"" class=""card-description"">Personal account </p>
              </div>
            </div>
            <div class=""row"">
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">First Name</label>
                  <div class=""col-sm-9"">
                    <input type=""text"" class=""form-control"" required/>
                  </div>
                </div>
              </div>
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Username</label>
                  <div class=""col-sm-9"">
                    <input type=""text"" class=""form-control"" required/>
                  </div>
");
                WriteLiteral(@"                </div>
              </div>
            </div>
            <div class=""row"">
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Last Name</label>
                  <div class=""col-sm-9"">
                    <input type=""text"" class=""form-control"" required/>
                  </div>
                </div>
              </div>
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Password</label>
                  <div class=""col-sm-9"">
                    <input type=""password"" class=""form-control"" required/>
                  </div>
                </div>
              </div>
            </div>
            <div class=""row"">
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Date of Birth</label>
                 ");
                WriteLiteral(@" <div class=""col-sm-9"">
                    <input type=""date"" class=""form-control"" placeholder=""dd/mm/yyyy"" />
                  </div>
                </div>
              </div>
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Enter Password</label>
                  <div class=""col-sm-9"">
                    <input type=""password"" class=""form-control"" required/>
                  </div>
                </div>
              </div>   
            </div>
            <div class=""row"">
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Phone</label>
                  <div class=""col-sm-9"">
                    <input type=""tel"" class=""form-control"" pattern=""0[0-9]{9,10}"" />
                  </div>
                </div>
              </div>
              <div class=""col-md-6"">
                <div class=""form-gr");
                WriteLiteral("oup row\">\r\n                  <label class=\"col-sm-3 col-form-label\">Status</label>\r\n                  <div class=\"col-sm-9\">\r\n                    <select class=\"form-control\">\r\n                      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c2ccfea3c388cd6d0fa972118684a1be4b00b0023877", async() => {
                    WriteLiteral("Active");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c2ccfea3c388cd6d0fa972118684a1be4b00b0024914", async() => {
                    WriteLiteral("Disable");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                  </div>
                </div>
              </div>
            </div>
            <div class=""row"">
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Address</label>
                  <div class=""col-sm-9"">
                    <input type=""text"" class=""form-control"" />
                  </div>
                </div>
              </div>
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Job</label>
                  <div class=""col-sm-9"">
                    <select class=""form-control"">
");
#nullable restore
#line 308 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Employer.cshtml"
                       foreach (var item in Model.ListJobs){

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c2ccfea3c388cd6d0fa972118684a1be4b00b0026976", async() => {
#nullable restore
#line 309 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Employer.cshtml"
                           Write(item.JobId);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" - \r\n                          ");
#nullable restore
#line 310 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Employer.cshtml"
                     Write(item.JobName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 311 "C:\Users\Administrator\Desktop\Greenair-1\presentation\Pages\Admin\Employer.cshtml"
                      }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                  </div>
                </div>
              </div>            
            </div>
            <div class=""row"">
              <div class=""col-md-6"">
              </div>                 
              <div class=""col-md-6"">
                <div class=""form-group row"">
                  <label class=""col-sm-3 col-form-label"">Salary</label>
                  <div class=""col-sm-9"">
                    <input type=""text"" class=""form-control"" />
                  </div>
                </div>
              </div>  
            </div>
            <div class=""row"" style="" display: flex; justify-content: flex-end;"">
              <button type=""submit"" class=""btn btn-success mr-2""><b>Update</b></button>
              <button class=""btn btn-light"" data-dismiss=""modal""><b>Cancel</b></button>
            </div>
          ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t    </div>\r\n      </div>    \r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Presentation.Pages.Admin.EmployerModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Presentation.Pages.Admin.EmployerModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Presentation.Pages.Admin.EmployerModel>)PageContext?.ViewData;
        public Presentation.Pages.Admin.EmployerModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
