#pragma checksum "D:\Code\C#\Greenair\Presentation\Pages\Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e787c446fa57b62615020d353f3ba4adf69a214"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Presentation.Pages.Pages_Account), @"mvc.1.0.razor-page", @"/Pages/Account.cshtml")]
namespace Presentation.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e787c446fa57b62615020d353f3ba4adf69a214", @"/Pages/Account.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d76d778d4c858045a827ae28cbb9bc28e1d5c23", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Account : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <div class=""hero-wrap js-fullheight"" style=""background-image: url('images/bg_1.jpg');"">
		<div class=""overlay""></div>
		<div class=""container"">
			<div class=""row no-gutters slider-text js-fullheight align-items-center justify-content-start"" data-scrollax-parent=""true"">
                <div class=""col-md-9 ftco-animate mb-5 pb-5 text-center text-md-left"" data-scrollax="" properties: { translateY: '70%' }"">
					<h1 class=""mb-4"" data-scrollax=""properties: { translateY: '30%', opacity: 1.6 }"">Discover <br>A new Place</h1>
					<p data-scrollax=""properties: { translateY: '30%', opacity: 1.6 }"">Find great places to stay, eat, shop, or visit from local experts</p>
				</div>
			</div>
		</div>
	</div>
	<section class=""ftco-section"">
		<div class=""container"">
			<div class=""row"">
				<div class=""col-md-3"" style=""border-right:1px solid #0f0f0f3b"">
					<div class=""nav nav-pills flex-column justify-content-center text-center"" id=""myTab"" role=""tablist"" aria-orientation=""vertical"">
						<a class=""");
            WriteLiteral(@"nav-link active"" id=""Account-tab"" data-toggle=""pill"" href=""#account-tab"" role=""tab"" aria-controls=""account"" aria-selected=""true"">Your account</a>
						<a class=""nav-link"" id=""Identify-tab"" data-toggle=""pill"" href=""#profile-tab"" role=""tab"" aria-controls=""profile"" aria-selected=""false"">Your profile</a>
						<a class=""nav-link"" id=""Ticket-tab"" data-toggle=""pill"" href=""#ticket-tab"" role=""tab"" aria-controls=""ticket"" aria-selected=""false"">Your tickets</a>
					</div>
				</div>
				<div class=""col-md-9"">
					<div class=""tab-content"" id=""myTabContent"">
						<div class=""tab-pane fade show active"" id=""account-tab""  role=""tabpanel"" aria-labelledby=""account"">
							<div style=""  border-bottom: 1px solid #0f0f0f3b;"" class=""row"">
								<div class=""account-title col-md-8"">
									<h2>Account Settings</h2>
								</div>
							</div>
							<div style=""margin-top: 30px"" class=""row"">
								<div class=""heading  col-md-8"">
									<h3>Username</h3>
								</div>
								<div class=""col-md-4"">
		");
            WriteLiteral(@"							<button class=""btn btn-primary save-user hidden"">Save Changes</button>
									<button class=""btn close-user hidden"">Cancel</button>
									<button class=""btn open-user"">Edit</button>
								</div>
							</div>
							<div class=""row user-show "">
								<div class=""col-md-6"">
									<div class=""form-group"" style=""padding-left:15px"">
										<label style=""font-weight:600"">Username:</label>
										<div>abc</div>
									</div>	
								</div>		
							</div>
							<div class=""row user-field hidden"">
								<div class=""col-md-4"">
									<div class=""form-group"" style=""padding-left:15px"">
										<label style=""font-weight:600"">Username:</label>
										<input type=""text"" class=""form-control"" value=""abc"" id=""username"">
									</div>
								</div>		
							</div>
							<div class=""row"">
								<div class=""heading col-md-8"" >
									<h3>Password</h3>
								</div>
								<div class=""col-md-4"">
									<button class=""btn btn-primary save-pass hidden"">Sav");
            WriteLiteral(@"e Changes</button>
									<button class=""btn close-pass hidden"">Cancel</button>
									<button class=""btn open-pass"">Edit</button>
								</div>
							</div>
							<div class=""row"" id=""pass-show"">
								<div class=""col-md-6"">
									<div class=""form-group"" style=""padding-left:15px"">
										<label style=""font-weight:600"">Password:</label>
										<div>*******</div>
									</div>
								</div>
							</div>
							<div class=""row hidden"" id=""pass-field"">
								<div class=""col-md-5"" style=""padding-left:15px"">
									<div class=""form-group"" >
										<label style=""font-weight:600"">Current password</label>
										<input type=""password"" class=""form-control"" id=""old-pass"">
									</div>
								</div>
								<div class=""col-md-5"">
									<div class=""form-group"">
										<label style=""font-weight:600"">Enter a new password</label>
										<input type=""password"" class=""form-control"" id=""new-pass"">
									</div>
								</div>
								<div class=""col-md-5""");
            WriteLiteral(@" style=""padding-top: 15px"">
									<div class=""form-group"">
										<label style=""font-weight:600"">Repeat new password</label>
										<input type=""password"" class=""form-control""   id=""re-pass"">
									</div>
										
								</div>
							</div>
						</div>
						<div class=""tab-pane fade"" id=""profile-tab""  role=""tabpanel"" aria-labelledby=""profile"">
							<div style=""  border-bottom: 1px solid #0f0f0f3b;"" class=""row"">
								<div class=""account-title col-md-8"">
									<h2>Profile Settings</h2>
								</div>
							</div>
							<div style=""margin-top: 30px"" class=""row"">
								<div class=""heading  col-md-8"">
									<h3>About you</h3>
								</div>
								<div class=""col-md-4"">
									<button id=""profile_s"" class=""btn btn-primary save-user hidden"">Save Changes</button>
									<button id=""profile_cl"" class=""btn cancel hidden"">Cancel</button>
									<button id=""profile_op""class=""btn open"">Edit</button>
								</div>
							</div>
							<div class=""row pro-sh");
            WriteLiteral(@"ow "">
								<div class=""col-md-6"">
									<div class=""form-group"" style=""padding-left:15px"">
										<label style=""font-weight:600"">Name:</label>
										<div class=""name""></div>
									</div>
								</div>
								<div class=""col-md-6"">
									<div class=""form-group"" style=""padding-left:15px"">
										<label style=""font-weight:600"">Date of birth</label>
										<div class=""birth_day""></div>
									</div>
								</div>
							</div>
							<div class=""row pro-field hidden"">
								<div class=""col-md-4"" style=""padding-left:15px"">
									<div class=""form-group"" >
										<label style=""font-weight:600"">Last name</label>
										<input id=""lastName"" type=""text"" class=""form-control"" value=""An"">
									</div>
								</div>
								<div class=""col-md-4"">
									<div class=""form-group"">
										<label style=""font-weight:600"">First name</label>
										<input id=""firstName"" type=""text"" class=""form-control"" value=""Do"" >
									</div>
								</div>
						");
            WriteLiteral(@"		<div class=""col-md-4"">
									<div class=""form-group"">
										<label style=""font-weight:600"">Date of birth</label>
										<input type=""text"" class=""form-control birth_date"" value=""26/07/1999"">
									</div>
								</div>
							</div>
							<div class=""row"">
								<div class=""heading col-md-8"" >
									<h3>Address</h3>
								</div>
								<div class=""col-md-4"">
									<button id=""add_s"" class=""btn btn-primary save hidden"">Save Changes</button>
									<button id=""add_cl"" class=""btn cancel hidden"">Cancel</button>
									<button id=""add_op"" class=""btn open"">Edit</button>
								</div>
							</div>
							<div class=""row"" id=""address-show"">
								<div class=""col-md-4"">
									<div class=""form-group"" style=""padding-left:15px"">
										<label style=""font-weight:600"">Num</label>
										<div>123</div>
									</div>
								</div>
								<div class=""col-md-4"">
									<div class=""form-group"" style=""padding-left:15px"">
										<label style=""font-weig");
            WriteLiteral(@"ht:600"">Street</label>
										<div>abc</div>
									</div>
								</div>
								<div class=""col-md-4"">
									<div class=""form-group"" style=""padding-left:15px"">
										<label style=""font-weight:600"">District</label>
										<div>asb</div>
									</div>
								</div>
								<div class=""col-md-4"">
									<div class=""form-group"" style=""padding-left:15px"">
										<label style=""font-weight:600"">City</label>
										<div>1abc</div>
									</div>
								</div>
								<div class=""col-md-4"">
									<div class=""form-group"" style=""padding-left:15px"">
										<label style=""font-weight:600"">State</label>
										<div>abc</div>
									</div>
								</div>
								<div class=""col-md-4"">
									<div class=""form-group"" style=""padding-left:15px"">
										<label style=""font-weight:600"">Country</label>
										<div>asb</div>
									</div>
								</div>
							</div>
							<div class=""row hidden"" id=""address-field"">
								<div class=""col-md-4"" style=""");
            WriteLiteral(@"padding-left:15px"">
									<div class=""form-group"" >
										<label style=""font-weight:600"">Num</label>
										<input type=""text"" class=""form-control"" >
									</div>
								</div>
								<div class=""col-md-4"">
									<div class=""form-group"">
										<label style=""font-weight:600"">Street</label>
										<input type=""text"" class=""form-control"" >
									</div>
								</div>
								<div class=""col-md-4"" >
									<div class=""form-group"">
										<label style=""font-weight:600"">District</label>
										<input type=""text"" class=""form-control""   >
									</div>			
								</div>
								<div class=""col-md-4"" style=""padding-left:15px"">
									<div class=""form-group"" >
										<label style=""font-weight:600"">City</label>
										<input type=""text"" class=""form-control"" >
									</div>
								</div>
								<div class=""col-md-4"">
									<div class=""form-group"">
										<label style=""font-weight:600"">State</label>
										<input type=""text"" class=""form-");
            WriteLiteral(@"control"" >
									</div>
								</div>
								<div class=""col-md-4"" >
									<div class=""form-group"">
										<label style=""font-weight:600"">Country</label>
										<select id=""items"" name=""items"" type=""text"" class=""form-control country"" ></select>
									</div>			
								</div>
							</div>
							<div class=""row"">
								<div class=""heading col-md-8"" >
									<h3>Phone</h3>
								</div>
								<div class=""col-md-4"">
									<button id=""phone_s"" class=""btn btn-primary save hidden"">Save Changes</button>
									<button id=""phone_cl"" class=""btn cancel hidden"">Cancel</button>
									<button id=""phone_op"" class=""btn open"">Edit</button>
								</div>
							</div>
							<div class=""row phone-show "">
								<div class=""col-md-6"">
									<div class=""form-group"" style=""padding-left:15px"">
										<label style=""font-weight:600"">Phone</label>
										<div class=""phone""></div>
									</div>
								</div>
							</div>
							<div class=""row phone-field hid");
            WriteLiteral(@"den"">
								<div class=""col-md-4"" style=""padding-left:15px"">
									<div class=""form-group"" >
										<label style=""font-weight:600"">Phone</label>
										<input id=""phone"" type=""text"" class=""form-control"">
									</div>
								</div>
							</div>
						</div>
						<div class=""tab-pane fade"" id=""ticket-tab""  role=""tabpanel"" aria-labelledby=""ticket"">
							<div style=""border-bottom: 1px solid #0f0f0f3b;"" class=""row"">
								<div class=""account-title col-md-8"">
									<h2>Your tickets</h2>
								</div>
							</div>
							<div class=""row"">
								<div style=""margin-top:30px"" class=""ticket_detail col-md-4"">
									<div class=""form-group"">
										<label>Enter your ticket id here:</label>
										<input class=""form-control"" type=""text"" id=""ticket_id""/>
									</div>
								</div>
								<div class=""col-md-4"">
									<button style=""margin-top: 70px"" class=""btn btn-primary"" id=""submit_ticket_id"">Check</button>
								</div>
							</div>
						</div>
				");
            WriteLiteral("\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccountModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccountModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccountModel>)PageContext?.ViewData;
        public AccountModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
