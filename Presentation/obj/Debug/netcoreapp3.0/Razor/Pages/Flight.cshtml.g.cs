#pragma checksum "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Flight.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a76e607831ae86c7f2de294eb5427ecf3a321d7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Presentation.Pages.Pages_Flight), @"mvc.1.0.razor-page", @"/Pages/Flight.cshtml")]
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
#line 1 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\_ViewImports.cshtml"
using Presentation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a76e607831ae86c7f2de294eb5427ecf3a321d7a", @"/Pages/Flight.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d76d778d4c858045a827ae28cbb9bc28e1d5c23", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Flight : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-weight:600"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\Greenair\Presentation\Pages\Flight.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div style=""background-image: -webkit-linear-gradient(315deg,#f58300 0,#f59300 50%,#f6a100 50%,#f58300 100%);
    background-image: linear-gradient(135deg,#f58300 0,#f59300 50%,#f6a100 50%,#f58300 100%); width:100%;height:450px"">
	<div class=""overlay""></div>
	<div class=""container"">
		<div class=""row no-gutters slider-text js-fullheight align-items-center "" data-scrollax-parent=""true"">
			<div style=""width:100%;padding-left: 250px"">
				<h1 class=""mb-5"">Flight start here</h1>		
            </div>
		</div>
	</div>
</div>
<section class=""ftco-section bg-light"">
	<div class=""container"">
		<div class=""row"">
			<div class=""col-sm-12"" style=""text-align:center;padding-left: .9375rem;padding-right: .9375rem;"">
				<h2 style=""font-weight:600"">Hanoi to Ho Chi Minh city</h2>
				");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a76e607831ae86c7f2de294eb5427ecf3a321d7a4528", async() => {
                WriteLiteral("\r\n\t\t\t\t\tChange flight search\r\n\t\t\t\t\t<span class=\"ion-ios-color-wand\"></span>\r\n\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t<div");
            BeginWriteAttribute("class", " class=\"", 1044, "\"", 1052, 0);
            EndWriteAttribute();
            WriteLiteral(@">
					<div class=""section-heading"">
						<h3 class=""section-heading__title"" style=""font-weight:600"">
							Flight go
						</h3>
						<span class=""section-heading__icon ion-ios-plane""></span>
						<div class=""section-heading__content"">
							<span class=""section-heading__route"">
								Ha Noi to Ho Chi Minh city
							</span>
							<span class=""section-heading__content-connector"">
								-
							</span>
							<span class=""section-heading__date"">
								Thursday,5 December,2019
							</span>
						</div>
					</div>
				</div>
			</div>
		</div>
		<div class=""row"">
			<div class=""col-sm-3"">
				<label for=""day-go"">Check in</label>
				<input type=""text"" data-date-format=""DD-dd/mm/yyyy"" id=""check-in"">
			</div>
		</div>
		<div class=""row"" style=""margin-top: 20px"">
			<div class=""col-sm-12"">
				<div class=""flight-card-wrapper"">
					<div class=""flight-card"">
						<div class=""flight-card-itinerary"">
							<div class=""itinerary-info"">
								<div class=""itinerary-");
            WriteLiteral(@"info__time"">
									5:30
								</div>
								<div class=""itinerary-info__airport""> 
										SGN-đi
								</div>
							</div>
							<div class=""itinerary-info__icons"">
								<span></span>
							</div>
							<div class=""itinerary-info"">
								<div class=""itinerary-info__time "">
									7:40
								</div>
								<div class=""itinerary-info__airport"">
									Han -đến
								</div>
							</div>
						</div>
						<div class=""flight-card-details-price"">
							<div class=""flight-card-details"">
								<div style=""float:left;"">
									<span class=""flight-card-details__duration "">Blasdasdasdasasdsad</span>
									<div class=""flight-card-details__more"">
										<span class=""info-show"" >
											Chi tiết
										</span>
										<span class=""info-hide"">
											Ẩn
										</span>
									</div>
								</div>
								
								<div class=""price-select"" style=""float:right"">
									<div class=""price-select__price  text-right"">
										<div cla");
            WriteLiteral(@"ss=""starter-price-wrapper"">
											<div class=""pricepoint-wrapper pricepoint-wrapper--orange"">
												<div class=""pricepoint"">
													<span class=""pricepoint__middle"">
														890,000
														<span class=""pricepoint__decimal""></span>
													</span>
													<span class=""pricepoint__symbol"">
														đ
													</span>
												</div>
											</div>
										</div>
									</div>
									<div class=""price-select__button"">
										<div class=""button-toggle js-button-toggle"">
											<span>
												Chọn
											</span>
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
					<div class="" qa-flight-card-details"">
						<div class=""fare__details fare__details--leg-0 "">
							<span class=""carrier""></span>
							<div class=""flight-info"">
								<div class=""flight-info__row  flight-info__flightNubmer"">
									<div class=""flight-info__row__label medium-3""> 
										Chuyến bay 1:
");
            WriteLiteral(@"									</div>
									<div class=""medium-9"">
										<p></p>
									</div>
								</div>
								<div class=""flight-info__row"">
									<div class=""flight-info__row__label medium-3""> 
										Khởi hành:
									</div>
									<div class=""medium-9"">
										<p></p>
									</div>
								</div>
								<div class=""flight-info__row"">
									<div class=""flight-info__row__label medium-3""> 
										Đến:
									</div>
									<div class=""medium-9"">
										<p></p>
									</div>
								</div>
								<div class=""flight-info__row"">
									<div class=""flight-info__row__label medium-3""> 
									</div>
									<div class=""flight-info__more medium-9"">
										<div class=""flight-info__more__item"">
											Thời gian:
											<p>2hrs 10mins</p>
										</div>
										<div class=""flight-info__more__item"">
											Máy bay:
											<p>2hrs 10mins</p>
										</div>
										<div class=""flight-info__more__item"">
											Hãng khai thác:
	");
            WriteLiteral(@"										<p>2hrs 10mins</p>
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
</section>

<script>
	$(document).ready(function()
	{ 
		$(""#check-in"").datepicker({
			'todayHighlight': 'true',
			'startDate' : '0d',
	  		'autoclose': true
		});
	});
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Presentation.Pages.FlightModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Presentation.Pages.FlightModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Presentation.Pages.FlightModel>)PageContext?.ViewData;
        public Presentation.Pages.FlightModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
