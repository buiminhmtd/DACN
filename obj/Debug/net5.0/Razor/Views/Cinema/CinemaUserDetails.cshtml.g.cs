#pragma checksum "C:\Users\Admin\Source\Repos\Movie_Ticket_Reservation\MovieTickets\Views\Cinema\CinemaUserDetails.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c669f15ee1701f104711cb28f1085ac557fe54593b7841b7508707a8369db430"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cinema_CinemaUserDetails), @"mvc.1.0.view", @"/Views/Cinema/CinemaUserDetails.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Admin\Source\Repos\Movie_Ticket_Reservation\MovieTickets\Views\_ViewImports.cshtml"
using MovieTickets.ViewModels

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Admin\Source\Repos\Movie_Ticket_Reservation\MovieTickets\Views\_ViewImports.cshtml"
using MovieTickets

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\Admin\Source\Repos\Movie_Ticket_Reservation\MovieTickets\Views\_ViewImports.cshtml"
using MovieTickets.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c669f15ee1701f104711cb28f1085ac557fe54593b7841b7508707a8369db430", @"/Views/Cinema/CinemaUserDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"dde3fba61d98bc34bd2c3adcadd9a0209609bdd96cfed7d93b0e2472b8a3c777", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cinema_CinemaUserDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieCinemaViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Admin\Source\Repos\Movie_Ticket_Reservation\MovieTickets\Views\Cinema\CinemaUserDetails.cshtml"
  
    Layout="_UserLayout";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"<div class=""hero hero3"">
	<div class=""container"">
		<div class=""row"">
			<div class=""col-md-12"">
				<!-- <h1> movie listing - list</h1>
				<ul class=""breadcumb"">
					<li class=""active""><a href=""#"">Home</a></li>
					<li> <span class=""ion-ios-arrow-right""></span> movie listing</li>
				</ul> -->
			</div>
		</div>
	</div>
</div>
<!-- celebrity single section-->

<div class=""page-single movie-single cebleb-single"">
	<div class=""container"">
		<div class=""row ipad-width"">
			<div class=""col-md-4 col-sm-12 col-xs-12"">
				<div class=""mv-ceb"">
					
");
#nullable restore
#line 27 "C:\Users\Admin\Source\Repos\Movie_Ticket_Reservation\MovieTickets\Views\Cinema\CinemaUserDetails.cshtml"
       if(Model.Cinema.Image!=null){
							var base64=	Convert.ToBase64String(@Model.Cinema.Image);
               string imgsrc= string.Format("data:images/*;base64,{0}", base64);

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 833, "\"", 846, 1);
            WriteAttributeValue("", 839, 
#nullable restore
#line 30 "C:\Users\Admin\Source\Repos\Movie_Ticket_Reservation\MovieTickets\Views\Cinema\CinemaUserDetails.cshtml"
                imgsrc

#line default
#line hidden
#nullable disable
            , 839, 7, false);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 847, "\"", 853, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:350px; height:500px; object-fit:cover\">\r\n");
#nullable restore
#line 31 "C:\Users\Admin\Source\Repos\Movie_Ticket_Reservation\MovieTickets\Views\Cinema\CinemaUserDetails.cshtml"
					}

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-md-8 col-sm-12 col-xs-12\">\r\n\t\t\t\t<div class=\"movie-single-ct\">\r\n\t\t\t\t\t<h1 class=\"bd-hd\">");
            Write(
#nullable restore
#line 36 "C:\Users\Admin\Source\Repos\Movie_Ticket_Reservation\MovieTickets\Views\Cinema\CinemaUserDetails.cshtml"
                        Model.Cinema.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h1>\r\n\t\t\t\t\t<p class=\"ceb-single\" >");
            Write(
#nullable restore
#line 37 "C:\Users\Admin\Source\Repos\Movie_Ticket_Reservation\MovieTickets\Views\Cinema\CinemaUserDetails.cshtml"
                             Model.Cinema.Description

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@" </p>
					<div class=""social-link cebsingle-socail"" hidden>
						<br />
						<br />
					</div>
					<div class=""movie-tabs"">
						<div class=""tabs"">
							<div class=""tabs"">
							<ul class=""tab-links tabs-mv"">
								<li class=""active""><a href=""#overviewceb"">Overview</a></li>
								                      
							</ul>
						    <div class=""tab-content"">
						        <div id=""overviewceb"" class=""tab active"">
						            <div class=""row"">
						            	<div class=""col-md-8 col-sm-12 col-xs-12"">
						            	
						            	
											<!-- movie cast -->
											<div class=""mvcast-item"">	
");
#nullable restore
#line 57 "C:\Users\Admin\Source\Repos\Movie_Ticket_Reservation\MovieTickets\Views\Cinema\CinemaUserDetails.cshtml"
             foreach(var item in Model.Movies){
												

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"cast-it\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"cast-left cebleb-film\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n");
#nullable restore
#line 62 "C:\Users\Admin\Source\Repos\Movie_Ticket_Reservation\MovieTickets\Views\Cinema\CinemaUserDetails.cshtml"
                if(item.Movie.Image!=null) {
																var base64=	Convert.ToBase64String(@item.Movie.Image);
                                              string  imgsrc= string.Format("data:images/*;base64,{0}", base64);

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 2186, "\"", 2199, 1);
            WriteAttributeValue("", 2192, 
#nullable restore
#line 65 "C:\Users\Admin\Source\Repos\Movie_Ticket_Reservation\MovieTickets\Views\Cinema\CinemaUserDetails.cshtml"
                         imgsrc

#line default
#line hidden
#nullable disable
            , 2192, 7, false);
            EndWriteAttribute();
            WriteLiteral("  style=\"width:120px; height:90px; object-fit:cover\">\r\n");
#nullable restore
#line 66 "C:\Users\Admin\Source\Repos\Movie_Ticket_Reservation\MovieTickets\Views\Cinema\CinemaUserDetails.cshtml"
															}

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c669f15ee1701f104711cb28f1085ac557fe54593b7841b7508707a8369db4309398", async() => {
                Write(
#nullable restore
#line 68 "C:\Users\Admin\Source\Repos\Movie_Ticket_Reservation\MovieTickets\Views\Cinema\CinemaUserDetails.cshtml"
                                                                                             item.Movie.Name

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 68 "C:\Users\Admin\Source\Repos\Movie_Ticket_Reservation\MovieTickets\Views\Cinema\CinemaUserDetails.cshtml"
                                                                             item.Movie.Id

#line default
#line hidden
#nullable disable
            );
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
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 75 "C:\Users\Admin\Source\Repos\Movie_Ticket_Reservation\MovieTickets\Views\Cinema\CinemaUserDetails.cshtml"
												}

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t            \t</div>\r\n\t\t\t\t\t\t            \r\n\t\t\t\t\t\t            </div>\r\n\r\n\t\t\t\t\t\t    </div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\t</div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieCinemaViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
