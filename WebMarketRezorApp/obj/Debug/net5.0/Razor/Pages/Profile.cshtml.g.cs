#pragma checksum "C:\Users\Khatibian\source\repos\WebMarketRezorApp\WebMarketRezorApp\Pages\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fd713ceae5935026690138dafd6bd4ab57ba61e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebMarketRezorApp.Pages.Pages_Profile), @"mvc.1.0.razor-page", @"/Pages/Profile.cshtml")]
namespace WebMarketRezorApp.Pages
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
#line 1 "C:\Users\Khatibian\source\repos\WebMarketRezorApp\WebMarketRezorApp\Pages\_ViewImports.cshtml"
using WebMarketRezorApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fd713ceae5935026690138dafd6bd4ab57ba61e", @"/Pages/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e39fe3595e14c42137f764e7d987bc3488940f5c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Profile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminTheme/assets/img/profile-img.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Khatibian\source\repos\WebMarketRezorApp\WebMarketRezorApp\Pages\Profile.cshtml"
  
    var Element = Model.Elements.ToList();
    foreach (var item in Element)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 class=\"text-bg-danger\"> ");
#nullable restore
#line 7 "C:\Users\Khatibian\source\repos\WebMarketRezorApp\WebMarketRezorApp\Pages\Profile.cshtml"
                           Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 8 "C:\Users\Khatibian\source\repos\WebMarketRezorApp\WebMarketRezorApp\Pages\Profile.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""pagetitle"">
        <h1>Profile</h1>
        <nav>
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                <li class=""breadcrumb-item"">Users</li>
                <li class=""breadcrumb-item active"">Profile</li>
            </ol>
        </nav>
    </div>
    <!-- End Page Title -->
");
            WriteLiteral(@"    <section class=""section profile"">
        <div class=""row"">
            <!--Show card-->
            <div class=""col-xl-4"">
                <div class=""card"">
                    <div class=""card-body profile-card pt-4 d-flex flex-column align-items-center"">

                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0fd713ceae5935026690138dafd6bd4ab57ba61e5787", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <h2>Kevin Anderson</h2>
                        <h3>Web Designer</h3>
                        <div class=""social-links mt-2"">
                            <a href=""#"" class=""twitter""><i class=""bi bi-twitter""></i></a>
                            <a href=""#"" class=""facebook""><i class=""bi bi-facebook""></i></a>
                            <a href=""#"" class=""instagram""><i class=""bi bi-instagram""></i></a>
                            <a href=""#"" class=""linkedin""><i class=""bi bi-linkedin""></i></a>
                        </div>
                    </div>
                </div>
            </div>
            <!--Profile Setings-->
            <div class=""col-xl-8"">

                <div class=""card"">
                    <div class=""card-body pt-3"">
                        <!-- Bordered Tabs -->
                        <ul class=""nav nav-tabs nav-tabs-bordered"">

                            <li class=""nav-item"">
                                <button class=""nav-link active""");
            WriteLiteral(@" data-bs-toggle=""tab"" data-bs-target=""#profile-overview"">Overview</button>
                            </li>

                            <li class=""nav-item"">
                                <button class=""nav-link"" data-bs-toggle=""tab"" data-bs-target=""#profile-edit"">Edit Profile</button>
                            </li>

                            <li class=""nav-item"">
                                <button class=""nav-link"" data-bs-toggle=""tab"" data-bs-target=""#profile-settings"">Settings</button>
                            </li>

                            <li class=""nav-item"">
                                <button class=""nav-link"" data-bs-toggle=""tab"" data-bs-target=""#profile-change-password"">Change Password</button>
                            </li>

                        </ul>
                        <div class=""tab-content pt-2"">

                            <div class=""tab-pane fade show active profile-overview"" id=""profile-overview"">
                                <h5 clas");
            WriteLiteral("s=\"card-title\">About</h5>\r\n                                <p class=\"small fst-italic\">");
#nullable restore
#line 69 "C:\Users\Khatibian\source\repos\WebMarketRezorApp\WebMarketRezorApp\Pages\Profile.cshtml"
                                                             foreach (var element in Model.Elements)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\Khatibian\source\repos\WebMarketRezorApp\WebMarketRezorApp\Pages\Profile.cshtml"
                               Write(element.BodyText);

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\Khatibian\source\repos\WebMarketRezorApp\WebMarketRezorApp\Pages\Profile.cshtml"
                                                     ;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

                                <h5 class=""card-title"">Profile Details</h5>

                                <div class=""row"">
                                    <div class=""col-lg-3 col-md-4 label "">Full Name</div>
                                    <div class=""col-lg-9 col-md-8"">Kevin Anderson</div>
                                </div>

                                <div class=""row"">
                                    <div class=""col-lg-3 col-md-4 label"">Company</div>
                                    <div class=""col-lg-9 col-md-8"">Lueilwitz, Wisoky and Leuschke</div>
                                </div>

                                <div class=""row"">
                                    <div class=""col-lg-3 col-md-4 label"">Job</div>
                                    <div class=""col-lg-9 col-md-8"">Web Designer</div>
                                </div>

                                <div class=""row"">
                                    <div class=""col-lg-3 col-md");
            WriteLiteral(@"-4 label"">Country</div>
                                    <div class=""col-lg-9 col-md-8"">USA</div>
                                </div>

                                <div class=""row"">
                                    <div class=""col-lg-3 col-md-4 label"">Address</div>
                                    <div class=""col-lg-9 col-md-8"">A108 Adam Street, New York, NY 535022</div>
                                </div>

                                <div class=""row"">
                                    <div class=""col-lg-3 col-md-4 label"">Phone</div>
                                    <div class=""col-lg-9 col-md-8"">(436) 486-3538 x29071</div>
                                </div>

                                <div class=""row"">
                                    <div class=""col-lg-3 col-md-4 label"">Email</div>
                                    <div class=""col-lg-9 col-md-8"">k.anderson@example.com</div>
                                </div>

                            </div>");
            WriteLiteral("\n\r\n                            <div class=\"tab-pane fade profile-edit pt-3\" id=\"profile-edit\">\r\n\r\n                                <!-- Profile Edit Form -->\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fd713ceae5935026690138dafd6bd4ab57ba61e12480", async() => {
                WriteLiteral(@"
                                    <div class=""row mb-3"">
                                        <label for=""profileImage"" class=""col-md-4 col-lg-3 col-form-label"">Profile Image</label>
                                        <div class=""col-md-8 col-lg-9"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0fd713ceae5935026690138dafd6bd4ab57ba61e13053", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
                                            <div class=""pt-2"">
                                                <a href=""#"" class=""btn btn-primary btn-sm"" title=""Upload new profile image""><i class=""bi bi-upload""></i></a>
                                                <a href=""#"" class=""btn btn-danger btn-sm"" title=""Remove my profile image""><i class=""bi bi-trash""></i></a>
                                            </div>
                                        </div>
                                    </div>

                                    <div class=""row mb-3"">
                                        <label for=""fullName"" class=""col-md-4 col-lg-3 col-form-label"">Full Name</label>
                                        <div class=""col-md-8 col-lg-9"">
                                            <input name=""fullName"" type=""text"" class=""form-control"" id=""fullName"" value=""Kevin Anderson"">
                                        </div>
                                    </div>

           ");
                WriteLiteral(@"                         <div class=""row mb-3"">
                                        <label for=""about"" class=""col-md-4 col-lg-3 col-form-label"">About</label>
                                        <div class=""col-md-8 col-lg-9"">
                                            <textarea name=""about"" class=""form-control"" id=""about"" style=""height: 100px"">Sunt est soluta temporibus accusantium neque nam maiores cumque temporibus. Tempora libero non est unde veniam est qui dolor. Ut sunt iure rerum quae quisquam autem eveniet perspiciatis odit. Fuga sequi sed ea saepe at unde.</textarea>
                                        </div>
                                    </div>

                                    <div class=""row mb-3"">
                                        <label for=""company"" class=""col-md-4 col-lg-3 col-form-label"">Company</label>
                                        <div class=""col-md-8 col-lg-9"">
                                            <input name=""company"" type=""text"" class");
                WriteLiteral(@"=""form-control"" id=""company"" value=""Lueilwitz, Wisoky and Leuschke"">
                                        </div>
                                    </div>

                                    <div class=""row mb-3"">
                                        <label for=""Job"" class=""col-md-4 col-lg-3 col-form-label"">Job</label>
                                        <div class=""col-md-8 col-lg-9"">
                                            <input name=""job"" type=""text"" class=""form-control"" id=""Job"" value=""Web Designer"">
                                        </div>
                                    </div>

                                    <div class=""row mb-3"">
                                        <label for=""Country"" class=""col-md-4 col-lg-3 col-form-label"">Country</label>
                                        <div class=""col-md-8 col-lg-9"">
                                            <input name=""country"" type=""text"" class=""form-control"" id=""Country"" value=""USA"">
                 ");
                WriteLiteral(@"                       </div>
                                    </div>

                                    <div class=""row mb-3"">
                                        <label for=""Address"" class=""col-md-4 col-lg-3 col-form-label"">Address</label>
                                        <div class=""col-md-8 col-lg-9"">
                                            <input name=""address"" type=""text"" class=""form-control"" id=""Address"" value=""A108 Adam Street, New York, NY 535022"">
                                        </div>
                                    </div>

                                    <div class=""row mb-3"">
                                        <label for=""Phone"" class=""col-md-4 col-lg-3 col-form-label"">Phone</label>
                                        <div class=""col-md-8 col-lg-9"">
                                            <input name=""phone"" type=""text"" class=""form-control"" id=""Phone"" value=""(436) 486-3538 x29071"">
                                        </div>
     ");
                WriteLiteral(@"                               </div>

                                    <div class=""row mb-3"">
                                        <label for=""Email"" class=""col-md-4 col-lg-3 col-form-label"">Email</label>
                                        <div class=""col-md-8 col-lg-9"">
                                            <input name=""email"" type=""email"" class=""form-control"" id=""Email"" value=""k.anderson@example.com"">
                                        </div>
                                    </div>

                                    <div class=""row mb-3"">
                                        <label for=""Twitter"" class=""col-md-4 col-lg-3 col-form-label"">Twitter Profile</label>
                                        <div class=""col-md-8 col-lg-9"">
                                            <input name=""twitter"" type=""text"" class=""form-control"" id=""Twitter"" value=""https://twitter.com/#"">
                                        </div>
                                    </div>

 ");
                WriteLiteral(@"                                   <div class=""row mb-3"">
                                        <label for=""Facebook"" class=""col-md-4 col-lg-3 col-form-label"">Facebook Profile</label>
                                        <div class=""col-md-8 col-lg-9"">
                                            <input name=""facebook"" type=""text"" class=""form-control"" id=""Facebook"" value=""https://facebook.com/#"">
                                        </div>
                                    </div>

                                    <div class=""row mb-3"">
                                        <label for=""Instagram"" class=""col-md-4 col-lg-3 col-form-label"">Instagram Profile</label>
                                        <div class=""col-md-8 col-lg-9"">
                                            <input name=""instagram"" type=""text"" class=""form-control"" id=""Instagram"" value=""https://instagram.com/#"">
                                        </div>
                                    </div>

              ");
                WriteLiteral(@"                      <div class=""row mb-3"">
                                        <label for=""Linkedin"" class=""col-md-4 col-lg-3 col-form-label"">Linkedin Profile</label>
                                        <div class=""col-md-8 col-lg-9"">
                                            <input name=""linkedin"" type=""text"" class=""form-control"" id=""Linkedin"" value=""https://linkedin.com/#"">
                                        </div>
                                    </div>

                                    <div class=""text-center"">
                                        <button type=""submit"" class=""btn btn-primary"">Save Changes</button>
                                    </div>
                                ");
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
            WriteLiteral("<!-- End Profile Edit Form -->\r\n\r\n                            </div>\r\n\r\n                            <div class=\"tab-pane fade pt-3\" id=\"profile-settings\">\r\n\r\n                                <!-- Settings Form -->\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fd713ceae5935026690138dafd6bd4ab57ba61e22793", async() => {
                WriteLiteral(@"

                                    <div class=""row mb-3"">
                                        <label for=""fullName"" class=""col-md-4 col-lg-3 col-form-label"">Email Notifications</label>
                                        <div class=""col-md-8 col-lg-9"">
                                            <div class=""form-check"">
                                                <input class=""form-check-input"" type=""checkbox"" id=""changesMade"" checked>
                                                <label class=""form-check-label"" for=""changesMade"">
                                                    Changes made to your account
                                                </label>
                                            </div>
                                            <div class=""form-check"">
                                                <input class=""form-check-input"" type=""checkbox"" id=""newProducts"" checked>
                                                <label class=""form-check-labe");
                WriteLiteral(@"l"" for=""newProducts"">
                                                    Information on new products and services
                                                </label>
                                            </div>
                                            <div class=""form-check"">
                                                <input class=""form-check-input"" type=""checkbox"" id=""proOffers"">
                                                <label class=""form-check-label"" for=""proOffers"">
                                                    Marketing and promo offers
                                                </label>
                                            </div>
                                            <div class=""form-check"">
                                                <input class=""form-check-input"" type=""checkbox"" id=""securityNotify"" checked disabled>
                                                <label class=""form-check-label"" for=""securityNotify"">
                  ");
                WriteLiteral(@"                                  Security alerts
                                                </label>
                                            </div>
                                        </div>
                                    </div>

                                    <div class=""text-center"">
                                        <button type=""submit"" class=""btn btn-primary"">Save Changes</button>
                                    </div>
                                ");
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
            WriteLiteral("<!-- End settings Form -->\r\n\r\n                            </div>\r\n\r\n                            <div class=\"tab-pane fade pt-3\" id=\"profile-change-password\">\r\n                                <!-- Change Password Form -->\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fd713ceae5935026690138dafd6bd4ab57ba61e26973", async() => {
                WriteLiteral(@"

                                    <div class=""row mb-3"">
                                        <label for=""currentPassword"" class=""col-md-4 col-lg-3 col-form-label"">Current Password</label>
                                        <div class=""col-md-8 col-lg-9"">
                                            <input name=""password"" type=""password"" class=""form-control"" id=""currentPassword"">
                                        </div>
                                    </div>

                                    <div class=""row mb-3"">
                                        <label for=""newPassword"" class=""col-md-4 col-lg-3 col-form-label"">New Password</label>
                                        <div class=""col-md-8 col-lg-9"">
                                            <input name=""newpassword"" type=""password"" class=""form-control"" id=""newPassword"">
                                        </div>
                                    </div>

                                    <div class=""r");
                WriteLiteral(@"ow mb-3"">
                                        <label for=""renewPassword"" class=""col-md-4 col-lg-3 col-form-label"">Re-enter New Password</label>
                                        <div class=""col-md-8 col-lg-9"">
                                            <input name=""renewpassword"" type=""password"" class=""form-control"" id=""renewPassword"">
                                        </div>
                                    </div>

                                    <div class=""text-center"">
                                        <button type=""submit"" class=""btn btn-primary"">Change Password</button>
                                    </div>
                                ");
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
            WriteLiteral("<!-- End Change Password Form -->\r\n\r\n                            </div>\r\n\r\n                        </div><!-- End Bordered Tabs -->\r\n\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebMarketRezorApp.Pages.ProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebMarketRezorApp.Pages.ProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebMarketRezorApp.Pages.ProfileModel>)PageContext?.ViewData;
        public WebMarketRezorApp.Pages.ProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
