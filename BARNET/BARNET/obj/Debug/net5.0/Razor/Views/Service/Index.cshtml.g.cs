#pragma checksum "C:\Users\TUF DASH\Desktop\New folder\BARNET\BARNET\Views\Service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85df2b1938f6ebcc2c4d69e2487960011414d55b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
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
#line 1 "C:\Users\TUF DASH\Desktop\New folder\BARNET\BARNET\Views\_ViewImports.cshtml"
using BARNET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TUF DASH\Desktop\New folder\BARNET\BARNET\Views\_ViewImports.cshtml"
using BARNET.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\TUF DASH\Desktop\New folder\BARNET\BARNET\Views\_ViewImports.cshtml"
using BARNET.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85df2b1938f6ebcc2c4d69e2487960011414d55b", @"/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6abfb30f3e69cadf4e3c56c8f7e0826818071f7d", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmService>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\TUF DASH\Desktop\New folder\BARNET\BARNET\Views\Service\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Page title -->
<section class=""page-title"" style=""background-image:url(images/background/3.jpg)"">
    <div class=""container"">
        <div class=""outer-box"">
            <h1>Service One</h1>
            <ul class=""bread-crumb clearfix"">
                <li><a href=""index.html"">Home</a></li>
                <li class=""active"">Service One</li>
            </ul>
        </div>
    </div>
</section>


<!-- Services section three -->
<section class=""services-section-one sp-two"">
    <div class=""container"">
        <div class=""sec-title centered"">
            <h1>");
#nullable restore
#line 24 "C:\Users\TUF DASH\Desktop\New folder\BARNET\BARNET\Views\Service\Index.cshtml"
           Write(Model.Page.ServiceHead);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 27 "C:\Users\TUF DASH\Desktop\New folder\BARNET\BARNET\Views\Service\Index.cshtml"
             foreach (var item in Model.Services)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"services-block-three col-lg-4\">\r\n                    <div class=\"inner-box hvr-float-shadow\">\r\n                        <div class=\"image\"><img");
            BeginWriteAttribute("src", " src=\"", 1002, "\"", 1035, 2);
            WriteAttributeValue("", 1008, "images/resource/", 1008, 16, true);
#nullable restore
#line 31 "C:\Users\TUF DASH\Desktop\New folder\BARNET\BARNET\Views\Service\Index.cshtml"
WriteAttributeValue("", 1024, item.Image, 1024, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1036, "\"", 1042, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        <div class=\"lower-content\">\r\n                            <div class=\"icon\"><span class=\"icon-light-bulb\"></span></div>\r\n                            <h4>");
#nullable restore
#line 34 "C:\Users\TUF DASH\Desktop\New folder\BARNET\BARNET\Views\Service\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <div class=\"text\">");
#nullable restore
#line 35 "C:\Users\TUF DASH\Desktop\New folder\BARNET\BARNET\Views\Service\Index.cshtml"
                                         Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div class=\"read-more-btn\"><a href=\"#\" class=\"theme-btn\">Read More <span class=\"icon-right-arrow2\"></span></a></div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 40 "C:\Users\TUF DASH\Desktop\New folder\BARNET\BARNET\Views\Service\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>

<!--Project Section-->
<section class=""project-section sp-four grey-bg"">

    <!--Porfolio Tabs-->
    <div class=""project-tab"">
        <div class=""container"">
            <!--Top content-->
            <div class=""top-content"">
                <div class=""row m-0 justify-content-md-between align-items-center"">
                    <div class=""sec-title"">
                        <h1>");
#nullable restore
#line 55 "C:\Users\TUF DASH\Desktop\New folder\BARNET\BARNET\Views\Service\Index.cshtml"
                       Write(Model.Page.WorkHead);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                    </div>
                    <div class=""tab-btns-box"">
                        <!--Tabs Header-->
                        <div class=""tabs-header"">
                            <ul class=""product-tab-btns clearfix"">
                                <li class=""p-tab-btn active-btn"" data-tab=""#p-tab-1"">All</li>
                                <li class=""p-tab-btn"" data-tab=""#p-tab-2"">Design</li>
                                <li class=""p-tab-btn"" data-tab=""#p-tab-3"">Graphic</li>
                                <li class=""p-tab-btn"" data-tab=""#p-tab-4"">Photography</li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!--Tabs Content-->
        <div class=""p-tabs-content"">
            <!--Portfolio Tab / Active Tab-->
            <div class=""p-tab active-tab"" id=""p-tab-1"">
                <div class=""project-carousel owl-theme owl-carousel"">

");
#nullable restore
#line 78 "C:\Users\TUF DASH\Desktop\New folder\BARNET\BARNET\Views\Service\Index.cshtml"
                     foreach (var item in Model.Works)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"gallery-block\">\r\n                            <div class=\"inner-box\">\r\n                                <figure class=\"image-box\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 3307, "\"", 3331, 2);
            WriteAttributeValue("", 3313, "images/", 3313, 7, true);
#nullable restore
#line 83 "C:\Users\TUF DASH\Desktop\New folder\BARNET\BARNET\Views\Service\Index.cshtml"
WriteAttributeValue("", 3320, item.Image, 3320, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3332, "\"", 3338, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <!--Overlay Box-->
                                    <div class=""overlay-box"">
                                        <div class=""overlay-inner"">
                                            <div class=""content"">
                                                <div class=""content-text"">
                                                    <div class=""category"">");
#nullable restore
#line 89 "C:\Users\TUF DASH\Desktop\New folder\BARNET\BARNET\Views\Service\Index.cshtml"
                                                                     Write(item.SupTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                    <h3><a href=\"projects-detail.html\">");
#nullable restore
#line 90 "C:\Users\TUF DASH\Desktop\New folder\BARNET\BARNET\Views\Service\Index.cshtml"
                                                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                                    <div class=\"text\">");
#nullable restore
#line 91 "C:\Users\TUF DASH\Desktop\New folder\BARNET\BARNET\Views\Service\Index.cshtml"
                                                                 Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                                    <div class=""link-btn""><a href=""#"" class=""theme-btn btn-style-two small-btn"">Read More</a></div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </figure>
                            </div>
                        </div>
");
#nullable restore
#line 100 "C:\Users\TUF DASH\Desktop\New folder\BARNET\BARNET\Views\Service\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <!--Portfolio Tab-->\r\n            <div class=\"p-tab\" id=\"p-tab-2\">\r\n                <div class=\"project-carousel owl-theme owl-carousel\">\r\n\r\n");
#nullable restore
#line 109 "C:\Users\TUF DASH\Desktop\New folder\BARNET\BARNET\Views\Service\Index.cshtml"
                     foreach (var item in Model.Works)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"gallery-block\">\r\n                            <div class=\"inner-box\">\r\n                                <figure class=\"image-box\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 4935, "\"", 4959, 2);
            WriteAttributeValue("", 4941, "images/", 4941, 7, true);
#nullable restore
#line 114 "C:\Users\TUF DASH\Desktop\New folder\BARNET\BARNET\Views\Service\Index.cshtml"
WriteAttributeValue("", 4948, item.Image, 4948, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4960, "\"", 4966, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <!--Overlay Box-->
                                    <div class=""overlay-box"">
                                        <div class=""overlay-inner"">
                                            <div class=""content"">
                                                <div class=""content-text"">
                                                    <div class=""category"">");
#nullable restore
#line 120 "C:\Users\TUF DASH\Desktop\New folder\BARNET\BARNET\Views\Service\Index.cshtml"
                                                                     Write(item.SupTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                    <h3><a href=\"projects-detail.html\">");
#nullable restore
#line 121 "C:\Users\TUF DASH\Desktop\New folder\BARNET\BARNET\Views\Service\Index.cshtml"
                                                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                                    <div class=\"text\">");
#nullable restore
#line 122 "C:\Users\TUF DASH\Desktop\New folder\BARNET\BARNET\Views\Service\Index.cshtml"
                                                                 Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                                    <div class=""link-btn""><a href=""#"" class=""theme-btn btn-style-two small-btn"">Read More</a></div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </figure>
                            </div>
                        </div>
");
#nullable restore
#line 131 "C:\Users\TUF DASH\Desktop\New folder\BARNET\BARNET\Views\Service\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>

        </div>

    </div>

</section>
<!--End Project Section-->
<!-- Testimonial Section -->
<section class=""testimonial-section-two sp-one"">
    <div class=""container"">

        <div class=""row"">
            <div class=""col-lg-8"">
                <div class=""content-wrapper wow fadeInUp"" data-wow-duration=""1.2s"">
                    <div class=""sec-title"">
                        <h1>What Our Clients <br>Are Saying</h1>
                    </div>
                    <ul class=""bxslider "">
                        <li>
                            <div class=""testimonial-block-two"">
                                <div class=""inner-box"">
                                    <div class=""quote""><img src=""images/icons/quote-icon.png""");
            BeginWriteAttribute("alt", " alt=\"", 6882, "\"", 6888, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                    <div class=""text"">Lorem ipsum dolor sit amet consectetur adipisicing elit eiusm tempor idunt ut labore dolore magna aliqua.enim ad ven.quis nostrud exercitation ullamc o laboris.aliquip ex ea commodo consequat duis aute irure dolor in reprehen derit in voluptate aute cillum dolore eu fugiat</div>
                                    <h4>Birte Janssen</h4>
                                </div>
                            </div>
                        </li>
                        <li>
                            <div class=""testimonial-block-two"">
                                <div class=""inner-box"">
                                    <div class=""quote""><img src=""images/icons/quote-icon.png""");
            BeginWriteAttribute("alt", " alt=\"", 7645, "\"", 7651, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                    <div class=""text"">Lorem ipsum dolor sit amet consectetur adipisicing elit eiusm tempor idunt ut labore dolore magna aliqua.enim ad ven.quis nostrud exercitation ullamc o laboris.aliquip ex ea commodo consequat duis aute irure dolor in reprehen derit in voluptate aute cillum dolore eu fugiat</div>
                                    <h4>Mark William</h4>
                                </div>
                            </div>
                        </li>
                        <li>
                            <div class=""testimonial-block-two"">
                                <div class=""inner-box"">
                                    <div class=""quote""><img src=""images/icons/quote-icon.png""");
            BeginWriteAttribute("alt", " alt=\"", 8407, "\"", 8413, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                    <div class=""text"">Lorem ipsum dolor sit amet consectetur adipisicing elit eiusm tempor idunt ut labore dolore magna aliqua.enim ad ven.quis nostrud exercitation ullamc o laboris.aliquip ex ea commodo consequat duis aute irure dolor in reprehen derit in voluptate aute cillum dolore eu fugiat</div>
                                    <h4>John Smith</h4>
                                </div>
                            </div>
                        </li>
                    </ul>
                    <div class=""slider-pager slide-nav"">
                        <ul class=""nav-link list-inline"">
                            <li id=""slider-prev""></li>
                            <li id=""slider-next""></li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""slider-pager"">
                    <ul class=""list-inline thumb-box"">
                     ");
            WriteLiteral("   <li>\r\n                            <a class=\"active\" data-slide-index=\"0\" href=\"#\"><img src=\"images/resource/team-4.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 9560, "\"", 9566, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                        </li>\r\n                        <li>\r\n                            <a data-slide-index=\"1\" href=\"#\"><img src=\"images/resource/team-5.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 9733, "\"", 9739, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                        </li>\r\n                        <li>\r\n                            <a data-slide-index=\"2\" href=\"#\"><img src=\"images/resource/team-6.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 9906, "\"", 9912, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmService> Html { get; private set; }
    }
}
#pragma warning restore 1591
